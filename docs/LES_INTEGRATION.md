# Связь АРТЕЛИ с LES

## Принцип

АРТЕЛЬ — самостоятельный продукт. LES добавляет retrieval и хранение BIM-экспорта, но его недоступность не блокирует live Revit inspection, генератор или локальные действия.

```text
Revit add-in -> ARTEL backend -> optional LES
```

Revit add-in не вызывает LES напрямую.

## ARTEL Index

Каноническая Git-копия корпуса находится в `knowledge/ARTEL`, manifest — `knowledge/ARTEL_DATASET.json`.

Состав:

- `REVIT_API_REFERENCE`;
- `REVIT_API_SYMBOL_MAP`;
- `REVIT_API_SDK_DOC` для Revit 2024/2025;
- `REVIT_MODEL_GUIDE`;
- `FOP_PROFILE`;
- `FAMILY_GUIDE`;
- `LEARNING_CASE`.

Installer копирует корпус локально. `installer/sync-artel-knowledge.ps1` по явной команде синхронизирует только `ARTEL_Index` в LES. Полный reindex LES не запускается.

## Runtime endpoints

Backend проверяет LES через:

```http
GET {LES_BASE_URL}/api/health
```

Справочный retrieval:

```http
POST {LES_BASE_URL}/api/search
Content-Type: application/json

{
  "query": "exact Revit API or ARTEL knowledge question",
  "dataset_filter": "ARTEL",
  "top_k": 8,
  "include_trace": true
}
```

API/FOP evidence не является фактом активной модели. Live model evidence приходит только через Revit MCP tools.

## BIM export

Экспорт активного проекта использует отдельный пользовательский dataset `ARTEL_BIM_Index`. Он не изменяет служебный `ARTEL_Index`.

Поток:

1. Add-in строит локальный read-only preview.
2. Пользователь подтверждает пакет и destination.
3. Backend сохраняет локальную JSON-копию.
4. При доступном LES пакет отправляется в `ARTEL_BIM_Index`.
5. Ошибка LES не удаляет локальный пакет.

## Degradation

| LES | ARTEL behavior |
|---|---|
| доступен | local Revit + ARTEL Index retrieval + BIM export |
| недоступен | local Revit и bundled skill/knowledge продолжают работать; retrieval/export показывают offline |
| несовместимый index contract | sync/export блокируются с явной ошибкой; Revit не затрагивается |

## Связь репозиториев

`proovcme/Agnostis` — канон исходников АРТЕЛИ. LES подключает этот репозиторий как version-pinned dependency/submodule и владеет только integration tests, dataset registration и runtime adapter своей стороны.
