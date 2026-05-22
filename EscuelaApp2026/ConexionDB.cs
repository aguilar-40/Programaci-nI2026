using System.Data.SqlClient;

namespace EscuelaApp2026
{
    public class ConexionDB
    {
        private string connectionString = "Server=.\\SQLEXPRESS;Database=EscuelaDB;Trusted_Connection=True;";
        

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}