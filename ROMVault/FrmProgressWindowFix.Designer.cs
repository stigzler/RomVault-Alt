namespace ROMVault
{
    partial class FrmProgressWindowFix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgressWindowFix));
            this.cancelButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DatTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RomTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROMFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flexiLabel1 = new ROMVault.UserControls.FlexiLabel();
            this.MainTT = new System.Windows.Forms.ToolTip(this.components);
            this.BottomPN = new System.Windows.Forms.Panel();
            this.MainTS = new System.Windows.Forms.ToolStrip();
            this.AutsozeGridBT = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BottomPN.SuspendLayout();
            this.MainTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(290, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(281, 23);
            this.progressBar.TabIndex = 8;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Location = new System.Drawing.Point(4, 29);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(4);
            this.label.Size = new System.Drawing.Size(107, 21);
            this.label.TabIndex = 4;
            this.label.Text = "Starting operation...";
            this.label.UseMnemonic = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatTo,
            this.GameTo,
            this.RomTo,
            this.FileSize,
            this.Status,
            this.DatFrom,
            this.GameFrom,
            this.ROMFrom});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 17;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(376, 178);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.VirtualMode = true;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridView1_CellValueNeeded);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1SelectionChanged);
            // 
            // DatTo
            // 
            this.DatTo.HeaderText = "Directory (Fixing)";
            this.DatTo.Name = "DatTo";
            this.DatTo.ReadOnly = true;
            // 
            // GameTo
            // 
            this.GameTo.HeaderText = "Archive (Fixing)";
            this.GameTo.Name = "GameTo";
            this.GameTo.ReadOnly = true;
            // 
            // RomTo
            // 
            this.RomTo.HeaderText = "File (Fixing)";
            this.RomTo.Name = "RomTo";
            this.RomTo.ReadOnly = true;
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "Size (Fixing)";
            this.FileSize.Name = "FileSize";
            this.FileSize.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // DatFrom
            // 
            this.DatFrom.HeaderText = "Directory (From)";
            this.DatFrom.Name = "DatFrom";
            this.DatFrom.ReadOnly = true;
            // 
            // GameFrom
            // 
            this.GameFrom.HeaderText = "Archive (From)";
            this.GameFrom.Name = "GameFrom";
            this.GameFrom.ReadOnly = true;
            // 
            // ROMFrom
            // 
            this.ROMFrom.HeaderText = "File (From)";
            this.ROMFrom.Name = "ROMFrom";
            this.ROMFrom.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Dat (Fixing)";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Game (Fixing)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ROM (Fixing)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Status";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Dat (From)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Game (From)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Rom (From)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // TopPanel
            // 
            this.TopPanel.AutoSize = true;
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Controls.Add(this.label);
            this.TopPanel.Controls.Add(this.flexiLabel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(4, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(4);
            this.TopPanel.Size = new System.Drawing.Size(376, 83);
            this.TopPanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 29);
            this.panel1.TabIndex = 11;
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
            this.flexiLabel1.Size = new System.Drawing.Size(74, 25);
            this.flexiLabel1.TabIndex = 0;
            this.flexiLabel1.Text = "Fix Files";
            // 
            // BottomPN
            // 
            this.BottomPN.AutoSize = true;
            this.BottomPN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BottomPN.Controls.Add(this.dataGridView1);
            this.BottomPN.Controls.Add(this.MainTS);
            this.BottomPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPN.Location = new System.Drawing.Point(4, 87);
            this.BottomPN.Name = "BottomPN";
            this.BottomPN.Size = new System.Drawing.Size(376, 203);
            this.BottomPN.TabIndex = 12;
            // 
            // MainTS
            // 
            this.MainTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutsozeGridBT});
            this.MainTS.Location = new System.Drawing.Point(0, 0);
            this.MainTS.Name = "MainTS";
            this.MainTS.Size = new System.Drawing.Size(376, 25);
            this.MainTS.TabIndex = 8;
            this.MainTS.Text = "toolStrip1";
            // 
            // AutsozeGridBT
            // 
            this.AutsozeGridBT.CheckOnClick = true;
            this.AutsozeGridBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AutsozeGridBT.Image = global::ROMVault.Properties.Resources.table_join_column;
            this.AutsozeGridBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AutsozeGridBT.Name = "AutsozeGridBT";
            this.AutsozeGridBT.Size = new System.Drawing.Size(23, 22);
            this.AutsozeGridBT.Text = "AutsozeGridBT";
            this.AutsozeGridBT.ToolTipText = "Autosize Columns";
            this.AutsozeGridBT.Click += new System.EventHandler(this.AutsozeGridBT_Click);
            // 
            // FrmProgressWindowFix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 294);
            this.Controls.Add(this.BottomPN);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FrmProgressWindowFix";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fixing Files";
            this.Load += new System.EventHandler(this.FrmProgressWindowFix_Load);
            this.Shown += new System.EventHandler(this.FrmProgressWindowFixShown);
            this.Resize += new System.EventHandler(this.FrmProgressWindowFixResize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.BottomPN.ResumeLayout(false);
            this.BottomPN.PerformLayout();
            this.MainTS.ResumeLayout(false);
            this.MainTS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RomTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROMFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel TopPanel;
        private UserControls.FlexiLabel flexiLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip MainTT;
        private System.Windows.Forms.Panel BottomPN;
        private System.Windows.Forms.ToolStrip MainTS;
        private System.Windows.Forms.ToolStripButton AutsozeGridBT;
    }
}