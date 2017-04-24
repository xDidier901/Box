using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoxManager.Classes;

namespace BoxManager.Reportes
{
    public partial class BoxeadoresReport : Form
    {
        BoxDBDataContext Database = new BoxDBDataContext();
        public BoxeadoresReport()
        {
            InitializeComponent();
        }

        private void ReporteBoxeadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReporteBoxeadores.reporteBoxeadoresPorCategoriaDivisionMunicipio' table. You can move, or remove it, as needed.
            reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource = Database.reporteBoxeadores();

            this.reportViewer1.RefreshReport();
        }

        private void Boxeadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Menu().Show();
        }
    }
}
