@echo off
echo ========================================
echo MyVeras AI Rendering Installer
echo ========================================
echo.

:: Check Revit 2025 installation
if not exist "%PROGRAMFILES%\Autodesk\Revit 2025\Revit.exe" (
    echo [ERROR] Revit 2025 not found!
    echo Please install Revit 2025 first.
    pause
    exit /b 1
)

:: Create Addins directory if not exists
if not exist "%APPDATA%\Autodesk\Revit\Addins\2025" (
    echo Creating Addins directory...
    mkdir "%APPDATA%\Autodesk\Revit\Addins\2025"
)

:: Create MyVeras subdirectory
if not exist "%APPDATA%\Autodesk\Revit\Addins\2025\MyVeras" (
    echo Creating MyVeras directory...
    mkdir "%APPDATA%\Autodesk\Revit\Addins\2025\MyVeras"
)

:: Copy plugin files to subdirectory
echo Installing MyVeras plugin files...
xcopy "MyVeras\*" "%APPDATA%\Autodesk\Revit\Addins\2025\MyVeras\" /E /I /Y

:: Copy add-in manifest to main directory with correct path
echo Installing add-in manifest...
copy "MyVeras.addin" "%APPDATA%\Autodesk\Revit\Addins\2025\"

echo.
echo ========================================
echo Installation completed!
echo ========================================
echo.
echo Plugin installed to: %APPDATA%\Autodesk\Revit\Addins\2025\MyVeras\
echo DLL location: MyVeras\MyVeras.RevitAPI.dll
echo.
echo Please restart Revit 2025 to use MyVeras AI Rendering
echo.
pause
