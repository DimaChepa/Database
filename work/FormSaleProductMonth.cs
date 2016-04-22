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
    public partial class FormSaleProductMonth : Form
    {
        public FormSaleProductMonth()
        {
            InitializeComponent();
        }

        private void FormSaleProductMonth_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetSaleProductMonth.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetSaleProductMonth.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
