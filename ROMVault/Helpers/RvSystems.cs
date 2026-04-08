using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROMVault.Helpers
{
    internal static class RvSystems
    {
        /// <summary>
        /// Translates any in app dir relative paths to full path name
        /// </summary>
        /// <param name="inputPath"></param>
        /// <returns></returns>
        public static string GetFullyQualifiedPath(string inputPath)
        {
            if (string.IsNullOrWhiteSpace(inputPath))
                return inputPath;

            // 1. Check if the path is relative
            // This returns false for "Cache" or "Data\Dats"
            // This returns true for "C:\App\Cache" or "\\Server\Share"
            if (!Path.IsPathRooted(inputPath))
            {
                // 2. Anchor it to the Application's Base Directory
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;

                // Path.Combine handles the slashes correctly
                string combined = Path.Combine(baseDir, inputPath);

                // 3. Clean it up (resolves any ".." or redundant slashes)
                return Path.GetFullPath(combined);
            }

            // If it was already rooted (Full Path or UNC), just return it
            // Use GetFullPath anyway to normalize slashes/formatting
            return Path.GetFullPath(inputPath);
        }

        public static string ResolveTokenisedDatPath(string tokenised, string replacementPath)
        {
            if (string.IsNullOrWhiteSpace(tokenised)) return tokenised;

            // 1. Split the path into individual directory segments
            // This handles both \ and / automatically
            string[] parts = tokenised.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar },
                                            StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 0) return tokenised;

            // 2. Check if the first segment is your token
            if (parts[0].Equals("DatRoot", StringComparison.OrdinalIgnoreCase))
            {
                // 3. If it's JUST "DatRoot", return the replacement directly
                if (parts.Length == 1)
                {
                    return replacementPath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
                }

                // 4. Otherwise, skip the first part and combine the rest with the new root
                // Path.Combine is "flexible" - it manages the slashes between segments for you
                string remainingPath = Path.Combine(parts.Skip(1).ToArray());
                return Path.Combine(replacementPath, remainingPath);
            }

            return tokenised;
        }
    }
}