using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace lpgui
{
    class DLLImports
    {
        public const int MB_ICONEXCLAMATION = 48;

        [DllImport("user32.dll")]
        public static extern bool MessageBeep(uint uType);
    }
}
