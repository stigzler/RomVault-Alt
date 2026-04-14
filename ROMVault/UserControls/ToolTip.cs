using Dark;
using RomVaultCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ROMVault.UserControls
{
    [DesignerCategory("Code")]
    internal class ToolTip : System.Windows.Forms.ToolTip
    {
        private const int HorizontalPadding = 8;
        private const int VerticalPadding = 6;

        private readonly Dictionary<Control, string> _toolTipTexts = new Dictionary<Control, string>();

        [DefaultValue(420)]
        public int MaxTextWidth { get; set; } = 420;

        [DefaultValue(1f)]
        public float FontScaleFactor { get; set; } = 1f;

        public ToolTip()
        {
            OwnerDraw = true;
            Popup += ToolTip_Popup;
            Draw += ToolTip_Draw;
        }

        public new void SetToolTip(Control control, string caption)
        {
            base.SetToolTip(control, caption);
            if (control == null) return;
            _toolTipTexts[control] = caption ?? string.Empty;
        }

        internal Size GetSuggestedToolTipSize(Control associatedControl, string text)
        {
            using (Font font = GetScaledFont(associatedControl))
            {
                string formattedText = FormatTextToBox(text, font, MaxTextWidth);
                Size textSize = MeasureFormattedText(formattedText, font);
                return new Size(textSize.Width + (HorizontalPadding * 2), textSize.Height + (VerticalPadding * 2));
            }
        }

        private void ToolTip_Popup(object sender, PopupEventArgs e)
        {
            string text = GetTextForControl(e.AssociatedControl);
            e.ToolTipSize = GetSuggestedToolTipSize(e.AssociatedControl, text);
        }

        private void ToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            bool darkMode = RomVaultCore.Settings.rvSettings.Darkness;
            Color backColor = darkMode ? dark.bgTs : SystemColors.Info;
            Color foreColor = darkMode ? dark.fg : SystemColors.InfoText;

            using (SolidBrush background = new SolidBrush(backColor))
            using (SolidBrush foreground = new SolidBrush(foreColor))
            using (Pen border = new Pen(darkMode ? dark.midGrey : SystemColors.ControlDark))
            using (Font font = GetScaledFont(e.AssociatedControl))
            {
                e.Graphics.FillRectangle(background, e.Bounds);
                e.Graphics.DrawRectangle(border, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1);

                string text = string.IsNullOrEmpty(e.ToolTipText) ? GetTextForControl(e.AssociatedControl) : e.ToolTipText;
                string formattedText = FormatTextToBox(text, font, MaxTextWidth);

                Rectangle textBounds = Rectangle.Inflate(e.Bounds, -HorizontalPadding, -VerticalPadding);
                TextRenderer.DrawText(e.Graphics, formattedText, font, textBounds, foreColor,
                    TextFormatFlags.Left | TextFormatFlags.Top | TextFormatFlags.NoPadding);
            }
        }

        private string GetTextForControl(Control control)
        {
            if (control == null) return string.Empty;
            if (_toolTipTexts.TryGetValue(control, out string text)) return text;
            return base.GetToolTip(control) ?? string.Empty;
        }

        private Font GetScaledFont(Control control)
        {
            Form parentForm = control?.FindForm();
            Font baseFont = parentForm?.Font ?? control?.Font ?? Control.DefaultFont;
            float scaledSize = Math.Max(6f, baseFont.Size * FontScaleFactor);
            return new Font(baseFont.FontFamily, scaledSize, baseFont.Style);
        }

        private static Size MeasureFormattedText(string text, Font font)
        {
            string[] lines = (text ?? string.Empty).Replace("\r\n", "\n").Split('\n');
            int maxWidth = 0;
            int totalHeight = 0;

            foreach (string line in lines)
            {
                string measureLine = string.IsNullOrEmpty(line) ? " " : line;
                Size lineSize = TextRenderer.MeasureText(measureLine, font, Size.Empty, TextFormatFlags.NoPadding);
                if (lineSize.Width > maxWidth) maxWidth = lineSize.Width;
                totalHeight += lineSize.Height;
            }

            return new Size(maxWidth, totalHeight);
        }

        private static string FormatTextToBox(string text, Font font, int maxWidth)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;
            if (maxWidth <= 0) return text;

            string[] sourceLines = text.Replace("\r\n", "\n").Split('\n');
            List<string> result = new List<string>();

            foreach (string sourceLine in sourceLines)
            {
                if (string.IsNullOrWhiteSpace(sourceLine))
                {
                    result.Add(string.Empty);
                    continue;
                }

                string[] words = sourceLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder current = new StringBuilder();

                foreach (string word in words)
                {
                    string candidate = current.Length == 0 ? word : current + " " + word;
                    Size candidateSize = TextRenderer.MeasureText(candidate, font, Size.Empty, TextFormatFlags.NoPadding);

                    if (candidateSize.Width <= maxWidth || current.Length == 0)
                    {
                        current.Clear();
                        current.Append(candidate);
                    }
                    else
                    {
                        result.Add(current.ToString());
                        current.Clear();
                        current.Append(word);
                    }
                }

                if (current.Length > 0)
                {
                    result.Add(current.ToString());
                }
            }

            return string.Join(Environment.NewLine, result);
        }
    }
}
