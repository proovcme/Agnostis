# Архитектура АРТЕЛИ

## Границы продукта

АРТЕЛЬ работает локально на Windows рядом с Autodesk Revit и не зависит от LES для базового чтения или изменения модели.

```text
Revit DockablePane
    |
    v
ARTEL local backend (:5057) ----> Ollama
    |                                  |
    | MCP host / tool adapter          | tool calls
    v                                  |
Revit session bridge <----------------+
    |
    v
ExternalEvent -> Revit API -> Transaction

optional: backend -> LES /api/search
optional: backend -> LES BIM export endpoint
```

## Четыре слоя

### Revit Agent Skill

`skills/revit-api-operator` хранит профессиональную дисциплину: разделение user intent, live document evidence и API evidence; порядок discovery; capability gates; безопасность; terminal behavior.

Skill не содержит словаря категорий и не является справочником точных API signatures.

### MCP capability layer

MCP публикует компактный набор typed resources/tools. Модель сама строит цепочку вызовов. Каталог должен быть достаточно универсальным для любой дисциплины Revit, но не должен выдавать весь Revit API как неограниченный reflection/code execution.

Целевой контракт описан в [MCP_CONTRACT.md](MCP_CONTRACT.md). В `0.25.9` это архитектурный контракт, не завершённая реализация.

### Revit session bridge

Backend не может обращаться к Revit API напрямую. Add-in принимает read/action request, поднимает `ExternalEvent`, выполняет его на Revit API thread и возвращает typed result. Для action сохраняются plan hash и target fingerprint.

### Knowledge

`ARTEL_Index` содержит version-exact Revit API docs, FOP, family guides и learning cases. Он отвечает на «как устроен API», но не доказывает факты активного документа.

## Текущий и целевой потоки

Текущий код использует HTTP agent loop `/api/assistant/live`: backend возвращает `tool_request`, dock pane исполняет live query и продолжает conversation.

Целевой поток сохраняет этот Revit session bridge, но заменяет C#-prompt orchestration на MCP host:

1. Backend загружает один canonical skill.
2. MCP server объявляет resources/tools и schemas.
3. Ollama получает machine-readable tool catalog.
4. Tool call маршрутизируется в active Revit session.
5. Read result возвращается модели как evidence.
6. Mutation проходит preview/confirmation/execute.

## Что не входит

- генерация и исполнение произвольного C#;
- UI automation мышью/клавиатурой;
- category-specific tools;
- скрытый deterministic intent router;
- model arithmetic по display values;
- прямой вызов LES из Revit add-in;
- Tauri/Electron как основной интерфейс.
