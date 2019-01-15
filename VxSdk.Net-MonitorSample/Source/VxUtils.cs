using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using MonitorSample.Properties;
using VxSdkNet;

namespace MonitorSample
{
    /// <summary>
    /// The VxUtils class contains methods used to interact with a VideoXpert system.
    /// </summary>
    internal static class VxUtils
    {
        /// <summary>
        /// The license key to use during login.
        /// </summary>
        public const string LicenseKey = "ENTER_LICENSE_KEY_HERE";

        /// <summary>
        /// The VideoXpert system.
        /// </summary>
        private static VXSystem system;

        /// <summary>
        /// The selectable monitor layouts.
        /// </summary>
        public enum VxLayout
        {
            /// <summary>
            /// The 1x1 layout.
            /// </summary>
            Layout1X1,

            /// <summary>
            /// The 2x2 layout.
            /// </summary>
            Layout2X2,

            /// <summary>
            /// The 3x3 layout.
            /// </summary>
            Layout3X3,

            /// <summary>
            /// The 4x4 layout.
            /// </summary>
            Layout4X4
        }

        /// <summary>
        /// Gets the list of available cameras.
        /// </summary>
        public static BindingList<DataSource> Cameras { get; } = new BindingList<DataSource>();

        /// <summary>
        /// Gets the list of available monitors.
        /// </summary>
        public static BindingList<Monitor> Monitors { get; } = new BindingList<Monitor>();

        /// <summary>
        /// Gets the expiration date of the VideoXpert grace license (if in use).
        /// </summary>
        public static DateTime ExpirationDate { get; } = system?.GraceLicenseExpirationTime.ToLocalTime() ?? DateTime.MinValue;

        /// <summary>
        /// Changes the layout on the remote monitor.
        /// </summary>
        /// <param name="monitor">The monitor to modify.</param>
        /// <param name="layout">The layout to be set on the monitor.</param>
        /// <returns>The ChangeLayout Task.</returns>
        public static async Task ChangeLayout(Monitor monitor, VxLayout layout)
        {
            if (system == null)
                return;

            switch (layout)
            {
                case VxLayout.Layout1X1:
                    await Task.Run(() => monitor.Layout = Monitor.Layouts.CellLayout1x1);
                    break;
                case VxLayout.Layout2X2:
                    await Task.Run(() => monitor.Layout = Monitor.Layouts.CellLayout2x2);
                    break;
                case VxLayout.Layout3X3:
                    await Task.Run(() => monitor.Layout = Monitor.Layouts.CellLayout3x3);
                    break;
                case VxLayout.Layout4X4:
                    await Task.Run(() => monitor.Layout = Monitor.Layouts.CellLayout4x4);
                    break;
            }
        }

        /// <summary>
        /// Gets all data sources (cameras) from the VideoXpert system and stores them in the <see cref="Cameras"/> list.
        /// </summary>
        /// <returns>The GetCameras Task.</returns>
        public static async Task GetCameras()
        {
            if (system == null)
                return;

            Cameras.Clear();
            var cameras = await Task.Run(() => system.DataSources);
            foreach (var camera in cameras)
                Cameras.Add(camera);
        }

        /// <summary>
        /// Gets all monitors from the VideoXpert system and stores them in the <see cref="Monitors"/> list.
        /// </summary>
        /// <returns>The GetMonitors Task.</returns>
        public static async Task GetMonitors()
        {
            if (system == null)
                return;

            Monitors.Clear();
            var monitors = await Task.Run(() => system.Monitors);
            foreach (var monitor in monitors)
                Monitors.Add(monitor);
        }

        /// <summary>
        /// Initializes and logs in to a VideoXpert system.
        /// </summary>
        /// <param name="ip">The IP address of the system.</param>
        /// <param name="username">The user name to log in with.</param>
        /// <param name="password">The password to log in with.</param>
        /// <returns>The Init Task.</returns>
        public static async Task<Results.Value> Init(string ip, string username, string password)
        {
            var retVal = Results.Value.UnknownError;
            try
            {
                system = new VXSystem(ip, 443, true, LicenseKey);
                retVal = await Task.Run(() => system.Login(username, password));
            }
            catch (Exception e)
            {
                Trace.WriteLine(new Exception(Resources.InitErrorMessage, e));
                system = null;
            }

            return retVal;
        }

        /// <summary>
        /// Displays a data source in a monitor cell.
        /// </summary>
        /// <param name="monitor">The monitor to display the data source on.</param>
        /// <param name="cellIdx">The index of the cell to place the data source on.</param>
        /// <param name="dataSource">The data source to display.</param>
        /// <param name="dateTime">The time to start video playback.  Use a default <see cref="DateTime"/> for live.</param>
        /// <returns>The PlayVideoInCell Task.</returns>
        public static async Task PlayVideoInCell(Monitor monitor, int cellIdx, DataSource dataSource, DateTime dateTime)
        {
            var live = dateTime == default(DateTime);
            var cell = monitor.MonitorCells[cellIdx];
            cell.DataSourceId = dataSource.Id;
            if (live)
                await Task.Run(() => cell.GoToLive());
            else
                await Task.Run(() => cell.Time = dateTime.ToUniversalTime());
        }
    }
}
