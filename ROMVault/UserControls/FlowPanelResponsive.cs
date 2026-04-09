using System;
using System.Windows.Forms;
using System.Drawing;

namespace ROMVault.UserControls
{
    [System.ComponentModel.DesignerCategory("Code")]
    public class FlowPanelResponsive : FlowLayoutPanel
    {
        public FlowPanelResponsive()
        {
            // Enable double buffering to reduce flicker during live resizing
            this.DoubleBuffered = true;
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            // Call the base layout logic first so children are positioned
            base.OnLayout(levent);

            if (this.Controls.Count == 0) return;

            // Get the last child control
            Control lastChild = this.Controls[this.Controls.Count - 1];

            // Only proceed if we are in LeftToRight or RightToLeft flow
            if (this.FlowDirection == FlowDirection.LeftToRight ||
                this.FlowDirection == FlowDirection.RightToLeft)
            {
                AdjustLastChildWidth(lastChild);
            }
            else
            {
                AdjustLastChildHeight(lastChild);
            }
        }

        private void AdjustLastChildWidth(Control lastChild)
        {
            // Calculate the space already taken by the last child's starting position
            int currentX = lastChild.Location.X;

            // Calculate available width inside the panel (subtracting padding and margins)
            int availableWidth = this.ClientSize.Width - currentX - lastChild.Margin.Right;

            if (lastChild.Width != availableWidth && availableWidth > 0)
            {
                lastChild.Width = availableWidth;
            }
        }

        private void AdjustLastChildHeight(Control lastChild)
        {
            int currentY = lastChild.Location.Y;
            int availableHeight = this.ClientSize.Height - currentY - lastChild.Margin.Bottom;

            if (lastChild.Height != availableHeight && availableHeight > 0)
            {
                lastChild.Height = availableHeight;
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            // Force a layout logic recalculation when the panel size changes
            this.PerformLayout();
        }
    }
}