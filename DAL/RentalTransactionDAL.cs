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

        public void UpdateRentalItemQuantity(int transactionId, int itemId, int newQuantity)
        {
            string updateStatement = @"
        UPDATE rental_items
        SET quantity = @NewQuantity
        WHERE transactionId = @TransactionId AND itemId = @ItemId;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(updateStatement, connection, transaction))
                        {
                            command.Parameters.Add("@TransactionId", SqlDbType.Int);
                            command.Parameters["@TransactionId"].Value = transactionId;

                            command.Parameters.Add("@ItemId", SqlDbType.Int);
                            command.Parameters["@ItemId"].Value = itemId;

                            command.Parameters.Add("@NewQuantity", SqlDbType.Int);
                            command.Parameters["@NewQuantity"].Value = newQuantity;

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

        public void RemoveRentalItem(int transactionId, int itemId)
        {
            string deleteStatement = @"
        DELETE FROM rental_items
        WHERE transactionId = @TransactionId AND itemId = @ItemId;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(deleteStatement, connection, transaction))
                        {
                            command.Parameters.Add("@TransactionId", SqlDbType.Int);
                            command.Parameters["@TransactionId"].Value = transactionId;

                            command.Parameters.Add("@ItemId", SqlDbType.Int);
                            command.Parameters["@ItemId"].Value = itemId;

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

        public RentalTransaction GetRentalTransactionById(int transactionId)
        {
            string selectStatement = @"
                SELECT id, employeeId, memberId, rentalDate, dueDate FROM rental_transactions
                WHERE id = @TransactionId;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@TransactionId", transactionId);
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var id = int.Parse(reader["id"].ToString());
                                var employeeId = int.Parse(reader["employeeId"].ToString());
                                var memberId = int.Parse(reader["memberId"].ToString());
                                var rentalDate = DateTime.Parse(reader["rentalDate"].ToString());
                                var dueDate = DateTime.Parse(reader["dueDate"].ToString());

                                RentalTransaction rentalTransaction = new RentalTransaction(id, employeeId, memberId, rentalDate, dueDate);

                                return rentalTransaction;
                            }
                            else
                            {
                                throw new Exception("No rental transaction found with the specified ID.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error retrieving rental transaction: " + ex.Message);
                    }
                }
            }
        }

        public void CompleteRentalTransaction(int transactionId)
        {
            string updateStatement = @"
        UPDATE rental_transactions
        SET isCompleted = 1  -- Assuming you have a field to mark the transaction as completed
        WHERE id = @TransactionId;";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(updateStatement, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@TransactionId", transactionId);
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