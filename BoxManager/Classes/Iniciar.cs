using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxManager
{
    static class Iniciar
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            try
            {
                Application.Run(new Menu());
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al ejecutar el sistema: " + e.ToString());
            }

        }
    }
}
