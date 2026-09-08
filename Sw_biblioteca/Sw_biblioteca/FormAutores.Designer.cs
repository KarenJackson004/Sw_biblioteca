namespace Sw_biblioteca
{
    partial class FormAutores
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
            BTNEliminar = new FontAwesome.Sharp.IconButton();
            BTNEditar = new FontAwesome.Sharp.IconButton();
            BTNGuardar = new FontAwesome.Sharp.IconButton();
            BTNNuevo = new FontAwesome.Sharp.IconButton();
            TXTBOXApellido = new TextBox();
            TXTBOXNombre = new TextBox();
            LBLApellido = new Label();
            LBLNombre = new Label();
            PNLLista = new Panel();
            DGVAutores = new DataGridView();
            PNLTitulo.SuspendLayout();
            PNLDatos.SuspendLayout();
            PNLLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAutores).BeginInit();
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
            PNLTitulo.TabIndex = 0;
            // 
            // LBLTitulo
            // 
            LBLTitulo.AutoSize = true;
            LBLTitulo.BackColor = Color.Transparent;
            LBLTitulo.Font = new Font("Gill Sans MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLTitulo.ForeColor = SystemColors.ButtonFace;
            LBLTitulo.Location = new Point(451, 9);
            LBLTitulo.Name = "LBLTitulo";
            LBLTitulo.Size = new Size(442, 52);
            LBLTitulo.TabIndex = 1;
            LBLTitulo.Text = "GESTOR DE AUTORES";
            LBLTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PNLDatos
            // 
            PNLDatos.BackColor = Color.LightCyan;
            PNLDatos.Controls.Add(BTNCancelar);
            PNLDatos.Controls.Add(BTNEliminar);
            PNLDatos.Controls.Add(BTNEditar);
            PNLDatos.Controls.Add(BTNGuardar);
            PNLDatos.Controls.Add(BTNNuevo);
            PNLDatos.Controls.Add(TXTBOXApellido);
            PNLDatos.Controls.Add(TXTBOXNombre);
            PNLDatos.Controls.Add(LBLApellido);
            PNLDatos.Controls.Add(LBLNombre);
            PNLDatos.Dock = DockStyle.Top;
            PNLDatos.Location = new Point(0, 70);
            PNLDatos.Name = "PNLDatos";
            PNLDatos.Size = new Size(1348, 393);
            PNLDatos.TabIndex = 1;
            // 
            // BTNCancelar
            // 
            BTNCancelar.BackColor = SystemColors.ActiveBorder;
            BTNCancelar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            BTNCancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNCancelar.IconColor = Color.Black;
            BTNCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNCancelar.Location = new Point(821, 281);
            BTNCancelar.Name = "BTNCancelar";
            BTNCancelar.Size = new Size(101, 40);
            BTNCancelar.TabIndex = 9;
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
            BTNEliminar.Location = new Point(700, 281);
            BTNEliminar.Name = "BTNEliminar";
            BTNEliminar.Size = new Size(94, 40);
            BTNEliminar.TabIndex = 8;
            BTNEliminar.Text = "Eliminar";
            BTNEliminar.UseVisualStyleBackColor = false;
            BTNEliminar.Click += BTNEliminar_Click;
            // 
            // BTNEditar
            // 
            BTNEditar.BackColor = Color.Khaki;
            BTNEditar.Font = new Font("Gill Sans MT", 10.8F, FontStyle.Bold);
            BTNEditar.IconChar = FontAwesome.Sharp.IconChar.None;
            BTNEditar.IconColor = Color.Black;
            BTNEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTNEditar.Location = new Point(575, 281);
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
            BTNGuardar.Location = new Point(446, 281);
            BTNGuardar.Name = "BTNGuardar";
            BTNGuardar.Size = new Size(103, 40);
            BTNGuardar.TabIndex = 6;
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
            BTNNuevo.Location = new Point(317, 281);
            BTNNuevo.Name = "BTNNuevo";
            BTNNuevo.Size = new Size(104, 40);
            BTNNuevo.TabIndex = 5;
            BTNNuevo.Text = "Nuevo";
            BTNNuevo.UseVisualStyleBackColor = false;
            BTNNuevo.Click += BTNNuevo_Click;
            // 
            // TXTBOXApellido
            // 
            TXTBOXApellido.Location = new Point(575, 169);
            TXTBOXApellido.Name = "TXTBOXApellido";
            TXTBOXApellido.Size = new Size(230, 27);
            TXTBOXApellido.TabIndex = 3;
            // 
            // TXTBOXNombre
            // 
            TXTBOXNombre.Location = new Point(575, 97);
            TXTBOXNombre.Name = "TXTBOXNombre";
            TXTBOXNombre.Size = new Size(230, 27);
            TXTBOXNombre.TabIndex = 2;
            // 
            // LBLApellido
            // 
            LBLApellido.AutoSize = true;
            LBLApellido.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLApellido.Location = new Point(350, 169);
            LBLApellido.Name = "LBLApellido";
            LBLApellido.Size = new Size(102, 29);
            LBLApellido.TabIndex = 1;
            LBLApellido.Text = "Apellido: ";
            // 
            // LBLNombre
            // 
            LBLNombre.AutoSize = true;
            LBLNombre.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLNombre.Location = new Point(350, 95);
            LBLNombre.Name = "LBLNombre";
            LBLNombre.Size = new Size(98, 29);
            LBLNombre.TabIndex = 0;
            LBLNombre.Text = "Nombre:";
            LBLNombre.Click += label1_Click;
            // 
            // PNLLista
            // 
            PNLLista.BackColor = SystemColors.ButtonFace;
            PNLLista.Controls.Add(DGVAutores);
            PNLLista.Dock = DockStyle.Fill;
            PNLLista.Location = new Point(0, 463);
            PNLLista.Name = "PNLLista";
            PNLLista.Size = new Size(1348, 496);
            PNLLista.TabIndex = 2;
            // 
            // DGVAutores
            // 
            DGVAutores.AllowUserToAddRows = false;
            DGVAutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAutores.Dock = DockStyle.Fill;
            DGVAutores.Location = new Point(0, 0);
            DGVAutores.MultiSelect = false;
            DGVAutores.Name = "DGVAutores";
            DGVAutores.ReadOnly = true;
            DGVAutores.RowHeadersWidth = 51;
            DGVAutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVAutores.Size = new Size(1348, 496);
            DGVAutores.TabIndex = 0;
            DGVAutores.CellDoubleClick += DGVAutores_CellDoubleClick;
            // 
            // FormAutores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 959);
            Controls.Add(PNLLista);
            Controls.Add(PNLDatos);
            Controls.Add(PNLTitulo);
            Name = "FormAutores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAutores";
            WindowState = FormWindowState.Maximized;
            PNLTitulo.ResumeLayout(false);
            PNLTitulo.PerformLayout();
            PNLDatos.ResumeLayout(false);
            PNLDatos.PerformLayout();
            PNLLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVAutores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PNLTitulo;
        private Panel PNLDatos;
        private Panel PNLLista;
        private Label LBLTitulo;
        private Label LBLNombre;
        private TextBox TXTBOXApellido;
        private TextBox TXTBOXNombre;
        private Label LBLApellido;
        private FontAwesome.Sharp.IconButton BTNCancelar;
        private FontAwesome.Sharp.IconButton BTNEliminar;
        private FontAwesome.Sharp.IconButton BTNEditar;
        private FontAwesome.Sharp.IconButton BTNGuardar;
        private FontAwesome.Sharp.IconButton BTNNuevo;
        private DataGridView DGVAutores;
    }
}