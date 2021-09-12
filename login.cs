using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grupo4_semana4_formulario
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server=DESKTOP-PMRS7B8\\SQL4;DataBase=master; integrated security=true");
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "Select * from ususario where ususario=´" + textBox1 + "´and contraseña=´" + textBox2 + "´";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.Read())
            {
                MessageBox.Show("Bienvenido");
                Form1 forbienvenido = new Form1();
                this.Hide();
                forbienvenido.Show();
            }
            else
            {
                MessageBox.Show("Usuario/contraseña incorrecta");
            }
            conexion.Close();
        }
    }
}
