using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace work
{
    public partial class FormViewWorkers : Form
    {

        public DataSet oilstationDS = new DataSet("OilStation");
        private string cnStr = string.Empty;
        public FormViewWorkers()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
        }

        private void FormViewWorkers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetViewWork.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.DataSetViewWork.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
