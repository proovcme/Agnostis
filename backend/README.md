# Backend

## Стек MVP

Backend MVP предлагается делать на ASP.NET Core:

- .NET 8;
- C# minimal APIs;
- PostgreSQL после перехода от in-memory skeleton;
- object storage или filesystem-backed storage для RFA/исходников;
- OpenAPI contract в [`../openapi/agnostis-mvp.yaml`](../openapi/agnostis-mvp.yaml).

Причина выбора: Revit-плагин и существующая кодовая база уже C#-ориентированы. Единый язык для API DTO, клиента плагина и части доменной модели снижает интеграционные риски.

## Текущий skeleton

Проект:

```text
backend/Agnostis.Api
```

Сейчас это in-memory API skeleton без внешних NuGet-пакетов.

Endpoints:

- `GET /health`
- `GET /api/tasks`
- `POST /api/tasks`
- `GET /api/tasks/{taskId}`
- `POST /api/tasks/{taskId}/ai-analysis`
- `GET /api/tasks/{taskId}/specification`
- `PUT /api/tasks/{taskId}/specification`
- `POST /api/tasks/{taskId}/specification/approve`
- `GET /api/revit/tasks`
- `GET /api/revit/tasks/{taskId}/package`
- `POST /api/revit/tasks/{taskId}/validation-reports`
- `GET /api/catalog`
- `GET /api/catalog/{catalogItemId}`
- `GET /api/catalog/{catalogItemId}/versions`
- `POST /api/catalog/{catalogItemId}/publish`
- `POST /api/catalog/{catalogItemId}/update-task`

## Запуск

Требуется установленный .NET SDK 8.

```bash
dotnet run --project backend/Agnostis.Api
```

Проверка:

```bash
curl http://localhost:5000/health
```

## Проверка

На текущей машине `dotnet` отсутствует, поэтому сборка backend skeleton здесь не выполнялась. Код и contract подготовлены для проверки в окружении с .NET SDK 8.

Фактическая проверка выполнена на Windows-хосте `legion` по SSH:

- `dotnet build backend/Agnostis.Api/Agnostis.Api.csproj --configuration Release`
- `dotnet run --no-build --configuration Release --urls http://127.0.0.1:5057`
- `GET /health`
- `POST /api/tasks/task_0241/ai-analysis`
- `GET /api/catalog/catalog_001`
- `GET /api/catalog/catalog_001/versions`
- `POST /api/catalog/catalog_001/publish`
- `POST /api/catalog/catalog_001/update-task`

Результат: build без предупреждений и ошибок, `/health` вернул `{"status":"ok"}`, AI-analysis endpoint вернул `provider: "openrouter"`, catalog endpoints вернули detail/versions, publish создал версию, update-task создал задание `FAM-0002`.
