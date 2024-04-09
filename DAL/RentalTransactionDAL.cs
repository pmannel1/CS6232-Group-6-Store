using CS6232_Group_6_Store.Model;
using System.Data.SqlClient;
using System.Data;

namespace CS6232_Group_6_Store.DAL
{
    /// <summary>
    /// data access class for rental transaction table
    /// </summary>
    public class RentalTransactionDAL
    {
        /// <summary>
        /// Creates the rental transaction.
        /// </summary>
        /// <param name="rTransaction">The r transaction.</param>
        /// <returns></returns>
        public int CreateRentalTransaction(RentalTransaction rTransaction)
        {
            string insertStatement = "INSERT INTO rental_transactions (employeeId, memberId, rentalDate, dueDate) " +
                                     "OUTPUT INSERTED.id " +
                                     "VALUES (@EmployeeId, @MemberId, @RentalDate, @DueDate);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(insertStatement, connection, transaction))
                        {
                            command.Parameters.Add("@EmployeeId", SqlDbType.Int);
                            command.Parameters["@EmployeeId"].Value = rTransaction.EmployeeId;

                            command.Parameters.Add("@MemberId", SqlDbType.Int);
                            command.Parameters["@MemberId"].Value = rTransaction.MemberId;

                            command.Parameters.Add("@RentalDate", SqlDbType.DateTime2);
                            command.Parameters["@RentalDate"].Value = rTransaction.RentalDate;

                            command.Parameters.Add("@DueDate", SqlDbType.DateTime2);
                            command.Parameters["@DueDate"].Value = rTransaction.DueDate;

                            // ExecuteScalar returns the first column of the first row in the result set
                            int transactionId = (int)command.ExecuteScalar();
                            transaction.Commit();
                            return transactionId;
                        }
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }


        /// <summary>
        /// Adds the rental item.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="quantity">The quantity.</param>
        public void AddRentalItem(int transactionId, int itemId, int quantity)
        {
            string insertStatement = @"
        INSERT INTO rental_items (transactionId, itemId, quantity)
        VALUES (@TransactionId, @ItemId, @Quantity);";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(insertStatement, connection, transaction))
                        {
                            command.Parameters.Add("@TransactionId", SqlDbType.Int);
                            command.Parameters["@TransactionId"].Value = transactionId;

                            command.Parameters.Add("@ItemId", SqlDbType.Int);
                            command.Parameters["@ItemId"].Value = itemId;

                            command.Parameters.Add("@Quantity", SqlDbType.Int);
                            command.Parameters["@Quantity"].Value = quantity;

                            command.ExecuteNonQuery();
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