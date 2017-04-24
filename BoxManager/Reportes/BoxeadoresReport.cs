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
        private OperacionesLINQ action = new OperacionesLINQ();
        private int categoria;


        public BoxeadoresReport()
        {
            InitializeComponent();
            // comboBoxMunicipios = action.llenarMunicipios(comboBoxMunicipios);
        }

        private Boolean validarFormulario()
        {
            //Listo para Reporte por rama
            if ((rbVaronil.Checked || rbFemenil.Checked)
                && comboBoxCategorias.SelectedIndex == -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex == -1)
            {
                return true;
            }
            else

            //Listo para Reporte por rama y municipio
            if ((rbVaronil.Checked || rbFemenil.Checked)
                && comboBoxCategorias.SelectedIndex == -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex != -1)
            {
                return true;
            }

            //Listo para Reporte categoria
            if (comboBoxCategorias.SelectedIndex != -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex == -1)
            {
                return true;
            }
            else


            //Listo para Reporte categoria y division
            if (comboBoxCategorias.SelectedIndex != -1
                && comboBoxDivisiones.SelectedIndex != -1
                && comboBoxMunicipios.SelectedIndex == -1)
            {
                return true;
            }
            else

            //Listo para Reporte categoria,division y municipio
            if (comboBoxCategorias.SelectedIndex != -1
                && comboBoxDivisiones.SelectedIndex != -1
                && comboBoxMunicipios.SelectedIndex != -1)
            {
                return true;
            }
            else

            //Listo para Reporte categoria y municipio
            if (comboBoxCategorias.SelectedIndex != -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex != -1)
            {
                return true;
            }
            else

            //Listo para Reporte municipio
            if ((rbVaronil.Checked == false && rbFemenil.Checked == false)
                && comboBoxCategorias.SelectedIndex == -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex != -1)
            {
                return true;
            }
            else return false;
        }


        public void escogerReporte()
        {
            //Reporte por rama
            if ((rbVaronil.Checked || rbFemenil.Checked)
                && comboBoxCategorias.SelectedIndex == -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex == -1)
            {
                reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource =
                Database.reporteBoxeadoresPorRama(obtenerRama());
                reportBoxeadores.RefreshReport();
            } else

            //Reporte por rama y municipio
            if ((rbVaronil.Checked || rbFemenil.Checked)
                && comboBoxCategorias.SelectedIndex == -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex != -1)
            {
                int municipioId = Convert.ToInt32(comboBoxMunicipios.SelectedValue.ToString().Trim());
                reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource =
                Database.reporteBoxeadoresPorRamaMunicipio(obtenerRama(),municipioId);
                reportBoxeadores.RefreshReport();
            }

            //Reporte categoria
            if (comboBoxCategorias.SelectedIndex != -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex == -1)
            {
                int categoriaId = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString().Trim());
                reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource =
                 Database.reporteBoxeadoresPorCategoria(categoriaId);
                reportBoxeadores.RefreshReport();
            } else


            //Reporte categoria y division
            if (comboBoxCategorias.SelectedIndex != -1
                && comboBoxDivisiones.SelectedIndex != -1
                && comboBoxMunicipios.SelectedIndex == -1)
            {
                int categoriaId = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString().Trim());
                int divisionId = Convert.ToInt32(comboBoxDivisiones.SelectedValue.ToString().Trim());
                reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource =
                 Database.reporteBoxeadoresPorCategoriaDivision(categoriaId, divisionId);
                reportBoxeadores.RefreshReport();
            } else 

            //Reporte categoria,division y municipio
            if (comboBoxCategorias.SelectedIndex != -1
                && comboBoxDivisiones.SelectedIndex != -1
                && comboBoxMunicipios.SelectedIndex != -1)
            {
                int categoriaId = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString().Trim());
                int divisionId = Convert.ToInt32(comboBoxDivisiones.SelectedValue.ToString().Trim());
                int municipioId = Convert.ToInt32(comboBoxMunicipios.SelectedValue.ToString().Trim());
                reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource =
                 Database.reporteBoxeadoresPorCategoriaDivisionMunicipio(categoriaId, divisionId,municipioId);
                reportBoxeadores.RefreshReport();
            } else

            //Reporte categoria y municipio
            if (comboBoxCategorias.SelectedIndex != -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex != -1)
            {
                int categoriaId = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString().Trim());
                int municipioId = Convert.ToInt32(comboBoxMunicipios.SelectedValue.ToString().Trim());
                reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource =
                 Database.reporteBoxeadoresPorCategoriaMunicipio(categoriaId,municipioId);
                reportBoxeadores.RefreshReport();
            } else

            //Reporte municipio
            if ((rbVaronil.Checked==false && rbFemenil.Checked==false)
                && comboBoxCategorias.SelectedIndex == -1
                && comboBoxDivisiones.SelectedIndex == -1
                && comboBoxMunicipios.SelectedIndex != -1)
            {
                int municipioId = Convert.ToInt32(comboBoxMunicipios.SelectedValue.ToString().Trim());
                reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource =
                 Database.reporteBoxeadoresPorMunicipio(municipioId);
                reportBoxeadores.RefreshReport();
            }
        }


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

        private void ReporteBoxeadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReporteBoxeadores.reporteBoxeadoresPorCategoriaDivisionMunicipio' table. You can move, or remove it, as needed.
            reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource = Database.reporteBoxeadores();

            this.reportBoxeadores.RefreshReport();
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

        private void buttonReestablecer_Click(object sender, EventArgs e)
        {
            reestablecerPredeterminado();
        }

        private void reestablecerPredeterminado()
        {
            buttonGenerarR.Enabled = false;
            rbVaronil.Checked = false;
            rbFemenil.Checked = false;
            comboBoxCategorias.SelectedIndex = -1;
            comboBoxCategorias.Text = "";
            comboBoxDivisiones.SelectedIndex = -1;
            comboBoxDivisiones.Text = "";
            comboBoxDivisiones.Enabled = false;
            comboBoxMunicipios.SelectedIndex = -1;
            comboBoxMunicipios.Text = "";
            reporteBoxeadoresPorCategoriaDivisionMunicipioBindingSource.DataSource = Database.reporteBoxeadores();
            reportBoxeadores.RefreshReport();
        }

        private void rbVaronil_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCategorias = action.llenarCategoriasByRama(comboBoxCategorias, obtenerRama());
            comboBoxCategorias.SelectedIndex = -1;
            if (validarFormulario()) buttonGenerarR.Enabled = true;
        }

        private void rbFemenil_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxCategorias = action.llenarCategoriasByRama(comboBoxCategorias, obtenerRama());
            comboBoxCategorias.SelectedIndex = -1;
            if (validarFormulario()) buttonGenerarR.Enabled = true;
        }

        private void comboBoxDivisiones_Click(object sender, EventArgs e)
        {
            if (comboBoxCategorias.SelectedValue != null)
            {
                categoria = Convert.ToInt32(comboBoxCategorias.SelectedValue.ToString());
                comboBoxDivisiones = action.llenarDivisiones(comboBoxDivisiones, categoria);
                if (validarFormulario()) buttonGenerarR.Enabled = true;
            }
        }

        private void comboBoxMunicipios_Click(object sender, EventArgs e)
        {
            comboBoxMunicipios = action.llenarMunicipios(comboBoxMunicipios);
            if (validarFormulario()) buttonGenerarR.Enabled = true;
        }

        private void comboBoxCategorias_Click(object sender, EventArgs e)
        {
            if (comboBoxCategorias.SelectedValue != null)
            {
                comboBoxDivisiones.Enabled = true;
                if (validarFormulario()) buttonGenerarR.Enabled = true;
            }
        }

        private void buttonGenerarR_Click(object sender, EventArgs e)
        {
            escogerReporte();
        }
    }
}
