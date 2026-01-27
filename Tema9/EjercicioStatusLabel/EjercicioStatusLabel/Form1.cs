using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioStatusLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            ToolStripStatusLabel nuevoStatusLabel = new ToolStripStatusLabel();
            //por si no esta visible
            statusStrip1.Show();
            statusStrip1.Items.Add(nuevoStatusLabel);
            //Y si queremos modificar su texto, como vimos antes:
            nuevoStatusLabel.Text = "Este es un StatusLabel nuevo";
            nuevoStatusLabel.Spring = true;
        }
    }
}
