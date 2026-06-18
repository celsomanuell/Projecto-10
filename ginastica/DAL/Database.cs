using Microsoft.Data.SqlClient;
//using System.Data;
namespace ginastica.DAL
{
    public static class Database
    {
        // TODO: update this connection string to your SQL Server Express instance and database
        public static string ConnectionString { get; set; } = "Server=CELSO-PC;Database=GinasticaDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
