using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyRuleForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add or modify a rule.</remarks>
    public partial class ModifyRuleForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyRuleForm" /> class.
        /// </summary>
        /// <param name="rule">The <paramref name="rule"/> parameter.</param>
        public ModifyRuleForm(Rule rule)
        {
            InitializeComponent();
            HaveTriggersChanged = false;
            HaveTimeTablesChanged = false;
            DeviceList = MainForm.CurrentSystem.Devices;
            DataSourceList = MainForm.CurrentSystem.DataSources;
            DataStorageList = MainForm.CurrentSystem.DataStorages;
            TagList = MainForm.CurrentSystem.Tags;
            SelectedRule = rule;

            tbxName.Text = rule.Name;
            chbxIsEnabled.Checked = rule.IsEnabled;
            var timetables = rule.TimeTables;
            foreach (var timeTable in MainForm.CurrentSystem.TimeTables)
            {
                var lvItem = new ListViewItem(string.Empty);
                lvItem.SubItems.Add(timeTable.Name);
                lvItem.Tag = timeTable;
                lvItem.Checked = timetables.Any(tm => tm.Id == timeTable.Id);
                lvTimeTables.Items.Add(lvItem);
            }

            foreach (var response in SelectedRule.Responses)
            {
                var lvItem = new ListViewItem(string.Empty) { Tag = response };
                if (response.IsCustomScript)
                    lvItem.SubItems.Add($"Custom Script: {response.Script}");
                else
                    lvItem.SubItems.Add($"Generate Event: {response.SituationType}");

                lvRuleResponses.Items.Add(lvItem);
            }
            lvRuleResponses.Refresh();

            foreach (var trigger in SelectedRule.Triggers)
            {
                var lvItem = new ListViewItem(string.Empty) { Tag = trigger };
                lvItem.SubItems.Add(trigger.SituationType);
                var resourceRefs = trigger.ResourceRefs;
                lvItem.SubItems.Add(resourceRefs.Count > 0 ? resourceRefs[0].Id : @"All");
                lvRuleTriggers.Items.Add(lvItem);
            }
            lvRuleTriggers.Refresh();
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// Gets or sets the SelectedRule property.
        /// </summary>
        /// <value>The currently selected rule.</value>
        public Rule SelectedRule { get; set; }

        #endregion Public Properties

        #region Private Properties

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
        /// Gets the HaveResponsesChanged property.
        /// </summary>
        /// <value><c>true</c> if the responses have been modified, otherwise <c>false</c>.</value>
        private bool HaveResponsesChanged { get; set; }

        /// <summary>
        /// Gets the HaveTimeTablesChanged property.
        /// </summary>
        /// <value><c>true</c> if the time tables have been modified, otherwise <c>false</c>.</value>
        private bool HaveTimeTablesChanged { get; set; }

        /// <summary>
        /// Gets the HaveTriggersChanged property.
        /// </summary>
        /// <value><c>true</c> if the triggers have been modified, otherwise <c>false</c>.</value>
        private bool HaveTriggersChanged { get; set; }

        /// <summary>
        /// Gets or sets the TagList property.
        /// </summary>
        /// <value>The list of tags on the system.</value>
        private List<Tag> TagList { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            using (var addRuleTriggerForm = new AddRuleTriggerForm(lvRuleTriggers, DeviceList, DataSourceList, DataStorageList, TagList))
            {
                if (addRuleTriggerForm.ShowDialog() != DialogResult.OK)
                    return;

                HaveTriggersChanged = true;
                lvRuleTriggers.Refresh();
            }
        }

        /// <summary>
        /// The ButtonAddResponse_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAddResponse_Click(object sender, EventArgs args)
        {
            using (var addRuleResponseForm = new AddRuleResponseForm(lvRuleResponses))
            {
                if (addRuleResponseForm.ShowDialog() != DialogResult.OK)
                    return;

                HaveResponsesChanged = true;
                lvRuleResponses.Refresh();
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
            if (remItems.Count > 0)
                HaveTriggersChanged = true;

            foreach (ListViewItem item in remItems)
                lvRuleTriggers.Items.Remove(item);

            lvRuleTriggers.Refresh();
        }

        /// <summary>
        /// The ButtonRemoveResponse_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRemoveResponse_Click(object sender, EventArgs args)
        {
            var remItems = lvRuleResponses.CheckedItems;
            if (remItems.Count > 0)
                HaveResponsesChanged = true;

            foreach (ListViewItem item in remItems)
                lvRuleResponses.Items.Remove(item);

            lvRuleResponses.Refresh();
        }

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (SelectedRule.IsEnabled != chbxIsEnabled.Checked)
                SelectedRule.IsEnabled = chbxIsEnabled.Checked;

            if (!string.IsNullOrEmpty(tbxName.Text) && SelectedRule.Name != tbxName.Text)
                SelectedRule.Name = tbxName.Text;

            var currentTimeTables = SelectedRule.TimeTables;
            foreach (ListViewItem timeTableItem in lvTimeTables.Items)
            {
                var timeTable = timeTableItem.Tag as TimeTable;
                if (timeTable == null)
                    continue;

                if (!timeTableItem.Checked && currentTimeTables.Any(tt => tt.Id == timeTable.Id))
                {
                    HaveTimeTablesChanged = true;
                    break;
                }

                if (!timeTableItem.Checked || currentTimeTables.Any(tt => tt.Id == timeTable.Id))
                    continue;

                HaveTimeTablesChanged = true;
                break;
            }

            if (HaveTimeTablesChanged)
            {
                var timeTables = new List<TimeTable>();
                foreach (ListViewItem timeTableItem in lvTimeTables.CheckedItems)
                {
                    var timeTable = timeTableItem.Tag as TimeTable;
                    if (timeTable == null)
                        continue;

                    timeTables.Add(timeTable);
                }

                SelectedRule.TimeTables = timeTables;
            }

            if (HaveResponsesChanged)
            {
                var ruleResponses = new List<RuleResponse>();
                foreach (ListViewItem responseItem in lvRuleResponses.Items)
                {
                    var response = responseItem.Tag as RuleResponse;
                    if (response == null)
                        continue;

                    ruleResponses.Add(response);
                }

                SelectedRule.Responses = ruleResponses;
            }

            if (!HaveTriggersChanged)
                return;

            var ruleTriggers = new List<RuleTrigger>();
            foreach (ListViewItem triggerItem in lvRuleTriggers.Items)
            {
                var trigger = triggerItem.Tag as RuleTrigger;
                if (trigger == null)
                    continue;

                ruleTriggers.Add(trigger);
            }

            SelectedRule.Triggers = ruleTriggers;
        }

        #endregion Private Methods


    }
}