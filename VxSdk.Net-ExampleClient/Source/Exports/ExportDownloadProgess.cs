using System;
using System.Windows.Forms;

namespace ExampleClient.Source.Exports
{
    public partial class ExportDownloadProgess : Form
    {
        #region Private Fields

        private bool _canceled = false;

        #endregion Private Fields

        #region Public Constructors

        public ExportDownloadProgess()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Properties

        public bool Canceled { get { return _canceled; } }

        #endregion Public Properties

        #region Private Methods

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            _canceled = true;
        }

        private void ExportDownloadProgess_Load(object sender, EventArgs e)
        {
        }

        #endregion Private Methods
    }
}