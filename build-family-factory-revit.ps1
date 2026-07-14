param(
    [int[]]$RevitVersions = @(2025),
    [string]$Configuration = "Release",
    [string]$InstallRoot = "$env:APPDATA\Autodesk\Revit\Addins"
)

$ErrorActionPreference = "Stop"

$root = Split-Path -Parent $MyInvocation.MyCommand.Path
$project = Join-Path $root "ARTEL.Revit.FamilyFactory\ARTEL.Revit.FamilyFactory.csproj"
$template = Join-Path $root "ARTEL.Revit.FamilyFactory\ARTEL.Revit.FamilyFactory.addin.template"

if (-not (Test-Path $project)) {
    throw "Project not found: $project"
}
$results = @()
foreach ($version in $RevitVersions) {
    if ($version -notin @(2024, 2025)) { throw "Supported Revit versions are 2024 and 2025" }
    $revitInstallDir = "C:\Program Files\Autodesk\Revit $version"
    $framework = if ($version -eq 2024) { "net48" } else { "net8.0-windows" }
    if (-not (Test-Path (Join-Path $revitInstallDir "RevitAPI.dll"))) {
        throw "RevitAPI.dll not found under $revitInstallDir"
    }
    $apiAssemblyVersion = [Reflection.AssemblyName]::GetAssemblyName((Join-Path $revitInstallDir "RevitAPI.dll")).Version
    if ($version -eq 2024 -and ($apiAssemblyVersion.Major -ne 24 -or $apiAssemblyVersion.Minor -ne 0)) {
        throw "Revit 2024 build must target the 24.0.0.0 API contract (compatible with base Revit 2024.0); found $apiAssemblyVersion"
    }
    dotnet build $project --configuration $Configuration --framework $framework -p:RevitInstallDir="$revitInstallDir"
    if ($LASTEXITCODE -ne 0) { throw "Revit $version add-in build failed with exit code $LASTEXITCODE" }

    $outputDir = Join-Path $root "ARTEL.Revit.FamilyFactory\bin\$Configuration\$framework"
    $installDir = Join-Path (Join-Path $InstallRoot $version) "ARTEL.FamilyFactory"
    New-Item -ItemType Directory -Path $installDir -Force | Out-Null
    Copy-Item (Join-Path $outputDir "*.dll") $installDir -Force
    $addinPath = Join-Path (Split-Path -Parent $installDir) "ARTEL.Revit.FamilyFactory.addin"
    $addin = (Get-Content $template -Raw).Replace("__INSTALL_DIR__", $installDir)
    Set-Content -Path $addinPath -Value $addin -Encoding UTF8
    $results += [pscustomobject]@{ version=$version; framework=$framework; apiAssemblyVersion=$apiAssemblyVersion.ToString(); installDir=$installDir; addin=$addinPath }
}

[pscustomobject]@{ status="ok"; project=$project; installs=$results } | ConvertTo-Json -Depth 5
