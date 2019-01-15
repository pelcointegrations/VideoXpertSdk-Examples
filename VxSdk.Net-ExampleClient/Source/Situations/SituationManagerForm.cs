﻿using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The SituationManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to view, create and delete situations
    /// from the VideoXpert system.</remarks>
    public partial class SituationManagerForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SituationManagerForm" /> class.
        /// </summary>
        public SituationManagerForm()
        {
            InitializeComponent();

            PopulateSituations();
        }

        /// <summary>
        /// The PopulateSituations method.
        /// </summary>
        private void PopulateSituations()
        {
            // Get the existing situations from the VideoXpert system and add
            // them to the list view.
            foreach (var situation in MainForm.CurrentSystem.Situations)
            {
                var lvItem = new ListViewItem(situation.Type);
                lvItem.SubItems.Add(Math.Abs(situation.Severity - 11).ToString());
                lvItem.SubItems.Add(situation.SourceDeviceId);
                lvItem.Tag = situation;
                lvSituationManager.Items.Add(lvItem);
            }
        }

        /// <summary>
        /// The ButtonViewSituation_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonViewSituation_Click(object sender, EventArgs args)
        {
            if (lvSituationManager.SelectedItems.Count == 0) 
                return;

            var situation = (Situation)lvSituationManager.SelectedItems[0].Tag;

            using (var detailsForm = new SituationDetailsForm())
            {
                detailsForm.GetSituationInfo(situation);
                detailsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonDeleteSituation_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>   
        private void ButtonDeleteSituation_Click(object sender, EventArgs args)
        {
            if (lvSituationManager.SelectedItems.Count == 0) 
                return;

            // Get the associated Situation object from the selected item and delete
            // it from the VideoXpert system.
            var situation = (Situation)lvSituationManager.SelectedItems[0].Tag;
            MainForm.CurrentSystem.DeleteSituation(situation);
            lvSituationManager.SelectedItems[0].Remove();
        }

        /// <summary>
        /// The ButtonNewSituation_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>   
        private void ButtonNewSituation_Click(object sender, EventArgs args)
        {
            // Show the AddSituationForm dialog.
            DialogResult result;
            using (var addSituationForm = new AddSituationForm())
            {
                result = addSituationForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to include the newly added situation.
            lvSituationManager.Items.Clear();
            PopulateSituations();
            lvSituationManager.Refresh();
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>   
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            if (lvSituationManager.SelectedItems.Count == 0) 
                return;

            var situation = (Situation)lvSituationManager.SelectedItems[0].Tag;

            // Show the ModifySituationForm dialog.
            DialogResult result;
            using (var modifySituationForm = new ModifySituationForm(situation))
            {
                result = modifySituationForm.ShowDialog();
            }

            // If the dialog was closed without clicking Save then skip the refresh.
            if (result != DialogResult.OK)
                return;

            // Refresh the items in the list view to update the modified situation.
            lvSituationManager.Items.Clear();
            PopulateSituations();
            lvSituationManager.Refresh();
        }

        /// <summary>
        /// The ButtonManageNotifications_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>   
        private void ButtonManageNotifications_Click(object sender, EventArgs args)
        {
            if (lvSituationManager.SelectedItems.Count == 0)
                return;

            var situation = (Situation)lvSituationManager.SelectedItems[0].Tag;

            using (var modifyNotificationsForm = new NotificationManagerForm(situation))
            {
                modifyNotificationsForm.ShowDialog();
            }
        }
    }
}
