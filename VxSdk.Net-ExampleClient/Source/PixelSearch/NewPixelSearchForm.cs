using System;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The NewPixelSearchForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to start a new pixel search.</remarks>
    public partial class NewPixelSearchForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NewPixelSearchForm" /> class.
        /// </summary>
        public NewPixelSearchForm()
        {
            InitializeComponent();

            // Get the existing data sources from the VideoXpert system and add them to the combobox
            var dataSources = MainForm.CurrentSystem.DataSources.OrderByDescending(x => x.Type);
            foreach (var dataSource in dataSources.Where(ds => ds.CanPixelSearch))
                cbxDataSources.Items.Add(new ComboboxItem { Text = dataSource.Name, Value = dataSource });
        }

        #endregion Public Constructors

        #region Private Methods

        /// <summary>
        /// The ButtonAddZone_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAddZone_Click(object sender, EventArgs args)
        {
            using (var addZoneForm = new AddZoneForm(lvZones))
            {
                if (addZoneForm.ShowDialog() == DialogResult.OK)
                    lvZones.Refresh();
            }

            btnSearch.Enabled = lvZones.Items.Count > 0;
        }

        /// <summary>
        /// The ButtonRemoveZone_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonRemoveZone_Click(object sender, EventArgs args)
        {
            var remItems = lvZones.CheckedItems;
            foreach (ListViewItem item in remItems)
            {
                lvZones.Items.Remove(item);
                lvZones.Refresh();
            }

            btnSearch.Enabled = lvZones.Items.Count > 0;
        }

        /// <summary>
        /// The ButtonSearch_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSearch_Click(object sender, EventArgs args)
        {
            var newPixelSearch = new NewPixelSearch
            {
                Columns = (int)nudColumns.Value,
                Rows = (int)nudRows.Value,
                SearchEndTime = dtpEndDate.Value,
                SearchStartTime = dtpStartDate.Value
            };

            foreach (ListViewItem lvZonesItem in lvZones.Items)
            {
                var rect = lvZonesItem.Tag as Rect;
                if (rect != null)
                    newPixelSearch.Zones.Add(rect);
            }

            var dataSource = ((ComboboxItem)cbxDataSources.SelectedItem).Value as DataSource;
            new PixelSearchResultsForm(newPixelSearch, dataSource).ShowDialog();
        }

        /// <summary>
        /// The ComboboxDataSources_SelectedIndexChanged method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ComboboxDataSources_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (cbxDataSources.SelectedIndex < 0)
                return;

            gbxSearchEndTime.Enabled = true;
            gbxSearchStartTime.Enabled = true;
            gbxSearchGrid.Enabled = true;
            gbxSearchZones.Enabled = true;
        }

        #endregion Private Methods
    }
}