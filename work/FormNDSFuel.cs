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
    public partial class FormNDSFuel : Form
    {
        public FormNDSFuel()
        {
            InitializeComponent();
        }

        private void FormNDSFuel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OilStationDataSet1.Selling_Client' table. You can move, or remove it, as needed.
            this.Selling_ClientTableAdapter.Fill(this.OilStationDataSet1.Selling_Client);

            this.reportViewer1.RefreshReport();
        }
    }
}
