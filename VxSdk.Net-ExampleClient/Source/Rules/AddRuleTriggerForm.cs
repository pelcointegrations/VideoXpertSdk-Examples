using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddRuleTriggerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to create a new
    /// event and push it to the VideoXpert system.</remarks>
    public partial class AddRuleTriggerForm : Form
    {
        private ListView TriggerListView { get; }

        private List<Device> DeviceList { get; }

        private List<DataSource> DataSourceList { get; }

        private List<DataStorage> DataStorageList { get; }

        private List<Tag> TagList { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRuleTriggerForm" /> class.
        /// </summary>    
        public AddRuleTriggerForm(ListView listView, List<Device> deviceList, List<DataSource> dataSourceList, List<DataStorage> dataStorageList, List<Tag> tagList)
        {
            InitializeComponent();
            TriggerListView = listView;

            DeviceList = deviceList;
            DataSourceList = dataSourceList;
            DataStorageList = dataStorageList;
            TagList = tagList;

            // Get the situations available on the VideoXpert system and use
            // them to pre-populate the type and device id drop downs.
            foreach (var situation in MainForm.CurrentSystem.Situations)
            {
                if (!string.IsNullOrEmpty(situation.Type))
                {
                    cbxSituationType.Items.Add(new ComboboxItem {Text = situation.Type, Value = ConvertSourceType(situation.ServiceType)});
                }
            }

            cbxSituationType.SelectedIndex = 0;
        }

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>     
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            var newRuleTrigger = new RuleTrigger { SituationType = cbxSituationType.SelectedItem.ToString() };
            if (chbxEnabled.Checked)
            {
                var resourceRefs = new List<ResourceRef>();
                var newResourceRef = new ResourceRef { Type = (ResourceRef.ResourceType) ((ComboboxItem) cbxSituationType.SelectedItem).Value };
                var sourceId = ((ComboboxItem)cbxSource.SelectedItem).Value as string;
                if (string.IsNullOrEmpty(sourceId))
                    return;

                newResourceRef.Id = sourceId;
                resourceRefs.Add(newResourceRef);
                newRuleTrigger.ResourceRefs = resourceRefs;
            }

            var lvItem = new ListViewItem(string.Empty);
            lvItem.SubItems.Add(newRuleTrigger.SituationType);
            lvItem.SubItems.Add(newRuleTrigger.ResourceRefs.Count > 0 ? newRuleTrigger.ResourceRefs[0].Id : @"All");
            lvItem.Tag = newRuleTrigger;
            TriggerListView.Items.Add(lvItem);
        }

        /// <summary>
        /// The ConvertSourceType method.
        /// </summary>
        /// <param name="sourceType">The <paramref name="sourceType"/> parameter.</param>
        private static ResourceRef.ResourceType ConvertSourceType(string sourceType)
        {
            switch (sourceType)
            {
                case "DataSource":
                    return ResourceRef.ResourceType.DataSource;
                case "DataStorage":
                case "Recorder":
                    return ResourceRef.ResourceType.DataStorage;
                case "Tag":
                    return ResourceRef.ResourceType.Tag;
                default:
                    return ResourceRef.ResourceType.Device;
            }
        }

        /// <summary>
        /// The ComboBoxSituationType_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ComboBoxSituationType_SelectedIndexChanged(object sender, EventArgs args)
        {
            cbxSource.Items.Clear();
            switch (ConvertSourceType(cbxSituationType.SelectedItem.ToString()))
            {
                case ResourceRef.ResourceType.DataSource:
                    lblType.Text = @"DataSource";
                    foreach (var dataSource in DataSourceList)
                        cbxSource.Items.Add(new ComboboxItem {Text = dataSource.Name, Value = dataSource.Id});

                    break;
                case ResourceRef.ResourceType.DataStorage:
                    lblType.Text = @"DataStorage";
                    foreach (var dataStorage in DataStorageList)
                        cbxSource.Items.Add(new ComboboxItem {Text = dataStorage.Name, Value = dataStorage.Id});

                    break;
                case ResourceRef.ResourceType.Tag:
                    lblType.Text = @"Tag";
                    foreach (var tag in TagList)
                        cbxSource.Items.Add(new ComboboxItem {Text = tag.Name, Value = tag.Id});

                    break;
                default:
                    lblType.Text = @"Device";
                    foreach (var device in DeviceList)
                        cbxSource.Items.Add(new ComboboxItem {Text = device.Name, Value = device.Id});

                    break;
            }
            cbxSource.SelectedIndex = 0;
        }

        /// <summary>
        /// The CheckBoxEnabled_CheckedChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void CheckBoxEnabled_CheckedChanged(object sender, EventArgs args)
        {
            lblType.Enabled = cbxSource.Enabled = lblSourceType.Enabled = lblSource.Enabled = chbxEnabled.Checked;
        }
    }
}
