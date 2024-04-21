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
        public string CreateRentalTransaction(RentalTransaction rTransaction,  List<RentalItem> rental)
        {
            string message = "Transaction is succcesful";
            string insertTransactionStatement = "INSERT INTO rental_transactions (employeeId, memberId, rentalDate, dueDate) " +
                                     "OUTPUT INSERTED.id " +
                                     "VALUES (@EmployeeId, @MemberId, @RentalDate, @DueDate);";
            string insertItemStatement = @"
        INSERT INTO rental_items (transactionId, furnitureId, quantity, quantityReturned)
        VALUES (@TransactionId, @ItemId, @Quantity, @QuantityReturned);";

            string updateStatement = "UPDATE furniture SET instockNumber = instockNumber - @Quantity WHERE id =  @ItemId";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                var transaction = connection.BeginTransaction();

                using (var command = connection.CreateCommand())
                {
                    command.Transaction = transaction;
                    command.Connection = connection;
                    try
                    {
                        command.CommandText = insertTransactionStatement;
                        command.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@employeeId", SqlDbType.Int),
                            new SqlParameter("@memberId", SqlDbType.Int),
                            new SqlParameter("@RentalDate", SqlDbType.DateTime2),
                            new SqlParameter("@DueDate", SqlDbType.DateTime2)

                        });
                        command.Parameters["@EmployeeId"].Value = rTransaction.EmployeeId;
                        command.Parameters["@MemberId"].Value = rTransaction.MemberId;
                        command.Parameters["@RentalDate"].Value = rTransaction.RentalDate;
                        command.Parameters["@DueDate"].Value = rTransaction.DueDate;


                        int transactionId = (int)command.ExecuteScalar();


                        command.Parameters.AddRange(new SqlParameter[]
                       {
                            new SqlParameter("@TransactionId", SqlDbType.Int),
                            new SqlParameter("@ItemId", SqlDbType.Int),
                            new SqlParameter("@Quantity", SqlDbType.Int),
                             new SqlParameter("@QuantityReturned", SqlDbType.Int)
                       });
                        foreach (RentalItem item in rental)
                        {
                            command.CommandText = insertItemStatement;
                            command.Parameters["@TransactionId"].Value = transactionId;
                            command.Parameters["@ItemId"].Value = item.FurnitureId;
                            command.Parameters["@Quantity"].Value = item.Quantity;
                            command.Parameters["@QuantityReturned"].Value = item.QuantityReturned;
                            command.ExecuteNonQuery();

                            command.CommandText = updateStatement;
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();




                    }
                    catch (Exception ex)
                    {
                        message = "An error occurred during transaction Error message:" + ex.Message + " addtional error message " + ex.StackTrace;
                        transaction.Rollback();
                    }
                }
            }
            return message;
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