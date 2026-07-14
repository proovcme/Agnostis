#define MyAppName "АРТЕЛЬ"
#define MyAppVersion "0.25.9"
#define MyPayloadVersion "0.25.9-420"
#define MyAppPublisher "OVC"

[Setup]
AppId={{5C090852-9599-45B3-A8C3-4C3F46B9E8F0}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={localappdata}\Programs\ARTEL
DefaultGroupName=АРТЕЛЬ
PrivilegesRequired=lowest
ArchitecturesAllowed=x64compatible
ArchitecturesInstallIn64BitMode=x64compatible
OutputDir=dist
OutputBaseFilename=ARTEL-Setup
SetupIconFile=assets\ARTEL.ico
UninstallDisplayIcon={app}\ARTEL.ico
WizardStyle=modern
WizardImageFile=assets\wizard-large.bmp
WizardSmallImageFile=assets\wizard-small.bmp
Compression=lzma2/ultra64
SolidCompression=yes
CloseApplications=yes
RestartApplications=no
DisableProgramGroupPage=yes
SetupLogging=yes

[Tasks]
Name: "lesintegration"; Description: "Подключить базу знаний и экспорт к установленному ЛЕС"; GroupDescription: "Дополнительные интеграции:"; Flags: unchecked

[Files]
Source: "payload\backend\*"; DestDir: "{app}\backend"; Flags: recursesubdirs createallsubdirs ignoreversion
Source: "payload\revit\2024\ARTEL.FamilyFactory\*"; DestDir: "{userappdata}\Autodesk\Revit\Addins\2024\ARTEL.FamilyFactory\{#MyPayloadVersion}"; Flags: recursesubdirs createallsubdirs ignoreversion; Check: DirExists(ExpandConstant('{pf}\Autodesk\Revit 2024'))
Source: "payload\revit\2025\ARTEL.FamilyFactory\*"; DestDir: "{userappdata}\Autodesk\Revit\Addins\2025\ARTEL.FamilyFactory\{#MyPayloadVersion}"; Flags: recursesubdirs createallsubdirs ignoreversion; Check: DirExists(ExpandConstant('{pf}\Autodesk\Revit 2025'))
Source: "start-artel.ps1"; DestDir: "{app}\runtime"; Flags: ignoreversion
Source: "stop-artel.ps1"; DestDir: "{app}\runtime"; Flags: ignoreversion
Source: "start-les-artel-index-proxy.ps1"; DestDir: "{app}\runtime"; Flags: ignoreversion
Source: "sync-artel-knowledge.ps1"; DestDir: "{app}\runtime"; Flags: ignoreversion
Source: "..\knowledge\ARTEL_DATASET.json"; DestDir: "{app}\knowledge"; Flags: ignoreversion
Source: "..\knowledge\ARTEL\*"; DestDir: "{app}\knowledge\ARTEL"; Flags: recursesubdirs createallsubdirs ignoreversion
Source: "..\skills\*"; DestDir: "{app}\skills"; Flags: recursesubdirs createallsubdirs ignoreversion
Source: "assets\ARTEL.ico"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
Name: "{group}\АРТЕЛЬ — открыть"; Filename: "http://127.0.0.1:5057/"; IconFilename: "{app}\ARTEL.ico"
Name: "{group}\АРТЕЛЬ — перезапустить"; Filename: "powershell.exe"; Parameters: "-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File ""{app}\runtime\start-artel.ps1"" -Restart"; IconFilename: "{app}\ARTEL.ico"
Name: "{group}\АРТЕЛЬ — обновить базу знаний в ЛЕС"; Filename: "powershell.exe"; Parameters: "-NoProfile -ExecutionPolicy Bypass -File ""{app}\runtime\sync-artel-knowledge.ps1"""; IconFilename: "{app}\ARTEL.ico"; Tasks: lesintegration
Name: "{userstartup}\АРТЕЛЬ backend"; Filename: "powershell.exe"; Parameters: "-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File ""{app}\runtime\start-artel.ps1"""; WorkingDir: "{app}"; IconFilename: "{app}\ARTEL.ico"

[Run]
Filename: "powershell.exe"; Parameters: "-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File ""{app}\runtime\start-les-artel-index-proxy.ps1"" -Register"; Flags: runhidden waituntilterminated; Tasks: lesintegration
Filename: "powershell.exe"; Parameters: "-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File ""{app}\runtime\start-artel.ps1"" -Restart"; Flags: nowait postinstall skipifsilent; Description: "Запустить backend АРТЕЛЬ"
Filename: "powershell.exe"; Parameters: "-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File ""{app}\runtime\sync-artel-knowledge.ps1"""; Flags: nowait postinstall skipifsilent; Description: "Обновить ARTEL Index в ЛЕС"; Tasks: lesintegration

[UninstallRun]
Filename: "powershell.exe"; Parameters: "-NoProfile -ExecutionPolicy Bypass -WindowStyle Hidden -File ""{app}\runtime\stop-artel.ps1"""; Flags: runhidden; RunOnceId: "StopArtelBackend"

[UninstallDelete]
Type: files; Name: "{userappdata}\Autodesk\Revit\Addins\2024\ARTEL.Revit.FamilyFactory.addin"
Type: filesandordirs; Name: "{userappdata}\Autodesk\Revit\Addins\2024\ARTEL.FamilyFactory"
Type: files; Name: "{userappdata}\Autodesk\Revit\Addins\2025\ARTEL.Revit.FamilyFactory.addin"
Type: filesandordirs; Name: "{userappdata}\Autodesk\Revit\Addins\2025\ARTEL.FamilyFactory"

[Code]
procedure WriteAddin(Year: String);
var
  Dir, Manifest, Xml: String;
begin
  Dir := ExpandConstant('{userappdata}\Autodesk\Revit\Addins\' + Year + '\ARTEL.FamilyFactory\{#MyPayloadVersion}');
  if not DirExists(Dir) then exit;
  Manifest := ExpandConstant('{userappdata}\Autodesk\Revit\Addins\' + Year + '\ARTEL.Revit.FamilyFactory.addin');
  Xml := '<?xml version="1.0" encoding="utf-8"?>' + #13#10 +
    '<RevitAddIns><AddIn Type="Application"><Name>ARTEL Family Factory</Name><Assembly>' + Dir + '\ARTEL.Revit.FamilyFactory.dll</Assembly>' +
    '<AddInId>2D6C42A9-893A-4DB2-B26E-1E4415D77633</AddInId><FullClassName>ARTEL.Revit.FamilyFactory.ArtelFamilyFactoryApplication</FullClassName>' +
    '<VendorId>ARTEL</VendorId><VendorDescription>ARTEL Revit family factory</VendorDescription></AddIn></RevitAddIns>';
  SaveStringToFile(Manifest, Xml, False);
end;

procedure CurStepChanged(CurStep: TSetupStep);
begin
  if CurStep = ssPostInstall then begin WriteAddin('2024'); WriteAddin('2025'); end;
end;
