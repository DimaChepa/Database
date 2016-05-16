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
    public partial class FormDeletePosition : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        private string cnStr = string.Empty;
        public FormDeletePosition()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
        }

        private void FormDeletePosition_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dAdapt = new SqlDataAdapter("Select* From Employee_position", cnStr);
            DataTable dt = new DataTable();
            dAdapt.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("Delete from Employee_position where Code = '{0}'", txtxDelete.Text);
                SqlDataAdapter dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(oilstationDS, "Employee_position");
                SqlDataAdapter update = new SqlDataAdapter("Select * from Employee_position", cnStr);
                DataTable dt = new DataTable();
                update.Fill(dt);
                dataGridView1.DataSource = dt;              
                MessageBox.Show("Должность сокращена");
                
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
