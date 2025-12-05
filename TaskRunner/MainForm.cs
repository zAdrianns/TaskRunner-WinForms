using TaskRunner.Copy_SQL_Scripts;
using TaskRunner.SQL;
using TaskRunner.Utilities;
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using TaskRunner;
using TaskRunner.Bat_Files;


namespace TaskRunner
{
    public partial class MainForm : Form
    {
        LiberacaoScript acesso = new LiberacaoScript();
        ScriptsParaCopiar scrptCopy = new ScriptsParaCopiar();
        public MainForm()
        {
            InitializeComponent();
            ListarServidores();

            ToolTip toolTip1 = new ToolTip();

            //Tab2

            btnEmpresario.Enabled = true;
            btnObjNFCE.Enabled = true;

            toolTip1.SetToolTip(this.btnTestarConexao, "Testar conexão com banco de dados");
            toolTip1.SetToolTip(this.btnUpdateCadSys, "update cadsys set dtimplantacao = '01/01/2000'");
            toolTip1.SetToolTip(this.btnLimparLog, "DBCC SHRINKDATABASE(Empresario, 0) WITH NO_INFOMSGS");
            toolTip1.SetToolTip(this.btnRecriaIndice, @"
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
");
            toolTip1.SetToolTip(this.btnRecriarEstatBanco, @"
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
");
            toolTip1.SetToolTip(this.btnRemoverRegTabelaHist, @"
DELETE HISTORICO 
WHERE LEN(REPLACE(HISTORICO.CONTEUDO, '', '')) > 0 AND COALESCE(ORIGEMID, '') = ''
");
            toolTip1.SetToolTip(this.btnAltGrupIbsCbsID7, @"
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
    IBSCBSGRUPOID = '7';
");


            //tab3
            toolTip1.SetToolTip(this.btnResetTransportNF, "Consulta nota fiscal e seus dados de transporte e remove o endereço vinculado ao transporte da nota fiscal.");
            toolTip1.SetToolTip(this.btnDupChaveAcesso, "Muda chave de acesso quando ocorre o erro de duplicidade de chave de acesso.");
        }

        //TAB 1 - Scripts Objetiva

        private void ExecutarBatFile(string texto, Action comando)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {texto}?", texto, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    comando.Invoke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdCustosFilial50_Click(object sender, EventArgs e)
        {
            ExecutarBatFile(btnUpdCustosFilial50.Text, () => TempFile.ExecuteTempFile(BatFiles.AtualizarCustosAPartirFilial50));
        }

        private void btnUpdCustosEntrada_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnUpdCustosEntrada.Text, () => TempFile.ExecuteTempFile(BatFiles.AtualizarCustosAPartirEntrada));
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnBackup.Text, () => TempFile.ExecuteTempFile(BatFiles.RealizarBackup));
            }
        }
        private void btnEndVarejo_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnEndVarejo.Text, () => TempFile.ExecuteTempFile(BatFiles.FinalizarTarefasObjVarejo));
            }
        }
        private void btnEndUniDanfe_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnEndUniDanfe.Text, () => TempFile.ExecuteTempFile(BatFiles.EncerrarUniDanfe));
            }
        }
        private void btnDellDLLECF_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnDellDLLECF.Text, () => TempFile.ExecuteTempFile(BatFiles.DeleteDllECF));
            }
        }
        private void btnClearFilaImpressao_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnClearFilaImpressao.Text, () => TempFile.ExecuteTempFile(BatFiles.LimparFilaImpressao));
            }
        }
        private void btnPermObjC_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnPermObjC.Text, () => TempFile.ExecuteTempFile(BatFiles.PermissaoObjC));
            }
        }
        private void btnPermObjD_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnPermObjD.Text, () => TempFile.ExecuteTempFile(BatFiles.PermissaoObjD));
            }
        }
        private void btnStartSQLService_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnStartSQLService.Text, () => TempFile.ExecuteTempFile(BatFiles.iniciarSqlService));
            }
        }
        private void btnLibSqlFirewall_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnLibSqlFirewall.Text, () => TempFile.ExecuteTempFile(BatFiles.LiberarSQLFirewall));
            }
        }
        private void btnRecEstatistBD_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnRecEstatistBD.Text, () => TempFile.ExecuteTempFile(BatFiles.RecriaEstatisticaBD));
            }
        }
        private void btnIndexBD_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnIndexBD.Text, () => TempFile.ExecuteTempFile(BatFiles.IndexarBanco));
            }
        }
        private void btnDellRegistroObjetiva_Click(object sender, EventArgs e)
        {
            {
                ExecutarBatFile(btnDellRegistroObjetiva.Text, () => TempFile.ExecuteTempFile(BatFiles.ExcluirRegistroObjetiva));
            }
        }

        //TAB 2 - SQL Scripts

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string servidorSelecionado = comboBox1.SelectedItem.ToString();
            SqlConn.setServer(servidorSelecionado);
        }
        public void ListarServidores()
        {
            //https://www.c-sharpcorner.com/blogs/get-all-installed-sql-server-instances-on-local-machine-using-c-sharp

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Selecione");
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();
            //string ServerName = Environment.MachineName;
            foreach (DataRow row in table.Rows)
            {
                string dtsource = (row["ServerName"].ToString() + "\\" + row["InstanceName"].ToString());
                comboBox1.Items.Add(dtsource);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
        private bool ValidarServerBanco()
        {
            if (comboBox1.SelectedItem.ToString() == "Selecione")
            {
                MessageBox.Show("Você não selecionou o servidor...", "Selecione um Servidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrEmpty(SqlConn.getDataBase()))
            {
                MessageBox.Show("Você não selecionou um banco de dados...", "Selecione um Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void ExecutarScript(string titulo, Action comando)
        {
            if (ValidarServerBanco())
            {
                acesso.ShowDialog();
                if (acesso.DialogResult == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show($"Tem certeza que deseja executar o comando {titulo}?", titulo, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            comando.Invoke();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel executar: \n" + ex, "Error");
                        }
                    }
                }
            }
        }

        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(SqlConn.ConnString))
            {
                try
                {
                    if (comboBox1.SelectedItem.ToString() == "Selecione")
                    {
                        MessageBox.Show("Você não selecionou o servidor...", "Selecione um Servidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (string.IsNullOrEmpty(SqlConn.getDataBase()))
                    {
                        MessageBox.Show("Você não selecionou um banco de dados...", "Selecione um Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        MessageBox.Show("Conexão Testada com Sucesso.\n\nServidor: " + comboBox1.SelectedItem.ToString() + "\nBanco: " + SqlConn.getDataBase(), "Testar Conexão", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEmpresario_Click(object sender, EventArgs e)
        {
            string dtBase = "Empresario";
            SqlConn.setDataBase(dtBase);

            btnEmpresario.Enabled = false;
            btnObjNFCE.Enabled = true;
        }

        private void btnObjNFCE_Click(object sender, EventArgs e)
        {
            string dtBase = "ObjetivaNFCe";
            SqlConn.setDataBase(dtBase);

            btnObjNFCE.Enabled = false;
            btnEmpresario.Enabled = true;

        }

        private void btnUpdateCadSys_Click(object sender, EventArgs e)
        {
            ExecutarScript("UpdateCadSys", Query.UpdateCadSys);
        }
        private void btnAttIbsCbsNCM_Click(object sender, EventArgs e)
        {
            ExecutarScript("ATUALIZA IBSCBS COM BASE NO NCM", Query.AtualizaIbsCbsNCM);
        }

        private void btnLimparLog_Click(object sender, EventArgs e)
        {
            ExecutarScript("Limpar Log", Query.LimparLog);
        }

        private void btnRecriaIndice_Click_1(object sender, EventArgs e)
        {
            ExecutarScript("Recria Indice", Query.RecriaIndice);
        }

        private void btnRecriarEstatBanco_Click(object sender, EventArgs e)
        {
            ExecutarScript("Recriar Estatisticas Banco", Query.RecriaEstatisticasBanco);
        }

        private void btnRemoverRegTabelaHist_Click(object sender, EventArgs e)
        {
            ExecutarScript("Remover Registros Tabela", Query.RemoverRegistrosTabela);
        }

        private void btnAltGrupIbsCbsID7_Click(object sender, EventArgs e)
        {
            ExecutarScript("Alterar Grupo IBSCBSGRUPOID = '7'", Query.AlterarGrupoIBSCBSID7);
        }

        //TAB 3 - Scripts Text

        private void AbrirScript(string script)
        {
            Tab3FormCreator.TextoScript(scrptCopy, script);
            scrptCopy.ShowDialog();
        }

        private void btnResetTransportNF_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.ResetarTransporteNF);
        }

        private void btnDupChaveAcesso_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.DuplicidadeChaveACesso);
        }

        private void btnCNPJautDownlo_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.CnpjAutorizadoDownload);
        }

        private void btnDescontoRateado_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.DescontoRateado);
        }

        private void btnDesvPreDoc_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.DesvinculaPreDoc);
        }

        private void btnMudaOpNF_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.MudaOperacaoNF);
        }

        private void btnMudaModelNF_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.MudaModeloNF);
        }

        private void btnNfPendenteEmitd_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.NfPendenteTransmitida);
        }

        private void btnPreDocAltEstacao_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.PreDocAlteradoEmOutraEstacao);
        }

        private void btnAltStatPreDoc_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.AlterarStatusPreDoc);
        }

        private void btnRefaturaCErro_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.ExcluirRefaturaErro);
        }

        private void btnRefInvisivel_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.RemoverRefInvisivel);
        }

        private void btnInutilizarNFAut_Click(object sender, EventArgs e)
        {
            AbrirScript(ScriptsTexts.InutilizouSemVerSitSefaz);
        }
    }
}