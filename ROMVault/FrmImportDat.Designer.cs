namespace ROMVault
{
    partial class FrmImportDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportDat));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ImportBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.FileToImportRTB = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileToImportBT = new System.Windows.Forms.Button();
            this.DestinationFolderBT = new System.Windows.Forms.Button();
            this.flowPanelResponsive1 = new ROMVault.UserControls.FlowPanelResponsive();
            this.InfoImagePB = new System.Windows.Forms.PictureBox();
            this.InfoLB = new ROMVault.UserControls.FlexiLabel();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.DestinationFolderLB = new ROMVault.UserControls.PathLabel();
            this.MainTT = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.flowPanelResponsive1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destination Folder:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.ImportBT);
            this.flowLayoutPanel1.Controls.Add(this.CancelBT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 270);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ImportBT
            // 
            this.ImportBT.Enabled = false;
            this.ImportBT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ImportBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportBT.Location = new System.Drawing.Point(343, 3);
            this.ImportBT.Name = "ImportBT";
            this.ImportBT.Size = new System.Drawing.Size(75, 23);
            this.ImportBT.TabIndex = 0;
            this.ImportBT.Text = "Import";
            this.ImportBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ImportBT.UseVisualStyleBackColor = true;
            this.ImportBT.Click += new System.EventHandler(this.ImportBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.CancelBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBT.Location = new System.Drawing.Point(262, 3);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.TabIndex = 1;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBT.UseVisualStyleBackColor = true;
            // 
            // FileToImportRTB
            // 
            this.FileToImportRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileToImportRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileToImportRTB.Location = new System.Drawing.Point(24, 137);
            this.FileToImportRTB.Name = "FileToImportRTB";
            this.FileToImportRTB.ReadOnly = true;
            this.FileToImportRTB.Size = new System.Drawing.Size(385, 89);
            this.FileToImportRTB.TabIndex = 5;
            this.FileToImportRTB.Text = "";
            this.FileToImportRTB.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File/s To Import:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FileToImportBT
            // 
            this.FileToImportBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FileToImportBT.AutoSize = true;
            this.FileToImportBT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.FileToImportBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileToImportBT.Image = global::ROMVault.Properties.Resources.folder_horizontal_open;
            this.FileToImportBT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FileToImportBT.Location = new System.Drawing.Point(333, 232);
            this.FileToImportBT.Name = "FileToImportBT";
            this.FileToImportBT.Size = new System.Drawing.Size(76, 25);
            this.FileToImportBT.TabIndex = 8;
            this.FileToImportBT.Text = "Browse";
            this.FileToImportBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FileToImportBT.UseVisualStyleBackColor = true;
            this.FileToImportBT.Click += new System.EventHandler(this.FileToImportBT_Click);
            // 
            // DestinationFolderBT
            // 
            this.DestinationFolderBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationFolderBT.AutoSize = true;
            this.DestinationFolderBT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DestinationFolderBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DestinationFolderBT.Image = global::ROMVault.Properties.Resources.folder_horizontal_open;
            this.DestinationFolderBT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DestinationFolderBT.Location = new System.Drawing.Point(333, 78);
            this.DestinationFolderBT.Name = "DestinationFolderBT";
            this.DestinationFolderBT.Size = new System.Drawing.Size(76, 25);
            this.DestinationFolderBT.TabIndex = 4;
            this.DestinationFolderBT.Text = "Browse";
            this.DestinationFolderBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DestinationFolderBT.UseVisualStyleBackColor = true;
            this.DestinationFolderBT.Click += new System.EventHandler(this.DestinationFolderBT_Click);
            // 
            // flowPanelResponsive1
            // 
            this.flowPanelResponsive1.AutoSize = true;
            this.flowPanelResponsive1.Controls.Add(this.InfoImagePB);
            this.flowPanelResponsive1.Controls.Add(this.InfoLB);
            this.flowPanelResponsive1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanelResponsive1.Location = new System.Drawing.Point(0, 33);
            this.flowPanelResponsive1.Name = "flowPanelResponsive1";
            this.flowPanelResponsive1.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.flowPanelResponsive1.Size = new System.Drawing.Size(421, 28);
            this.flowPanelResponsive1.TabIndex = 7;
            this.flowPanelResponsive1.WrapContents = false;
            // 
            // InfoImagePB
            // 
            this.InfoImagePB.Image = global::ROMVault.Properties.Resources.information;
            this.InfoImagePB.Location = new System.Drawing.Point(17, 3);
            this.InfoImagePB.Name = "InfoImagePB";
            this.InfoImagePB.Size = new System.Drawing.Size(22, 22);
            this.InfoImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.InfoImagePB.TabIndex = 8;
            this.InfoImagePB.TabStop = false;
            // 
            // InfoLB
            // 
            this.InfoLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InfoLB.AutoSize = true;
            this.InfoLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.InfoLB.Location = new System.Drawing.Point(45, 7);
            this.InfoLB.Name = "InfoLB";
            this.InfoLB.ScaleFactor = 1D;
            this.InfoLB.Size = new System.Drawing.Size(373, 13);
            this.InfoLB.TabIndex = 9;
            this.InfoLB.Text = "Please choose your destinaiton folder and files";
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
            this.flexiLabel1.Size = new System.Drawing.Size(243, 33);
            this.flexiLabel1.TabIndex = 3;
            this.flexiLabel1.Text = "Import Dat/s to Specific Folder";
            // 
            // DestinationFolderLB
            // 
            this.DestinationFolderLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationFolderLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationFolderLB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DestinationFolderLB.Location = new System.Drawing.Point(24, 78);
            this.DestinationFolderLB.Name = "DestinationFolderLB";
            this.DestinationFolderLB.Size = new System.Drawing.Size(303, 25);
            this.DestinationFolderLB.TabIndex = 1;
            // 
            // FrmImportDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 299);
            this.Controls.Add(this.FileToImportBT);
            this.Controls.Add(this.flowPanelResponsive1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FileToImportRTB);
            this.Controls.Add(this.DestinationFolderBT);
            this.Controls.Add(this.flexiLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DestinationFolderLB);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(437, 338);
            this.Name = "FrmImportDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Dat/s";
            this.Load += new System.EventHandler(this.FrmImportDat_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowPanelResponsive1.ResumeLayout(false);
            this.flowPanelResponsive1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoImagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UserControls.PathLabel DestinationFolderLB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ImportBT;
        private System.Windows.Forms.Button CancelBT;
        private UserControls.FlexiLabel flexiLabel1;
        private System.Windows.Forms.Button DestinationFolderBT;
        private System.Windows.Forms.RichTextBox FileToImportRTB;
        private System.Windows.Forms.Label label2;
        private UserControls.FlowPanelResponsive flowPanelResponsive1;
        private System.Windows.Forms.PictureBox InfoImagePB;
        private UserControls.FlexiLabel InfoLB;
        private System.Windows.Forms.Button FileToImportBT;
        private System.Windows.Forms.ToolTip MainTT;
    }
}