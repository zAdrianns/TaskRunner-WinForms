using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class IniciarSQLService
    {
        public static string comando = @"
net start MSSQL$OBJETIVA
";
    }
}
