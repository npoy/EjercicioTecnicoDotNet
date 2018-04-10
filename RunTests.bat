set MSTEST=call "C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\MSTest.exe"
set THIS_PATH=%~dp0

%MSTEST% /testcontainer:"%THIS_PATH%EjercicioTecnicoDotNet.Tests\bin\Debug\EjercicioTecnicoDotNet.Tests.dll""
