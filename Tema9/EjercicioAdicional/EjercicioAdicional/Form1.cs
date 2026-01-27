using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioAdicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblNombre.ForeColor = Color.Blue;
        }

        private void MenuGrande_Click(object sender, EventArgs e)
        {
            lblNombre.Font = new Font(lblNombre.Font.Name, 50);

        }

        private void MenuMediano_Click(object sender, EventArgs e)
        {
            lblNombre.Font = new Font(lblNombre.Font.Name, 30);
        }

        private void MenuPequeño_Click(object sender, EventArgs e)
        {
            lblNombre.Font = new Font(lblNombre.Font.Name, 15);

        }

        private void verdeMenu_Click(object sender, EventArgs e)
        {
            lblNombre.ForeColor= Color.Green;
        }

        private void rojoMenu_Click(object sender, EventArgs e)
        {
            lblNombre.ForeColor = Color.Red;
        }

        private void salirMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
