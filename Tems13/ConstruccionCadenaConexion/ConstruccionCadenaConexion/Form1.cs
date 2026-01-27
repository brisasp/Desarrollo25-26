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

namespace ConstruccionCadenaConexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Construimos la cadena de conexion
            SqlConnectionStringBuilder cadenaConexion = new SqlConnectionStringBuilder
            {
                DataSource = "localhost\\SQLEXPRESS",
                InitialCatalog = "Northwind",
                IntegratedSecurity = true
            };
            //mostramos la cadena de conexion que hemos construido
            MessageBox.Show(cadenaConexion.ConnectionString);

            //creamos la conexion
            SqlConnection conexion = new SqlConnection(cadenaConexion.ToString());

            //abrimos la conexion, si es posible
            try
            {
                conexion.Open();
                if (conexion.State == ConnectionState.Open)
                    MessageBox.Show("Conexion abierta correctamente");
            }
            catch {
                MessageBox.Show("Ha habido un problema en la conexion");
            
            }
        }

        
}
