using ROMVault.Helpers;
using ROMVault.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROMVault
{
    public partial class FrmImportDat : Form
    {
        public string InitialPath = string.Empty;
        public string DestinationPath = string.Empty;
        public List<string> SourcePaths;

        private string resolvedDatRoot;
        private string formatsFilterString;

        public FrmImportDat(string initialPath, string formatsFilterString)
        {
            InitializeComponent();

            resolvedDatRoot = RvSystems.GetFullyQualifiedPath(RomVaultCore.Settings.rvSettings.DatRoot);

            InitialPath = initialPath.Trim();
            DestinationFolderLB.Text = InitialPath;
            ValidateImportDirectory(InitialPath);

            this.formatsFilterString = formatsFilterString;
        }

        private void FrmImportDat_Load(object sender, EventArgs e)
        {
            Dark.dark.SetColors(this, RomVaultCore.Settings.rvSettings.Darkness);
            Helpers.Theming.SetFormTextSizeToDefault(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void SetValidDestinationPath()
        {
            InfoImagePB.Image = Resources.tick;
            InfoLB.Text = "The selected destination folder is valid.";
        }

        private void ValidateImportDirectory(string path)
        {
            if (Helpers.FileSystem.IsPathInsideFolder(resolvedDatRoot, path)
                && Directory.Exists(path))
            {
                SetValidDestinationPath();
                DestinationFolderLB.Text = path;
                _isValidImportDirectory = true;
            }
            else
            {
                _isValidImportDirectory = false;
                InfoImagePB.Image = Resources.exclamation_circle;
                InfoLB.Text = "The selected destination folder must be valid and inside the DAT root folder.";
            }
        }

        private void DestinationFolderBT_Click(object sender, EventArgs e)
        {
            UserControls.FolderBrowserDialog fbd = new UserControls.FolderBrowserDialog()
            {
                Description = "Select or Create the folder to import the DAT file to. Must be inside the DAT root folder",
                OkButtonLabel = "Select",
                InputPath = InitialPath
            };

            DestinationFolderLB.Text = "";

            var result = fbd.ShowDialog(this);

            if (result != true) return;

            ValidateImportDirectory(fbd.SelectedPath);

            UpdateImportButton();
        }

        private bool _isValidImportDirectory = false;
        private bool _areValidSourceFiles = false;

        private void UpdateImportButton()
        {
            if (!_isValidImportDirectory || !_areValidSourceFiles) ImportBT.Enabled = false;
            else ImportBT.Enabled = true;
        }

        private void ImportBT_Click(object sender, EventArgs e)
        {
            if (!_isValidImportDirectory || !_areValidSourceFiles) ImportBT.Enabled = false;

            // still validate import folder and files at this point as user may delete between selection and importing.
            if (!Directory.Exists(DestinationFolderLB.Text.Trim()))
            {
                InfoImagePB.Image = Resources.exclamation_circle;
                InfoLB.Text = "The selected destination folder no longer exists. Please check.";
                _isValidImportDirectory = false;
                ImportBT.Enabled = false;
                return;
            }

            List<string> sourceFiles = FileToImportRTB.Lines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => line.Trim())
                .ToList();

            foreach (string file in sourceFiles)
            {
                if (!File.Exists(file))
                {
                    InfoImagePB.Image = Resources.exclamation_circle;
                    InfoLB.Text = "One or more of the import files no longer exist.";
                    _areValidSourceFiles = false;
                    ImportBT.Enabled = false;
                    //FileToImportRTB.Text = "";
                    return;
                }
            }

            DestinationPath = DestinationFolderLB.Text.Trim();
            SourcePaths = sourceFiles;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FileToImportBT_Click(object sender, EventArgs e)
        {
            FileToImportRTB.Text = "";

            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Please select DAT files to import.",
                Multiselect = true,
                Filter = formatsFilterString
            };

            var result = ofd.ShowDialog(this);
            if (result != DialogResult.OK) return;

            foreach (string file in ofd.FileNames)
            {
                if (!File.Exists(file))
                {
                    InfoImagePB.Image = Resources.exclamation_circle;
                    InfoLB.Text = "One or more of the selected files do not exist.";
                    _areValidSourceFiles = false;
                    FileToImportRTB.Text = "";
                    return;
                }
                else
                {
                    FileToImportRTB.AppendText(file + Environment.NewLine);
                }
            }
            InfoLB.Text = "Import Files valid.";
            InfoImagePB.Image = Resources.tick;
            _areValidSourceFiles = true;

            UpdateImportButton();
        }
    }
}