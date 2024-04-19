
using CS6232_Group_6_Store.Model;
using System.Data;
using System.Data.SqlClient;

namespace CS6232_Group_6_Store.DAL
{
    internal class ReturnTransactionDAL
    {
        /// <summary>
        /// Creates the return transaction scope.
        /// </summary>
        /// <param name="returnTransaction">The return transaction.</param>
        /// <param name="returnItems">The return items.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int CreateReturnTransactionScope(ReturnTransaction returnTransaction, List<ReturnItem> returnItems)
        {            
            if (returnTransaction == null)
            {
                throw new ArgumentException("returnTransaction cannot be null.");
            }

            if (returnItems == null)
            {
                throw new ArgumentException("returnItems cannot be null");
            }

            if (returnItems.Count == 0)
            {
                throw new ArgumentException("returnItems cannot be empty");
            }
            
            int transactionId = 0;
            
            string insertReturnTransactionStatement = "INSERT INTO return_transactions (employeeId, memberId, returnDate, refund, fine) "
                + "OUTPUT INSERTED.id "
                + "VALUES (@employeeId, @memberId, GETDATE(), @refund, @fine);";

            string insertReturnItemStatement = "INSERT INTO return_items (returnId, rentalItemId, quantity) " 
                + "VALUES (@returnId, @rentalItemId, @quantity);";

            string updateInstockNumberFurnitureStatement = "UPDATE furniture "
                + "SET instockNumber = instockNumber + @quantity " 
                + "WHERE id = @furnitureId;";

            string updateQuantityReturnedRentalItemStatement = "UPDATE rental_items "
                + "SET quantityReturned = quantityReturned + @quantity " 
                + "WHERE id = @rentalItemId;";
            
            using (var connection = DBConnection.GetConnection())
            {                
                connection.Open();
                var transaction = connection.BeginTransaction();

                using (var command = connection.CreateCommand())
                {
                    command.Transaction = transaction;
                    command.Connection = connection;
                    try
                    {
                        command.CommandText = insertReturnTransactionStatement;
                        command.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@employeeId", SqlDbType.Int), 
                            new SqlParameter("@memberId", SqlDbType.Int), 
                            new SqlParameter("@refund", SqlDbType.Decimal), 
                            new SqlParameter("@fine", SqlDbType.Decimal)                            
                        });

                        command.Parameters["@employeeId"].Value = returnTransaction.EmployeeId;
                        command.Parameters["@memberId"].Value = returnTransaction.MemberId;
                        command.Parameters["@refund"].Value = returnTransaction.Refund;
                        command.Parameters["@fine"].Value = returnTransaction.Fine;

                        transactionId = (int)command.ExecuteScalar();

                        command.Parameters.AddRange(new SqlParameter[]
                        {
                            new SqlParameter("@returnId", SqlDbType.Int),
                            new SqlParameter("@rentalItemId", SqlDbType.Int),
                            new SqlParameter("@quantity", SqlDbType.Int)
                        });

                        int count = 0;
                        foreach(ReturnItem item in returnItems)
                        {
                            command.CommandText = insertReturnItemStatement;
                            command.Parameters["@returnId"].Value = transactionId;
                            command.Parameters["@rentalItemId"].Value = item.RentalItemId;
                            command.Parameters["@quantity"].Value = item.Quantity;
                            command.ExecuteNonQuery();

                            command.CommandText = updateInstockNumberFurnitureStatement;

                            if (count == 0) 
                            { 
                                command.Parameters.Add("@furnitureId", SqlDbType.Int);
                                count++;
                            }

                            command.Parameters["@furnitureId"].Value= item.FurnitureId;
                            command.ExecuteNonQuery();

                            command.CommandText = updateQuantityReturnedRentalItemStatement;
                            command.ExecuteNonQuery();

                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred during checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show($"An error occurred during checkout: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        transaction.Rollback();
                    }
                }
            }

            return transactionId;

        }
    }
}
