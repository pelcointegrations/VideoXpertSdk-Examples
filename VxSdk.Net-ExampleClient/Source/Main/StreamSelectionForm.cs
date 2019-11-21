using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The StreamSelectionForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to select a stream.</remarks>
    public partial class StreamSelectionForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamSelectionForm" /> class.
        /// </summary>
        /// <param name="dataInterfaces">The data interfaces to get streams from.</param>
        public StreamSelectionForm(IReadOnlyCollection<DataInterface> dataInterfaces)
        {
            InitializeComponent();
            DisplayedListView = lvStreams;
            var isDetailed = dataInterfaces.Any(iface => iface.DataEncodingId != string.Empty);
            if (isDetailed)
            {
                lvStreams.Visible = false;
                lvDetailedStreams.Visible = true;
                DisplayedListView = lvDetailedStreams;
            }

            // Iterate the data interface list and parse out the endpoint URL.
            var interfaceList = new Dictionary<string, DataInterface>();
            foreach (var dataInterface in dataInterfaces)
            {
                if (isDetailed)
                {
                    var lvItem = new ListViewItem(dataInterface.DataEncodingId) { Tag = dataInterface };
                    lvItem.SubItems.Add(dataInterface.SupportsMulticast.ToString());
                    lvItem.SubItems.Add(Math.Abs(dataInterface.Framerate) < 1 ? "Unknown" : dataInterface.Framerate.ToString(CultureInfo.InvariantCulture));
                    lvItem.SubItems.Add(dataInterface.Bitrate == 0 ? "Unknown" : dataInterface.Bitrate.ToString());
                    lvItem.SubItems.Add($"{dataInterface.XResolution}x{dataInterface.YResolution}");
                    lvItem.SubItems.Add(dataInterface.IsTranscoded.ToString());
                    DisplayedListView.Items.Add(lvItem);
                }
                else
                {
                    IEnumerable<string> set = dataInterface.DataEndpoint.Split('&');
                    foreach (var section in set)
                    {
                        if (!section.StartsWith("streaming_uri="))
                            continue;

                        var url = System.Net.WebUtility.UrlDecode(section.Substring(14));
                        interfaceList[url] = dataInterface;
                    }
                }
            }

            if (isDetailed)
                return;

            // Populate the stream list.
            foreach (var item in interfaceList)
            {
                var lvItem = new ListViewItem(item.Key) { Tag = item.Value };
                DisplayedListView.Items.Add(lvItem);
            }
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the DisplayedListView property.
        /// </summary>
        /// <value>The list view to display to the user.</value>
        public ListView DisplayedListView { get; set; }

        /// <summary>
        /// Gets or sets the SelectedInterface property.
        /// </summary>
        /// <value>The currently selected data interface.</value>
        public DataInterface SelectedInterface { get; set; }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// The ButtonOk_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonOk_Click(object sender, EventArgs args)
        {
            // Close the dialog if no situations are checked.
            if (DisplayedListView.SelectedItems.Count == 0)
                return;

            SelectedInterface = (DataInterface)DisplayedListView.SelectedItems[0].Tag;
        }

        #endregion Private Methods
    }
}