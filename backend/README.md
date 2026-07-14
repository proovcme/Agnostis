# ARTEL local backend

ASP.NET Core 8 backend для локального продукта АРТЕЛЬ.

Текущие обязанности:

- отдавать `app/`;
- проверять Ollama и LES;
- вести generator/BIM agent loop;
- хранить task/catalog/validation prototype state;
- принимать BIM export;
- загружать runtime skills.

Целевая граница — MCP host/model adapter. Backend не обращается к Revit API напрямую: live read/action выполняет add-in через Revit session bridge и `ExternalEvent`.

Запуск:

```bash
dotnet run --project backend/Agnostis.Api --urls http://127.0.0.1:5057
```

Configuration:

```text
OLLAMA_BASE_URL=http://127.0.0.1:11434
OLLAMA_MODEL=qwen3.5:9b
LES_BASE_URL=http://127.0.0.1:8050
LES_API_KEY=
ARTEL_STATE_ROOT=
```

LES optional. Revit session absent must return `MISSING`, never stale model facts.
