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
   
    public partial class FormDeleteProvider : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        private string cnStr = string.Empty;
        public FormDeleteProvider()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
        }

        private void FormDeleteProvider_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dAdapt = new SqlDataAdapter("Select* From Information_about_provider", cnStr);
            DataTable dt = new DataTable();
            dAdapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("Delete from Information_about_provider where Code = '{0}'", txtDelete.Text);
                SqlDataAdapter dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(oilstationDS, "Information_about_provider");
                SqlDataAdapter update = new SqlDataAdapter("Select * from Information_about_provider", cnStr);
                DataTable dt = new DataTable();
                update.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Поставщик удален");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Удаление невозможно");
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
