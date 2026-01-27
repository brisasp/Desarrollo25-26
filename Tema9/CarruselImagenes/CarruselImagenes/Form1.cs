using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarruselImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cont = 0;
        private void btnImagenes_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[cont];
            cont += 1;
            if (cont == imageList1.Images.Count)
                cont = 0;

        }
    }
}
