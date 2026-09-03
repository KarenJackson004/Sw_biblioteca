using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SwBiblioteca.Datos;

namespace Sw_biblioteca
{
    public partial class FormLibros : Form
    {

        private bool modoEdicion = false;
        public FormLibros()
        {
            InitializeComponent();
            CargarLibros();
            CargarAutores();
            CargarEditoriales();

        }
        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvLibros.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdAutor, Nombre, Apellido FROM Autores ORDER BY Nombre, Apellido";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        tabla.Columns.Add("NombreCompleto", typeof(string));

                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] =
                                fila["Nombre"].ToString() + " " +
                                fila["Apellido"].ToString();
                        }

                        CMBAutor.DataSource = tabla;
                        CMBAutor.DisplayMember = "NombreCompleto";
                        CMBAutor.ValueMember = "IdAutor";
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

        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdEditorial, Nombre FROM Editoriales ORDER BY Nombre";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        CMBEditorial.DataSource = tabla;
                        CMBEditorial.DisplayMember = "Nombre";
                        CMBEditorial.ValueMember = "IdEditorial";
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTCategoria_Click(object sender, EventArgs e)
        {

        }

        private void PNLGestor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CMBEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTNBusqueda_Click(object sender, EventArgs e)

        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTBuscarISBN.Text))
                {
                    MessageBox.Show(
                        "Ingrese un ISBN para realizar la búsqueda.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", TXTBuscarISBN.Text.Trim());

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                TXTBOXIsbn1.Text = lector["ISBN"].ToString();
                                TXTBOXTitulo.Text = lector["Titulo"].ToString();

                                CMBAutor.SelectedValue = Convert.ToInt32(lector["IdAutor"]);
                                CMBEditorial.SelectedValue = Convert.ToInt32(lector["IdEditorial"]);

                                TXTBOXGenero.Text = lector["Categoria"].ToString();
                                TXTBOXAnio.Text = lector["Anio"].ToString();
                                TXTBOXExistencias.Text = lector["Existencias"].ToString();

                                MessageBox.Show(
                                    "Libro encontrado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró un libro con ese ISBN.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            TXTBOXIsbn1.Clear();
            TXTBOXTitulo.Clear();
            TXTBOXGenero.Clear();
            TXTBOXAnio.Clear();
            TXTBOXExistencias.Clear();

            CMBAutor.SelectedIndex = -1;
            CMBEditorial.SelectedIndex = -1;

            TXTBOXIsbn1.Focus();
        }

        private void CargarLibroSeleccionado(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TXTBOXIsbn1.Text = dgvLibros.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            TXTBOXTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();

            CMBAutor.SelectedValue = Convert.ToInt32(
                dgvLibros.Rows[e.RowIndex].Cells["IdAutor"].Value
            );

            CMBEditorial.SelectedValue = Convert.ToInt32(
                dgvLibros.Rows[e.RowIndex].Cells["IdEditorial"].Value
            );

            TXTBOXGenero.Text = dgvLibros.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
            TXTBOXAnio.Text = dgvLibros.Rows[e.RowIndex].Cells["Anio"].Value.ToString();
            TXTBOXExistencias.Text = dgvLibros.Rows[e.RowIndex].Cells["Existencias"].Value.ToString();
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTBOXIsbn1.Text) ||
                    string.IsNullOrWhiteSpace(TXTBOXTitulo.Text) ||
                    CMBAutor.SelectedIndex == -1 ||
                    CMBEditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(TXTBOXGenero.Text) ||
                    string.IsNullOrWhiteSpace(TXTBOXAnio.Text) ||
                    string.IsNullOrWhiteSpace(TXTBOXExistencias.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de guardar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int anio;
                int existencias;

                if (!int.TryParse(TXTBOXAnio.Text, out anio))
                {
                    MessageBox.Show(
                        "El año debe ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!int.TryParse(TXTBOXExistencias.Text, out existencias))
                {
                    MessageBox.Show(
                        "Las existencias deben ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"INSERT INTO Libros
                                (ISBN, Titulo, IdAutor, IdEditorial, Categoria, Anio, Existencias)
                                VALUES
                                (@ISBN, @Titulo, @IdAutor, @IdEditorial, @Categoria, @Anio, @Existencias)";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", TXTBOXIsbn1.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", TXTBOXTitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(CMBAutor.SelectedValue));
                        comando.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(CMBEditorial.SelectedValue));
                        comando.Parameters.AddWithValue("@Categoria", TXTBOXGenero.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", anio);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro guardado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();

                BTNNuevo_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTNEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TXTBOXIsbn1.Text) ||
                    string.IsNullOrWhiteSpace(TXTBOXTitulo.Text) ||
                    CMBAutor.SelectedIndex == -1 ||
                    CMBEditorial.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(TXTBOXGenero.Text) ||
                    string.IsNullOrWhiteSpace(TXTBOXAnio.Text) ||
                    string.IsNullOrWhiteSpace(TXTBOXExistencias.Text))
                {
                    MessageBox.Show(
                        "Complete todos los campos antes de editar.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                int anio;
                int existencias;

                if (!int.TryParse(TXTBOXAnio.Text, out anio))
                {
                    MessageBox.Show(
                        "El año debe ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!int.TryParse(TXTBOXExistencias.Text, out existencias))
                {
                    MessageBox.Show(
                        "Las existencias deben ser un número entero.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = @"UPDATE Libros
                                SET Titulo = @Titulo,
                                    IdAutor = @IdAutor,
                                    IdEditorial = @IdEditorial,
                                    Categoria = @Categoria,
                                    Anio = @Anio,
                                    Existencias = @Existencias
                                WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", TXTBOXIsbn1.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", TXTBOXTitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", Convert.ToInt32(CMBAutor.SelectedValue));
                        comando.Parameters.AddWithValue("@IdEditorial", Convert.ToInt32(CMBEditorial.SelectedValue));
                        comando.Parameters.AddWithValue("@Categoria", TXTBOXGenero.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", anio);
                        comando.Parameters.AddWithValue("@Existencias", existencias);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Libro actualizado correctamente.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarLibros();
                BTNCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            TXTBOXIsbn1.Clear();
            TXTBOXTitulo.Clear();
            TXTBOXGenero.Clear();
            TXTBOXAnio.Clear();
            TXTBOXExistencias.Clear();

            CMBAutor.SelectedIndex = -1;
            CMBEditorial.SelectedIndex = -1;

            modoEdicion = false;
        }
    }
} 