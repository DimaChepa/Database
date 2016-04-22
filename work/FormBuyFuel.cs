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
    public partial class FormBuyFuel : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        public SqlDataAdapter dAdapt;
        private static DataRow[] drsAddFuel = null;
        private string cnStr = string.Empty;
        private SqlDataAdapter BuyFuelTabkeAdapter;
        string[] str;
        public FormBuyFuel()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
             SqlDataAdapter empTableAdapter = new SqlDataAdapter("Select * from Employ", this.cnStr);
            SqlCommandBuilder sqlCBEmployer = new SqlCommandBuilder(empTableAdapter);
            empTableAdapter.Fill(oilstationDS, "Employ");
        }

        private void Purch_DateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void FormBuyFuel_Load(object sender, EventArgs e)
        {
            cmbBoxNameProvider.Items.Clear();
            DataTable dt = new DataTable();
            BuyFuelTabkeAdapter = new SqlDataAdapter("Select * from Information_about_provider", cnStr);
            BuyFuelTabkeAdapter.Fill(dt);
            drsAddFuel = dt.Select("Code > '0'");
            str = new string[drsAddFuel.Length];
            for (int i = 0; i < drsAddFuel.Length; i++)
            {
                str[i] = drsAddFuel[i]["Name"].ToString();
                cmbBoxNameProvider.Items.Add(str[i]);
            }

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                string converttocode = drsAddFuel[cmbBoxNameProvider.SelectedIndex]["Code"].ToString();
               
                string sql = string.Format("Insert Into Provider (Name, Volume, Purch_price, Purch_date, Name_fuel) Values('{0}', '{1}', '{2}', '{3}', '{4}')", converttocode,(txtVolume.Text), txtPrice_litr.Text, Buy_Date.Text, txtNameFuel.Text);
                dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(oilstationDS, "Provider");
                MessageBox.Show("Бензин куплен");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно купить");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void cmbBoxNameProvider_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
