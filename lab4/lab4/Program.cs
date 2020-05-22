using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using static lab4.WndSearcher;

namespace lab4
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Clear();
                CallBackPtr callBackPtr = new CallBackPtr(EnumReport.Show);
                EnumReport.EnumWindows(callBackPtr, 0);
                Console.WriteLine("\n\nPress Enter to refresh results or any button to exit");
            } while (Console.ReadKey(false).Key==ConsoleKey.Enter);
        }
    }

}