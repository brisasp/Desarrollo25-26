using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1_T5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string elemento = txtElemento.Text.Trim();

            if (elemento == "")
            {
                MessageBox.Show("No se pueden insertar cadenas vacías.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstElementos.Items.Add(elemento);
            txtElemento.Clear();
            txtElemento.Focus();

            /*su forma
            //if (txtElemento.Text.Trim()|= "")
            // {
            //lstElementos.Items.Add(elemento);
            //txtElemento.Clear();
            //txtElemento.Focus();
             }
            */

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscar = txtBuscar.Text.Trim();

            if (buscar == "")
            {
                MessageBox.Show("Introduce un elemento a buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int n = lstElementos.Items.Count;
            if (n == 0)
            {
                MessageBox.Show("La lista está vacía.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Algoritmo del centinela
            string buscarMin = buscar.ToLower(); // convertimos a minúsculas
            string[] elementos = new string[n + 1]; // espacio para centinela
            for (int i = 0; i < n; i++)
            elementos[i] = lstElementos.Items[i].ToString().ToLower();

            elementos[n] = buscarMin; // centinela

            int iIndex = 0;
            while (elementos[iIndex] != buscarMin)
                iIndex++;

            if (iIndex < n)
                MessageBox.Show($"El elemento \"{buscar}\" SÍ está en la lista.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show($"El elemento \"{buscar}\" NO está en la lista.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtBuscar.Clear();
            txtBuscar.Focus();
        }

        private void Terminar_Click(object sender, EventArgs e)
        {
            // Muestra una confirmación antes de salir
            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que quieres terminar el programa?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
            /*Enviroment.Exit(0); Como lo hace ella */
        
    }
    }
}