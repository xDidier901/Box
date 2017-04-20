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
    public partial class DivisionesCategorias : Form
    {

        //Variables
        private OperacionesLINQ action = new OperacionesLINQ();
        private Boolean botonPresionadoCat = false;
        private Boolean botonPresionadoDiv = false;
        private Categoria c;
        private Divisione d;

        public DivisionesCategorias()
        {
            InitializeComponent();
            action.mostrarCategorias(dgCategorias);
            action.mostrarDivisiones(dgDivisiones);
            comboBoxCategorias = action.llenarCategorias(comboBoxCategorias);
            
        }

        private void DivsionesCategorias_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Menu().Show();
        }

        private void comboBoxFiltCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltCat.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(comboBoxFiltCat.SelectedValue.ToString().Trim());
                action.mostrarDivisionesByCategoria(dgDivisiones, id);
            } else
            {
                action.mostrarDivisiones(dgDivisiones);
            }
        }

        private void comboBoxFiltCat_Click(object sender, EventArgs e)
        {
            comboBoxFiltCat = action.llenarCategorias(comboBoxFiltCat);
            buttonCancelarDiv.Enabled = true;
        }

        private void buttonCancelarDiv_Click(object sender, EventArgs e)
        {
            reestablecerPredeterminadoDiv();
        }

        private void reestablecerPredeterminadoDiv()
        {
            d = null;
            botonPresionadoDiv = false;
            this.dgDivisiones.Enabled = true;
            action.mostrarDivisiones(dgDivisiones);
            this.textBoxBuscarDivision.Enabled = true;
            this.textBoxBuscarDivision.Focus();
            this.llenarCamposDiv();
            this.groupBoxDivisiones.Enabled = false;
            this.buttonAgregarDiv.Enabled = true;
            this.buttonAgregarDiv.Text = "Agregar";
            this.buttonEditarDiv.Enabled = true;
            this.buttonEditarDiv.Text = "Editar";
            this.buttonCancelarDiv.Enabled = false;
            this.buttonEliminarDiv.Enabled = true;
            comboBoxFiltCat.Text = "";
            comboBoxFiltCat.Enabled = true;
        }

        private void llenarCamposDiv()
        {
            this.textBoxNombreDiv.Text = dgDivisiones.CurrentRow.Cells[1].Value.ToString().Trim();
            this.comboBoxCategorias.Text = dgDivisiones.CurrentRow.Cells[2].Value.ToString().Trim();
        }

        private void textBoxBuscarDivision_TextChanged(object sender, EventArgs e)
        {
            action.buscarDivisiones(dgDivisiones, textBoxBuscarDivision.Text.Trim());
        }

        private void dgDivisiones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            llenarCamposDiv();
        }

        private void buttonAgregarDiv_Click(object sender, EventArgs e)
        {

            if (botonPresionadoDiv == false)
            {

                botonPresionadoDiv = true;
                limpiarCamposDiv();

                this.groupBoxDivisiones.Enabled = true;
                this.buttonEditarDiv.Enabled = false;
                comboBoxFiltCat.Enabled = false;
                this.buttonEliminarDiv.Enabled = false;
                this.buttonCancelarDiv.Enabled = true;
                this.dgDivisiones.Enabled = false;
                this.textBoxBuscarDivision.Enabled = false;
                this.buttonAgregarDiv.Text = "Guardar";
                this.textBoxNombreDiv.Focus();

            }
            else if (botonPresionadoDiv == true)
            {
                if (datosCorrectosDiv())
                {
                    crearDivision();
                    action.agregarDivision(d);
                    reestablecerPredeterminadoDiv();
                }
                else
                {
                    MessageBox.Show("Los datos no estan correctos, no se puede agregar el boxeador a la base de datos");
                }
            }
        }

        //Valida los campos del formulario
        private bool datosCorrectosDiv()
        {
            int camposCorrectos = 0;
            if (this.textBoxNombreDiv.Text.Length != 0) camposCorrectos++;
            if (this.comboBoxCategorias.SelectedIndex != -1) camposCorrectos++;

            if (camposCorrectos == 2) return true;
            else return false;
        }

        private void limpiarCamposDiv()
        {
            this.textBoxNombreDiv.ResetText();
            comboBoxCategorias.SelectedIndex = -1;
        }


        //Crea un objeto division con la informacion de los campos
        private void crearDivision()
        {
            d = new Divisione();
            d.Nombre = textBoxNombreDiv.Text.Trim();
            d.Categoria = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString());
        }

        private void buttonEditarDiv_Click(object sender, EventArgs e)
        {
            if (botonPresionadoDiv == false)
            {

                botonPresionadoDiv = true;


                this.groupBoxDivisiones.Enabled = true;
                this.buttonAgregarDiv.Enabled = false;
                comboBoxFiltCat.Enabled = false;
                this.buttonEliminarDiv.Enabled = false;
                this.buttonCancelarDiv.Enabled = true;
                this.dgDivisiones.Enabled = false;
                this.textBoxBuscarDivision.Enabled = false;
                this.buttonEditarDiv.Text = "Guardar";
                this.textBoxNombreDiv.Focus();


            }
            else if (botonPresionadoDiv == true)
            {

                if (datosCorrectosDiv())
                {
                    crearDivision();
                    action.actualizarDivisión(d, obtenerIdDiv());
                    reestablecerPredeterminadoDiv();
                }
                else
                {
                    MessageBox.Show("Los datos no estan correctos, no se puede editar la división en la base de datos");
                }

            }
        }

        //Obtiene el ID de la division seleccionadoa en el datagrid
        private int obtenerIdDiv()
        {
            int id = Convert.ToInt32(dgDivisiones.CurrentRow.Cells[0].Value.ToString().Trim());
            return id;
        }

        private void buttonEliminarDiv_Click(object sender, EventArgs e)
        {
            String nombre = textBoxNombreDiv.Text.Trim();

            if (MessageBox.Show("¿Está seguro que desea eliminar la división " + nombre + " de la base de datos?", "Eliminar División", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                action.eliminarDivision(nombre, obtenerIdDiv());
                reestablecerPredeterminadoDiv();
            }
            else
            {
                reestablecerPredeterminadoDiv();
            }
        }
    }
}
