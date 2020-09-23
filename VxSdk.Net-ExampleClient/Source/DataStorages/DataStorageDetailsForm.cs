using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The DataStorageDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the detailed info for the selected data storage.</remarks>
    public partial class DataStorageDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DataStorageDetailsForm" /> class.
        /// </summary>
        public DataStorageDetailsForm()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// The GetDataStorageInfo method.
        /// </summary>
        /// <param name="dataStorage">The <paramref name="dataStorage"/> to get information for.</param>
        public void GetDataStorageInfo(DataStorage dataStorage)
        {
            if (dataStorage == null)
                return;

            AddDataStorageInfo(dataStorage);
            AddRetentionInfo(dataStorage);
            AddStorageConfigInfo(dataStorage);

            if (dataStorage.DataSources.Count > 0)
                AddDataSourceInfo(dataStorage);
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The AddDataSourceInfo method.
        /// </summary>
        /// <param name="dataStorage">The <paramref name="dataStorage"/> to add the info for.</param>
        private void AddDataSourceInfo(DataStorage dataStorage)
        {
            var lvItem = new ListViewItem(string.Empty) { BackColor = Color.LightGray };
            lvItem.SubItems.Add("Assignments");
            lvDataStorageDetails.Items.Add(lvItem);
            foreach (var dataSource in dataStorage.DataSources)
            {
                var lvSubItem = new ListViewItem(string.Empty);
                lvSubItem.SubItems.Add("Camera");
                lvSubItem.SubItems.Add(dataSource.Name);
                lvDataStorageDetails.Items.Add(lvSubItem);
            }
        }

        /// <summary>
        /// The AddRetentionInfo method.
        /// </summary>
        /// <param name="dataStorage">The <paramref name="dataStorage"/> to add the info for.</param>
        private void AddRetentionInfo(DataStorage dataStorage)
        {
            var lvItem = new ListViewItem(string.Empty) { BackColor = Color.LightGray };
            lvItem.SubItems.Add("Retentions");
            lvDataStorageDetails.Items.Add(lvItem);
            var dataSources = dataStorage.DataSources;
            foreach (var retention in dataStorage.Retentions)
            {
                var dataSource = dataSources.FirstOrDefault(ds => ds.Id == retention.Resource.Id);
                var lvSubItem = new ListViewItem(string.Empty);
                lvSubItem.SubItems.Add(dataSource?.Name);
                lvSubItem.SubItems.Add(retention.OldestRecording.ToString("u"));
                lvDataStorageDetails.Items.Add(lvSubItem);
            }
        }

        /// <summary>
        /// The AddDataStorageInfo method.
        /// </summary>
        /// <param name="dataStorage">The <paramref name="dataStorage"/> to add the info for.</param>
        private void AddDataStorageInfo(DataStorage dataStorage)
        {
            var lvMainItem = new ListViewItem(string.Empty) { BackColor = Color.LightGray };
            lvMainItem.SubItems.Add("Data Storage");
            lvDataStorageDetails.Items.Add(lvMainItem);

            // Use reflection to get each available property from the schedule.
            foreach (var prop in dataStorage.GetType().GetProperties())
            {
                // Get the value from the property.
                var val = prop.GetValue(dataStorage, null);
                if (val == null)
                    continue;

                // Get each item if the value is a List type and generate a string.
                if (val.GetType() != typeof(string))
                    continue;

                var valList = val.ToString();

                // Add the property name and value to the list view.
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(prop.Name);
                lvItem.SubItems.Add(valList);
                lvDataStorageDetails.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The AddStorageConfigInfo method.
        /// </summary>
        /// <param name="dataStorage">The <paramref name="dataStorage"/> to add the info for.</param>
        private void AddStorageConfigInfo(DataStorage dataStorage)
        {
            var config = dataStorage.Configuration;
            if (config == null)
                return;

            var lvItem = new ListViewItem(string.Empty) { BackColor = Color.LightGray };
            lvItem.SubItems.Add("Config");
            lvDataStorageDetails.Items.Add(lvItem);

            // Use reflection to get each available property from the configuration object.
            foreach (var prop in config.GetType().GetProperties())
            {
                string valItem;

                // Skip unreadable properties.
                if (!prop.CanRead)
                    continue;

                // Get the value from the property.
                var val = prop.GetValue(config, null);

                // Skip the property if the value is a volume or volume group list.
                if (val == null || val.GetType() == typeof(List<VolumeGroup>) || val.GetType() == typeof(List<Volume>))
                    continue;

                // Convert the property to a local time string if it's a DateTime type.
                if (val is DateTime)
                {
                    var time = (DateTime)val;
                    valItem = time.ToLocalTime().ToString(CultureInfo.InvariantCulture);
                }
                else if (val.GetType() == typeof(List<string>))
                {
                    var valList = val as List<string>;
                    valItem = string.Join(", ", valList);
                }
                else
                    valItem = val.ToString();

                // Add the property name and value to the list view.
                var lvItem2 = new ListViewItem(string.Empty);
                lvItem2.SubItems.Add(prop.Name);
                lvItem2.SubItems.Add(valItem);
                lvDataStorageDetails.Items.Add(lvItem2);
            }
        }

        #endregion Private Methods
    }
}