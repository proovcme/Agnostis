param([switch]$Register)
$ErrorActionPreference = "Stop"

$taskName = "LES ARTEL Index Proxy"
$lesRoot = Join-Path $env:LOCALAPPDATA "Programs\LES\runtime"
$uv = (Get-Command uv.exe -ErrorAction SilentlyContinue).Source
$logRoot = Join-Path $env:LOCALAPPDATA "LES\logs"

if ($Register) {
    if (-not $uv -or -not (Test-Path (Join-Path $lesRoot "pyproject.toml"))) { exit 0 }
    $powershell = (Get-Command powershell.exe).Source
    $arguments = '-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File "' + $MyInvocation.MyCommand.Path + '"'
    $action = New-ScheduledTaskAction -Execute $powershell -Argument $arguments -WorkingDirectory $lesRoot
    $settings = New-ScheduledTaskSettingsSet -ExecutionTimeLimit (New-TimeSpan -Days 3650) -RestartCount 3 -RestartInterval (New-TimeSpan -Minutes 1)
    Register-ScheduledTask -TaskName $taskName -Action $action -Settings $settings -Force | Out-Null
    if (-not (Get-NetTCPConnection -LocalPort 8050 -State Listen -ErrorAction SilentlyContinue)) {
        Start-ScheduledTask -TaskName $taskName
    }
    exit 0
}

if (-not $uv) { throw "uv.exe is required to start the installed LES runtime" }
New-Item -ItemType Directory -Path $logRoot -Force | Out-Null

$env:LES_EMBED_PROFILE = "legacy"
$env:RAG_META_DB_PATH = Join-Path $lesRoot "data\les_meta.db"
$env:RAG_INDEX_CONTRACT_PATH = Join-Path $lesRoot "data\les_meta.db.les_rag.index-contract.json"
$env:RAG_COLLECTION_NAME = "les_rag"
$env:RAG_VECTOR_SIZE = "1024"
$env:RAG_CHUNK_UNIT = "chars"
$env:RAG_CHUNK_SIZE = "900"
$env:RAG_CHUNK_OVERLAP = "80"
$env:OLLAMA_BASE_URL = "http://127.0.0.1:11434"
$env:MLX_URL = $env:OLLAMA_BASE_URL
$env:EMBED_URL_PARSE = $env:OLLAMA_BASE_URL
$env:EMBED_MODEL = "bge-m3:latest"
$env:EMBEDDING_MODEL = "bge-m3"
$env:EMBED_BACKEND = "ollama"
$env:RERANKER_ENABLED = "true"
$env:RERANKER_BACKEND = "sentence_transformers"
$env:RERANK_MODEL = "BAAI/bge-reranker-v2-m3"

Set-Location $lesRoot
& $uv run uvicorn proxy_server:app --host 127.0.0.1 --port 8050 `
    1>> (Join-Path $logRoot "artel-index-proxy.out.log") `
    2>> (Join-Path $logRoot "artel-index-proxy.err.log")
exit $LASTEXITCODE
