param(
    [string]$LesBaseUrl = $(if ($env:LES_BASE_URL) { $env:LES_BASE_URL } else { "http://127.0.0.1:8050" }),
    [string]$LesRagContentRoot = $(if ($env:LES_RAG_CONTENT_ROOT) { $env:LES_RAG_CONTENT_ROOT } else { Join-Path $env:LOCALAPPDATA "Programs\LES\RAG_Content" })
)
$ErrorActionPreference = "Stop"
$installRoot = Split-Path -Parent $PSScriptRoot
$source = Join-Path $installRoot "knowledge\ARTEL"
$destination = Join-Path $LesRagContentRoot "ARTEL"
$stateRoot = if ($env:ARTEL_STATE_ROOT) { $env:ARTEL_STATE_ROOT } else { Join-Path $env:LOCALAPPDATA "ARTEL" }
$statusPath = Join-Path $stateRoot "logs\knowledge-status.json"
New-Item -ItemType Directory -Path (Split-Path $statusPath -Parent) -Force | Out-Null

try {
    if (-not (Test-Path $source)) { throw "Bundled ARTEL knowledge is missing: $source" }
    New-Item -ItemType Directory -Path $destination -Force | Out-Null
    Copy-Item (Join-Path $source "*") $destination -Recurse -Force
    $health = $null
    foreach ($attempt in 1..12) {
        try {
            $health = Invoke-RestMethod "$($LesBaseUrl.TrimEnd('/'))/api/health" -TimeoutSec 10
            break
        } catch {
            if ($attempt -eq 12) { throw }
            Start-Sleep -Seconds 5
        }
    }
    if (-not $health.rag.index_contract.compatible) { throw "LES index contract is not compatible" }
    $sync = Invoke-RestMethod -Method Post "$($LesBaseUrl.TrimEnd('/'))/api/rag/sync/ARTEL" -TimeoutSec 120
    [ordered]@{schema="artel.knowledge-status.v1";status="sync_started";checkedAt=[DateTimeOffset]::UtcNow.ToString("o");source=$source;destination=$destination;dataset="ARTEL_Index";jobId=$sync.job_id} |
        ConvertTo-Json -Depth 5 | Set-Content $statusPath -Encoding UTF8
} catch {
    [ordered]@{schema="artel.knowledge-status.v1";status="sync_failed";checkedAt=[DateTimeOffset]::UtcNow.ToString("o");source=$source;destination=$destination;dataset="ARTEL_Index";message=$_.Exception.Message} |
        ConvertTo-Json -Depth 5 | Set-Content $statusPath -Encoding UTF8
    exit 1
}
