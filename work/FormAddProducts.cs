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
    public partial class FormAddProducts : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        private string cnStr = string.Empty;
        public DataRow[] information;
        DataRow[] inform = null;
        public FormAddProducts()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
            SqlDataAdapter empTableAdapter = new SqlDataAdapter("Select * from Employ", this.cnStr);
            SqlCommandBuilder sqlCBEmployer = new SqlCommandBuilder(empTableAdapter);
            empTableAdapter.Fill(oilstationDS, "Employ");
            SqlDataAdapter stockAdapter = new SqlDataAdapter("Select * from Stock", cnStr);
            SqlCommandBuilder cmd = new SqlCommandBuilder(stockAdapter);
            stockAdapter.Fill(oilstationDS, "Stock");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Delete from Stock where Total_Count = '0'", cnStr);
                sqlDataAdapter.Fill(new DataTable());
                string[] Mas = System.Text.RegularExpressions.Regex.Split(txtCustomer.Text, " ");
                inform = this.oilstationDS.Tables["Employ"].Select(string.Format("Surname = '{0}' and Name = '{1}'", Mas[0], Mas[1]));
                string code = inform[0]["Code"].ToString();

                string converttocode = information[cmbboxName.SelectedIndex]["Code"].ToString();
                string sql = string.Format("Insert Into Store (Name, Surname, Count, Price, Date) Values('{0}', '{1}', '{2}', '{3}', '{4}')", converttocode, code, txtCount.Text, txtPrice.Text, CalendarSell.Text);
                SqlDataAdapter dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(oilstationDS, "Store");

                string New_query_update = string.Format("declare @Vol int "+
"select @Vol = Count  from Store "+
"where Code = (select Max(Code) from Store) "+

"if @Vol > (select Max(Stock.Total_Count)  from Stock "+
"INNER JOIN "+
                        " Store ON Stock.Code = Store.Name) "+
"delete from Store "+
"where Code = (select Max(Code) from Store) "+ 
"else update Stock set Total_Count = Stock.Total_Count - Store.Count "+
"FROM Stock INNER JOIN Store ON Stock.Code = Store.Name "+
"where Store.Code = (SElect MAX(Code) from Store)");
                SqlDataAdapter update = new SqlDataAdapter(New_query_update, cnStr);
                DataTable updateData = new DataTable();


                update.Fill(oilstationDS, "Stock");

                SqlDataAdapter dUpdateAdapt = new SqlDataAdapter("SElect Count from Store where Code=(Select MAX(Code) from Store)", cnStr);
                dUpdateAdapt.Fill(updateData);
                DataRow[] drsupdate = updateData.Select();

                if (drsupdate[0]["Count"].ToString() == txtCount.Text)
                {
                    MessageBox.Show("Товар продан");
                    FormCheckProdact form = new FormCheckProdact();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Товара нет в таком количестве");
                }
            }
            catch (Exception ex)
            {

                
                MessageBox.Show("Невозможно продать товар");
            }
        }

        private void FormAddProducts_Load(object sender, EventArgs e)
        {
            cmbboxName.Items.Clear();
            DataTable dt = new DataTable();
            SqlDataAdapter dAdapt = new SqlDataAdapter("Select * from Stock",cnStr);
            dAdapt.Fill(dt);
             information= dt.Select("Code > '0'");
            
            string []str = new string[information.Length];
            for (int i = 0; i < information.Length; i++)
            {
                str[i] = information[i]["Name"].ToString();
                cmbboxName.Items.Add(str[i]);
            }
            txtCustomer.Text = this.Text;
        }

        private void CalendarSell_ValueChanged(object sender, EventArgs e)
        {

        }
        public double someString;
        private void cmbboxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
           
            SqlDataAdapter dAdapt = new SqlDataAdapter("Select * from Stock", cnStr);
            dAdapt.Fill(dt);
            DataRow[] drs = dt.Select("Code > '0'");


            someString = Convert.ToDouble(drs[cmbboxName.SelectedIndex]["Price"].ToString());
            txtPrice.Text = Convert.ToString(someString * 0.5 + someString);
            CalendarSell.MinDate = Convert.ToDateTime(drs[cmbboxName.SelectedIndex]["Sell_date"].ToString());
        }
    }
}
