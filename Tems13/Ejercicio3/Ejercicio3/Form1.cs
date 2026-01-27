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

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.northwindDataSet.Employees);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            employeesBindingSource.EndEdit();
            employeesTableAdapter.Update(northwindDataSet);
            employeesTableAdapter.Fill(northwindDataSet.Employees);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Eliminamos el registro actual
            employeesBindingSource.RemoveCurrent();
            //actualizamos el dataset con el tableadapter
            employeesTableAdapter.Update(northwindDataSet);
            //actualizamos el datagridview
            employeesTableAdapter.Fill(northwindDataSet.Employees);
        }

        private void btnLastName_Click(object sender, EventArgs e)
        {
            SqlCommand consulta = new SqlCommand();
            consulta.CommandText = "select * from Employees where LastName like '%' + @Apellido + '%'";
            consulta.Connection = employeesTableAdapter.Connection;
            consulta.Parameters.AddWithValue("@Apellido", txtBuscar.Text);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataSet ds= new DataSet();
            da.Fill(ds, "Empleados");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Empleados";

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            DataRow fila = northwindDataSet.Tables["Employees"].NewRow();
            fila["Lastname"]=txtLastName.Text;
            fila["Firstname"] = txtFirstName.Text;
            northwindDataSet.Tables["Employees"].Rows.Add(fila);

            //Actualizamos el data adapter con el dataset
            employeesTableAdapter.Update(northwindDataSet);
            //actualizamos el datagridview para mostrarlo

            employeesTableAdapter.Fill(northwindDataSet.Employees);
        }
    }   
}
