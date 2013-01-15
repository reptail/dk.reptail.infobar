@ECHO OFF

REM Define Variables
SET sln=%1
SET build=%sln%\InfoBar\bin\Release
SET out=%sln%\LatestBuild
SET rar="c:\Program Files\WinRAR\rar.exe"

REM Deleting Previous Build
ECHO Deleting old release files...
DEL /Q %out%\* >nul 2>&1

REM Copying New Build
ECHO Copying new release files...
COPY /Y %build%\InfoBar.exe %out% >nul 2>&1
COPY /Y %build%\InfoBar.Modules.dll %out% >nul 2>&1
COPY /Y %build%\InfoBar.Libraries.dll %out% >nul 2>&1
COPY /Y %build%\InfoBar.Settings.xml %out% >nul 2>&1

REM Creating RAR
ECHO Creating RAR Archive...
cd %out%
%rar% a InfoBar.rar >nul 2>&1
cd..