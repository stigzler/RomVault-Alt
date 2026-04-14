using ROMVault.Properties;
using ROMVault.UserControls;
using RomVaultCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROMVault
{
    public partial class FrmDirectoryWizard : Form
    {
        private string _infoLabelPrefix = "      ";
        private string _schemaDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets\\FolderSchema");

        public FrmDirectoryWizard()
        {
            InitializeComponent();
            LoadSchemaDropdown();
        }

        private void DefaultSchemaDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fullfile = Path.Combine(_schemaDir, DefaultSchemaDD.SelectedItem.ToString() + ".rvs");
            if (!File.Exists(fullfile))
            {
                UpdateSchemaInfoLabel(SchemaInfoLB, visible: true, Properties.Resources.exclamation_red, "Default Schema file not found.");
                return;
            }

            UpdateSchemaInfoLabel(SchemaInfoLB, false); // clears any error

            LoadSchemaFromFile(fullfile);
        }

        private void FoldersRTB_TextChanged(object sender, EventArgs e)
        {
            SetAsNeedsValidation();
        }

        private void FrmDirectoryWizard_Load(object sender, EventArgs e)
        {
            Dark.dark.SetColors(this, RomVaultCore.Settings.rvSettings.Darkness);
            Helpers.Theming.SetFormTextSizeToDefault(this);
        }

        private void LoadSchemaDropdown()
        {
            DefaultSchemaDD.Items.Clear();
            foreach (var file in Directory.GetFiles(_schemaDir, "*.rvs"))
            {
                DefaultSchemaDD.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void LoadSchemaFromFile(string fileName)
        {
            FoldersRTB.Clear();
            SubFoldersRTB.Clear();
            foreach (string line in File.ReadLines(fileName))
            {
                if (line.First() != '*')
                {
                    FoldersRTB.AppendText(line + Environment.NewLine);
                }
                else
                {
                    SubFoldersRTB.AppendText(line.Substring(1) + Environment.NewLine);
                }
            }
        }

        private void SetAsNeedsValidation()
        {
            SetSaveAndGoButtons(false);
        }

        private void SubFoldersRTB_TextChanged(object sender, EventArgs e)
        {
            SetAsNeedsValidation();
        }

        private void TestBT_Click(object sender, EventArgs e)
        {
            GoBT.Enabled = true;
            SaveAsBT.Enabled = true;
        }

        private void UpdateSchemaInfoLabel(Label label, bool visible, Image icon = null, string message = "")
        {
            label.Visible = visible;
            label.Image = icon;
            label.Text = _infoLabelPrefix + message;
        }

        private bool _updatingCreateDeleteCheckboxes = false;

        private void CReateFoldersChB_CheckedChanged(object sender, EventArgs e)
        {
            if (_updatingCreateDeleteCheckboxes) return;

            _updatingCreateDeleteCheckboxes = true;

            if (CreateFoldersChB.Checked == true)
            {
                DeleteFoldersChB.Checked = false;
                DeleteFilesChB.Enabled = false;
            }
            else
            {
                DeleteFoldersChB.Checked = true;
                DeleteFilesChB.Enabled = true;
            }
            _updatingCreateDeleteCheckboxes = false;
        }

        private void DeleteFoldersChB_CheckedChanged(object sender, EventArgs e)
        {
            if (_updatingCreateDeleteCheckboxes) return;

            _updatingCreateDeleteCheckboxes = true;

            if (DeleteFoldersChB.Checked == true)
            {
                CreateFoldersChB.Checked = false;
                DeleteFilesChB.Enabled = true;
            }
            else
            {
                CreateFoldersChB.Checked = true;
                DeleteFilesChB.Enabled = false;
            }
            _updatingCreateDeleteCheckboxes = false;
        }

        private void ValidateBT_Click(object sender, EventArgs e)
        {
            OutcomeLB.Visible = false;
            bool isValid = ValidateSchema();
            if (!isValid) return;
            SetSaveAndGoButtons(enabled: true);
        }

        private void SetSaveAndGoButtons(bool enabled)
        {
            GoBT.Enabled = enabled;
            SaveAsBT.Enabled = enabled;
        }

        private void SetRTBSelectedTextColors(RichTextBox rtb, Color background, Color foreground)
        {
            rtb.SelectionBackColor = background;
            rtb.SelectionColor = foreground;
        }

        private void ClearRTBHighlights(RichTextBox rtb)
        {
            rtb.SelectAll();
            SetRTBSelectedTextColors(rtb, FoldersRTB.BackColor, foreground: FoldersRTB.ForeColor);
            rtb.SelectionStart = 0;
            rtb.SelectionLength = 0;
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>True if valid</returns>
        private bool ValidateSchema()
        {
            string errorMessage = "";
            bool invalid = false;

            int charPointer = 0;

            foreach (string line in FoldersRTB.Lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                ClearRTBHighlights(FoldersRTB);
                ClearRTBHighlights(SubFoldersRTB);

                string cleanLine = line.Trim('/', '\\'); // removes prefixing or suffixing slashes for consideration
                if (!Helpers.FileSystem.IsValidPath(cleanLine))
                {
                    errorMessage = $"Invalid path: {line}";
                    UpdateSchemaInfoLabel(FoldersInfoLB, true, Resources.exclamation_circle, errorMessage);
                    invalid = true;
                    FoldersRTB.Select(charPointer, line.Length);
                    SetRTBSelectedTextColors(FoldersRTB, background: Color.Yellow, foreground: Color.Black);
                    FoldersRTB.ScrollToCaret();
                    break;
                }
                charPointer += line.Length + 1;
            }
            if (!invalid)
                UpdateSchemaInfoLabel(FoldersInfoLB, true, Resources.tick, "Paths Good.");

            charPointer = 0;

            foreach (string line in SubFoldersRTB.Lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string cleanLine = line.Trim('/', '\\'); // removes prefixing or suffixing slashes for consideration
                if (!Helpers.FileSystem.IsValidPath(cleanLine))
                {
                    errorMessage = $"Invalid path: {line}";
                    UpdateSchemaInfoLabel(SubFolderInfoLB, true, Resources.exclamation_circle, errorMessage);
                    invalid = true;
                    SubFoldersRTB.Select(charPointer, line.Length);
                    SetRTBSelectedTextColors(SubFoldersRTB, background: Color.Yellow, foreground: Color.Black);
                    SubFoldersRTB.ScrollToCaret();
                    break;
                }
                charPointer += line.Length + 1;
            }
            if (!invalid)
                UpdateSchemaInfoLabel(SubFolderInfoLB, true, Resources.tick, "Paths Good.");

            return !invalid;
        }

        private void GoBT_Click(object sender, EventArgs e)
        {
            if (DeleteFoldersChB.Checked == true && DeleteFilesChB.Checked)
            {
                var result = MessageBox.Show("You have chosen to delete folders and all files within them. Are you sure you want to proceed?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    return;
                }
            }

            if (UnderCustomLocationChB.Checked && !Directory.Exists(CustomLocationLB.Text))
            {
                OutcomeLB.Visible = true;
                OutcomeLB.Image = Resources.exclamation_circle;
                OutcomeLB.Text = $"{_infoLabelPrefix}Custom Location does not exist. Aborting operation.";
                SystemSounds.Beep.Play();
                return;
            }

            if (!UnderRomsChB.Checked && !UnderDatsChB.Checked && !UnderCustomLocationChB.Checked)
            {
                OutcomeLB.Visible = true;
                OutcomeLB.Image = Resources.exclamation_circle;
                OutcomeLB.Text = $"{_infoLabelPrefix}No folder roots selected";
                SystemSounds.Beep.Play();
                return;
            }

            DoFolderOperations();
        }

        private void DoFolderOperations()
        {
            List<string> folderRoots = new List<string>();
            List<String> errorLog = new List<String>();

            LogRTB.Clear();
            LogRTB.AppendText($"Operation start at {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}{Environment.NewLine}");
            LogRTB.AppendText($"Starting folder {(CreateFoldersChB.Checked ? "creation" : "deletion")} process...{Environment.NewLine}");
            LogRTB.AppendText($"Operation will be performed on the following root folders:" +
                $"{String.Join(", ", folderRoots.ToArray())}{Environment.NewLine}");
            LogRTB.AppendText($"Also Delete Files set to: {DeleteFilesChB.Checked}{Environment.NewLine}");
            LogRTB.AppendText($"------------------------------{Environment.NewLine}");

            if (UnderRomsChB.Checked)
            {
                string romVaultRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    RomVaultCore.Settings.rvSettings.DirMappings.Find(dm => dm.DirKey == "RomVault").DirPath);
                if (romVaultRoot != null && Directory.Exists(romVaultRoot))
                {
                    folderRoots.Add(romVaultRoot);
                }
            }

            string datRoot = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                    RomVaultCore.Settings.rvSettings.DatRoot));

            if (UnderDatsChB.Checked && Directory.Exists(datRoot))
            {
                folderRoots.Add(datRoot);
            }

            if (UnderCustomLocationChB.Checked && Directory.Exists(CustomLocationLB.Text))
            {
                folderRoots.Add(CustomLocationLB.Text);
            }

            // shouldn't ever fire b/c dat and rom root must always exist, but just in case

            bool create = CreateFoldersChB.Checked;

            Cursor.Current = Cursors.WaitCursor;

            // blurgh - below messy and inelegant. However, does the job and want my life back.

            foreach (string root in folderRoots)
            {
                foreach (string line in FoldersRTB.Lines)
                {
                    if (String.IsNullOrEmpty(line)) continue;
                    if (create)
                    {
                        string newFolderPath = Path.Combine(root.Trim('/', '\\'), line.Trim('/', '\\'));
                        if (!Directory.Exists(newFolderPath))
                        {
                            try
                            {
                                Directory.CreateDirectory(newFolderPath);
                                LogRTB.AppendText($"Created folder: {newFolderPath}{Environment.NewLine}");
                            }
                            catch (Exception ex)
                            {
                                LogRTB.AppendText($"ERROR: Failed to create folder: {newFolderPath}\nError: {ex.Message}");
                            }
                        }
                        else
                        {
                            LogRTB.AppendText($"Folder already exists: {newFolderPath}{Environment.NewLine}");
                        }
                    }
                    else // delete folder
                    {
                        string folderPath = Path.Combine(root.Trim('/', '\\'), line.Trim('/', '\\'));
                        if (Directory.Exists(folderPath))
                        {
                            if (DeleteFilesChB.Checked || (!DeleteFilesChB.Checked && !Helpers.FileSystem.FolderHasFiles(folderPath)))
                                try
                                {
                                    Directory.Delete(folderPath, recursive: true);
                                    LogRTB.AppendText($"Deleted folder: {folderPath}{Environment.NewLine}");
                                }
                                catch (Exception ex)
                                {
                                    LogRTB.AppendText($"ERROR: Failed to delete folder: {folderPath}\nError: {ex.Message}");
                                }
                        }
                        {
                            LogRTB.AppendText($"Folder does not exist: {folderPath}{Environment.NewLine}");
                        }
                    }

                    // now for any subfolders
                    foreach (string subLine in SubFoldersRTB.Lines)
                    {
                        if (String.IsNullOrEmpty(subLine)) continue;
                        if (create)
                        {
                            string newFolderPath = Path.Combine(root.Trim('/', '\\'), line.Trim('/', '\\'), subLine.Trim('/', '\\'));
                            if (!Directory.Exists(newFolderPath))
                            {
                                try
                                {
                                    Directory.CreateDirectory(newFolderPath);
                                    LogRTB.AppendText($"Created sub-folder: {newFolderPath}{Environment.NewLine}");
                                }
                                catch (Exception ex)
                                {
                                    LogRTB.AppendText($"ERROR: Failed to create sub-folder: {newFolderPath}\nError: {ex.Message}");
                                }
                            }
                            else
                            {
                                LogRTB.AppendText($"Folder already exists: {newFolderPath}{Environment.NewLine}");
                            }
                        }
                        else // delete folder
                        {
                            string folderPath = Path.Combine(root.Trim('/', '\\'), line.Trim('/', '\\'), subLine.Trim('/', '\\'));
                            if (Directory.Exists(folderPath))
                            {
                                if (DeleteFilesChB.Checked || (!DeleteFilesChB.Checked && !Helpers.FileSystem.FolderHasFiles(folderPath)))
                                {
                                    try
                                    {
                                        Debug.WriteLine(folderPath);
                                        Directory.Delete(folderPath, recursive: true);
                                        LogRTB.AppendText($"Deleted sub-folder: {folderPath}{Environment.NewLine}");
                                    }
                                    catch (Exception ex)
                                    {
                                        LogRTB.AppendText($"ERROR: Failed to delete sub-folder: {folderPath}\nError: {ex.Message}");
                                    }
                                }
                            }
                            {
                                LogRTB.AppendText($"Folder does not exist: {folderPath}{Environment.NewLine}");
                            }
                        }
                    }
                }
            }

            Cursor.Current = Cursors.Default;
            OutcomeLB.Visible = true;
            OutcomeLB.Image = Resources.smiley;
            OutcomeLB.Text = $"{_infoLabelPrefix}Operation completed at {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}";
            SystemSounds.Asterisk.Play();
        }

        private void LoadSchemaBT_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            { Title = "Choose a Folder Schema file to import..", Multiselect = false };

            var result = ofd.ShowDialog(this);
            if (result != DialogResult.OK) return;

            if (File.Exists(ofd.FileName))
            {
                LoadSchemaPathLB.Text = ofd.FileName;
                LoadSchemaFromFile(ofd.FileName);
            }
        }

        private void CustomLocationBT_Click(object sender, EventArgs e)
        {
            UserControls.FolderBrowserDialog fbd = new UserControls.FolderBrowserDialog()
            { Description = "Directory to do Folder Operations on..", Multiselect = false };

            var result = fbd.ShowDialog(this);
            if (result != true) return;

            if (Directory.Exists(fbd.SelectedPath))
            {
                CustomLocationLB.Text = fbd.SelectedPath;
            }
        }

        private void SaveAsBT_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = "RomVault Folder Schema (*.rvs)|*.rvs",
                Title = "Save Folder Schema As..",
                InitialDirectory = _schemaDir
            };

            var result = sfd.ShowDialog(this);
            if (result != DialogResult.OK) return;

            StringBuilder sb = new StringBuilder();
            foreach (string line in FoldersRTB.Lines)
            {
                if (!String.IsNullOrWhiteSpace(line))
                    sb.AppendLine(line);
            }

            foreach (string line in SubFoldersRTB.Lines)
            {
                if (!String.IsNullOrWhiteSpace(line))
                    sb.AppendLine($"*{line}");
            }

            try
            {
                File.WriteAllText(sfd.FileName, sb.ToString());
                if (Path.GetDirectoryName(sfd.FileName) == _schemaDir)
                {
                    LoadSchemaDropdown();
                }

                OutcomeLB.Visible = true;
                OutcomeLB.Image = Resources.disk;
                OutcomeLB.Text = $"{_infoLabelPrefix}File saved as {Path.GetFileName(sfd.FileName)}";
            }
            catch (Exception ex)
            {
                OutcomeLB.Visible = true;
                OutcomeLB.Image = Resources.exclamation_red;
                OutcomeLB.Text = $"Failed to save schema. Error: {ex.Message}";
            }
        }
    }
}