using RomVaultCore.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomVaultCore
{
    public enum DatTreeStatus
    {
        [EnumMetadata("None Missing Dir",
            "No ROMs are missing from any DATs in the branch. Also used to signify an empty ToSort directory.",
            "DirectoryTree3")]
        DirComplete,

        [EnumMetadata("None Missing -MIA Dir",
            "No ROMs are missing from any DATs in the branch, except for MIA ROMs.",
            "DirectoryTree5")]
        DirCompleteNoMia,

        [EnumMetadata("Some Missing Dir",
            "Some ROMs missing from DATs in the branch.",
            "DirectoryTree2")]
        DirIncomplete,

        [EnumMetadata("All Missing Dir",
            "All ROMs are missing from DATs in the branch. Also used to signify a ToSort directory that only contains corrupt files.",
            "DirectoryTree1")]
        DirNone,

        [EnumMetadata("To Sort Dir",
            "ToSort directory with files present.",
            "DirectoryTree4")]
        DirToSort,

        [EnumMetadata("None Missing DAT",
            "No ROMs are missing for this DAT file.",
            "Tree3")]
        DatComplete,

        [EnumMetadata("None Missing -MIA DAT",
            "No ROMs are missing for this DAT file, except for MIA ROMs.",
            "Tree5")]
        DatCompleteNoMia,

        [EnumMetadata("Some Missing DAT",
            "Some ROMs are missing for this DAT file.",
            "Tree2")]
        DatIncomplete,

        [EnumMetadata("All Missing DAT",
            "All ROMs are missing for this DAT file.",
            "Tree1")]
        DatNone,
    }
}