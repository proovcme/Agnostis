using System.Collections.Concurrent;

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

var app = builder.Build();

app.UseCors();

var store = SeedData.Create();

app.MapGet("/health", () => Results.Ok(new HealthResponse("ok", DateTimeOffset.UtcNow)));

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

app.MapPost("/api/tasks/{taskId}/ai-analysis", (string taskId, AIAnalysisRequest request) =>
{
    if (!store.Tasks.TryGetValue(taskId, out var task))
    {
        return Results.NotFound(ApiError.Create("task_not_found", "Task was not found."));
    }

    var specification = new FamilySpecification(
        Id: $"spec_{Guid.NewGuid():N}",
        TaskId: taskId,
        Status: SpecificationStatuses.Draft,
        FamilyName: task.Title,
        RevitCategory: task.RevitCategory ?? "Unspecified",
        TemplateFileId: request.TemplateFileId,
        SharedParameterProfileId: request.SharedParameterProfileId,
        Parameters:
        [
            new SpecificationParameter("param_ai_001", "ADSK_Наименование", "shared_parameter", null, "Text", "Identity Data", false, true, null, null, "Draft from AI analysis placeholder")
        ],
        Types: [],
        Materials: [],
        AcceptanceChecklist:
        [
            "Проверить обязательные параметры",
            "Проверить типы семейства",
            "Проверить заполненность каталожных данных"
        ],
        CreatedAt: DateTimeOffset.UtcNow,
        UpdatedAt: DateTimeOffset.UtcNow);

    store.Specifications[taskId] = specification;

    return Results.Accepted($"/api/tasks/{taskId}/specification", new AIAnalysisResult(
        Provider: "openrouter",
        Model: request.Model,
        Status: "completed",
        Specification: specification,
        Warnings:
        [
            "This MVP skeleton does not call OpenRouter yet. It reserves the endpoint and response contract."
        ]));
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
    return Results.Created($"/api/validation-reports/{report.Id}", report);
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

app.Run();

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

record AIAnalysisRequest(
    IReadOnlyList<string> SourceFileIds,
    string? SharedParameterProfileId,
    string? TemplateFileId,
    string? Model);

record AIAnalysisResult(
    string Provider,
    string? Model,
    string Status,
    FamilySpecification Specification,
    IReadOnlyList<string> Warnings);

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
    string CurrentVersion,
    IReadOnlyList<string> Tags);

record AppStore(
    ConcurrentDictionary<string, FamilyTask> Tasks,
    ConcurrentDictionary<string, FamilySpecification> Specifications,
    ConcurrentDictionary<string, SourceFile> Files,
    ConcurrentDictionary<string, ValidationReport> ValidationReports,
    ConcurrentDictionary<string, CatalogItem> Catalog);

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
                KeyValuePair.Create("catalog_001", new CatalogItem("catalog_001", "Шкаф архивный металлический", "Furniture", "Параметрическое семейство шкафа.", "0.1.0", ["мебель", "шкаф", "архив"]))
            }));
    }
}
