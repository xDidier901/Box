using System;
using System.Windows.Forms;
using BoxManager.Classes;

namespace BoxManager.Interfaces
{
    public partial class Acciones : Form
    {

        //Variables
        private OperacionesLINQ action = new OperacionesLINQ();


        public Acciones()
        {
            InitializeComponent();
            this.dtpFecha1.MaxDate = DateTime.Today;
            this.dtpFecha2.MaxDate = DateTime.Today;
            this.dtpFecha2.Value = DateTime.Today;
        }

        private void Acciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Acciones_Load(object sender, EventArgs e)
        {
            action.mostrarAcciones(dgAcciones);
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            action.buscarAcciones(dgAcciones, textBoxBuscar.Text.Trim());
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Menu().Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            DateTime[] fechas = new DateTime[] { dtpFecha1.Value, dtpFecha2.Value };
            action.buscarAccionesFechas(dgAcciones, fechas);

        }
    }
}
