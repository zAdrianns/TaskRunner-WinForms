using System;
using System.Diagnostics;
using System.IO;

namespace TaskRunner.Utilities
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
            Process proc = Process.Start(ProcessInfo);
            proc.WaitForExit();
            File.Delete(TempFile.CreateTempFile);
        }
    }
}
