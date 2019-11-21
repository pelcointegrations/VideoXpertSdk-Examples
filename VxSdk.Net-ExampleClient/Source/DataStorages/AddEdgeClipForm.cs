using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddEdgeClipForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to create a new
    /// clip on the selected data storage.</remarks>
    public partial class AddEdgeClipForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddEdgeClipForm" /> class.
        /// </summary>
        /// <param name="dataStorage">The selected data storage.</param>
        public AddEdgeClipForm(DataStorage dataStorage)
        {
            InitializeComponent();
            SelectedDataStorage = dataStorage;
            PopulateDataStorages();
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the SelectedDataStorage property.
        /// </summary>
        /// <value>The selected data storage.</value>
        public DataStorage SelectedDataStorage { get; set; }

        #endregion Public Properties

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            if (lvEdgeClips.SelectedItems.Count < 1)
                return;

            var selectedClip = (Clip)lvEdgeClips.SelectedItems[0].Tag;
            var newClip = new NewClip
            {
                DataSourceId = selectedClip.DataSourceId,
                DataStorageId = SelectedDataStorage.Id,
                StartTime = dtpStartDate.Value.ToUniversalTime(),
                EndTime = dtpEndDate.Value.ToUniversalTime()
            };

            var result = SelectedDataStorage.AddClip(newClip);
            if (result != Results.Value.OK)
                MessageBox.Show($@"Unable to add new clip: {result}", @"Error");

            Close();
        }

        /// <summary>
        /// The ListViewDataStorages_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ListViewDataStorages_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (lvDataStorages.SelectedItems.Count < 1)
                return;

            btnAdd.Enabled = gbxEndTime.Enabled = gbxStartTime.Enabled = false;
            lvEdgeClips.Items.Clear();
            var dataStorage = (DataStorage)lvDataStorages.SelectedItems[0].Tag;
            foreach (var dataSource in dataStorage.HostDevice.DataSources)
            {
                foreach (var edgeClip in dataSource.EdgeClips)
                {
                    var lvItem = new ListViewItem(edgeClip.EventType.ToString());
                    lvItem.SubItems.Add(edgeClip.Framerate.ToString());
                    lvItem.SubItems.Add(edgeClip.StartTime.ToString("s"));
                    lvItem.SubItems.Add(edgeClip.EndTime.ToString("s"));
                    lvItem.Tag = edgeClip;
                    lvEdgeClips.Items.Add(lvItem);
                }
            }

            lblNoClips.Visible = lvEdgeClips.Items.Count == 0;
        }

        /// <summary>
        /// The ListViewEdgeClips_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter</param>
        /// <param name="args">The <paramref name="args"/> parameter</param>
        private void ListViewEdgeClips_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (lvEdgeClips.SelectedItems.Count < 1)
            {
                btnAdd.Enabled = gbxEndTime.Enabled = gbxStartTime.Enabled = false;
                return;
            }

            var selectedClip = (Clip)lvEdgeClips.SelectedItems[0].Tag;
            btnAdd.Enabled = gbxEndTime.Enabled = gbxStartTime.Enabled = true;

            // Get the start and end time of the selected clip.
            var startTime = selectedClip.StartTime.ToLocalTime();
            var endTime = selectedClip.EndTime.ToLocalTime();

            // Set up the DateTimePickers to only allow values within the selected
            // clips time frame.
            dtpStartDate.MinDate = startTime;
            dtpStartDate.MaxDate = endTime;
            dtpStartDate.Value = startTime;

            dtpEndDate.MinDate = startTime;
            dtpEndDate.MaxDate = endTime;
            dtpEndDate.Value = endTime;
        }

        /// <summary>
        /// The PopulateDataStorages method.
        /// </summary>
        private void PopulateDataStorages()
        {
            // Get the data storages from the VideoXpert system and add
            // them to the list view.
            foreach (var dataStorage in MainForm.CurrentSystem.DataStorages.Where(ds => ds.Type == DataStorage.DataStorageTypes.Edge))
            {
                var lvItem = new ListViewItem(dataStorage.HostDevice.Name);
                lvItem.SubItems.Add(dataStorage.HostDevice.Type.ToString());
                lvItem.Tag = dataStorage;
                lvDataStorages.Items.Add(lvItem);
            }
        }

        #endregion Private Methods
    }
}