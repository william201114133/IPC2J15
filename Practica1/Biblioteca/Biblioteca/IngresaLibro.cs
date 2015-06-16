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
    public partial class IngresaLibro : Form
    {
        string dato = "";
        public IngresaLibro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servidorpractica.Service1 servidor = new Servidorpractica.Service1();
            dato = "INSERT INTO libro VALUES ('" + textBox1.Text + "'," + textBox2.Text + ",'" + textBox3.Text + "'.'" + textBox4.Text + "'," + textBox5.Text + ")";
            servidor.guardar(dato);
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void IngresaLibro_Load(object sender, EventArgs e)
        {

        }

        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ingrecliente = new Form1();
            ingrecliente.Show();
            this.SetVisibleCore(false);
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prestamo prestamo = new prestamo();
            prestamo.Show();
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
