using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ROMVault.UserControls
{
    [System.ComponentModel.DesignerCategory("Code")]
    internal class PromptTextBox : TextBox
    {
        private string _promptOnEmpty = "Enter text...";
        private Color _promptColor = Color.Gray;
        private bool _promptItalicised = true;

        [Category("Appearance")]
        public string PromptOnEmpty
        {
            get => _promptOnEmpty;
            set { _promptOnEmpty = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public Color PromptColor
        {
            get => _promptColor;
            set { _promptColor = value; this.Invalidate(); }
        }

        [Category("Appearance")]
        public bool PromptItalicised
        {
            get => _promptItalicised;
            set { _promptItalicised = value; this.Invalidate(); }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // 0x000F is WM_PAINT
            if (m.Msg == 0x000F && string.IsNullOrEmpty(this.Text) && !this.Focused)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    // Determine the font style
                    FontStyle style = _promptItalicised ? (this.Font.Style | FontStyle.Italic) : this.Font.Style;

                    using (Font promptFont = new Font(this.Font, style))
                    {
                        // TextFormatFlags.NoPadding helps align with the native textbox cursor
                        TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left | TextFormatFlags.NoPadding;

                        // Offset by 2-3 pixels to match standard TextBox internal margins
                        Rectangle rect = this.ClientRectangle;
                        rect.Offset(2, 0);

                        TextRenderer.DrawText(g, _promptOnEmpty, promptFont, rect, _promptColor, flags);
                    }
                }
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e); this.Invalidate();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e); this.Invalidate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e); this.Invalidate();
        }
    }
}