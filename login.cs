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
using System.Data.OleDb;

namespace Grupo4_semana4_formulario
{
    public partial class login : Form
    {
       
        public login()
        {
            InitializeComponent();
        }

        
        private void login_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-PMRS7B8\\SQL4;DataBase=master; integrated security=true");

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

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conex = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\Users\\orell\\OneDrive\\Escritorio\\login.accdb");

            try
            {
                conex.Open();
                MessageBox.Show("Conectado");
            }
            catch (Exception a)

            {
                MessageBox.Show("error por: " + a.ToString());
            }

            string consulto = "select contraseña,usuario from login where contraseña = ´" + textBox2.Text + "´ and usuario = ´" + textBox1.Text + "´;";
            OleDbCommand comande = new OleDbCommand (consulto, conex);
            OleDbDataReader leeDb;
            leeDb = comande.ExecuteReader();
            Boolean existereng = leeDb.HasRows;
            if (existereng)
            {
                MessageBox.Show("vienbenido/a al sistema " + textBox1.Text);
                Form1 abrir = new Form1();
                this.Hide();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("ususario o contraseña incorrecto trate de nuevo");
                return;
            }
            conex.Close();
        }
    }
}
