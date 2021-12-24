
echo $File = "c:\MTAAgent.zip">c:\install_Service.ps1

echo $ftp = "ftp://ftp_user:CMCGlobal2020@192.168.35.99/MTAAgent/MTAAgent.zip" >>c:\install_Service.ps1

echo "ftp url: $ftp">>c:\install_Service.ps1

echo $webclient = New-Object System.Net.WebClient>>c:\install_Service.ps1

echo $uri = New-Object System.Uri($ftp)>>c:\install_Service.ps1

echo "Downloading $File...">>c:\install_Service.ps1

echo $webclient.DownloadFile($uri, $File)>>c:\install_Service.ps1

echo if (Get-Service MTAAgent -ErrorAction SilentlyContinue) {>>c:\install_Service.ps1
echo   $service = Get-WmiObject -Class Win32_Service -Filter "name='MTAAgent'">>c:\install_Service.ps1
echo   $service.StopService()>>c:\install_Service.ps1
echo   Start-Sleep -s 2 >>c:\install_Service.ps1
echo   $service.delete()>>c:\install_Service.ps1
echo }>>c:\install_Service.ps1

echo $Folder_Install = (get-date).ToString("yyyy-MM-dd HHmmss")>>c:\install_Service.ps1
echo Expand-Archive -Path "C:\MTAAgent.zip" -DestinationPath "C:\MTAAgent\$Folder_Install" -Force >>c:\install_Service.ps1

echo $workdir = "C:\MTAAgent\$Folder_Install">>c:\install_Service.ps1

echo # Create the new service.>>c:\install_Service.ps1
echo New-Service -name MTAAgent -displayName MTAAgent -binaryPathName "$workdir\WS_Agent.exe" -startupType Automatic>>c:\install_Service.ps1

echo Start-Service -Name "MTAAgent">>c:\install_Service.ps1