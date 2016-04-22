using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace work
{
    public partial class FormBuyProduct : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        public SqlDataAdapter dAdapt;
        private static DataRow[] drsAddFuel = null;
        private string cnStr = string.Empty;
        private SqlDataAdapter BuyFuelTabkeAdapter;
        string[] str;
        public FormBuyProduct()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
               

                string sql = string.Format("Insert Into Stock (Name,Total_count, Price, Sell_date) Values('{0}', '{1}', '{2}', '{3}')", txtName.Text, txtCount.Text, txtPrice.Text, BuyCalendar.Text);
                dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(oilstationDS, "Stock");
                MessageBox.Show("Товар куплен");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCustomer form = new FormCustomer();
            form.ShowDialog();
            this.Close();
        }
    }
}
