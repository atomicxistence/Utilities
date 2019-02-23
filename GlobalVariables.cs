using System;

namespace Utilities.ConsoleUI
{
    public static class GlobalVariables
    {
        #region Colors
        public static ConsoleColor highlightColor = ConsoleColor.Cyan;
        public static ConsoleColor textColor = ConsoleColor.Black;
        public static ConsoleColor borderColor = ConsoleColor.DarkCyan;
        public static ConsoleColor titleHighlightColor = ConsoleColor.DarkMagenta;
        #endregion

        public static readonly int rowLength = 60;

        public static string SelectionIndicator
        {
            get
            {
                switch (Environment.OSVersion.Platform)
                {
                    case PlatformID.Win32S:
                    case PlatformID.Win32Windows:
                    case PlatformID.Win32NT:
                    case PlatformID.WinCE:
                        return " > ";
                    case PlatformID.MacOSX:
                        return " ► ";
                    default:
                        return " > ";
                }
            }   
        }
    }
}
