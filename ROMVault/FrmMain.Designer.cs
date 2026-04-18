using ROMVault.UserControls;
using System;
using System.Windows.Forms;

namespace ROMVault
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.splitToolBarMain = new System.Windows.Forms.SplitContainer();
            this.HideNavBT = new System.Windows.Forms.Button();
            this.flexiLabel3 = new ROMVault.UserControls.FlexiLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDefault1 = new System.Windows.Forms.Button();
            this.btnDefault2 = new System.Windows.Forms.Button();
            this.btnDefault3 = new System.Windows.Forms.Button();
            this.btnDefault4 = new System.Windows.Forms.Button();
            this.gbDatInfo = new System.Windows.Forms.GroupBox();
            this.Padding5PN = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.Padding4PN = new System.Windows.Forms.Panel();
            this.btnFixFiles = new System.Windows.Forms.Button();
            this.gbSetInfo = new System.Windows.Forms.GroupBox();
            this.Padding3PN = new System.Windows.Forms.Panel();
            this.btnFindFixes = new System.Windows.Forms.Button();
            this.PaddingPN2 = new System.Windows.Forms.Panel();
            this.btnScanRoms = new System.Windows.Forms.Button();
            this.PaddingPN = new System.Windows.Forms.Panel();
            this.btnUpdateDats = new System.Windows.Forms.Button();
            this.lblTreePreSets = new System.Windows.Forms.Label();
            this.splitDatInfoGameInfo = new System.Windows.Forms.SplitContainer();
            this.DatInfoPN = new System.Windows.Forms.Panel();
            this.DatTreePN = new System.Windows.Forms.Panel();
            this.ctrRvTree = new ROMVault.RvTree();
            this.DatsTS = new System.Windows.Forms.ToolStrip();
            this.DatsCollapseTreeBT = new System.Windows.Forms.ToolStripButton();
            this.RomsStatusTagsFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.RomsUnknownLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsFixableLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsMissingLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsGotLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsPathFPR = new ROMVault.UserControls.FlowPanelResponsive();
            this.lblDIRomPath = new System.Windows.Forms.Label();
            this.DatInfoPathLb = new ROMVault.UserControls.PathLabel();
            this.CopyTextCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatNameFPR = new ROMVault.UserControls.FlowPanelResponsive();
            this.lblDIName = new System.Windows.Forms.Label();
            this.DatInfoNameLb = new System.Windows.Forms.Label();
            this.VaultHeaderPN = new System.Windows.Forms.Panel();
            this.DatPanelHeaderLB = new ROMVault.UserControls.FlexiLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitGameInfoLists = new System.Windows.Forms.SplitContainer();
            this.PropertryGridSC = new System.Windows.Forms.SplitContainer();
            this.MainPG = new System.Windows.Forms.PropertyGrid();
            this.PropertyGridHelpTB = new System.Windows.Forms.TextBox();
            this.PgHeader = new System.Windows.Forms.Panel();
            this.PgHeaderLB = new ROMVault.UserControls.FlexiLabel();
            this.PropGridHelpBT = new System.Windows.Forms.Button();
            this.PgHeaderPB = new System.Windows.Forms.PictureBox();
            this.splitListArt = new System.Windows.Forms.SplitContainer();
            this.GameRomPN = new System.Windows.Forms.Panel();
            this.splitGameListRomList = new System.Windows.Forms.SplitContainer();
            this.GameGrid = new System.Windows.Forms.DataGridView();
            this.CType = new System.Windows.Forms.DataGridViewImageColumn();
            this.CGame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CROMStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.RomGrid = new System.Windows.Forms.DataGridView();
            this.CGot = new System.Windows.Forms.DataGridViewImageColumn();
            this.CRom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMerge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCRC32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAltSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAltCRC32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAltSHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAltMD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CFileModDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CZipIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CInstanceCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameRomTableTS = new System.Windows.Forms.ToolStrip();
            this.GameRomToHomeBT = new System.Windows.Forms.ToolStripButton();
            this.AutoSizeGameColChB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.FilterTSDD = new System.Windows.Forms.ToolStripDropDownButton();
            this.chkBoxShowCompleteTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.chkBoxShowPartialTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.chkBoxShowEmptyTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.chkBoxShowFixesTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.chkBoxShowMIATSI = new System.Windows.Forms.ToolStripMenuItem();
            this.chkBoxShowMergedTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toggleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameSearchTSTB = new System.Windows.Forms.ToolStripTextBox();
            this.gameSearchTSBT = new System.Windows.Forms.ToolStripButton();
            this.gameSearchClearBT = new System.Windows.Forms.ToolStripButton();
            this.GameGridRowCountLB = new System.Windows.Forms.ToolStripLabel();
            this.TabEmuArc = new System.Windows.Forms.TabControl();
            this.tabArtWork = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picArtwork = new System.Windows.Forms.PictureBox();
            this.tabMedium = new System.Windows.Forms.TabPage();
            this.picMedium2 = new System.Windows.Forms.PictureBox();
            this.picMedium1 = new System.Windows.Forms.PictureBox();
            this.tabScreens = new System.Windows.Forms.TabPage();
            this.picScreenShot = new System.Windows.Forms.PictureBox();
            this.picScreenTitle = new System.Windows.Forms.PictureBox();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.tabInfo2 = new System.Windows.Forms.TabPage();
            this.txtInfo2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmUpdateDATs = new System.Windows.Forms.ToolStripMenuItem();
            this.updateNewDATsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAllDATsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBlankDATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.DatProvidersTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanROMs = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToSortFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmScanLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.RomProvidersTSI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFindFixes = new System.Windows.Forms.ToolStripMenuItem();
            this.findFixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findFixeswithLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fixROMsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scanFindAndFixROMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderCReatorWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.fixDatReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryMappingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.romVaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitHelpWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.colorKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRomVaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.garbageCollectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainSS = new System.Windows.Forms.StatusStrip();
            this.CollapseAllSSBT = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatsControlSSBT = new System.Windows.Forms.ToolStripDropDownButton();
            this.DatsGroupVisibilitySSBT = new System.Windows.Forms.ToolStripMenuItem();
            this.DatsShortnameToggleSSBT = new System.Windows.Forms.ToolStripMenuItem();
            this.RomsControlSSBT = new System.Windows.Forms.ToolStripDropDownButton();
            this.RomsGroupVisibilitySSBT = new System.Windows.Forms.ToolStripMenuItem();
            this.RomsShortnameToggleSSBT = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip = new ROMVault.UserControls.ToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.splitToolBarMain)).BeginInit();
            this.splitToolBarMain.Panel1.SuspendLayout();
            this.splitToolBarMain.Panel2.SuspendLayout();
            this.splitToolBarMain.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Padding5PN.SuspendLayout();
            this.Padding4PN.SuspendLayout();
            this.Padding3PN.SuspendLayout();
            this.PaddingPN2.SuspendLayout();
            this.PaddingPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDatInfoGameInfo)).BeginInit();
            this.splitDatInfoGameInfo.Panel1.SuspendLayout();
            this.splitDatInfoGameInfo.Panel2.SuspendLayout();
            this.splitDatInfoGameInfo.SuspendLayout();
            this.DatInfoPN.SuspendLayout();
            this.DatTreePN.SuspendLayout();
            this.DatsTS.SuspendLayout();
            this.RomsStatusTagsFLP.SuspendLayout();
            this.RomsPathFPR.SuspendLayout();
            this.CopyTextCMS.SuspendLayout();
            this.DatNameFPR.SuspendLayout();
            this.VaultHeaderPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGameInfoLists)).BeginInit();
            this.splitGameInfoLists.Panel1.SuspendLayout();
            this.splitGameInfoLists.Panel2.SuspendLayout();
            this.splitGameInfoLists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertryGridSC)).BeginInit();
            this.PropertryGridSC.Panel1.SuspendLayout();
            this.PropertryGridSC.Panel2.SuspendLayout();
            this.PropertryGridSC.SuspendLayout();
            this.PgHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PgHeaderPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitListArt)).BeginInit();
            this.splitListArt.Panel1.SuspendLayout();
            this.splitListArt.Panel2.SuspendLayout();
            this.splitListArt.SuspendLayout();
            this.GameRomPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitGameListRomList)).BeginInit();
            this.splitGameListRomList.Panel1.SuspendLayout();
            this.splitGameListRomList.Panel2.SuspendLayout();
            this.splitGameListRomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RomGrid)).BeginInit();
            this.GameRomTableTS.SuspendLayout();
            this.TabEmuArc.SuspendLayout();
            this.tabArtWork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtwork)).BeginInit();
            this.tabMedium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMedium2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedium1)).BeginInit();
            this.tabScreens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenTitle)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.tabInfo2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.MainSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitToolBarMain
            // 
            this.splitToolBarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitToolBarMain.Location = new System.Drawing.Point(0, 25);
            this.splitToolBarMain.Name = "splitToolBarMain";
            // 
            // splitToolBarMain.Panel1
            // 
            this.splitToolBarMain.Panel1.Controls.Add(this.HideNavBT);
            this.splitToolBarMain.Panel1.Controls.Add(this.flexiLabel3);
            this.splitToolBarMain.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitToolBarMain.Panel1.Controls.Add(this.gbDatInfo);
            this.splitToolBarMain.Panel1.Controls.Add(this.Padding5PN);
            this.splitToolBarMain.Panel1.Controls.Add(this.Padding4PN);
            this.splitToolBarMain.Panel1.Controls.Add(this.gbSetInfo);
            this.splitToolBarMain.Panel1.Controls.Add(this.Padding3PN);
            this.splitToolBarMain.Panel1.Controls.Add(this.PaddingPN2);
            this.splitToolBarMain.Panel1.Controls.Add(this.PaddingPN);
            this.splitToolBarMain.Panel1.Controls.Add(this.lblTreePreSets);
            this.splitToolBarMain.Panel1.Padding = new System.Windows.Forms.Padding(4);
            // 
            // splitToolBarMain.Panel2
            // 
            this.splitToolBarMain.Panel2.Controls.Add(this.splitDatInfoGameInfo);
            this.splitToolBarMain.Size = new System.Drawing.Size(1300, 765);
            this.splitToolBarMain.SplitterDistance = 130;
            this.splitToolBarMain.TabIndex = 5;
            this.splitToolBarMain.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitToolBarMain_SplitterMoved);
            // 
            // HideNavBT
            // 
            this.HideNavBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.HideNavBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.HideNavBT.FlatAppearance.BorderSize = 0;
            this.HideNavBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideNavBT.Image = global::ROMVault.Properties.Resources.MenuCollapse;
            this.HideNavBT.Location = new System.Drawing.Point(4, 314);
            this.HideNavBT.Name = "HideNavBT";
            this.HideNavBT.Size = new System.Drawing.Size(122, 52);
            this.HideNavBT.TabIndex = 23;
            this.HideNavBT.UseVisualStyleBackColor = true;
            this.HideNavBT.Click += new System.EventHandler(this.HideNavBT_Click);
            // 
            // flexiLabel3
            // 
            this.flexiLabel3.AutoSize = true;
            this.flexiLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flexiLabel3.Font = new System.Drawing.Font("Segoe UI", 11.7F, System.Drawing.FontStyle.Bold);
            this.flexiLabel3.Location = new System.Drawing.Point(4, 632);
            this.flexiLabel3.Name = "flexiLabel3";
            this.flexiLabel3.ScaleFactor = 1.2D;
            this.flexiLabel3.Size = new System.Drawing.Size(46, 21);
            this.flexiLabel3.TabIndex = 22;
            this.flexiLabel3.Text = "Tree:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnDefault1);
            this.flowLayoutPanel1.Controls.Add(this.btnDefault2);
            this.flowLayoutPanel1.Controls.Add(this.btnDefault3);
            this.flowLayoutPanel1.Controls.Add(this.btnDefault4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 653);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(122, 108);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // btnDefault1
            // 
            this.btnDefault1.BackgroundImage = global::ROMVault.Properties.Resources.Fave1;
            this.btnDefault1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDefault1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDefault1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault1.Location = new System.Drawing.Point(3, 3);
            this.btnDefault1.Name = "btnDefault1";
            this.btnDefault1.Padding = new System.Windows.Forms.Padding(2);
            this.btnDefault1.Size = new System.Drawing.Size(48, 48);
            this.btnDefault1.TabIndex = 14;
            this.btnDefault1.UseVisualStyleBackColor = true;
            this.btnDefault1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDefault1_MouseDown);
            // 
            // btnDefault2
            // 
            this.btnDefault2.BackgroundImage = global::ROMVault.Properties.Resources.Fave2;
            this.btnDefault2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDefault2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDefault2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault2.Location = new System.Drawing.Point(57, 3);
            this.btnDefault2.Name = "btnDefault2";
            this.btnDefault2.Size = new System.Drawing.Size(48, 48);
            this.btnDefault2.TabIndex = 15;
            this.btnDefault2.UseVisualStyleBackColor = true;
            this.btnDefault2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDefault2_MouseDown);
            // 
            // btnDefault3
            // 
            this.btnDefault3.BackgroundImage = global::ROMVault.Properties.Resources.Fave3;
            this.btnDefault3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDefault3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDefault3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault3.Location = new System.Drawing.Point(3, 57);
            this.btnDefault3.Name = "btnDefault3";
            this.btnDefault3.Size = new System.Drawing.Size(48, 48);
            this.btnDefault3.TabIndex = 16;
            this.btnDefault3.UseVisualStyleBackColor = true;
            this.btnDefault3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDefault3_MouseDown);
            // 
            // btnDefault4
            // 
            this.btnDefault4.BackgroundImage = global::ROMVault.Properties.Resources.Fave4;
            this.btnDefault4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDefault4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDefault4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault4.Location = new System.Drawing.Point(57, 57);
            this.btnDefault4.Name = "btnDefault4";
            this.btnDefault4.Size = new System.Drawing.Size(48, 48);
            this.btnDefault4.TabIndex = 17;
            this.btnDefault4.UseVisualStyleBackColor = true;
            this.btnDefault4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDefault4_MouseDown);
            // 
            // gbDatInfo
            // 
            this.gbDatInfo.AutoSize = true;
            this.gbDatInfo.Location = new System.Drawing.Point(17, 667);
            this.gbDatInfo.Name = "gbDatInfo";
            this.gbDatInfo.Size = new System.Drawing.Size(48, 61);
            this.gbDatInfo.TabIndex = 3;
            this.gbDatInfo.TabStop = false;
            this.gbDatInfo.Text = "Dat Info :";
            this.gbDatInfo.Visible = false;
            // 
            // Padding5PN
            // 
            this.Padding5PN.Controls.Add(this.btnReport);
            this.Padding5PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Padding5PN.Location = new System.Drawing.Point(4, 252);
            this.Padding5PN.Name = "Padding5PN";
            this.Padding5PN.Padding = new System.Windows.Forms.Padding(2);
            this.Padding5PN.Size = new System.Drawing.Size(122, 62);
            this.Padding5PN.TabIndex = 20;
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = global::ROMVault.Properties.Resources.ReportsDownload;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(3);
            this.btnReport.Size = new System.Drawing.Size(118, 58);
            this.btnReport.TabIndex = 13;
            this.btnReport.Text = "Reports";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tooltip.SetToolTip(this.btnReport, "Generate Reports");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnReportMouseUp);
            // 
            // Padding4PN
            // 
            this.Padding4PN.Controls.Add(this.btnFixFiles);
            this.Padding4PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Padding4PN.Location = new System.Drawing.Point(4, 190);
            this.Padding4PN.Name = "Padding4PN";
            this.Padding4PN.Padding = new System.Windows.Forms.Padding(2);
            this.Padding4PN.Size = new System.Drawing.Size(122, 62);
            this.Padding4PN.TabIndex = 20;
            // 
            // btnFixFiles
            // 
            this.btnFixFiles.AutoSize = true;
            this.btnFixFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFixFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFixFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnFixFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixFiles.Image = global::ROMVault.Properties.Resources.RomsFix;
            this.btnFixFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixFiles.Location = new System.Drawing.Point(2, 2);
            this.btnFixFiles.Name = "btnFixFiles";
            this.btnFixFiles.Padding = new System.Windows.Forms.Padding(3);
            this.btnFixFiles.Size = new System.Drawing.Size(118, 58);
            this.btnFixFiles.TabIndex = 10;
            this.btnFixFiles.Text = "Fix Roms";
            this.btnFixFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tooltip.SetToolTip(this.btnFixFiles, "Fix ROMs");
            this.btnFixFiles.UseVisualStyleBackColor = true;
            this.btnFixFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFixFilesMouseUp);
            // 
            // gbSetInfo
            // 
            this.gbSetInfo.Location = new System.Drawing.Point(71, 667);
            this.gbSetInfo.Name = "gbSetInfo";
            this.gbSetInfo.Size = new System.Drawing.Size(46, 61);
            this.gbSetInfo.TabIndex = 4;
            this.gbSetInfo.TabStop = false;
            this.gbSetInfo.Text = "Game Info :";
            this.gbSetInfo.Visible = false;
            // 
            // Padding3PN
            // 
            this.Padding3PN.Controls.Add(this.btnFindFixes);
            this.Padding3PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Padding3PN.Location = new System.Drawing.Point(4, 128);
            this.Padding3PN.Name = "Padding3PN";
            this.Padding3PN.Padding = new System.Windows.Forms.Padding(2);
            this.Padding3PN.Size = new System.Drawing.Size(122, 62);
            this.Padding3PN.TabIndex = 20;
            // 
            // btnFindFixes
            // 
            this.btnFindFixes.AutoSize = true;
            this.btnFindFixes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFindFixes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFindFixes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnFindFixes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindFixes.Image = global::ROMVault.Properties.Resources.RomsFindFixes;
            this.btnFindFixes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindFixes.Location = new System.Drawing.Point(2, 2);
            this.btnFindFixes.Name = "btnFindFixes";
            this.btnFindFixes.Padding = new System.Windows.Forms.Padding(3);
            this.btnFindFixes.Size = new System.Drawing.Size(118, 58);
            this.btnFindFixes.TabIndex = 9;
            this.btnFindFixes.Text = "Find Fixes";
            this.btnFindFixes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindFixes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tooltip.SetToolTip(this.btnFindFixes, "Find Fixes");
            this.btnFindFixes.UseVisualStyleBackColor = true;
            this.btnFindFixes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnFindFixes_MouseUp);
            // 
            // PaddingPN2
            // 
            this.PaddingPN2.Controls.Add(this.btnScanRoms);
            this.PaddingPN2.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaddingPN2.Location = new System.Drawing.Point(4, 66);
            this.PaddingPN2.Name = "PaddingPN2";
            this.PaddingPN2.Padding = new System.Windows.Forms.Padding(2);
            this.PaddingPN2.Size = new System.Drawing.Size(122, 62);
            this.PaddingPN2.TabIndex = 20;
            // 
            // btnScanRoms
            // 
            this.btnScanRoms.AutoSize = true;
            this.btnScanRoms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnScanRoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScanRoms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnScanRoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanRoms.Image = global::ROMVault.Properties.Resources.RomsScan;
            this.btnScanRoms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanRoms.Location = new System.Drawing.Point(2, 2);
            this.btnScanRoms.Name = "btnScanRoms";
            this.btnScanRoms.Padding = new System.Windows.Forms.Padding(3);
            this.btnScanRoms.Size = new System.Drawing.Size(118, 58);
            this.btnScanRoms.TabIndex = 8;
            this.btnScanRoms.Text = "Scan Roms";
            this.btnScanRoms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanRoms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tooltip.SetToolTip(this.btnScanRoms, "Scan ROMs");
            this.btnScanRoms.UseVisualStyleBackColor = true;
            this.btnScanRoms.Click += new System.EventHandler(this.BtnScanRomsClick);
            // 
            // PaddingPN
            // 
            this.PaddingPN.Controls.Add(this.btnUpdateDats);
            this.PaddingPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaddingPN.Location = new System.Drawing.Point(4, 4);
            this.PaddingPN.Name = "PaddingPN";
            this.PaddingPN.Padding = new System.Windows.Forms.Padding(2);
            this.PaddingPN.Size = new System.Drawing.Size(122, 62);
            this.PaddingPN.TabIndex = 19;
            // 
            // btnUpdateDats
            // 
            this.btnUpdateDats.AutoSize = true;
            this.btnUpdateDats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateDats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateDats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnUpdateDats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDats.Image = global::ROMVault.Properties.Resources.DatsUpdate;
            this.btnUpdateDats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDats.Location = new System.Drawing.Point(2, 2);
            this.btnUpdateDats.Name = "btnUpdateDats";
            this.btnUpdateDats.Padding = new System.Windows.Forms.Padding(3);
            this.btnUpdateDats.Size = new System.Drawing.Size(118, 58);
            this.btnUpdateDats.TabIndex = 0;
            this.btnUpdateDats.Text = "Update DATs";
            this.btnUpdateDats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tooltip.SetToolTip(this.btnUpdateDats, "Update DATs");
            this.btnUpdateDats.UseVisualStyleBackColor = false;
            this.btnUpdateDats.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnUpdateDatsMouseUp);
            // 
            // lblTreePreSets
            // 
            this.lblTreePreSets.AutoSize = true;
            this.lblTreePreSets.Location = new System.Drawing.Point(14, 731);
            this.lblTreePreSets.Name = "lblTreePreSets";
            this.lblTreePreSets.Size = new System.Drawing.Size(85, 17);
            this.lblTreePreSets.TabIndex = 18;
            this.lblTreePreSets.Text = "Tree Pre-Sets";
            this.lblTreePreSets.Visible = false;
            // 
            // splitDatInfoGameInfo
            // 
            this.splitDatInfoGameInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitDatInfoGameInfo.Location = new System.Drawing.Point(0, 0);
            this.splitDatInfoGameInfo.Name = "splitDatInfoGameInfo";
            // 
            // splitDatInfoGameInfo.Panel1
            // 
            this.splitDatInfoGameInfo.Panel1.Controls.Add(this.DatInfoPN);
            this.splitDatInfoGameInfo.Panel1.Padding = new System.Windows.Forms.Padding(4);
            this.splitDatInfoGameInfo.Panel1MinSize = 200;
            // 
            // splitDatInfoGameInfo.Panel2
            // 
            this.splitDatInfoGameInfo.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitDatInfoGameInfo.Panel2.Controls.Add(this.splitGameInfoLists);
            this.splitDatInfoGameInfo.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitDatInfoGameInfo.Size = new System.Drawing.Size(1166, 765);
            this.splitDatInfoGameInfo.SplitterDistance = 348;
            this.splitDatInfoGameInfo.TabIndex = 0;
            // 
            // DatInfoPN
            // 
            this.DatInfoPN.AutoSize = true;
            this.DatInfoPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatInfoPN.Controls.Add(this.DatTreePN);
            this.DatInfoPN.Controls.Add(this.RomsStatusTagsFLP);
            this.DatInfoPN.Controls.Add(this.RomsPathFPR);
            this.DatInfoPN.Controls.Add(this.DatNameFPR);
            this.DatInfoPN.Controls.Add(this.VaultHeaderPN);
            this.DatInfoPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatInfoPN.Location = new System.Drawing.Point(4, 4);
            this.DatInfoPN.Name = "DatInfoPN";
            this.DatInfoPN.Padding = new System.Windows.Forms.Padding(2);
            this.DatInfoPN.Size = new System.Drawing.Size(340, 757);
            this.DatInfoPN.TabIndex = 4;
            // 
            // DatTreePN
            // 
            this.DatTreePN.AutoSize = true;
            this.DatTreePN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatTreePN.Controls.Add(this.ctrRvTree);
            this.DatTreePN.Controls.Add(this.DatsTS);
            this.DatTreePN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatTreePN.Location = new System.Drawing.Point(2, 121);
            this.DatTreePN.Name = "DatTreePN";
            this.DatTreePN.Size = new System.Drawing.Size(334, 632);
            this.DatTreePN.TabIndex = 6;
            // 
            // ctrRvTree
            // 
            this.ctrRvTree.AutoSize = true;
            this.ctrRvTree.BackColor = System.Drawing.Color.Coral;
            this.ctrRvTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrRvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrRvTree.Location = new System.Drawing.Point(0, 31);
            this.ctrRvTree.Name = "ctrRvTree";
            this.ctrRvTree.Size = new System.Drawing.Size(332, 599);
            this.ctrRvTree.TabIndex = 2;
            this.ctrRvTree.Visible = false;
            this.ctrRvTree.RvSelected += new System.Windows.Forms.MouseEventHandler(this.DirTreeRvSelected);
            this.ctrRvTree.RvChecked += new System.Windows.Forms.MouseEventHandler(this.DirTreeRvChecked);
            // 
            // DatsTS
            // 
            this.DatsTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.DatsTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatsCollapseTreeBT});
            this.DatsTS.Location = new System.Drawing.Point(0, 0);
            this.DatsTS.Name = "DatsTS";
            this.DatsTS.Padding = new System.Windows.Forms.Padding(4);
            this.DatsTS.Size = new System.Drawing.Size(332, 31);
            this.DatsTS.TabIndex = 5;
            this.DatsTS.Text = "toolStrip1";
            // 
            // DatsCollapseTreeBT
            // 
            this.DatsCollapseTreeBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DatsCollapseTreeBT.Image = global::ROMVault.Properties.Resources.folderTreeGray;
            this.DatsCollapseTreeBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DatsCollapseTreeBT.Name = "DatsCollapseTreeBT";
            this.DatsCollapseTreeBT.Size = new System.Drawing.Size(23, 20);
            this.DatsCollapseTreeBT.Text = "toolStripButton1";
            this.DatsCollapseTreeBT.ToolTipText = "Expand/Collapse Dat Tree";
            this.DatsCollapseTreeBT.Click += new System.EventHandler(this.DatsCollapseTreeBT_Click);
            // 
            // RomsStatusTagsFLP
            // 
            this.RomsStatusTagsFLP.AutoSize = true;
            this.RomsStatusTagsFLP.BackColor = System.Drawing.SystemColors.Control;
            this.RomsStatusTagsFLP.Controls.Add(this.RomsUnknownLB);
            this.RomsStatusTagsFLP.Controls.Add(this.RomsFixableLB);
            this.RomsStatusTagsFLP.Controls.Add(this.RomsMissingLB);
            this.RomsStatusTagsFLP.Controls.Add(this.RomsGotLB);
            this.RomsStatusTagsFLP.Dock = System.Windows.Forms.DockStyle.Top;
            this.RomsStatusTagsFLP.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.RomsStatusTagsFLP.Location = new System.Drawing.Point(2, 90);
            this.RomsStatusTagsFLP.Name = "RomsStatusTagsFLP";
            this.RomsStatusTagsFLP.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.RomsStatusTagsFLP.Size = new System.Drawing.Size(334, 31);
            this.RomsStatusTagsFLP.TabIndex = 20;
            // 
            // RomsUnknownLB
            // 
            this.RomsUnknownLB.AutoSize = true;
            this.RomsUnknownLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsUnknownLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsUnknownLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsUnknownLB.ForeColor = System.Drawing.Color.Cyan;
            this.RomsUnknownLB.Location = new System.Drawing.Point(260, 2);
            this.RomsUnknownLB.Margin = new System.Windows.Forms.Padding(2);
            this.RomsUnknownLB.Name = "RomsUnknownLB";
            this.RomsUnknownLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsUnknownLB.ScaleFactor = 1D;
            this.RomsUnknownLB.Size = new System.Drawing.Size(72, 25);
            this.RomsUnknownLB.TabIndex = 24;
            this.RomsUnknownLB.Tag = "override";
            this.RomsUnknownLB.Text = "Unknown";
            // 
            // RomsFixableLB
            // 
            this.RomsFixableLB.AutoSize = true;
            this.RomsFixableLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsFixableLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsFixableLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsFixableLB.ForeColor = System.Drawing.Color.Yellow;
            this.RomsFixableLB.Location = new System.Drawing.Point(200, 2);
            this.RomsFixableLB.Margin = new System.Windows.Forms.Padding(2);
            this.RomsFixableLB.Name = "RomsFixableLB";
            this.RomsFixableLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsFixableLB.ScaleFactor = 1D;
            this.RomsFixableLB.Size = new System.Drawing.Size(56, 25);
            this.RomsFixableLB.TabIndex = 23;
            this.RomsFixableLB.Tag = "override";
            this.RomsFixableLB.Text = "Fixable";
            // 
            // RomsMissingLB
            // 
            this.RomsMissingLB.AutoSize = true;
            this.RomsMissingLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsMissingLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsMissingLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsMissingLB.ForeColor = System.Drawing.Color.Red;
            this.RomsMissingLB.Location = new System.Drawing.Point(136, 2);
            this.RomsMissingLB.Margin = new System.Windows.Forms.Padding(2);
            this.RomsMissingLB.Name = "RomsMissingLB";
            this.RomsMissingLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsMissingLB.ScaleFactor = 1D;
            this.RomsMissingLB.Size = new System.Drawing.Size(60, 25);
            this.RomsMissingLB.TabIndex = 22;
            this.RomsMissingLB.Tag = "override";
            this.RomsMissingLB.Text = "Missing";
            // 
            // RomsGotLB
            // 
            this.RomsGotLB.AutoSize = true;
            this.RomsGotLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsGotLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsGotLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsGotLB.ForeColor = System.Drawing.Color.LimeGreen;
            this.RomsGotLB.Location = new System.Drawing.Point(96, 2);
            this.RomsGotLB.Margin = new System.Windows.Forms.Padding(2);
            this.RomsGotLB.Name = "RomsGotLB";
            this.RomsGotLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsGotLB.ScaleFactor = 1D;
            this.RomsGotLB.Size = new System.Drawing.Size(36, 25);
            this.RomsGotLB.TabIndex = 21;
            this.RomsGotLB.Tag = "override";
            this.RomsGotLB.Text = "Got";
            // 
            // RomsPathFPR
            // 
            this.RomsPathFPR.AutoSize = true;
            this.RomsPathFPR.Controls.Add(this.lblDIRomPath);
            this.RomsPathFPR.Controls.Add(this.DatInfoPathLb);
            this.RomsPathFPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.RomsPathFPR.Location = new System.Drawing.Point(2, 59);
            this.RomsPathFPR.Name = "RomsPathFPR";
            this.RomsPathFPR.Size = new System.Drawing.Size(334, 31);
            this.RomsPathFPR.TabIndex = 26;
            this.RomsPathFPR.WrapContents = false;
            // 
            // lblDIRomPath
            // 
            this.lblDIRomPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDIRomPath.AutoSize = true;
            this.lblDIRomPath.Location = new System.Drawing.Point(0, 7);
            this.lblDIRomPath.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIRomPath.Name = "lblDIRomPath";
            this.lblDIRomPath.Size = new System.Drawing.Size(80, 17);
            this.lblDIRomPath.TabIndex = 15;
            this.lblDIRomPath.Text = "ROMs Path: ";
            this.lblDIRomPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DatInfoPathLb
            // 
            this.DatInfoPathLb.AutoSize = true;
            this.DatInfoPathLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatInfoPathLb.ContextMenuStrip = this.CopyTextCMS;
            this.DatInfoPathLb.Location = new System.Drawing.Point(83, 3);
            this.DatInfoPathLb.Margin = new System.Windows.Forms.Padding(3);
            this.DatInfoPathLb.Name = "DatInfoPathLb";
            this.DatInfoPathLb.Padding = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.DatInfoPathLb.Size = new System.Drawing.Size(248, 25);
            this.DatInfoPathLb.TabIndex = 21;
            this.DatInfoPathLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CopyTextCMS
            // 
            this.CopyTextCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTextToolStripMenuItem});
            this.CopyTextCMS.Name = "CopyTextCMS";
            this.CopyTextCMS.Size = new System.Drawing.Size(134, 26);
            // 
            // copyTextToolStripMenuItem
            // 
            this.copyTextToolStripMenuItem.Image = global::ROMVault.Properties.Resources.blue_document_copy;
            this.copyTextToolStripMenuItem.Name = "copyTextToolStripMenuItem";
            this.copyTextToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.copyTextToolStripMenuItem.Text = "Copy Text";
            this.copyTextToolStripMenuItem.Click += new System.EventHandler(this.copyTextToolStripMenuItem_Click);
            // 
            // DatNameFPR
            // 
            this.DatNameFPR.AutoSize = true;
            this.DatNameFPR.Controls.Add(this.lblDIName);
            this.DatNameFPR.Controls.Add(this.DatInfoNameLb);
            this.DatNameFPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatNameFPR.Location = new System.Drawing.Point(2, 30);
            this.DatNameFPR.Name = "DatNameFPR";
            this.DatNameFPR.Size = new System.Drawing.Size(334, 29);
            this.DatNameFPR.TabIndex = 27;
            this.DatNameFPR.WrapContents = false;
            // 
            // lblDIName
            // 
            this.lblDIName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDIName.AutoSize = true;
            this.lblDIName.Location = new System.Drawing.Point(0, 6);
            this.lblDIName.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIName.Name = "lblDIName";
            this.lblDIName.Size = new System.Drawing.Size(77, 17);
            this.lblDIName.TabIndex = 3;
            this.lblDIName.Text = "DAT Name: ";
            this.lblDIName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DatInfoNameLb
            // 
            this.DatInfoNameLb.AutoSize = true;
            this.DatInfoNameLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatInfoNameLb.ContextMenuStrip = this.CopyTextCMS;
            this.DatInfoNameLb.Location = new System.Drawing.Point(80, 3);
            this.DatInfoNameLb.Margin = new System.Windows.Forms.Padding(3);
            this.DatInfoNameLb.Name = "DatInfoNameLb";
            this.DatInfoNameLb.Padding = new System.Windows.Forms.Padding(2);
            this.DatInfoNameLb.Size = new System.Drawing.Size(251, 23);
            this.DatInfoNameLb.TabIndex = 22;
            this.DatInfoNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VaultHeaderPN
            // 
            this.VaultHeaderPN.Controls.Add(this.DatPanelHeaderLB);
            this.VaultHeaderPN.Controls.Add(this.pictureBox1);
            this.VaultHeaderPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.VaultHeaderPN.Location = new System.Drawing.Point(2, 2);
            this.VaultHeaderPN.Name = "VaultHeaderPN";
            this.VaultHeaderPN.Padding = new System.Windows.Forms.Padding(2);
            this.VaultHeaderPN.Size = new System.Drawing.Size(334, 28);
            this.VaultHeaderPN.TabIndex = 7;
            // 
            // DatPanelHeaderLB
            // 
            this.DatPanelHeaderLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatPanelHeaderLB.Font = new System.Drawing.Font("Roboto", 11.7F, System.Drawing.FontStyle.Bold);
            this.DatPanelHeaderLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatPanelHeaderLB.Location = new System.Drawing.Point(26, 2);
            this.DatPanelHeaderLB.Name = "DatPanelHeaderLB";
            this.DatPanelHeaderLB.ScaleFactor = 1.2D;
            this.DatPanelHeaderLB.Size = new System.Drawing.Size(306, 24);
            this.DatPanelHeaderLB.TabIndex = 3;
            this.DatPanelHeaderLB.Text = "DATs";
            this.DatPanelHeaderLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ROMVault.Properties.Resources.databaseBig;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // splitGameInfoLists
            // 
            this.splitGameInfoLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGameInfoLists.Location = new System.Drawing.Point(4, 4);
            this.splitGameInfoLists.Name = "splitGameInfoLists";
            this.splitGameInfoLists.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGameInfoLists.Panel1
            // 
            this.splitGameInfoLists.Panel1.Controls.Add(this.PropertryGridSC);
            this.splitGameInfoLists.Panel1.Controls.Add(this.PgHeader);
            this.splitGameInfoLists.Panel1.Resize += new System.EventHandler(this.splitContainer4_Panel1_Resize);
            // 
            // splitGameInfoLists.Panel2
            // 
            this.splitGameInfoLists.Panel2.Controls.Add(this.splitListArt);
            this.splitGameInfoLists.Size = new System.Drawing.Size(806, 757);
            this.splitGameInfoLists.SplitterDistance = 244;
            this.splitGameInfoLists.TabIndex = 0;
            // 
            // PropertryGridSC
            // 
            this.PropertryGridSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertryGridSC.Location = new System.Drawing.Point(0, 31);
            this.PropertryGridSC.Name = "PropertryGridSC";
            // 
            // PropertryGridSC.Panel1
            // 
            this.PropertryGridSC.Panel1.Controls.Add(this.MainPG);
            // 
            // PropertryGridSC.Panel2
            // 
            this.PropertryGridSC.Panel2.Controls.Add(this.PropertyGridHelpTB);
            this.PropertryGridSC.Panel2Collapsed = true;
            this.PropertryGridSC.Size = new System.Drawing.Size(806, 213);
            this.PropertryGridSC.SplitterDistance = 627;
            this.PropertryGridSC.TabIndex = 6;
            // 
            // MainPG
            // 
            this.MainPG.CategoryForeColor = System.Drawing.Color.Cyan;
            this.MainPG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPG.HelpVisible = false;
            this.MainPG.Location = new System.Drawing.Point(0, 0);
            this.MainPG.Name = "MainPG";
            this.MainPG.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.MainPG.Size = new System.Drawing.Size(806, 213);
            this.MainPG.TabIndex = 0;
            this.MainPG.ToolbarVisible = false;
            this.MainPG.UseCompatibleTextRendering = true;
            this.MainPG.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.MainPG_SelectedGridItemChanged);
            this.MainPG.SelectedObjectsChanged += new System.EventHandler(this.MainPG_SelectedObjectsChanged);
            // 
            // PropertyGridHelpTB
            // 
            this.PropertyGridHelpTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyGridHelpTB.Location = new System.Drawing.Point(0, 0);
            this.PropertyGridHelpTB.Multiline = true;
            this.PropertyGridHelpTB.Name = "PropertyGridHelpTB";
            this.PropertyGridHelpTB.ReadOnly = true;
            this.PropertyGridHelpTB.Size = new System.Drawing.Size(96, 100);
            this.PropertyGridHelpTB.TabIndex = 5;
            // 
            // PgHeader
            // 
            this.PgHeader.Controls.Add(this.PgHeaderLB);
            this.PgHeader.Controls.Add(this.PropGridHelpBT);
            this.PgHeader.Controls.Add(this.PgHeaderPB);
            this.PgHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PgHeader.Location = new System.Drawing.Point(0, 0);
            this.PgHeader.Name = "PgHeader";
            this.PgHeader.Padding = new System.Windows.Forms.Padding(4);
            this.PgHeader.Size = new System.Drawing.Size(806, 31);
            this.PgHeader.TabIndex = 4;
            // 
            // PgHeaderLB
            // 
            this.PgHeaderLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PgHeaderLB.Font = new System.Drawing.Font("Roboto", 11.7F, System.Drawing.FontStyle.Bold);
            this.PgHeaderLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PgHeaderLB.Location = new System.Drawing.Point(31, 4);
            this.PgHeaderLB.Name = "PgHeaderLB";
            this.PgHeaderLB.ScaleFactor = 1.2D;
            this.PgHeaderLB.Size = new System.Drawing.Size(746, 23);
            this.PgHeaderLB.TabIndex = 3;
            this.PgHeaderLB.Text = "Welcome to RomVault";
            this.PgHeaderLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PropGridHelpBT
            // 
            this.PropGridHelpBT.BackgroundImage = global::ROMVault.Properties.Resources.question_frame;
            this.PropGridHelpBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PropGridHelpBT.Dock = System.Windows.Forms.DockStyle.Right;
            this.PropGridHelpBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.PropGridHelpBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PropGridHelpBT.Location = new System.Drawing.Point(777, 4);
            this.PropGridHelpBT.Name = "PropGridHelpBT";
            this.PropGridHelpBT.Size = new System.Drawing.Size(25, 23);
            this.PropGridHelpBT.TabIndex = 5;
            this.tooltip.SetToolTip(this.PropGridHelpBT, "Show Help");
            this.PropGridHelpBT.UseVisualStyleBackColor = true;
            this.PropGridHelpBT.Click += new System.EventHandler(this.PropGridHelpBT_Click);
            // 
            // PgHeaderPB
            // 
            this.PgHeaderPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PgHeaderPB.Dock = System.Windows.Forms.DockStyle.Left;
            this.PgHeaderPB.Image = global::ROMVault.Properties.Resources.smileyBig;
            this.PgHeaderPB.Location = new System.Drawing.Point(4, 4);
            this.PgHeaderPB.Name = "PgHeaderPB";
            this.PgHeaderPB.Padding = new System.Windows.Forms.Padding(4);
            this.PgHeaderPB.Size = new System.Drawing.Size(27, 23);
            this.PgHeaderPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PgHeaderPB.TabIndex = 4;
            this.PgHeaderPB.TabStop = false;
            this.PgHeaderPB.Click += new System.EventHandler(this.PgHeaderPB_Click);
            // 
            // splitListArt
            // 
            this.splitListArt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitListArt.Location = new System.Drawing.Point(0, 0);
            this.splitListArt.Name = "splitListArt";
            // 
            // splitListArt.Panel1
            // 
            this.splitListArt.Panel1.Controls.Add(this.GameRomPN);
            // 
            // splitListArt.Panel2
            // 
            this.splitListArt.Panel2.Controls.Add(this.TabEmuArc);
            this.splitListArt.Size = new System.Drawing.Size(806, 509);
            this.splitListArt.SplitterDistance = 621;
            this.splitListArt.TabIndex = 1;
            // 
            // GameRomPN
            // 
            this.GameRomPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameRomPN.Controls.Add(this.splitGameListRomList);
            this.GameRomPN.Controls.Add(this.GameRomTableTS);
            this.GameRomPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameRomPN.Location = new System.Drawing.Point(0, 0);
            this.GameRomPN.Name = "GameRomPN";
            this.GameRomPN.Size = new System.Drawing.Size(621, 509);
            this.GameRomPN.TabIndex = 1;
            // 
            // splitGameListRomList
            // 
            this.splitGameListRomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGameListRomList.Location = new System.Drawing.Point(0, 31);
            this.splitGameListRomList.Name = "splitGameListRomList";
            this.splitGameListRomList.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGameListRomList.Panel1
            // 
            this.splitGameListRomList.Panel1.Controls.Add(this.GameGrid);
            // 
            // splitGameListRomList.Panel2
            // 
            this.splitGameListRomList.Panel2.Controls.Add(this.RomGrid);
            this.splitGameListRomList.Size = new System.Drawing.Size(619, 476);
            this.splitGameListRomList.SplitterDistance = 297;
            this.splitGameListRomList.TabIndex = 0;
            // 
            // GameGrid
            // 
            this.GameGrid.AllowUserToAddRows = false;
            this.GameGrid.AllowUserToDeleteRows = false;
            this.GameGrid.AllowUserToResizeRows = false;
            this.GameGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GameGrid.BackgroundColor = System.Drawing.Color.White;
            this.GameGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CType,
            this.CGame,
            this.CDescription,
            this.CDateTime,
            this.CROMStatus});
            this.GameGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GameGrid.Location = new System.Drawing.Point(0, 0);
            this.GameGrid.MultiSelect = false;
            this.GameGrid.Name = "GameGrid";
            this.GameGrid.ReadOnly = true;
            this.GameGrid.RowHeadersVisible = false;
            this.GameGrid.RowHeadersWidth = 72;
            this.GameGrid.RowTemplate.Height = 19;
            this.GameGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GameGrid.ShowCellErrors = false;
            this.GameGrid.ShowCellToolTips = false;
            this.GameGrid.ShowEditingIcon = false;
            this.GameGrid.ShowRowErrors = false;
            this.GameGrid.Size = new System.Drawing.Size(619, 297);
            this.GameGrid.TabIndex = 4;
            this.GameGrid.VirtualMode = true;
            this.GameGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GameGridCellFormatting);
            this.GameGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.GameGridCellValueNeeded);
            this.GameGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GameGridColumnHeaderMouseClick);
            this.GameGrid.SelectionChanged += new System.EventHandler(this.GameGridSelectionChanged);
            this.GameGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.GameGridMouseDoubleClick);
            this.GameGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameGrid_MouseDown);
            this.GameGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameGridMouseUp);
            // 
            // CType
            // 
            this.CType.FillWeight = 40F;
            this.CType.HeaderText = "Type";
            this.CType.MinimumWidth = 9;
            this.CType.Name = "CType";
            this.CType.ReadOnly = true;
            this.CType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CType.Width = 40;
            // 
            // CGame
            // 
            this.CGame.HeaderText = "Game (Directory / Zip)";
            this.CGame.MinimumWidth = 9;
            this.CGame.Name = "CGame";
            this.CGame.ReadOnly = true;
            this.CGame.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CGame.Width = 220;
            // 
            // CDescription
            // 
            this.CDescription.HeaderText = "Description";
            this.CDescription.MinimumWidth = 9;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CDescription.Width = 220;
            // 
            // CDateTime
            // 
            this.CDateTime.HeaderText = "Modified";
            this.CDateTime.MinimumWidth = 8;
            this.CDateTime.Name = "CDateTime";
            this.CDateTime.ReadOnly = true;
            this.CDateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CDateTime.Width = 150;
            // 
            // CROMStatus
            // 
            this.CROMStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CROMStatus.FillWeight = 450F;
            this.CROMStatus.HeaderText = "ROM Status";
            this.CROMStatus.MinimumWidth = 200;
            this.CROMStatus.Name = "CROMStatus";
            this.CROMStatus.ReadOnly = true;
            this.CROMStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // RomGrid
            // 
            this.RomGrid.AllowUserToAddRows = false;
            this.RomGrid.AllowUserToDeleteRows = false;
            this.RomGrid.AllowUserToResizeRows = false;
            this.RomGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.RomGrid.BackgroundColor = System.Drawing.Color.White;
            this.RomGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CGot,
            this.CRom,
            this.CMerge,
            this.CSize,
            this.CCRC32,
            this.CSHA1,
            this.CMD5,
            this.CAltSize,
            this.CAltCRC32,
            this.CAltSHA1,
            this.CAltMD5,
            this.CStatus,
            this.CFileModDate,
            this.CZipIndex,
            this.CInstanceCount});
            this.RomGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RomGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RomGrid.Location = new System.Drawing.Point(0, 0);
            this.RomGrid.MultiSelect = false;
            this.RomGrid.Name = "RomGrid";
            this.RomGrid.ReadOnly = true;
            this.RomGrid.RowHeadersVisible = false;
            this.RomGrid.RowHeadersWidth = 72;
            this.RomGrid.RowTemplate.Height = 19;
            this.RomGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RomGrid.ShowCellErrors = false;
            this.RomGrid.ShowEditingIcon = false;
            this.RomGrid.ShowRowErrors = false;
            this.RomGrid.Size = new System.Drawing.Size(619, 175);
            this.RomGrid.TabIndex = 21;
            this.RomGrid.VirtualMode = true;
            this.RomGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RomGridCellFormatting);
            this.RomGrid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.RomGridCellValueNeeded);
            this.RomGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RomGridColumnHeaderMouseClick);
            this.RomGrid.SelectionChanged += new System.EventHandler(this.RomGridSelectionChanged);
            this.RomGrid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RomGridMouseUp);
            // 
            // CGot
            // 
            this.CGot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CGot.HeaderText = "Got";
            this.CGot.MinimumWidth = 9;
            this.CGot.Name = "CGot";
            this.CGot.ReadOnly = true;
            this.CGot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CGot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CGot.Width = 65;
            // 
            // CRom
            // 
            this.CRom.HeaderText = "ROM (File)";
            this.CRom.MinimumWidth = 9;
            this.CRom.Name = "CRom";
            this.CRom.ReadOnly = true;
            this.CRom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CRom.Width = 150;
            // 
            // CMerge
            // 
            this.CMerge.HeaderText = "Merge";
            this.CMerge.MinimumWidth = 9;
            this.CMerge.Name = "CMerge";
            this.CMerge.ReadOnly = true;
            this.CMerge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CMerge.Width = 60;
            // 
            // CSize
            // 
            this.CSize.HeaderText = "Size";
            this.CSize.MinimumWidth = 9;
            this.CSize.Name = "CSize";
            this.CSize.ReadOnly = true;
            this.CSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CSize.Width = 60;
            // 
            // CCRC32
            // 
            this.CCRC32.HeaderText = "CRC32";
            this.CCRC32.MinimumWidth = 9;
            this.CCRC32.Name = "CCRC32";
            this.CCRC32.ReadOnly = true;
            this.CCRC32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CCRC32.Width = 175;
            // 
            // CSHA1
            // 
            this.CSHA1.HeaderText = "SHA1";
            this.CSHA1.MinimumWidth = 9;
            this.CSHA1.Name = "CSHA1";
            this.CSHA1.ReadOnly = true;
            this.CSHA1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CSHA1.Width = 150;
            // 
            // CMD5
            // 
            this.CMD5.HeaderText = "MD5";
            this.CMD5.MinimumWidth = 9;
            this.CMD5.Name = "CMD5";
            this.CMD5.ReadOnly = true;
            this.CMD5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CMD5.Width = 150;
            // 
            // CAltSize
            // 
            this.CAltSize.HeaderText = "AltSize";
            this.CAltSize.MinimumWidth = 9;
            this.CAltSize.Name = "CAltSize";
            this.CAltSize.ReadOnly = true;
            this.CAltSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CAltSize.Visible = false;
            this.CAltSize.Width = 60;
            // 
            // CAltCRC32
            // 
            this.CAltCRC32.HeaderText = "AltCRC32";
            this.CAltCRC32.MinimumWidth = 9;
            this.CAltCRC32.Name = "CAltCRC32";
            this.CAltCRC32.ReadOnly = true;
            this.CAltCRC32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CAltCRC32.Visible = false;
            this.CAltCRC32.Width = 175;
            // 
            // CAltSHA1
            // 
            this.CAltSHA1.HeaderText = "AltSHA1";
            this.CAltSHA1.MinimumWidth = 9;
            this.CAltSHA1.Name = "CAltSHA1";
            this.CAltSHA1.ReadOnly = true;
            this.CAltSHA1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CAltSHA1.Visible = false;
            this.CAltSHA1.Width = 150;
            // 
            // CAltMD5
            // 
            this.CAltMD5.HeaderText = "AltMD5";
            this.CAltMD5.MinimumWidth = 9;
            this.CAltMD5.Name = "CAltMD5";
            this.CAltMD5.ReadOnly = true;
            this.CAltMD5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CAltMD5.Visible = false;
            this.CAltMD5.Width = 150;
            // 
            // CStatus
            // 
            this.CStatus.HeaderText = "Status";
            this.CStatus.MinimumWidth = 9;
            this.CStatus.Name = "CStatus";
            this.CStatus.ReadOnly = true;
            this.CStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CStatus.Width = 175;
            // 
            // CFileModDate
            // 
            this.CFileModDate.HeaderText = "Modified Date/Time";
            this.CFileModDate.MinimumWidth = 9;
            this.CFileModDate.Name = "CFileModDate";
            this.CFileModDate.ReadOnly = true;
            this.CFileModDate.Width = 175;
            // 
            // CZipIndex
            // 
            this.CZipIndex.HeaderText = "ZipIndex";
            this.CZipIndex.MinimumWidth = 9;
            this.CZipIndex.Name = "CZipIndex";
            this.CZipIndex.ReadOnly = true;
            this.CZipIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CZipIndex.Width = 175;
            // 
            // CInstanceCount
            // 
            this.CInstanceCount.HeaderText = "Instance Count";
            this.CInstanceCount.MinimumWidth = 6;
            this.CInstanceCount.Name = "CInstanceCount";
            this.CInstanceCount.ReadOnly = true;
            this.CInstanceCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CInstanceCount.Width = 125;
            // 
            // GameRomTableTS
            // 
            this.GameRomTableTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.GameRomTableTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameRomToHomeBT,
            this.AutoSizeGameColChB,
            this.toolStripSeparator4,
            this.FilterTSDD,
            this.gameSearchTSTB,
            this.gameSearchTSBT,
            this.gameSearchClearBT,
            this.GameGridRowCountLB});
            this.GameRomTableTS.Location = new System.Drawing.Point(0, 0);
            this.GameRomTableTS.Name = "GameRomTableTS";
            this.GameRomTableTS.Padding = new System.Windows.Forms.Padding(4);
            this.GameRomTableTS.Size = new System.Drawing.Size(619, 31);
            this.GameRomTableTS.TabIndex = 0;
            this.GameRomTableTS.Text = "Navigate to Root";
            // 
            // GameRomToHomeBT
            // 
            this.GameRomToHomeBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GameRomToHomeBT.Image = ((System.Drawing.Image)(resources.GetObject("GameRomToHomeBT.Image")));
            this.GameRomToHomeBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GameRomToHomeBT.Name = "GameRomToHomeBT";
            this.GameRomToHomeBT.Size = new System.Drawing.Size(23, 20);
            this.GameRomToHomeBT.Text = "toolStripButton1";
            this.GameRomToHomeBT.ToolTipText = "Home Directory";
            this.GameRomToHomeBT.Click += new System.EventHandler(this.GameRomToHomeBT_Click);
            // 
            // AutoSizeGameColChB
            // 
            this.AutoSizeGameColChB.Checked = true;
            this.AutoSizeGameColChB.CheckOnClick = true;
            this.AutoSizeGameColChB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoSizeGameColChB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AutoSizeGameColChB.Image = global::ROMVault.Properties.Resources.table_join_column;
            this.AutoSizeGameColChB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AutoSizeGameColChB.Name = "AutoSizeGameColChB";
            this.AutoSizeGameColChB.Size = new System.Drawing.Size(23, 20);
            this.AutoSizeGameColChB.Text = "Autosize Game Column";
            this.AutoSizeGameColChB.Click += new System.EventHandler(this.AutoSizeGameColChB_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // FilterTSDD
            // 
            this.FilterTSDD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilterTSDD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chkBoxShowCompleteTSI,
            this.chkBoxShowPartialTSI,
            this.chkBoxShowEmptyTSI,
            this.chkBoxShowFixesTSI,
            this.chkBoxShowMIATSI,
            this.chkBoxShowMergedTSI,
            this.toolStripSeparator5,
            this.toggleToolStripMenuItem,
            this.setAllToolStripMenuItem});
            this.FilterTSDD.Image = global::ROMVault.Properties.Resources.funnel;
            this.FilterTSDD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterTSDD.Name = "FilterTSDD";
            this.FilterTSDD.Size = new System.Drawing.Size(29, 20);
            this.FilterTSDD.Text = "Filter Results";
            // 
            // chkBoxShowCompleteTSI
            // 
            this.chkBoxShowCompleteTSI.Checked = true;
            this.chkBoxShowCompleteTSI.CheckOnClick = true;
            this.chkBoxShowCompleteTSI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowCompleteTSI.Name = "chkBoxShowCompleteTSI";
            this.chkBoxShowCompleteTSI.Size = new System.Drawing.Size(167, 22);
            this.chkBoxShowCompleteTSI.Text = "Complete";
            this.chkBoxShowCompleteTSI.CheckedChanged += new System.EventHandler(this.completeToolStripMenuItem_Click);
            this.chkBoxShowCompleteTSI.Click += new System.EventHandler(this.completeToolStripMenuItem_Click);
            // 
            // chkBoxShowPartialTSI
            // 
            this.chkBoxShowPartialTSI.Checked = true;
            this.chkBoxShowPartialTSI.CheckOnClick = true;
            this.chkBoxShowPartialTSI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowPartialTSI.Name = "chkBoxShowPartialTSI";
            this.chkBoxShowPartialTSI.Size = new System.Drawing.Size(167, 22);
            this.chkBoxShowPartialTSI.Text = "Partial";
            this.chkBoxShowPartialTSI.Click += new System.EventHandler(this.paToolStripMenuItem_Click);
            // 
            // chkBoxShowEmptyTSI
            // 
            this.chkBoxShowEmptyTSI.Checked = true;
            this.chkBoxShowEmptyTSI.CheckOnClick = true;
            this.chkBoxShowEmptyTSI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowEmptyTSI.Name = "chkBoxShowEmptyTSI";
            this.chkBoxShowEmptyTSI.Size = new System.Drawing.Size(167, 22);
            this.chkBoxShowEmptyTSI.Text = "Empty";
            this.chkBoxShowEmptyTSI.Click += new System.EventHandler(this.emptyToolStripMenuItem_Click);
            // 
            // chkBoxShowFixesTSI
            // 
            this.chkBoxShowFixesTSI.Checked = true;
            this.chkBoxShowFixesTSI.CheckOnClick = true;
            this.chkBoxShowFixesTSI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowFixesTSI.Name = "chkBoxShowFixesTSI";
            this.chkBoxShowFixesTSI.Size = new System.Drawing.Size(167, 22);
            this.chkBoxShowFixesTSI.Text = "Fixes";
            this.chkBoxShowFixesTSI.Click += new System.EventHandler(this.fixesToolStripMenuItem_Click);
            // 
            // chkBoxShowMIATSI
            // 
            this.chkBoxShowMIATSI.Checked = true;
            this.chkBoxShowMIATSI.CheckOnClick = true;
            this.chkBoxShowMIATSI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowMIATSI.Name = "chkBoxShowMIATSI";
            this.chkBoxShowMIATSI.Size = new System.Drawing.Size(167, 22);
            this.chkBoxShowMIATSI.Text = "MIA";
            this.chkBoxShowMIATSI.Click += new System.EventHandler(this.mIAToolStripMenuItem_Click);
            // 
            // chkBoxShowMergedTSI
            // 
            this.chkBoxShowMergedTSI.Checked = true;
            this.chkBoxShowMergedTSI.CheckOnClick = true;
            this.chkBoxShowMergedTSI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowMergedTSI.Name = "chkBoxShowMergedTSI";
            this.chkBoxShowMergedTSI.Size = new System.Drawing.Size(167, 22);
            this.chkBoxShowMergedTSI.Text = "Merged/Duped";
            this.chkBoxShowMergedTSI.Click += new System.EventHandler(this.mergedDupedToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // toggleToolStripMenuItem
            // 
            this.toggleToolStripMenuItem.Name = "toggleToolStripMenuItem";
            this.toggleToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.toggleToolStripMenuItem.Text = "Toggle";
            this.toggleToolStripMenuItem.Click += new System.EventHandler(this.toggleToolStripMenuItem_Click);
            // 
            // setAllToolStripMenuItem
            // 
            this.setAllToolStripMenuItem.Name = "setAllToolStripMenuItem";
            this.setAllToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.setAllToolStripMenuItem.Text = "Clear All";
            this.setAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // gameSearchTSTB
            // 
            this.gameSearchTSTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gameSearchTSTB.Name = "gameSearchTSTB";
            this.gameSearchTSTB.Size = new System.Drawing.Size(120, 23);
            this.gameSearchTSTB.Enter += new System.EventHandler(this.gameSearchTSTB_Enter);
            this.gameSearchTSTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gameSearchTSTB_KeyPress);
            // 
            // gameSearchTSBT
            // 
            this.gameSearchTSBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gameSearchTSBT.Image = global::ROMVault.Properties.Resources.magnifier_left;
            this.gameSearchTSBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gameSearchTSBT.Name = "gameSearchTSBT";
            this.gameSearchTSBT.Size = new System.Drawing.Size(23, 20);
            this.gameSearchTSBT.Text = "Search Results";
            this.gameSearchTSBT.Click += new System.EventHandler(this.gameSearchTSBT_Click);
            // 
            // gameSearchClearBT
            // 
            this.gameSearchClearBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gameSearchClearBT.Image = global::ROMVault.Properties.Resources.cross;
            this.gameSearchClearBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gameSearchClearBT.Name = "gameSearchClearBT";
            this.gameSearchClearBT.Size = new System.Drawing.Size(23, 20);
            this.gameSearchClearBT.Text = "Clear Search";
            this.gameSearchClearBT.Click += new System.EventHandler(this.gameSearchClearBT_Click);
            // 
            // GameGridRowCountLB
            // 
            this.GameGridRowCountLB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.GameGridRowCountLB.Name = "GameGridRowCountLB";
            this.GameGridRowCountLB.Size = new System.Drawing.Size(104, 20);
            this.GameGridRowCountLB.Text = "No row selected";
            // 
            // TabEmuArc
            // 
            this.TabEmuArc.Controls.Add(this.tabArtWork);
            this.TabEmuArc.Controls.Add(this.tabMedium);
            this.TabEmuArc.Controls.Add(this.tabScreens);
            this.TabEmuArc.Controls.Add(this.tabInfo);
            this.TabEmuArc.Controls.Add(this.tabInfo2);
            this.TabEmuArc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabEmuArc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.TabEmuArc.Location = new System.Drawing.Point(0, 0);
            this.TabEmuArc.Name = "TabEmuArc";
            this.TabEmuArc.SelectedIndex = 0;
            this.TabEmuArc.Size = new System.Drawing.Size(181, 509);
            this.TabEmuArc.TabIndex = 0;
            // 
            // tabArtWork
            // 
            this.tabArtWork.BackColor = System.Drawing.SystemColors.Control;
            this.tabArtWork.Controls.Add(this.picLogo);
            this.tabArtWork.Controls.Add(this.picArtwork);
            this.tabArtWork.Location = new System.Drawing.Point(4, 22);
            this.tabArtWork.Name = "tabArtWork";
            this.tabArtWork.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtWork.Size = new System.Drawing.Size(173, 483);
            this.tabArtWork.TabIndex = 0;
            this.tabArtWork.Text = "ArtWork";
            this.tabArtWork.Resize += new System.EventHandler(this.tabArtWork_Resize);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(14, 197);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(114, 117);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // picArtwork
            // 
            this.picArtwork.BackColor = System.Drawing.Color.White;
            this.picArtwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picArtwork.Location = new System.Drawing.Point(13, 60);
            this.picArtwork.Name = "picArtwork";
            this.picArtwork.Size = new System.Drawing.Size(116, 104);
            this.picArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArtwork.TabIndex = 0;
            this.picArtwork.TabStop = false;
            // 
            // tabMedium
            // 
            this.tabMedium.BackColor = System.Drawing.SystemColors.Control;
            this.tabMedium.Controls.Add(this.picMedium2);
            this.tabMedium.Controls.Add(this.picMedium1);
            this.tabMedium.Location = new System.Drawing.Point(4, 22);
            this.tabMedium.Name = "tabMedium";
            this.tabMedium.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedium.Size = new System.Drawing.Size(173, 483);
            this.tabMedium.TabIndex = 3;
            this.tabMedium.Text = "Medium";
            this.tabMedium.Resize += new System.EventHandler(this.tabMedium_Resize);
            // 
            // picMedium2
            // 
            this.picMedium2.BackColor = System.Drawing.Color.White;
            this.picMedium2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMedium2.Location = new System.Drawing.Point(24, 283);
            this.picMedium2.Name = "picMedium2";
            this.picMedium2.Size = new System.Drawing.Size(114, 117);
            this.picMedium2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMedium2.TabIndex = 3;
            this.picMedium2.TabStop = false;
            // 
            // picMedium1
            // 
            this.picMedium1.BackColor = System.Drawing.Color.White;
            this.picMedium1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMedium1.Location = new System.Drawing.Point(23, 146);
            this.picMedium1.Name = "picMedium1";
            this.picMedium1.Size = new System.Drawing.Size(116, 104);
            this.picMedium1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMedium1.TabIndex = 2;
            this.picMedium1.TabStop = false;
            // 
            // tabScreens
            // 
            this.tabScreens.BackColor = System.Drawing.SystemColors.Control;
            this.tabScreens.Controls.Add(this.picScreenShot);
            this.tabScreens.Controls.Add(this.picScreenTitle);
            this.tabScreens.Location = new System.Drawing.Point(4, 22);
            this.tabScreens.Name = "tabScreens";
            this.tabScreens.Padding = new System.Windows.Forms.Padding(3);
            this.tabScreens.Size = new System.Drawing.Size(173, 483);
            this.tabScreens.TabIndex = 1;
            this.tabScreens.Text = "Screens";
            this.tabScreens.Resize += new System.EventHandler(this.tabScreens_Resize);
            // 
            // picScreenShot
            // 
            this.picScreenShot.BackColor = System.Drawing.Color.White;
            this.picScreenShot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picScreenShot.Location = new System.Drawing.Point(15, 218);
            this.picScreenShot.Name = "picScreenShot";
            this.picScreenShot.Size = new System.Drawing.Size(104, 113);
            this.picScreenShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScreenShot.TabIndex = 1;
            this.picScreenShot.TabStop = false;
            // 
            // picScreenTitle
            // 
            this.picScreenTitle.BackColor = System.Drawing.Color.White;
            this.picScreenTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picScreenTitle.Location = new System.Drawing.Point(15, 69);
            this.picScreenTitle.Name = "picScreenTitle";
            this.picScreenTitle.Size = new System.Drawing.Size(104, 117);
            this.picScreenTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picScreenTitle.TabIndex = 0;
            this.picScreenTitle.TabStop = false;
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tabInfo.Controls.Add(this.txtInfo);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(173, 483);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Info";
            this.tabInfo.Resize += new System.EventHandler(this.tabInfo_Resize);
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Font = new System.Drawing.Font("Consolas", 7F);
            this.txtInfo.Location = new System.Drawing.Point(0, 0);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(173, 483);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.WordWrap = false;
            // 
            // tabInfo2
            // 
            this.tabInfo2.BackColor = System.Drawing.SystemColors.Control;
            this.tabInfo2.Controls.Add(this.txtInfo2);
            this.tabInfo2.Location = new System.Drawing.Point(4, 22);
            this.tabInfo2.Name = "tabInfo2";
            this.tabInfo2.Size = new System.Drawing.Size(173, 483);
            this.tabInfo2.TabIndex = 4;
            this.tabInfo2.Text = "Info2";
            // 
            // txtInfo2
            // 
            this.txtInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo2.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo2.Location = new System.Drawing.Point(0, 0);
            this.txtInfo2.Multiline = true;
            this.txtInfo2.Name = "txtInfo2";
            this.txtInfo2.ReadOnly = true;
            this.txtInfo2.Size = new System.Drawing.Size(173, 483);
            this.txtInfo2.TabIndex = 2;
            this.txtInfo2.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUpdateDATs,
            this.tsmScanROMs,
            this.tsmFindFixes,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmUpdateDATs
            // 
            this.tsmUpdateDATs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateNewDATsToolStripMenuItem,
            this.updateAllDATsToolStripMenuItem,
            this.addBlankDATToolStripMenuItem,
            this.toolStripSeparator9,
            this.DatProvidersTSI});
            this.tsmUpdateDATs.Name = "tsmUpdateDATs";
            this.tsmUpdateDATs.Size = new System.Drawing.Size(48, 21);
            this.tsmUpdateDATs.Text = "DATs";
            // 
            // updateNewDATsToolStripMenuItem
            // 
            this.updateNewDATsToolStripMenuItem.Image = global::ROMVault.Properties.Resources.arrowCircle;
            this.updateNewDATsToolStripMenuItem.Name = "updateNewDATsToolStripMenuItem";
            this.updateNewDATsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.updateNewDATsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.updateNewDATsToolStripMenuItem.Text = "Update New DATs";
            this.updateNewDATsToolStripMenuItem.Click += new System.EventHandler(this.updateNewDATsToolStripMenuItem_Click);
            // 
            // updateAllDATsToolStripMenuItem
            // 
            this.updateAllDATsToolStripMenuItem.Name = "updateAllDATsToolStripMenuItem";
            this.updateAllDATsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.updateAllDATsToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.updateAllDATsToolStripMenuItem.Text = "Refresh All DATs";
            this.updateAllDATsToolStripMenuItem.Click += new System.EventHandler(this.updateAllDATsToolStripMenuItem_Click);
            // 
            // addBlankDATToolStripMenuItem
            // 
            this.addBlankDATToolStripMenuItem.Name = "addBlankDATToolStripMenuItem";
            this.addBlankDATToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.addBlankDATToolStripMenuItem.Text = "Add Blank DAT";
            this.addBlankDATToolStripMenuItem.Click += new System.EventHandler(this.addBlankDATToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(222, 6);
            // 
            // DatProvidersTSI
            // 
            this.DatProvidersTSI.Name = "DatProvidersTSI";
            this.DatProvidersTSI.Size = new System.Drawing.Size(225, 22);
            this.DatProvidersTSI.Text = "DAT Providers:";
            // 
            // tsmScanROMs
            // 
            this.tsmScanROMs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToSortFolderToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmScanLevel1,
            this.tsmScanLevel2,
            this.tsmScanLevel3,
            this.toolStripSeparator10,
            this.RomProvidersTSI});
            this.tsmScanROMs.Name = "tsmScanROMs";
            this.tsmScanROMs.Size = new System.Drawing.Size(56, 21);
            this.tsmScanROMs.Text = "ROMs";
            // 
            // addNewToSortFolderToolStripMenuItem
            // 
            this.addNewToSortFolderToolStripMenuItem.Image = global::ROMVault.Properties.Resources.blue_folder__plus;
            this.addNewToSortFolderToolStripMenuItem.Name = "addNewToSortFolderToolStripMenuItem";
            this.addNewToSortFolderToolStripMenuItem.Size = new System.Drawing.Size(379, 22);
            this.addNewToSortFolderToolStripMenuItem.Text = "Add New ToSort Folder";
            this.addNewToSortFolderToolStripMenuItem.Click += new System.EventHandler(this.addNewToSortFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(376, 6);
            // 
            // tsmScanLevel1
            // 
            this.tsmScanLevel1.Image = global::ROMVault.Properties.Resources.arrowCircle;
            this.tsmScanLevel1.Name = "tsmScanLevel1";
            this.tsmScanLevel1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
            this.tsmScanLevel1.Size = new System.Drawing.Size(379, 22);
            this.tsmScanLevel1.Text = "Scan ticked new ROMs headers only";
            this.tsmScanLevel1.Click += new System.EventHandler(this.TsmScanLevel1Click);
            // 
            // tsmScanLevel2
            // 
            this.tsmScanLevel2.Name = "tsmScanLevel2";
            this.tsmScanLevel2.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsmScanLevel2.Size = new System.Drawing.Size(379, 22);
            this.tsmScanLevel2.Text = "Scan ticked new ROMs with full hash check";
            this.tsmScanLevel2.Click += new System.EventHandler(this.TsmScanLevel2Click);
            // 
            // tsmScanLevel3
            // 
            this.tsmScanLevel3.Name = "tsmScanLevel3";
            this.tsmScanLevel3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.tsmScanLevel3.Size = new System.Drawing.Size(379, 22);
            this.tsmScanLevel3.Text = "ReScan All ticked ROMs with full hash check";
            this.tsmScanLevel3.Click += new System.EventHandler(this.TsmScanLevel3Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(376, 6);
            // 
            // RomProvidersTSI
            // 
            this.RomProvidersTSI.Name = "RomProvidersTSI";
            this.RomProvidersTSI.Size = new System.Drawing.Size(379, 22);
            this.RomProvidersTSI.Text = "ROM Providers:";
            // 
            // tsmFindFixes
            // 
            this.tsmFindFixes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findFixesToolStripMenuItem,
            this.findFixeswithLogToolStripMenuItem,
            this.toolStripSeparator1,
            this.fixROMsToolStripMenuItem1,
            this.scanFindAndFixROMsToolStripMenuItem});
            this.tsmFindFixes.Name = "tsmFindFixes";
            this.tsmFindFixes.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tsmFindFixes.Size = new System.Drawing.Size(48, 21);
            this.tsmFindFixes.Text = "Fixes";
            // 
            // findFixesToolStripMenuItem
            // 
            this.findFixesToolStripMenuItem.Image = global::ROMVault.Properties.Resources.magnifier_zoom;
            this.findFixesToolStripMenuItem.Name = "findFixesToolStripMenuItem";
            this.findFixesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.findFixesToolStripMenuItem.Text = "Find Fixes";
            this.findFixesToolStripMenuItem.Click += new System.EventHandler(this.findFixesToolStripMenuItem_Click);
            // 
            // findFixeswithLogToolStripMenuItem
            // 
            this.findFixeswithLogToolStripMenuItem.Name = "findFixeswithLogToolStripMenuItem";
            this.findFixeswithLogToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.findFixeswithLogToolStripMenuItem.Text = "Find Fixes (with log)";
            this.findFixeswithLogToolStripMenuItem.Click += new System.EventHandler(this.findFixeswithLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // fixROMsToolStripMenuItem1
            // 
            this.fixROMsToolStripMenuItem1.Image = global::ROMVault.Properties.Resources.wand_magic;
            this.fixROMsToolStripMenuItem1.Name = "fixROMsToolStripMenuItem1";
            this.fixROMsToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.fixROMsToolStripMenuItem1.Text = "Fix ROMs";
            this.fixROMsToolStripMenuItem1.Click += new System.EventHandler(this.fixROMsToolStripMenuItem1_Click);
            // 
            // scanFindAndFixROMsToolStripMenuItem
            // 
            this.scanFindAndFixROMsToolStripMenuItem.Name = "scanFindAndFixROMsToolStripMenuItem";
            this.scanFindAndFixROMsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.scanFindAndFixROMsToolStripMenuItem.Text = "Scan and Fix ROMs";
            this.scanFindAndFixROMsToolStripMenuItem.ToolTipText = "This combines operations: scans ROMs, finds fixes and applies them";
            this.scanFindAndFixROMsToolStripMenuItem.Click += new System.EventHandler(this.scanFindAndFixROMsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderCReatorWizardToolStripMenuItem,
            this.toolStripSeparator8,
            this.fixDatReportToolStripMenuItem,
            this.fullReportToolStripMenuItem,
            this.fixReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.reportsToolStripMenuItem.Text = "Tools";
            // 
            // folderCReatorWizardToolStripMenuItem
            // 
            this.folderCReatorWizardToolStripMenuItem.Image = global::ROMVault.Properties.Resources.folder_smiley1;
            this.folderCReatorWizardToolStripMenuItem.Name = "folderCReatorWizardToolStripMenuItem";
            this.folderCReatorWizardToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.folderCReatorWizardToolStripMenuItem.Text = "Folder Creator Wizard";
            this.folderCReatorWizardToolStripMenuItem.Click += new System.EventHandler(this.folderCReatorWizardToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(203, 6);
            // 
            // fixDatReportToolStripMenuItem
            // 
            this.fixDatReportToolStripMenuItem.Image = global::ROMVault.Properties.Resources.blue_document_text;
            this.fixDatReportToolStripMenuItem.Name = "fixDatReportToolStripMenuItem";
            this.fixDatReportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.fixDatReportToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.fixDatReportToolStripMenuItem.Text = "Fix Dat Report";
            this.fixDatReportToolStripMenuItem.Click += new System.EventHandler(this.fixDatReportToolStripMenuItem_Click);
            // 
            // fullReportToolStripMenuItem
            // 
            this.fullReportToolStripMenuItem.Name = "fullReportToolStripMenuItem";
            this.fullReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F9)));
            this.fullReportToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.fullReportToolStripMenuItem.Text = "Full Report";
            this.fullReportToolStripMenuItem.Click += new System.EventHandler(this.fullReportToolStripMenuItem_Click);
            // 
            // fixReportToolStripMenuItem
            // 
            this.fixReportToolStripMenuItem.Name = "fixReportToolStripMenuItem";
            this.fixReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F9)));
            this.fixReportToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.fixReportToolStripMenuItem.Text = "Fix Report";
            this.fixReportToolStripMenuItem.Click += new System.EventHandler(this.fixReportToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directorySettingsToolStripMenuItem,
            this.directoryMappingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.darkModeToolStripMenuItem,
            this.toolStripSeparator6,
            this.romVaultSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // directorySettingsToolStripMenuItem
            // 
            this.directorySettingsToolStripMenuItem.Image = global::ROMVault.Properties.Resources.database_property;
            this.directorySettingsToolStripMenuItem.Name = "directorySettingsToolStripMenuItem";
            this.directorySettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.directorySettingsToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.directorySettingsToolStripMenuItem.Text = "DAT Rules";
            this.directorySettingsToolStripMenuItem.Click += new System.EventHandler(this.DirectorySettingsToolStripMenuItem_Click);
            // 
            // directoryMappingsToolStripMenuItem
            // 
            this.directoryMappingsToolStripMenuItem.Image = global::ROMVault.Properties.Resources.DatRom;
            this.directoryMappingsToolStripMenuItem.Name = "directoryMappingsToolStripMenuItem";
            this.directoryMappingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.directoryMappingsToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.directoryMappingsToolStripMenuItem.Text = "ROM Folder Mappings";
            this.directoryMappingsToolStripMenuItem.Click += new System.EventHandler(this.directoryMappingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(264, 6);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.CheckOnClick = true;
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(264, 6);
            // 
            // romVaultSettingsToolStripMenuItem
            // 
            this.romVaultSettingsToolStripMenuItem.Image = global::ROMVault.Properties.Resources.gear;
            this.romVaultSettingsToolStripMenuItem.Name = "romVaultSettingsToolStripMenuItem";
            this.romVaultSettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.romVaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.romVaultSettingsToolStripMenuItem.Text = "RomVault Settings";
            this.romVaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.RomVaultSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torrentZipToolStripMenuItem,
            this.visitHelpWikiToolStripMenuItem,
            this.whatsNewToolStripMenuItem,
            this.toolStripSeparator7,
            this.colorKeyToolStripMenuItem,
            this.aboutRomVaultToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // torrentZipToolStripMenuItem
            // 
            this.torrentZipToolStripMenuItem.Name = "torrentZipToolStripMenuItem";
            this.torrentZipToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.torrentZipToolStripMenuItem.Text = "Structured Archive Maker";
            this.torrentZipToolStripMenuItem.Click += new System.EventHandler(this.torrentZipToolStripMenuItem_Click);
            // 
            // visitHelpWikiToolStripMenuItem
            // 
            this.visitHelpWikiToolStripMenuItem.Name = "visitHelpWikiToolStripMenuItem";
            this.visitHelpWikiToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.visitHelpWikiToolStripMenuItem.Text = "Visit Help Wiki";
            this.visitHelpWikiToolStripMenuItem.Click += new System.EventHandler(this.visitHelpWikiToolStripMenuItem_Click);
            // 
            // whatsNewToolStripMenuItem
            // 
            this.whatsNewToolStripMenuItem.Name = "whatsNewToolStripMenuItem";
            this.whatsNewToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.whatsNewToolStripMenuItem.Text = "Whats New";
            this.whatsNewToolStripMenuItem.Click += new System.EventHandler(this.whatsNewToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(220, 6);
            // 
            // colorKeyToolStripMenuItem
            // 
            this.colorKeyToolStripMenuItem.Name = "colorKeyToolStripMenuItem";
            this.colorKeyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.colorKeyToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.colorKeyToolStripMenuItem.Text = "Color Key";
            this.colorKeyToolStripMenuItem.Click += new System.EventHandler(this.colorKeyToolStripMenuItem_Click);
            // 
            // aboutRomVaultToolStripMenuItem
            // 
            this.aboutRomVaultToolStripMenuItem.Name = "aboutRomVaultToolStripMenuItem";
            this.aboutRomVaultToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutRomVaultToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.aboutRomVaultToolStripMenuItem.Text = "About RomVault";
            this.aboutRomVaultToolStripMenuItem.Click += new System.EventHandler(this.AboutRomVaultToolStripMenuItemClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 40F;
            this.dataGridViewImageColumn1.HeaderText = "Type";
            this.dataGridViewImageColumn1.MinimumWidth = 9;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "ROM Status";
            this.dataGridViewImageColumn2.MinimumWidth = 9;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 300;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn3.HeaderText = "Got";
            this.dataGridViewImageColumn3.MinimumWidth = 9;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 65;
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // garbageCollectToolStripMenuItem
            // 
            this.garbageCollectToolStripMenuItem.Name = "garbageCollectToolStripMenuItem";
            this.garbageCollectToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // MainSS
            // 
            this.MainSS.AllowItemReorder = true;
            this.MainSS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CollapseAllSSBT,
            this.DatsControlSSBT,
            this.RomsControlSSBT});
            this.MainSS.Location = new System.Drawing.Point(0, 790);
            this.MainSS.Name = "MainSS";
            this.MainSS.Size = new System.Drawing.Size(1300, 30);
            this.MainSS.TabIndex = 7;
            this.MainSS.Text = "statusStrip1";
            // 
            // CollapseAllSSBT
            // 
            this.CollapseAllSSBT.Image = global::ROMVault.Properties.Resources.MenuCollapse;
            this.CollapseAllSSBT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 2);
            this.CollapseAllSSBT.Name = "CollapseAllSSBT";
            this.CollapseAllSSBT.Size = new System.Drawing.Size(24, 25);
            this.CollapseAllSSBT.ToolTipText = "Collapse All\r\nR-Click on Dropdown = Show/Hide\r\nShift+R-Click on Dropdown = Toggle" +
    " Text";
            this.CollapseAllSSBT.Click += new System.EventHandler(this.ToggleStatusTextBT_Click);
            this.CollapseAllSSBT.MouseEnter += new System.EventHandler(this.CollapseAllSSBT_MouseEnter);
            this.CollapseAllSSBT.MouseLeave += new System.EventHandler(this.CollapseAllSSBT_MouseLeave);
            // 
            // DatsControlSSBT
            // 
            this.DatsControlSSBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DatsControlSSBT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatsGroupVisibilitySSBT,
            this.DatsShortnameToggleSSBT});
            this.DatsControlSSBT.Image = global::ROMVault.Properties.Resources.database;
            this.DatsControlSSBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DatsControlSSBT.Name = "DatsControlSSBT";
            this.DatsControlSSBT.Size = new System.Drawing.Size(37, 28);
            this.DatsControlSSBT.Text = "toolStripDropDownButton1";
            this.DatsControlSSBT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DatsControlSSBT_MouseDown);
            // 
            // DatsGroupVisibilitySSBT
            // 
            this.DatsGroupVisibilitySSBT.Name = "DatsGroupVisibilitySSBT";
            this.DatsGroupVisibilitySSBT.Size = new System.Drawing.Size(208, 22);
            this.DatsGroupVisibilitySSBT.Text = "Toggle Group Visibility";
            this.DatsGroupVisibilitySSBT.Click += new System.EventHandler(this.DatsGroupVisibilitySSBT_Click);
            // 
            // DatsShortnameToggleSSBT
            // 
            this.DatsShortnameToggleSSBT.Name = "DatsShortnameToggleSSBT";
            this.DatsShortnameToggleSSBT.Size = new System.Drawing.Size(208, 22);
            this.DatsShortnameToggleSSBT.Text = "Toggle Shortname";
            this.DatsShortnameToggleSSBT.Click += new System.EventHandler(this.DatsShortnameToggleSSBT_Click);
            // 
            // RomsControlSSBT
            // 
            this.RomsControlSSBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RomsControlSSBT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RomsGroupVisibilitySSBT,
            this.RomsShortnameToggleSSBT});
            this.RomsControlSSBT.Image = global::ROMVault.Properties.Resources.disc;
            this.RomsControlSSBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RomsControlSSBT.Name = "RomsControlSSBT";
            this.RomsControlSSBT.Size = new System.Drawing.Size(37, 28);
            this.RomsControlSSBT.Text = "toolStripDropDownButton1";
            this.RomsControlSSBT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RomsControlSSBT_MouseDown);
            // 
            // RomsGroupVisibilitySSBT
            // 
            this.RomsGroupVisibilitySSBT.Name = "RomsGroupVisibilitySSBT";
            this.RomsGroupVisibilitySSBT.Size = new System.Drawing.Size(208, 22);
            this.RomsGroupVisibilitySSBT.Text = "Toggle Group Visibility";
            this.RomsGroupVisibilitySSBT.Click += new System.EventHandler(this.RomsGroupVisibilitySSBT_Click);
            // 
            // RomsShortnameToggleSSBT
            // 
            this.RomsShortnameToggleSSBT.Name = "RomsShortnameToggleSSBT";
            this.RomsShortnameToggleSSBT.Size = new System.Drawing.Size(208, 22);
            this.RomsShortnameToggleSSBT.Text = "Toggle Shortname";
            this.RomsShortnameToggleSSBT.Click += new System.EventHandler(this.RomsShortnameToggleSSBT_Click);
            // 
            // tooltip
            // 
            this.tooltip.AutoPopDelay = 32767;
            this.tooltip.InitialDelay = 1000;
            this.tooltip.OwnerDraw = true;
            this.tooltip.ReshowDelay = 500;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.splitToolBarMain);
            this.Controls.Add(this.MainSS);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "RomVault (V3.0)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.ResizeBegin += new System.EventHandler(this.FrmMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FrmMain_ResizeEnd);
            this.splitToolBarMain.Panel1.ResumeLayout(false);
            this.splitToolBarMain.Panel1.PerformLayout();
            this.splitToolBarMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitToolBarMain)).EndInit();
            this.splitToolBarMain.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Padding5PN.ResumeLayout(false);
            this.Padding5PN.PerformLayout();
            this.Padding4PN.ResumeLayout(false);
            this.Padding4PN.PerformLayout();
            this.Padding3PN.ResumeLayout(false);
            this.Padding3PN.PerformLayout();
            this.PaddingPN2.ResumeLayout(false);
            this.PaddingPN2.PerformLayout();
            this.PaddingPN.ResumeLayout(false);
            this.PaddingPN.PerformLayout();
            this.splitDatInfoGameInfo.Panel1.ResumeLayout(false);
            this.splitDatInfoGameInfo.Panel1.PerformLayout();
            this.splitDatInfoGameInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDatInfoGameInfo)).EndInit();
            this.splitDatInfoGameInfo.ResumeLayout(false);
            this.DatInfoPN.ResumeLayout(false);
            this.DatInfoPN.PerformLayout();
            this.DatTreePN.ResumeLayout(false);
            this.DatTreePN.PerformLayout();
            this.DatsTS.ResumeLayout(false);
            this.DatsTS.PerformLayout();
            this.RomsStatusTagsFLP.ResumeLayout(false);
            this.RomsStatusTagsFLP.PerformLayout();
            this.RomsPathFPR.ResumeLayout(false);
            this.RomsPathFPR.PerformLayout();
            this.CopyTextCMS.ResumeLayout(false);
            this.DatNameFPR.ResumeLayout(false);
            this.DatNameFPR.PerformLayout();
            this.VaultHeaderPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitGameInfoLists.Panel1.ResumeLayout(false);
            this.splitGameInfoLists.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGameInfoLists)).EndInit();
            this.splitGameInfoLists.ResumeLayout(false);
            this.PropertryGridSC.Panel1.ResumeLayout(false);
            this.PropertryGridSC.Panel2.ResumeLayout(false);
            this.PropertryGridSC.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertryGridSC)).EndInit();
            this.PropertryGridSC.ResumeLayout(false);
            this.PgHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PgHeaderPB)).EndInit();
            this.splitListArt.Panel1.ResumeLayout(false);
            this.splitListArt.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitListArt)).EndInit();
            this.splitListArt.ResumeLayout(false);
            this.GameRomPN.ResumeLayout(false);
            this.GameRomPN.PerformLayout();
            this.splitGameListRomList.Panel1.ResumeLayout(false);
            this.splitGameListRomList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGameListRomList)).EndInit();
            this.splitGameListRomList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RomGrid)).EndInit();
            this.GameRomTableTS.ResumeLayout(false);
            this.GameRomTableTS.PerformLayout();
            this.TabEmuArc.ResumeLayout(false);
            this.tabArtWork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArtwork)).EndInit();
            this.tabMedium.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMedium2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedium1)).EndInit();
            this.tabScreens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picScreenShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenTitle)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.tabInfo2.ResumeLayout(false);
            this.tabInfo2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainSS.ResumeLayout(false);
            this.MainSS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.SplitContainer splitToolBarMain;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnFixFiles;
        private System.Windows.Forms.Button btnFindFixes;
        private System.Windows.Forms.Button btnScanRoms;
        private System.Windows.Forms.Button btnUpdateDats;
        private System.Windows.Forms.SplitContainer splitDatInfoGameInfo;
        private System.Windows.Forms.GroupBox gbDatInfo;
        private System.Windows.Forms.Label lblDIRomPath;
        private System.Windows.Forms.Label lblDIName;
        private System.Windows.Forms.SplitContainer splitGameInfoLists;
        private System.Windows.Forms.GroupBox gbSetInfo;

        private System.Windows.Forms.SplitContainer splitGameListRomList;
        private System.Windows.Forms.DataGridView GameGrid;
        private System.Windows.Forms.DataGridView RomGrid;
        private RvTree ctrRvTree;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateDATs;
        private System.Windows.Forms.ToolStripMenuItem tsmScanROMs;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel1;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel3;
        private System.Windows.Forms.ToolStripMenuItem tsmFindFixes;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutRomVaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel2;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixDatReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixReportToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitListArt;
        private System.Windows.Forms.TabControl TabEmuArc;
        private System.Windows.Forms.TabPage tabArtWork;
        private System.Windows.Forms.TabPage tabScreens;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picArtwork;
        private System.Windows.Forms.PictureBox picScreenShot;
        private System.Windows.Forms.PictureBox picScreenTitle;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.ToolStripMenuItem colorKeyToolStripMenuItem;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ToolStripMenuItem romVaultSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorySettingsToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem updateNewDATsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAllDATsToolStripMenuItem;
        private System.Windows.Forms.Button btnDefault2;
        private System.Windows.Forms.Button btnDefault1;
        private System.Windows.Forms.Button btnDefault4;
        private System.Windows.Forms.Button btnDefault3;
        private System.Windows.Forms.Label lblTreePreSets;
        private System.Windows.Forms.ToolStripMenuItem visitHelpWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whatsNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torrentZipToolStripMenuItem;
        private System.Windows.Forms.TabPage tabMedium;
        private System.Windows.Forms.PictureBox picMedium2;
        private System.Windows.Forms.PictureBox picMedium1;
        private UserControls.ToolTip tooltip;
        private System.Windows.Forms.DataGridViewImageColumn CGot;
        private System.Windows.Forms.DataGridViewTextBoxColumn CRom;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMerge;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCRC32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAltSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAltCRC32;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAltSHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAltMD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CFileModDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CZipIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn CInstanceCount;
        private System.Windows.Forms.ToolStripMenuItem directoryMappingsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn CType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGame;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDateTime;
        private System.Windows.Forms.DataGridViewImageColumn CROMStatus;
        private System.Windows.Forms.TabPage tabInfo2;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.Panel DatInfoPN;
        private System.Windows.Forms.Panel Padding5PN;
        private System.Windows.Forms.Panel PaddingPN2;
        private System.Windows.Forms.Panel Padding4PN;
        private System.Windows.Forms.Panel Padding3PN;
        private System.Windows.Forms.Panel PaddingPN;
        private System.Windows.Forms.StatusStrip MainSS;
        private FlowLayoutPanel flowLayoutPanel1;
        private UserControls.FlexiLabel flexiLabel3;
        private Button HideNavBT;
        private ToolStripStatusLabel CollapseAllSSBT;
        private ToolStripMenuItem findFixesToolStripMenuItem;
        private ToolStripMenuItem findFixeswithLogToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem fixROMsToolStripMenuItem1;
        private ToolStripMenuItem scanFindAndFixROMsToolStripMenuItem;
        private ToolStripMenuItem addNewToSortFolderToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton DatsControlSSBT;
        private ToolStripMenuItem DatsGroupVisibilitySSBT;
        private ToolStripMenuItem DatsShortnameToggleSSBT;
        private ToolStripDropDownButton RomsControlSSBT;
        private ToolStripMenuItem RomsGroupVisibilitySSBT;
        private ToolStripMenuItem RomsShortnameToggleSSBT;
        private ToolStrip DatsTS;
        private ToolStripButton DatsCollapseTreeBT;
        private Panel DatTreePN;
        private Panel GameRomPN;
        private ToolStrip GameRomTableTS;
        private ToolStripButton GameRomToHomeBT;
        private PropertyGrid MainPG;
        private FlexiLabel PgHeaderLB;
        private Panel PgHeader;
        private PictureBox PgHeaderPB;
        private Panel VaultHeaderPN;
        private FlexiLabel DatPanelHeaderLB;
        private PictureBox pictureBox1;
        private FlexiLabel RomsUnknownLB;
        private FlexiLabel RomsFixableLB;
        private FlexiLabel RomsMissingLB;
        private FlexiLabel RomsGotLB;
        private FlowLayoutPanel RomsStatusTagsFLP;
        private PathLabel DatInfoPathLb;
        private Label DatInfoNameLb;
        private FlowPanelResponsive RomsPathFPR;
        private FlowPanelResponsive DatNameFPR;
        private ContextMenuStrip CopyTextCMS;
        private ToolStripMenuItem copyTextToolStripMenuItem;
        private ToolStripDropDownButton FilterTSDD;
        private ToolStripMenuItem chkBoxShowCompleteTSI;
        private ToolStripMenuItem chkBoxShowPartialTSI;
        private ToolStripMenuItem chkBoxShowEmptyTSI;
        private ToolStripMenuItem chkBoxShowFixesTSI;
        private ToolStripMenuItem chkBoxShowMIATSI;
        private ToolStripMenuItem chkBoxShowMergedTSI;
        private ToolStripTextBox gameSearchTSTB;
        private ToolStripButton gameSearchTSBT;
        private ToolStripButton gameSearchClearBT;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toggleToolStripMenuItem;
        private ToolStripMenuItem setAllToolStripMenuItem;
        private ToolStripLabel GameGridRowCountLB;
        private ToolStripMenuItem darkModeToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton AutoSizeGameColChB;
        private SplitContainer PropertryGridSC;
        private TextBox PropertyGridHelpTB;
        private Button PropGridHelpBT;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem folderCReatorWizardToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem DatProvidersTSI;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem RomProvidersTSI;
        private ToolStripMenuItem addBlankDATToolStripMenuItem;
    }
}

