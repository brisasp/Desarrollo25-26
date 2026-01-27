using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtElemento.Text.Trim() != "")
                //hay algo escrito.Comprobamos que no exista ya en la lista
                if (lstElementos.FindStringExact(txtElemento.Text) != -1)
                    MessageBox.Show("No puedo añadir el elemento :" + txtElemento.)

                       else {
                    lstElementos.Items.Add(txtElemento.Text);
                    EscribeTotales();
                    txtElemento.Clear();
                }
        }

        private void EscribeTotales() {
        //escribe en la label el numero de elementos de la lista actualizado
       
        
        }
    }
}
