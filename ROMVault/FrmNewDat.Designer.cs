namespace ROMVault
{
    partial class FrmNewDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewDat));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddBT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FilenameTB = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoryTB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.AddBT);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 243);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 37);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AddBT
            // 
            this.AddBT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AddBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBT.Image = global::ROMVault.Properties.Resources.plus;
            this.AddBT.Location = new System.Drawing.Point(169, 7);
            this.AddBT.Name = "AddBT";
            this.AddBT.Size = new System.Drawing.Size(85, 23);
            this.AddBT.TabIndex = 1;
            this.AddBT.Text = "Add";
            this.AddBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBT.UseVisualStyleBackColor = true;
            this.AddBT.Click += new System.EventHandler(this.AddBT_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ROMVault.Properties.Resources.cross;
            this.button1.Location = new System.Drawing.Point(78, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FilenameTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(265, 29);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = ".dat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filename:";
            // 
            // FilenameTB
            // 
            this.FilenameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilenameTB.Location = new System.Drawing.Point(61, 4);
            this.FilenameTB.Name = "FilenameTB";
            this.FilenameTB.Size = new System.Drawing.Size(168, 20);
            this.FilenameTB.TabIndex = 0;
            this.FilenameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilenameTB_KeyDown);
            this.FilenameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilenameTB_KeyPress);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NameTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 83);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(265, 29);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // NameTB
            // 
            this.NameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTB.Location = new System.Drawing.Point(61, 4);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(199, 20);
            this.NameTB.TabIndex = 0;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ErrorLabel.Image = global::ROMVault.Properties.Resources.exclamation_red;
            this.ErrorLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrorLabel.Location = new System.Drawing.Point(0, 62);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Padding = new System.Windows.Forms.Padding(4);
            this.ErrorLabel.Size = new System.Drawing.Size(185, 21);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "       File already exisits in DAT folder";
            this.ErrorLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description:";
            // 
            // DescriptionRTB
            // 
            this.DescriptionRTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionRTB.Location = new System.Drawing.Point(12, 160);
            this.DescriptionRTB.Name = "DescriptionRTB";
            this.DescriptionRTB.Size = new System.Drawing.Size(241, 77);
            this.DescriptionRTB.TabIndex = 6;
            this.DescriptionRTB.Text = "";
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
            this.flexiLabel1.Size = new System.Drawing.Size(145, 33);
            this.flexiLabel1.TabIndex = 0;
            this.flexiLabel1.Text = "Add New Dat File";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.CategoryTB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 112);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(265, 29);
            this.panel3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category:";
            // 
            // CategoryTB
            // 
            this.CategoryTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryTB.Location = new System.Drawing.Point(61, 4);
            this.CategoryTB.Name = "CategoryTB";
            this.CategoryTB.Size = new System.Drawing.Size(199, 20);
            this.CategoryTB.TabIndex = 0;
            this.CategoryTB.Text = "Custom";
            // 
            // FrmNewDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 280);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DescriptionRTB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flexiLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(281, 319);
            this.Name = "FrmNewDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Dat File";
            this.Load += new System.EventHandler(this.FrmNewDat_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.FlexiLabel flexiLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button AddBT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilenameTB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox DescriptionRTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CategoryTB;
    }
}