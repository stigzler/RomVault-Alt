using System;
using System.Drawing;
using System.Windows.Forms;

namespace ROMVault.UserControls
{
    [System.ComponentModel.DesignerCategory("Code")]
    internal class PathLabel : Label
    {
        public PathLabel()
        {
            // We keep AutoSize false so we can control the Width/Ellipsis behavior
            this.AutoSize = false;
        }

        /// <summary>
        /// Manually calculate and set the height based on the current font.
        /// </summary>
        private void UpdateHeight()
        {
            using (Graphics g = this.CreateGraphics())
            {
                // Measure the height of a standard character in the current font
                Size size = TextRenderer.MeasureText(g, "W", this.Font);
                int requiredHeight = size.Height + this.Padding.Vertical;

                // Only update if the height actually needs to change to prevent layout loops
                if (this.Height != requiredHeight)
                {
                    this.Height = requiredHeight;
                }
            }
        }

        // Trigger height update when Font changes (e.g., Form scaling)
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            if (this.AutoSize)
                UpdateHeight();
        }

        // Trigger height update when the control is first created/added to a form
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.AutoSize)
                UpdateHeight();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 1. Calculate the area inside the padding
            Rectangle paddedBounds = new Rectangle(
                this.ClientRectangle.X + this.Padding.Left,
                this.ClientRectangle.Y + this.Padding.Top,
                this.ClientRectangle.Width - this.Padding.Horizontal,
                this.ClientRectangle.Height - this.Padding.Vertical
            );

            // 2. Use PathEllipsis
            TextFormatFlags flags = TextFormatFlags.Left |
                                    TextFormatFlags.PathEllipsis |
                                    TextFormatFlags.VerticalCenter;

            // 3. Draw inside the PADDED bounds, not the ClientRectangle
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font,
                                  paddedBounds, this.ForeColor, flags);
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            if (this.AutoSize)
                UpdateHeight();
            this.Invalidate(); // Redraw to apply the new horizontal padding
        }

        // We override this so that if a parent DOES call it,
        // it returns the current width but the calculated height.
        public override Size GetPreferredSize(Size proposedSize)
        {
            Size textSize = TextRenderer.MeasureText("W", this.Font);
            return new Size(this.Width, textSize.Height + this.Padding.Vertical);
        }
    }
}