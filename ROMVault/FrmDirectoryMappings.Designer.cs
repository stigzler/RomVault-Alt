namespace ROMVault
{
    partial class FrmDirectoryMappings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDirectoryMappings));
            this.DGDirectoryMappingRules = new System.Windows.Forms.DataGridView();
            this.CPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.txtROMLocation = new System.Windows.Forms.Label();
            this.lblROMLocation = new System.Windows.Forms.Label();
            this.txtDATLocation = new System.Windows.Forms.Label();
            this.lblDATLocation = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnClearROMLocation = new System.Windows.Forms.Button();
            this.btnSetROMLocation = new System.Windows.Forms.Button();
            this.btnEditSelected = new System.Windows.Forms.Button();
            this.BottomButtonsPN = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.MappingPN = new System.Windows.Forms.Panel();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flexiLabel2 = new ROMVault.UserControls.FlexiLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DGDirectoryMappingRules)).BeginInit();
            this.BottomButtonsPN.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.MappingPN.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGDirectoryMappingRules
            // 
            this.DGDirectoryMappingRules.AllowUserToAddRows = false;
            this.DGDirectoryMappingRules.AllowUserToDeleteRows = false;
            this.DGDirectoryMappingRules.AllowUserToResizeRows = false;
            this.DGDirectoryMappingRules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGDirectoryMappingRules.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGDirectoryMappingRules.BackgroundColor = System.Drawing.Color.White;
            this.DGDirectoryMappingRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGDirectoryMappingRules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDirectoryMappingRules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPath,
            this.CLocation});
            this.DGDirectoryMappingRules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGDirectoryMappingRules.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGDirectoryMappingRules.Location = new System.Drawing.Point(4, 29);
            this.DGDirectoryMappingRules.Name = "DGDirectoryMappingRules";
            this.DGDirectoryMappingRules.ReadOnly = true;
            this.DGDirectoryMappingRules.RowHeadersVisible = false;
            this.DGDirectoryMappingRules.RowHeadersWidth = 62;
            this.DGDirectoryMappingRules.RowTemplate.Height = 17;
            this.DGDirectoryMappingRules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGDirectoryMappingRules.ShowCellErrors = false;
            this.DGDirectoryMappingRules.ShowCellToolTips = false;
            this.DGDirectoryMappingRules.ShowEditingIcon = false;
            this.DGDirectoryMappingRules.ShowRowErrors = false;
            this.DGDirectoryMappingRules.Size = new System.Drawing.Size(376, 130);
            this.DGDirectoryMappingRules.TabIndex = 10;
            this.DGDirectoryMappingRules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDirectoryMappingRules_CellClick);
            this.DGDirectoryMappingRules.DoubleClick += new System.EventHandler(this.DataGridGamesDoubleClick);
            // 
            // CPath
            // 
            this.CPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPath.HeaderText = "Rule Path";
            this.CPath.MinimumWidth = 8;
            this.CPath.Name = "CPath";
            this.CPath.ReadOnly = true;
            // 
            // CLocation
            // 
            this.CLocation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CLocation.HeaderText = "Dir Location";
            this.CLocation.MinimumWidth = 8;
            this.CLocation.Name = "CLocation";
            this.CLocation.ReadOnly = true;
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSelected.Location = new System.Drawing.Point(105, 3);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(96, 25);
            this.btnDeleteSelected.TabIndex = 11;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.BtnDeleteSelectedClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(246, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 24);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Location = new System.Drawing.Point(311, 70);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(59, 25);
            this.btnSet.TabIndex = 14;
            this.btnSet.Text = "Apply";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnApplyClick);
            // 
            // txtROMLocation
            // 
            this.txtROMLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtROMLocation.BackColor = System.Drawing.Color.White;
            this.txtROMLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtROMLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtROMLocation.Location = new System.Drawing.Point(80, 42);
            this.txtROMLocation.Margin = new System.Windows.Forms.Padding(3);
            this.txtROMLocation.Name = "txtROMLocation";
            this.txtROMLocation.Size = new System.Drawing.Size(220, 22);
            this.txtROMLocation.TabIndex = 13;
            this.txtROMLocation.Text = "label2";
            this.txtROMLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtROMLocation.UseMnemonic = false;
            // 
            // lblROMLocation
            // 
            this.lblROMLocation.AutoSize = true;
            this.lblROMLocation.Location = new System.Drawing.Point(7, 47);
            this.lblROMLocation.Name = "lblROMLocation";
            this.lblROMLocation.Size = new System.Drawing.Size(67, 13);
            this.lblROMLocation.TabIndex = 12;
            this.lblROMLocation.Text = "Dir Location:";
            // 
            // txtDATLocation
            // 
            this.txtDATLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDATLocation.BackColor = System.Drawing.Color.White;
            this.txtDATLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDATLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDATLocation.Location = new System.Drawing.Point(80, 14);
            this.txtDATLocation.Margin = new System.Windows.Forms.Padding(3);
            this.txtDATLocation.Name = "txtDATLocation";
            this.txtDATLocation.Size = new System.Drawing.Size(290, 22);
            this.txtDATLocation.TabIndex = 11;
            this.txtDATLocation.Text = "label2";
            this.txtDATLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtDATLocation.UseMnemonic = false;
            // 
            // lblDATLocation
            // 
            this.lblDATLocation.AutoSize = true;
            this.lblDATLocation.Location = new System.Drawing.Point(17, 23);
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
            this.btnClose.Location = new System.Drawing.Point(285, 3);
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
            this.btnResetAll.Location = new System.Drawing.Point(207, 3);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(96, 25);
            this.btnResetAll.TabIndex = 17;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.BtnResetAllClick);
            // 
            // btnClearROMLocation
            // 
            this.btnClearROMLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearROMLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearROMLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnClearROMLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearROMLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearROMLocation.Image = global::ROMVault.Properties.Resources.cross;
            this.btnClearROMLocation.Location = new System.Drawing.Point(341, 42);
            this.btnClearROMLocation.Name = "btnClearROMLocation";
            this.btnClearROMLocation.Size = new System.Drawing.Size(29, 22);
            this.btnClearROMLocation.TabIndex = 38;
            this.btnClearROMLocation.UseVisualStyleBackColor = true;
            this.btnClearROMLocation.Click += new System.EventHandler(this.btnClearROMLocation_Click);
            // 
            // btnSetROMLocation
            // 
            this.btnSetROMLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetROMLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetROMLocation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnSetROMLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetROMLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetROMLocation.Image = global::ROMVault.Properties.Resources.folder_horizontal_open;
            this.btnSetROMLocation.Location = new System.Drawing.Point(306, 42);
            this.btnSetROMLocation.Name = "btnSetROMLocation";
            this.btnSetROMLocation.Size = new System.Drawing.Size(29, 22);
            this.btnSetROMLocation.TabIndex = 37;
            this.btnSetROMLocation.UseVisualStyleBackColor = true;
            this.btnSetROMLocation.Click += new System.EventHandler(this.BtnSetROMLocationClick);
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditSelected.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btnEditSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSelected.Location = new System.Drawing.Point(3, 3);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(96, 25);
            this.btnEditSelected.TabIndex = 40;
            this.btnEditSelected.Text = "Edit Selected";
            this.btnEditSelected.UseVisualStyleBackColor = true;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // BottomButtonsPN
            // 
            this.BottomButtonsPN.AutoSize = true;
            this.BottomButtonsPN.Controls.Add(this.btnClose);
            this.BottomButtonsPN.Controls.Add(this.button1);
            this.BottomButtonsPN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomButtonsPN.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.BottomButtonsPN.Location = new System.Drawing.Point(0, 330);
            this.BottomButtonsPN.Name = "BottomButtonsPN";
            this.BottomButtonsPN.Size = new System.Drawing.Size(384, 31);
            this.BottomButtonsPN.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(183, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.btnEditSelected);
            this.flowLayoutPanel2.Controls.Add(this.btnDeleteSelected);
            this.flowLayoutPanel2.Controls.Add(this.btnResetAll);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 159);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(376, 31);
            this.flowLayoutPanel2.TabIndex = 42;
            // 
            // MappingPN
            // 
            this.MappingPN.Controls.Add(this.DGDirectoryMappingRules);
            this.MappingPN.Controls.Add(this.flexiLabel1);
            this.MappingPN.Controls.Add(this.flowLayoutPanel2);
            this.MappingPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MappingPN.Location = new System.Drawing.Point(0, 136);
            this.MappingPN.Name = "MappingPN";
            this.MappingPN.Padding = new System.Windows.Forms.Padding(4);
            this.MappingPN.Size = new System.Drawing.Size(384, 194);
            this.MappingPN.TabIndex = 43;
            // 
            // flexiLabel1
            // 
            this.flexiLabel1.AutoSize = true;
            this.flexiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel1.Font = new System.Drawing.Font("Roboto", 9.900001F, System.Drawing.FontStyle.Bold);
            this.flexiLabel1.Location = new System.Drawing.Point(4, 4);
            this.flexiLabel1.Name = "flexiLabel1";
            this.flexiLabel1.Padding = new System.Windows.Forms.Padding(4);
            this.flexiLabel1.ScaleFactor = 1.2D;
            this.flexiLabel1.Size = new System.Drawing.Size(139, 25);
            this.flexiLabel1.TabIndex = 0;
            this.flexiLabel1.Text = "Existing Mapping";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDATLocation);
            this.panel2.Controls.Add(this.txtDATLocation);
            this.panel2.Controls.Add(this.lblROMLocation);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtROMLocation);
            this.panel2.Controls.Add(this.btnSet);
            this.panel2.Controls.Add(this.btnSetROMLocation);
            this.panel2.Controls.Add(this.btnClearROMLocation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 107);
            this.panel2.TabIndex = 44;
            // 
            // flexiLabel2
            // 
            this.flexiLabel2.AutoSize = true;
            this.flexiLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel2.Font = new System.Drawing.Font("Roboto", 9.900001F, System.Drawing.FontStyle.Bold);
            this.flexiLabel2.Location = new System.Drawing.Point(0, 0);
            this.flexiLabel2.Name = "flexiLabel2";
            this.flexiLabel2.Padding = new System.Windows.Forms.Padding(6);
            this.flexiLabel2.ScaleFactor = 1.2D;
            this.flexiLabel2.Size = new System.Drawing.Size(159, 29);
            this.flexiLabel2.TabIndex = 45;
            this.flexiLabel2.Text = "Directory Mappings";
            // 
            // FrmDirectoryMappings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.MappingPN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flexiLabel2);
            this.Controls.Add(this.BottomButtonsPN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "FrmDirectoryMappings";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set ROM Folder Mapping";
            this.Activated += new System.EventHandler(this.FrmSetDirActivated);
            this.Load += new System.EventHandler(this.FrmDirectoryMappings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGDirectoryMappingRules)).EndInit();
            this.BottomButtonsPN.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.MappingPN.ResumeLayout(false);
            this.MappingPN.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGDirectoryMappingRules;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label txtROMLocation;
        private System.Windows.Forms.Label lblROMLocation;
        private System.Windows.Forms.Label txtDATLocation;
        private System.Windows.Forms.Label lblDATLocation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnSetROMLocation;
        private System.Windows.Forms.Button btnClearROMLocation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLocation;
        private System.Windows.Forms.Button btnEditSelected;
        private System.Windows.Forms.FlowLayoutPanel BottomButtonsPN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel MappingPN;
        private UserControls.FlexiLabel flexiLabel1;
        private System.Windows.Forms.Panel panel2;
        private UserControls.FlexiLabel flexiLabel2;
    }
}