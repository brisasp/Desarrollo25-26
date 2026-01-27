using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPad_Hijo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevoHijo_Click(object sender, EventArgs e)
        {
            Form FormNuevoHijo = new Hijo();
            FormNuevoHijo.MdiParent = this;
            FormNuevoHijo.Show();

        }

        private void btnCXerrar_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void btnMostrarVert_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //para habilitar opciones
            //menuStrip1.Enabled = true;
            //dejar marcada opcion
            //abrirToolStripMenuItem.Checked = true;





        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
