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
    public partial class FormViewEquipment : Form
    {
        public FormViewEquipment()
        {
            InitializeComponent();
        }

        private void FormViewEquipment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OilStationDataSet.Equipment' table. You can move, or remove it, as needed.
            this.EquipmentTableAdapter.Fill(this.OilStationDataSet.Equipment);

            this.reportViewer1.RefreshReport();
        }
    }
}
