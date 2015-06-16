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
    public partial class top5 : Form
    {
        public top5()
        {
            InitializeComponent();
        }

        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ingrecliente = new Form1();
            ingrecliente.Show();
            this.SetVisibleCore(false);
        }

        private void top5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet7.top5' table. You can move, or remove it, as needed.
            this.top5TableAdapter.Fill(this.bibliotecaDataSet7.top5);

        }

        private void ingresarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresaLibro ingrelibro = new IngresaLibro();
            ingrelibro.Show();
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

        private void reservacionToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
