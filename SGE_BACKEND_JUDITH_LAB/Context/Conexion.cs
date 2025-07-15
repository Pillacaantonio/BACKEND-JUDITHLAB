using Microsoft.Data.SqlClient;

namespace SGE_BACKEND_JUDITH_LAB.Context
{
    public class Conexion
    {
        private readonly string _connnectionString;

        public Conexion(string connnectionString)
        {
            _connnectionString = connnectionString;
        }
        public SqlConnection ObtenerConnexion()
        {
            var connection = new SqlConnection(_connnectionString);
            connection.Open();
            return connection;
        }
    }
}
