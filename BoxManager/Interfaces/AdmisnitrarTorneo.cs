using BoxManager.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BoxManager.Interfaces
{
    public partial class AdmisnitrarTorneo : Form
    {

        //Variables
        private OperacionesLINQ action = new OperacionesLINQ();
        private DataGridViewCellStyle azul = new DataGridViewCellStyle();
        private DataGridViewCellStyle rojo = new DataGridViewCellStyle();
        private DataGridViewCellStyle violeta = new DataGridViewCellStyle();

        public AdmisnitrarTorneo()
        {
            InitializeComponent();
            cargarTorneos();
            comboBoxTorneos.SelectedIndex = -1;
            azul.BackColor  = Color.Blue;
            rojo.BackColor = Color.Red;
            violeta.BackColor = Color.BlueViolet;
        }

        private void AdmisnitrarTorneo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new Menu().Show();
        }

        //Carga el combobox con los torneos existentes
        private void cargarTorneos()
        {
            comboBoxTorneos = action.llenarTorneos(comboBoxTorneos);
        }

        private void comboBoxTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Actualiza la tabla para darle una mejor visual
        private void formatearCampos()
        {
            dgPeleas.Columns["Id_Torneo"].Visible = false;
            dgPeleas.Columns["Id_Pelea"].Visible = false;
            foreach (DataGridViewColumn column in dgPeleas.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewRow dr in dgPeleas.Rows)
            {

                dr.Cells[5].Style.BackColor = Color.White;

                dr.Cells[1].Style.BackColor = azul.BackColor;
                dr.Cells[1].Style.ForeColor = Color.White;

                dr.Cells[2].Style.BackColor = rojo.BackColor;
                dr.Cells[2].Style.ForeColor = Color.White;

                if (dr.Cells[1].Value.Equals("LIBRE"))
                {
                    dr.Cells[1].Style.BackColor = Color.BlueViolet;
                    dr.Cells[5].Style.BackColor = Color.BlueViolet;
                    dr.Cells[5].Style.ForeColor = Color.White;
                }
                else if (dr.Cells[2].Value.Equals("LIBRE"))
                {
                    dr.Cells[2].Style.BackColor = Color.BlueViolet;
                    dr.Cells[5].Style.BackColor = Color.BlueViolet;
                    dr.Cells[5].Style.ForeColor = Color.White;
                }
                else if (dr.Cells[5].Value != null)
                {
                    if (dr.Cells[5].Value.Equals(dr.Cells[1].Value))
                    {
                        dr.Cells[5].Style.BackColor = azul.BackColor;
                        dr.Cells[5].Style.ForeColor = Color.White;
                    }
                    else if (dr.Cells[5].Value.Equals(dr.Cells[2].Value))
                    {
                        dr.Cells[5].Style.BackColor = rojo.BackColor;
                        dr.Cells[5].Style.ForeColor = Color.White;
                    }
                }
            }
            etapaLista();
        }

        //Verifica si todas las peleas de la etapa actual han concluido
        private void etapaLista()
        {
            int peleasTotales = dgPeleas.RowCount;
            int peleasListas = 0;
            int torneoID = Convert.ToInt32(comboBoxTorneos.SelectedValue);
            int etapa = action.obtenerUltimaEtapa(torneoID);

            //Verifica cuantas peleas hay de esa etapa
            int cantEtapas = 0;
            foreach (DataGridViewRow dr in dgPeleas.Rows)
            {
                if (Convert.ToInt32(dr.Cells[4].Value).Equals(etapa))
                {
                    cantEtapas++;
                }

            }

            if (cantEtapas == 1)
            {
                buttonEtapa.Enabled = false;
                return;
            }
            else
            {

                foreach (DataGridViewRow dr in dgPeleas.Rows)
                {
                    if (dr.Cells[5].Value != null)
                    {
                        peleasListas++;
                    }
                }

                if (peleasListas == peleasTotales)
                {
                    buttonEtapa.Enabled = true;
                }
                else
                {
                    buttonEtapa.Enabled = false;
                }
            }
        }

        //Al entrar a una celda, se puede activar el boton de ganador o el de cancelar, así como cargar si información.
        private void dgPeleas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgPeleas.CurrentCell.ColumnIndex == 1 || dgPeleas.CurrentCell.ColumnIndex == 2) && dgPeleas.CurrentRow.Cells[5].Style.BackColor == Color.White)
            {
                buttonGanador.Enabled = true;
            }
            else if (dgPeleas.CurrentRow.Cells[5].Style.BackColor == Color.White && dgPeleas.CurrentRow.Cells[5].Value != null)
            {
                buttonCancelar.Enabled = true;
            } else
            {
                buttonGanador.Enabled = false;
                buttonCancelar.Enabled = false;
            }

            //Si es la celda de algún boxeador, carga su información.
            try
            {
                string[] dato = dgPeleas.CurrentCell.Value.ToString().Trim().Split('-');
                string boxeadorID = dato.First();
                if ((dgPeleas.CurrentCell.ColumnIndex == 1 || dgPeleas.CurrentCell.ColumnIndex == 2 || dgPeleas.CurrentCell.ColumnIndex == 5) && !boxeadorID.Equals("LIBRE"))
                {
                    List<string> datosBoxeadores = action.obtenerDatosBoxeador(boxeadorID);
                    labelNombre.Text = datosBoxeadores.First();
                    labelMunicipio.Text = datosBoxeadores.Last();
                }
                else
                {
                    labelNombre.Text = "";
                    labelMunicipio.Text = "";
                }
            }
            catch (Exception)
            {
                labelNombre.Text = "";
                labelMunicipio.Text = "";
            }

        }

        private void buttonGanador_Click(object sender, EventArgs e)
        {
            dgPeleas.CurrentRow.Cells[5].Value = dgPeleas.CurrentCell.Value;
            buttonGanador.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            dgPeleas.CurrentRow.Cells[5].Value = null;
            dgPeleas.CurrentRow.Cells[5].Style.BackColor = Color.White;
            buttonCancelar.Enabled = false;
        }

        private void comboBoxTorneos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void mostrarInfoTorneo()
        {
            int torneoID = Convert.ToInt32(comboBoxTorneos.SelectedValue.ToString());
            List<string> datosTorneo = action.obtenerDatosTorneo(torneoID);
            labelCategoria.Text = datosTorneo.First();
            labelParticipantes.Text = datosTorneo.Last();
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            int peleasActualizadas = 0;
            int etapa = Convert.ToInt32(dgPeleas[4, 0].Value);

            foreach (DataGridViewRow dr in dgPeleas.Rows)
            {
                int peleaID;
                string ganador;

                if (dr.Cells[5].Value != null && dr.Cells[5].Style.BackColor == Color.White)
                {
                    ganador = dr.Cells[5].Value.ToString().Trim();
                }
                else
                {
                    continue;
                }

                peleaID = Convert.ToInt32(dr.Cells[0].Value);
                action.actualizarPelea(peleaID, ganador);
                peleasActualizadas++;

            }
            if (peleasActualizadas > 0)
            {
                MessageBox.Show($"Peleas actualizadas: {peleasActualizadas}");
            }
            actualizarTabla();

        }

        private void buttonEliminarTorneo_Click(object sender, EventArgs e)
        {

            String nombre = comboBoxTorneos.Text.Trim();
            int torneoID = Convert.ToInt32(comboBoxTorneos.SelectedValue.ToString());


            if (MessageBox.Show("¿Está seguro que desea eliminar el torneo " + nombre + " de la base de datos?", "Eliminar Torneo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                action.eliminarTorneo(torneoID);
                this.Dispose();
                new Menu().Show();
            }
 
        }

        private void buttonEtapa_Click(object sender, EventArgs e)
        {
            int cantBoxeadores = 0;
            int etapa = Convert.ToInt32(dgPeleas[4, 0].Value);
            int idTorneo = Convert.ToInt32(comboBoxTorneos.SelectedValue);

            foreach (DataGridViewRow dr in dgPeleas.Rows)
            {
                if (Convert.ToInt32(dr.Cells[4].Value).Equals(etapa))
                {
                    cantBoxeadores++;
                }
            }

            //Se procede a crear los rounds de forma aleatoria
            List<String> participantes = new List<String>();

            foreach (DataGridViewRow dr in dgPeleas.Rows)
            {
                if (Convert.ToInt32(dr.Cells[4].Value).Equals(etapa))
                {
                    participantes.Add(dr.Cells[5].Value.ToString().Trim());
                }
            }

            if (cantBoxeadores % 2 != 0)
            {
                participantes.Add("LIBRE");
            }

            //Creación de la lista de peladores en orden aleatorio
            Random rnd = new Random();
            participantes = participantes.OrderBy(item => rnd.Next()).ToList();

            int aux = participantes.Count;
            etapa++;

            for (int i = 0; i < (aux / 2); i++)
            {
                string boxeador1 = participantes.Last();
                participantes.RemoveAt(participantes.Count - 1);

                string boxeador2 = participantes.Last();
                participantes.RemoveAt(participantes.Count - 1);

                Boolean resultPelea = action.crearPelea(idTorneo, boxeador1, boxeador2, etapa);

                if (!resultPelea)
                {
                    MessageBox.Show("Error al crear una de las peleas del torneo");
                    return;
                }

            }

            //Se muestra un progressBar sólo para hacer más notorio que las peleas son aleatorias
            if (aux > 2)
            {
                labelCreandoRandom.Visible = true;
                progressBarPeleas.Visible = true;
                timer1.Start();
            } else
            {
                actualizarTabla();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBarPeleas.PerformStep();

            if (progressBarPeleas.Value.Equals(100))
            {
                labelCreandoRandom.Visible = false;
                progressBarPeleas.Visible = false;
                timer1.Stop();
                progressBarPeleas.Value = 0;
                actualizarTabla();
            }
        }

        private void actualizarTabla()
        {
            int torneoID = Convert.ToInt32(comboBoxTorneos.SelectedValue.ToString());
            action.mostrarPeleas(dgPeleas, torneoID);
            formatearCampos();
            mostrarInfoTorneo();
        }

    }
}
