namespace TaskRunner.Copy_SQL_Scripts
{
    internal class ScriptsTexts
    {
        public static string ResetarTransporteNF = @"
select * from documentofiscal where codigo = ''
select * from documentofiscaltransporte where id = ''
update documentofiscaltransporte set enderecoid = NULL where id = ''
";

        public static string DuplicidadeChaveACesso = @"
--Selecionar NF e pegar o ID
SELECT * FROM DOCUMENTOFISCAL WHERE CODIGO = ''

--Usar ID para confirmar NF
SELECT * FROM NOTAFISCAL WHERE ID = ''

--Anotar chave antiga
XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

--Trocar a chave, pela chave que consta na receita
UPDATE NOTAFISCAL SET CHAVEACESSO = '' WHERE ID = ''
";

        public static string CnpjAutorizadoDownload = @"
ERRO: CNPJ DO DESTINATÁRIO JÁ AUTORIZADO PARA DOWNLOAD

select * from documentofiscal where codigo = ''

select * from documentofiscalautorizacaoaces where documentofiscalid=''

update documentofiscalautorizacaoaces set ativo = '0' where id = ''
";

        public static string DescontoRateado = @"
-- PEGAR ID DA NOTA FISCAL
SELECT * FROM DOCUMENTOFISCAL WHERE CODIGO = ''

-- OBSERVAR DESCONTO NOS ITENS
SELECT * FROM ITEMDOCUMENTOFISCAL WHERE DOCUMENTOFISCALID = '' AND ATIVO = '1'

-- SOMA VALOR DE DESCONTO TOTAL DOS ITENS
SELECT SUM (VALORDESCONTORATEADO) FROM ITEMDOCUMENTOFISCAL WHERE DOCUMENTOFISCALID = '' AND ATIVO = '1'

-- SOMA VALOR TOTAL (LIQUIDO) DA NOTA FISCAL
SELECT SUM (VALORLIQUIDO) FROM ITEMDOCUMENTOFISCAL WHERE DOCUMENTOFISCALID = '' AND ATIVO = '1'

U PDATE ITEMDOCUMENTOFISCAL SET VALORDESCONTORATEADO = '-0.0', VALORLIQUIDO = '.' WHERE ID = '' AND DOCUMENTOFISCALID = ''
";

        public static string DesvinculaPreDoc = @"
SELECT * FROM DOCUMENTOFISCAL WHERE CODIGO = 

SELECT ESTORC_ESTMOV.IDESTORC, ESTORC_ESTMOV.IDESTMOV, ESTORC_ESTMOV.RESERVAESTOQUE, ESTORC_ESTMOV.DATAORIGEM 
FROM DOCUMENTOFISCAL INNER JOIN ESTORC_ESTMOV ON DOCUMENTOFISCAL.ID = ESTORC_ESTMOV.IDESTMOV AND ESTORC_ESTMOV.ATIVO = 1 
WHERE DOCUMENTOFISCAL.ID = '' AND DOCUMENTOFISCAL.ATIVO = 1

SELECT * FROM ESTORC_ESTMOV WHERE IDESTORC = ''

DELETE ESTORC_ESTMOV WHERE IDESTMOV = ''
";

        public static string MudaOperacaoNF = @"
select * from documentofiscal where codigo= ''

update documentofiscal set operacaoid='1' where codigo=''

-- MUDA OPERAÇÃO DA NOTA
";

        public static string MudaModeloNF = @"
-- PEGAR NUMERO DA NOTA FISCAL
SELECT * FROM DOCUMENTOFISCAL WHERE CODIGO = ''

-- PEGAR CHAVE DE ACESSO E CONSULTAR NA RECEITA
SELECT * FROM NOTAFISCAL WHERE ID = ''


-- MUDAR O MODELO NAS TRES TABELAS
update documentofiscal set modelodocumentofiscalid = '01' where id = ''

update cadnot set modelo = '01' where id = ''

update estmov set NF_modelo = '01' where id = ''
";

        public static string NfPendenteTransmitida = @"
SITUAÇÃO: NOTA PENDENTE MAS ESTAVA TRANSMITIDA


select *from documentofiscal where codigo =''

update notafiscal set chaveacesso ='' where id=''
";

        public static string PreDocAlteradoEmOutraEstacao = @"
SELECT * FROM DOCUMENTOFISCAL WHERE CODIGO = 

SELECT ESTORC_ESTMOV.IDESTORC, ESTORC_ESTMOV.IDESTMOV, ESTORC_ESTMOV.RESERVAESTOQUE, ESTORC_ESTMOV.DATAORIGEM 
FROM DOCUMENTOFISCAL INNER JOIN ESTORC_ESTMOV ON DOCUMENTOFISCAL.ID = ESTORC_ESTMOV.IDESTMOV AND ESTORC_ESTMOV.ATIVO = 1 
WHERE DOCUMENTOFISCAL.ID = '' AND DOCUMENTOFISCAL.ATIVO = 1

SELECT * FROM ESTORC_ESTMOV WHERE IDESTORC = ''

DELETE ESTORC_ESTMOV WHERE IDESTMOV = ''
";

        public static string AlterarStatusPreDoc = @"
select * from estorc where codigo = '' -- CODIGO DA PRE VENDA
u pdate estorc set situacao_s = 'F', situacao_p = 'F' where id = ''
";

        public static string ExcluirRefaturaErro = @"
---consultar recibo refatura; copiar idrecibo---
select * from climov where recibo = ''

---consultar documento gerado pela refatura colocando o idrecibo no campo IDRELATE (""clibax...idrecibo..."")---
---consultar se contrato está em aberto no contas a receber do cliente---
---copiar idclidoc---
select * from clidoc where idrelate = ''

---select movimento de baixa do documento gerado pela refatura---
---copiar o idclidoc e idrecibo para deletar---
select * from climov where idclidoc in ('')

---NAO DELETAR ANTES DE COPIAR O IDRECIBO DO CLIMOV---
---deletar climov do documento gerado pela refatura---
delete climov where idclidoc IN ('')

---deletar recibo do documento gerado pela refatura---
delete recibo where idrecibo = ''
";

        public static string RemoverRefInvisivel = @"
SELECT * FROM DOCUMENTOFISCAL WHERE CODIGO = 
SELECT * FROM DOCUMENTOFISCALREFERENCIADO WHERE DOCUMENTOFISCALID = ''
DELETE DOCUMENTOFISCALREFERENCIADO WHERE ID = ''

(pode ser usado o update para desativar a referencia invisivel)
";

        public static string InutilizouSemVerSitSefaz = @"
select * from documentofiscal where codigo=''
select * from documentofiscal where id=''
delete documentofiscalinutilizacao where id=''

update documentofiscal set ativo='1' where id=''

delete documentofiscalautorizacao where id=''
";
    }
}
