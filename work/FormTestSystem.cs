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
using System.Diagnostics;

namespace work
{
    public partial class FormTestSystem : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");
        private string cnStr = string.Empty;
        public FormTestSystem()
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

        private void btnTest_Click(object sender, EventArgs e)
        {
            /* try
             {  */
            Stopwatch st = new Stopwatch();
            st.Start();
            for (int i = 0; i < Convert.ToInt32(cmbItems.SelectedItem.ToString()); i++)
            {
                
                string sql = string.Format("Insert into Selling_Client (Name, Volume, Price_for_litr, Surname_Customer, Selling_day) VALUES(NULL,NULL,NULL,NULL,NULL)" );
                SqlDataAdapter dAdapt = new SqlDataAdapter(sql, cnStr);
                dAdapt.Fill(new DataTable());
            }
            st.Stop();
            txtAddTime.Text = st.ElapsedMilliseconds.ToString();
            st.Reset();
            st.Start();
            string select_sql = string.Format("SELECT  TOP {0}    Code, Name, Volume, Price_for_litr, Surname_Customer, Selling_day " +
"FROM            Selling_Client   ORDER BY  Code desc", cmbItems.SelectedItem.ToString());
            SqlDataAdapter dAdaptselect = new SqlDataAdapter(select_sql, cnStr);
            dAdaptselect.Fill(new DataTable());
            st.Stop();
            txtSelectTime.Text = st.ElapsedMilliseconds.ToString();

            st.Reset();
            st.Start();
            string update_sql = string.Format("UPDATE       Selling_Client "+
"SET                Name = NULL "+
"where Surname_Customer = NULL");
            SqlDataAdapter dAdaptUpdate = new SqlDataAdapter(update_sql, cnStr);
            dAdaptUpdate.Fill(new DataTable());
            st.Stop();
            txtUpdateTime.Text = st.ElapsedMilliseconds.ToString();


            st.Reset();
            st.Start();
            string delete_sql = string.Format("WITH CTE AS(SELECT TOP({0}) * FROM Selling_Client ORDER BY Code DESC) "+
"DELETE CTE ", cmbItems.SelectedItem.ToString());
            SqlDataAdapter dAdaptDelete = new SqlDataAdapter(delete_sql, cnStr);
            dAdaptDelete.Fill(new DataTable());
            st.Stop();
            txtDeleteTime.Text = st.ElapsedMilliseconds.ToString();
        //    }
           /* catch (Exception ex)
            {
                MessageBox.Show("Невозможно протестировать");
            }    */
        }
    }
}
