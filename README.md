# MyVeras AI Rendering — плагин для Autodesk Revit

[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-purple)](https://dotnet.microsoft.com/)
[![Revit API 2025](https://img.shields.io/badge/Revit%20API-2025-blue)](https://aps.autodesk.com/)
[![WPF](https://img.shields.io/badge/UI-WPF-orange)](https://docs.microsoft.com/dotnet/desktop/wpf/)
[![License: MIT](https://img.shields.io/badge/License-MIT-green)](LICENSE)

**MyVeras** — профессиональный плагин для гибридного AI-рендеринга в Autodesk Revit с поддержкой локальных (ComfyUI) и облачных (GenAPI.ru) движков генерации изображений.

---

## 🎨 Возможности

- 🖼️ **Гибридный рендеринг**: переключение между локальным ComfyUI и облачным GenAPI.ru
- 📸 **Захват видов Revit**: экспорт 3D-видов через `ImageExportOptions`
- 🤖 **AI-генерация**: поддержка промптов, ControlNet depth maps, архитектурных стилей
- ⚙️ **Гибкие настройки**: конфигурация через `settings.json` в `%AppData%/MyVeras`
- 📊 **Логирование**: детальное логирование с временными метками
- 🧪 **Тестирование**: полный набор юнит-тестов на xUnit

---

## 🏗️ Архитектура

### Паттерны проектирования
- **Strategy** — абстракция движков рендеринга (`IRenderingEngine`)
- **Singleton** — единый экземпляр `SettingsManager`
- **MVVM** — разделение логики и UI в `MyVeras.UI`

### Структура решения (9 проектов)

```
MyVeras/
├── MyVeras.Core/          # Ядро: GenApiClient, сервисы, интерфейсы
├── MyVeras.Models/        # Модели: RenderingRequest, RenderingResult, BIMDataContext
├── MyVeras.Settings/      # SettingsManager для работы с JSON-конфигурацией
├── MyVeras.Engines/       # LocalEngine (ComfyUI) + CloudEngine (GenAPI.ru REST)
├── MyVeras.UI/            # WPF: MainWindow, MainViewModel, конвертеры
├── MyVeras.RevitAPI/      # Интеграция: Revit 2025 API, команды, external events
├── MyVeras.Setup/         # Установщик: WPF-мастер установки
├── MyVeras.Setup.Wix/     # WiX-проект для MSI-пакета
├── MyVeras.Tests/         # Юнит-тесты: xUnit, Moq
├── Dist/                  # Скомпилированные сборки и установочные файлы
└── MyVeras.sln            # Решение Visual Studio 2022
```

---

## 🔧 Компоненты

### 1. Ядро (MyVeras.Core)
- `GenApiClient` — клиент для работы с API GenAPI.ru
- `IRenderingEngine` — интерфейс движка рендеринга
- `IMyVerasService` — сервис управления рендерингом
- `IRevitView` — абстракция работы с видами Revit

### 2. Движки (MyVeras.Engines)
- **LocalEngine**: интеграция с ComfyUI/Automatic1111
  - URL: `http://localhost:7860`
  - Поддержка ControlNet depth maps
  - Асинхронная очередь задач
- **CloudEngine**: REST API GenAPI.ru
  - Авторизация через API-ключ
  - Polling-механизм готовности задачи
  - Обработка Base64-изображений

### 3. Модели данных (MyVeras.Models)
- `RenderingRequest` — параметры запроса (промпт, разрешение, шаги)
- `RenderingResult` — результат рендеринга (изображение, метаданные)
- `BIMDataContext` — контекст BIM-данных (материалы, категории, виды)

### 4. Настройки (MyVeras.Settings)
Конфигурация хранится в `%AppData%/MyVeras/settings.json`:

```json
{
  "ActiveProvider": "Local",
  "Cloud": {
    "Url": "https://api.genapi.ru/v1",
    "Key": "your-api-key-here"
  },
  "Local": {
    "Url": "http://localhost:7860",
    "Model": "SDXL_Architectural",
    "UseControlNet": true
  },
  "Logging": {
    "Level": "Information",
    "FilePath": "%AppData%/MyVeras/logs/myveras.log"
  }
}
```

### 5. Пользовательский интерфейс (MyVeras.UI)
- **MainWindow**: основное окно плагина
- **MainViewModel**: ViewModel с бизнес-логикой
- **Переключатель источников**: Local ↔ Cloud
- **Индикатор статуса**: подключение, прогресс, ошибки
- **Настройки изображения**: промпт, разрешение, AI influence, steps
- **Галерея**: последние 3 рендера
- **Prompt Helper**: авто-генерация промпта из BIM-контекста

### 6. Интеграция с Revit (MyVeras.RevitAPI)
- **Revit API 2025**: полная совместимость
- **Commands**: запуск рендеринга из ленты Revit
- **External Event Handler**: безопасная работа с API Revit из UI
- **MockRenderingEngine**: заглушка для тестирования без Revit

### 7. Установщики
- **MyVeras.Setup**: интерактивный WPF-установщик
- **MyVeras.Setup.Wix**: WiX Toolset для создания MSI

---

## 📋 Требования

| Компонент | Версия |
|-----------|--------|
| ОС | Windows 10/11 (x64) |
| .NET | 8.0 Windows |
| Revit | 2025 |
| IDE | Visual Studio 2022 |
| Локальный AI | ComfyUI или Automatic1111 (опционально) |
| Облачный AI | Аккаунт GenAPI.ru (опционально) |

---

## 🚀 Установка

### Быстрый старт

1. **Скачайте дистрибутив** из папки `Dist/` или соберите проект:
   ```bash
   .\build.bat
   ```

2. **Установите плагин**:
   - Запустите `Dist/install.bat` (копирует `.addin` и DLL в папку Revit)
   - Или используйте `MyVeras.Setup.exe` для полной установки

3. **Настройте подключение**:
   - Для **локального рендеринга**: запустите ComfyUI на `http://localhost:7860`
   - Для **облачного рендеринга**: получите API-ключ на [GenAPI.ru](https://genapi.ru)

4. **Запустите Revit 2025** → вкладка **Add-Ins** → **MyVeras**

### Ручная установка

```bash
# Копирование файлов плагина
xcopy /E /Y "Dist\*" "C:\ProgramData\Autodesk\REVIT\Addins\2025\MyVeras\"

# Регистрация аддона (автоматически при копировании .addin файла)
```

---

## 💻 Использование

1. Откройте **3D-вид** в Revit
2. Перейдите на вкладку **MyVeras** → нажмите **Render**
3. Выберите источник рендеринга: **Local** или **Cloud**
4. Настройте параметры:
   - **Prompt**: описание желаемого результата
   - **Resolution**: 512×512, 1024×1024 и т.д.
   - **AI Influence**: сила влияния ИИ (0–100%)
   - **Steps**: количество шагов диффузии
5. Нажмите **Start Rendering**
6. Дождитесь завершения → результат отобразится в галерее

---

## 🛠️ Разработка

### Сборка проекта

```bash
# Через PowerShell
.\build.ps1

# Или вручную
dotnet restore MyVeras.sln
dotnet build MyVeras.sln --configuration Release
```

### Запуск тестов

```bash
dotnet test MyVeras.Tests/MyVeras.Tests.csproj --verbosity normal
```

### Структура тестов
- `GenApiClientTests` — тесты клиента GenAPI
- `SettingsManagerTests` — управление настройками
- `RenderingModelsTests` — модели данных
- `ErrorHandlingTests` — обработка ошибок
- `BuildSmokeTests` — проверка сборки

### Логирование

Логи сохраняются в:
```
%AppData%/MyVeras/logs/myveras_YYYY-MM-DD.log
```

Формат лога:
```
[2025-01-15 14:32:10] [INFO] Rendering started with LocalEngine
[2025-01-15 14:32:15] [DEBUG] Sending request to http://localhost:7860/api/prompt
[2025-01-15 14:32:45] [INFO] Rendering completed successfully
```

---

## 🌐 API GenAPI.ru

### Регистрация
1. Зарегистрируйтесь на [genapi.ru](https://genapi.ru)
2. Получите API-ключ в личном кабинете
3. Добавьте ключ в `settings.json`:
   ```json
   "Cloud": {
     "Url": "https://api.genapi.ru/v1",
     "Key": "gapi_xxxxxxxxxxxxx"
   }
   ```

### Поддерживаемые модели
- SDXL Architectural
- Realistic Vision
- ArchVis Diffusion
- Custom LoRA модели

---

## 🧩 Расширение функциональности

### Добавление нового движка

1. Создайте класс, реализующий `IRenderingEngine`:
   ```csharp
   public class CustomEngine : IRenderingEngine
   {
       public Task<RenderingResult> RenderAsync(RenderingRequest request, CancellationToken ct)
       {
           // Ваша логика
       }
   }
   ```

2. Зарегистрируйте движок в `MyVerasService`

### Кастомизация UI
- Измените `MyVerasWindow.xaml` для нового дизайна
- Обновите `MainViewModel` для новой логики
- Добавьте конвертеры в папку `Converters/`

---

## 📄 Лицензия

MIT License — см. файл [LICENSE](LICENSE)

---

## 🤝 Поддержка

- **Документация**: [BUILD.md](BUILD.md) — подробное руководство по сборке
- **Вопросы**: создайте Issue в репозитории
- **Генерация изображений**: [GenAPI.ru](https://genapi.ru)

---

## 📸 Скриншоты

*(Добавьте скриншоты интерфейса в папку `docs/screenshots/`)*

---

**MyVeras** — ваш интеллектуальный помощник для архитектурной визуализации в Revit! 🏗️✨
