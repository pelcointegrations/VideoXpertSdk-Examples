using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleClient.Source.Exports
{
    public partial class ExportDownloadProgess : Form
    {
        public ExportDownloadProgess()
        {
            InitializeComponent();
        }

        bool _canceled = false;
        private void Button_cancel_Click(object sender, EventArgs e)
        {
            _canceled = true;
        }

        public bool Canceled { get { return _canceled; } }

        private void ExportDownloadProgess_Load(object sender, EventArgs e)
        {

        }
    }
}
