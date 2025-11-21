using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class PermObjetivaC
    {
        public static string comando = @"
echo S| cacls C:\Objetiva /e /t /c /g Todos:F
Echo Processo Terminado
pause
";
    }
}
