using ObjetivaScripts.Bat_Files;
using ObjetivaScripts.Copy_SQL_Scripts;
using ObjetivaScripts.SQL;
using ObjetivaScripts.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjetivaScripts
{
    public partial class MainForm : Form
    {
        public static string Senha = "SA_0bjetiva";
        LiberacaoScript acesso = new LiberacaoScript();
        public MainForm()
        {
            InitializeComponent();
            ListarServidores();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.btnTestarConexao, "Testar conexão com banco de dados");
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
                    TempFile.ExecuteTempFile(AtualizarCustosAPartirFilial50.comando);
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
                    TempFile.ExecuteTempFile(AtualizarCustosAPartirEntrada.comando);
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
                    TempFile.ExecuteTempFile(RealizarBackup.comando);
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
                    TempFile.ExecuteTempFile(FinalizarTarefasVarejo.comando);
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
                    TempFile.ExecuteTempFile(EncerrarUniDanfe.comando);
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
                    TempFile.ExecuteTempFile(DeleteDLLECF.comando);
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
                    TempFile.ExecuteTempFile(ClearFilaImpressao.comando);
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
                    TempFile.ExecuteTempFile(PermObjetivaC.comando);
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
                    TempFile.ExecuteTempFile(PermObjetivaD.comando);
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
                    TempFile.ExecuteTempFile(IniciarSQLService.comando);
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
                    TempFile.ExecuteTempFile(LiberarSQLFirewall.comando);
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
                    TempFile.ExecuteTempFile(RecriarEstatisticaBD.comando);
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
                    TempFile.ExecuteTempFile(IndexarBanco.comando);
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
                    TempFile.ExecuteTempFile(ExcluirRegistroObjetiva.comando);
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

        //TAB 3 - Testes
        private void btnResetTransportNF_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.ResetarTransporteNF);
            ScriptforCopy.ShowDialog();
        }

        private void btnDupChaveAcesso_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.DuplicidadeChaveACesso);
            ScriptforCopy.ShowDialog();
        }

        private void btnCNPJautDownlo_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.CnpjAutorizadoDownload);
            ScriptforCopy.ShowDialog();
        }

        private void btnDescontoRateado_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.DescontoRateado);
            ScriptforCopy.ShowDialog();
        }

        private void btnDesvPreDoc_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.DesvinculaPreDoc);
            ScriptforCopy.ShowDialog();
        }

        private void btnMudaOpNF_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.MudaOperacaoNF);
            ScriptforCopy.ShowDialog();
        }

        private void btnMudaModelNF_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.MudaModeloNF);
            ScriptforCopy.ShowDialog();
        }

        private void btnNfPendenteEmitd_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.NfPendenteTransmitida);
            ScriptforCopy.ShowDialog();
        }

        private void btnPreDocAltEstacao_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.PreDocAlteradoEmOutraEstacao);
            ScriptforCopy.ShowDialog();
        }

        private void btnAltStatPreDoc_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.AlterarStatusPreDoc);
            ScriptforCopy.ShowDialog();
        }

        private void btnRefaturaCErro_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.ExcluirRefaturaErro);
            ScriptforCopy.ShowDialog();
        }

        private void btnRefInvisivel_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.RemoverRefInvisivel);
            ScriptforCopy.ShowDialog();
        }

        private void btnInutilizarNFAut_Click(object sender, EventArgs e)
        {
            Form ScriptforCopy = new Form();
            Tab3FormCreator.TextoScript(ScriptforCopy, ScriptsTexts.InutilizouSemVerSitSefaz);
            ScriptforCopy.ShowDialog();
        }

        
    }
}