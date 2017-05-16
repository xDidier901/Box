using System;
using System.Windows.Forms;
using BoxManager.Interfaces;
using BoxManager.Classes;
using BoxManager.Reportes;
using LibreriaRegistros;

namespace BoxManager
{
    public partial class Menu : Form
    {
        //Variables
        private OperacionesLINQ action = new OperacionesLINQ();
        int[] registro;

        public Menu()
        {
            InitializeComponent();

            registro = action.obtenerRegistros();
            //    llenarRegistrios();
        }

        //public void llenarRegistrios()
        //{
        //    labelCantBoxeadores.Text = registro[0].ToString();
        //    labelCantCategorias.Text = registro[1].ToString();
        //    labelCantDivisiones.Text = registro[2].ToString();
        //    labelCantAcciones.Text = registro[3].ToString();
        //}

        private void buttonBoxeadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Interfaces.Boxeadores().Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Acciones().Show();
        }

        private void buttonCatDiv_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DivisionesCategorias().Show();
        }

        private void buttonAgregarBoxeador_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Interfaces.Boxeadores().Show();
        }

        private void buttonAgregarCateDiv_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DivisionesCategorias().Show();
        }

        private void buttonCrearTorneo_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BoxeadoresReport().Show();
        }

        private void buttonRegistros_Click(object sender, EventArgs e)
        {
            new Registros(registro).Show();
        }
    }
}
