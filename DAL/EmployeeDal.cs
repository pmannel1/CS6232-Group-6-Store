
using CS6232_Group_6_Store.Model;
using System.Data.SqlClient;
using System.Data;

namespace CS6232_Group_6_Store.DAL
{
    /// <summary>
    /// DAL for employee table in DB
    /// </summary>
    internal class EmployeeDal
    {

        /// <summary>
        /// Validates the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public string ValidateEmployee(int id, string password)
        {
            string selectStatement =
              "SELECT lastName  + ' ' + firstName[user] FROM employees " +
              "Where id = @userName and password=@hashedPassword;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@userName", SqlDbType.Int);
                    selectCommand.Parameters["@userName"].Value = id;
                    selectCommand.Parameters.Add("@hashedPassword", SqlDbType.VarChar);
                    selectCommand.Parameters["@hashedPassword"].Value = password;

                    string code = Convert.ToString(selectCommand.ExecuteScalar());

                    return code;
                }
            }
        }

    }
}
