using System;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The ModifyDataSourceForm class.
    /// </summary>
    /// <remarks>Provides a dialog window that allows the user to modify a dataSource.</remarks>
    public partial class ModifyDataSourceForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyDataSourceForm" /> class.
        /// </summary>
        /// <param name="dataSource">The <paramref name="dataSource"/> parameter.</param>
        public ModifyDataSourceForm(DataSource dataSource)
        {
            InitializeComponent();
            SelectedDataSource = dataSource;
            tbxName.Text = dataSource.Name;
            nudNumber.Value = dataSource.Number;
            nudRetentionLimit.Value = dataSource.RetentionLimit;
            nudPruningThreshold.Value = dataSource.PruningThreshold;
            chbxEnabled.Checked = dataSource.IsEnabled;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedDataSource property.
        /// </summary>
        /// <value>The currently selected dataSource.</value>
        private DataSource SelectedDataSource { get; }

        #endregion Private Properties

        #region Private Methods

        /// <summary>
        /// The ButtonSave_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonSave_Click(object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(tbxName.Text) && SelectedDataSource.Name != tbxName.Text)
                SelectedDataSource.Name = tbxName.Text;

            if (SelectedDataSource.Number != (int)nudNumber.Value)
                SelectedDataSource.Number = (int)nudNumber.Value;

            if (SelectedDataSource.RetentionLimit != (int)nudRetentionLimit.Value)
                SelectedDataSource.RetentionLimit = (int)nudRetentionLimit.Value;

            if (SelectedDataSource.PruningThreshold != (int)nudPruningThreshold.Value)
                SelectedDataSource.PruningThreshold = (int)nudPruningThreshold.Value;

            if (SelectedDataSource.IsEnabled != chbxEnabled.Checked)
                SelectedDataSource.IsEnabled = chbxEnabled.Checked;
        }

        #endregion Private Methods
    }
}