namespace ROMVault
{
    partial class FrmProgressWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgressWindow));
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl2Prog = new System.Windows.Forms.Label();
            this.ErrorGrid = new System.Windows.Forms.DataGridView();
            this.CError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CErrorFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPN = new System.Windows.Forms.Panel();
            this.BottomPbPN = new System.Windows.Forms.Panel();
            this.ProgressBarAndButtonPN = new System.Windows.Forms.Panel();
            this.TopRowPN = new System.Windows.Forms.Panel();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGrid)).BeginInit();
            this.TopPN.SuspendLayout();
            this.BottomPbPN.SuspendLayout();
            this.ProgressBarAndButtonPN.SuspendLayout();
            this.TopRowPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(6, 8);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(496, 19);
            this.progressBar2.TabIndex = 3;
            this.progressBar2.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(8, 9);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(403, 18);
            this.progressBar.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoEllipsis = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Location = new System.Drawing.Point(2, 2);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(2);
            this.label.Size = new System.Drawing.Size(426, 22);
            this.label.TabIndex = 0;
            this.label.Text = "Starting operation...";
            this.label.UseMnemonic = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(417, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 25);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(510, 22);
            this.label2.TabIndex = 4;
            this.label2.UseMnemonic = false;
            this.label2.Visible = false;
            // 
            // lbl2Prog
            // 
            this.lbl2Prog.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl2Prog.Location = new System.Drawing.Point(428, 2);
            this.lbl2Prog.Name = "lbl2Prog";
            this.lbl2Prog.Padding = new System.Windows.Forms.Padding(2);
            this.lbl2Prog.Size = new System.Drawing.Size(80, 22);
            this.lbl2Prog.TabIndex = 5;
            this.lbl2Prog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl2Prog.Visible = false;
            // 
            // ErrorGrid
            // 
            this.ErrorGrid.AllowUserToAddRows = false;
            this.ErrorGrid.AllowUserToDeleteRows = false;
            this.ErrorGrid.AllowUserToResizeRows = false;
            this.ErrorGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ErrorGrid.BackgroundColor = System.Drawing.Color.White;
            this.ErrorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ErrorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CError,
            this.CErrorFile});
            this.ErrorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ErrorGrid.Location = new System.Drawing.Point(2, 177);
            this.ErrorGrid.MultiSelect = false;
            this.ErrorGrid.Name = "ErrorGrid";
            this.ErrorGrid.ReadOnly = true;
            this.ErrorGrid.RowHeadersVisible = false;
            this.ErrorGrid.RowTemplate.Height = 17;
            this.ErrorGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ErrorGrid.ShowCellErrors = false;
            this.ErrorGrid.ShowCellToolTips = false;
            this.ErrorGrid.ShowEditingIcon = false;
            this.ErrorGrid.ShowRowErrors = false;
            this.ErrorGrid.Size = new System.Drawing.Size(518, 0);
            this.ErrorGrid.TabIndex = 6;
            this.ErrorGrid.SelectionChanged += new System.EventHandler(this.ErrorGridSelectionChanged);
            // 
            // CError
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CError.DefaultCellStyle = dataGridViewCellStyle1;
            this.CError.HeaderText = "Error";
            this.CError.Name = "CError";
            this.CError.ReadOnly = true;
            this.CError.Width = 200;
            // 
            // CErrorFile
            // 
            this.CErrorFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CErrorFile.HeaderText = "Error Filename";
            this.CErrorFile.Name = "CErrorFile";
            this.CErrorFile.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(510, 22);
            this.label3.TabIndex = 6;
            this.label3.UseMnemonic = false;
            // 
            // TopPN
            // 
            this.TopPN.AutoSize = true;
            this.TopPN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopPN.Controls.Add(this.BottomPbPN);
            this.TopPN.Controls.Add(this.ProgressBarAndButtonPN);
            this.TopPN.Controls.Add(this.label3);
            this.TopPN.Controls.Add(this.label2);
            this.TopPN.Controls.Add(this.TopRowPN);
            this.TopPN.Controls.Add(this.flexiLabel1);
            this.TopPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPN.Location = new System.Drawing.Point(2, 2);
            this.TopPN.Name = "TopPN";
            this.TopPN.Padding = new System.Windows.Forms.Padding(4);
            this.TopPN.Size = new System.Drawing.Size(518, 175);
            this.TopPN.TabIndex = 7;
            // 
            // BottomPbPN
            // 
            this.BottomPbPN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomPbPN.Controls.Add(this.progressBar);
            this.BottomPbPN.Controls.Add(this.cancelButton);
            this.BottomPbPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.BottomPbPN.Location = new System.Drawing.Point(4, 132);
            this.BottomPbPN.Name = "BottomPbPN";
            this.BottomPbPN.Padding = new System.Windows.Forms.Padding(2);
            this.BottomPbPN.Size = new System.Drawing.Size(510, 39);
            this.BottomPbPN.TabIndex = 8;
            // 
            // ProgressBarAndButtonPN
            // 
            this.ProgressBarAndButtonPN.Controls.Add(this.progressBar2);
            this.ProgressBarAndButtonPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProgressBarAndButtonPN.Location = new System.Drawing.Point(4, 99);
            this.ProgressBarAndButtonPN.Name = "ProgressBarAndButtonPN";
            this.ProgressBarAndButtonPN.Size = new System.Drawing.Size(510, 33);
            this.ProgressBarAndButtonPN.TabIndex = 9;
            // 
            // TopRowPN
            // 
            this.TopRowPN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TopRowPN.Controls.Add(this.label);
            this.TopRowPN.Controls.Add(this.lbl2Prog);
            this.TopRowPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopRowPN.Location = new System.Drawing.Point(4, 29);
            this.TopRowPN.Name = "TopRowPN";
            this.TopRowPN.Padding = new System.Windows.Forms.Padding(2);
            this.TopRowPN.Size = new System.Drawing.Size(510, 26);
            this.TopRowPN.TabIndex = 2;
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
            this.flexiLabel1.Size = new System.Drawing.Size(80, 25);
            this.flexiLabel1.TabIndex = 1;
            this.flexiLabel1.Text = "Progress";
            // 
            // FrmProgressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(522, 178);
            this.ControlBox = false;
            this.Controls.Add(this.ErrorGrid);
            this.Controls.Add(this.TopPN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "FrmProgressWindow";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RomVault Progress";
            this.Load += new System.EventHandler(this.FrmProgressWindow_Load);
            this.Shown += new System.EventHandler(this.FrmProgressWindowNewShown);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorGrid)).EndInit();
            this.TopPN.ResumeLayout(false);
            this.TopPN.PerformLayout();
            this.BottomPbPN.ResumeLayout(false);
            this.ProgressBarAndButtonPN.ResumeLayout(false);
            this.TopRowPN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl2Prog;
        private System.Windows.Forms.DataGridView ErrorGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CError;
        private System.Windows.Forms.DataGridViewTextBoxColumn CErrorFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel TopPN;
        private System.Windows.Forms.Panel TopRowPN;
        private UserControls.FlexiLabel flexiLabel1;
        private System.Windows.Forms.Panel BottomPbPN;
        private System.Windows.Forms.Panel ProgressBarAndButtonPN;
    }
}