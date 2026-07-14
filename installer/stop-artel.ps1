$stateRoot = if ($env:ARTEL_STATE_ROOT) { $env:ARTEL_STATE_ROOT } else { Join-Path $env:LOCALAPPDATA "ARTEL" }
$pidFile = Join-Path $stateRoot "logs\backend.pid"
Stop-ScheduledTask -TaskName "ARTEL Backend" -ErrorAction SilentlyContinue
if (Test-Path $pidFile) {
    Stop-Process -Id ([int](Get-Content $pidFile -Raw)) -Force -ErrorAction SilentlyContinue
    Remove-Item $pidFile -Force -ErrorAction SilentlyContinue
}
Unregister-ScheduledTask -TaskName "ARTEL Backend" -Confirm:$false -ErrorAction SilentlyContinue
