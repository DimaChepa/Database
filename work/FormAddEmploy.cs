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
using System.Security.Cryptography;
namespace work
{
  public partial class FormAddEmploy : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        public SqlDataAdapter dAdapt;
        private static DataRow[] drsEmployPos = null;
        private string cnStr = string.Empty;
        private SqlDataAdapter empPosTableAdapter;
        string[] str;
        public FormAddEmploy()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
          
            
        }

       

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(txtAddPassword.Text));
                byte[] result = md5.Hash;
                StringBuilder str = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    str.Append(result[i].ToString("x2"));
                }
                string converttocode = drsEmployPos[cmbBoxAddPos.SelectedIndex]["Code"].ToString();
                string sql  =string.Format("Insert Into Employ (Login, Password, Surname, Name, Second_Name, Telephone, Position, Status) Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", txtAddLogin.Text, str.ToString(), txtAddSurname.Text, txtAddName.Text, txtAddSecond.Text, txtAddPhone.Text, converttocode, txtAddStatus.Text);
                dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(oilstationDS, "Employ");
                MessageBox.Show("Сотрудник нанят");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможность добавления");
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.ShowDialog();
            this.Close();
        }

        private void FormAddEmploy_Load(object sender, EventArgs e)
        {
            cmbBoxAddPos.Items.Clear();
            DataTable dt = new DataTable();
            empPosTableAdapter = new SqlDataAdapter("Select * from Employee_position", cnStr);
            empPosTableAdapter.Fill(dt);
            drsEmployPos = dt.Select("Code > '0'");
            str = new string[drsEmployPos.Length];
            for (int i = 0; i < drsEmployPos.Length; i++)
            {
                str[i] = drsEmployPos[i]["Position"].ToString();
                cmbBoxAddPos.Items.Add(str[i]);
            }
        }
    }
}
