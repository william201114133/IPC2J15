namespace Biblioteca
{
    partial class verlibros
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
            this.top5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bibliotecaDataSet8 = new Biblioteca.bibliotecaDataSet8();
            this.listalibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listalibrosTableAdapter = new Biblioteca.bibliotecaDataSet8TableAdapters.listalibrosTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prestadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponiblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listalibrosBindingSource)).BeginInit();
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
            this.top5ToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // top5ToolStripMenuItem
            // 
            this.top5ToolStripMenuItem.Name = "top5ToolStripMenuItem";
            this.top5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.top5ToolStripMenuItem.Text = "Top5";
            this.top5ToolStripMenuItem.Click += new System.EventHandler(this.top5ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn,
            this.prestadosDataGridViewTextBoxColumn,
            this.disponiblesDataGridViewTextBoxColumn,
            this.reservadosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listalibrosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(284, 238);
            this.dataGridView1.TabIndex = 1;
            // 
            // bibliotecaDataSet8
            // 
            this.bibliotecaDataSet8.DataSetName = "bibliotecaDataSet8";
            this.bibliotecaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listalibrosBindingSource
            // 
            this.listalibrosBindingSource.DataMember = "listalibros";
            this.listalibrosBindingSource.DataSource = this.bibliotecaDataSet8;
            // 
            // listalibrosTableAdapter
            // 
            this.listalibrosTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "existencia";
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            this.existenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prestadosDataGridViewTextBoxColumn
            // 
            this.prestadosDataGridViewTextBoxColumn.DataPropertyName = "Prestados";
            this.prestadosDataGridViewTextBoxColumn.HeaderText = "Prestados";
            this.prestadosDataGridViewTextBoxColumn.Name = "prestadosDataGridViewTextBoxColumn";
            this.prestadosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // disponiblesDataGridViewTextBoxColumn
            // 
            this.disponiblesDataGridViewTextBoxColumn.DataPropertyName = "Disponibles";
            this.disponiblesDataGridViewTextBoxColumn.HeaderText = "Disponibles";
            this.disponiblesDataGridViewTextBoxColumn.Name = "disponiblesDataGridViewTextBoxColumn";
            this.disponiblesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservadosDataGridViewTextBoxColumn
            // 
            this.reservadosDataGridViewTextBoxColumn.DataPropertyName = "Reservados";
            this.reservadosDataGridViewTextBoxColumn.HeaderText = "Reservados";
            this.reservadosDataGridViewTextBoxColumn.Name = "reservadosDataGridViewTextBoxColumn";
            this.reservadosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // verlibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "verlibros";
            this.Text = "verlibros";
            this.Load += new System.EventHandler(this.verlibros_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotecaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listalibrosBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem top5ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bibliotecaDataSet8 bibliotecaDataSet8;
        private System.Windows.Forms.BindingSource listalibrosBindingSource;
        private bibliotecaDataSet8TableAdapters.listalibrosTableAdapter listalibrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prestadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponiblesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservadosDataGridViewTextBoxColumn;
    }
}