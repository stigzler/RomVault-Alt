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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDATRoot = new System.Windows.Forms.Label();
            this.btnDAT = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFixLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDebugLogs = new System.Windows.Forms.CheckBox();
            this.chkCacheSaveTimer = new System.Windows.Forms.CheckBox();
            this.upTime = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkDoubleCheckDelete = new System.Windows.Forms.CheckBox();
            this.chkDetailedReporting = new System.Windows.Forms.CheckBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chkSendFoundMIA = new System.Windows.Forms.CheckBox();
            this.chkSendFoundMIAAnon = new System.Windows.Forms.CheckBox();
            this.chkDeleteOldCueFiles = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo7zStruct = new System.Windows.Forms.ComboBox();
            this.cboCores = new System.Windows.Forms.ComboBox();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.chkDoNotReportFeedback = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MainTextSizeNUM = new System.Windows.Forms.NumericUpDown();
            this.InfoTextColorPB = new System.Windows.Forms.PictureBox();
            this.ColorBroswer = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.upTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTextSizeNUM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTextColorPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATRoot:";
            // 
            // lblDATRoot
            // 
            this.lblDATRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDATRoot.BackColor = System.Drawing.Color.White;
            this.lblDATRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDATRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDATRoot.Location = new System.Drawing.Point(85, 30);
            this.lblDATRoot.Name = "lblDATRoot";
            this.lblDATRoot.Size = new System.Drawing.Size(269, 22);
            this.lblDATRoot.TabIndex = 3;
            this.lblDATRoot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDAT
            // 
            this.btnDAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDAT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDAT.Location = new System.Drawing.Point(360, 30);
            this.btnDAT.Name = "btnDAT";
            this.btnDAT.Size = new System.Drawing.Size(44, 24);
            this.btnDAT.TabIndex = 6;
            this.btnDAT.Text = "Set";
            this.btnDAT.UseVisualStyleBackColor = true;
            this.btnDAT.Click += new System.EventHandler(this.BtnDatClick);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(238, 762);
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
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(333, 762);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(9, 166);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(395, 121);
            this.textBox1.TabIndex = 12;
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
            // cboFixLevel
            // 
            this.cboFixLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFixLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFixLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFixLevel.FormattingEnabled = true;
            this.cboFixLevel.Location = new System.Drawing.Point(86, 58);
            this.cboFixLevel.Name = "cboFixLevel";
            this.cboFixLevel.Size = new System.Drawing.Size(318, 21);
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
            // chkCacheSaveTimer
            // 
            this.chkCacheSaveTimer.AutoSize = true;
            this.chkCacheSaveTimer.Location = new System.Drawing.Point(14, 312);
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
            this.upTime.Location = new System.Drawing.Point(174, 310);
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
            this.label5.Location = new System.Drawing.Point(230, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Minutes";
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
            this.chkSendFoundMIAAnon.Location = new System.Drawing.Point(30, 37);
            this.chkSendFoundMIAAnon.Name = "chkSendFoundMIAAnon";
            this.chkSendFoundMIAAnon.Size = new System.Drawing.Size(115, 17);
            this.chkSendFoundMIAAnon.TabIndex = 28;
            this.chkSendFoundMIAAnon.Text = "Send anonymously";
            this.chkSendFoundMIAAnon.UseVisualStyleBackColor = true;
            // 
            // chkDeleteOldCueFiles
            // 
            this.chkDeleteOldCueFiles.AutoSize = true;
            this.chkDeleteOldCueFiles.Location = new System.Drawing.Point(14, 55);
            this.chkDeleteOldCueFiles.Name = "chkDeleteOldCueFiles";
            this.chkDeleteOldCueFiles.Size = new System.Drawing.Size(208, 17);
            this.chkDeleteOldCueFiles.TabIndex = 30;
            this.chkDeleteOldCueFiles.Text = "Delete previous Cue file zips in ToSort ";
            this.chkDeleteOldCueFiles.UseVisualStyleBackColor = true;
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
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.Location = new System.Drawing.Point(14, 45);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(161, 17);
            this.chkDarkMode.TabIndex = 42;
            this.chkDarkMode.Text = "Dark Mode (restart required.)";
            this.chkDarkMode.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 341);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Core Settings";
            // 
            // flexiLabel1
            // 
            this.flexiLabel1.AutoSize = true;
            this.flexiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold);
            this.flexiLabel1.FontStyle = System.Drawing.FontStyle.Bold;
            this.flexiLabel1.Location = new System.Drawing.Point(12, 9);
            this.flexiLabel1.Name = "flexiLabel1";
            this.flexiLabel1.ScaleFactor = 1.2D;
            this.flexiLabel1.Size = new System.Drawing.Size(67, 17);
            this.flexiLabel1.TabIndex = 45;
            this.flexiLabel1.Text = "Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkSendFoundMIA);
            this.groupBox2.Controls.Add(this.chkSendFoundMIAAnon);
            this.groupBox2.Controls.Add(this.chkDeleteOldCueFiles);
            this.groupBox2.Location = new System.Drawing.Point(12, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 81);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DAT Vault";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chkDetailedReporting);
            this.groupBox3.Controls.Add(this.chkDebugLogs);
            this.groupBox3.Controls.Add(this.chkDoNotReportFeedback);
            this.groupBox3.Location = new System.Drawing.Point(12, 473);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 84);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logging";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cbo7zStruct);
            this.groupBox4.Controls.Add(this.cboCores);
            this.groupBox4.Location = new System.Drawing.Point(12, 563);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(410, 81);
            this.groupBox4.TabIndex = 48;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compression";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.MainTextSizeNUM);
            this.groupBox5.Controls.Add(this.InfoTextColorPB);
            this.groupBox5.Controls.Add(this.chkDarkMode);
            this.groupBox5.Location = new System.Drawing.Point(12, 650);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(410, 103);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Appearance and Theme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Main Text Size (restart required)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Info Text Color";
            // 
            // MainTextSizeNUM
            // 
            this.MainTextSizeNUM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainTextSizeNUM.Location = new System.Drawing.Point(14, 19);
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
            // InfoTextColorPB
            // 
            this.InfoTextColorPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoTextColorPB.Location = new System.Drawing.Point(14, 68);
            this.InfoTextColorPB.Name = "InfoTextColorPB";
            this.InfoTextColorPB.Size = new System.Drawing.Size(22, 22);
            this.InfoTextColorPB.TabIndex = 43;
            this.InfoTextColorPB.TabStop = false;
            this.InfoTextColorPB.Click += new System.EventHandler(this.InfoTextColorPB_Click);
            // 
            // ColorBroswer
            // 
            this.ColorBroswer.AnyColor = true;
            this.ColorBroswer.FullOpen = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(434, 794);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flexiLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 833);
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RomVault Settings";
            this.Load += new System.EventHandler(this.FrmConfigLoad);
            ((System.ComponentModel.ISupportInitialize)(this.upTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTextSizeNUM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoTextColorPB)).EndInit();
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
        private System.Windows.Forms.CheckBox chkSendFoundMIA;
        private System.Windows.Forms.CheckBox chkSendFoundMIAAnon;
        private System.Windows.Forms.CheckBox chkDeleteOldCueFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo7zStruct;
        private System.Windows.Forms.ComboBox cboCores;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.CheckBox chkDoNotReportFeedback;
        private System.Windows.Forms.GroupBox groupBox1;
        private UserControls.FlexiLabel flexiLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown MainTextSizeNUM;
        private System.Windows.Forms.PictureBox InfoTextColorPB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog ColorBroswer;
    }
}