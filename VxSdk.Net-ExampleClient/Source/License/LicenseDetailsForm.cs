using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The LicenseDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains the detailed info of the system license.</remarks>
    public partial class LicenseDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseDetailsForm" /> class.
        /// </summary>
        public LicenseDetailsForm()
        {
            InitializeComponent();
            GetLicenseInfo();
            tvLicenseDetails.ExpandAll();
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// The GetLicenseInfo method.
        /// </summary>
        public void GetLicenseInfo()
        {
            // Get the license from the current system.
            var license = MainForm.CurrentSystem.GetLicense();
            if (license == null)
                return;

            // Create the base node.
            var licenseNode = tvLicenseDetails.Nodes.Add("License");

            // Use reflection to get each available property from the license.
            foreach (var prop in license.GetType().GetProperties())
            {
                // Get the value from the property.
                var val = prop.GetValue(license, null);

                // Skip any null values.
                if (val == null)
                    continue;

                // Skip if the value is a List type.
                if (val.GetType() == typeof(List<LicenseFeature>))
                    continue;

                // Add the value to the current node.
                licenseNode.Nodes.Add($"{prop.Name}: {val}");
            }

            // Populate the feature nodes if present.
            if (license.LicenseFeatures.Count > 0)
            {
                foreach (var feature in license.LicenseFeatures)
                    AddFeatureInfo(feature, licenseNode);
            }

            // Populate the license SUP node if present.
            if (license.LicenseSupInfo != null)
                AddLicenseSupInfo(license.LicenseSupInfo, licenseNode);
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The AddDeviceInfo method.
        /// </summary>
        /// <param name="device">The <paramref name="device"/> to add the info for.</param>
        /// <param name="deviceNode">The node to add the info to.</param>
        private static void AddDeviceInfo(Device device, TreeNode deviceNode)
        {
            // Change the device type to a more readable form.
            string type;
            switch (device.Type)
            {
                case Device.Types.Acc:
                    type = "Accessory Server";
                    break;

                case Device.Types.AllInOne:
                    type = "VxPro";
                    break;

                case Device.Types.Mg:
                    type = "MediaGateway";
                    break;

                case Device.Types.Ui:
                    type = "User Interface";
                    break;

                default:
                    type = device.Type.ToString();
                    break;
            }

            // Add the device info to the current node.
            deviceNode.Nodes.Add($"{type}: {device.Name}");
        }

        /// <summary>
        /// The AddFeatureInfo method.
        /// </summary>
        /// <param name="licenseFeature">The <paramref name="licenseFeature"/> to add the info for.</param>
        /// <param name="licenseNode">The node to add the info to.</param>
        private static void AddFeatureInfo(LicenseFeature licenseFeature, TreeNode licenseNode)
        {
            var featureNode = licenseNode.Nodes.Add("Feature");

            // Use reflection to get each available property from the license feature.
            foreach (var prop in licenseFeature.GetType().GetProperties())
            {
                if (prop.Name == "CapabilityRequestEndpoint")
                    continue;

                // Get the value from the property.
                var val = prop.GetValue(licenseFeature, null);

                // Skip if the value is a List type.
                if (val.GetType() == typeof(List<Device>))
                    continue;

                // Generate a string based on the value type.
                string valList;
                if (val is DateTime)
                {
                    var dt = (DateTime)val;
                    valList = dt == default(DateTime) ? "None" : dt.ToString("G");
                }
                else
                    valList = val.ToString();

                // Add the value to the current node.
                featureNode.Nodes.Add($"{prop.Name}: {valList}");
            }

            if (licenseFeature.CommissionedDevices.Count == 0)
                return;

            // Add a new node for commissioned devices if they are present and populate it.
            var deviceNode = featureNode.Nodes.Add("Commissioned Devices");
            foreach (var device in licenseFeature.CommissionedDevices)
                AddDeviceInfo(device, deviceNode);
        }

        /// <summary>
        /// The AddLicenseSupEventInfo method.
        /// </summary>
        /// <param name="supEvent">The <paramref name="supEvent"/> to add the info for.</param>
        /// <param name="licenseSupNode">The node to add the info to.</param>
        private static void AddLicenseSupEventInfo(LicenseSupEvent supEvent, TreeNode licenseSupNode)
        {
            var licenseSupEventNode = licenseSupNode.Nodes.Add("Event");

            // Change the event type to a more readable form.
            string type;
            switch (supEvent.Type)
            {
                case LicenseSupEvent.SupEventType.Commissioned:
                    type = "License Commissioned";
                    break;

                case LicenseSupEvent.SupEventType.Decommissioned:
                    type = "License Decommissioned";
                    break;

                case LicenseSupEvent.SupEventType.ExpiredSup1:
                    type = "1-year License Expired";
                    break;

                case LicenseSupEvent.SupEventType.ExpiredSup3:
                    type = "3-year License Expired";
                    break;

                case LicenseSupEvent.SupEventType.ExtendedSup:
                    type = "License Extended";
                    break;

                case LicenseSupEvent.SupEventType.InstalledSup1:
                    type = "1-year License Installed";
                    break;

                case LicenseSupEvent.SupEventType.InstalledSup3:
                    type = "3-year License Installed";
                    break;

                case LicenseSupEvent.SupEventType.Tampered:
                    type = "License Was Tampered";
                    break;

                default:
                    type = supEvent.Type.ToString();
                    break;
            }

            // Add the event type to the current node.
            licenseSupEventNode.Nodes.Add($"Event Type: {type}");

            // Use reflection to get each available property from the license SUP event.
            foreach (var prop in supEvent.GetType().GetProperties())
            {
                // Get the value from the property.
                var val = prop.GetValue(supEvent, null);

                // Skip if the value is a SupEventType.
                if (val.GetType() == typeof(LicenseSupEvent.SupEventType))
                    continue;

                // Generate a string based on the value type.
                string valList;
                if (val is DateTime)
                {
                    var dt = (DateTime)val;
                    valList = dt == default(DateTime) ? "None" : dt.ToString("G");
                }
                else
                    valList = val.ToString();

                // Add the value to the current node.
                licenseSupEventNode.Nodes.Add($"{prop.Name}: {valList}");
            }
        }

        /// <summary>
        /// The AddLicenseSupInfo method.
        /// </summary>
        /// <param name="licenseSup">The <paramref name="licenseSup"/> to add the info for.</param>
        /// <param name="licenseNode">The node to add the info to.</param>
        private static void AddLicenseSupInfo(LicenseSup licenseSup, TreeNode licenseNode)
        {
            var licenseSupNode = licenseNode.Nodes.Add("Software Upgrade Plan Info");

            // Use reflection to get each available property from the license SUP.
            foreach (var prop in licenseSup.GetType().GetProperties())
            {
                // Get the value from the property.
                var val = prop.GetValue(licenseSup, null);

                // Skip if the value is a List type.
                if (val.GetType() == typeof(List<LicenseSupEvent>))
                    continue;

                // Generate a string based on the value type.
                string valList;
                if (val is DateTime)
                {
                    var dt = (DateTime)val;
                    valList = dt == default(DateTime) ? "None" : dt.ToString("G");
                }
                else
                    valList = val.ToString();

                // Add the value to the current node.
                licenseSupNode.Nodes.Add($"{prop.Name}: {valList}");
            }

            if (licenseSup.Events.Count == 0)
                return;

            // Add license SUP event info if any are present.
            foreach (var supEvent in licenseSup.Events)
                AddLicenseSupEventInfo(supEvent, licenseSupNode);
        }

        #endregion Private Methods
    }
}