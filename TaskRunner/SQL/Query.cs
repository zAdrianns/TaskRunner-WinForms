using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TaskRunner.SQL
{
    internal class Query
    {
        public static void UpdateCadSys()
        {
            using (SqlConnection con = new SqlConnection(SqlConn.ConnString))
            {
                try
                {
                    con.Open();

                    string update =
                        "UPDATE CADSYS SET DTIMPLANTACAO ='01/01/2000'";

                    SqlCommand cmd = new SqlCommand(update, con)
                    {
                        CommandTimeout = 600
                    };

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Correções feitas com sucesso", "Sucesso", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void AtualizaIbsCbsNCM()
        {
            using (SqlConnection con = new SqlConnection(SqlConn.ConnString))
            {
                try
                {
                    con.Open();

                    string atualiza =
                        @"
DECLARE @FILIAL VARCHAR(10)
SET @FILIAL = '1'

UPDATE E
SET E.IBSCBSGRUPOID =
    CASE
        -- Grupo 2 CCLASSTRIB 200002
        WHEN LEFT(C.CODIGONCM, 8) IN (
            '84321000','84322100','84322900','84323000','84324000',
            '84328000','84329000','84331100','84331900','84332000',
            '84333000','84334000','84335100','84335910','84335990',
            '84339000','87011000','87042110','87042210','87042310',
            '87043210','87049010','87049090'
        ) THEN 2

-- Grupo 3 CCLASSTRIB 200003
    -- NCM com 4 dígitos
    WHEN LEFT(C.CODIGONCM, 4) IN (
        '0201', '0202', '0203', '0204', '0207', '0209',
        '0302', '0303', '0304', '0305', '0306', '0401',
        '0402', '0404', '0406', '0407', '0701', '0702',
        '0703', '0704', '0705', '0706', '0707', '0708',
        '0709', '0712', '0801', '0802', '0803', '0804',
        '0805', '0806', '0807', '0808', '0809', '0810',
        '0813', '0901', '1101', '1510', '1511', '1512',
        '1513', '1514', '1515', '1517', '1601', '1602',
        '1603', '1604', '1701', '2501'
    ) THEN 3

    -- NCM com 5 dígitos
    WHEN LEFT(C.CODIGONCM, 5) IN (
        '0105', '02101', '06062', '07133', '0714', '19021'
    ) THEN 3

    -- NCM com 6 dígitos
    WHEN LEFT(C.CODIGONCM, 6) IN (
        '040610', '190110'
    ) THEN 3

    -- NCM com 8 dígitos
    WHEN LEFT(C.CODIGONCM, 8) IN (
        '02061000', '02102000', '02109911', '02109920',
        '04051000', '04090000', '11022000', '15171000'
    ) THEN 3


-- Grupo 4 CCLASSTRIB 200013
        WHEN LEFT(C.CODIGONCM, 8) IN (
            '96190000'
        ) THEN 4

-- Grupo 5 CCLASSTRIB 200014
    -- NCM com 4 dígitos
    WHEN LEFT(C.CODIGONCM, 4) IN (
        '0603', '0604',
        '0701', '0703', '0704', '0705',
        '0706', '0708', '0709', '0710',
        '0714', '0803', '0804', '0805',
        '0806', '0807', '0808', '0809',
        '0810', '0811'
    ) THEN 5

    -- NCM com 5 dígitos
    WHEN LEFT(C.CODIGONCM, 5) IN (
        '04072', '07095', '08011'
    ) THEN 5

    -- NCM com 6 dígitos
    WHEN LEFT(C.CODIGONCM, 6) IN (
        '071080'
    ) THEN 5

    -- NCM com 8 dígitos
    WHEN LEFT(C.CODIGONCM, 8) IN (
        '07020000', '07070000', '07108000'
    ) THEN 5

-- Grupo 6 CCLASSTRIB 200034
    -- NCM com 4 dígitos
    WHEN LEFT(C.CODIGONCM, 4) IN (
        '0201', '0202', '0203', '0204', '0205',
        '0206', '0207', '0208', '0209', '0303',
        '0304', '0406', '0501', '0502', '0504',
        '0505', '0506', '0507', '0508', '0509',
        '0510', '0511', '1508', '1511', '1512',
        '1513', '1514', '1515', '2008', '2009'
    ) THEN 6

    -- NCM com 5 dígitos
    WHEN LEFT(C.CODIGONCM, 5) IN (
        '03021', '03022', '03023', '03024', '03025',
        '03027', '03028', '03053', '03054', '03055',
        '03056', '03061', '03063', '03079', '15079'
    ) THEN 6

    -- NCM com 6 dígitos
    WHEN LEFT(C.CODIGONCM, 6) IN (
        '150790'
    ) THEN 6

    -- NCM com 8 dígitos
    WHEN LEFT(C.CODIGONCM, 8) IN (
        '03051000', '03052000', '04021010', '04021090',
        '04022110', '04022120', '04022130', '04022190',
        '04022910', '04022920', '04029100', '04029900',
        '11010020', '11021000', '11031100', '11032000',
        '11081200', '19022000', '19023000', '19051000',
        '19052000', '19059010', '19059090'
    ) THEN 6


-- Grupo 7 CCLASSTRIB 510002
    -- NCM com 4 dígitos
    WHEN LEFT(C.CODIGONCM, 4) IN (
        '0601', '0602', '1001', '1002', '1003', '1004',
        '1005', '1006', '1007', '1008', '1101', '1102',
        '1103', '1104', '1105', '1106', '1107', '1108',
        '1109', '1201', '1202', '1203', '1204', '1205',
        '1206', '1207', '1208', '1209', '1210', '1211',
        '1212', '1213', '1214', '2301', '2302', '2303',
        '2521', '3101', '3102', '3103', '3104', '3105'
    ) THEN 7

    -- NCM com 5 dígitos
    WHEN LEFT(C.CODIGONCM, 5) IN (
        '23099'
    ) THEN 7

    -- NCM com 8 dígitos
    WHEN LEFT(C.CODIGONCM, 8) IN (
        '31010000', '38249977', '25210000'
    ) THEN 7


-- Grupo 8 CCLASSTRIB 620006
    -- NCM com 8 dígitos
    WHEN LEFT(C.CODIGONCM, 8) IN (
        '27111100', '27111300', '27111910', '27112100'
    ) THEN 8

        ELSE E.IBSCBSGRUPOID
    END,

	   -- Campos exclusivos do grupo 8
    E.QTDBCMONORETIBSCBS =
        CASE
            WHEN LEFT(C.CODIGONCM, 8) IN ('27111100','27111300','27111910','27112100')
                THEN '1'
            ELSE E.QTDBCMONORETIBSCBS
        END,

    E.VRMONORETIBS =
        CASE
            WHEN LEFT(C.CODIGONCM, 8) IN ('27111100','27111300','27111910','27112100')
                THEN '0.1000'
            ELSE E.VRMONORETIBS
        END,

    E.VRMONORETCBS =
        CASE
            WHEN LEFT(C.CODIGONCM, 8) IN ('27111100','27111300','27111910','27112100')
                THEN '0.9000'
		  ELSE E.VRMONORETCBS
        END

FROM ESTSAL E
INNER JOIN CADPRO C ON E.matricula = C.ID
WHERE E.FILIAL = @FILIAL;

-- Listagem de quantos produtos foram atualizados por grupo
SELECT 
    E.IBSCBSGRUPOID AS Grupo,
    COUNT(DISTINCT E.MATRICULA) AS Qtde_Produtos_Atualizados
FROM ESTSAL E
WHERE E.FILIAL = @FILIAL
  AND E.IBSCBSGRUPOID IN (2,3,4,5,6,7,8)
GROUP BY E.IBSCBSGRUPOID
ORDER BY E.IBSCBSGRUPOID;
";

                    SqlCommand cmd = new SqlCommand(atualiza, con)
                    {
                        CommandTimeout = 600
                    };

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Correções feitas com sucesso", "Sucesso", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LimparLog()
        {
            using (SqlConnection con = new SqlConnection(SqlConn.ConnString))
            {
                try
                {
                    con.Open();

                    string limpar =
                        "DBCC SHRINKDATABASE(Empresario, 0) WITH NO_INFOMSGS";

                    SqlCommand cmd = new SqlCommand(limpar, con)
                    {
                        CommandTimeout = 600
                    };

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Correções feitas com sucesso", "Sucesso", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void RecriaIndice()
        {
            using (SqlConnection con = new SqlConnection(SqlConn.ConnString))
            {
                try
                {
                    con.Open();

                    string recriarInd =
                        @"
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
DEALLOCATE DB_CURSOR
";

                    SqlCommand cmd = new SqlCommand(recriarInd, con)
                    {
                        CommandTimeout = 600
                    };

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Correções feitas com sucesso", "Sucesso", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void RecriaEstatisticasBanco()
        {
            using (SqlConnection con = new SqlConnection(SqlConn.ConnString))
            {
                try
                {
                    con.Open();

                    string recriarEstatisticaBD =
                        @"
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
DEALLOCATE DB_CURSOR
";

                    SqlCommand cmd = new SqlCommand(recriarEstatisticaBD, con)
                    {
                        CommandTimeout = 600
                    };

                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Correções feitas com sucesso", "Sucesso", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
