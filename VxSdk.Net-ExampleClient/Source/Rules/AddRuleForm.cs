using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddRuleForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add or modify a rule.</remarks>
    public partial class AddRuleForm : Form
    {
        /// <summary>
        /// Gets or sets the DataSourceList property.
        /// </summary>
        /// <value>The list of data sources on the system.</value>
        private List<DataSource> DataSourceList { get; }

        /// <summary>
        /// Gets or sets the DataStorageList property.
        /// </summary>
        /// <value>The list of data storages on the system.</value>
        private List<DataStorage> DataStorageList { get; }

        /// <summary>
        /// Gets or sets the DeviceList property.
        /// </summary>
        /// <value>The list of devices on the system.</value>
        private List<Device> DeviceList { get; }

        /// <summary>
        /// Gets or sets the TagList property.
        /// </summary>
        /// <value>The list of tags on the system.</value>
        private List<Tag> TagList { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRuleForm" /> class.
        /// </summary>
        public AddRuleForm()
        {
            InitializeComponent();

            DeviceList = MainForm.CurrentSystem.Devices;
            DataSourceList = MainForm.CurrentSystem.DataSources;
            DataStorageList = MainForm.CurrentSystem.DataStorages;
            TagList = MainForm.CurrentSystem.Tags;

            foreach (var timeTable in MainForm.CurrentSystem.TimeTables)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(timeTable.Name);
                lvItem.Tag = timeTable;
                lvTimeTables.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            using (var addRuleTriggerForm = new AddRuleTriggerForm(lvRuleTriggers, DeviceList, DataSourceList, DataStorageList, TagList))
            {
                if (addRuleTriggerForm.ShowDialog() == DialogResult.OK)
                    lvRuleTriggers.Refresh();
            }
        }

        /// <summary>
        /// The ButtonRemove_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRemove_Click(object sender, EventArgs args)
        {
            var remItems = lvRuleTriggers.CheckedItems;
            foreach (ListViewItem item in remItems)
                lvRuleTriggers.Items.Remove(item);

            lvRuleTriggers.Refresh();
        }

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            var newRule = new NewRule
            {
                IsEnabled = chbxIsEnabled.Checked,
                Name = tbxName.Text,
                Script = rtbScript.Text
            };

            foreach (ListViewItem timeTableItem in lvTimeTables.CheckedItems)
            {
                var timeTable = timeTableItem.Tag as TimeTable;
                if (timeTable == null)
                    continue;

                newRule.TimeTables.Add(timeTable);
            }

            foreach (ListViewItem triggerItem in lvRuleTriggers.Items)
            {
                var trigger = triggerItem.Tag as RuleTrigger;
                if (trigger == null)
                    continue;

                newRule.RuleTriggers.Add(trigger);
            }

            MainForm.CurrentSystem.AddRule(newRule);
        }
    }
}
