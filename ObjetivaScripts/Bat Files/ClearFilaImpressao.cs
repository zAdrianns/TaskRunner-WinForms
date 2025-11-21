using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class ClearFilaImpressao
    {
        public static string comando = @"
echo off
title Limpar Fila de Impressao, by Luis Henrique
rem O comando abaixo, pára o serviço de impressão
net stop spooler
rem entra no diretorio C
c:
rem abre a pasta de impressão
cd C:\Windows\System32\spool\PRINTERS
rem deleta os arquivos
del /f/s *.shd
del /f/s *.spl
del /f/s *.TMP
rem reinicia o serviço de impressão
net start spooler
echo S| cacls C:\Windows\System32\spool /e /t /c /g Todos:F

Echo Processo Terminado
pause
";
    }
}
