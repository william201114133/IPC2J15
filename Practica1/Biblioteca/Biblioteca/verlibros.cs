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
    public partial class verlibros : Form
    {
        public verlibros()
        {
            InitializeComponent();
        }

        private void verlibros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotecaDataSet8.listalibros' table. You can move, or remove it, as needed.
            this.listalibrosTableAdapter.Fill(this.bibliotecaDataSet8.listalibros);

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

        private void top5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            top5 top = new top5();
            top.Show();
            this.SetVisibleCore(false);
        }
    }
}
