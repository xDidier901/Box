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
    public partial class Boxeadores : Form
    {

        //Variables
        private OperacionesLINQ action = new OperacionesLINQ();
        private Boxeadore b;
        private Boolean botonPresionado = false;
        private int categoria;
 
        //Constructor
        public Boxeadores()
        {
            InitializeComponent();
            this.dtpFechaN.MaxDate = DateTime.Today;
        }

        //Marca cheked al radiobutton sobre la rama de acuerdo al datagrid
        private void establecerRama()
        {
            String rama = dgBoxeadores.CurrentRow.Cells[2].Value.ToString().Trim();

            if (rama.Equals("Varonil"))
            {
                this.rbVaronil.Checked = true;
                this.rbFemenil.Checked = false;
            }
            else if (rama.Equals("Femenil"))
            {
                this.rbFemenil.Checked = true;
                this.rbVaronil.Checked = false;
            }

        }

        //Calcula la edad de acuerdo a la introducida en el dateTimePicker
        private void establecerEdad()
        {
            DateTime hoy = DateTime.Today;  //Fecha actual

            DateTime fechaNacimiento = dtpFechaN.Value;   //Fecha de nacimiento

            int age = hoy.Year - fechaNacimiento.Year;

            if (hoy.Month < fechaNacimiento.Month || (hoy.Month == fechaNacimiento.Month && hoy.Day < fechaNacimiento.Day))
                age--;

            textBoxEdad.Text = age.ToString();

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
            else return "Undefined";
        }

        //Valida los campos del formulario
        private bool datosCorrectos()
        {
            int camposCorrectos = 0;
            if (this.textBoxNombre.Text.Length != 0) camposCorrectos++;
            if (this.rbVaronil.Checked || this.rbFemenil.Checked) camposCorrectos++;
            if ((this.dtpFechaN.Value >= dtpFechaN.MinDate) && (this.dtpFechaN.Value <= dtpFechaN.MaxDate)) camposCorrectos++;
            if (this.comboBoxCategorias.SelectedIndex != -1) camposCorrectos++;
            if (this.comboBoxDivisiones.SelectedIndex != -1) camposCorrectos++;
            if (this.comboBoxMunicipios.SelectedIndex != -1) camposCorrectos++;

            if (camposCorrectos == 6) return true;
            else return false;

        }

        //Crea un objeto boxeador con la informacion de los campos
        private void crearBoxeador()
        {
            b = new Boxeadore();

            b.Nombre = textBoxNombre.Text.Trim();
            b.Rama = obtenerRama();
            b.FechaNacimiento = dtpFechaN.Value;
            b.Categoria = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString());
            b.Division = Convert.ToInt32(comboBoxDivisiones.SelectedValue.ToString());
            b.Municipio = Convert.ToInt32(comboBoxMunicipios.SelectedValue.ToString());
        }

        //Restablece los valores predeterminados del formulario
        private void reestablecerPredeterminado()
        {
            b = null;
            botonPresionado = false;
            categoria = -1;

            this.dgBoxeadores.Enabled = true;
            action.mostrarBoxeadores(dgBoxeadores);
            this.textBoxBuscar.Enabled = true;
            this.textBoxBuscar.Focus();
            this.llenarCampos();
            this.groupBoxDatos.Enabled = false;
            this.buttonAgregar.Enabled = true;
            this.buttonAgregar.Text = "Agregar";
            this.buttonEditar.Enabled = true;
            this.buttonEditar.Text = "Editar";
            this.buttonCancelar.Enabled = false;
            this.buttonEliminar.Enabled = true;
        }

        //Obtiene el ID del boxeador seleccionado en el datagrid
        private int obtenerIdBoxeador()
        {
            int id = Convert.ToInt32(dgBoxeadores.CurrentRow.Cells[0].Value.ToString().Trim());
            return id;
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

        private void Boxeadores_Load(object sender, EventArgs e)
        {
            action.mostrarBoxeadores(dgBoxeadores); //Muestra boxeadores en datagrid
            comboBoxMunicipios = action.llenarMunicipios(comboBoxMunicipios);
        }

        private void dgBoxeadores_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            llenarCampos();
        }

        private void llenarCampos()
        {
            this.textBoxNombre.Text = dgBoxeadores.CurrentRow.Cells[1].Value.ToString().Trim();
            dtpFechaN.Value = Convert.ToDateTime(dgBoxeadores.CurrentRow.Cells[3].Value.ToString().Trim());
            establecerRama();
            this.comboBoxMunicipios.Text = dgBoxeadores.CurrentRow.Cells[6].Value.ToString().Trim();
            this.comboBoxDivisiones.Text = dgBoxeadores.CurrentRow.Cells[5].Value.ToString().Trim();
            this.comboBoxCategorias.Text = dgBoxeadores.CurrentRow.Cells[4].Value.ToString().Trim();     
    }

        private void dtpFechaN_ValueChanged(object sender, EventArgs e)
        {
            establecerEdad();
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
                //Console.WriteLine(comboBoxCategorias.SelectedValue.ToString());
                categoria = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString());
                comboBoxDivisiones = action.llenarDivisiones(comboBoxDivisiones, categoria);
            }

        }

        private void limpiarCampos()
        {
            this.textBoxNombre.ResetText();
            this.rbVaronil.Checked = false;
            this.rbFemenil.Checked = false;
            this.dtpFechaN.Value = dtpFechaN.MinDate;
            comboBoxCategorias.DataSource = null; 
            comboBoxDivisiones.DataSource = null;
            comboBoxCategorias.SelectedIndex = -1;
            comboBoxDivisiones.SelectedIndex = -1;
            comboBoxMunicipios.SelectedIndex = -1;
            this.textBoxEdad.ResetText();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            if (botonPresionado == false)
            {

                botonPresionado = true;
                limpiarCampos();

                this.groupBoxDatos.Enabled = true;
                this.buttonEditar.Enabled = false;
                this.buttonEliminar.Enabled = false;
                this.buttonCancelar.Enabled = true;
                this.dgBoxeadores.Enabled = false;
                this.textBoxBuscar.Enabled = false;
                this.buttonAgregar.Text = "Guardar";
                this.textBoxNombre.Focus();

            }
            else if (botonPresionado == true)
            {
                if (datosCorrectos())
                {
                    crearBoxeador();
                    action.agregarBoxeador(b);
                    reestablecerPredeterminado();
                }
                else
                {
                    MessageBox.Show("Los datos no estan correctos, no se puede agregar el boxeador a la base de datos");
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            reestablecerPredeterminado();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            action.buscarBoxeador(dgBoxeadores, textBoxBuscar.Text.Trim());
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (botonPresionado == false)
            {

                botonPresionado = true;


                this.groupBoxDatos.Enabled = true;
                this.buttonAgregar.Enabled = false;
                this.buttonEliminar.Enabled = false;
                this.buttonCancelar.Enabled = true;
                this.dgBoxeadores.Enabled = false;
                this.textBoxBuscar.Enabled = false;
                this.buttonEditar.Text = "Guardar";
                this.textBoxNombre.Focus();


            }
            else if (botonPresionado == true)
            {

                if (datosCorrectos())
                {
                   crearBoxeador();
                   action.actualizarBoxeador(b, obtenerIdBoxeador());
                   reestablecerPredeterminado();
                }
                else
                {
                    MessageBox.Show("Los datos no estan correctos, no se puede editar al boxeador en la base de datos");
                }

            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            String nombre = textBoxNombre.Text.Trim();

            if (MessageBox.Show("¿Está seguro que desea eliminar a " + nombre + " de la base de datos?", "Eliminar Boxeador", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                action.eliminarBoxeador(nombre, obtenerIdBoxeador());
                reestablecerPredeterminado();
            }
            else
            {
                reestablecerPredeterminado();
            }
        }
    }
}
