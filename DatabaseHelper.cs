using System.Data.SqlClient;

namespace CliniqueVeterinaire
{
    public class DatabaseHelper
    {
        // Chemin complet de ta base de données
        private static string path = @"C:\Users\user\source\repos\CliniqueVeterinaire\CliniqueVeterinaire\CliniqueDB.mdf";

        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}