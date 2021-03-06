﻿using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The NewExportForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to create clips,
    /// add them to a new export and begin the export process.</remarks>
    public partial class NewExportForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NewExportForm" /> class.
        /// </summary>
        public NewExportForm()
        {
            InitializeComponent();

            // Clone each item in the MainForm ListView and add it to lvDataSources.
            foreach (DataGridViewRow item in MainForm.Instance.dgvDataSources.Rows)
            {
                var ds = (DataSource)item.Tag;
                var lvItem = new ListViewItem(ds.Name);
                lvItem.SubItems.Add(ds.Number.ToString());
                lvItem.Tag = ds;
                lvDataSources.Items.Add(lvItem);
            }

            Instance = this;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets the Instance property.
        /// </summary>
        /// <value>The current <see cref="NewExportForm"/> instance.</value>
        public static NewExportForm Instance { get; private set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// The ListViewDevices_ItemSelected method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        /// <remarks>Populates the available clips list when a new device is selected.</remarks>
        public void ListViewDevices_ItemSelected(object sender, EventArgs args)
        {
            try
            {
                lvAvailableClips.Items.Clear();

                if (lvDataSources.SelectedItems.Count == 0) return;

                // Get the selected device.
                var dataSource = (DataSource)lvDataSources.SelectedItems[0].Tag;

                foreach (var dataInterface in dataSource.DataInterfaces)
                {
                    // If the protocol is not Rtsp/Rtp then it will not be recording.
                    if (dataInterface.Protocol != DataInterface.StreamProtocols.RtspRtp)
                        continue;

                    var clips = dataSource.Clips;
                    if (clips.Count <= 0)
                        continue;

                    foreach (var clip in clips)
                    {
                        var lvItem = new ListViewItem(clip.EventType.ToString());
                        lvItem.SubItems.Add(clip.StartTime.ToLocalTime().ToString("s"));
                        lvItem.SubItems.Add(clip.EndTime.ToLocalTime().ToString("s"));
                        lvItem.Tag = clip;
                        lvAvailableClips.Items.Add(lvItem);
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                MainForm.Instance.WriteToLog($"Error: {ex.Message}");
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The ButtonAddClip_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.s</param>
        private void ButtonAddClip_Click(object sender, EventArgs args)
        {
            if (lvAvailableClips.SelectedItems.Count == 0)
                return;

            using (var addClipForm = new AddClipForm())
            {
                addClipForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonEstimateExport_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.s</param>
        private void ButtonEstimateExport_Click(object sender, EventArgs args)
        {
            var newExport = new NewExport();
            foreach (ListViewItem item in lvAddedClips.Items)
            {
                var clip = (NewExportClip)item.Tag;
                newExport.Clips.Add(clip);
            }

            newExport.Format = Export.Formats.MkvZip;
            newExport.Name = tbxExportName.Text;
            newExport.Password = tbxExportPassword.Text;
            var estimate = MainForm.CurrentSystem.GetExportEstimate(newExport);
            if (estimate != null)
            {
                lblTooLargeValue.Text = estimate.IsTooLarge.ToString();
                if (estimate.Size < 1024)
                    lblSizeValue.Text = estimate.Size + @" KB";
                else if (estimate.Size < 1048576)
                    lblSizeValue.Text = Math.Round((double)estimate.Size / 1024, 1) + @" MB";
                else
                    lblSizeValue.Text = Math.Round((double)estimate.Size / 1024 / 1024, 1) + @" GB";
            }
            else
            {
                lblTooLargeValue.Text = string.Empty;
                lblSizeValue.Text = "Error";
            }
        }

        /// <summary>
        /// The ButtonExport_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonExport_Click(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(tbxExportName.Text))
                return;

            var newExport = new NewExport();
            foreach (ListViewItem item in lvAddedClips.Items)
            {
                var clip = (NewExportClip)item.Tag;
                newExport.Clips.Add(clip);
            }
            newExport.Format = Export.Formats.MkvZip;
            newExport.Name = tbxExportName.Text;
            newExport.Password = tbxExportPassword.Text;
            MainForm.CurrentSystem.AddExport(newExport);

            Close();
        }

        /// <summary>
        /// The ButtonRemoveClip_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.s</param>
        private void ButtonRemoveClip_Click(object sender, EventArgs args)
        {
            if (lvAddedClips.SelectedItems.Count != 0)
                lvAddedClips.SelectedItems[0].Remove();
        }

        #endregion Private Methods
    }
}