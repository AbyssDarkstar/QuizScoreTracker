; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Quiz Score Tracker"
#define MyAppVersion "1.0.0.0"
#define MyAppPublisher "Studio Darkstar"
#define MyAppCopyright "Copyright � 2020"
#define MyAppExeName "QuizScoreTracker.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{72652EBA-5007-4077-BCDA-81A1AB3EB9D8}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} v{#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppCopyright={#MyAppCopyright} {#MyAppPublisher}
DefaultDirName={autopf}\Studio Darkstar\Quiz Score Tracker
DefaultGroupName=Studio Darkstar\Quiz Score Tracker
AllowNoIcons=yes
InfoBeforeFile=D:\Development\GitHub\QuizScoreTracker\Update Notes\{#MyAppVersion}.txt
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=D:\Development\GitHub\QuizScoreTracker\Installers
OutputBaseFilename=QuizScoreTrackerInstaller
Compression=lzma
SolidCompression=yes
WizardStyle=modern
UninstallDisplayName={#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
DisableWelcomePage=no

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Development\GitHub\QuizScoreTracker\QuizScoreTracker\bin\Release\QuizScoreTracker.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Development\GitHub\QuizScoreTracker\QuizScoreTracker\bin\Release\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Development\GitHub\QuizScoreTracker\QuizScoreTracker\bin\Release\QuizScoreTracker.exe.config"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

