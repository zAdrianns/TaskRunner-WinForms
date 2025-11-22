using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Copy_SQL_Scripts
{
    internal class ResetarTransportedaNotaFiscal
    {
        public static string script = @"
select * from documentofiscal where codigo = ''
select * from documentofiscaltransporte where id = ''
update documentofiscaltransporte set enderecoid = NULL where id = ''
";
    }
}
