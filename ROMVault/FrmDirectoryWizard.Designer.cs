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
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.DefaultSchemaDD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadSchemaPathLB = new ROMVault.UserControls.PathLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.FoldersRTB = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FolderPN = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SubFoldersRTB = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CreateUnderRomsChB = new System.Windows.Forms.CheckBox();
            this.CreateUnderDatsChB = new System.Windows.Forms.CheckBox();
            this.CreateInCustomLocationChB = new System.Windows.Forms.CheckBox();
            this.CustomLocationChB = new System.Windows.Forms.TextBox();
            this.DeleteExistingFoldersChB = new System.Windows.Forms.CheckBox();
            this.DoNotDeleteExistingChB = new System.Windows.Forms.CheckBox();
            this.OptionsPaddingPN = new System.Windows.Forms.Panel();
            this.FoldersInfoLB = new System.Windows.Forms.Label();
            this.SubFolderInfoLB = new System.Windows.Forms.Label();
            this.CustomLocationBT = new System.Windows.Forms.Button();
            this.CreateBT = new System.Windows.Forms.Button();
            this.SaveAsBT = new System.Windows.Forms.Button();
            this.ValidateBT = new System.Windows.Forms.Button();
            this.CancelBT = new System.Windows.Forms.Button();
            this.SchemaInfoLB = new System.Windows.Forms.Label();
            this.LoadSchemaBT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.FolderPN.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.OptionsPaddingPN.SuspendLayout();
            this.SuspendLayout();
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
            this.flexiLabel1.Size = new System.Drawing.Size(187, 33);
            this.flexiLabel1.TabIndex = 0;
            this.flexiLabel1.Text = "Folder Creation Wizard";
            // 
            // DefaultSchemaDD
            // 
            this.DefaultSchemaDD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultSchemaDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DefaultSchemaDD.FormattingEnabled = true;
            this.DefaultSchemaDD.Location = new System.Drawing.Point(103, 3);
            this.DefaultSchemaDD.Name = "DefaultSchemaDD";
            this.DefaultSchemaDD.Size = new System.Drawing.Size(321, 21);
            this.DefaultSchemaDD.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Load Schema:";
            // 
            // FoldersRTB
            // 
            this.FoldersRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FoldersRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoldersRTB.Location = new System.Drawing.Point(0, 19);
            this.FoldersRTB.Name = "FoldersRTB";
            this.FoldersRTB.Size = new System.Drawing.Size(434, 173);
            this.FoldersRTB.TabIndex = 6;
            this.FoldersRTB.Text = "";
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
            // FolderPN
            // 
            this.FolderPN.Controls.Add(this.FoldersRTB);
            this.FolderPN.Controls.Add(this.FoldersInfoLB);
            this.FolderPN.Controls.Add(this.label3);
            this.FolderPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FolderPN.Location = new System.Drawing.Point(0, 108);
            this.FolderPN.MinimumSize = new System.Drawing.Size(0, 150);
            this.FolderPN.Name = "FolderPN";
            this.FolderPN.Size = new System.Drawing.Size(434, 213);
            this.FolderPN.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Folders:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SubFoldersRTB);
            this.panel2.Controls.Add(this.SubFolderInfoLB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 321);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 138);
            this.panel2.TabIndex = 9;
            // 
            // SubFoldersRTB
            // 
            this.SubFoldersRTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubFoldersRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubFoldersRTB.Location = new System.Drawing.Point(0, 19);
            this.SubFoldersRTB.Name = "SubFoldersRTB";
            this.SubFoldersRTB.Size = new System.Drawing.Size(434, 98);
            this.SubFoldersRTB.TabIndex = 6;
            this.SubFoldersRTB.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sub Folders:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.CreateBT);
            this.flowLayoutPanel1.Controls.Add(this.SaveAsBT);
            this.flowLayoutPanel1.Controls.Add(this.ValidateBT);
            this.flowLayoutPanel1.Controls.Add(this.CancelBT);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 646);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(434, 35);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.DoNotDeleteExistingChB);
            this.groupBox1.Controls.Add(this.DeleteExistingFoldersChB);
            this.groupBox1.Controls.Add(this.CustomLocationBT);
            this.groupBox1.Controls.Add(this.CustomLocationChB);
            this.groupBox1.Controls.Add(this.CreateInCustomLocationChB);
            this.groupBox1.Controls.Add(this.CreateUnderDatsChB);
            this.groupBox1.Controls.Add(this.CreateUnderRomsChB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(424, 177);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // CreateUnderRomsChB
            // 
            this.CreateUnderRomsChB.AutoSize = true;
            this.CreateUnderRomsChB.Location = new System.Drawing.Point(20, 21);
            this.CreateUnderRomsChB.Name = "CreateUnderRomsChB";
            this.CreateUnderRomsChB.Size = new System.Drawing.Size(146, 17);
            this.CreateUnderRomsChB.TabIndex = 0;
            this.CreateUnderRomsChB.Text = "Create under ROMs Root";
            this.CreateUnderRomsChB.UseVisualStyleBackColor = true;
            // 
            // CreateUnderDatsChB
            // 
            this.CreateUnderDatsChB.AutoSize = true;
            this.CreateUnderDatsChB.Location = new System.Drawing.Point(20, 44);
            this.CreateUnderDatsChB.Name = "CreateUnderDatsChB";
            this.CreateUnderDatsChB.Size = new System.Drawing.Size(143, 17);
            this.CreateUnderDatsChB.TabIndex = 1;
            this.CreateUnderDatsChB.Text = "Create under DATs Root";
            this.CreateUnderDatsChB.UseVisualStyleBackColor = true;
            // 
            // CreateInCustomLocationChB
            // 
            this.CreateInCustomLocationChB.AutoSize = true;
            this.CreateInCustomLocationChB.Location = new System.Drawing.Point(20, 67);
            this.CreateInCustomLocationChB.Name = "CreateInCustomLocationChB";
            this.CreateInCustomLocationChB.Size = new System.Drawing.Size(148, 17);
            this.CreateInCustomLocationChB.TabIndex = 2;
            this.CreateInCustomLocationChB.Text = "Create in custom location:";
            this.CreateInCustomLocationChB.UseVisualStyleBackColor = true;
            // 
            // CustomLocationChB
            // 
            this.CustomLocationChB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomLocationChB.Location = new System.Drawing.Point(38, 90);
            this.CustomLocationChB.Name = "CustomLocationChB";
            this.CustomLocationChB.Size = new System.Drawing.Size(294, 20);
            this.CustomLocationChB.TabIndex = 3;
            // 
            // DeleteExistingFoldersChB
            // 
            this.DeleteExistingFoldersChB.AutoSize = true;
            this.DeleteExistingFoldersChB.Location = new System.Drawing.Point(20, 116);
            this.DeleteExistingFoldersChB.Name = "DeleteExistingFoldersChB";
            this.DeleteExistingFoldersChB.Size = new System.Drawing.Size(198, 17);
            this.DeleteExistingFoldersChB.TabIndex = 6;
            this.DeleteExistingFoldersChB.Text = "Delete existing folders not in schema";
            this.DeleteExistingFoldersChB.UseVisualStyleBackColor = true;
            // 
            // DoNotDeleteExistingChB
            // 
            this.DoNotDeleteExistingChB.AutoSize = true;
            this.DoNotDeleteExistingChB.Location = new System.Drawing.Point(38, 139);
            this.DoNotDeleteExistingChB.Name = "DoNotDeleteExistingChB";
            this.DoNotDeleteExistingChB.Size = new System.Drawing.Size(178, 17);
            this.DoNotDeleteExistingChB.TabIndex = 7;
            this.DoNotDeleteExistingChB.Text = "Do not delete folders with files in";
            this.DoNotDeleteExistingChB.UseVisualStyleBackColor = true;
            // 
            // OptionsPaddingPN
            // 
            this.OptionsPaddingPN.AutoSize = true;
            this.OptionsPaddingPN.Controls.Add(this.groupBox1);
            this.OptionsPaddingPN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OptionsPaddingPN.Location = new System.Drawing.Point(0, 459);
            this.OptionsPaddingPN.Name = "OptionsPaddingPN";
            this.OptionsPaddingPN.Padding = new System.Windows.Forms.Padding(5);
            this.OptionsPaddingPN.Size = new System.Drawing.Size(434, 187);
            this.OptionsPaddingPN.TabIndex = 12;
            // 
            // FoldersInfoLB
            // 
            this.FoldersInfoLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FoldersInfoLB.Image = global::ROMVault.Properties.Resources.information;
            this.FoldersInfoLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FoldersInfoLB.Location = new System.Drawing.Point(0, 192);
            this.FoldersInfoLB.Name = "FoldersInfoLB";
            this.FoldersInfoLB.Size = new System.Drawing.Size(434, 21);
            this.FoldersInfoLB.TabIndex = 8;
            this.FoldersInfoLB.Text = "        Information";
            this.FoldersInfoLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubFolderInfoLB
            // 
            this.SubFolderInfoLB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubFolderInfoLB.Image = global::ROMVault.Properties.Resources.information;
            this.SubFolderInfoLB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubFolderInfoLB.Location = new System.Drawing.Point(0, 117);
            this.SubFolderInfoLB.Name = "SubFolderInfoLB";
            this.SubFolderInfoLB.Size = new System.Drawing.Size(434, 21);
            this.SubFolderInfoLB.TabIndex = 9;
            this.SubFolderInfoLB.Text = "        Information";
            this.SubFolderInfoLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomLocationBT
            // 
            this.CustomLocationBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomLocationBT.Image = global::ROMVault.Properties.Resources.folder_horizontal_open;
            this.CustomLocationBT.Location = new System.Drawing.Point(338, 89);
            this.CustomLocationBT.Name = "CustomLocationBT";
            this.CustomLocationBT.Size = new System.Drawing.Size(78, 23);
            this.CustomLocationBT.TabIndex = 5;
            this.CustomLocationBT.Text = "Browse";
            this.CustomLocationBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomLocationBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CustomLocationBT.UseVisualStyleBackColor = true;
            // 
            // CreateBT
            // 
            this.CreateBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateBT.Image = global::ROMVault.Properties.Resources.folder_smiley;
            this.CreateBT.Location = new System.Drawing.Point(335, 6);
            this.CreateBT.Name = "CreateBT";
            this.CreateBT.Size = new System.Drawing.Size(90, 23);
            this.CreateBT.TabIndex = 5;
            this.CreateBT.Text = "Create";
            this.CreateBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateBT.UseVisualStyleBackColor = true;
            // 
            // SaveAsBT
            // 
            this.SaveAsBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAsBT.Image = global::ROMVault.Properties.Resources.disk;
            this.SaveAsBT.Location = new System.Drawing.Point(239, 6);
            this.SaveAsBT.Name = "SaveAsBT";
            this.SaveAsBT.Size = new System.Drawing.Size(90, 23);
            this.SaveAsBT.TabIndex = 8;
            this.SaveAsBT.Text = "SaveAs";
            this.SaveAsBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveAsBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveAsBT.UseVisualStyleBackColor = true;
            // 
            // ValidateBT
            // 
            this.ValidateBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidateBT.Image = global::ROMVault.Properties.Resources.stamp;
            this.ValidateBT.Location = new System.Drawing.Point(143, 6);
            this.ValidateBT.Name = "ValidateBT";
            this.ValidateBT.Size = new System.Drawing.Size(90, 23);
            this.ValidateBT.TabIndex = 7;
            this.ValidateBT.Text = "Validate";
            this.ValidateBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValidateBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ValidateBT.UseVisualStyleBackColor = true;
            // 
            // CancelBT
            // 
            this.CancelBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBT.Image = global::ROMVault.Properties.Resources.cross;
            this.CancelBT.Location = new System.Drawing.Point(47, 6);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(90, 23);
            this.CancelBT.TabIndex = 6;
            this.CancelBT.Text = "Cancel";
            this.CancelBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CancelBT.UseVisualStyleBackColor = true;
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
            this.SchemaInfoLB.Text = "        Information";
            this.SchemaInfoLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoadSchemaBT
            // 
            this.LoadSchemaBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadSchemaBT.Image = global::ROMVault.Properties.Resources.folder_horizontal_open;
            this.LoadSchemaBT.Location = new System.Drawing.Point(346, 30);
            this.LoadSchemaBT.Name = "LoadSchemaBT";
            this.LoadSchemaBT.Size = new System.Drawing.Size(78, 23);
            this.LoadSchemaBT.TabIndex = 4;
            this.LoadSchemaBT.Text = "Browse";
            this.LoadSchemaBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadSchemaBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoadSchemaBT.UseVisualStyleBackColor = true;
            // 
            // FrmDirectoryWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 681);
            this.Controls.Add(this.FolderPN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OptionsPaddingPN);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flexiLabel1);
            this.MinimumSize = new System.Drawing.Size(450, 720);
            this.Name = "FrmDirectoryWizard";
            this.Text = "Folder Wizard";
            this.Load += new System.EventHandler(this.FrmDirectoryWizard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FolderPN.ResumeLayout(false);
            this.FolderPN.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OptionsPaddingPN.ResumeLayout(false);
            this.OptionsPaddingPN.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox SubFoldersRTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CreateBT;
        private System.Windows.Forms.Button CancelBT;
        private System.Windows.Forms.Button ValidateBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CreateInCustomLocationChB;
        private System.Windows.Forms.CheckBox CreateUnderDatsChB;
        private System.Windows.Forms.CheckBox CreateUnderRomsChB;
        private System.Windows.Forms.CheckBox DoNotDeleteExistingChB;
        private System.Windows.Forms.CheckBox DeleteExistingFoldersChB;
        private System.Windows.Forms.Button CustomLocationBT;
        private System.Windows.Forms.TextBox CustomLocationChB;
        private System.Windows.Forms.Label SchemaInfoLB;
        private System.Windows.Forms.Panel OptionsPaddingPN;
        private System.Windows.Forms.Label FoldersInfoLB;
        private System.Windows.Forms.Label SubFolderInfoLB;
        private System.Windows.Forms.Button SaveAsBT;
    }
}