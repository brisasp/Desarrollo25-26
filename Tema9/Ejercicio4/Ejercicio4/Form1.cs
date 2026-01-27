using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarraEstadoColor.Text = "Color: " + ((ToolStripMenuItem)sender).Text;
            //otra forma
            //BarraEstadoColor.Text = "Color: azul";
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarraEstadoColor.Text = "Color: Rojo";
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarraEstadoColor.Text = "Color: Verde";
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarraEstadoColor.Text = "Color: Amarillo";
        }

        private void marronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarraEstadoColor.Text = "Color: Marron";
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarraEstadoColor.Text = "Color: Negro";
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            azulToolStripMenuItem_Click(sender, e);
        }

        private void verdeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rojoToolStripMenuItem_Click(sender, e);
        }

        private void amarilloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            amarilloToolStripMenuItem_Click(sender, e);
        }

        private void negroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            negroToolStripMenuItem_Click(sender, e);
        }

        private void marronToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            marronToolStripMenuItem_Click(sender, e);
        }

        private void linkAulaVirtual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //abrimos el enlace
            System.Diagnostics.Process.Start("https://aulavirtual-educacion.larioja.org/");
            //marcamos el enlace como visitado
            linkAulaVirtual.LinkVisited=true;
        }
    }
}
