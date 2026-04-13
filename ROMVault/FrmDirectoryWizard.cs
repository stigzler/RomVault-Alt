using RomVaultCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROMVault
{
    public partial class FrmDirectoryWizard : Form
    {
        public FrmDirectoryWizard()
        {
            InitializeComponent();
        }

        private void FrmDirectoryWizard_Load(object sender, EventArgs e)
        {
            Dark.dark.SetColors(this, Settings.rvSettings.Darkness);
            Helpers.Theming.SetFormTextSizeToDefault(this);
        }
    }
}
