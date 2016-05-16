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
using System.Security.Cryptography;

namespace work
{
    public partial class FormConnection : Form
    {
        
        public DataSet oilstationDS = new DataSet("OilStation");
        public SqlDataAdapter empTableAdapter;
        public SqlCommandBuilder sqlCBEmployer;
        private  static DataRow[] drsUser = null;
        public static  string NameString
        {
            get;
            set;
        }
        public string DataPerson
        {
            get; set;
        }
        private string cnStr = string.Empty;
        string state
        {
            get; set;
        }
        public FormConnection()
        {
            InitializeComponent();
            
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
            empTableAdapter = new SqlDataAdapter("Select * from Employ", this.cnStr);
            sqlCBEmployer = new SqlCommandBuilder(empTableAdapter);
            empTableAdapter.Fill(oilstationDS, "Employ");
            txtPassword.PasswordChar = '*';
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            /*try
            {*/       
            //txtPassword.Text = GetMD5(txtLogin.Text); 
            
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(txtPassword.Text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
            drsUser = this.oilstationDS.Tables["Employ"].Select(string.Format("Login = '{0}' and Password = '{1}'", txtLogin.Text, str.ToString()));
            string insert = string.Format("INSERT INTO Journal " +
                    "(Employ, Name_query, Name_Table, Date_Execute) " +
"VALUES('{0}','Вход в базу','Employ','{1}')", drsUser[0]["Login"].ToString(), DateTime.Now.ToShortDateString());
            SqlDataAdapter dAda = new SqlDataAdapter(insert, cnStr);
            dAda.Fill(new DataTable());
            state = drsUser[0]["Status"].ToString();
                Connect();
                
       /*     }
            
            catch (Exception ex)
            {
                MessageBox.Show("Неверный логин или пароль");
            }     */
        }
        public void Connect()
        {
            if (state == "Admin")
            {
                this.Hide();
                MainForm form = new MainForm();
                form.ShowDialog();
                this.Close();
            }
            if (state == "Customer")
            {
                this.Hide();
                FormCustomer form = new FormCustomer();

                NameString = drsUser[0]["Surname"].ToString() + " " + drsUser[0]["Name"].ToString();
                form.Text = NameString;
                DataPerson= drsUser[0]["Surname"].ToString() + " " + drsUser[0]["Name"].ToString();
                form.ShowDialog();
                this.Close();
            }
            if (state == "Expert")
            {
                this.Hide();
                FormExpert form = new FormExpert();
                NameString = drsUser[0]["Surname"].ToString() + " " + drsUser[0]["Name"].ToString();
                form.Text = NameString;
                form.ShowDialog();
                this.Close();
            }

        }
    }
}
