using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class FormGato : Form
    {
        public FormGato()
        {
            InitializeComponent();
        }

        private void btnMostrarFormulario_Click(object sender, EventArgs e)
        {
            FormDatos f1 = new FormDatos();
            f1.Show();
        }
    }
}
