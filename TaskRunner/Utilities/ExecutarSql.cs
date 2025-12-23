using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskRunner.Utilities
{
    internal class ExecutarSql
    {
        public void ExecutarScript(Func<bool> ValidarServerBanco , LiberacaoScript acesso , string titulo, Action comando)
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
    }
}
