/******************************************************
 *     ROMVault3 is written by Gordon J.              *
 *     Contact gordon@romvault.com                    *
 *     Copyright 2025                                 *
 ******************************************************/

using Dark;
using Dark.Renderers;
using DATReader.DatStore;
using DATReader.DatWriter;
using ROMVault.Extensions;
using ROMVault.Helpers;
using ROMVault.ViewModels;
using RomVaultCore;
using RomVaultCore.Extensions;
using RomVaultCore.ReadDat;
using RomVaultCore.RvDB;
using RomVaultCore.Scanner;
using RomVaultCore.Utils;
using RVIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TrrntZipUI;

namespace ROMVault
{
    public partial class FrmMain : Form
    {
        private static readonly Color CBlue = Color.FromArgb(214, 214, 255);
        private static readonly Color CGreyBlue = Color.FromArgb(214, 224, 255);
        private static readonly Color CRed = Color.FromArgb(255, 214, 214);
        private static readonly Color CBrightRed = Color.FromArgb(255, 0, 0);
        private static readonly Color CGreen = Color.FromArgb(214, 255, 214);
        private static readonly Color CNeonGreen = Color.FromArgb(100, 255, 100);
        private static readonly Color CLightRed = Color.FromArgb(255, 235, 235);
        private static readonly Color CSoftGreen = Color.FromArgb(150, 200, 150);
        private static readonly Color CGrey = Color.FromArgb(214, 214, 214);
        private static readonly Color CCyan = Color.FromArgb(214, 255, 255);
        private static readonly Color CCyanGrey = Color.FromArgb(214, 225, 225);
        private static readonly Color CMagenta = Color.FromArgb(255, 214, 255);
        private static readonly Color CBrown = Color.FromArgb(140, 80, 80);
        private static readonly Color CPurple = Color.FromArgb(214, 140, 214);
        private static readonly Color CYellow = Color.FromArgb(255, 255, 214);
        private static readonly Color CDarkYellow = Color.FromArgb(255, 255, 100);
        private static readonly Color COrange = Color.FromArgb(255, 214, 140);
        private static readonly Color CWhite = Color.FromArgb(255, 255, 255);
        private static int[] _gameGridColumnXPositions;

        private readonly Color[] _displayColor;
        private readonly Color[] _fontColor;

        private readonly ContextMenuStrip _mnuContext = new ContextMenuStrip().DarkCompliant();
        private readonly ContextMenuStrip _mnuContextToSort = new ContextMenuStrip().DarkCompliant();

        private readonly ToolStripMenuItem _mnuOpen;

        private readonly ToolStripMenuItem _mnuToSortImportRomFiles;
        private readonly ToolStripMenuItem _mnuToSortImportRomFolders;
        private readonly ToolStripMenuItem _mnuToSortOpen;
        private readonly ToolStripMenuItem _mnuToSortDelete;
        private readonly ToolStripSeparator _mnuToSortConditionalSeparator;
        private readonly ToolStripMenuItem _mnuToSortSetPrimary;
        private readonly ToolStripMenuItem _mnuToSortSetCache;
        private readonly ToolStripMenuItem _mnuToSortSetFileOnly;
        private readonly ToolStripMenuItem _mnuToSortClearFileOnly;
        private readonly ToolStripMenuItem _mnuToSortUp;
        private readonly ToolStripMenuItem _mnuToSortDown;
        private readonly ToolStripMenuItem _mnuToSortLock;

        private RvFile _clickedTree;

        private bool _updatingGameGrid;

        private FrmKey _fk;

        private float _scaleFactorX = 1;
        private float _scaleFactorY = 1;

        private bool _shown = false;

        private ToolStripMenuItem garbageCollectToolStripMenuItem;

        private Dictionary<Button, string> NavButtonDetails = new Dictionary<Button, string>();

        // For the Status Strip Key System
        private List<ToolStripStatusLabel> romStatusStripKeys = new List<ToolStripStatusLabel>();

        private List<ToolStripStatusLabel> datStatusStripKeys = new List<ToolStripStatusLabel>();
        private List<ToolStrip> FormToolstrips;
        private List<ToolStripMenuItem> FilterCheckboxes;
        private List<ContextMenuStrip> ContextMenuStrips;

        private DatInfo DatInfo = new DatInfo() { Name = "No DAT Selected" };
        private GameInfo GameInfo = new GameInfo() { Name = "None Selected" };

        #region MainUISetup

        public FrmMain()
        {
            InitializeComponent();

            SetupControlLists(); // used in UI management

            //Theming.SetFormTextSizeToDefault(this);

            AddGameMetaData();
            //Text = $@"RomVault ({Program.strVersion}) {Application.StartupPath}";
            Text = $@"RomVault ({Program.strVersion})";

            Type dgvType = GameGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(GameGrid, true, null);

            dgvType = RomGrid.GetType();
            pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(RomGrid, true, null);

            _displayColor = new Color[(int)RepStatus.EndValue];
            _fontColor = new Color[(int)RepStatus.EndValue];

            darkModeToolStripMenuItem.Checked = Settings.rvSettings.Darkness;

            // RepStatus.UnSet

            _displayColor[(int)RepStatus.UnScanned] = CBlue;

            _displayColor[(int)RepStatus.DirCorrect] = CGreen;
            _displayColor[(int)RepStatus.DirMissing] = CRed;
            _displayColor[(int)RepStatus.DirCorrupt] = CBrightRed; //BrightRed

            _displayColor[(int)RepStatus.Missing] = CRed;
            _displayColor[(int)RepStatus.Correct] = CGreen;
            _displayColor[(int)RepStatus.CorrectMIA] = CNeonGreen;
            _displayColor[(int)RepStatus.NotCollected] = CGrey;
            _displayColor[(int)RepStatus.UnNeeded] = CCyanGrey;
            _displayColor[(int)RepStatus.Unknown] = CCyan;
            _displayColor[(int)RepStatus.InToSort] = CMagenta;

            _displayColor[(int)RepStatus.MissingMIA] = CSoftGreen;

            _displayColor[(int)RepStatus.Corrupt] = CBrightRed; //BrightRed
            _displayColor[(int)RepStatus.Ignore] = CGreyBlue;

            _displayColor[(int)RepStatus.CanBeFixed] = CYellow;
            _displayColor[(int)RepStatus.CanBeFixedMIA] = CDarkYellow;
            _displayColor[(int)RepStatus.MoveToSort] = CPurple;
            _displayColor[(int)RepStatus.Delete] = CBrown;
            _displayColor[(int)RepStatus.NeededForFix] = COrange;
            _displayColor[(int)RepStatus.Rename] = COrange;

            _displayColor[(int)RepStatus.CorruptCanBeFixed] = CYellow;
            _displayColor[(int)RepStatus.MoveToCorrupt] = CPurple; //Missing

            _displayColor[(int)RepStatus.Incomplete] = CLightRed;

            _displayColor[(int)RepStatus.Deleted] = CWhite;

            for (int i = 0; i < (int)RepStatus.EndValue; i++)
            {
                _fontColor[i] = Contrasty(_displayColor[i]);
            }
            _gameGridColumnXPositions = new int[(int)RepStatus.EndValue];

            ctrRvTree.Setup(ref DB.DirRoot);

            splitContainer4_Panel1_Resize(new object(), new EventArgs());

            ToolStripMenuItem mnuScan1 = new ToolStripMenuItem
            {
                Text = @"Scan Quick (Headers Only)",
                Tag = EScanLevel.Level1
            };
            ToolStripMenuItem mnuScan2 = new ToolStripMenuItem
            {
                Text = @"Scan ROMs",
                Image = Properties.Resources.arrowCircle,
                Tag = EScanLevel.Level2
            };
            ToolStripMenuItem mnuScan3 = new ToolStripMenuItem
            {
                Text = @"Scan Full (Complete Re-Scan)",
                Tag = EScanLevel.Level3
            };

            ToolStripMenuItem mnuDirDatSettings = new ToolStripMenuItem
            {
                Text = @"Set Dir Dat Settings",
                Image = Properties.Resources.folder__pencil,
                Tag = null
            };

            ToolStripMenuItem mnuDirMappings = new ToolStripMenuItem
            {
                Text = @"Set ROM Folder",
                Tag = null
            };

            ToolStripMenuItem _mnuLock = new ToolStripMenuItem
            {
                Text = @"Lock Item",
                Image = Properties.Resources._lock,
                Tag = null
            };

            _mnuOpen = new ToolStripMenuItem
            {
                Text = @"Open ROMs Folder",
                Image = Properties.Resources.folder_open,
                Tag = null
            };

            ToolStripMenuItem mnuFixDat = new ToolStripMenuItem
            {
                Text = @"Save fix DATs",
                Image = Properties.Resources.database_export,
                Tag = null
            };

            ToolStripMenuItem mnuMakeDat = new ToolStripMenuItem
            {
                Text = @"Save full DAT",
                Tag = null
            };

            ToolStripMenuItem mnuImportToThisDir = new ToolStripMenuItem
            {
                Text = @"Import DAT/s to this Directory",
                Image = Properties.Resources.database__plus,
                Tag = null
            };

            ToolStripMenuItem mnuImportToPickedDir = new ToolStripMenuItem
            {
                Text = @"Import DAT/s to chosen Directory",
                Tag = null
            };

            _mnuContext.Items.Add(mnuScan2);
            _mnuContext.Items.Add(mnuScan1);
            _mnuContext.Items.Add(mnuScan3);
            _mnuContext.Items.Add(new ToolStripSeparator());
            _mnuContext.Items.Add(_mnuOpen);
            _mnuContext.Items.Add(_mnuLock);
            _mnuContext.Items.Add(mnuDirDatSettings);
            _mnuContext.Items.Add(mnuDirMappings);
            _mnuContext.Items.Add(new ToolStripSeparator());
            _mnuContext.Items.Add(mnuFixDat);
            _mnuContext.Items.Add(mnuMakeDat);
            _mnuContext.Items.Add(new ToolStripSeparator());
            _mnuContext.Items.Add(mnuImportToThisDir);
            _mnuContext.Items.Add(mnuImportToPickedDir);

            mnuScan1.Click += MnuScan;
            mnuScan2.Click += MnuScan;
            mnuScan3.Click += MnuScan;
            mnuDirDatSettings.Click += MnuDirSettings;
            mnuDirMappings.Click += MnuDirMappings;
            _mnuLock.Click += MnuLockClick;
            _mnuOpen.Click += MnuOpenClick;
            mnuFixDat.Click += MnuMakeFixDatClick;
            mnuMakeDat.Click += MnuMakeDatClick;
            mnuImportToThisDir.Click += MnuImportToThisDir;
            mnuImportToPickedDir.Click += MnuImportToPickedDir;

            //_mnuContextToSort.ShowCheckMargin = false;
            //_mnuContextToSort.ShowImageMargin = false;

            ToolStripMenuItem mnuToSortScan1 = new ToolStripMenuItem
            {
                Text = @"Scan Quick (Headers Only)",
                Tag = EScanLevel.Level1
            };
            ToolStripMenuItem mnuToSortScan2 = new ToolStripMenuItem
            {
                Text = @"Scan ROM Files",
                Image = Properties.Resources.magnifier_zoom,
                Tag = EScanLevel.Level2
            };
            ToolStripMenuItem mnuToSortScan3 = new ToolStripMenuItem
            {
                Text = @"Scan Full (Complete Re-Scan)",
                Tag = EScanLevel.Level3
            };

            _mnuToSortOpen = new ToolStripMenuItem
            {
                Text = @"Open ToSort Directory",
                Image = Properties.Resources.blue_folder_open,
                Tag = null
            };

            _mnuToSortImportRomFiles = new ToolStripMenuItem
            {
                Text = @"Import Rom File/s",
                Image = Properties.Resources.disc__plus,
                Tag = null
            };

            _mnuToSortImportRomFolders = new ToolStripMenuItem
            {
                Text = @"Import Rom Folder/s",
                Tag = null
            };

            _mnuToSortDelete = new ToolStripMenuItem
            {
                Text = @"Remove",
                Image = Properties.Resources.cross,
                Tag = null
            };

            _mnuToSortConditionalSeparator = new ToolStripSeparator() { Visible = false };

            _mnuToSortSetPrimary = new ToolStripMenuItem
            {
                Text = @"Set As Primary ToSort",
                Image = Properties.Resources.blue_folder_stamp,
                Tag = null
            };

            _mnuToSortSetCache = new ToolStripMenuItem
            {
                Text = @"Set As Cache ToSort",
                Tag = null
            };

            _mnuToSortSetFileOnly = new ToolStripMenuItem
            {
                Text = @"Set As File Only ToSort",
                Tag = null
            };

            _mnuToSortClearFileOnly = new ToolStripMenuItem
            {
                Text = @"Clear File Only ToSort",
                Tag = null
            };

            _mnuToSortUp = new ToolStripMenuItem
            {
                Text = @"Move Up",
                Image = Properties.Resources.arrowUp,
                Tag = null
            };

            _mnuToSortDown = new ToolStripMenuItem
            {
                Text = @"Move Down",
                Image = Properties.Resources.arrowDown,
                Tag = null
            };

            _mnuToSortLock = new ToolStripMenuItem
            {
                Text = @"Lock ToSort",
                Image = Properties.Resources._lock,
                Tag = null
            };

            _mnuContextToSort.Items.Add(_mnuToSortOpen);
            _mnuContextToSort.Items.Add(_mnuToSortLock);
            _mnuContextToSort.Items.Add(new ToolStripSeparator());
            _mnuContextToSort.Items.Add(mnuToSortScan2);
            _mnuContextToSort.Items.Add(mnuToSortScan1);
            _mnuContextToSort.Items.Add(mnuToSortScan3);
            _mnuContextToSort.Items.Add(new ToolStripSeparator());
            _mnuContextToSort.Items.Add(_mnuToSortUp);
            _mnuContextToSort.Items.Add(_mnuToSortDown);
            _mnuContextToSort.Items.Add(_mnuToSortDelete);
            _mnuContextToSort.Items.Add(_mnuToSortConditionalSeparator); // visibility=all 4 items below are also visible
            _mnuContextToSort.Items.Add(_mnuToSortSetPrimary);
            _mnuContextToSort.Items.Add(_mnuToSortSetCache);
            _mnuContextToSort.Items.Add(_mnuToSortSetFileOnly);
            _mnuContextToSort.Items.Add(_mnuToSortClearFileOnly);
            _mnuContextToSort.Items.Add(new ToolStripSeparator());
            _mnuContextToSort.Items.Add(_mnuToSortImportRomFiles);
            _mnuContextToSort.Items.Add(_mnuToSortImportRomFolders);

            mnuToSortScan1.Click += MnuScan;
            mnuToSortScan2.Click += MnuScan;
            mnuToSortScan3.Click += MnuScan;
            _mnuToSortImportRomFiles.Click += MnuImportRomFiles;
            _mnuToSortImportRomFolders.Click += MnuImportRomFolders;
            _mnuToSortOpen.Click += MnuToSortOpen;
            _mnuToSortDelete.Click += MnuToSortDelete;
            _mnuToSortSetPrimary.Click += MnuToSortSetPrimary;
            _mnuToSortSetCache.Click += MnuToSortSetCache;
            _mnuToSortSetFileOnly.Click += MnuToSortSetFileOnly;
            _mnuToSortClearFileOnly.Click += MnuToSortClearFileOnly;
            _mnuToSortUp.Click += MnuToSortUp;
            _mnuToSortDown.Click += MnuToSortDown;
            _mnuToSortLock.Click += ToSortLock;

            chkBoxShowCompleteTSI.Checked = Settings.rvSettings.chkBoxShowComplete;
            chkBoxShowPartialTSI.Checked = Settings.rvSettings.chkBoxShowPartial;
            chkBoxShowFixesTSI.Checked = Settings.rvSettings.chkBoxShowFixes;
            chkBoxShowMIATSI.Checked = Settings.rvSettings.chkBoxShowMIA;
            chkBoxShowMergedTSI.Checked = Settings.rvSettings.chkBoxShowMerged;
            //chkBoxShowEmptyTSI.Checked = Settings.rvSettings.chkBoxShowEmpty;   // i think this one may have been missed off? not sure if operaiotnal decision?

            TabArtworkInitialize();

            //SetButtonPosLeft();

            tooltip.SetToolTip(btnDefault1, "Right Click: Save Tree Settings\nLeft Click: Load Tree Settings");
            tooltip.SetToolTip(btnDefault2, "Right Click: Save Tree Settings\nLeft Click: Load Tree Settings");
            tooltip.SetToolTip(btnDefault3, "Right Click: Save Tree Settings\nLeft Click: Load Tree Settings");
            tooltip.SetToolTip(btnDefault4, "Right Click: Save Tree Settings\nLeft Click: Load Tree Settings");

            tooltip.SetToolTip(btnUpdateDats, "Left Click: Dat Update\nShift Left Click: Full Dat Rescan\n\nRight Click: Open DatVault");
            tooltip.SetToolTip(btnFixFiles, "Left Click: Fix Files\nRight Click: Scan / Find Fix / Fix");

#if DEBUG
            garbageCollectToolStripMenuItem.Name = "garbageCollectToolStripMenuItem";
            garbageCollectToolStripMenuItem.Size = new Size(186, 22);
            garbageCollectToolStripMenuItem.Text = "Garbage Collect";
            garbageCollectToolStripMenuItem.Click += new EventHandler(this.garbageCollectToolStripMenuItem_Click_1);
            helpToolStripMenuItem.DropDownItems.Add(garbageCollectToolStripMenuItem);
#endif

            InitGameGridMenu();

            UpdateThemeAndControls();
        }

        private void SetupControlLists()
        {
            // Control Lists
            FilterCheckboxes = new List<ToolStripMenuItem>()
            { chkBoxShowCompleteTSI, chkBoxShowPartialTSI,chkBoxShowEmptyTSI, chkBoxShowFixesTSI, chkBoxShowMIATSI, chkBoxShowMergedTSI };

            FormToolstrips = new List<ToolStrip>() { GameRomTableTS, DatsTS };

            ContextMenuStrips = new List<ContextMenuStrip>()
            { CopyTextCMS, _mnuContext, _mnuContextToSort, _mnuGameGrid};
        }

        private void MnuImportToPickedDir(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles User Imports of dat files to the selected DAT dir        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MnuImportToThisDir(object sender, EventArgs e)
        {
            // These used to detemrine the correct method to select the right DAT path
            bool datFilePresent = _clickedTree.Dat != null ? true : false;
            string datTreeFullName = _clickedTree.DatTreeFullName;
            string resolvedDatRoot = RvSystems.GetFullyQualifiedPath(Settings.rvSettings.DatRoot);

            // Set destination path depending on datTreeFullName + datFilePresent combinations.
            string destinationPath;
            if (datTreeFullName == "DatRoot")
            {
                destinationPath = resolvedDatRoot;
            }
            else if (datFilePresent)
            {
                destinationPath = System.IO.Directory.GetParent(
                    RvSystems.ResolveTokenisedDatPath(datTreeFullName, resolvedDatRoot)).FullName;
            }
            else
            {
                destinationPath = RvSystems.ResolveTokenisedDatPath(datTreeFullName, resolvedDatRoot);
            }

            // now construct the filter list for the file select browser.
            // constructed from User Settings, the defualts of which are based on the hard coded default dat types
            // Put in User settings in case others add new dat types, or if users want to remove some of the default ones.
            // Future devs can update the list by editing the Defualt setting of: RecognisedDatFormats
            var formats = Properties.Settings.Default.RecognisedDatFormats?.Cast<string>().ToList();
            if (formats == null || formats.Count == 0)
            {
                // urgh ugly messageBox. But, priorities my dear boy... Shouldn't happen too often.
                MessageBox.Show("No recognized DAT formats are set. Please set these in the settings menu before importing.", "No Recognised Formats", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string combinedPattern = string.Join(";", formats.Select(f => "*." + f));
            string combinedLabel = string.Join(", ", formats.Select(f => "." + f));
            StringBuilder sb = new StringBuilder($"Supported DATs ({combinedLabel})|{combinedPattern}");

            foreach (string format in formats)
            {
                sb.Append($"|{format} files (*.{format})|*.{format}");
            }

            // Now present the file browser
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Please select DAT files to import.",
                Multiselect = true,
                Filter = sb.ToString()
            };

            var result = ofd.ShowDialog(this);
            if (result != DialogResult.OK) return;

            // Copy the files to the destination folder using Shell
            if (Properties.Settings.Default.DatImportMoveDontCopy)
                Helpers.FileSystem.MoveFiles(ofd.FileNames.ToList(), destinationPath, Settings.rvSettings.Darkness);
            else
                Helpers.FileSystem.CopyFiles(ofd.FileNames.ToList(), destinationPath, Settings.rvSettings.Darkness);

            UpdateDats();
        }

        private void MnuLockClick(object sender, EventArgs e)
        {
            _clickedTree.Tree.SetChecked(RvTreeRow.TreeSelect.Locked, true);
            ctrRvTree.Refresh();
        }

        private void ToSortLock(object sender, EventArgs e)
        {
            // bit of guesswork here - _working in this class I'm hoping corresponds to Working in rvTree, i think.
            // it's all a bit baffling
            // last paramter - if set to true - it just doesn't set it to locked with nothing else.
            // See rvTree.SetCheckedRecurse
            _clickedTree.Tree.SetChecked(RvTreeRow.TreeSelect.Locked, true);
            ctrRvTree.Refresh();
        }

        private void MnuImportRomFiles(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Please select ROM files to import.",
                Multiselect = true,
                Filter = "All Files|*.*"
            };
            var result = ofd.ShowDialog(this);

            if (result != DialogResult.OK) return;

            string folderName = _clickedTree.FullName;
            string tDir = Helpers.FileSystem.NormalizePath(NameFix.AddLongPathPrefix(folderName));
            if (!Directory.Exists(tDir)) return;

            if (Properties.Settings.Default.RomImportMoveNotCopy)
                Helpers.FileSystem.MoveFiles(ofd.FileNames.ToList(), tDir, Settings.rvSettings.Darkness);
            else
                Helpers.FileSystem.CopyFiles(ofd.FileNames.ToList(), tDir, Settings.rvSettings.Darkness);

            ScanRoms(EScanLevel.Level2);
        }

        private void MnuImportRomFolders(object sender, EventArgs e)
        {
            UserControls.FolderBrowserDialog fbd = new UserControls.FolderBrowserDialog()
            {
                Description = "Please select ROM folders to import.",
                Multiselect = true,
                OkButtonLabel = "Import"
            };
            var result = fbd.ShowDialog(this);
            if (result != true) return;

            string folderName = _clickedTree.FullName;
            string tDir = Helpers.FileSystem.NormalizePath(NameFix.AddLongPathPrefix(folderName));
            if (!Directory.Exists(tDir)) return;

            if (Properties.Settings.Default.RomImportMoveNotCopy)
                Helpers.FileSystem.MoveFiles(fbd.SelectedPaths.ToList(), tDir, Settings.rvSettings.Darkness);
            else
                Helpers.FileSystem.CopyFiles(fbd.SelectedPaths.ToList(), tDir, Settings.rvSettings.Darkness);

            ScanRoms(EScanLevel.Level2);
        }

        private void UpdateTextBoxes(Control c, Color primaryUpdateColor)
        {
            foreach (Control c1 in c.Controls)
                UpdateTextBoxes(c1, primaryUpdateColor);

            switch (c)
            {
                case TextBox tb:
                    //tb.Height = 40;
                    tb.ForeColor = primaryUpdateColor;
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    break;
            }
        }

        /// <summary>
        /// This happens before form is shown. If post-show teaks are needed use FrmMain_Shown
        /// </summary>
        internal void UpdateThemeAndControls(bool settingsUpdated = false)
        {
            this.Font = new System.Drawing.Font(this.Font.FontFamily, (float)Properties.Settings.Default.MainTextSize);

            Theming.SetControlTextSizeToDefault(menuStrip1);
            int iconSize = (int)(1.5 * Properties.Settings.Default.MainTextSize);
            menuStrip1.ImageScalingSize = new Size(iconSize, iconSize);

            foreach (ToolStrip ts in FormToolstrips)
            {
                Theming.SetControlTextSizeToDefault(ts);
                ts.ImageScalingSize = new Size(iconSize, iconSize);
            }

            foreach (ContextMenuStrip cms in ContextMenuStrips)
            {
                Theming.SetControlTextSizeToDefault(cms);
                cms.ImageScalingSize = new Size(iconSize, iconSize);
            }
            dark.SetColors(CopyTextCMS, Settings.rvSettings.Darkness);

            dark.SetColors(this, Settings.rvSettings.Darkness);

            if (settingsUpdated)
            {
                MainPG.Invalidate();
                GameGrid.Invalidate();
                RomGrid.Invalidate();
            }

            // Dat Tree
            ctrRvTree.UpdateFontSize(Properties.Settings.Default.MainTextSize);

            DatInfoNameLb.ForeColor = dark.GetForegroundDimmed(Settings.rvSettings.Darkness);
            DatInfoPathLb.ForeColor = dark.GetForegroundDimmed(Settings.rvSettings.Darkness);

            // Dats Roms Status Tags
            var setts = Properties.Settings.Default;
            RomsGotLB.ForeColor = setts.RomGotColor;
            RomsMissingLB.ForeColor = setts.RomMissingColor;
            RomsFixableLB.ForeColor = setts.RomFixableColor;
            RomsUnknownLB.ForeColor = setts.RomUnknownColor;
        }

        internal void InitialiseStatusStrip()
        {
            MainSS.Font = this.Font;

            if (Properties.Settings.Default.StatusIconSizeAuto)
            {
                int fontHeight = TextRenderer.MeasureText("Dummy", this.Font).Height;
                MainSS.ImageScalingSize = new Size(fontHeight, fontHeight);
            }
            else
                MainSS.ImageScalingSize = new Size(Properties.Settings.Default.StatusIconSize, Properties.Settings.Default.StatusIconSize);

            int i = 2;

            // Add Game Status Icons to StatusStrip at position 2 (skips the i icon and the db icon at the bottom).
            foreach (KeyValuePair<DatTreeStatus, string> kvp in Constants.UI.DatTreeStatusText)
            {
                DatTreeStatus datTreeStatus = kvp.Key;

                ToolStripStatusLabel lbl = new ToolStripStatusLabel
                {
                    Text = kvp.Key.ToString(),
                    Image = rvImages.GetBitmap(datTreeStatus.GetMetadata().ImageName),
                    ToolTipText = kvp.Value,
                    Padding = new Padding(0, 0, 2, 0),
                    DisplayStyle = ToolStripItemDisplayStyle.Image
                };
                lbl.MouseHover += Lbl_MouseHover;
                lbl.MouseLeave += Lbl_MouseLeave;
                //MainSS.Items.Add(lbl);
                MainSS.Items.Insert(i, lbl);
                datStatusStripKeys.Add(lbl);
                i++;
            }

            i += 1; //  skips the pre existing game category icon and prefixing separator in the statusbar

            // Add Game Status Icons to StatusStrip
            foreach (KeyValuePair<RepStatus, string> kvp in Constants.UI.RepStatusText)
            {
                ToolStripStatusLabel lbl = new ToolStripStatusLabel
                {
                    Text = kvp.Key.ToString(),
                    Image = rvImages.GetBitmap("G_" + kvp.Key),
                    ToolTipText = kvp.Value,
                    Padding = new Padding(0, 0, 1, 0),
                    DisplayStyle = ToolStripItemDisplayStyle.Image
                };
                lbl.MouseHover += Lbl_MouseHover;
                lbl.MouseLeave += Lbl_MouseLeave;
                //MainSS.Items.Add(lbl);
                MainSS.Items.Insert(i, lbl);
                romStatusStripKeys.Add(lbl);
                i++;
            }

            // this used later in tooltip display for left icon/control
            statusBarLeftTooltipHeight = TextRenderer.MeasureText(CollapseAllSSBT.ToolTipText, SystemFonts.StatusFont).Height;

            // Dark mode on status strip. ⚠️⚠️ IMPORTANT: This must be done AFTER   InitialiseStatusStrip(); ⚠️⚠️
            if (Settings.rvSettings.Darkness)
            {
                var darkRenderer = new DarkToolStripRenderer();
                MainSS.Renderer = darkRenderer;
                foreach (var item in MainSS.Items)
                {
                    if (item is ToolStripDropDownButton dropDownButton)
                    {
                        // Successfully identified
                        dropDownButton.DropDown.Renderer = darkRenderer;
                    }
                }
            }
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            tooltip.Hide(MainSS);
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            if (sender is ToolStripStatusLabel statusLabel)
            {
                string text = statusLabel.ToolTipText;
                if (string.IsNullOrEmpty(text)) return;

                // 1. Ensure the tooltip is in standard mode
                tooltip.IsBalloon = false;

                // 2. Measure the exact height and width of the multiline text
                Size textSize = TextRenderer.MeasureText(text, SystemFonts.MessageBoxFont);

                // 3. Set the X position to the left of the label
                int x = statusLabel.Bounds.Left;

                // 4. Check for right-edge collision against the StatusStrip's width
                // Add 10px for the tooltip's internal border padding
                if (x + textSize.Width + 10 > MainSS.Width)
                {
                    x = MainSS.Width - textSize.Width - 10;
                }

                // Safety check for the left edge
                if (x < 0) x = 5;

                // 5. Calculate Y so the bottom of the tooltip rests 5px above the bar
                // Since we are referencing 'MainSS', Y coordinates are relative to the top of the bar.
                // A negative Y value pushes it ABOVE the bar.
                int y = -textSize.Height - 5;

                tooltip.Show(text, MainSS, x, y);
            }
        }

        // returns either white or black, depending of quick luminance of the Color " a "

        // called when the _displayColor is finished, in order to populate the _fontColor table.
        private static Color Contrasty(Color a)
        {
            return (a.R << 1) + a.B + a.G + (a.G << 2) < 1024 ? Color.White : Color.Black;
        }

        public override sealed string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void splitContainer4_Panel1_Resize(object sender, EventArgs e)
        {
            // fixes a rendering issue in mono
            if (splitGameInfoLists.Panel1.Width == 0)
                return;
        }

        protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
        {
            base.ScaleControl(factor, specified);
            splitToolBarMain.SplitterDistance = (int)(splitToolBarMain.SplitterDistance * factor.Width);
            splitDatInfoGameInfo.SplitterDistance = (int)(splitDatInfoGameInfo.SplitterDistance * factor.Width);
            splitDatInfoGameInfo.Panel1MinSize = (int)(splitDatInfoGameInfo.Panel1MinSize * factor.Width);

            //splitDatInfoTree.SplitterDistance = (int)(splitDatInfoTree.SplitterDistance * factor.Height);
            splitGameInfoLists.SplitterDistance = (int)(splitGameInfoLists.SplitterDistance * factor.Height);

            _scaleFactorX *= factor.Width;
            _scaleFactorY *= factor.Height;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Properties.Settings.Default.SidebarSplitterDistance = splitToolBarMain.SplitterDistance;
            Properties.Settings.Default.DatGameSplitterDistance = splitDatInfoGameInfo.SplitterDistance;
            Properties.Settings.Default.GameInfoSplitterDistance = splitGameInfoLists.SplitterDistance;
            Properties.Settings.Default.RomListSplitterDistance = splitGameListRomList.SplitterDistance;
            Properties.Settings.Default.WindowPosition = this.Location;
            Properties.Settings.Default.WindowSize = this.Size;

            Properties.Settings.Default.Save();

            if (_working)
            {
                e.Cancel = true;
                return;
            }
        }

        #endregion

        #region Tree

        private void DirTreeRvChecked(object sender, MouseEventArgs e)
        {
            RepairStatus.ReportStatusReset(DB.DirRoot);
            DatSetSelected(ctrRvTree.Selected);
        }

        private void DirTreeRvSelected(object sender, MouseEventArgs e)
        {
            RvFile cf = (RvFile)sender;

            if (e.Button != MouseButtons.Right)
            {
                if (cf != gameGridSource)
                {
                    DatSetSelected(cf);
                }
                return;
            }

            if (cf != ctrRvTree.Selected)
            {
                DatSetSelected(cf);
            }

            _clickedTree = (RvFile)sender;

            if (_working)
                return;

            Point controLocation = ControlLoc(ctrRvTree);

            if (cf.IsInToSort)
            {
                _mnuToSortOpen.Enabled = Directory.Exists(_clickedTree.FullName);
                _mnuToSortDelete.Enabled = !(_clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortPrimary) || _clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortCache));

                _mnuToSortSetCache.Visible = !(_clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortCache) || _clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortFileOnly));
                _mnuToSortSetPrimary.Visible = !(_clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortPrimary) || _clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortFileOnly));
                _mnuToSortSetFileOnly.Visible = !(_clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortFileOnly) || _clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortPrimary) || _clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortCache));
                _mnuToSortClearFileOnly.Visible = _clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortFileOnly);

                // Made not sense. These were already added at cm creation and visibility toggled above. Unneccessary.
                //_mnuContextToSort.Items.Add(_mnuToSortSetPrimary);
                //_mnuContextToSort.Items.Add(_mnuToSortSetCache);
                //_mnuContextToSort.Items.Add(_mnuToSortSetFileOnly);
                //_mnuContextToSort.Items.Add(_mnuToSortClearFileOnly);

                int thisToSort = 0;
                for (int i = 0; i < DB.DirRoot.ChildCount; i++)
                {
                    if (DB.DirRoot.Child(i) == cf)
                    {
                        thisToSort = i;
                        break;
                    }
                }
                _mnuToSortUp.Enabled = thisToSort >= 2;
                _mnuToSortDown.Enabled = thisToSort <= DB.DirRoot.ChildCount - 2;

                _mnuContextToSort.Show(this, new Point(controLocation.X + e.X, controLocation.Y + e.Y));

                if (_mnuToSortSetPrimary.Visible
                       || _mnuToSortSetCache.Visible
                       || _mnuToSortSetFileOnly.Visible
                       || _mnuToSortClearFileOnly.Visible)
                {
                    _mnuToSortConditionalSeparator.Visible = true;
                }
                else
                {
                    _mnuToSortConditionalSeparator.Visible = false;
                }
            }
            else
            {
                _mnuOpen.Enabled = Directory.Exists(_clickedTree.FullName);
                //_mnuFile.Enabled = _clickedTree.Dat == null;
                _mnuContext.Show(this, new Point(controLocation.X + e.X, controLocation.Y + e.Y));
            }
        }

        private Point ControlLoc(Control c)
        {
            Point ret = new Point(c.Left, c.Top);

            if (c.Parent == this)
                return ret;

            Point pNext = ControlLoc(c.Parent);
            ret.X += pNext.X;
            ret.Y += pNext.Y;

            return ret;
        }

        #endregion

        #region popupMenus

        private void MnuScan(object sender, EventArgs e)
        {
            ScanRoms((EScanLevel)((ToolStripMenuItem)sender).Tag, _clickedTree);
        }

        private void MnuDirSettings(object sender, EventArgs e)
        {
            using (FrmDirectorySettings fDirSettings = new FrmDirectorySettings())
            {
                string tDir = _clickedTree.TreeFullName;
                fDirSettings.SetLocation(tDir);
                fDirSettings.SetDisplayType(true);
                fDirSettings.ShowDialog(this);

                if (fDirSettings.ChangesMade)
                    UpdateDats();
            }
        }

        private void MnuDirMappings(object sender, EventArgs e)
        {
            using (FrmDirectoryMappings fDirMappings = new FrmDirectoryMappings())
            {
                string tDir = _clickedTree.TreeFullName;
                fDirMappings.SetLocation(tDir);
                fDirMappings.SetDisplayType(true);
                fDirMappings.ShowDialog(this);
            }
        }

        private void MnuOpenClick(object sender, EventArgs e)
        {
            string tDir = _clickedTree.FullName;
            if (Directory.Exists(tDir))
                try { Process.Start(tDir); } catch { }
        }

        private void MnuMakeFixDatClick(object sender, EventArgs e)
        {
            MakeFixDat(_clickedTree, true);
        }

        private void MakeFixDat(RvFile baseDir, bool redOnly)
        {
            FolderBrowser browse = new FolderBrowser
            {
                ShowNewFolderButton = true,
                Description = @"Please select fixdat files destination. NOTE: " + (redOnly ? @"reports will include Missing && MIA items only (omitting any Fixable items that may be present)" : @"reports will include both Missing, MIA and Fixable items"),
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = Settings.rvSettings.FixDatOutPath
            };

            if (browse.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (!Directory.Exists(browse.SelectedPath))
            {
                MessageBox.Show("Output Directory Not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (browse.SelectedPath != Settings.rvSettings.FixDatOutPath)
            {
                Settings.rvSettings.FixDatOutPath = browse.SelectedPath;
                Settings.WriteConfig(Settings.rvSettings);
            }

            FixDatReport.RecursiveDatTree(Settings.rvSettings.FixDatOutPath, baseDir, redOnly);
        }

        private void MnuMakeDatClick(object sender, EventArgs e)
        {
            SaveFileDialog browse = new SaveFileDialog
            {
                Filter = "DAT file|*.dat",
                Title = "Save an Dat File",
                FileName = _clickedTree.Name
            };

            if (browse.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            if (browse.FileName == "")
            {
                return;
            }

            DatHeader dh = (new ExternalDatConverterTo()).ConvertToExternalDat(_clickedTree);
            DatXMLWriter.WriteDat(browse.FileName, dh);
        }

        private void MnuToSortOpen(object sender, EventArgs e)
        {
            string tDir = _clickedTree.FullName;
            if (Directory.Exists(tDir))
                try { Process.Start(tDir); } catch { }
        }

        private void MnuToSortDelete(object sender, EventArgs e)
        {
            for (int i = 0; i < DB.DirRoot.ChildCount; i++)
            {
                if (DB.DirRoot.Child(i) == _clickedTree)
                {
                    DB.DirRoot.ChildRemove(i);
                    RepairStatus.ReportStatusReset(DB.DirRoot);

                    ctrRvTree.Setup(ref DB.DirRoot);
                    DatSetSelected(DB.DirRoot.Child(i - 1));
                    DB.Write();
                    ctrRvTree.Refresh();
                    return;
                }
            }
        }

        private void MnuToSortSetPrimary(object sender, EventArgs e)
        {
            if (_clickedTree.Tree.Checked == RvTreeRow.TreeSelect.Locked)
            {
                _clickedTree.Tree.SetChecked(RvTreeRow.TreeSelect.Selected, true);
                //MessageBox.Show("Directory Must be ticked.", "RomVault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }

            RvFile t = DB.GetToSortPrimary();
            bool wasCache = t.ToSortStatusIs(RvFile.ToSortDirType.ToSortCache);
            t.ToSortStatusClear(RvFile.ToSortDirType.ToSortPrimary | RvFile.ToSortDirType.ToSortCache);

            _clickedTree.ToSortStatusSet(RvFile.ToSortDirType.ToSortPrimary);
            if (wasCache)
                _clickedTree.ToSortStatusSet(RvFile.ToSortDirType.ToSortCache);

            DB.Write();
            ctrRvTree.Refresh();
        }

        private void MnuToSortSetCache(object sender, EventArgs e)
        {
            if (_clickedTree.Tree.Checked == RvTreeRow.TreeSelect.Locked)
            {
                _clickedTree.Tree.SetChecked(RvTreeRow.TreeSelect.Selected, true);
                //MessageBox.Show("Directory Must be ticked.", "RomVault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }

            RvFile t = DB.GetToSortCache();
            t.ToSortStatusClear(RvFile.ToSortDirType.ToSortCache);

            _clickedTree.ToSortStatusSet(RvFile.ToSortDirType.ToSortCache);

            DB.Write();
            ctrRvTree.Refresh();
        }

        private void MnuToSortSetFileOnly(object sender, EventArgs e)
        {
            if (_clickedTree.Tree.Checked == RvTreeRow.TreeSelect.Locked)
            {
                _clickedTree.Tree.SetChecked(RvTreeRow.TreeSelect.Selected, true);
                //MessageBox.Show("Directory Must be ticked.", "RomVault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            if (_clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortPrimary))
            {
                MessageBox.Show("Primary Directory Cannot be File Only.", "RomVault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_clickedTree.ToSortStatusIs(RvFile.ToSortDirType.ToSortCache))
            {
                MessageBox.Show("Cache Directory Cannot be File Only.", "RomVault", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _clickedTree.ToSortStatusSet(RvFile.ToSortDirType.ToSortFileOnly);

            DB.Write();
            ctrRvTree.Refresh();
        }

        private void MnuToSortClearFileOnly(object sender, EventArgs e)
        {
            _clickedTree.ToSortStatusClear(RvFile.ToSortDirType.ToSortFileOnly);
            ctrRvTree.Setup(ref DB.DirRoot);
            DB.Write();
        }

        private void MnuToSortUp(object sender, EventArgs e)
        {
            DB.MoveToSortUp(_clickedTree);
            ctrRvTree.Setup(ref DB.DirRoot);
            DB.Write();
        }

        private void MnuToSortDown(object sender, EventArgs e)
        {
            DB.MoveToSortDown(_clickedTree);
            ctrRvTree.Setup(ref DB.DirRoot);
            DB.Write();
        }

        #endregion

        #region TopMenu

        private void updateNewDATsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            UpdateDats();
        }

        private void updateAllDATsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            DatUpdate.CheckAllDats(DB.DirRoot.Child(0), @"DatRoot\");
            UpdateDats();
        }

        private void TsmScanLevel1Click(object sender, EventArgs e)
        {
            if (_working) return;
            ScanRoms(EScanLevel.Level1);
        }

        private void TsmScanLevel2Click(object sender, EventArgs e)
        {
            if (_working) return;
            ScanRoms(EScanLevel.Level2);
        }

        private void TsmScanLevel3Click(object sender, EventArgs e)
        {
            if (_working) return;
            ScanRoms(EScanLevel.Level3);
        }

        private void RomVaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            using (FrmSettings fcfg = new FrmSettings(this))
            {
                fcfg.ShowDialog(this);
            }
        }

        private void DirectorySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            using (FrmDirectorySettings sd = new FrmDirectorySettings())
            {
                string tDir = "RomVault";
                sd.SetLocation(tDir);
                sd.SetDisplayType(false);
                sd.ShowDialog(this);

                if (sd.ChangesMade)
                    UpdateDats();
            }
        }

        private void directoryMappingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            using (FrmDirectoryMappings sd = new FrmDirectoryMappings())
            {
                string tDir = "RomVault";
                sd.SetLocation(tDir);
                sd.SetDisplayType(false);
                sd.ShowDialog(this);
            }
        }

        private void fixDatReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            MakeFixDat(DB.DirRoot.Child(0), true);
        }

        private void fullReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            Report.GenerateReport();
        }

        private void fixReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            Report.GenerateFixReport();
        }

        private void colorKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fk == null || _fk.IsDisposed)
            {
                _fk = new FrmKey();
            }

            _fk.Show();
        }

        private void AboutRomVaultToolStripMenuItemClick(object sender, EventArgs e)
        {
            FrmHelpAbout fha = new FrmHelpAbout();
            fha.ShowDialog(this);
            fha.Dispose();
        }

        #endregion

        #region sideButtons

        private void BtnUpdateDatsMouseUp(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                DatUpdate.CheckAllDats(DB.DirRoot.Child(0), @"DatRoot\");
            }
            RootDirsCreate.CheckDatRoot();
            Start();
            UpdateDats();
            Finish();
        }

        private void BtnScanRomsClick(object sender, EventArgs e)
        {
            ScanRoms(EScanLevel.Level2);
        }

        private void btnFindFixes_MouseUp(object sender, MouseEventArgs e)
        {
            FindFixes(Control.ModifierKeys == (Keys.Shift | Keys.Control));
        }

        private void BtnFixFilesMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Automate.AutoScanFix();
                return;
            }

            FixFiles();
        }

        private void BtnReportMouseUp(object sender, MouseEventArgs e)
        {
            MakeFixDat(DB.DirRoot.Child(0), e.Button == MouseButtons.Left);
        }

        #endregion

        #region TopRight

        private void FilterGamesList()
        {
            if (gameGridSource != null)
                UpdateGameGrid(gameGridSource);
            //txtFilter.Focus();
        }

        private void picPayPal_Click(object sender, EventArgs e)
        {
            try { Process.Start("http://paypal.me/romvault"); } catch { }
        }

        private void picPatreon_Click(object sender, EventArgs e)
        {
            try { Process.Start("https://www.patreon.com/romvault"); } catch { }
        }

        #endregion

        #region coreFunctions

        public void UpdateDats()
        {
            // incase the selected tree item(DAT) is removed from the tree in the updated we need to build a parent list and traverse up it until we find a parent item still in the tree.

            // build a list of the selected item in the Tree view and all the items up the parent list from there back to the root.
            RvFile selected = ctrRvTree.Selected;
            List<RvFile> parents = new List<RvFile>();
            while (selected != null)
            {
                parents.Add(selected);
                selected = selected.Parent;
            }

            // update the dats
            FrmProgressWindow progress = new FrmProgressWindow(this, "Scanning Dats", DatUpdate.UpdateDat, null);
            progress.HideCancelButton();
            progress.ShowDialog(this);
            progress.Dispose();

            // rebuild the tree
            ctrRvTree.Setup(ref DB.DirRoot);

            // if the rvFile.Parent is null it have been removed from the tree so remove it from the list.
            // set up until we find a rvFile with a parent.
            while (parents.Count > 1 && parents[0].Parent == null)
                parents.RemoveAt(0);

            // did we find a parent
            if (parents.Count > 0)
                selected = parents[0];
            else
                selected = null;

            // update the selected tree item, and the game grid view.
            ctrRvTree.SetSelected(selected);
            DatSetSelected(selected);
        }

        private void setPos(Form childForm)
        {
            childForm.Owner = this;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Location = new Point(
              Location.X + (Width - childForm.Width) / 2,
              Location.Y + (Height - childForm.Height) / 2
            );
        }

        public FrmProgressWindow frmScanRoms;

        public void ScanRoms(EScanLevel sd, RvFile StartAt = null, FormClosedEventHandler fceh = null)
        {
            FileScanning.StartAt = StartAt;
            FileScanning.EScanLevel = sd;
            frmScanRoms = new FrmProgressWindow(this, "Scanning Dirs", FileScanning.ScanFiles, Finish);
            Start();
            setPos(frmScanRoms);
            if (fceh != null)
                frmScanRoms.FormClosed += fceh;
            frmScanRoms.Show();
        }

        public FrmProgressWindow frmFindFixes;

        public void FindFixes(bool showLog = false, FormClosedEventHandler fceh = null)
        {
            frmFindFixes = new FrmProgressWindow(this, "Finding Fixes", RomVaultCore.FindFix.FindFixes.ScanFiles, Finish);
            frmFindFixes.ShowTimeLog = showLog;
            Start();
            setPos(frmFindFixes);
            if (fceh != null)
                frmFindFixes.FormClosed += fceh;
            frmFindFixes.Show();
        }

        private FrmProgressWindowFix frmFixFiles;

        public void FixFiles(bool closeOnExit = false, FormClosedEventHandler fceh = null)
        {
            frmFixFiles = new FrmProgressWindowFix(this, closeOnExit, Finish);
            Start();
            setPos(frmFixFiles);
            if (fceh != null)
                frmFixFiles.FormClosed += fceh;
            frmFixFiles.Show();
        }

        private bool _working = false;

        private void Start()
        {
            _working = true;
            timer1.Enabled = true;
            ctrRvTree.Working = true;
            //menuStrip1.Enabled = false;
            foreach (var item in menuStrip1.Items)
            {
                if (!(item is ToolStripMenuItem menuItem))
                    continue;
                if (menuItem.Text == "Help")
                    continue;
                menuItem.Enabled = false;
            }
            btnUpdateDats.Enabled = false;
            btnScanRoms.Enabled = false;
            btnFindFixes.Enabled = false;
            btnFixFiles.Enabled = false;
            btnReport.Enabled = false;

            btnDefault1.Enabled = false;
            btnDefault2.Enabled = false;
            btnDefault3.Enabled = false;
            btnDefault4.Enabled = false;

            //btnUpdateDats.BackgroundImage = rvImages.GetBitmap("btnUpdateDats_Disabled");
            //btnScanRoms.BackgroundImage = rvImages.GetBitmap("btnScanRoms_Disabled");
            //btnFindFixes.BackgroundImage = rvImages.GetBitmap("btnFindFixes_Disabled");
            //btnFixFiles.BackgroundImage = rvImages.GetBitmap("btnFixFiles_Disabled");
            //btnReport.BackgroundImage = rvImages.GetBitmap("btnReport_Disabled");
        }

        private void Finish()
        {
            _working = false;
            ctrRvTree.Working = false;
            //menuStrip1.Enabled = true;
            foreach (var item in menuStrip1.Items)
            {
                if (item is ToolStripMenuItem menuItem)
                    menuItem.Enabled = true;
            }

            //btnUpdateDats.BackgroundImage = rvImages.GetBitmap("btnUpdateDats_Enabled");
            //btnScanRoms.BackgroundImage = rvImages.GetBitmap("btnScanRoms_Enabled");
            //btnFindFixes.BackgroundImage = rvImages.GetBitmap("btnFindFixes_Enabled");
            //btnFixFiles.BackgroundImage = rvImages.GetBitmap("btnFixFiles_Enabled");
            //btnReport.BackgroundImage = rvImages.GetBitmap("btnReport_Enabled");

            btnDefault1.Enabled = true;
            btnDefault2.Enabled = true;
            btnDefault3.Enabled = true;
            btnDefault4.Enabled = true;

            btnUpdateDats.Enabled = true;
            btnScanRoms.Enabled = true;
            btnFindFixes.Enabled = true;
            btnFixFiles.Enabled = true;
            btnReport.Enabled = true;

            timer1.Enabled = false;
            DatSetSelected(ctrRvTree.Selected);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ctrRvTree.Refresh();
            UpdateGameGrid(true);
            if (ctrRvTree.Selected != null)
                UpdateDatMetaData(ctrRvTree.Selected);
            GameGrid.Refresh();
        }

        #endregion

        #region DatDisplay

        private void DatSetSelected(RvFile cf)
        {
            ctrRvTree.Refresh();

            ClearGameGrid();

            if (cf == null)
            {
                return;
            }

            UpdateDatMetaData(cf);
            UpdateGameGrid(cf);
        }

        private void UpdateDatMetaData(RvFile tDir)
        {
            DatInfo = new DatInfo();

            DatInfo.Name = tDir.Name;

            RvDat tDat = null;
            if (tDir.Dat != null)
                tDat = tDir.Dat;
            else if (tDir.DirDatCount == 1)
                tDat = tDir.DirDat(0);

            if (tDat != null)
            {
                if (DatInfo.Name != tDat.GetData(RvDat.DatData.DatName))
                    DatInfo.Name += $":  {tDat.GetData(RvDat.DatData.DatName)}";

                string DatId = tDat.GetData(RvDat.DatData.Id);
                if (!string.IsNullOrWhiteSpace(DatId))
                    DatInfo.Name += $" (ID:{DatId})";

                DatInfo.Description = tDat.GetData(RvDat.DatData.Description);
                DatInfo.Category = tDat.GetData(RvDat.DatData.Category);
                DatInfo.Version = tDat.GetData(RvDat.DatData.Version);
                DatInfo.Author = tDat.GetData(RvDat.DatData.Author);
                DatInfo.Date = tDat.GetData(RvDat.DatData.Date);
                string header = tDat.GetData(RvDat.DatData.Header);
                if (!string.IsNullOrWhiteSpace(header))
                    DatInfo.Name += " (" + header + ")";
            }
            else
            {
                DatInfo.Description = "";
                DatInfo.Category = "";
                DatInfo.Version = "";
                DatInfo.Author = "";
                DatInfo.Date = "";
            }

            DatInfo.RomPath = tDir.FullName;

            DatInfo.RomsGot = tDir.DirStatus.CountCorrect().ToString(CultureInfo.InvariantCulture);
            if (tDir.DirStatus.CountFoundMIA() > 0) { DatInfo.RomsGot += $"  -  {tDir.DirStatus.CountFoundMIA()} Found MIA"; }
            DatInfo.RomsMissing = tDir.DirStatus.CountMissing().ToString(CultureInfo.InvariantCulture);
            if (tDir.DirStatus.CountMIA() > 0) { DatInfo.RomsMissing += $"  -  {tDir.DirStatus.CountMIA()} MIA"; }
            DatInfo.RomsFixable = tDir.DirStatus.CountFixesNeeded().ToString(CultureInfo.InvariantCulture);
            DatInfo.RomsUnknown = (tDir.DirStatus.CountUnknown() + tDir.DirStatus.CountInToSort()).ToString(CultureInfo.InvariantCulture);

            UpdateDatInfoControls();
        }

        private void UpdateDatInfoControls()
        {
            MainPG.SelectedObject = DatInfo;

            string compositName = DatInfo.Name;
            if (!string.IsNullOrEmpty(DatInfo.Category))
                compositName += $" ({DatInfo.Category})";
            DatInfoNameLb.Text = compositName;

            DatInfoPathLb.Text = DatInfo.RomPath;
            tooltip.SetToolTip(DatInfoPathLb, DatInfo.RomPath);
            //  DatInfoPathLb.Tooltip

            RomsGotLB.Text = $"Got: {DatInfo.RomsGot}";
            RomsFixableLB.Text = $"Fixable: {DatInfo.RomsFixable}";
            RomsMissingLB.Text = $"Missing: {DatInfo.RomsMissing}";
            RomsUnknownLB.Text = $"Unknown: {DatInfo.RomsUnknown}";

            //MainPG.Refresh();
        }

        #endregion

        private void btnDefault1_MouseDown(object sender, MouseEventArgs e)
        {
            treeDefault(e.Button == MouseButtons.Right, 1);
        }

        private void btnDefault2_MouseDown(object sender, MouseEventArgs e)
        {
            treeDefault(e.Button == MouseButtons.Right, 2);
        }

        private void btnDefault3_MouseDown(object sender, MouseEventArgs e)
        {
            treeDefault(e.Button == MouseButtons.Right, 3);
        }

        private void btnDefault4_MouseDown(object sender, MouseEventArgs e)
        {
            treeDefault(e.Button == MouseButtons.Right, 4);
        }

        public void treeDefault(bool set, int index)
        {
            DatTreeStatusStore dtss = new DatTreeStatusStore();
            if (set)
            {
                dtss.write(index);
                return;
            }
            dtss.read(index);
            ctrRvTree.Setup(ref DB.DirRoot, true);
        }

        private void visitHelpWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { Process.Start("https://wiki.romvault.com/doku.php?id=help"); } catch { }
        }

        private void whatsNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { Process.Start("https://wiki.romvault.com/doku.php?id=whats_new"); } catch { }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_fk != null && !_fk.IsDisposed)
                _fk.Close();

            this.Hide();
            foreach (Thread frmTrrntzip in frmTrrntzips)
                frmTrrntzip.Join();

            Environment.Exit(0);
        }

        private List<Thread> frmTrrntzips = new List<Thread>();

        private void torrentZipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread tStart = new Thread(() =>
            {
                FrmTrrntzip frmTrrntzip = new FrmTrrntzip();
                if (Settings.rvSettings.Darkness)
                    Dark.dark.SetColors(frmTrrntzip);
                Application.Run(frmTrrntzip);
            });
            frmTrrntzips.Add(tStart);
            tStart.SetApartmentState(ApartmentState.STA);
            tStart.Start();
        }

        private void garbageCollectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GC.Collect();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            NavButtonDetails = new Dictionary<Button, string>()
            {
                { btnUpdateDats, "Update DATs" },
                { btnScanRoms, "Scan Roms" },
                { btnFindFixes, "Find Fixes" },
                { btnFixFiles, "Fix ROMs" },
                { btnReport, "Reports" }
            };
        }

        /// <summary>
        /// UpdateThemeAndControls Fires before this and also contain UI setup logic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            // Restore visuals
            if (Properties.Settings.Default.WindowPosition != new Point(0, 0))
                this.Location = Properties.Settings.Default.WindowPosition;

            if (Properties.Settings.Default.WindowSize != new Size(0, 0))
                this.Size = Properties.Settings.Default.WindowSize;

            // Restore splitters
            if (Properties.Settings.Default.SidebarSplitterDistance != 0)
                splitToolBarMain.SplitterDistance = Properties.Settings.Default.SidebarSplitterDistance;

            if (Properties.Settings.Default.DatGameSplitterDistance != 0)
                splitDatInfoGameInfo.SplitterDistance = Properties.Settings.Default.DatGameSplitterDistance;

            if (Properties.Settings.Default.GameInfoSplitterDistance != 0)
                splitGameInfoLists.SplitterDistance = Properties.Settings.Default.GameInfoSplitterDistance;

            if (Properties.Settings.Default.RomListSplitterDistance != 0)
                splitGameListRomList.SplitterDistance = Properties.Settings.Default.RomListSplitterDistance;

            // Set up status strip
            InitialiseStatusStrip();

            ctrRvTree.Visible = true;

            _shown = true;
        }

        private void ToggleNavText(bool visible)
        {
            if (visible)
            {
                foreach (KeyValuePair<Button, string> navButton in NavButtonDetails)
                {
                    navButton.Key.Text = navButton.Value;
                }
            }
            else
            {
                foreach (KeyValuePair<Button, string> navButton in NavButtonDetails)
                {
                    navButton.Key.Text = "";
                }
            }
        }

        private int navBarWidth = 156;

        private void splitToolBarMain_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (splitToolBarMain.Panel1.Width < navBarWidth)
            {
                CollapseSidebar();
            }
            else if (splitToolBarMain.Panel1.Width >= navBarWidth && string.IsNullOrEmpty(btnUpdateDats.Text))
            {
                if (string.IsNullOrEmpty(btnUpdateDats.Text)) ToggleNavText(visible: true);
            }
        }

        private void CollapseSidebar()
        {
            splitToolBarMain.Visible = false;
            splitToolBarMain.SuspendLayout();

            ToggleNavText(visible: false);
            splitToolBarMain.SplitterDistance = 68;

            splitToolBarMain.ResumeLayout();
            splitToolBarMain.Visible = true;

            HideNavBT.Image = Properties.Resources.MenuExpand;
        }

        private void ExpandSidebar()
        {
            ToggleNavText(visible: true);
            splitToolBarMain.SplitterDistance = navBarWidth + 4;

            HideNavBT.Image = Properties.Resources.MenuCollapse;
        }

        private void HideNavBT_Click(object sender, EventArgs e)
        {
            if (splitToolBarMain.Panel1.Width >= navBarWidth)
            {
                CollapseSidebar();
            }
            else
            {
                ExpandSidebar();
            }
        }

        private void GameGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// This handles the collapse/expand of the Status Bar keys.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleStatusTextBT_Click(object sender, EventArgs e)
        {
            //ToggleRomStatusIconText();
            //ToggleDatStatusIconText();
            if (romStatusStripKeys.First().Visible == true) ToggleRomStatusGroup();
            if (datStatusStripKeys.First().Visible == true) ToggleDatStatusGroup();
        }

        private void ToggleRomStatusIconText()
        {
            if (romStatusStripKeys.First().DisplayStyle == ToolStripItemDisplayStyle.Image)
            {
                foreach (ToolStripStatusLabel status in romStatusStripKeys)
                {
                    status.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                }
            }
            else
            {
                foreach (ToolStripStatusLabel status in romStatusStripKeys)
                {
                    status.DisplayStyle = ToolStripItemDisplayStyle.Image;
                }
            }
        }

        private void ToggleDatStatusIconText()
        {
            if (datStatusStripKeys.First().DisplayStyle == ToolStripItemDisplayStyle.Image)
            {
                foreach (ToolStripStatusLabel status in datStatusStripKeys)
                {
                    status.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                }
            }
            else
            {
                foreach (ToolStripStatusLabel status in datStatusStripKeys)
                {
                    status.DisplayStyle = ToolStripItemDisplayStyle.Image;
                }
            }
        }

        private void ToggleDatStatusGroup()
        {
            if (datStatusStripKeys.First().Visible == false)
            {
                foreach (ToolStripStatusLabel status in datStatusStripKeys)
                    status.Visible = true;

                DatsShortnameToggleSSBT.Enabled = true;
            }
            else
            {
                foreach (ToolStripStatusLabel status in datStatusStripKeys)
                    status.Visible = false;

                DatsShortnameToggleSSBT.Enabled = false;
            }
        }

        private void ToggleRomStatusGroup()
        {
            if (romStatusStripKeys.First().Visible == false)
            {
                foreach (ToolStripStatusLabel status in romStatusStripKeys)
                    status.Visible = true;

                RomsShortnameToggleSSBT.Enabled = true;
            }
            else
            {
                foreach (ToolStripStatusLabel status in romStatusStripKeys)
                    status.Visible = false;

                RomsShortnameToggleSSBT.Enabled = false;
            }
        }

        private void ToggleGamesKeyTextBT_Click(object sender, EventArgs e)
        {
            ToggleRomStatusIconText();
        }

        private void ToggleDatKeyTextBT_Click(object sender, EventArgs e)
        {
            ToggleDatStatusIconText();
        }

        private void FrmMain_ResizeBegin(object sender, EventArgs e)
        {
            //this.SuspendLayout();
            //DatInfoTLP.Visible = false;
            //GameInfoTLP.Visible = false;
            //ctrRvTree.Visible = false;
        }

        private void FrmMain_ResizeEnd(object sender, EventArgs e)
        {
            //DatInfoTLP.Visible = true;
            //GameInfoTLP.Visible = true;
            //ctrRvTree.Visible = true;
            //this.ResumeLayout();
        }

        private void findFixesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            FindFixes();
        }

        private void findFixeswithLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            FindFixes(true);
        }

        private void fixROMsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_working) return;
            FixFiles();
        }

        private void scanFindAndFixROMsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            Automate.AutoScanFix();
        }

        private void addNewToSortFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_working) return;
            FolderBrowser cfbd = new FolderBrowser
            {
                ShowNewFolderButton = true,
                RootFolder = Environment.SpecialFolder.MyComputer,
                Description = "Select new ToSort Folder"
            };

            DialogResult result = cfbd.ShowDialog(this);
            if (result != DialogResult.OK) return;

            string relPath = RelativePath.MakeRelative(AppDomain.CurrentDomain.BaseDirectory, cfbd.SelectedPath);

            RvFile ts = new RvFile(FileType.Dir)
            {
                Name = relPath,
                DatStatus = DatStatus.InToSort,
                Tree = new RvTreeRow()
            };
            ts.Tree.SetChecked(RvTreeRow.TreeSelect.Locked, false);

            DB.DirRoot.ChildAdd(ts, DB.DirRoot.ChildCount);

            RepairStatus.ReportStatusReset(DB.DirRoot);
            ctrRvTree.Setup(ref DB.DirRoot);
            DatSetSelected(ts);

            DB.Write();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Zip Files|*.zip",
                Title = "Select a Zip File",
                Multiselect = true
            };
            ofd.ShowDialog();
        }

        private void DatsShortnameToggleSSBT_Click(object sender, EventArgs e)
        {
            ToggleDatStatusIconText();
        }

        private void DatsGroupVisibilitySSBT_Click(object sender, EventArgs e)
        {
            ToggleDatStatusGroup();
        }

        private void RomsShortnameToggleSSBT_Click(object sender, EventArgs e)
        {
            ToggleRomStatusIconText();
        }

        private void RomsGroupVisibilitySSBT_Click(object sender, EventArgs e)
        {
            ToggleRomStatusGroup();
        }

        private void DatsControlSSBT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                    ToggleDatStatusIconText();
                else
                    ToggleDatStatusGroup();
            }
        }

        private int statusBarLeftTooltipHeight = 10;

        private void CollapseAllSSBT_MouseEnter(object sender, EventArgs e)
        {
            tooltip.Show(CollapseAllSSBT.ToolTipText, MainSS, CollapseAllSSBT.Bounds.Left,
                CollapseAllSSBT.Bounds.Top - statusBarLeftTooltipHeight,
                5000);
        }

        private void CollapseAllSSBT_MouseLeave(object sender, EventArgs e)
        {
            tooltip.Hide(MainSS);
        }

        private void RomsControlSSBT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
                    ToggleRomStatusIconText();
                else
                    ToggleRomStatusGroup();
            }
        }

        private void DatsCollapseTreeBT_Click(object sender, EventArgs e)
        {
            var rootDatNode = ctrRvTree.ChildFiles[0];

            ctrRvTree.SetExpanded(rootDatNode,
               rightClick: ((Control.ModifierKeys & Keys.Shift) == Keys.Shift),
               isWorking: _working);

            ctrRvTree.SetupInt(); // refresh tree to update icons
        }

        private void ctrRvTree_Load(object sender, EventArgs e)
        {
        }

        private void MainPG_SelectedObjectsChanged(object sender, EventArgs e)
        {
            if (MainPG.SelectedObjects.Count() == 0) return;
            if (MainPG.SelectedObjects[0] is ViewModelBase)
            {
                PgHeaderLB.Text = ((ViewModelBase)MainPG.SelectedObjects[0]).Title;
                PgHeaderPB.Image = ((ViewModelBase)MainPG.SelectedObjects[0]).Icon;
            }
        }

        private void PgHeaderPB_Click(object sender, EventArgs e)
        {
        }

        private void DatInfoRomsLB_Click(object sender, EventArgs e)
        {
        }

        private void copyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sourceControl = copyTextToolStripMenuItem.Owner is ContextMenuStrip cms ? cms.SourceControl : null;

            if (!string.IsNullOrEmpty(sourceControl?.Text))
            {
                Clipboard.SetText(sourceControl.Text);
            }
        }

        private void gameSearchTSBT_Click(object sender, EventArgs e)
        {
            FilterGamesList();
        }

        private void gameSearchTSTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return) FilterGamesList();
        }

        private void gameSearchTSTB_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                gameSearchTSTB.SelectAll();
            });
        }

        private void gameSearchClearBT_Click(object sender, EventArgs e)
        {
            gameSearchTSTB.Text = string.Empty;
            FilterGamesList();
        }

        private void SaveFiltersToSettings()
        {
            Settings.rvSettings.chkBoxShowComplete = this.chkBoxShowCompleteTSI.Checked;
            Settings.rvSettings.chkBoxShowPartial = this.chkBoxShowPartialTSI.Checked;
            Settings.rvSettings.chkBoxShowEmpty = this.chkBoxShowEmptyTSI.Checked;
            Settings.rvSettings.chkBoxShowFixes = this.chkBoxShowFixesTSI.Checked;
            Settings.rvSettings.chkBoxShowMIA = this.chkBoxShowMIATSI.Checked;
            Settings.rvSettings.chkBoxShowMerged = this.chkBoxShowMergedTSI.Checked;
            // Settings.rvSettings.chkBoxShowEmpty = this.chkBoxShowEmptyTSI.Checked; // added this - missed off? Could be likely design decision
            Settings.WriteConfig(Settings.rvSettings);
        }

        private void completeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_batchSettingFilters) return;
            SaveFiltersToSettings();
            DatSetSelected(ctrRvTree.Selected);
        }

        private void paToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_batchSettingFilters) return;
            SaveFiltersToSettings();
            DatSetSelected(ctrRvTree.Selected);
        }

        private void emptyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_batchSettingFilters) return;
            SaveFiltersToSettings();
            DatSetSelected(ctrRvTree.Selected);
        }

        private void fixesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_batchSettingFilters) return;
            SaveFiltersToSettings();
            DatSetSelected(ctrRvTree.Selected);
        }

        private void mIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_batchSettingFilters) return;
            SaveFiltersToSettings();
            DatSetSelected(ctrRvTree.Selected);
        }

        private void mergedDupedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_batchSettingFilters) return;
            SaveFiltersToSettings();
            DatSetSelected(ctrRvTree.Selected);
        }

        private bool _batchSettingFilters;

        private void setAllToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void toggleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _batchSettingFilters = true;
            foreach (ToolStripMenuItem item in FilterCheckboxes)
            {
                item.Checked = !item.Checked;
            }
            _batchSettingFilters = false;
            SaveFiltersToSettings();
            DatSetSelected(ctrRvTree.Selected);
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_shown) return;
            Settings.rvSettings.Darkness = ((ToolStripMenuItem)sender).Checked;
            Settings.WriteConfig(Settings.rvSettings);
            UpdateThemeAndControls();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _batchSettingFilters = true;
            foreach (ToolStripMenuItem item in FilterCheckboxes)
            {
                item.Checked = false;
            }
            _batchSettingFilters = false;
            SaveFiltersToSettings();
            DatSetSelected(ctrRvTree.Selected);
        }

        private void GameRomToHomeBT_Click(object sender, EventArgs e)
        {
            GameGridNanigateToRoot();
        }
    }
}