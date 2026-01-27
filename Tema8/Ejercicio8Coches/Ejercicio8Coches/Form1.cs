using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio8Coches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            //Calculo el importe
            double importe = double.Parse(txtImporte.Text);

            //Calculo el interes segun el tipo de financiacion
            double iPersonal = importe * 0.05;
            double iBanco = importe * 0.1;
            double iFondoColectivo= importe * 0.15;

            //Calculo la cuota inicial segun el tipo de financiacion
            double ciPersonal = (importe + iPersonal) * 0.6;
            double ciBanco = (importe + iBanco) * 0.5;
            double ciFondoColectivo = (importe + iFondoColectivo) * 0.35;

            //Calculo el numero de letras segun el tipo de financiacion
            int lPersonal = 2;
            int lBanco = 4;
            int lFondoColectivo = 6;

            //Imprimir en el listView lvCantidades
            ListViewItem fila1 = new ListViewItem("Personal");
            fila1.SubItems.Add(iPersonal.ToString());
            fila1.SubItems.Add(ciPersonal.ToString());
            fila1.SubItems.Add(lPersonal.ToString());
            lstCantidades.Items.Add(fila1);

            ListViewItem fila2 = new ListViewItem("Banco");
            fila2.SubItems.Add(iBanco.ToString());
            fila2.SubItems.Add(ciBanco.ToString());
            fila2.SubItems.Add(lBanco.ToString());
            lstCantidades.Items.Add(fila2);

            ListViewItem fila3 = new ListViewItem("Fondo Colectivo");
            fila3.SubItems.Add(iFondoColectivo.ToString());
            fila3.SubItems.Add(ciFondoColectivo.ToString());
            fila3.SubItems.Add(lFondoColectivo.ToString());
            lstCantidades.Items.Add(fila3);
        }

        private void cmbTipoFinanciamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int letras = 0;
                double importe = Convert.ToDouble(txtImporte.Text);
                double interes = 0, cuotaInicial = 0;
                int i = 0;
                while (i < lstCantidades.Items.Count) {
                    if (lstCantidades.Items[i].SubItems[0].Text == cmbTipoFinanciamiento.Text) {
                        letras = int.Parse(lstCantidades.Items[i].SubItems[3].Text);
                        interes = Convert.ToDouble(lstCantidades.Items[i].SubItems[1].Text);
                        cuotaInicial = Convert.ToDouble(lstCantidades.Items[i].SubItems[2].Text);
                    }
                    i += 1;
                }
                int n = 1;
                double cuotaMensual = (importe + interes - cuotaInicial) / letras;
                DateTime fechaActual = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                //Limpiamos el ListView de las cuotas mensuales
                lvCuotas.Items.Clear();
                //Escribimos las cuotas en el ListView
                while (n <= letras) {
                    DateTime fecha = fechaActual.AddMonths(n);
                    ListViewItem fila = new ListViewItem(n.ToString());
                    fila.SubItems.Add(fecha.ToShortDateString());
                    fila.SubItems.Add(cuotaMensual.ToString());




                }
            
            
            
            }
        }
    }
}
