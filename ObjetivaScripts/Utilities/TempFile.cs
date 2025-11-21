using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Utilities
{
    internal class TempFile
    {
        public static readonly string CreateTempFile = Path.Combine(Path.GetTempPath(), "arquivo.bat");

        public static void ExecuteTempFile(string bat)
        {
            //File.WriteAllText -> Cria um novo arquivo, grava a cadeia de caracteres especificada no arquivo e fecha o arquivo.
            File.WriteAllText(TempFile.CreateTempFile, bat);
            ProcessStartInfo ProcessInfo = new ProcessStartInfo();

            ProcessInfo.FileName = TempFile.CreateTempFile;
            ProcessInfo.Verb = "runas";
            ProcessInfo.UseShellExecute = true;
            Process.Start(ProcessInfo);
        }
    }
}
