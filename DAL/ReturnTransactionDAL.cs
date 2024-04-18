
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
                var transaction = connection.BeginTransaction();
                connection.Open();

                using(var command = connection.CreateCommand())
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
                            new SqlParameter("@fine", SqlDbType.Decimal),
                            new SqlParameter("@returnId", SqlDbType.Int),
                            new SqlParameter("@rentalItemId", SqlDbType.Int),
                            new SqlParameter("@quantity", SqlDbType.Int),
                            new SqlParameter("@furnitureId", SqlDbType.Int)
                        });

                        command.Parameters["@employeeId"].Value = returnTransaction.EmployeeId;
                        command.Parameters["@memberId"].Value = returnTransaction.MemberId;
                        command.Parameters["@refund"].Value = returnTransaction.Refund;
                        command.Parameters["@fine"].Value = returnTransaction.Fine;

                        transactionId = (int)command.ExecuteScalar();





                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show(ex.StackTrace);
                        transaction.Rollback();
                    }
                }
            }

            return transactionId;

        }
    }
}
