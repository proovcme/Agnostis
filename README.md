# Agnostis

Agnostis — AI-платформа для управления разработкой Revit-семейств: от задания и исходников до спецификации, проверки, приемки и публикации во внутренний каталог.

## About

В основе продукта — связка веб-сервиса и Revit-плагина.

Веб-сервис хранит задания, исходники, шаблоны, ФОП/shared parameters, стандарты, AI-спецификации, версии семейств и каталог. Revit-плагин получает формализованное задание, помогает разработчику применить параметры и типы, проверяет открытое семейство и отправляет RFA с отчетом обратно.

Главная продуктовая сущность — задание на разработку семейства. Каталог — результат принятых заданий и база для дальнейшего поиска и переиспользования.

Подробнее: [About](docs/about.md)

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
- [Архитектура системы](docs/system-architecture.md)
- [Доменная модель](docs/domain-model.md)
- [Backlog](docs/backlog.md)
- [UI-прототип](docs/ui-prototype.md)
- [Открытые вопросы](docs/open-questions.md)

## Текущий состав репозитория

- `app/` — статический прототип веб-интерфейса Agnostis.
- `docs/` — продуктовая и техническая документация.
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
