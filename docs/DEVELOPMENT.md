# Разработка и выпуск

## Требования

- .NET SDK 8 для backend;
- Windows 11 x64 для packaged product;
- Autodesk Revit 2024.0 и/или 2025 для add-in compile/live gate;
- Ollama с tool-capable моделью;
- Inno Setup 6 для installer.

## Backend

```bash
dotnet build backend/Agnostis.Api/Agnostis.Api.csproj --configuration Release
dotnet run --project backend/Agnostis.Api --urls http://127.0.0.1:5057
curl -fsS http://127.0.0.1:5057/health
```

## UI

```bash
node --check app/app.js
python3 -m http.server 4173 --directory app
```

GitHub Pages публикует `app/` только как prototype/demo.

## Add-in

На Windows из корня репозитория:

```powershell
.\build-family-factory-revit.ps1 -RevitVersions 2024,2025
```

Revit 2024 target обязан ссылаться на API assembly `24.0.0.0` и не требовать update 2024.3. Revit 2025 собирается отдельным target.

## Installer

```powershell
.\build-artel-installer.ps1
```

Готовый EXE — build artifact. Он не коммитится в Git.

## Release gate

Compile и unit tests проверяют исходники, но не доказывают работоспособность Revit-агента.

Минимальный выпускной gate:

1. clean Windows checkout;
2. backend/add-in compile для заявленных версий Revit;
3. installer build и SHA-256;
4. silent install при закрытом Revit;
5. проверка manifest/versioned DLL path;
6. backend/Ollama/LES status;
7. живой Revit hand-test на открытой модели;
8. проверка actual result в Revit, а не только model plan.

Критические hand-tests: document describe, category discovery, typed aggregate, selection, schedule fields/create, instance/type parameter read/write, guard ON/OFF, rollback.

## Version

Канон — `version.json`. В той же правке синхронизировать `installer/ARTEL.iss`.

## Запреты

- не коммитить build outputs;
- не считать synthetic tool JSON заменой живого Revit;
- не менять удалённую Windows/Revit-машину без явного разрешения;
- не запускать LES reindex из этого проекта;
- не добавлять category-specific intent code.
