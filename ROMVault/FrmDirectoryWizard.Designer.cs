namespace ROMVault
{
    partial class FrmDirectoryWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDirectoryWizard));
            this.DefaultSchemaDD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SchemaInfoLB = new System.Windows.Forms.Label();
            this.LoadSchemaPathLB = new ROMVault.UserControls.PathLabel();
            this.LoadSchemaBT = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GoBT = new System.Windows.Forms.Button();
            this.SaveAsBT = new System.Windows.Forms.Button();
            this.ValidateBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.TestBT = new System.Windows.Forms.Button();
            this.OptionsGB = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateFoldersChB = new System.Windows.Forms.CheckBox();
            this.DeleteFoldersChB = new System.Windows.Forms.CheckBox();
            this.CustomLocationLB = new ROMVault.UserControls.PathLabel();
            this.DeleteFilesChB = new System.Windows.Forms.CheckBox();
            this.CustomLocationBT = new System.Windows.Forms.Button();
            this.UnderCustomLocationChB = new System.Windows.Forms.CheckBox();
            this.UnderDatsChB = new System.Windows.Forms.CheckBox();
            this.UnderRomsChB = new System.Windows.Forms.CheckBox();
            this.OptionsPaddingPN = new System.Windows.Forms.Panel();
            this.MainTT = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1 = new ROMVault.UserControls.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SubFolerPN = new System.Windows.Forms.Panel();
            this.SubFoldersRTB = new System.Windows.Forms.RichTextBox();
            this.SubFolderInfoLB = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FolderPN = new System.Windows.Forms.Panel();
            this.FoldersRTB = new System.Windows.Forms.RichTextBox();
            this.FoldersInfoLB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LogRTB = new System.Windows.Forms.RichTextBox();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.OptionsGB.SuspendLayout();
            this.OptionsPaddingPN.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SubFolerPN.SuspendLayout();
            this.FolderPN.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DefaultSchemaDD
            // 
            this.DefaultSchemaDD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultSchemaDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultSchemaDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultSchemaDD.FormattingEnabled = true;
            this.DefaultSchemaDD.Location = new System.Drawing.Point(103, 3);
            this.DefaultSchemaDD.Name = "DefaultSchemaDD";
            this.DefaultSchemaDD.Size = new System.Drawing.Size(321, 21);
            this.DefaultSchemaDD.TabIndex = 1;
            this.DefaultSchemaDD.SelectedIndexChanged += new System.EventHandler(this.DefaultSchemaDD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Default Schemas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Load Schema:";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.SchemaInfoLB);
            this.panel1.Controls.Add(this.DefaultSchemaDD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LoadSchemaPathLB);
            this.panel1.Controls.Add(this.LoadSchemaBT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 75);
            this.panel1.TabIndex = 7;
            // 
            // SchemaInfoLB
            // 
            this.SchemaInfoLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchemaInfoLB.Image = global::ROMVault.Properties.Resources.information;
            this.SchemaInfoLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SchemaInfoLB.Location = new System.Drawing.Point(100, 54);
            this.SchemaInfoLB.Name = "SchemaInfoLB";
            this.SchemaInfoLB.Size = new System.Drawing.Size(324, 21);
            this.SchemaInfoLB.TabIndex = 6;
            this.SchemaInfoLB.Text = "      Information";
            this.SchemaInfoLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SchemaInfoLB.Visible = false;
            // 
            // LoadSchemaPathLB
            // 
            this.LoadSchemaPathLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadSchemaPathLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoadSchemaPathLB.Location = new System.Drawing.Point(103, 30);
            this.LoadSchemaPathLB.Margin = new System.Windows.Forms.Padding(3);
            this.LoadSchemaPathLB.Name = "LoadSchemaPathLB";
            this.LoadSchemaPathLB.Size = new System.Drawing.Size(237, 21);
            this.LoadSchemaPathLB.TabIndex = 3;
            // 
            // LoadSchemaBT
            // 
            this.LoadSchemaBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadSchemaBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.LoadSchemaBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSchemaBT.Image = global::ROMVault.Properties.Resources.folder_horizontal_open;
            this.LoadSchemaBT.Location = new System.Drawing.Point(346, 30);
            this.LoadSchemaBT.Name = "LoadSchemaBT";
            this.LoadSchemaBT.Size = new System.Drawing.Size(78, 23);
            this.LoadSchemaBT.TabIndex = 4;
            this.LoadSchemaBT.Text = " Browse";
            this.LoadSchemaBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadSchemaBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadSchemaBT.UseVisualStyleBackColor = true;
            this.LoadSchemaBT.Click += new System.EventHandler(this.LoadSchemaBT_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.GoBT);
            this.flowLayoutPanel1.Controls.Add(this.SaveAsBT);
            this.flowLayoutPanel1.Controls.Add(this.ValidateBT);
            this.flowLayoutPanel1.Controls.Add(this.CancelBT);
            this.flowLayoutPanel1.Controls.Add(this.TestBT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 538);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 42);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // GoBT
            // 
            this.GoBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.GoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBT.Image = global::ROMVault.Properties.Resources.folder_smiley;
            this.GoBT.Location = new System.Drawing.Point(335, 6);
            this.GoBT.Name = "GoBT";
            this.GoBT.Size = new System.Drawing.Size(90, 30);
            this.GoBT.TabIndex = 5;
            this.GoBT.Text = " GO!";
            this.GoBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GoBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MainTT.SetToolTip(this.GoBT, "Start Operation");
            this.GoBT.UseVisualStyleBackColor = true;
            this.GoBT.Click += new System.EventHandler(this.GoBT_Click);
            // 
            // SaveAsBT
            // 
            this.SaveAsBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAsBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.SaveAsBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsBT.Image = global::ROMVault.Properties.Resources.disk;
            this.SaveAsBT.Location = new System.Drawing.Point(239, 6);
            this.SaveAsBT.Name = "SaveAsBT";
            this.SaveAsBT.Size = new System.Drawing.Size(90, 30);
            this.SaveAsBT.TabIndex = 8;
            this.SaveAsBT.Text = " SaveAs";
            this.SaveAsBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveAsBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MainTT.SetToolTip(this.SaveAsBT, "Saves the current schema as RomVault Schema file (rvs)");
            this.SaveAsBT.UseVisualStyleBackColor = true;
            // 
            // ValidateBT
            // 
            this.ValidateBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidateBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ValidateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValidateBT.Image = global::ROMVault.Properties.Resources.stamp;
            this.ValidateBT.Location = new System.Drawing.Point(143, 6);
            this.ValidateBT.Name = "ValidateBT";
            this.ValidateBT.Size = new System.Drawing.Size(90, 30);
            this.ValidateBT.TabIndex = 7;
            this.ValidateBT.Text = " Validate";
            this.ValidateBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValidateBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MainTT.SetToolTip(this.ValidateBT, "Validates the schema to ensure correct syntax + pathing");
            this.ValidateBT.UseVisualStyleBackColor = true;
            this.ValidateBT.Click += new System.EventHandler(this.ValidateBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBT.Image = global::ROMVault.Properties.Resources.cross;
            this.CancelBT.Location = new System.Drawing.Point(47, 6);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(90, 30);
            this.CancelBT.TabIndex = 6;
            this.CancelBT.Text = " Cancel";
            this.CancelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // TestBT
            // 
            this.TestBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TestBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.TestBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TestBT.Image = global::ROMVault.Properties.Resources.question_frame;
            this.TestBT.Location = new System.Drawing.Point(7, 6);
            this.TestBT.Name = "TestBT";
            this.TestBT.Size = new System.Drawing.Size(34, 30);
            this.TestBT.TabIndex = 9;
            this.TestBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TestBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TestBT.UseVisualStyleBackColor = true;
            this.TestBT.Click += new System.EventHandler(this.TestBT_Click);
            // 
            // OptionsGB
            // 
            this.OptionsGB.AutoSize = true;
            this.OptionsGB.Controls.Add(this.label5);
            this.OptionsGB.Controls.Add(this.CreateFoldersChB);
            this.OptionsGB.Controls.Add(this.DeleteFoldersChB);
            this.OptionsGB.Controls.Add(this.CustomLocationLB);
            this.OptionsGB.Controls.Add(this.DeleteFilesChB);
            this.OptionsGB.Controls.Add(this.CustomLocationBT);
            this.OptionsGB.Controls.Add(this.UnderCustomLocationChB);
            this.OptionsGB.Controls.Add(this.UnderDatsChB);
            this.OptionsGB.Controls.Add(this.UnderRomsChB);
            this.OptionsGB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsGB.Location = new System.Drawing.Point(5, 5);
            this.OptionsGB.Margin = new System.Windows.Forms.Padding(10);
            this.OptionsGB.Name = "OptionsGB";
            this.OptionsGB.Padding = new System.Windows.Forms.Padding(5);
            this.OptionsGB.Size = new System.Drawing.Size(424, 133);
            this.OptionsGB.TabIndex = 11;
            this.OptionsGB.TabStop = false;
            this.OptionsGB.Text = "Options";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Method:";
            // 
            // CreateFoldersChB
            // 
            this.CreateFoldersChB.AutoSize = true;
            this.CreateFoldersChB.Checked = true;
            this.CreateFoldersChB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreateFoldersChB.Location = new System.Drawing.Point(71, 20);
            this.CreateFoldersChB.Name = "CreateFoldersChB";
            this.CreateFoldersChB.Size = new System.Drawing.Size(94, 17);
            this.CreateFoldersChB.TabIndex = 10;
            this.CreateFoldersChB.Text = "Create Folders";
            this.CreateFoldersChB.UseVisualStyleBackColor = true;
            this.CreateFoldersChB.CheckedChanged += new System.EventHandler(this.CReateFoldersChB_CheckedChanged);
            // 
            // DeleteFoldersChB
            // 
            this.DeleteFoldersChB.AutoSize = true;
            this.DeleteFoldersChB.Location = new System.Drawing.Point(171, 20);
            this.DeleteFoldersChB.Name = "DeleteFoldersChB";
            this.DeleteFoldersChB.Size = new System.Drawing.Size(94, 17);
            this.DeleteFoldersChB.TabIndex = 9;
            this.DeleteFoldersChB.Text = "Delete Folders";
            this.DeleteFoldersChB.UseVisualStyleBackColor = true;
            this.DeleteFoldersChB.CheckedChanged += new System.EventHandler(this.DeleteFoldersChB_CheckedChanged);
            // 
            // CustomLocationLB
            // 
            this.CustomLocationLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomLocationLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomLocationLB.Location = new System.Drawing.Point(19, 89);
            this.CustomLocationLB.Margin = new System.Windows.Forms.Padding(3);
            this.CustomLocationLB.Name = "CustomLocationLB";
            this.CustomLocationLB.Size = new System.Drawing.Size(312, 21);
            this.CustomLocationLB.TabIndex = 8;
            // 
            // DeleteFilesChB
            // 
            this.DeleteFilesChB.AutoSize = true;
            this.DeleteFilesChB.Enabled = false;
            this.DeleteFilesChB.Location = new System.Drawing.Point(271, 20);
            this.DeleteFilesChB.Name = "DeleteFilesChB";
            this.DeleteFilesChB.Size = new System.Drawing.Size(99, 17);
            this.DeleteFilesChB.TabIndex = 7;
            this.DeleteFilesChB.Text = "Also delete files";
            this.MainTT.SetToolTip(this.DeleteFilesChB, "Delete any files in folders marked for deletion. Otherwise, skips the folder dele" +
        "tion. ");
            this.DeleteFilesChB.UseVisualStyleBackColor = true;
            // 
            // CustomLocationBT
            // 
            this.CustomLocationBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomLocationBT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.CustomLocationBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomLocationBT.Image = global::ROMVault.Properties.Resources.folder_horizontal_open;
            this.CustomLocationBT.Location = new System.Drawing.Point(337, 89);
            this.CustomLocationBT.Name = "CustomLocationBT";
            this.CustomLocationBT.Size = new System.Drawing.Size(78, 23);
            this.CustomLocationBT.TabIndex = 5;
            this.CustomLocationBT.Text = " Browse";
            this.CustomLocationBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomLocationBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomLocationBT.UseVisualStyleBackColor = true;
            this.CustomLocationBT.Click += new System.EventHandler(this.CustomLocationBT_Click);
            // 
            // UnderCustomLocationChB
            // 
            this.UnderCustomLocationChB.AutoSize = true;
            this.UnderCustomLocationChB.Location = new System.Drawing.Point(19, 66);
            this.UnderCustomLocationChB.Name = "UnderCustomLocationChB";
            this.UnderCustomLocationChB.Size = new System.Drawing.Size(135, 17);
            this.UnderCustomLocationChB.TabIndex = 2;
            this.UnderCustomLocationChB.Text = "Under custom location:";
            this.UnderCustomLocationChB.UseVisualStyleBackColor = true;
            // 
            // UnderDatsChB
            // 
            this.UnderDatsChB.AutoSize = true;
            this.UnderDatsChB.Location = new System.Drawing.Point(138, 43);
            this.UnderDatsChB.Name = "UnderDatsChB";
            this.UnderDatsChB.Size = new System.Drawing.Size(111, 17);
            this.UnderDatsChB.TabIndex = 1;
            this.UnderDatsChB.Text = "Under DATs Root";
            this.UnderDatsChB.UseVisualStyleBackColor = true;
            // 
            // UnderRomsChB
            // 
            this.UnderRomsChB.AutoSize = true;
            this.UnderRomsChB.Location = new System.Drawing.Point(19, 43);
            this.UnderRomsChB.Name = "UnderRomsChB";
            this.UnderRomsChB.Size = new System.Drawing.Size(114, 17);
            this.UnderRomsChB.TabIndex = 0;
            this.UnderRomsChB.Text = "Under ROMs Root";
            this.UnderRomsChB.UseVisualStyleBackColor = true;
            // 
            // OptionsPaddingPN
            // 
            this.OptionsPaddingPN.AutoSize = true;
            this.OptionsPaddingPN.Controls.Add(this.OptionsGB);
            this.OptionsPaddingPN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsPaddingPN.Location = new System.Drawing.Point(0, 395);
            this.OptionsPaddingPN.Name = "OptionsPaddingPN";
            this.OptionsPaddingPN.Padding = new System.Windows.Forms.Padding(5);
            this.OptionsPaddingPN.Size = new System.Drawing.Size(434, 143);
            this.OptionsPaddingPN.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HideBorders = true;
            this.tabControl1.HideTabs = false;
            this.tabControl1.ItemSize = new System.Drawing.Size(58, 23);
            this.tabControl1.Location = new System.Drawing.Point(0, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedTabColor = System.Drawing.Color.Transparent;
            this.tabControl1.Size = new System.Drawing.Size(434, 287);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 13;
            this.tabControl1.TabOutlineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabControl1.TabPadding = 5;
            this.tabControl1.UnselectedTabBackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FolderPN);
            this.tabPage1.Controls.Add(this.SubFolerPN);
            this.tabPage1.Location = new System.Drawing.Point(0, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Schema Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SubFolerPN
            // 
            this.SubFolerPN.Controls.Add(this.SubFoldersRTB);
            this.SubFolerPN.Controls.Add(this.SubFolderInfoLB);
            this.SubFolerPN.Controls.Add(this.label4);
            this.SubFolerPN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubFolerPN.Location = new System.Drawing.Point(3, 152);
            this.SubFolerPN.MinimumSize = new System.Drawing.Size(0, 50);
            this.SubFolerPN.Name = "SubFolerPN";
            this.SubFolerPN.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.SubFolerPN.Size = new System.Drawing.Size(428, 107);
            this.SubFolerPN.TabIndex = 9;
            // 
            // SubFoldersRTB
            // 
            this.SubFoldersRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubFoldersRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubFoldersRTB.Location = new System.Drawing.Point(5, 22);
            this.SubFoldersRTB.Name = "SubFoldersRTB";
            this.SubFoldersRTB.Size = new System.Drawing.Size(418, 61);
            this.SubFoldersRTB.TabIndex = 6;
            this.SubFoldersRTB.Text = "";
            this.SubFoldersRTB.TextChanged += new System.EventHandler(this.SubFoldersRTB_TextChanged);
            // 
            // SubFolderInfoLB
            // 
            this.SubFolderInfoLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubFolderInfoLB.Image = global::ROMVault.Properties.Resources.information;
            this.SubFolderInfoLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubFolderInfoLB.Location = new System.Drawing.Point(5, 83);
            this.SubFolderInfoLB.Name = "SubFolderInfoLB";
            this.SubFolderInfoLB.Size = new System.Drawing.Size(418, 21);
            this.SubFolderInfoLB.TabIndex = 9;
            this.SubFolderInfoLB.Text = "      Information";
            this.SubFolderInfoLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubFolderInfoLB.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub Folders:";
            // 
            // FolderPN
            // 
            this.FolderPN.Controls.Add(this.FoldersRTB);
            this.FolderPN.Controls.Add(this.FoldersInfoLB);
            this.FolderPN.Controls.Add(this.label3);
            this.FolderPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderPN.Location = new System.Drawing.Point(3, 3);
            this.FolderPN.MinimumSize = new System.Drawing.Size(0, 100);
            this.FolderPN.Name = "FolderPN";
            this.FolderPN.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.FolderPN.Size = new System.Drawing.Size(428, 149);
            this.FolderPN.TabIndex = 8;
            // 
            // FoldersRTB
            // 
            this.FoldersRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoldersRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldersRTB.Location = new System.Drawing.Point(5, 22);
            this.FoldersRTB.Name = "FoldersRTB";
            this.FoldersRTB.Size = new System.Drawing.Size(418, 103);
            this.FoldersRTB.TabIndex = 6;
            this.FoldersRTB.Text = "";
            this.FoldersRTB.TextChanged += new System.EventHandler(this.FoldersRTB_TextChanged);
            // 
            // FoldersInfoLB
            // 
            this.FoldersInfoLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FoldersInfoLB.Image = global::ROMVault.Properties.Resources.information;
            this.FoldersInfoLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoldersInfoLB.Location = new System.Drawing.Point(5, 125);
            this.FoldersInfoLB.Name = "FoldersInfoLB";
            this.FoldersInfoLB.Size = new System.Drawing.Size(418, 21);
            this.FoldersInfoLB.TabIndex = 8;
            this.FoldersInfoLB.Text = "      Information";
            this.FoldersInfoLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoldersInfoLB.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Folders:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LogRTB);
            this.tabPage2.Location = new System.Drawing.Point(0, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LogRTB
            // 
            this.LogRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogRTB.Location = new System.Drawing.Point(3, 3);
            this.LogRTB.Name = "LogRTB";
            this.LogRTB.Size = new System.Drawing.Size(428, 256);
            this.LogRTB.TabIndex = 0;
            this.LogRTB.Text = "";
            this.LogRTB.WordWrap = false;
            // 
            // flexiLabel1
            // 
            this.flexiLabel1.AutoSize = true;
            this.flexiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel1.Font = new System.Drawing.Font("Roboto", 9.900001F, System.Drawing.FontStyle.Bold);
            this.flexiLabel1.Location = new System.Drawing.Point(0, 0);
            this.flexiLabel1.Name = "flexiLabel1";
            this.flexiLabel1.Padding = new System.Windows.Forms.Padding(8);
            this.flexiLabel1.ScaleFactor = 1.2D;
            this.flexiLabel1.Size = new System.Drawing.Size(122, 33);
            this.flexiLabel1.TabIndex = 0;
            this.flexiLabel1.Text = "Folder Wizard";
            // 
            // FrmDirectoryWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 580);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OptionsPaddingPN);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flexiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 619);
            this.Name = "FrmDirectoryWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Folder Wizard";
            this.Load += new System.EventHandler(this.FrmDirectoryWizard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.OptionsGB.ResumeLayout(false);
            this.OptionsGB.PerformLayout();
            this.OptionsPaddingPN.ResumeLayout(false);
            this.OptionsPaddingPN.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.SubFolerPN.ResumeLayout(false);
            this.SubFolerPN.PerformLayout();
            this.FolderPN.ResumeLayout(false);
            this.FolderPN.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.FlexiLabel flexiLabel1;
        private System.Windows.Forms.ComboBox DefaultSchemaDD;
        private System.Windows.Forms.Label label1;
        private UserControls.PathLabel LoadSchemaPathLB;
        private System.Windows.Forms.Button LoadSchemaBT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox FoldersRTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel FolderPN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel SubFolerPN;
        private System.Windows.Forms.RichTextBox SubFoldersRTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button GoBT;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button ValidateBT;
        private System.Windows.Forms.GroupBox OptionsGB;
        private System.Windows.Forms.CheckBox UnderCustomLocationChB;
        private System.Windows.Forms.CheckBox UnderDatsChB;
        private System.Windows.Forms.CheckBox UnderRomsChB;
        private System.Windows.Forms.CheckBox DeleteFilesChB;
        private System.Windows.Forms.Button CustomLocationBT;
        private System.Windows.Forms.Label SchemaInfoLB;
        private System.Windows.Forms.Panel OptionsPaddingPN;
        private System.Windows.Forms.Label FoldersInfoLB;
        private System.Windows.Forms.Label SubFolderInfoLB;
        private System.Windows.Forms.Button SaveAsBT;
        private UserControls.PathLabel CustomLocationLB;
        private System.Windows.Forms.Button TestBT;
        private System.Windows.Forms.CheckBox DeleteFoldersChB;
        private System.Windows.Forms.CheckBox CreateFoldersChB;
        private System.Windows.Forms.ToolTip MainTT;
        private System.Windows.Forms.Label label5;
        private UserControls.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox LogRTB;
    }
}