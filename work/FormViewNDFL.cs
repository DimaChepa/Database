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
    public partial class FormViewNDFL : Form
    {
        public FormViewNDFL()
        {
            InitializeComponent();
        }

        private void FormViewNDFL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetTax.Salar' table. You can move, or remove it, as needed.
            this.SalarTableAdapter.Fill(this.DataSetTax.Salar);

            this.reportViewer1.RefreshReport();
        }
    }
}
