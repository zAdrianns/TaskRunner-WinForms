using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjetivaScripts.Utilities
{
    internal class Tab3FormCreator
    {
        public static Form TextoScript(Form tela, string texto)
        {
            RichTextBox txt = new RichTextBox()
            {
                Font = new Font("Consolas", 11),
                Text = texto,
                ReadOnly = true,
                Location = new Point(0, 0),
                Size = new Size(1000, 800)
            };
            tela.Controls.Add(txt);
            return tela;
        }
    }
}
