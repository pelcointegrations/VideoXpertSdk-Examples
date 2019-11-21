using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source.Exports
{
    public partial class LocalExportSelect : Form
    {
        #region Private Fields

        private WebClient _webClient;

        private long _webClientBytesReceived = 0;

        private bool _webClientDownloadComplete = false;

        #endregion Private Fields

        #region Public Constructors

        public LocalExportSelect()
        {
            InitializeComponent();

            // Clone each item in the MainForm ListView and add it to lvDataSources.
            // If it has any recording
            foreach (DataGridViewRow item in MainForm.Instance.dgvDataSources.Rows)
            {
                var ds = (DataSource)item.Tag;
                if (ds.Clips.Count > 0)
                {
                    var lvItem = new ListViewItem(ds.Name);
                    lvItem.SubItems.Add(ds.Number.ToString());
                    lvItem.Tag = ds;
                    listView_dataSources.Items.Add(lvItem);
                }
            }
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// The WebClientDownloadFileCompleted method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        /// <remarks>Checks to see if the download completed event was due to an error or cancellation.</remarks>
        public void WebClientDownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs args)
        {
            if (args?.Error == null)
                return;

            _webClientDownloadComplete = true;
        }

        public void WebClientDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs args)
        {
            _webClientBytesReceived = args.BytesReceived;
        }

        #endregion Public Methods

        #region Private Methods

        /// <returns>The Base64 encoded string.</returns>
        private static string EncodeToBase64(string toEncode)
        {
            var toEncodeAsBytes = System.Text.Encoding.ASCII.GetBytes(toEncode);
            var returnValue = Convert.ToBase64String(toEncodeAsBytes);
            return returnValue;
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            if (textBox_fileName.Text == "")
            {
                MessageBox.Show("Must select MP4 file name");
                return;
            }
            if (dateTimePicker_end.Value < dateTimePicker_start.Value)
            {
                MessageBox.Show("End time must be after start time");
                return;
            }
            if (listView_dataSources.SelectedItems.Count == 0) return;

            // Get the selected device.
            var dataSource = (DataSource)listView_dataSources.SelectedItems[0].Tag;

            DateTime startTime = new DateTime(dateTimePicker_start.Value.Ticks, DateTimeKind.Local);
            DateTime endTime = new DateTime(dateTimePicker_end.Value.Ticks, DateTimeKind.Local);

            // Get the clips first using a time filter
            Dictionary<Filters.Value, string> timeFilter = new Dictionary<Filters.Value, string>();
            timeFilter.Add(Filters.Value.SearchStartTime, startTime.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'"));
            timeFilter.Add(Filters.Value.SearchEndTime, endTime.ToUniversalTime().ToString("yyyy-MM-dd'T'HH:mm:ss.fff'Z'"));
            var clipListSource = dataSource.GetClips(timeFilter);

            if (clipListSource.Count == 0)
            {
                MessageBox.Show("Did not find any recorded video at this time");
                return;
            }

            List<NewExportClip> exportedClips = new List<NewExportClip>();
            // Fill in the clip list for the export (there may be gaps)
            for (int i = 0; i < clipListSource.Count; i++)
            {
                NewExportClip newExportClip = new NewExportClip();
                newExportClip.DataSourceId = dataSource.Id;
                // Check and move the start time to the passed in start time if it is after the first clip start time
                if ((i == 0) && (startTime.ToUniversalTime() > clipListSource[i].StartTime))
                {
                    newExportClip.StartTime = startTime.ToUniversalTime();
                }
                else
                {
                    newExportClip.StartTime = clipListSource[i].StartTime;
                }

                // Check and move the end time to the passed in end time if it is before the last clip end time
                if ((i == clipListSource.Count - 1) && (endTime.ToUniversalTime() < clipListSource[i].EndTime))
                {
                    newExportClip.EndTime = endTime.ToUniversalTime();
                }
                else
                {
                    newExportClip.EndTime = clipListSource[i].EndTime;
                }
                exportedClips.Add(newExportClip);
            }

            var newExport = new NewExport();
            newExport.Format = Export.Formats.MkvZip;
            string exportFileName = System.Guid.NewGuid().ToString();
            newExport.Name = exportFileName;
            newExport.Clips = exportedClips;
            MainForm.CurrentSystem.AddExport(newExport);

            // Wait for export to finish, then download, then unzip,
            //   then merge files if necessary
            Exports.ExportDownloadProgess exportDownloadProgess = new Exports.ExportDownloadProgess();
            System.Threading.Tasks.Task exportProgress = new System.Threading.Tasks.Task(() =>
            {
                exportDownloadProgess.ShowDialog();
            });
            exportProgress.Start();

            // Wait for server to make the export file
            Export addedExport;
            float lastPerentComplete = 0.0F;
            int lastSecondsRemaining = int.MaxValue;
            while (true)
            {
                // First - get the export from the server.   It can take a little bit
                //   for an export to show up.  Wait up to 30 seconds
                var filter = new System.Collections.Generic.Dictionary<Filters.Value, string>();
                filter.Add(Filters.Value.Name, newExport.Name);
                System.Collections.Generic.List<Export> exportList = null;
                for (int i = 0; i < 60; i++)
                {
                    exportList = MainForm.CurrentSystem.GetExports(filter);
                    if (exportList.Count > 0)
                    {
                        break;
                    }
                    System.Threading.Thread.Sleep(500);
                }
                if (exportList.Count == 0)
                {
                    MessageBox.Show("could not retreive export named:  " + newExport.Name);
                    exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
                    {
                        exportDownloadProgess.Close();
                    });
                    Close();
                    return;
                }
                addedExport = exportList[0];

                // Check for done
                if (addedExport.Status == Export.States.Successful)
                {
                    break;
                }

                string status = "Vx Sever Progress:  ";
                status += lastPerentComplete = (addedExport.PercentComplete > lastPerentComplete) ? addedExport.PercentComplete : lastPerentComplete;
                status += "%     Time Left:  ";
                status += lastSecondsRemaining = (addedExport.SecondsRemaining < lastSecondsRemaining) ? addedExport.SecondsRemaining : lastSecondsRemaining;
                status += "s";
                exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
                {
                    exportDownloadProgess.textBox_status.Text = status;
                });
                if (exportDownloadProgess.Canceled == true)
                {
                    exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
                    {
                        exportDownloadProgess.Close();
                    });
                    Close();
                    return;
                }
                System.Threading.Thread.Sleep(500);
            }

            string[] progressString = new string[3];
            progressString[0] = "VideoXpert Server Finished Making File.";
            progressString[1] = "Download 0 KB of " + addedExport.FileSizeKb + " KB";
            progressString[2] = "....";

            exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
            {
                exportDownloadProgess.textBox_status.Lines = progressString;
            });
            // Get the export file
            // Create a new WebClient instance.
            _webClient = new WebClient();

            // Sets the WebClient to use the correct SecurityProtocol for the VideoXpert server.
            if (ServicePointManager.SecurityProtocol != (SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3))
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;

            // Forces the WebClient to trust the security certificate handed back from the VideoXpert server.
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

            // Supply the username and password that was used to create the VideoXpert system.
            _webClient.Headers.Add("X-Serenity-User", EncodeToBase64(MainForm.CurrentUserName));
            _webClient.Headers.Add("X-Serenity-Password", EncodeToBase64(MainForm.CurrentPassword));

            // Subscribe to the download events.
            _webClient.DownloadProgressChanged += WebClientDownloadProgressChanged;
            _webClient.DownloadFileCompleted += WebClientDownloadFileCompleted;
            _webClient.DownloadFileAsync(new Uri(addedExport.DataUri), Path.GetTempPath() + addedExport.Name + ".zip");

            while (true)
            {
                System.Threading.Thread.Sleep(500);
                if ((_webClientDownloadComplete == true) || (_webClient.IsBusy == false))
                {
                    progressString[1] = "Download 100%";
                    progressString[2] = "Making MP4 File (This may take several minutes)";
                    exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
                    {
                        exportDownloadProgess.textBox_status.Lines = progressString;
                    });
                    break;
                }
                progressString[1] = "Download " + (_webClientBytesReceived / 1024) + " KB of " + addedExport.FileSizeKb + " KB";
                if (exportDownloadProgess.Canceled == true)
                {
                    exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
                    {
                        exportDownloadProgess.Close();
                    });
                    Close();
                }
            }

            _webClient.DownloadProgressChanged -= WebClientDownloadProgressChanged;
            _webClient.DownloadFileCompleted -= WebClientDownloadFileCompleted;
            _webClient.Dispose();
            if (exportDownloadProgess.Canceled == true) return;

            string tempDir = Path.Combine(Path.GetTempPath(), addedExport.Name);
            Directory.CreateDirectory(tempDir);
            ZipFile.ExtractToDirectory(Path.GetTempPath() + addedExport.Name + ".zip", tempDir);

            // Get all the MKV files in the temp directory
            string[] mkvFiles = Directory.GetFiles(tempDir, "*.mkv");

            if (mkvFiles.Count() == 0)
            {
                MessageBox.Show("Cannot find mkv files in zip");
                exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
                {
                    exportDownloadProgess.Close();
                });
                Close();
                return;
            }

            // Change the files to .mp4 using ffmpeg
            try
            {
                if (mkvFiles.Count() == 1)
                {
                    using (var process = new Process())
                    {
                        process.StartInfo.UseShellExecute = false;
                        process.StartInfo.CreateNoWindow = true;
                        process.StartInfo.RedirectStandardOutput = true;
                        process.StartInfo.FileName = "ffmpeg.exe";
                        process.StartInfo.Arguments = "-y -i \"" + mkvFiles[0] + "\" " + textBox_fileName.Text;
                        process.Start();
                        process.WaitForExit();
                    }
                }
                else
                {
                    // In this case, you need to make several 'ts' files and then concat them together
                    foreach (string mkvFile in mkvFiles)
                    {
                        using (var process = new Process())
                        {
                            process.StartInfo.UseShellExecute = false;
                            process.StartInfo.CreateNoWindow = true;
                            process.StartInfo.RedirectStandardOutput = true;
                            process.StartInfo.FileName = "ffmpeg.exe";
                            process.StartInfo.Arguments = "-i \"" + mkvFile + "\" -c:v mpeg4 -q:v 0 -max_muxing_queue_size 9999 \"" + mkvFile + ".ts\"";
                            process.Start();
                            process.WaitForExit();
                        }
                        if (exportDownloadProgess.Canceled == true)
                        {
                            exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
                            {
                                exportDownloadProgess.Close();
                            });
                            Close();
                            break;
                        }
                    }
                    // Now merge all the files together
                    string fileList = "concat:";
                    if (exportDownloadProgess.Canceled == false)
                    {
                        foreach (string mkvFile in mkvFiles)
                        {
                            fileList += mkvFile + ".ts|";
                        }
                        // Remove the last '|'
                        fileList = fileList.Substring(0, fileList.Length - 1);
                        using (var process = new Process())
                        {
                            process.StartInfo.UseShellExecute = false;
                            process.StartInfo.CreateNoWindow = true;
                            process.StartInfo.RedirectStandardOutput = true;
                            process.StartInfo.FileName = "ffmpeg.exe";
                            process.StartInfo.Arguments = "-y -i \"" + fileList + "\" \"" + textBox_fileName.Text + "\"";
                            process.Start();
                            process.WaitForExit();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
                {
                    exportDownloadProgess.Close();
                });

                MessageBox.Show("Error making MP4 File  " + exception.ToString());
                exportDownloadProgess.BeginInvoke((MethodInvoker)delegate
                {
                    exportDownloadProgess.Close();
                });
                DialogResult = DialogResult.Abort;
                Close();
            }
            // Delete the export from the server
            addedExport.TrashExport();

            // Delete any temp files
            var filesToDelete = Directory.EnumerateFiles(tempDir);
            foreach (var file in filesToDelete)
            {
                File.Delete(file);
            }
            Directory.Delete(tempDir);
            File.Delete(Path.GetTempPath() + addedExport.Name + ".zip");

            exportDownloadProgess?.BeginInvoke((MethodInvoker)delegate
            {
                exportDownloadProgess?.Close();
            });
            DialogResult = (exportDownloadProgess.Canceled == true) ? DialogResult.Cancel : DialogResult.OK;
            Close();
        }

        private void button_fileSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "MP4 File|*.mp4";
            dialog.Title = "Save Export File As ...";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                textBox_fileName.Text = dialog.FileName;
            }

            if (listView_dataSources.SelectedItems.Count != 0)
            {
                button_export.Enabled = true;
            }
        }

        private void listView_dataSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_dataSources.SelectedItems.Count == 0)
            {
                // Gray out buttons
                dateTimePicker_end.Enabled = false;
                dateTimePicker_start.Enabled = false;
                button_export.Enabled = false;
                return;
            }

            dateTimePicker_end.Enabled = true;
            dateTimePicker_start.Enabled = true;
            if (textBox_fileName.Text != "")
            {
                button_export.Enabled = true;
            }

            // Get the selected device.
            var dataSource = (DataSource)listView_dataSources.SelectedItems[0].Tag;

            var clips = dataSource.Clips;

            dateTimePicker_start.MaxDate = clips[clips.Count - 1].EndTime.ToLocalTime().AddSeconds(-5);
            dateTimePicker_start.MinDate = clips[0].StartTime.ToLocalTime();
            dateTimePicker_start.Value = clips[0].StartTime.ToLocalTime();

            dateTimePicker_end.MaxDate = clips[clips.Count - 1].EndTime.ToLocalTime();
            dateTimePicker_end.MinDate = clips[0].StartTime.ToLocalTime().AddSeconds(5);
            dateTimePicker_end.Value = clips[clips.Count - 1].EndTime.ToLocalTime();
        }

        private void textBox_fileName_TextChanged(object sender, EventArgs e)
        {
            if (textBox_fileName.Text != "")
            {
                button_export.Enabled = true;
            }
        }

        #endregion Private Methods
    }
}