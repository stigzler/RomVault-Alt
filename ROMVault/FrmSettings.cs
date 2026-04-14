/******************************************************
 *     ROMVault3 is written by Gordon J.              *
 *     Contact gordon@romvault.com                    *
 *     Copyright 2025                                 *
 ******************************************************/

using ROMVault.ViewModels;
using RomVaultCore;
using RomVaultCore.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Linq;

namespace ROMVault
{
    public partial class FrmSettings : Form
    {
        private const int WM_SETREDRAW = 11;

        private BindingList<DatSourceUrl> _datSourceUrls;

        private BindingList<RomSourceUrl> _romSourceUrls;

        private bool _shown = false;

        private FrmMain mainForm;

        public FrmSettings(FrmMain mainForm)
        {
            InitializeComponent();

            Helpers.Theming.SetFormTextSizeToDefault(this);
            Helpers.Theming.SetControlTextSizeToDefault(MainTV);

            this.mainForm = mainForm;

            Dark.dark.SetColors(this, Settings.rvSettings.Darkness);

            foreach (TreeNode node in MainTV.Nodes)
                node.Expand();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        public void CenterFormOnScreen()
        {
            // Get the screen that currently contains the majority of the form
            Screen currentScreen = Screen.FromControl(this);

            Rectangle workingArea = currentScreen.WorkingArea;

            this.Location = new Point(
                workingArea.Left + (workingArea.Width - this.Width) / 2,
                workingArea.Top + (workingArea.Height - this.Height) / 2
            );
        }

        private void AddDatFormatBT_Click(object sender, EventArgs e)
        {
            DatFormatsLV.Items.Add("{click to edit}");
        }

        private void AddDatSourceBT_Click(object sender, EventArgs e)
        {
            _datSourceUrls.Add(new DatSourceUrl { Name = "{new source}", Url = "http://example.com/dat.xml" });
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDatClick(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = "Select a folder for DAT Root",
                RootFolder = Environment.SpecialFolder.MyComputer,
                SelectedPath = Settings.rvSettings.DatRoot
            };

            if (browse.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (Settings.rvSettings.UseRootedPaths)
            {
                lblDATRoot.Text = browse.SelectedPath;
            }
            else
            {
                lblDATRoot.Text = RelativePath.MakeRelative(AppDomain.CurrentDomain.BaseDirectory, browse.SelectedPath);
            }
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            SetSettings();
            PersistSettings();
            mainForm.UpdateThemeAndControls();
            Close();
        }

        private void ChangeFormControlsFontSizes()
        {
            // 1. Stop the Form from painting at the Windows message level
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);

            try
            {
                float newSize = (float)MainTextSizeNUM.Value;
                Font previewFont = new Font(this.Font.FontFamily, newSize);

                this.Font = previewFont;
                MainSS.Font = previewFont;

                // Update TV while preserved family
                MainTV.Font = new Font(MainTV.Font.FontFamily, newSize);

                // FlexiLabel controls will adjust themselves via the Form.FontChanged event.
            }
            finally
            {
                // 2. Re-enable painting and force a clean redraw
                SendMessage(this.Handle, WM_SETREDRAW, true, 0);
                this.Refresh();
            }
        }

        private void chkSendFoundMIA_CheckedChanged(object sender, EventArgs e)
        {
            chkSendFoundMIAAnon.Enabled = chkSendFoundMIA.Checked;
        }

        private void DatFormatsLV_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // If the user cancelled or left it blank, do nothing
            if (string.IsNullOrEmpty(e.Label)) return;

            // Check if the new label contains only letters or digits
            foreach (char c in e.Label)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    //MessageBox.Show("Only letters and numbers are allowed.");
                    e.CancelEdit = true; // Reverts the change
                    return;
                }
            }
        }

        private void DeleteDatFormatBT_Click(object sender, EventArgs e)
        {
            if (DatFormatsLV.SelectedItems.Count == 0) return;
            DatFormatsLV.Items.Remove(DatFormatsLV.SelectedItems[0]);
        }

        private void DeleteDATSourceBT_Click(object sender, EventArgs e)
        {
            _datSourceUrls.Remove(_datSourceUrls.FirstOrDefault(url => url.Name == DatSourceLinksDGV.CurrentRow.Cells["Name"].Value.ToString()));
        }

        private void FrmConfigLoad(object sender, EventArgs e)
        {
            SetupControls();

            LoadSettings();

            UpdateStatusBar(); // has to be done after LaodSettings;

            if (Properties.Settings.Default.SettingsSplitterDistance != 0)
            {
                MainSC.SplitterDistance = Properties.Settings.Default.SettingsSplitterDistance;
            }
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SettingsSplitterDistance = MainSC.SplitterDistance;
        }

        private void FrmSettings_Shown(object sender, EventArgs e)
        {
            _shown = true;//TvPaddingPN.BackColor = MainTV.BackColor;
        }

        private Color GetColor()
        {
            var result = ColorBroswer.ShowDialog();
            if (result != DialogResult.OK) return Color.Empty;
            return ColorBroswer.Color;
        }

        private void InfoTextColorPB_Click(object sender, EventArgs e)
        {
            if (!_shown) return; // avoid trying to update status bar before form is shown and controls are fully loaded
            var result = ColorBroswer.ShowDialog();
            if (result != DialogResult.OK) return;
            Properties.Settings.Default.InfoTextColor = ColorBroswer.Color;
            InfoTextColorPB.BackColor = ColorBroswer.Color;
            InfoTextExampleLB.ForeColor = ColorBroswer.Color;
        }

        private void LoadDatUrls()
        {
            // Transform: String -> DatMap Object -> BindingList
            var list = Properties.Settings.Default.DatUrls.Cast<string>()
                .Select(line => line.Split('|'))
                .Where(parts => parts.Length == 2)
                .Select(parts => new DatSourceUrl { Name = parts[0], Url = parts[1] })
                .ToList();

            _datSourceUrls = new BindingList<DatSourceUrl>(list);
            DatSourceLinksDGV.DataSource = _datSourceUrls;
        }

        private void LoadRomUrls()
        {
            // Transform: String -> DatMap Object -> BindingList
            var list = Properties.Settings.Default.RomUrls.Cast<string>()
                .Select(line => line.Split('|'))
                .Where(parts => parts.Length == 2)
                .Select(parts => new RomSourceUrl { Name = parts[0], Url = parts[1] })
                .ToList();

            _romSourceUrls = new BindingList<RomSourceUrl>(list);
            RomSourceLinksDGV.DataSource = _romSourceUrls;
        }

        private void LoadSettings()
        {
            chkSendFoundMIA.Checked = Settings.rvSettings.MIACallback;
            chkSendFoundMIAAnon.Checked = Settings.rvSettings.MIAAnon;

            chkDetailedReporting.Checked = Settings.rvSettings.DetailedFixReporting;
            chkDoubleCheckDelete.Checked = Settings.rvSettings.DoubleCheckDelete;
            chkCacheSaveTimer.Checked = Settings.rvSettings.CacheSaveTimerEnabled;
            upTime.Value = Settings.rvSettings.CacheSaveTimePeriod;
            chkDebugLogs.Checked = Settings.rvSettings.DebugLogsEnabled;
            chkDeleteOldCueFiles.Checked = Settings.rvSettings.DeleteOldCueFiles;
            cboCores.SelectedIndex = Settings.rvSettings.zstdCompCount >= cboCores.Items.Count ? 0 : Settings.rvSettings.zstdCompCount;
            cbo7zStruct.SelectedIndex = Settings.rvSettings.sevenZDefaultStruct;
            chkDarkMode.Checked = Settings.rvSettings.Darkness;
            chkDoNotReportFeedback.Checked = Settings.rvSettings.DoNotReportFeedback;

            // Supplemental Settings
            var setts = Properties.Settings.Default;

            // DATs
            foreach (var format in setts.RecognisedDatFormats)
                DatFormatsLV.Items.Add(new ListViewItem() { Text = format });
            MoveDontCopyDatsChB.Checked = setts.DatImportMoveDontCopy;
            LoadDatUrls();

            // Roms
            LoadRomUrls();

            // File OPs
            MoveFilesNotCopyChB.Checked = setts.RomImportMoveNotCopy;
            DeleteOrigRomsRelocateChB.Checked = setts.RomRelocateDeleteOriginal;
            PreserveEmptyRomFoldersChB.Checked = Settings.rvSettings.PreserveEmptyRomFolders;
            UseRootedPathsChB.Checked = Settings.rvSettings.UseRootedPaths;

            // UI and UX
            MainTextSizeNUM.Value = setts.MainTextSize;
            InfoTextColorPB.BackColor = setts.InfoTextColor;
            EnableGamesGridRClickChB.Checked = setts.EnableGamesGridRClick;
            StatusIconSizeNUM.Value = setts.StatusIconSize;
            StatusIconSizeAutoChB.Checked = setts.StatusIconSizeAuto;

            RomsFixableLB.ForeColor = setts.RomFixableColor;
            RomsGotLB.ForeColor = setts.RomGotColor;
            RomsMissingLB.ForeColor = setts.RomMissingColor;
            RomsUnknownLB.ForeColor = setts.RomUnknownColor;
            AutoCloseProgressChB.Checked = setts.AutoCloseProgressWindow;
        }

        private void MainTextSizeNUM_ValueChanged(object sender, EventArgs e)
        {
            if (!_shown) return; // avoid trying to update status bar before form is shown and controls are fully loaded
            ChangeFormControlsFontSizes();
            UpdateStatusBar();
            CenterFormOnScreen();
        }

        private void MainTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MainTC.SelectedTab = MainTC.TabPages[e.Node.Name.Replace("TVI", "TP")];
        }

        /// <summary>
        /// Save all settings to disk to persist over sessions.
        /// </summary>
        private void PersistSettings()
        {
            Settings.WriteConfig(Settings.rvSettings);
            Properties.Settings.Default.Save();
            mainForm.UpdateDatProvidersMenu(); // updates dat provider urls in the menu in case they were changed
            mainForm.UpdateRomProvidersMenu();
        }

        private void RestoreDatFormatsBT_Click(object sender, EventArgs e)
        {
            DatFormatsLV.Items.Clear();

            // 1. Get the XML string from the default properties
            string xmlDefault = (string)Properties.Settings.Default.Properties["RecognisedDatFormats"].DefaultValue;

            // 2. Setup the Serializer for StringCollection
            XmlSerializer serializer = new XmlSerializer(typeof(StringCollection));

            // 3. Deserialize the string back into a collection
            using (StringReader reader = new StringReader(xmlDefault))
            {
                StringCollection defaultCollection = (StringCollection)serializer.Deserialize(reader);

                // 4. Use it in your ListView
                DatFormatsLV.BeginUpdate();
                DatFormatsLV.Items.Clear();
                foreach (string format in defaultCollection)
                {
                    DatFormatsLV.Items.Add(format);
                }
                DatFormatsLV.EndUpdate();
            }

            // (thanks AI - 16 hours coding and my brain hurts)
        }

        private void RomsGotLB_Click(object sender, EventArgs e)
        {
        }

        private void RomsStatusTagChangeColor(object sender, EventArgs e)
        {
            switch (sender)
            {
                case Label lbl when lbl == RomsFixableLB:
                    if (GetColor() != Color.Empty)
                        RomsFixableLB.ForeColor = ColorBroswer.Color;
                    break;

                case Label lbl when lbl == RomsMissingLB:
                    if (GetColor() != Color.Empty)
                        RomsMissingLB.ForeColor = ColorBroswer.Color;
                    break;

                case Label lbl when lbl == RomsUnknownLB:
                    if (GetColor() != Color.Empty)
                        RomsUnknownLB.ForeColor = ColorBroswer.Color;
                    break;

                case Label lbl when lbl == RomsGotLB:
                    if (GetColor() != Color.Empty)
                        RomsGotLB.ForeColor = ColorBroswer.Color;
                    break;
            }
        }

        private void SetDatUrls()
        {
            Properties.Settings.Default.DatUrls.Clear();
            foreach (var url in _datSourceUrls)
            {
                Properties.Settings.Default.DatUrls.Add($"{url.Name}|{url.Url}");
            }
        }

        private void SetRomUrls()
        {
            Properties.Settings.Default.RomUrls.Clear();
            foreach (var url in _romSourceUrls)
            {
                Properties.Settings.Default.RomUrls.Add($"{url.Name}|{url.Url}");
            }
        }

        /// <summary>
        /// This will update all the settings in memory. This will not persist them.
        /// That is they will not be saved to disk here. PersistSettings does that.
        /// </summary>
        private void SetSettings()
        {
            Settings.rvSettings.DatRoot = lblDATRoot.Text;
            Settings.rvSettings.FixLevel = (EFixLevel)cboFixLevel.SelectedIndex;
            string strtxt = textBox1.Text;
            strtxt = strtxt.Replace("\r", "");
            string[] strsplit = strtxt.Split('\n');

            Settings.rvSettings.IgnoreFiles = new List<string>(strsplit);
            for (int i = 0; i < Settings.rvSettings.IgnoreFiles.Count; i++)
            {
                Settings.rvSettings.IgnoreFiles[i] = Settings.rvSettings.IgnoreFiles[i].Trim();
                if (string.IsNullOrEmpty(Settings.rvSettings.IgnoreFiles[i]))
                {
                    Settings.rvSettings.IgnoreFiles.RemoveAt(i);
                    i--;
                }
            }

            Settings.rvSettings.SetRegExRules();

            Settings.rvSettings.DetailedFixReporting = chkDetailedReporting.Checked;
            Settings.rvSettings.DoubleCheckDelete = chkDoubleCheckDelete.Checked;
            Settings.rvSettings.DebugLogsEnabled = chkDebugLogs.Checked;
            Settings.rvSettings.CacheSaveTimerEnabled = chkCacheSaveTimer.Checked;
            Settings.rvSettings.CacheSaveTimePeriod = (int)upTime.Value;

            Settings.rvSettings.MIACallback = chkSendFoundMIA.Checked;
            Settings.rvSettings.MIAAnon = chkSendFoundMIAAnon.Checked;
            Settings.rvSettings.DeleteOldCueFiles = chkDeleteOldCueFiles.Checked;

            Settings.rvSettings.zstdCompCount = cboCores.SelectedIndex;

            Settings.rvSettings.sevenZDefaultStruct = cbo7zStruct.SelectedIndex;
            Settings.rvSettings.Darkness = chkDarkMode.Checked;

            Settings.rvSettings.DoNotReportFeedback = chkDoNotReportFeedback.Checked;

            // Other setts
            var setts = Properties.Settings.Default;

            // Dats
            setts.RecognisedDatFormats.Clear();
            foreach (ListViewItem formatLvi in DatFormatsLV.Items)
            {
                setts.RecognisedDatFormats.Add(formatLvi.Text);
            }
            setts.DatImportMoveDontCopy = MoveDontCopyDatsChB.Checked;
            SetDatUrls();

            // Roms
            SetRomUrls();

            // File Ops
            setts.RomImportMoveNotCopy = MoveFilesNotCopyChB.Checked;
            setts.RomRelocateDeleteOriginal = DeleteOrigRomsRelocateChB.Checked;
            Settings.rvSettings.PreserveEmptyRomFolders = PreserveEmptyRomFoldersChB.Checked;
            Settings.rvSettings.UseRootedPaths = UseRootedPathsChB.Checked;

            // UI and UX
            setts.MainTextSize = (int)MainTextSizeNUM.Value;
            setts.InfoTextColor = InfoTextColorPB.BackColor;
            setts.EnableGamesGridRClick = EnableGamesGridRClickChB.Checked;
            setts.StatusIconSize = (int)StatusIconSizeNUM.Value;
            setts.StatusIconSizeAuto = StatusIconSizeAutoChB.Checked;

            setts.RomGotColor = RomsFixableLB.ForeColor;
            setts.RomGotColor = RomsGotLB.ForeColor;
            setts.RomMissingColor = RomsMissingLB.ForeColor;
            setts.RomUnknownColor = RomsUnknownLB.ForeColor;
            setts.AutoCloseProgressWindow = AutoCloseProgressChB.Checked;

            mainForm.UpdateThemeAndControls();

            setts.Save();
        }

        private void SetupControls()
        {
            cboFixLevel.Items.Clear();
            cboFixLevel.Items.Add("Level 1 - Fast copy Match on CRC");
            cboFixLevel.Items.Add("Level 2 - Fast copy if SHA1 scanned");
            cboFixLevel.Items.Add("Level 3 - Uncompress/Hash/Compress");

            cboCores.Items.Add("Auto");
            for (int i = 1; i <= 64; i++)
                cboCores.Items.Add(i.ToString());

            cbo7zStruct.Items.Add("LZMA Solid - rv7z");
            cbo7zStruct.Items.Add("LZMA Non-Solid");
            cbo7zStruct.Items.Add("ZSTD Solid");
            cbo7zStruct.Items.Add("ZSTD Non-Solid");

            lblDATRoot.Text = Settings.rvSettings.DatRoot;

            cboFixLevel.SelectedIndex = (int)Settings.rvSettings.FixLevel;

            textBox1.Text = "";
            foreach (string file in Settings.rvSettings.IgnoreFiles)
            {
                textBox1.Text += file + Environment.NewLine;
            }

            MainTC.HideTabs = true;
            TvPaddingPN.BackColor = MainTV.BackColor;

            InfoTextExampleLB.ForeColor = Properties.Settings.Default.InfoTextColor;
        }

        private void StatusIconSizeAutoChB_CheckedChanged(object sender, EventArgs e)
        {
            if (!_shown) return;
            StatusIconSizeNUM.Enabled = !StatusIconSizeAutoChB.Checked;
            UpdateStatusBar();
        }

        private void StatusIconSizeNUM_ValueChanged(object sender, EventArgs e)
        {
            if (!_shown) return; // avoid trying to update status bar before form is shown and controls are fully loaded
            UpdateStatusBar();
        }

        private void UpdateStatusBar()
        {
            // 1. Stop the Form from painting at the Windows message level
            SendMessage(this.Handle, WM_SETREDRAW, false, 0);

            try
            {
                int newSize = (int)StatusIconSizeNUM.Value;

                if (StatusIconSizeAutoChB.Checked)
                {
                    newSize = TextRenderer.MeasureText("Dummy", this.Font).Height;
                }

                MainSS.ImageScalingSize = new Size(newSize, newSize);

                MainSS.Items.Clear();
                MainSS.Items.Add(new ToolStripLabel()
                {
                    Image = Properties.Resources.information_frame,
                    Text = "Version",
                    Padding = new Padding(4, 4, 4, 4)
                });

                MainSS.PerformLayout();
            }
            finally
            {
                // 2. Re-enable painting and force a clean redraw
                SendMessage(this.Handle, WM_SETREDRAW, true, 0);
                this.Refresh();
            }
        }

        /// <summary>
        /// Need to do this in form, because Set DAT Root refences this setting.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UseRootedPathsChB_CheckedChanged(object sender, EventArgs e)
        {
            Settings.rvSettings.UseRootedPaths = UseRootedPathsChB.Checked;
            Settings.WriteConfig(Settings.rvSettings);
        }

        private void AddRomSourceBT_Click(object sender, EventArgs e)
        {
            _romSourceUrls.Add(new RomSourceUrl { Name = "{new source}", Url = "http://example.com/roms" });
        }

        private void DeleteRomSourceBT_Click(object sender, EventArgs e)
        {
            _romSourceUrls.Remove(_romSourceUrls.FirstOrDefault(url => url.Name == RomSourceLinksDGV.CurrentRow.Cells["Name"].Value.ToString()));
        }
    }
}