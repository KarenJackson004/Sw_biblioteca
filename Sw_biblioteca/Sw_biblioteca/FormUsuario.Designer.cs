namespace Sw_biblioteca
{
    partial class FormUsuario
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
            PNLTitulo = new Panel();
            LBLTitulo = new Label();
            PNLDatos = new Panel();
            BTNCancelar = new FontAwesome.Sharp.IconButton();
            TXTBOXCorreo = new TextBox();
            BTNEliminar = new FontAwesome.Sharp.IconButton();
            TXTBOXTelefono = new TextBox();
            BTNEditar = new FontAwesome.Sharp.IconButton();
            BTNGuardar = new FontAwesome.Sharp.IconButton();
            TXTBOXDocumento = new TextBox();
            BTNNuevo = new FontAwesome.Sharp.IconButton();
            TXTBOXApellido = new TextBox();
            TXTBOXNombre = new TextBox();
            TXTCorreo = new Label();
            TXTTelefono = new Label();
            TXTDocumento = new Label();
            TXTApellido = new Label();
            TXTNombre = new Label();
            panel1 = new Panel();
            DGVUsuarios = new DataGridView();
            PNLTitulo.SuspendLayout();
            PNLDatos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).BeginInit();
            SuspendLayout();
            // 
            // PNLTitulo
            // 
            PNLTitulo.BackColor = Color.MediumSeaGreen;
            PNLTitulo.Controls.Add(LBLTitulo);
            PNLTitulo.Dock = DockStyle.Top;
            PNLTitulo.Location = new Point(0, 0);
            PNLTitulo.Name = "PNLTitulo";
            PNLTitulo.Size = new Size(1348, 70);
            PNLTitulo.TabIndex = 4;
            // 
            // LBLTitulo
            // 
            LBLTitulo.AutoSize = true;
            LBLTitulo.BackColor = Color.Transparent;
            LBLTitulo.Font = new Font("Gill Sans MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLTitulo.ForeColor = SystemColors.ButtonFace;
            LBLTitulo.Location = new Point(451, 9);
            LBLTitulo.Name = "LBLTitulo";
            LBLTitulo.Size = new Size(456, 52);
            LBLTitulo.TabIndex = 1;
            LBLTitulo.Text = "GESTOR DE USUARIOS";
            LBLTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PNLDatos
            // 
            PNLDatos.BackColor = Color.Linen;
            PNLDatos.Controls.Add(BTNCancelar);
            PNLDatos.Controls.Add(TXTBOXCorreo);
            PNLDatos.Controls.Add(BTNEliminar);
            PNLDatos.Controls.Add(TXTBOXTelefono);
            PNLDatos.Controls.Add(BTNEditar);
            PNLDatos.Controls.Add(BTNGuardar);
            PNLDatos.Controls.Add(TXTBOXDocumento);
            PNLDatos.Controls.Add(BTNNuevo);
            PNLDatos.Controls.Add(TXTBOXApellido);
            PNLDatos.Controls.Add(TXTBOXNombre);
            PNLDatos.Controls.Add(TXTCorreo);
            PNLDatos.Controls.Add(TXTTelefono);
            PNLDatos.Controls.Add(TXTDocumento);
            PNLDatos.Controls.Add(TXTApellido);
            PNLDatos.Controls.Add(TXTNombre);
            PNLDatos.Dock = DockStyle.Top;
            PNLDatos.Location = new Point(0, 70);
            PNLDatos.Name = "PNLDatos";
            PNLDatos.Size = new Size(1348, 339);
            PNLDatos.TabIndex = 5;
            // 
            // BTNCancelar
            // 
            BTNCancelar.BackColor = SystemColors.ActiveBorder;
            BTNCancelar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            BTNCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNCancelar.IconColor = Color.Black;
            BTNCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNCancelar.Location = new Point(851, 261);
            BTNCancelar.Name = "BTNCancelar";
            BTNCancelar.Size = new Size(101, 40);
            BTNCancelar.TabIndex = 9;
            BTNCancelar.Text = "Cancelar";
            BTNCancelar.UseMnemonic = false;
            BTNCancelar.UseVisualStyleBackColor = false;
            BTNCancelar.Click += BTNCancelar_Click;
            // 
            // TXTBOXCorreo
            // 
            TXTBOXCorreo.Location = new Point(570, 190);
            TXTBOXCorreo.Name = "TXTBOXCorreo";
            TXTBOXCorreo.Size = new Size(285, 27);
            TXTBOXCorreo.TabIndex = 13;
            // 
            // BTNEliminar
            // 
            BTNEliminar.BackColor = Color.Salmon;
            BTNEliminar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            BTNEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNEliminar.IconColor = Color.Black;
            BTNEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNEliminar.Location = new Point(730, 261);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Size = new Size(94, 40);
            BTNEliminar.TabIndex = 8;
            BTNEliminar.Text = "Eliminar";
            BTNEliminar.UseVisualStyleBackColor = false;
            BTNEliminar.Click += BTNEliminar_Click;
            // 
            // TXTBOXTelefono
            // 
            TXTBOXTelefono.Location = new Point(570, 154);
            TXTBOXTelefono.Name = "TXTBOXTelefono";
            TXTBOXTelefono.Size = new Size(285, 27);
            TXTBOXTelefono.TabIndex = 12;
            // 
            // BTNEditar
            // 
            BTNEditar.BackColor = Color.Khaki;
            BTNEditar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            BTNEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNEditar.IconColor = Color.Black;
            BTNEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNEditar.Location = new Point(605, 261);
            BTNEditar.Name = "BTNEditar";
            BTNEditar.Size = new Size(98, 40);
            BTNEditar.TabIndex = 7;
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
            BTNGuardar.Location = new Point(476, 261);
            BTNGuardar.Name = "BTNGuardar";
            BTNGuardar.Size = new Size(103, 40);
            BTNGuardar.TabIndex = 6;
            BTNGuardar.Text = "Guardar";
            BTNGuardar.UseVisualStyleBackColor = false;
            BTNGuardar.Click += BTNGuardar_Click;
            // 
            // TXTBOXDocumento
            // 
            TXTBOXDocumento.Location = new Point(570, 119);
            TXTBOXDocumento.Name = "TXTBOXDocumento";
            TXTBOXDocumento.Size = new Size(285, 27);
            TXTBOXDocumento.TabIndex = 11;
            // 
            // BTNNuevo
            // 
            BTNNuevo.BackColor = SystemColors.ActiveCaption;
            BTNNuevo.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNNuevo.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNNuevo.IconColor = Color.Black;
            BTNNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNNuevo.Location = new Point(347, 261);
            BTNNuevo.Name = "BTNNuevo";
            BTNNuevo.Size = new Size(104, 40);
            BTNNuevo.TabIndex = 5;
            BTNNuevo.Text = "Nuevo";
            BTNNuevo.UseVisualStyleBackColor = false;
            BTNNuevo.Click += BTNNuevo_Click;
            // 
            // TXTBOXApellido
            // 
            TXTBOXApellido.Location = new Point(570, 80);
            TXTBOXApellido.Name = "TXTBOXApellido";
            TXTBOXApellido.Size = new Size(285, 27);
            TXTBOXApellido.TabIndex = 8;
            // 
            // TXTBOXNombre
            // 
            TXTBOXNombre.Location = new Point(570, 42);
            TXTBOXNombre.Name = "TXTBOXNombre";
            TXTBOXNombre.Size = new Size(285, 27);
            TXTBOXNombre.TabIndex = 7;
            // 
            // TXTCorreo
            // 
            TXTCorreo.AutoSize = true;
            TXTCorreo.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTCorreo.Location = new Point(410, 189);
            TXTCorreo.Name = "TXTCorreo";
            TXTCorreo.Size = new Size(70, 25);
            TXTCorreo.TabIndex = 4;
            TXTCorreo.Text = "Correo";
            // 
            // TXTTelefono
            // 
            TXTTelefono.AutoSize = true;
            TXTTelefono.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTTelefono.Location = new Point(410, 154);
            TXTTelefono.Name = "TXTTelefono";
            TXTTelefono.Size = new Size(92, 25);
            TXTTelefono.TabIndex = 3;
            TXTTelefono.Text = "Teléfono: ";
            // 
            // TXTDocumento
            // 
            TXTDocumento.AutoSize = true;
            TXTDocumento.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTDocumento.Location = new Point(411, 118);
            TXTDocumento.Name = "TXTDocumento";
            TXTDocumento.Size = new Size(117, 25);
            TXTDocumento.TabIndex = 2;
            TXTDocumento.Text = "Documento: ";
            // 
            // TXTApellido
            // 
            TXTApellido.AutoSize = true;
            TXTApellido.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTApellido.Location = new Point(410, 80);
            TXTApellido.Name = "TXTApellido";
            TXTApellido.Size = new Size(84, 25);
            TXTApellido.TabIndex = 1;
            TXTApellido.Text = "Apellido:";
            // 
            // TXTNombre
            // 
            TXTNombre.AutoSize = true;
            TXTNombre.Font = new Font("Gill Sans MT", 10.2F, FontStyle.Bold);
            TXTNombre.Location = new Point(411, 44);
            TXTNombre.Name = "TXTNombre";
            TXTNombre.Size = new Size(84, 25);
            TXTNombre.TabIndex = 0;
            TXTNombre.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(DGVUsuarios);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 409);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 550);
            panel1.TabIndex = 6;
            // 
            // DGVUsuarios
            // 
            DGVUsuarios.AllowUserToAddRows = false;
            DGVUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsuarios.Dock = DockStyle.Fill;
            DGVUsuarios.Location = new Point(0, 0);
            DGVUsuarios.MultiSelect = false;
            DGVUsuarios.Name = "DGVUsuarios";
            DGVUsuarios.ReadOnly = true;
            DGVUsuarios.RowHeadersWidth = 51;
            DGVUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVUsuarios.Size = new Size(1348, 550);
            DGVUsuarios.TabIndex = 1;
            DGVUsuarios.CellDoubleClick += DGVUsuarios_CellDoubleClick;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 959);
            Controls.Add(panel1);
            Controls.Add(PNLDatos);
            Controls.Add(PNLTitulo);
            Name = "FormUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUsuario";
            WindowState = FormWindowState.Maximized;
            PNLTitulo.ResumeLayout(false);
            PNLTitulo.PerformLayout();
            PNLDatos.ResumeLayout(false);
            PNLDatos.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PNLTitulo;
        private Label LBLTitulo;
        private Panel PNLDatos;
        private TextBox TXTBOXCorreo;
        private TextBox TXTBOXTelefono;
        private TextBox TXTBOXDocumento;
        private TextBox TXTBOXApellido;
        private TextBox TXTBOXNombre;
        private Label TXTCorreo;
        private Label TXTTelefono;
        private Label TXTDocumento;
        private Label TXTApellido;
        private Label TXTNombre;
        private Panel panel1;
        private DataGridView DGVUsuarios;
        private FontAwesome.Sharp.IconButton BTNCancelar;
        private FontAwesome.Sharp.IconButton BTNEliminar;
        private FontAwesome.Sharp.IconButton BTNEditar;
        private FontAwesome.Sharp.IconButton BTNGuardar;
        private FontAwesome.Sharp.IconButton BTNNuevo;
    }
}