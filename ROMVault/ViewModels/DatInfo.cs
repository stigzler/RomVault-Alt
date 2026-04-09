using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMVault.ViewModels
{
    internal class DatInfo : ViewModelBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string RomPath { get; set; } = string.Empty;
        public string RomsGot { get; set; } = string.Empty;
        public string RomsMissing { get; set; } = string.Empty;
        public string RomsFixable { get; set; } = string.Empty;
        public string RomsUnknown { get; set; } = string.Empty;

        public DatInfo()
        {
            Icon = Properties.Resources.databaseBig;
            Title = "DAT Info";
        }
    }
}