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
    public partial class FormAddEquipment : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        public SqlDataAdapter dAdapt;
        private static DataRow[] drsSellFuel = null;
        private string cnStr = string.Empty;
        private SqlDataAdapter SellFuelTableAdapter;
        string[] str;
        public DataRow[] drs1 = null;
        SqlDataAdapter empTableAdapter;
        SqlCommandBuilder sqlCBEmployer;
        public FormAddEquipment()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
            empTableAdapter = new SqlDataAdapter("Select * from Employ", this.cnStr);
            sqlCBEmployer = new SqlCommandBuilder(empTableAdapter);
            empTableAdapter.Fill(oilstationDS, "Employ");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] Mas = System.Text.RegularExpressions.Regex.Split(txtSurname.Text, " ");
            drs1 = this.oilstationDS.Tables["Employ"].Select(string.Format("Surname = '{0}' and Name = '{1}'", Mas[0], Mas[1]));
            string code = drs1[0]["Code"].ToString();
    
            string sql = string.Format("Insert Into Equipment (finaly_date, Name, Surname,  Price_for_one) Values('{0}', '{1}', '{2}', '{3}' )", finaldate.Text, txtName.Text, code, txtPrice.Text);
            dAdapt = new SqlDataAdapter(sql, cnStr);
            dAdapt.Fill(oilstationDS, "Equipment");
            MessageBox.Show("Инвентарь добавлен");
        }

        private void FormAddEquipment_Load(object sender, EventArgs e)
        {
            txtSurname.Text = this.Text;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormExpert form = new FormExpert();
            form.ShowDialog();
            this.Close();
        }
    }
}
