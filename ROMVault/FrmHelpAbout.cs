/******************************************************
 *     ROMVault3 is written by Gordon J.              *
 *     Contact gordon@romvault.com                    *
 *     Copyright 2025                                 *
 ******************************************************/

using RomVaultCore;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ROMVault
{
    public partial class FrmHelpAbout : Form
    {
        public FrmHelpAbout()
        {
            InitializeComponent();
            lblVersion.Text = "Version " + Program.strVersion;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try { Process.Start("http://www.romvault.com/"); } catch { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try { Process.Start("http://paypal.me/romvault"); } catch { }
        }

        private void FrmHelpAbout_Load(object sender, EventArgs e)
        {
            Dark.dark.SetColors(this, Settings.rvSettings.Darkness);
            Helpers.Theming.SetFormTextSizeToDefault(this);
        }

        private void flexiLabel4_Click(object sender, EventArgs e)
        {
            try { Process.Start("https://github.com/stigzler/RomVault-Alt"); } catch { }

        }
    }
}