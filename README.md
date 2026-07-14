# АРТЕЛЬ

**АРТЕЛЬ** — локальный Revit-агент и генератор семейств для Autodesk Revit 2024/2025.

Репозиторий содержит самостоятельный продукт: Revit add-in, локальный backend, интерфейс внутри Revit, installer source, агентные skills и служебный корпус `ARTEL_Index`. ЛЕС остаётся внешним опциональным контуром поиска и приёма BIM-экспорта; исходники АРТЕЛИ больше не должны развиваться как независимая копия внутри LES.

## Что строим

АРТЕЛЬ состоит из трёх пользовательских возможностей:

1. **Генератор семейств** — принимает текст, ТЗ, PDF/DOCX/XLSX, ссылку или изображение; формирует проверяемую спецификацию семейства и пошаговый план.
2. **BIM-агент** — отвечает по активному документу Revit, считает, выделяет элементы, готовит и выполняет действия через Revit API.
3. **Экспорт данных** — показывает read-only preview и отдельно отправляет подтверждённый BIM-пакет в пользовательский индекс LES.

Целевая агентная архитектура:

```text
пользователь
  -> Revit Agent Skill
  -> MCP capability catalog
  -> live Revit evidence
  -> preview / confirmation
  -> ExternalEvent + Transaction
  -> фактический результат

ARTEL Index -> справка Revit API / FOP / learning cases
LES         -> опциональный retrieval и ARTEL_BIM_Index
```

Skill определяет, как рассуждать. MCP даёт модели глаза и руки. Add-in остаётся единственным исполнителем Revit API на корректном API-потоке.

## Текущий статус

`0.25.9 / build 420` — **skill-first source candidate**. Он не собирался и не устанавливался в рамках выноса репозитория.

Последний установленный пакет `0.25.8-419` отвергнут живым Revit-тестом: модель передала выдуманное поле `id` для спецификации светильников. Общая тестовая сюита и synthetic model smoke этого не обнаружили. Поэтому следующий рабочий этап — MCP capability layer, начиная с `schedule_fields` и typed `aggregate`, а не новые предметные ветки в C#.

Подробно: [docs/STATUS.md](docs/STATUS.md).

## Архитектурные правила

- Модель понимает намерение и выбирает профессиональное решение.
- Код читает Revit, валидирует идентичности/типы/единицы, считает и исполняет.
- Пользовательское слово не является Revit category/id/parameter.
- Параметр элемента не является полем спецификации.
- Модель не складывает форматированные строки: суммы считает typed tool.
- Отсутствующая capability возвращается как `MISSING`, а не заменяется соседним инструментом.
- Мутации идут только через preview, подтверждение, `ExternalEvent`, `Transaction` и rollback.
- Никаких сгенерированных C#-скриптов или управления Revit мышью.

## Состав репозитория

| Путь | Назначение |
|---|---|
| `ARTEL.Revit.FamilyFactory/` | add-in Revit 2024/2025, DockablePane и API-thread executor |
| `backend/Agnostis.Api/` | локальный ASP.NET Core backend; namespace пока сохраняет историческое имя |
| `app/` | интерфейс, который backend отдаёт в Revit pane |
| `skills/` | Revit agent, family generator и Codex/operator skills |
| `knowledge/ARTEL/` | Git-копия служебного корпуса `ARTEL_Index` |
| `conformance/` | проверяемые семейные планы и fixtures |
| `installer/` | Inno Setup, runtime scripts и графика без собранного EXE |
| `openapi/` | публичный core runtime contract |
| `docs/` | текущая архитектура, MCP, LES, разработка и статус |

Legacy MyVeras, `Dist`, `bin`, `obj`, DLL/PDB и Tauri/Electron-макеты в новый канон не входят.

## Быстрый запуск backend

Требуется .NET 8 и установленная Ollama с выбранной tool-capable моделью.

```bash
dotnet run --project backend/Agnostis.Api --urls http://127.0.0.1:5057
```

Проверка:

```bash
curl -fsS http://127.0.0.1:5057/health
```

Статический интерфейс будет доступен на `http://127.0.0.1:5057/`.

Сборка add-in и installer выполняется только на Windows с установленными Revit 2024/2025 SDK assemblies. См. [docs/DEVELOPMENT.md](docs/DEVELOPMENT.md).

## Документация

- [Архитектура](docs/ARCHITECTURE.md)
- [MCP contract](docs/MCP_CONTRACT.md)
- [Связь с LES](docs/LES_INTEGRATION.md)
- [Разработка и выпуск](docs/DEVELOPMENT.md)
- [Текущее состояние и известные провалы](docs/STATUS.md)
- [OpenAPI core runtime](openapi/artel-runtime.yaml)

## GitHub Pages

GitHub Pages публикует только статический `app/` как демонстрацию интерфейса. Рабочий продукт запускается внутри Revit и требует локальный backend.

<https://proovcme.github.io/Agnostis/>
