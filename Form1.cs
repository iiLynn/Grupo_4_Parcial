﻿using Grupo4_semana4_formulario.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.OleDb;


namespace Grupo4_semana4_formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 newMDIChild = new AboutBox1();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void laptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lapto AcercaDe = new Lapto();
            _ = AcercaDe.ShowDialog();
        }

        private void pCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Computadora newMDIChild = new Computadora();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
