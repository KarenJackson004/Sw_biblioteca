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
    public partial class FormAutores : Form
    {
        public FormAutores()
        {
            InitializeComponent();
            CargarAutores();
        }
        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Autores";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        DGVAutores.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los autores:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            TXTBOXNombre.Clear();
            TXTBOXApellido.Clear();

            TXTBOXNombre.Focus();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTBOXNombre.Text) ||
                    string.IsNullOrWhiteSpace(TXTBOXApellido.Text))
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

                    string consulta = @"INSERT INTO Autores
                                (Nombre, Apellido)
                                VALUES
                                (@Nombre, @Apellido)";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@Nombre",
                            TXTBOXNombre.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Apellido",
                            TXTBOXApellido.Text.Trim());

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Autor guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarAutores();

                TXTBOXNombre.Clear();
                TXTBOXApellido.Clear();

                TXTBOXNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el autor:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DGVAutores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TXTBOXNombre.Text = DGVAutores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            TXTBOXApellido.Text = DGVAutores.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
        }

        private void BTNEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTBOXNombre.Text) ||
                    string.IsNullOrWhiteSpace(TXTBOXApellido.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (DGVAutores.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un autor para editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idAutor = Convert.ToInt32(
                    DGVAutores.CurrentRow.Cells["IdAutor"].Value);

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Autores
                                SET Nombre = @Nombre,
                                    Apellido = @Apellido
                                WHERE IdAutor = @IdAutor";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@Nombre",
                            TXTBOXNombre.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@Apellido",
                            TXTBOXApellido.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@IdAutor",
                            idAutor);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Autor actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarAutores();

                TXTBOXNombre.Clear();
                TXTBOXApellido.Clear();

                TXTBOXNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el autor:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVAutores.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un autor para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idAutor = Convert.ToInt32(
                    DGVAutores.CurrentRow.Cells["IdAutor"].Value);

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este autor?",
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
                        "DELETE FROM Autores WHERE IdAutor = @IdAutor";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@IdAutor",
                            idAutor);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Autor eliminado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarAutores();

                TXTBOXNombre.Clear();
                TXTBOXApellido.Clear();

                TXTBOXNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el autor:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            TXTBOXNombre.Clear();
            TXTBOXApellido.Clear();

            TXTBOXNombre.Focus();
        }
    }
}
