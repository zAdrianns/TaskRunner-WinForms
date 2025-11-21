using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class ExcluirRegistroObjetiva
    {
        public static string comando = @"
REG DELETE ""HKEY_CURRENT_USER\SOFTWARE\Data Access Worldwide\DataFlex Applications\18.0\Objetiva\WINDOWS"" /F
";
    }
}
