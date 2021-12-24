@echo OFF
echo Stopping old service version...
net stop "MTAAgent"
echo Uninstalling old service version...
sc delete "MTAAgent"
echo Installing service...
rem DO NOT remove the space after "binpath="!
sc create "MTAAgent" binpath= "%~dp0\WS_Agent.exe" start= auto
net start "MTAAgent"
echo Starting service complete
