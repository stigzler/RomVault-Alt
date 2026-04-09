using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;

namespace ROMVault.UserControls
{
    [DesignerCategory("Code")]
    internal class AutoEllipsisTextBox : TextBox
    {
        private string _fullText = string.Empty;
        private bool _isInternalChange = false;

        public new event EventHandler TextChanged;

        public EllipsisPosition EllipsisPlacement { get; set; } = EllipsisPosition.Middle;
        public bool PreserveBlocks { get; set; } = true;

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            // NEVER return different values here based on focus.
            // base.Text must always reflect what the control actually holds.
            get => base.Text;
            set
            {
                _fullText = value ?? string.Empty;
                if (!Focused) ApplyEllipsis();
                else SetBaseText(_fullText);
            }
        }

        // Use this to expose the actual path to your logic
        [Browsable(false)]
        public string FullPath => _fullText;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!Focused)
            {
                int clickCharIndex = GetCharIndexFromPosition(e.Location);
                string displayedText = base.Text;
                base.OnMouseDown(e); // Triggers OnEnter -> SetBaseText(_fullText)
                HandleClickPlacement(clickCharIndex, displayedText);
            }
            else base.OnMouseDown(e);
        }

        private void HandleClickPlacement(int clickIndex, string displayedText)
        {
            if (string.IsNullOrEmpty(displayedText) || !displayedText.Contains("...")) return;
            int ellipsisIndex = displayedText.IndexOf("...");

            if (clickIndex >= ellipsisIndex && clickIndex <= ellipsisIndex + 2)
            {
                if (EllipsisPlacement == EllipsisPosition.Left) this.SelectionStart = 0;
                else if (EllipsisPlacement == EllipsisPosition.Right) this.SelectionStart = _fullText.Length;
                else
                {
                    string suffix = displayedText.Substring(ellipsisIndex + 3);
                    this.SelectionStart = Math.Max(0, _fullText.LastIndexOf(suffix));
                }
            }
            else
            {
                if (clickIndex < ellipsisIndex) this.SelectionStart = Math.Min(clickIndex, _fullText.Length);
                else
                {
                    string suffixClicked = displayedText.Substring(clickIndex);
                    int mapIndex = _fullText.LastIndexOf(suffixClicked);
                    if (mapIndex != -1) this.SelectionStart = mapIndex;
                }
            }
            this.SelectionLength = 0;
        }

        protected override void OnEnter(EventArgs e)
        {
            SetBaseText(_fullText);
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            _fullText = base.Text;
            ApplyEllipsis();
            base.OnLeave(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (!Focused && IsHandleCreated) ApplyEllipsis();
        }

        private void SetBaseText(string text)
        {
            if (base.Text == text) return;
            _isInternalChange = true;
            base.Text = text;
            _isInternalChange = false;
        }

        private void ApplyEllipsis()
        {
            if (!IsHandleCreated) return;
            SetBaseText(GetEllipsizedText(_fullText));
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!_isInternalChange)
            {
                _fullText = base.Text;
                TextChanged?.Invoke(this, e);
            }
        }

        private string GetEllipsizedText(string source)
        {
            if (string.IsNullOrEmpty(source)) return string.Empty;

            // Subtract a small buffer (15px) for the TextBox internal margins
            int maxWidth = this.ClientSize.Width - 15;
            if (TextRenderer.MeasureText(source, this.Font).Width <= maxWidth) return source;

            char sep = source.Contains('\\') ? '\\' : (source.Contains('/') ? '/' : ' ');
            if (!PreserveBlocks) return SimpleCharEllipsis(source, maxWidth);

            string[] segments = source.Split(new[] { sep }, StringSplitOptions.None);
            if (segments.Length <= 1) return SimpleCharEllipsis(source, maxWidth);

            return BuildBlockEllipsis(segments, sep, maxWidth);
        }

        private string BuildBlockEllipsis(string[] segments, char sep, int maxWidth)
        {
            // Initialization: Start with the most aggressive ellipsis
            string bestFit = segments.First() + "..." + segments.Last();

            switch (EllipsisPlacement)
            {
                case EllipsisPosition.Left:
                    for (int i = 1; i < segments.Length; i++)
                    {
                        string trial = "..." + sep + string.Join(sep.ToString(), segments.Skip(i));
                        if (TextRenderer.MeasureText(trial, Font).Width <= maxWidth) return trial;
                    }
                    break;

                case EllipsisPosition.Right:
                    for (int i = segments.Length - 1; i > 0; i--)
                    {
                        string trial = string.Join(sep.ToString(), segments.Take(i)) + sep + "...";
                        if (TextRenderer.MeasureText(trial, Font).Width <= maxWidth) return trial;
                    }
                    break;

                case EllipsisPosition.Middle:
                default:
                    int leftIdx = 1, rightIdx = segments.Length - 1;
                    while (leftIdx < rightIdx)
                    {
                        string trial = string.Join(sep.ToString(), segments.Take(leftIdx)) + sep + "..." + sep + string.Join(sep.ToString(), segments.Skip(rightIdx));
                        if (TextRenderer.MeasureText(trial, Font).Width <= maxWidth)
                        {
                            bestFit = trial;
                            if (leftIdx <= (segments.Length - rightIdx)) leftIdx++; else rightIdx--;
                        }
                        else break;
                    }
                    break;
            }
            return bestFit;
        }

        private string SimpleCharEllipsis(string text, int maxWidth)
        {
            int low = 0, high = text.Length;
            string lastFit = "...";
            while (low <= high)
            {
                int mid = (low + high) / 2;
                string trial = (EllipsisPlacement == EllipsisPosition.Left)
                    ? "..." + text.Substring(text.Length - mid)
                    : text.Substring(0, mid) + "...";

                if (TextRenderer.MeasureText(trial, Font).Width <= maxWidth)
                {
                    lastFit = trial;
                    low = mid + 1;
                }
                else high = mid - 1;
            }
            return lastFit;
        }
    }
}