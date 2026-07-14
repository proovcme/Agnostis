param([switch]$Restart, [switch]$Worker)
$ErrorActionPreference = "Stop"
$installRoot = Split-Path -Parent $PSScriptRoot
$stateRoot = if ($env:ARTEL_STATE_ROOT) { $env:ARTEL_STATE_ROOT } else { Join-Path $env:LOCALAPPDATA "ARTEL" }
$logRoot = Join-Path $stateRoot "logs"
$pidFile = Join-Path $logRoot "backend.pid"
New-Item -ItemType Directory -Path $logRoot -Force | Out-Null

$taskName = "ARTEL Backend"
if (-not $Worker) {
    $existingTask = Get-ScheduledTask -TaskName $taskName -ErrorAction SilentlyContinue
    if ($existingTask -and $existingTask.State -eq "Running" -and -not $Restart) { exit 0 }
    if ($Restart) {
        Stop-ScheduledTask -TaskName $taskName -ErrorAction SilentlyContinue
        if (Test-Path $pidFile) {
            Stop-Process -Id ([int](Get-Content $pidFile -Raw)) -Force -ErrorAction SilentlyContinue
            Remove-Item $pidFile -Force -ErrorAction SilentlyContinue
        }
    }
    $powershell = (Get-Command powershell.exe).Source
    $arguments = '-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File "' + $MyInvocation.MyCommand.Path + '" -Worker'
    $action = New-ScheduledTaskAction -Execute $powershell -Argument $arguments -WorkingDirectory $installRoot
    $settings = New-ScheduledTaskSettingsSet -ExecutionTimeLimit (New-TimeSpan -Days 3650) -RestartCount 3 -RestartInterval (New-TimeSpan -Minutes 1)
    Register-ScheduledTask -TaskName $taskName -Action $action -Settings $settings -Force | Out-Null
    Start-ScheduledTask -TaskName $taskName
    exit 0
}

if (Test-Path $pidFile) {
    $existing = Get-Process -Id ([int](Get-Content $pidFile -Raw)) -ErrorAction SilentlyContinue
    if ($existing) { exit 0 }
}

$ollamaModel = if ($env:OLLAMA_MODEL) { $env:OLLAMA_MODEL } else { "qwen3.5:9b" }
$ollamaBaseUrl = if ($env:OLLAMA_BASE_URL) { $env:OLLAMA_BASE_URL } else { "http://127.0.0.1:11434" }
$ollamaCommand = Get-Command "ollama.exe" -ErrorAction SilentlyContinue
$ollama = [ordered]@{ installed=($null -ne $ollamaCommand); reachable=$false; model=$ollamaModel; modelInstalled=$false; status="not_installed"; message="Ollama не установлена" }
if ($ollamaCommand) {
    $ollama.status = "service_unavailable"; $ollama.message = "Ollama установлена, но сервис не отвечает"
    try {
        $tags = Invoke-RestMethod "$($ollamaBaseUrl.TrimEnd('/'))/api/tags" -TimeoutSec 3
        $ollama.reachable = $true
        $ollama.modelInstalled = @($tags.models | ForEach-Object { $_.name }) -contains $ollamaModel
        if ($ollama.modelInstalled) { $ollama.status="ready"; $ollama.message="Ollama и модель $ollamaModel готовы" }
        else { $ollama.status="model_missing"; $ollama.message="Модель $ollamaModel не загружена" }
    } catch {}
}
[ordered]@{schema="artel.runtime-status.v1";checkedAt=[DateTimeOffset]::UtcNow.ToString("o");ollama=$ollama} |
    ConvertTo-Json -Depth 5 | Set-Content (Join-Path $logRoot "runtime-status.json") -Encoding UTF8

$env:ARTEL_STATE_ROOT = $stateRoot
$env:ARTEL_DATA_DIR = Join-Path $stateRoot "data"
$env:LES_BASE_URL = if ($env:LES_BASE_URL) { $env:LES_BASE_URL } else { "http://127.0.0.1:8050" }
$env:OLLAMA_BASE_URL = $ollamaBaseUrl
$env:OLLAMA_MODEL = $ollamaModel
$env:ASPNETCORE_URLS = "http://127.0.0.1:5057"
$backend = Join-Path $installRoot "backend\Agnostis.Api.exe"
$process = Start-Process $backend -WorkingDirectory (Split-Path $backend -Parent) -WindowStyle Hidden `
    -RedirectStandardOutput (Join-Path $logRoot "backend.log") `
    -RedirectStandardError (Join-Path $logRoot "backend-error.log") -PassThru
Set-Content $pidFile $process.Id -Encoding ASCII
$process.WaitForExit()
Remove-Item $pidFile -Force -ErrorAction SilentlyContinue
