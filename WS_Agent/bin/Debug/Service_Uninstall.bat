@echo OFF
echo Stopping old service version...
net stop "AMS_TMS_"
echo Uninstalling old service version...
sc delete "AMS_TMS_"


pause