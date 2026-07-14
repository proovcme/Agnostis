# ARTEL Revit MCP contract

## Назначение

MCP — граница между моделью и Revit. Skill говорит модели, как исследовать задачу; MCP сообщает, какие действия реально доступны в текущей версии плагина и активном документе.

## Transport и session

MCP server живёт в локальном ARTEL backend. Revit add-in регистрирует активную loopback-session и исполняет запросы через `ExternalEvent`. Отсутствующая/устаревшая session возвращает `MISSING`, а не snapshot из прошлого документа.

Сетевой bind по умолчанию: только `127.0.0.1`. Внешний MCP transport не включается автоматически.

## Resources

| URI | Содержание |
|---|---|
| `artel://skill/revit-agent` | canonical runtime skill и версия |
| `artel://revit/session` | active document/session/revit version, без полного snapshot |
| `artel://revit/capabilities` | доступные tools, schemas и safety class |
| `artel://knowledge/status` | наличие ARTEL Index и LES enrichment |

## Core read tools

| Tool | Назначение |
|---|---|
| `revit.document.describe` | активный документ, view, version, selection count |
| `revit.categories.list` | полный пагинированный live-каталог категорий |
| `revit.parameters.list` | parameter identity/scope/storage/spec/read-only для exact targets |
| `revit.schedule.fields` | schedulable fields конкретной категории |
| `revit.elements.query` | строки элементов по универсальному selector |
| `revit.values.aggregate` | count/sum/min/max/average/group с units и coverage |
| `revit.selection.get` | текущий UI selection |

## Core action tools

| Tool | Safety | Назначение |
|---|---|---|
| `revit.action.preview` | read-only | разрешает selector, count/sample/fingerprint, проверяет capabilities |
| `revit.selection.set` | UI state | меняет selection и возвращает actual ids |
| `revit.action.execute` | mutation | выполняет подтверждённый typed plan |

`revit.action.execute` принимает только action kind, который есть в `artel://revit/capabilities`. Начальный registry: schedule creation и parameter write. Placement, delete, view, file lifecycle и format export не эмулируются, пока не появится отдельная typed capability.

## Universal selector

```json
{
  "scope": "model|active_view|selection",
  "categories": [{"id": "stable live identity", "name": "display only"}],
  "family": null,
  "type": null,
  "system": null,
  "parameter_filters": [
    {
      "parameter": {"identity": "live identity", "scope": "instance|type"},
      "operator": "equal|contains|greater|has_value|...",
      "value": {"storage": "typed value", "display": "optional"}
    }
  ]
}
```

Names are not stable identity when Revit exposes a stronger id/GUID/built-in identity.

## Evidence result

Every result includes:

- `schema` and contract version;
- `session_id`, document identity and Revit version;
- `status=ok|missing|blocked|error`;
- pagination coverage;
- typed rows/result;
- warnings and missing capabilities;
- provenance describing the Revit API source of each metric/field.

Aggregate additionally returns `matched_count`, `covered_count`, `null_count`, operation, unit/spec and storage-to-output conversion.

## Safety

- Resources/read tools never mutate the document.
- Preview and execute use the same canonical plan hash and target fingerprint.
- Safety guard ON requires explicit user confirmation for mutation.
- Safety guard OFF removes only the confirmation pause.
- Validation, target limits, API-thread execution, transaction and rollback always remain.
- Any session/document/fingerprint change invalidates the plan.

## Model adapter

Ollama tool calling is not assumed to speak MCP transport directly. ARTEL backend acts as MCP host/client adapter: it translates MCP tool descriptors to the model's tool schema and routes calls/results without adding domain decisions.
