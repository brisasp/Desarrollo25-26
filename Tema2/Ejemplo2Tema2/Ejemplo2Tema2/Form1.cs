using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2Tema2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.lstNombres.Items.Clear();
            //Asignar los valores para anclar los controles
            //El textBox se anclaba arriba izquierda y derecha
            txtNombre.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            // el boton Añadir se ancla arriba a la derecha
            btnAñadir.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            //El listbox se ancla en los cuatro vertices
            lstNombres.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

            //El boton cerrar se ancla a la derecha y abajo
            btnCerrar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0){
                lstNombres.Items.Add(txtNombre.Text);
                txtNombre.Clear();
            }
        }

        private void lstNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (lstNombres.SelectedIndex!=-1)
                txtNombre.Text=lstNombres.SelectedItem.ToString();
        }

        private void lstNombres_KeyDown(object sender, KeyEventArgs e)
        {
            //Borrar elemento seleccionado, es con el suprimir, no con delete
            // if (e.KeyCode == Keys.Delete)
            // {
            //    lstNombres.Items.Remove(lstNombres.SelectedItem);
            //}
            //Borrar todos los elementos de la lista
            if (e.KeyCode == Keys.Delete) {
                //elemento en la polsicion i del ListBox
                int i;
                //Borra las palabras seleccionadas del listBox
                for (i = lstNombres.SelectedItems.Count - 1; i >= 0; i--) {
                    lstNombres.Items.Remove(lstNombres.SelectedItems[i]);
                
                }
            }
        }
    }
}
