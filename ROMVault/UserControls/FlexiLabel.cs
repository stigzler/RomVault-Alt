using System;
using System.Drawing;
using System.Windows.Forms;

namespace ROMVault.UserControls
{
    [System.ComponentModel.DesignerCategory("Code")]
    internal class FlexiLabel : Label
    {
        private double _scaleFactor = 1.0;
        private Form _trackedForm;

        public double ScaleFactor
        {
            get => _scaleFactor;
            set
            {
                if (value < 0.1 || value > 10) return;
                _scaleFactor = value;
                UpdateScaledFont();
            }
        }

        public FlexiLabel()
        {
            this.AutoSize = false;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            SubscribeToForm();
            UpdateScaledFont();
        }

        private void SubscribeToForm()
        {
            if (_trackedForm != null) _trackedForm.FontChanged -= Form_FontChanged;
            _trackedForm = this.FindForm();
            if (_trackedForm != null) _trackedForm.FontChanged += Form_FontChanged;
        }

        private void Form_FontChanged(object sender, EventArgs e) => UpdateScaledFont();

        private void UpdateScaledFont()
        {
            Form parentForm = _trackedForm ?? this.FindForm();
            if (parentForm == null) return;

            // 1. Get the base size from the Form
            float formSize = parentForm.Font.Size;
            float targetSize = formSize * (float)_scaleFactor;

            // 2. Preserve the CURRENT properties of this specific Label
            // This ensures we keep the Family, Bold, Italic, etc., set in the designer
            Font newFont = new Font(this.Font.FontFamily, targetSize, this.Font.Style);

            if (!newFont.Equals(this.Font))
            {
                this.Font = newFont;

                // Keep our custom height logic for the PathLabel scenario
                UpdateHeight();
            }
        }

        private void UpdateHeight()
        {
            int requiredHeight = TextRenderer.MeasureText("W", this.Font).Height + this.Padding.Vertical;
            if (this.Height != requiredHeight)
            {
                this.Height = requiredHeight;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _trackedForm != null)
            {
                _trackedForm.FontChanged -= Form_FontChanged;
            }
            base.Dispose(disposing);
        }
    }
}