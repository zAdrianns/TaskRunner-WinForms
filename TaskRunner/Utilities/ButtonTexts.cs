using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskRunner.Utilities
{
    internal class ButtonTexts
    {
        public ToolTip ToolTip1 { get; set; } = new ToolTip();

        public void SetToolTip(Control control, string text)
        {
            ToolTip1.SetToolTip(control, text);
        }
    }
}
