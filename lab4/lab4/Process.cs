using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace lab4
{
    public class WndSearcher
    {
        public delegate bool CallBackPtr(IntPtr hwnd, int lParam);

        public CallBackPtr callBackPtr;

        public class EnumReport
        {
            [DllImport("user32.dll")]
            public static extern int EnumWindows(CallBackPtr callPtr, int lPar);

            [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
            public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

            public static bool Show(IntPtr hwnd, int lParam)
            {
                StringBuilder Name = new StringBuilder();
                StringBuilder Decription = new StringBuilder();
                Name.Capacity = 1024;
                Decription.Capacity = 1024;
                GetClassName(hwnd, Name, Name.Capacity);
                GetWindowText(hwnd, Decription, Decription.Capacity);
                Console.WriteLine($"Name: {Name}\nProcess Decription: {Decription}\n");
                return true;
            }
        }
    }
}