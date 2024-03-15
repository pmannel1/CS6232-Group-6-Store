using CS6232_Group_6_Store.Model;
using System.Data.SqlClient;
using System.Data;

namespace CS6232_Group_6_Store.DAL
{
    public class LoginDAL
    {
        /// <summary>
        /// Returns employee name if login is succesful.
        /// </summary>
        /// <param name="login">Login Model</param>
        /// <returns></returns>
        public string CheckCredentials(Login login)
        {
            string selectStatement =
              "SELECT lastName  + ' ' + firstName[user] FROM employees " +
              "Where id = @userName and hashedPassword=@hashedPassword;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@userName", SqlDbType.Int);
                    selectCommand.Parameters["@userName"].Value = login.UserName;
                    selectCommand.Parameters.Add("@hashedPassword", SqlDbType.VarChar);
                    selectCommand.Parameters["@hashedPassword"].Value = login.Password;

                    string code = Convert.ToString(selectCommand.ExecuteScalar());

                    return code;
                }
            }
        }
    }
}
