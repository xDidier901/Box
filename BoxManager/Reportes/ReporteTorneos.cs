using BoxManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxManager.Reportes
{
    public partial class ReporteTorneos : Form
    {
        BoxDBDataContext Database = new BoxDBDataContext();
        int torneoID = 0;

        public ReporteTorneos(int torneoID)
        {
            InitializeComponent();
            this.torneoID = torneoID;
        }

        private void ReporteTorneos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'boxManagerDBDataSetPeleasPorTorneoID.reportePeleasPorTorneoID' table. You can move, or remove it, as needed.
            //this.reportePeleasPorTorneoIDTableAdapter.Fill(this.boxManagerDBDataSetPeleasPorTorneoID.reportePeleasPorTorneoID);
            // TODO: This line of code loads data into the 'boxManagerDBDataSetPeleasPorTorneoID.reportePeleasPorTorneoID' table. You can move, or remove it, as needed.
            this.reportePeleasPorTorneoIDBindingSource.DataSource = Database.reportePeleasPorTorneoID(this.torneoID);
            this.reportViewer1.RefreshReport();
        }
    }
}
