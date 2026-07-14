using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace ARTEL.Revit.FamilyFactory;

internal sealed class ArtelExternalEventBridge : IDisposable
{
    private readonly ArtelExternalEventHandler _handler = new();
    private readonly ExternalEvent _externalEvent;

    internal ArtelExternalEventBridge()
    {
        _externalEvent = ExternalEvent.Create(_handler);
    }

    internal Task<string> RunAsync(string kind, string payload = "", string confirmationHash = "", bool bypassSafety = false)
    {
        var task = _handler.Queue(kind, payload, confirmationHash, bypassSafety);
        var result = _externalEvent.Raise();
        if (result != ExternalEventRequest.Accepted)
        {
            _handler.FailPending($"Revit отклонил ExternalEvent: {result}.");
        }
        return task;
    }

    public void Dispose() => _externalEvent.Dispose();
}

internal sealed class ArtelExternalEventHandler : IExternalEventHandler
{
    private readonly object _gate = new();
    private readonly Dictionary<string, string> _operatorPreviews = new(StringComparer.OrdinalIgnoreCase);
    private ArtelEventRequest? _pending;

    internal Task<string> Queue(string kind, string payload, string confirmationHash, bool bypassSafety)
    {
        lock (_gate)
        {
            if (_pending is not null) throw new InvalidOperationException("Предыдущее действие АРТЕЛЬ ещё выполняется.");
            var completion = new TaskCompletionSource<string>();
            _pending = new ArtelEventRequest(kind, payload, confirmationHash, bypassSafety, completion);
            return completion.Task;
        }
    }

    internal void FailPending(string message)
    {
        ArtelEventRequest? request;
        lock (_gate) { request = _pending; _pending = null; }
        request?.Completion.TrySetException(new InvalidOperationException(message));
    }

    public void Execute(UIApplication application)
    {
        ArtelEventRequest? request;
        lock (_gate) { request = _pending; _pending = null; }
        if (request is null) return;
        try
        {
            var result = request.Kind switch
            {
                "context" => CaptureContext(application),
                "agent_query" => QueryRevitLive(application, request.Payload),
                "generate" => Generate(application, request.Payload, request.ConfirmationHash),
                "validate" => Validate(application),
                "operator_preview" => PreviewOperator(application, request.Payload, request.ConfirmationHash),
                "operator" => ExecuteOperator(application, request.Payload, request.ConfirmationHash, request.BypassSafety),
                "export_preview" => ExportPreview(application, request.Payload),
                _ => throw new InvalidOperationException($"Неизвестное действие ARTEL: {request.Kind}")
            };
            request.Completion.TrySetResult(result);
        }
        catch (Exception error)
        {
            request.Completion.TrySetException(error);
        }
    }

    public string GetName() => "ARTEL confirmed Revit API bridge";

    private static string QueryRevitLive(UIApplication application, string requestJson)
    {
        var uiDocument = application.ActiveUIDocument ?? throw new InvalidOperationException("Нет активного документа Revit.");
        var document = uiDocument.Document;
        using var request = JsonDocument.Parse(string.IsNullOrWhiteSpace(requestJson) ? "{}" : requestJson);
        var root = request.RootElement;
        var mode = GetString(root, "mode", "document");
        var offset = root.TryGetProperty("offset", out var offsetNode) && offsetNode.TryGetInt32(out var parsedOffset)
            ? Math.Max(0, parsedOffset) : 0;
        var limit = root.TryGetProperty("limit", out var limitNode) && limitNode.TryGetInt32(out var parsedLimit)
            ? Math.Max(1, Math.Min(1000, parsedLimit)) : 200;
        var query = root.TryGetProperty("query", out var queryNode) && queryNode.ValueKind == JsonValueKind.Object
            ? queryNode : default;
        object rows;
        int total;

        if (mode == "document")
        {
            var documentRows = new List<Dictionary<string, object?>>
            {
                new()
                {
                    ["title"] = document.Title, ["path"] = document.PathName ?? "",
                    ["revit_version"] = application.Application.VersionNumber,
                    ["active_view"] = document.ActiveView?.Name ?? "",
                    ["is_family_document"] = document.IsFamilyDocument,
                    ["warning_count"] = document.GetWarnings().Count,
                    ["selection_count"] = uiDocument.Selection.GetElementIds().Count
                }
            };
            total = documentRows.Count;
            rows = documentRows.Skip(offset).Take(limit).ToList();
        }
        else
        {
            var ids = ResolveLiveTargets(uiDocument, query, mode == "selection" ? "selection" : null);
            if (mode == "categories")
            {
                var categoryRows = ids.Select(document.GetElement).Where(element => element?.Category is not null)
                    .GroupBy(element => element!.Category!.Name, StringComparer.OrdinalIgnoreCase)
                    .OrderBy(group => group.Key)
                    .Select(group => new Dictionary<string, object?> { ["category"] = group.Key, ["count"] = group.Count() })
                    .ToList();
                total = categoryRows.Count;
                rows = categoryRows.Skip(offset).Take(limit).ToList();
            }
            else if (mode == "parameters")
            {
                var parameterRows = new Dictionary<string, Dictionary<string, object?>>(StringComparer.OrdinalIgnoreCase);
                foreach (var element in ids.Select(document.GetElement).Where(element => element is not null).Cast<Element>())
                {
                    foreach (var owner in new[] { new { Scope = "instance", Element = element }, new { Scope = "type", Element = document.GetElement(element.GetTypeId()) } })
                    {
                        if (owner.Element is null) continue;
                        foreach (Parameter parameter in owner.Element.Parameters)
                        {
                            if (parameter.Definition is null) continue;
                            var key = owner.Scope + "\u001f" + parameter.Definition.Name;
                            if (parameterRows.ContainsKey(key)) continue;
                            parameterRows[key] = new Dictionary<string, object?>
                            {
                                ["name"] = parameter.Definition.Name,
                                ["scope"] = owner.Scope,
                                ["storage_type"] = parameter.StorageType.ToString(),
                                ["is_read_only"] = parameter.IsReadOnly,
                                ["has_value"] = parameter.HasValue,
                                ["sample_display_value"] = parameter.AsValueString() ?? ""
                            };
                        }
                    }
                }
                var ordered = parameterRows.Values
                    .OrderBy(row => row["name"]?.ToString()).ThenBy(row => row["scope"]?.ToString()).ToList();
                total = ordered.Count;
                rows = ordered.Skip(offset).Take(limit).ToList();
            }
            else if (mode is "elements" or "selection")
            {
                var requestedFieldSource = GetArray(root, "fields").ToArray();
                if (requestedFieldSource.Length == 0 && query.ValueKind == JsonValueKind.Object)
                    requestedFieldSource = GetArray(query, "fields").ToArray();
                var fields = requestedFieldSource.Select(value => value.GetString() ?? "")
                    .Where(value => !string.IsNullOrWhiteSpace(value)).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
                var elementRows = ids.Skip(offset).Take(limit).Select(id =>
                {
                    var element = document.GetElement(id)!;
                    var type = document.GetElement(element.GetTypeId());
                    var values = new Dictionary<string, object?>();
                    foreach (var field in fields)
                    {
                        var instanceParameter = element.LookupParameter(field);
                        var typeParameter = type?.LookupParameter(field);
                        var parameter = instanceParameter ?? typeParameter;
                        values[field] = parameter is null ? null : new Dictionary<string, object?>
                        {
                            ["scope"] = instanceParameter is not null ? "instance" : "type",
                            ["value"] = ParameterText(document, parameter),
                            ["storage_type"] = parameter.StorageType.ToString()
                        };
                    }
                    return new Dictionary<string, object?>
                    {
                        ["id"] = id.Value,
                        ["category"] = element.Category?.Name ?? "",
                        ["family"] = type is ElementType elementType ? elementType.FamilyName : "",
                        ["type"] = type?.Name ?? element.Name,
                        ["system"] = element.get_Parameter(BuiltInParameter.RBS_SYSTEM_NAME_PARAM)?.AsValueString() ?? "",
                        ["parameters"] = values
                    };
                }).ToList();
                total = ids.Count;
                rows = elementRows;
            }
            else throw new InvalidOperationException($"Неизвестный query_revit mode: {mode}");
        }

        var returned = rows is System.Collections.ICollection collection ? collection.Count : 0;
        return JsonSerializer.Serialize(new Dictionary<string, object?>
        {
            ["schema"] = "artel.revit_live_query.v1", ["status"] = "ok", ["mode"] = mode,
            ["total"] = total, ["offset"] = offset, ["limit"] = limit,
            ["returned"] = returned, ["has_more"] = offset + returned < total,
            ["rows"] = rows
        }, JsonOptions);
    }

    private static List<ElementId> ResolveLiveTargets(UIDocument uiDocument, JsonElement query, string? forcedScope)
    {
        var normalizedQuery = query.ValueKind == JsonValueKind.Object ? query.GetRawText() : "{\"scope\":\"model\"}";
        if (query.ValueKind == JsonValueKind.Object
            && !query.TryGetProperty("scope", out _)
            && !query.TryGetProperty("categories", out _)
            && !query.TryGetProperty("category", out _))
            normalizedQuery = "{\"scope\":\"model\"}";
        using var operation = JsonDocument.Parse($"{{\"arguments\":{{\"query\":{normalizedQuery}}},\"target_ids\":[]}}");
        if (!string.IsNullOrWhiteSpace(forcedScope))
        {
            using var forced = JsonDocument.Parse($"{{\"arguments\":{{\"query\":{{\"scope\":\"{forcedScope}\"}}}},\"target_ids\":[]}}");
            return ResolveTargets(uiDocument, forced.RootElement);
        }
        return ResolveTargets(uiDocument, operation.RootElement);
    }

    private static string CaptureContext(UIApplication application)
    {
        var uiDocument = application.ActiveUIDocument;
        var document = uiDocument?.Document;
        if (document is null)
            return JsonSerializer.Serialize(new Dictionary<string, object?> { ["status"] = "no_active_document", ["revit_version"] = application.Application.VersionNumber });

        var selection = uiDocument!.Selection.GetElementIds().Take(100).ToArray();
        var selected = new List<Dictionary<string, object?>>();
        foreach (var id in selection.Take(20))
        {
            var element = document.GetElement(id);
            if (element is null) continue;
            selected.Add(new Dictionary<string, object?>
            {
                ["id"] = id.Value,
                ["name"] = element.Name,
                ["category"] = element.Category?.Name ?? "",
                ["type_id"] = element.GetTypeId().Value,
                ["parameters"] = ArtelModelReader.ReadParameters(element, 200),
                ["type_parameters"] = document.GetElement(element.GetTypeId()) is Element type ? ArtelModelReader.ReadParameters(type, 200) : new List<Dictionary<string, object?>>()
            });
        }
        var context = new Dictionary<string, object?>
        {
            ["status"] = "ok",
            ["revit_version"] = application.Application.VersionNumber,
            ["document_title"] = document.Title,
            ["document_path"] = document.PathName ?? "",
            ["is_family_document"] = document.IsFamilyDocument,
            ["active_view"] = document.ActiveView?.Name ?? "",
            ["selected_element_ids"] = selection.Select(id => id.Value).ToArray(),
            ["selected_elements"] = selected,
            ["model_quantities"] = ArtelModelReader.QuantitySummary(document),
            ["system_quantities"] = ArtelModelReader.SystemQuantitySummary(document),
            ["model_inventory"] = ArtelModelReader.InventorySummary(document),
            ["parameter_catalog"] = ArtelModelReader.ParameterCatalog(document),
            ["warning_count"] = document.GetWarnings().Count
        };
        return JsonSerializer.Serialize(context, JsonOptions);
    }

    private static string Generate(UIApplication application, string planJson, string confirmationHash)
    {
        EnsureConfirmed(planJson, confirmationHash);
        var document = application.ActiveUIDocument?.Document ?? throw new InvalidOperationException("Нет активного документа Revit.");
        if (!document.IsFamilyDocument) throw new InvalidOperationException("Откройте документ семейства RFA/RFT перед генерацией.");
        using var plan = JsonDocument.Parse(planJson);
        var generation = FamilyPlanExecutor.Execute(document, plan.RootElement, application.Application);
        var validation = FamilyFactoryValidator.Validate(document, application.Application, application.Application.VersionNumber, null, ArtelOptions.Load());
        var path = FamilyFactoryPaths.WriteJson("wizard_result", new Dictionary<string, object?>
        {
            ["schema"] = "artel.generator_wizard_result.v1",
            ["confirmation_hash"] = confirmationHash,
            ["generation"] = generation,
            ["validation"] = validation,
            ["completed_at"] = DateTimeOffset.UtcNow.ToString("O")
        });
        return JsonSerializer.Serialize(new Dictionary<string, object?>
        {
            ["status"] = generation["status"],
            ["generation"] = generation,
            ["validation"] = validation,
            ["report_path"] = path
        }, JsonOptions);
    }

    private static string Validate(UIApplication application)
    {
        var document = application.ActiveUIDocument?.Document ?? throw new InvalidOperationException("Нет активного документа Revit.");
        var validation = FamilyFactoryValidator.Validate(document, application.Application, application.Application.VersionNumber, null, ArtelOptions.Load());
        var path = FamilyFactoryPaths.WriteJson("validation", validation);
        return JsonSerializer.Serialize(new Dictionary<string, object?> { ["status"] = validation["status"], ["validation"] = validation, ["report_path"] = path }, JsonOptions);
    }

    private static string ExportPreview(UIApplication application, string optionsJson)
    {
        var uiDocument = application.ActiveUIDocument ?? throw new InvalidOperationException("Нет активного документа Revit.");
        var document = uiDocument.Document;
        using var options = JsonDocument.Parse(string.IsNullOrWhiteSpace(optionsJson) ? "{}" : optionsJson);
        var packageName = GetString(options.RootElement, "package_name", document.Title);
        var includeQuantities = !options.RootElement.TryGetProperty("include_quantities", out var quantitiesOption) || quantitiesOption.GetBoolean();
        var includeSelection = !options.RootElement.TryGetProperty("include_selection", out var selectionOption) || selectionOption.GetBoolean();
        var export = FamilyFactoryExporter.Export(document, application.Application.VersionNumber);
        export["export_name"] = packageName;
        export["target_dataset"] = "ARTEL_BIM_Index";
        if (!includeQuantities) export.Remove("model_quantities");
        if (!includeQuantities) export.Remove("system_quantities");
        if (includeSelection)
        {
            export["selected_elements"] = uiDocument.Selection.GetElementIds().Take(100)
                .Select(id => document.GetElement(id))
                .Where(element => element is not null)
                .Select(element => new Dictionary<string, object?>
                {
                    ["id"] = element!.Id.Value,
                    ["name"] = element.Name,
                    ["category"] = element.Category?.Name ?? "",
                    ["parameters"] = ArtelModelReader.ReadParameters(element, 80)
                }).ToList();
        }
        var path = FamilyFactoryPaths.WriteJson("export_preview", export);
        return JsonSerializer.Serialize(new Dictionary<string, object?> { ["status"] = "preview", ["payload"] = export, ["local_path"] = path }, JsonOptions);
    }

    private string PreviewOperator(UIApplication application, string planJson, string confirmationHash)
    {
        EnsureConfirmed(planJson, confirmationHash);
        var uiDocument = application.ActiveUIDocument ?? throw new InvalidOperationException("Нет активного документа Revit.");
        using var plan = JsonDocument.Parse(planJson);
        EnsureOperatorSchema(plan.RootElement);
        var previews = new List<Dictionary<string, object?>>();
        var fingerprints = new List<string>();
        foreach (var operation in GetArray(plan.RootElement, "operations"))
        {
            var ids = ResolveTargets(uiDocument, operation);
            var fingerprint = Fingerprint(ids);
            fingerprints.Add(fingerprint);
            previews.Add(new Dictionary<string, object?>
            {
                ["op"] = GetString(operation, "op"), ["target_count"] = ids.Count,
                ["sample_element_ids"] = ids.Take(20).Select(id => id.Value).ToArray(),
                ["target_fingerprint"] = fingerprint
            });
        }
        _operatorPreviews[confirmationHash] = Fingerprint(fingerprints);
        return JsonSerializer.Serialize(new Dictionary<string, object?>
        {
            ["schema"] = "artel.revit_operator_preview.v1", ["status"] = "preview",
            ["confirmation_hash"] = confirmationHash, ["operations"] = previews
        }, JsonOptions);
    }

    private string ExecuteOperator(UIApplication application, string planJson, string confirmationHash, bool bypassSafety)
    {
        EnsureConfirmed(planJson, confirmationHash);
        var uiDocument = application.ActiveUIDocument ?? throw new InvalidOperationException("Нет активного документа Revit.");
        var document = uiDocument.Document;
        using var plan = JsonDocument.Parse(planJson);
        EnsureOperatorSchema(plan.RootElement);
        var currentFingerprint = Fingerprint(GetArray(plan.RootElement, "operations")
            .Select(operation => Fingerprint(ResolveTargets(uiDocument, operation))));
        if (!bypassSafety)
        {
            if (!_operatorPreviews.TryGetValue(confirmationHash, out var previewFingerprint))
                throw new InvalidOperationException("Предохранитель: сначала получите предпросмотр точных целей действия.");
            if (!string.Equals(currentFingerprint, previewFingerprint, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException("Предохранитель: состав целей изменился после предпросмотра. Запросите план заново.");
        }
        var results = new List<Dictionary<string, object?>>();
        foreach (var operation in GetArray(plan.RootElement, "operations"))
        {
            var op = GetString(operation, "op");
            var ids = ResolveTargets(uiDocument, operation);
            if (op is "select_elements" or "select_category")
            {
                uiDocument.Selection.SetElementIds(ids);
                results.Add(Result(op, ids, "ok", $"Выбрано элементов: {ids.Count}."));
                continue;
            }
            if (op == "create_schedule")
            {
                var scheduleArguments = operation.GetProperty("arguments");
                var query = GetQuery(scheduleArguments);
                var categoryName = GetArray(query, "categories").Select(value => value.GetString() ?? "").FirstOrDefault()
                    ?? GetString(scheduleArguments, "category");
                var categoryElements = ids.Select(id => document.GetElement(id)).Where(element => element is not null).Cast<Element>().ToList();
                if (categoryElements.Count == 0) throw new InvalidOperationException($"Категория '{categoryName}' не найдена в активной модели.");
                var scheduleCategory = document.Settings.Categories.Cast<Category>()
                    .FirstOrDefault(candidate =>
                        string.Equals(candidate.Name, categoryName, StringComparison.OrdinalIgnoreCase)
                        && ViewSchedule.IsValidCategoryForSchedule(candidate.Id));
                if (scheduleCategory is null)
                    throw new InvalidOperationException($"Категория '{categoryName}' недоступна для обычной спецификации Revit.");
                var categoryId = scheduleCategory.Id;
                var requestedFields = GetArray(scheduleArguments, "fields").Select(value => value.GetString() ?? "")
                    .Where(value => !string.IsNullOrWhiteSpace(value)).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
                var requestedGroupBy = GetArray(scheduleArguments, "group_by").Select(value => value.GetString() ?? "")
                    .Where(value => !string.IsNullOrWhiteSpace(value)).Distinct(StringComparer.OrdinalIgnoreCase).ToList();
                var itemizeEveryInstance = !scheduleArguments.TryGetProperty("itemize_every_instance", out var itemizeNode)
                    || itemizeNode.ValueKind != JsonValueKind.False;
                var requestedFilters = GetArray(query, "parameter_filters").Select(value => new
                {
                    Field = GetString(value, "parameter"),
                    Operator = GetString(value, "operator"),
                    Value = GetString(value, "value")
                }).ToList();
                var requestedSystem = GetString(query, "system");
                var requestedFamily = GetString(query, "family");
                var requestedType = GetString(query, "type");
                using var scheduleTransaction = new Transaction(document, GetString(operation, "transaction", "ARTEL create schedule"));
                scheduleTransaction.Start();
                try
                {
                    var schedule = ViewSchedule.CreateSchedule(document, categoryId);
                    schedule.Name = UniqueViewName(document, GetString(scheduleArguments, "schedule_name", $"АРТЕЛЬ — {categoryName}"));
                    var schedulableFields = schedule.Definition.GetSchedulableFields();
                    var addedFields = new Dictionary<string, ScheduleField>(StringComparer.OrdinalIgnoreCase);
                    foreach (var requestedField in requestedFields)
                    {
                        var field = schedulableFields.FirstOrDefault(candidate =>
                            string.Equals(candidate.GetName(document), requestedField, StringComparison.OrdinalIgnoreCase));
                        if (field is null) throw new InvalidOperationException($"Поле '{requestedField}' недоступно для спецификации категории '{categoryName}'.");
                        addedFields[requestedField] = schedule.Definition.AddField(field);
                    }
                    foreach (var groupFieldName in requestedGroupBy)
                    {
                        if (!addedFields.TryGetValue(groupFieldName, out var groupField))
                            throw new InvalidOperationException($"Поле группировки '{groupFieldName}' отсутствует в полях спецификации.");
                        schedule.Definition.AddSortGroupField(new ScheduleSortGroupField(groupField.FieldId, ScheduleSortOrder.Ascending));
                    }
                    schedule.Definition.IsItemized = itemizeEveryInstance;
                    foreach (var requestedFilter in requestedFilters)
                    {
                        if (!addedFields.TryGetValue(requestedFilter.Field, out var scheduleField))
                        {
                            var field = schedulableFields.FirstOrDefault(candidate =>
                                string.Equals(candidate.GetName(document), requestedFilter.Field, StringComparison.OrdinalIgnoreCase));
                            if (field is null) throw new InvalidOperationException($"Поле фильтра '{requestedFilter.Field}' недоступно для спецификации категории '{categoryName}'.");
                            scheduleField = schedule.Definition.AddField(field);
                            addedFields[requestedFilter.Field] = scheduleField;
                        }
                        var filterType = requestedFilter.Operator.ToLowerInvariant() switch
                        {
                            "equal" => ScheduleFilterType.Equal,
                            "not_equal" => ScheduleFilterType.NotEqual,
                            "contains" => ScheduleFilterType.Contains,
                            "not_contains" => ScheduleFilterType.NotContains,
                            "begins_with" => ScheduleFilterType.BeginsWith,
                            "ends_with" => ScheduleFilterType.EndsWith,
                            "greater" => ScheduleFilterType.GreaterThan,
                            "greater_or_equal" => ScheduleFilterType.GreaterThanOrEqual,
                            "less" => ScheduleFilterType.LessThan,
                            "less_or_equal" => ScheduleFilterType.LessThanOrEqual,
                            _ => throw new InvalidOperationException($"Оператор фильтра '{requestedFilter.Operator}' не разрешён.")
                        };
                        schedule.Definition.AddFilter(BuildScheduleFilter(
                            document, categoryElements, scheduleField.FieldId, requestedFilter.Field,
                            filterType, requestedFilter.Value));
                    }
                    foreach (var builtInFilter in new[]
                    {
                        new { Value = requestedFamily, Parameter = BuiltInParameter.ELEM_FAMILY_PARAM, Label = "семейство" },
                        new { Value = requestedType, Parameter = BuiltInParameter.ELEM_TYPE_PARAM, Label = "тип" },
                        new { Value = requestedSystem, Parameter = BuiltInParameter.RBS_SYSTEM_NAME_PARAM, Label = "инженерная система" }
                    })
                    {
                        if (string.IsNullOrWhiteSpace(builtInFilter.Value)) continue;
                        var builtInField = schedulableFields.FirstOrDefault(candidate =>
                            candidate.ParameterId.Value == (long)builtInFilter.Parameter);
                        if (builtInField is null)
                            throw new InvalidOperationException($"Категория '{categoryName}' не предоставляет поле '{builtInFilter.Label}' для спецификации.");
                        var builtInFieldName = builtInField.GetName(document);
                        if (!addedFields.TryGetValue(builtInFieldName, out var addedBuiltInField))
                        {
                            addedBuiltInField = schedule.Definition.AddField(builtInField);
                            addedFields[builtInFieldName] = addedBuiltInField;
                        }
                        schedule.Definition.AddFilter(BuildScheduleFilter(
                            document, categoryElements, addedBuiltInField.FieldId, builtInFieldName,
                            ScheduleFilterType.Equal, builtInFilter.Value));
                    }
                    scheduleTransaction.Commit();
                    var filterParts = requestedFilters.Select(filter => $"{filter.Field} {filter.Operator} {filter.Value}").ToList();
                    if (!string.IsNullOrWhiteSpace(requestedFamily)) filterParts.Add($"family = {requestedFamily}");
                    if (!string.IsNullOrWhiteSpace(requestedType)) filterParts.Add($"type = {requestedType}");
                    if (!string.IsNullOrWhiteSpace(requestedSystem)) filterParts.Add($"system = {requestedSystem}");
                    var filterSummary = filterParts.Count == 0 ? "без фильтров" : "фильтры: " + string.Join(", ", filterParts);
                    results.Add(Result(op, new[] { schedule.Id }, "ok", $"Создана спецификация '{schedule.Name}' с полями: {string.Join(", ", addedFields.Keys)}; {filterSummary}."));
                }
                catch
                {
                    if (scheduleTransaction.HasStarted()) scheduleTransaction.RollBack();
                    throw;
                }
                continue;
            }
            if (op != "set_parameter") throw new InvalidOperationException($"Операция не входит в allowlist: {op}");
            var arguments = operation.GetProperty("arguments");
            var parameterName = GetString(arguments, "parameter");
            var value = GetString(arguments, "value");
            if (ids.Count == 0) throw new InvalidOperationException("Универсальный query не нашёл элементов для изменения параметра.");
            var parameterScope = GetString(arguments, "parameter_scope", "instance");
            using var transaction = new Transaction(document, GetString(operation, "transaction", "ARTEL set parameter"));
            transaction.Start();
            try
            {
                var changed = new List<ElementId>();
                foreach (var id in ids)
                {
                    var element = document.GetElement(id) ?? throw new InvalidOperationException($"Элемент {id.Value} не найден.");
                    var parameterOwner = string.Equals(parameterScope, "type", StringComparison.OrdinalIgnoreCase)
                        ? document.GetElement(element.GetTypeId()) ?? throw new InvalidOperationException($"Тип элемента {id.Value} не найден.")
                        : element;
                    if (changed.Contains(parameterOwner.Id)) continue;
                    var parameter = parameterOwner.LookupParameter(parameterName) ?? throw new InvalidOperationException($"Параметр '{parameterName}' не найден у элемента {parameterOwner.Id.Value}.");
                    if (parameter.IsReadOnly) throw new InvalidOperationException($"Параметр '{parameterName}' только для чтения.");
                    SetParameter(parameter, value);
                    changed.Add(parameterOwner.Id);
                }
                transaction.Commit();
                results.Add(Result(op, changed, "ok", $"Параметр '{parameterName}' изменён у {changed.Count} элементов."));
            }
            catch
            {
                if (transaction.HasStarted()) transaction.RollBack();
                throw;
            }
        }
        var report = new Dictionary<string, object?>
        {
            ["schema"] = "artel.revit_operator_result.v1",
            ["status"] = "pass",
            ["confirmation_hash"] = confirmationHash,
            ["safety_bypassed"] = bypassSafety,
            ["results"] = results,
            ["completed_at"] = DateTimeOffset.UtcNow.ToString("O")
        };
        var path = FamilyFactoryPaths.WriteJson("operator", report);
        report["report_path"] = path;
        _operatorPreviews.Remove(confirmationHash);
        return JsonSerializer.Serialize(report, JsonOptions);
    }

    private static void EnsureOperatorSchema(JsonElement plan)
    {
        var schema = GetString(plan, "schema");
        if (schema is not ("artel.revit_operator_plan.v1" or "artel.revit_operator_plan.v2" or "artel.revit_operator_plan.v3"))
            throw new InvalidOperationException("Неверная схема operator plan.");
    }

    private static JsonElement GetQuery(JsonElement arguments)
    {
        if (arguments.TryGetProperty("query", out var query) && query.ValueKind == JsonValueKind.Object) return query;
        return arguments;
    }

    private static List<ElementId> ResolveTargets(UIDocument uiDocument, JsonElement operation)
    {
        var document = uiDocument.Document;
        var explicitIds = GetArray(operation, "target_ids").Select(value => new ElementId(value.GetInt64())).ToList();
        var arguments = operation.TryGetProperty("arguments", out var argumentsNode) ? argumentsNode : default;
        var query = arguments.ValueKind == JsonValueKind.Object ? GetQuery(arguments) : default;
        var hasQuery = query.ValueKind == JsonValueKind.Object &&
            (query.TryGetProperty("scope", out _) || query.TryGetProperty("categories", out _) || query.TryGetProperty("category", out _));
        if (!hasQuery) return explicitIds;

        var scope = GetString(query, "scope", "model");
        IEnumerable<Element> candidates = scope switch
        {
            "selection" => uiDocument.Selection.GetElementIds().Select(document.GetElement).Where(element => element is not null).Cast<Element>(),
            "active_view" => new FilteredElementCollector(document, document.ActiveView.Id).WhereElementIsNotElementType().Cast<Element>(),
            "model" => new FilteredElementCollector(document).WhereElementIsNotElementType().Cast<Element>(),
            _ => throw new InvalidOperationException($"Неизвестная область query: {scope}")
        };
        var categories = new HashSet<string>(GetArray(query, "categories").Select(value => value.GetString() ?? "")
            .Where(value => !string.IsNullOrWhiteSpace(value)), StringComparer.OrdinalIgnoreCase);
        var legacyCategory = GetString(query, "category");
        if (!string.IsNullOrWhiteSpace(legacyCategory)) categories.Add(legacyCategory);
        var family = GetString(query, "family");
        var type = GetString(query, "type");
        var system = GetString(query, "system");
        var filters = GetArray(query, "parameter_filters").ToArray();
        var matched = new List<ElementId>();
        foreach (var element in candidates)
        {
            if (categories.Count > 0 && !categories.Contains(element.Category?.Name ?? "")) continue;
            var typeElement = document.GetElement(element.GetTypeId());
            var familyName = typeElement is ElementType elementType ? elementType.FamilyName : "";
            if (!MatchesText(familyName, family) || !MatchesText(typeElement?.Name ?? element.Name, type)) continue;
            if (!string.IsNullOrWhiteSpace(system))
            {
                var systemParameter = element.get_Parameter(BuiltInParameter.RBS_SYSTEM_NAME_PARAM);
                var actualSystem = systemParameter?.AsString() ?? systemParameter?.AsValueString() ?? "";
                if (!MatchesText(actualSystem, system)) continue;
            }
            if (filters.Any(filter => !MatchesParameterFilter(document, element, filter))) continue;
            matched.Add(element.Id);
            if (matched.Count > 100000) throw new InvalidOperationException("Query вернул больше 100000 элементов. Сузьте область или фильтры.");
        }
        return matched.Distinct().OrderBy(id => id.Value).ToList();
    }

    private static bool MatchesText(string actual, string requested) => string.IsNullOrWhiteSpace(requested)
        || ContainsText(actual, requested);

    private static bool ContainsText(string actual, string requested) =>
        actual.IndexOf(requested, StringComparison.OrdinalIgnoreCase) >= 0;

    private static bool MatchesParameterFilter(Document document, Element element, JsonElement filter)
    {
        var parameterName = GetString(filter, "parameter");
        var owner = string.Equals(GetString(filter, "scope", "instance"), "type", StringComparison.OrdinalIgnoreCase)
            ? document.GetElement(element.GetTypeId())
            : element;
        var parameter = owner?.LookupParameter(parameterName);
        var operation = GetString(filter, "operator").ToLowerInvariant();
        var hasValue = parameter is not null && parameter.HasValue && !string.IsNullOrWhiteSpace(ParameterText(document, parameter));
        if (operation == "has_value") return hasValue;
        if (operation == "not_has_value") return !hasValue;
        if (parameter is null) return false;
        var actual = ParameterText(document, parameter);
        var requested = GetString(filter, "value");
        return operation switch
        {
            "equal" => string.Equals(actual, requested, StringComparison.OrdinalIgnoreCase),
            "not_equal" => !string.Equals(actual, requested, StringComparison.OrdinalIgnoreCase),
            "contains" => ContainsText(actual, requested),
            "not_contains" => !ContainsText(actual, requested),
            "begins_with" => actual.StartsWith(requested, StringComparison.OrdinalIgnoreCase),
            "ends_with" => actual.EndsWith(requested, StringComparison.OrdinalIgnoreCase),
            "greater" => CompareNumbers(actual, requested) is double greater && greater > 0,
            "greater_or_equal" => CompareNumbers(actual, requested) is double greaterOrEqual && greaterOrEqual >= 0,
            "less" => CompareNumbers(actual, requested) is double less && less < 0,
            "less_or_equal" => CompareNumbers(actual, requested) is double lessOrEqual && lessOrEqual <= 0,
            _ => throw new InvalidOperationException($"Оператор query '{operation}' не разрешён.")
        };
    }

    private static string ParameterText(Document document, Parameter parameter)
    {
        var display = parameter.AsValueString();
        if (!string.IsNullOrWhiteSpace(display)) return display.Trim();
        return parameter.StorageType switch
        {
            StorageType.String => parameter.AsString() ?? "",
            StorageType.Integer => parameter.AsInteger().ToString(CultureInfo.InvariantCulture),
            StorageType.Double => parameter.AsDouble().ToString("G17", CultureInfo.InvariantCulture),
            StorageType.ElementId => document.GetElement(parameter.AsElementId())?.Name ?? parameter.AsElementId().Value.ToString(CultureInfo.InvariantCulture),
            _ => ""
        };
    }

    private static bool TryNumber(string text, out double value)
    {
        var match = Regex.Match(text ?? "", @"[-+]?\d+(?:[\.,]\d+)?");
        return double.TryParse(match.Value.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out value);
    }

    private static double? CompareNumbers(string actual, string requested) =>
        TryNumber(actual, out var left) && TryNumber(requested, out var right) ? left - right : null;

    private static string Fingerprint(IEnumerable<ElementId> ids) => Fingerprint(ids.Select(id => id.Value.ToString(CultureInfo.InvariantCulture)));

    private static string Fingerprint(IEnumerable<string> values) => Sha256(string.Join("|", values));

    private static string UniqueViewName(Document document, string requested)
    {
        var used = new HashSet<string>(new FilteredElementCollector(document).OfClass(typeof(View))
            .Cast<View>().Select(view => view.Name), StringComparer.OrdinalIgnoreCase);
        if (!used.Contains(requested)) return requested;
        for (var suffix = 2; suffix < 1000; suffix++)
        {
            var candidate = $"{requested} ({suffix})";
            if (!used.Contains(candidate)) return candidate;
        }
        throw new InvalidOperationException("Не удалось подобрать уникальное имя спецификации.");
    }

    private static ScheduleFilter BuildScheduleFilter(
        Document document,
        IReadOnlyCollection<Element> categoryElements,
        ScheduleFieldId fieldId,
        string fieldName,
        ScheduleFilterType filterType,
        string requestedValue)
    {
        var parameters = categoryElements.SelectMany(element =>
        {
            var owners = new List<Element> { element };
            var type = document.GetElement(element.GetTypeId());
            if (type is not null) owners.Add(type);
            return owners.Select(owner => owner.LookupParameter(fieldName)).Where(parameter => parameter is not null).Cast<Parameter>();
        }).ToList();
        var sample = parameters.FirstOrDefault();
        if (sample is null)
            throw new InvalidOperationException($"Параметр фильтра '{fieldName}' не найден у элементов категории.");
        if (sample.StorageType == StorageType.String)
            return new ScheduleFilter(fieldId, filterType, requestedValue);
        if (filterType is ScheduleFilterType.Contains or ScheduleFilterType.NotContains or ScheduleFilterType.BeginsWith or ScheduleFilterType.EndsWith)
            throw new InvalidOperationException($"Оператор {filterType} допустим только для текстового поля фильтра '{fieldName}'.");
        return sample.StorageType switch
        {
            StorageType.ElementId => new ScheduleFilter(fieldId, filterType, parameters.FirstOrDefault(parameter =>
                string.Equals(document.GetElement(parameter.AsElementId())?.Name ?? parameter.AsValueString(), requestedValue, StringComparison.OrdinalIgnoreCase))?.AsElementId()
                ?? throw new InvalidOperationException($"Значение '{requestedValue}' параметра '{fieldName}' не найдено в категории.")),
            StorageType.Integer => int.TryParse(requestedValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out var integer)
                ? new ScheduleFilter(fieldId, filterType, integer)
                : throw new InvalidOperationException($"Для фильтра '{fieldName}' ожидалось целое число."),
            StorageType.Double => TryNumber(requestedValue, out var number)
                ? new ScheduleFilter(fieldId, filterType, UnitUtils.ConvertToInternalUnits(number, sample.GetUnitTypeId()))
                : throw new InvalidOperationException($"Для фильтра '{fieldName}' ожидалось число."),
            _ => throw new InvalidOperationException($"Тип хранения {sample.StorageType} не поддержан для фильтра '{fieldName}'.")
        };
    }

    private static void SetParameter(Parameter parameter, string value)
    {
        switch (parameter.StorageType)
        {
            case StorageType.String:
                if (!parameter.Set(value)) throw new InvalidOperationException("Revit отклонил строковое значение.");
                return;
            case StorageType.Integer:
                if (!int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out var integer) || !parameter.Set(integer))
                    throw new InvalidOperationException("Ожидалось целое значение параметра.");
                return;
            case StorageType.Double:
                if (!double.TryParse(value.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out var number))
                    throw new InvalidOperationException("Ожидалось числовое значение параметра.");
                var internalValue = UnitUtils.ConvertToInternalUnits(number, parameter.GetUnitTypeId());
                if (!parameter.Set(internalValue)) throw new InvalidOperationException("Revit отклонил числовое значение.");
                return;
            default:
                throw new InvalidOperationException($"Тип хранения {parameter.StorageType} не входит в allowlist.");
        }
    }

    private static Dictionary<string, object?> Result(string op, IReadOnlyCollection<ElementId> ids, string status, string message) => new()
    {
        ["op"] = op, ["status"] = status, ["changed_element_ids"] = ids.Select(id => id.Value).ToArray(), ["message"] = message
    };

    private static void EnsureConfirmed(string payload, string expectedHash)
    {
        var actual = Sha256(payload);
        if (string.IsNullOrWhiteSpace(expectedHash) || !string.Equals(actual, expectedHash, StringComparison.OrdinalIgnoreCase))
            throw new InvalidOperationException("План изменился после подтверждения. Запросите новый план и подтвердите его заново.");
    }

    private static IEnumerable<JsonElement> GetArray(JsonElement element, string name)
    {
        if (!element.TryGetProperty(name, out var value) || value.ValueKind != JsonValueKind.Array) return Array.Empty<JsonElement>();
        return value.EnumerateArray().ToArray();
    }

    private static string GetString(JsonElement element, string name, string fallback = "") =>
        element.TryGetProperty(name, out var value) && value.ValueKind == JsonValueKind.String ? value.GetString() ?? fallback : fallback;

    private static string Sha256(string value)
    {
        using var sha = SHA256.Create();
        return BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(value))).Replace("-", "").ToLowerInvariant();
    }

    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    private sealed class ArtelEventRequest
    {
        internal ArtelEventRequest(string kind, string payload, string confirmationHash, bool bypassSafety, TaskCompletionSource<string> completion)
        {
            Kind = kind;
            Payload = payload;
            ConfirmationHash = confirmationHash;
            BypassSafety = bypassSafety;
            Completion = completion;
        }

        internal string Kind { get; }
        internal string Payload { get; }
        internal string ConfirmationHash { get; }
        internal bool BypassSafety { get; }
        internal TaskCompletionSource<string> Completion { get; }
    }
}

internal static class ArtelModelReader
{
    internal static List<Dictionary<string, object?>> ReadParameters(Element element, int limit)
    {
        return element.Parameters.Cast<Parameter>()
            .Where(parameter => parameter.Definition is not null && parameter.HasValue)
            .GroupBy(parameter => parameter.Definition.Name, StringComparer.OrdinalIgnoreCase)
            .Select(group => group.First())
            .OrderBy(parameter => parameter.Definition.Name)
            .Take(limit)
            .Select(parameter => new Dictionary<string, object?>
            {
                ["name"] = parameter.Definition.Name,
                ["storage_type"] = parameter.StorageType.ToString(),
                ["value"] = ParameterValue(parameter),
                ["display_value"] = parameter.AsValueString() ?? "",
                ["is_read_only"] = parameter.IsReadOnly
            })
            .ToList();
    }

    internal static List<Dictionary<string, object?>> QuantitySummary(Document document)
    {
        var groups = new Dictionary<string, QuantityGroup>(StringComparer.OrdinalIgnoreCase);
        foreach (var element in new FilteredElementCollector(document).WhereElementIsNotElementType())
        {
            var category = element.Category?.Name;
            if (string.IsNullOrWhiteSpace(category)) continue;
            if (!groups.TryGetValue(category!, out var group))
            {
                group = new QuantityGroup();
                groups[category!] = group;
            }
            group.Count++;
            group.VolumeInternal += FirstDouble(element, BuiltInParameter.HOST_VOLUME_COMPUTED, BuiltInParameter.ROOM_VOLUME);
            group.AreaInternal += FirstDouble(element, BuiltInParameter.HOST_AREA_COMPUTED, BuiltInParameter.ROOM_AREA);
            group.LengthInternal += FirstDouble(element, BuiltInParameter.CURVE_ELEM_LENGTH, BuiltInParameter.INSTANCE_LENGTH_PARAM);
        }
        return groups
            .OrderByDescending(pair => pair.Value.Count)
            .ThenBy(pair => pair.Key)
            .Take(100)
            .Select(pair => new Dictionary<string, object?>
            {
                ["category"] = pair.Key,
                ["count"] = pair.Value.Count,
                ["volume_m3"] = Math.Round(UnitUtils.ConvertFromInternalUnits(pair.Value.VolumeInternal, UnitTypeId.CubicMeters), 6),
                ["area_m2"] = Math.Round(UnitUtils.ConvertFromInternalUnits(pair.Value.AreaInternal, UnitTypeId.SquareMeters), 6),
                ["length_m"] = Math.Round(UnitUtils.ConvertFromInternalUnits(pair.Value.LengthInternal, UnitTypeId.Meters), 6),
                ["computed_by"] = "Revit API built-in quantity parameters"
            })
            .ToList();
    }

    internal static List<Dictionary<string, object?>> InventorySummary(Document document)
    {
        var groups = new Dictionary<string, InventoryGroup>(StringComparer.OrdinalIgnoreCase);
        foreach (var element in new FilteredElementCollector(document).WhereElementIsNotElementType())
        {
            var category = element.Category?.Name;
            if (string.IsNullOrWhiteSpace(category)) continue;
            var type = document.GetElement(element.GetTypeId());
            var family = element is FamilyInstance instance ? instance.Symbol?.FamilyName ?? "" : "";
            var typeName = type?.Name ?? element.Name ?? "";
            var key = category + "\u001f" + family + "\u001f" + typeName;
            if (!groups.TryGetValue(key, out var group))
            {
                group = new InventoryGroup(category!, family, typeName);
                groups[key] = group;
            }
            group.Count++;
            group.VolumeInternal += FirstDouble(element, BuiltInParameter.HOST_VOLUME_COMPUTED, BuiltInParameter.ROOM_VOLUME);
            group.AreaInternal += FirstDouble(element, BuiltInParameter.HOST_AREA_COMPUTED, BuiltInParameter.ROOM_AREA);
            group.LengthInternal += FirstDouble(element, BuiltInParameter.CURVE_ELEM_LENGTH, BuiltInParameter.INSTANCE_LENGTH_PARAM);
        }
        return groups.Values.OrderBy(group => group.Category).ThenBy(group => group.Family).ThenBy(group => group.Type).Take(2000)
            .Select(group => new Dictionary<string, object?>
            {
                ["category"] = group.Category, ["family"] = group.Family, ["type"] = group.Type, ["count"] = group.Count,
                ["volume_m3"] = Math.Round(UnitUtils.ConvertFromInternalUnits(group.VolumeInternal, UnitTypeId.CubicMeters), 6),
                ["area_m2"] = Math.Round(UnitUtils.ConvertFromInternalUnits(group.AreaInternal, UnitTypeId.SquareMeters), 6),
                ["length_m"] = Math.Round(UnitUtils.ConvertFromInternalUnits(group.LengthInternal, UnitTypeId.Meters), 6),
                ["computed_by"] = "Revit API type inventory"
            }).ToList();
    }

    internal static List<Dictionary<string, object?>> SystemQuantitySummary(Document document)
    {
        var groups = new Dictionary<string, SystemQuantityGroup>(StringComparer.OrdinalIgnoreCase);
        foreach (var element in new FilteredElementCollector(document).WhereElementIsNotElementType())
        {
            var category = element.Category?.Name;
            var system = SystemName(element);
            if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(system)) continue;
            var key = category + "\u001f" + system;
            if (!groups.TryGetValue(key, out var group))
            {
                group = new SystemQuantityGroup(category!, system);
                groups[key] = group;
            }
            group.Count++;
            group.VolumeInternal += FirstDouble(element, BuiltInParameter.HOST_VOLUME_COMPUTED, BuiltInParameter.ROOM_VOLUME);
            group.AreaInternal += FirstDouble(element, BuiltInParameter.HOST_AREA_COMPUTED, BuiltInParameter.ROOM_AREA);
            group.LengthInternal += FirstDouble(element, BuiltInParameter.CURVE_ELEM_LENGTH, BuiltInParameter.INSTANCE_LENGTH_PARAM);
        }
        return groups.Values.OrderBy(group => group.Category).ThenBy(group => group.System).Take(1000)
            .Select(group => new Dictionary<string, object?>
            {
                ["category"] = group.Category, ["system"] = group.System, ["count"] = group.Count,
                ["volume_m3"] = Math.Round(UnitUtils.ConvertFromInternalUnits(group.VolumeInternal, UnitTypeId.CubicMeters), 6),
                ["area_m2"] = Math.Round(UnitUtils.ConvertFromInternalUnits(group.AreaInternal, UnitTypeId.SquareMeters), 6),
                ["length_m"] = Math.Round(UnitUtils.ConvertFromInternalUnits(group.LengthInternal, UnitTypeId.Meters), 6),
                ["computed_by"] = "Revit API system quantity summary"
            }).ToList();
    }

    internal static List<Dictionary<string, object?>> ParameterCatalog(Document document)
    {
        return new FilteredElementCollector(document).WhereElementIsNotElementType()
            .Where(element => !string.IsNullOrWhiteSpace(element.Category?.Name))
            .GroupBy(element => element.Category!.Name, StringComparer.OrdinalIgnoreCase)
            .OrderBy(group => group.Key).Take(200)
            .Select(group =>
            {
                var element = group.First();
                var type = document.GetElement(element.GetTypeId());
                return new Dictionary<string, object?>
                {
                    ["category"] = group.Key,
                    ["instance_parameters"] = ReadParameters(element, 300),
                    ["type_parameters"] = type is null ? new List<Dictionary<string, object?>>() : ReadParameters(type, 300)
                };
            }).ToList();
    }

    private static string SystemName(Element element)
    {
        var parameter = element.get_Parameter(BuiltInParameter.RBS_SYSTEM_NAME_PARAM);
        return parameter?.AsString()?.Trim() ?? parameter?.AsValueString()?.Trim() ?? "";
    }

    private static object? ParameterValue(Parameter parameter) => parameter.StorageType switch
    {
        StorageType.String => parameter.AsString(),
        StorageType.Integer => parameter.AsInteger(),
        StorageType.Double => parameter.AsDouble(),
        StorageType.ElementId => parameter.AsElementId().Value,
        _ => null
    };

    private static double FirstDouble(Element element, params BuiltInParameter[] candidates)
    {
        foreach (var candidate in candidates)
        {
            var parameter = element.get_Parameter(candidate);
            if (parameter is not null && parameter.HasValue && parameter.StorageType == StorageType.Double)
                return parameter.AsDouble();
        }
        return 0;
    }

    private sealed class QuantityGroup
    {
        internal int Count { get; set; }
        internal double VolumeInternal { get; set; }
        internal double AreaInternal { get; set; }
        internal double LengthInternal { get; set; }
    }

    private sealed class InventoryGroup
    {
        internal InventoryGroup(string category, string family, string type) { Category = category; Family = family; Type = type; }
        internal string Category { get; }
        internal string Family { get; }
        internal string Type { get; }
        internal int Count { get; set; }
        internal double VolumeInternal { get; set; }
        internal double AreaInternal { get; set; }
        internal double LengthInternal { get; set; }
    }

    private sealed class SystemQuantityGroup
    {
        internal SystemQuantityGroup(string category, string system) { Category = category; System = system; }
        internal string Category { get; }
        internal string System { get; }
        internal int Count { get; set; }
        internal double VolumeInternal { get; set; }
        internal double AreaInternal { get; set; }
        internal double LengthInternal { get; set; }
    }
}
