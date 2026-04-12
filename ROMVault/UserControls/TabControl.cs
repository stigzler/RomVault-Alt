using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROMVault.UserControls
{
    [System.ComponentModel.DesignerCategory("Code")]
    [ToolboxItem(true)]
    [DesignTimeVisible(true)]
    public class TabControl : System.Windows.Forms.TabControl
    {
        [Category("Appearance"), DisplayName("Override Theme"), Description("Overrides the Light/Dark theme rendering"), DefaultValue(false)]
        public bool OverrideTheme { get; set; } = false;

        private bool _hideTabs = false;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool HideTabs
        {
            get { return _hideTabs; }
            set
            {
                _hideTabs = value;
                DoHideTabs();
            }
        }

        private bool _hideBorders = false;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool HideBorders
        {
            get { return _hideBorders; }
            set
            {
                _hideBorders = value;
                //this.Invalidate();
                //this.Update();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TabOutlineColor { get; set; } = SystemColors.ControlDarkDark;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color SelectedTabColor { get; set; } = Color.FromArgb(34, 120, 187);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Color BackColor { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color UnselectedTabBackColor { get; set; } = SystemColors.ControlDark;

        private int _tabPadding = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Appearance"), DisplayName("Tab Padding"), Description("Padding around tab text in pixels"), DefaultValue(0)]
        public int TabPadding
        {
            get { return _tabPadding; }
            set
            {
                _tabPadding = value;
                UpdateItemSize();
                this.Invalidate();
            }
        }

        internal struct RECT
        { public int Left, Top, Right, Bottom; }

        private int nMargin = 0;

        public TabControl()
        {
            //DrawMode = TabDrawMode.OwnerDrawFixed;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawControl(e.Graphics);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateItemSize();
        }

        internal void DrawControl(Graphics g)
        {
            if (!Visible)
                return;

            Rectangle TabControlArea = this.ClientRectangle;
            Rectangle TabArea = this.DisplayRectangle;

            // fill client area
            Brush br = new SolidBrush(BackColor);
            g.FillRectangle(br, TabControlArea);
            br.Dispose();

            // draw border
            int nDelta = SystemInformation.Border3DSize.Width;

            Pen border = new Pen(TabOutlineColor);
            TabArea.Inflate(nDelta, nDelta);
            g.DrawRectangle(border, TabArea);
            border.Dispose();

            // clip region for drawing tabs
            Region rsaved = g.Clip;
            Rectangle rreg;

            int nWidth = TabArea.Width + nMargin;

            rreg = new Rectangle(TabArea.Left, TabControlArea.Top, nWidth - nMargin, TabControlArea.Height);

            g.SetClip(rreg);

            // draw tabs
            for (int i = 0; i < this.TabCount; i++)
                DrawTab(g, this.TabPages[i], i);

            g.Clip = rsaved;

            // draw background to cover flat border areas
            if (this.SelectedTab != null)
            {
                TabPage tabPage = (TabPage)base.SelectedTab;
                Color color = tabPage.BackColor;
                border = new Pen(color);

                TabArea.Offset(1, 1);
                TabArea.Width -= 2;
                TabArea.Height -= 2;

                g.DrawRectangle(border, TabArea);
                TabArea.Width -= 1;
                TabArea.Height -= 1;
                g.DrawRectangle(border, TabArea);

                border.Dispose();
            }
        }

        internal void DrawTab(Graphics g, TabPage tabPage, int nIndex)
        {
            Rectangle recBounds = GetTabRect(nIndex);
            RectangleF tabTextArea = (RectangleF)this.GetTabRect(nIndex);

            // Apply vertical padding only - shrink top and bottom
            if (_tabPadding > 0)
            {
                tabTextArea.Y += _tabPadding;
                tabTextArea.Height -= (2 * _tabPadding);
            }

            bool bSelected = (this.SelectedIndex == nIndex);

            Point[] pt = new Point[7];
            if (this.Alignment == TabAlignment.Top)
            {
                pt[0] = new Point(recBounds.Left, recBounds.Bottom);
                pt[1] = new Point(recBounds.Left, recBounds.Top + 3);
                pt[2] = new Point(recBounds.Left + 3, recBounds.Top);
                pt[3] = new Point(recBounds.Right - 3, recBounds.Top);
                pt[4] = new Point(recBounds.Right, recBounds.Top + 3);
                pt[5] = new Point(recBounds.Right, recBounds.Bottom);
                pt[6] = new Point(recBounds.Left, recBounds.Bottom);
            }
            else
            {
                pt[0] = new Point(recBounds.Left, recBounds.Top);
                pt[1] = new Point(recBounds.Right, recBounds.Top);
                pt[2] = new Point(recBounds.Right, recBounds.Bottom - 3);
                pt[3] = new Point(recBounds.Right - 3, recBounds.Bottom);
                pt[4] = new Point(recBounds.Left + 3, recBounds.Bottom);
                pt[5] = new Point(recBounds.Left, recBounds.Bottom - 3);
                pt[6] = new Point(recBounds.Left, recBounds.Top);
            }

            // fill this tab with background color
            Brush br = new SolidBrush(tabPage.BackColor);
            g.FillPolygon(br, pt);
            br.Dispose();

            // draw border
            g.DrawPolygon(new Pen(TabOutlineColor, 1), pt);

            if (bSelected)
            {
                // clear bottom lines
                Pen pen = new Pen(BackColor, 1);

                switch (this.Alignment)
                {
                    case TabAlignment.Top:
                        g.FillPolygon(new SolidBrush(BackColor), pt);
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Bottom - 1,
                                        recBounds.Right, recBounds.Bottom - 1);
                        //g.DrawLine(pen, recBounds.Left + 1, recBounds.Bottom - 1,
                        //                recBounds.Right, recBounds.Bottom - 1);

                        break;

                    case TabAlignment.Bottom:
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Top,
                                           recBounds.Right - 1, recBounds.Top);
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Top - 1,
                                           recBounds.Right - 1, recBounds.Top - 1);
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Top - 2,
                                           recBounds.Right - 1, recBounds.Top - 2);
                        break;
                }
                pen.Dispose();
            }
            else
            {
                Pen pen = new Pen(TabOutlineColor, 2);

                switch (this.Alignment)
                {
                    case TabAlignment.Top:

                        g.FillPolygon(new SolidBrush(UnselectedTabBackColor), pt);

                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Bottom - 1,
                                        recBounds.Right, recBounds.Bottom - 1);

                        break;

                    case TabAlignment.Bottom:
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Top,
                                           recBounds.Right - 1, recBounds.Top);
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Top - 1,
                                           recBounds.Right - 1, recBounds.Top - 1);
                        g.DrawLine(pen, recBounds.Left + 1, recBounds.Top - 2,
                                           recBounds.Right - 1, recBounds.Top - 2);
                        break;
                }
                pen.Dispose();
            }

            // draw border
            g.DrawPolygon(new Pen(TabOutlineColor, 1), pt);

            // draw tab's icon
            if ((tabPage.ImageIndex >= 0) && (ImageList != null) &&
                       (ImageList.Images[tabPage.ImageIndex] != null))
            {
                int nLeftMargin = 8;
                int nRightMargin = 2;

                Image img = ImageList.Images[tabPage.ImageIndex];

                Rectangle rimage = new Rectangle(recBounds.X + nLeftMargin,
                                    recBounds.Y + 1, img.Width, img.Height);

                // adjust rectangles
                float nAdj = (float)(nLeftMargin + img.Width + nRightMargin);

                rimage.Y += (recBounds.Height - img.Height) / 2;
                tabTextArea.X += nAdj;
                tabTextArea.Width -= nAdj;

                // draw icon
                g.DrawImage(img, rimage);
            }

            // draw string
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            br = new SolidBrush(tabPage.ForeColor);

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            g.DrawString(tabPage.Text, Font, br, tabTextArea,
                                                 stringFormat);
        }

        // Used to Hide Borders
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x1300 + 40 && HideBorders)
            {
                RECT rc = (RECT)m.GetLParam(typeof(RECT));
                rc.Left -= 4;
                rc.Right += 4;
                rc.Bottom += 4;
                rc.Top -= HideTabs == true ? 5 : 2;
                Marshal.StructureToPtr(rc, m.LParam, true);
            }
            base.WndProc(ref m);
        }

        private void UpdateItemSize()
        {
            if (_hideTabs)
                return;

            int height = Font.Height + (2 * _tabPadding);
            int width = 58;
            this.ItemSize = new Size(width, height);
        }

        private void DoHideTabs()
        {
            if (_hideTabs == true)
            {
                this.Appearance = TabAppearance.FlatButtons;
                this.ItemSize = new Size(0, 1);
                this.SizeMode = TabSizeMode.Fixed;
            }
            else
            {
                this.Appearance = TabAppearance.Normal;
                this.SizeMode = TabSizeMode.Normal;
                UpdateItemSize();
            }
        }
    }
}