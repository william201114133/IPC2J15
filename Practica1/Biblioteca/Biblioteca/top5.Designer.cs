namespace Biblioteca
{
    partial class top5
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
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bibliotecaDataSet7 = new Biblioteca.bibliotecaDataSet7();
            this.top5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.top5TableAdapter = new Biblioteca.bibliotecaDataSet7TableAdapters.top5TableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top5BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClienteToolStripMenuItem,
            this.ingresarLibroToolStripMenuItem,
            this.prestamoToolStripMenuItem,
            this.devolucionToolStripMenuItem,
            this.reservacionToolStripMenuItem});
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
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.prestamoToolStripMenuItem.Text = "Prestamo";
            this.prestamoToolStripMenuItem.Click += new System.EventHandler(this.prestamoToolStripMenuItem_Click);
            // 
            // devolucionToolStripMenuItem
            // 
            this.devolucionToolStripMenuItem.Name = "devolucionToolStripMenuItem";
            this.devolucionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.devolucionToolStripMenuItem.Text = "Devolucion";
            this.devolucionToolStripMenuItem.Click += new System.EventHandler(this.devolucionToolStripMenuItem_Click);
            // 
            // reservacionToolStripMenuItem
            // 
            this.reservacionToolStripMenuItem.Name = "reservacionToolStripMenuItem";
            this.reservacionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reservacionToolStripMenuItem.Text = "Reservacion";
            this.reservacionToolStripMenuItem.Click += new System.EventHandler(this.reservacionToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem});
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.top5BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(397, 274);
            this.dataGridView1.TabIndex = 1;
            // 
            // bibliotecaDataSet7
            // 
            this.bibliotecaDataSet7.DataSetName = "bibliotecaDataSet7";
            this.bibliotecaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // top5BindingSource
            // 
            this.top5BindingSource.DataMember = "top5";
            this.top5BindingSource.DataSource = this.bibliotecaDataSet7;
            // 
            // top5TableAdapter
            // 
            this.top5TableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // top5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 298);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "top5";
            this.Text = "top5";
            this.Load += new System.EventHandler(this.top5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top5BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bibliotecaDataSet7 bibliotecaDataSet7;
        private System.Windows.Forms.BindingSource top5BindingSource;
        private bibliotecaDataSet7TableAdapters.top5TableAdapter top5TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
    }
}