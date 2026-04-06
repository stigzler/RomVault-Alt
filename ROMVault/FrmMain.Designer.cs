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
            this.DatINfoTlpPN = new System.Windows.Forms.Panel();
            this.ctrRvTree = new ROMVault.RvTree();
            this.DatInfoTLP = new System.Windows.Forms.TableLayoutPanel();
            this.flexiLabel2 = new ROMVault.UserControls.FlexiLabel();
            this.lblDITDate = new System.Windows.Forms.TextBox();
            this.lblDITVersion = new System.Windows.Forms.TextBox();
            this.lblDIName = new System.Windows.Forms.Label();
            this.lblDIDate = new System.Windows.Forms.Label();
            this.lblDICategory = new System.Windows.Forms.Label();
            this.lblDIVersion = new System.Windows.Forms.Label();
            this.lblDIDescription = new System.Windows.Forms.Label();
            this.lblDIAuthor = new System.Windows.Forms.Label();
            this.lblDITAuthor = new System.Windows.Forms.TextBox();
            this.lblDITCategory = new System.Windows.Forms.TextBox();
            this.lblDITName = new System.Windows.Forms.TextBox();
            this.lblDITDescription = new System.Windows.Forms.TextBox();
            this.lblDITRomsMissing = new System.Windows.Forms.TextBox();
            this.lblDITRomsGot = new System.Windows.Forms.TextBox();
            this.lblDIROMsMissing = new System.Windows.Forms.Label();
            this.lblDIROMsGot = new System.Windows.Forms.Label();
            this.lblDIRomsUnknown = new System.Windows.Forms.Label();
            this.lblDIRomsFixable = new System.Windows.Forms.Label();
            this.lblDIRomPath = new System.Windows.Forms.Label();
            this.lblDITRomsUnknown = new System.Windows.Forms.TextBox();
            this.lblDITRomsFixable = new System.Windows.Forms.TextBox();
            this.lblDITPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitGameInfoLists = new System.Windows.Forms.SplitContainer();
            this.GameInfoWrapperPanel = new System.Windows.Forms.Panel();
            this.GameInfoTLP = new System.Windows.Forms.TableLayoutPanel();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this._textTruripScore = new System.Windows.Forms.TextBox();
            this._textTruripSubGenre = new System.Windows.Forms.TextBox();
            this._textTruripPlayers = new System.Windows.Forms.TextBox();
            this._textTruripRatings = new System.Windows.Forms.TextBox();
            this._textTruripGenre = new System.Windows.Forms.TextBox();
            this._labelTruripYear = new System.Windows.Forms.Label();
            this._textTruripRelatedTo = new System.Windows.Forms.TextBox();
            this._labelTruripRelatedTo = new System.Windows.Forms.Label();
            this._textTruripCloneOf = new System.Windows.Forms.TextBox();
            this._labelTruripCloneOf = new System.Windows.Forms.Label();
            this._labelGameName = new System.Windows.Forms.Label();
            this._textGameDescription = new System.Windows.Forms.TextBox();
            this._labelGameDescription = new System.Windows.Forms.Label();
            this._textGameName = new System.Windows.Forms.TextBox();
            this._textGameRomOf = new System.Windows.Forms.TextBox();
            this._textTruripDeveloper = new System.Windows.Forms.TextBox();
            this._textGameCloneOf = new System.Windows.Forms.TextBox();
            this._textTruripPublisher = new System.Windows.Forms.TextBox();
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
            this._textGameManufacturer = new System.Windows.Forms.TextBox();
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
            this.tsmScanROMs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmScanLevel3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFindFixes = new System.Windows.Forms.ToolStripMenuItem();
            this.FixROMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixDatReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romVaultSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryMappingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torrentZipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitHelpWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whatsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutRomVaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.garbageCollectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.MainSS = new System.Windows.Forms.StatusStrip();
            this.ToggleStatusTextBT = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToggleDatKeyLB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToggleGameKeyLB = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.DatINfoTlpPN.SuspendLayout();
            this.DatInfoTLP.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitGameListRomList)).BeginInit();
            this.splitGameListRomList.Panel1.SuspendLayout();
            this.splitGameListRomList.Panel2.SuspendLayout();
            this.splitGameListRomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RomGrid)).BeginInit();
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
            this.splitToolBarMain.Location = new System.Drawing.Point(0, 24);
            this.splitToolBarMain.Name = "splitToolBarMain";
            // 
            // splitToolBarMain.Panel1
            // 
            this.splitToolBarMain.Panel1.BackColor = System.Drawing.Color.White;
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
            this.splitToolBarMain.Panel1.Resize += new System.EventHandler(this.splitToolBarMain_Panel1_Resize);
            // 
            // splitToolBarMain.Panel2
            // 
            this.splitToolBarMain.Panel2.Controls.Add(this.splitDatInfoGameInfo);
            this.splitToolBarMain.Size = new System.Drawing.Size(1430, 908);
            this.splitToolBarMain.SplitterDistance = 144;
            this.splitToolBarMain.TabIndex = 5;
            this.splitToolBarMain.SplitterMoving += new System.Windows.Forms.SplitterCancelEventHandler(this.splitToolBarMain_SplitterMoving);
            this.splitToolBarMain.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitToolBarMain_SplitterMoved);
            // 
            // HideNavBT
            // 
            this.HideNavBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.HideNavBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.HideNavBT.FlatAppearance.BorderSize = 0;
            this.HideNavBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideNavBT.Image = global::ROMVault.Properties.Resources.Back__Custom_;
            this.HideNavBT.Location = new System.Drawing.Point(4, 314);
            this.HideNavBT.Name = "HideNavBT";
            this.HideNavBT.Size = new System.Drawing.Size(136, 52);
            this.HideNavBT.TabIndex = 23;
            this.HideNavBT.UseVisualStyleBackColor = true;
            this.HideNavBT.Click += new System.EventHandler(this.HideNavBT_Click);
            // 
            // flexiLabel3
            // 
            this.flexiLabel3.AutoSize = true;
            this.flexiLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flexiLabel3.Font = new System.Drawing.Font("Segoe UI", 11.7F, System.Drawing.FontStyle.Bold);
            this.flexiLabel3.FontStyle = System.Drawing.FontStyle.Bold;
            this.flexiLabel3.Location = new System.Drawing.Point(4, 759);
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 780);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(136, 124);
            this.flowLayoutPanel1.TabIndex = 21;
            // 
            // btnDefault1
            // 
            this.btnDefault1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefault1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDefault1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault1.Image = global::ROMVault.Properties.Resources.Favourite1__Custom_;
            this.btnDefault1.Location = new System.Drawing.Point(3, 3);
            this.btnDefault1.Name = "btnDefault1";
            this.btnDefault1.Size = new System.Drawing.Size(56, 56);
            this.btnDefault1.TabIndex = 14;
            this.btnDefault1.UseVisualStyleBackColor = true;
            this.btnDefault1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDefault1_MouseDown);
            // 
            // btnDefault2
            // 
            this.btnDefault2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefault2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDefault2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault2.Image = global::ROMVault.Properties.Resources.Favourite2__Custom_;
            this.btnDefault2.Location = new System.Drawing.Point(65, 3);
            this.btnDefault2.Name = "btnDefault2";
            this.btnDefault2.Size = new System.Drawing.Size(56, 56);
            this.btnDefault2.TabIndex = 15;
            this.btnDefault2.UseVisualStyleBackColor = true;
            this.btnDefault2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDefault2_MouseDown);
            // 
            // btnDefault3
            // 
            this.btnDefault3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefault3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDefault3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault3.Image = global::ROMVault.Properties.Resources.Favourite3__Custom_;
            this.btnDefault3.Location = new System.Drawing.Point(3, 65);
            this.btnDefault3.Name = "btnDefault3";
            this.btnDefault3.Size = new System.Drawing.Size(56, 56);
            this.btnDefault3.TabIndex = 16;
            this.btnDefault3.UseVisualStyleBackColor = true;
            this.btnDefault3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDefault3_MouseDown);
            // 
            // btnDefault4
            // 
            this.btnDefault4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDefault4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDefault4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault4.Image = global::ROMVault.Properties.Resources.Favourite4__Custom_;
            this.btnDefault4.Location = new System.Drawing.Point(65, 65);
            this.btnDefault4.Name = "btnDefault4";
            this.btnDefault4.Size = new System.Drawing.Size(56, 56);
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
            this.gbDatInfo.Resize += new System.EventHandler(this.gbDatInfo_Resize);
            // 
            // Padding5PN
            // 
            this.Padding5PN.Controls.Add(this.btnReport);
            this.Padding5PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Padding5PN.Location = new System.Drawing.Point(4, 252);
            this.Padding5PN.Name = "Padding5PN";
            this.Padding5PN.Padding = new System.Windows.Forms.Padding(2);
            this.Padding5PN.Size = new System.Drawing.Size(136, 62);
            this.Padding5PN.TabIndex = 20;
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = global::ROMVault.Properties.Resources.GenerateReports__Custom_;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(2, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(3);
            this.btnReport.Size = new System.Drawing.Size(132, 58);
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
            this.Padding4PN.Size = new System.Drawing.Size(136, 62);
            this.Padding4PN.TabIndex = 20;
            // 
            // btnFixFiles
            // 
            this.btnFixFiles.AutoSize = true;
            this.btnFixFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFixFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFixFiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnFixFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixFiles.Image = global::ROMVault.Properties.Resources.Fix_Roms__Custom_;
            this.btnFixFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixFiles.Location = new System.Drawing.Point(2, 2);
            this.btnFixFiles.Name = "btnFixFiles";
            this.btnFixFiles.Padding = new System.Windows.Forms.Padding(3);
            this.btnFixFiles.Size = new System.Drawing.Size(132, 58);
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
            this.Padding3PN.Size = new System.Drawing.Size(136, 62);
            this.Padding3PN.TabIndex = 20;
            // 
            // btnFindFixes
            // 
            this.btnFindFixes.AutoSize = true;
            this.btnFindFixes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFindFixes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFindFixes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnFindFixes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindFixes.Image = global::ROMVault.Properties.Resources.FindFixes__Custom_;
            this.btnFindFixes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindFixes.Location = new System.Drawing.Point(2, 2);
            this.btnFindFixes.Name = "btnFindFixes";
            this.btnFindFixes.Padding = new System.Windows.Forms.Padding(3);
            this.btnFindFixes.Size = new System.Drawing.Size(132, 58);
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
            this.PaddingPN2.Size = new System.Drawing.Size(136, 62);
            this.PaddingPN2.TabIndex = 20;
            // 
            // btnScanRoms
            // 
            this.btnScanRoms.AutoSize = true;
            this.btnScanRoms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnScanRoms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScanRoms.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnScanRoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanRoms.Image = global::ROMVault.Properties.Resources.ScanRoms__Custom_;
            this.btnScanRoms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanRoms.Location = new System.Drawing.Point(2, 2);
            this.btnScanRoms.Name = "btnScanRoms";
            this.btnScanRoms.Padding = new System.Windows.Forms.Padding(3);
            this.btnScanRoms.Size = new System.Drawing.Size(132, 58);
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
            this.PaddingPN.Size = new System.Drawing.Size(136, 62);
            this.PaddingPN.TabIndex = 19;
            // 
            // btnUpdateDats
            // 
            this.btnUpdateDats.AutoSize = true;
            this.btnUpdateDats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateDats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateDats.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnUpdateDats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDats.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateDats.Image")));
            this.btnUpdateDats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateDats.Location = new System.Drawing.Point(2, 2);
            this.btnUpdateDats.Name = "btnUpdateDats";
            this.btnUpdateDats.Padding = new System.Windows.Forms.Padding(3);
            this.btnUpdateDats.Size = new System.Drawing.Size(132, 58);
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
            this.splitDatInfoGameInfo.Panel1.Controls.Add(this.DatINfoTlpPN);
            this.splitDatInfoGameInfo.Panel1MinSize = 450;
            // 
            // splitDatInfoGameInfo.Panel2
            // 
            this.splitDatInfoGameInfo.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitDatInfoGameInfo.Panel2.Controls.Add(this.splitGameInfoLists);
            this.splitDatInfoGameInfo.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitDatInfoGameInfo.Size = new System.Drawing.Size(1282, 908);
            this.splitDatInfoGameInfo.SplitterDistance = 478;
            this.splitDatInfoGameInfo.TabIndex = 0;
            // 
            // DatINfoTlpPN
            // 
            this.DatINfoTlpPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatINfoTlpPN.Controls.Add(this.ctrRvTree);
            this.DatINfoTlpPN.Controls.Add(this.DatInfoTLP);
            this.DatINfoTlpPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatINfoTlpPN.Location = new System.Drawing.Point(0, 0);
            this.DatINfoTlpPN.Name = "DatINfoTlpPN";
            this.DatINfoTlpPN.Padding = new System.Windows.Forms.Padding(4);
            this.DatINfoTlpPN.Size = new System.Drawing.Size(478, 908);
            this.DatINfoTlpPN.TabIndex = 4;
            // 
            // ctrRvTree
            // 
            this.ctrRvTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctrRvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrRvTree.Location = new System.Drawing.Point(4, 257);
            this.ctrRvTree.Name = "ctrRvTree";
            this.ctrRvTree.Size = new System.Drawing.Size(468, 645);
            this.ctrRvTree.TabIndex = 2;
            this.ctrRvTree.RvSelected += new System.Windows.Forms.MouseEventHandler(this.DirTreeRvSelected);
            this.ctrRvTree.RvChecked += new System.Windows.Forms.MouseEventHandler(this.DirTreeRvChecked);
            // 
            // DatInfoTLP
            // 
            this.DatInfoTLP.AutoSize = true;
            this.DatInfoTLP.ColumnCount = 4;
            this.DatInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DatInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DatInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DatInfoTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DatInfoTLP.Controls.Add(this.flexiLabel2, 0, 0);
            this.DatInfoTLP.Controls.Add(this.lblDITDate, 3, 4);
            this.DatInfoTLP.Controls.Add(this.lblDITVersion, 3, 3);
            this.DatInfoTLP.Controls.Add(this.lblDIName, 0, 1);
            this.DatInfoTLP.Controls.Add(this.lblDIDate, 2, 4);
            this.DatInfoTLP.Controls.Add(this.lblDICategory, 0, 3);
            this.DatInfoTLP.Controls.Add(this.lblDIVersion, 2, 3);
            this.DatInfoTLP.Controls.Add(this.lblDIDescription, 0, 2);
            this.DatInfoTLP.Controls.Add(this.lblDIAuthor, 0, 4);
            this.DatInfoTLP.Controls.Add(this.lblDITAuthor, 1, 4);
            this.DatInfoTLP.Controls.Add(this.lblDITCategory, 1, 3);
            this.DatInfoTLP.Controls.Add(this.lblDITName, 1, 1);
            this.DatInfoTLP.Controls.Add(this.lblDITDescription, 1, 2);
            this.DatInfoTLP.Controls.Add(this.lblDITRomsMissing, 1, 8);
            this.DatInfoTLP.Controls.Add(this.lblDITRomsGot, 1, 7);
            this.DatInfoTLP.Controls.Add(this.lblDIROMsMissing, 0, 8);
            this.DatInfoTLP.Controls.Add(this.lblDIROMsGot, 0, 7);
            this.DatInfoTLP.Controls.Add(this.lblDIRomsUnknown, 2, 8);
            this.DatInfoTLP.Controls.Add(this.lblDIRomsFixable, 2, 7);
            this.DatInfoTLP.Controls.Add(this.lblDIRomPath, 0, 6);
            this.DatInfoTLP.Controls.Add(this.lblDITRomsUnknown, 3, 8);
            this.DatInfoTLP.Controls.Add(this.lblDITRomsFixable, 3, 7);
            this.DatInfoTLP.Controls.Add(this.lblDITPath, 1, 6);
            this.DatInfoTLP.Controls.Add(this.label1, 0, 5);
            this.DatInfoTLP.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatInfoTLP.Location = new System.Drawing.Point(4, 4);
            this.DatInfoTLP.Name = "DatInfoTLP";
            this.DatInfoTLP.Padding = new System.Windows.Forms.Padding(4);
            this.DatInfoTLP.RowCount = 10;
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DatInfoTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.DatInfoTLP.Size = new System.Drawing.Size(468, 253);
            this.DatInfoTLP.TabIndex = 4;
            // 
            // flexiLabel2
            // 
            this.flexiLabel2.AutoSize = true;
            this.DatInfoTLP.SetColumnSpan(this.flexiLabel2, 4);
            this.flexiLabel2.Font = new System.Drawing.Font("Segoe UI", 11.7F, System.Drawing.FontStyle.Bold);
            this.flexiLabel2.FontStyle = System.Drawing.FontStyle.Bold;
            this.flexiLabel2.Location = new System.Drawing.Point(7, 4);
            this.flexiLabel2.Name = "flexiLabel2";
            this.flexiLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.flexiLabel2.ScaleFactor = 1.2D;
            this.flexiLabel2.Size = new System.Drawing.Size(80, 27);
            this.flexiLabel2.TabIndex = 39;
            this.flexiLabel2.Text = "DAT Info:";
            // 
            // lblDITDate
            // 
            this.lblDITDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITDate.Location = new System.Drawing.Point(309, 113);
            this.lblDITDate.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITDate.Name = "lblDITDate";
            this.lblDITDate.ReadOnly = true;
            this.lblDITDate.Size = new System.Drawing.Size(154, 25);
            this.lblDITDate.TabIndex = 32;
            this.lblDITDate.TabStop = false;
            this.lblDITDate.Tag = "";
            // 
            // lblDITVersion
            // 
            this.lblDITVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITVersion.Location = new System.Drawing.Point(309, 86);
            this.lblDITVersion.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITVersion.Name = "lblDITVersion";
            this.lblDITVersion.ReadOnly = true;
            this.lblDITVersion.Size = new System.Drawing.Size(154, 25);
            this.lblDITVersion.TabIndex = 34;
            this.lblDITVersion.TabStop = false;
            this.lblDITVersion.Tag = "";
            // 
            // lblDIName
            // 
            this.lblDIName.AutoSize = true;
            this.lblDIName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIName.Location = new System.Drawing.Point(4, 31);
            this.lblDIName.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIName.Name = "lblDIName";
            this.lblDIName.Size = new System.Drawing.Size(81, 27);
            this.lblDIName.TabIndex = 3;
            this.lblDIName.Text = "Name :";
            this.lblDIName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIDate
            // 
            this.lblDIDate.AutoSize = true;
            this.lblDIDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIDate.Location = new System.Drawing.Point(240, 112);
            this.lblDIDate.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIDate.Name = "lblDIDate";
            this.lblDIDate.Size = new System.Drawing.Size(68, 27);
            this.lblDIDate.TabIndex = 12;
            this.lblDIDate.Text = "Date :";
            this.lblDIDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDICategory
            // 
            this.lblDICategory.AutoSize = true;
            this.lblDICategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDICategory.Location = new System.Drawing.Point(4, 85);
            this.lblDICategory.Margin = new System.Windows.Forms.Padding(0);
            this.lblDICategory.Name = "lblDICategory";
            this.lblDICategory.Size = new System.Drawing.Size(81, 27);
            this.lblDICategory.TabIndex = 7;
            this.lblDICategory.Text = "Category :";
            this.lblDICategory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIVersion
            // 
            this.lblDIVersion.AutoSize = true;
            this.lblDIVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIVersion.Location = new System.Drawing.Point(240, 85);
            this.lblDIVersion.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIVersion.Name = "lblDIVersion";
            this.lblDIVersion.Size = new System.Drawing.Size(68, 27);
            this.lblDIVersion.TabIndex = 8;
            this.lblDIVersion.Text = "Version :";
            this.lblDIVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIDescription
            // 
            this.lblDIDescription.AutoSize = true;
            this.lblDIDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIDescription.Location = new System.Drawing.Point(4, 58);
            this.lblDIDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIDescription.Name = "lblDIDescription";
            this.lblDIDescription.Size = new System.Drawing.Size(81, 27);
            this.lblDIDescription.TabIndex = 4;
            this.lblDIDescription.Text = "Description :";
            this.lblDIDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIAuthor
            // 
            this.lblDIAuthor.AutoSize = true;
            this.lblDIAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIAuthor.Location = new System.Drawing.Point(4, 112);
            this.lblDIAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIAuthor.Name = "lblDIAuthor";
            this.lblDIAuthor.Size = new System.Drawing.Size(81, 27);
            this.lblDIAuthor.TabIndex = 11;
            this.lblDIAuthor.Text = "Author :";
            this.lblDIAuthor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDITAuthor
            // 
            this.lblDITAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITAuthor.Location = new System.Drawing.Point(86, 113);
            this.lblDITAuthor.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITAuthor.Name = "lblDITAuthor";
            this.lblDITAuthor.ReadOnly = true;
            this.lblDITAuthor.Size = new System.Drawing.Size(153, 25);
            this.lblDITAuthor.TabIndex = 33;
            this.lblDITAuthor.TabStop = false;
            this.lblDITAuthor.Tag = "";
            // 
            // lblDITCategory
            // 
            this.lblDITCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITCategory.Location = new System.Drawing.Point(86, 86);
            this.lblDITCategory.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITCategory.Name = "lblDITCategory";
            this.lblDITCategory.ReadOnly = true;
            this.lblDITCategory.Size = new System.Drawing.Size(153, 25);
            this.lblDITCategory.TabIndex = 35;
            this.lblDITCategory.TabStop = false;
            this.lblDITCategory.Tag = "";
            // 
            // lblDITName
            // 
            this.lblDITName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatInfoTLP.SetColumnSpan(this.lblDITName, 3);
            this.lblDITName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITName.Location = new System.Drawing.Point(86, 32);
            this.lblDITName.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITName.Name = "lblDITName";
            this.lblDITName.ReadOnly = true;
            this.lblDITName.Size = new System.Drawing.Size(377, 25);
            this.lblDITName.TabIndex = 37;
            this.lblDITName.TabStop = false;
            this.lblDITName.Tag = "";
            this.lblDITName.Text = "wedwed";
            // 
            // lblDITDescription
            // 
            this.lblDITDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatInfoTLP.SetColumnSpan(this.lblDITDescription, 3);
            this.lblDITDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITDescription.Location = new System.Drawing.Point(86, 59);
            this.lblDITDescription.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITDescription.Name = "lblDITDescription";
            this.lblDITDescription.ReadOnly = true;
            this.lblDITDescription.Size = new System.Drawing.Size(377, 25);
            this.lblDITDescription.TabIndex = 36;
            this.lblDITDescription.TabStop = false;
            this.lblDITDescription.Tag = "";
            // 
            // lblDITRomsMissing
            // 
            this.lblDITRomsMissing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITRomsMissing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITRomsMissing.Location = new System.Drawing.Point(86, 219);
            this.lblDITRomsMissing.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITRomsMissing.Name = "lblDITRomsMissing";
            this.lblDITRomsMissing.ReadOnly = true;
            this.lblDITRomsMissing.Size = new System.Drawing.Size(153, 25);
            this.lblDITRomsMissing.TabIndex = 29;
            this.lblDITRomsMissing.TabStop = false;
            this.lblDITRomsMissing.Tag = "";
            // 
            // lblDITRomsGot
            // 
            this.lblDITRomsGot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITRomsGot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITRomsGot.Location = new System.Drawing.Point(86, 192);
            this.lblDITRomsGot.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITRomsGot.Name = "lblDITRomsGot";
            this.lblDITRomsGot.ReadOnly = true;
            this.lblDITRomsGot.Size = new System.Drawing.Size(153, 25);
            this.lblDITRomsGot.TabIndex = 30;
            this.lblDITRomsGot.TabStop = false;
            this.lblDITRomsGot.Tag = "";
            // 
            // lblDIROMsMissing
            // 
            this.lblDIROMsMissing.AutoSize = true;
            this.lblDIROMsMissing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIROMsMissing.Location = new System.Drawing.Point(4, 218);
            this.lblDIROMsMissing.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIROMsMissing.Name = "lblDIROMsMissing";
            this.lblDIROMsMissing.Size = new System.Drawing.Size(81, 27);
            this.lblDIROMsMissing.TabIndex = 24;
            this.lblDIROMsMissing.Text = "Missing :";
            this.lblDIROMsMissing.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIROMsGot
            // 
            this.lblDIROMsGot.AutoSize = true;
            this.lblDIROMsGot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIROMsGot.Location = new System.Drawing.Point(4, 191);
            this.lblDIROMsGot.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIROMsGot.Name = "lblDIROMsGot";
            this.lblDIROMsGot.Size = new System.Drawing.Size(81, 27);
            this.lblDIROMsGot.TabIndex = 23;
            this.lblDIROMsGot.Text = "Got :";
            this.lblDIROMsGot.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIRomsUnknown
            // 
            this.lblDIRomsUnknown.AutoSize = true;
            this.lblDIRomsUnknown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIRomsUnknown.Location = new System.Drawing.Point(240, 218);
            this.lblDIRomsUnknown.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIRomsUnknown.Name = "lblDIRomsUnknown";
            this.lblDIRomsUnknown.Size = new System.Drawing.Size(68, 27);
            this.lblDIRomsUnknown.TabIndex = 26;
            this.lblDIRomsUnknown.Text = "Unknown :";
            this.lblDIRomsUnknown.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIRomsFixable
            // 
            this.lblDIRomsFixable.AutoSize = true;
            this.lblDIRomsFixable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIRomsFixable.Location = new System.Drawing.Point(240, 191);
            this.lblDIRomsFixable.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIRomsFixable.Name = "lblDIRomsFixable";
            this.lblDIRomsFixable.Size = new System.Drawing.Size(68, 27);
            this.lblDIRomsFixable.TabIndex = 25;
            this.lblDIRomsFixable.Text = "Fixable :";
            this.lblDIRomsFixable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDIRomPath
            // 
            this.lblDIRomPath.AutoSize = true;
            this.lblDIRomPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDIRomPath.Location = new System.Drawing.Point(4, 164);
            this.lblDIRomPath.Margin = new System.Windows.Forms.Padding(0);
            this.lblDIRomPath.Name = "lblDIRomPath";
            this.lblDIRomPath.Size = new System.Drawing.Size(81, 27);
            this.lblDIRomPath.TabIndex = 15;
            this.lblDIRomPath.Text = "Path :";
            this.lblDIRomPath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDITRomsUnknown
            // 
            this.lblDITRomsUnknown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITRomsUnknown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITRomsUnknown.Location = new System.Drawing.Point(309, 219);
            this.lblDITRomsUnknown.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITRomsUnknown.Name = "lblDITRomsUnknown";
            this.lblDITRomsUnknown.ReadOnly = true;
            this.lblDITRomsUnknown.Size = new System.Drawing.Size(154, 25);
            this.lblDITRomsUnknown.TabIndex = 27;
            this.lblDITRomsUnknown.TabStop = false;
            this.lblDITRomsUnknown.Tag = "";
            // 
            // lblDITRomsFixable
            // 
            this.lblDITRomsFixable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDITRomsFixable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITRomsFixable.Location = new System.Drawing.Point(309, 192);
            this.lblDITRomsFixable.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITRomsFixable.Name = "lblDITRomsFixable";
            this.lblDITRomsFixable.ReadOnly = true;
            this.lblDITRomsFixable.Size = new System.Drawing.Size(154, 25);
            this.lblDITRomsFixable.TabIndex = 28;
            this.lblDITRomsFixable.TabStop = false;
            this.lblDITRomsFixable.Tag = "";
            // 
            // lblDITPath
            // 
            this.lblDITPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatInfoTLP.SetColumnSpan(this.lblDITPath, 3);
            this.lblDITPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDITPath.Location = new System.Drawing.Point(86, 165);
            this.lblDITPath.Margin = new System.Windows.Forms.Padding(1);
            this.lblDITPath.Name = "lblDITPath";
            this.lblDITPath.ReadOnly = true;
            this.lblDITPath.Size = new System.Drawing.Size(377, 25);
            this.lblDITPath.TabIndex = 31;
            this.lblDITPath.TabStop = false;
            this.lblDITPath.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.DatInfoTLP.SetColumnSpan(this.label1, 4);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.label1.Size = new System.Drawing.Size(460, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "ROMs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.splitGameInfoLists.Size = new System.Drawing.Size(792, 900);
            this.splitGameInfoLists.SplitterDistance = 429;
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
            this.GameInfoWrapperPanel.Size = new System.Drawing.Size(596, 429);
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
            this.GameInfoTLP.Controls.Add(this.flexiLabel1, 0, 0);
            this.GameInfoTLP.Controls.Add(this._textTruripScore, 5, 11);
            this.GameInfoTLP.Controls.Add(this._textTruripSubGenre, 3, 11);
            this.GameInfoTLP.Controls.Add(this._textTruripPlayers, 1, 11);
            this.GameInfoTLP.Controls.Add(this._textTruripRatings, 5, 10);
            this.GameInfoTLP.Controls.Add(this._textTruripGenre, 3, 10);
            this.GameInfoTLP.Controls.Add(this._labelTruripYear, 0, 10);
            this.GameInfoTLP.Controls.Add(this._textTruripRelatedTo, 1, 9);
            this.GameInfoTLP.Controls.Add(this._labelTruripRelatedTo, 0, 9);
            this.GameInfoTLP.Controls.Add(this._textTruripCloneOf, 1, 8);
            this.GameInfoTLP.Controls.Add(this._labelTruripCloneOf, 0, 8);
            this.GameInfoTLP.Controls.Add(this._labelGameName, 0, 1);
            this.GameInfoTLP.Controls.Add(this._textGameDescription, 1, 2);
            this.GameInfoTLP.Controls.Add(this._labelGameDescription, 0, 2);
            this.GameInfoTLP.Controls.Add(this._textGameName, 1, 1);
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
            this.GameInfoTLP.Controls.Add(this._textGameManufacturer, 1, 3);
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
            this.GameInfoTLP.Size = new System.Drawing.Size(586, 372);
            this.GameInfoTLP.TabIndex = 1;
            // 
            // flexiLabel1
            // 
            this.flexiLabel1.AutoSize = true;
            this.GameInfoTLP.SetColumnSpan(this.flexiLabel1, 6);
            this.flexiLabel1.Font = new System.Drawing.Font("Segoe UI", 11.7F, System.Drawing.FontStyle.Bold);
            this.flexiLabel1.FontStyle = System.Drawing.FontStyle.Bold;
            this.flexiLabel1.Location = new System.Drawing.Point(3, 0);
            this.flexiLabel1.Name = "flexiLabel1";
            this.flexiLabel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 6);
            this.flexiLabel1.ScaleFactor = 1.2D;
            this.flexiLabel1.Size = new System.Drawing.Size(93, 31);
            this.flexiLabel1.TabIndex = 21;
            this.flexiLabel1.Text = "Game Info:";
            // 
            // _textTruripScore
            // 
            this._textTruripScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripScore.Location = new System.Drawing.Point(468, 344);
            this._textTruripScore.Name = "_textTruripScore";
            this._textTruripScore.ReadOnly = true;
            this._textTruripScore.Size = new System.Drawing.Size(115, 25);
            this._textTruripScore.TabIndex = 42;
            // 
            // _textTruripSubGenre
            // 
            this._textTruripSubGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripSubGenre.Location = new System.Drawing.Point(289, 344);
            this._textTruripSubGenre.Name = "_textTruripSubGenre";
            this._textTruripSubGenre.ReadOnly = true;
            this._textTruripSubGenre.Size = new System.Drawing.Size(115, 25);
            this._textTruripSubGenre.TabIndex = 41;
            // 
            // _textTruripPlayers
            // 
            this._textTruripPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripPlayers.Location = new System.Drawing.Point(96, 344);
            this._textTruripPlayers.Name = "_textTruripPlayers";
            this._textTruripPlayers.ReadOnly = true;
            this._textTruripPlayers.Size = new System.Drawing.Size(115, 25);
            this._textTruripPlayers.TabIndex = 40;
            // 
            // _textTruripRatings
            // 
            this._textTruripRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripRatings.Location = new System.Drawing.Point(468, 313);
            this._textTruripRatings.Name = "_textTruripRatings";
            this._textTruripRatings.ReadOnly = true;
            this._textTruripRatings.Size = new System.Drawing.Size(115, 25);
            this._textTruripRatings.TabIndex = 39;
            // 
            // _textTruripGenre
            // 
            this._textTruripGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripGenre.Location = new System.Drawing.Point(289, 313);
            this._textTruripGenre.Name = "_textTruripGenre";
            this._textTruripGenre.ReadOnly = true;
            this._textTruripGenre.Size = new System.Drawing.Size(115, 25);
            this._textTruripGenre.TabIndex = 38;
            // 
            // _labelTruripYear
            // 
            this._labelTruripYear.AutoSize = true;
            this._labelTruripYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripYear.Location = new System.Drawing.Point(0, 310);
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
            this._textTruripRelatedTo.Location = new System.Drawing.Point(96, 282);
            this._textTruripRelatedTo.Name = "_textTruripRelatedTo";
            this._textTruripRelatedTo.ReadOnly = true;
            this._textTruripRelatedTo.Size = new System.Drawing.Size(487, 25);
            this._textTruripRelatedTo.TabIndex = 30;
            // 
            // _labelTruripRelatedTo
            // 
            this._labelTruripRelatedTo.AutoSize = true;
            this._labelTruripRelatedTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripRelatedTo.Location = new System.Drawing.Point(0, 279);
            this._labelTruripRelatedTo.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripRelatedTo.Name = "_labelTruripRelatedTo";
            this._labelTruripRelatedTo.Size = new System.Drawing.Size(93, 31);
            this._labelTruripRelatedTo.TabIndex = 29;
            this._labelTruripRelatedTo.Text = "Relatied To :";
            this._labelTruripRelatedTo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textTruripCloneOf
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripCloneOf, 5);
            this._textTruripCloneOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripCloneOf.Location = new System.Drawing.Point(96, 251);
            this._textTruripCloneOf.Name = "_textTruripCloneOf";
            this._textTruripCloneOf.ReadOnly = true;
            this._textTruripCloneOf.Size = new System.Drawing.Size(487, 25);
            this._textTruripCloneOf.TabIndex = 28;
            // 
            // _labelTruripCloneOf
            // 
            this._labelTruripCloneOf.AutoSize = true;
            this._labelTruripCloneOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripCloneOf.Location = new System.Drawing.Point(0, 248);
            this._labelTruripCloneOf.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripCloneOf.Name = "_labelTruripCloneOf";
            this._labelTruripCloneOf.Size = new System.Drawing.Size(93, 31);
            this._labelTruripCloneOf.TabIndex = 27;
            this._labelTruripCloneOf.Text = "Clone Of :";
            this._labelTruripCloneOf.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelGameName
            // 
            this._labelGameName.AutoSize = true;
            this._labelGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameName.Location = new System.Drawing.Point(0, 31);
            this._labelGameName.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameName.Name = "_labelGameName";
            this._labelGameName.Size = new System.Drawing.Size(93, 31);
            this._labelGameName.TabIndex = 7;
            this._labelGameName.Text = "Name :";
            this._labelGameName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textGameDescription
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameDescription, 5);
            this._textGameDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameDescription.Location = new System.Drawing.Point(96, 65);
            this._textGameDescription.Name = "_textGameDescription";
            this._textGameDescription.ReadOnly = true;
            this._textGameDescription.Size = new System.Drawing.Size(487, 25);
            this._textGameDescription.TabIndex = 6;
            // 
            // _labelGameDescription
            // 
            this._labelGameDescription.AutoSize = true;
            this._labelGameDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameDescription.Location = new System.Drawing.Point(0, 62);
            this._labelGameDescription.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameDescription.Name = "_labelGameDescription";
            this._labelGameDescription.Size = new System.Drawing.Size(93, 31);
            this._labelGameDescription.TabIndex = 5;
            this._labelGameDescription.Text = "Description :";
            this._labelGameDescription.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textGameName
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameName, 5);
            this._textGameName.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameName.Location = new System.Drawing.Point(96, 34);
            this._textGameName.Name = "_textGameName";
            this._textGameName.ReadOnly = true;
            this._textGameName.Size = new System.Drawing.Size(487, 25);
            this._textGameName.TabIndex = 1;
            // 
            // _textGameRomOf
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameRomOf, 2);
            this._textGameRomOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameRomOf.Location = new System.Drawing.Point(96, 220);
            this._textGameRomOf.Name = "_textGameRomOf";
            this._textGameRomOf.ReadOnly = true;
            this._textGameRomOf.Size = new System.Drawing.Size(187, 25);
            this._textGameRomOf.TabIndex = 25;
            // 
            // _textTruripDeveloper
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripDeveloper, 2);
            this._textTruripDeveloper.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripDeveloper.Location = new System.Drawing.Point(96, 189);
            this._textTruripDeveloper.Name = "_textTruripDeveloper";
            this._textTruripDeveloper.ReadOnly = true;
            this._textTruripDeveloper.Size = new System.Drawing.Size(187, 25);
            this._textTruripDeveloper.TabIndex = 21;
            // 
            // _textGameCloneOf
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameCloneOf, 2);
            this._textGameCloneOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameCloneOf.Location = new System.Drawing.Point(96, 158);
            this._textGameCloneOf.Name = "_textGameCloneOf";
            this._textGameCloneOf.ReadOnly = true;
            this._textGameCloneOf.Size = new System.Drawing.Size(187, 25);
            this._textGameCloneOf.TabIndex = 11;
            // 
            // _textTruripPublisher
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripPublisher, 2);
            this._textTruripPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripPublisher.Location = new System.Drawing.Point(96, 127);
            this._textTruripPublisher.Name = "_textTruripPublisher";
            this._textTruripPublisher.ReadOnly = true;
            this._textTruripPublisher.Size = new System.Drawing.Size(187, 25);
            this._textTruripPublisher.TabIndex = 18;
            // 
            // _textGameCategory
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameCategory, 2);
            this._textGameCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameCategory.Location = new System.Drawing.Point(410, 220);
            this._textGameCategory.Name = "_textGameCategory";
            this._textGameCategory.ReadOnly = true;
            this._textGameCategory.Size = new System.Drawing.Size(173, 25);
            this._textGameCategory.TabIndex = 26;
            // 
            // _textTruripSource
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripSource, 2);
            this._textTruripSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripSource.Location = new System.Drawing.Point(410, 189);
            this._textTruripSource.Name = "_textTruripSource";
            this._textTruripSource.ReadOnly = true;
            this._textTruripSource.Size = new System.Drawing.Size(173, 25);
            this._textTruripSource.TabIndex = 22;
            // 
            // _textGameYear
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameYear, 2);
            this._textGameYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameYear.Location = new System.Drawing.Point(410, 158);
            this._textGameYear.Name = "_textGameYear";
            this._textGameYear.ReadOnly = true;
            this._textGameYear.Size = new System.Drawing.Size(173, 25);
            this._textGameYear.TabIndex = 13;
            // 
            // _textTruripTitleId
            // 
            this.GameInfoTLP.SetColumnSpan(this._textTruripTitleId, 2);
            this._textTruripTitleId.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textTruripTitleId.Location = new System.Drawing.Point(410, 127);
            this._textTruripTitleId.Name = "_textTruripTitleId";
            this._textTruripTitleId.ReadOnly = true;
            this._textTruripTitleId.Size = new System.Drawing.Size(173, 25);
            this._textTruripTitleId.TabIndex = 17;
            // 
            // _labelGameRomOf
            // 
            this._labelGameRomOf.AutoSize = true;
            this._labelGameRomOf.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameRomOf.Location = new System.Drawing.Point(0, 217);
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
            this._labelTruripDeveloper.Location = new System.Drawing.Point(0, 186);
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
            this._labelGameCloneOf.Location = new System.Drawing.Point(0, 155);
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
            this._labelTruripPublisher.Location = new System.Drawing.Point(0, 124);
            this._labelTruripPublisher.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripPublisher.Name = "_labelTruripPublisher";
            this._labelTruripPublisher.Size = new System.Drawing.Size(93, 31);
            this._labelTruripPublisher.TabIndex = 14;
            this._labelTruripPublisher.Text = "Publisher :";
            this._labelTruripPublisher.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelGameCategory
            // 
            this._labelGameCategory.AutoSize = true;
            this._labelGameCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameCategory.Location = new System.Drawing.Point(286, 217);
            this._labelGameCategory.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameCategory.Name = "_labelGameCategory";
            this._labelGameCategory.Size = new System.Drawing.Size(121, 31);
            this._labelGameCategory.TabIndex = 24;
            this._labelGameCategory.Text = "Category :";
            this._labelGameCategory.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripSource
            // 
            this._labelTruripSource.AutoSize = true;
            this._labelTruripSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripSource.Location = new System.Drawing.Point(286, 186);
            this._labelTruripSource.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripSource.Name = "_labelTruripSource";
            this._labelTruripSource.Size = new System.Drawing.Size(121, 31);
            this._labelTruripSource.TabIndex = 20;
            this._labelTruripSource.Text = "Source :";
            this._labelTruripSource.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelGameYear
            // 
            this._labelGameYear.AutoSize = true;
            this._labelGameYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameYear.Location = new System.Drawing.Point(286, 155);
            this._labelGameYear.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameYear.Name = "_labelGameYear";
            this._labelGameYear.Size = new System.Drawing.Size(121, 31);
            this._labelGameYear.TabIndex = 12;
            this._labelGameYear.Text = "Year :";
            this._labelGameYear.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelTruripTitleId
            // 
            this._labelTruripTitleId.AutoSize = true;
            this._labelTruripTitleId.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripTitleId.Location = new System.Drawing.Point(286, 124);
            this._labelTruripTitleId.Margin = new System.Windows.Forms.Padding(0);
            this._labelTruripTitleId.Name = "_labelTruripTitleId";
            this._labelTruripTitleId.Size = new System.Drawing.Size(121, 31);
            this._labelTruripTitleId.TabIndex = 16;
            this._labelTruripTitleId.Text = "Title ID :";
            this._labelTruripTitleId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _labelGameManufacturer
            // 
            this._labelGameManufacturer.AutoSize = true;
            this._labelGameManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelGameManufacturer.Location = new System.Drawing.Point(0, 93);
            this._labelGameManufacturer.Margin = new System.Windows.Forms.Padding(0);
            this._labelGameManufacturer.Name = "_labelGameManufacturer";
            this._labelGameManufacturer.Size = new System.Drawing.Size(93, 31);
            this._labelGameManufacturer.TabIndex = 8;
            this._labelGameManufacturer.Text = "Manufacturer :";
            this._labelGameManufacturer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _textGameManufacturer
            // 
            this.GameInfoTLP.SetColumnSpan(this._textGameManufacturer, 5);
            this._textGameManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textGameManufacturer.Location = new System.Drawing.Point(96, 96);
            this._textGameManufacturer.Name = "_textGameManufacturer";
            this._textGameManufacturer.ReadOnly = true;
            this._textGameManufacturer.Size = new System.Drawing.Size(487, 25);
            this._textGameManufacturer.TabIndex = 9;
            // 
            // _labelTruripGenre
            // 
            this._labelTruripGenre.AutoSize = true;
            this._labelTruripGenre.Dock = System.Windows.Forms.DockStyle.Fill;
            this._labelTruripGenre.Location = new System.Drawing.Point(214, 310);
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
            this._labelTruripRatings.Location = new System.Drawing.Point(407, 310);
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
            this._labelTruripPlayers.Location = new System.Drawing.Point(0, 341);
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
            this._labelTruripSubGenre.Location = new System.Drawing.Point(214, 341);
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
            this._labelTruripScore.Location = new System.Drawing.Point(407, 341);
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
            this._textTruripYear.Location = new System.Drawing.Point(96, 313);
            this._textTruripYear.Name = "_textTruripYear";
            this._textTruripYear.ReadOnly = true;
            this._textTruripYear.Size = new System.Drawing.Size(115, 25);
            this._textTruripYear.TabIndex = 37;
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
            this.GameDetailsRhsFLP.Location = new System.Drawing.Point(596, 0);
            this.GameDetailsRhsFLP.Name = "GameDetailsRhsFLP";
            this.GameDetailsRhsFLP.Padding = new System.Windows.Forms.Padding(4);
            this.GameDetailsRhsFLP.Size = new System.Drawing.Size(196, 429);
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
            this.btnClear.BackgroundImage = global::ROMVault.Properties.Resources.cross;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.splitListArt.Panel1.Controls.Add(this.splitGameListRomList);
            // 
            // splitListArt.Panel2
            // 
            this.splitListArt.Panel2.Controls.Add(this.TabEmuArc);
            this.splitListArt.Size = new System.Drawing.Size(792, 467);
            this.splitListArt.SplitterDistance = 612;
            this.splitListArt.TabIndex = 1;
            // 
            // splitGameListRomList
            // 
            this.splitGameListRomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGameListRomList.Location = new System.Drawing.Point(0, 0);
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
            this.splitGameListRomList.Size = new System.Drawing.Size(612, 467);
            this.splitGameListRomList.SplitterDistance = 128;
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
            this.GameGrid.Size = new System.Drawing.Size(612, 128);
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
            this.RomGrid.Size = new System.Drawing.Size(612, 335);
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
            this.TabEmuArc.Size = new System.Drawing.Size(176, 467);
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
            this.tabArtWork.Size = new System.Drawing.Size(168, 441);
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
            this.tabMedium.Size = new System.Drawing.Size(168, 441);
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
            this.tabScreens.Size = new System.Drawing.Size(168, 441);
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
            this.tabInfo.Size = new System.Drawing.Size(168, 441);
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
            this.txtInfo.Size = new System.Drawing.Size(168, 441);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.WordWrap = false;
            // 
            // tabInfo2
            // 
            this.tabInfo2.BackColor = System.Drawing.SystemColors.Control;
            this.tabInfo2.Controls.Add(this.txtInfo2);
            this.tabInfo2.Location = new System.Drawing.Point(4, 22);
            this.tabInfo2.Name = "tabInfo2";
            this.tabInfo2.Size = new System.Drawing.Size(168, 441);
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
            this.txtInfo2.Size = new System.Drawing.Size(168, 441);
            this.txtInfo2.TabIndex = 2;
            this.txtInfo2.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUpdateDATs,
            this.tsmScanROMs,
            this.tsmFindFixes,
            this.FixROMsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.addToSortToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1430, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmUpdateDATs
            // 
            this.tsmUpdateDATs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateNewDATsToolStripMenuItem,
            this.updateAllDATsToolStripMenuItem});
            this.tsmUpdateDATs.Name = "tsmUpdateDATs";
            this.tsmUpdateDATs.Size = new System.Drawing.Size(86, 20);
            this.tsmUpdateDATs.Text = "Update DATs";
            // 
            // updateNewDATsToolStripMenuItem
            // 
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
            this.tsmScanLevel1,
            this.tsmScanLevel2,
            this.tsmScanLevel3});
            this.tsmScanROMs.Name = "tsmScanROMs";
            this.tsmScanROMs.Size = new System.Drawing.Size(79, 20);
            this.tsmScanROMs.Text = "Scan ROMs";
            // 
            // tsmScanLevel1
            // 
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
            this.tsmFindFixes.Name = "tsmFindFixes";
            this.tsmFindFixes.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tsmFindFixes.Size = new System.Drawing.Size(70, 20);
            this.tsmFindFixes.Text = "Find Fixes";
            this.tsmFindFixes.Click += new System.EventHandler(this.TsmFindFixesClick);
            // 
            // FixROMsToolStripMenuItem
            // 
            this.FixROMsToolStripMenuItem.Name = "FixROMsToolStripMenuItem";
            this.FixROMsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.FixROMsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.FixROMsToolStripMenuItem.Text = "Fix ROMs";
            this.FixROMsToolStripMenuItem.Click += new System.EventHandler(this.FixFilesToolStripMenuItemClick);
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
            this.romVaultSettingsToolStripMenuItem,
            this.directorySettingsToolStripMenuItem,
            this.directoryMappingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // romVaultSettingsToolStripMenuItem
            // 
            this.romVaultSettingsToolStripMenuItem.Name = "romVaultSettingsToolStripMenuItem";
            this.romVaultSettingsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.romVaultSettingsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.romVaultSettingsToolStripMenuItem.Text = "RomVault Settings";
            this.romVaultSettingsToolStripMenuItem.Click += new System.EventHandler(this.RomVaultSettingsToolStripMenuItem_Click);
            // 
            // directorySettingsToolStripMenuItem
            // 
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
            // addToSortToolStripMenuItem
            // 
            this.addToSortToolStripMenuItem.Name = "addToSortToolStripMenuItem";
            this.addToSortToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.addToSortToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.addToSortToolStripMenuItem.Text = "Add ToSort";
            this.addToSortToolStripMenuItem.Click += new System.EventHandler(this.AddToSortToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torrentZipToolStripMenuItem,
            this.visitHelpWikiToolStripMenuItem,
            this.colorKeyToolStripMenuItem,
            this.whatsNewToolStripMenuItem,
            this.aboutRomVaultToolStripMenuItem});
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
            this.MainSS.AutoSize = false;
            this.MainSS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainSS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToggleStatusTextBT,
            this.ToggleDatKeyLB,
            this.toolStripStatusLabel1,
            this.ToggleGameKeyLB});
            this.MainSS.Location = new System.Drawing.Point(0, 932);
            this.MainSS.Name = "MainSS";
            this.MainSS.Size = new System.Drawing.Size(1430, 40);
            this.MainSS.TabIndex = 7;
            this.MainSS.Text = "statusStrip1";
            // 
            // ToggleStatusTextBT
            // 
            this.ToggleStatusTextBT.Image = global::ROMVault.Properties.Resources.ui_text_field_password;
            this.ToggleStatusTextBT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 2);
            this.ToggleStatusTextBT.Name = "ToggleStatusTextBT";
            this.ToggleStatusTextBT.Size = new System.Drawing.Size(16, 35);
            this.ToggleStatusTextBT.ToolTipText = "Toggle Status Icon Titles";
            this.ToggleStatusTextBT.Click += new System.EventHandler(this.ToggleStatusTextBT_Click);
            // 
            // ToggleDatKeyLB
            // 
            this.ToggleDatKeyLB.Image = global::ROMVault.Properties.Resources.database;
            this.ToggleDatKeyLB.Name = "ToggleDatKeyLB";
            this.ToggleDatKeyLB.Size = new System.Drawing.Size(27, 35);
            this.ToggleDatKeyLB.Text = ":";
            this.ToggleDatKeyLB.Click += new System.EventHandler(this.ToggleDatKeyTextBT_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 35);
            this.toolStripStatusLabel1.Text = " ";
            // 
            // ToggleGameKeyLB
            // 
            this.ToggleGameKeyLB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleGameKeyLB.Image = global::ROMVault.Properties.Resources.board_game_go;
            this.ToggleGameKeyLB.Name = "ToggleGameKeyLB";
            this.ToggleGameKeyLB.Size = new System.Drawing.Size(27, 35);
            this.ToggleGameKeyLB.Text = ":";
            this.ToggleGameKeyLB.Click += new System.EventHandler(this.ToggleGamesKeyTextBT_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1430, 972);
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
            this.splitDatInfoGameInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDatInfoGameInfo)).EndInit();
            this.splitDatInfoGameInfo.ResumeLayout(false);
            this.DatINfoTlpPN.ResumeLayout(false);
            this.DatINfoTlpPN.PerformLayout();
            this.DatInfoTLP.ResumeLayout(false);
            this.DatInfoTLP.PerformLayout();
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
            this.splitGameListRomList.Panel1.ResumeLayout(false);
            this.splitGameListRomList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGameListRomList)).EndInit();
            this.splitGameListRomList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RomGrid)).EndInit();
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
        private System.Windows.Forms.Label lblDIRomsUnknown;
        private System.Windows.Forms.Label lblDIROMsMissing;
        private System.Windows.Forms.Label lblDIROMsGot;
        private System.Windows.Forms.TextBox lblDITRomsUnknown;
        private System.Windows.Forms.TextBox lblDITRomsMissing;
        private System.Windows.Forms.TextBox lblDITRomsGot;
        private System.Windows.Forms.Label lblDIRomPath;
        private System.Windows.Forms.TextBox lblDITPath;
        private System.Windows.Forms.Label lblDIDate;
        private System.Windows.Forms.Label lblDIAuthor;
        private System.Windows.Forms.TextBox lblDITDate;
        private System.Windows.Forms.TextBox lblDITAuthor;
        private System.Windows.Forms.Label lblDIVersion;
        private System.Windows.Forms.Label lblDICategory;
        private System.Windows.Forms.TextBox lblDITVersion;
        private System.Windows.Forms.TextBox lblDITCategory;
        private System.Windows.Forms.Label lblDIDescription;
        private System.Windows.Forms.Label lblDIName;
        private System.Windows.Forms.TextBox lblDITDescription;
        private System.Windows.Forms.TextBox lblDITName;
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
        private System.Windows.Forms.ToolStripMenuItem FixROMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmScanLevel2;
        private System.Windows.Forms.TextBox lblDITRomsFixable;
        private System.Windows.Forms.Label lblDIRomsFixable;
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
        private System.Windows.Forms.ToolStripMenuItem addToSortToolStripMenuItem;
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
        private System.Windows.Forms.TableLayoutPanel DatInfoTLP;
        private System.Windows.Forms.Panel DatINfoTlpPN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel GameInfoTLP;
        private System.Windows.Forms.TextBox _textGameName;
        private System.Windows.Forms.Label _labelGameName;
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
        private System.Windows.Forms.TextBox _textTruripPublisher;
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
        private UserControls.FlexiLabel flexiLabel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private UserControls.FlexiLabel flexiLabel3;
        private Button HideNavBT;
        private ToolStripStatusLabel ToggleStatusTextBT;
        private ToolStripStatusLabel ToggleGameKeyLB;
        private ToolStripStatusLabel ToggleDatKeyLB;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}

