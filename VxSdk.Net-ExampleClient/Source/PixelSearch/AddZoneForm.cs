using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddZoneForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user create a new zone.</remarks>
    public partial class AddZoneForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddZoneForm" /> class.
        /// </summary>
        /// <param name="listView">The <paramref name="listView"/> parameter.</param>
        public AddZoneForm(ListView listView)
        {
            InitializeComponent();
            ZonesListView = listView;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the IsHeightChanging property.
        /// </summary>
        /// <value><c>true</c> if the height is being changed, otherwise <c>false</c>.</value>
        private bool IsHeightChanging { get; set; }

        /// <summary>
        /// Gets or sets the IsWidthChanging property.
        /// </summary>
        /// <value><c>true</c> if the width is being changed, otherwise <c>false</c>.</value>
        private bool IsWidthChanging { get; set; }

        /// <summary>
        /// Gets or sets the ZonesListView property.
        /// </summary>
        /// <value>The zone ListView.</value>
        private ListView ZonesListView { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            var rect = new Rect
            {
                Left = (int)nudLeft.Value,
                Top = (int)nudTop.Value,
                Width = (int)nudWidth.Value,
                Height = (int)nudHeight.Value
            };

            // Add the rect info to the list view.
            var lvItem = new ListViewItem(string.Empty);
            lvItem.SubItems.Add(rect.Left.ToString());
            lvItem.SubItems.Add(rect.Top.ToString());
            lvItem.SubItems.Add(rect.Width.ToString());
            lvItem.SubItems.Add(rect.Height.ToString());
            lvItem.Tag = rect;
            ZonesListView.Items.Add(lvItem);
        }

        /// <summary>
        /// The NumericUpDownTopHeight_ValueChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void NumericUpDownTopHeight_ValueChanged(object sender, EventArgs args)
        {
            if (IsHeightChanging)
            {
                IsHeightChanging = false;
                return;
            }

            if (nudTop.Value + nudHeight.Value >= 1000)
            {
                IsHeightChanging = true;
                nudHeight.Value = 999 - nudTop.Value;
            }

            var newTop = nudTop.Value / 5;
            var newHeight = nudHeight.Value / 5;

            var newSize = pnlSelection.Size;
            newSize.Height = (int)Math.Round(newHeight);

            var newLocation = pnlSelection.Location;
            newLocation.Y = (int)Math.Round(newTop);

            pnlSelection.Size = newSize;
            pnlSelection.Location = newLocation;
        }

        /// <summary>
        /// The NumericUpDownTopLeft_ValueChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void NumericUpDownTopLeft_ValueChanged(object sender, EventArgs args)
        {
            if (IsWidthChanging)
            {
                IsWidthChanging = false;
                return;
            }

            if (nudLeft.Value + nudWidth.Value >= 1000)
            {
                IsWidthChanging = true;
                nudWidth.Value = 999 - nudLeft.Value;
            }

            var newLeft = nudLeft.Value / 5;
            var newWidth = nudWidth.Value / 5;

            var newSize = pnlSelection.Size;
            newSize.Width = (int)Math.Round(newWidth);

            var newLocation = pnlSelection.Location;
            newLocation.X = (int)Math.Round(newLeft);

            pnlSelection.Size = newSize;
            pnlSelection.Location = newLocation;
        }

        #endregion Private Methods
    }
}