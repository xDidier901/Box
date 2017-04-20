using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxManager.Classes
{
    class OperacionesLINQ
    {


        BoxDBDataContext Database = new BoxDBDataContext();

        //agregar boxeador a la base de datos
        public void agregarBoxeador(Boxeadore x)
        {
            Database.Boxeadores.InsertOnSubmit(x);

            try
            {
                Database.SubmitChanges();
                registrarAccion("Se agregó al boxeador " + x.Nombre + " en la base de datos");
                MessageBox.Show("Boxeador " + x.Nombre + " agregado correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentar agregar al boxeador");
            }
        }

        //Actualiza la informacion de un boxeador
        public void actualizarBoxeador(Boxeadore x, int id)
        {
            var resultado = from valor in Database.Boxeadores
                            where valor.Id_Boxeador == id
                            select valor;

            foreach (var valor in resultado)
            {
                valor.Nombre = x.Nombre;
                valor.Rama = x.Rama;
                valor.FechaNacimiento = x.FechaNacimiento;
                valor.Categoria = x.Categoria;
                valor.Division = x.Division;
                valor.Municipio = x.Municipio;
            }

            try
            {
                Database.SubmitChanges();
                registrarAccion("Se modificó al boxeador " + x.Nombre + " en la base de datos");
                MessageBox.Show("Boxeador " + x.Nombre + " actualizado correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al actualizar el boxeador");
            }

        }

        //Borra un boxeador de la base de datos
        public void eliminarBoxeador(String nombre, int id)
        {
            var query =
            from valor in Database.Boxeadores
            where valor.Id_Boxeador == id
            select valor;

            foreach (var detail in query)
            {
                Database.Boxeadores.DeleteOnSubmit(detail);
            }

            try
            {
                Database.SubmitChanges();
                registrarAccion("Se eliminó al boxeador " + nombre + " de la base de datos");
                MessageBox.Show("Se eliminó al boxeador " + nombre + " correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error al tratar de eliminar el boxeador", e.ToString());
            }
        }

        //Mostrar boxeadores en datagrid
        public void mostrarBoxeadores(DataGridView x)
        {

            var query = from valor in Database.Boxeadores
                        from valor2 in Database.Categorias
                        from valor3 in Database.Divisiones
                        from valor4 in Database.Municipios
                        where valor2.Id_Categoria == valor.Categoria &&
                         valor3.Id_Division == valor.Division &&
                         valor4.Id_Municipio == valor.Municipio

                        select new
                        {
                            ID = valor.Id_Boxeador,
                            Nombre = valor.Nombre,
                            Rama = valor.Rama,
                            Fecha_de_Nacimiento = valor.FechaNacimiento,
                            Categoria = valor2.Nombre,
                            Division = valor3.Nombre,
                            Municipio = valor4.Nombre
                        };

            x.DataSource = query;
        }

        //Buscar boxeador
        public void buscarBoxeador(DataGridView x, string nombre)
        {

            var query = from valor in Database.Boxeadores
                        from valor2 in Database.Categorias
                        from valor3 in Database.Divisiones
                        from valor4 in Database.Municipios
                        where valor.Nombre.Contains(nombre) &&
                         valor2.Id_Categoria == valor.Categoria &&
                         valor3.Id_Division == valor.Division &&
                         valor4.Id_Municipio == valor.Municipio

                        select new
                        {
                            ID = valor.Id_Boxeador,
                            Nombre = valor.Nombre,
                            Rama = valor.Rama,
                            Fecha_de_Nacimiento = valor.FechaNacimiento,
                            Categoria = valor2.Nombre,
                            Division = valor3.Nombre,
                            Municipio = valor4.Nombre
                        };

            x.DataSource = query;
        }

        //Llena un combobox con las categorias con cierta rama
        public ComboBox llenarCategorias(ComboBox combo, string rama)
        {
            var query = from valor in Database.Categorias
                        where valor.Rama.Equals(rama)
                        select new { Name = valor.Nombre.Trim(), ID = valor.Id_Categoria.ToString().Trim() };
            
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID";
            combo.DataSource = query.ToList();
           
            
            return combo;
        }

        //Llena un combobox con las divisiones con cierta categoria
        public ComboBox llenarDivisiones(ComboBox combo, int id)
        {
            //combo.Items.Clear();
            var query = from valor in Database.Divisiones
                        where valor.Categoria == id
                        select new { Name = valor.Nombre.Trim(), ID = valor.Id_Division.ToString().Trim() };
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID";
            combo.DataSource = query.ToList();
            
            return combo;
        }

        //Llena un combobox con los municipios
        public ComboBox llenarMunicipios(ComboBox combo)
        {
            //combo.Items.Clear();
            var query = from valor in Database.Municipios
                        select new { Name = valor.Nombre, ID = valor.Id_Municipio.ToString().Trim() };
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID";
            combo.DataSource = query.ToList();
            
            return combo;
        }

        //Agrega una accion en la base de datos
        public void registrarAccion(String accion)
        {
            Accione a = new Accione();
            a.Fecha = DateTime.Today;
            a.Descripcion = accion;
            Database.Acciones.InsertOnSubmit(a);
            try
            {
                Database.SubmitChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al registrar la accion");
            }

        }

        //Muestra todas las acciones de la base de datos
        public void mostrarAcciones(DataGridView x)
        {

            var query = from valor in Database.Acciones
                        select new { Descripción = valor.Descripcion, Fecha = valor.Fecha };

            x.DataSource = query;
        }

        //Busca acciones en la base de datos
        public void buscarAcciones(DataGridView x, string descp)
        {

            var query = from valor in Database.Acciones
                        where valor.Descripcion.Contains(descp)
                        select new { Descripción = valor.Descripcion, Fecha = valor.Fecha };

            x.DataSource = query;
        }

        //Busca acciones en la base de datos por rango de fechas
        public void buscarAccionesFechas(DataGridView x, DateTime[] fechas)
        {
            Console.WriteLine("Fecha 1: " + fechas[0] + "\n Fecha 2: " + fechas[1]);

            var query = from valor in Database.Acciones
                        where (valor.Fecha.Date >= fechas[0].Date) //&& (valor.Fecha.Date <= fechas[1].Date)
                        select new { Descripción = valor.Descripcion, Fecha = valor.Fecha.Date };

            x.DataSource = query;
        }


    }
}
