using System;
using System.Windows.Forms;

namespace Drummers_metronome_Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new PlaylistEditor("TestList.dat"));
            }
            catch(Exception e)
            {
                HandleException(e);
            }
        }

        private static void HandleException(Exception e)
        {
            MessageBox.Show(
                "An exception has occurred and the metronome must shut down." + Environment.NewLine
                + " Debug information:" + Environment.NewLine
                + e.Message + Environment.NewLine
                + e.StackTrace, "Fatal error");
            Application.Exit();
        }
    }
}
