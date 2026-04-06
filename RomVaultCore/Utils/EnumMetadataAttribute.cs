using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RomVaultCore.Utils
{
    /// <summary>
    /// Note: ShortName and ImageName included in case of future refactoring.
    /// At present, the system built around RomVaultCore.RepStatus reliees on RomVault.Constants.UI.RepStatusText
    /// for the description text and auto-generates the relevant image for each (see FrmMain.InitialiseStatusStrip)
    /// This implement for DatTreeStatus in RomVaultCore
    /// Decorate Enum data with [EnumMetadata("The system is running", "ok_icon.png")]
    /// Access via EnumExtensions.GetMetadata() extension method in RomVaultCore.Extensions.EnumExtensions
    /// eg:
    /// AppStatus currentStatus = AppStatus.Online;
    /// var meta = currentStatus.GetMetadata();
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class EnumMetadataAttribute : Attribute
    {
        /// <summary>
        /// This is the standardized name of the image in the Graphics packs without extension (eg. "Tree1")
        /// All images are png so rvImages.GetBitmap adds the png itself
        /// </summary>
        public string ImageName { get; }

        public string Description { get; }
        public string ShortName { get; set; }

        public EnumMetadataAttribute(string shortName = null, string description = null, string imageName = null)
        {
            Description = description;
            ImageName = imageName;
            ShortName = shortName;
        }

        public EnumMetadataAttribute(string imageName = null)
        {
            ImageName = imageName;
        }
    }
}