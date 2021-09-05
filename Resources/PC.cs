using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_semana4_formulario.Resources
{
    public partial class Computadora : Form
    {
        public Computadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Computadora_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su compra se ha completado", "Compra de una Computadora", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su compra se ha completado", "Compra de una Computadora", MessageBoxButtons.OK);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su compra se ha completado", "Compra de una Computadora", MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
