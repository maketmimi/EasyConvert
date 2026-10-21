using EasyConvert.CLI;
using System;
using System.Windows.Forms;

namespace EasyConvert
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                if (CliHelpers.EnterCliMode())
                {
                    CliUtility.Run(args);
                }

                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
