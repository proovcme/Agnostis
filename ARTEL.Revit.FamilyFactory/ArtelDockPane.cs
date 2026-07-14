using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;
using Microsoft.Win32;
using WpfTextBox = System.Windows.Controls.TextBox;

namespace ARTEL.Revit.FamilyFactory;

internal static class ArtelPaneIds
{
    internal static readonly DockablePaneId Main = new(new Guid("B97D620B-6A3C-44CD-87E2-0AD2B8F1E791"));
}

internal sealed class ArtelDockPane : UserControl, IDockablePaneProvider
{
    private readonly ArtelExternalEventBridge _revit = new();
    private readonly TextBlock _runtime = new();
    private readonly TextBlock _modeTitle = new();
    private readonly TextBlock _modeHelp = new();
    private readonly Border _wizardCard = Card();
    private readonly StackPanel _wizardContent = new();
    private readonly TextBlock _wizardStepLabel = new();
    private readonly Button _wizardBack = SecondaryButton("Назад");
    private readonly Button _wizardNext = PrimaryButton("Далее");
    private readonly WpfTextBox _sourceDescription = Input(true, 110);
    private readonly WpfTextBox _sourceUrl = Input(false, 40);
    private readonly TextBlock _sourceFileStatus = Muted("Перетащите файл сюда или выберите его на диске");
    private readonly WpfTextBox _clarifications = Input(true, 90);
    private readonly CheckBox _confirm = new() { Content = "Я проверил точный план и подтверждаю изменение активного документа Revit", Margin = new Thickness(0, 10, 0, 4) };
    private readonly Border _chatCard = Card();
    private readonly WpfTextBox _question = Input(true, 92);
    private readonly FlowDocumentScrollViewer _answer = new() { VerticalScrollBarVisibility = ScrollBarVisibility.Auto, MaxHeight = 520 };
    private readonly Button _ask = PrimaryButton("Спросить АРТЕЛЬ");
    private readonly Button _execute = PrimaryButton("Выполнить подтверждённый план");
    private readonly CheckBox _safety = new() { Content = "Предохранитель действий Revit", IsChecked = true, FontWeight = FontWeights.SemiBold };
    private readonly TextBlock _safetyStatus = Muted("");
    private readonly WpfTextBox _exportPackageName = Input(false, 40);
    private readonly CheckBox _exportQuantities = new() { Content = "Категории, количества, площади, объёмы и длины", IsChecked = true };
    private readonly CheckBox _exportSelection = new() { Content = "Выбранные элементы и их параметры", IsChecked = true, Margin = new Thickness(0, 6, 0, 0) };
    private readonly List<Button> _modeButtons = new();
    private string _mode = "chat";
    private int _wizardStep = 1;
    private byte[]? _sourceBytes;
    private string _sourceName = "";
    private string _generatorSpec = "";
    private string _generatorPlan = "";
    private string _generatorHash = "";
    private string _generatorResult = "";
    private string _pendingExport = "";
    private string _pendingPlan = "";
    private string _pendingHash = "";
    private string _pendingAnswer = "";

    internal ArtelDockPane()
    {
        _safety.IsChecked = LoadSafetySetting();
        _safety.Checked += (_, _) => { SaveSafetySetting(true); RefreshSafetyStatus(); };
        _safety.Unchecked += (_, _) => { SaveSafetySetting(false); RefreshSafetyStatus(); };
        Background = Brush("#F4F3EF");
        var root = new StackPanel { Margin = new Thickness(18) };
        root.Children.Add(new TextBlock { Text = "АРТЕЛЬ", FontSize = 22, FontWeight = FontWeights.SemiBold, Foreground = Brush("#176C52") });
        root.Children.Add(Muted("Генератор семейств · BIM-чат · экспорт данных", new Thickness(0, 2, 0, 16)));

        var statusCard = Card();
        _runtime.Text = "Проверяю backend, Ollama и ЛЕС…";
        _runtime.TextWrapping = TextWrapping.Wrap;
        statusCard.Child = _runtime;
        root.Children.Add(statusCard);

        var modes = new WrapPanel { Margin = new Thickness(0, 0, 0, 14) };
        modes.Children.Add(ModeButton("Генератор", "generator"));
        modes.Children.Add(ModeButton("BIM-чат", "chat"));
        modes.Children.Add(ModeButton("Экспорт в ЛЕС", "export"));
        root.Children.Add(modes);

        _modeTitle.FontSize = 18;
        _modeTitle.FontWeight = FontWeights.SemiBold;
        _modeTitle.Foreground = Brush("#24332D");
        root.Children.Add(_modeTitle);
        _modeHelp.Margin = new Thickness(0, 4, 0, 12);
        _modeHelp.TextWrapping = TextWrapping.Wrap;
        _modeHelp.Foreground = Brush("#6A6D67");
        root.Children.Add(_modeHelp);

        var wizard = new StackPanel();
        _wizardStepLabel.FontWeight = FontWeights.SemiBold;
        _wizardStepLabel.Foreground = Brush("#176C52");
        wizard.Children.Add(_wizardStepLabel);
        wizard.Children.Add(_wizardContent);
        var wizardButtons = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 12, 0, 0) };
        _wizardBack.Margin = new Thickness(0, 0, 8, 0);
        _wizardBack.Click += (_, _) => { _wizardStep = Math.Max(1, _wizardStep - 1); RenderWizard(); };
        _wizardNext.Click += async (_, _) => await AdvanceWizardAsync();
        wizardButtons.Children.Add(_wizardBack);
        wizardButtons.Children.Add(_wizardNext);
        wizard.Children.Add(wizardButtons);
        _wizardCard.Child = wizard;
        root.Children.Add(_wizardCard);

        _ask.Margin = new Thickness(0, 10, 0, 10);
        _ask.Click += async (_, _) => await AskAsync();
        _execute.Visibility = Visibility.Collapsed;
        _execute.Margin = new Thickness(0, 0, 0, 10);
        _execute.Click += async (_, _) => await ExecutePendingAsync();
        root.Children.Add(_chatCard);

        Content = new ScrollViewer { Content = root, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
        SelectMode("chat");
        Loaded += async (_, _) => await RefreshRuntimeAsync();
    }

    public void SetupDockablePane(DockablePaneProviderData data)
    {
        data.FrameworkElement = this;
        data.InitialState = new DockablePaneState { DockPosition = DockPosition.Right };
    }

    private Button ModeButton(string text, string mode)
    {
        var button = SecondaryButton(text);
        button.Tag = mode;
        button.Margin = new Thickness(0, 0, 7, 7);
        button.Click += (_, _) => SelectMode(mode);
        _modeButtons.Add(button);
        return button;
    }

    private void SelectMode(string mode)
    {
        _mode = mode;
        _wizardCard.Visibility = mode == "generator" ? Visibility.Visible : Visibility.Collapsed;
        _chatCard.Visibility = mode == "generator" ? Visibility.Collapsed : Visibility.Visible;
        _execute.Visibility = Visibility.Collapsed;
        DetachConfirm();
        _confirm.IsChecked = false;
        _pendingExport = "";
        _pendingPlan = _pendingHash = _pendingAnswer = "";
        foreach (var button in _modeButtons)
        {
            var selected = string.Equals(Convert.ToString(button.Tag), mode, StringComparison.Ordinal);
            button.Background = selected ? Brush("#176C52") : Brushes.White;
            button.Foreground = selected ? Brushes.White : Brush("#176C52");
        }
        switch (mode)
        {
            case "generator":
                _modeTitle.Text = "Генератор семейств";
                _modeHelp.Text = "Источник превращается в проверяемую спецификацию и детерминированный action plan. Revit изменяется только после вашего подтверждения.";
                RenderWizard();
                break;
            case "export":
                _modeTitle.Text = "Экспорт BIM-данных в ЛЕС";
                _modeHelp.Text = "Отдельный рабочий сценарий: выберите состав, проверьте BIM-пакет и только затем отправьте его в служебный ARTEL_BIM_Index.";
                _question.Text = "";
                _question.IsEnabled = false;
                _ask.Content = "Подготовить BIM-пакет";
                if (string.IsNullOrWhiteSpace(_exportPackageName.Text)) _exportPackageName.Text = "Текущая модель Revit";
                break;
            default:
                _modeTitle.Text = "BIM-чат";
                _modeHelp.Text = "Задайте вопрос об открытой модели или Revit. Факты модели читаются напрямую через Revit API, справка — из ARTEL Index.";
                _question.IsEnabled = true;
                _question.Text = "";
                _ask.Content = "Спросить АРТЕЛЬ";
                break;
        }
        if (mode != "export") _question.IsEnabled = true;
        RenderModeCard();
    }

    private void RenderModeCard()
    {
        var content = new StackPanel();
        if (_mode == "export")
        {
            content.Children.Add(Label("Название BIM-пакета"));
            content.Children.Add(_exportPackageName);
            content.Children.Add(Muted("Датасет назначения: ARTEL_BIM_Index", new Thickness(0, 6, 0, 0)));
            content.Children.Add(Label("Что экспортировать"));
            content.Children.Add(_exportQuantities);
            content.Children.Add(_exportSelection);
            content.Children.Add(Muted("Сначала будет показан read-only предпросмотр. Отправка начнётся только после отдельного подтверждения.", new Thickness(0, 9, 0, 0)));
            content.Children.Add(_ask);
            content.Children.Add(_execute);
            content.Children.Add(_answer);
            SetAnswer("## Экспорт ещё не запускался\n\nНажмите **Подготовить BIM-пакет**, чтобы увидеть состав и объём данных до отправки в ЛЕС.");
        }
        else
        {
            var safetyCard = new Border
            {
                Padding = new Thickness(11), Margin = new Thickness(0, 0, 0, 11), CornerRadius = new CornerRadius(10),
                BorderThickness = new Thickness(1), BorderBrush = Brush("#D8C6A1"), Background = Brush("#FFF9EC")
            };
            var safetyContent = new StackPanel();
            safetyContent.Children.Add(_safety);
            _safetyStatus.TextWrapping = TextWrapping.Wrap;
            _safetyStatus.Margin = new Thickness(0, 5, 0, 0);
            safetyContent.Children.Add(_safetyStatus);
            safetyCard.Child = safetyContent;
            content.Children.Add(safetyCard);
            content.Children.Add(Label("Вопрос по открытой модели Revit"));
            content.Children.Add(_question);
            content.Children.Add(_ask);
            content.Children.Add(_execute);
            content.Children.Add(_answer);
            SetAnswer("Задайте вопрос об открытой модели — например, о количестве элементов, длинах, площадях или текущем выделении.");
            RefreshSafetyStatus();
        }
        _chatCard.Child = content;
    }

    private void RenderWizard()
    {
        _wizardContent.Children.Clear();
        _wizardBack.IsEnabled = _wizardStep > 1 && _wizardStep < 5;
        _wizardNext.IsEnabled = true;
        _wizardStepLabel.Text = $"Шаг {_wizardStep} из 6 · {WizardTitle(_wizardStep)}";
        _wizardContent.Margin = new Thickness(0, 9, 0, 0);
        switch (_wizardStep)
        {
            case 1:
                AddWizardText("Опишите семейство или добавьте ТЗ, техничку, таблицу, ссылку либо изображение. Можно сочетать описание с одним файлом.");
                _wizardContent.Children.Add(Label("Описание"));
                _wizardContent.Children.Add(_sourceDescription);
                _wizardContent.Children.Add(Label("Ссылка"));
                _wizardContent.Children.Add(_sourceUrl);
                var drop = new Border
                {
                    AllowDrop = true, Margin = new Thickness(0, 10, 0, 4), Padding = new Thickness(12),
                    CornerRadius = new CornerRadius(12), BorderThickness = new Thickness(1), BorderBrush = Brush("#AFCFC2"), Background = Brush("#F3FAF7")
                };
                var dropContent = new StackPanel();
                var pick = SecondaryButton("+ Прикрепить файл");
                pick.HorizontalAlignment = HorizontalAlignment.Left;
                pick.Margin = new Thickness(0, 0, 0, 7);
                pick.Click += (_, _) => PickSource();
                dropContent.Children.Add(pick);
                dropContent.Children.Add(_sourceFileStatus);
                drop.Child = dropContent;
                drop.DragOver += (_, e) => { e.Effects = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None; e.Handled = true; };
                drop.Drop += (_, e) => { if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0) LoadSource(files[0]); };
                _wizardContent.Children.Add(drop);
                _wizardNext.Content = "Разобрать источники";
                break;
            case 2:
                AddWizardText("АРТЕЛЬ извлекает требования, ищет family/FOP/API evidence в ЛЕС и формирует машинный family_spec. Для PDF используется ingestion ЛЕС; изображение читает vision-модель Ollama.");
                if (!string.IsNullOrWhiteSpace(_generatorResult)) AddWizardText("\nПоследний результат:\n" + _generatorResult);
                _wizardNext.Content = "Повторить разбор";
                break;
            case 3:
                AddWizardText("Блокирующие вопросы из спецификации:\n" + SpecificationList("blocking_questions"));
                _wizardContent.Children.Add(Label("Уточнения (если нужны)"));
                _wizardContent.Children.Add(_clarifications);
                _wizardNext.Content = string.IsNullOrWhiteSpace(_clarifications.Text) ? "К спецификации" : "Учесть ответы";
                break;
            case 4:
                AddWizardText("Спецификация и детерминированный action plan. Неизвестные значения остаются MISSING.\n\nСПЕЦИФИКАЦИЯ\n" + Pretty(_generatorSpec) + "\n\nACTION PLAN\n" + Pretty(_generatorPlan));
                _wizardNext.Content = "К подтверждению";
                break;
            case 5:
                AddWizardText("Проверьте активный документ семейства. Выполнится только показанный план; любое изменение сбросит подтверждение. После генерации автоматически запускается validation.");
                DetachConfirm();
                _confirm.IsChecked = false;
                _confirm.Content = "Я проверил точный план и подтверждаю изменение активного документа Revit";
                _wizardContent.Children.Add(_confirm);
                _wizardNext.Content = "Создать и проверить";
                break;
            default:
                AddWizardText(string.IsNullOrWhiteSpace(_generatorResult) ? "Результат ещё не получен." : "Генерация завершена. Полный отчёт сохранён локально.\n\n" + Pretty(_generatorResult));
                _wizardBack.IsEnabled = false;
                _wizardNext.Content = "Новый мастер";
                break;
        }
    }

    private async Task AdvanceWizardAsync()
    {
        if (_wizardStep is 1 or 2)
        {
            if (_wizardStep == 1 && string.IsNullOrWhiteSpace(_sourceDescription.Text) && string.IsNullOrWhiteSpace(_sourceUrl.Text) && _sourceBytes is null)
            {
                AddWizardText("Добавьте хотя бы один источник.");
                return;
            }
            _wizardStep = 2;
            RenderWizard();
            _wizardNext.IsEnabled = false;
            await AnalyzeGeneratorAsync();
            return;
        }
        if (_wizardStep == 3 && !string.IsNullOrWhiteSpace(_clarifications.Text))
        {
            _sourceDescription.Text = (_sourceDescription.Text + "\n\nУточнения пользователя:\n" + _clarifications.Text).Trim();
            _clarifications.Clear();
            _wizardStep = 2;
            RenderWizard();
            _wizardNext.IsEnabled = false;
            await AnalyzeGeneratorAsync();
            return;
        }
        if (_wizardStep == 5)
        {
            if (_confirm.IsChecked != true) { AddWizardText("Нужно явно подтвердить точный план."); return; }
            _wizardNext.IsEnabled = false;
            try
            {
                _generatorResult = await _revit.RunAsync("generate", _generatorPlan, _generatorHash);
                _wizardStep = 6;
            }
            catch (Exception error) { _generatorResult = JsonSerializer.Serialize(new { status = "failed", message = error.Message }); }
            RenderWizard();
            return;
        }
        if (_wizardStep == 6)
        {
            _wizardStep = 1;
            _generatorSpec = _generatorPlan = _generatorHash = _generatorResult = "";
            _sourceBytes = null;
            _sourceName = "";
            _sourceFileStatus.Text = "Перетащите файл сюда или выберите его на диске";
            RenderWizard();
            return;
        }
        _wizardStep++;
        RenderWizard();
    }

    private async Task AnalyzeGeneratorAsync()
    {
        try
        {
            var context = await _revit.RunAsync("context");
            var payload = JsonSerializer.Serialize(new
            {
                description = _sourceDescription.Text.Trim(),
                sourceName = _sourceName,
                contentType = ContentType(_sourceName),
                contentBase64 = _sourceBytes is null ? null : Convert.ToBase64String(_sourceBytes),
                sourceUrl = _sourceUrl.Text.Trim(),
                context = JsonDocument.Parse(context).RootElement
            });
            using var client = new HttpClient { Timeout = TimeSpan.FromMinutes(4) };
            using var response = await client.PostAsync(BackendUrl + "/api/generator/draft", new StringContent(payload, Encoding.UTF8, "application/json"));
            var body = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode) throw new InvalidOperationException(body);
            using var document = JsonDocument.Parse(body);
            _generatorSpec = document.RootElement.GetProperty("specification").GetRawText();
            _generatorPlan = document.RootElement.GetProperty("planJson").GetString() ?? "";
            _generatorHash = document.RootElement.GetProperty("confirmationHash").GetString() ?? "";
            _generatorResult = "";
            _wizardStep = 3;
        }
        catch (Exception error)
        {
            _generatorResult = error.Message;
            _wizardStep = 2;
        }
        finally { _wizardNext.IsEnabled = true; RenderWizard(); }
    }

    private void PickSource()
    {
        var dialog = new OpenFileDialog
        {
            Title = "Источник для генератора АРТЕЛЬ",
            Filter = "Поддерживаемые источники|*.pdf;*.docx;*.xlsx;*.txt;*.md;*.csv;*.json;*.png;*.jpg;*.jpeg;*.webp|Все файлы|*.*"
        };
        if (dialog.ShowDialog() != true) return;
        LoadSource(dialog.FileName);
    }

    private void LoadSource(string path)
    {
        var info = new FileInfo(path);
        if (info.Length > 25 * 1024 * 1024) { _sourceFileStatus.Text = "Файл больше 25 МБ — выберите меньший источник."; return; }
        var supported = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { ".pdf", ".docx", ".xlsx", ".txt", ".md", ".csv", ".json", ".png", ".jpg", ".jpeg", ".webp" };
        if (!supported.Contains(info.Extension)) { _sourceFileStatus.Text = "Формат не поддерживается: " + info.Extension; return; }
        _sourceBytes = File.ReadAllBytes(path);
        _sourceName = info.Name;
        _sourceFileStatus.Text = $"✓ {info.Name} · {Math.Max(1, info.Length / 1024)} КБ · готов к разбору";
    }

    private async Task AskAsync()
    {
        _ask.IsEnabled = false;
        _execute.Visibility = Visibility.Collapsed;
        _confirm.IsChecked = false;
        _pendingPlan = _pendingHash = _pendingAnswer = "";
        try
        {
            if (_mode == "export")
            {
                var options = JsonSerializer.Serialize(new
                {
                    package_name = _exportPackageName.Text.Trim(),
                    include_quantities = _exportQuantities.IsChecked == true,
                    include_selection = _exportSelection.IsChecked == true
                });
                var preview = await _revit.RunAsync("export_preview", options);
                using var previewDoc = JsonDocument.Parse(preview);
                _pendingExport = previewDoc.RootElement.GetProperty("payload").GetRawText();
                SetAnswer("## Предпросмотр BIM-пакета\n\nПакет сохранён локально и готов к отправке.\n\n```json\n" + Pretty(preview) + "\n```");
                ShowConfirmation("Подтверждаю отправку показанного BIM-пакета в пользовательский ARTEL_BIM_Index", "Отправить в ЛЕС");
                return;
            }
            var question = _question.Text.Trim();
            if (question.Length < 3) return;
            SetAnswer("_Агент запрашивает данные непосредственно у Revit…_");
            using var client = new HttpClient { Timeout = TimeSpan.FromMinutes(5) };
            var conversationJson = "";
            var toolResultJson = "";
            var body = "";
            for (var round = 0; round < 20; round++)
            {
                var requestPayload = new Dictionary<string, object?>
                {
                    ["question"] = question,
                    ["datasetFilter"] = "ARTEL"
                };
                if (!string.IsNullOrWhiteSpace(conversationJson))
                    requestPayload["conversation"] = JsonDocument.Parse(conversationJson).RootElement.Clone();
                if (!string.IsNullOrWhiteSpace(toolResultJson))
                    requestPayload["toolResult"] = JsonDocument.Parse(toolResultJson).RootElement.Clone();
                using var response = await client.PostAsync(
                    BackendUrl + "/api/assistant/live",
                    new StringContent(JsonSerializer.Serialize(requestPayload), Encoding.UTF8, "application/json"));
                body = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode) throw new InvalidOperationException(body);
                using var turn = JsonDocument.Parse(body);
                var status = GetJsonString(turn.RootElement, "status");
                if (status != "tool_request") break;
                var toolRequest = turn.RootElement.GetProperty("toolRequest");
                var toolName = GetJsonString(toolRequest, "tool_name");
                if (toolName != "query_revit") throw new InvalidOperationException("Backend запросил неизвестный live Revit tool: " + toolName);
                var liveResult = await _revit.RunAsync("agent_query", toolRequest.GetProperty("arguments").GetRawText());
                conversationJson = turn.RootElement.GetProperty("conversation").GetRawText();
                using var resultDocument = JsonDocument.Parse(liveResult);
                toolResultJson = JsonSerializer.Serialize(new Dictionary<string, object?>
                {
                    ["tool_name"] = toolName,
                    ["result"] = resultDocument.RootElement.Clone()
                });
            }
            if (string.IsNullOrWhiteSpace(body)) throw new InvalidOperationException("Live Revit agent не вернул ответ.");
            using var document = JsonDocument.Parse(body);
            if (GetJsonString(document.RootElement, "status") == "tool_request")
                throw new InvalidOperationException("Live Revit agent превысил 20 последовательных API-запросов.");
            var answer = document.RootElement.GetProperty("answer").GetString() ?? body;
            SetAnswer(answer);
            if (document.RootElement.TryGetProperty("action", out var action)
                && action.ValueKind == JsonValueKind.Object
                && GetJsonString(action, "status") == "ready")
            {
                _pendingPlan = GetJsonString(action, "planJson");
                _pendingHash = GetJsonString(action, "confirmationHash");
                _pendingAnswer = answer;
                var summary = GetJsonString(action, "summary");
                var requiresConfirmation = action.TryGetProperty("requires_confirmation", out var confirmationNode)
                    && confirmationNode.ValueKind == JsonValueKind.True;
                var preview = await _revit.RunAsync("operator_preview", _pendingPlan, _pendingHash);
                var previewMarkdown = OperatorPreviewMarkdown(preview);
                if (requiresConfirmation && SafetyEnabled)
                {
                    SetAnswer(answer + "\n\n### Готово к выполнению\n\n" + summary + "." + previewMarkdown + "\n\nПроверьте действие и подтвердите изменение документа Revit.");
                    ShowConfirmation("Подтверждаю это действие в активном документе Revit", "Выполнить в Revit");
                }
                else
                {
                    var result = await _revit.RunAsync("operator", _pendingPlan, _pendingHash, bypassSafety: requiresConfirmation && !SafetyEnabled);
                    SetAnswer(answer + previewMarkdown + OperatorResultMarkdown(result));
                    _pendingPlan = _pendingHash = _pendingAnswer = "";
                }
            }
        }
        catch (Exception error) { SetAnswer("## Не удалось выполнить запрос\n\n" + error.Message); }
        finally { _ask.IsEnabled = true; }
    }

    private void ShowConfirmation(string text, string buttonText)
    {
        DetachConfirm();
        var stack = (StackPanel)_chatCard.Child;
        var index = stack.Children.IndexOf(_execute);
        _confirm.Content = text;
        stack.Children.Insert(index, _confirm);
        _execute.Content = buttonText;
        _execute.Visibility = Visibility.Visible;
    }

    private void DetachConfirm()
    {
        if (_confirm.Parent is Panel parent) parent.Children.Remove(_confirm);
    }

    private async Task ExecutePendingAsync()
    {
        if ((_mode == "export" || SafetyEnabled) && _confirm.IsChecked != true) { SetAnswer("**Сначала подтвердите точный план или BIM-пакет.**"); return; }
        _execute.IsEnabled = false;
        try
        {
            if (_mode == "export")
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromMinutes(2) };
                using var response = await client.PostAsync(BackendUrl + "/api/integrations/les/export", new StringContent(_pendingExport, Encoding.UTF8, "application/json"));
                var result = Pretty(await response.Content.ReadAsStringAsync());
                SetAnswer("## Результат экспорта\n\n```json\n" + result + "\n```");
                if (!response.IsSuccessStatusCode) throw new InvalidOperationException(result);
            }
            else if (_mode == "chat" && !string.IsNullOrWhiteSpace(_pendingPlan))
            {
                var result = await _revit.RunAsync("operator", _pendingPlan, _pendingHash, bypassSafety: !SafetyEnabled);
                SetAnswer(_pendingAnswer + OperatorResultMarkdown(result));
                _pendingPlan = _pendingHash = _pendingAnswer = "";
            }
            _execute.Visibility = Visibility.Collapsed;
            DetachConfirm();
        }
        catch (Exception error) { SetAnswer("## Выполнение не завершено\n\n" + error.Message); }
        finally { _execute.IsEnabled = true; }
    }

    private static string OperatorResultMarkdown(string result)
    {
        using var document = JsonDocument.Parse(result);
        if (!document.RootElement.TryGetProperty("results", out var results) || results.ValueKind != JsonValueKind.Array)
            return "\n\n### Revit\n\nДействие выполнено.";
        var messages = results.EnumerateArray().Select(item => GetJsonString(item, "message"))
            .Where(message => !string.IsNullOrWhiteSpace(message));
        return "\n\n### Выполнено в Revit\n\n" + string.Join("\n", messages.Select(message => "- " + message));
    }

    private static string OperatorPreviewMarkdown(string preview)
    {
        using var document = JsonDocument.Parse(preview);
        if (!document.RootElement.TryGetProperty("operations", out var operations) || operations.ValueKind != JsonValueKind.Array) return "";
        var rows = operations.EnumerateArray().Select(item =>
            $"- `{GetJsonString(item, "op")}`: целей — {GetJsonInt(item, "target_count")}");
        return "\n\n### Предпросмотр целей\n\n" + string.Join("\n", rows);
    }

    private bool SafetyEnabled => _safety.IsChecked != false;

    private void RefreshSafetyStatus()
    {
        _safetyStatus.Text = SafetyEnabled
            ? "Включён: изменяющий план сначала показывает точные цели и требует подтверждения. Изменение состава целей блокирует выполнение."
            : "ОТКЛЮЧЁН: агент выполняет изменяющий план сразу после read-only предпросмотра. Валидация, ExternalEvent, Transaction и rollback остаются включены.";
        _safetyStatus.Foreground = SafetyEnabled ? Brush("#6A6D67") : Brush("#A33A2B");
    }

    private static string SafetySettingsPath => Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ARTEL", "revit-agent-settings.json");

    private static bool LoadSafetySetting()
    {
        try
        {
            if (!File.Exists(SafetySettingsPath)) return true;
            using var document = JsonDocument.Parse(File.ReadAllText(SafetySettingsPath));
            return !document.RootElement.TryGetProperty("safety_enabled", out var value) || value.GetBoolean();
        }
        catch { return true; }
    }

    private static void SaveSafetySetting(bool enabled)
    {
        try
        {
            var directory = Path.GetDirectoryName(SafetySettingsPath)!;
            Directory.CreateDirectory(directory);
            File.WriteAllText(SafetySettingsPath, JsonSerializer.Serialize(new { safety_enabled = enabled }));
        }
        catch { }
    }

    private static string GetJsonString(JsonElement element, string name) =>
        element.TryGetProperty(name, out var value) && value.ValueKind == JsonValueKind.String ? value.GetString() ?? "" : "";

    private static int GetJsonInt(JsonElement element, string name) =>
        element.TryGetProperty(name, out var value) && value.ValueKind == JsonValueKind.Number ? value.GetInt32() : 0;

    private void SetAnswer(string markdown)
    {
        var document = new FlowDocument
        {
            FontFamily = new FontFamily("Segoe UI"), FontSize = 13.5, Foreground = Brush("#343632"),
            PagePadding = new Thickness(0), LineHeight = 20, TextAlignment = TextAlignment.Left
        };
        var lines = (markdown ?? "").Replace("\r\n", "\n").Split('\n');
        for (var index = 0; index < lines.Length; index++)
        {
            var line = lines[index];
            if (line.StartsWith("```", StringComparison.Ordinal))
            {
                var code = new StringBuilder();
                while (++index < lines.Length && !lines[index].StartsWith("```", StringComparison.Ordinal)) code.AppendLine(lines[index]);
                document.Blocks.Add(new Paragraph(new Run(code.ToString().TrimEnd()))
                {
                    FontFamily = new FontFamily("Consolas"), FontSize = 12, Background = Brush("#F0F2EF"),
                    Padding = new Thickness(10), Margin = new Thickness(0, 6, 0, 10)
                });
                continue;
            }
            if (IsMarkdownTable(lines, index))
            {
                var table = new Table { CellSpacing = 0, Margin = new Thickness(0, 6, 0, 10) };
                var rows = new TableRowGroup();
                table.RowGroups.Add(rows);
                AddMarkdownTableRow(rows, SplitTableRow(lines[index]), true);
                index += 2;
                while (index < lines.Length && lines[index].TrimStart().StartsWith("|", StringComparison.Ordinal))
                {
                    AddMarkdownTableRow(rows, SplitTableRow(lines[index]), false);
                    index++;
                }
                index--;
                document.Blocks.Add(table);
                continue;
            }
            if (line.StartsWith("- ", StringComparison.Ordinal) || line.StartsWith("* ", StringComparison.Ordinal))
            {
                var list = new System.Windows.Documents.List { MarkerStyle = TextMarkerStyle.Disc, Margin = new Thickness(18, 3, 0, 8) };
                while (index < lines.Length && (lines[index].StartsWith("- ", StringComparison.Ordinal) || lines[index].StartsWith("* ", StringComparison.Ordinal)))
                {
                    var paragraph = new Paragraph { Margin = new Thickness(0, 1, 0, 1) };
                    AddMarkdownInlines(paragraph.Inlines, lines[index].Substring(2));
                    list.ListItems.Add(new ListItem(paragraph));
                    index++;
                }
                index--;
                document.Blocks.Add(list);
                continue;
            }
            if (string.IsNullOrWhiteSpace(line)) continue;
            var headingLevel = line.TakeWhile(character => character == '#').Count();
            var paragraphBlock = new Paragraph
            {
                Margin = headingLevel > 0 ? new Thickness(0, 8, 0, 5) : new Thickness(0, 2, 0, 7),
                FontSize = headingLevel switch { 1 => 20, 2 => 17, 3 => 15, _ => 13.5 },
                FontWeight = headingLevel > 0 ? FontWeights.SemiBold : FontWeights.Normal,
                Foreground = headingLevel > 0 ? Brush("#24332D") : Brush("#343632")
            };
            AddMarkdownInlines(paragraphBlock.Inlines, headingLevel > 0 ? line.Substring(Math.Min(line.Length, headingLevel)).TrimStart() : line);
            document.Blocks.Add(paragraphBlock);
        }
        if (document.Blocks.Count == 0) document.Blocks.Add(new Paragraph(new Run("—")));
        _answer.Document = document;
    }

    private static void AddMarkdownInlines(InlineCollection inlines, string text)
    {
        var position = 0;
        while (position < text.Length)
        {
            var bold = text.IndexOf("**", position, StringComparison.Ordinal);
            var code = text.IndexOf('`', position);
            var next = bold < 0 ? code : code < 0 ? bold : Math.Min(bold, code);
            if (next < 0) { inlines.Add(new Run(text.Substring(position))); break; }
            if (next > position) inlines.Add(new Run(text.Substring(position, next - position)));
            if (next == bold)
            {
                var end = text.IndexOf("**", bold + 2, StringComparison.Ordinal);
                if (end < 0) { inlines.Add(new Run(text.Substring(bold))); break; }
                inlines.Add(new Bold(new Run(text.Substring(bold + 2, end - bold - 2))));
                position = end + 2;
            }
            else
            {
                var end = text.IndexOf('`', code + 1);
                if (end < 0) { inlines.Add(new Run(text.Substring(code))); break; }
                inlines.Add(new Run(text.Substring(code + 1, end - code - 1)) { FontFamily = new FontFamily("Consolas"), Background = Brush("#F0F2EF") });
                position = end + 1;
            }
        }
    }

    private static bool IsMarkdownTable(string[] lines, int index) =>
        index + 1 < lines.Length && lines[index].TrimStart().StartsWith("|", StringComparison.Ordinal)
        && lines[index + 1].Contains("---");

    private static string[] SplitTableRow(string line)
    {
        var cells = new List<string>();
        var cell = new StringBuilder();
        var value = line.Trim().Trim('|');
        for (var index = 0; index < value.Length; index++)
        {
            if (value[index] == '\\' && index + 1 < value.Length && value[index + 1] == '|')
            {
                cell.Append('|');
                index++;
            }
            else if (value[index] == '|')
            {
                cells.Add(cell.ToString().Trim());
                cell.Clear();
            }
            else cell.Append(value[index]);
        }
        cells.Add(cell.ToString().Trim());
        return cells.ToArray();
    }

    private static void AddMarkdownTableRow(TableRowGroup group, string[] cells, bool header)
    {
        var row = new TableRow { Background = header ? Brush("#E8F3EE") : Brushes.White };
        foreach (var value in cells)
        {
            var paragraph = new Paragraph { Margin = new Thickness(0) };
            AddMarkdownInlines(paragraph.Inlines, value);
            row.Cells.Add(new TableCell(paragraph)
            {
                Padding = new Thickness(8, 6, 8, 6), BorderBrush = Brush("#DDE4E0"), BorderThickness = new Thickness(0, 0, 0, 1),
                FontWeight = header ? FontWeights.SemiBold : FontWeights.Normal
            });
        }
        group.Rows.Add(row);
    }

    private async Task RefreshRuntimeAsync()
    {
        try
        {
            using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(8) };
            var health = await client.GetStringAsync(BackendUrl + "/health");
            var model = await client.GetStringAsync(BackendUrl + "/api/integrations/model/status");
            var les = await client.GetStringAsync(BackendUrl + "/api/integrations/les/status");
            using var modelDoc = JsonDocument.Parse(model);
            using var lesDoc = JsonDocument.Parse(les);
            var ollama = modelDoc.RootElement.TryGetProperty("ollama", out var nested) ? nested : modelDoc.RootElement;
            var status = ollama.TryGetProperty("status", out var value) ? value.GetString() : "unknown";
            var lesStatus = lesDoc.RootElement.TryGetProperty("status", out var lesValue) ? lesValue.GetString() : "unknown";
            _runtime.Text = health.Contains("\"status\":\"ok\"")
                ? $"Backend: готов · Ollama: {RuntimeLabel(status)} · ЛЕС: {RuntimeLabel(lesStatus)}"
                : "Backend ответил с неожиданным статусом";
        }
        catch (Exception error) { _runtime.Text = "Backend ARTEL недоступен. Перезапустите службу из меню Пуск.\n" + error.Message; }
    }

    private void AddWizardText(string text)
    {
        _wizardContent.Children.Add(new TextBlock { Text = text, TextWrapping = TextWrapping.Wrap, LineHeight = 20, Foreground = Brush("#343632") });
    }

    private string SpecificationList(string property)
    {
        if (string.IsNullOrWhiteSpace(_generatorSpec)) return "—";
        try
        {
            using var doc = JsonDocument.Parse(_generatorSpec);
            if (!doc.RootElement.TryGetProperty(property, out var values) || values.ValueKind != JsonValueKind.Array || values.GetArrayLength() == 0) return "Блокирующих вопросов нет.";
            var result = new StringBuilder();
            foreach (var value in values.EnumerateArray()) result.AppendLine("• " + value.ToString());
            return result.ToString();
        }
        catch { return "—"; }
    }

    private static string WizardTitle(int step) => step switch { 1 => "Источник", 2 => "Разбор", 3 => "Уточнения", 4 => "Спецификация", 5 => "Генерация", _ => "Проверка" };
    private static string ContentType(string name) => Path.GetExtension(name).ToLowerInvariant() switch { ".png" => "image/png", ".jpg" or ".jpeg" => "image/jpeg", ".webp" => "image/webp", ".pdf" => "application/pdf", _ => "application/octet-stream" };
    private static string Pretty(string json)
    {
        try { using var document = JsonDocument.Parse(json); return JsonSerializer.Serialize(document.RootElement, new JsonSerializerOptions { WriteIndented = true, Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping }); }
        catch { return json; }
    }

    private static Border Card() => new()
    {
        Padding = new Thickness(14), Margin = new Thickness(0, 0, 0, 14), CornerRadius = new CornerRadius(16), Background = Brushes.White,
        BorderThickness = new Thickness(0), Effect = new System.Windows.Media.Effects.DropShadowEffect { Color = Colors.Black, Opacity = .08, BlurRadius = 10, ShadowDepth = 1 }
    };

    private static TextBlock Label(string text) => new() { Text = text, Margin = new Thickness(0, 8, 0, 6), FontWeight = FontWeights.SemiBold, Foreground = Brush("#343632") };
    private static TextBlock Muted(string text, Thickness? margin = null) => new() { Text = text, TextWrapping = TextWrapping.Wrap, Foreground = Brush("#6A6D67"), Margin = margin ?? new Thickness(0) };
    private static WpfTextBox Input(bool multiline, double minHeight) => new()
    {
        MinHeight = minHeight, AcceptsReturn = multiline, TextWrapping = multiline ? TextWrapping.Wrap : TextWrapping.NoWrap, Padding = new Thickness(10),
        BorderBrush = Brush("#D9D8D2"), Background = Brushes.White, VerticalScrollBarVisibility = multiline ? ScrollBarVisibility.Auto : ScrollBarVisibility.Disabled
    };
    private static Button PrimaryButton(string text) => new()
    {
        Content = text, MinHeight = 40, Padding = new Thickness(16, 8, 14, 8), Background = Brush("#176C52"), Foreground = Brushes.White, BorderThickness = new Thickness(0)
    };
    private static Button SecondaryButton(string text) => new()
    {
        Content = text, MinHeight = 40, Padding = new Thickness(14, 8, 14, 8), Background = Brushes.White, Foreground = Brush("#176C52"), BorderBrush = Brush("#C9DDD5")
    };
    private static SolidColorBrush Brush(string color) => new((Color)ColorConverter.ConvertFromString(color));
    private static string RuntimeLabel(string? status) => status?.Trim().ToLowerInvariant() switch
    {
        "ready" or "ok" => "готов",
        "unavailable" or "offline" or "error" => "недоступен",
        _ => "проверить"
    };
    private static string BackendUrl => (Environment.GetEnvironmentVariable("ARTEL_BASE_URL") ?? "http://127.0.0.1:5057").TrimEnd('/');
}

[Transaction(TransactionMode.Manual)]
public sealed class ArtelShowPaneCommand : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, Autodesk.Revit.DB.ElementSet elements)
    {
        commandData.Application.GetDockablePane(ArtelPaneIds.Main).Show();
        return Result.Succeeded;
    }
}
