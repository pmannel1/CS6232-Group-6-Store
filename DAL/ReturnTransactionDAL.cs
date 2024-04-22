
using CS6232_Group_6_Store.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CS6232_Group_6_Store.DAL
{
    internal class ReturnTransactionDAL
    {
        private ReturnItemDAL _returnItemDAL;

        public ReturnTransactionDAL()
        {
            _returnItemDAL = new ReturnItemDAL();
        }

        /// <summary>
        /// Creates the return transaction scope.
        /// </summary>
        /// <param name="returnTransaction">The return transaction.</param>
        /// <param name="returnItems">The return items.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public string CreateReturnTransactionScope(ReturnTransaction returnTransaction, List<ReturnItem> returnItems)
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
            
            string transactionId = "";
            
            string insertReturnTransactionStatement = "INSERT INTO return_transactions (employeeId, memberId, returnDate, refund, fine) "
                + "OUTPUT INSERTED.id "
                + "VALUES (@employeeId, @memberId, GETDATE(), @refund, @fine);";
            
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

                        int returnValue = (int)command.ExecuteScalar();
                        transactionId = "" + returnValue;

                        SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@returnId", SqlDbType.Int),
                            new SqlParameter("@rentalItemId", SqlDbType.Int),
                            new SqlParameter("@quantity", SqlDbType.Int),
                            new SqlParameter("@furnitureId", SqlDbType.Int)
                        };
                        
                        command.Parameters.AddRange(parameters);

                        command.Parameters["@furnitureId"].Value = -1;

                        this._returnItemDAL.ReturnItemByRentalReturnTransaction(returnItems, parameters, transactionId, command);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transactionId = "An error occurred during transaction Error message:" + ex.Message + " addtional error message " + ex.StackTrace;
                        transaction.Rollback();
                    }
                }
            }

            return transactionId;

        }


        /// <summary>
        /// Gets retal transaction summery.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id must be greater than 0</exception>
        public List<RentalReturnTransactionSummary> GetRentalReturnTransactionsummary(int id)
        {
            List<RentalReturnTransactionSummary> rentalReturnTransactions = new List<RentalReturnTransactionSummary>();
            string selectStatement = "select T.id[TransactionId],  R.id[ReturnId] , R.rentalItemId[RentalItemId], F.name[FurnitureName],R.quantity,M.firstName + ' ' + M.lastName[MemeberName], E.firstName + ' ' + E.lastName[EmployeeName], T.returnDate " +
                "from return_transactions T inner join return_items R  on T.id=R.returnId inner join rental_items RI on R.rentalItemId=RI.id  LEFT join furniture F on RI.furnitureId=F.id  inner join members M on T.memberId=M.id left join employees E on T.employeeId=E.id" +
                " where R.returnId=@transactionId";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@transactionId", SqlDbType.Int);
                    selectCommand.Parameters["@transactionId"].Value = id;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            var transactionId = int.Parse(reader["TransactionId"].ToString());
                            var returnId = int.Parse(reader["ReturnId"].ToString());
                            var rentalItemId = int.Parse(reader["RentalItemId"].ToString());
                            var furnitureName = reader["FurnitureName"].ToString();
                            var quantity = int.Parse(reader["quantity"].ToString());
                            var memberName = reader["MemeberName"].ToString();
                            var employeeName = reader["EmployeeName"].ToString();
                            var dueDate = DateTime.Parse(reader["returnDate"].ToString());
                            
                            RentalReturnTransactionSummary rentalReturnItem = new RentalReturnTransactionSummary(transactionId, returnId, rentalItemId, furnitureName, quantity, memberName, employeeName, dueDate);
                            rentalReturnTransactions.Add(rentalReturnItem);
                        }
                    }
                }
            }

            return rentalReturnTransactions;
        }
    }
}
