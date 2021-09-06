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

            string linea_mostrar = "";

            ArrayList contenido = new ArrayList();

            
            {
                
                
                linea_mostrar = Archivo.ReadLine();
                if (linea_mostrar != null)
                contenido.Add(linea_mostrar);
                textBox1.Text = linea_mostrar;
            }
            Archivo.Close();

            textBox1.Text = "";

            {
                foreach (object v in contenido) ;
                
                textBox1.Text = textBox1.Text+linea_mostrar + "\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
