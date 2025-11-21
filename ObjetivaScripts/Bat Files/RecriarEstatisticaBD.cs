using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class RecriarEstatisticaBD
    {
        public static string comando = @"
@ECHO OFF

sqlcmd -U SA -P SA_0bjetiva -S SRV-AP\OBJETIVA -i ""C:\Objetiva\Recria Estatisticas Banco.sql""

REM PAUSE
";
    }
}
