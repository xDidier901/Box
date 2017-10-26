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
    public partial class Torneos : Form
    {
        string[] peleador = new string[16];
        string[] shuffle;

        public Torneos()
        {
            InitializeComponent();
            bleh();
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //Recibir vector con nombres
        public void bleh()
        {
            string[] peleadores = { "Luis", "Jorge", "Roberto", "Didier", "Hector", "6", "7", "8", "9", "10", "11", "12", "13" };
            shuffle = RandomizeStrings(peleadores);
        }

        //Cambia de posición cada elemento de un array posicionando los mismos al azar
        static Random _random = new Random();
        static string[] RandomizeStrings(string[] arr)
        {
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
            // Add all strings from array.
            // ... Add new random int each time.
            foreach (string s in arr)
            {
                list.Add(new KeyValuePair<int, string>(_random.Next(), s));
            }
            // Sort the list by the random number.
            var sorted = from item in list
                         orderby item.Key
                         select item;
            // Allocate new string array.
            string[] result = new string[arr.Length];
            // Copy values to array.
            int index = 0;
            foreach (KeyValuePair<int, string> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array.
            return result;
        }

        //Cambiar los colores de la celda de cada peleador en la etapa inicial
        DataGridViewCellStyle style = new DataGridViewCellStyle();
        DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        public void cambiarColoresIniciales()
        {
            style.BackColor = Color.RoyalBlue;
            style2.BackColor = Color.Firebrick;
            style.ForeColor = Color.White;
            style2.ForeColor = Color.White;
            bool ban = false;
            for (int i = 1; i < (shuffle.Length * 2); i += 2)
            {
                if (ban == false)
                {
                    dataGridView.Rows[i].Cells[0].Style = style;
                    ban = true;
                }
                else
                {
                    dataGridView.Rows[i].Cells[0].Style = style2;
                    ban = false;
                }
            }
        }

        //Creación de tabla inicial. Se utiliza solo cuando se crea un torneo
        DataTable dt = new DataTable();
        public void llenarTabla()
        {
            int j = 0;
            for (int i = 1; i < (shuffle.Length * 2); i += 2)
            {
                dt.Rows.Add("", "", ""); //Separación entre peleadores      
                dt.Rows.Add(shuffle[j], "", "");
                j++;
            }
            if (shuffle.Length % 2 != 0)
            {
                dt.Rows.Add("", "", "");//Separación al final de la tabla
                dt.Rows.Add("", "", "");//Separación al final de la tabla
                dt.Rows.Add("", "", "");//Separación al final de la tabla
            }
            else
            {
                dt.Rows.Add("", "", "");//Separación al final de la tabla

            }

            dataGridView.DataSource = dt;
            cambiarColoresIniciales();
        }

        public void crearTabla(int x)
        {
            switch (x)
            {
                case 3:
                    dt.Columns.Add("Etapa inicial", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("", "", ""); //Division y categoria
                    dt.Rows.Add(shuffle[0], "", "");
                    dt.Rows.Add("", "", "");
                    dt.Rows.Add(shuffle[1], "", "");
                    dt.Rows.Add("", "", "");
                    dt.Rows.Add(shuffle[2], "", "");

                    style.BackColor = Color.RoyalBlue;
                    style2.BackColor = Color.Firebrick;

                    style.ForeColor = Color.White;
                    style2.ForeColor = Color.White;

                    dataGridView.DataSource = dt;
                    dataGridView.Rows[1].Cells[0].Style = style;
                    dataGridView.Rows[3].Cells[0].Style = style2;
                    dataGridView.Rows[5].Cells[0].Style = style;

                    break;
                case 4:
                    dt.Columns.Add("Ronda inicial", typeof(string));
                    dt.Columns.Add("Finales", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    style.BackColor = Color.RoyalBlue;
                    style2.BackColor = Color.Firebrick;
                    style.ForeColor = Color.White;
                    style2.ForeColor = Color.White;

                    dt.Rows.Add("", "", ""); //Division y categoria
                    dt.Rows.Add(shuffle[0], "", "");
                    dt.Rows.Add("", "", "");
                    dt.Rows.Add(shuffle[1], "", "");
                    dt.Rows.Add("", "", "");
                    dt.Rows.Add(shuffle[2], "", "");
                    dt.Rows.Add("", "", "");
                    dt.Rows.Add(shuffle[3], "", "");

                    dataGridView.DataSource = dt;
                    dataGridView.Rows[1].Cells[0].Style = style;//azul
                    dataGridView.Rows[3].Cells[0].Style = style2;//rojo
                    dataGridView.Rows[5].Cells[0].Style = style;//azul
                    dataGridView.Rows[7].Cells[0].Style = style2;//rojo
                    //llenarTabla();
                    break;
                case 5:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    style.BackColor = Color.RoyalBlue;
                    style2.BackColor = Color.Firebrick;
                    style.ForeColor = Color.White;
                    style2.ForeColor = Color.White;

                    dt.Rows.Add("", "", "", ""); //Division y categoria
                    dt.Rows.Add(shuffle[0], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[1], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[2], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[3], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[4], "", "", "");

                    dataGridView.DataSource = dt;
                    dataGridView.Rows[1].Cells[0].Style = style;
                    dataGridView.Rows[3].Cells[0].Style = style2;
                    dataGridView.Rows[5].Cells[0].Style = style;
                    dataGridView.Rows[7].Cells[0].Style = style2;
                    dataGridView.Rows[9].Cells[0].Style = style;
                    break;
                    //llenarTabla();
                    break;
                case 6:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("", "", "", ""); //Division y categoria
                    dt.Rows.Add(shuffle[0], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[1], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[2], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[3], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[4], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[5], "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 7:
                    dt.Columns.Add("Etapa inicial", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("", "", "", ""); //Division y categoria
                    dt.Rows.Add(shuffle[0], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[1], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[2], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[3], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[4], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[5], "", "", "");
                    dt.Rows.Add("", "", "", "");
                    dt.Rows.Add(shuffle[6], "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 8:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Cuartos de final", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("Division", "", "Categoria", "", ""); //Fila division ylm
                    dt.Rows.Add("", "", "", "", ""); //separador 
                    dt.Rows.Add(shuffle[0], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador1
                    dt.Rows.Add(shuffle[1], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador5
                    dt.Rows.Add(shuffle[2], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador2
                    dt.Rows.Add(shuffle[3], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Campeón         
                    dt.Rows.Add(shuffle[4], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador3
                    dt.Rows.Add(shuffle[5], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador 7           
                    dt.Rows.Add(shuffle[6], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//ganador4
                    dt.Rows.Add(shuffle[7], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 9:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Cuartos de final", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("Division", "", "Categoria", "", ""); //Fila division ylm
                    dt.Rows.Add("", "", "", "", ""); //separador 
                    dt.Rows.Add(shuffle[0], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador1
                    dt.Rows.Add(shuffle[1], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador5
                    dt.Rows.Add(shuffle[2], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador2
                    dt.Rows.Add(shuffle[3], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Campeón         
                    dt.Rows.Add(shuffle[4], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador3
                    dt.Rows.Add(shuffle[5], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador 7           
                    dt.Rows.Add(shuffle[6], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//ganador4
                    dt.Rows.Add(shuffle[7], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador
                    dt.Rows.Add(shuffle[8], "", "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 10:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Cuartos de final", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("Division", "", "Categoria", "", ""); //Fila division ylm
                    dt.Rows.Add("", "", "", "", ""); //separador 
                    dt.Rows.Add(shuffle[0], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador1
                    dt.Rows.Add(shuffle[1], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador5
                    dt.Rows.Add(shuffle[2], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador2
                    dt.Rows.Add(shuffle[3], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Campeón         
                    dt.Rows.Add(shuffle[4], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador3
                    dt.Rows.Add(shuffle[5], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador 7           
                    dt.Rows.Add(shuffle[6], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//ganador4
                    dt.Rows.Add(shuffle[7], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador
                    dt.Rows.Add(shuffle[8], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[9], "", "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 11:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Cuartos de final", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("Division", "", "Categoria", "", ""); //Fila division ylm
                    dt.Rows.Add("", "", "", "", ""); //separador 
                    dt.Rows.Add(shuffle[0], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador1
                    dt.Rows.Add(shuffle[1], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador5
                    dt.Rows.Add(shuffle[2], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador2
                    dt.Rows.Add(shuffle[3], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Campeón         
                    dt.Rows.Add(shuffle[4], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador3
                    dt.Rows.Add(shuffle[5], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador 7           
                    dt.Rows.Add(shuffle[6], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//ganador4
                    dt.Rows.Add(shuffle[7], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador
                    dt.Rows.Add(shuffle[8], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[9], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[10], "", "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 12:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Cuartos de final", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("Division", "", "Categoria", "", ""); //Fila division ylm
                    dt.Rows.Add("", "", "", "", ""); //separador 
                    dt.Rows.Add(shuffle[0], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador1
                    dt.Rows.Add(shuffle[1], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador5
                    dt.Rows.Add(shuffle[2], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador2
                    dt.Rows.Add(shuffle[3], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Campeón         
                    dt.Rows.Add(shuffle[4], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador3
                    dt.Rows.Add(shuffle[5], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador 7           
                    dt.Rows.Add(shuffle[6], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//ganador4
                    dt.Rows.Add(shuffle[7], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador
                    dt.Rows.Add(shuffle[8], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[9], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[10], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[11], "", "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 13:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Cuartos de final", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("Division", "", "Categoria", "", ""); //Fila division ylm
                    dt.Rows.Add("", "", "", "", ""); //separador 
                    dt.Rows.Add(shuffle[0], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador1
                    dt.Rows.Add(shuffle[1], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador5
                    dt.Rows.Add(shuffle[2], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador2
                    dt.Rows.Add(shuffle[3], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Campeón         
                    dt.Rows.Add(shuffle[4], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador3
                    dt.Rows.Add(shuffle[5], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador 7           
                    dt.Rows.Add(shuffle[6], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//ganador4
                    dt.Rows.Add(shuffle[7], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador
                    dt.Rows.Add(shuffle[8], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[9], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[10], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[11], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[12], "", "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 14:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Cuartos de final", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("Division", "", "Categoria", "", ""); //Fila division ylm
                    dt.Rows.Add("", "", "", "", ""); //separador 
                    dt.Rows.Add(shuffle[0], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador1
                    dt.Rows.Add(shuffle[1], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador5
                    dt.Rows.Add(shuffle[2], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador2
                    dt.Rows.Add(shuffle[3], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Campeón         
                    dt.Rows.Add(shuffle[4], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador3
                    dt.Rows.Add(shuffle[5], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador 7           
                    dt.Rows.Add(shuffle[6], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//ganador4
                    dt.Rows.Add(shuffle[7], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador
                    dt.Rows.Add(shuffle[8], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[9], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[10], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[11], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[12], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[13], "", "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 15:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Cuartos de final", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("Division", "", "Categoria", "", ""); //Fila division ylm
                    dt.Rows.Add("", "", "", "", ""); //separador 
                    dt.Rows.Add(shuffle[0], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador1
                    dt.Rows.Add(shuffle[1], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador5
                    dt.Rows.Add(shuffle[2], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador2
                    dt.Rows.Add(shuffle[3], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Campeón         
                    dt.Rows.Add(shuffle[4], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador3
                    dt.Rows.Add(shuffle[5], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador 7           
                    dt.Rows.Add(shuffle[6], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//ganador4
                    dt.Rows.Add(shuffle[7], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador
                    dt.Rows.Add(shuffle[8], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[9], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[10], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[11], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[12], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[13], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[14], "", "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
                case 16:
                    dt.Columns.Add("Rondas iniciales", typeof(string));
                    dt.Columns.Add("Cuartos de final", typeof(string));
                    dt.Columns.Add("Semifinal", typeof(string));
                    dt.Columns.Add("Final", typeof(string));
                    dt.Columns.Add("Campeón", typeof(string));

                    dt.Rows.Add("Division", "", "Categoria", "", ""); //Fila division ylm
                    dt.Rows.Add("", "", "", "", ""); //separador 
                    dt.Rows.Add(shuffle[0], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador1
                    dt.Rows.Add(shuffle[1], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador5
                    dt.Rows.Add(shuffle[2], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador2
                    dt.Rows.Add(shuffle[3], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Campeón         
                    dt.Rows.Add(shuffle[4], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador3
                    dt.Rows.Add(shuffle[5], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//Ganador 7           
                    dt.Rows.Add(shuffle[6], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador//ganador4
                    dt.Rows.Add(shuffle[7], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");//separador
                    dt.Rows.Add(shuffle[8], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[9], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[10], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[11], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[12], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[13], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[14], "", "", "", "");
                    dt.Rows.Add("", "", "", "", "");
                    dt.Rows.Add(shuffle[15], "", "", "", "");

                    dataGridView.DataSource = dt;
                    //llenarTabla();
                    break;
            }
            //dataGridView.DataSource = dt;
        }

        private void Torneos_Load(object sender, EventArgs e)
        {
            crearTabla(shuffle.Length);
        }

        private void btnGanador_Click(object sender, EventArgs e)
        {
            style.BackColor = Color.RoyalBlue;
            style.ForeColor = Color.White;
            style2.BackColor = Color.Firebrick;
            style2.ForeColor = Color.White;
            int fila = dataGridView.CurrentCell.RowIndex;
            int columna = dataGridView.CurrentCell.ColumnIndex;

            if (columna == 0 && dataGridView[columna, fila].Value != null)
            {
                if (fila == 1 || fila == 3)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[1, 2].Value.ToString() != null)
                    {
                        dataGridView[1, 2].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[1, 2].Style = style;

                    }
                    if (fila == 1)
                    {
                        dataGridView[0, 3].Style.BackColor = Color.Gray;
                    }
                    else
                    {
                        dataGridView[0, 1].Style.BackColor = Color.Gray;
                    }
                }
                else if (fila == 5 || fila == 7)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[1, 6].Value.ToString() != null)
                    {
                        dataGridView[1, 6].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[1, 6].Style = style2;
                    }
                }
                else if (fila == 9 || fila == 11)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[1, 10].Value.ToString() != null)
                    {
                        dataGridView[1, 10].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[1, 10].Style = style;
                    }
                }
                else if (fila == 13 || fila == 15)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[1, 14].Value.ToString() != null)
                    {
                        dataGridView[1, 14].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[1, 14].Style = style2;
                    }
                }
                else if (fila == 17 || fila == 19)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[1, 18].Value.ToString() != null)
                    {
                        dataGridView[1, 18].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[1, 18].Style = style;
                    }
                }
                else if (fila == 21 || fila == 23)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[1, 22].Value.ToString() != null)
                    {
                        dataGridView[1, 22].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[1, 22].Style = style2;
                    }
                }
                else if (fila == 25 || fila == 27)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[1, 26].Value.ToString() != null)
                    {
                        dataGridView[1, 26].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[1, 26].Style = style;
                    }
                }
                else if (fila == 29 || fila == 31)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[1, 30].Value.ToString() != null)
                    {
                        dataGridView[1, 30].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[1, 30].Style = style2;
                    }
                }
            }
            else if (columna == 1 && dataGridView[columna, fila].Value != null)
            {
                if (fila == 2 || fila == 6)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[2, 4].Value.ToString() != null)
                    {
                        dataGridView[2, 4].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[2, 4].Style = style;
                    }
                }
                else if (fila == 10 || fila == 14)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[2, 12].Value.ToString() != null)
                    {
                        dataGridView[2, 12].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[2, 12].Style = style2;
                    }
                }
                else if (fila == 18 || fila == 22)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[2, 20].Value.ToString() != null)
                    {
                        dataGridView[2, 20].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[2, 20].Style = style;
                    }
                }
                else if (fila == 26 || fila == 30)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[2, 28].Value.ToString() != null)
                    {
                        dataGridView[2, 28].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[2, 28].Style = style2;
                    }
                }
            }
            else if (columna == 2 && dataGridView[columna, fila].Value != null)
            {
                if (fila == 4 || fila == 12)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[3, 8].Value.ToString() != null)
                    {
                        dataGridView[3, 8].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[3, 8].Style = style;
                    }
                }
                else if (fila == 20 || fila == 28)
                {
                    if (MessageBox.Show("¿Ganador?", "Decidir ganador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && dataGridView[3, 24].Value.ToString() != null)
                    {
                        dataGridView[3, 24].Value = dataGridView[columna, fila].Value.ToString();
                        dataGridView[3, 24].Style = style2;
                    }
                }
            }
            else if ((columna == 3 && dataGridView[columna, fila].Value != null) && dataGridView[4, 16].Value.ToString() != null)
            {
                if (fila == 8 || fila == 24)
                {
                    dataGridView[4, 16].Value = dataGridView[columna, fila].Value.ToString();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int fila = dataGridView.CurrentCell.RowIndex;
            int columna = dataGridView.CurrentCell.ColumnIndex;

            if (columna == 0)
            {
                MessageBox.Show("No se pueden cancelar peleadores de la primera ronda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dataGridView[columna, fila].Value.ToString() != "")
            {
                DataGridViewCellStyle estiloDefecto = new DataGridViewCellStyle();
                estiloDefecto.BackColor = Color.White;
                if (MessageBox.Show("¿Cancelar peleador ganador?", "¿Cancelar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView[columna, fila].Style = estiloDefecto;
                    dataGridView[columna, fila].Value = "";
                }
            }
        }
    }
}
