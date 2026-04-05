using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROMVault.Helpers
{
    internal static class Theming
    {
        internal static void SetFormTextSizeToDefault(Form form)
        {
            form.Font = new System.Drawing.Font(form.Font.FontFamily, (float)Properties.Settings.Default.MainTextSize);
        }

        internal static void SetControlTextSizeToDefault(Control control)
        {
            control.Font = new System.Drawing.Font(control.Font.FontFamily, (float)Properties.Settings.Default.MainTextSize);
        }
    }
}