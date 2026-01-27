using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ComandoInsercion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //creamos la conexion
            string cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False";

            //creamos el objeto conexion
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //abrimos la conexion
            conexion.Open();

            //Definimos el comando para insertar una fila en la bbdd
            string sql = "Insert into Employees (LastName,FirstName) values ('Cervantes', 'Miguel')";

            //creamos el comando de ejecucion.
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = sql;

            try
            {
                //Ejecuto la consulta y obtenemos el numero de regustros afectados
                int registros = comando.ExecuteNonQuery();
                MessageBox.Show("Registros afectados: " + registros);

            }
            catch
            {
                //Procesamos el error

            }
            finally
            {
                //cerramos la conexion
                conexion.Close();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //creamos la conexion
            string cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False";

            //creamos el objeto conexion
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //abrimos la conexion
            conexion.Open();

            //Definimos el comando para insertar una fila en la bbdd
            string sql = "Delete from Employees where EmployeeID=10";

            //creamos el comando de ejecucion.
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = sql;

            try
            {
                //Ejecuto la consulta y obtenemos el numero de regustros afectados
                int registros = comando.ExecuteNonQuery();
                MessageBox.Show("Registros afectados: " + registros);

            }
            catch
            {
                //Procesamos el error

            }
            finally
            {
                //cerramos la conexion
                conexion.Close();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //creamos la conexion
            string cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False";

            //creamos el objeto conexion
            SqlConnection conexion = new SqlConnection(cadenaConexion);

            //abrimos la conexion
            conexion.Open();

            //Definimos el comando para insertar una fila en la bbdd
            string sql = "Update Employees set FirstName = 'Federico' where EmployeeID=11";

            //creamos el comando de ejecucion.
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = sql;

            try
            {
                //Ejecuto la consulta y obtenemos el numero de regustros afectados
                int registros = comando.ExecuteNonQuery();
                MessageBox.Show("Actualizacion realizada correctamente ", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                //Procesamos el error
                MessageBox.Show("Se ha producido un error en la actualizacion ", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                //cerramos la conexion
                conexion.Close();
            }

        }

    }
}
