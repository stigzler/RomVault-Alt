using ROMVault.Properties;
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
    public partial class FrmImportDat : Form
    {
        public string DestinationPath = string.Empty;
        public List<string> SourcePaths;

        public FrmImportDat()
        {
            InitializeComponent();
        }

        private void FrmImportDat_Load(object sender, EventArgs e)
        {
            Dark.dark.SetColors(this, RomVaultCore.Settings.rvSettings.Darkness);
            Helpers.Theming.SetFormTextSizeToDefault(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void DestinationFolderBT_Click(object sender, EventArgs e)
        {
            UserControls.FolderBrowserDialog fbd = new UserControls.FolderBrowserDialog()
            {
                Description = "Select or Create the folder to import the DAT file to. Must be inside the DAT root folder",
                OkButtonLabel = "Select"
            };

            var result = fbd.ShowDialog(this);

            if (result != true) return;

            if (Helpers.FileSystem.IsPathInsideFolder(fbd.SelectedPath, ))
            {
                DestinationFolderTB.Text = fbd.SelectedPath;
            }
            else
            {
                MessageBox.Show(this, "The selected folder must be inside the DAT root folder", "Invalid Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}