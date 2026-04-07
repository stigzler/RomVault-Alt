using Dark;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ROMVault.Helpers
{
    internal class FileSystem
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private struct SHFILEOPSTRUCT
        {
            public IntPtr hwnd;
            [MarshalAs(UnmanagedType.U4)] public int wFunc;
            public string pFrom;
            public string pTo;
            public short fFlags;
            [MarshalAs(UnmanagedType.Bool)] public bool fAnyOperationsAborted;
            public IntPtr hNameMappings;
            public string lpszProgressTitle;
        }

        private const int FO_MOVE = 0x0001;
        private const int FO_COPY = 0x0002;
        private const int FOF_ALLOWUNDO = 0x0040;
        private const int FOF_NOCONFIRMMKDIR = 0x0200;

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern int SHFileOperation(ref SHFILEOPSTRUCT lpFileOp);

        [DllImport("uxtheme.dll", SetLastError = true, EntryPoint = "#135")]
        private static extern int SetPreferredAppMode(int appMode);

        private const int ForceDark = 2; // 0 = Default, 1 = AllowDark, 2 = ForceDark, 3 = ForceLight

        public static void InitializeDarkMode()
        {
            // This tells the OS that this process wants to use Dark Mode for system dialogs
            SetPreferredAppMode(ForceDark);
        }

        // --- Single Item Operations ---

        public static void CopyFile(string sourceFile, string destinationPath, bool dark = false)
        {
            ExecuteShellOp(FO_COPY, new List<string> { sourceFile }, destinationPath, dark);
        }

        public static void MoveFile(string sourceFile, string destinationPath, bool dark = false)
        {
            ExecuteShellOp(FO_MOVE, new List<string> { sourceFile }, destinationPath, dark);
        }

        // --- Bulk Operations ---

        public static void CopyFiles(List<string> sourcePaths, string destinationPath, bool dark = false)
        {
            ExecuteShellOp(FO_COPY, sourcePaths, destinationPath, dark);
        }

        public static void MoveFiles(List<string> sourcePaths, string destinationPath, bool dark = false)
        {
            ExecuteShellOp(FO_MOVE, sourcePaths, destinationPath, dark);
        }

        // --- Core Execution ---

        private static void ExecuteShellOp(int operation, List<string> sources, string destination, bool dark)
        {
            if (dark) InitializeDarkMode();

            // The Shell API requires the source string to be terminated by two NULL characters.
            StringBuilder sb = new StringBuilder();
            foreach (string path in sources)
            {
                sb.Append(path).Append('\0');
            }
            sb.Append('\0');

            SHFILEOPSTRUCT fileOp = new SHFILEOPSTRUCT
            {
                wFunc = operation,
                pFrom = sb.ToString(),
                // Destination also needs a double-null if it's a list,
                // but a single null-terminated string works for a directory target.
                pTo = destination + '\0' + '\0',
                fFlags = FOF_ALLOWUNDO | FOF_NOCONFIRMMKDIR
            };

            int result = SHFileOperation(ref fileOp);

            // 0 indicates success. We check fAnyOperationsAborted in case the user
            // clicked "Cancel" on the Windows dialog.
            if (result != 0 && !fileOp.fAnyOperationsAborted)
            {
                throw new Exception($"Shell operation failed with error code: {result}");
            }
        }

        public static string NormalizePath(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return path;

            // Handle the Long Path Prefix specifically
            if (path.StartsWith(@"\\?\"))
            {
                // If it's a UNC network path: \\?\UNC\Server\Share -> \\Server\Share
                if (path.StartsWith(@"\\?\UNC\", StringComparison.OrdinalIgnoreCase))
                {
                    return @"\\" + path.Substring(8);
                }

                // If it's a local drive path: \\?\C:\Folder -> C:\Folder
                return path.Substring(4);
            }

            // Otherwise, let the OS normalize it (handles relative paths, dots, etc.)
            return Path.GetFullPath(path);
        }
    }
}