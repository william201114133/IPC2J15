using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Devolucion : Form
    {
        string dato = "";
        Servidorpractica.Service1 servidor = new Servidorpractica.Service1();
        public Devolucion()
        {
            InitializeComponent();
        }

        private void Devolucion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet3.libro' table. You can move, or remove it, as needed.
            this.libroTableAdapter.Fill(this.bibliotecaDataSet3.libro);
            // TODO: This line of code loads data into the 'bibliotecaDataSet2.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bibliotecaDataSet2.cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            dato = "INSESRT INTRO devolucion VALUES('" + textBox1.Text + "'," + comboBox1.ValueMember + "," + comboBox2.ValueMember + ")";
            servidor.guardar(dato);
            textBox1.Text = "";
        }

        private void pendienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestamo prestamo = new prestamo();
            prestamo.Show();
            this.SetVisibleCore(false);
        }

        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ingrecliente = new Form1();
            ingrecliente.Show();
            this.SetVisibleCore(false);
        }

        private void ingresarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresaLibro ingrelibro = new IngresaLibro();
            ingrelibro.Show();
            this.SetVisibleCore(false);
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reservacion reservacion = new reservacion();
            reservacion.Show();
            this.SetVisibleCore(false);
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verlibros libro = new verlibros();
            libro.Show();
            this.SetVisibleCore(false);
        }

        private void top5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            top5 top = new top5();
            top.Show();
            this.SetVisibleCore(false);
        }
    }
}
