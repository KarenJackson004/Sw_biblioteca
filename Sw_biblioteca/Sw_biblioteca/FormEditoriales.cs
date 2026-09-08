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
    public partial class FormEditoriales : Form
    {
        public FormEditoriales()
        {
            InitializeComponent();
            CargarEditoriales();
        }

        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Editoriales";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        DGVEditoriales.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las editoriales:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTBOXNombre.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre de la editorial.",
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
                    "INSERT INTO Editoriales (Nombre) VALUES (@Nombre)";

                using (SqlCommand comando =
                       new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        TXTBOXNombre.Text.Trim());

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Editorial guardada correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarEditoriales();

            TXTBOXNombre.Clear();
            TXTBOXNombre.Focus();
        }


        private void DGVEditoriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TXTBOXNombre.Text =
                DGVEditoriales.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
        }

        private void BTNEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVEditoriales.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione una editorial para editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idEditorial = Convert.ToInt32(
                    DGVEditoriales.CurrentRow.Cells["IdEditorial"].Value);

                if (string.IsNullOrWhiteSpace(TXTBOXNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la editorial.",
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
                        "UPDATE Editoriales SET Nombre = @Nombre WHERE IdEditorial = @IdEditorial";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@Nombre",
                            TXTBOXNombre.Text.Trim());

                        comando.Parameters.AddWithValue(
                            "@IdEditorial",
                            idEditorial);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial actualizada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEditoriales();

                TXTBOXNombre.Clear();
                TXTBOXNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar la editorial:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVEditoriales.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione una editorial para eliminar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int idEditorial = Convert.ToInt32(
                    DGVEditoriales.CurrentRow.Cells["IdEditorial"].Value);

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar esta editorial?",
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
                        "DELETE FROM Editoriales WHERE IdEditorial = @IdEditorial";

                    using (SqlCommand comando =
                           new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue(
                            "@IdEditorial",
                            idEditorial);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Editorial eliminada correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarEditoriales();

                TXTBOXNombre.Clear();
                TXTBOXNombre.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la editorial:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            TXTBOXNombre.Clear();
            TXTBOXNombre.Focus();
        }

        private void BTNNuevo_Click_1(object sender, EventArgs e)
        {
            TXTBOXNombre.Clear();
            TXTBOXNombre.Focus();
        }
    }
}
