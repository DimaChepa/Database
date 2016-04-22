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
    public partial class FormExpert : Form
    {
        public FormExpert()
        {
            InitializeComponent();
           this.Text = FormConnection.NameString;
        }

        private void btnAddThing_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddEquipment form = new FormAddEquipment();
            form.Text = FormConnection.NameString;
            form.ShowDialog();
            
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConnection form = new FormConnection();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormViewEquipment form = new FormViewEquipment();
            form.ShowDialog();
        }
    }
}
