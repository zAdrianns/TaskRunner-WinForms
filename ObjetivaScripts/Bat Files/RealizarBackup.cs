using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class RealizarBackup
    {
        public static string comando = @"
@echo off
@rem muda a cor da tela do script
@color 80

@title “Iniciando o Backup”

@cd C:\Objetiva

@echo ———————————-
@echo Iniciando Backup
@echo ———————————-
@echo Iniciando copia dos arquivos de nome do computador para nome computador destino

@rem o caminho D:\Backup
@xcopy C:\objetiva D:\Backup /m /y /r /e /i > logbackup.txt

@rem muda o titulo
@title “Backup Finalizado”

@rem imprimi uma mensagem na tela
@echo ———————————-
@echo “backup finalizado”
@echo ———————————-
@rem Pause
@exit
";
    }
}
