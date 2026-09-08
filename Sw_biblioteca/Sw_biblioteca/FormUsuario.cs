using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SwBiblioteca.Datos;

namespace Sw_biblioteca
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
            CargarUsuarios();

        }

        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Usuarios";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        DGVUsuarios.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            TXTBOXNombre.Clear();
            TXTBOXApellido.Clear();
            TXTBOXDocumento.Clear();
            TXTBOXTelefono.Clear();
            TXTBOXCorreo.Clear();

            TXTBOXNombre.Focus();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTBOXNombre.Text) ||
                string.IsNullOrWhiteSpace(TXTBOXApellido.Text) ||
                string.IsNullOrWhiteSpace(TXTBOXDocumento.Text) ||
                string.IsNullOrWhiteSpace(TXTBOXTelefono.Text) ||
                string.IsNullOrWhiteSpace(TXTBOXCorreo.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de guardar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "INSERT INTO Usuarios " +
                    "(Nombre, Apellido, Documento, Telefono, Correo) " +
                    "VALUES " +
                    "(@Nombre, @Apellido, @Documento, @Telefono, @Correo)";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@Nombre", TXTBOXNombre.Text.Trim());
                    comando.Parameters.AddWithValue("@Apellido", TXTBOXApellido.Text.Trim());
                    comando.Parameters.AddWithValue("@Documento", TXTBOXDocumento.Text.Trim());
                    comando.Parameters.AddWithValue("@Telefono", TXTBOXTelefono.Text.Trim());
                    comando.Parameters.AddWithValue("@Correo", TXTBOXCorreo.Text.Trim());

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario guardado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            BTNNuevo_Click(null, null);
        }

        private void BTNEditar_Click(object sender, EventArgs e)
        {
            if (DGVUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                DGVUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            if (string.IsNullOrWhiteSpace(TXTBOXNombre.Text) ||
                string.IsNullOrWhiteSpace(TXTBOXApellido.Text) ||
                string.IsNullOrWhiteSpace(TXTBOXDocumento.Text) ||
                string.IsNullOrWhiteSpace(TXTBOXTelefono.Text) ||
                string.IsNullOrWhiteSpace(TXTBOXCorreo.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "UPDATE Usuarios SET " +
                    "Nombre = @Nombre, " +
                    "Apellido = @Apellido, " +
                    "Documento = @Documento, " +
                    "Telefono = @Telefono, " +
                    "Correo = @Correo " +
                    "WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        TXTBOXNombre.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Apellido",
                        TXTBOXApellido.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Documento",
                        TXTBOXDocumento.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Telefono",
                        TXTBOXTelefono.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Correo",
                        TXTBOXCorreo.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@IdUsuario",
                        idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario actualizado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            BTNNuevo_Click(null, null);
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            if (DGVUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para eliminar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                DGVUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este usuario?",
                "Biblioteca",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario eliminado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            BTNNuevo_Click(null, null);
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            TXTBOXNombre.Clear();
            TXTBOXApellido.Clear();
            TXTBOXDocumento.Clear();
            TXTBOXTelefono.Clear();
            TXTBOXCorreo.Clear();

            DGVUsuarios.ClearSelection();

            TXTBOXNombre.Focus();
        }

        private void DGVUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TXTBOXNombre.Text = DGVUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            TXTBOXApellido.Text = DGVUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();

            TXTBOXDocumento.Text = DGVUsuarios.Rows[e.RowIndex].Cells["Documento"].Value.ToString();

            TXTBOXTelefono.Text = DGVUsuarios.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

            TXTBOXCorreo.Text = DGVUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
        }
    }
}
