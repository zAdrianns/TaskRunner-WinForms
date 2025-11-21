using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetivaScripts.Bat_Files
{
    internal class FinalizarTarefasVarejo
    {
        public static string comando = @"
@echo off
title Finalizar Tarefas do Aplicativo
echo ======================================
echo ENCERRANDO TODAS AS TAREFAS DO APLICATIVO
echo ======================================
echo.

:: Nome do processo (modifique aqui)
set ""processo=Objetiva.exe""

echo Verificando tarefas do %processo%...
tasklist /FI ""IMAGENAME eq %processo%"" | find /I ""%processo%"" >nul
if errorlevel 1 (
    echo Nenhum processo %processo% encontrado.
) else (
    echo Encerrando todas as instâncias de %processo%...
    taskkill /F /IM %processo% /T
    echo Todas as tarefas foram finalizadas.
)

echo.
pause
";
    }
}
