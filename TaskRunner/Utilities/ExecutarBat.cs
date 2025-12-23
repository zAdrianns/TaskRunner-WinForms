using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskRunner.Utilities
{
    internal class ExecutarBat
    {
        public void ExecutarBatFile(string texto, Action comando)
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
    }
}
