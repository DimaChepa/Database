using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work
{
    public partial class FormPrintCheck : Form
    {
        public FormPrintCheck()
        {
            InitializeComponent();
        }

        private void FormPrintCheck_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetCheck.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetCheck.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
