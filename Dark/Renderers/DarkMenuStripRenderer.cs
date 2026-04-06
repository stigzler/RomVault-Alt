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
    internal class DarkMenuStripRenderer : ToolStripSystemRenderer
    {
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Color.Gainsboro;
            base.OnRenderArrow(e);
        }

        /// <summary>
        /// DROPDOWN menu border
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (!(e.ToolStrip is MenuStrip))
            {
                ControlPaint.DrawBorder(e.Graphics, e.AffectedBounds, dark.midGrey, ButtonBorderStyle.Solid);
            }
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            ToolStripMenuItem menuItem = e.Item as ToolStripMenuItem;
            bool isDropDownOpen = menuItem != null && menuItem.HasDropDownItems && menuItem.DropDown.Visible;

            // if (e.Item.Selected || e.Item.Pressed || isDropDownOpen)

            if (e.Item.Selected)
            {
                var rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 47, 47, 47)), rectangle);
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 37, 37, 37)), rectangle);
            }
            else if (e.Item.Pressed)
            {
                var rectangle = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 255, 0, 0)), rectangle);
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 37, 37, 37)), rectangle);
            }
        }

        /// <summary>
        /// HOVER Color
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Selected)
            {
                var rectangle = new Rectangle(0, 0, e.Item.Size.Width, e.Item.Size.Height);
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 63, 63, 70)), rectangle);
            }
        }

        /// <summary>
        /// Dropdown BG
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            ToolStripDropDown dr = e.ToolStrip as ToolStripDropDown;

            if (dr != null)
            {
                e.Graphics.FillRectangle(new SolidBrush(dark.bg), e.AffectedBounds);
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

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            if (e.Item == null)
            {
                base.OnRenderSeparator(e);
                return;
            }

            if (e.Vertical)
            {
                int verticalPadding = (int)(((double)e.Item.Height * 20) / 100);
                Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
                int x = Convert.ToInt32((double)bounds.Width / 2) - 1;
                using (Pen pen = new Pen(Color.FromArgb(200, 128, 128, 128)))
                    e.Graphics.DrawLine(pen, x, bounds.Top + verticalPadding, x, bounds.Bottom - 1 - verticalPadding);
            }
            else
            {
                int horizontalPadding = (int)(((double)e.Item.Width * 20) / 100);
                Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
                int y = Convert.ToInt32((double)bounds.Height / 2) - 1;
                using (Pen pen = new Pen(Color.FromArgb(200, 128, 128, 128)))
                    e.Graphics.DrawLine(pen, bounds.Left + horizontalPadding, y, bounds.Right - 1 - horizontalPadding, y);
            }
        }
    }
}