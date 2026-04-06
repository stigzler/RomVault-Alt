using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROMVault.UserControls
{
    [System.ComponentModel.DesignerCategory("Code")]
    internal class FlexiLabel : Label
    {
        // public FontStyle FontStyle { get; set; } = FontStyle.Regular;

        private double _scaleFactor = 1.0;

        private FontStyle _fontStyle;

        public FontStyle FontStyle
        {
            get { return _fontStyle; }
            set
            {
                _fontStyle = value;
                SetFont();
            }
        }

        public double ScaleFactor
        {
            get { return _scaleFactor; }
            set
            {
                if (_scaleFactor < 0.1 || _scaleFactor > 10) return;
                _scaleFactor = value;
                SetFont();
            }
        }

        public FlexiLabel()
        {
        }

        private void SetFont()
        {
            if (this.FindForm() == null) return;
            float formFontSize = this.FindForm().Font.Size;
            this.Font = new Font(this.Font.FontFamily, formFontSize * (float)_scaleFactor, this.FontStyle);
        }
    }
}