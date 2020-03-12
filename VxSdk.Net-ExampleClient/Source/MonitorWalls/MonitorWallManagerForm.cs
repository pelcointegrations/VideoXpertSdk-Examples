using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The MonitorWallManagerForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to add, delete and modify
    /// monitor walls from the VideoXpert system.</remarks>
    public partial class MonitorWallManagerForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorWallManagerForm" /> class.
        /// </summary>
        public MonitorWallManagerForm()
        {
            InitializeComponent();

            PopulateMonitorWalls();
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonDelete_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonDelete_Click(object sender, EventArgs args)
        {
            // Verify that an item is selected.
            if (lvMonitorWallManager.SelectedItems.Count == 0)
                return;

            // Get the associated monitor wall object from the selected item and delete
            // it from the VideoXpert system.
            var monitorWall = (MonitorWall)lvMonitorWallManager.SelectedItems[0].Tag;
            MainForm.CurrentSystem.DeleteMonitorWall(monitorWall);
            PopulateMonitorWalls();
        }

        /// <summary>
        /// The ButtonManageSelections_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonManageSelections_Click(object sender, EventArgs args)
        {
            // Verify that an item is selected.
            if (lvMonitorWallManager.SelectedItems.Count == 0)
                return;

            // Show the ManageMonitorSelectionsForm dialog.
            var monitorWall = (MonitorWall)lvMonitorWallManager.SelectedItems[0].Tag;
            using (var manageMonitorSelectionsForm = new ManageMonitorSelectionsForm(monitorWall))
            {
                manageMonitorSelectionsForm.ShowDialog();
            }
        }

        /// <summary>
        /// The ButtonModify_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonModify_Click(object sender, EventArgs args)
        {
            // Verify that an item is selected.
            if (lvMonitorWallManager.SelectedItems.Count == 0)
                return;

            // Show the ModifyMonitorWallForm dialog.
            var monitorWall = (MonitorWall)lvMonitorWallManager.SelectedItems[0].Tag;
            using (var modifyMonitorWallForm = new ModifyMonitorWallForm(monitorWall))
            {
                modifyMonitorWallForm.ShowDialog();
            }

            // Refresh the items in the list view.
            PopulateMonitorWalls();
        }

        /// <summary>
        /// The ButtonNewMonitorWall_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonNewMonitorWall_Click(object sender, EventArgs args)
        {
            // Show the AddMonitorWallForm dialog.
            DialogResult result;
            using (var addMonitorWallForm = new AddMonitorWallForm())
            {
                result = addMonitorWallForm.ShowDialog();
            }

            // If the dialog was closed without clicking OK then skip the refresh.
            if (result == DialogResult.Cancel)
                return;

            // Refresh the items in the list view to include the newly added monitor wall.
            PopulateMonitorWalls();
        }

        /// <summary>
        /// The ButtonRefresh_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRefresh_Click(object sender, EventArgs args)
        {
            // Refresh the items in the list view.
            PopulateMonitorWalls();
        }

        /// <summary>
        /// The PopulateMonitorWalls method.
        /// </summary>
        private void PopulateMonitorWalls()
        {
            lvMonitorWallManager.Items.Clear();

            // Get the existing monitor walls from the VideoXpert system and add
            // them to the list view.
            foreach (var monitorWall in MainForm.CurrentSystem.MonitorWalls)
            {
                var lvItem = new ListViewItem(monitorWall.Name);
                lvItem.SubItems.Add(monitorWall.MonitorPositions.Count.ToString());
                lvItem.Tag = monitorWall;
                lvMonitorWallManager.Items.Add(lvItem);
            }

            lvMonitorWallManager.Refresh();
        }

        #endregion Private Methods
    }
}