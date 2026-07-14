# Текущее состояние

## Source candidate

- Version: `0.25.9`
- Build: `420`
- Date: `2026-07-14`
- State: skill-first source candidate; не установлен

## Что существует

- add-in для Revit 2024/2025;
- DockablePane с генератором, BIM-чатом и экспортом;
- локальный ASP.NET Core backend;
- Ollama tool loop;
- live Revit query через `ExternalEvent`;
- generic selector;
- selection, schedule creation и parameter write executor;
- safety guard, preview, hash/fingerprint, transaction/rollback;
- ARTEL Index и optional LES integration;
- Revit Agent Skill v1.

## Что отвергнуто

Установленный `0.25.8-419` не считается рабочим выпуском. Живой запрос «Дай спецификацию светильников» дошёл до Revit с полем `id`, которого нет в schedulable fields категории. Ранее synthetic smoke принял похожий plan, а общая тестовая сюита не проверяла самостоятельное capability discovery моделью.

## Skill v1

Прямые повторяемые прогоны `qwen3.5:9b`, `think=false`, подтвердили:

- user noun сначала приводит к live category discovery;
- API-вопрос вызывает ARTEL Index search;
- selection использует universal selector;
- отсутствие `schedule_fields`, `aggregate`, placement или IFC export возвращает `MISSING`;
- выдуманные `BuiltInCategory.Lights`, `Id/Name/Wattage` воспроизведены как отрицательные трассы и закрыты canonical examples.

Это доказывает поведение skill в изолированной tool-сессии, но не является живым Revit release gate.

## Следующий этап

Реализовать MCP capability layer без category hardcode:

1. active Revit session resource;
2. exact category/parameter identities;
3. `revit.schedule.fields`;
4. `revit.values.aggregate`;
5. preview/execute split;
6. model adapter, который не добавляет domain prompt;
7. живые hand-tests и только затем installer release.
