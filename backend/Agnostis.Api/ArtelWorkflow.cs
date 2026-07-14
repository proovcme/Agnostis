using System.IO.Compression;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Xml.Linq;

internal static class ArtelWorkflow
{
    private const int MaxSourceBytes = 25 * 1024 * 1024;
    private static readonly HashSet<string> ImageExtensions = new(StringComparer.OrdinalIgnoreCase)
    {
        ".png", ".jpg", ".jpeg", ".webp"
    };
    private static readonly HashSet<string> AllowedOperatorOps = new(StringComparer.OrdinalIgnoreCase)
    {
        "set_parameter", "select_elements", "select_category"
    };

    public static void MapArtelWorkflow(this WebApplication app)
    {
        app.MapPost("/api/generator/draft", CreateGeneratorDraftAsync);
        app.MapPost("/api/operator/plan", CreateOperatorPlanAsync);
    }

    private static async Task<IResult> CreateGeneratorDraftAsync(
        GeneratorDraftRequest input,
        IHttpClientFactory httpClientFactory,
        IConfiguration configuration,
        IWebHostEnvironment environment)
    {
        if (string.IsNullOrWhiteSpace(input.Description)
            && string.IsNullOrWhiteSpace(input.SourceUrl)
            && string.IsNullOrWhiteSpace(input.ContentBase64))
        {
            return Results.BadRequest(new { error = new { code = "source_required", message = "Добавьте описание, файл, ссылку или изображение." } });
        }

        byte[]? bytes = null;
        if (!string.IsNullOrWhiteSpace(input.ContentBase64))
        {
            try { bytes = Convert.FromBase64String(input.ContentBase64); }
            catch (FormatException) { return Results.BadRequest(new { error = new { code = "invalid_base64", message = "Файл повреждён или имеет неверный формат." } }); }
            if (bytes.Length > MaxSourceBytes)
            {
                return Results.BadRequest(new { error = new { code = "source_too_large", message = "Размер одного источника не должен превышать 25 МБ." } });
            }
        }

        var sourceName = string.IsNullOrWhiteSpace(input.SourceName) ? "описание" : Path.GetFileName(input.SourceName);
        var extension = Path.GetExtension(sourceName);
        var sourceText = new StringBuilder();
        if (!string.IsNullOrWhiteSpace(input.Description)) sourceText.AppendLine(input.Description.Trim());
        JsonNode? documentEvidence = null;

        if (bytes is not null && bytes.Length > 0 && !ImageExtensions.Contains(extension))
        {
            if (extension.Equals(".docx", StringComparison.OrdinalIgnoreCase)) sourceText.AppendLine(ExtractDocx(bytes));
            else if (extension.Equals(".xlsx", StringComparison.OrdinalIgnoreCase)) sourceText.AppendLine(ExtractXlsx(bytes));
            else if (extension.Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                documentEvidence = await IngestPdfAndRetrieveAsync(httpClientFactory, configuration, sourceName, bytes);
            else sourceText.AppendLine(Encoding.UTF8.GetString(bytes));
        }

        if (!string.IsNullOrWhiteSpace(input.SourceUrl))
        {
            sourceText.AppendLine(await ReadUrlTextAsync(httpClientFactory, input.SourceUrl));
        }

        var evidenceQuestion = $"Требования к Revit-семейству: {input.Description} {sourceName}. Найди применимые правила семейства, FOP и API evidence.";
        var artelEvidence = await SearchLesAsync(httpClientFactory, configuration, evidenceQuestion, "ARTEL", 8);
        var generatorSkill = LoadGeneratorSkill(environment.ContentRootPath);
        var modelPrompt = BuildGeneratorPrompt(input, sourceName, sourceText.ToString(), artelEvidence, documentEvidence, generatorSkill);
        var images = bytes is not null && ImageExtensions.Contains(extension) ? new[] { Convert.ToBase64String(bytes) } : Array.Empty<string>();

        JsonObject specification;
        try
        {
            try { specification = await AskOllamaForObjectAsync(httpClientFactory, configuration, modelPrompt, images); }
            catch (InvalidOperationException) { specification = new JsonObject(); }
            if (!LooksLikeFamilySpecification(specification))
            {
                var retryPrompt = $$$"""
                    Ты JSON-нормализатор результата BIM-модели. Переведи ЕЁ СОБСТВЕННЫЙ черновик в точный artel.family_spec.v1.
                    Не выбирай новую категорию, параметры, размеры, геометрию или материалы. Не добавляй отсутствующие факты:
                    помещай их в missing и blocking_questions. Сохрани профессиональные решения модели без изменений.
                    Используй только точные snake_case ключи из схемы ниже и верни только JSON.

                    Схема:
                    {"family_name":"...","category":"...","template":"...|MISSING","parameters":[{"name":"...","data_type":"Text|Length|Material|Number","group":"Dimensions|Identity Data|Materials and Finishes","is_instance":false,"is_required":true,"shared_guid":null}],"types":[{"name":"...","values":{}}],"materials":[],"geometry":{"shape":"...","width_parameter":"...","depth_parameter":"...","height_parameter":"...","features":[]},"acceptance_checklist":[],"missing":[],"blocking_questions":[],"provenance":[]}

                    Исходный запрос: {{{Limit(input.Description ?? sourceName, 3000)}}}
                    Черновик модели: {{{Limit(specification.ToJsonString(), 5000)}}}
                    """;
                try { specification = await AskOllamaForObjectAsync(httpClientFactory, configuration, retryPrompt, images); }
                catch (InvalidOperationException) { specification = new JsonObject(); }
            }
        }
        catch (Exception error) when (error is HttpRequestException or TaskCanceledException)
        {
            return Results.Json(new
            {
                status = "model_unavailable",
                message = "Не удалось сформировать спецификацию. Проверьте Ollama и наличие qwen3.5:9b.",
                detail = error.Message
            }, statusCode: 503);
        }

        specification = NormalizeFamilySpecification(specification, input.Description, sourceName);
        specification["source_name"] = sourceName;
        specification["source_url"] = input.SourceUrl;
        var plan = CompileFamilyPlan(specification);
        var planJson = plan.ToJsonString(new JsonSerializerOptions { WriteIndented = false });
        var confirmationHash = Sha256(planJson);

        return Results.Ok(new
        {
            status = plan["status"]?.GetValue<string>() == "ok" ? "ready" : "missing",
            specification,
            plan,
            planJson,
            confirmationHash,
            source = new
            {
                name = sourceName,
                kind = ImageExtensions.Contains(extension) ? "image" : extension.TrimStart('.'),
                pdfIngestedToLes = documentEvidence is not null
            },
            evidence = artelEvidence
        });
    }

    private static async Task<IResult> CreateOperatorPlanAsync(
        OperatorPlanRequest input,
        IHttpClientFactory httpClientFactory,
        IConfiguration configuration)
    {
        if (string.IsNullOrWhiteSpace(input.Question))
            return Results.BadRequest(new { error = new { code = "question_required", message = "Опишите действие в Revit." } });

        var context = input.Context as JsonObject ?? new JsonObject();
        var selectedIds = (context["selected_element_ids"] as JsonArray)?
            .Select(value => value?.GetValue<long>() ?? 0).Where(value => value > 0).Distinct().ToArray() ?? Array.Empty<long>();
        var evidence = await SearchLesAsync(httpClientFactory, configuration, input.Question, "ARTEL", 8);
        var prompt = $$"""
            Ты планировщик безопасного оператора Autodesk Revit 2024/2025.
            Верни только JSON-объект. Разрешённые операции: set_parameter, select_elements, select_category.
            set_parameter: arguments = {"parameter":"точное имя", "value":"значение"}; target_ids только из selection.
            select_elements: target_ids только из доступных element ids.
            select_category: arguments = {"category":"точное имя из model_inventory"}; target_ids=[]; используй для запросов «выдели все ...».
            Если запрос нельзя выполнить этим allowlist или данных недостаточно, status=missing и operations=[].
            Не придумывай ids, параметры, API или значения. Не утверждай, что действие выполнено.
            Для selection-запроса model_inventory — единственный источник целей: дословно скопируй category и count из него.
            LES evidence не может изменить имя/состав цели selection.

            JSON shape:
            {"status":"ready|missing|blocked","summary":"...","operations":[{"op":"set_parameter|select_elements|select_category","target_ids":[1],"arguments":{},"evidence_refs":[],"transaction":"...","expected_result":"...","rollback":"Transaction rollback"}],"missing":[],"risks":[]}

            Запрос: {{input.Question.Trim()}}
            Контекст Revit: {{context.ToJsonString()}}
            LES evidence: {{EvidenceForPrompt(evidence)}}
            """;

        JsonObject draft;
        try
        {
            draft = await AskOllamaForObjectAsync(httpClientFactory, configuration, prompt, Array.Empty<string>(), preserveUnparsed: true, responseFormat: OperatorPlanFormat());
            if (draft["_unparsed_model_output"] is JsonValue rawOutput)
            {
                var retryPrompt = $$"""
                    Ты JSON-нормализатор собственного черновика Revit-плана. Верни только JSON.
                    Не добавляй новые цели, категории, ids, параметры или значения и не меняй профессиональный выбор.
                    Если черновик не содержит безопасной операции, верни status=missing и operations=[].

                    Точная схема:
                    {"status":"ready|missing|blocked","summary":"...","operations":[{"op":"set_parameter|select_elements|select_category","target_ids":[],"arguments":{},"evidence_refs":[],"transaction":"...","expected_result":"...","rollback":"Transaction rollback"}],"missing":[],"risks":[]}

                    Исходный запрос: {{Limit(input.Question, 2000)}}
                    Контекст Revit: {{Limit(context.ToJsonString(), 8000)}}
                    Собственный черновик модели: {{Limit(rawOutput.GetValue<string>(), 8000)}}
                    """;
                draft = await AskOllamaForObjectAsync(httpClientFactory, configuration, retryPrompt, Array.Empty<string>(), responseFormat: OperatorPlanFormat());
            }
        }
        catch (Exception error) when (error is HttpRequestException or TaskCanceledException or InvalidOperationException)
        {
            return Results.Json(new { status = "model_unavailable", message = "Ollama не подготовила план.", detail = error.Message }, statusCode: 503);
        }

        var normalized = NormalizeOperatorPlan(draft, context, selectedIds);
        var planJson = normalized.ToJsonString(new JsonSerializerOptions { WriteIndented = false });
        var confirmationHash = Sha256(planJson);
        var responsePlan = normalized.DeepClone().AsObject();
        responsePlan["confirmation_hash"] = confirmationHash;
        return Results.Ok(new { status = normalized["status"]?.GetValue<string>(), plan = responsePlan, planJson, confirmationHash, evidence });
    }

    private static JsonObject NormalizeOperatorPlan(JsonObject draft, JsonObject context, long[] selectedIds)
    {
        var selected = selectedIds.ToHashSet();
        var categoryCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        foreach (var item in context["model_inventory"] as JsonArray ?? new JsonArray())
        {
            if (item is not JsonObject row) continue;
            var category = row["category"]?.GetValue<string>() ?? "";
            var count = row["count"]?.GetValue<int>() ?? 0;
            if (category.Length > 0) categoryCounts[category] = categoryCounts.GetValueOrDefault(category) + count;
        }
        var operations = new JsonArray();
        foreach (var item in draft["operations"] as JsonArray ?? new JsonArray())
        {
            if (item is not JsonObject operation) continue;
            var op = operation["op"]?.GetValue<string>() ?? "";
            if (!AllowedOperatorOps.Contains(op)) continue;
            if (op == "select_category")
            {
                var category = operation["arguments"]?["category"]?.GetValue<string>() ?? "";
                if (!categoryCounts.TryGetValue(category, out var expectedCount) || expectedCount <= 0) continue;
                operations.Add(new JsonObject
                {
                    ["op"] = op, ["target_ids"] = new JsonArray(),
                    ["arguments"] = new JsonObject { ["category"] = category, ["expected_count"] = expectedCount },
                    ["evidence_refs"] = new JsonArray("typed:model_inventory"),
                    ["transaction"] = "ARTEL select category", ["expected_result"] = $"Выбрать {expectedCount} элементов категории '{category}'",
                    ["rollback"] = "Restore previous selection"
                });
                continue;
            }
            var ids = new JsonArray();
            foreach (var idNode in operation["target_ids"] as JsonArray ?? new JsonArray())
            {
                var id = idNode?.GetValue<long>() ?? 0;
                if (id > 0 && selected.Contains(id)) ids.Add(id);
            }
            if (ids.Count == 0) continue;
            operations.Add(new JsonObject
            {
                ["op"] = op,
                ["target_ids"] = ids,
                ["arguments"] = operation["arguments"]?.DeepClone() ?? new JsonObject(),
                ["evidence_refs"] = operation["evidence_refs"]?.DeepClone() ?? new JsonArray(),
                ["transaction"] = operation["transaction"]?.GetValue<string>() ?? $"ARTEL {op}",
                ["expected_result"] = operation["expected_result"]?.GetValue<string>() ?? "Проверяемое изменение выбранных элементов",
                ["rollback"] = "Transaction rollback"
            });
        }
        var requestedStatus = draft["status"]?.GetValue<string>() ?? "missing";
        var status = operations.Count > 0 && requestedStatus == "ready" ? "ready" : "missing";
        return new JsonObject
        {
            ["schema"] = "artel.revit_operator_plan.v1",
            ["status"] = status,
            ["revit_version"] = context["revit_version"]?.GetValue<string>() ?? "unknown",
            ["summary"] = draft["summary"]?.GetValue<string>() ?? "План требует уточнения",
            ["operations"] = operations,
            ["missing"] = draft["missing"]?.DeepClone() ?? new JsonArray(),
            ["risks"] = draft["risks"]?.DeepClone() ?? new JsonArray()
        };
    }

    private static JsonObject OperatorPlanFormat() => new()
    {
        ["type"] = "object",
        ["required"] = new JsonArray("status", "summary", "operations", "missing", "risks"),
        ["properties"] = new JsonObject
        {
            ["status"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("ready", "missing", "blocked") },
            ["summary"] = new JsonObject { ["type"] = "string" },
            ["operations"] = new JsonObject
            {
                ["type"] = "array",
                ["items"] = new JsonObject
                {
                    ["type"] = "object",
                    ["required"] = new JsonArray("op", "target_ids", "arguments", "evidence_refs", "transaction", "expected_result", "rollback"),
                    ["properties"] = new JsonObject
                    {
                        ["op"] = new JsonObject { ["type"] = "string", ["enum"] = new JsonArray("set_parameter", "select_elements", "select_category") },
                        ["target_ids"] = new JsonObject { ["type"] = "array", ["items"] = new JsonObject { ["type"] = "integer" } },
                        ["arguments"] = new JsonObject { ["type"] = "object" },
                        ["evidence_refs"] = new JsonObject { ["type"] = "array", ["items"] = new JsonObject { ["type"] = "string" } },
                        ["transaction"] = new JsonObject { ["type"] = "string" },
                        ["expected_result"] = new JsonObject { ["type"] = "string" },
                        ["rollback"] = new JsonObject { ["type"] = "string" }
                    }
                }
            },
            ["missing"] = new JsonObject { ["type"] = "array", ["items"] = new JsonObject { ["type"] = "string" } },
            ["risks"] = new JsonObject { ["type"] = "array", ["items"] = new JsonObject { ["type"] = "string" } }
        }
    };

    private static JsonObject CompileFamilyPlan(JsonObject specification)
    {
        var operations = new JsonArray();
        var parameterNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var item in specification["parameters"] as JsonArray ?? new JsonArray())
        {
            if (item is not JsonObject parameter) continue;
            var name = StringValue(parameter["name"]).Trim();
            if (name.Length == 0 || !parameterNames.Add(name)) continue;
            var guid = StringValue(parameter["shared_guid"]);
            var shared = Guid.TryParse(guid, out _);
            var operation = new JsonObject
            {
                ["op"] = shared ? "add_shared_parameter" : "add_family_parameter",
                ["name"] = name,
                ["data_type"] = StringValue(parameter["data_type"], "Text"),
                ["storage_type"] = "String",
                ["group"] = StringValue(parameter["group"], "Identity Data"),
                ["is_instance"] = BoolValue(parameter["is_instance"]),
                ["is_required"] = BoolValue(parameter["is_required"])
            };
            if (shared) operation["guid"] = guid;
            operations.Add(operation);
        }

        var geometry = specification["geometry"] as JsonObject;
        var width = StringValue(geometry?["width_parameter"]);
        var depth = StringValue(geometry?["depth_parameter"]);
        var height = StringValue(geometry?["height_parameter"]);
        if (parameterNames.Contains(width) && parameterNames.Contains(depth) && parameterNames.Contains(height))
        {
            operations.Add(Extrusion("body", "body", "level", width, depth, new JsonObject { ["parameter"] = height }));
            var features = geometry?["features"] as JsonArray ?? new JsonArray();
            var shelfIndex = 0;
            foreach (var featureNode in features)
            {
                var feature = StringValue(featureNode).ToLowerInvariant();
                if (feature == "door") operations.Add(Extrusion("door", "door", "front", width, height, Constant(18)));
                else if (feature == "back") operations.Add(Extrusion("back", "back", "back", width, height, Constant(4)));
                else if (feature.StartsWith("shelf"))
                {
                    shelfIndex++;
                    var shelf = Extrusion($"shelf_{shelfIndex}", "shelf", "level", width, depth, Constant(18));
                    shelf["placement"]!["z_fraction"] = Math.Min(.9, shelfIndex * .25);
                    operations.Add(shelf);
                }
            }
        }

        foreach (var item in specification["types"] as JsonArray ?? new JsonArray())
        {
            if (item is not JsonObject type) continue;
            var values = new JsonArray();
            foreach (var pair in type["values"] as JsonObject ?? new JsonObject())
                values.Add(new JsonObject { ["parameter"] = pair.Key, ["value"] = pair.Value?.DeepClone() });
            operations.Add(new JsonObject { ["op"] = "create_type", ["name"] = StringValue(type["name"], "Тип 1"), ["values"] = values });
        }
        foreach (var item in specification["materials"] as JsonArray ?? new JsonArray())
        {
            var name = StringValue(item);
            if (!string.IsNullOrWhiteSpace(name)) operations.Add(new JsonObject { ["op"] = "assign_material", ["name"] = name });
        }

        var familyName = StringValue(specification["family_name"], "MISSING");
        var category = StringValue(specification["category"], "MISSING");
        var template = StringValue(specification["template"], "MISSING");
        var hasBlockingQuestions = (specification["blocking_questions"] as JsonArray)?.Count > 0;
        var identityMissing = new[] { familyName, category, template }.Any(value => string.Equals(value, "MISSING", StringComparison.OrdinalIgnoreCase));
        var planReady = operations.Count > 0 && !hasBlockingQuestions && !identityMissing;

        return new JsonObject
        {
            ["schema_version"] = "artel.family_action_plan.v1",
            ["plan_id"] = $"artel_{Guid.NewGuid():N}",
            ["status"] = planReady ? "ok" : "missing",
            ["compiled_at"] = DateTimeOffset.UtcNow.ToString("O"),
            ["generator"] = new JsonObject { ["mode"] = "deterministic", ["llm_used"] = false, ["tool"] = "artel_sidecar_compiler" },
            ["family"] = new JsonObject
            {
                ["name"] = familyName,
                ["category"] = category,
                ["template_file_id"] = template
            },
            ["operations"] = operations,
            ["missing"] = specification["missing"]?.DeepClone() ?? new JsonArray(),
            ["provenance"] = specification["provenance"]?.DeepClone() ?? new JsonArray()
        };
    }

    private static string StringValue(JsonNode? node, string fallback = "") =>
        node is JsonValue value && value.TryGetValue<string>(out var text) ? text : fallback;

    private static bool BoolValue(JsonNode? node) =>
        node is JsonValue value && value.TryGetValue<bool>(out var flag) && flag;

    private static JsonObject Extrusion(string id, string role, string plane, string width, string depth, JsonObject extrusion) => new()
    {
        ["op"] = "create_extrusion", ["id"] = id, ["role"] = role, ["sketch_plane"] = plane,
        ["placement"] = new JsonObject { ["plane"] = plane },
        ["profile"] = new JsonObject
        {
            ["shape"] = "rectangle",
            ["width"] = new JsonObject { ["parameter"] = width },
            ["depth"] = new JsonObject { ["parameter"] = depth }
        },
        ["extrusion"] = extrusion
    };

    private static JsonObject Constant(double value) => new() { ["constant"] = value, ["unit"] = "mm" };

    private static string BuildGeneratorPrompt(GeneratorDraftRequest input, string sourceName, string sourceText, JsonNode? evidence, JsonNode? documentEvidence, string generatorSkill) => $$$"""
        Ты АРТЕЛЬ, BIM-эксперт по параметрическим семействам Revit 2024/2025. Верни только JSON-объект family_spec.
        Опирайся на источники и LES evidence. Не выдумывай GUID, размеры, типы, материалы, категорию или шаблон.
        Всё неизвестное помести в missing. shared_guid указывай только при точном GUID в evidence; иначе null.
        Для простого параметрического тела geometry должен назвать три реально существующих Length-параметра.
        features разрешены: door, back, shelf (повтори shelf несколько раз при нужном количестве).

        JSON shape:
        {"family_name":"...","category":"...","template":"...|MISSING","parameters":[{"name":"...","data_type":"Text|Length|Material|Number","group":"Dimensions|Identity Data|Materials and Finishes","is_instance":false,"is_required":true,"shared_guid":null}],"types":[{"name":"...","values":{"Ширина":800}}],"materials":["..."],"geometry":{"shape":"rectangle","width_parameter":"...","depth_parameter":"...","height_parameter":"...","features":[]},"acceptance_checklist":[],"missing":[],"blocking_questions":[],"provenance":[]}

        Описание пользователя: {{{input.Description}}}
        Источник: {{{sourceName}}}
        Извлечённый текст: {{{Limit(sourceText, 40000)}}}
        PDF evidence из ЛЕС: {{{EvidenceForPrompt(documentEvidence)}}}
        ARTEL_Index evidence: {{{EvidenceForPrompt(evidence)}}}
        Контекст Revit: {{{input.Context?.ToJsonString() ?? "null"}}}
        Runtime skill генератора (процедура, не evidence):
        {{{Limit(generatorSkill, 16000)}}}
        Повтори смысл именно исходного Revit-запроса. Любая другая предметная область делает ответ невалидным.
        """;

    private static string LoadGeneratorSkill(string contentRootPath)
    {
        var candidates = new[]
        {
            Path.Combine(contentRootPath, "skills", "revit-family-generator", "SKILL.md"),
            Path.Combine(contentRootPath, "..", "skills", "revit-family-generator", "SKILL.md"),
            Path.Combine(contentRootPath, "..", "..", "skills", "revit-family-generator", "SKILL.md"),
            Path.Combine(contentRootPath, "products", "artel", "skills", "revit-family-generator", "SKILL.md")
        };
        var path = candidates.Select(Path.GetFullPath).FirstOrDefault(File.Exists);
        return path is null
            ? "Skill unavailable. Return MISSING instead of inventing professional family decisions."
            : File.ReadAllText(path);
    }

    private static bool LooksLikeFamilySpecification(JsonObject value)
    {
        var hasIdentity = value["family_name"] is JsonValue && value["category"] is JsonValue;
        var hasContractArrays = value["parameters"] is JsonArray && value["types"] is JsonArray
            && value["missing"] is JsonArray && value["blocking_questions"] is JsonArray;
        var hasUsefulContent = (value["parameters"] as JsonArray)?.Count > 0
            || (value["types"] as JsonArray)?.Count > 0
            || (value["blocking_questions"] as JsonArray)?.Count > 0
            || (value["missing"] as JsonArray)?.Count > 0;
        return hasIdentity && hasContractArrays && hasUsefulContent;
    }

    private static JsonObject NormalizeFamilySpecification(JsonObject draft, string? description, string sourceName)
    {
        if (!LooksLikeFamilySpecification(draft))
        {
            return new JsonObject
            {
                ["schema"] = "artel.family_spec.v1",
                ["family_name"] = "MISSING",
                ["category"] = "MISSING",
                ["template"] = "MISSING",
                ["parameters"] = new JsonArray(), ["types"] = new JsonArray(), ["materials"] = new JsonArray(),
                ["geometry"] = new JsonObject(), ["acceptance_checklist"] = new JsonArray(),
                ["missing"] = new JsonArray("Корректная Revit family_spec не получена от модели."),
                ["blocking_questions"] = new JsonArray("Уточните категорию, шаблон и обязательные параметры семейства."),
                ["provenance"] = new JsonArray(), ["source_summary"] = Limit(description ?? sourceName, 1000)
            };
        }
        return new JsonObject
        {
            ["schema"] = "artel.family_spec.v1",
            ["family_name"] = draft["family_name"]?.DeepClone() ?? "MISSING",
            ["category"] = draft["category"]?.DeepClone() ?? "MISSING",
            ["template"] = draft["template"]?.DeepClone() ?? "MISSING",
            ["parameters"] = draft["parameters"]?.DeepClone() ?? new JsonArray(),
            ["types"] = draft["types"]?.DeepClone() ?? new JsonArray(),
            ["materials"] = draft["materials"]?.DeepClone() ?? new JsonArray(),
            ["geometry"] = draft["geometry"]?.DeepClone() ?? new JsonObject(),
            ["acceptance_checklist"] = draft["acceptance_checklist"]?.DeepClone() ?? new JsonArray(),
            ["missing"] = draft["missing"]?.DeepClone() ?? new JsonArray(),
            ["blocking_questions"] = draft["blocking_questions"]?.DeepClone() ?? new JsonArray(),
            ["provenance"] = draft["provenance"]?.DeepClone() ?? new JsonArray(),
            ["source_summary"] = Limit(description ?? sourceName, 1000)
        };
    }

    private static string EvidenceForPrompt(JsonNode? evidence)
    {
        if (evidence is not JsonObject root) return evidence?.ToJsonString() ?? "null";
        var compact = new JsonObject { ["status"] = root["status"]?.DeepClone() };
        var chunks = new JsonArray();
        foreach (var item in (root["chunks"] as JsonArray ?? new JsonArray()).Take(6))
        {
            if (item is not JsonObject chunk) continue;
            chunks.Add(new JsonObject
            {
                ["doc_name"] = chunk["doc_name"]?.DeepClone(),
                ["doc_type"] = chunk["doc_type"]?.DeepClone(),
                ["content"] = Limit(chunk["content"]?.GetValue<string>() ?? "", 1200)
            });
        }
        compact["chunks"] = chunks;
        return compact.ToJsonString();
    }

    private static async Task<JsonObject> AskOllamaForObjectAsync(
        IHttpClientFactory factory,
        IConfiguration configuration,
        string prompt,
        string[] images,
        bool preserveUnparsed = false,
        JsonNode? responseFormat = null)
    {
        var baseUrl = (configuration["Ollama:BaseUrl"] ?? Environment.GetEnvironmentVariable("OLLAMA_BASE_URL") ?? "http://127.0.0.1:11434").TrimEnd('/');
        var model = configuration["Ollama:Model"] ?? Environment.GetEnvironmentVariable("OLLAMA_MODEL") ?? "qwen3.5:9b";
        using var client = factory.CreateClient();
        client.Timeout = TimeSpan.FromMinutes(3);
        var user = new JsonObject { ["role"] = "user", ["content"] = prompt };
        if (images.Length > 0)
        {
            var imageArray = new JsonArray();
            foreach (var image in images) imageArray.Add(image);
            user["images"] = imageArray;
        }
        var payload = new JsonObject
        {
            ["model"] = model,
            ["stream"] = false,
            ["think"] = false,
            ["format"] = responseFormat?.DeepClone() ?? JsonValue.Create("json"),
            ["options"] = new JsonObject { ["temperature"] = 0.1, ["num_predict"] = 2400, ["num_ctx"] = 16384 },
            ["messages"] = new JsonArray(user)
        };
        using var response = await client.PostAsJsonAsync($"{baseUrl}/api/chat", payload);
        var body = await response.Content.ReadAsStringAsync();
        if (!response.IsSuccessStatusCode) throw new HttpRequestException($"Ollama HTTP {(int)response.StatusCode}: {Limit(body, 500)}");
        var root = JsonNode.Parse(body);
        var content = root?["message"]?["content"]?.GetValue<string>() ?? "";
        var parsed = ExtractJsonObject(content);
        if (parsed is null && preserveUnparsed)
            return new JsonObject { ["_unparsed_model_output"] = Limit(content, 8000) };
        return parsed ?? throw new InvalidOperationException("Модель не вернула корректный JSON-объект.");
    }

    private static async Task<JsonNode?> SearchLesAsync(IHttpClientFactory factory, IConfiguration configuration, string query, string dataset, int topK)
    {
        var options = LesOptions.FromConfiguration(configuration);
        using var client = factory.CreateClient();
        client.Timeout = TimeSpan.FromSeconds(options.TimeoutSeconds);
        using var request = CreateLesRequest(HttpMethod.Post, options, "/api/search");
        request.Content = JsonContent.Create(new { query, dataset_filter = dataset, top_k = topK, include_trace = true });
        try
        {
            using var response = await client.SendAsync(request);
            var body = await response.Content.ReadAsStringAsync();
            try
            {
                var parsed = JsonNode.Parse(body);
                if (response.IsSuccessStatusCode) return parsed;
                return new JsonObject
                {
                    ["status"] = "upstream_error",
                    ["http_status"] = (int)response.StatusCode,
                    ["response"] = parsed
                };
            }
            catch (JsonException)
            {
                return new JsonObject
                {
                    ["status"] = "upstream_error",
                    ["http_status"] = (int)response.StatusCode,
                    ["message"] = Limit(body, 500)
                };
            }
        }
        catch (Exception error) when (error is HttpRequestException or TaskCanceledException)
        {
            return new JsonObject { ["status"] = "unavailable", ["error"] = error.GetType().Name };
        }
    }

    private static async Task<JsonNode?> IngestPdfAndRetrieveAsync(IHttpClientFactory factory, IConfiguration configuration, string fileName, byte[] bytes)
    {
        var options = LesOptions.FromConfiguration(configuration);
        using var client = factory.CreateClient();
        client.Timeout = TimeSpan.FromSeconds(Math.Max(options.TimeoutSeconds, 180));
        string? datasetId = null;
        using (var list = CreateLesRequest(HttpMethod.Get, options, "/api/rag/datasets"))
        using (var response = await client.SendAsync(list))
        {
            var array = JsonNode.Parse(await response.Content.ReadAsStringAsync()) as JsonArray;
            datasetId = array?.FirstOrDefault(item => string.Equals(item?["name"]?.GetValue<string>(), "ARTEL_DRAFTS_Index", StringComparison.OrdinalIgnoreCase))?["id"]?.GetValue<string>();
        }
        if (string.IsNullOrWhiteSpace(datasetId))
        {
            using var create = CreateLesRequest(HttpMethod.Post, options, "/api/rag/datasets?name=ARTEL_DRAFTS_Index");
            using var response = await client.SendAsync(create);
            datasetId = JsonNode.Parse(await response.Content.ReadAsStringAsync())?["id"]?.GetValue<string>();
        }
        if (string.IsNullOrWhiteSpace(datasetId)) return new JsonObject { ["status"] = "upload_failed" };
        using (var upload = CreateLesRequest(HttpMethod.Post, options, $"/api/rag/upload/{datasetId}"))
        using (var multipart = new MultipartFormDataContent())
        {
            multipart.Add(new ByteArrayContent(bytes), "file", fileName);
            upload.Content = multipart;
            using var response = await client.SendAsync(upload);
            if (!response.IsSuccessStatusCode) return new JsonObject { ["status"] = "upload_failed", ["http_status"] = (int)response.StatusCode };
        }
        for (var attempt = 0; attempt < 18; attempt++)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            var evidence = await SearchLesAsync(factory, configuration, $"Требования и технические характеристики из файла {fileName}", "ARTEL_DRAFTS", 12);
            if (evidence?["results"] is JsonArray results && results.Count > 0) return evidence;
        }
        return new JsonObject { ["status"] = "indexing", ["message"] = "PDF принят ЛЕС, но разбор ещё не завершён." };
    }

    private static HttpRequestMessage CreateLesRequest(HttpMethod method, LesOptions options, string path)
    {
        var request = new HttpRequestMessage(method, new Uri(new Uri(options.BaseUrl), path));
        if (!string.IsNullOrWhiteSpace(options.ApiKey)) request.Headers.TryAddWithoutValidation("X-API-Key", options.ApiKey);
        return request;
    }

    private static async Task<string> ReadUrlTextAsync(IHttpClientFactory factory, string rawUrl)
    {
        if (!Uri.TryCreate(rawUrl, UriKind.Absolute, out var uri) || uri.Scheme is not ("http" or "https")) return "MISSING: некорректная ссылка";
        using var client = factory.CreateClient();
        client.Timeout = TimeSpan.FromSeconds(30);
        var body = await client.GetStringAsync(uri);
        return Limit(Regex.Replace(Regex.Replace(body, "<script[\\s\\S]*?</script>|<style[\\s\\S]*?</style>", " ", RegexOptions.IgnoreCase), "<[^>]+>", " "), 40000);
    }

    private static string ExtractDocx(byte[] bytes)
    {
        using var stream = new MemoryStream(bytes);
        using var zip = new ZipArchive(stream, ZipArchiveMode.Read);
        var entry = zip.GetEntry("word/document.xml");
        if (entry is null) return "MISSING: word/document.xml";
        using var reader = new StreamReader(entry.Open());
        var document = XDocument.Parse(reader.ReadToEnd());
        return Limit(string.Join(" ", document.DescendantNodes().OfType<XText>().Select(text => text.Value)), 40000);
    }

    private static string ExtractXlsx(byte[] bytes)
    {
        using var stream = new MemoryStream(bytes);
        using var zip = new ZipArchive(stream, ZipArchiveMode.Read);
        var output = new StringBuilder();
        foreach (var entry in zip.Entries.Where(entry => entry.FullName.Equals("xl/sharedStrings.xml", StringComparison.OrdinalIgnoreCase) || entry.FullName.StartsWith("xl/worksheets/sheet", StringComparison.OrdinalIgnoreCase)).Take(20))
        {
            using var reader = new StreamReader(entry.Open());
            var document = XDocument.Parse(reader.ReadToEnd());
            output.AppendLine(entry.Name);
            output.AppendLine(string.Join(" | ", document.DescendantNodes().OfType<XText>().Select(text => text.Value)));
        }
        return Limit(output.ToString(), 40000);
    }

    private static JsonObject? ExtractJsonObject(string text)
    {
        try { return JsonNode.Parse(text) as JsonObject; }
        catch
        {
            var start = text.IndexOf('{');
            var end = text.LastIndexOf('}');
            if (start < 0 || end <= start) return null;
            var candidate = text[start..(end + 1)];
            try { return JsonNode.Parse(candidate) as JsonObject; }
            catch
            {
                // Ollama JSON mode can still emit a trailing comma. Repair syntax only;
                // semantic fields are validated separately by LooksLikeFamilySpecification.
                var repaired = Regex.Replace(candidate, @",\s*([}\]])", "$1");
                try { return JsonNode.Parse(repaired) as JsonObject; }
                catch { return null; }
            }
        }
    }

    private static string Sha256(string value) => Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(value))).ToLowerInvariant();
    private static string Limit(string value, int max) => value.Length <= max ? value : value[..max];
}

internal sealed record GeneratorDraftRequest(
    string? Description,
    string? SourceName,
    string? ContentType,
    string? ContentBase64,
    string? SourceUrl,
    JsonNode? Context);

internal sealed record OperatorPlanRequest(string Question, JsonNode? Context);
