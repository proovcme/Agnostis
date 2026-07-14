# AGENTS.md — АРТЕЛЬ

## Канон

Читайте в порядке:

1. `README.md`
2. `docs/ARCHITECTURE.md`
3. `docs/MCP_CONTRACT.md`
4. `docs/LES_INTEGRATION.md`
5. `docs/DEVELOPMENT.md`
6. `docs/STATUS.md`

Источники правды по поведению — код, machine contracts и живой Revit hand-test. Старые имена `Agnostis` в namespace/path не означают старую продуктовую архитектуру.

## Инварианты

- АРТЕЛЬ — standalone Windows/Revit product; LES опционален.
- Цели: базовый Revit 2024.0 и Revit 2025.
- Skill задаёт reasoning discipline; MCP предоставляет typed capabilities; add-in исполняет Revit API через `ExternalEvent`.
- Модель выбирает intent/category/field/filter/action только по evidence. Код не подменяет профессиональное решение.
- Суммы и единицы считает typed code tool. Модель не складывает display strings.
- Element parameter и schedule field — разные каталоги.
- Missing capability должна оставаться `MISSING`.
- Любая мутация требует preview; safety guard управляет ручным подтверждением, но не отключает validation/Transaction/rollback.
- Revit/Windows/Legion не трогать без явной просьбы пользователя.
- LES runtime, индекс и данные не менять из этого репозитория без отдельного разрешения.

## Репозиторная гигиена

- Не коммитить `Dist`, `bin`, `obj`, `publish`, installer payload/dist, DLL, PDB, EXE, логи или state.
- Не возвращать legacy MyVeras и отдельный Tauri/Electron UI.
- Документацию менять вместе с контрактом/потоком.
- Версию менять в `version.json`; installer define синхронизировать в той же правке.
- Не объявлять готовность по compile/pytest. Для Revit action нужен живой hand-test собранного и установленного пакета.

## Проверки

Без Revit:

```bash
dotnet build backend/Agnostis.Api/Agnostis.Api.csproj --configuration Release
node --check app/app.js
git diff --check
```

Skill проверять прямыми повторяемыми tool-трассами целевой модели. Windows compile/install/live Revit gate выполнять только по явному разрешению.

## Формат ответа

**Summary · Files changed · Checks run · Result · Risks/TODOs**
