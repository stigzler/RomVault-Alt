using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROMVault.UserControls
{
    [System.ComponentModel.DesignerCategory("Code")]
    internal class TableLayoutPanel : System.Windows.Forms.TableLayoutPanel
    {
        public TableLayoutPanel()
        {
            DoubleBuffered = true;
        }
    }
}