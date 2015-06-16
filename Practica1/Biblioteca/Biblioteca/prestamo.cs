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
    public partial class prestamo : Form
    {
        string dato = "";
        Servidorpractica.Service1 servidor = new Servidorpractica.Service1();
        public prestamo()
        {
            InitializeComponent();
        }

        private void prestamo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet1.libro' table. You can move, or remove it, as needed.
            this.libroTableAdapter.Fill(this.bibliotecaDataSet1.libro);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bibliotecaDataSet.cliente);
            // TODO: This line of code loads data into the 'bibliotecaDataSet1.libro' table. You can move, or remove it, as needed.
            this.libroTableAdapter.Fill(this.bibliotecaDataSet1.libro);
            // TODO: This line of code loads data into the 'bibliotecaDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.bibliotecaDataSet.cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dato = "INSERT INTO prestamo VALUES ('" + textBox1.Text + "'," + comboBox1.ValueMember + "," + comboBox2.ValueMember + ")";
            servidor.guardar(dato);

            textBox1.Text = "";
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

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucion devolucion = new Devolucion();
            devolucion.Show();
            this.SetVisibleCore(false);
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reservacion reserva = new reservacion();
            reserva.Show();
            this.SetVisibleCore(false);
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
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
