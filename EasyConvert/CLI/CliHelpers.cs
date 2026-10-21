using System;
using System.IO;
using System.Runtime.InteropServices;

namespace EasyConvert.CLI
{
    public static class CliHelpers
    {
        [DllImport("kernel32.dll")]
        private static extern bool AttachConsole(int PID);

        private static readonly int ATTACH_TO_PARENT_CONSOLE = -1; 


        private static void InitializeConsoleOut()
        {
            Console.SetOut(new StreamWriter(Console.OpenStandardOutput())
            {
                AutoFlush = true
            });

            // you can set the error destanition here if you want
        }

        public static bool EnterCliMode()
        {
            bool AttachResult = AttachConsole(ATTACH_TO_PARENT_CONSOLE);

            if (AttachResult)
            {
                InitializeConsoleOut();
                Console.WriteLine();
            }

            return AttachResult;
        }
    }
}
