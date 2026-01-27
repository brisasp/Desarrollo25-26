using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategoriaConCodigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //cadena de conexion
        string cadenaConexion = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False";

        //creamos el objeto conexion
        SqlConnection conexion = new SqlConnection();

        //creamos el objeto comando
        SqlCommand comando = new SqlCommand();

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion = new SqlConnection(cadenaConexion);

            //Asignamos al comando la consulta a realizar
            comando.CommandText = "Select * from Categories";

            comando.Connection = conexion;


            conexion.Open();
            //Creamos un objeto DataReader para almacenar el resultado de la consulta
            // Ejecutamos la consulta con ExecuteReader
            SqlDataReader resultado =comando.ExecuteReader();

            //Hacemos un bucle en el DataReader para mostrar los datos en el listBox
            while (resultado.Read())
            {
                listBox1.Items.Add(resultado["CategoryName"].ToString() + "---" + resultado["Description"].ToString());


            }
            conexion.Close();
        }
    }
}
