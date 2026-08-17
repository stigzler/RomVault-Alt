namespace ROMVault
{
    partial class FrmHelpAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHelpAbout));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogoPN = new System.Windows.Forms.Panel();
            this.label1 = new ROMVault.UserControls.FlexiLabel();
            this.lblVersion = new ROMVault.UserControls.FlexiLabel();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.flexiLabel3 = new ROMVault.UserControls.FlexiLabel();
            this.flexiLabel4 = new ROMVault.UserControls.FlexiLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogoPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(10, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(8);
            this.pictureBox2.Size = new System.Drawing.Size(310, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Size = new System.Drawing.Size(292, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // LogoPN
            // 
            this.LogoPN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(38)))), ((int)(((byte)(82)))), ((int)(((byte)(126)))));
            this.LogoPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoPN.Controls.Add(this.pictureBox1);
            this.LogoPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPN.Location = new System.Drawing.Point(10, 10);
            this.LogoPN.Name = "LogoPN";
            this.LogoPN.Padding = new System.Windows.Forms.Padding(8);
            this.LogoPN.Size = new System.Drawing.Size(310, 100);
            this.LogoPN.TabIndex = 16;
            this.LogoPN.Tag = "override";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.900001F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(10, 168);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8);
            this.label1.ScaleFactor = 1.2D;
            this.label1.Size = new System.Drawing.Size(310, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "www.romvault.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVersion.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVersion.Location = new System.Drawing.Point(10, 110);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Padding = new System.Windows.Forms.Padding(8);
            this.lblVersion.ScaleFactor = 1D;
            this.lblVersion.Size = new System.Drawing.Size(310, 29);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "label1";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flexiLabel1
            // 
            this.flexiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel1.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.flexiLabel1.Location = new System.Drawing.Point(10, 139);
            this.flexiLabel1.Name = "flexiLabel1";
            this.flexiLabel1.Padding = new System.Windows.Forms.Padding(8);
            this.flexiLabel1.ScaleFactor = 1D;
            this.flexiLabel1.Size = new System.Drawing.Size(310, 29);
            this.flexiLabel1.TabIndex = 17;
            this.flexiLabel1.Text = "An extension of the fantastic original RomVault App";
            this.flexiLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flexiLabel3
            // 
            this.flexiLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel3.Font = new System.Drawing.Font("Roboto", 8.25F);
            this.flexiLabel3.Location = new System.Drawing.Point(10, 234);
            this.flexiLabel3.Name = "flexiLabel3";
            this.flexiLabel3.Padding = new System.Windows.Forms.Padding(8);
            this.flexiLabel3.ScaleFactor = 1D;
            this.flexiLabel3.Size = new System.Drawing.Size(310, 29);
            this.flexiLabel3.TabIndex = 19;
            this.flexiLabel3.Text = "Donate to the original project:";
            this.flexiLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flexiLabel4
            // 
            this.flexiLabel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flexiLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.flexiLabel4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flexiLabel4.ForeColor = System.Drawing.Color.Blue;
            this.flexiLabel4.Location = new System.Drawing.Point(10, 201);
            this.flexiLabel4.Name = "flexiLabel4";
            this.flexiLabel4.Padding = new System.Windows.Forms.Padding(8);
            this.flexiLabel4.ScaleFactor = 1.2D;
            this.flexiLabel4.Size = new System.Drawing.Size(310, 33);
            this.flexiLabel4.TabIndex = 20;
            this.flexiLabel4.Text = "RomVault-Alt Github";
            this.flexiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.flexiLabel4.Click += new System.EventHandler(this.flexiLabel4_Click);
            // 
            // FrmHelpAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(330, 326);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flexiLabel3);
            this.Controls.Add(this.flexiLabel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flexiLabel1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.LogoPN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(346, 335);
            this.Name = "FrmHelpAbout";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.FrmHelpAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogoPN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.FlexiLabel lblVersion;
        private UserControls.FlexiLabel label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LogoPN;
        private UserControls.FlexiLabel flexiLabel1;
        private UserControls.FlexiLabel flexiLabel3;
        private UserControls.FlexiLabel flexiLabel4;
    }
}
