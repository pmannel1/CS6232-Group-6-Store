using CS6232_Group_6_Store.Model;
using System.Data.SqlClient;
using System.Data;

namespace CS6232_Group_6_Store.DAL
{
    public class RentalTransactionDAL
    {
        public void CreateRentalTransaction(int employeeId, int memberId, DateTime rentalDate, DateTime dueDate)
        {
            
            string updateStatement = "INSERT INTO rental_transactions (employeeId, memberId, rentalDate, dueDate) " +
                         "OUTPUT INSERTED.id " +
                         "VALUES (@EmployeeId, @MemberId, @RentalDate, @DueDate);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(updateStatement, connection, transaction))
                        {
                            command.Parameters.Add("@EmployeeId", SqlDbType.Int);
                            command.Parameters["@EmployeeId"].Value = employeeId;

                            command.Parameters.Add("@MemberId", SqlDbType.Int);
                            command.Parameters["@MemberId"].Value = memberId;

                            command.Parameters.Add("@RentalDate", SqlDbType.DateTime2);
                            command.Parameters["@RentalDate"].Value = rentalDate;

                            command.Parameters.Add("@DueDate", SqlDbType.DateTime2);
                            command.Parameters["@DueDate"].Value = dueDate;

                            command.ExecuteScalar();
                        }

                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
