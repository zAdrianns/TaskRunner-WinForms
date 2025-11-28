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

            //tab3
            toolTip1.SetToolTip(this.btnResetTransportNF, "Consulta nota fiscal e seus dados de transporte e remove o endereço vinculado ao transporte da nota fiscal.");
            toolTip1.SetToolTip(this.btnDupChaveAcesso, "Muda chave de acesso quando ocorre o erro de duplicidade de chave de acesso.");
        }

        //TAB 1 - Scripts Objetiva
        private void btnUpdCustosFilial50_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnUpdCustosFilial50.Text}?", btnUpdCustosFilial50.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.AtualizarCustosAPartirFilial50);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnUpdCustosEntrada_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnUpdCustosEntrada.Text}?", btnUpdCustosEntrada.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.AtualizarCustosAPartirEntrada);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBackup_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnBackup.Text}?", btnBackup.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.RealizarBackup);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEndVarejo_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnEndVarejo.Text}?", btnEndVarejo.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.FinalizarTarefasObjVarejo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEndUniDanfe_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnEndUniDanfe.Text}?", btnEndUniDanfe.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.EncerrarUniDanfe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDellDLLECF_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnDellDLLECF.Text}?", btnDellDLLECF.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.DeleteDllECF);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClearFilaImpressao_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnClearFilaImpressao.Text}?", btnClearFilaImpressao.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.LimparFilaImpressao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPermObjC_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnPermObjC.Text}?", btnPermObjC.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.PermissaoObjC);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPermObjD_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnPermObjD.Text}?", btnPermObjD.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.PermissaoObjD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnStartSQLService_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnStartSQLService.Text}?", btnStartSQLService.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.iniciarSqlService);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLibSqlFirewall_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnLibSqlFirewall.Text}?", btnLibSqlFirewall.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.LiberarSQLFirewall);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRecEstatistBD_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnRecEstatistBD.Text}?", btnRecEstatistBD.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.RecriaEstatisticaBD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIndexBD_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnIndexBD.Text}?", btnIndexBD.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.IndexarBanco);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDellRegistroObjetiva_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show($"Tem certeza que deseja {btnDellRegistroObjetiva.Text}?", btnDellRegistroObjetiva.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (msg == DialogResult.Yes)
                {
                    TempFile.ExecuteTempFile(BatFiles.ExcluirRegistroObjetiva);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(SqlConn.ConnString))
            {
                try
                {
                    if (comboBox1.SelectedItem.ToString() == "Selecione")
                    {
                        MessageBox.Show("Você não selecionou um servidor...", "Selecione um Servidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        con.Open();
                        MessageBox.Show("Conexão Testada com Sucesso.\n" + comboBox1.SelectedItem.ToString(), "Testar Conexão", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnUpdateCadSys_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Selecione")
            {
                MessageBox.Show("Você não selecionou um servidor...", "Selecione um Servidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                acesso.ShowDialog();
                if (acesso.DialogResult == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja executar o comando UpdateCadSys?", "Update CadSys", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Query.UpdateCadSys();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel executar: \n" + ex, "Error");
                        }
                    }
                }
            }
        }
        private void btnAttIbsCbsNCM_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Selecione")
            {
                MessageBox.Show("Você não selecionou um servidor...", "Selecione um Servidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                acesso.ShowDialog();
                if (acesso.DialogResult == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja executar o comando ATUALIZA IBSCBS COM BASE NO NCM?", "ATUALIZA IBSCBS COM BASE NO NCM", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Query.AtualizaIbsCbsNCM();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel executar: \n" + ex, "Error");
                        }
                    }
                }
            }
        }

        private void btnLimparLog_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Selecione")
            {
                MessageBox.Show("Você não selecionou um servidor...", "Selecione um Servidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                acesso.ShowDialog();
                if (acesso.DialogResult == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja executar o comando Limpar Log?", "Limpar Log", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Query.LimparLog();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel executar: \n" + ex, "Error");
                        }
                    }
                }
            }
        }

        private void btnRecriaIndice_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Selecione")
            {
                MessageBox.Show("Você não selecionou um servidor...", "Selecione um Servidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                acesso.ShowDialog();
                if (acesso.DialogResult == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja executar o comando Recria Indice?", "Recria Indice", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Query.RecriaIndice();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel executar: \n" + ex, "Error");
                        }
                    }
                }
            }
        }

        private void btnRecriarEstatBanco_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Selecione")
            {
                MessageBox.Show("Você não selecionou um servidor...", "Selecione um Servidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                acesso.ShowDialog();
                if (acesso.DialogResult == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja executar o comando Recria Estatisticas Banco?", "Recria Estatisticas Banco", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Query.RecriaEstatisticasBanco();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel executar: \n" + ex, "Error");
                        }
                    }
                }
            }
        }

        private void btnRemoverRegTabelaHist_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Selecione")
            {
                MessageBox.Show("Você não selecionou um servidor...", "Selecione um Servidor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                acesso.ShowDialog();
                if (acesso.DialogResult == DialogResult.OK)
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja executar o comando Recria Estatisticas Banco?", "Recria Estatisticas Banco", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Query.RemoverRegistrosTabela();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Não foi possivel executar: \n" + ex, "Error");
                        }
                    }
                }
            }
        }

        //TAB 3 - Scripts Text
        private void btnResetTransportNF_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.ResetarTransporteNF);
            scrptCopy.ShowDialog();
        }

        private void btnDupChaveAcesso_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.DuplicidadeChaveACesso);
            scrptCopy.ShowDialog();
        }

        private void btnCNPJautDownlo_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.CnpjAutorizadoDownload);
            scrptCopy.ShowDialog();
        }

        private void btnDescontoRateado_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.DescontoRateado);
            scrptCopy.ShowDialog();
        }

        private void btnDesvPreDoc_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.DesvinculaPreDoc);
            scrptCopy.ShowDialog();
        }

        private void btnMudaOpNF_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.MudaOperacaoNF);
            scrptCopy.ShowDialog();
        }

        private void btnMudaModelNF_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.MudaModeloNF);
            scrptCopy.ShowDialog();
        }

        private void btnNfPendenteEmitd_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.NfPendenteTransmitida);
            scrptCopy.ShowDialog();
        }

        private void btnPreDocAltEstacao_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.PreDocAlteradoEmOutraEstacao);
            scrptCopy.ShowDialog();
        }

        private void btnAltStatPreDoc_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.AlterarStatusPreDoc);
            scrptCopy.ShowDialog();
        }

        private void btnRefaturaCErro_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.ExcluirRefaturaErro);
            scrptCopy.ShowDialog();
        }

        private void btnRefInvisivel_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.RemoverRefInvisivel);
            scrptCopy.ShowDialog();
        }

        private void btnInutilizarNFAut_Click(object sender, EventArgs e)
        {
            Tab3FormCreator.TextoScript(scrptCopy, ScriptsTexts.InutilizouSemVerSitSefaz);
            scrptCopy.ShowDialog();
        }

        
    }
}