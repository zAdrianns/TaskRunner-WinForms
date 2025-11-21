using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class LiberarSQLFirewall
    {
        public static string comando = @"
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
    }
}
