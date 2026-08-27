using Microsoft.Data.SqlClient;

namespace SwBiblioteca.Datos
{
    public class Conexion
    {
        private string cadenaConexion =
            "Server=.\\localhost;Database=Biblioteca;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}