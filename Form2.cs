using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Collections;

namespace Grupo4_semana4_formulario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader Archivo = new StreamReader("C:\\Users\\Luis2\\OneDrive\\Documentos\\CICLO 2\\Parcial_Grupo4\\ayuda.txt");

            string linea = "";

            ArrayList contenido = new ArrayList();

            while (linea != null);
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                contenido.Add(linea);
                textBox1.Text = linea;
            }
            Archivo.Close();

            textBox1.Text = "";

            foreach (String linea_mostrar in contenido);
            {
                string linea_mostrar = null;
                textBox1.Text = textBox1.Text + linea_mostrar + "\n";
            }
        }
    }
}
