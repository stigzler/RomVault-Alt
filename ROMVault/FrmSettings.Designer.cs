namespace ROMVault
{
    partial class FrmSettings
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Dat Vault");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("DATs", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ROMs");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("File Operations");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("UI and UX");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ColorBroswer = new System.Windows.Forms.ColorDialog();
            this.TvPaddingPN = new System.Windows.Forms.Panel();
            this.MainTV = new System.Windows.Forms.TreeView();
            this.MainIL = new System.Windows.Forms.ImageList(this.components);
            this.DatFormatLvLineHeightForcer = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MainSS = new System.Windows.Forms.StatusStrip();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MainTT = new ROMVault.UserControls.ToolTip();
            this.MoveDontCopyDatsChB = new System.Windows.Forms.CheckBox();
            this.AutoCloseProgressChB = new System.Windows.Forms.CheckBox();
            this.PreserveEmptyRomFoldersChB = new System.Windows.Forms.CheckBox();
            this.UseRootedPathsChB = new System.Windows.Forms.CheckBox();
            this.LeftPN = new System.Windows.Forms.Panel();
            this.flexiLabel2 = new ROMVault.UserControls.FlexiLabel();
            this.MainTC = new ROMVault.UserControls.TabControl();
            this.DatSettingsTP = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDATRoot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDAT = new System.Windows.Forms.Button();
            this.cboFixLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkDoubleCheckDelete = new System.Windows.Forms.CheckBox();
            this.chkCacheSaveTimer = new System.Windows.Forms.CheckBox();
            this.upTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.DatVaultTP = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.DeleteDATSourceBT = new System.Windows.Forms.Button();
            this.AddDatSourceBT = new System.Windows.Forms.Button();
            this.DatSourceLinksDGV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RestoreDatFormatsBT = new System.Windows.Forms.Button();
            this.DeleteDatFormatBT = new System.Windows.Forms.Button();
            this.AddDatFormatBT = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.DatFormatsLV = new System.Windows.Forms.ListView();
            this.chkSendFoundMIA = new System.Windows.Forms.CheckBox();
            this.chkSendFoundMIAAnon = new System.Windows.Forms.CheckBox();
            this.chkDeleteOldCueFiles = new System.Windows.Forms.CheckBox();
            this.flexiLabel4 = new ROMVault.UserControls.FlexiLabel();
            this.FileOperationsTP = new System.Windows.Forms.TabPage();
            this.LoggingGB = new System.Windows.Forms.GroupBox();
            this.chkDetailedReporting = new System.Windows.Forms.CheckBox();
            this.chkDebugLogs = new System.Windows.Forms.CheckBox();
            this.chkDoNotReportFeedback = new System.Windows.Forms.CheckBox();
            this.FileOperationalGB = new System.Windows.Forms.GroupBox();
            this.flexiLabel5 = new ROMVault.UserControls.FlexiLabel();
            this.UiTP = new System.Windows.Forms.TabPage();
            this.OperationalGB = new System.Windows.Forms.GroupBox();
            this.EnableGamesGridRClickChB = new System.Windows.Forms.CheckBox();
            this.AppearanceThemesGB = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.RomsGotLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsMissingLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsFixableLB = new ROMVault.UserControls.FlexiLabel();
            this.RomsUnknownLB = new ROMVault.UserControls.FlexiLabel();
            this.label17 = new System.Windows.Forms.Label();
            this.StatusIconSizeAutoChB = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.StatusIconSizeNUM = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.MainTextSizeNUM = new System.Windows.Forms.NumericUpDown();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.flexiLabel3 = new ROMVault.UserControls.FlexiLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InfoTextExampleLB = new ROMVault.UserControls.FlexiLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.InfoTextColorPB = new System.Windows.Forms.PictureBox();
            this.MainSC = new System.Windows.Forms.SplitContainer();
            this.RomsTP = new System.Windows.Forms.TabPage();
            this.flexiLabel6 = new ROMVault.UserControls.FlexiLabel();
            this.RomImportsGB = new System.Windows.Forms.GroupBox();
            this.DeleteOrigRomsRelocateChB = new System.Windows.Forms.CheckBox();
            this.MoveFilesNotCopyChB = new System.Windows.Forms.CheckBox();
            this.CompressionGB = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo7zStruct = new System.Windows.Forms.ComboBox();
            this.cboCores = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteRomSourceBT = new System.Windows.Forms.Button();
            this.AddRomSourceBT = new System.Windows.Forms.Button();
            this.RomSourceLinksDGV = new System.Windows.Forms.DataGridView();
            this.TvPaddingPN.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.LeftPN.SuspendLayout();
            this.MainTC.SuspendLayout();
            this.DatSettingsTP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upTime)).BeginInit();
            this.DatVaultTP.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatSourceLinksDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.FileOperationsTP.SuspendLayout();
            this.LoggingGB.SuspendLayout();
            this.FileOperationalGB.SuspendLayout();
            this.UiTP.SuspendLayout();
            this.OperationalGB.SuspendLayout();
            this.AppearanceThemesGB.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIconSizeNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTextSizeNUM)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTextColorPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSC)).BeginInit();
            this.MainSC.Panel1.SuspendLayout();
            this.MainSC.Panel2.SuspendLayout();
            this.MainSC.SuspendLayout();
            this.RomsTP.SuspendLayout();
            this.RomImportsGB.SuspendLayout();
            this.CompressionGB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RomSourceLinksDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(492, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(89, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOkClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(397, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // ColorBroswer
            // 
            this.ColorBroswer.AnyColor = true;
            this.ColorBroswer.FullOpen = true;
            // 
            // TvPaddingPN
            // 
            this.TvPaddingPN.Controls.Add(this.MainTV);
            this.TvPaddingPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TvPaddingPN.Location = new System.Drawing.Point(0, 36);
            this.TvPaddingPN.Name = "TvPaddingPN";
            this.TvPaddingPN.Padding = new System.Windows.Forms.Padding(6);
            this.TvPaddingPN.Size = new System.Drawing.Size(150, 474);
            this.TvPaddingPN.TabIndex = 47;
            // 
            // MainTV
            // 
            this.MainTV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTV.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTV.HideSelection = false;
            this.MainTV.ImageIndex = 0;
            this.MainTV.ImageList = this.MainIL;
            this.MainTV.ItemHeight = 30;
            this.MainTV.Location = new System.Drawing.Point(6, 6);
            this.MainTV.Name = "MainTV";
            treeNode1.Name = "DatVaultTVI";
            treeNode1.Text = "Dat Vault";
            treeNode2.ImageKey = "database.png";
            treeNode2.Name = "DatSettingsTVI";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Text = "DATs";
            treeNode3.ImageKey = "disc.png";
            treeNode3.Name = "RomsTVI";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "ROMs";
            treeNode4.ImageKey = "folder-smiley.png";
            treeNode4.Name = "FileOperationsTVI";
            treeNode4.SelectedImageIndex = 1;
            treeNode4.Text = "File Operations";
            treeNode5.ImageKey = "ui-combo-box-blue.png";
            treeNode5.Name = "UiTVI";
            treeNode5.SelectedImageIndex = 2;
            treeNode5.Text = "UI and UX";
            this.MainTV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            this.MainTV.SelectedImageIndex = 0;
            this.MainTV.ShowPlusMinus = false;
            this.MainTV.ShowRootLines = false;
            this.MainTV.Size = new System.Drawing.Size(138, 462);
            this.MainTV.TabIndex = 46;
            this.MainTV.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTV_AfterSelect);
            // 
            // MainIL
            // 
            this.MainIL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainIL.ImageStream")));
            this.MainIL.TransparentColor = System.Drawing.Color.Transparent;
            this.MainIL.Images.SetKeyName(0, "database.png");
            this.MainIL.Images.SetKeyName(1, "folder-smiley.png");
            this.MainIL.Images.SetKeyName(2, "ui-combo-box-blue.png");
            this.MainIL.Images.SetKeyName(3, "disc.png");
            // 
            // DatFormatLvLineHeightForcer
            // 
            this.DatFormatLvLineHeightForcer.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.DatFormatLvLineHeightForcer.ImageSize = new System.Drawing.Size(1, 20);
            this.DatFormatLvLineHeightForcer.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnOK);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 510);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 29);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // MainSS
            // 
            this.MainSS.Location = new System.Drawing.Point(0, 539);
            this.MainSS.Name = "MainSS";
            this.MainSS.Size = new System.Drawing.Size(584, 22);
            this.MainSS.TabIndex = 52;
            this.MainSS.Text = "statusStrip1";
            // 
            // MainTT
            // 
            this.MainTT.OwnerDraw = true;
            // 
            // MoveDontCopyDatsChB
            // 
            this.MoveDontCopyDatsChB.AutoSize = true;
            this.MoveDontCopyDatsChB.Location = new System.Drawing.Point(9, 228);
            this.MoveDontCopyDatsChB.Name = "MoveDontCopyDatsChB";
            this.MoveDontCopyDatsChB.Size = new System.Drawing.Size(182, 17);
            this.MoveDontCopyDatsChB.TabIndex = 36;
            this.MoveDontCopyDatsChB.Text = "Move, don\'t copy Imported DATs";
            this.MainTT.SetToolTip(this.MoveDontCopyDatsChB, "By default, RomVault copies any DAT fies to the Dat vault directory, preserving o" +
        "riginal copies. Set this if you just want to move them instead.");
            this.MoveDontCopyDatsChB.UseVisualStyleBackColor = true;
            // 
            // AutoCloseProgressChB
            // 
            this.AutoCloseProgressChB.AutoSize = true;
            this.AutoCloseProgressChB.Location = new System.Drawing.Point(11, 42);
            this.AutoCloseProgressChB.Name = "AutoCloseProgressChB";
            this.AutoCloseProgressChB.Size = new System.Drawing.Size(159, 17);
            this.AutoCloseProgressChB.TabIndex = 2;
            this.AutoCloseProgressChB.Text = "Auto Close progress window";
            this.MainTT.SetToolTip(this.AutoCloseProgressChB, "Closes the progress window on operation completion automoatically");
            this.AutoCloseProgressChB.UseVisualStyleBackColor = true;
            // 
            // PreserveEmptyRomFoldersChB
            // 
            this.PreserveEmptyRomFoldersChB.AutoSize = true;
            this.PreserveEmptyRomFoldersChB.Location = new System.Drawing.Point(14, 19);
            this.PreserveEmptyRomFoldersChB.Name = "PreserveEmptyRomFoldersChB";
            this.PreserveEmptyRomFoldersChB.Size = new System.Drawing.Size(200, 17);
            this.PreserveEmptyRomFoldersChB.TabIndex = 0;
            this.PreserveEmptyRomFoldersChB.Text = "Preserve Empty Folders in ROM Files";
            this.MainTT.SetToolTip(this.PreserveEmptyRomFoldersChB, "Prevent empty folders being deleted from the Roms folder on Fix.");
            this.PreserveEmptyRomFoldersChB.UseVisualStyleBackColor = true;
            // 
            // UseRootedPathsChB
            // 
            this.UseRootedPathsChB.AutoSize = true;
            this.UseRootedPathsChB.Location = new System.Drawing.Point(14, 42);
            this.UseRootedPathsChB.Name = "UseRootedPathsChB";
            this.UseRootedPathsChB.Size = new System.Drawing.Size(225, 17);
            this.UseRootedPathsChB.TabIndex = 1;
            this.UseRootedPathsChB.Text = "Use rooted Paths rather than relative ones";
            this.MainTT.SetToolTip(this.UseRootedPathsChB, resources.GetString("UseRootedPathsChB.ToolTip"));
            this.UseRootedPathsChB.UseVisualStyleBackColor = true;
            this.UseRootedPathsChB.CheckedChanged += new System.EventHandler(this.UseRootedPathsChB_CheckedChanged);
            // 
            // LeftPN
            // 
            this.LeftPN.Controls.Add(this.TvPaddingPN);
            this.LeftPN.Controls.Add(this.flexiLabel2);
            this.LeftPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPN.Location = new System.Drawing.Point(0, 0);
            this.LeftPN.Name = "LeftPN";
            this.LeftPN.Size = new System.Drawing.Size(150, 510);
            this.LeftPN.TabIndex = 53;
            // 
            // flexiLabel2
            // 
            this.flexiLabel2.AutoSize = true;
            this.flexiLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel2.Font = new System.Drawing.Font("Roboto", 12.375F, System.Drawing.FontStyle.Bold);
            this.flexiLabel2.Location = new System.Drawing.Point(0, 0);
            this.flexiLabel2.Name = "flexiLabel2";
            this.flexiLabel2.Padding = new System.Windows.Forms.Padding(8);
            this.flexiLabel2.ScaleFactor = 1.5D;
            this.flexiLabel2.Size = new System.Drawing.Size(96, 36);
            this.flexiLabel2.TabIndex = 49;
            this.flexiLabel2.Text = "Settings";
            // 
            // MainTC
            // 
            this.MainTC.Controls.Add(this.DatSettingsTP);
            this.MainTC.Controls.Add(this.DatVaultTP);
            this.MainTC.Controls.Add(this.RomsTP);
            this.MainTC.Controls.Add(this.FileOperationsTP);
            this.MainTC.Controls.Add(this.UiTP);
            this.MainTC.Controls.Add(this.tabPage1);
            this.MainTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTC.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTC.HideBorders = true;
            this.MainTC.HideTabs = false;
            this.MainTC.ItemSize = new System.Drawing.Size(91, 13);
            this.MainTC.Location = new System.Drawing.Point(0, 0);
            this.MainTC.Name = "MainTC";
            this.MainTC.SelectedIndex = 0;
            this.MainTC.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.MainTC.Size = new System.Drawing.Size(430, 510);
            this.MainTC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTC.TabIndex = 0;
            this.MainTC.TabOutlineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainTC.UnselectedTabBackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // DatSettingsTP
            // 
            this.DatSettingsTP.AutoScroll = true;
            this.DatSettingsTP.Controls.Add(this.groupBox1);
            this.DatSettingsTP.Controls.Add(this.flexiLabel1);
            this.DatSettingsTP.Location = new System.Drawing.Point(0, 15);
            this.DatSettingsTP.Name = "DatSettingsTP";
            this.DatSettingsTP.Padding = new System.Windows.Forms.Padding(8);
            this.DatSettingsTP.Size = new System.Drawing.Size(430, 495);
            this.DatSettingsTP.TabIndex = 0;
            this.DatSettingsTP.Text = "Dat Settings";
            this.DatSettingsTP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDATRoot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDAT);
            this.groupBox1.Controls.Add(this.cboFixLevel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.chkDoubleCheckDelete);
            this.groupBox1.Controls.Add(this.chkCacheSaveTimer);
            this.groupBox1.Controls.Add(this.upTime);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(8, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 350);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Core Settings";
            // 
            // lblDATRoot
            // 
            this.lblDATRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDATRoot.BackColor = System.Drawing.Color.White;
            this.lblDATRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDATRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDATRoot.Location = new System.Drawing.Point(78, 26);
            this.lblDATRoot.Name = "lblDATRoot";
            this.lblDATRoot.Size = new System.Drawing.Size(280, 22);
            this.lblDATRoot.TabIndex = 3;
            this.lblDATRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATRoot:";
            // 
            // btnDAT
            // 
            this.btnDAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDAT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDAT.Location = new System.Drawing.Point(364, 26);
            this.btnDAT.Name = "btnDAT";
            this.btnDAT.Size = new System.Drawing.Size(44, 24);
            this.btnDAT.TabIndex = 6;
            this.btnDAT.Text = "Set";
            this.btnDAT.UseVisualStyleBackColor = true;
            this.btnDAT.Click += new System.EventHandler(this.BtnDatClick);
            // 
            // cboFixLevel
            // 
            this.cboFixLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFixLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFixLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFixLevel.FormattingEnabled = true;
            this.cboFixLevel.Location = new System.Drawing.Point(78, 59);
            this.cboFixLevel.Name = "cboFixLevel";
            this.cboFixLevel.Size = new System.Drawing.Size(330, 21);
            this.cboFixLevel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fixing Level:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 67);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filenames not to remove:\r\n- One rule per line\r\n- Basic rules support * and ? wild" +
    "cards\r\n- Regex rules must start with regex:\'\r\n- Scanning Ignore rules must start" +
    " with \'ignore:\'";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(9, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 121);
            this.textBox1.TabIndex = 12;
            // 
            // chkDoubleCheckDelete
            // 
            this.chkDoubleCheckDelete.AutoSize = true;
            this.chkDoubleCheckDelete.Location = new System.Drawing.Point(14, 293);
            this.chkDoubleCheckDelete.Name = "chkDoubleCheckDelete";
            this.chkDoubleCheckDelete.Size = new System.Drawing.Size(262, 17);
            this.chkDoubleCheckDelete.TabIndex = 22;
            this.chkDoubleCheckDelete.Text = "Double check file exists elsewhere before deleting";
            this.chkDoubleCheckDelete.UseVisualStyleBackColor = true;
            // 
            // chkCacheSaveTimer
            // 
            this.chkCacheSaveTimer.AutoSize = true;
            this.chkCacheSaveTimer.Location = new System.Drawing.Point(14, 316);
            this.chkCacheSaveTimer.Name = "chkCacheSaveTimer";
            this.chkCacheSaveTimer.Size = new System.Drawing.Size(154, 17);
            this.chkCacheSaveTimer.TabIndex = 19;
            this.chkCacheSaveTimer.Text = "Save Cache on timer every";
            this.chkCacheSaveTimer.UseVisualStyleBackColor = true;
            // 
            // upTime
            // 
            this.upTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.upTime.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upTime.Location = new System.Drawing.Point(174, 316);
            this.upTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.upTime.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.upTime.Name = "upTime";
            this.upTime.Size = new System.Drawing.Size(47, 20);
            this.upTime.TabIndex = 20;
            this.upTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Minutes";
            // 
            // flexiLabel1
            // 
            this.flexiLabel1.AutoSize = true;
            this.flexiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel1.Font = new System.Drawing.Font("Roboto", 12.375F, System.Drawing.FontStyle.Bold);
            this.flexiLabel1.Location = new System.Drawing.Point(8, 8);
            this.flexiLabel1.Name = "flexiLabel1";
            this.flexiLabel1.Padding = new System.Windows.Forms.Padding(5);
            this.flexiLabel1.ScaleFactor = 1.5D;
            this.flexiLabel1.Size = new System.Drawing.Size(62, 30);
            this.flexiLabel1.TabIndex = 55;
            this.flexiLabel1.Text = "DATs";
            // 
            // DatVaultTP
            // 
            this.DatVaultTP.Controls.Add(this.groupBox7);
            this.DatVaultTP.Controls.Add(this.groupBox2);
            this.DatVaultTP.Controls.Add(this.flexiLabel4);
            this.DatVaultTP.Location = new System.Drawing.Point(0, 15);
            this.DatVaultTP.Name = "DatVaultTP";
            this.DatVaultTP.Padding = new System.Windows.Forms.Padding(8);
            this.DatVaultTP.Size = new System.Drawing.Size(430, 495);
            this.DatVaultTP.TabIndex = 5;
            this.DatVaultTP.Text = "DatVault";
            this.DatVaultTP.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.DeleteDATSourceBT);
            this.groupBox7.Controls.Add(this.AddDatSourceBT);
            this.groupBox7.Controls.Add(this.DatSourceLinksDGV);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(8, 290);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(414, 197);
            this.groupBox7.TabIndex = 56;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DAT Source Links";
            // 
            // DeleteDATSourceBT
            // 
            this.DeleteDATSourceBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteDATSourceBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.DeleteDATSourceBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDATSourceBT.Image = global::ROMVault.Properties.Resources.minus;
            this.DeleteDATSourceBT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteDATSourceBT.Location = new System.Drawing.Point(330, 55);
            this.DeleteDATSourceBT.Name = "DeleteDATSourceBT";
            this.DeleteDATSourceBT.Size = new System.Drawing.Size(75, 30);
            this.DeleteDATSourceBT.TabIndex = 36;
            this.DeleteDATSourceBT.Text = "Delete";
            this.DeleteDATSourceBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteDATSourceBT.UseVisualStyleBackColor = true;
            this.DeleteDATSourceBT.Click += new System.EventHandler(this.DeleteDATSourceBT_Click);
            // 
            // AddDatSourceBT
            // 
            this.AddDatSourceBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDatSourceBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.AddDatSourceBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDatSourceBT.Image = global::ROMVault.Properties.Resources.plus;
            this.AddDatSourceBT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddDatSourceBT.Location = new System.Drawing.Point(330, 19);
            this.AddDatSourceBT.Name = "AddDatSourceBT";
            this.AddDatSourceBT.Size = new System.Drawing.Size(75, 30);
            this.AddDatSourceBT.TabIndex = 35;
            this.AddDatSourceBT.Text = "Add";
            this.AddDatSourceBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDatSourceBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddDatSourceBT.UseVisualStyleBackColor = true;
            this.AddDatSourceBT.Click += new System.EventHandler(this.AddDatSourceBT_Click);
            // 
            // DatSourceLinksDGV
            // 
            this.DatSourceLinksDGV.AllowUserToAddRows = false;
            this.DatSourceLinksDGV.AllowUserToResizeRows = false;
            this.DatSourceLinksDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatSourceLinksDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatSourceLinksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatSourceLinksDGV.Location = new System.Drawing.Point(14, 19);
            this.DatSourceLinksDGV.Name = "DatSourceLinksDGV";
            this.DatSourceLinksDGV.RowHeadersVisible = false;
            this.DatSourceLinksDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DatSourceLinksDGV.Size = new System.Drawing.Size(310, 172);
            this.DatSourceLinksDGV.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MoveDontCopyDatsChB);
            this.groupBox2.Controls.Add(this.RestoreDatFormatsBT);
            this.groupBox2.Controls.Add(this.DeleteDatFormatBT);
            this.groupBox2.Controls.Add(this.AddDatFormatBT);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.DatFormatsLV);
            this.groupBox2.Controls.Add(this.chkSendFoundMIA);
            this.groupBox2.Controls.Add(this.chkSendFoundMIAAnon);
            this.groupBox2.Controls.Add(this.chkDeleteOldCueFiles);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(8, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 252);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DAT Vault";
            // 
            // RestoreDatFormatsBT
            // 
            this.RestoreDatFormatsBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RestoreDatFormatsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.RestoreDatFormatsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreDatFormatsBT.Image = global::ROMVault.Properties.Resources.arrowCircle;
            this.RestoreDatFormatsBT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RestoreDatFormatsBT.Location = new System.Drawing.Point(333, 192);
            this.RestoreDatFormatsBT.Name = "RestoreDatFormatsBT";
            this.RestoreDatFormatsBT.Size = new System.Drawing.Size(75, 30);
            this.RestoreDatFormatsBT.TabIndex = 35;
            this.RestoreDatFormatsBT.Text = "Defaults";
            this.RestoreDatFormatsBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RestoreDatFormatsBT.UseVisualStyleBackColor = true;
            this.RestoreDatFormatsBT.Click += new System.EventHandler(this.RestoreDatFormatsBT_Click);
            // 
            // DeleteDatFormatBT
            // 
            this.DeleteDatFormatBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteDatFormatBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.DeleteDatFormatBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDatFormatBT.Image = global::ROMVault.Properties.Resources.minus;
            this.DeleteDatFormatBT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteDatFormatBT.Location = new System.Drawing.Point(333, 156);
            this.DeleteDatFormatBT.Name = "DeleteDatFormatBT";
            this.DeleteDatFormatBT.Size = new System.Drawing.Size(75, 30);
            this.DeleteDatFormatBT.TabIndex = 34;
            this.DeleteDatFormatBT.Text = "Delete";
            this.DeleteDatFormatBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteDatFormatBT.UseVisualStyleBackColor = true;
            this.DeleteDatFormatBT.Click += new System.EventHandler(this.DeleteDatFormatBT_Click);
            // 
            // AddDatFormatBT
            // 
            this.AddDatFormatBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDatFormatBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.AddDatFormatBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDatFormatBT.Image = global::ROMVault.Properties.Resources.plus;
            this.AddDatFormatBT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddDatFormatBT.Location = new System.Drawing.Point(333, 120);
            this.AddDatFormatBT.Name = "AddDatFormatBT";
            this.AddDatFormatBT.Size = new System.Drawing.Size(75, 30);
            this.AddDatFormatBT.TabIndex = 33;
            this.AddDatFormatBT.Text = "Add";
            this.AddDatFormatBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDatFormatBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddDatFormatBT.UseVisualStyleBackColor = true;
            this.AddDatFormatBT.Click += new System.EventHandler(this.AddDatFormatBT_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Accepted DAT formats (click item to edit):";
            // 
            // DatFormatsLV
            // 
            this.DatFormatsLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatFormatsLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DatFormatsLV.FullRowSelect = true;
            this.DatFormatsLV.HideSelection = false;
            this.DatFormatsLV.LabelEdit = true;
            this.DatFormatsLV.Location = new System.Drawing.Point(9, 120);
            this.DatFormatsLV.Name = "DatFormatsLV";
            this.DatFormatsLV.Size = new System.Drawing.Size(315, 102);
            this.DatFormatsLV.SmallImageList = this.DatFormatLvLineHeightForcer;
            this.DatFormatsLV.TabIndex = 31;
            this.DatFormatsLV.UseCompatibleStateImageBehavior = false;
            this.DatFormatsLV.View = System.Windows.Forms.View.List;
            // 
            // chkSendFoundMIA
            // 
            this.chkSendFoundMIA.AutoSize = true;
            this.chkSendFoundMIA.Location = new System.Drawing.Point(14, 19);
            this.chkSendFoundMIA.Name = "chkSendFoundMIA";
            this.chkSendFoundMIA.Size = new System.Drawing.Size(165, 17);
            this.chkSendFoundMIA.TabIndex = 27;
            this.chkSendFoundMIA.Text = "Send Found MIA notifications";
            this.chkSendFoundMIA.UseVisualStyleBackColor = true;
            this.chkSendFoundMIA.CheckedChanged += new System.EventHandler(this.chkSendFoundMIA_CheckedChanged);
            // 
            // chkSendFoundMIAAnon
            // 
            this.chkSendFoundMIAAnon.AutoSize = true;
            this.chkSendFoundMIAAnon.Location = new System.Drawing.Point(37, 42);
            this.chkSendFoundMIAAnon.Name = "chkSendFoundMIAAnon";
            this.chkSendFoundMIAAnon.Size = new System.Drawing.Size(115, 17);
            this.chkSendFoundMIAAnon.TabIndex = 28;
            this.chkSendFoundMIAAnon.Text = "Send anonymously";
            this.chkSendFoundMIAAnon.UseVisualStyleBackColor = true;
            // 
            // chkDeleteOldCueFiles
            // 
            this.chkDeleteOldCueFiles.AutoSize = true;
            this.chkDeleteOldCueFiles.Location = new System.Drawing.Point(14, 65);
            this.chkDeleteOldCueFiles.Name = "chkDeleteOldCueFiles";
            this.chkDeleteOldCueFiles.Size = new System.Drawing.Size(208, 17);
            this.chkDeleteOldCueFiles.TabIndex = 30;
            this.chkDeleteOldCueFiles.Text = "Delete previous Cue file zips in ToSort ";
            this.chkDeleteOldCueFiles.UseVisualStyleBackColor = true;
            // 
            // flexiLabel4
            // 
            this.flexiLabel4.AutoSize = true;
            this.flexiLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel4.Font = new System.Drawing.Font("Roboto", 12.375F, System.Drawing.FontStyle.Bold);
            this.flexiLabel4.Location = new System.Drawing.Point(8, 8);
            this.flexiLabel4.Name = "flexiLabel4";
            this.flexiLabel4.Padding = new System.Windows.Forms.Padding(5);
            this.flexiLabel4.ScaleFactor = 1.5D;
            this.flexiLabel4.Size = new System.Drawing.Size(102, 30);
            this.flexiLabel4.TabIndex = 55;
            this.flexiLabel4.Text = "DAT Vault";
            // 
            // FileOperationsTP
            // 
            this.FileOperationsTP.AutoScroll = true;
            this.FileOperationsTP.Controls.Add(this.LoggingGB);
            this.FileOperationsTP.Controls.Add(this.FileOperationalGB);
            this.FileOperationsTP.Controls.Add(this.flexiLabel5);
            this.FileOperationsTP.Location = new System.Drawing.Point(0, 15);
            this.FileOperationsTP.Name = "FileOperationsTP";
            this.FileOperationsTP.Padding = new System.Windows.Forms.Padding(8);
            this.FileOperationsTP.Size = new System.Drawing.Size(430, 495);
            this.FileOperationsTP.TabIndex = 1;
            this.FileOperationsTP.Text = "File Operations";
            this.FileOperationsTP.UseVisualStyleBackColor = true;
            // 
            // LoggingGB
            // 
            this.LoggingGB.Controls.Add(this.chkDetailedReporting);
            this.LoggingGB.Controls.Add(this.chkDebugLogs);
            this.LoggingGB.Controls.Add(this.chkDoNotReportFeedback);
            this.LoggingGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.LoggingGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoggingGB.Location = new System.Drawing.Point(8, 116);
            this.LoggingGB.Name = "LoggingGB";
            this.LoggingGB.Size = new System.Drawing.Size(414, 95);
            this.LoggingGB.TabIndex = 47;
            this.LoggingGB.TabStop = false;
            this.LoggingGB.Text = "Logging";
            // 
            // chkDetailedReporting
            // 
            this.chkDetailedReporting.AutoSize = true;
            this.chkDetailedReporting.Location = new System.Drawing.Point(14, 19);
            this.chkDetailedReporting.Name = "chkDetailedReporting";
            this.chkDetailedReporting.Size = new System.Drawing.Size(243, 17);
            this.chkDetailedReporting.TabIndex = 25;
            this.chkDetailedReporting.Text = "Show detailed actions in Fixing Status window";
            this.chkDetailedReporting.UseVisualStyleBackColor = true;
            // 
            // chkDebugLogs
            // 
            this.chkDebugLogs.AutoSize = true;
            this.chkDebugLogs.Location = new System.Drawing.Point(14, 39);
            this.chkDebugLogs.Name = "chkDebugLogs";
            this.chkDebugLogs.Size = new System.Drawing.Size(131, 17);
            this.chkDebugLogs.TabIndex = 18;
            this.chkDebugLogs.Text = "Enable Debug logging";
            this.chkDebugLogs.UseVisualStyleBackColor = true;
            // 
            // chkDoNotReportFeedback
            // 
            this.chkDoNotReportFeedback.AutoSize = true;
            this.chkDoNotReportFeedback.Location = new System.Drawing.Point(14, 59);
            this.chkDoNotReportFeedback.Name = "chkDoNotReportFeedback";
            this.chkDoNotReportFeedback.Size = new System.Drawing.Size(136, 17);
            this.chkDoNotReportFeedback.TabIndex = 43;
            this.chkDoNotReportFeedback.Text = "Do not report feedback";
            this.chkDoNotReportFeedback.UseVisualStyleBackColor = true;
            // 
            // FileOperationalGB
            // 
            this.FileOperationalGB.Controls.Add(this.UseRootedPathsChB);
            this.FileOperationalGB.Controls.Add(this.PreserveEmptyRomFoldersChB);
            this.FileOperationalGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileOperationalGB.Location = new System.Drawing.Point(8, 38);
            this.FileOperationalGB.Name = "FileOperationalGB";
            this.FileOperationalGB.Size = new System.Drawing.Size(414, 78);
            this.FileOperationalGB.TabIndex = 56;
            this.FileOperationalGB.TabStop = false;
            this.FileOperationalGB.Text = "Operational";
            // 
            // flexiLabel5
            // 
            this.flexiLabel5.AutoSize = true;
            this.flexiLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel5.Font = new System.Drawing.Font("Roboto", 12.375F, System.Drawing.FontStyle.Bold);
            this.flexiLabel5.Location = new System.Drawing.Point(8, 8);
            this.flexiLabel5.Name = "flexiLabel5";
            this.flexiLabel5.Padding = new System.Windows.Forms.Padding(5);
            this.flexiLabel5.ScaleFactor = 1.5D;
            this.flexiLabel5.Size = new System.Drawing.Size(148, 30);
            this.flexiLabel5.TabIndex = 55;
            this.flexiLabel5.Text = "File Operations";
            // 
            // UiTP
            // 
            this.UiTP.AutoScroll = true;
            this.UiTP.Controls.Add(this.OperationalGB);
            this.UiTP.Controls.Add(this.AppearanceThemesGB);
            this.UiTP.Controls.Add(this.flexiLabel3);
            this.UiTP.Location = new System.Drawing.Point(0, 15);
            this.UiTP.Name = "UiTP";
            this.UiTP.Padding = new System.Windows.Forms.Padding(8);
            this.UiTP.Size = new System.Drawing.Size(430, 495);
            this.UiTP.TabIndex = 3;
            this.UiTP.Text = "Ui + UX";
            this.UiTP.UseVisualStyleBackColor = true;
            // 
            // OperationalGB
            // 
            this.OperationalGB.Controls.Add(this.AutoCloseProgressChB);
            this.OperationalGB.Controls.Add(this.EnableGamesGridRClickChB);
            this.OperationalGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.OperationalGB.Location = new System.Drawing.Point(8, 167);
            this.OperationalGB.Name = "OperationalGB";
            this.OperationalGB.Size = new System.Drawing.Size(414, 68);
            this.OperationalGB.TabIndex = 52;
            this.OperationalGB.TabStop = false;
            this.OperationalGB.Text = "Operational";
            // 
            // EnableGamesGridRClickChB
            // 
            this.EnableGamesGridRClickChB.AutoSize = true;
            this.EnableGamesGridRClickChB.Location = new System.Drawing.Point(11, 19);
            this.EnableGamesGridRClickChB.Name = "EnableGamesGridRClickChB";
            this.EnableGamesGridRClickChB.Size = new System.Drawing.Size(228, 17);
            this.EnableGamesGridRClickChB.TabIndex = 0;
            this.EnableGamesGridRClickChB.Text = "Right Click for context menu in Games Grid";
            this.EnableGamesGridRClickChB.UseVisualStyleBackColor = true;
            // 
            // AppearanceThemesGB
            // 
            this.AppearanceThemesGB.Controls.Add(this.flowLayoutPanel2);
            this.AppearanceThemesGB.Controls.Add(this.label17);
            this.AppearanceThemesGB.Controls.Add(this.StatusIconSizeAutoChB);
            this.AppearanceThemesGB.Controls.Add(this.label12);
            this.AppearanceThemesGB.Controls.Add(this.StatusIconSizeNUM);
            this.AppearanceThemesGB.Controls.Add(this.label8);
            this.AppearanceThemesGB.Controls.Add(this.MainTextSizeNUM);
            this.AppearanceThemesGB.Controls.Add(this.chkDarkMode);
            this.AppearanceThemesGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppearanceThemesGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppearanceThemesGB.Location = new System.Drawing.Point(8, 38);
            this.AppearanceThemesGB.Name = "AppearanceThemesGB";
            this.AppearanceThemesGB.Size = new System.Drawing.Size(414, 129);
            this.AppearanceThemesGB.TabIndex = 49;
            this.AppearanceThemesGB.TabStop = false;
            this.AppearanceThemesGB.Text = "Appearance and Theme";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.RomsGotLB);
            this.flowLayoutPanel2.Controls.Add(this.RomsMissingLB);
            this.flowLayoutPanel2.Controls.Add(this.RomsFixableLB);
            this.flowLayoutPanel2.Controls.Add(this.RomsUnknownLB);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(96, 71);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(309, 28);
            this.flowLayoutPanel2.TabIndex = 55;
            // 
            // RomsGotLB
            // 
            this.RomsGotLB.AutoSize = true;
            this.RomsGotLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsGotLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsGotLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RomsGotLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsGotLB.ForeColor = System.Drawing.Color.Lime;
            this.RomsGotLB.Location = new System.Drawing.Point(3, 0);
            this.RomsGotLB.Name = "RomsGotLB";
            this.RomsGotLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsGotLB.ScaleFactor = 1D;
            this.RomsGotLB.Size = new System.Drawing.Size(36, 25);
            this.RomsGotLB.TabIndex = 51;
            this.RomsGotLB.Tag = "override";
            this.RomsGotLB.Text = "Got";
            this.RomsGotLB.Click += new System.EventHandler(this.RomsStatusTagChangeColor);
            // 
            // RomsMissingLB
            // 
            this.RomsMissingLB.AutoSize = true;
            this.RomsMissingLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsMissingLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsMissingLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RomsMissingLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsMissingLB.ForeColor = System.Drawing.Color.Red;
            this.RomsMissingLB.Location = new System.Drawing.Point(45, 0);
            this.RomsMissingLB.Name = "RomsMissingLB";
            this.RomsMissingLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsMissingLB.ScaleFactor = 1D;
            this.RomsMissingLB.Size = new System.Drawing.Size(60, 25);
            this.RomsMissingLB.TabIndex = 52;
            this.RomsMissingLB.Tag = "override";
            this.RomsMissingLB.Text = "Missing";
            this.RomsMissingLB.Click += new System.EventHandler(this.RomsStatusTagChangeColor);
            // 
            // RomsFixableLB
            // 
            this.RomsFixableLB.AutoSize = true;
            this.RomsFixableLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsFixableLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsFixableLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RomsFixableLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsFixableLB.ForeColor = System.Drawing.Color.Yellow;
            this.RomsFixableLB.Location = new System.Drawing.Point(111, 0);
            this.RomsFixableLB.Name = "RomsFixableLB";
            this.RomsFixableLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsFixableLB.ScaleFactor = 1D;
            this.RomsFixableLB.Size = new System.Drawing.Size(56, 25);
            this.RomsFixableLB.TabIndex = 53;
            this.RomsFixableLB.Tag = "override";
            this.RomsFixableLB.Text = "Fixable";
            this.RomsFixableLB.Click += new System.EventHandler(this.RomsStatusTagChangeColor);
            // 
            // RomsUnknownLB
            // 
            this.RomsUnknownLB.AutoSize = true;
            this.RomsUnknownLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RomsUnknownLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RomsUnknownLB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RomsUnknownLB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomsUnknownLB.ForeColor = System.Drawing.Color.Cyan;
            this.RomsUnknownLB.Location = new System.Drawing.Point(173, 0);
            this.RomsUnknownLB.Name = "RomsUnknownLB";
            this.RomsUnknownLB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.RomsUnknownLB.ScaleFactor = 1D;
            this.RomsUnknownLB.Size = new System.Drawing.Size(72, 25);
            this.RomsUnknownLB.TabIndex = 54;
            this.RomsUnknownLB.Tag = "override";
            this.RomsUnknownLB.Text = "Unknown";
            this.RomsUnknownLB.Click += new System.EventHandler(this.RomsStatusTagChangeColor);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 50;
            this.label17.Text = "Rom Info Color:";
            // 
            // StatusIconSizeAutoChB
            // 
            this.StatusIconSizeAutoChB.AutoSize = true;
            this.StatusIconSizeAutoChB.Location = new System.Drawing.Point(149, 22);
            this.StatusIconSizeAutoChB.Name = "StatusIconSizeAutoChB";
            this.StatusIconSizeAutoChB.Size = new System.Drawing.Size(182, 17);
            this.StatusIconSizeAutoChB.TabIndex = 49;
            this.StatusIconSizeAutoChB.Text = "Auto (scales with Main Text Size)";
            this.StatusIconSizeAutoChB.UseVisualStyleBackColor = true;
            this.StatusIconSizeAutoChB.CheckedChanged += new System.EventHandler(this.StatusIconSizeAutoChB_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Staus Icon Size:";
            // 
            // StatusIconSizeNUM
            // 
            this.StatusIconSizeNUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusIconSizeNUM.Location = new System.Drawing.Point(96, 19);
            this.StatusIconSizeNUM.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.StatusIconSizeNUM.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.StatusIconSizeNUM.Name = "StatusIconSizeNUM";
            this.StatusIconSizeNUM.Size = new System.Drawing.Size(47, 20);
            this.StatusIconSizeNUM.TabIndex = 47;
            this.StatusIconSizeNUM.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.StatusIconSizeNUM.ValueChanged += new System.EventHandler(this.StatusIconSizeNUM_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Main Text Size:";
            // 
            // MainTextSizeNUM
            // 
            this.MainTextSizeNUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainTextSizeNUM.Location = new System.Drawing.Point(96, 45);
            this.MainTextSizeNUM.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.MainTextSizeNUM.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.MainTextSizeNUM.Name = "MainTextSizeNUM";
            this.MainTextSizeNUM.Size = new System.Drawing.Size(47, 20);
            this.MainTextSizeNUM.TabIndex = 44;
            this.MainTextSizeNUM.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.MainTextSizeNUM.ValueChanged += new System.EventHandler(this.MainTextSizeNUM_ValueChanged);
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Location = new System.Drawing.Point(96, 105);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(79, 17);
            this.chkDarkMode.TabIndex = 42;
            this.chkDarkMode.Text = "Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            // 
            // flexiLabel3
            // 
            this.flexiLabel3.AutoSize = true;
            this.flexiLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel3.Font = new System.Drawing.Font("Roboto", 12.375F, System.Drawing.FontStyle.Bold);
            this.flexiLabel3.Location = new System.Drawing.Point(8, 8);
            this.flexiLabel3.Name = "flexiLabel3";
            this.flexiLabel3.Padding = new System.Windows.Forms.Padding(5);
            this.flexiLabel3.ScaleFactor = 1.5D;
            this.flexiLabel3.Size = new System.Drawing.Size(102, 30);
            this.flexiLabel3.TabIndex = 54;
            this.flexiLabel3.Text = "UI and UX";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InfoTextExampleLB);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.InfoTextColorPB);
            this.tabPage1.Location = new System.Drawing.Point(0, 15);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 495);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "retired/parked";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // InfoTextExampleLB
            // 
            this.InfoTextExampleLB.AutoSize = true;
            this.InfoTextExampleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.InfoTextExampleLB.Location = new System.Drawing.Point(129, 27);
            this.InfoTextExampleLB.Name = "InfoTextExampleLB";
            this.InfoTextExampleLB.ScaleFactor = 1D;
            this.InfoTextExampleLB.Size = new System.Drawing.Size(53, 13);
            this.InfoTextExampleLB.TabIndex = 59;
            this.InfoTextExampleLB.Text = "(Example)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Info Text Color:";
            // 
            // InfoTextColorPB
            // 
            this.InfoTextColorPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoTextColorPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoTextColorPB.Location = new System.Drawing.Point(101, 22);
            this.InfoTextColorPB.Name = "InfoTextColorPB";
            this.InfoTextColorPB.Size = new System.Drawing.Size(22, 22);
            this.InfoTextColorPB.TabIndex = 57;
            this.InfoTextColorPB.TabStop = false;
            // 
            // MainSC
            // 
            this.MainSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSC.Location = new System.Drawing.Point(0, 0);
            this.MainSC.Name = "MainSC";
            // 
            // MainSC.Panel1
            // 
            this.MainSC.Panel1.Controls.Add(this.LeftPN);
            // 
            // MainSC.Panel2
            // 
            this.MainSC.Panel2.Controls.Add(this.MainTC);
            this.MainSC.Size = new System.Drawing.Size(584, 510);
            this.MainSC.SplitterDistance = 150;
            this.MainSC.TabIndex = 54;
            // 
            // RomsTP
            // 
            this.RomsTP.Controls.Add(this.groupBox3);
            this.RomsTP.Controls.Add(this.RomImportsGB);
            this.RomsTP.Controls.Add(this.CompressionGB);
            this.RomsTP.Controls.Add(this.flexiLabel6);
            this.RomsTP.Location = new System.Drawing.Point(0, 15);
            this.RomsTP.Name = "RomsTP";
            this.RomsTP.Padding = new System.Windows.Forms.Padding(8);
            this.RomsTP.Size = new System.Drawing.Size(430, 495);
            this.RomsTP.TabIndex = 6;
            this.RomsTP.Text = "Roms";
            this.RomsTP.UseVisualStyleBackColor = true;
            // 
            // flexiLabel6
            // 
            this.flexiLabel6.AutoSize = true;
            this.flexiLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel6.Font = new System.Drawing.Font("Roboto", 12.375F, System.Drawing.FontStyle.Bold);
            this.flexiLabel6.Location = new System.Drawing.Point(8, 8);
            this.flexiLabel6.Name = "flexiLabel6";
            this.flexiLabel6.Padding = new System.Windows.Forms.Padding(5);
            this.flexiLabel6.ScaleFactor = 1.5D;
            this.flexiLabel6.Size = new System.Drawing.Size(69, 30);
            this.flexiLabel6.TabIndex = 55;
            this.flexiLabel6.Text = "ROMs";
            // 
            // RomImportsGB
            // 
            this.RomImportsGB.AutoSize = true;
            this.RomImportsGB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RomImportsGB.Controls.Add(this.DeleteOrigRomsRelocateChB);
            this.RomImportsGB.Controls.Add(this.MoveFilesNotCopyChB);
            this.RomImportsGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.RomImportsGB.Location = new System.Drawing.Point(8, 122);
            this.RomImportsGB.Name = "RomImportsGB";
            this.RomImportsGB.Size = new System.Drawing.Size(414, 78);
            this.RomImportsGB.TabIndex = 57;
            this.RomImportsGB.TabStop = false;
            this.RomImportsGB.Text = "Rom Imports";
            // 
            // DeleteOrigRomsRelocateChB
            // 
            this.DeleteOrigRomsRelocateChB.AutoSize = true;
            this.DeleteOrigRomsRelocateChB.Location = new System.Drawing.Point(14, 42);
            this.DeleteOrigRomsRelocateChB.Name = "DeleteOrigRomsRelocateChB";
            this.DeleteOrigRomsRelocateChB.Size = new System.Drawing.Size(196, 17);
            this.DeleteOrigRomsRelocateChB.TabIndex = 46;
            this.DeleteOrigRomsRelocateChB.Text = "Delete original ROMs after Relocate";
            this.MainTT.SetToolTip(this.DeleteOrigRomsRelocateChB, resources.GetString("DeleteOrigRomsRelocateChB.ToolTip"));
            this.DeleteOrigRomsRelocateChB.UseVisualStyleBackColor = true;
            this.DeleteOrigRomsRelocateChB.Visible = false;
            // 
            // MoveFilesNotCopyChB
            // 
            this.MoveFilesNotCopyChB.AutoSize = true;
            this.MoveFilesNotCopyChB.Location = new System.Drawing.Point(14, 19);
            this.MoveFilesNotCopyChB.Name = "MoveFilesNotCopyChB";
            this.MoveFilesNotCopyChB.Size = new System.Drawing.Size(155, 17);
            this.MoveFilesNotCopyChB.TabIndex = 44;
            this.MoveFilesNotCopyChB.Text = "Move files rather than Copy";
            this.MainTT.SetToolTip(this.MoveFilesNotCopyChB, "By default, Rom files are copied rather than Moved when importing Roms. Select th" +
        "is if you wish to Move them instead (you will loose the files from your original" +
        " location)");
            this.MoveFilesNotCopyChB.UseVisualStyleBackColor = true;
            // 
            // CompressionGB
            // 
            this.CompressionGB.Controls.Add(this.label2);
            this.CompressionGB.Controls.Add(this.label7);
            this.CompressionGB.Controls.Add(this.cbo7zStruct);
            this.CompressionGB.Controls.Add(this.cboCores);
            this.CompressionGB.Dock = System.Windows.Forms.DockStyle.Top;
            this.CompressionGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompressionGB.Location = new System.Drawing.Point(8, 38);
            this.CompressionGB.Name = "CompressionGB";
            this.CompressionGB.Size = new System.Drawing.Size(414, 84);
            this.CompressionGB.TabIndex = 56;
            this.CompressionGB.TabStop = false;
            this.CompressionGB.Text = "Compression";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Max ZSTD workers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Default 7Z type:";
            // 
            // cbo7zStruct
            // 
            this.cbo7zStruct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo7zStruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo7zStruct.FormattingEnabled = true;
            this.cbo7zStruct.Location = new System.Drawing.Point(127, 48);
            this.cbo7zStruct.Name = "cbo7zStruct";
            this.cbo7zStruct.Size = new System.Drawing.Size(121, 21);
            this.cbo7zStruct.TabIndex = 40;
            // 
            // cboCores
            // 
            this.cboCores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCores.FormattingEnabled = true;
            this.cboCores.Location = new System.Drawing.Point(127, 24);
            this.cboCores.Name = "cboCores";
            this.cboCores.Size = new System.Drawing.Size(121, 21);
            this.cboCores.TabIndex = 41;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteRomSourceBT);
            this.groupBox3.Controls.Add(this.AddRomSourceBT);
            this.groupBox3.Controls.Add(this.RomSourceLinksDGV);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(8, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 287);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ROM Source Links";
            // 
            // DeleteRomSourceBT
            // 
            this.DeleteRomSourceBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteRomSourceBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.DeleteRomSourceBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRomSourceBT.Image = global::ROMVault.Properties.Resources.minus;
            this.DeleteRomSourceBT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteRomSourceBT.Location = new System.Drawing.Point(330, 55);
            this.DeleteRomSourceBT.Name = "DeleteRomSourceBT";
            this.DeleteRomSourceBT.Size = new System.Drawing.Size(75, 30);
            this.DeleteRomSourceBT.TabIndex = 36;
            this.DeleteRomSourceBT.Text = "Delete";
            this.DeleteRomSourceBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteRomSourceBT.UseVisualStyleBackColor = true;
            this.DeleteRomSourceBT.Click += new System.EventHandler(this.DeleteRomSourceBT_Click);
            // 
            // AddRomSourceBT
            // 
            this.AddRomSourceBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRomSourceBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.AddRomSourceBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRomSourceBT.Image = global::ROMVault.Properties.Resources.plus;
            this.AddRomSourceBT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddRomSourceBT.Location = new System.Drawing.Point(330, 19);
            this.AddRomSourceBT.Name = "AddRomSourceBT";
            this.AddRomSourceBT.Size = new System.Drawing.Size(75, 30);
            this.AddRomSourceBT.TabIndex = 35;
            this.AddRomSourceBT.Text = "Add";
            this.AddRomSourceBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRomSourceBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRomSourceBT.UseVisualStyleBackColor = true;
            this.AddRomSourceBT.Click += new System.EventHandler(this.AddRomSourceBT_Click);
            // 
            // RomSourceLinksDGV
            // 
            this.RomSourceLinksDGV.AllowUserToAddRows = false;
            this.RomSourceLinksDGV.AllowUserToResizeRows = false;
            this.RomSourceLinksDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RomSourceLinksDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RomSourceLinksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RomSourceLinksDGV.Location = new System.Drawing.Point(14, 19);
            this.RomSourceLinksDGV.Name = "RomSourceLinksDGV";
            this.RomSourceLinksDGV.RowHeadersVisible = false;
            this.RomSourceLinksDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RomSourceLinksDGV.Size = new System.Drawing.Size(310, 262);
            this.RomSourceLinksDGV.TabIndex = 0;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.MainSC);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.MainSS);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RomVault Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSettings_FormClosing);
            this.Load += new System.EventHandler(this.FrmConfigLoad);
            this.Shown += new System.EventHandler(this.FrmSettings_Shown);
            this.TvPaddingPN.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.LeftPN.ResumeLayout(false);
            this.LeftPN.PerformLayout();
            this.MainTC.ResumeLayout(false);
            this.DatSettingsTP.ResumeLayout(false);
            this.DatSettingsTP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upTime)).EndInit();
            this.DatVaultTP.ResumeLayout(false);
            this.DatVaultTP.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatSourceLinksDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.FileOperationsTP.ResumeLayout(false);
            this.FileOperationsTP.PerformLayout();
            this.LoggingGB.ResumeLayout(false);
            this.LoggingGB.PerformLayout();
            this.FileOperationalGB.ResumeLayout(false);
            this.FileOperationalGB.PerformLayout();
            this.UiTP.ResumeLayout(false);
            this.UiTP.PerformLayout();
            this.OperationalGB.ResumeLayout(false);
            this.OperationalGB.PerformLayout();
            this.AppearanceThemesGB.ResumeLayout(false);
            this.AppearanceThemesGB.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StatusIconSizeNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainTextSizeNUM)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTextColorPB)).EndInit();
            this.MainSC.Panel1.ResumeLayout(false);
            this.MainSC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSC)).EndInit();
            this.MainSC.ResumeLayout(false);
            this.RomsTP.ResumeLayout(false);
            this.RomsTP.PerformLayout();
            this.RomImportsGB.ResumeLayout(false);
            this.RomImportsGB.PerformLayout();
            this.CompressionGB.ResumeLayout(false);
            this.CompressionGB.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RomSourceLinksDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDATRoot;
        private System.Windows.Forms.Button btnDAT;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboFixLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDebugLogs;
        private System.Windows.Forms.CheckBox chkCacheSaveTimer;
        private System.Windows.Forms.NumericUpDown upTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkDoubleCheckDelete;
        private System.Windows.Forms.CheckBox chkDetailedReporting;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkDoNotReportFeedback;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox LoggingGB;
        private System.Windows.Forms.ColorDialog ColorBroswer;
        private UserControls.TabControl MainTC;
        private System.Windows.Forms.TabPage DatSettingsTP;
        private System.Windows.Forms.TabPage FileOperationsTP;
        private System.Windows.Forms.TreeView MainTV;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList MainIL;
        private System.Windows.Forms.Panel TvPaddingPN;
        private System.Windows.Forms.StatusStrip MainSS;
        private System.Windows.Forms.TabPage UiTP;
        private System.Windows.Forms.GroupBox AppearanceThemesGB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown MainTextSizeNUM;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.GroupBox OperationalGB;
        private System.Windows.Forms.CheckBox EnableGamesGridRClickChB;
        private System.Windows.Forms.ImageList DatFormatLvLineHeightForcer;
        private UserControls.ToolTip MainTT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown StatusIconSizeNUM;
        private System.Windows.Forms.CheckBox StatusIconSizeAutoChB;
        private System.Windows.Forms.Panel LeftPN;
        private System.Windows.Forms.Label label17;
        private UserControls.FlexiLabel RomsUnknownLB;
        private UserControls.FlexiLabel RomsFixableLB;
        private UserControls.FlexiLabel RomsMissingLB;
        private UserControls.FlexiLabel RomsGotLB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private UserControls.FlexiLabel flexiLabel2;
        private UserControls.FlexiLabel flexiLabel3;
        private System.Windows.Forms.TabPage tabPage1;
        private UserControls.FlexiLabel InfoTextExampleLB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox InfoTextColorPB;
        private System.Windows.Forms.TabPage DatVaultTP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox MoveDontCopyDatsChB;
        private System.Windows.Forms.Button RestoreDatFormatsBT;
        private System.Windows.Forms.Button DeleteDatFormatBT;
        private System.Windows.Forms.Button AddDatFormatBT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView DatFormatsLV;
        private System.Windows.Forms.CheckBox chkSendFoundMIA;
        private System.Windows.Forms.CheckBox chkSendFoundMIAAnon;
        private System.Windows.Forms.CheckBox chkDeleteOldCueFiles;
        private UserControls.FlexiLabel flexiLabel1;
        private UserControls.FlexiLabel flexiLabel4;
        private UserControls.FlexiLabel flexiLabel5;
        private System.Windows.Forms.SplitContainer MainSC;
        private System.Windows.Forms.CheckBox AutoCloseProgressChB;
        private System.Windows.Forms.GroupBox FileOperationalGB;
        private System.Windows.Forms.CheckBox PreserveEmptyRomFoldersChB;
        private System.Windows.Forms.CheckBox UseRootedPathsChB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView DatSourceLinksDGV;
        private System.Windows.Forms.Button DeleteDATSourceBT;
        private System.Windows.Forms.Button AddDatSourceBT;
        private System.Windows.Forms.TabPage RomsTP;
        private UserControls.FlexiLabel flexiLabel6;
        private System.Windows.Forms.GroupBox RomImportsGB;
        private System.Windows.Forms.CheckBox DeleteOrigRomsRelocateChB;
        private System.Windows.Forms.CheckBox MoveFilesNotCopyChB;
        private System.Windows.Forms.GroupBox CompressionGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo7zStruct;
        private System.Windows.Forms.ComboBox cboCores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DeleteRomSourceBT;
        private System.Windows.Forms.Button AddRomSourceBT;
        private System.Windows.Forms.DataGridView RomSourceLinksDGV;
    }
}