using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyTagForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a tag.</remarks>
    public partial class ModifyTagForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyTagForm" /> class.
        /// </summary>
        /// <param name="tag">The <paramref name="tag"/> parameter.</param>
        public ModifyTagForm(Tag tag)
        {
            InitializeComponent();
            SelectedTag = tag;
            tbxName.Text = SelectedTag.Name;
            if (SelectedTag.IsFolder)
            {
                PopulateTags();
                cbxTags.Enabled = true;
            }

            PopulateDataSources();
            PopulateDevices();
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the CurrentDeviceList property.
        /// </summary>
        /// <value>The list of devices for the currently selected tag.</value>
        private List<string> CurrentDeviceList { get; set; }

        /// <summary>
        /// Gets or sets the CurrentSourceList property.
        /// </summary>
        /// <value>The list of sources for the currently selected tag.</value>
        private List<string> CurrentSourceList { get; set; }

        /// <summary>
        /// Gets or sets the SelectedTag property.
        /// </summary>
        /// <value>The currently selected tag.</value>
        private Tag SelectedTag { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (SelectedTag.Name != tbxName.Text)
                SelectedTag.Name = tbxName.Text;

            if (cbxTags.Enabled && cbxTags.SelectedIndex >= 0)
            {
                if (cbxTags.SelectedIndex == 0)
                    SelectedTag.Parent = null;
                else
                {
                    var cbxTag = (Tag)((ComboboxItem)cbxTags.SelectedItem).Value;
                    if (cbxTag != null)
                    {
                        if (SelectedTag.Parent != null && SelectedTag.Parent.Id != cbxTag.Id)
                            SelectedTag.Parent = cbxTag;
                        else if (SelectedTag.Parent == null)
                            SelectedTag.Parent = cbxTag;
                    }
                }
            }

            LinkDataSources();
            LinkDevices();
        }

        /// <summary>
        /// The LinkDataSources method.
        /// </summary>
        private void LinkDataSources()
        {
            var linkList = new List<DataSource>();
            var unlinkList = new List<DataSource>();

            foreach (ListViewItem item in lvTagSources.Items)
            {
                var dataSource = (DataSource)item.Tag;

                if (item.Checked)
                {
                    if (!CurrentSourceList.Any(s => dataSource.Id.Contains(s)))
                        linkList.Add(dataSource);
                }
                else
                {
                    if (CurrentSourceList.Any(s => dataSource.Id.Contains(s)))
                        unlinkList.Add(dataSource);
                }
            }

            if (linkList.Count > 0)
                SelectedTag.Link(linkList);

            if (unlinkList.Count > 0)
                SelectedTag.Unlink(unlinkList);
        }

        /// <summary>
        /// The LinkDevices method.
        /// </summary>
        private void LinkDevices()
        {
            var linkList = new List<Device>();
            var unlinkList = new List<Device>();

            foreach (ListViewItem item in lvTagDevices.Items)
            {
                var device = (Device)item.Tag;

                if (item.Checked)
                {
                    if (!CurrentDeviceList.Any(s => device.Id.Contains(s)))
                        linkList.Add(device);
                }
                else
                {
                    if (CurrentDeviceList.Any(s => device.Id.Contains(s)))
                        unlinkList.Add(device);
                }
            }

            if (linkList.Count > 0)
                SelectedTag.Link(linkList);

            if (unlinkList.Count > 0)
                SelectedTag.Unlink(unlinkList);
        }

        /// <summary>
        /// The PopulateDataSources method.
        /// </summary>
        private void PopulateDataSources()
        {
            CurrentSourceList = new List<string>();
            foreach (var dataSource in SelectedTag.LinkedDataSources)
                CurrentSourceList.Add(dataSource.Id);

            // Clone each item in the MainForm ListView and add it to lvDataSources.
            foreach (var dataSource in MainForm.CurrentDataSources)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(dataSource.Name);
                lvItem.Tag = dataSource;
                if (CurrentSourceList.Any(s => dataSource.Id.Contains(s)))
                    lvItem.Checked = true;

                lvTagSources.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The PopulateDataSources method.
        /// </summary>
        private void PopulateDevices()
        {
            CurrentDeviceList = new List<string>();
            foreach (var device in SelectedTag.LinkedDevices)
                CurrentDeviceList.Add(device.Id);

            // Clone each item in the MainForm ListView and add it to lvDataSources.
            foreach (var device in MainForm.CurrentDevices)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(device.Name);
                lvItem.Tag = device;
                if (CurrentDeviceList.Any(s => device.Id.Contains(s)))
                    lvItem.Checked = true;

                lvTagDevices.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The PopulateTags method.
        /// </summary>
        private void PopulateTags()
        {
            // Add each folder tag to the combobox.
            var index = -1;
            foreach (var tag in MainForm.CurrentSystem.Tags.Where(t => t.IsFolder))
            {
                var tempIndex = cbxTags.Items.Add(new ComboboxItem { Text = tag.Name, Value = tag });
                if (SelectedTag.Parent != null && SelectedTag.Parent.Id == tag.Id)
                    index = tempIndex;
            }

            cbxTags.SelectedIndex = index;
        }

        #endregion Private Methods
    }
}