using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class AtualizarCustosAPartirFilial50
    {
        public static string comando = @"
@ECHO OFF

sqlcmd -E -S SERVIDOR\OBJETIVA -i""C:\ObjetivaGE\Atualiza custo apartir da filial 50.txt""

REM PAUSE
";
    }
}
