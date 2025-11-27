using System;
using System.Windows.Forms;

namespace TaskRunner
{
    public partial class LiberacaoScript : Form
    {
        public LiberacaoScript()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals("SA_0bjetiva"))
            {
                this.DialogResult = DialogResult.OK;
                txtSenha.Text = "";
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            txtSenha.Text = "";
            this.Close();
        }
    }
}
