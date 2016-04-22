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
    public partial class FormCancelFuel : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        private string cnStr = string.Empty;
        public FormCancelFuel()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
        }

        private void FormCancelFuel_Load(object sender, EventArgs e)
        {
            cmbFuel.Items.Clear();
            DataTable dt = new DataTable();
            SqlDataAdapter SellFuelTableAdapter = new SqlDataAdapter("Select * from Provider", cnStr);
            SellFuelTableAdapter.Fill(dt);
            DataRow[] drsSellFuel = dt.Select("Code > '0'");
            string []str = new string[drsSellFuel.Length];
            for (int i = 0; i < drsSellFuel.Length; i++)
            {
                str[i] = drsSellFuel[i]["Name_fuel"].ToString();
                cmbFuel.Items.Add(str[i]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("Delete from Provider where Name_Fuel = '{0}'", cmbFuel.SelectedItem.ToString());
                SqlDataAdapter dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(oilstationDS, "Provider");
                MessageBox.Show("Списание успешно");

                cmbFuel.Items.Clear();
                DataTable dt = new DataTable();
                SqlDataAdapter SellFuelTableAdapter = new SqlDataAdapter("Select * from Provider", cnStr);
                SellFuelTableAdapter.Fill(dt);
                DataRow[] drsSellFuel = dt.Select("Code > '0'");
                string[] str = new string[drsSellFuel.Length];
                for (int i = 0; i < drsSellFuel.Length; i++)
                {
                    str[i] = drsSellFuel[i]["Name_fuel"].ToString();
                    cmbFuel.Items.Add(str[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно списать");
            }
        }
    }
}
