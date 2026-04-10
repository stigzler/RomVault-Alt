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
            this.label1 = new System.Windows.Forms.Label();
            this.DestinationFolderTB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.DestinationFolderBT = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowPanelResponsive1 = new ROMVault.UserControls.FlowPanelResponsive();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flexiLabel2 = new ROMVault.UserControls.FlexiLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowPanelResponsive1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // DestinationFolderTB
            // 
            this.DestinationFolderTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationFolderTB.Location = new System.Drawing.Point(24, 78);
            this.DestinationFolderTB.Name = "DestinationFolderTB";
            this.DestinationFolderTB.ReadOnly = true;
            this.DestinationFolderTB.Size = new System.Drawing.Size(303, 20);
            this.DestinationFolderTB.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 270);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(343, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(262, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flexiLabel1
            // 
            this.flexiLabel1.AutoSize = true;
            this.flexiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexiLabel1.Location = new System.Drawing.Point(0, 0);
            this.flexiLabel1.Name = "flexiLabel1";
            this.flexiLabel1.Padding = new System.Windows.Forms.Padding(8);
            this.flexiLabel1.ScaleFactor = 1.2D;
            this.flexiLabel1.Size = new System.Drawing.Size(226, 31);
            this.flexiLabel1.TabIndex = 3;
            this.flexiLabel1.Text = "Import Dat/s to Specific Folder";
            // 
            // DestinationFolderBT
            // 
            this.DestinationFolderBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationFolderBT.Image = global::ROMVault.Properties.Resources.folder_horizontal_open;
            this.DestinationFolderBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DestinationFolderBT.Location = new System.Drawing.Point(333, 78);
            this.DestinationFolderBT.Name = "DestinationFolderBT";
            this.DestinationFolderBT.Size = new System.Drawing.Size(76, 23);
            this.DestinationFolderBT.TabIndex = 4;
            this.DestinationFolderBT.Text = "Browse";
            this.DestinationFolderBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DestinationFolderBT.UseVisualStyleBackColor = true;
            this.DestinationFolderBT.Click += new System.EventHandler(this.DestinationFolderBT_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(24, 117);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(385, 116);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File/s To Import:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // flowPanelResponsive1
            // 
            this.flowPanelResponsive1.AutoSize = true;
            this.flowPanelResponsive1.Controls.Add(this.pictureBox1);
            this.flowPanelResponsive1.Controls.Add(this.flexiLabel2);
            this.flowPanelResponsive1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowPanelResponsive1.Location = new System.Drawing.Point(0, 31);
            this.flowPanelResponsive1.Name = "flowPanelResponsive1";
            this.flowPanelResponsive1.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.flowPanelResponsive1.Size = new System.Drawing.Size(421, 28);
            this.flowPanelResponsive1.TabIndex = 7;
            this.flowPanelResponsive1.WrapContents = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ROMVault.Properties.Resources.information_frame;
            this.pictureBox1.Location = new System.Drawing.Point(17, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // flexiLabel2
            // 
            this.flexiLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flexiLabel2.AutoSize = true;
            this.flexiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flexiLabel2.Location = new System.Drawing.Point(45, 7);
            this.flexiLabel2.Name = "flexiLabel2";
            this.flexiLabel2.ScaleFactor = 1D;
            this.flexiLabel2.Size = new System.Drawing.Size(373, 13);
            this.flexiLabel2.TabIndex = 9;
            this.flexiLabel2.Text = "Please choose your destinaiton folder and files";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = global::ROMVault.Properties.Resources.folder_horizontal_open;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(333, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Browse";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FrmImportDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 299);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.flowPanelResponsive1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.DestinationFolderBT);
            this.Controls.Add(this.flexiLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.DestinationFolderTB);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(437, 338);
            this.Name = "FrmImportDat";
            this.Text = "Import Dat/s";
            this.Load += new System.EventHandler(this.FrmImportDat_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowPanelResponsive1.ResumeLayout(false);
            this.flowPanelResponsive1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DestinationFolderTB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControls.FlexiLabel flexiLabel1;
        private System.Windows.Forms.Button DestinationFolderBT;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private UserControls.FlowPanelResponsive flowPanelResponsive1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.FlexiLabel flexiLabel2;
        private System.Windows.Forms.Button button3;
    }
}