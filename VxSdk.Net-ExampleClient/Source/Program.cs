using System;
using System.Windows.Forms;

namespace ExampleClient.Source
{
    /// <summary>
    /// The Program class
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // Build the path to GStreamer based on the current system settings.
            var currentPath = new System.IO.DirectoryInfo(Application.ExecutablePath).Parent;
            Environment.SetEnvironmentVariable("PATH", currentPath?.FullName + "\\bin");
            //Environment.SetEnvironmentVariable("GST_DEBUG", "2");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
