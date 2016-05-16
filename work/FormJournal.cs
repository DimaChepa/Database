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
    public partial class FormJournal : Form
    {
        public FormJournal()
        {
            InitializeComponent();
        }

        private void FormJournal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetViewJournal.Journal' table. You can move, or remove it, as needed.
            this.JournalTableAdapter.Fill(this.DataSetViewJournal.Journal);

            this.reportViewer1.RefreshReport();
        }
    }
}
