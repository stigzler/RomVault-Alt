using Dark.Renderers;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dark
{
    public static class dark
    {
        //public static Color bg0 = Color.FromArgb(37, 39, 44);
        //public static Color bg = Color.FromArgb(47, 49, 54);
        //public static Color bg1 = Color.FromArgb(54, 57, 63);
        public static Color bg0 = Color.FromArgb(28, 28, 28);

        public static Color bg1 = Color.FromArgb(35, 35, 35);
        public static Color bg = Color.FromArgb(40, 40, 40);
        public static Color bgTs = Color.FromArgb(50, 50, 50); // toolstip bg

        public static Color bgMenuItemRollover = Color.FromArgb(255, 63, 63, 70);

        public static Color midGrey = Color.FromArgb(128, 128, 128, 128);

        public static Color fgBright = Color.White;
        public static Color fg = Color.FromArgb(210, 210, 210);
        public static Color fgDimmed = Color.FromArgb(192, 192, 192);
        public static Brush sb_bg = new SolidBrush(bg);
        public static Brush sb_bg1 = new SolidBrush(bg1);
        public static Brush sb_fg = new SolidBrush(fg);

        public static bool darkEnabled;

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        private const int DWWMA_CAPTION_COLOR = 35;

        private static void SetTitleBarColor(Color color, IntPtr handle)
        {
            if (IsUnix)
                return;

            IntPtr hWnd = handle;
            int[] colorstr = new int[] { color.ToArgb() & 0x00FFFFFF };
            DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, colorstr, 4);
        }

        public static void SetColors(Form frm, bool darkMode = false)
        {
            SetTitleBarColor(bg0, frm.Handle);

            frm.BackColor = (darkMode) ? bg : Control.DefaultBackColor;
            frm.ForeColor = (darkMode) ? fg : Control.DefaultForeColor;

            foreach (Control c in frm.Controls)
            {
                SetColors(c, darkMode);
            }
        }

        public static void SetColors(Control c, bool darkMode = false)
        {
            if (c.Tag != null && c.Tag.ToString() == "override") return;

            if (darkMode)
            {
                c.BackColor = bg;
                c.ForeColor = fg;
            }
            else
            {
                c.BackColor = Color.Empty;
                c.ForeColor = Color.Empty;
            }

            foreach (Control c1 in c.Controls)
                SetColors(c1, darkMode);

            //Debug.WriteLine(c.GetType().ToString(), c.Name);

            switch (c)
            {
                case TextBox tb:
                    tb.BorderStyle = BorderStyle.FixedSingle;
                    tb.ForeColor = (darkMode) ? fg : Control.DefaultForeColor;
                    tb.BackColor = (darkMode) ? bg0 : Control.DefaultBackColor;
                    if (tb.ReadOnly)
                    {
                        tb.BackColor = (darkMode) ? bg1 : Control.DefaultBackColor;
                    }
                    break;

                case DataGridView dgv:
                    dgv.BackgroundColor = (darkMode) ? bg1 : Control.DefaultBackColor;
                    dgv.ForeColor = (darkMode) ? fg : Control.DefaultForeColor;

                    dgv.DefaultCellStyle.BackColor = (darkMode) ? bg1 : Control.DefaultBackColor;
                    dgv.DefaultCellStyle.ForeColor = (darkMode) ? fg : Control.DefaultForeColor;

                    dgv.ColumnHeadersDefaultCellStyle.BackColor = (darkMode) ? bg : Control.DefaultBackColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = (darkMode) ? fg : Control.DefaultForeColor;

                    dgv.DefaultCellStyle.SelectionBackColor = (darkMode) ? bgMenuItemRollover : Control.DefaultBackColor;
                    //dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                    dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                    dgv.GridColor = (darkMode) ? bg : Control.DefaultBackColor;
                    break;

                case MenuStrip ms:
                    ms.RenderMode = ToolStripRenderMode.Professional;
                    ms.Renderer = (darkMode) ? new DarkMenuStripRenderer() : null;
                    ms.BackColor = (darkMode) ? bg0 : Control.DefaultBackColor;
                    break;

                case ContextMenuStrip cms:
                    cms.BackColor = (darkMode) ? bg : Control.DefaultBackColor;
                    cms.ForeColor = (darkMode) ? fg : Control.DefaultForeColor;
                    cms.RenderMode = ToolStripRenderMode.System;
                    cms.Renderer = new DarkToolStripRenderer();
                    break;

                case ToolStrip ts:
                    ts.RenderMode = ToolStripRenderMode.System;
                    ts.Renderer = new DarkToolStripRenderer();
                    ts.BackColor = bg;
                    ts.ForeColor = fg;

                    //foreach (ToolStripSeparator tss in ts.Items.OfType<ToolStripSeparator>().ToList())
                    //{
                    //    tss.ForeColor = fgDimmed;
                    //    tss.BackColor = bgTs;
                    //}

                    break;

                case PropertyGrid pg:
                    pg.UseCompatibleTextRendering = true;
                    pg.ViewBackColor = bg;
                    pg.ViewForeColor = fg;
                    pg.LineColor = midGrey;
                    pg.BackColor = bg;
                    pg.CategoryForeColor = fgBright;
                    pg.CategorySplitterColor = midGrey;
                    pg.HelpBackColor = bg;
                    pg.HelpForeColor = fgDimmed;

                    EventHandler applyPropertyGridTheme = null;
                    applyPropertyGridTheme = (s, e) =>
                    {
                        try
                        {
                            SetWindowTheme(pg.Handle, string.Empty, string.Empty);
                            pg.Refresh();
                        }
                        catch { }

                        pg.HandleCreated -= applyPropertyGridTheme;
                    };

                    if (pg.IsHandleCreated)
                        applyPropertyGridTheme(pg, EventArgs.Empty);
                    else
                        pg.HandleCreated += applyPropertyGridTheme;

                    break;

                case Label _:
                case Button _:
                case SplitContainer _:
                case TrackBar _:
                case CheckBox _:
                case ComboBox _:
                case Panel _:
                case PictureBox _:
                case RichTextBox _:
                case HScrollBar _:
                case VScrollBar _:
                case TabControl _:
                case GroupBox _:
                case ProgressBar _:
                    break;

                default:
                    Debug.WriteLine($"Control Unknown {c}");
                    break;
            }
        }

        public static Color bgColor(Color c)
        {
            return darkEnabled ? bg : c;
        }

        public static Color bgColor1(Color c)
        {
            return darkEnabled ? bg1 : c;
        }

        public static Brush bgBrush(Brush b)
        {
            return darkEnabled ? sb_bg : b;
        }

        public static Brush bgBrush1(Brush b)
        {
            return darkEnabled ? sb_bg1 : b;
        }

        public static Brush fgBrush(Brush b)
        {
            return darkEnabled ? sb_fg : b;
        }

        public static Color Down(Color c)
        {
            if (!darkEnabled)
                return c;

            return Color.FromArgb(255, (int)(c.R * 0.8), (int)(c.G * 0.8), (int)(c.B * 0.8));
        }

        public static bool IsUnix
        {
            get
            {
                int p = (int)Environment.OSVersion.Platform;
                return ((p == 4) || (p == 6) || (p == 128));
            }
        }
    }
}