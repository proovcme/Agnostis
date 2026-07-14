param([string]$Configuration = "Release")
$ErrorActionPreference = "Stop"
$root = Split-Path -Parent $MyInvocation.MyCommand.Path
$installer = Join-Path $root "installer"
$payload = Join-Path $installer "payload"
$iscc = ${env:ProgramFiles(x86)} + "\Inno Setup 6\ISCC.exe"
if (-not (Test-Path $iscc)) { throw "Inno Setup 6 not found. Install JRSoftware.InnoSetup with winget." }
if (Test-Path $payload) { Remove-Item $payload -Recurse -Force }
New-Item -ItemType Directory -Path (Join-Path $payload "backend") -Force | Out-Null

dotnet publish (Join-Path $root "backend\Agnostis.Api\Agnostis.Api.csproj") -c $Configuration -r win-x64 --self-contained true `
  -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true -o (Join-Path $payload "backend")
if ($LASTEXITCODE -ne 0) { throw "ARTEL backend publish failed" }
Copy-Item (Join-Path $root "app") (Join-Path $payload "backend\app") -Recurse -Force

& (Join-Path $root "build-family-factory-revit.ps1") -RevitVersions 2024,2025 -Configuration $Configuration -InstallRoot (Join-Path $payload "revit")
if ($LASTEXITCODE -ne 0) { throw "ARTEL Revit add-in build failed" }

& $iscc (Join-Path $installer "ARTEL.iss")
if ($LASTEXITCODE -ne 0) { throw "ARTEL installer build failed" }
Get-Item (Join-Path $installer "dist\ARTEL-Setup.exe") | Select-Object FullName,Length,LastWriteTimeUtc | ConvertTo-Json
