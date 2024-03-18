using System.Data.SqlClient;


namespace CS6232_Group_6_Store.DAL
{
    /// <summary>
    /// database connection class
    /// </summary>
    public class DBConnection
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            var connectionString =
            "Data Source=localhost;Initial Catalog=cs6232-6;" +
            "Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
