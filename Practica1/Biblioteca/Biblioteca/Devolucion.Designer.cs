namespace Biblioteca
{
    partial class Devolucion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet2 = new Biblioteca.bibliotecaDataSet2();
            this.clienteTableAdapter = new Biblioteca.bibliotecaDataSet2TableAdapters.clienteTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.libroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotecaDataSet3 = new Biblioteca.bibliotecaDataSet3();
            this.libroTableAdapter = new Biblioteca.bibliotecaDataSet3TableAdapters.libroTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClienteToolStripMenuItem,
            this.ingresarLibroToolStripMenuItem,
            this.pendienteToolStripMenuItem,
            this.reservarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ingresarClienteToolStripMenuItem
            // 
            this.ingresarClienteToolStripMenuItem.Name = "ingresarClienteToolStripMenuItem";
            this.ingresarClienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ingresarClienteToolStripMenuItem.Text = "Ingresar Cliente";
            this.ingresarClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarClienteToolStripMenuItem_Click);
            // 
            // ingresarLibroToolStripMenuItem
            // 
            this.ingresarLibroToolStripMenuItem.Name = "ingresarLibroToolStripMenuItem";
            this.ingresarLibroToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ingresarLibroToolStripMenuItem.Text = "Ingresar Libro";
            this.ingresarLibroToolStripMenuItem.Click += new System.EventHandler(this.ingresarLibroToolStripMenuItem_Click);
            // 
            // pendienteToolStripMenuItem
            // 
            this.pendienteToolStripMenuItem.Name = "pendienteToolStripMenuItem";
            this.pendienteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pendienteToolStripMenuItem.Text = "Pendiente";
            this.pendienteToolStripMenuItem.Click += new System.EventHandler(this.pendienteToolStripMenuItem_Click);
            // 
            // reservarToolStripMenuItem
            // 
            this.reservarToolStripMenuItem.Name = "reservarToolStripMenuItem";
            this.reservarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reservarToolStripMenuItem.Text = "Reservar";
            this.reservarToolStripMenuItem.Click += new System.EventHandler(this.reservarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "REALIZAR DEVOLUCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Libro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "idCliente", true));
            this.comboBox1.DataSource = this.clienteBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(92, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.bibliotecaDataSet2;
            // 
            // bibliotecaDataSet2
            // 
            this.bibliotecaDataSet2.DataSetName = "bibliotecaDataSet2";
            this.bibliotecaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.libroBindingSource, "idLibro", true));
            this.comboBox2.DataSource = this.libroBindingSource;
            this.comboBox2.DisplayMember = "nombre";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 153);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "idLibro";
            // 
            // libroBindingSource
            // 
            this.libroBindingSource.DataMember = "libro";
            this.libroBindingSource.DataSource = this.bibliotecaDataSet3;
            // 
            // bibliotecaDataSet3
            // 
            this.bibliotecaDataSet3.DataSetName = "bibliotecaDataSet3";
            this.bibliotecaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libroTableAdapter
            // 
            this.libroTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.top5ToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.librosToolStripMenuItem.Text = "Libros";
            this.librosToolStripMenuItem.Click += new System.EventHandler(this.librosToolStripMenuItem_Click);
            // 
            // top5ToolStripMenuItem
            // 
            this.top5ToolStripMenuItem.Name = "top5ToolStripMenuItem";
            this.top5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.top5ToolStripMenuItem.Text = "Top5";
            this.top5ToolStripMenuItem.Click += new System.EventHandler(this.top5ToolStripMenuItem_Click);
            // 
            // Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Devolucion";
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.Devolucion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendienteToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private bibliotecaDataSet2 bibliotecaDataSet2;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private bibliotecaDataSet2TableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private bibliotecaDataSet3 bibliotecaDataSet3;
        private System.Windows.Forms.BindingSource libroBindingSource;
        private bibliotecaDataSet3TableAdapters.libroTableAdapter libroTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem reservarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top5ToolStripMenuItem;
    }
}