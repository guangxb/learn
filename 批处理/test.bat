::setlocal enabledelayedexpansion
::FOR /F "usebackq delims==" %%i IN (`set`) DO @echo %%i    !%%i!

@echo off 
for /l %%i in (1 1 70) do ( 
set /p=O<nul 
for /l %%a in (1 1 50) do ver>nul 
) 
pause>nul 

@echo.

::@echo on
Echo ����һ����ʱ�ļ� > tmp.txt


Rem �����ȱ��浱ǰĿ¼���ٽ�c:\windows��Ϊ��ǰĿ¼

pushd c:\windows
call :sub tmp.txt
Rem ���лָ�ǰ�εĵ�ǰĿ¼
Popd
Call :sub tmp.txt
pause
Del tmp.txt

exit


:sub
Echo ɾ������: %~1
Echo ���䵽·��: %~f1
Echo ���䵽һ����������: %~d1
Echo ���䵽һ��·��: %~p1
Echo ���䵽һ���ļ����� %~n1
Echo ���䵽һ���ļ���չ���� %~x1
Echo �����·��ָ���ж����� %~s1
Echo ���䵽�ļ����ԣ� %~a1
Echo ���䵽�ļ�������/ʱ�䣺 %~t1
Echo ���䵽�ļ��Ĵ�С�� %~z1
Echo ��չ���������ź�·����%~dp1
Echo ��չ���ļ�������չ����%~nx1

Echo ��չ������ DIR ������У�%~ftza1
Echo.
Goto :eof

::pause

pause>nul 