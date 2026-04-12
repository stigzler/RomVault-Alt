namespace ROMVault
{
    partial class FrmDirectorySettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDirectorySettings));
            this.DataGridGames = new System.Windows.Forms.DataGridView();
            this.CDAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CArchiveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMergeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSingleArchive = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtDATLocation = new System.Windows.Forms.Label();
            this.lblDATLocation = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExistingRulesPN = new System.Windows.Forms.Panel();
            this.RulesActionsFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.RulesPN = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDelete = new ROMVault.UserControls.FlexiLabel();
            this.MainTC = new ROMVault.UserControls.TabControl();
            this.tabDirMerge = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblArchiveCompression = new System.Windows.Forms.Label();
            this.cboCompression = new System.Windows.Forms.ComboBox();
            this.chkConvertWhenFixing = new System.Windows.Forms.CheckBox();
            this.cboHeaderType = new System.Windows.Forms.ComboBox();
            this.lblHeaderType = new System.Windows.Forms.Label();
            this.lblArchiveType = new System.Windows.Forms.Label();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.chkFileTypeOverride = new System.Windows.Forms.CheckBox();
            this.cboMergeType = new System.Windows.Forms.ComboBox();
            this.cboDirType = new System.Windows.Forms.ComboBox();
            this.lblMergeType = new System.Windows.Forms.Label();
            this.chkUseDescription = new System.Windows.Forms.CheckBox();
            this.chkMergeTypeOverride = new System.Windows.Forms.CheckBox();
            this.cboFilterType = new System.Windows.Forms.ComboBox();
            this.chkSingleArchive = new System.Windows.Forms.CheckBox();
            this.lblROMCHDFilter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMultiDatDirOverride = new System.Windows.Forms.CheckBox();
            this.tabAdvanced = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.dgCategories = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAddCategorySubDirs = new System.Windows.Forms.CheckBox();
            this.chkCompleteOnly = new System.Windows.Forms.CheckBox();
            this.chkUseIdForName = new System.Windows.Forms.CheckBox();
            this.tabExclude = new System.Windows.Forms.TabPage();
            this.flexiLabel2 = new ROMVault.UserControls.FlexiLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGames)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.ExistingRulesPN.SuspendLayout();
            this.RulesActionsFLP.SuspendLayout();
            this.RulesPN.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainTC.SuspendLayout();
            this.tabDirMerge.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabAdvanced.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).BeginInit();
            this.tabExclude.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridGames
            // 
            this.DataGridGames.AllowUserToAddRows = false;
            this.DataGridGames.AllowUserToDeleteRows = false;
            this.DataGridGames.AllowUserToResizeRows = false;
            this.DataGridGames.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridGames.BackgroundColor = System.Drawing.Color.White;
            this.DataGridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridGames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDAT,
            this.CArchiveType,
            this.CMergeType,
            this.CSingleArchive});
            this.DataGridGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridGames.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridGames.Location = new System.Drawing.Point(4, 27);
            this.DataGridGames.Name = "DataGridGames";
            this.DataGridGames.ReadOnly = true;
            this.DataGridGames.RowHeadersVisible = false;
            this.DataGridGames.RowHeadersWidth = 62;
            this.DataGridGames.RowTemplate.Height = 17;
            this.DataGridGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridGames.ShowCellErrors = false;
            this.DataGridGames.ShowCellToolTips = false;
            this.DataGridGames.ShowEditingIcon = false;
            this.DataGridGames.ShowRowErrors = false;
            this.DataGridGames.Size = new System.Drawing.Size(694, 156);
            this.DataGridGames.TabIndex = 10;
            this.DataGridGames.DoubleClick += new System.EventHandler(this.DataGridGamesDoubleClick);
            // 
            // CDAT
            // 
            this.CDAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDAT.FillWeight = 50F;
            this.CDAT.HeaderText = "Rule Path";
            this.CDAT.MinimumWidth = 8;
            this.CDAT.Name = "CDAT";
            this.CDAT.ReadOnly = true;
            // 
            // CArchiveType
            // 
            this.CArchiveType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CArchiveType.FillWeight = 20F;
            this.CArchiveType.HeaderText = "Archive Type";
            this.CArchiveType.MinimumWidth = 8;
            this.CArchiveType.Name = "CArchiveType";
            this.CArchiveType.ReadOnly = true;
            // 
            // CMergeType
            // 
            this.CMergeType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CMergeType.FillWeight = 20F;
            this.CMergeType.HeaderText = "Merge Type";
            this.CMergeType.MinimumWidth = 8;
            this.CMergeType.Name = "CMergeType";
            this.CMergeType.ReadOnly = true;
            // 
            // CSingleArchive
            // 
            this.CSingleArchive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CSingleArchive.FillWeight = 10F;
            this.CSingleArchive.HeaderText = "Single";
            this.CSingleArchive.MinimumWidth = 8;
            this.CSingleArchive.Name = "CSingleArchive";
            this.CSingleArchive.ReadOnly = true;
            this.CSingleArchive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CSingleArchive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelected.Location = new System.Drawing.Point(3, 3);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(96, 25);
            this.btnDeleteSelected.TabIndex = 11;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.BtnDeleteSelectedClick);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 24);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
            // 
            // btnSet
            // 
            this.btnSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(3, 33);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(59, 25);
            this.btnSet.TabIndex = 14;
            this.btnSet.Text = "Apply";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnApplyClick);
            // 
            // txtDATLocation
            // 
            this.txtDATLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDATLocation.BackColor = System.Drawing.Color.White;
            this.txtDATLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDATLocation.Location = new System.Drawing.Point(84, 8);
            this.txtDATLocation.Name = "txtDATLocation";
            this.txtDATLocation.Size = new System.Drawing.Size(606, 22);
            this.txtDATLocation.TabIndex = 11;
            this.txtDATLocation.Text = "label2";
            this.txtDATLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDATLocation.UseMnemonic = false;
            // 
            // lblDATLocation
            // 
            this.lblDATLocation.AutoSize = true;
            this.lblDATLocation.Location = new System.Drawing.Point(21, 13);
            this.lblDATLocation.Name = "lblDATLocation";
            this.lblDATLocation.Size = new System.Drawing.Size(57, 13);
            this.lblDATLocation.TabIndex = 10;
            this.lblDATLocation.Text = "Rule Path:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(603, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 25);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Done";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnResetAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnResetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetAll.Location = new System.Drawing.Point(105, 3);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(96, 25);
            this.btnResetAll.TabIndex = 17;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.BtnResetAllClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 504);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(702, 34);
            this.flowLayoutPanel1.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(501, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btnDeleteSelected);
            this.flowLayoutPanel2.Controls.Add(this.btnResetAll);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 183);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(694, 31);
            this.flowLayoutPanel2.TabIndex = 52;
            // 
            // ExistingRulesPN
            // 
            this.ExistingRulesPN.AutoSize = true;
            this.ExistingRulesPN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExistingRulesPN.Controls.Add(this.DataGridGames);
            this.ExistingRulesPN.Controls.Add(this.lblDelete);
            this.ExistingRulesPN.Controls.Add(this.flowLayoutPanel2);
            this.ExistingRulesPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExistingRulesPN.Location = new System.Drawing.Point(0, 286);
            this.ExistingRulesPN.Name = "ExistingRulesPN";
            this.ExistingRulesPN.Padding = new System.Windows.Forms.Padding(4);
            this.ExistingRulesPN.Size = new System.Drawing.Size(702, 218);
            this.ExistingRulesPN.TabIndex = 53;
            // 
            // RulesActionsFLP
            // 
            this.RulesActionsFLP.AutoSize = true;
            this.RulesActionsFLP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RulesActionsFLP.Controls.Add(this.btnDelete);
            this.RulesActionsFLP.Controls.Add(this.btnSet);
            this.RulesActionsFLP.Dock = System.Windows.Forms.DockStyle.Right;
            this.RulesActionsFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RulesActionsFLP.Location = new System.Drawing.Point(633, 4);
            this.RulesActionsFLP.Name = "RulesActionsFLP";
            this.RulesActionsFLP.Size = new System.Drawing.Size(65, 215);
            this.RulesActionsFLP.TabIndex = 54;
            // 
            // RulesPN
            // 
            this.RulesPN.Controls.Add(this.MainTC);
            this.RulesPN.Controls.Add(this.RulesActionsFLP);
            this.RulesPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.RulesPN.Location = new System.Drawing.Point(0, 63);
            this.RulesPN.Name = "RulesPN";
            this.RulesPN.Padding = new System.Windows.Forms.Padding(4);
            this.RulesPN.Size = new System.Drawing.Size(702, 223);
            this.RulesPN.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.txtDATLocation);
            this.panel1.Controls.Add(this.lblDATLocation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(702, 38);
            this.panel1.TabIndex = 56;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDelete.Font = new System.Drawing.Font("Roboto", 9.075F, System.Drawing.FontStyle.Bold);
            this.lblDelete.Location = new System.Drawing.Point(4, 4);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Padding = new System.Windows.Forms.Padding(4);
            this.lblDelete.ScaleFactor = 1.1D;
            this.lblDelete.Size = new System.Drawing.Size(139, 23);
            this.lblDelete.TabIndex = 16;
            this.lblDelete.Text = "Existing DAT Rules";
            // 
            // MainTC
            // 
            this.MainTC.Controls.Add(this.tabDirMerge);
            this.MainTC.Controls.Add(this.tabAdvanced);
            this.MainTC.Controls.Add(this.tabExclude);
            this.MainTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTC.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainTC.HideBorders = true;
            this.MainTC.HideTabs = false;
            this.MainTC.ItemSize = new System.Drawing.Size(138, 23);
            this.MainTC.Location = new System.Drawing.Point(4, 4);
            this.MainTC.Name = "MainTC";
            this.MainTC.SelectedIndex = 0;
            this.MainTC.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.MainTC.Size = new System.Drawing.Size(629, 215);
            this.MainTC.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTC.TabIndex = 50;
            this.MainTC.TabOutlineColor = System.Drawing.SystemColors.ControlDark;
            this.MainTC.TabPadding = 5;
            this.MainTC.UnselectedTabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // tabDirMerge
            // 
            this.tabDirMerge.Controls.Add(this.groupBox2);
            this.tabDirMerge.Controls.Add(this.groupBox1);
            this.tabDirMerge.Location = new System.Drawing.Point(0, 25);
            this.tabDirMerge.Name = "tabDirMerge";
            this.tabDirMerge.Padding = new System.Windows.Forms.Padding(4);
            this.tabDirMerge.Size = new System.Drawing.Size(629, 190);
            this.tabDirMerge.TabIndex = 0;
            this.tabDirMerge.Text = "Directory/Merge Rules";
            this.tabDirMerge.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblArchiveCompression);
            this.groupBox2.Controls.Add(this.cboCompression);
            this.groupBox2.Controls.Add(this.chkConvertWhenFixing);
            this.groupBox2.Controls.Add(this.cboHeaderType);
            this.groupBox2.Controls.Add(this.lblHeaderType);
            this.groupBox2.Controls.Add(this.lblArchiveType);
            this.groupBox2.Controls.Add(this.cboFileType);
            this.groupBox2.Controls.Add(this.chkFileTypeOverride);
            this.groupBox2.Controls.Add(this.cboMergeType);
            this.groupBox2.Controls.Add(this.cboDirType);
            this.groupBox2.Controls.Add(this.lblMergeType);
            this.groupBox2.Controls.Add(this.chkUseDescription);
            this.groupBox2.Controls.Add(this.chkMergeTypeOverride);
            this.groupBox2.Controls.Add(this.cboFilterType);
            this.groupBox2.Controls.Add(this.chkSingleArchive);
            this.groupBox2.Controls.Add(this.lblROMCHDFilter);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(4, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 142);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DAT Rule Settings";
            // 
            // lblArchiveCompression
            // 
            this.lblArchiveCompression.AutoSize = true;
            this.lblArchiveCompression.Location = new System.Drawing.Point(6, 46);
            this.lblArchiveCompression.Name = "lblArchiveCompression";
            this.lblArchiveCompression.Size = new System.Drawing.Size(97, 13);
            this.lblArchiveCompression.TabIndex = 48;
            this.lblArchiveCompression.Text = "Compression Type:";
            // 
            // cboCompression
            // 
            this.cboCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCompression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCompression.FormattingEnabled = true;
            this.cboCompression.Location = new System.Drawing.Point(105, 43);
            this.cboCompression.Name = "cboCompression";
            this.cboCompression.Size = new System.Drawing.Size(132, 21);
            this.cboCompression.TabIndex = 47;
            // 
            // chkConvertWhenFixing
            // 
            this.chkConvertWhenFixing.Location = new System.Drawing.Point(247, 46);
            this.chkConvertWhenFixing.Name = "chkConvertWhenFixing";
            this.chkConvertWhenFixing.Size = new System.Drawing.Size(120, 17);
            this.chkConvertWhenFixing.TabIndex = 49;
            this.chkConvertWhenFixing.Text = "Convert when fixing";
            this.chkConvertWhenFixing.UseVisualStyleBackColor = true;
            // 
            // cboHeaderType
            // 
            this.cboHeaderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeaderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHeaderType.FormattingEnabled = true;
            this.cboHeaderType.Location = new System.Drawing.Point(465, 44);
            this.cboHeaderType.Name = "cboHeaderType";
            this.cboHeaderType.Size = new System.Drawing.Size(102, 21);
            this.cboHeaderType.TabIndex = 46;
            // 
            // lblHeaderType
            // 
            this.lblHeaderType.AutoSize = true;
            this.lblHeaderType.Location = new System.Drawing.Point(375, 47);
            this.lblHeaderType.Name = "lblHeaderType";
            this.lblHeaderType.Size = new System.Drawing.Size(72, 13);
            this.lblHeaderType.TabIndex = 45;
            this.lblHeaderType.Text = "Header Type:";
            // 
            // lblArchiveType
            // 
            this.lblArchiveType.AutoSize = true;
            this.lblArchiveType.Location = new System.Drawing.Point(6, 19);
            this.lblArchiveType.Name = "lblArchiveType";
            this.lblArchiveType.Size = new System.Drawing.Size(73, 13);
            this.lblArchiveType.TabIndex = 30;
            this.lblArchiveType.Text = "Archive Type:";
            // 
            // cboFileType
            // 
            this.cboFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Location = new System.Drawing.Point(105, 16);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(132, 21);
            this.cboFileType.TabIndex = 29;
            this.cboFileType.SelectedIndexChanged += new System.EventHandler(this.cboFileType_SelectedIndexChanged);
            // 
            // chkFileTypeOverride
            // 
            this.chkFileTypeOverride.Location = new System.Drawing.Point(247, 19);
            this.chkFileTypeOverride.Name = "chkFileTypeOverride";
            this.chkFileTypeOverride.Size = new System.Drawing.Size(120, 17);
            this.chkFileTypeOverride.TabIndex = 31;
            this.chkFileTypeOverride.Text = "Override DAT";
            this.chkFileTypeOverride.UseVisualStyleBackColor = true;
            // 
            // cboMergeType
            // 
            this.cboMergeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMergeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMergeType.FormattingEnabled = true;
            this.cboMergeType.Location = new System.Drawing.Point(105, 70);
            this.cboMergeType.Name = "cboMergeType";
            this.cboMergeType.Size = new System.Drawing.Size(132, 21);
            this.cboMergeType.TabIndex = 32;
            // 
            // cboDirType
            // 
            this.cboDirType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDirType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDirType.FormattingEnabled = true;
            this.cboDirType.Location = new System.Drawing.Point(105, 95);
            this.cboDirType.Name = "cboDirType";
            this.cboDirType.Size = new System.Drawing.Size(331, 21);
            this.cboDirType.TabIndex = 44;
            // 
            // lblMergeType
            // 
            this.lblMergeType.AutoSize = true;
            this.lblMergeType.Location = new System.Drawing.Point(6, 73);
            this.lblMergeType.Name = "lblMergeType";
            this.lblMergeType.Size = new System.Drawing.Size(67, 13);
            this.lblMergeType.TabIndex = 33;
            this.lblMergeType.Text = "Merge Type:";
            // 
            // chkUseDescription
            // 
            this.chkUseDescription.Location = new System.Drawing.Point(9, 119);
            this.chkUseDescription.Name = "chkUseDescription";
            this.chkUseDescription.Size = new System.Drawing.Size(297, 19);
            this.chkUseDescription.TabIndex = 42;
            this.chkUseDescription.Text = "Use description (instead of name)  for auto added paths";
            this.chkUseDescription.UseVisualStyleBackColor = true;
            // 
            // chkMergeTypeOverride
            // 
            this.chkMergeTypeOverride.Location = new System.Drawing.Point(247, 73);
            this.chkMergeTypeOverride.Name = "chkMergeTypeOverride";
            this.chkMergeTypeOverride.Size = new System.Drawing.Size(118, 17);
            this.chkMergeTypeOverride.TabIndex = 34;
            this.chkMergeTypeOverride.Text = "Override DAT";
            this.chkMergeTypeOverride.UseVisualStyleBackColor = true;
            // 
            // cboFilterType
            // 
            this.cboFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilterType.FormattingEnabled = true;
            this.cboFilterType.Location = new System.Drawing.Point(465, 16);
            this.cboFilterType.Name = "cboFilterType";
            this.cboFilterType.Size = new System.Drawing.Size(102, 21);
            this.cboFilterType.TabIndex = 41;
            // 
            // chkSingleArchive
            // 
            this.chkSingleArchive.Location = new System.Drawing.Point(9, 98);
            this.chkSingleArchive.Name = "chkSingleArchive";
            this.chkSingleArchive.Size = new System.Drawing.Size(95, 19);
            this.chkSingleArchive.TabIndex = 35;
            this.chkSingleArchive.Text = "Single Archive";
            this.chkSingleArchive.UseVisualStyleBackColor = true;
            this.chkSingleArchive.CheckedChanged += new System.EventHandler(this.chkSingleArchive_CheckedChanged);
            // 
            // lblROMCHDFilter
            // 
            this.lblROMCHDFilter.AutoSize = true;
            this.lblROMCHDFilter.Location = new System.Drawing.Point(375, 19);
            this.lblROMCHDFilter.Name = "lblROMCHDFilter";
            this.lblROMCHDFilter.Size = new System.Drawing.Size(88, 13);
            this.lblROMCHDFilter.TabIndex = 40;
            this.lblROMCHDFilter.Text = "ROM/CHD Filter:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMultiDatDirOverride);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 44);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multi DAT Directory Setting";
            // 
            // chkMultiDatDirOverride
            // 
            this.chkMultiDatDirOverride.Location = new System.Drawing.Point(11, 20);
            this.chkMultiDatDirOverride.Name = "chkMultiDatDirOverride";
            this.chkMultiDatDirOverride.Size = new System.Drawing.Size(220, 16);
            this.chkMultiDatDirOverride.TabIndex = 36;
            this.chkMultiDatDirOverride.Text = "Don\'t auto add DAT directories";
            this.chkMultiDatDirOverride.UseVisualStyleBackColor = true;
            // 
            // tabAdvanced
            // 
            this.tabAdvanced.Controls.Add(this.groupBox3);
            this.tabAdvanced.Location = new System.Drawing.Point(0, 21);
            this.tabAdvanced.Name = "tabAdvanced";
            this.tabAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanced.Size = new System.Drawing.Size(629, 194);
            this.tabAdvanced.TabIndex = 2;
            this.tabAdvanced.Text = "Advanced Options";
            this.tabAdvanced.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDown);
            this.groupBox3.Controls.Add(this.btnUp);
            this.groupBox3.Controls.Add(this.dgCategories);
            this.groupBox3.Controls.Add(this.chkAddCategorySubDirs);
            this.groupBox3.Controls.Add(this.chkCompleteOnly);
            this.groupBox3.Controls.Add(this.chkUseIdForName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 188);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Advanced Options";
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Image = global::ROMVault.Properties.Resources.arrowDown;
            this.btnDown.Location = new System.Drawing.Point(585, 59);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(31, 35);
            this.btnDown.TabIndex = 54;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Image = global::ROMVault.Properties.Resources.arrowUp;
            this.btnUp.Location = new System.Drawing.Point(585, 18);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(31, 35);
            this.btnUp.TabIndex = 53;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // dgCategories
            // 
            this.dgCategories.AllowUserToAddRows = false;
            this.dgCategories.AllowUserToDeleteRows = false;
            this.dgCategories.AllowUserToResizeColumns = false;
            this.dgCategories.AllowUserToResizeRows = false;
            this.dgCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category});
            this.dgCategories.EnableHeadersVisualStyles = false;
            this.dgCategories.Location = new System.Drawing.Point(286, 18);
            this.dgCategories.MultiSelect = false;
            this.dgCategories.Name = "dgCategories";
            this.dgCategories.ReadOnly = true;
            this.dgCategories.RowHeadersVisible = false;
            this.dgCategories.RowHeadersWidth = 62;
            this.dgCategories.RowTemplate.Height = 18;
            this.dgCategories.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCategories.ShowCellErrors = false;
            this.dgCategories.ShowCellToolTips = false;
            this.dgCategories.ShowEditingIcon = false;
            this.dgCategories.ShowRowErrors = false;
            this.dgCategories.Size = new System.Drawing.Size(286, 155);
            this.dgCategories.TabIndex = 52;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.HeaderText = "Category Priority";
            this.Category.MinimumWidth = 8;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chkAddCategorySubDirs
            // 
            this.chkAddCategorySubDirs.Location = new System.Drawing.Point(6, 28);
            this.chkAddCategorySubDirs.Name = "chkAddCategorySubDirs";
            this.chkAddCategorySubDirs.Size = new System.Drawing.Size(265, 17);
            this.chkAddCategorySubDirs.TabIndex = 51;
            this.chkAddCategorySubDirs.Text = "Add Category Sub Directories";
            this.chkAddCategorySubDirs.UseVisualStyleBackColor = true;
            this.chkAddCategorySubDirs.CheckedChanged += new System.EventHandler(this.chkAddCategorySubDirs_CheckedChanged);
            // 
            // chkCompleteOnly
            // 
            this.chkCompleteOnly.Location = new System.Drawing.Point(6, 88);
            this.chkCompleteOnly.Name = "chkCompleteOnly";
            this.chkCompleteOnly.Size = new System.Drawing.Size(265, 17);
            this.chkCompleteOnly.TabIndex = 50;
            this.chkCompleteOnly.Text = "Only Keep Complete Sets";
            this.chkCompleteOnly.UseVisualStyleBackColor = true;
            // 
            // chkUseIdForName
            // 
            this.chkUseIdForName.Location = new System.Drawing.Point(6, 65);
            this.chkUseIdForName.Name = "chkUseIdForName";
            this.chkUseIdForName.Size = new System.Drawing.Size(265, 17);
            this.chkUseIdForName.TabIndex = 49;
            this.chkUseIdForName.Text = "Use ID for Numbered DAT Names (No-Intro DATs)";
            this.chkUseIdForName.UseVisualStyleBackColor = true;
            // 
            // tabExclude
            // 
            this.tabExclude.Controls.Add(this.flexiLabel2);
            this.tabExclude.Controls.Add(this.label6);
            this.tabExclude.Controls.Add(this.textBox1);
            this.tabExclude.Location = new System.Drawing.Point(0, 21);
            this.tabExclude.Name = "tabExclude";
            this.tabExclude.Padding = new System.Windows.Forms.Padding(3);
            this.tabExclude.Size = new System.Drawing.Size(629, 194);
            this.tabExclude.TabIndex = 1;
            this.tabExclude.Text = "Filename Exclude";
            this.tabExclude.UseVisualStyleBackColor = true;
            // 
            // flexiLabel2
            // 
            this.flexiLabel2.AutoSize = true;
            this.flexiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexiLabel2.Location = new System.Drawing.Point(17, 17);
            this.flexiLabel2.Name = "flexiLabel2";
            this.flexiLabel2.ScaleFactor = 1D;
            this.flexiLabel2.Size = new System.Drawing.Size(145, 13);
            this.flexiLabel2.TabIndex = 51;
            this.flexiLabel2.Text = "Filenames not to remove";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(400, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 49);
            this.label6.TabIndex = 50;
            this.label6.Text = "One rule per line\r\nBasic rules support * and ? wildcards\r\nRegex rules must start " +
    "with \"regex:\"";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(18, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 150);
            this.textBox1.TabIndex = 48;
            // 
            // flexiLabel1
            // 
            this.flexiLabel1.AutoSize = true;
            this.flexiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel1.Font = new System.Drawing.Font("Roboto", 9.900001F, System.Drawing.FontStyle.Bold);
            this.flexiLabel1.Location = new System.Drawing.Point(0, 0);
            this.flexiLabel1.Name = "flexiLabel1";
            this.flexiLabel1.Padding = new System.Windows.Forms.Padding(4);
            this.flexiLabel1.ScaleFactor = 1.2D;
            this.flexiLabel1.Size = new System.Drawing.Size(87, 25);
            this.flexiLabel1.TabIndex = 57;
            this.flexiLabel1.Text = "DAT Rules";
            // 
            // FrmDirectorySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(702, 538);
            this.Controls.Add(this.ExistingRulesPN);
            this.Controls.Add(this.RulesPN);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flexiLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(671, 392);
            this.Name = "FrmDirectorySettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set DAT Rules";
            this.Activated += new System.EventHandler(this.FrmSetDirActivated);
            this.Load += new System.EventHandler(this.FrmDirectorySettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGames)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ExistingRulesPN.ResumeLayout(false);
            this.ExistingRulesPN.PerformLayout();
            this.RulesActionsFLP.ResumeLayout(false);
            this.RulesPN.ResumeLayout(false);
            this.RulesPN.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainTC.ResumeLayout(false);
            this.tabDirMerge.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabAdvanced.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).EndInit();
            this.tabExclude.ResumeLayout(false);
            this.tabExclude.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridGames;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label txtDATLocation;
        private System.Windows.Forms.Label lblDATLocation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnDelete;
        private UserControls.TabControl MainTC;
        private System.Windows.Forms.TabPage tabDirMerge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboHeaderType;
        private System.Windows.Forms.Label lblHeaderType;
        private System.Windows.Forms.Label lblArchiveType;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.CheckBox chkFileTypeOverride;
        private System.Windows.Forms.ComboBox cboMergeType;
        private System.Windows.Forms.ComboBox cboDirType;
        private System.Windows.Forms.Label lblMergeType;
        private System.Windows.Forms.CheckBox chkUseDescription;
        private System.Windows.Forms.CheckBox chkMergeTypeOverride;
        private System.Windows.Forms.ComboBox cboFilterType;
        private System.Windows.Forms.CheckBox chkSingleArchive;
        private System.Windows.Forms.Label lblROMCHDFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMultiDatDirOverride;
        private System.Windows.Forms.TabPage tabExclude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabAdvanced;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkCompleteOnly;
        private System.Windows.Forms.CheckBox chkUseIdForName;
        private System.Windows.Forms.CheckBox chkAddCategorySubDirs;
        private System.Windows.Forms.DataGridView dgCategories;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CArchiveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMergeType;
        private System.Windows.Forms.DataGridViewImageColumn CSingleArchive;
        private System.Windows.Forms.Label lblArchiveCompression;
        private System.Windows.Forms.ComboBox cboCompression;
        private System.Windows.Forms.CheckBox chkConvertWhenFixing;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel ExistingRulesPN;
        private UserControls.FlexiLabel lblDelete;
        private System.Windows.Forms.FlowLayoutPanel RulesActionsFLP;
        private System.Windows.Forms.Panel RulesPN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private UserControls.FlexiLabel flexiLabel1;
        private UserControls.FlexiLabel flexiLabel2;
    }
}