using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjRecogidaDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //utilizo variables de tipo string para almacenar los resultados
            string cadena;
            string cadenaEstado = "";
            string cadenaViajar;
            string cadenaVehiculo;

            //voy concatenando la cadena con el resultado
            cadena = "El nombre escrito es ;" + txtNombre.Text + " " + txtApellidos.Text + ", ";

            //compruebo el estado civil
            //if (rbSoltero.Checked == true)
            //    cadenaEstado = rbSoltero.Text;
            //else if(rbCasado.Checked.Text == true;
            //   cadenaEstado = rbCasado.Text;
            // else 
            //cadenaEstado = rbOtros.Text;


            foreach (RadioButton control in gbEstadoCivil.Controls.OfType<RadioButton>()) {
                RadioButton radio = control;
                if (radio.Checked) {
                
                    cadenaEstado = control.Text;
                }
            }

            //sigo concatenando
                cadena = cadena + "Tu estado civil es: " + cadenaEstado + ".";
            //compruebo si tiene disponibilidad para viajar
            if (cbViajar.Checked)
                cadenaViajar = "Si";
            else cadenaViajar = "No ";

            //concateno
            cadena = cadena + cadenaViajar + " tienes disponibilidad para viajar";

            if (cbVehiculo.Checked)
                cadenaVehiculo = "si ";
            else cadenaVehiculo = " no ";
            //concateno
            cadena = cadena + " y " + cadenaVehiculo + "tienes vehiculo propio";
            //finalmente escribo el resultado
            MessageBox.Show(cadena);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Estas seguro de querer salir?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(respuesta == DialogResult.Yes)
                Application.Exit();
        }
    }
}
