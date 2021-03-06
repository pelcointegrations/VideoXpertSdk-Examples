﻿using ExampleClient.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VxSdkNet;

namespace ExampleClient.Source
{
    public static class Utilities
    {
        #region Public Methods

        /// <summary>
        /// The BackgroundWorker_DoWork method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        public static void BackgroundWorker_DoWork(object sender, DoWorkEventArgs args)
        {
            MainForm.Instance.MainBeginInvoke(() => MainForm.Instance.dgvDataSources.Rows.Clear());

            if (MainForm.CurrentDevices != null)
                MainForm.CurrentDevices.Clear();
            MainForm.CurrentDevices = MainForm.CurrentSystem.Devices;

            if (MainForm.CurrentDataSources != null)
                MainForm.CurrentDataSources.Clear();

            ChangeProgressViewState(true);
            MainForm.CurrentDataSources = MainForm.CurrentSystem.DataSources;

            var dataSourceTotal = MainForm.CurrentDataSources.Count;
            var dataSourceNum = 0;
            foreach (var dataSource in MainForm.CurrentDataSources.Where(ds => ds.HostDevice.IsCommissioned))
            {
                dataSourceNum++;
                if (dataSource.Type != DataSource.Types.Video)
                    continue;

                var progress = (decimal)dataSourceNum / dataSourceTotal * 100;
                MainForm.Instance.bgWorker.ReportProgress((int)progress, null);
                Bitmap camIcon;
                if (dataSource.DataInterfaces.Any(item => (int)item.RenderType > 0 && (int)item.RenderType <= 4))
                {
                    camIcon = dataSource.State == DataSource.States.Offline ? Resources.cam_pano_offline : Resources.cam_pano;
                }
                else
                {
                    if (dataSource.IsPTZ)
                        camIcon = dataSource.State == DataSource.States.Offline ? Resources.cam_ptz_offline : Resources.cam_ptz;
                    else
                        camIcon = dataSource.State == DataSource.States.Offline ? Resources.cam_fixed_offline : Resources.cam_fixed;
                }

                object[] row = { camIcon, dataSource.Name, dataSource.Number.ToString() };
                var index = AddRowToGridView(row);
                var newRow = MainForm.Instance.dgvDataSources.Rows[index];
                newRow.Tag = dataSource;
            }

            MainForm.Instance.MainBeginInvoke(() =>
            {
                // If data source collection was successful enable the UI elements.
                MainForm.Instance.eventsToolStripMenuItem.Enabled = true;
                MainForm.Instance.manageToolStripMenuItem.Enabled = true;

                // If unknown we are logging in.
                if (MainForm.Instance.Control.States.VcrState == ControlManager.VcrMode.Unknown)
                {
                    MainForm.Instance.Control.SetVcrStates(ControlManager.VcrMode.Stopped);
                    MainForm.Instance.EnableModeByState();
                }
            });
        }

        /// <summary>
        /// The BackgroundWorker_ProgressChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        public static void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs args)
        {
            MainForm.Instance.MainBeginInvoke(() => MainForm.Instance.pbLoadCameras.Value = args.ProgressPercentage);
        }

        /// <summary>
        /// The BackgroundWorker_RunWorkerCompleted method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        public static void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs args)
        {
            ChangeProgressViewState(false);
        }

        /// <summary>
        /// The ColorToUInt method.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The <c>Color</c> value as a <c>uint</c>.</returns>
        public static uint ColorToUInt(Color color)
        {
            return (uint)((color.A << 24) | (color.R << 16) | (color.G << 8) | (color.B << 0));
        }

        /// <summary>
        /// The EncodeToBase64 method.
        /// </summary>
        /// <param name="toEncode">The string to encode to Base64.</param>
        /// <returns>The Base64 encoded string.</returns>
        public static string EncodeToBase64(string toEncode)
        {
            var toEncodeAsBytes = Encoding.ASCII.GetBytes(toEncode);
            var returnValue = Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }

        /// <summary>
        /// The RotateImage method.
        /// </summary>
        /// <param name="image">The image to be rotated.</param>
        /// <param name="rotationAngle">The angle (in degrees).</param>
        /// <returns>The rotated image.</returns>
        public static Image RotateImage(Image image, float rotationAngle)
        {
            if (image == null)
                return null;

            // Create an empty image.
            var bitmap = new Bitmap(image.Width, image.Height);
            bitmap.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            // Turn the bitmap into a graphics object.
            var graphics = Graphics.FromImage(bitmap);

            // Set the rotation point to the center of the image.
            graphics.TranslateTransform((float)bitmap.Width / 2, (float)bitmap.Height / 2);

            // Rotate the image.
            graphics.RotateTransform(rotationAngle);
            graphics.TranslateTransform(-(float)bitmap.Width / 2, -(float)bitmap.Height / 2);

            // Set the InterpolationMode to HighQualityBicubic to ensure a high
            // quality image once it is transformed to the specified size.
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw the new image onto the graphics object.
            graphics.DrawImage(image, new Point(0, 0));

            // Dispose of the graphics object.
            graphics.Dispose();

            // Return the image.
            return bitmap;
        }

        /// <summary>
        /// The SendRequest method.
        /// </summary>
        /// <param name="uri">The request <c>Uri</c>.</param>
        /// <returns>The response message.</returns>
        public static async Task<HttpResponseMessage> SendRequest(Uri uri)
        {
            // Create a new WebClient instance.
            var client = new HttpClient();

            // Supply the username and password that was used to create the VideoXpert system.
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            request.Headers.Add("X-Serenity-User", EncodeToBase64(MainForm.CurrentUserName));
            request.Headers.Add("X-Serenity-Password", EncodeToBase64(MainForm.CurrentPassword));

            // Forces the WebClient to trust the security certificate handed back from the VideoXpert server.
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            var response = await client.SendAsync(request);
            return response;
        }

        /// <summary>
        /// The UIntToColor method.
        /// </summary>
        /// <param name="color">The ARGB color as an <c>uint</c>.</param>
        /// <returns>The <c>uint</c> value as a <c>Color</c>.</returns>
        public static Color UIntToColor(uint color)
        {
            byte a = (byte)(color >> 24);
            byte r = (byte)(color >> 16);
            byte g = (byte)(color >> 8);
            byte b = (byte)(color >> 0);
            return Color.FromArgb(a, r, g, b);
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The AddRowToGridView method.
        /// </summary>
        /// <param name="item">The item to add to the list.</param>
        private static int AddRowToGridView(object[] item)
        {
            var rowIndex = 0;
            if (MainForm.Instance.dgvDataSources.InvokeRequired)
            {
                MainForm.Instance.MainInvoke(() => rowIndex = MainForm.Instance.dgvDataSources.Rows.Add(item));
            }
            else
                rowIndex = MainForm.Instance.dgvDataSources.Rows.Add(item);

            return rowIndex;
        }

        /// <summary>
        /// The ChangeProgressViewState method.
        /// </summary>
        /// <param name="isVisible">The value to set the visible property to.</param>
        private static void ChangeProgressViewState(bool isVisible)
        {
            MainForm.Instance.MainBeginInvoke(() =>
            {
                MainForm.Instance.pbLoadCameras.Visible = isVisible;
                MainForm.Instance.lblAddingCameras.Visible = isVisible;
                MainForm.Instance.btnRefreshDataSources.Visible = !isVisible;
            });
        }

        #endregion Private Methods
    }
}