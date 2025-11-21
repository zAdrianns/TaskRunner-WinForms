using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class AtualizarCustosAPartirEntrada
    {
        public static string comando = @"
@ECHO OFF

sqlcmd -E -S SERVIDOR\OBJETIVA -i""C:\ObjetivaGE\Atualiza_valores_estsal.txt""

REM PAUSE
";
    }
}
