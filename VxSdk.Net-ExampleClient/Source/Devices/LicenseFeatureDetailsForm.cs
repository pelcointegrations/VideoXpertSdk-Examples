using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The LicenseFeatureDetailsForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that contains info for the licensable features of the selected device.</remarks>
    public partial class LicenseFeatureDetailsForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseFeatureDetailsForm" /> class.
        /// </summary>
        public LicenseFeatureDetailsForm(Device device)
        {
            InitializeComponent();

            AddLicenseFeatureInfo(device);
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The AddLicenseFeatureInfo method.
        /// </summary>
        /// <param name="device">The <paramref name="device"/> to add the info for.</param>
        private void AddLicenseFeatureInfo(Device device)
        {
            if (device.LicensedFeatures.Count > 0)
            {
                var lvMainItem = new ListViewItem(string.Empty) {BackColor = Color.LightGray};
                lvMainItem.SubItems.Add("Licensed Features");
                lvLicenseFeatureDetails.Items.Add(lvMainItem);

                foreach (var feature in device.LicensedFeatures)
                {
                    // Add the feature value to the list view.
                    var lvItem = new ListViewItem(string.Empty);
                    lvItem.SubItems.Add(feature);
                    lvLicenseFeatureDetails.Items.Add(lvItem);
                }
            }

            if (device.LicensableFeatures.Count > 0)
            {
                var lvMainItem = new ListViewItem(string.Empty) { BackColor = Color.LightGray };
                lvMainItem.SubItems.Add("Licensable Features");
                lvLicenseFeatureDetails.Items.Add(lvMainItem);

                foreach (var feature in device.LicensableFeatures)
                {
                    // Add the feature value to the list view.
                    var lvItem = new ListViewItem(string.Empty);
                    lvItem.SubItems.Add(feature);
                    lvLicenseFeatureDetails.Items.Add(lvItem);
                }
            }
        }

        #endregion Private Methods
    }
}