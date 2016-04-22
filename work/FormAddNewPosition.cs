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
    public partial class FormAddNewPosition : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        private string cnStr = string.Empty;
        public FormAddNewPosition()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            try
            {
               
                string sql = string.Format("Insert into Employee_position" + "(Position, hourly_pay) Values" + "( '{0}', '{1}')", txtAddPosition.Text, txtAddPay.Text);
                SqlDataAdapter addPosTableAdapter = new SqlDataAdapter(sql, cnStr);
                addPosTableAdapter.Fill(oilstationDS, "Employee_position");


                MessageBox.Show("Вакансия добавлена");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
}
