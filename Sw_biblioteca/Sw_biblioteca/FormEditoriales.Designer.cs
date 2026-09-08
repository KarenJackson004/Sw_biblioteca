namespace Sw_biblioteca
{
    partial class FormEditoriales
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
            PNLLista = new Panel();
            DGVEditoriales = new DataGridView();
            PNLDatos = new Panel();
            BTNCancelar = new FontAwesome.Sharp.IconButton();
            BTNEliminar = new FontAwesome.Sharp.IconButton();
            BTNEditar = new FontAwesome.Sharp.IconButton();
            BTNGuardar = new FontAwesome.Sharp.IconButton();
            BTNNuevo = new FontAwesome.Sharp.IconButton();
            TXTBOXNombre = new TextBox();
            LBLNombre = new Label();
            PNLTitulo = new Panel();
            LBLTitulo = new Label();
            PNLLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVEditoriales).BeginInit();
            PNLDatos.SuspendLayout();
            PNLTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // PNLLista
            // 
            PNLLista.BackColor = SystemColors.ButtonFace;
            PNLLista.Controls.Add(DGVEditoriales);
            PNLLista.Dock = DockStyle.Fill;
            PNLLista.Location = new Point(0, 463);
            PNLLista.Name = "PNLLista";
            PNLLista.Size = new Size(1348, 496);
            PNLLista.TabIndex = 5;
            // 
            // DGVEditoriales
            // 
            DGVEditoriales.AllowUserToAddRows = false;
            DGVEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVEditoriales.Dock = DockStyle.Fill;
            DGVEditoriales.Location = new Point(0, 0);
            DGVEditoriales.MultiSelect = false;
            DGVEditoriales.Name = "DGVEditoriales";
            DGVEditoriales.ReadOnly = true;
            DGVEditoriales.RowHeadersWidth = 51;
            DGVEditoriales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVEditoriales.Size = new Size(1348, 496);
            DGVEditoriales.TabIndex = 0;
            DGVEditoriales.CellDoubleClick += DGVEditoriales_CellDoubleClick;
            // 
            // PNLDatos
            // 
            PNLDatos.BackColor = Color.LightCyan;
            PNLDatos.Controls.Add(BTNCancelar);
            PNLDatos.Controls.Add(BTNEliminar);
            PNLDatos.Controls.Add(BTNEditar);
            PNLDatos.Controls.Add(BTNGuardar);
            PNLDatos.Controls.Add(BTNNuevo);
            PNLDatos.Controls.Add(TXTBOXNombre);
            PNLDatos.Controls.Add(LBLNombre);
            PNLDatos.Dock = DockStyle.Top;
            PNLDatos.Location = new Point(0, 70);
            PNLDatos.Name = "PNLDatos";
            PNLDatos.Size = new Size(1348, 393);
            PNLDatos.TabIndex = 4;
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
            BTNNuevo.Click += BTNNuevo_Click_1;
            // 
            // TXTBOXNombre
            // 
            TXTBOXNombre.Location = new Point(575, 133);
            TXTBOXNombre.Name = "TXTBOXNombre";
            TXTBOXNombre.Size = new Size(271, 27);
            TXTBOXNombre.TabIndex = 2;
            // 
            // LBLNombre
            // 
            LBLNombre.AutoSize = true;
            LBLNombre.Font = new Font("Gill Sans MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLNombre.Location = new Point(354, 133);
            LBLNombre.Name = "LBLNombre";
            LBLNombre.Size = new Size(112, 33);
            LBLNombre.TabIndex = 0;
            LBLNombre.Text = "Nombre:";
            // 
            // PNLTitulo
            // 
            PNLTitulo.BackColor = Color.MediumSeaGreen;
            PNLTitulo.Controls.Add(LBLTitulo);
            PNLTitulo.Dock = DockStyle.Top;
            PNLTitulo.Location = new Point(0, 0);
            PNLTitulo.Name = "PNLTitulo";
            PNLTitulo.Size = new Size(1348, 70);
            PNLTitulo.TabIndex = 3;
            // 
            // LBLTitulo
            // 
            LBLTitulo.AutoSize = true;
            LBLTitulo.BackColor = Color.Transparent;
            LBLTitulo.Font = new Font("Gill Sans MT", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLTitulo.ForeColor = SystemColors.ButtonFace;
            LBLTitulo.Location = new Point(451, 9);
            LBLTitulo.Name = "LBLTitulo";
            LBLTitulo.Size = new Size(512, 52);
            LBLTitulo.TabIndex = 1;
            LBLTitulo.Text = "GESTOR DE EDITORIALES";
            LBLTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormEditoriales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 959);
            Controls.Add(PNLLista);
            Controls.Add(PNLDatos);
            Controls.Add(PNLTitulo);
            Name = "FormEditoriales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGeneros";
            WindowState = FormWindowState.Maximized;
            PNLLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVEditoriales).EndInit();
            PNLDatos.ResumeLayout(false);
            PNLDatos.PerformLayout();
            PNLTitulo.ResumeLayout(false);
            PNLTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PNLLista;
        private DataGridView DGVEditoriales;
        private Panel PNLDatos;
        private FontAwesome.Sharp.IconButton BTNCancelar;
        private FontAwesome.Sharp.IconButton BTNEliminar;
        private FontAwesome.Sharp.IconButton BTNEditar;
        private FontAwesome.Sharp.IconButton BTNGuardar;
        private FontAwesome.Sharp.IconButton BTNNuevo;
        private TextBox TXTBOXNombre;
        private Label LBLNombre;
        private Panel PNLTitulo;
        private Label LBLTitulo;
    }
}