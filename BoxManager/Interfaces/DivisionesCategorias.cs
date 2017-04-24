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
            comboBoxFiltRama.SelectedIndex = -1;

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
                    MessageBox.Show("Los datos no estan correctos, no se puede la división a la base de datos");
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

        private void textBoxBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            action.buscarCategorias(dgCategorias, textBoxBuscarCategoria.Text.Trim());
        }

        private void dgCategorias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            llenarCamposCat();
        }

        private void llenarCamposCat()
        {
            this.textBoxNombreCat.Text = dgCategorias.CurrentRow.Cells[1].Value.ToString().Trim();
            establecerRama();
        }

        //Marca cheked al radiobutton sobre la rama de acuerdo al datagrid
        private void establecerRama()
        {
            String rama = dgCategorias.CurrentRow.Cells[2].Value.ToString().Trim();

            if (rama.Equals("Varonil"))
            {
                this.rbVarCat.Checked = true;
                this.rbFemCat.Checked = false;
            }
            else if (rama.Equals("Femenil"))
            {
                this.rbFemCat.Checked = true;
                this.rbVarCat.Checked = false;
            }

        }

        private void comboBoxFiltRama_Click(object sender, EventArgs e)
        {
            comboBoxFiltRama.Items.Clear();
            comboBoxFiltRama.Items.Add("Varonil");
            comboBoxFiltRama.Items.Add("Femenil");
            buttonCancelarCat.Enabled = true;
        }

        private void comboBoxFiltRama_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFiltRama.SelectedIndex != -1)
            {
                action.mostrarCategoriasByRama(dgCategorias, comboBoxFiltRama.SelectedItem.ToString().Trim());
            }
            else
            {
                action.mostrarCategorias(dgCategorias);
            }
        }

        //Retorna la rama dependiendo de que radiobutton este presionado
        private String obtenerRama()
        {
            if (this.rbVarCat.Checked == true)
            {
                return "Varonil";
            }
            else if (this.rbFemCat.Checked == true)
            {
                return "Femenil";
            }
            else return "Undefined";
        }

        private void reestablecerPredeterminadoCat()
        {
            c = null;
            botonPresionadoCat = false;
            this.dgCategorias.Enabled = true;
            action.mostrarCategorias(dgCategorias);
            this.textBoxBuscarCategoria.Enabled = true;
            this.textBoxBuscarCategoria.Focus();
            this.llenarCamposCat();
            this.groupBoxCategorias.Enabled = false;
            this.buttonAgregarCat.Enabled = true;
            this.buttonAgregarCat.Text = "Agregar";
            this.buttonEditarCat.Enabled = true;
            this.buttonEditarCat.Text = "Editar";
            this.buttonCancelarCat.Enabled = false;
            this.buttonEliminarCat.Enabled = true;
            comboBoxFiltRama.Text = "";
            comboBoxFiltRama.Enabled = true;
        }

        private void buttonCancelarCat_Click(object sender, EventArgs e)
        {
            reestablecerPredeterminadoCat();
        }

        private void buttonAgregarCat_Click(object sender, EventArgs e)
        {

            if (botonPresionadoCat == false)
            {

                botonPresionadoCat = true;
                limpiarCamposCat();

                this.groupBoxCategorias.Enabled = true;
                this.buttonEditarCat.Enabled = false;
                comboBoxFiltRama.Enabled = false;
                this.buttonEliminarCat.Enabled = false;
                this.buttonCancelarCat.Enabled = true;
                this.dgCategorias.Enabled = false;
                this.textBoxBuscarCategoria.Enabled = false;
                this.buttonAgregarCat.Text = "Guardar";
                this.textBoxNombreCat.Focus();

            }
            else if (botonPresionadoCat == true)
            {
                if (datosCorrectosCat())
                {
                   crearCategoria();
                   action.agregarCategoria(c);
                   comboBoxCategorias = action.llenarCategorias(comboBoxCategorias);
                   reestablecerPredeterminadoCat();
                }
                else
                {
                    MessageBox.Show("Los datos no estan correctos, no se puede agregar la categoría a la base de datos");
                }
            }
        }

        //Crea un objeto categirua con la informacion de los campos
        private void crearCategoria()
        {
            c = new Categoria();
            c.Nombre = textBoxNombreCat.Text.Trim();
            c.Rama = obtenerRama();
        }

        //Valida los campos de categoria del formulario
        private bool datosCorrectosCat()
        {
            int camposCorrectos = 0;
            if (this.textBoxNombreCat.Text.Length != 0) camposCorrectos++;
            if (this.rbVarCat.Checked || this.rbFemCat.Checked) camposCorrectos++;

            if (camposCorrectos == 2) return true;
            else return false;
        }

        private void limpiarCamposCat()
        {
            this.textBoxNombreCat.ResetText();
            rbVarCat.Checked = false;
            rbFemCat.Checked = false;
        }

        private void buttonEditarCat_Click(object sender, EventArgs e)
        {
            if (botonPresionadoCat == false)
            {

                botonPresionadoCat = true;


                this.groupBoxCategorias.Enabled = true;
                this.buttonAgregarCat.Enabled = false;
                comboBoxFiltRama.Enabled = false;
                this.buttonEliminarCat.Enabled = false;
                this.buttonCancelarCat.Enabled = true;
                this.dgCategorias.Enabled = false;
                this.textBoxBuscarCategoria.Enabled = false;
                this.buttonEditarCat.Text = "Guardar";
                this.textBoxNombreCat.Focus();


            }
            else if (botonPresionadoCat == true)
            {

                if (datosCorrectosCat())
                {
                    crearCategoria();
                    action.actualizarCategoria(c, obtenerIdCat());
                    reestablecerPredeterminadoCat();
                }
                else
                {
                    MessageBox.Show("Los datos no estan correctos, no se puede editar la categoría en la base de datos");
                }

            }
        }

        private int obtenerIdCat()
        {
            int id = Convert.ToInt32(dgCategorias.CurrentRow.Cells[0].Value.ToString().Trim());
            return id;
        }

        private void buttonEliminarCat_Click(object sender, EventArgs e)
        {
            String nombre = textBoxNombreCat.Text.Trim();

            if (MessageBox.Show("¿Está seguro que desea eliminar la categoría " + nombre + " de la base de datos?", "Eliminar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                action.eliminarCategoria(nombre, obtenerIdCat());
                reestablecerPredeterminadoCat();
            }
            else
            {
                reestablecerPredeterminadoCat();
            }
        }
    }
}
