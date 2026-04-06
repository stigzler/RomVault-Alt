using System.Windows.Forms;
using Dark;
using RomVaultCore;

namespace ROMVault.Extensions
{
    /// <summary>
    /// Extension helpers for ContextMenuStrip to apply project-wide styling.
    /// Usage: new ContextMenuStrip().DarkCompliant();
    /// </summary>
    public static class ContextMenuStripExtensions
    {
        public static ContextMenuStrip DarkCompliant(this ContextMenuStrip cms)
        {
            if (cms == null)
                cms = new ContextMenuStrip();

            if (Settings.rvSettings.Darkness)
            {
                // Apply the same styling used elsewhere in the app
                cms.BackColor = dark.bg;
                cms.ForeColor = dark.fg;
                cms.RenderMode = ToolStripRenderMode.System;
                cms.Renderer = new Dark.Renderers.DarkToolStripRenderer();
            }

            return cms;
        }
    }
}