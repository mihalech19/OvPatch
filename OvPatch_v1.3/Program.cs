using System;
using System.Linq;
using System.Windows.Forms;

namespace OvPatch
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Environment.GetCommandLineArgs().Count() == 1)
                Application.Run(new MainForm());
            else
                OneClickPatch.PatchApply();}
    }
}