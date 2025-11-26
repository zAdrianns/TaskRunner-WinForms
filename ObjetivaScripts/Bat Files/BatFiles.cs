using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRunner.Bat_Files
{
    internal class BatFiles
    {
        public static string AtualizarCustosAPartirEntrada = @"
@ECHO OFF

sqlcmd -E -S SERVIDOR\OBJETIVA -i""C:\ObjetivaGE\Atualiza_valores_estsal.txt""

REM PAUSE
";

        public static string AtualizarCustosAPartirFilial50 = @"
@ECHO OFF

sqlcmd -E -S SERVIDOR\OBJETIVA -i""C:\ObjetivaGE\Atualiza custo apartir da filial 50.txt""

REM PAUSE
";

        public static string LimparFilaImpressao = @"
echo off
title Limpar Fila de Impressao, by Luis Henrique
rem O comando abaixo, pára o serviço de impressão
net stop spooler
rem entra no diretorio C
c:
rem abre a pasta de impressão
cd C:\Windows\System32\spool\PRINTERS
rem deleta os arquivos
del /f/s *.shd
del /f/s *.spl
del /f/s *.TMP
rem reinicia o serviço de impressão
net start spooler
echo S| cacls C:\Windows\System32\spool /e /t /c /g Todos:F

Echo Processo Terminado
pause
";

        public static string DeleteDllECF = @"
@ECHO OFF

ECHO.
ECHO    ##############################
ECHO    # APAGANDO DLLs DARUMA       #
ECHO    ##############################
ECHO.
DEL C:\WINDOWS\SYSTEM32\FS_345.DLL
DEL C:\WINDOWS\SYSTEM32\DARUMA32.DLL

DEL C:\WINDOWS\SYSTEM\FS_345.DLL
DEL C:\WINDOWS\SYSTEM\DARUMA32.DLL

DEL C:\WINDOWS\SYSWOW64\FS_345.DLL
DEL C:\WINDOWS\SYSWOW64\DARUMA32.DLL


ECHO.
ECHO    ##############################
ECHO    # APAGANDO DLLs BEMATECH     #
ECHO    ##############################
ECHO.
DEL C:\WINDOWS\SYSTEM32\BEMAFI32.DLL
DEL C:\WINDOWS\SYSTEM32\BEMAFI32.INI
DEL C:\WINDOWS\SYSTEM32\BEMAMFD.DLL
DEL C:\WINDOWS\SYSTEM32\BEMAMFD2.DLL
DEL C:\WINDOWS\SYSTEM32\AX6R32.DLL
DEL C:\WINDOWS\SYSTEM32\BEMAMFD2_MP4000THFI.DLL
DEL C:\WINDOWS\SYSTEM32\BEMATECH.DLL
DEL C:\WINDOWS\SYSTEM32\DAO350.DLL
DEL C:\WINDOWS\SYSTEM32\LIBEAY32.DLL
DEL C:\WINDOWS\SYSTEM32\MSJET35.DLL
DEL C:\WINDOWS\SYSTEM32\SIGN_BEMA.DLL
DEL C:\WINDOWS\SYSTEM32\REGISTRA.DLL

DEL C:\WINDOWS\SYSTEM\BEMAFI32.DLL
DEL C:\WINDOWS\SYSTEM\BEMAFI32.INI
DEL C:\WINDOWS\SYSTEM\BEMAMFD.DLL
DEL C:\WINDOWS\SYSTEM\BEMAMFD2.DLL
DEL C:\WINDOWS\SYSTEM\AX6R32.DLL
DEL C:\WINDOWS\SYSTEM\BEMAMFD2_MP4000THFI.DLL
DEL C:\WINDOWS\SYSTEM\BEMATECH.DLL
DEL C:\WINDOWS\SYSTEM\DAO350.DLL
DEL C:\WINDOWS\SYSTEM\LIBEAY32.DLL
DEL C:\WINDOWS\SYSTEM\MSJET35.DLL
DEL C:\WINDOWS\SYSTEM\SIGN_BEMA.DLL
DEL C:\WINDOWS\SYSTEM\REGISTRA.DLL

DEL C:\WINDOWS\SYSWOW64\BEMAFI32.DLL
DEL C:\WINDOWS\SYSWOW64\BEMAFI32.INI
DEL C:\WINDOWS\SYSWOW64\BEMAMFD.DLL
DEL C:\WINDOWS\SYSWOW64\BEMAMFD2.DLL
DEL C:\WINDOWS\SYSWOW64\AX6R32.DLL
DEL C:\WINDOWS\SYSWOW64\BEMAMFD2_MP4000THFI.DLL
DEL C:\WINDOWS\SYSWOW64\BEMATECH.DLL
DEL C:\WINDOWS\SYSWOW64\DAO350.DLL
DEL C:\WINDOWS\SYSWOW64\LIBEAY32.DLL
DEL C:\WINDOWS\SYSWOW64\MSJET35.DLL
DEL C:\WINDOWS\SYSWOW64\SIGN_BEMA.DLL
DEL C:\WINDOWS\SYSWOW64\REGISTRA.DLL

ECHO.
ECHO    ##############################
ECHO    # APAGANDO DLLs SWEDA        #
ECHO    ##############################
ECHO.
DEL C:\WINDOWS\SYSTEM32\swmfd.DLL
DEL C:\WINDOWS\SYSTEM32\CONVECF.DLL
DEL C:\WINDOWS\SYSTEM32\RSA.BIN

DEL C:\WINDOWS\SYSTEM\swmfd.DLL
DEL C:\WINDOWS\SYSTEM\CONVECF.DLL
DEL C:\WINDOWS\SYSTEM\RSA.BIN

DEL C:\WINDOWS\SYSWOW64\swmfd.DLL
DEL C:\WINDOWS\SYSWOW64\CONVECF.DLL
DEL C:\WINDOWS\SYSWOW64\RSA.BIN

ECHO.
ECHO    ##############################
ECHO    # APAGANDO DLLs DATAREGIS    #
ECHO    ##############################
ECHO.
DEL C:\WINDOWS\SYSTEM32\DLLG2.DLL
DEL C:\WINDOWS\SYSTEM32\DLLG2_GERADOR.DLL

DEL C:\WINDOWS\SYSTEM\DLLG2.DLL
DEL C:\WINDOWS\SYSTEM\DLLG2_GERADOR.DLL

DEL C:\WINDOWS\SYSWOW64\DLLG2.DLL
DEL C:\WINDOWS\SYSWOW64\DLLG2_GERADOR.DLL

ECHO.
ECHO    ##############################
ECHO    # APAGANDO DLLs ELGIN        #
ECHO    ##############################
ECHO.
DEL C:\WINDOWS\SYSTEM32\ELGIN.DLL
DEL C:\WINDOWS\SYSTEM32\ELGIN.INI

DEL C:\WINDOWS\SYSTEM\ELGIN.DLL
DEL C:\WINDOWS\SYSTEM\ELGIN.INI

DEL C:\WINDOWS\SYSWOW64\ELGIN.DLL
DEL C:\WINDOWS\SYSWOW64\ELGIN.INI


ECHO.
ECHO    ##############################
ECHO    # APAGANDO DLLs EPSON        #
ECHO    ##############################
ECHO.
DEL C:\WINDOWS\SYSTEM32\INTERFACEEPSON.DLL

DEL C:\WINDOWS\SYSTEM\INTERFACEEPSON.DLL

DEL C:\WINDOWS\SYSWOW64\INTERFACEEPSON.DLL

ECHO.
ECHO    ############################################
ECHO    #                                          #
ECHO    #  PRESSIONE QUALQUER TECLA PARA TERMINAR  #
ECHO    #                                          #
ECHO    #                  F I M                   #
ECHO    #                                          #
ECHO    ############################################
ECHO.
PAUSE >NUL
EXIT
";

        public static string EncerrarUniDanfe = @"
tskill unidanfe
";

        public static string ExcluirRegistroObjetiva = @"
REG DELETE ""HKEY_CURRENT_USER\SOFTWARE\Data Access Worldwide\DataFlex Applications\18.0\Objetiva\WINDOWS"" /F
";

        public static string FinalizarTarefasObjVarejo = @"
@echo off
title Finalizar Tarefas do Aplicativo
echo ======================================
echo ENCERRANDO TODAS AS TAREFAS DO APLICATIVO
echo ======================================
echo.

:: Nome do processo (modifique aqui)
set ""processo=Objetiva.exe""

echo Verificando tarefas do %processo%...
tasklist /FI ""IMAGENAME eq %processo%"" | find /I ""%processo%"" >nul
if errorlevel 1 (
    echo Nenhum processo %processo% encontrado.
) else (
    echo Encerrando todas as instâncias de %processo%...
    taskkill /F /IM %processo% /T
    echo Todas as tarefas foram finalizadas.
)

echo.
pause
";

        public static string IndexarBanco = @"
@ECHO OFF

sqlcmd -E -S SRV-AP\OBJETIVA -i""C:\Objetiva\Recria Indices Banco Empresario.sql""

REM PAUSE
";

        public static string iniciarSqlService = @"
net start MSSQL$OBJETIVA
";

        public static string LiberarSQLFirewall = @"
@echo off
echo Adicionando exceções no firewall (entrada e saída)...

:: ========================
:: Regras para Executáveis
:: ========================

:: SQL Browser (entrada)
netsh advfirewall firewall add rule name=""SQL Browser IN"" dir=in action=allow program=""%ProgramFiles(x86)%\Microsoft SQL Server\90\Shared\sqlbrowser.exe"" enable=yes
:: SQL Browser (saída)
netsh advfirewall firewall add rule name=""SQL Browser OUT"" dir=out action=allow program=""%ProgramFiles(x86)%\Microsoft SQL Server\90\Shared\sqlbrowser.exe"" enable=yes

:: SQL Server (entrada)
netsh advfirewall firewall add rule name=""SQL Server IN"" dir=in action=allow program=""%ProgramFiles%\Microsoft SQL Server\MSSQL12.OBJETIVA\MSSQL\Binn\sqlservr.exe"" enable=yes
:: SQL Server (saída)
netsh advfirewall firewall add rule name=""SQL Server OUT"" dir=out action=allow program=""%ProgramFiles%\Microsoft SQL Server\MSSQL12.OBJETIVA\MSSQL\Binn\sqlservr.exe"" enable=yes

:: ========================
:: Regras para Portas
:: ========================

:: Porta TCP 1433 (entrada e saída)
netsh advfirewall firewall add rule name=""SQL Server TCP 1433 IN""  dir=in  action=allow protocol=TCP localport=1433 enable=yes
netsh advfirewall firewall add rule name=""SQL Server TCP 1433 OUT"" dir=out action=allow protocol=TCP localport=1433 enable=yes

:: Porta UDP 1434 (entrada e saída)
netsh advfirewall firewall add rule name=""SQL Browser UDP 1434 IN""  dir=in  action=allow protocol=UDP localport=1434 enable=yes
netsh advfirewall firewall add rule name=""SQL Browser UDP 1434 OUT"" dir=out action=allow protocol=UDP localport=1434 enable=yes

echo Todas as regras de entrada e saída foram adicionadas com sucesso!
pause
";

        public static string PermissaoObjC = @"
echo S| cacls C:\Objetiva /e /t /c /g Todos:F
Echo Processo Terminado
pause
";

        public static string PermissaoObjD = @"
echo S| cacls D:\Objetiva /e /t /c /g Todos:F
Echo Processo Terminado
pause
";

        public static string RealizarBackup = @"
@echo off
@rem muda a cor da tela do script
@color 80

@title “Iniciando o Backup”

@cd C:\Objetiva

@echo ———————————-
@echo Iniciando Backup
@echo ———————————-
@echo Iniciando copia dos arquivos de nome do computador para nome computador destino

@rem o caminho D:\Backup
@xcopy C:\objetiva D:\Backup /m /y /r /e /i > logbackup.txt

@rem muda o titulo
@title “Backup Finalizado”

@rem imprimi uma mensagem na tela
@echo ———————————-
@echo “backup finalizado”
@echo ———————————-
@rem Pause
@exit
";

        public static string RecriaEstatisticaBD = @"
@ECHO OFF

sqlcmd -U SA -P SA_0bjetiva -S SRV-AP\OBJETIVA -i ""C:\Objetiva\Recria Estatisticas Banco.sql""

REM PAUSE
";
    }
}
