using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class IndexarBanco
    {
        public static string comando = @"
@ECHO OFF

sqlcmd -E -S SRV-AP\OBJETIVA -i""C:\Objetiva\Recria Indices Banco Empresario.sql""

REM PAUSE
";
    }
}
