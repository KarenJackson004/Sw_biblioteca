namespace Sw_biblioteca
{
    partial class PPLWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPLWin));
            PNLMenu = new Panel();
            BTNExit = new Button();
            BTNInicio = new Button();
            BTNPrestamos = new Button();
            BTNLibros = new Button();
            BTNDevoluciones = new Button();
            BTNEditoriales = new Button();
            BTNAutores = new Button();
            BTNUsuario = new Button();
            PNLLogo = new Panel();
            LBLTitulo = new Label();
            PNGLogo = new PictureBox();
            PNLSuperior = new Panel();
            PNLEstado = new Panel();
            PNLContenido = new Panel();
            PNLMenu.SuspendLayout();
            PNLLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PNGLogo).BeginInit();
            SuspendLayout();
            // 
            // PNLMenu
            // 
            PNLMenu.BackColor = Color.OldLace;
            PNLMenu.Controls.Add(BTNExit);
            PNLMenu.Controls.Add(BTNInicio);
            PNLMenu.Controls.Add(BTNPrestamos);
            PNLMenu.Controls.Add(BTNLibros);
            PNLMenu.Controls.Add(BTNDevoluciones);
            PNLMenu.Controls.Add(BTNEditoriales);
            PNLMenu.Controls.Add(BTNAutores);
            PNLMenu.Controls.Add(BTNUsuario);
            PNLMenu.Controls.Add(PNLLogo);
            PNLMenu.Dock = DockStyle.Left;
            PNLMenu.Location = new Point(0, 0);
            PNLMenu.Name = "PNLMenu";
            PNLMenu.Size = new Size(285, 620);
            PNLMenu.TabIndex = 0;
            // 
            // BTNExit
            // 
            BTNExit.BackColor = Color.Transparent;
            BTNExit.Cursor = Cursors.Hand;
            BTNExit.FlatAppearance.BorderSize = 0;
            BTNExit.FlatStyle = FlatStyle.Flat;
            BTNExit.Image = (Image)resources.GetObject("BTNExit.Image");
            BTNExit.Location = new Point(111, 546);
            BTNExit.Name = "BTNExit";
            BTNExit.Size = new Size(56, 65);
            BTNExit.TabIndex = 12;
            BTNExit.UseVisualStyleBackColor = false;
            BTNExit.Click += BTNExit_Click;
            // 
            // BTNInicio
            // 
            BTNInicio.AutoSize = true;
            BTNInicio.BackColor = Color.YellowGreen;
            BTNInicio.BackgroundImageLayout = ImageLayout.None;
            BTNInicio.FlatAppearance.BorderSize = 0;
            BTNInicio.FlatStyle = FlatStyle.Flat;
            BTNInicio.Font = new Font("Gill Sans MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNInicio.ForeColor = Color.Black;
            BTNInicio.Image = (Image)resources.GetObject("BTNInicio.Image");
            BTNInicio.ImageAlign = ContentAlignment.MiddleRight;
            BTNInicio.Location = new Point(0, 187);
            BTNInicio.Margin = new Padding(2);
            BTNInicio.Name = "BTNInicio";
            BTNInicio.RightToLeft = RightToLeft.No;
            BTNInicio.Size = new Size(293, 46);
            BTNInicio.TabIndex = 11;
            BTNInicio.Text = "Inicio";
            BTNInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNInicio.UseVisualStyleBackColor = false;
            BTNInicio.Click += BTNInicio_Click_1;
            // 
            // BTNPrestamos
            // 
            BTNPrestamos.BackColor = Color.YellowGreen;
            BTNPrestamos.FlatAppearance.BorderSize = 0;
            BTNPrestamos.FlatStyle = FlatStyle.Flat;
            BTNPrestamos.Font = new Font("Gill Sans MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNPrestamos.ForeColor = Color.Black;
            BTNPrestamos.Image = (Image)resources.GetObject("BTNPrestamos.Image");
            BTNPrestamos.ImageAlign = ContentAlignment.MiddleRight;
            BTNPrestamos.Location = new Point(-9, 443);
            BTNPrestamos.Margin = new Padding(2);
            BTNPrestamos.Name = "BTNPrestamos";
            BTNPrestamos.Size = new Size(300, 49);
            BTNPrestamos.TabIndex = 3;
            BTNPrestamos.Text = "Préstamos";
            BTNPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNPrestamos.UseVisualStyleBackColor = false;
            BTNPrestamos.Click += BTNPrestamos_Click_1;
            // 
            // BTNLibros
            // 
            BTNLibros.BackColor = Color.YellowGreen;
            BTNLibros.FlatAppearance.BorderSize = 0;
            BTNLibros.FlatStyle = FlatStyle.Flat;
            BTNLibros.Font = new Font("Gill Sans MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNLibros.ForeColor = Color.Black;
            BTNLibros.Image = Properties.Resources.books_1901210;
            BTNLibros.ImageAlign = ContentAlignment.MiddleRight;
            BTNLibros.Location = new Point(0, 236);
            BTNLibros.Margin = new Padding(2);
            BTNLibros.Name = "BTNLibros";
            BTNLibros.Size = new Size(285, 49);
            BTNLibros.TabIndex = 8;
            BTNLibros.Text = "Libros";
            BTNLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNLibros.UseVisualStyleBackColor = false;
            BTNLibros.Click += BTNLibros_Click;
            // 
            // BTNDevoluciones
            // 
            BTNDevoluciones.BackColor = Color.YellowGreen;
            BTNDevoluciones.FlatAppearance.BorderSize = 0;
            BTNDevoluciones.FlatStyle = FlatStyle.Flat;
            BTNDevoluciones.Font = new Font("Gill Sans MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNDevoluciones.ForeColor = Color.Black;
            BTNDevoluciones.Image = (Image)resources.GetObject("BTNDevoluciones.Image");
            BTNDevoluciones.ImageAlign = ContentAlignment.MiddleRight;
            BTNDevoluciones.Location = new Point(-2, 496);
            BTNDevoluciones.Margin = new Padding(2);
            BTNDevoluciones.Name = "BTNDevoluciones";
            BTNDevoluciones.Size = new Size(290, 49);
            BTNDevoluciones.TabIndex = 7;
            BTNDevoluciones.Text = "Devoluciones";
            BTNDevoluciones.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNDevoluciones.UseVisualStyleBackColor = false;
            BTNDevoluciones.Click += BTNDevoluciones_Click;
            // 
            // BTNEditoriales
            // 
            BTNEditoriales.BackColor = Color.YellowGreen;
            BTNEditoriales.FlatAppearance.BorderSize = 0;
            BTNEditoriales.FlatStyle = FlatStyle.Flat;
            BTNEditoriales.Font = new Font("Gill Sans MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNEditoriales.ForeColor = Color.Black;
            BTNEditoriales.Image = (Image)resources.GetObject("BTNEditoriales.Image");
            BTNEditoriales.ImageAlign = ContentAlignment.MiddleRight;
            BTNEditoriales.Location = new Point(-2, 390);
            BTNEditoriales.Margin = new Padding(2);
            BTNEditoriales.Name = "BTNEditoriales";
            BTNEditoriales.Size = new Size(294, 49);
            BTNEditoriales.TabIndex = 5;
            BTNEditoriales.Text = "Editoriales";
            BTNEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNEditoriales.UseVisualStyleBackColor = false;
            BTNEditoriales.Click += BTNGeneros_Click;
            // 
            // BTNAutores
            // 
            BTNAutores.BackColor = Color.YellowGreen;
            BTNAutores.FlatAppearance.BorderSize = 0;
            BTNAutores.FlatStyle = FlatStyle.Flat;
            BTNAutores.Font = new Font("Gill Sans MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNAutores.ForeColor = Color.Black;
            BTNAutores.Image = (Image)resources.GetObject("BTNAutores.Image");
            BTNAutores.ImageAlign = ContentAlignment.MiddleRight;
            BTNAutores.Location = new Point(-9, 339);
            BTNAutores.Margin = new Padding(0);
            BTNAutores.Name = "BTNAutores";
            BTNAutores.Size = new Size(305, 49);
            BTNAutores.TabIndex = 4;
            BTNAutores.Text = "Autores";
            BTNAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNAutores.UseVisualStyleBackColor = false;
            BTNAutores.Click += BTNAutores_Click;
            // 
            // BTNUsuario
            // 
            BTNUsuario.BackColor = Color.YellowGreen;
            BTNUsuario.FlatAppearance.BorderSize = 0;
            BTNUsuario.FlatStyle = FlatStyle.Flat;
            BTNUsuario.Font = new Font("Gill Sans MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNUsuario.ForeColor = Color.Black;
            BTNUsuario.Image = (Image)resources.GetObject("BTNUsuario.Image");
            BTNUsuario.ImageAlign = ContentAlignment.MiddleRight;
            BTNUsuario.Location = new Point(0, 288);
            BTNUsuario.Margin = new Padding(2);
            BTNUsuario.Name = "BTNUsuario";
            BTNUsuario.Size = new Size(285, 49);
            BTNUsuario.TabIndex = 3;
            BTNUsuario.Text = "Usuario";
            BTNUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNUsuario.UseVisualStyleBackColor = false;
            BTNUsuario.Click += BTNUsuario_Click;
            // 
            // PNLLogo
            // 
            PNLLogo.BackColor = Color.Olive;
            PNLLogo.Controls.Add(LBLTitulo);
            PNLLogo.Controls.Add(PNGLogo);
            PNLLogo.Location = new Point(0, 0);
            PNLLogo.Name = "PNLLogo";
            PNLLogo.Size = new Size(285, 184);
            PNLLogo.TabIndex = 0;
            // 
            // LBLTitulo
            // 
            LBLTitulo.AutoSize = true;
            LBLTitulo.BackColor = Color.Transparent;
            LBLTitulo.Font = new Font("Gill Sans MT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBLTitulo.ForeColor = SystemColors.ControlLightLight;
            LBLTitulo.Location = new Point(12, 9);
            LBLTitulo.Name = "LBLTitulo";
            LBLTitulo.Size = new Size(261, 42);
            LBLTitulo.TabIndex = 0;
            LBLTitulo.Text = "SG BIBLIOTECA";
            LBLTitulo.Click += LBLTitulo_Click;
            // 
            // PNGLogo
            // 
            PNGLogo.BackColor = Color.Transparent;
            PNGLogo.Image = (Image)resources.GetObject("PNGLogo.Image");
            PNGLogo.Location = new Point(-4, 36);
            PNGLogo.Name = "PNGLogo";
            PNGLogo.Size = new Size(286, 169);
            PNGLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PNGLogo.TabIndex = 1;
            PNGLogo.TabStop = false;
            // 
            // PNLSuperior
            // 
            PNLSuperior.BackColor = Color.DarkOliveGreen;
            PNLSuperior.Dock = DockStyle.Top;
            PNLSuperior.Location = new Point(285, 0);
            PNLSuperior.Name = "PNLSuperior";
            PNLSuperior.Size = new Size(996, 125);
            PNLSuperior.TabIndex = 1;
            // 
            // PNLEstado
            // 
            PNLEstado.BackColor = Color.DarkKhaki;
            PNLEstado.Dock = DockStyle.Bottom;
            PNLEstado.Location = new Point(285, 570);
            PNLEstado.Name = "PNLEstado";
            PNLEstado.Size = new Size(996, 50);
            PNLEstado.TabIndex = 2;
            // 
            // PNLContenido
            // 
            PNLContenido.BackColor = Color.LemonChiffon;
            PNLContenido.BorderStyle = BorderStyle.FixedSingle;
            PNLContenido.Dock = DockStyle.Fill;
            PNLContenido.Location = new Point(285, 125);
            PNLContenido.Name = "PNLContenido";
            PNLContenido.Size = new Size(996, 445);
            PNLContenido.TabIndex = 3;
            PNLContenido.Paint += PNLContenido_Paint;
            // 
            // PPLWin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1281, 620);
            Controls.Add(PNLContenido);
            Controls.Add(PNLEstado);
            Controls.Add(PNLSuperior);
            Controls.Add(PNLMenu);
            Name = "PPLWin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SG Biblioteca";
            WindowState = FormWindowState.Maximized;
            PNLMenu.ResumeLayout(false);
            PNLMenu.PerformLayout();
            PNLLogo.ResumeLayout(false);
            PNLLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PNGLogo).EndInit();
            ResumeLayout(false);
        }

        private void PNLContenido_Paint_1(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LBLTitulo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BTNInicio_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BTNPrestamos_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel PNLMenu;
        private Panel PNLSuperior;
        private Panel PNLEstado;
        private Panel PNLLogo;
        private Label LBLTitulo;
        private PictureBox PNGLogo;
        private Button BTNUsuario;
        private Button BTNAutores;
        private Button BTNEditoriales;
        private Button BTNDevoluciones;
        private Panel PNLContenido;
        private Button BTNLibros;
        private Button BTNPrestamos;
        private Button BTNInicio;
        private Button BTNExit;
    }
}
