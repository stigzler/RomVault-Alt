using RomVaultCore.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomVaultCore.Extensions
{
    public static class EnumExtensions
    {
        public static EnumMetadataAttribute GetMetadata(this Enum value)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);

            // Use reflection to find the attribute on the enum field
            var attribute = type.GetField(name)
                                .GetCustomAttributes(typeof(EnumMetadataAttribute), false)
                                .FirstOrDefault() as EnumMetadataAttribute;

            return attribute;
        }
    }
}