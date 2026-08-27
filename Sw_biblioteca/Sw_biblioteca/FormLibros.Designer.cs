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
            TXTBOXBusqueda = new TextBox();
            LBLIsbn = new Label();
            PNLGestor = new Panel();
            LBLGestor = new Label();
            PNLDatos = new Panel();
            TXTExsistencias = new Label();
            TXTAnio = new Label();
            TXTCategoria = new Label();
            TXTEditorial = new Label();
            TXTAutor = new Label();
            TXTTitulo = new Label();
            TXTIsbn1 = new Label();
            panel1 = new Panel();
            TXTCancelar = new FontAwesome.Sharp.IconButton();
            TXTEliminar = new FontAwesome.Sharp.IconButton();
            TXTEditar = new FontAwesome.Sharp.IconButton();
            TXTGuardar = new FontAwesome.Sharp.IconButton();
            TXTNuevo = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            TXTBOXIsbn1 = new TextBox();
            TXTBOXTitulo = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            TXTBOXGenero = new TextBox();
            TXTBOXAnio = new TextBox();
            TXTBOXExistencias = new TextBox();
            PNLBusqueda.SuspendLayout();
            PNLGestor.SuspendLayout();
            PNLDatos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PNLBusqueda
            // 
            PNLBusqueda.BackColor = Color.PaleGoldenrod;
            PNLBusqueda.Controls.Add(BTNBusqueda);
            PNLBusqueda.Controls.Add(TXTBOXBusqueda);
            PNLBusqueda.Controls.Add(LBLIsbn);
            PNLBusqueda.Dock = DockStyle.Top;
            PNLBusqueda.Location = new Point(0, 79);
            PNLBusqueda.Name = "PNLBusqueda";
            PNLBusqueda.Size = new Size(1263, 80);
            PNLBusqueda.TabIndex = 3;
            // 
            // BTNBusqueda
            // 
            BTNBusqueda.BackColor = SystemColors.ControlLight;
            BTNBusqueda.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNBusqueda.Location = new Point(857, 20);
            BTNBusqueda.Name = "BTNBusqueda";
            BTNBusqueda.Size = new Size(103, 31);
            BTNBusqueda.TabIndex = 2;
            BTNBusqueda.Text = "Buscar";
            BTNBusqueda.UseVisualStyleBackColor = false;
            // 
            // TXTBOXBusqueda
            // 
            TXTBOXBusqueda.Location = new Point(541, 22);
            TXTBOXBusqueda.Name = "TXTBOXBusqueda";
            TXTBOXBusqueda.Size = new Size(282, 27);
            TXTBOXBusqueda.TabIndex = 1;
            // 
            // LBLIsbn
            // 
            LBLIsbn.AutoSize = true;
            LBLIsbn.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLIsbn.Location = new Point(450, 22);
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
            PNLGestor.Size = new Size(1263, 79);
            PNLGestor.TabIndex = 2;
            // 
            // LBLGestor
            // 
            LBLGestor.AutoSize = true;
            LBLGestor.BackColor = Color.Transparent;
            LBLGestor.Font = new Font("Gill Sans MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLGestor.ForeColor = SystemColors.ButtonFace;
            LBLGestor.Location = new Point(541, 9);
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
            PNLDatos.Controls.Add(comboBox2);
            PNLDatos.Controls.Add(comboBox1);
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
            PNLDatos.Size = new Size(1263, 272);
            PNLDatos.TabIndex = 4;
            // 
            // TXTExsistencias
            // 
            TXTExsistencias.AutoSize = true;
            TXTExsistencias.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTExsistencias.Location = new Point(441, 235);
            TXTExsistencias.Name = "TXTExsistencias";
            TXTExsistencias.Size = new Size(100, 25);
            TXTExsistencias.TabIndex = 6;
            TXTExsistencias.Text = "Existencias";
            // 
            // TXTAnio
            // 
            TXTAnio.AutoSize = true;
            TXTAnio.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTAnio.Location = new Point(441, 199);
            TXTAnio.Name = "TXTAnio";
            TXTAnio.Size = new Size(45, 25);
            TXTAnio.TabIndex = 5;
            TXTAnio.Text = "Año";
            // 
            // TXTCategoria
            // 
            TXTCategoria.AutoSize = true;
            TXTCategoria.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTCategoria.Location = new Point(440, 164);
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
            TXTEditorial.Location = new Point(440, 129);
            TXTEditorial.Name = "TXTEditorial";
            TXTEditorial.Size = new Size(82, 25);
            TXTEditorial.TabIndex = 3;
            TXTEditorial.Text = "Editorial";
            // 
            // TXTAutor
            // 
            TXTAutor.AutoSize = true;
            TXTAutor.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTAutor.Location = new Point(441, 93);
            TXTAutor.Name = "TXTAutor";
            TXTAutor.Size = new Size(65, 25);
            TXTAutor.TabIndex = 2;
            TXTAutor.Text = "Autor ";
            // 
            // TXTTitulo
            // 
            TXTTitulo.AutoSize = true;
            TXTTitulo.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTTitulo.Location = new Point(440, 55);
            TXTTitulo.Name = "TXTTitulo";
            TXTTitulo.Size = new Size(66, 25);
            TXTTitulo.TabIndex = 1;
            TXTTitulo.Text = "Titulo ";
            // 
            // TXTIsbn1
            // 
            TXTIsbn1.AutoSize = true;
            TXTIsbn1.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTIsbn1.Location = new Point(441, 19);
            TXTIsbn1.Name = "TXTIsbn1";
            TXTIsbn1.Size = new Size(54, 25);
            TXTIsbn1.TabIndex = 0;
            TXTIsbn1.Text = "ISBN";
            TXTIsbn1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(TXTCancelar);
            panel1.Controls.Add(TXTEliminar);
            panel1.Controls.Add(TXTEditar);
            panel1.Controls.Add(TXTGuardar);
            panel1.Controls.Add(TXTNuevo);
            panel1.Location = new Point(365, 437);
            panel1.Name = "panel1";
            panel1.Size = new Size(679, 78);
            panel1.TabIndex = 5;
            // 
            // TXTCancelar
            // 
            TXTCancelar.BackColor = SystemColors.ActiveBorder;
            TXTCancelar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            TXTCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            TXTCancelar.IconColor = Color.Black;
            TXTCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TXTCancelar.Location = new Point(538, 17);
            TXTCancelar.Name = "TXTCancelar";
            TXTCancelar.Size = new Size(101, 40);
            TXTCancelar.TabIndex = 4;
            TXTCancelar.Text = "Cancelar";
            TXTCancelar.UseMnemonic = false;
            TXTCancelar.UseVisualStyleBackColor = false;
            // 
            // TXTEliminar
            // 
            TXTEliminar.BackColor = Color.Salmon;
            TXTEliminar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            TXTEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            TXTEliminar.IconColor = Color.Black;
            TXTEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TXTEliminar.Location = new Point(426, 17);
            TXTEliminar.Name = "TXTEliminar";
            TXTEliminar.Size = new Size(94, 40);
            TXTEliminar.TabIndex = 3;
            TXTEliminar.Text = "Eliminar";
            TXTEliminar.UseVisualStyleBackColor = false;
            // 
            // TXTEditar
            // 
            TXTEditar.BackColor = Color.Khaki;
            TXTEditar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            TXTEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            TXTEditar.IconColor = Color.Black;
            TXTEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TXTEditar.Location = new Point(301, 17);
            TXTEditar.Name = "TXTEditar";
            TXTEditar.Size = new Size(98, 40);
            TXTEditar.TabIndex = 2;
            TXTEditar.Text = "Editar";
            TXTEditar.UseVisualStyleBackColor = false;
            // 
            // TXTGuardar
            // 
            TXTGuardar.BackColor = Color.PaleGreen;
            TXTGuardar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            TXTGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            TXTGuardar.IconColor = Color.Black;
            TXTGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TXTGuardar.Location = new Point(172, 17);
            TXTGuardar.Name = "TXTGuardar";
            TXTGuardar.Size = new Size(103, 40);
            TXTGuardar.TabIndex = 1;
            TXTGuardar.Text = "Guardar";
            TXTGuardar.UseVisualStyleBackColor = false;
            // 
            // TXTNuevo
            // 
            TXTNuevo.BackColor = SystemColors.ActiveCaption;
            TXTNuevo.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TXTNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            TXTNuevo.IconColor = Color.Black;
            TXTNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            TXTNuevo.Location = new Point(41, 17);
            TXTNuevo.Name = "TXTNuevo";
            TXTNuevo.Size = new Size(104, 40);
            TXTNuevo.TabIndex = 0;
            TXTNuevo.Text = "Nuevo";
            TXTNuevo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 538);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1398, 320);
            dataGridView1.TabIndex = 6;
            // 
            // TXTBOXIsbn1
            // 
            TXTBOXIsbn1.Location = new Point(600, 17);
            TXTBOXIsbn1.Name = "TXTBOXIsbn1";
            TXTBOXIsbn1.Size = new Size(285, 27);
            TXTBOXIsbn1.TabIndex = 7;
            // 
            // TXTBOXTitulo
            // 
            TXTBOXTitulo.Location = new Point(600, 55);
            TXTBOXTitulo.Name = "TXTBOXTitulo";
            TXTBOXTitulo.Size = new Size(285, 27);
            TXTBOXTitulo.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(600, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 28);
            comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(600, 129);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(285, 28);
            comboBox2.TabIndex = 10;
            // 
            // TXTBOXGenero
            // 
            TXTBOXGenero.Location = new Point(600, 164);
            TXTBOXGenero.Name = "TXTBOXGenero";
            TXTBOXGenero.Size = new Size(285, 27);
            TXTBOXGenero.TabIndex = 11;
            // 
            // TXTBOXAnio
            // 
            TXTBOXAnio.Location = new Point(600, 199);
            TXTBOXAnio.Name = "TXTBOXAnio";
            TXTBOXAnio.Size = new Size(285, 27);
            TXTBOXAnio.TabIndex = 12;
            // 
            // TXTBOXExistencias
            // 
            TXTBOXExistencias.Location = new Point(600, 235);
            TXTBOXExistencias.Name = "TXTBOXExistencias";
            TXTBOXExistencias.Size = new Size(285, 27);
            TXTBOXExistencias.TabIndex = 13;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1263, 870);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PNLBusqueda;
        private Button BTNBusqueda;
        private TextBox TXTBOXBusqueda;
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
        private FontAwesome.Sharp.IconButton TXTNuevo;
        private FontAwesome.Sharp.IconButton TXTCancelar;
        private FontAwesome.Sharp.IconButton TXTEliminar;
        private FontAwesome.Sharp.IconButton TXTEditar;
        private FontAwesome.Sharp.IconButton TXTGuardar;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private TextBox TXTBOXTitulo;
        private TextBox TXTBOXIsbn1;
        private TextBox TXTBOXExistencias;
        private TextBox TXTBOXAnio;
        private TextBox TXTBOXGenero;
        private ComboBox comboBox2;
    }
}