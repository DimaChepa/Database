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
    public partial class FormAddSalary : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");

        private string cnStr = string.Empty;
        public FormAddSalary()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
           /* SqlDataAdapter data = new SqlDataAdapter("Select * from Employee_position", cnStr);
            SqlCommandBuilder scb = new SqlCommandBuilder(data);
            data.Fill(oilstationDS, "");*/


        }

        private void btnGetWorker_Click(object sender, EventArgs e)
        {
            dataGridGetWorker.Visible = true;
            SqlDataAdapter dAdapt;
            dAdapt = new SqlDataAdapter("SELECT Login, Surname, Name, Second_Name FROM Employ", cnStr);
            DataTable dt = new DataTable();
            dAdapt.Fill(dt);
            dataGridGetWorker.DataSource = dt;
        }

        private void FormAddSalary_Load(object sender, EventArgs e)
        {
            
            cmbBoxCode.Items.Clear();
            DataTable dt = new DataTable();
            SqlDataAdapter dAdapt;
            DataRow[] drsEmployPos = null;
            string[] str;
            dAdapt = new SqlDataAdapter("Select * from Employ", cnStr);
            dAdapt.Fill(dt);
            drsEmployPos = dt.Select("Code > '0'");
            str = new string[drsEmployPos.Length];
            for (int i = 0; i < drsEmployPos.Length; i++)
            {
                str[i] = drsEmployPos[i]["Login"].ToString();
                cmbBoxCode.Items.Add(str[i]);
            }
            
        }
        bool same = false;
        int next = 0;
        int next1 = 1;
    
        
        private void cmbBoxCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dAdapt;
            dAdapt = new SqlDataAdapter("Select * from Employ", cnStr);
            dAdapt.Fill(dt);
            DataRow[] drs = dt.Select("Code > '0'");
            txtName.Text = drs[cmbBoxCode.SelectedIndex]["Surname"].ToString();
          
            string sql = string.Format("SELECT        Employee_position.Hourly_pay "+
"FROM            Employ INNER JOIN "+
                         "Employee_position ON Employ.Position = Employee_position.Code "+
                         "Where Employee_position.Code = '{0}'", drs[cmbBoxCode.SelectedIndex]["Position"].ToString());
            dAdapt = new SqlDataAdapter(sql, cnStr);
            DataTable table = new DataTable();
            dAdapt.Fill(table);
            DataRow[] data = table.Select();
            txtHour_pay.Text = data[0]["Hourly_pay"].ToString();
         
                                   

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
             
                int value = Convert.ToInt32(Convert.ToInt32(txtWork_hour.Text) * Convert.ToDouble(txtHour_pay.Text) - 0.18 * Convert.ToInt32(txtWork_hour.Text) * Convert.ToDouble(txtHour_pay.Text));
                txtTotal.Text = Convert.ToString(value);
                int one;

                one = Convert.ToInt32(txtHour_pay.Text);

                string str = string.Format("Select Code from Employ where Login = '{0}'", cmbBoxCode.SelectedItem.ToString());
                SqlDataAdapter data = new SqlDataAdapter(str, cnStr);
                DataTable dt = new DataTable();
                data.Fill(dt);

                DataRow[] dr = dt.Select();

                string sql = string.Format("Insert Into Salar (Code, Name, Work_day, Hour_payment,Total_payment, Month) Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", cmbBoxCode.SelectedItem.ToString(), dr[0]["Code"].ToString(), Convert.ToInt32(txtWork_hour.Text), one, value, SalarCalendar.Text);
                SqlDataAdapter dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(oilstationDS, "Salar");
                MessageBox.Show("Зарплата начислена");
                SqlDataAdapter dAdapter = new SqlDataAdapter("Select * from Salar", cnStr);
                DataTable myDt = new DataTable();
                dAdapter.Fill(myDt);
                DataRow[] drs = myDt.Select("Code > '0'");
                SqlDataAdapter myAdapter = new SqlDataAdapter("Select * from Employ", cnStr);
                DataTable datatable = new DataTable();
                myAdapter.Fill(datatable);
                DataRow[] datarow = datatable.Select("Code > '0'");
                next++;
                if (next == datarow.Length * next1)
                {
                    cmbBoxCode.Items.Clear();
                    next1++;
                    SalarCalendar.MinDate = new DateTime(2016, next1, 01);
                    SqlDataAdapter myadapter;
                    DataRow[] drsEmployPos = null;
                    DataTable myTB = new DataTable();
                    string[] some;
                    myadapter = new SqlDataAdapter("Select * from Employ", cnStr);
                    myadapter.Fill(myTB);
                    drsEmployPos = myTB.Select("Code > '0'");
                    some = new string[drsEmployPos.Length];
                    for (int i = 0; i < drsEmployPos.Length; i++)
                    {
                        some[i] = drsEmployPos[i]["Login"].ToString();
                        cmbBoxCode.Items.Add(some[i]);
                    }
                }
                else
                {
                    cmbBoxCode.Items.RemoveAt(cmbBoxCode.SelectedIndex);
                }
              //  MessageBox.Show(datarow.Length.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно начислить зарплату");
            }
        }

        private void txtWork_hour_TextChanged(object sender, EventArgs e)
        {

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

