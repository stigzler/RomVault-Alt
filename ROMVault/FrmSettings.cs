/******************************************************
 *     ROMVault3 is written by Gordon J.              *
 *     Contact gordon@romvault.com                    *
 *     Copyright 2025                                 *
 ******************************************************/

using RomVaultCore;
using RomVaultCore.Utils;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ROMVault
{
    public partial class FrmSettings : Form
    {
        private FrmMain mainForm;

        public FrmSettings(FrmMain mainForm)
        {
            InitializeComponent();

            this.mainForm = mainForm;

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

            if (Settings.rvSettings.Darkness)
                Dark.dark.SetColors(this);

            MainTC.HideTabs = true;
            TvPaddingPN.BackColor = MainTV.BackColor;
        }

        private void FrmConfigLoad(object sender, EventArgs e)
        {
            lblDATRoot.Text = Settings.rvSettings.DatRoot;
            cboFixLevel.SelectedIndex = (int)Settings.rvSettings.FixLevel;

            textBox1.Text = "";
            foreach (string file in Settings.rvSettings.IgnoreFiles)
            {
                textBox1.Text += file + Environment.NewLine;
            }
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
            // DATs
            foreach (var format in Properties.Settings.Default.RecognisedDatFormats)
                DatFormatsLV.Items.Add(new ListViewItem() { Text = format });
            MoveDontCopyDatsChB.Checked = Properties.Settings.Default.DatImportMoveDontCopy;

            // File OPs
            MoveFilesNotCopyChB.Checked = Properties.Settings.Default.RomImportMoveNotCopy;

            // UI and UX
            MainTextSizeNUM.Value = Properties.Settings.Default.MainTextSize;
            InfoTextColorPB.BackColor = Properties.Settings.Default.InfoTextColor;
            EnableGamesGridRClickChB.Checked = Properties.Settings.Default.EnableGamesGridRClick;
            StatusIconSizeNUM.Value = Properties.Settings.Default.StatusIconSize;
            StatusIconSizeAutoChB.Checked = Properties.Settings.Default.StatusIconSizeAuto;
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnOkClick(object sender, EventArgs e)
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

            SaveSettings();

            Close();
        }

        private void SaveSettings()
        {
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

            Settings.WriteConfig(Settings.rvSettings);

            // Dats
            Properties.Settings.Default.RecognisedDatFormats.Clear();
            foreach (ListViewItem formatLvi in DatFormatsLV.Items)
            {
                Properties.Settings.Default.RecognisedDatFormats.Add(formatLvi.Text);
            }
            Properties.Settings.Default.DatImportMoveDontCopy = MoveDontCopyDatsChB.Checked;

            // File Ops
            Properties.Settings.Default.RomImportMoveNotCopy = MoveFilesNotCopyChB.Checked;

            // UI and UX
            Properties.Settings.Default.MainTextSize = (int)MainTextSizeNUM.Value;
            Properties.Settings.Default.InfoTextColor = InfoTextColorPB.BackColor;
            Properties.Settings.Default.EnableGamesGridRClick = EnableGamesGridRClickChB.Checked;
            Properties.Settings.Default.StatusIconSize = (int)StatusIconSizeNUM.Value;
            Properties.Settings.Default.StatusIconSizeAuto = StatusIconSizeAutoChB.Checked;

            Properties.Settings.Default.Save();
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

            lblDATRoot.Text = RelativePath.MakeRelative(AppDomain.CurrentDomain.BaseDirectory, browse.SelectedPath);
        }

        private void chkSendFoundMIA_CheckedChanged(object sender, EventArgs e)
        {
            chkSendFoundMIAAnon.Enabled = chkSendFoundMIA.Checked;
        }

        private void InfoTextColorPB_Click(object sender, EventArgs e)
        {
            var result = ColorBroswer.ShowDialog();
            if (result != DialogResult.OK) return;
            Properties.Settings.Default.InfoTextColor = ColorBroswer.Color;
            InfoTextColorPB.BackColor = ColorBroswer.Color;
            mainForm.UpdateThemeAndControls();
        }

        private void MainTextSizeNUM_ValueChanged(object sender, EventArgs e)
        {
            //this.Font = new System.Drawing.Font(this.Font.FontFamily, (float)MainTextSizeNUM.Value);
            Properties.Settings.Default.MainTextSize = (int)MainTextSizeNUM.Value;
            //mainForm.UpdateThemeAndControls();
        }

        // Call this after InitializeComponent()
        private void HideTabControlTabs(TabControl tab)
        {
            tab.Multiline = true;                // allow small fixed tabs
            tab.SizeMode = TabSizeMode.Fixed;
            tab.ItemSize = new Size(0, 1);       // very small tab header
            tab.Padding = new Point(0, 0);
            tab.TabStop = false;
        }

        private void FrmSettings_Shown(object sender, EventArgs e)
        {
            //TvPaddingPN.BackColor = MainTV.BackColor;
        }

        private void MainTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MainTC.SelectedTab = MainTC.TabPages[e.Node.Name.Replace("TVI", "TP")];
        }

        private void AddDatFormatBT_Click(object sender, EventArgs e)
        {
            DatFormatsLV.Items.Add("{click to edit}");
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

        private void StatusIconSizeAutoChB_CheckedChanged(object sender, EventArgs e)
        {
            StatusIconSizeNUM.Enabled = !StatusIconSizeAutoChB.Checked;
        }
    }
}