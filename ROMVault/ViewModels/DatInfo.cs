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
        public string RomPath { get; set; } = string.Empty;
        public int RomsGot { get; set; } = 0;
        public int RomsMissing { get; set; } = 0;
        public int RomsFixable { get; set; } = 0;
        public int RomsUnknown { get; set; } = 0;

        public DatInfo()
        {
            Icon = Properties.Resources.database;
            Title = "DAT Info";
        }
    }
}