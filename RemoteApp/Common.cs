using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

namespace RemoteApp
{
    class Common
    {
        public static int processid=0;

        [DllImport("user32", EntryPoint = "GetWindowThreadProcessId")]
        private static extern int GetWindowThreadProcessId(IntPtr hwnd, out int pid);

        public static void GetFormProcessId()
        {
            while (true)
            {
                int processId = 0;
                IntPtr handle = FindWindow.GetForegroundWindow();
                processid = GetWindowThreadProcessId(handle, out processId);
                Thread.Sleep(2000);
            }

        }

        public static void TestFunc()
        {
            Thread thread=new Thread(GetFormProcessId);
            thread.Start();
        }
    }
}
