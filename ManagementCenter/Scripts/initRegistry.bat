
echo function Create-AesManagedObject($key, $IV) { >c:\initRegistry.ps1
echo 	$aesManaged = New-Object "System.Security.Cryptography.AesManaged" >>c:\initRegistry.ps1
echo 	$aesManaged.Mode = [System.Security.Cryptography.CipherMode]::CBC>>c:\initRegistry.ps1
echo 	$aesManaged.Padding = [System.Security.Cryptography.PaddingMode]::Zeros>>c:\initRegistry.ps1
echo 	$aesManaged.BlockSize = 128>>c:\initRegistry.ps1
echo 	$aesManaged.KeySize = 256>>c:\initRegistry.ps1

echo 	if ($IV) {>>c:\initRegistry.ps1
echo 		if ($IV.getType().Name -eq "String") {>>c:\initRegistry.ps1
echo 			$aesManaged.IV = [System.Convert]::FromBase64String($IV)>>c:\initRegistry.ps1
echo 		}>>c:\initRegistry.ps1
echo 		else {>>c:\initRegistry.ps1
echo 			$aesManaged.IV = $IV>>c:\initRegistry.ps1
echo 		}>>c:\initRegistry.ps1
echo 	}>>c:\initRegistry.ps1

echo 	if ($key) {>>c:\initRegistry.ps1
echo 		if ($key.getType().Name -eq "String") {>>c:\initRegistry.ps1
echo 			$aesManaged.Key = [System.Convert]::FromBase64String($key)>>c:\initRegistry.ps1
echo 		}>>c:\initRegistry.ps1
echo 		else {>>c:\initRegistry.ps1
echo 			$aesManaged.Key = $key>>c:\initRegistry.ps1
echo 		}>>c:\initRegistry.ps1
echo 	}>>c:\initRegistry.ps1

echo 	$aesManaged>>c:\initRegistry.ps1
echo }>>c:\initRegistry.ps1

echo function Encrypt-String($key, $unencryptedString) {>>c:\initRegistry.ps1
echo 	$bytes = [System.Text.Encoding]::UTF8.GetBytes($unencryptedString)>>c:\initRegistry.ps1
echo 	$aesManaged = Create-AesManagedObject $key $IV>>c:\initRegistry.ps1
echo 	$encryptor = $aesManaged.CreateEncryptor()>>c:\initRegistry.ps1
echo 	$encryptedData = $encryptor.TransformFinalBlock($bytes, 0, $bytes.Length);>>c:\initRegistry.ps1
echo 	[byte[]] $fullData = $aesManaged.IV + $encryptedData>>c:\initRegistry.ps1
echo 	$aesManaged.Dispose()>>c:\initRegistry.ps1
echo 	[System.Convert]::ToBase64String($fullData)>>c:\initRegistry.ps1
echo }>>c:\initRegistry.ps1

echo Function Get-StringHash { >>c:\initRegistry.ps1
echo     param>>c:\initRegistry.ps1
echo     (>>c:\initRegistry.ps1
echo         [String] $String,>>c:\initRegistry.ps1
echo         $HashName = "MD5">>c:\initRegistry.ps1
echo     )>>c:\initRegistry.ps1
echo     $bytes = [System.Text.Encoding]::UTF8.GetBytes($String)>>c:\initRegistry.ps1
echo     $algorithm = [System.Security.Cryptography.HashAlgorithm]::Create('MD5')>>c:\initRegistry.ps1
echo     $StringBuilder = New-Object System.Text.StringBuilder >>c:\initRegistry.ps1

echo     $algorithm.ComputeHash($bytes) ^| >>c:\initRegistry.ps1
echo     ForEach-Object { >>c:\initRegistry.ps1
echo         $null = $StringBuilder.Append($_.ToString("x2")) >>c:\initRegistry.ps1
echo     } >>c:\initRegistry.ps1

echo     $StringBuilder.ToString() >>c:\initRegistry.ps1
echo }>>c:\initRegistry.ps1

echo $serial = gwmi win32_bios ^| select -expand serialnumber>>c:\initRegistry.ps1

echo $key_passphrase = Get-StringHash $serial>>c:\initRegistry.ps1

echo $Bytes = [System.Text.Encoding]::Ascii.GetBytes($key_passphrase)[0..15]>>c:\initRegistry.ps1

echo $key =[Convert]::ToBase64String($Bytes)>>c:\initRegistry.ps1

echo $IV = (new-Object Security.Cryptography.SHA256Managed).ComputeHash( [Text.Encoding]::Ascii.GetBytes($key_passphrase) )[0..15] >>c:\initRegistry.ps1


echo $unencryptedString = "Data Source = [SQL_SERVER]; Initial Catalog = [SQL_DB_NAME]; Persist Security Info = True; User ID = [SQL_USER]; Password = [SQL_PASSWORD]; Connection Timeout = 20">>c:\initRegistry.ps1
echo $encryptedString = Encrypt-String $key $unencryptedString>>c:\initRegistry.ps1
	
echo if ([Environment]::Is64BitOperatingSystem) {>>c:\initRegistry.ps1
echo [microsoft.win32.registry]::SetValue('HKEY_LOCAL_MACHINE\Software\WOW6432Node\MTAAgent', 'CON', $encryptedString)>>c:\initRegistry.ps1
echo [microsoft.win32.registry]::SetValue('HKEY_LOCAL_MACHINE\Software\WOW6432Node\MTAAgent', 'RoomID', '[RoomID]')}>>c:\initRegistry.ps1
echo else {>>c:\initRegistry.ps1
echo [microsoft.win32.registry]::SetValue('HKEY_LOCAL_MACHINE\Software\MTAAgent', 'CON', $encryptedString)>>c:\initRegistry.ps1
echo [microsoft.win32.registry]::SetValue('HKEY_LOCAL_MACHINE\Software\MTAAgent', 'RoomID', '[RoomID]')}>>c:\initRegistry.ps1


