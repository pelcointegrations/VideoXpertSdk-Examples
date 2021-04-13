using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddRuleResponseForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to create a new rule response.</remarks>
    public partial class AddRuleResponseForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRuleResponseForm" /> class.
        /// </summary>
        public AddRuleResponseForm(ListView listView)
        {
            InitializeComponent();
            ResponseListView = listView;
            gbxEventSettings.Visible = false;
        }

        #endregion Public Constructors

        #region Private Properties

        private ListView ResponseListView { get; }

        #endregion Private Properties

        #region Private Methods


        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            var lvItem = new ListViewItem(string.Empty);
            var newRuleResponse = new RuleResponse();
            if (rbCustomScript.Checked)
            {
                newRuleResponse.IsCustomScript = true;
                newRuleResponse.Script = tbxScript.Text;
                lvItem.SubItems.Add($"Custom Script: {newRuleResponse.Script}");
            }
            else
            {
                newRuleResponse.IsCustomScript = false;
                newRuleResponse.SituationType = tbxSituationType.Text;
                if (chbxSeverity.Checked)
                    newRuleResponse.UsedSourceEventFields.Add("severity");

                if (chbxSourceDeviceId.Checked)
                    newRuleResponse.UsedSourceEventFields.Add("source_device_id");

                if (chbxProperties.Checked)
                    newRuleResponse.UsedSourceEventFields.Add("properties");

                lvItem.SubItems.Add($"Generate Event: {newRuleResponse.SituationType}");
            }
            
            lvItem.Tag = newRuleResponse;
            ResponseListView.Items.Add(lvItem);
        }

        #endregion Private Methods

        private void RadioButtonResponseType_CheckedChanged(object sender, EventArgs args)
        {
            gbxEventSettings.Visible = rbGenerateEvent.Checked;
            gbxScript.Visible = !rbGenerateEvent.Checked;
        }
    }
}