using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1Tema2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Ejercicio 1 - Tema 2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.listBox1.Items.Clear();
            //Asignar los valores para anclar los controles
            //El textBox se anclaba arriba izquierda y derecha
            txtNombre.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            // el boton Añadir se ancla arriba a la derecha
            btnAceptar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);

            //El listbox se ancla en los cuatro vertices
            listBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

            //El boton cerrar se ancla a la derecha y abajo
            btnCancelar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
         {
           this.Close();
            }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }
    }
    }


