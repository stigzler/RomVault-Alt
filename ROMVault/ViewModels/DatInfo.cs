using ROMVault.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMVault.ViewModels
{
    internal class DatInfo : ViewModelBase
    {
        //[SortableCategory("DAT File", 10)]
        public string Name { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        //[Description("The path where ROMs are put when fixed (your final ROM collection.")]
        public string RomPath { get; set; } = string.Empty;

        public string DatPath { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        public string Description { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        public string Version { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        public string Category { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        public string Author { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        public string Date { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        //[Description("ROMs in your ToSort folder/s that can be moved into your ROM collection by fixing.")]
        public string RomsFixable { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        //[Description("ROMs in your ROM collection that match the DAT file specifications.")]
        public string RomsGot { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        //[Description("ROM entries in the DAT file that cannot be located in the ToSort folder/s or in your ROM collection")]
        public string RomsMissing { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        //[Description("Rom entries in the DAT file in an Unknown state (see docs online).")]
        public string RomsUnknown { get; set; } = string.Empty;

        public DatInfo()
        {
            Icon = Properties.Resources.databaseBig;
            Title = "DAT Info";
        }
    }
}