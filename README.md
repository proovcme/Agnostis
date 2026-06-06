# Agnostis

Agnostis — AI-платформа для управления разработкой Revit-семейств: от задания и исходников до спецификации, проверки, приемки и публикации во внутренний каталог.

## About

В основе продукта — связка веб-сервиса и Revit-плагина.

Веб-сервис хранит задания, исходники, шаблоны, ФОП/shared parameters, стандарты, AI-спецификации, версии семейств и каталог. Revit-плагин получает формализованное задание, помогает разработчику применить параметры и типы, проверяет открытое семейство и отправляет RFA с отчетом обратно.

Главная продуктовая сущность — задание на разработку семейства. Каталог — результат принятых заданий и база для дальнейшего поиска и переиспользования.

Подробнее: [About](docs/about.md)

## Архитектурная позиция

Agnostis не строит отдельный RAG с нуля. Для локального знания, поиска по BIM/RFA/CAD_BIM данным и объектному контексту используется LES.

Разделение ответственности:

- Agnostis — задания, исходники, шаблоны, ФОП/shared parameters, AI-спецификации, Revit workflow, приемка и каталог.
- LES — retrieval, Qdrant/SQLite, CAD/BIM JSON ingestion, локальная модель, dataset routing и object-level context.
- OpenRouter — внешний AI provider для анализа, генерации черновиков спецификаций и объяснений поверх найденного контекста.

Ключевой принцип BIM RFA RAG: модель вторична, качество исходных данных первично. Чем больше принятых семейств, спецификаций, отчетов проверок и RFA-derived JSON попадает в контур знаний, тем лучше следующая разработка семейств.

## UI-прототип

- GitHub Pages: <https://proovcme.github.io/Agnostis/>
- Исходники макета: [app](app)
- Документация макета: [docs/ui-prototype.md](docs/ui-prototype.md)

## Документация

- [About](docs/about.md)
- [Концепция продукта](docs/product-concept.md)
- [Состав MVP](docs/mvp-scope.md)
- [MVP Roadmap](docs/mvp-roadmap.md)
- [MVP User Stories](docs/mvp-user-stories.md)
- [MVP API Contract](docs/mvp-api-contract.md)
- [Revit Add-In MVP](docs/revit-addin-mvp.md)
- [Technical Stack](docs/technical-stack.md)
- [OpenRouter Integration](docs/openrouter.md)
- [LES Integration](docs/les-integration.md)
- [Learning Loop](docs/learning-loop.md)
- [BIM RFA RAG](docs/bim-rfa-rag.md)
- [Архитектура системы](docs/system-architecture.md)
- [Доменная модель](docs/domain-model.md)
- [Backlog](docs/backlog.md)
- [UI-прототип](docs/ui-prototype.md)
- [Открытые вопросы](docs/open-questions.md)

## Codex skill

Для работы с проектом подготовлен skill:

- исходник в репозитории: [skills/agnostis/SKILL.md](skills/agnostis/SKILL.md)
- локальная установленная копия: `/Users/ovc/.codex/skills/agnostis/SKILL.md`

Skill фиксирует рабочий контекст Agnostis, связь с LES, правила проверки backend/OpenAPI, документационный closeout и ограничения: Revit-плагин идет через Agnostis backend, Agnostis вызывает LES/OpenRouter, LES runtime не трогаем без явного запроса.

## Текущий состав репозитория

- `app/` — статический прототип веб-интерфейса Agnostis.
- `docs/` — продуктовая и техническая документация.
- `backend/Agnostis.Api/` — skeleton backend API для MVP.
- `openapi/agnostis-mvp.yaml` — начальная OpenAPI-схема MVP.
- `skills/agnostis/` — Codex skill для работы с Agnostis и LES RAG контуром.
- `.github/workflows/pages.yml` — публикация макета на GitHub Pages.
- `MyVeras.*`, `Dist/`, `MyVeras.sln` — существующая кодовая база Revit-плагина, сохраненная как legacy/исходный материал. Сейчас она не является основным описанием Agnostis.

## Проверка прототипа локально

```bash
python3 -m http.server 4173
```

После запуска открыть:

```text
http://127.0.0.1:4173/app/index.html
```
