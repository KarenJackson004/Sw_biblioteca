namespace Sw_biblioteca
{
    partial class FormLibros
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
            PNLBusqueda = new Panel();
            BTNBusqueda = new Button();
            TXTBuscarISBN = new TextBox();
            LBLIsbn = new Label();
            PNLGestor = new Panel();
            LBLGestor = new Label();
            PNLDatos = new Panel();
            TXTBOXExistencias = new TextBox();
            TXTBOXAnio = new TextBox();
            TXTBOXGenero = new TextBox();
            CMBEditorial = new ComboBox();
            CMBAutor = new ComboBox();
            TXTBOXTitulo = new TextBox();
            TXTBOXIsbn1 = new TextBox();
            TXTExsistencias = new Label();
            TXTAnio = new Label();
            TXTCategoria = new Label();
            TXTEditorial = new Label();
            TXTAutor = new Label();
            TXTTitulo = new Label();
            TXTIsbn1 = new Label();
            panel1 = new Panel();
            BTNCancelar = new FontAwesome.Sharp.IconButton();
            BTNEliminar = new FontAwesome.Sharp.IconButton();
            BTNEditar = new FontAwesome.Sharp.IconButton();
            BTNGuardar = new FontAwesome.Sharp.IconButton();
            BTNNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            PNLBusqueda.SuspendLayout();
            PNLGestor.SuspendLayout();
            PNLDatos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // PNLBusqueda
            // 
            PNLBusqueda.BackColor = Color.PaleGoldenrod;
            PNLBusqueda.Controls.Add(BTNBusqueda);
            PNLBusqueda.Controls.Add(TXTBuscarISBN);
            PNLBusqueda.Controls.Add(LBLIsbn);
            PNLBusqueda.Dock = DockStyle.Top;
            PNLBusqueda.Location = new Point(0, 79);
            PNLBusqueda.Name = "PNLBusqueda";
            PNLBusqueda.Size = new Size(1183, 80);
            PNLBusqueda.TabIndex = 3;
            // 
            // BTNBusqueda
            // 
            BTNBusqueda.BackColor = SystemColors.ControlLight;
            BTNBusqueda.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNBusqueda.Location = new Point(742, 27);
            BTNBusqueda.Name = "BTNBusqueda";
            BTNBusqueda.Size = new Size(103, 31);
            BTNBusqueda.TabIndex = 2;
            BTNBusqueda.Text = "Buscar";
            BTNBusqueda.UseVisualStyleBackColor = false;
            BTNBusqueda.Click += BTNBusqueda_Click;
            // 
            // TXTBuscarISBN
            // 
            TXTBuscarISBN.Location = new Point(426, 29);
            TXTBuscarISBN.Name = "TXTBuscarISBN";
            TXTBuscarISBN.Size = new Size(282, 27);
            TXTBuscarISBN.TabIndex = 1;
            // 
            // LBLIsbn
            // 
            LBLIsbn.AutoSize = true;
            LBLIsbn.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLIsbn.Location = new Point(335, 29);
            LBLIsbn.Name = "LBLIsbn";
            LBLIsbn.Size = new Size(63, 29);
            LBLIsbn.TabIndex = 0;
            LBLIsbn.Text = "ISBN";
            // 
            // PNLGestor
            // 
            PNLGestor.BackColor = Color.LimeGreen;
            PNLGestor.Controls.Add(LBLGestor);
            PNLGestor.Dock = DockStyle.Top;
            PNLGestor.Location = new Point(0, 0);
            PNLGestor.Name = "PNLGestor";
            PNLGestor.Size = new Size(1183, 79);
            PNLGestor.TabIndex = 2;
            PNLGestor.Paint += PNLGestor_Paint;
            // 
            // LBLGestor
            // 
            LBLGestor.AutoSize = true;
            LBLGestor.BackColor = Color.Transparent;
            LBLGestor.Font = new Font("Gill Sans MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLGestor.ForeColor = SystemColors.ButtonFace;
            LBLGestor.Location = new Point(365, 9);
            LBLGestor.Name = "LBLGestor";
            LBLGestor.Size = new Size(301, 52);
            LBLGestor.TabIndex = 0;
            LBLGestor.Text = "Gestor de libros";
            LBLGestor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PNLDatos
            // 
            PNLDatos.BackColor = Color.Linen;
            PNLDatos.Controls.Add(TXTBOXExistencias);
            PNLDatos.Controls.Add(TXTBOXAnio);
            PNLDatos.Controls.Add(TXTBOXGenero);
            PNLDatos.Controls.Add(CMBEditorial);
            PNLDatos.Controls.Add(CMBAutor);
            PNLDatos.Controls.Add(TXTBOXTitulo);
            PNLDatos.Controls.Add(TXTBOXIsbn1);
            PNLDatos.Controls.Add(TXTExsistencias);
            PNLDatos.Controls.Add(TXTAnio);
            PNLDatos.Controls.Add(TXTCategoria);
            PNLDatos.Controls.Add(TXTEditorial);
            PNLDatos.Controls.Add(TXTAutor);
            PNLDatos.Controls.Add(TXTTitulo);
            PNLDatos.Controls.Add(TXTIsbn1);
            PNLDatos.Dock = DockStyle.Top;
            PNLDatos.Location = new Point(0, 159);
            PNLDatos.Name = "PNLDatos";
            PNLDatos.Size = new Size(1183, 272);
            PNLDatos.TabIndex = 4;
            // 
            // TXTBOXExistencias
            // 
            TXTBOXExistencias.Location = new Point(505, 232);
            TXTBOXExistencias.Name = "TXTBOXExistencias";
            TXTBOXExistencias.Size = new Size(285, 27);
            TXTBOXExistencias.TabIndex = 13;
            // 
            // TXTBOXAnio
            // 
            TXTBOXAnio.Location = new Point(505, 196);
            TXTBOXAnio.Name = "TXTBOXAnio";
            TXTBOXAnio.Size = new Size(285, 27);
            TXTBOXAnio.TabIndex = 12;
            // 
            // TXTBOXGenero
            // 
            TXTBOXGenero.Location = new Point(505, 161);
            TXTBOXGenero.Name = "TXTBOXGenero";
            TXTBOXGenero.Size = new Size(285, 27);
            TXTBOXGenero.TabIndex = 11;
            // 
            // CMBEditorial
            // 
            CMBEditorial.FormattingEnabled = true;
            CMBEditorial.Location = new Point(505, 126);
            CMBEditorial.Name = "CMBEditorial";
            CMBEditorial.Size = new Size(285, 28);
            CMBEditorial.TabIndex = 10;
            CMBEditorial.SelectedIndexChanged += CMBEditorial_SelectedIndexChanged;
            // 
            // CMBAutor
            // 
            CMBAutor.FormattingEnabled = true;
            CMBAutor.Location = new Point(505, 90);
            CMBAutor.Name = "CMBAutor";
            CMBAutor.Size = new Size(285, 28);
            CMBAutor.TabIndex = 9;
            // 
            // TXTBOXTitulo
            // 
            TXTBOXTitulo.Location = new Point(505, 52);
            TXTBOXTitulo.Name = "TXTBOXTitulo";
            TXTBOXTitulo.Size = new Size(285, 27);
            TXTBOXTitulo.TabIndex = 8;
            // 
            // TXTBOXIsbn1
            // 
            TXTBOXIsbn1.Location = new Point(505, 14);
            TXTBOXIsbn1.Name = "TXTBOXIsbn1";
            TXTBOXIsbn1.Size = new Size(285, 27);
            TXTBOXIsbn1.TabIndex = 7;
            // 
            // TXTExsistencias
            // 
            TXTExsistencias.AutoSize = true;
            TXTExsistencias.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTExsistencias.Location = new Point(346, 232);
            TXTExsistencias.Name = "TXTExsistencias";
            TXTExsistencias.Size = new Size(100, 25);
            TXTExsistencias.TabIndex = 6;
            TXTExsistencias.Text = "Existencias";
            // 
            // TXTAnio
            // 
            TXTAnio.AutoSize = true;
            TXTAnio.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTAnio.Location = new Point(346, 196);
            TXTAnio.Name = "TXTAnio";
            TXTAnio.Size = new Size(45, 25);
            TXTAnio.TabIndex = 5;
            TXTAnio.Text = "Año";
            // 
            // TXTCategoria
            // 
            TXTCategoria.AutoSize = true;
            TXTCategoria.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTCategoria.Location = new Point(345, 161);
            TXTCategoria.Name = "TXTCategoria";
            TXTCategoria.Size = new Size(72, 25);
            TXTCategoria.TabIndex = 4;
            TXTCategoria.Text = "Genero";
            TXTCategoria.Click += TXTCategoria_Click;
            // 
            // TXTEditorial
            // 
            TXTEditorial.AutoSize = true;
            TXTEditorial.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTEditorial.Location = new Point(345, 126);
            TXTEditorial.Name = "TXTEditorial";
            TXTEditorial.Size = new Size(82, 25);
            TXTEditorial.TabIndex = 3;
            TXTEditorial.Text = "Editorial";
            // 
            // TXTAutor
            // 
            TXTAutor.AutoSize = true;
            TXTAutor.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTAutor.Location = new Point(346, 90);
            TXTAutor.Name = "TXTAutor";
            TXTAutor.Size = new Size(65, 25);
            TXTAutor.TabIndex = 2;
            TXTAutor.Text = "Autor ";
            // 
            // TXTTitulo
            // 
            TXTTitulo.AutoSize = true;
            TXTTitulo.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTTitulo.Location = new Point(345, 52);
            TXTTitulo.Name = "TXTTitulo";
            TXTTitulo.Size = new Size(66, 25);
            TXTTitulo.TabIndex = 1;
            TXTTitulo.Text = "Titulo ";
            // 
            // TXTIsbn1
            // 
            TXTIsbn1.AutoSize = true;
            TXTIsbn1.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTIsbn1.Location = new Point(346, 16);
            TXTIsbn1.Name = "TXTIsbn1";
            TXTIsbn1.Size = new Size(54, 25);
            TXTIsbn1.TabIndex = 0;
            TXTIsbn1.Text = "ISBN";
            TXTIsbn1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(BTNCancelar);
            panel1.Controls.Add(BTNEliminar);
            panel1.Controls.Add(BTNEditar);
            panel1.Controls.Add(BTNGuardar);
            panel1.Controls.Add(BTNNuevo);
            panel1.Location = new Point(254, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 78);
            panel1.TabIndex = 5;
            // 
            // BTNCancelar
            // 
            BTNCancelar.BackColor = SystemColors.ActiveBorder;
            BTNCancelar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            BTNCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNCancelar.IconColor = Color.Black;
            BTNCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNCancelar.Location = new Point(547, 17);
            BTNCancelar.Name = "BTNCancelar";
            BTNCancelar.Size = new Size(101, 40);
            BTNCancelar.TabIndex = 4;
            BTNCancelar.Text = "Cancelar";
            BTNCancelar.UseMnemonic = false;
            BTNCancelar.UseVisualStyleBackColor = false;
            BTNCancelar.Click += BTNCancelar_Click;
            // 
            // BTNEliminar
            // 
            BTNEliminar.BackColor = Color.Salmon;
            BTNEliminar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            BTNEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNEliminar.IconColor = Color.Black;
            BTNEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNEliminar.Location = new Point(426, 17);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Size = new Size(94, 40);
            BTNEliminar.TabIndex = 3;
            BTNEliminar.Text = "Eliminar";
            BTNEliminar.UseVisualStyleBackColor = false;
            // 
            // BTNEditar
            // 
            BTNEditar.BackColor = Color.Khaki;
            BTNEditar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            BTNEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNEditar.IconColor = Color.Black;
            BTNEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNEditar.Location = new Point(301, 17);
            BTNEditar.Name = "BTNEditar";
            BTNEditar.Size = new Size(98, 40);
            BTNEditar.TabIndex = 2;
            BTNEditar.Text = "Editar";
            BTNEditar.UseVisualStyleBackColor = false;
            BTNEditar.Click += BTNEditar_Click;
            // 
            // BTNGuardar
            // 
            BTNGuardar.BackColor = Color.PaleGreen;
            BTNGuardar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            BTNGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNGuardar.IconColor = Color.Black;
            BTNGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNGuardar.Location = new Point(172, 17);
            BTNGuardar.Name = "BTNGuardar";
            BTNGuardar.Size = new Size(103, 40);
            BTNGuardar.TabIndex = 1;
            BTNGuardar.Text = "Guardar";
            BTNGuardar.UseVisualStyleBackColor = false;
            BTNGuardar.Click += BTNGuardar_Click;
            // 
            // BTNNuevo
            // 
            BTNNuevo.BackColor = SystemColors.ActiveCaption;
            BTNNuevo.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNNuevo.IconColor = Color.Black;
            BTNNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNNuevo.Location = new Point(43, 17);
            BTNNuevo.Name = "BTNNuevo";
            BTNNuevo.Size = new Size(104, 40);
            BTNNuevo.TabIndex = 0;
            BTNNuevo.Text = "Nuevo";
            BTNNuevo.UseVisualStyleBackColor = false;
            BTNNuevo.Click += BTNNuevo_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(41, 551);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(1130, 269);
            dgvLibros.TabIndex = 6;
            dgvLibros.CellContentDoubleClick += CargarLibroSeleccionado;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1183, 703);
            Controls.Add(dgvLibros);
            Controls.Add(panel1);
            Controls.Add(PNLDatos);
            Controls.Add(PNLBusqueda);
            Controls.Add(PNLGestor);
            Name = "FormLibros";
            Text = "FormLibros";
            WindowState = FormWindowState.Maximized;
            PNLBusqueda.ResumeLayout(false);
            PNLBusqueda.PerformLayout();
            PNLGestor.ResumeLayout(false);
            PNLGestor.PerformLayout();
            PNLDatos.ResumeLayout(false);
            PNLDatos.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PNLBusqueda;
        private Button BTNBusqueda;
        private TextBox TXTBuscarISBN;
        private Label LBLIsbn;
        private Panel PNLGestor;
        private Label LBLGestor;
        private Panel PNLDatos;
        private Label TXTIsbn1;
        private Label TXTExsistencias;
        private Label TXTAnio;
        private Label TXTCategoria;
        private Label TXTEditorial;
        private Label TXTAutor;
        private Label TXTTitulo;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BTNNuevo;
        private FontAwesome.Sharp.IconButton BTNCancelar;
        private FontAwesome.Sharp.IconButton BTNEliminar;
        private FontAwesome.Sharp.IconButton BTNEditar;
        private FontAwesome.Sharp.IconButton BTNGuardar;
        private DataGridView dgvLibros;
        private ComboBox CMBAutor;
        private TextBox TXTBOXTitulo;
        private TextBox TXTBOXIsbn1;
        private TextBox TXTBOXExistencias;
        private TextBox TXTBOXAnio;
        private TextBox TXTBOXGenero;
        private ComboBox CMBEditorial;
    }
}