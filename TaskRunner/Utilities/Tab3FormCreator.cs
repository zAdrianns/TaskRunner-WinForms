using System;
using System.Drawing;
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

            tela.FormClosed += (s, e) =>
            {
                txt.Clear();
                tela.Controls.Remove(txt);
                txt.Dispose();
            };

            return tela;

        }

        private static void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
