using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRunner.Entities
{
    internal class MainFormButtonTexts
    {
        //TAB2
        public static string btnEmpresarioText = "Selecionar banco de dados Empresario";
        public static string btnTestarConexaoText = "Testar conexão";
        public static string btnUpdateCadSysText = "update cadsys set dtimplantacao = '01/01/2000'";
        public static string btnLimparLogText = "DBCC SHRINKDATABASE(Empresario, 0) WITH NO_INFOMSGS";
        public static string btnRecriaIndiceText = @"
USE EMPRESARIO
DECLARE @COMANDO VARCHAR(MAX)
DECLARE DB_CURSOR CURSOR FOR SELECT NAME FROM SYS.TABLES
OPEN DB_CURSOR 
FETCH NEXT FROM DB_CURSOR INTO @COMANDO
WHILE @@FETCH_STATUS = 0 
BEGIN 
	SET @COMANDO = ('ALTER INDEX ALL ON ' + @comando + ' REBUILD')
	EXEC (@COMANDO)
    FETCH NEXT FROM DB_CURSOR INTO @COMANDO
END 
CLOSE DB_CURSOR 
DEALLOCATE DB_CURSOR";
        public static string btnRecriarEstatBancoText = @"
DECLARE @COMANDO VARCHAR(MAX)

DECLARE DB_CURSOR CURSOR FOR SELECT NAME FROM SYS.TABLES ORDER BY name

OPEN DB_CURSOR 

FETCH NEXT FROM DB_CURSOR INTO @COMANDO

WHILE @@FETCH_STATUS = 0 
BEGIN 
	--SET @COMANDO = ('ALTER INDEX ALL ON ' + @comando + ' REBUILD')
	SET @COMANDO = ('UPDATE STATISTICS ' + @comando + ' WITH FULLSCAN')
	PRINT @COMANDO
	EXEC (@COMANDO)

    FETCH NEXT FROM DB_CURSOR INTO @COMANDO
END 

CLOSE DB_CURSOR 
DEALLOCATE DB_CURSOR";
        public static string btnRemoverRegTabelaHistText = @"
DELETE HISTORICO 
WHERE LEN(REPLACE(HISTORICO.CONTEUDO, '', '')) > 0 AND COALESCE(ORIGEMID, '') = ''";
        public static string btnAltGrupIbsCbsID7Text = @"
UPDATE IBSCBS
SET
    CSTIBSCBSID = '200',
    CCLASSTRIBIBSCBSID = '200038',
    PERCENTUALREDUCAOIBSUF = '60.0000',
    PERCENTUALALIQUOTAEFETIVAIBSUF = '0.0400',
    PERCENTUALREDUCAOIBSMUNICIPIO = '60.0000',
    PERCENTUALREDUCAOCBS = '60.0000',
    PERCENTUALALIQUOTACBS = '0.9000',
    PERCENTUALALIQUOTAEFETIVACBS = '0.3600',
    TIPOREDUCAOCBS = '0',
    TIPOREDUCAOIBS = '0'
WHERE
    IBSCBSGRUPOID = '7';";


        //TAB 3

        public static string btnResetTransportNFText = "Consulta nota fiscal e seus dados de transporte e remove o endereço vinculado ao transporte da nota fiscal.";
        public static string btnDupChaveAcessoText = "Muda chave de acesso quando ocorre o erro de duplicidade de chave de acesso.";
    }
}
