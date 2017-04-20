using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoxManager.Interfaces;
using BoxManager.Interfaces;

namespace BoxManager
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonBoxeadores_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Boxeadores().Show();
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
    }
}
