using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        int numeroIzquierda;
        int numeroDerecha;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            

            try
            {
                numeroIzquierda = Convert.ToInt32(txtIzquierda.Text);
            }
            catch {
                MessageBox.Show("El dato introducido no es un entero");}
            try
            {
                numeroDerecha = Convert.ToInt32(txtDerecha.Text);
            }
            catch
            {
                MessageBox.Show("El dato introducido no es un entero");
            }
            Calcular();
        }

        private void Calcular() {
            double tmpResultado= 0;
            //Intentamos realizar la operacion 
            try
            {
                switch (comboBox1.SelectedItem.ToString())
                {
                    case "+":
                        tmpResultado = numeroIzquierda + numeroDerecha;
                        break;

                    case "-":
                        tmpResultado = numeroIzquierda - numeroDerecha;
                        break;

                    case "*":
                        tmpResultado = numeroIzquierda * numeroDerecha;
                        break;

                    case "/":
                        tmpResultado = numeroIzquierda / numeroDerecha;
                        break;

                }

            }
            catch (Exception ex) { 
            //Capturamos cualquier excepcion
            tmpResultado= 0;
            }
            //Mostramos el resultado de cualquier operaciohn
            txtResultado.Text = Convert.ToString(tmpResultado);
        }
    }
}
