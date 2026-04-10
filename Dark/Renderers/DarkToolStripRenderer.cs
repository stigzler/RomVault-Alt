using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dark.Renderers
{
    public class DarkToolStripRenderer : ToolStripSystemRenderer
    {
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Color.Gainsboro;
            base.OnRenderArrow(e);
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            ToolStripButton button = (ToolStripButton)e.Item;

            if (button.CheckOnClick && button.Checked)
            {
                var Rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(dark.bgMenuItemRollover), Rectangle);
                e.Graphics.DrawRectangle(new Pen(dark.midGrey), Rectangle);
            }
            else if (button.Selected)
            {
                // Hover Over Button Background
                var Rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(ControlPaint.Light(dark.bgMenuItemRollover)), Rectangle);
                e.Graphics.DrawRectangle(new Pen(dark.fgDimmed), Rectangle);
            }
            else
            {
                base.OnRenderButtonBackground(e);
            }
        }

        // Hover color
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var rectangle = new Rectangle(0, 0, e.Item.Size.Width, e.Item.Size.Height);

            if (e.Item.Selected)
            {
                // hover color (keep as-is)
                e.Graphics.FillRectangle(new SolidBrush(dark.bgMenuItemRollover), rectangle);
            }
            else
            {
                // unhover (normal) background - paint dark background explicitly
                e.Graphics.FillRectangle(new SolidBrush(dark.bg), rectangle);
            }
        }

        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            ToolStripDropDown dr = e.ToolStrip as ToolStripDropDown;

            if (dr != null)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 20, 20, 20)), e.AffectedBounds);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = Color.FromArgb(255, 220, 220, 220);
            base.OnRenderItemText(e);
        }

        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            var rectangle = new Rectangle(new Point(e.ImageRectangle.Location.X - 1, e.ImageRectangle.Y - 1), new Size(e.ImageRectangle.Size.Width + 1, e.ImageRectangle.Size.Height + 1));
            rectangle.Inflate(1, 1);
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 61, 102)), rectangle);
            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(0, 142, 224)), rectangle);

            if (e.Item.Image is null)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                var tickBrush = new SolidBrush(Color.Gainsboro);
                var tickPen = new Pen(tickBrush, 2f);
                var r = new Rectangle(e.ImageRectangle.Location, e.ImageRectangle.Size);
                r.Inflate(-2, -4);
                e.Graphics.DrawLines(tickPen, new Point[] { new Point(r.Left, (int)Math.Round(r.Bottom - r.Height / 2d)), new Point((int)Math.Round(r.Left + r.Width / 3d), r.Bottom), new Point(r.Right, r.Top) });
            }
        }

        protected override void OnRenderDropDownButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Pressed)
            {
                var Rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(ControlPaint.Light(dark.bgMenuItemRollover)), Rectangle);
                e.Graphics.DrawRectangle(new Pen(dark.fgDimmed), Rectangle);
            }
            else if (e.Item.Selected)
            {
                var Rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(dark.bgMenuItemRollover), Rectangle);
                e.Graphics.DrawRectangle(new Pen(dark.fgDimmed), Rectangle);
            }
            else
            {
                base.OnRenderButtonBackground(e);
            }
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if ((e.ToolStrip.GetType() == typeof(ToolStrip)))
            {
                // skip render border
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, e.AffectedBounds, Color.FromArgb(120, 120, 120), ButtonBorderStyle.Solid);
            }
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            if ((e.Item as ToolStripSeparator) == null)
            {
                base.OnRenderSeparator(e);
                return;
            }
            // Ensure the separator area uses the dark background so the line appears on the correct color
            Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
            using (Brush back = new SolidBrush(e.ToolStrip.BackColor))
                e.Graphics.FillRectangle(back, bounds);

            if (e.Vertical)
            {
                int verticalPadding = (int)(((double)e.Item.Height * 20) / 100);
                int x = Convert.ToInt32((double)bounds.Width / 2) - 1;
                using (Pen pen = new Pen(ControlPaint.Dark(e.ToolStrip.ForeColor)))
                    e.Graphics.DrawLine(pen, x, bounds.Top + verticalPadding, x, bounds.Bottom - 1 - verticalPadding);
            }
            else
            {
                int horizontalPadding = (int)(((double)e.Item.Width * 20) / 100);
                int y = Convert.ToInt32((double)bounds.Height / 2) - 1;
                using (Pen pen = new Pen(ControlPaint.Dark(e.ToolStrip.ForeColor)))
                    e.Graphics.DrawLine(pen, bounds.Left + horizontalPadding, y, bounds.Right - 1 - horizontalPadding, y);
            }
        }
    }
}