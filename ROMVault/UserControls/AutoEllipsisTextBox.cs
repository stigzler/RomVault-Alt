using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.ComponentModel;

namespace ROMVault.UserControls
{
    [System.ComponentModel.DesignerCategory("Code")]
    internal class AutoEllipsisTextBox : TextBox
    {
        private string _fullText = string.Empty;
        private bool _isInternalChange = false;

        public new event EventHandler TextChanged;

        public EllipsisPosition EllipsisPlacement { get; set; } = EllipsisPosition.Middle;
        public bool PreserveBlocks { get; set; } = true;

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get => Focused ? base.Text : _fullText;
            set
            {
                _fullText = value ?? string.Empty;
                if (!Focused) ApplyEllipsis();
                else UpdateBaseText(_fullText);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!Focused)
            {
                // Capture the click location before the control gets focus and wipes the ellipsis
                int clickCharIndex = GetCharIndexFromPosition(e.Location);
                string displayedText = base.Text;

                base.OnMouseDown(e); // This triggers focus and restores full text via OnEnter

                HandleClickPlacement(clickCharIndex, displayedText);
            }
            else
            {
                base.OnMouseDown(e);
            }
        }

        private void HandleClickPlacement(int clickIndex, string displayedText)
        {
            if (string.IsNullOrEmpty(displayedText) || !displayedText.Contains("...")) return;

            int ellipsisIndex = displayedText.IndexOf("...");

            // Logic for clicking ON or NEAR the ellipsis
            if (clickIndex >= ellipsisIndex && clickIndex <= ellipsisIndex + 2)
            {
                switch (EllipsisPlacement)
                {
                    case EllipsisPosition.Left:
                        this.SelectionStart = 0;
                        break;

                    case EllipsisPosition.Right:
                        this.SelectionStart = _fullText.Length;
                        break;

                    case EllipsisPosition.Middle:
                        // Place at the start of the "suffix" block
                        string suffix = displayedText.Substring(ellipsisIndex + 3);
                        int fullSuffixStart = _fullText.LastIndexOf(suffix);
                        this.SelectionStart = Math.Max(0, fullSuffixStart);
                        break;
                }
            }
            else
            {
                // If they clicked a visible part of the path, try to map it 1:1
                if (EllipsisPlacement == EllipsisPosition.Right || (EllipsisPlacement == EllipsisPosition.Middle && clickIndex < ellipsisIndex))
                {
                    this.SelectionStart = Math.Min(clickIndex, _fullText.Length);
                }
                else
                {
                    // Clicked the suffix part after a Left or Middle ellipsis
                    string suffixClicked = displayedText.Substring(clickIndex);
                    int mapIndex = _fullText.LastIndexOf(suffixClicked);
                    if (mapIndex != -1) this.SelectionStart = mapIndex;
                }
            }

            this.SelectionLength = 0;
        }

        protected override void OnEnter(EventArgs e)
        {
            UpdateBaseText(_fullText);
            base.OnEnter(e);
            // Selection is now handled by OnMouseDown if via click,
            // otherwise (Tab key) it stays default.
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
            if (!Focused) ApplyEllipsis();
        }

        private void UpdateBaseText(string newText)
        {
            _isInternalChange = true;
            base.Text = newText;
            _isInternalChange = false;
        }

        private void ApplyEllipsis()
        {
            UpdateBaseText(GetEllipsizedText(_fullText));
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
            int maxWidth = this.ClientSize.Width - 10;
            if (TextRenderer.MeasureText(source, this.Font).Width <= maxWidth) return source;

            char sep = source.Contains('\\') ? '\\' : (source.Contains('/') ? '/' : ' ');
            if (!PreserveBlocks) return SimpleCharEllipsis(source, maxWidth);

            string[] segments = source.Split(new[] { sep }, StringSplitOptions.None);
            if (segments.Length <= 1) return SimpleCharEllipsis(source, maxWidth);

            return BuildBlockEllipsis(segments, sep, maxWidth);
        }

        private string BuildBlockEllipsis(string[] segments, char sep, int maxWidth)
        {
            switch (EllipsisPlacement)
            {
                case EllipsisPosition.Left:
                    for (int i = 1; i < segments.Length; i++)
                    {
                        string trial = "..." + sep + string.Join(sep.ToString(), segments.Skip(i));
                        if (TextRenderer.MeasureText(trial, Font).Width <= maxWidth) return trial;
                    }
                    return "..." + segments.Last();

                case EllipsisPosition.Right:
                    for (int i = segments.Length - 1; i > 0; i--)
                    {
                        string trial = string.Join(sep.ToString(), segments.Take(i)) + sep + "...";
                        if (TextRenderer.MeasureText(trial, Font).Width <= maxWidth) return trial;
                    }
                    return segments.First() + "...";

                case EllipsisPosition.Middle:
                default:
                    int leftIdx = 1, rightIdx = segments.Length - 1;
                    string bestFit = segments.First() + "..." + segments.Last();
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
                    return bestFit;
            }
        }

        private string SimpleCharEllipsis(string text, int maxWidth)
        {
            string ellipsis = "...";
            int low = 0, high = text.Length;
            string lastFit = ellipsis;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                string trial = (EllipsisPlacement == EllipsisPosition.Left)
                    ? ellipsis + text.Substring(Math.Max(0, text.Length - mid))
                    : text.Substring(0, mid) + ellipsis;
                if (TextRenderer.MeasureText(trial, Font).Width <= maxWidth) { lastFit = trial; low = mid + 1; }
                else high = mid - 1;
            }
            return lastFit;
        }
    }
}