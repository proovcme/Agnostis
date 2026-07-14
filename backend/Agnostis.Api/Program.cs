using System.Collections.Concurrent;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin();
    });
});
builder.Services.AddHttpClient();

var app = builder.Build();

app.UseCors();

var appRoot = ResolveAppRoot(app.Environment.ContentRootPath);
if (Directory.Exists(appRoot))
{
    app.UseDefaultFiles(new DefaultFilesOptions
    {
        FileProvider = new PhysicalFileProvider(appRoot)
    });
    app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(appRoot)
    });
}

var store = SeedData.Create();
var validationReportArchive = ValidationReportArchive.FromConfiguration(builder.Configuration, app.Environment.ContentRootPath);
validationReportArchive.LoadInto(store.ValidationReports);

app.MapArtelWorkflow();

app.MapGet("/health", () => Results.Ok(new HealthResponse("ok", DateTimeOffset.UtcNow)));

app.MapGet("/api/integrations/model/status", () =>
{
    var stateRoot = Environment.GetEnvironmentVariable("ARTEL_STATE_ROOT")
        ?? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ARTEL");
    var statusPath = Path.Combine(stateRoot, "logs", "runtime-status.json");
    if (!File.Exists(statusPath))
    {
        return Results.Ok(new
        {
            status = "unknown",
            model = Environment.GetEnvironmentVariable("OLLAMA_MODEL") ?? "qwen3.5:9b",
            message = "Проверка Ollama ещё не выполнялась"
        });
    }
    try
    {
        return Results.Content(File.ReadAllText(statusPath), "application/json");
    }
    catch (IOException error)
    {
        return Results.Ok(new { status = "error", message = error.Message });
    }
});

app.MapPost("/api/assistant/live", async (
    ArtelLiveAssistantRequest input,
    IHttpClientFactory httpClientFactory,
    IConfiguration configuration) =>
{
    if (string.IsNullOrWhiteSpace(input.Question))
        return Results.BadRequest(ApiError.Create("question_required", "Question is required."));

    var ollamaBaseUrl = (configuration["Ollama:BaseUrl"]
        ?? Environment.GetEnvironmentVariable("OLLAMA_BASE_URL")
        ?? "http://127.0.0.1:11434").TrimEnd('/');
    var model = configuration["Ollama:Model"]
        ?? Environment.GetEnvironmentVariable("OLLAMA_MODEL")
        ?? "qwen3.5:9b";
    var messages = input.Conversation as JsonArray ?? new JsonArray
    {
        new JsonObject
        {
            ["role"] = "system",
            ["content"] = LiveAssistantSystemPrompt(app.Environment.ContentRootPath)
        },
        new JsonObject { ["role"] = "user", ["content"] = input.Question.Trim() }
    };
    var hasLiveRevitEvidence = input.ToolResult is JsonObject suppliedResult
        && string.Equals(NodeText(suppliedResult["tool_name"]), "query_revit", StringComparison.OrdinalIgnoreCase);
    if (input.ToolResult is JsonObject previousResult)
    {
        messages.Add(new JsonObject
        {
            ["role"] = "tool",
            ["tool_name"] = NodeText(previousResult["tool_name"]),
            ["content"] = ModelJson(previousResult["result"])
        });
    }

    using var client = httpClientFactory.CreateClient();
    client.Timeout = TimeSpan.FromMinutes(3);
    for (var internalRound = 0; internalRound < 4; internalRound++)
    {
        using var response = await client.PostAsJsonAsync($"{ollamaBaseUrl}/api/chat", new JsonObject
        {
            ["model"] = model,
            ["stream"] = false,
            ["think"] = false,
            ["messages"] = messages.DeepClone(),
            ["tools"] = LiveAssistantTools()
        });
        var body = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode)
            return Results.Json(new { status = "model_error", model, message = body }, statusCode: 503);
        var assistantMessage = TryParseJson(body)?["message"] as JsonObject;
        if (assistantMessage is null)
            return Results.Json(new { status = "model_error", model, message = "Ollama returned no assistant message" }, statusCode: 503);
        messages.Add(assistantMessage.DeepClone());
        var calls = assistantMessage["tool_calls"] as JsonArray ?? new JsonArray();
        if (calls.Count == 0)
        {
            messages.Add(new JsonObject
            {
                ["role"] = "user",
                ["content"] = hasLiveRevitEvidence
                    ? "Не завершай агентный ход обещанием или обычным текстом. Явно выбери следующий шаг инструментом: query_revit для дополнительных фактов, prepare_revit_action для действия или finish_revit_response для окончательного read-only ответа."
                    : "У тебя ещё нет фактов активного Revit. Вызови query_revit; не отвечай по памяти и не делай вывод об отсутствии элементов."
            });
            continue;
        }

        var function = calls[0]?["function"] as JsonObject;
        var toolName = NodeText(function?["name"]);
        var arguments = ToolArguments(function?["arguments"]);
        if (toolName == "query_revit")
        {
            return Results.Ok(new
            {
                status = "tool_request",
                model,
                conversation = messages,
                toolRequest = new { tool_name = toolName, arguments }
            });
        }
        if (toolName == "search_artel_index")
        {
            var searchInput = new ArtelAssistantRequest(input.Question, input.DatasetFilter, input.TopK, "chat", null);
            var evidence = await SearchAssistantEvidenceAsync(
                httpClientFactory, configuration, searchInput,
                NodeText(arguments?["query"], input.Question.Trim()));
            messages.Add(new JsonObject
            {
                ["role"] = "tool", ["tool_name"] = toolName,
                ["content"] = ModelJson(evidence ?? new JsonObject { ["status"] = "unavailable" })
            });
            continue;
        }
        if (toolName == "prepare_revit_action")
        {
            if (!hasLiveRevitEvidence)
            {
                messages.Add(new JsonObject
                {
                    ["role"] = "tool", ["tool_name"] = toolName,
                    ["content"] = ModelJson(new JsonObject { ["status"] = "blocked", ["message"] = "Call query_revit before preparing an action" })
                });
                continue;
            }
            var action = PrepareLiveRevitAction(arguments);
            messages.Add(new JsonObject
            {
                ["role"] = "tool", ["tool_name"] = toolName,
                ["content"] = ModelJson(action)
            });
            if (NodeText(action["status"]) != "ready")
            {
                messages.Add(new JsonObject
                {
                    ["role"] = "user",
                    ["content"] = "Исправь аргументы prepare_revit_action по сообщению инструмента. Не подменяй действие текстовым обещанием и не проси код выбрать поля за тебя."
                });
                continue;
            }
            return Results.Ok(new
            {
                status = "complete",
                model,
                answer = NodeText(action["message"], NodeText(action["summary"], "План действия подготовлен.")),
                action
            });
        }
        if (toolName == "finish_revit_response")
        {
            if (!hasLiveRevitEvidence)
            {
                messages.Add(new JsonObject
                {
                    ["role"] = "tool", ["tool_name"] = toolName,
                    ["content"] = ModelJson(new JsonObject { ["status"] = "blocked", ["message"] = "Call query_revit before finishing the response" })
                });
                continue;
            }
            var answer = NodeText(arguments?["answer"]);
            if (string.IsNullOrWhiteSpace(answer))
            {
                messages.Add(new JsonObject
                {
                    ["role"] = "tool", ["tool_name"] = toolName,
                    ["content"] = ModelJson(new JsonObject { ["status"] = "blocked", ["message"] = "A non-empty final answer is required" })
                });
                continue;
            }
            return Results.Ok(new { status = "complete", model, answer, action = (JsonNode?)null });
        }
        messages.Add(new JsonObject
        {
            ["role"] = "tool", ["tool_name"] = toolName,
            ["content"] = ModelJson(new JsonObject { ["status"] = "blocked", ["message"] = $"Unknown tool: {toolName}" })
        });
    }
    return Results.Json(new { status = "model_error", model, message = "Agent exceeded internal tool rounds" }, statusCode: 503);
});

app.MapPost("/api/assistant", () => Results.Json(
    new { status = "gone", message = "Snapshot BIM chat is disabled; use /api/assistant/live." },
    statusCode: StatusCodes.Status410Gone));

app.MapPost("/api/assistant/snapshot-legacy-disabled", async (
    ArtelAssistantRequest input,
    IHttpClientFactory httpClientFactory,
    IConfiguration configuration) =>
{
    if (string.IsNullOrWhiteSpace(input.Question))
    {
        return Results.BadRequest(ApiError.Create("question_required", "Question is required."));
    }

    JsonNode? evidence = null;
    JsonObject? pendingAction = null;
    var ollamaBaseUrl = (configuration["Ollama:BaseUrl"]
        ?? Environment.GetEnvironmentVariable("OLLAMA_BASE_URL")
        ?? "http://127.0.0.1:11434").TrimEnd('/');
    var model = configuration["Ollama:Model"]
        ?? Environment.GetEnvironmentVariable("OLLAMA_MODEL")
        ?? "qwen3.5:9b";
    var modeRule = input.Mode switch
    {
        "generator" => "Сформируй спецификацию семейства и проверяемый action plan; не подменяй детерминированный исполнитель.",
        "operator" => "Дай только план Revit API действий с рисками, ожидаемым результатом и точкой подтверждения. Не утверждай, что изменения уже выполнены.",
        "export" => "Помоги определить минимальный состав BIM-данных для экспорта и явно перечисли, что попадёт в LES.",
        _ => "Отвечай как BIM-чат по всей активной модели и справка по Revit. Сначала вызови inspect_revit_model, затем выбери подходящий query tool. search_artel_index вызывай только когда действительно нужна справка. Не своди чат только к семействам."
    };
    var systemPrompt =
        "Ты АРТЕЛЬ, BIM-помощник по всей активной модели Autodesk Revit и отдельный эксперт по генерации семейств. " +
        "inspect_revit_model показывает компактный состав открытой модели. query_revit_quantities выполняет выбранный тобой запрос по метрике, категории и инженерной системе. query_revit_inventory читает состав семейств и типов. search_artel_index содержит только справку Revit API/FOP и никогда не является источником фактов модели. " +
        "Для смешанного вопроса можно вызвать несколько tools. Не отвечай о модели до вызова Revit tools и не отвечай точным API-фактом без search_artel_index. " +
        "Сохраняй предмет вопроса; не заменяй его соседним объектом из результата другого инструмента. " +
        "На вопрос о количестве, длине, площади или объёме сама выбери metric и фильтры query_revit_quantities. Если вопрос ограничен инженерной системой, обязательно передай system из результата inspect_revit_model. Если нужного scope нет, так и скажи. Никогда не выводи пользователю сырой JSON или escaped Unicode из tool result. " +
        "Для параметров вызови query_revit_parameters и различай instance/type. Если пользователь просит выделить элементы, создать спецификацию или изменить параметр, это команда: вызови prepare_revit_action, а не описывай результат как уже выполненный. Сначала собери универсальный query: scope=model|active_view|selection, точные categories, family, type, system и parameter_filters. Один и тот же query обязан определять цели выделения, спецификации и изменения параметров. Для спецификации и изменения параметра сначала прочитай параметры; выбирай только реально доступное поле и правильный parameter_scope. Не теряй условия пользователя и не переноси их только в название спецификации. Если запрос неоднозначен, задай уточнение. " +
        "Не выдумывай GUID, параметры, нормы, числа или API symbols. Если результатов недостаточно, явно скажи, чего не хватает. " +
        "Модель принимает профессиональное решение; код только исполняет выбранные read-only tools и передаёт их результат. " +
        "Оформляй ответ аккуратным Markdown: короткие секции, списки и таблицы для количеств. " + modeRule;
    if (string.Equals(input.Mode, "operator", StringComparison.OrdinalIgnoreCase))
    {
        systemPrompt += "\n\nRuntime skill:\n" + LoadOperatorSkill(app.Environment.ContentRootPath);
    }
    var messages = new JsonArray
    {
        new JsonObject { ["role"] = "system", ["content"] = systemPrompt },
        new JsonObject { ["role"] = "user", ["content"] = input.Question.Trim() }
    };
    var tools = AssistantTools(input.Context);

    using var ollamaClient = httpClientFactory.CreateClient();
    ollamaClient.Timeout = TimeSpan.FromMinutes(3);
    try
    {
        var readContextUsed = false;
        var toolContractRetryIssued = false;
        var answer = "";
        var queryResults = new JsonArray();
        for (var round = 0; round < 5; round++)
        {
            using var ollamaResponse = await ollamaClient.PostAsJsonAsync($"{ollamaBaseUrl}/api/chat", new JsonObject
            {
                ["model"] = model, ["stream"] = false, ["think"] = false,
                ["messages"] = messages.DeepClone(), ["tools"] = tools.DeepClone()
            });
            var ollamaBody = await ollamaResponse.Content.ReadAsStringAsync();
            if (!ollamaResponse.IsSuccessStatusCode)
                return Results.Json(new { status = "model_error", model, message = ollamaBody, evidence }, statusCode: 503);
            var assistantMessage = TryParseJson(ollamaBody)?["message"] as JsonObject;
            var toolCalls = assistantMessage?["tool_calls"] as JsonArray ?? new JsonArray();
            if (assistantMessage is not null) messages.Add(assistantMessage.DeepClone());
            if (toolCalls.Count == 0)
            {
                if (!readContextUsed && evidence is null && !toolContractRetryIssued)
                {
                    toolContractRetryIssued = true;
                    messages.Add(new JsonObject
                    {
                        ["role"] = "user",
                        ["content"] = "Ты ответила без инструментов и поэтому не можешь знать состояние Revit или выполнить команду. Продолжи тот же запрос: сначала вызови inspect_revit_model, затем нужный query/action tool. Не пиши пользователю второй ответ до tool result."
                    });
                    continue;
                }
                answer = assistantMessage?["content"]?.GetValue<string>() ?? "";
                break;
            }
            foreach (var callNode in toolCalls)
            {
                var function = callNode?["function"] as JsonObject;
                var toolName = function?["name"]?.GetValue<string>() ?? "";
                var arguments = ToolArguments(function?["arguments"]);
                JsonNode toolResult;
                if (toolName == "inspect_revit_model")
                {
                    readContextUsed = true;
                    toolResult = CompactRevitContext(input.Context);
                }
                else if (toolName == "query_revit_quantities")
                {
                    readContextUsed = true;
                    toolResult = QueryRevitQuantities(input.Context, arguments);
                    queryResults.Add(toolResult.DeepClone());
                }
                else if (toolName == "query_revit_inventory")
                {
                    readContextUsed = true;
                    toolResult = QueryRevitInventory(input.Context, arguments);
                    queryResults.Add(toolResult.DeepClone());
                }
                else if (toolName == "query_revit_parameters")
                {
                    readContextUsed = true;
                    toolResult = QueryRevitParameters(input.Context, arguments);
                    queryResults.Add(toolResult.DeepClone());
                }
                else if (toolName == "prepare_revit_action")
                {
                    readContextUsed = true;
                    pendingAction = PrepareRevitAction(input.Context, arguments);
                    toolResult = pendingAction.DeepClone();
                }
                else if (toolName == "search_artel_index")
                {
                    var query = arguments?["query"]?.GetValue<string>() ?? input.Question.Trim();
                    evidence = await SearchAssistantEvidenceAsync(httpClientFactory, configuration, input, query);
                    toolResult = evidence?.DeepClone() ?? new JsonObject { ["status"] = "unavailable" };
                }
                else toolResult = new JsonObject { ["status"] = "blocked", ["message"] = $"Unknown tool: {toolName}" };
                messages.Add(new JsonObject { ["role"] = "tool", ["tool_name"] = toolName, ["content"] = ModelJson(toolResult) });
            }
        }
        if (string.IsNullOrWhiteSpace(answer))
        {
            using var finalResponse = await ollamaClient.PostAsJsonAsync($"{ollamaBaseUrl}/api/chat", new JsonObject
            {
                ["model"] = model, ["stream"] = false, ["think"] = false, ["messages"] = messages.DeepClone()
            });
            var finalBody = await finalResponse.Content.ReadAsStringAsync();
            if (!finalResponse.IsSuccessStatusCode)
                return Results.Json(new { status = "model_error", model, message = finalBody, evidence }, statusCode: 503);
            answer = TryParseJson(finalBody)?["message"]?["content"]?.GetValue<string>() ?? "";
        }
        if (!string.Equals(NodeText(pendingAction?["status"]), "ready", StringComparison.OrdinalIgnoreCase))
        {
            var actionArbitrationPrompt = $$"""
                Ты диспетчер действий Revit. Определи только по исходной реплике пользователя,
                просит ли он выполнить действие в активном документе. Это профессиональное решение модели,
                не подмена кодом. Верни один JSON без Markdown:
                {"operation":"none|select_elements|create_schedule|set_parameter","query":{"scope":"model|active_view|selection","categories":["точное имя"],"family":"","type":"","system":"","parameter_filters":[{"parameter":"точное имя","scope":"instance|type","operator":"equal|not_equal|contains|not_contains|begins_with|ends_with|greater|greater_or_equal|less|less_or_equal|has_value|not_has_value","value":""}]},"schedule_name":"","fields":[],"group_by":[],"itemize_every_instance":true,"parameter":"","value":"","parameter_scope":"instance|type"}
                `select_elements` — просьба выделить элементы; `create_schedule` — создать спецификацию;
                `set_parameter` — изменить значение параметра. Вопросы, подсчёты, справка и просмотр = `none`.
                Не выдумывай категорию: используй только точное имя из manifest. Все ограничения переноси
                в query; условие вида «по типу системы X» перенеси в query.system либо parameter_filters.
                `fields` и `group_by` — только массивы строк, не объекты. Для просьбы свести или сгруппировать
                спецификацию перенеси выбранные поля группировки в `group_by` и установи
                `itemize_every_instance=false`. Имена в fields, group_by, parameter_filters.parameter и parameter
                обязаны буквально совпадать с одним из `name` в typed parameter catalog; запрещено
                возвращать Name, System или иной перевод, если такой строки в каталоге нет.
                Если данных недостаточно, оставь массив/строку пустыми — executor вернёт MISSING.

                Реплика: {{input.Question.Trim()}}
                Manifest активной модели: {{ModelJson(CompactRevitContext(input.Context))}}
                Typed parameter catalog: {{ModelJson(input.Context?["parameter_catalog"])}}
                Предыдущая ошибка action validation: {{NodeText(pendingAction?["message"], "tool action was not produced")}}
                """;
            using var arbitrationResponse = await ollamaClient.PostAsJsonAsync($"{ollamaBaseUrl}/api/chat", new JsonObject
            {
                ["model"] = model, ["stream"] = false, ["think"] = false, ["format"] = "json",
                ["messages"] = new JsonArray(new JsonObject { ["role"] = "user", ["content"] = actionArbitrationPrompt })
            });
            if (arbitrationResponse.IsSuccessStatusCode)
            {
                var arbitrationBody = await arbitrationResponse.Content.ReadAsStringAsync();
                var decisionText = TryParseJson(arbitrationBody)?["message"]?["content"]?.GetValue<string>() ?? "";
                var decision = TryParseJson(decisionText) as JsonObject;
                if (NodeText(decision?["operation"]) is string operation && !string.IsNullOrWhiteSpace(operation) && operation != "none")
                    pendingAction = PrepareRevitAction(input.Context, decision);
            }
        }
        if (readContextUsed
            && !string.IsNullOrWhiteSpace(answer)
            && !string.Equals(NodeText(pendingAction?["status"]), "ready", StringComparison.OrdinalIgnoreCase))
        {
            var auditPrompt = $$"""
                Ты строгий редактор BIM-ответа. Перечитай вопрос, typed Revit tool result и черновик.
                Оставь только прямой ответ на заданный предмет и метрику. Любое число, категория и название
                должны буквально подтверждаться typed Revit tool result. ARTEL Index и справка Revit API
                не подтверждают факты открытой модели. Удали согласие с пользователем, рассуждения о JSON,
                соседние категории, энергопотребление, нагрузки и гипотезы о параметрах или геометрии.
                Если требуемой категории или метрики нет, одной фразой честно сообщи, что она не найдена
                в снимке открытой модели. Верни только короткий исправленный Markdown-ответ.

                Вопрос: {{input.Question.Trim()}}
                Результаты выбранных Revit queries: {{ModelJson(queryResults)}}
                Черновик модели: {{answer}}
                """;
            using var auditResponse = await ollamaClient.PostAsJsonAsync($"{ollamaBaseUrl}/api/chat", new
            {
                model, stream = false, think = false,
                messages = new object[] { new { role = "user", content = auditPrompt } }
            });
            var auditBody = await auditResponse.Content.ReadAsStringAsync();
            if (auditResponse.IsSuccessStatusCode)
                answer = TryParseJson(auditBody)?["message"]?["content"]?.GetValue<string>() ?? answer;
        }
        return Results.Ok(new
        {
            status = "ok",
            model,
            datasetFilter = string.IsNullOrWhiteSpace(input.DatasetFilter) ? "ARTEL" : input.DatasetFilter,
            answer,
            evidence,
            action = pendingAction
        });
    }
    catch (Exception error) when (error is HttpRequestException or TaskCanceledException)
    {
        return Results.Json(new
        {
            status = "model_unavailable",
            model,
            message = "Ollama не отвечает. Проверьте установку, сервис и наличие модели.",
            detail = error.GetType().Name,
            evidence
        }, statusCode: 503);
    }
});

app.MapPost("/api/integrations/les/export", async (
    JsonNode payload,
    IHttpClientFactory httpClientFactory,
    IConfiguration configuration) =>
{
    var options = LesOptions.FromConfiguration(configuration);
    const string exportDataset = "ARTEL_BIM_Index";
    var title = payload["document_title"]?.GetValue<string>()
        ?? payload["family_name"]?.GetValue<string>()
        ?? "revit-export";
    var safeTitle = string.Concat(title.Select(character =>
        char.IsLetterOrDigit(character) || character is '-' or '_' ? character : '_')).Trim('_');
    if (string.IsNullOrWhiteSpace(safeTitle)) safeTitle = "revit-export";

    using var client = httpClientFactory.CreateClient();
    client.Timeout = TimeSpan.FromSeconds(options.TimeoutSeconds);
    string? exportDatasetId = null;
    using (var listRequest = CreateLesRequest(HttpMethod.Get, options, "/api/rag/datasets"))
    using (var listResponse = await client.SendAsync(listRequest))
    {
        var datasets = TryParseJson(await listResponse.Content.ReadAsStringAsync()) as JsonArray;
        exportDatasetId = datasets?
            .FirstOrDefault(item => string.Equals(item?["name"]?.GetValue<string>(), exportDataset, StringComparison.OrdinalIgnoreCase))?["id"]?
            .GetValue<string>();
    }
    if (string.IsNullOrWhiteSpace(exportDatasetId))
    {
        using var createRequest = CreateLesRequest(HttpMethod.Post, options, $"/api/rag/datasets?name={Uri.EscapeDataString(exportDataset)}");
        using var createResponse = await client.SendAsync(createRequest);
        var created = TryParseJson(await createResponse.Content.ReadAsStringAsync());
        exportDatasetId = created?["id"]?.GetValue<string>();
        if (!createResponse.IsSuccessStatusCode || string.IsNullOrWhiteSpace(exportDatasetId))
        {
            return Results.Json(new { status = "rejected", dataset = exportDataset, message = "Не удалось создать рабочий BIM-датасет в ЛЕС." }, statusCode: 502);
        }
    }
    using var request = CreateLesRequest(HttpMethod.Post, options, $"/api/rag/upload/{exportDatasetId}");
    using var multipart = new MultipartFormDataContent();
    var json = payload.ToJsonString(new JsonSerializerOptions { WriteIndented = true });
    multipart.Add(new StringContent(json, System.Text.Encoding.UTF8, "application/json"), "file", $"revit_{safeTitle}_{DateTime.UtcNow:yyyyMMdd_HHmmss}.json");
    request.Content = multipart;
    try
    {
        using var response = await client.SendAsync(request);
        var body = await response.Content.ReadAsStringAsync();
        return Results.Json(new
        {
            status = response.IsSuccessStatusCode ? "queued" : "rejected",
            dataset = exportDataset,
            lesHttpStatus = (int)response.StatusCode,
            lesResponse = TryParseJson(body),
            message = response.IsSuccessStatusCode
                ? "BIM-данные приняты ЛЕС и поставлены в очередь индексации."
                : "ЛЕС отклонил экспорт. Проверьте доступ и LES_API_KEY."
        }, statusCode: response.IsSuccessStatusCode ? 202 : 502);
    }
    catch (Exception error) when (error is HttpRequestException or TaskCanceledException)
    {
        return Results.Json(new
        {
            status = "unavailable",
            dataset = exportDataset,
            message = "ЛЕС недоступен; локальный JSON сохранён и может быть отправлен позже.",
            detail = error.GetType().Name
        }, statusCode: 503);
    }
});

app.MapGet("/api/integrations/les/status", async (IHttpClientFactory httpClientFactory, IConfiguration configuration) =>
{
    var options = LesOptions.FromConfiguration(configuration);
    using var client = httpClientFactory.CreateClient();
    client.Timeout = TimeSpan.FromSeconds(options.TimeoutSeconds);
    using var request = CreateLesRequest(HttpMethod.Get, options, "/api/health");

    try
    {
        using var response = await client.SendAsync(request);
        var body = await response.Content.ReadAsStringAsync();
        var parsed = TryParseJson(body);

        return Results.Ok(new LesStatusResponse(
            Status: response.IsSuccessStatusCode ? "ok" : "unhealthy",
            BaseUrl: options.BaseUrl,
            HttpStatus: (int)response.StatusCode,
            Health: parsed,
            CheckedAt: DateTimeOffset.UtcNow));
    }
    catch (HttpRequestException error)
    {
        return Results.Ok(new LesStatusResponse(
            Status: "unreachable",
            BaseUrl: options.BaseUrl,
            HttpStatus: 0,
            Health: new JsonObject { ["error"] = error.GetType().Name },
            CheckedAt: DateTimeOffset.UtcNow));
    }
    catch (TaskCanceledException)
    {
        return Results.Ok(new LesStatusResponse(
            Status: "timeout",
            BaseUrl: options.BaseUrl,
            HttpStatus: 0,
            Health: CreateLesTimeoutBody(options.TimeoutSeconds),
            CheckedAt: DateTimeOffset.UtcNow));
    }
});

app.MapGet("/api/tasks", (string? status) =>
{
    var tasks = store.Tasks.Values
        .Where(task => string.IsNullOrWhiteSpace(status) || task.Status == status)
        .OrderByDescending(task => task.UpdatedAt)
        .Select(TaskSummary.FromTask)
        .ToArray();

    return Results.Ok(tasks);
});

app.MapPost("/api/tasks", (CreateTaskRequest request) =>
{
    if (string.IsNullOrWhiteSpace(request.Title))
    {
        return Results.BadRequest(ApiError.Create("invalid_title", "Task title is required."));
    }

    var sequence = store.Tasks.Count + 1;
    var task = new FamilyTask(
        Id: $"task_{sequence:0000}",
        Number: $"FAM-{sequence:0000}",
        Title: request.Title.Trim(),
        Description: request.Description?.Trim(),
        Status: TaskStatuses.Draft,
        RevitCategory: request.RevitCategory?.Trim(),
        AssignedTo: request.AssignedTo?.Trim(),
        DueDate: request.DueDate,
        CreatedAt: DateTimeOffset.UtcNow,
        UpdatedAt: DateTimeOffset.UtcNow);

    store.Tasks[task.Id] = task;
    return Results.Created($"/api/tasks/{task.Id}", task);
});

app.MapGet("/api/tasks/{taskId}", (string taskId) =>
{
    return store.Tasks.TryGetValue(taskId, out var task)
        ? Results.Ok(task)
        : Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
});

app.MapGet("/api/tasks/{taskId}/specification", (string taskId) =>
{
    if (!store.Tasks.ContainsKey(taskId))
    {
        return Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
    }

    return store.Specifications.TryGetValue(taskId, out var specification)
        ? Results.Ok(specification)
        : Results.NotFound(ApiError.Create("specification_not_found", "Specification was not found."));
});

app.MapPost("/api/tasks/{taskId}/ai-analysis", (string taskId) =>
{
    if (!store.Tasks.ContainsKey(taskId))
    {
        return Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
    }

    return Results.Json(new
    {
        status = "gone",
        message = "Legacy AI analysis placeholder is disabled; use /api/generator/draft."
    }, statusCode: StatusCodes.Status410Gone);
});

app.MapPost("/api/tasks/{taskId}/rag-context", async (
    string taskId,
    LesRagContextRequest request,
    IHttpClientFactory httpClientFactory,
    IConfiguration configuration) =>
{
    if (!store.Tasks.TryGetValue(taskId, out var task))
    {
        return Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
    }

    var specification = store.Specifications.GetValueOrDefault(taskId);
    var question = string.IsNullOrWhiteSpace(request.Question)
        ? BuildDefaultLesQuestion(task, specification)
        : request.Question.Trim();

    var options = LesOptions.FromConfiguration(configuration);
    using var client = httpClientFactory.CreateClient();
    client.Timeout = TimeSpan.FromSeconds(options.TimeoutSeconds);
    using var lesRequest = CreateLesRequest(HttpMethod.Post, options, "/api/search");
    lesRequest.Content = JsonContent.Create(new
    {
        query = question,
        dataset_filter = request.DatasetFilter ?? "ARTEL",
        top_k = request.TopK ?? 8,
        include_trace = request.IncludeTrace ?? false
    });

    try
    {
        using var response = await client.SendAsync(lesRequest);
        var body = await response.Content.ReadAsStringAsync();
        var parsed = TryParseJson(body);

        return Results.Ok(new LesRagContextResult(
            Status: response.IsSuccessStatusCode ? "ok" : "upstream_error",
            TaskId: taskId,
            DatasetFilter: request.DatasetFilter ?? "ARTEL",
            Question: question,
            LesBaseUrl: options.BaseUrl,
            HttpStatus: (int)response.StatusCode,
            Response: parsed,
            CreatedAt: DateTimeOffset.UtcNow));
    }
    catch (HttpRequestException error)
    {
        return Results.Ok(new LesRagContextResult(
            Status: "unreachable",
            TaskId: taskId,
            DatasetFilter: request.DatasetFilter ?? "ARTEL",
            Question: question,
            LesBaseUrl: options.BaseUrl,
            HttpStatus: 0,
            Response: new JsonObject { ["error"] = error.GetType().Name },
            CreatedAt: DateTimeOffset.UtcNow));
    }
    catch (TaskCanceledException)
    {
        return Results.Ok(new LesRagContextResult(
            Status: "timeout",
            TaskId: taskId,
            DatasetFilter: request.DatasetFilter ?? "ARTEL",
            Question: question,
            LesBaseUrl: options.BaseUrl,
            HttpStatus: 0,
            Response: CreateLesTimeoutBody(options.TimeoutSeconds),
            CreatedAt: DateTimeOffset.UtcNow));
    }
});

app.MapPut("/api/tasks/{taskId}/specification", (string taskId, FamilySpecification specification) =>
{
    if (!store.Tasks.ContainsKey(taskId))
    {
        return Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
    }

    var normalized = specification with
    {
        TaskId = taskId,
        UpdatedAt = DateTimeOffset.UtcNow
    };

    store.Specifications[taskId] = normalized;
    return Results.Ok(normalized);
});

app.MapPost("/api/tasks/{taskId}/specification/approve", (string taskId) =>
{
    if (!store.Specifications.TryGetValue(taskId, out var specification))
    {
        return Results.NotFound(ApiError.Create("specification_not_found", "Specification was not found."));
    }

    var approved = specification with
    {
        Status = SpecificationStatuses.Approved,
        UpdatedAt = DateTimeOffset.UtcNow
    };

    store.Specifications[taskId] = approved;
    return Results.Ok(approved);
});

app.MapGet("/api/revit/tasks", () =>
{
    var tasks = store.Tasks.Values
        .Where(task => task.Status is TaskStatuses.ReadyForDevelopment or TaskStatuses.InDevelopment)
        .OrderBy(task => task.DueDate)
        .Select(TaskSummary.FromTask)
        .ToArray();

    return Results.Ok(tasks);
});

app.MapGet("/api/revit/tasks/{taskId}/package", (string taskId) =>
{
    if (!store.Tasks.TryGetValue(taskId, out var task))
    {
        return Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
    }

    if (!store.Specifications.TryGetValue(taskId, out var specification))
    {
        return Results.NotFound(ApiError.Create("specification_not_found", "Specification was not found."));
    }

    if (specification.Status != SpecificationStatuses.Approved)
    {
        return Results.BadRequest(ApiError.Create(
            "specification_not_approved",
            "Specification must be approved before it can be issued to Revit."));
    }

    return Results.Ok(new RevitTaskPackage(
        Task: TaskSummary.FromTask(task),
        Specification: specification,
        Files: store.Files.Values.Where(file => file.TaskId == taskId).ToArray()));
});

app.MapPost("/api/revit/tasks/{taskId}/validation-reports", (string taskId, ValidationReportRequest request) =>
{
    if (!store.Tasks.ContainsKey(taskId))
    {
        return Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
    }

    var report = new ValidationReport(
        Id: $"report_{Guid.NewGuid():N}",
        TaskId: taskId,
        Status: request.Status,
        Summary: request.Summary,
        Issues: request.Issues,
        Actions: request.Actions,
        CreatedAt: DateTimeOffset.UtcNow);

    store.ValidationReports[report.Id] = report;
    validationReportArchive.Save(report);
    return Results.Created($"/api/validation-reports/{report.Id}", report);
});

app.MapGet("/api/validation-reports", (string? taskId) =>
{
    var reports = store.ValidationReports.Values
        .Where(report => string.IsNullOrWhiteSpace(taskId) || report.TaskId == taskId)
        .OrderByDescending(report => report.CreatedAt)
        .ToArray();

    return Results.Ok(reports);
});

app.MapGet("/api/validation-reports/{reportId}/learning-case", (string reportId) =>
{
    if (!store.ValidationReports.TryGetValue(reportId, out var report))
    {
        return Results.NotFound(ApiError.Create("validation_report_not_found", "Validation report was not found."));
    }

    if (!store.Tasks.TryGetValue(report.TaskId, out var task))
    {
        return Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
    }

    if (!store.Specifications.TryGetValue(report.TaskId, out var specification))
    {
        return Results.NotFound(ApiError.Create("specification_not_found", "Specification was not found."));
    }

    var catalogItem = store.Catalog.Values.FirstOrDefault(item =>
        string.Equals(item.Name, specification.FamilyName, StringComparison.OrdinalIgnoreCase)
        || string.Equals(item.Category, specification.RevitCategory, StringComparison.OrdinalIgnoreCase));

    return Results.Ok(BuildLearningCase(task, specification, report, catalogItem));
});

app.MapGet("/api/tasks/{taskId}/learning-case", (string taskId) =>
{
    if (!store.Tasks.TryGetValue(taskId, out var task))
    {
        return Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
    }

    if (!store.Specifications.TryGetValue(taskId, out var specification))
    {
        return Results.NotFound(ApiError.Create("specification_not_found", "Specification was not found."));
    }

    var report = store.ValidationReports.Values
        .Where(item => item.TaskId == taskId)
        .OrderByDescending(item => item.CreatedAt)
        .FirstOrDefault();

    if (report is null)
    {
        return Results.NotFound(ApiError.Create("validation_report_not_found", "No validation report exists for this task."));
    }

    var catalogItem = store.Catalog.Values.FirstOrDefault(item =>
        string.Equals(item.Name, specification.FamilyName, StringComparison.OrdinalIgnoreCase)
        || string.Equals(item.Category, specification.RevitCategory, StringComparison.OrdinalIgnoreCase));

    return Results.Ok(BuildLearningCase(task, specification, report, catalogItem));
});

app.MapGet("/api/catalog", (string? query) =>
{
    var items = store.Catalog.Values
        .Where(item =>
            string.IsNullOrWhiteSpace(query)
            || item.Name.Contains(query, StringComparison.OrdinalIgnoreCase)
            || item.Category.Contains(query, StringComparison.OrdinalIgnoreCase)
            || item.Tags.Any(tag => tag.Contains(query, StringComparison.OrdinalIgnoreCase)))
        .OrderBy(item => item.Name)
        .ToArray();

    return Results.Ok(items);
});

app.MapGet("/api/catalog/{catalogItemId}", (string catalogItemId) =>
{
    return store.Catalog.TryGetValue(catalogItemId, out var item)
        ? Results.Ok(new CatalogItemDetail(
            Item: item,
            Versions: store.FamilyVersions.Values
                .Where(version => version.CatalogItemId == catalogItemId)
                .OrderByDescending(version => version.SubmittedAt)
                .ToArray()))
        : Results.NotFound(ApiError.Create("catalog_item_not_found", "Catalog item was not found."));
});

app.MapGet("/api/catalog/{catalogItemId}/versions", (string catalogItemId) =>
{
    if (!store.Catalog.ContainsKey(catalogItemId))
    {
        return Results.NotFound(ApiError.Create("catalog_item_not_found", "Catalog item was not found."));
    }

    var versions = store.FamilyVersions.Values
        .Where(version => version.CatalogItemId == catalogItemId)
        .OrderByDescending(version => version.SubmittedAt)
        .ToArray();

    return Results.Ok(versions);
});

app.MapPost("/api/catalog/{catalogItemId}/publish", (string catalogItemId, PublishCatalogVersionRequest request) =>
{
    if (!store.Catalog.TryGetValue(catalogItemId, out var item))
    {
        return Results.NotFound(ApiError.Create("catalog_item_not_found", "Catalog item was not found."));
    }

    var version = new FamilyVersion(
        Id: $"version_{Guid.NewGuid():N}",
        CatalogItemId: catalogItemId,
        TaskId: request.TaskId,
        Version: request.Version,
        RfaFileId: request.RfaFileId,
        Status: "published",
        Changelog: request.Changelog,
        SubmittedBy: request.SubmittedBy,
        SubmittedAt: DateTimeOffset.UtcNow);

    store.FamilyVersions[version.Id] = version;
    store.Catalog[catalogItemId] = item with
    {
        CurrentVersion = request.Version,
        CurrentVersionId = version.Id,
        UpdatedAt = DateTimeOffset.UtcNow
    };

    return Results.Created($"/api/catalog/{catalogItemId}/versions/{version.Id}", version);
});

app.MapPost("/api/catalog/{catalogItemId}/update-task", (string catalogItemId, CreateCatalogUpdateTaskRequest request) =>
{
    if (!store.Catalog.TryGetValue(catalogItemId, out var item))
    {
        return Results.NotFound(ApiError.Create("catalog_item_not_found", "Catalog item was not found."));
    }

    var sequence = store.Tasks.Count + 1;
    var task = new FamilyTask(
        Id: $"task_{sequence:0000}",
        Number: $"FAM-{sequence:0000}",
        Title: $"Обновить: {item.Name}",
        Description: request.Reason,
        Status: TaskStatuses.Draft,
        RevitCategory: item.Category,
        AssignedTo: request.AssignedTo,
        DueDate: request.DueDate,
        CreatedAt: DateTimeOffset.UtcNow,
        UpdatedAt: DateTimeOffset.UtcNow);

    store.Tasks[task.Id] = task;
    return Results.Created($"/api/tasks/{task.Id}", new CatalogUpdateTaskResult(task.Id, task.Number, catalogItemId));
});

app.Run();

static HttpRequestMessage CreateLesRequest(HttpMethod method, LesOptions options, string path)
{
    var request = new HttpRequestMessage(method, new Uri(new Uri(options.BaseUrl), path));
    if (!string.IsNullOrWhiteSpace(options.ApiKey))
    {
        request.Headers.TryAddWithoutValidation("X-API-Key", options.ApiKey);
    }

    return request;
}

static JsonArray AssistantTools(JsonNode? context)
{
    var categoryEnum = new JsonArray();
    var categorySource = context?["category_catalog"] as JsonArray ?? context?["model_quantities"] as JsonArray ?? new JsonArray();
    foreach (var category in categorySource
        .Select(node => node?["category"]?.GetValue<string>() ?? "")
        .Where(value => !string.IsNullOrWhiteSpace(value)).Distinct(StringComparer.OrdinalIgnoreCase))
        categoryEnum.Add(JsonValue.Create(category));
    var parameterEnum = new JsonArray();
    foreach (var name in (context?["parameter_catalog"] as JsonArray ?? new JsonArray())
        .SelectMany(row => new[] { row?["instance_parameters"] as JsonArray, row?["type_parameters"] as JsonArray })
        .Where(array => array is not null).SelectMany(array => array!)
        .Select(node => node?["name"]?.GetValue<string>() ?? "")
        .Where(value => !string.IsNullOrWhiteSpace(value)).Distinct(StringComparer.OrdinalIgnoreCase))
        parameterEnum.Add(JsonValue.Create(name));
    var categorySchema = new JsonObject { ["type"] = "string" };
    if (categoryEnum.Count > 0) categorySchema["enum"] = categoryEnum;
    var parameterSchema = new JsonObject { ["type"] = "string" };
    if (parameterEnum.Count > 0) parameterSchema["enum"] = parameterEnum;
    var parameterFilterSchema = new JsonObject
    {
        ["type"] = "object", ["required"] = new JsonArray("parameter", "operator"),
        ["properties"] = new JsonObject
        {
            ["parameter"] = parameterSchema.DeepClone(),
            ["scope"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("instance", "type") },
            ["operator"] = new JsonObject
            {
                ["type"] = "string",
                ["enum"] = new JsonArray("equal", "not_equal", "contains", "not_contains", "begins_with", "ends_with", "greater", "greater_or_equal", "less", "less_or_equal", "has_value", "not_has_value")
            },
            ["value"] = new JsonObject { ["type"] = "string" }
        }
    };
    var querySchema = new JsonObject
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["scope"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("model", "active_view", "selection") },
            ["categories"] = new JsonObject { ["type"] = "array", ["items"] = categorySchema.DeepClone() },
            ["family"] = new JsonObject { ["type"] = "string" },
            ["type"] = new JsonObject { ["type"] = "string" },
            ["system"] = new JsonObject { ["type"] = "string" },
            ["parameter_filters"] = new JsonObject { ["type"] = "array", ["items"] = parameterFilterSchema }
        }
    };
    return new JsonArray(
    new JsonObject
    {
        ["type"] = "function",
        ["function"] = new JsonObject
        {
            ["name"] = "inspect_revit_model",
            ["description"] = "Read a compact manifest of the active Revit document: title, view, available categories, engineering systems and selection. Call this before choosing filters.",
            ["parameters"] = new JsonObject { ["type"] = "object", ["properties"] = new JsonObject() }
        }
    },
    new JsonObject
    {
        ["type"] = "function",
        ["function"] = new JsonObject
        {
            ["name"] = "query_revit_parameters",
            ["description"] = "Read instance and type parameter definitions and sample displayed values for an exact category returned by inspect_revit_model.",
            ["parameters"] = new JsonObject
            {
                ["type"] = "object", ["required"] = new JsonArray("category"),
                ["properties"] = new JsonObject { ["category"] = new JsonObject { ["type"] = "string" } }
            }
        }
    },
    new JsonObject
    {
        ["type"] = "function",
        ["function"] = new JsonObject
        {
            ["name"] = "prepare_revit_action",
            ["description"] = "Prepare one action over a universal Revit query. The same model/active-view/selection query with category, family, type, system and parameter predicates drives selection, schedules and parameter updates.",
            ["parameters"] = new JsonObject
            {
                ["type"] = "object", ["required"] = new JsonArray("operation", "query"),
                ["properties"] = new JsonObject
                {
                    ["operation"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("select_elements", "create_schedule", "set_parameter") },
                    ["query"] = querySchema,
                    ["schedule_name"] = new JsonObject { ["type"] = "string" },
                    ["fields"] = new JsonObject { ["type"] = "array", ["items"] = parameterSchema.DeepClone() },
                    ["group_by"] = new JsonObject { ["type"] = "array", ["items"] = parameterSchema.DeepClone() },
                    ["itemize_every_instance"] = new JsonObject { ["type"] = "boolean" },
                    ["parameter"] = parameterSchema.DeepClone(),
                    ["value"] = new JsonObject { ["type"] = "string" },
                    ["parameter_scope"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("instance", "type") }
                }
            }
        }
    },
    new JsonObject
    {
        ["type"] = "function",
        ["function"] = new JsonObject
        {
            ["name"] = "query_revit_quantities",
            ["description"] = "Execute a read-only quantity query selected by the model. Use exact category/system names returned by inspect_revit_model.",
            ["parameters"] = new JsonObject
            {
                ["type"] = "object", ["required"] = new JsonArray("metric"),
                ["properties"] = new JsonObject
                {
                    ["metric"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("count", "length_m", "area_m2", "volume_m3") },
                    ["category"] = new JsonObject { ["type"] = "string" },
                    ["system"] = new JsonObject { ["type"] = "string" }
                }
            }
        }
    },
    new JsonObject
    {
        ["type"] = "function",
        ["function"] = new JsonObject
        {
            ["name"] = "query_revit_inventory",
            ["description"] = "Read category/family/type inventory for schedules and model composition. Filters are optional and model-selected.",
            ["parameters"] = new JsonObject
            {
                ["type"] = "object", ["properties"] = new JsonObject
                {
                    ["category"] = new JsonObject { ["type"] = "string" },
                    ["family"] = new JsonObject { ["type"] = "string" },
                    ["type"] = new JsonObject { ["type"] = "string" }
                }
            }
        }
    },
    new JsonObject
    {
        ["type"] = "function",
        ["function"] = new JsonObject
        {
            ["name"] = "search_artel_index",
            ["description"] = "Search ARTEL_Index for Revit API, FOP and family guidance. Never use this tool as evidence for quantities or contents of the active model.",
            ["parameters"] = new JsonObject
            {
                ["type"] = "object", ["required"] = new JsonArray("query"),
                ["properties"] = new JsonObject { ["query"] = new JsonObject { ["type"] = "string" } }
            }
        }
    });
}

static string LiveAssistantSystemPrompt(string contentRoot) =>
    "Ты АРТЕЛЬ — агент Autodesk Revit. У тебя нет заранее подготовленного снимка модели. " +
    "Все факты об открытом документе получай сама через query_revit. Код не выбирает за тебя категории, " +
    "поля, фильтры или операции. Результаты query_revit пагинированы: всегда проверяй total, returned и has_more; " +
    "если данных недостаточно, запроси следующую страницу через offset. Сначала запроси categories или selection, " +
    "затем parameters точной категории, затем elements с нужными fields. Не объявляй категорию отсутствующей, пока " +
    "не прочитана полная выдача categories. Для выделения, спецификации или изменения параметра вызови " +
    "prepare_revit_action. Один универсальный query определяет цели всех действий. Для сводной спецификации " +
    "перечисли поля в group_by и поставь itemize_every_instance=false. Код только проверяет схему и выполняет " +
    "Revit API действие; профессиональный выбор остаётся за тобой. Никогда не заканчивай ход обещанием " +
    "вроде «теперь подготовлю». Для действия сразу вызывай prepare_revit_action; окончательный ответ без " +
    "действия возвращай только через finish_revit_response. Не выводи сырой JSON. " +
    "Справку Revit API запрашивай через search_artel_index, но не используй её как факт открытой модели.\n\n" +
    "Runtime skill:\n" + LoadOperatorSkill(contentRoot);

static JsonArray LiveAssistantTools()
{
    var parameterFilter = new JsonObject
    {
        ["type"] = "object",
        ["required"] = new JsonArray("parameter", "scope", "operator"),
        ["properties"] = new JsonObject
        {
            ["parameter"] = new JsonObject { ["type"] = "string" },
            ["scope"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("instance", "type") },
            ["operator"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("equal", "not_equal", "contains", "not_contains", "begins_with", "ends_with", "greater", "greater_or_equal", "less", "less_or_equal", "has_value", "not_has_value") },
            ["value"] = new JsonObject { ["type"] = "string" }
        }
    };
    var query = new JsonObject
    {
        ["type"] = "object",
        ["properties"] = new JsonObject
        {
            ["scope"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("model", "active_view", "selection") },
            ["categories"] = new JsonObject { ["type"] = "array", ["items"] = new JsonObject { ["type"] = "string" } },
            ["family"] = new JsonObject { ["type"] = "string" },
            ["type"] = new JsonObject { ["type"] = "string" },
            ["system"] = new JsonObject { ["type"] = "string" },
            ["parameter_filters"] = new JsonObject { ["type"] = "array", ["items"] = parameterFilter }
        }
    };
    return new JsonArray
    {
        new JsonObject
        {
            ["type"] = "function",
            ["function"] = new JsonObject
            {
                ["name"] = "query_revit",
                ["description"] = "Run one live read-only query on the active Revit document. Results are complete only when has_more=false.",
                ["parameters"] = new JsonObject
                {
                    ["type"] = "object", ["required"] = new JsonArray("mode"),
                    ["properties"] = new JsonObject
                    {
                        ["mode"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("document", "categories", "parameters", "elements", "selection") },
                        ["query"] = query.DeepClone(),
                        ["fields"] = new JsonObject { ["type"] = "array", ["items"] = new JsonObject { ["type"] = "string" } },
                        ["offset"] = new JsonObject { ["type"] = "integer", ["minimum"] = 0 },
                        ["limit"] = new JsonObject { ["type"] = "integer", ["minimum"] = 1, ["maximum"] = 1000 }
                    }
                }
            }
        },
        new JsonObject
        {
            ["type"] = "function",
            ["function"] = new JsonObject
            {
                ["name"] = "prepare_revit_action",
                ["description"] = "Prepare a model-selected Revit action after live query_revit evidence.",
                ["parameters"] = new JsonObject
                {
                    ["type"] = "object", ["required"] = new JsonArray("operation", "query"),
                    ["properties"] = new JsonObject
                    {
                        ["operation"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("select_elements", "create_schedule", "set_parameter") },
                        ["query"] = query.DeepClone(),
                        ["schedule_name"] = new JsonObject { ["type"] = "string" },
                        ["fields"] = new JsonObject { ["type"] = "array", ["items"] = new JsonObject { ["type"] = "string" } },
                        ["group_by"] = new JsonObject { ["type"] = "array", ["items"] = new JsonObject { ["type"] = "string" } },
                        ["itemize_every_instance"] = new JsonObject { ["type"] = "boolean" },
                        ["parameter"] = new JsonObject { ["type"] = "string" },
                        ["value"] = new JsonObject { ["type"] = "string" },
                        ["parameter_scope"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("instance", "type") }
                    }
                }
            }
        },
        new JsonObject
        {
            ["type"] = "function",
            ["function"] = new JsonObject
            {
                ["name"] = "finish_revit_response",
                ["description"] = "Finish a read-only Revit answer after sufficient live query_revit evidence. Never use this instead of prepare_revit_action when the user requested an action.",
                ["parameters"] = new JsonObject
                {
                    ["type"] = "object", ["required"] = new JsonArray("answer"),
                    ["properties"] = new JsonObject { ["answer"] = new JsonObject { ["type"] = "string" } }
                }
            }
        },
        new JsonObject
        {
            ["type"] = "function",
            ["function"] = new JsonObject
            {
                ["name"] = "search_artel_index",
                ["description"] = "Search ARTEL_Index for Revit API reference only.",
                ["parameters"] = new JsonObject
                {
                    ["type"] = "object", ["required"] = new JsonArray("query"),
                    ["properties"] = new JsonObject { ["query"] = new JsonObject { ["type"] = "string" } }
                }
            }
        }
    };
}

static JsonObject PrepareLiveRevitAction(JsonObject? arguments)
{
    var operation = NodeText(arguments?["operation"]);
    if (operation is not ("select_elements" or "create_schedule" or "set_parameter"))
        return new JsonObject { ["status"] = "blocked", ["message"] = "Operation is not enabled" };
    if (arguments?["query"] is not JsonObject sourceQuery)
        return new JsonObject { ["status"] = "missing", ["message"] = "Universal query is required" };
    var query = sourceQuery.DeepClone() as JsonObject ?? new JsonObject();
    query["scope"] ??= "model";
    query["categories"] ??= new JsonArray();
    query["parameter_filters"] ??= new JsonArray();
    var categories = query["categories"] as JsonArray ?? new JsonArray();
    if (operation is "create_schedule" or "set_parameter" && categories.Count != 1)
        return new JsonObject { ["status"] = "missing", ["message"] = "This action requires one exact category selected by the model from live Revit results" };

    var actionArguments = new JsonObject { ["query"] = query };
    if (operation == "create_schedule")
    {
        var fields = StringArray(arguments?["fields"]);
        if (fields.Count == 0)
            return new JsonObject { ["status"] = "missing", ["message"] = "Schedule fields are required" };
        var groupBy = StringArray(arguments?["group_by"]);
        if (groupBy.Any(group => !fields.Any(field => string.Equals(NodeText(field), NodeText(group), StringComparison.OrdinalIgnoreCase))))
            return new JsonObject { ["status"] = "missing", ["message"] = "Every group_by field must also be present in fields" };
        actionArguments["schedule_name"] = NodeText(arguments?["schedule_name"], "АРТЕЛЬ — спецификация");
        actionArguments["fields"] = fields;
        actionArguments["group_by"] = groupBy;
        actionArguments["itemize_every_instance"] = arguments?["itemize_every_instance"]?.DeepClone() ?? true;
    }
    else if (operation == "set_parameter")
    {
        var parameter = NodeText(arguments?["parameter"]);
        if (string.IsNullOrWhiteSpace(parameter))
            return new JsonObject { ["status"] = "missing", ["message"] = "Parameter name is required" };
        actionArguments["parameter"] = parameter;
        actionArguments["value"] = NodeText(arguments?["value"]);
        actionArguments["parameter_scope"] = NodeText(arguments?["parameter_scope"], "instance");
    }
    var requiresConfirmation = operation != "select_elements";
    var plan = new JsonObject
    {
        ["schema"] = "artel.revit_operator_plan.v3", ["status"] = "ready", ["summary"] = operation,
        ["operations"] = new JsonArray(new JsonObject
        {
            ["op"] = operation, ["target_ids"] = new JsonArray(), ["arguments"] = actionArguments,
            ["transaction"] = operation == "create_schedule" ? "ARTEL create schedule" : operation == "set_parameter" ? "ARTEL set parameter" : "selection only",
            ["expected_result"] = operation, ["rollback"] = requiresConfirmation ? "Transaction rollback" : "restore selection"
        })
    };
    var planJson = ModelJson(plan);
    var hash = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(planJson))).ToLowerInvariant();
    return new JsonObject
    {
        ["status"] = "ready", ["operation"] = operation, ["requires_confirmation"] = requiresConfirmation,
        ["summary"] = operation == "select_elements" ? "Выделить элементы по live Revit query"
            : operation == "create_schedule" ? $"Создать спецификацию «{NodeText(actionArguments["schedule_name"])}»"
            : $"Изменить параметр «{NodeText(actionArguments["parameter"])}»",
        ["message"] = "План сформирован моделью по результатам live Revit tools.",
        ["planJson"] = planJson, ["confirmationHash"] = hash
    };
}

static JsonArray StringArray(JsonNode? source)
{
    var result = new JsonArray();
    foreach (var node in source as JsonArray ?? new JsonArray())
    {
        var value = NodeText(node).Trim();
        if (!string.IsNullOrWhiteSpace(value) && !result.Any(existing => string.Equals(NodeText(existing), value, StringComparison.OrdinalIgnoreCase)))
            result.Add(value);
    }
    return result;
}

static string ModelJson(JsonNode? node) => node?.ToJsonString(new JsonSerializerOptions
{
    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
    TypeInfoResolver = new System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver()
}) ?? "null";

static JsonObject? ToolArguments(JsonNode? node)
{
    if (node is JsonObject value) return value;
    if (node is JsonValue scalar && scalar.TryGetValue<string>(out var text)) return TryParseJson(text) as JsonObject;
    return new JsonObject();
}

static string NodeText(JsonNode? node, string fallback = "") =>
    node is JsonValue value && value.TryGetValue<string>(out var text) ? text : fallback;

static JsonNode CompactRevitContext(JsonNode? context)
{
    if (context is not JsonObject source) return new JsonObject { ["status"] = "missing", ["message"] = "Revit context unavailable" };
    var categories = new JsonArray();
    var categorySource = source["category_catalog"] as JsonArray ?? source["model_quantities"] as JsonArray ?? new JsonArray();
    foreach (var row in categorySource)
        if (row?["category"] is JsonValue category) categories.Add(category.DeepClone());
    var systems = new JsonArray();
    foreach (var row in source["system_quantities"] as JsonArray ?? new JsonArray())
    {
        if (row is not JsonObject item) continue;
        systems.Add(new JsonObject { ["category"] = item["category"]?.DeepClone(), ["system"] = item["system"]?.DeepClone() });
    }
    return new JsonObject
    {
        ["status"] = source["status"]?.DeepClone(), ["revit_version"] = source["revit_version"]?.DeepClone(),
        ["document_title"] = source["document_title"]?.DeepClone(), ["active_view"] = source["active_view"]?.DeepClone(),
        ["is_family_document"] = source["is_family_document"]?.DeepClone(), ["warning_count"] = source["warning_count"]?.DeepClone(),
        ["categories"] = categories, ["systems"] = systems,
        ["selected_elements"] = source["selected_elements"]?.DeepClone() ?? new JsonArray()
    };
}

static JsonNode QueryRevitQuantities(JsonNode? context, JsonObject? arguments)
{
    if (context is not JsonObject source) return new JsonObject { ["status"] = "missing", ["message"] = "Revit context unavailable" };
    var metric = arguments?["metric"]?.GetValue<string>() ?? "count";
    if (metric is not ("count" or "length_m" or "area_m2" or "volume_m3"))
        return new JsonObject { ["status"] = "invalid", ["message"] = "Unsupported metric" };
    var category = arguments?["category"]?.GetValue<string>()?.Trim() ?? "";
    var system = arguments?["system"]?.GetValue<string>()?.Trim() ?? "";
    var rows = string.IsNullOrWhiteSpace(system) ? source["model_quantities"] as JsonArray : source["system_quantities"] as JsonArray;
    var matches = new JsonArray();
    double total = 0;
    foreach (var node in rows ?? new JsonArray())
    {
        if (node is not JsonObject row) continue;
        if (!TextMatches(row["category"]?.GetValue<string>(), category)) continue;
        if (!string.IsNullOrWhiteSpace(system) && !TextMatches(row["system"]?.GetValue<string>(), system)) continue;
        var value = row[metric]?.GetValue<double>() ?? 0;
        total += value;
        matches.Add(new JsonObject
        {
            ["category"] = row["category"]?.DeepClone(), ["system"] = row["system"]?.DeepClone(),
            ["metric"] = metric, ["value"] = value, ["count"] = row["count"]?.DeepClone(),
            ["computed_by"] = row["computed_by"]?.DeepClone()
        });
    }
    return new JsonObject
    {
        ["status"] = matches.Count > 0 ? "ok" : "not_found", ["metric"] = metric,
        ["filters"] = new JsonObject { ["category"] = category, ["system"] = system },
        ["matched_rows"] = matches.Count, ["total"] = Math.Round(total, 6), ["rows"] = matches
    };
}

static JsonNode QueryRevitInventory(JsonNode? context, JsonObject? arguments)
{
    if (context?["model_inventory"] is not JsonArray inventory) return new JsonObject { ["status"] = "missing" };
    var matches = new JsonArray();
    foreach (var node in inventory)
    {
        if (node is not JsonObject row) continue;
        if (!TextMatches(row["category"]?.GetValue<string>(), arguments?["category"]?.GetValue<string>())) continue;
        if (!TextMatches(row["family"]?.GetValue<string>(), arguments?["family"]?.GetValue<string>())) continue;
        if (!TextMatches(row["type"]?.GetValue<string>(), arguments?["type"]?.GetValue<string>())) continue;
        matches.Add(row.DeepClone());
        if (matches.Count >= 200) break;
    }
    return new JsonObject { ["status"] = matches.Count > 0 ? "ok" : "not_found", ["matched_rows"] = matches.Count, ["rows"] = matches };
}

static JsonNode QueryRevitParameters(JsonNode? context, JsonObject? arguments)
{
    if (context?["parameter_catalog"] is not JsonArray catalog) return new JsonObject { ["status"] = "missing" };
    var category = arguments?["category"]?.GetValue<string>() ?? "";
    var row = catalog.FirstOrDefault(item => TextMatches(item?["category"]?.GetValue<string>(), category));
    return row is null
        ? new JsonObject { ["status"] = "not_found", ["category"] = category }
        : new JsonObject { ["status"] = "ok", ["category"] = row["category"]?.DeepClone(), ["instance_parameters"] = row["instance_parameters"]?.DeepClone(), ["type_parameters"] = row["type_parameters"]?.DeepClone() };
}

static JsonObject PrepareRevitAction(JsonNode? context, JsonObject? arguments)
{
    var operation = NodeText(arguments?["operation"]);
    if (operation == "select_category") operation = "select_elements";
    if (operation is not ("select_elements" or "create_schedule" or "set_parameter"))
        return new JsonObject { ["status"] = "blocked", ["message"] = "Operation is not enabled" };

    var sourceQuery = arguments?["query"] as JsonObject;
    if (sourceQuery is null)
    {
        sourceQuery = new JsonObject { ["scope"] = "model", ["categories"] = new JsonArray() };
        var legacyCategory = NodeText(arguments?["category"]);
        if (!string.IsNullOrWhiteSpace(legacyCategory)) (sourceQuery["categories"] as JsonArray)!.Add(legacyCategory);
    }
    var scope = NodeText(sourceQuery["scope"], "model").ToLowerInvariant();
    if (scope is not ("model" or "active_view" or "selection"))
        return new JsonObject { ["status"] = "missing", ["message"] = "Query scope must be model, active_view or selection" };

    var availableCategories = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    var categorySource = context?["category_catalog"] as JsonArray ?? context?["model_quantities"] as JsonArray ?? new JsonArray();
    foreach (var row in categorySource)
    {
        var name = NodeText(row?["category"]).Trim();
        if (!string.IsNullOrWhiteSpace(name)) availableCategories[name] = name;
    }
    var exactCategories = new JsonArray();
    foreach (var node in sourceQuery["categories"] as JsonArray ?? new JsonArray())
    {
        var requested = NodeText(node).Trim();
        if (!availableCategories.TryGetValue(requested, out var exact))
            return new JsonObject { ["status"] = "missing", ["message"] = $"Category '{requested}' is not present in the active Revit model" };
        if (!exactCategories.Any(item => string.Equals(NodeText(item), exact, StringComparison.OrdinalIgnoreCase))) exactCategories.Add(exact);
    }
    if (operation is "create_schedule" or "set_parameter" && exactCategories.Count == 0)
        return new JsonObject { ["status"] = "missing", ["message"] = "A mutating action requires at least one exact category" };
    if (operation == "create_schedule" && exactCategories.Count != 1)
        return new JsonObject { ["status"] = "missing", ["message"] = "A regular Revit schedule requires exactly one category" };

    var exactParameterNames = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
    foreach (var catalogRow in context?["parameter_catalog"] as JsonArray ?? new JsonArray())
    {
        var rowCategory = NodeText(catalogRow?["category"]);
        if (exactCategories.Count > 0 && !exactCategories.Any(item => string.Equals(NodeText(item), rowCategory, StringComparison.OrdinalIgnoreCase))) continue;
        foreach (var scopeName in new[] { "instance_parameters", "type_parameters" })
            foreach (var parameterNode in catalogRow?[scopeName] as JsonArray ?? new JsonArray())
            {
                var name = NodeText(parameterNode?["name"]).Trim();
                if (!string.IsNullOrWhiteSpace(name)) exactParameterNames[name] = name;
            }
    }
    var allowedOperators = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        { "equal", "not_equal", "contains", "not_contains", "begins_with", "ends_with", "greater", "greater_or_equal", "less", "less_or_equal", "has_value", "not_has_value" };
    var parameterFilters = new JsonArray();
    foreach (var node in sourceQuery["parameter_filters"] as JsonArray ?? new JsonArray())
    {
        if (node is not JsonObject filter)
            return new JsonObject { ["status"] = "missing", ["message"] = "Each query parameter filter must be an object" };
        var requestedParameter = NodeText(filter["parameter"]).Trim();
        var filterScope = NodeText(filter["scope"], "instance").ToLowerInvariant();
        var filterOperator = NodeText(filter["operator"]).ToLowerInvariant();
        if (!exactParameterNames.TryGetValue(requestedParameter, out var exactParameter))
            return new JsonObject { ["status"] = "missing", ["message"] = $"Query parameter '{requestedParameter}' is not present in the typed Revit catalog" };
        if (filterScope is not ("instance" or "type") || !allowedOperators.Contains(filterOperator))
            return new JsonObject { ["status"] = "missing", ["message"] = "Query parameter scope or operator is invalid" };
        parameterFilters.Add(new JsonObject
        {
            ["parameter"] = exactParameter, ["scope"] = filterScope,
            ["operator"] = filterOperator, ["value"] = NodeText(filter["value"])
        });
    }
    var query = new JsonObject
    {
        ["scope"] = scope, ["categories"] = exactCategories,
        ["family"] = NodeText(sourceQuery["family"]).Trim(),
        ["type"] = NodeText(sourceQuery["type"]).Trim(),
        ["system"] = NodeText(sourceQuery["system"]).Trim(),
        ["parameter_filters"] = parameterFilters
    };
    var args = new JsonObject { ["query"] = query };
    var requiresConfirmation = operation != "select_elements";
    if (operation == "create_schedule")
    {
        var category = NodeText(exactCategories[0]);
        if (parameterFilters.Any(node => NodeText(node?["operator"]) is "has_value" or "not_has_value"))
            return new JsonObject { ["status"] = "missing", ["message"] = "Regular Revit schedules do not expose has_value/not_has_value in this action contract; use an explicit value predicate" };
        var fields = arguments?["fields"] as JsonArray ?? new JsonArray();
        if (fields.Count == 0) return new JsonObject { ["status"] = "missing", ["message"] = "Schedule fields are required; call query_revit_parameters first" };
        var catalog = QueryRevitParameters(context, new JsonObject { ["category"] = category });
        var availableNames = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var scopeName in new[] { "instance_parameters", "type_parameters" })
        {
            foreach (var node in catalog[scopeName] as JsonArray ?? new JsonArray())
            {
                var name = node?["name"]?.GetValue<string>()?.Trim() ?? "";
                if (!string.IsNullOrWhiteSpace(name)) availableNames[name] = name;
            }
        }
        var validatedFields = new JsonArray();
        foreach (var node in fields)
        {
            var requestedField = node is JsonValue value && value.TryGetValue<string>(out var scalar)
                ? scalar
                : node is JsonObject fieldObject
                    ? NodeText(fieldObject["field"], NodeText(fieldObject["parameter"], NodeText(fieldObject["name"])))
                    : "";
            if (!availableNames.TryGetValue(requestedField.Trim(), out var exactField))
                return new JsonObject { ["status"] = "missing", ["message"] = $"Schedule field '{requestedField}' is not present in the Revit parameter catalog" };
            if (!validatedFields.Any(existing => string.Equals(existing?.GetValue<string>(), exactField, StringComparison.OrdinalIgnoreCase)))
                validatedFields.Add(JsonValue.Create(exactField));
        }
        var requestedScheduleName = NodeText(arguments?["schedule_name"]).Trim();
        args["schedule_name"] = string.IsNullOrWhiteSpace(requestedScheduleName) ? $"АРТЕЛЬ — {category}" : requestedScheduleName;
        args["fields"] = validatedFields;
        foreach (var node in parameterFilters)
            if (!availableNames.ContainsKey(NodeText(node?["parameter"])))
                return new JsonObject { ["status"] = "missing", ["message"] = $"Schedule filter field '{NodeText(node?["parameter"])}' is not schedulable for category '{category}'" };
    }
    else if (operation == "set_parameter")
    {
        var parameter = NodeText(arguments?["parameter"]);
        var value = NodeText(arguments?["value"]);
        var parameterScope = NodeText(arguments?["parameter_scope"], "instance");
        JsonNode? matched = null;
        foreach (var categoryNode in exactCategories)
        {
            var catalog = QueryRevitParameters(context, new JsonObject { ["category"] = NodeText(categoryNode) });
            var available = catalog[parameterScope == "type" ? "type_parameters" : "instance_parameters"] as JsonArray;
            var categoryMatch = available?.FirstOrDefault(item => string.Equals(NodeText(item?["name"]), parameter, StringComparison.OrdinalIgnoreCase));
            if (categoryMatch is null) return new JsonObject { ["status"] = "missing", ["message"] = $"Parameter '{parameter}' is not available in the requested scope for category '{NodeText(categoryNode)}'" };
            if (categoryMatch["is_read_only"]?.GetValue<bool>() == true) return new JsonObject { ["status"] = "blocked", ["message"] = "Parameter is read-only" };
            matched ??= categoryMatch;
        }
        args["parameter"] = matched?["name"]?.DeepClone();
        args["value"] = value;
        args["parameter_scope"] = parameterScope;
    }
    var plan = new JsonObject
    {
        ["schema"] = "artel.revit_operator_plan.v2", ["status"] = "ready", ["summary"] = operation,
        ["operations"] = new JsonArray(new JsonObject
        {
            ["op"] = operation, ["target_ids"] = new JsonArray(), ["arguments"] = args,
            ["transaction"] = operation == "create_schedule" ? "ARTEL create schedule" : operation == "set_parameter" ? "ARTEL set parameter" : "selection only",
            ["expected_result"] = operation, ["rollback"] = requiresConfirmation ? "Transaction rollback" : "restore selection"
        }),
        ["missing"] = new JsonArray(), ["risks"] = new JsonArray()
    };
    var planJson = ModelJson(plan);
    var hash = Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(System.Text.Encoding.UTF8.GetBytes(planJson))).ToLowerInvariant();
    return new JsonObject
    {
        ["status"] = "ready", ["operation"] = operation, ["requires_confirmation"] = requiresConfirmation,
        ["summary"] = operation == "select_elements" ? $"Выделить элементы: {QuerySummary(query)}"
            : operation == "create_schedule" ? $"Создать спецификацию «{args["schedule_name"]}»"
            : $"Изменить параметр «{args["parameter"]}»: {QuerySummary(query)}",
        ["planJson"] = planJson, ["confirmationHash"] = hash
    };
}

static string QuerySummary(JsonObject query)
{
    var parts = new List<string>();
    var categories = query["categories"] as JsonArray ?? new JsonArray();
    if (categories.Count > 0) parts.Add(string.Join(", ", categories.Select(node => NodeText(node))));
    foreach (var name in new[] { "family", "type", "system" })
    {
        var value = NodeText(query[name]);
        if (!string.IsNullOrWhiteSpace(value)) parts.Add($"{name}={value}");
    }
    var filters = query["parameter_filters"] as JsonArray ?? new JsonArray();
    if (filters.Count > 0) parts.Add($"условий по параметрам: {filters.Count}");
    parts.Add($"область: {NodeText(query["scope"], "model")}");
    return string.Join("; ", parts);
}

static bool TextMatches(string? actual, string? requested)
{
    if (string.IsNullOrWhiteSpace(requested)) return true;
    if (string.IsNullOrWhiteSpace(actual)) return false;
    return actual.Contains(requested, StringComparison.OrdinalIgnoreCase)
        || requested.Contains(actual, StringComparison.OrdinalIgnoreCase);
}

static async Task<JsonNode?> SearchAssistantEvidenceAsync(
    IHttpClientFactory factory,
    IConfiguration configuration,
    ArtelAssistantRequest input,
    string query)
{
    var options = LesOptions.FromConfiguration(configuration);
    using var client = factory.CreateClient();
    client.Timeout = TimeSpan.FromSeconds(options.TimeoutSeconds);
    using var request = CreateLesRequest(HttpMethod.Post, options, "/api/search");
    request.Content = JsonContent.Create(new
    {
        query,
        dataset_filter = string.IsNullOrWhiteSpace(input.DatasetFilter) ? "ARTEL" : input.DatasetFilter,
        top_k = input.TopK is > 0 and <= 20 ? input.TopK : 8,
        include_trace = true
    });
    try
    {
        using var response = await client.SendAsync(request);
        return TryParseJson(await response.Content.ReadAsStringAsync());
    }
    catch (Exception error) when (error is HttpRequestException or TaskCanceledException)
    {
        return new JsonObject { ["status"] = "unavailable", ["error"] = error.GetType().Name };
    }
}

static string ResolveAppRoot(string contentRootPath)
{
    var candidates = new[]
    {
        Path.Combine(contentRootPath, "app"),
        Path.Combine(contentRootPath, "products", "artel", "app"),
        Path.Combine(contentRootPath, "..", "app"),
        Path.Combine(contentRootPath, "..", "..", "app"),
        Path.Combine(contentRootPath, "..", "..", "..", "app"),
        Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "..", "app"),
    };

    foreach (var candidate in candidates.Select(Path.GetFullPath))
    {
        if (Directory.Exists(candidate) && File.Exists(Path.Combine(candidate, "index.html")))
        {
            return candidate;
        }
    }

    return Path.GetFullPath(Path.Combine(contentRootPath, "app"));
}

static string LoadOperatorSkill(string contentRootPath)
{
    var candidates = new[]
    {
        Path.Combine(contentRootPath, "skills", "revit-api-operator", "SKILL.md"),
        Path.Combine(contentRootPath, "..", "skills", "revit-api-operator", "SKILL.md"),
        Path.Combine(contentRootPath, "..", "..", "skills", "revit-api-operator", "SKILL.md"),
        Path.Combine(contentRootPath, "products", "artel", "skills", "revit-api-operator", "SKILL.md")
    };
    var path = candidates.Select(Path.GetFullPath).FirstOrDefault(File.Exists);
    return path is null
        ? "Skill unavailable: keep all operator actions read-only until a plan is confirmed."
        : File.ReadAllText(path);
}

static JsonNode? TryParseJson(string body)
{
    if (string.IsNullOrWhiteSpace(body))
    {
        return null;
    }

    try
    {
        return JsonNode.Parse(body);
    }
    catch
    {
        return new JsonObject { ["raw"] = body };
    }
}

static JsonObject CreateLesTimeoutBody(int timeoutSeconds)
{
    return new JsonObject
    {
        ["error"] = "timeout",
        ["timeoutSeconds"] = timeoutSeconds
    };
}

static string BuildDefaultLesQuestion(FamilyTask task, FamilySpecification? specification)
{
    var parameterNames = specification is null
        ? "нет утвержденной спецификации"
        : string.Join(", ", specification.Parameters.Select(parameter => parameter.Name));

    return
        $"Найди похожие ARTEL/RFA кейсы и типовые ошибки для разработки Revit-семейства. " +
        $"Задание: {task.Number} {task.Title}. Категория: {task.RevitCategory ?? "не указана"}. " +
        $"Параметры спецификации: {parameterNames}. " +
        "Нужны релевантные образцы, параметры, risks и checklist для приемки.";
}

static JsonObject BuildLearningCase(
    FamilyTask task,
    FamilySpecification specification,
    ValidationReport report,
    CatalogItem? catalogItem)
{
    var parameters = new JsonArray();
    foreach (var parameter in specification.Parameters)
    {
        parameters.Add(new JsonObject
        {
            ["name"] = parameter.Name,
            ["value_or_rule"] = parameter.DefaultValue ?? parameter.Formula ?? parameter.Notes ?? (parameter.IsRequired ? "required" : "optional"),
            ["group"] = parameter.Group
        });
    }

    var checks = new JsonArray();
    foreach (var item in specification.AcceptanceChecklist)
    {
        checks.Add(item);
    }
    foreach (var issue in report.Issues)
    {
        checks.Add($"{issue.Severity}: {issue.Code} - {issue.Title}");
    }

    var knownFailures = new JsonArray();
    foreach (var issue in report.Issues.Where(issue => !string.Equals(issue.Severity, "info", StringComparison.OrdinalIgnoreCase)))
    {
        knownFailures.Add($"{issue.Code}: {issue.Description}");
    }

    var fixes = new JsonArray();
    foreach (var action in report.Actions)
    {
        fixes.Add($"{action.Type} {action.Target}: {action.Status}{(string.IsNullOrWhiteSpace(action.Message) ? "" : " - " + action.Message)}");
    }

    return new JsonObject
    {
        ["schema_version"] = "artel.family_learning_case.v1",
        ["case_id"] = $"validation_{report.Id}",
        ["product"] = "ARTEL",
        ["visibility"] = "private_runtime",
        ["task"] = new JsonObject
        {
            ["title"] = task.Title,
            ["family_category"] = specification.RevitCategory,
            ["family_name"] = specification.FamilyName,
            ["goal"] = task.Description ?? task.Title,
            ["constraints"] = ToJsonArray(specification.AcceptanceChecklist)
        },
        ["source_summaries"] = new JsonArray
        {
            new JsonObject
            {
                ["kind"] = "validation_report",
                ["summary"] = report.Summary
            }
        },
        ["specification"] = new JsonObject
        {
            ["types"] = ToJsonArray(specification.Types.Select(type => type.Name)),
            ["geometry"] = "See approved ARTEL specification and Revit validation report.",
            ["materials"] = ToJsonArray(specification.Materials.Select(material => $"{material.Name}: {material.DefaultValue ?? material.ParameterName ?? "not specified"}")),
            ["parameters"] = parameters
        },
        ["parameter_profile"] = new JsonObject
        {
            ["fop_profile"] = specification.SharedParameterProfileId ?? "not specified",
            ["required_shared_parameters"] = ToJsonArray(specification.Parameters
                .Where(parameter => parameter.Source.Contains("shared", StringComparison.OrdinalIgnoreCase) || parameter.SharedParameterGuid is not null)
                .Select(parameter => string.IsNullOrWhiteSpace(parameter.SharedParameterGuid)
                    ? parameter.Name
                    : $"{parameter.Name} ({parameter.SharedParameterGuid})"))
        },
        ["validation_report"] = new JsonObject
        {
            ["status"] = report.Status,
            ["checks"] = checks,
            ["known_failures"] = knownFailures,
            ["fixes"] = fixes
        },
        ["catalog_card"] = new JsonObject
        {
            ["display_name"] = catalogItem?.Name ?? specification.FamilyName,
            ["category"] = catalogItem?.Category ?? specification.RevitCategory,
            ["tags"] = ToJsonArray(catalogItem?.Tags ?? [specification.RevitCategory, "revit-family"]),
            ["search_terms"] = ToJsonArray(new[]
            {
                specification.FamilyName,
                specification.RevitCategory,
                task.Number,
                "RFA",
                "ARTEL"
            })
        },
        ["acceptance"] = new JsonObject
        {
            ["outcome"] = report.Status,
            ["accepted_by_role"] = "ARTEL validation workflow",
            ["notes"] = report.Summary
        }
    };
}

static JsonArray ToJsonArray(IEnumerable<string> values)
{
    var array = new JsonArray();
    foreach (var value in values)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            array.Add(value);
        }
    }
    return array;
}

static class TaskStatuses
{
    public const string Draft = "draft";
    public const string ReadyForDevelopment = "ready_for_development";
    public const string InDevelopment = "in_development";
}

static class SpecificationStatuses
{
    public const string Draft = "draft";
    public const string Approved = "approved";
}

record HealthResponse(string Status, DateTimeOffset CheckedAt);

record ArtelAssistantRequest(string Question, string? DatasetFilter, int? TopK, string? Mode, JsonNode? Context);
record ArtelLiveAssistantRequest(string Question, string? DatasetFilter, int? TopK, JsonNode? Conversation, JsonNode? ToolResult);

record LesOptions(string BaseUrl, string? ApiKey, int TimeoutSeconds)
{
    public static LesOptions FromConfiguration(IConfiguration configuration)
    {
        var baseUrl = configuration["Les:BaseUrl"] ?? Environment.GetEnvironmentVariable("LES_BASE_URL") ?? "http://127.0.0.1:8050";
        var apiKey = configuration["Les:ApiKey"] ?? Environment.GetEnvironmentVariable("LES_API_KEY");
        var timeoutSeconds = ParseTimeoutSeconds(
            configuration["Les:TimeoutSeconds"]
            ?? Environment.GetEnvironmentVariable("LES_TIMEOUT_SECONDS"));

        return new LesOptions(baseUrl.TrimEnd('/') + "/", apiKey, timeoutSeconds);
    }

    private static int ParseTimeoutSeconds(string? value)
    {
        if (!int.TryParse(value, out var timeoutSeconds))
        {
            return 120;
        }

        return Math.Clamp(timeoutSeconds, 1, 600);
    }
}

record LesStatusResponse(
    string Status,
    string BaseUrl,
    int HttpStatus,
    JsonNode? Health,
    DateTimeOffset CheckedAt);

record ApiError(ApiErrorBody Error)
{
    public static ApiError Create(string code, string message) => new(new ApiErrorBody(code, message));
}

record ApiErrorBody(string Code, string Message);

record CreateTaskRequest(
    string Title,
    string? Description,
    string? RevitCategory,
    string? AssignedTo,
    DateOnly? DueDate);

record FamilyTask(
    string Id,
    string Number,
    string Title,
    string? Description,
    string Status,
    string? RevitCategory,
    string? AssignedTo,
    DateOnly? DueDate,
    DateTimeOffset CreatedAt,
    DateTimeOffset UpdatedAt);

record TaskSummary(
    string Id,
    string Number,
    string Title,
    string Status,
    string? RevitCategory,
    string? AssignedTo,
    DateOnly? DueDate)
{
    public static TaskSummary FromTask(FamilyTask task)
    {
        return new TaskSummary(
            task.Id,
            task.Number,
            task.Title,
            task.Status,
            task.RevitCategory,
            task.AssignedTo,
            task.DueDate);
    }
}

record SourceFile(
    string Id,
    string TaskId,
    string Name,
    string Kind,
    string DownloadUrl);

record LesRagContextRequest(
    string? Question,
    string? DatasetFilter,
    int? TopK,
    bool? IncludeTrace,
    bool? ValidationEnabled,
    bool? RerankerEnabled,
    bool? SemanticCacheEnabled);

record LesRagContextResult(
    string Status,
    string TaskId,
    string DatasetFilter,
    string Question,
    string LesBaseUrl,
    int HttpStatus,
    JsonNode? Response,
    DateTimeOffset CreatedAt);

record FamilySpecification(
    string Id,
    string TaskId,
    string Status,
    string FamilyName,
    string RevitCategory,
    string? TemplateFileId,
    string? SharedParameterProfileId,
    IReadOnlyList<SpecificationParameter> Parameters,
    IReadOnlyList<SpecificationType> Types,
    IReadOnlyList<SpecificationMaterial> Materials,
    IReadOnlyList<string> AcceptanceChecklist,
    DateTimeOffset CreatedAt,
    DateTimeOffset UpdatedAt);

record SpecificationParameter(
    string Id,
    string Name,
    string Source,
    string? SharedParameterGuid,
    string DataType,
    string Group,
    bool IsInstance,
    bool IsRequired,
    string? DefaultValue,
    string? Formula,
    string? Notes);

record SpecificationType(
    string Id,
    string Name,
    IReadOnlyDictionary<string, object?> Values,
    string? Notes);

record SpecificationMaterial(
    string Id,
    string Name,
    string? ParameterName,
    string? DefaultValue);

record RevitTaskPackage(
    TaskSummary Task,
    FamilySpecification Specification,
    IReadOnlyList<SourceFile> Files);

record ValidationReportRequest(
    string Status,
    string Summary,
    IReadOnlyList<ValidationIssue> Issues,
    IReadOnlyList<ValidationAction> Actions);

record ValidationReport(
    string Id,
    string TaskId,
    string Status,
    string Summary,
    IReadOnlyList<ValidationIssue> Issues,
    IReadOnlyList<ValidationAction> Actions,
    DateTimeOffset CreatedAt);

record ValidationIssue(
    string Severity,
    string Code,
    string Title,
    string Description,
    string? RevitElementId,
    string? SuggestedFix);

record ValidationAction(
    string Type,
    string Target,
    string Status,
    string? Message);

record CatalogItem(
    string Id,
    string Name,
    string Category,
    string Description,
    string Status,
    string CurrentVersion,
    string? CurrentVersionId,
    string? CurrentRfaFileId,
    string RevitCompatibility,
    string FileSize,
    IReadOnlyList<string> Tags,
    DateTimeOffset UpdatedAt);

record CatalogItemDetail(
    CatalogItem Item,
    IReadOnlyList<FamilyVersion> Versions);

record FamilyVersion(
    string Id,
    string CatalogItemId,
    string? TaskId,
    string Version,
    string RfaFileId,
    string Status,
    string? Changelog,
    string? SubmittedBy,
    DateTimeOffset SubmittedAt);

record PublishCatalogVersionRequest(
    string Version,
    string RfaFileId,
    string? TaskId,
    string? Changelog,
    string? SubmittedBy);

record CreateCatalogUpdateTaskRequest(
    string Reason,
    string? AssignedTo,
    DateOnly? DueDate);

record CatalogUpdateTaskResult(
    string TaskId,
    string TaskNumber,
    string CatalogItemId);

record AppStore(
    ConcurrentDictionary<string, FamilyTask> Tasks,
    ConcurrentDictionary<string, FamilySpecification> Specifications,
    ConcurrentDictionary<string, SourceFile> Files,
    ConcurrentDictionary<string, ValidationReport> ValidationReports,
    ConcurrentDictionary<string, CatalogItem> Catalog,
    ConcurrentDictionary<string, FamilyVersion> FamilyVersions);

sealed class ValidationReportArchive
{
    private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web)
    {
        WriteIndented = true
    };

    private readonly string _reportsDir;

    private ValidationReportArchive(string reportsDir)
    {
        _reportsDir = reportsDir;
    }

    public static ValidationReportArchive FromConfiguration(IConfiguration configuration, string contentRootPath)
    {
        var dataRoot = configuration["ARTEL_DATA_DIR"];
        if (string.IsNullOrWhiteSpace(dataRoot))
        {
            dataRoot = Path.Combine(contentRootPath, "artel_data");
        }

        return new ValidationReportArchive(Path.Combine(dataRoot, "validation_reports"));
    }

    public void LoadInto(ConcurrentDictionary<string, ValidationReport> target)
    {
        if (!Directory.Exists(_reportsDir))
        {
            return;
        }

        foreach (var path in Directory.EnumerateFiles(_reportsDir, "*.json", SearchOption.TopDirectoryOnly))
        {
            try
            {
                var report = JsonSerializer.Deserialize<ValidationReport>(File.ReadAllText(path), JsonOptions);
                if (report is not null && !string.IsNullOrWhiteSpace(report.Id))
                {
                    target[report.Id] = report;
                }
            }
            catch
            {
                // Keep serving valid reports even if one archived file is corrupt.
            }
        }
    }

    public void Save(ValidationReport report)
    {
        Directory.CreateDirectory(_reportsDir);
        var path = Path.Combine(_reportsDir, $"{report.Id}.json");
        var tmpPath = path + ".tmp";
        File.WriteAllText(tmpPath, JsonSerializer.Serialize(report, JsonOptions));
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        File.Move(tmpPath, path);
    }
}

static class SeedData
{
    public static AppStore Create()
    {
        var task = new FamilyTask(
            Id: "task_0241",
            Number: "FAM-0241",
            Title: "Шкаф архивный металлический",
            Description: "Параметрическое семейство шкафа с линейкой типоразмеров.",
            Status: TaskStatuses.ReadyForDevelopment,
            RevitCategory: "Furniture",
            AssignedTo: "family.developer@example.com",
            DueDate: new DateOnly(2026, 6, 12),
            CreatedAt: DateTimeOffset.UtcNow,
            UpdatedAt: DateTimeOffset.UtcNow);

        var specification = new FamilySpecification(
            Id: "spec_0241",
            TaskId: task.Id,
            Status: SpecificationStatuses.Approved,
            FamilyName: "Шкаф архивный металлический",
            RevitCategory: "Furniture",
            TemplateFileId: "file_template_001",
            SharedParameterProfileId: "fop_2026",
            Parameters:
            [
                new SpecificationParameter("param_001", "ADSK_Наименование", "shared_parameter", "4f5cb6a1-0000-0000-0000-000000000000", "Text", "Identity Data", false, true, null, null, null),
                new SpecificationParameter("param_002", "Ширина", "family_parameter", null, "Length", "Dimensions", false, true, null, null, null),
                new SpecificationParameter("param_003", "Высота", "family_parameter", null, "Length", "Dimensions", false, true, null, null, null)
            ],
            Types:
            [
                new SpecificationType("type_001", "Шкаф 800x400x1800", new Dictionary<string, object?>
                {
                    ["Ширина"] = 800,
                    ["Глубина"] = 400,
                    ["Высота"] = 1800
                }, null)
            ],
            Materials:
            [
                new SpecificationMaterial("mat_001", "Материал корпуса", "Материал корпуса", "RAL 7035")
            ],
            AcceptanceChecklist:
            [
                "Все обязательные параметры существуют",
                "Все типы из спецификации созданы",
                "Материалы назначены параметрически"
            ],
            CreatedAt: DateTimeOffset.UtcNow,
            UpdatedAt: DateTimeOffset.UtcNow);

        var catalogItem = new CatalogItem(
            Id: "catalog_001",
            Name: "Шкаф архивный металлический",
            Category: "Furniture",
            Description: "Параметрическое семейство шкафа.",
            Status: "active",
            CurrentVersion: "0.1.0",
            CurrentVersionId: "version_001",
            CurrentRfaFileId: "file_rfa_001",
            RevitCompatibility: "2023-2025",
            FileSize: "1.8 MB",
            Tags: ["мебель", "шкаф", "архив"],
            UpdatedAt: DateTimeOffset.UtcNow);

        var familyVersion = new FamilyVersion(
            Id: "version_001",
            CatalogItemId: catalogItem.Id,
            TaskId: task.Id,
            Version: "0.1.0",
            RfaFileId: "file_rfa_001",
            Status: "published",
            Changelog: "Initial MVP catalog version",
            SubmittedBy: "bim.manager@example.com",
            SubmittedAt: DateTimeOffset.UtcNow);

        return new AppStore(
            Tasks: new ConcurrentDictionary<string, FamilyTask>(new[] { KeyValuePair.Create(task.Id, task) }),
            Specifications: new ConcurrentDictionary<string, FamilySpecification>(new[] { KeyValuePair.Create(task.Id, specification) }),
            Files: new ConcurrentDictionary<string, SourceFile>(new[]
            {
                KeyValuePair.Create("file_001", new SourceFile("file_001", task.Id, "ТЗ_шкаф_архивный.pdf", "brief", "/api/files/file_001/download"))
            }),
            ValidationReports: new ConcurrentDictionary<string, ValidationReport>(),
            Catalog: new ConcurrentDictionary<string, CatalogItem>(new[]
            {
                KeyValuePair.Create(catalogItem.Id, catalogItem)
            }),
            FamilyVersions: new ConcurrentDictionary<string, FamilyVersion>(new[]
            {
                KeyValuePair.Create(familyVersion.Id, familyVersion)
            }));
    }
}
