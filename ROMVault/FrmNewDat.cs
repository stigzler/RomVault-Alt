using RomVaultCore;
using System;
using System.IO;
using System.Windows.Forms;

namespace ROMVault
{
    public partial class FrmNewDat : Form
    {
        public string Filename { get => FilenameTB.Text; set => FilenameTB.Text = value; }
        public string Name { get => NameTB.Text; set => NameTB.Text = value; }
        public string Description { get => DescriptionRTB.Text; set => DescriptionRTB.Text = value; }
        public string Category { get => CategoryTB.Text; set => CategoryTB.Text = value; }

        public string RootPath; // where the dat file will go.

        public bool ValidFilename = false;

        public FrmNewDat()
        {
            InitializeComponent();
        }

        private bool FileAlreadyExists()
        {
            string fullPath = Path.Combine(RootPath, $"{Filename}.dat");
            return File.Exists(fullPath);
        }

        private void FilenameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (Array.IndexOf(Path.GetInvalidFileNameChars(), e.KeyChar) >= 0)
                e.Handled = true;
        }

        private void FilenameTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsText())
                {
                    string clipboardText = Clipboard.GetText();
                    char[] invalidChars = Path.GetInvalidFileNameChars();

                    foreach (char c in clipboardText)
                    {
                        if (Array.IndexOf(invalidChars, c) >= 0)
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }
            }
        }

        private void AddBT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Filename))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "      Filename cannot be empty.";
                return;
            }
            else if (FileAlreadyExists())
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = "      A file with this name already exists in the target directory.";
                return;
            }
            else
            {
                ErrorLabel.Visible = false;
            }
            ValidFilename = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmNewDat_Load(object sender, EventArgs e)
        {
            Dark.dark.SetColors(this, Settings.rvSettings.Darkness);
            Helpers.Theming.SetFormTextSizeToDefault(this);
        }
    }
}