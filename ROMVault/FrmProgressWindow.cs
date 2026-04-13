/******************************************************
 *     ROMVault3 is written by Gordon J.              *
 *     Contact gordon@romvault.com                    *
 *     Copyright 2025                                 *
 ******************************************************/

using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using RomVaultCore;

namespace ROMVault
{
    public delegate void Finished();

    public partial class FrmProgressWindow : Form
    {
        private readonly string _titleRoot;
        private readonly Form _parentForm;
        private bool _errorOpen;
        private bool _bDone;
        public bool Cancelled;
        public bool ShowTimeLog = false;

        private readonly ThreadWorker _thWrk;
        private readonly Finished _funcFinished;

        private DateTime _dateTime;
        private DateTime _dateTimeLast;
        private string _lastMessage;

        // UI update throttling
        private volatile bool _updatePending = false;

        private object _latestUpdate = null;
        private readonly object _updateLock = new object();

        public FrmProgressWindow(Form parentForm, string titleRoot, WorkerStart function, Finished funcFinished)
        {
            Cancelled = false;
            _parentForm = parentForm;
            _titleRoot = titleRoot;
            _funcFinished = funcFinished;
            InitializeComponent();

            Type dgvType = ErrorGrid.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(ErrorGrid, true, null);

            ErrorGrid.Visible = false;
            ClientSize = new Size(this.Width, TopPN.Height + 10);
            _dateTime = DateTime.Now;
            _dateTimeLast = _dateTime;

            _titleRoot = titleRoot;
            _lastMessage = "Initializing";

            _thWrk = new ThreadWorker(function);
        }

        public void HideCancelButton()
        {
            cancelButton.Text = "Close";
            cancelButton.Enabled = false;
        }

        private void FrmProgressWindowNewShown(object sender, EventArgs e)
        {
            SetDataGridSize();
            _thWrk.wReport = BgwProgressChanged;
            _thWrk.wFinal = BgwRunWorkerCompleted;
            _thWrk.StartAsync();
        }

        private void TimeLogShow(string message)
        {
            if (!_errorOpen)
            {
                _errorOpen = true;
                ErrorGrid.Visible = true;
                Size newSize = new Size(this.Size.Width, this.Size.Height * 2);
                this.AutoSize = false;
                this.Size = newSize;
                ErrorGrid.Columns[0].HeaderText = "Time";
                ErrorGrid.Columns[1].HeaderText = "Log";
            }

            ErrorGrid.Rows.Add();
            int row = ErrorGrid.Rows.Count - 1;

            DateTime dtNow = DateTime.Now;
            string total = Math.Round((dtNow - _dateTime).TotalSeconds, 3).ToString();
            string part = Math.Round((dtNow - _dateTimeLast).TotalSeconds, 3).ToString();
            _dateTimeLast = dtNow;
            ErrorGrid.Rows[row].Cells["CError"].Value = $"{total} s  ,  ({part} s)";

            ErrorGrid.Rows[row].Cells["CErrorFile"].Value = $"Completed: {_lastMessage}";
            _lastMessage = message;

            if (row >= 0)
            {
                ErrorGrid.FirstDisplayedScrollingRowIndex = row;
            }
        }

        private void BgwProgressChanged(object obj)
        {
            if (InvokeRequired)
            {
                lock (_updateLock)
                {
                    // Check if current object is important
                    bool isImportant = (obj is bgwText txt &&
                                       (txt.Text.Contains("Complete") || txt.Text.Contains("Finished")))
                                    || (obj is int progress && progress >= 100);

                    // Check if stored update is important
                    bool storedIsImportant = (_latestUpdate is bgwText txt2 &&
                                     (txt2.Text.Contains("Complete") || txt2.Text.Contains("Finished")))
                                  || (_latestUpdate is int progress2 && progress2 >= 100);

                    // Don't overwrite important messages with non-important ones
                    if (!isImportant && storedIsImportant)
                        return;

                    _latestUpdate = obj;

                    if (!isImportant && _updatePending)
                        return; // Skip if update already queued

                    _updatePending = true;
                }

                BeginInvoke(new MethodInvoker(() =>
                {
                    object updateToProcess;
                    lock (_updateLock)
                    {
                        updateToProcess = _latestUpdate;
                        _updatePending = false;
                    }
                    BgwProgressChanged(updateToProcess);
                }));
                return;
            }

            // Now on UI thread - process the update
            if (obj is int e)
            {
                if (e >= progressBar.Minimum && e <= progressBar.Maximum)
                {
                    progressBar.Value = e;
                }
                UpdateStatusText();
                return;
            }

            if (obj is bgwText bgwT)
            {
                label.Text = bgwT.Text;
                if (ShowTimeLog)
                    TimeLogShow(bgwT.Text);
                return;
            }

            if (obj is bgwSetRange bgwSr)
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = bgwSr.MaxVal >= 0 ? bgwSr.MaxVal : 0;
                progressBar.Value = 0;
                UpdateStatusText();
                return;
            }

            if (obj is bgwText2 bgwT2)
            {
                label2.Text = bgwT2.Text;
                return;
            }

            if (obj is bgwValue2 bgwV2)
            {
                if (bgwV2.Value >= progressBar2.Minimum && bgwV2.Value <= progressBar2.Maximum)
                {
                    progressBar2.Value = bgwV2.Value;
                }
                UpdateStatusText2();
                return;
            }

            if (obj is bgwSetRange2 bgwSr2)
            {
                progressBar2.Minimum = 0;
                progressBar2.Maximum = bgwSr2.MaxVal >= 0 ? bgwSr2.MaxVal : 0;
                progressBar2.Value = 0;
                UpdateStatusText2();
                return;
            }

            if (obj is bgwRange2Visible bgwR2V)
            {
                label2.Visible = bgwR2V.Visible;
                progressBar2.Visible = bgwR2V.Visible;
                lbl2Prog.Visible = bgwR2V.Visible;
                return;
            }

            if (obj is bgwText3 bgwT3)
            {
                label3.Text = bgwT3.Text;
                return;
            }

            if (obj is bgwShowError bgwSE)
            {
                if (!_errorOpen)
                {
                    _errorOpen = true;
                    ErrorGrid.Visible = true;
                    ClientSize = new Size(this.Width, this.Height * 2);
                }

                ErrorGrid.Rows.Add();
                int row = ErrorGrid.Rows.Count - 1;

                ErrorGrid.Rows[row].Cells["CError"].Value = bgwSE.error;
                ErrorGrid.Rows[row].Cells["CError"].Style.ForeColor = Color.FromArgb(255, 0, 0);

                ErrorGrid.Rows[row].Cells["CErrorFile"].Value = bgwSE.filename;
                ErrorGrid.Rows[row].Cells["CErrorFile"].Style.ForeColor = Color.FromArgb(255, 0, 0);

                RVPlayer.PlaySound("audio\\error.wav");

                if (row >= 0)
                {
                    ErrorGrid.FirstDisplayedScrollingRowIndex = row;
                }
            }
        }

        private void UpdateStatusText()
        {
            int range = progressBar.Maximum - progressBar.Minimum;
            int percent = range > 0 ? progressBar.Value * 100 / range : 0;

            Text = $"{_titleRoot} - {percent}% complete";
        }

        private void UpdateStatusText2()
        {
            lbl2Prog.Text = progressBar2.Maximum > 0 ? $"{progressBar2.Value}/{progressBar2.Maximum}" : "";
        }

        private void BgwRunWorkerCompleted()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(BgwRunWorkerCompleted));
                return;
            }

            // Flush any pending update BEFORE showing completion
            lock (_updateLock)
            {
                if (_latestUpdate != null)
                {
                    BgwProgressChanged(_latestUpdate);
                    _latestUpdate = null;
                }
            }

            // Explicitly set progress to 100%
            progressBar.Value = progressBar.Maximum;
            UpdateStatusText(); // This will now show "100% complete"

            // Handle cleanup that comes after completion messages
            label2.Text = "";
            label2.Visible = false;
            progressBar2.Visible = false;
            lbl2Prog.Visible = false;

            RVPlayer.PlaySound("audio\\complete.wav");

            cancelButton.Visible = true;
            cancelButton.Text = "Close";
            cancelButton.Enabled = true;

            if (_errorOpen)
            {
                _bDone = true;
            }
            else
            {
                _funcFinished?.Invoke();
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            if (_bDone)
            {
                if (!_parentForm.Visible)
                {
                    //_parentForm.Show();
                }
                _funcFinished?.Invoke();
                Close();
            }
            else
            {
                Cancelled = true;
                cancelButton.Visible = true;
                cancelButton.Text = "Cancelling";
                cancelButton.Enabled = false;
                _thWrk.Cancel();
            }
        }

        private void ErrorGridSelectionChanged(object sender, EventArgs e)
        {
            ErrorGrid.ClearSelection();
        }

        private void FrmProgressWindow_Resize(object sender, EventArgs e)
        {
        }

        private void SetDataGridSize()
        {
        }

        private void FrmProgressWindow_Load(object sender, EventArgs e)
        {
            Dark.dark.SetColors(this, Settings.rvSettings.Darkness);
            Helpers.Theming.SetFormTextSizeToDefault(this);
        }

        private void FrmProgressWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}