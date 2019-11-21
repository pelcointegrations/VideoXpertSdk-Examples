using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using VxSdkNet;

namespace ExampleClient.Source
{
    /// <summary>
    /// The AddNotificationForm class.
    /// </summary>
    /// <remarks>
    /// Provides a dialog window that allows the user to add a notification to the VideoXpert system.
    /// </remarks>
    public partial class AddNotificationForm : Form
    {
        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNotificationForm" /> class.
        /// </summary>
        public AddNotificationForm(Situation situation)
        {
            InitializeComponent();
            SelectedSituation = situation;
        }

        #endregion Public Constructors

        #region Private Properties

        /// <summary>
        /// Gets or sets the SelectedSituation property.
        /// </summary>
        /// <value>The currently selected situation.</value>
        private Situation SelectedSituation { get; }

        #endregion Private Properties

        #region Public Methods

        /// <summary>
        /// The PopulateRoles method.
        /// </summary>
        public void PopulateRoles()
        {
            clbRoles.Items.Clear();

            // Get the existing roles from the VideoXpert system and add them to the list box.
            var table = new DataTable();
            table.Columns.Add(new DataColumn("OBJECT", typeof(Role)));
            table.Columns.Add(new DataColumn("NAME", typeof(string)));
            foreach (var role in MainForm.CurrentSystem.Roles.Where(role => !role.IsReadOnly || role.Name == "administrator"))
                table.Rows.Add(role, role.Name);

            clbRoles.DataSource = table;
            clbRoles.ValueMember = "OBJECT";
            clbRoles.DisplayMember = "NAME";
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// The ButtonAdd_Click method.
        /// </summary>
        /// <param name="sender">The <paramref name="sender"/> parameter.</param>
        /// <param name="args">The <paramref name="args"/> parameter.</param>
        private void ButtonAdd_Click(object sender, EventArgs args)
        {
            var roles = (from DataRowView view in clbRoles.CheckedItems select (Role)view["OBJECT"]).ToList();

            var newNotification = new NewNotification();
            foreach (var role in roles)
                newNotification.Roles.Add(role);

            SelectedSituation.AddNotification(newNotification);
        }

        #endregion Private Methods
    }
}