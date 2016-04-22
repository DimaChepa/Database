using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            this.Text = FormConnection.NameString;
      
        }

        private void продатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void бензинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSellFuel form = new FormSellFuel();
            form.Text = this.Text;
            form.ShowDialog();
            this.Close();
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddProducts form = new FormAddProducts();
            form.Text = this.Text;
            form.ShowDialog();
            this.Close();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConnection form = new FormConnection();
            form.ShowDialog();
            this.Close();
        }

        private void товарToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBuyProduct form = new FormBuyProduct();
            form.ShowDialog();
            this.Close();
        }

        private void остатокТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewProduct form = new FormViewProduct();
            form.ShowDialog();
            this.Close();

        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
