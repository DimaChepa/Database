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
    public partial class FormAddProvider : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        private string cnStr = string.Empty;
        public FormAddProvider()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter infTableAdapter;
                string sql = string.Format("Insert into Information_about_provider" + "(Name, [E-mail], Country, City, Street, Build, Telephone)Values" + "('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}')", txtAddName.Text, txtAddEMail.Text,txtAddCountry.Text,txtAddTown.Text,txtAddStreet.Text,txtAddBuilding.Text,txtAddPhone.Text );
                infTableAdapter = new SqlDataAdapter(sql, cnStr);
                infTableAdapter.Fill(oilstationDS, "Information_about_provider");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некоректные данные");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }
    }
}
