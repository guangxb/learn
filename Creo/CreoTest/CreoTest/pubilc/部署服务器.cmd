@echo off

rem ��ȡ�����װ·��
rem HKEY_LOCAL_MACHINE\SOFTWARE\Kingdee\��� K3 WISE PLM�ͻ��������
rem Path : c:\Program Files\Kingdee\K3PLM\Integration

rem webվ�㰲װĿ¼
rem HKEY_LOCAL_MACHINE\SOFTWARE\Kingdee\KDMIDDLEWARE\K3PLM
rem 64λ
rem HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Kingdee\KDMIDDLEWARE\K3PLM
rem Path : D:\Program Files\kingdee\K3PLM\web

setlocal 

echo ��ʼ����������
if /i "%PROCESSOR_IDENTIFIER:~0,3%" == "X86" ( 
goto x86
) else (
goto x64
)

:x86
for /f "tokens=1,2,* " %%i in ('REG QUERY "HKEY_LOCAL_MACHINE\SOFTWARE\Kingdee\KDMIDDLEWARE\K3PLM" ^| find /i "Path"') do set "PLMPath=%%k"
goto copyoperate

:x64
for /f "tokens=1,2,* " %%i in ('REG QUERY "HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Kingdee\KDMIDDLEWARE\K3PLM" ^| find /i "Path"') do set "PLMPath=%%k"
goto copyoperate

:copyoperate

copy /y "Creo.Server.dll" "%PLMPath%\bin\Creo.Server.dll"
if not exist "%PLMPath%\Integration_back.config.xml" (
	copy /y "%PLMPath%\Integration.config.xml" "%PLMPath%\Integration_back.config.xml"
)
copy /y "ZSKIntegration.js" "%PLMPath%\Javascript\Integration\ZSKIntegration.js"

ModifyConfig.exe "%PLMPath%\Integration.config.xml" IntegrationConfiguration/appSettings update PROE "Creo.Server.CreoOperate, Creo.Server"

::ModifyConfig.exe "%PLMPath%\Document\ElectronIntegration.aspx" IntegrationConfiguration/appSettings replace "var isimport = false;" "if(!bomtips()) {return false;};var isimport = false;"
::ModifyConfig.exe "%PLMPath%\Document\Class\Document.js" IntegrationConfiguration/appSettings append "/***DocumentDownload-SetFileWriteAttributes(LocalFileName)***/" ";function DocumentDownload(FtpFileName, LocalFileName) {if (!CheckFtp()) return false;if (FtpFileName == \"\" || LocalFileName == \"\") return false;result = fileControler.Controler.DownloadFile(FtpFileName, LocalFileName);/***DocumentDownload-SetFileWriteAttributes(LocalFileName)***/SetFileWriteAttributes(LocalFileName);}"

echo �������������
echo.
echo.
echo ��ʼ�������

set Integration=%PLMPath%\..\Integration\Integration Setup

::copy /y "Kingdee.PLM.Integration.Setup.Zuken.dll" "%Integration%\KDSetup\Dll\Kingdee.PLM.Integration.Setup.Zuken.dll"
copy /y "Kingdee.PLM.Integration.Client.Proe.dll" "%Integration%\Resources\Common\Dll\Kingdee.PLM.Integration.Client.Proe.dll"
copy /y "Intgration.Common.dll" "%Integration%\Resources\Common\Dll\Intgration.Common.dll"


echo ����������
echo.
echo �ڿͻ��˰�װ�������ʹ��
echo.
pause