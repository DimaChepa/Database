﻿using System;
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
    public partial class FormSellFuel : Form
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
        public FormSellFuel()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
            empTableAdapter = new SqlDataAdapter("Select * from Employ", this.cnStr);
            sqlCBEmployer = new SqlCommandBuilder(empTableAdapter);
            empTableAdapter.Fill(oilstationDS, "Employ");
        }
        public double someString;
        public string one;
        private void btnSell_Click(object sender, EventArgs e)
        {
             try
             {

                if (txtPrice_for_litr.Text.Contains(","))
                {
                    string[] Double = System.Text.RegularExpressions.Regex.Split(txtPrice_for_litr.Text, ",");
                    one = Double[0] + "." + Double[1];
                }
                else
                {
                    one = txtPrice_for_litr.Text;
                }
                string[] Mas = System.Text.RegularExpressions.Regex.Split(txtSurname.Text, " ");
                drs1 = this.oilstationDS.Tables["Employ"].Select(string.Format("Surname = '{0}' and Name = '{1}'", Mas[0], Mas[1]));
                string code = drs1[0]["Code"].ToString();
                string converttocode = drsSellFuel[cmbBoxNameFuel.SelectedIndex]["Code"].ToString();
                string sql = string.Format("Insert Into Selling_Client (Name, Volume, Price_for_litr, Surname_Customer, Selling_day) Values('{0}', '{1}', '{2}', '{3}', '{4}')", converttocode,txtVolume.Text, one,code, dateTimeSelling.Text );
                dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(oilstationDS, "Provider");
                MessageBox.Show("Бензин продан");
                SqlDataAdapter update = new SqlDataAdapter("UPDATE Provider SET Volume = Provider.Volume - Selling_Client.Volume FROM Provider INNER JOIN Selling_Client ON Provider.Code = Selling_Client.Name", cnStr);
                update.Fill(oilstationDS, "Provider");
                FormPrintCheck form = new FormPrintCheck();
                form.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCustomer form = new FormCustomer();
            form.ShowDialog();
            this.Close();
        }

        private void FormSellFuel_Load(object sender, EventArgs e)
        {
            cmbBoxNameFuel.Items.Clear();
            DataTable dt = new DataTable();
            SellFuelTableAdapter = new SqlDataAdapter("Select * from Provider", cnStr);
            SellFuelTableAdapter.Fill(dt);
            drsSellFuel = dt.Select("Code > '0'");
            str = new string[drsSellFuel.Length];
            for (int i = 0; i < drsSellFuel.Length; i++)
            {
                str[i] = drsSellFuel[i]["Name_fuel"].ToString();
                cmbBoxNameFuel.Items.Add(str[i]);
            }
            
            txtSurname.Text = this.Text;
        }

        private void cmbBoxNameFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            DataTable dt = new DataTable();
  
            dAdapt = new SqlDataAdapter("Select * from Provider", cnStr);
            dAdapt.Fill(dt);
            DataRow[] drs = dt.Select("Code > '0'");
            someString = Convert.ToDouble(drs[cmbBoxNameFuel.SelectedIndex]["Purch_price"].ToString());
            txtPrice_for_litr.Text = Convert.ToString(someString * 0.5 + someString);
            
            dateTimeSelling.MinDate = Convert.ToDateTime(drs[cmbBoxNameFuel.SelectedIndex]["Purch_date"].ToString());


        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
           
        }
    }
}