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

namespace BoxManager.Interfaces
{
    public partial class Torneo : Form
    {

        //Variables
        private OperacionesLINQ action = new OperacionesLINQ();
        private int categoria;


        public Torneo()
        {
            InitializeComponent();
        }


        //Retorna la rama dependiendo de que radiobutton este presionado
        private String obtenerRama()
        {
            if (this.rbVaronil.Checked == true)
            {
                return "Varonil";
            }
            else if (this.rbFemenil.Checked == true)
            {
                return "Femenil";
            }
            else return null;
        }

        private void Torneo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Menu().Show();
        }

        private void Torneo_Load(object sender, EventArgs e)
        {

        }

        private void rbVaronil_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCategorias = action.llenarCategoriasByRama(comboBoxCategorias, obtenerRama());
        }

        private void rbFemenil_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCategorias = action.llenarCategoriasByRama(comboBoxCategorias, obtenerRama());
        }

        private void comboBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCategorias.SelectedValue != null)
            {
                categoria = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString());
                comboBoxDivisiones = action.llenarDivisiones(comboBoxDivisiones, categoria);
            }
        }

        private void comboBoxDivisiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtrosValidados())
            {
                llenarBoxeadoresDisponibles();
            }
        }

        private void llenarBoxeadoresDisponibles()
        {
            Boxeadore[] boxeadores = action.filtrarBoxeadores(
                    this.categoria,
                    Convert.ToInt32(comboBoxDivisiones.SelectedValue.ToString()),
                    this.obtenerRama());
            foreach (Boxeadore boxeador in boxeadores)
            {
                dgDisponibles.Rows.Add(boxeador.Id_Boxeador, boxeador.Nombre);
            }
            dgDisponibles.Refresh();
        }

        private Boolean filtrosValidados()
        {
            int filtro = 0;
            if (!String.IsNullOrEmpty(obtenerRama())) filtro++;
            if (comboBoxCategorias.SelectedIndex != -1) filtro++;
            if (comboBoxDivisiones.SelectedIndex != -1) filtro++;
            if (filtro == 3) return true;
            return false;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            deshabilitarFiltros();
            foreach (DataGridViewRow dr in dgDisponibles.SelectedRows)
            {
                dgSeleccionados.Rows.Add(dr.Cells[0].Value, dr.Cells[1].Value);
                dgDisponibles.Rows.Remove(dr);
            }
            dgSeleccionados.Refresh();
        }

        public void deshabilitarFiltros()
        {
            comboBoxDivisiones.Enabled = false;
            comboBoxCategorias.Enabled = false;
            rbFemenil.Enabled = false;
            rbVaronil.Enabled = false;
        }

        public void habilitarFiltros()
        {
            comboBoxDivisiones.Enabled = true;
            comboBoxCategorias.Enabled = true;
            rbFemenil.Enabled = true;
            rbVaronil.Enabled = true;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgSeleccionados.SelectedRows)
            {
                dgDisponibles.Rows.Add(dr.Cells[0].Value, dr.Cells[1].Value);
                dgSeleccionados.Rows.Remove(dr);
            }
            dgDisponibles.Refresh();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            habilitarFiltros();
            textBoxNombreT.Text = String.Empty;
            rbVaronil.Checked = false;
            rbFemenil.Checked = false;
            comboBoxCategorias.DataSource = null;
            comboBoxCategorias.Text = String.Empty;
            comboBoxDivisiones.DataSource = null;
            comboBoxDivisiones.Text = String.Empty;
            dgDisponibles.Rows.Clear();
            dgDisponibles.Refresh();
            dgSeleccionados.Rows.Clear();
            dgSeleccionados.Refresh();
        }
    }
}
