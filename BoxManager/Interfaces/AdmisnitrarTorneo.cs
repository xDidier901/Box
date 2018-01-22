using BoxManager.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BoxManager.Interfaces
{
    public partial class AdmisnitrarTorneo : Form
    {

        //Variables
        private OperacionesLINQ action = new OperacionesLINQ();


        public AdmisnitrarTorneo()
        {
            InitializeComponent();
            cargarTorneos();
            comboBoxTorneos.SelectedIndex = -1;
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

        private void cargarTorneos()
        {
            comboBoxTorneos = action.llenarTorneos(comboBoxTorneos);
        }

        private void comboBoxTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formatearCampos()
        {

            foreach (DataGridViewColumn column in dgPeleas.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewRow dr in dgPeleas.Rows)
            {
                dr.Cells[1].Style.BackColor = Color.Blue;
                dr.Cells[1].Style.ForeColor = Color.White;
                dr.Cells[2].Style.BackColor = Color.Red;
                dr.Cells[2].Style.ForeColor = Color.White;

                if (dr.Cells[1].Value.Equals("LIBRE"))
                {
                    dr.Cells[1].Style.BackColor = Color.BlueViolet;
                }
                else if (dr.Cells[2].Value.Equals("LIBRE"))
                {
                    dr.Cells[2].Style.BackColor = Color.BlueViolet;
                }
            }
        }

        private void dgPeleas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgPeleas.CurrentCell.ColumnIndex == 1 || dgPeleas.CurrentCell.ColumnIndex == 2) && dgPeleas.CurrentRow.Cells[5].Value == null)
            {
                buttonGanador.Enabled = true;
            }
            else if (dgPeleas.CurrentRow.Cells[5].Value != null)
            {
                buttonCancelar.Enabled = true;
            } else
            {
                buttonGanador.Enabled = false;
                buttonCancelar.Enabled = false;
            }
        }

        private void buttonGanador_Click(object sender, EventArgs e)
        {
            dgPeleas.CurrentRow.Cells[5].Value = dgPeleas.CurrentCell.Value;
            dgPeleas.CurrentRow.Cells[5].Style.BackColor = Color.Green;
            dgPeleas.CurrentRow.Cells[5].Style.ForeColor = Color.White;
            buttonGanador.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            dgPeleas.CurrentRow.Cells[5].Value = null;
            buttonCancelar.Enabled = false;
        }

        private void comboBoxTorneos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int torneoID = Convert.ToInt32(comboBoxTorneos.SelectedValue.ToString());
            action.mostrarPeleas(dgPeleas, torneoID);
            formatearCampos();
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow dr in dgPeleas.Rows)
            {
                int peleaID, ganador;

                peleaID = Convert.ToInt32(dr.Cells[0].Value);
                ganador = Convert.ToInt32(dr.Cells[5].Value);

                if (ganador != 0)
                {
                    action.actualizarPelea(peleaID, ganador);
                }
            }

        }

        private void buttonEliminarTorneo_Click(object sender, EventArgs e)
        {
            int torneoID = Convert.ToInt32(comboBoxTorneos.SelectedValue.ToString());
            action.eliminarTorneo(torneoID);
            this.Dispose();
            new Menu().Show();
        }
    }
}
