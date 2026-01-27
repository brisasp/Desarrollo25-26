using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //creamos la conexion
        SqlConnection conexion = new SqlConnection();
        
        //creamos el adaptador
        SqlDataAdapter adaptador = new SqlDataAdapter();

        //creamos el comando
        SqlCommand consulta = new SqlCommand();

        //Creamos el DataSet
        DataSet ClientesDataSet = new DataSet();

    /// <summary>
    /// Carga los datos de customers de la bbdd northwind y los muestra en el datagridview clientes
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    
        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Limpiamos el dataset
            ClientesDataSet.Clear();

            //creamos la conexion
            conexion.ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False";

            consulta = new SqlCommand("select * from customers" , conexion);
            adaptador.SelectCommand = consulta;

            //hacemos que se carguen los datos en el DataSet
            adaptador.Fill(ClientesDataSet, "Customers");

            //asignamos el dataset al datagridview
            dgvClientes.DataSource = ClientesDataSet;
            dgvClientes.DataMember = "Customers";

            //cerramos la conexion
            conexion.Close();

            btnCancelarTodo.Enabled = false;
        }

        private void btnCancelarTodo_Click(object sender, EventArgs e)
        {
            //el metodo este lo hace solo
            ClientesDataSet.RejectChanges();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //construimos el adaptador con las sentencias Insert y Update
            SqlCommandBuilder constructor = new SqlCommandBuilder(adaptador);
            //Actualizamos la bbdd por medio del dateAdapter
            adaptador.Update(ClientesDataSet, "Customers");
            ClientesDataSet.Tables["Customers"].AcceptChanges();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCancelarTodo.Enabled=true;
        }
    }
}
