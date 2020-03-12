using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The DiagnosticDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the diagnostics info for a device.</remarks>
    public partial class DiagnosticDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticDetailsForm" /> class.
        /// </summary>
        public DiagnosticDetailsForm(Device device)
        {
            InitializeComponent();

            GetDiagnostics(device);
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// The GetDiagnostics method.
        /// </summary>
        /// <param name="device">The <paramref name="device"/> to get the diagnostics for.</param>
        public void GetDiagnostics(Device device)
        {
            var diagnostics = device?.DeviceDiagnostics;
            if (diagnostics == null)
                return;

            TreeNode topNode = tvDiagnostics.Nodes.Add(device.Name);
            topNode.Expand();

            if (diagnostics.AssignmentsInfo != null)
            {
                var node = topNode.Nodes.Add("Assignments");
                AddPropertyInfo(diagnostics.AssignmentsInfo, null, node);
            }

            if (diagnostics.BackupPowers.Count > 0)
            {
                var node = topNode.Nodes.Add("Backup Powers");
                foreach (var backupPower in diagnostics.BackupPowers)
                    AddPropertyInfo(backupPower, backupPower.Id, node);
            }

            if (diagnostics.Databases.Count > 0)
            {
                var node = topNode.Nodes.Add("Databases");
                foreach (var database in diagnostics.Databases)
                    AddPropertyInfo(database, database.Id, node);
            }

            if (diagnostics.EventingInfo != null)
            {
                var node = topNode.Nodes.Add("Eventing");
                AddPropertyInfo(diagnostics.EventingInfo, null, node);
            }

            if (diagnostics.Fans.Count > 0)
            {
                var node = topNode.Nodes.Add("Fans");
                foreach (var fan in diagnostics.Fans)
                    AddPropertyInfo(fan, "Fan: " + fan.Id, node);
            }

            if (diagnostics.Hdds.Count > 0)
            {
                var node = topNode.Nodes.Add("Hard Drives");
                foreach (var hdd in diagnostics.Hdds)
                    AddPropertyInfo(hdd, hdd.Id, node);
            }

            if (diagnostics.Loads.Count > 0)
            {
                var node = topNode.Nodes.Add("Loads");
                foreach (var load in diagnostics.Loads)
                    AddPropertyInfo(load, load.Type.ToString(), node);
            }

            if (diagnostics.Networks.Count > 0)
            {
                var node = topNode.Nodes.Add("Networks");
                foreach (var network in diagnostics.Networks)
                    AddPropertyInfo(network, network.Id, node);
            }

            if (diagnostics.Powers.Count > 0)
            {
                var node = topNode.Nodes.Add("Power Supplies");
                foreach (var power in diagnostics.Powers)
                    AddPropertyInfo(power, ":" + power.Id, node);
            }

            if (diagnostics.RetentionInfo != null)
            {
                var node = topNode.Nodes.Add("Retention");
                AddPropertyInfo(diagnostics.RetentionInfo, null, node);
            }

            if (diagnostics.Storages.Count > 0)
            {
                var node = topNode.Nodes.Add("Storages");
                foreach (var storage in diagnostics.Storages)
                    AddPropertyInfo(storage, storage.Id, node);
            }

            if (diagnostics.Temperatures.Count > 0)
            {
                var node = topNode.Nodes.Add("Temperatures");
                foreach (var temperature in diagnostics.Temperatures)
                    AddPropertyInfo(temperature, temperature.Id, node);
            }
            diagnostics.Dispose();
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The AddPropertyInfo method.
        /// </summary>
        /// <param name="diagnosticObject">The <paramref name="diagnosticObject"/> to add the properties for.</param>
        /// <param name="id">The device ID to use for the root node, if any.</param>
        /// <param name="parentNode">The parent node for this property.</param>
        private void AddPropertyInfo(object diagnosticObject, string id, TreeNode parentNode)
        {
            TreeNode topNode = parentNode;
            if (!string.IsNullOrEmpty(id))
                topNode = parentNode.Nodes.Add(id);

            // Use reflection to get each available property in the diagnostic object.
            foreach (var prop in diagnosticObject.GetType().GetProperties())
            {
                // Skip the Id property if present since it's added in the title already.
                if (prop.Name.ToLower() == "id")
                    continue;

                // Get the value from the property.
                string value = prop.GetValue(diagnosticObject, null).ToString();

                // Add the property name and value to the tree view.
                topNode.Nodes.Add(prop.Name + ": " + value);
            }
        }

        /// <summary>
        /// The ButtonCollapseAll_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonCollapseAll_Click(object sender, EventArgs args)
        {
            tvDiagnostics.CollapseAll();
        }

        /// <summary>
        /// The ButtonExpandAll_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonExpandAll_Click(object sender, EventArgs args)
        {
            tvDiagnostics.ExpandAll();
        }

        #endregion Private Methods
    }
}