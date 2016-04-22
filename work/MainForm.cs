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
    public partial class MainForm : Form
    {
        public DataSet oilstationDS = new DataSet("OilStation");

        private string cnStr = string.Empty;
        public MainForm()
        {
            InitializeComponent();
            cnStr = ConfigurationManager.ConnectionStrings["OilStationsqlprovider"].ConnectionString;
        }

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddProvider form = new FormAddProvider();
            form.ShowDialog();
        }

        private void должностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddNewPosition form = new FormAddNewPosition();
            form.ShowDialog();
        }

        private void сотрудникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddEmploy form = new FormAddEmploy();
            form.ShowDialog();
        }

        private void бензинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBuyFuel form = new FormBuyFuel();
            form.ShowDialog();
            this.Close();
        }

        private void проданыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void заДеньToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormRepordSellFuel form = new FormRepordSellFuel();
            form.ShowDialog();

        }

        private void заНеделюToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormReportSellFuelWeek form = new FormReportSellFuelWeek();
            form.ShowDialog();

        }

        private void заМесяцToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormReportSellFuelMonth form = new FormReportSellFuelMonth();
            form.ShowDialog();

        }

        private void заГодToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormSellFuelYear form = new FormSellFuelYear();
            form.ShowDialog();
    
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void начислитьЗарплатуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddSalary form = new FormAddSalary();
            form.ShowDialog();
            this.Close();
        }

        private void вакансияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeletePosition form = new FormDeletePosition();
            form.ShowDialog();
            this.Close();
        }

        private void сотрудникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeleteWorker form = new FormDeleteWorker();
            form.ShowDialog();
            this.Close();
        }

        private void поставщикToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDeleteProvider form = new FormDeleteProvider();
            form.ShowDialog();
            this.Close();
        }

        private void остаткиБензинаToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormControlFuel form = new FormControlFuel();
            form.ShowDialog();

        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConnection form = new FormConnection();
            form.ShowDialog();
            this.Close();
        }

        private void зарплатыToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormSalaryReport form = new FormSalaryReport();
            form.ShowDialog();

        }

        private void нДФЛToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            FormViewNDFL form = new FormViewNDFL();
            form.ShowDialog();

        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormViewWorkers form = new FormViewWorkers();
            form.ShowDialog();
            
        }

        private void проданныйТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void самыйПопулярныйБензинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = string.Format("SELECT        SUM(Selling_Client.Volume) AS Expr1, Provider.Name_fuel " +
"FROM            Provider INNER JOIN " +
                         "Selling_Client ON Provider.Code = Selling_Client.Name " +


"GROUP BY Provider.Name_fuel " +
"having sum(Selling_Client.Volume) >= All(select sum(Selling_Client.Volume) " +
 "FROM            Provider INNER JOIN " +
                         "Selling_Client ON Provider.Code = Selling_Client.Name " +

                         "GROUP BY Provider.Name_fuel)");
            SqlDataAdapter dAdapt = new SqlDataAdapter(sql, cnStr);
            DataTable dt = new DataTable();
            dAdapt.Fill(dt);
            DataRow[] drs = dt.Select();
            string smth = string.Format("Количество проданного {0} бензина: {1} литра", drs[0]["Name_Fuel"].ToString(), drs[0]["Expr1"].ToString());
            MessageBox.Show(smth);
        }

        private void заДеньToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewSaleProductsDay form = new ViewSaleProductsDay();
            form.ShowDialog();
        }

        private void заНеделюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSaleProductWeek form = new FormSaleProductWeek();
            form.ShowDialog();
        }

        private void списатьБензинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCancelFuel form = new FormCancelFuel();
            form.ShowDialog();
        }

        private void заМесяцToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSaleProductMonth form = new FormSaleProductMonth();
            form.ShowDialog();
            
        }

        private void бензинToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormNDSFuel form = new FormNDSFuel();
            form.ShowDialog();
        }
    }
}
