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
            // You may set this environment variable to gain g-streamer debug information.
            //   See the g-streamer documentation for more information.
            //Environment.SetEnvironmentVariable("GST_DEBUG", "2");


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        // private static string _licenseString = "ENTER_LICENSE_KEY_HERE";
        public static string _licenseString = "DCovPywTKiY5LgolLiYsKCI/MywlBRUTdxAAD24dGxsfFRE=";
        public static string LicenseString { get => _licenseString; }

    }
}
