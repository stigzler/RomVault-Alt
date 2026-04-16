using DATReader.DatStore;
using ROMVault.Attributes;
using RomVaultCore.RvDB;
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
        //[ReadOnly(true)]
        public string Name { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        [Description("The path where ROMs are put when fixed (your final ROM collection.")]
        [ReadOnly(true)]
        public string RomPath { get; set; } = string.Empty;

        [ReadOnly(true)]
        public string DatPath { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        //[ReadOnly(true)]
        public string Category { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        //[ReadOnly(true)]
        public string Description { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        //[ReadOnly(true)]
        public string Version { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        //[ReadOnly(true)]
        public string Author { get; set; } = string.Empty;

        //[SortableCategory("DAT File", 10)]
        [ReadOnly(true)]
        public string Date { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        [Description("ROMs in your ToSort folder/s that can be moved into your ROM collection by fixing.")]
        [ReadOnly(true)]
        public string RomsFixable { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        [Description("ROMs in your ROM collection that match the DAT file specifications.")]
        [ReadOnly(true)]
        public string RomsGot { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        [Description("ROM entries in the DAT file that cannot be located in the ToSort folder/s or in your ROM collection")]
        [ReadOnly(true)]
        public string RomsMissing { get; set; } = string.Empty;

        //[SortableCategory("Associated ROMs", 15)]
        //[Description("Rom entries in the DAT file in an Unknown state (see docs online).")]
        [ReadOnly(true)]
        public string RomsUnknown { get; set; } = string.Empty;

        public RvDat Dat;

        public DatInfo()
        {
            Icon = Properties.Resources.databaseBig;
            Title = "DAT Info";
        }
    }
}