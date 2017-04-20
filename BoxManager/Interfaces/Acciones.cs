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
            this.Hide();
            new Menu().Show();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Console.WriteLine("boton");
            DateTime[] fechas = new DateTime[] { dtpFecha1.Value, dtpFecha2.Value };
            Console.WriteLine("Fecha 1: "+fechas[0]+" Fecha 2: "+fechas[1]);

            action.buscarAccionesFechas(dgAcciones, fechas);

        }
    }
}
