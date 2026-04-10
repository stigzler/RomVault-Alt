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
            this.MainSC = new System.Windows.Forms.SplitContainer();
            this.splitDatInfoGameInfo = new System.Windows.Forms.SplitContainer();
            this.DatInfoPN = new System.Windows.Forms.Panel();
            this.DatTreePN = new System.Windows.Forms.Panel();
            this.ctrRvTree = new ROMVault.RvTree();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DatsCollapseTreeBT = new System.Windows.Forms.ToolStripButton();
            this.RomsStatusTagsFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.RomsUnknownLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsFixableLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsMissingLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsGotLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsPathFPR = new ROMVault.UserControls.FlowPanelResponsive();
            this.lblDIRomPath = new System.Windows.Forms.Label();
            this.DatInfoPathLb = new ROMVault.UserControls.PathLabel();
            this.DatNameFPR = new ROMVault.UserControls.FlowPanelResponsive();
            this.lblDIName = new System.Windows.Forms.Label();
            this.DatInfoNameLb = new System.Windows.Forms.Label();
            this.VaultHeaderPN = new System.Windows.Forms.Panel();
            this.DatPanelHeaderLB = new ROMVault.UserControls.FlexiLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitGameInfoLists = new System.Windows.Forms.SplitContainer();
            this.GameInfoWrapperPanel = new System.Windows.Forms.Panel();
            this.GameInfoTLP = new ROMVault.UserControls.TableLayoutPanel();
            this._textGameName = new System.Windows.Forms.TextBox();
            this._labelGameName = new System.Windows.Forms.Label();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this._textTruripScore = new System.Windows.Forms.TextBox();
            this._textGameManufacturer = new System.Windows.Forms.TextBox();
            this._textGameDescription = new System.Windows.Forms.TextBox();
            this._textTruripSubGenre = new System.Windows.Forms.TextBox();
            this._textTruripPlayers = new System.Windows.Forms.TextBox();
            this._textTruripRatings = new System.Windows.Forms.TextBox();
            this._textTruripGenre = new System.Windows.Forms.TextBox();
            this._labelTruripYear = new System.Windows.Forms.Label();
            this._textTruripRelatedTo = new System.Windows.Forms.TextBox();
            this._labelTruripRelatedTo = new System.Windows.Forms.Label();
            this._textTruripCloneOf = new System.Windows.Forms.TextBox();
            this._labelTruripCloneOf = new System.Windows.Forms.Label();
            this._labelGameDescription = new System.Windows.Forms.Label();
            this._textGameRomOf = new System.Windows.Forms.TextBox();
            this._textTruripDeveloper = new System.Windows.Forms.TextBox();
            this._textGameCloneOf = new System.Windows.Forms.TextBox();
            this._textTruripPublisher = new System.Windows.Forms.Label();
            this._textGameCategory = new System.Windows.Forms.TextBox();
            this._textTruripSource = new System.Windows.Forms.TextBox();
            this._textGameYear = new System.Windows.Forms.TextBox();
            this._textTruripTitleId = new System.Windows.Forms.TextBox();
            this._labelGameRomOf = new System.Windows.Forms.Label();
            this._labelTruripDeveloper = new System.Windows.Forms.Label();
            this._labelGameCloneOf = new System.Windows.Forms.Label();
            this._labelTruripPublisher = new System.Windows.Forms.Label();
            this._labelGameCategory = new System.Windows.Forms.Label();
            this._labelTruripSource = new System.Windows.Forms.Label();
            this._labelGameYear = new System.Windows.Forms.Label();
            this._labelTruripTitleId = new System.Windows.Forms.Label();
            this._labelGameManufacturer = new System.Windows.Forms.Label();
            this._labelTruripGenre = new System.Windows.Forms.Label();
            this._labelTruripRatings = new System.Windows.Forms.Label();
            this._labelTruripPlayers = new System.Windows.Forms.Label();
            this._labelTruripSubGenre = new System.Windows.Forms.Label();
            this._labelTruripScore = new System.Windows.Forms.Label();
            this._textTruripYear = new System.Windows.Forms.TextBox();
            this.GameDetailsRhsFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.chkBoxShowComplete = new System.Windows.Forms.CheckBox();
            this.chkBoxShowPartial = new System.Windows.Forms.CheckBox();
            this.chkBoxShowEmpty = new System.Windows.Forms.CheckBox();
            this.chkBoxShowFixes = new System.Windows.Forms.CheckBox();
            this.chkBoxShowMIA = new System.Windows.Forms.CheckBox();
            this.chkBoxShowMerged = new System.Windows.Forms.CheckBox();
            this.SearchTLP = new System.Windows.Forms.TableLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFilter = new ROMVault.UserControls.PromptTextBox();
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
            this.GameRomNavigateToRootBT = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
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
            this.MainPG = new System.Windows.Forms.PropertyGrid();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.PgHeader = new System.Windows.Forms.Panel();
            this.PgHeaderLB = new ROMVault.UserControls.FlexiLabel();
            this.PgHeaderPB = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmUpdateDATs = new System.Windows.Forms.ToolStripMenuItem();
            this.updateNewDATsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAllDATsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanROMs = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToSortFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmScanLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFindFixes = new System.Windows.Forms.ToolStripMenuItem();
            this.findFixesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findFixeswithLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fixROMsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scanFindAndFixROMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixDatReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryMappingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.romVaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitHelpWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRomVaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.garbageCollectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.MainSS = new System.Windows.Forms.StatusStrip();
            this.CollapseAllSSBT = new System.Windows.Forms.ToolStripStatusLabel();
            this.DatsControlSSBT = new System.Windows.Forms.ToolStripDropDownButton();
            this.DatsGroupVisibilitySSBT = new System.Windows.Forms.ToolStripMenuItem();
            this.DatsShortnameToggleSSBT = new System.Windows.Forms.ToolStripMenuItem();
            this.RomsControlSSBT = new System.Windows.Forms.ToolStripDropDownButton();
            this.RomsGroupVisibilitySSBT = new System.Windows.Forms.ToolStripMenuItem();
            this.RomsShortnameToggleSSBT = new System.Windows.Forms.ToolStripMenuItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.MainSC)).BeginInit();
            this.MainSC.Panel1.SuspendLayout();
            this.MainSC.Panel2.SuspendLayout();
            this.MainSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDatInfoGameInfo)).BeginInit();
            this.splitDatInfoGameInfo.Panel1.SuspendLayout();
            this.splitDatInfoGameInfo.Panel2.SuspendLayout();
            this.splitDatInfoGameInfo.SuspendLayout();
            this.DatInfoPN.SuspendLayout();
            this.DatTreePN.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.RomsStatusTagsFLP.SuspendLayout();
            this.RomsPathFPR.SuspendLayout();
            this.DatNameFPR.SuspendLayout();
            this.VaultHeaderPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGameInfoLists)).BeginInit();
            this.splitGameInfoLists.Panel1.SuspendLayout();
            this.splitGameInfoLists.Panel2.SuspendLayout();
            this.splitGameInfoLists.SuspendLayout();
            this.GameInfoWrapperPanel.SuspendLayout();
            this.GameInfoTLP.SuspendLayout();
            this.GameDetailsRhsFLP.SuspendLayout();
            this.SearchTLP.SuspendLayout();
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
            this.GameRomNavigateToRootBT.SuspendLayout();
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
            this.toolStrip2.SuspendLayout();
            this.PgHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PgHeaderPB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.MainSS.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitToolBarMain
            // 
            this.splitToolBarMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitToolBarMain.Location = new System.Drawing.Point(0, 24);
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
            this.splitToolBarMain.Panel2.Controls.Add(this.MainSC);
            this.splitToolBarMain.Size = new System.Drawing.Size(1300, 766);
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
            this.flexiLabel3.Location = new System.Drawing.Point(4, 633);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 654);
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
            // MainSC
            // 
            this.MainSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSC.Location = new System.Drawing.Point(0, 0);
            this.MainSC.Name = "MainSC";
            // 
            // MainSC.Panel1
            // 
            this.MainSC.Panel1.Controls.Add(this.splitDatInfoGameInfo);
            // 
            // MainSC.Panel2
            // 
            this.MainSC.Panel2.Controls.Add(this.MainPG);
            this.MainSC.Panel2.Controls.Add(this.toolStrip2);
            this.MainSC.Panel2.Controls.Add(this.PgHeader);
            this.MainSC.Panel2.Padding = new System.Windows.Forms.Padding(2);
            this.MainSC.Size = new System.Drawing.Size(1166, 766);
            this.MainSC.SplitterDistance = 814;
            this.MainSC.TabIndex = 1;
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
            this.splitDatInfoGameInfo.Size = new System.Drawing.Size(814, 766);
            this.splitDatInfoGameInfo.SplitterDistance = 450;
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
            this.DatInfoPN.Padding = new System.Windows.Forms.Padding(4);
            this.DatInfoPN.Size = new System.Drawing.Size(442, 758);
            this.DatInfoPN.TabIndex = 4;
            // 
            // DatTreePN
            // 
            this.DatTreePN.AutoSize = true;
            this.DatTreePN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatTreePN.Controls.Add(this.ctrRvTree);
            this.DatTreePN.Controls.Add(this.toolStrip1);
            this.DatTreePN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatTreePN.Location = new System.Drawing.Point(4, 118);
            this.DatTreePN.Name = "DatTreePN";
            this.DatTreePN.Size = new System.Drawing.Size(432, 634);
            this.DatTreePN.TabIndex = 6;
            // 
            // ctrRvTree
            // 
            this.ctrRvTree.AutoSize = true;
            this.ctrRvTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrRvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrRvTree.Location = new System.Drawing.Point(0, 25);
            this.ctrRvTree.Name = "ctrRvTree";
            this.ctrRvTree.Size = new System.Drawing.Size(430, 607);
            this.ctrRvTree.TabIndex = 2;
            this.ctrRvTree.Visible = false;
            this.ctrRvTree.RvSelected += new System.Windows.Forms.MouseEventHandler(this.DirTreeRvSelected);
            this.ctrRvTree.RvChecked += new System.Windows.Forms.MouseEventHandler(this.DirTreeRvChecked);
            this.ctrRvTree.Load += new System.EventHandler(this.ctrRvTree_Load);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DatsCollapseTreeBT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(430, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DatsCollapseTreeBT
            // 
            this.DatsCollapseTreeBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DatsCollapseTreeBT.Image = global::ROMVault.Properties.Resources.folder_tree;
            this.DatsCollapseTreeBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DatsCollapseTreeBT.Name = "DatsCollapseTreeBT";
            this.DatsCollapseTreeBT.Size = new System.Drawing.Size(23, 22);
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
            this.RomsStatusTagsFLP.Location = new System.Drawing.Point(4, 89);
            this.RomsStatusTagsFLP.Name = "RomsStatusTagsFLP";
            this.RomsStatusTagsFLP.Size = new System.Drawing.Size(432, 29);
            this.RomsStatusTagsFLP.TabIndex = 20;
            // 
            // RomsUnknownLB
            // 
            this.RomsUnknownLB.AutoSize = true;
            this.RomsUnknownLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsUnknownLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsUnknownLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsUnknownLB.ForeColor = System.Drawing.Color.Cyan;
            this.RomsUnknownLB.Location = new System.Drawing.Point(381, 2);
            this.RomsUnknownLB.Margin = new System.Windows.Forms.Padding(2);
            this.RomsUnknownLB.Name = "RomsUnknownLB";
            this.RomsUnknownLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsUnknownLB.ScaleFactor = 1D;
            this.RomsUnknownLB.Size = new System.Drawing.Size(49, 25);
            this.RomsUnknownLB.TabIndex = 24;
            this.RomsUnknownLB.Tag = "override";
            this.RomsUnknownLB.Text = "label2";
            // 
            // RomsFixableLB
            // 
            this.RomsFixableLB.AutoSize = true;
            this.RomsFixableLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsFixableLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsFixableLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsFixableLB.ForeColor = System.Drawing.Color.Yellow;
            this.RomsFixableLB.Location = new System.Drawing.Point(328, 2);
            this.RomsFixableLB.Margin = new System.Windows.Forms.Padding(2);
            this.RomsFixableLB.Name = "RomsFixableLB";
            this.RomsFixableLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsFixableLB.ScaleFactor = 1D;
            this.RomsFixableLB.Size = new System.Drawing.Size(49, 25);
            this.RomsFixableLB.TabIndex = 23;
            this.RomsFixableLB.Tag = "override";
            this.RomsFixableLB.Text = "label2";
            // 
            // RomsMissingLB
            // 
            this.RomsMissingLB.AutoSize = true;
            this.RomsMissingLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsMissingLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsMissingLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsMissingLB.ForeColor = System.Drawing.Color.Red;
            this.RomsMissingLB.Location = new System.Drawing.Point(275, 2);
            this.RomsMissingLB.Margin = new System.Windows.Forms.Padding(2);
            this.RomsMissingLB.Name = "RomsMissingLB";
            this.RomsMissingLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsMissingLB.ScaleFactor = 1D;
            this.RomsMissingLB.Size = new System.Drawing.Size(49, 25);
            this.RomsMissingLB.TabIndex = 22;
            this.RomsMissingLB.Tag = "override";
            this.RomsMissingLB.Text = "label2";
            // 
            // RomsGotLB
            // 
            this.RomsGotLB.AutoSize = true;
            this.RomsGotLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsGotLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsGotLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsGotLB.ForeColor = System.Drawing.Color.LimeGreen;
            this.RomsGotLB.Location = new System.Drawing.Point(222, 2);
            this.RomsGotLB.Margin = new System.Windows.Forms.Padding(2);
            this.RomsGotLB.Name = "RomsGotLB";
            this.RomsGotLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsGotLB.ScaleFactor = 1D;
            this.RomsGotLB.Size = new System.Drawing.Size(49, 25);
            this.RomsGotLB.TabIndex = 21;
            this.RomsGotLB.Tag = "override";
            this.RomsGotLB.Text = "label2";
            // 
            // RomsPathFPR
            // 
            this.RomsPathFPR.AutoSize = true;
            this.RomsPathFPR.Controls.Add(this.lblDIRomPath);
            this.RomsPathFPR.Controls.Add(this.DatInfoPathLb);
            this.RomsPathFPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.RomsPathFPR.Location = new System.Drawing.Point(4, 60);
            this.RomsPathFPR.Name = "RomsPathFPR";
            this.RomsPathFPR.Size = new System.Drawing.Size(432, 29);
            this.RomsPathFPR.TabIndex = 26;
            this.RomsPathFPR.WrapContents = false;
            // 
            // lblDIRomPath
            // 
            this.lblDIRomPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDIRomPath.AutoSize = true;
            this.lblDIRomPath.Location = new System.Drawing.Point(0, 6);
            this.lblDIRomPath.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIRomPath.Name = "lblDIRomPath";
            this.lblDIRomPath.Size = new System.Drawing.Size(76, 17);
            this.lblDIRomPath.TabIndex = 15;
            this.lblDIRomPath.Text = "ROMs Path:";
            this.lblDIRomPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DatInfoPathLb
            // 
            this.DatInfoPathLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatInfoPathLb.Location = new System.Drawing.Point(79, 3);
            this.DatInfoPathLb.Margin = new System.Windows.Forms.Padding(3);
            this.DatInfoPathLb.Name = "DatInfoPathLb";
            this.DatInfoPathLb.Padding = new System.Windows.Forms.Padding(3);
            this.DatInfoPathLb.Size = new System.Drawing.Size(350, 23);
            this.DatInfoPathLb.TabIndex = 21;
            this.DatInfoPathLb.Text = "label3";
            this.DatInfoPathLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DatNameFPR
            // 
            this.DatNameFPR.AutoSize = true;
            this.DatNameFPR.Controls.Add(this.lblDIName);
            this.DatNameFPR.Controls.Add(this.DatInfoNameLb);
            this.DatNameFPR.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatNameFPR.Location = new System.Drawing.Point(4, 31);
            this.DatNameFPR.Name = "DatNameFPR";
            this.DatNameFPR.Size = new System.Drawing.Size(432, 29);
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
            this.lblDIName.Size = new System.Drawing.Size(73, 17);
            this.lblDIName.TabIndex = 3;
            this.lblDIName.Text = "DAT Name:";
            this.lblDIName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DatInfoNameLb
            // 
            this.DatInfoNameLb.AutoSize = true;
            this.DatInfoNameLb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatInfoNameLb.Location = new System.Drawing.Point(76, 3);
            this.DatInfoNameLb.Margin = new System.Windows.Forms.Padding(3);
            this.DatInfoNameLb.Name = "DatInfoNameLb";
            this.DatInfoNameLb.Padding = new System.Windows.Forms.Padding(2);
            this.DatInfoNameLb.Size = new System.Drawing.Size(353, 23);
            this.DatInfoNameLb.TabIndex = 22;
            this.DatInfoNameLb.Text = "label3";
            this.DatInfoNameLb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VaultHeaderPN
            // 
            this.VaultHeaderPN.Controls.Add(this.DatPanelHeaderLB);
            this.VaultHeaderPN.Controls.Add(this.pictureBox1);
            this.VaultHeaderPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.VaultHeaderPN.Location = new System.Drawing.Point(4, 4);
            this.VaultHeaderPN.Name = "VaultHeaderPN";
            this.VaultHeaderPN.Padding = new System.Windows.Forms.Padding(2);
            this.VaultHeaderPN.Size = new System.Drawing.Size(432, 27);
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
            this.DatPanelHeaderLB.Size = new System.Drawing.Size(404, 23);
            this.DatPanelHeaderLB.TabIndex = 3;
            this.DatPanelHeaderLB.Text = "Dat Summary";
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
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
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
            this.splitGameInfoLists.Panel1.Controls.Add(this.GameInfoWrapperPanel);
            this.splitGameInfoLists.Panel1.Controls.Add(this.GameDetailsRhsFLP);
            this.splitGameInfoLists.Panel1.Resize += new System.EventHandler(this.splitContainer4_Panel1_Resize);
            // 
            // splitGameInfoLists.Panel2
            // 
            this.splitGameInfoLists.Panel2.Controls.Add(this.splitListArt);
            this.splitGameInfoLists.Size = new System.Drawing.Size(352, 758);
            this.splitGameInfoLists.SplitterDistance = 420;
            this.splitGameInfoLists.TabIndex = 0;
            // 
            // GameInfoWrapperPanel
            // 
            this.GameInfoWrapperPanel.AutoScroll = true;
            this.GameInfoWrapperPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameInfoWrapperPanel.Controls.Add(this.GameInfoTLP);
            this.GameInfoWrapperPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameInfoWrapperPanel.Location = new System.Drawing.Point(0, 0);
            this.GameInfoWrapperPanel.Name = "GameInfoWrapperPanel";
            this.GameInfoWrapperPanel.Padding = new System.Windows.Forms.Padding(4);
            this.GameInfoWrapperPanel.Size = new System.Drawing.Size(156, 420);
            this.GameInfoWrapperPanel.TabIndex = 0;
            // 
            // GameInfoTLP
            // 
            this.GameInfoTLP.AutoSize = true;
            this.GameInfoTLP.ColumnCount = 6;
            this.GameInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GameInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.GameInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GameInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.GameInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GameInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.GameInfoTLP.Controls.Add(this._textGameName, 1, 1);
            this.GameInfoTLP.Controls.Add(this._labelGameName, 0, 1);
            this.GameInfoTLP.Controls.Add(this.flexiLabel1, 0, 0);
            this.GameInfoTLP.Controls.Add(this._textTruripScore, 5, 11);
            this.GameInfoTLP.Controls.Add(this._textGameManufacturer, 1, 3);
            this.GameInfoTLP.Controls.Add(this._textGameDescription, 1, 2);
            this.GameInfoTLP.Controls.Add(this._textTruripSubGenre, 3, 11);
            this.GameInfoTLP.Controls.Add(this._textTruripPlayers, 1, 11);
            this.GameInfoTLP.Controls.Add(this._textTruripRatings, 5, 10);
            this.GameInfoTLP.Controls.Add(this._textTruripGenre, 3, 10);
            this.GameInfoTLP.Controls.Add(this._labelTruripYear, 0, 10);
            this.GameInfoTLP.Controls.Add(this._textTruripRelatedTo, 1, 9);
            this.GameInfoTLP.Controls.Add(this._labelTruripRelatedTo, 0, 9);
            this.GameInfoTLP.Controls.Add(this._textTruripCloneOf, 1, 8);
            this.GameInfoTLP.Controls.Add(this._labelTruripCloneOf, 0, 8);
            this.GameInfoTLP.Controls.Add(this._labelGameDescription, 0, 2);
            this.GameInfoTLP.Controls.Add(this._textGameRomOf, 1, 7);
            this.GameInfoTLP.Controls.Add(this._textTruripDeveloper, 1, 6);
            this.GameInfoTLP.Controls.Add(this._textGameCloneOf, 1, 5);
            this.GameInfoTLP.Controls.Add(this._textTruripPublisher, 1, 4);
            this.GameInfoTLP.Controls.Add(this._textGameCategory, 4, 7);
            this.GameInfoTLP.Controls.Add(this._textTruripSource, 4, 6);
            this.GameInfoTLP.Controls.Add(this._textGameYear, 4, 5);
            this.GameInfoTLP.Controls.Add(this._textTruripTitleId, 4, 4);
            this.GameInfoTLP.Controls.Add(this._labelGameRomOf, 0, 7);
            this.GameInfoTLP.Controls.Add(this._labelTruripDeveloper, 0, 6);
            this.GameInfoTLP.Controls.Add(this._labelGameCloneOf, 0, 5);
            this.GameInfoTLP.Controls.Add(this._labelTruripPublisher, 0, 4);
            this.GameInfoTLP.Controls.Add(this._labelGameCategory, 3, 7);
            this.GameInfoTLP.Controls.Add(this._labelTruripSource, 3, 6);
            this.GameInfoTLP.Controls.Add(this._labelGameYear, 3, 5);
            this.GameInfoTLP.Controls.Add(this._labelTruripTitleId, 3, 4);
            this.GameInfoTLP.Controls.Add(this._labelGameManufacturer, 0, 3);
            this.GameInfoTLP.Controls.Add(this._labelTruripGenre, 2, 10);
            this.GameInfoTLP.Controls.Add(this._labelTruripRatings, 4, 10);
            this.GameInfoTLP.Controls.Add(this._labelTruripPlayers, 0, 11);
            this.GameInfoTLP.Controls.Add(this._labelTruripSubGenre, 2, 11);
            this.GameInfoTLP.Controls.Add(this._labelTruripScore, 4, 11);
            this.GameInfoTLP.Controls.Add(this._textTruripYear, 1, 10);
            this.GameInfoTLP.Dock = System.Windows.Forms.DockStyle.Top;
            this.GameInfoTLP.Location = new System.Drawing.Point(4, 4);
            this.GameInfoTLP.Name = "GameInfoTLP";
            this.GameInfoTLP.RowCount = 13;
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GameInfoTLP.Size = new System.Drawing.Size(146, 405);
            this.GameInfoTLP.TabIndex = 1;
            this.GameInfoTLP.Visible = false;
            // 
            // _textGameName
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameName, 5);
            this._textGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameName.Location = new System.Drawing.Point(96, 30);
            this._textGameName.Name = "_textGameName";
            this._textGameName.ReadOnly = true;
            this._textGameName.Size = new System.Drawing.Size(49, 25);
            this._textGameName.TabIndex = 44;
            // 
            // _labelGameName
            // 
            this._labelGameName.AutoSize = true;
            this._labelGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameName.Location = new System.Drawing.Point(0, 27);
            this._labelGameName.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameName.Name = "_labelGameName";
            this._labelGameName.Size = new System.Drawing.Size(93, 31);
            this._labelGameName.TabIndex = 43;
            this._labelGameName.Text = "Name :";
            this._labelGameName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // flexiLabel1
            // 
            this.flexiLabel1.AutoSize = true;
            this.GameInfoTLP.SetColumnSpan(this.flexiLabel1, 6);
            this.flexiLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.flexiLabel1.Location = new System.Drawing.Point(3, 0);
            this.flexiLabel1.Name = "flexiLabel1";
            this.flexiLabel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 6);
            this.flexiLabel1.ScaleFactor = 1D;
            this.flexiLabel1.Size = new System.Drawing.Size(76, 27);
            this.flexiLabel1.TabIndex = 21;
            this.flexiLabel1.Text = "Game Info:";
            // 
            // _textTruripScore
            // 
            this._textTruripScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripScore.Location = new System.Drawing.Point(176, 377);
            this._textTruripScore.Name = "_textTruripScore";
            this._textTruripScore.ReadOnly = true;
            this._textTruripScore.Size = new System.Drawing.Size(1, 25);
            this._textTruripScore.TabIndex = 42;
            // 
            // _textGameManufacturer
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameManufacturer, 5);
            this._textGameManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameManufacturer.Location = new System.Drawing.Point(96, 92);
            this._textGameManufacturer.Name = "_textGameManufacturer";
            this._textGameManufacturer.ReadOnly = true;
            this._textGameManufacturer.Size = new System.Drawing.Size(49, 25);
            this._textGameManufacturer.TabIndex = 9;
            // 
            // _textGameDescription
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameDescription, 5);
            this._textGameDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameDescription.Location = new System.Drawing.Point(96, 61);
            this._textGameDescription.Name = "_textGameDescription";
            this._textGameDescription.ReadOnly = true;
            this._textGameDescription.Size = new System.Drawing.Size(49, 25);
            this._textGameDescription.TabIndex = 6;
            // 
            // _textTruripSubGenre
            // 
            this._textTruripSubGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripSubGenre.Location = new System.Drawing.Point(143, 377);
            this._textTruripSubGenre.Name = "_textTruripSubGenre";
            this._textTruripSubGenre.ReadOnly = true;
            this._textTruripSubGenre.Size = new System.Drawing.Size(1, 25);
            this._textTruripSubGenre.TabIndex = 41;
            // 
            // _textTruripPlayers
            // 
            this._textTruripPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripPlayers.Location = new System.Drawing.Point(96, 377);
            this._textTruripPlayers.Name = "_textTruripPlayers";
            this._textTruripPlayers.ReadOnly = true;
            this._textTruripPlayers.Size = new System.Drawing.Size(1, 25);
            this._textTruripPlayers.TabIndex = 40;
            // 
            // _textTruripRatings
            // 
            this._textTruripRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripRatings.Location = new System.Drawing.Point(176, 346);
            this._textTruripRatings.Name = "_textTruripRatings";
            this._textTruripRatings.ReadOnly = true;
            this._textTruripRatings.Size = new System.Drawing.Size(1, 25);
            this._textTruripRatings.TabIndex = 39;
            // 
            // _textTruripGenre
            // 
            this._textTruripGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripGenre.Location = new System.Drawing.Point(143, 346);
            this._textTruripGenre.Name = "_textTruripGenre";
            this._textTruripGenre.ReadOnly = true;
            this._textTruripGenre.Size = new System.Drawing.Size(1, 25);
            this._textTruripGenre.TabIndex = 38;
            // 
            // _labelTruripYear
            // 
            this._labelTruripYear.AutoSize = true;
            this._labelTruripYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripYear.Location = new System.Drawing.Point(0, 343);
            this._labelTruripYear.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripYear.Name = "_labelTruripYear";
            this._labelTruripYear.Size = new System.Drawing.Size(93, 31);
            this._labelTruripYear.TabIndex = 31;
            this._labelTruripYear.Text = "Year :";
            this._labelTruripYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textTruripRelatedTo
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripRelatedTo, 5);
            this._textTruripRelatedTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripRelatedTo.Location = new System.Drawing.Point(96, 315);
            this._textTruripRelatedTo.Name = "_textTruripRelatedTo";
            this._textTruripRelatedTo.ReadOnly = true;
            this._textTruripRelatedTo.Size = new System.Drawing.Size(49, 25);
            this._textTruripRelatedTo.TabIndex = 30;
            this._textTruripRelatedTo.Text = "_textTruripRelatedTo";
            // 
            // _labelTruripRelatedTo
            // 
            this._labelTruripRelatedTo.AutoSize = true;
            this._labelTruripRelatedTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripRelatedTo.Location = new System.Drawing.Point(0, 312);
            this._labelTruripRelatedTo.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripRelatedTo.Name = "_labelTruripRelatedTo";
            this._labelTruripRelatedTo.Size = new System.Drawing.Size(93, 31);
            this._labelTruripRelatedTo.TabIndex = 29;
            this._labelTruripRelatedTo.Text = "Related To :";
            this._labelTruripRelatedTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textTruripCloneOf
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripCloneOf, 5);
            this._textTruripCloneOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripCloneOf.Location = new System.Drawing.Point(96, 284);
            this._textTruripCloneOf.Name = "_textTruripCloneOf";
            this._textTruripCloneOf.ReadOnly = true;
            this._textTruripCloneOf.Size = new System.Drawing.Size(49, 25);
            this._textTruripCloneOf.TabIndex = 28;
            this._textTruripCloneOf.Text = "_textTruripCloneOf";
            // 
            // _labelTruripCloneOf
            // 
            this._labelTruripCloneOf.AutoSize = true;
            this._labelTruripCloneOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripCloneOf.Location = new System.Drawing.Point(0, 281);
            this._labelTruripCloneOf.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripCloneOf.Name = "_labelTruripCloneOf";
            this._labelTruripCloneOf.Size = new System.Drawing.Size(93, 31);
            this._labelTruripCloneOf.TabIndex = 27;
            this._labelTruripCloneOf.Text = "Clone Of :";
            this._labelTruripCloneOf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelGameDescription
            // 
            this._labelGameDescription.AutoSize = true;
            this._labelGameDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameDescription.Location = new System.Drawing.Point(0, 58);
            this._labelGameDescription.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameDescription.Name = "_labelGameDescription";
            this._labelGameDescription.Size = new System.Drawing.Size(93, 31);
            this._labelGameDescription.TabIndex = 5;
            this._labelGameDescription.Text = "Description :";
            this._labelGameDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textGameRomOf
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameRomOf, 2);
            this._textGameRomOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameRomOf.Location = new System.Drawing.Point(96, 253);
            this._textGameRomOf.Name = "_textGameRomOf";
            this._textGameRomOf.ReadOnly = true;
            this._textGameRomOf.Size = new System.Drawing.Size(41, 25);
            this._textGameRomOf.TabIndex = 25;
            // 
            // _textTruripDeveloper
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripDeveloper, 2);
            this._textTruripDeveloper.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripDeveloper.Location = new System.Drawing.Point(96, 222);
            this._textTruripDeveloper.Name = "_textTruripDeveloper";
            this._textTruripDeveloper.ReadOnly = true;
            this._textTruripDeveloper.Size = new System.Drawing.Size(41, 25);
            this._textTruripDeveloper.TabIndex = 21;
            this._textTruripDeveloper.Text = "_textTruripDeveloper";
            // 
            // _textGameCloneOf
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameCloneOf, 2);
            this._textGameCloneOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameCloneOf.Location = new System.Drawing.Point(96, 191);
            this._textGameCloneOf.Name = "_textGameCloneOf";
            this._textGameCloneOf.ReadOnly = true;
            this._textGameCloneOf.Size = new System.Drawing.Size(41, 25);
            this._textGameCloneOf.TabIndex = 11;
            // 
            // _textTruripPublisher
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripPublisher, 2);
            this._textTruripPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripPublisher.Location = new System.Drawing.Point(96, 120);
            this._textTruripPublisher.Name = "_textTruripPublisher";
            this._textTruripPublisher.Size = new System.Drawing.Size(41, 68);
            this._textTruripPublisher.TabIndex = 18;
            this._textTruripPublisher.Text = "_textTruripPublisher";
            // 
            // _textGameCategory
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameCategory, 2);
            this._textGameCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameCategory.Location = new System.Drawing.Point(118, 253);
            this._textGameCategory.Name = "_textGameCategory";
            this._textGameCategory.ReadOnly = true;
            this._textGameCategory.Size = new System.Drawing.Size(27, 25);
            this._textGameCategory.TabIndex = 26;
            // 
            // _textTruripSource
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripSource, 2);
            this._textTruripSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripSource.Location = new System.Drawing.Point(118, 222);
            this._textTruripSource.Name = "_textTruripSource";
            this._textTruripSource.ReadOnly = true;
            this._textTruripSource.Size = new System.Drawing.Size(27, 25);
            this._textTruripSource.TabIndex = 22;
            this._textTruripSource.Text = "_textTruripSource";
            // 
            // _textGameYear
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameYear, 2);
            this._textGameYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameYear.Location = new System.Drawing.Point(118, 191);
            this._textGameYear.Name = "_textGameYear";
            this._textGameYear.ReadOnly = true;
            this._textGameYear.Size = new System.Drawing.Size(27, 25);
            this._textGameYear.TabIndex = 13;
            // 
            // _textTruripTitleId
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripTitleId, 2);
            this._textTruripTitleId.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripTitleId.Location = new System.Drawing.Point(118, 123);
            this._textTruripTitleId.Name = "_textTruripTitleId";
            this._textTruripTitleId.ReadOnly = true;
            this._textTruripTitleId.Size = new System.Drawing.Size(27, 25);
            this._textTruripTitleId.TabIndex = 17;
            this._textTruripTitleId.Text = "_textTruripTitleId";
            // 
            // _labelGameRomOf
            // 
            this._labelGameRomOf.AutoSize = true;
            this._labelGameRomOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameRomOf.Location = new System.Drawing.Point(0, 250);
            this._labelGameRomOf.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameRomOf.Name = "_labelGameRomOf";
            this._labelGameRomOf.Size = new System.Drawing.Size(93, 31);
            this._labelGameRomOf.TabIndex = 23;
            this._labelGameRomOf.Text = "Rom Of :";
            this._labelGameRomOf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripDeveloper
            // 
            this._labelTruripDeveloper.AutoSize = true;
            this._labelTruripDeveloper.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripDeveloper.Location = new System.Drawing.Point(0, 219);
            this._labelTruripDeveloper.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripDeveloper.Name = "_labelTruripDeveloper";
            this._labelTruripDeveloper.Size = new System.Drawing.Size(93, 31);
            this._labelTruripDeveloper.TabIndex = 19;
            this._labelTruripDeveloper.Text = "Developer :";
            this._labelTruripDeveloper.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelGameCloneOf
            // 
            this._labelGameCloneOf.AutoSize = true;
            this._labelGameCloneOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameCloneOf.Location = new System.Drawing.Point(0, 188);
            this._labelGameCloneOf.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameCloneOf.Name = "_labelGameCloneOf";
            this._labelGameCloneOf.Size = new System.Drawing.Size(93, 31);
            this._labelGameCloneOf.TabIndex = 10;
            this._labelGameCloneOf.Text = "Clone Of :";
            this._labelGameCloneOf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripPublisher
            // 
            this._labelTruripPublisher.AutoSize = true;
            this._labelTruripPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripPublisher.Location = new System.Drawing.Point(0, 120);
            this._labelTruripPublisher.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripPublisher.Name = "_labelTruripPublisher";
            this._labelTruripPublisher.Size = new System.Drawing.Size(93, 68);
            this._labelTruripPublisher.TabIndex = 14;
            this._labelTruripPublisher.Text = "Publisher :";
            this._labelTruripPublisher.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelGameCategory
            // 
            this._labelGameCategory.AutoSize = true;
            this._labelGameCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameCategory.Location = new System.Drawing.Point(140, 250);
            this._labelGameCategory.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameCategory.Name = "_labelGameCategory";
            this._labelGameCategory.Size = new System.Drawing.Size(1, 31);
            this._labelGameCategory.TabIndex = 24;
            this._labelGameCategory.Text = "Category :";
            this._labelGameCategory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripSource
            // 
            this._labelTruripSource.AutoSize = true;
            this._labelTruripSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripSource.Location = new System.Drawing.Point(140, 219);
            this._labelTruripSource.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripSource.Name = "_labelTruripSource";
            this._labelTruripSource.Size = new System.Drawing.Size(1, 31);
            this._labelTruripSource.TabIndex = 20;
            this._labelTruripSource.Text = "Source :";
            this._labelTruripSource.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelGameYear
            // 
            this._labelGameYear.AutoSize = true;
            this._labelGameYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameYear.Location = new System.Drawing.Point(140, 188);
            this._labelGameYear.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameYear.Name = "_labelGameYear";
            this._labelGameYear.Size = new System.Drawing.Size(1, 31);
            this._labelGameYear.TabIndex = 12;
            this._labelGameYear.Text = "Year :";
            this._labelGameYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripTitleId
            // 
            this._labelTruripTitleId.AutoSize = true;
            this._labelTruripTitleId.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripTitleId.Location = new System.Drawing.Point(140, 120);
            this._labelTruripTitleId.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripTitleId.Name = "_labelTruripTitleId";
            this._labelTruripTitleId.Size = new System.Drawing.Size(1, 68);
            this._labelTruripTitleId.TabIndex = 16;
            this._labelTruripTitleId.Text = "Title ID :";
            this._labelTruripTitleId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelGameManufacturer
            // 
            this._labelGameManufacturer.AutoSize = true;
            this._labelGameManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameManufacturer.Location = new System.Drawing.Point(0, 89);
            this._labelGameManufacturer.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameManufacturer.Name = "_labelGameManufacturer";
            this._labelGameManufacturer.Size = new System.Drawing.Size(93, 31);
            this._labelGameManufacturer.TabIndex = 8;
            this._labelGameManufacturer.Text = "Manufacturer :";
            this._labelGameManufacturer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripGenre
            // 
            this._labelTruripGenre.AutoSize = true;
            this._labelTruripGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripGenre.Location = new System.Drawing.Point(68, 343);
            this._labelTruripGenre.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripGenre.Name = "_labelTruripGenre";
            this._labelTruripGenre.Size = new System.Drawing.Size(72, 31);
            this._labelTruripGenre.TabIndex = 32;
            this._labelTruripGenre.Text = "Genre :";
            this._labelTruripGenre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripRatings
            // 
            this._labelTruripRatings.AutoSize = true;
            this._labelTruripRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripRatings.Location = new System.Drawing.Point(115, 343);
            this._labelTruripRatings.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripRatings.Name = "_labelTruripRatings";
            this._labelTruripRatings.Size = new System.Drawing.Size(58, 31);
            this._labelTruripRatings.TabIndex = 33;
            this._labelTruripRatings.Text = "Ratings :";
            this._labelTruripRatings.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripPlayers
            // 
            this._labelTruripPlayers.AutoSize = true;
            this._labelTruripPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripPlayers.Location = new System.Drawing.Point(0, 374);
            this._labelTruripPlayers.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripPlayers.Name = "_labelTruripPlayers";
            this._labelTruripPlayers.Size = new System.Drawing.Size(93, 31);
            this._labelTruripPlayers.TabIndex = 34;
            this._labelTruripPlayers.Text = "Players :";
            this._labelTruripPlayers.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripSubGenre
            // 
            this._labelTruripSubGenre.AutoSize = true;
            this._labelTruripSubGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripSubGenre.Location = new System.Drawing.Point(68, 374);
            this._labelTruripSubGenre.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripSubGenre.Name = "_labelTruripSubGenre";
            this._labelTruripSubGenre.Size = new System.Drawing.Size(72, 31);
            this._labelTruripSubGenre.TabIndex = 35;
            this._labelTruripSubGenre.Text = "SubGenre :";
            this._labelTruripSubGenre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripScore
            // 
            this._labelTruripScore.AutoSize = true;
            this._labelTruripScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripScore.Location = new System.Drawing.Point(115, 374);
            this._labelTruripScore.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripScore.Name = "_labelTruripScore";
            this._labelTruripScore.Size = new System.Drawing.Size(58, 31);
            this._labelTruripScore.TabIndex = 36;
            this._labelTruripScore.Text = "Score :";
            this._labelTruripScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textTruripYear
            // 
            this._textTruripYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripYear.Location = new System.Drawing.Point(96, 346);
            this._textTruripYear.Name = "_textTruripYear";
            this._textTruripYear.ReadOnly = true;
            this._textTruripYear.Size = new System.Drawing.Size(1, 25);
            this._textTruripYear.TabIndex = 37;
            this._textTruripYear.Text = "these 6 = trurip";
            // 
            // GameDetailsRhsFLP
            // 
            this.GameDetailsRhsFLP.AutoSize = true;
            this.GameDetailsRhsFLP.Controls.Add(this.chkBoxShowComplete);
            this.GameDetailsRhsFLP.Controls.Add(this.chkBoxShowPartial);
            this.GameDetailsRhsFLP.Controls.Add(this.chkBoxShowEmpty);
            this.GameDetailsRhsFLP.Controls.Add(this.chkBoxShowFixes);
            this.GameDetailsRhsFLP.Controls.Add(this.chkBoxShowMIA);
            this.GameDetailsRhsFLP.Controls.Add(this.chkBoxShowMerged);
            this.GameDetailsRhsFLP.Controls.Add(this.SearchTLP);
            this.GameDetailsRhsFLP.Dock = System.Windows.Forms.DockStyle.Right;
            this.GameDetailsRhsFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.GameDetailsRhsFLP.Location = new System.Drawing.Point(156, 0);
            this.GameDetailsRhsFLP.Name = "GameDetailsRhsFLP";
            this.GameDetailsRhsFLP.Padding = new System.Windows.Forms.Padding(4);
            this.GameDetailsRhsFLP.Size = new System.Drawing.Size(196, 420);
            this.GameDetailsRhsFLP.TabIndex = 21;
            // 
            // chkBoxShowComplete
            // 
            this.chkBoxShowComplete.AutoSize = true;
            this.chkBoxShowComplete.Checked = true;
            this.chkBoxShowComplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowComplete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxShowComplete.Location = new System.Drawing.Point(7, 7);
            this.chkBoxShowComplete.Name = "chkBoxShowComplete";
            this.chkBoxShowComplete.Size = new System.Drawing.Size(124, 22);
            this.chkBoxShowComplete.TabIndex = 5;
            this.chkBoxShowComplete.Text = "Show Complete";
            this.chkBoxShowComplete.UseVisualStyleBackColor = true;
            this.chkBoxShowComplete.CheckedChanged += new System.EventHandler(this.ChkBoxShowCompleteCheckedChanged);
            // 
            // chkBoxShowPartial
            // 
            this.chkBoxShowPartial.AutoSize = true;
            this.chkBoxShowPartial.Checked = true;
            this.chkBoxShowPartial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowPartial.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxShowPartial.Location = new System.Drawing.Point(7, 35);
            this.chkBoxShowPartial.Name = "chkBoxShowPartial";
            this.chkBoxShowPartial.Size = new System.Drawing.Size(104, 22);
            this.chkBoxShowPartial.TabIndex = 6;
            this.chkBoxShowPartial.Text = "Show Partial";
            this.chkBoxShowPartial.UseVisualStyleBackColor = true;
            this.chkBoxShowPartial.CheckedChanged += new System.EventHandler(this.ChkBoxShowPartialCheckedChanged);
            // 
            // chkBoxShowEmpty
            // 
            this.chkBoxShowEmpty.AutoSize = true;
            this.chkBoxShowEmpty.Checked = true;
            this.chkBoxShowEmpty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowEmpty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxShowEmpty.Location = new System.Drawing.Point(7, 63);
            this.chkBoxShowEmpty.Name = "chkBoxShowEmpty";
            this.chkBoxShowEmpty.Size = new System.Drawing.Size(104, 22);
            this.chkBoxShowEmpty.TabIndex = 20;
            this.chkBoxShowEmpty.Text = "Show Empty";
            this.chkBoxShowEmpty.UseVisualStyleBackColor = true;
            this.chkBoxShowEmpty.CheckedChanged += new System.EventHandler(this.chkBoxShowEmptyCheckedChanged);
            // 
            // chkBoxShowFixes
            // 
            this.chkBoxShowFixes.AutoSize = true;
            this.chkBoxShowFixes.Checked = true;
            this.chkBoxShowFixes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowFixes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxShowFixes.Location = new System.Drawing.Point(7, 91);
            this.chkBoxShowFixes.Name = "chkBoxShowFixes";
            this.chkBoxShowFixes.Size = new System.Drawing.Size(96, 22);
            this.chkBoxShowFixes.TabIndex = 7;
            this.chkBoxShowFixes.Text = "Show Fixes";
            this.chkBoxShowFixes.UseVisualStyleBackColor = true;
            this.chkBoxShowFixes.CheckedChanged += new System.EventHandler(this.ChkBoxShowFixesCheckedChanged);
            // 
            // chkBoxShowMIA
            // 
            this.chkBoxShowMIA.AutoSize = true;
            this.chkBoxShowMIA.Checked = true;
            this.chkBoxShowMIA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxShowMIA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxShowMIA.Location = new System.Drawing.Point(7, 119);
            this.chkBoxShowMIA.Name = "chkBoxShowMIA";
            this.chkBoxShowMIA.Size = new System.Drawing.Size(91, 22);
            this.chkBoxShowMIA.TabIndex = 19;
            this.chkBoxShowMIA.Text = "Show MIA";
            this.chkBoxShowMIA.UseVisualStyleBackColor = true;
            this.chkBoxShowMIA.CheckedChanged += new System.EventHandler(this.chkBoxShowMIA_CheckedChanged);
            // 
            // chkBoxShowMerged
            // 
            this.chkBoxShowMerged.AutoSize = true;
            this.chkBoxShowMerged.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxShowMerged.Location = new System.Drawing.Point(7, 147);
            this.chkBoxShowMerged.Name = "chkBoxShowMerged";
            this.chkBoxShowMerged.Size = new System.Drawing.Size(182, 22);
            this.chkBoxShowMerged.TabIndex = 8;
            this.chkBoxShowMerged.Text = "Show Merged / Deduped";
            this.chkBoxShowMerged.UseVisualStyleBackColor = true;
            this.chkBoxShowMerged.CheckedChanged += new System.EventHandler(this.ChkBoxShowMergedCheckedChanged);
            // 
            // SearchTLP
            // 
            this.SearchTLP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTLP.AutoSize = true;
            this.SearchTLP.ColumnCount = 2;
            this.SearchTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SearchTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.SearchTLP.Controls.Add(this.btnClear, 1, 0);
            this.SearchTLP.Controls.Add(this.txtFilter, 0, 0);
            this.SearchTLP.Location = new System.Drawing.Point(7, 175);
            this.SearchTLP.Name = "SearchTLP";
            this.SearchTLP.RowCount = 1;
            this.SearchTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SearchTLP.Size = new System.Drawing.Size(182, 31);
            this.SearchTLP.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::ROMVault.Properties.Resources.cross;
            this.btnClear.Location = new System.Drawing.Point(154, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(25, 25);
            this.btnClear.TabIndex = 18;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtFilter.Location = new System.Drawing.Point(3, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PromptColor = System.Drawing.Color.Gray;
            this.txtFilter.PromptItalicised = true;
            this.txtFilter.PromptOnEmpty = "Filter ROMS...";
            this.txtFilter.Size = new System.Drawing.Size(145, 25);
            this.txtFilter.TabIndex = 17;
            this.txtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
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
            this.splitListArt.Size = new System.Drawing.Size(352, 334);
            this.splitListArt.SplitterDistance = 272;
            this.splitListArt.TabIndex = 1;
            // 
            // GameRomPN
            // 
            this.GameRomPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameRomPN.Controls.Add(this.splitGameListRomList);
            this.GameRomPN.Controls.Add(this.GameRomNavigateToRootBT);
            this.GameRomPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameRomPN.Location = new System.Drawing.Point(0, 0);
            this.GameRomPN.Name = "GameRomPN";
            this.GameRomPN.Size = new System.Drawing.Size(272, 334);
            this.GameRomPN.TabIndex = 1;
            // 
            // splitGameListRomList
            // 
            this.splitGameListRomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGameListRomList.Location = new System.Drawing.Point(0, 25);
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
            this.splitGameListRomList.Size = new System.Drawing.Size(270, 307);
            this.splitGameListRomList.SplitterDistance = 192;
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
            this.GameGrid.Size = new System.Drawing.Size(542, 323);
            this.GameGrid.TabIndex = 4;
            this.GameGrid.VirtualMode = true;
            this.GameGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GameGrid_CellContentClick);
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
            this.RomGrid.Size = new System.Drawing.Size(270, 111);
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
            // GameRomNavigateToRootBT
            // 
            this.GameRomNavigateToRootBT.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.GameRomNavigateToRootBT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.GameRomNavigateToRootBT.Location = new System.Drawing.Point(0, 0);
            this.GameRomNavigateToRootBT.Name = "GameRomNavigateToRootBT";
            this.GameRomNavigateToRootBT.Size = new System.Drawing.Size(270, 25);
            this.GameRomNavigateToRootBT.TabIndex = 0;
            this.GameRomNavigateToRootBT.Text = "Navigate to Root";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
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
            this.TabEmuArc.Size = new System.Drawing.Size(76, 334);
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
            this.tabArtWork.Size = new System.Drawing.Size(68, 308);
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
            this.tabMedium.Size = new System.Drawing.Size(68, 308);
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
            this.tabScreens.Size = new System.Drawing.Size(68, 308);
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
            this.tabInfo.Size = new System.Drawing.Size(68, 308);
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
            this.txtInfo.Size = new System.Drawing.Size(68, 308);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.WordWrap = false;
            // 
            // tabInfo2
            // 
            this.tabInfo2.BackColor = System.Drawing.SystemColors.Control;
            this.tabInfo2.Controls.Add(this.txtInfo2);
            this.tabInfo2.Location = new System.Drawing.Point(4, 22);
            this.tabInfo2.Name = "tabInfo2";
            this.tabInfo2.Size = new System.Drawing.Size(68, 308);
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
            this.txtInfo2.Size = new System.Drawing.Size(68, 308);
            this.txtInfo2.TabIndex = 2;
            this.txtInfo2.WordWrap = false;
            // 
            // MainPG
            // 
            this.MainPG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPG.Location = new System.Drawing.Point(2, 58);
            this.MainPG.Name = "MainPG";
            this.MainPG.Size = new System.Drawing.Size(344, 706);
            this.MainPG.TabIndex = 0;
            this.MainPG.ToolbarVisible = false;
            this.MainPG.SelectedObjectsChanged += new System.EventHandler(this.MainPG_SelectedObjectsChanged);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(2, 33);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(344, 25);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // PgHeader
            // 
            this.PgHeader.Controls.Add(this.PgHeaderLB);
            this.PgHeader.Controls.Add(this.PgHeaderPB);
            this.PgHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PgHeader.Location = new System.Drawing.Point(2, 2);
            this.PgHeader.Name = "PgHeader";
            this.PgHeader.Padding = new System.Windows.Forms.Padding(4);
            this.PgHeader.Size = new System.Drawing.Size(344, 31);
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
            this.PgHeaderLB.Size = new System.Drawing.Size(309, 23);
            this.PgHeaderLB.TabIndex = 3;
            this.PgHeaderLB.Text = "Welcome to RomVault";
            this.PgHeaderLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmUpdateDATs
            // 
            this.tsmUpdateDATs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateNewDATsToolStripMenuItem,
            this.updateAllDATsToolStripMenuItem});
            this.tsmUpdateDATs.Name = "tsmUpdateDATs";
            this.tsmUpdateDATs.Size = new System.Drawing.Size(45, 20);
            this.tsmUpdateDATs.Text = "DATs";
            // 
            // updateNewDATsToolStripMenuItem
            // 
            this.updateNewDATsToolStripMenuItem.Image = global::ROMVault.Properties.Resources.arrowCircle;
            this.updateNewDATsToolStripMenuItem.Name = "updateNewDATsToolStripMenuItem";
            this.updateNewDATsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.updateNewDATsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.updateNewDATsToolStripMenuItem.Text = "Update New DATs";
            this.updateNewDATsToolStripMenuItem.Click += new System.EventHandler(this.updateNewDATsToolStripMenuItem_Click);
            // 
            // updateAllDATsToolStripMenuItem
            // 
            this.updateAllDATsToolStripMenuItem.Name = "updateAllDATsToolStripMenuItem";
            this.updateAllDATsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.updateAllDATsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.updateAllDATsToolStripMenuItem.Text = "Refresh All DATs";
            this.updateAllDATsToolStripMenuItem.Click += new System.EventHandler(this.updateAllDATsToolStripMenuItem_Click);
            // 
            // tsmScanROMs
            // 
            this.tsmScanROMs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToSortFolderToolStripMenuItem,
            this.toolStripSeparator2,
            this.tsmScanLevel1,
            this.tsmScanLevel2,
            this.tsmScanLevel3});
            this.tsmScanROMs.Name = "tsmScanROMs";
            this.tsmScanROMs.Size = new System.Drawing.Size(51, 20);
            this.tsmScanROMs.Text = "ROMs";
            // 
            // addNewToSortFolderToolStripMenuItem
            // 
            this.addNewToSortFolderToolStripMenuItem.Image = global::ROMVault.Properties.Resources.blue_folder__plus;
            this.addNewToSortFolderToolStripMenuItem.Name = "addNewToSortFolderToolStripMenuItem";
            this.addNewToSortFolderToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.addNewToSortFolderToolStripMenuItem.Text = "Add New ToSort Folder";
            this.addNewToSortFolderToolStripMenuItem.Click += new System.EventHandler(this.addNewToSortFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(350, 6);
            // 
            // tsmScanLevel1
            // 
            this.tsmScanLevel1.Image = global::ROMVault.Properties.Resources.arrowCircle;
            this.tsmScanLevel1.Name = "tsmScanLevel1";
            this.tsmScanLevel1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
            this.tsmScanLevel1.Size = new System.Drawing.Size(353, 22);
            this.tsmScanLevel1.Text = "Scan ticked new ROMs headers only";
            this.tsmScanLevel1.Click += new System.EventHandler(this.TsmScanLevel1Click);
            // 
            // tsmScanLevel2
            // 
            this.tsmScanLevel2.Name = "tsmScanLevel2";
            this.tsmScanLevel2.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsmScanLevel2.Size = new System.Drawing.Size(353, 22);
            this.tsmScanLevel2.Text = "Scan ticked new ROMs with full hash check";
            this.tsmScanLevel2.Click += new System.EventHandler(this.TsmScanLevel2Click);
            // 
            // tsmScanLevel3
            // 
            this.tsmScanLevel3.Name = "tsmScanLevel3";
            this.tsmScanLevel3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.tsmScanLevel3.Size = new System.Drawing.Size(353, 22);
            this.tsmScanLevel3.Text = "ReScan All ticked ROMs with full hash check";
            this.tsmScanLevel3.Click += new System.EventHandler(this.TsmScanLevel3Click);
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
            this.tsmFindFixes.Size = new System.Drawing.Size(44, 20);
            this.tsmFindFixes.Text = "Fixes";
            // 
            // findFixesToolStripMenuItem
            // 
            this.findFixesToolStripMenuItem.Image = global::ROMVault.Properties.Resources.magnifier_zoom;
            this.findFixesToolStripMenuItem.Name = "findFixesToolStripMenuItem";
            this.findFixesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.findFixesToolStripMenuItem.Text = "Find Fixes";
            this.findFixesToolStripMenuItem.Click += new System.EventHandler(this.findFixesToolStripMenuItem_Click);
            // 
            // findFixeswithLogToolStripMenuItem
            // 
            this.findFixeswithLogToolStripMenuItem.Name = "findFixeswithLogToolStripMenuItem";
            this.findFixeswithLogToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.findFixeswithLogToolStripMenuItem.Text = "Find Fixes (with log)";
            this.findFixeswithLogToolStripMenuItem.Click += new System.EventHandler(this.findFixeswithLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // fixROMsToolStripMenuItem1
            // 
            this.fixROMsToolStripMenuItem1.Image = global::ROMVault.Properties.Resources.wand_magic;
            this.fixROMsToolStripMenuItem1.Name = "fixROMsToolStripMenuItem1";
            this.fixROMsToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.fixROMsToolStripMenuItem1.Text = "Fix ROMs";
            this.fixROMsToolStripMenuItem1.Click += new System.EventHandler(this.fixROMsToolStripMenuItem1_Click);
            // 
            // scanFindAndFixROMsToolStripMenuItem
            // 
            this.scanFindAndFixROMsToolStripMenuItem.Name = "scanFindAndFixROMsToolStripMenuItem";
            this.scanFindAndFixROMsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.scanFindAndFixROMsToolStripMenuItem.Text = "Scan and Fix ROMs";
            this.scanFindAndFixROMsToolStripMenuItem.ToolTipText = "This combines operations: scans ROMs, finds fixes and applies them";
            this.scanFindAndFixROMsToolStripMenuItem.Click += new System.EventHandler(this.scanFindAndFixROMsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fixDatReportToolStripMenuItem,
            this.fullReportToolStripMenuItem,
            this.fixReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // fixDatReportToolStripMenuItem
            // 
            this.fixDatReportToolStripMenuItem.Image = global::ROMVault.Properties.Resources.blue_document_text;
            this.fixDatReportToolStripMenuItem.Name = "fixDatReportToolStripMenuItem";
            this.fixDatReportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.fixDatReportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fixDatReportToolStripMenuItem.Text = "Fix Dat Report";
            this.fixDatReportToolStripMenuItem.Click += new System.EventHandler(this.fixDatReportToolStripMenuItem_Click);
            // 
            // fullReportToolStripMenuItem
            // 
            this.fullReportToolStripMenuItem.Name = "fullReportToolStripMenuItem";
            this.fullReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F9)));
            this.fullReportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fullReportToolStripMenuItem.Text = "Full Report";
            this.fullReportToolStripMenuItem.Click += new System.EventHandler(this.fullReportToolStripMenuItem_Click);
            // 
            // fixReportToolStripMenuItem
            // 
            this.fixReportToolStripMenuItem.Name = "fixReportToolStripMenuItem";
            this.fixReportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F9)));
            this.fixReportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fixReportToolStripMenuItem.Text = "Fix Report";
            this.fixReportToolStripMenuItem.Click += new System.EventHandler(this.fixReportToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.directorySettingsToolStripMenuItem,
            this.directoryMappingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.romVaultSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // directorySettingsToolStripMenuItem
            // 
            this.directorySettingsToolStripMenuItem.Image = global::ROMVault.Properties.Resources.folder__pencil;
            this.directorySettingsToolStripMenuItem.Name = "directorySettingsToolStripMenuItem";
            this.directorySettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.directorySettingsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.directorySettingsToolStripMenuItem.Text = "Directory Dat Rules";
            this.directorySettingsToolStripMenuItem.Click += new System.EventHandler(this.DirectorySettingsToolStripMenuItem_Click);
            // 
            // directoryMappingsToolStripMenuItem
            // 
            this.directoryMappingsToolStripMenuItem.Name = "directoryMappingsToolStripMenuItem";
            this.directoryMappingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.directoryMappingsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.directoryMappingsToolStripMenuItem.Text = "Directory Mappings";
            this.directoryMappingsToolStripMenuItem.Click += new System.EventHandler(this.directoryMappingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
            // 
            // romVaultSettingsToolStripMenuItem
            // 
            this.romVaultSettingsToolStripMenuItem.Image = global::ROMVault.Properties.Resources.gear;
            this.romVaultSettingsToolStripMenuItem.Name = "romVaultSettingsToolStripMenuItem";
            this.romVaultSettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.romVaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.romVaultSettingsToolStripMenuItem.Text = "Settings";
            this.romVaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.RomVaultSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torrentZipToolStripMenuItem,
            this.visitHelpWikiToolStripMenuItem,
            this.colorKeyToolStripMenuItem,
            this.whatsNewToolStripMenuItem,
            this.aboutRomVaultToolStripMenuItem,
            this.testToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // torrentZipToolStripMenuItem
            // 
            this.torrentZipToolStripMenuItem.Name = "torrentZipToolStripMenuItem";
            this.torrentZipToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.torrentZipToolStripMenuItem.Text = "Structured Archive Maker";
            this.torrentZipToolStripMenuItem.Click += new System.EventHandler(this.torrentZipToolStripMenuItem_Click);
            // 
            // visitHelpWikiToolStripMenuItem
            // 
            this.visitHelpWikiToolStripMenuItem.Name = "visitHelpWikiToolStripMenuItem";
            this.visitHelpWikiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.visitHelpWikiToolStripMenuItem.Text = "Visit Help Wiki";
            this.visitHelpWikiToolStripMenuItem.Click += new System.EventHandler(this.visitHelpWikiToolStripMenuItem_Click);
            // 
            // colorKeyToolStripMenuItem
            // 
            this.colorKeyToolStripMenuItem.Name = "colorKeyToolStripMenuItem";
            this.colorKeyToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.colorKeyToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.colorKeyToolStripMenuItem.Text = "Color Key";
            this.colorKeyToolStripMenuItem.Click += new System.EventHandler(this.colorKeyToolStripMenuItem_Click);
            // 
            // whatsNewToolStripMenuItem
            // 
            this.whatsNewToolStripMenuItem.Name = "whatsNewToolStripMenuItem";
            this.whatsNewToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.whatsNewToolStripMenuItem.Text = "Whats New";
            this.whatsNewToolStripMenuItem.Click += new System.EventHandler(this.whatsNewToolStripMenuItem_Click);
            // 
            // aboutRomVaultToolStripMenuItem
            // 
            this.aboutRomVaultToolStripMenuItem.Name = "aboutRomVaultToolStripMenuItem";
            this.aboutRomVaultToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutRomVaultToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.aboutRomVaultToolStripMenuItem.Text = "About RomVault";
            this.aboutRomVaultToolStripMenuItem.Click += new System.EventHandler(this.AboutRomVaultToolStripMenuItemClick);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
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
            // tooltip
            // 
            this.tooltip.AutoPopDelay = 32767;
            this.tooltip.InitialDelay = 1000;
            this.tooltip.ReshowDelay = 500;
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
            this.DatsControlSSBT.Image = global::ROMVault.Properties.Resources.database__arrow;
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
            this.RomsControlSSBT.Image = global::ROMVault.Properties.Resources.disc__arrow;
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
            this.MainSC.Panel1.ResumeLayout(false);
            this.MainSC.Panel2.ResumeLayout(false);
            this.MainSC.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSC)).EndInit();
            this.MainSC.ResumeLayout(false);
            this.splitDatInfoGameInfo.Panel1.ResumeLayout(false);
            this.splitDatInfoGameInfo.Panel1.PerformLayout();
            this.splitDatInfoGameInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDatInfoGameInfo)).EndInit();
            this.splitDatInfoGameInfo.ResumeLayout(false);
            this.DatInfoPN.ResumeLayout(false);
            this.DatInfoPN.PerformLayout();
            this.DatTreePN.ResumeLayout(false);
            this.DatTreePN.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.RomsStatusTagsFLP.ResumeLayout(false);
            this.RomsStatusTagsFLP.PerformLayout();
            this.RomsPathFPR.ResumeLayout(false);
            this.RomsPathFPR.PerformLayout();
            this.DatNameFPR.ResumeLayout(false);
            this.DatNameFPR.PerformLayout();
            this.VaultHeaderPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitGameInfoLists.Panel1.ResumeLayout(false);
            this.splitGameInfoLists.Panel1.PerformLayout();
            this.splitGameInfoLists.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGameInfoLists)).EndInit();
            this.splitGameInfoLists.ResumeLayout(false);
            this.GameInfoWrapperPanel.ResumeLayout(false);
            this.GameInfoWrapperPanel.PerformLayout();
            this.GameInfoTLP.ResumeLayout(false);
            this.GameInfoTLP.PerformLayout();
            this.GameDetailsRhsFLP.ResumeLayout(false);
            this.GameDetailsRhsFLP.PerformLayout();
            this.SearchTLP.ResumeLayout(false);
            this.SearchTLP.PerformLayout();
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
            this.GameRomNavigateToRootBT.ResumeLayout(false);
            this.GameRomNavigateToRootBT.PerformLayout();
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
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.PgHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PgHeaderPB)).EndInit();
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
        private System.Windows.Forms.CheckBox chkBoxShowMerged;
        private System.Windows.Forms.CheckBox chkBoxShowFixes;
        private System.Windows.Forms.CheckBox chkBoxShowPartial;
        private System.Windows.Forms.CheckBox chkBoxShowComplete;
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
        private System.Windows.Forms.Button btnClear;
        private UserControls.PromptTextBox txtFilter;
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
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.CheckBox chkBoxShowMIA;
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
        private System.Windows.Forms.CheckBox chkBoxShowEmpty;
        private System.Windows.Forms.TabPage tabInfo2;
        private System.Windows.Forms.TextBox txtInfo2;
        private System.Windows.Forms.Panel DatInfoPN;
        private UserControls.TableLayoutPanel GameInfoTLP;
        private System.Windows.Forms.TextBox _textGameDescription;
        private System.Windows.Forms.Label _labelGameDescription;
        private System.Windows.Forms.Label _labelGameManufacturer;
        private System.Windows.Forms.TextBox _textGameManufacturer;
        private System.Windows.Forms.TextBox _textGameCloneOf;
        private System.Windows.Forms.Label _labelGameCloneOf;
        private System.Windows.Forms.TextBox _textGameYear;
        private System.Windows.Forms.Label _labelGameYear;
        private System.Windows.Forms.TextBox _textTruripTitleId;
        private System.Windows.Forms.Label _labelTruripTitleId;
        private System.Windows.Forms.Label _labelTruripPublisher;
        private System.Windows.Forms.Panel Padding5PN;
        private System.Windows.Forms.Panel PaddingPN2;
        private System.Windows.Forms.Panel Padding4PN;
        private System.Windows.Forms.Panel Padding3PN;
        private System.Windows.Forms.Panel PaddingPN;
        private System.Windows.Forms.Label _textTruripPublisher;
        private System.Windows.Forms.TextBox _textTruripSource;
        private System.Windows.Forms.TextBox _textTruripDeveloper;
        private System.Windows.Forms.Label _labelTruripDeveloper;
        private System.Windows.Forms.Label _labelTruripSource;
        private System.Windows.Forms.TextBox _textGameCategory;
        private System.Windows.Forms.Label _labelGameRomOf;
        private System.Windows.Forms.Label _labelGameCategory;
        private System.Windows.Forms.TextBox _textGameRomOf;
        private System.Windows.Forms.TextBox _textTruripCloneOf;
        private System.Windows.Forms.Label _labelTruripCloneOf;
        private System.Windows.Forms.TextBox _textTruripRelatedTo;
        private System.Windows.Forms.Label _labelTruripRelatedTo;
        private System.Windows.Forms.Label _labelTruripYear;
        private System.Windows.Forms.Label _labelTruripGenre;
        private System.Windows.Forms.Label _labelTruripRatings;
        private System.Windows.Forms.Label _labelTruripPlayers;
        private System.Windows.Forms.TextBox _textTruripScore;
        private System.Windows.Forms.TextBox _textTruripSubGenre;
        private System.Windows.Forms.TextBox _textTruripPlayers;
        private System.Windows.Forms.TextBox _textTruripRatings;
        private System.Windows.Forms.TextBox _textTruripGenre;
        private System.Windows.Forms.Label _labelTruripSubGenre;
        private System.Windows.Forms.Label _labelTruripScore;
        private System.Windows.Forms.TextBox _textTruripYear;
        private System.Windows.Forms.StatusStrip MainSS;
        private System.Windows.Forms.FlowLayoutPanel GameDetailsRhsFLP;
        private System.Windows.Forms.TableLayoutPanel SearchTLP;
        private System.Windows.Forms.Panel GameInfoWrapperPanel;
        private UserControls.FlexiLabel flexiLabel1;
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
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripDropDownButton DatsControlSSBT;
        private ToolStripMenuItem DatsGroupVisibilitySSBT;
        private ToolStripMenuItem DatsShortnameToggleSSBT;
        private ToolStripDropDownButton RomsControlSSBT;
        private ToolStripMenuItem RomsGroupVisibilitySSBT;
        private ToolStripMenuItem RomsShortnameToggleSSBT;
        private ToolStrip toolStrip1;
        private ToolStripButton DatsCollapseTreeBT;
        private Panel DatTreePN;
        private Panel GameRomPN;
        private ToolStrip GameRomNavigateToRootBT;
        private ToolStripButton toolStripButton1;
        private TextBox _textGameName;
        private Label _labelGameName;
        private SplitContainer MainSC;
        private PropertyGrid MainPG;
        private FlexiLabel PgHeaderLB;
        private Panel PgHeader;
        private PictureBox PgHeaderPB;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton2;
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
    }
}

