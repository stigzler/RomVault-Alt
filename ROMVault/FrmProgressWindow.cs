/******************************************************
 *     ROMVault3 is written by Gordon J.              *
 *     Contact gordon@romvault.com                    *
 *     Copyright 2025                                 *
 ******************************************************/

using System;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Threading;
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

        // Timer-based update system
        private System.Windows.Forms.Timer _updateTimer;

        private readonly object _stateLock = new object();

        // Current state (updated by background thread, read by UI timer)
        private string _currentText = "";

        private string _currentText2 = "";
        private string _currentText3 = "";
        private int _currentProgress = 0;
        private int _currentProgress2 = 0;
        private int _progressMax = 100;
        private int _progress2Max = 0;
        private bool _range2Visible = false;

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

            // Create update timer
            _updateTimer = new System.Windows.Forms.Timer();
            _updateTimer.Interval = 100; // Update UI every 100ms
            _updateTimer.Tick += UpdateTimer_Tick;
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
            _updateTimer.Start();
            _thWrk.StartAsync();

            // Force focus retention
            this.Activate();
            this.BringToFront();
            this.Focus();
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

        private void BgwProgressChanged(object obj, bool imperative)
        {
            // Update state (always runs, regardless of imperative flag)
            lock (_stateLock)
            {
                if (obj is int e)
                {
                    _currentProgress = e;
                }
                else if (obj is bgwText bgwT)
                {
                    _currentText = bgwT.Text;
                    if (ShowTimeLog)
                    {
                        if (InvokeRequired)
                            BeginInvoke(new MethodInvoker(() => TimeLogShow(bgwT.Text)));
                        else
                            TimeLogShow(bgwT.Text);
                    }
                }
                else if (obj is bgwSetRange bgwSr)
                {
                    _progressMax = bgwSr.MaxVal >= 0 ? bgwSr.MaxVal : 0;
                    _currentProgress = 0;
                }
                else if (obj is bgwText2 bgwT2)
                {
                    _currentText2 = bgwT2.Text;
                }
                else if (obj is bgwValue2 bgwV2)
                {
                    _currentProgress2 = bgwV2.Value;
                }
                else if (obj is bgwSetRange2 bgwSr2)
                {
                    _progress2Max = bgwSr2.MaxVal >= 0 ? bgwSr2.MaxVal : 0;
                    _currentProgress2 = 0;
                }
                else if (obj is bgwRange2Visible bgwR2V)
                {
                    _range2Visible = bgwR2V.Visible;
                }
                else if (obj is bgwText3 bgwT3)
                {
                    _currentText3 = bgwT3.Text;
                }
            }

            // Imperative updates: apply immediately
            if (imperative)
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => ApplyCurrentState()));
                }
                else
                {
                    ApplyCurrentState();
                }
            }

            // Handle errors immediately regardless of imperative flag
            if (obj is bgwShowError bgwSE)
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new MethodInvoker(() => HandleError(bgwSE)));
                }
                else
                {
                    HandleError(bgwSE);
                }
            }
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            ApplyCurrentState();
        }

        private void ApplyCurrentState()
        {
            lock (_stateLock)
            {
                label.Text = _currentText;
                label2.Text = _currentText2;
                label3.Text = _currentText3;

                progressBar.Maximum = _progressMax;
                if (_currentProgress >= progressBar.Minimum && _currentProgress <= progressBar.Maximum)
                    progressBar.Value = _currentProgress;

                progressBar2.Maximum = _progress2Max;
                if (_currentProgress2 >= progressBar2.Minimum && _currentProgress2 <= progressBar2.Maximum)
                    progressBar2.Value = _currentProgress2;

                label2.Visible = _range2Visible;
                progressBar2.Visible = _range2Visible;
                lbl2Prog.Visible = _range2Visible;

                UpdateStatusText();
                UpdateStatusText2();
            }
        }

        private void MakeErrorGridVisible()
        {
            ErrorGrid.Visible = true;
            ErrorGrid.Visible = true;
            ClientSize = new Size(this.Width, this.Height * 2);
        }

        private void HandleError(bgwShowError bgwSE)
        {
            if (!_errorOpen)
            {
                MakeErrorGridVisible();
                _errorOpen = true;
            }

            ErrorGrid.Rows.Add();
            int row = ErrorGrid.Rows.Count - 1;

            ErrorGrid.Rows[row].Cells["CError"].Value = bgwSE.error;
            ErrorGrid.Rows[row].Cells["CError"].Style.ForeColor = Color.FromArgb(255, 0, 0);

            ErrorGrid.Rows[row].Cells["CErrorFile"].Value = bgwSE.filename;
            ErrorGrid.Rows[row].Cells["CErrorFile"].Style.ForeColor = Color.FromArgb(255, 0, 0);

            RVPlayer.PlaySound("audio\\error.wav");

            if (row >= 0)
                ErrorGrid.FirstDisplayedScrollingRowIndex = row;
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

            _updateTimer.Stop();
            ApplyCurrentState(); // Final state update

            // Cleanup
            label2.Text = "";
            label2.Visible = false;
            progressBar2.Visible = false;
            lbl2Prog.Visible = false;
            progressBar.Value = progressBar.Maximum;
            UpdateStatusText();

            //RVPlayer.PlaySound("audio\\complete.wav");
            SystemSounds.Asterisk.Play();

            cancelButton.Visible = true;
            cancelButton.Text = "Close";
            cancelButton.Enabled = true;

            if (_errorOpen)
            {
                cancelButton.Visible = true;
                cancelButton.Text = "Close";
                cancelButton.Enabled = true;
                _bDone = true;
            }
            else
            {
                _funcFinished?.Invoke();
                if (Properties.Settings.Default.AutoCloseProgressWindow)
                {
                    Application.DoEvents();
                    Thread.Sleep(1000);
                    _parentForm.Show();
                    Close();
                }
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

        private void SetDataGridSize()
        {
        }

        private void FrmProgressWindow_Load(object sender, EventArgs e)
        {
            Dark.dark.SetColors(this, Settings.rvSettings.Darkness);
            Helpers.Theming.SetFormTextSizeToDefault(this);
        }
    }
}