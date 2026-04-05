using RomVaultCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMVault.Constants
{
    internal static class UI
    {
        internal static Dictionary<RepStatus, string> RepStatusText = new Dictionary<RepStatus, string>
        {
            { RepStatus.Correct, "Green - This ROM is Correct." },
            { RepStatus.CorrectMIA, "SuperGreen - The ROM was known to be\nMIA (Missing In Action), but you found\nit. (Good Job!)" },
            { RepStatus.Missing, "Red - This ROM is missing." },
            { RepStatus.MissingMIA, "Salmon - This ROM is known to be\nprivate or missing in action (MIA)." },
            { RepStatus.Unknown, "Cyan - The ROM is not needed here. Use\n'Find Fixes' to see what should be done\nwith the ROM." },
            { RepStatus.UnNeeded, "Light Cyan - The ROM is not needed here\nbecause it belongs in the parent or\nprimary deduped set." },
            { RepStatus.NotCollected, "Gray - The ROM is not collected here\nbecause it belongs in the parent or\nprimary deduped set." },
            { RepStatus.InToSort, "Magenta - The ROM is in a ToSort\ndirectory." },
            { RepStatus.Ignore, "GreyBlue - The file matches an ignore\nrule." },
            { RepStatus.CanBeFixed, "Yellow - The ROM is missing here, but\nit's available elsewhere. The ROM will\nbe fixed." },
            { RepStatus.CanBeFixedMIA, "SuperYellow - The MIA ROM is missing\nhere, but it's available elsewhere.\nThe ROM will be fixed." },
            { RepStatus.NeededForFix, "Orange - The ROM is not needed here,\nbut it's needed elsewhere. The ROM\nwill be moved." },
            { RepStatus.Rename, "Light Orange - The ROM is needed here,\nbut has the incorrect name. The ROM\nwill be renamed." },
            { RepStatus.MoveToSort, "Purple - The ROM is not needed here,\nbut a copy isn't located elsewhere.\nThe ROM will be moved to the Primary\nToSort." },
            { RepStatus.Incomplete, "Pink - This is a ROM that could be\nfixed, but will not be because it is\npart of an incomplete set." },
            { RepStatus.Delete, "Brown - The ROM is not needed here,\nbut a copy is located elsewhere. The\nROM will be deleted." },
            { RepStatus.Corrupt, "Red - This file is corrupt." },
            { RepStatus.UnScanned, "Blue - The file could not be scanned.\nThe file could be locked or have\nincompatible permissions." }
        };
    }
}