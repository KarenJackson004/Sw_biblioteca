namespace Sw_biblioteca
{
    public partial class PPLWin : Form
    {
        public PPLWin()
        {
            InitializeComponent();
        }

        private void AbrirFormulario(Form formulario)


        {
            PNLContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            PNLContenido.Controls.Add(formulario);
            formulario.Show();
        }

        private void BTNInicio_Click_1(object sender, EventArgs e)

        {
            AbrirFormulario(new FormInicio());
        }

        private void BTNLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormLibros());
        }

        private void BTNUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormUsuario());
        }

        private void BTNAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormAutores());
        }

        private void BTNGeneros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormGeneros());
        }

        private void BTNPrestamos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormPrestamos());
        }

        private void BTNDevoluciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormDevoluciones());
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PNLContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
