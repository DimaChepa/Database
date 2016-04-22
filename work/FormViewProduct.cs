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
    public partial class FormViewProduct : Form
    {
        public FormViewProduct()
        {
            InitializeComponent();
        }

        private void FormViewProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetProduct.Stock' table. You can move, or remove it, as needed.
            this.StockTableAdapter.Fill(this.DataSetProduct.Stock);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
