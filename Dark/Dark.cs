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
        // DARK Pallette
        public static Color bg0 = Color.FromArgb(28, 28, 28);

        public static Color bg1 = Color.FromArgb(35, 35, 35);
        public static Color bg = Color.FromArgb(40, 40, 40);

        public static Color bgTs = Color.FromArgb(50, 50, 50); // toolstip bg

        public static Color bgMenuItemRollover = Color.FromArgb(255, 63, 63, 70);
        public static Color midGrey = Color.FromArgb(128, 128, 128);

        public static Color fgBright = Color.White;
        public static Color fg = Color.FromArgb(220, 220, 220);
        public static Color fgDimmed = Color.FromArgb(180, 180, 180);
        public static Brush sb_bg = new SolidBrush(bg);
        public static Brush sb_bg1 = new SolidBrush(bg1);
        public static Brush sb_fg = new SolidBrush(fg);

        // DARK Pallette
        public static Color darkSelectorBackColor = Color.FromArgb(0, 120, 212);

        public static Color darkSelectorForeColor = Color.White;
        public static Color darkForeColor = fg;

        // LIGHT Pallette
        public static Color lightSelectorBackColor = Color.FromArgb(200, 200, 200);

        public static Color lightSelectorForeColor = Color.Black;
        public static Color lightForeColor = Color.FromArgb(10, 10, 10);
        public static Color lightDimmedColor = Color.FromArgb(70, 70, 70);
        public static Color lightBackColor = Color.FromArgb(240, 240, 240);
        // I know this is a bit of a mess but lost the will to live - stigzler

        public static bool darkEnabled;

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        private const int DWWMA_CAPTION_COLOR = 35;

        public static Color GetSelectorBackColor(bool darkMode)
        {
            if (darkMode) return darkSelectorBackColor;
            else
                return lightSelectorBackColor;
        }

        public static Color GetForegroundDimmed(bool darkMode)
        {
            if (darkMode) return fgDimmed;
            else return lightDimmedColor;
        }

        public static Color GetForecolor(bool darkMode)
        {
            if (darkMode) return darkForeColor;
            else return lightForeColor;
        }

        public static Color GetBackcolor(bool darkMode)
        {
            if (darkMode) return bg;
            else return lightBackColor;
        }

        public static Color GetSelectorForeColor(bool darkMode)
        {
            if (darkMode) return darkSelectorForeColor;
            else
                return lightSelectorForeColor;
        }

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
            if (darkMode)
                SetTitleBarColor(bg0, frm.Handle);
            else
                SetTitleBarColor(Color.FromArgb(200, 200, 200), frm.Handle);

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

                case RichTextBox rtb:
                    rtb.BorderStyle = BorderStyle.None;
                    rtb.BackColor = (darkMode) ? bg1 : Control.DefaultBackColor;
                    break;

                case Button bt:
                    ////bt.ForeColor = (darkMode) ? fg : Control.DefaultForeColor;
                    ////bt.BackColor = (darkMode) ? bg0 : Control.DefaultBackColor;
                    //bt.FlatStyle = FlatStyle.Flat;
                    //bt.FlatAppearance.BorderColor = (darkMode) ? midGrey : Color.Black;
                    //bt.FlatAppearance.BorderSize = 1;
                    //break;
                    break;

                case DataGridView dgv:
                    dgv.BackgroundColor = (darkMode) ? bg1 : Control.DefaultBackColor;
                    dgv.ForeColor = (darkMode) ? fg : Color.FromArgb(10, 10, 10);

                    dgv.DefaultCellStyle.BackColor = (darkMode) ? bg1 : Control.DefaultBackColor;
                    dgv.DefaultCellStyle.ForeColor = (darkMode) ? fg : Color.FromArgb(10, 10, 10);

                    dgv.ColumnHeadersDefaultCellStyle.BackColor = (darkMode) ? bg : Color.FromArgb(210, 210, 210);
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = (darkMode) ? fg : Color.FromArgb(0, 0, 0);

                    dgv.DefaultCellStyle.SelectionBackColor = (darkMode) ? darkSelectorBackColor : Color.FromArgb(200, 200, 200);
                    dgv.DefaultCellStyle.SelectionForeColor = (darkMode) ? fgBright : Color.Black;
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
                    cms.Renderer = (darkMode) ? new DarkToolStripRenderer() : null;
                    break;

                case ToolStrip ts:
                    ts.RenderMode = ToolStripRenderMode.System;
                    ts.Renderer = (darkMode) ? new DarkToolStripRenderer() : null;
                    ts.BackColor = (darkMode) ? bgTs : Control.DefaultBackColor;
                    ts.ForeColor = (darkMode) ? fg : Control.DefaultForeColor;
                    break;

                case PropertyGrid pg:
                    pg.UseCompatibleTextRendering = true;
                    pg.ViewBackColor = (darkMode) ? bg : Control.DefaultBackColor;
                    pg.ViewForeColor = (darkMode) ? fg : Control.DefaultForeColor;
                    pg.LineColor = (darkMode) ? bg1 : Color.FromArgb(200, 200, 200);
                    pg.BackColor = (darkMode) ? bg : Control.DefaultBackColor;
                    pg.CategoryForeColor = (darkMode) ? fgBright : Color.Black;
                    pg.CategorySplitterColor = (darkMode) ? bg0 : Control.DefaultForeColor; ;
                    pg.HelpBackColor = (darkMode) ? bg : Control.DefaultBackColor;
                    pg.HelpForeColor = (darkMode) ? fgDimmed : Control.DefaultForeColor;
                    break;

                case Label _:
                case SplitContainer _:
                case TrackBar _:
                case CheckBox _:
                case ComboBox _:
                case Panel _:
                case PictureBox _:
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