using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Tema2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click_1(object sender, EventArgs e)
        {
            if (txtAñadir.Text.Length > 0)
            {
                lstCosas.Items.Add(txtAñadir.Text);
                txtAñadir.Clear();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstCosas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCosas.SelectedIndex != -1)
                txtSeleccionado.Text = lstCosas.SelectedItem.ToString();
        }

        private void btnEliminarTodos_Click(object sender, EventArgs e)
        {
            lstCosas.Items.Clear();
            txtAñadir.Clear();

        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            int i;
            for (i = lstCosas.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstCosas.Items.Remove(lstCosas.SelectedItems[i]);
            }
            txtSeleccionado.Clear();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
            this.txtAñadir.Text = "";
            this.lstCosas.Items.Clear();
            //Asignar los valores para anclar los controles
            //El textBox se anclaba arriba izquierda y derecha
            txtAñadir.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            // el boton Añadir se ancla arriba a la derecha
            btnAñadir.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            
            //El listbox se ancla en los cuatro vertices
            lstCosas.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom|AnchorStyles.Left);
            label1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            label2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtSeleccionado.Anchor = 
                (AnchorStyles.Top | AnchorStyles.Right);
            //El boton cerrar se ancla a la derecha y abajo
            btnCerrar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            btnEliminarTodos.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            btnEliminarSeleccionado.Anchor= (AnchorStyles.Top | AnchorStyles.Right);
            groupBox1.Anchor = lstCosas.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
        }
    }
}
