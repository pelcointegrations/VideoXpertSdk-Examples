using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The RuleManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view rules on the VideoXpert system.</remarks>
    public partial class RuleManagerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleManagerForm" /> class.
        /// </summary>
        public RuleManagerForm()
        {
            InitializeComponent();

            PopulateRules();
        }

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param> 
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            // Show the AddRuleForm dialog.
            DialogResult result;
            using (var addRuleForm = new AddRuleForm())
            {
                result = addRuleForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view.
            PopulateRules();
        }

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param> 
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            if (lvRuleManager.SelectedItems.Count == 0)
                return;

            var rule = (Rule)lvRuleManager.SelectedItems[0].Tag;
            if (rule == null)
                return;

            MainForm.CurrentSystem.DeleteRule(rule);
            PopulateRules();
        }

        /// <summary>
        /// The ButtonHalt_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param> 
        private void ButtonHalt_Click(object sender, EventArgs args)
        {
            if (lvRuleManager.SelectedItems.Count == 0)
                return;

            var rule = (Rule)lvRuleManager.SelectedItems[0].Tag;
            rule?.HaltScript();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param> 
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvRuleManager.SelectedItems.Count == 0)
                return;

            var rule = (Rule)lvRuleManager.SelectedItems[0].Tag;

            // Show the ModifyRuleForm dialog.
            DialogResult result;
            using (var modifyRuleForm = new ModifyRuleForm(rule))
            {
                result = modifyRuleForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

           // Refresh the items in the list view.
           PopulateRules();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param> 
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view.
            PopulateRules();
            lvRuleManager.Refresh();
        }

        /// <summary>
        /// The PopulateRules method.
        /// </summary>
        private void PopulateRules()
        {
            // Get the existing rules from the VideoXpert system and add
            // them to the list view.
            lvRuleManager.Items.Clear();
            foreach (var rule in MainForm.CurrentSystem.Rules)
            {
                var lvItem = new ListViewItem(rule.Name);
                lvItem.SubItems.Add(rule.Id);
                lvItem.SubItems.Add(rule.IsEnabled.ToString());
                lvItem.SubItems.Add(rule.TimeTables.Count.ToString());
                lvItem.SubItems.Add(rule.Triggers.Count.ToString());
                lvItem.Tag = rule;
                lvRuleManager.Items.Add(lvItem);
            }
        }
    }
}
