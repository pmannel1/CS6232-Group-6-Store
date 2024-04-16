using CS6232_Group_6_Store.Model;
using System.Data;
using System.Data.SqlClient;

namespace CS6232_Group_6_Store.DAL
{
    public class RentalItemDAL
    {
        /// <summary>
        /// Gets the member rental item history.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id must be greater than 0</exception>
        public List<RentalItem> GetMemberRentalItemHistory(int id)
        {
            List<RentalItem> rentalItems = new List<RentalItem>();
            string selectStatement =
               "SELECT ri.*, f.name AS FurnitureName, f.rentalRate, rt.rentalDate, rt.dueDate " +
               "FROM rental_transactions rt " +
               "JOIN rental_items ri ON rt.id = ri.transactionId " +
               "JOIN furniture f ON ri.furnitureId = f.id " +
               "WHERE rt.memberId = @memberId";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@memberId", SqlDbType.Int);
                    selectCommand.Parameters["@memberId"].Value = id;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RentalItem rentalItem = new RentalItem
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                TransactionId = int.Parse(reader["transactionId"].ToString()),
                                FurnitureId = int.Parse(reader["furnitureId"].ToString()),
                                Quantity = int.Parse(reader["quantity"].ToString()),
                                QuantityReturned = int.Parse(reader["quantityReturned"].ToString()),
                                RentalDate = DateTime.Parse(reader["rentalDate"].ToString()),
                                DueDate = DateTime.Parse(reader["dueDate"].ToString()),
                                RentalRate = decimal.Parse(reader["rentalRate"].ToString()),
                                FurnitureName = reader["FurnitureName"].ToString()
                            };
                            rentalItems.Add(rentalItem);
                        }
                    }
                }
            }

            return rentalItems;
        }

        /// <summary>
        /// Adds the rental item.
        /// </summary>
        /// <param name="rental">The rental.</param>
        public void AddRentalItem(RentalItem rental)
        {
            string insertStatement = @"
        INSERT INTO rental_items (transactionId, furnitureId, quantity, quantityReturned)
        VALUES (@TransactionId, @ItemId, @Quantity, @QuantityReturned);";

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
                            command.Parameters["@TransactionId"].Value = rental.TransactionId;

                            command.Parameters.Add("@ItemId", SqlDbType.Int);
                            command.Parameters["@ItemId"].Value = rental.FurnitureId;

                            command.Parameters.Add("@Quantity", SqlDbType.Int);
                            command.Parameters["@Quantity"].Value = rental.Quantity;

                            command.Parameters.Add("@QuantityReturned", SqlDbType.Int);
                            command.Parameters["@QuantityReturned"].Value = rental.QuantityReturned;

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

        /// <summary>
        /// Gets the outstanding rental items by identifier.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">memberId cannot be less than 1.</exception>
        public List<RentalItem> getOutstandingRentalItemsById(int memberId)
        {
            if (memberId < 1)
            {
                throw new ArgumentException("memberId cannot be less than 1.");
            }

            List<RentalItem> rentalItems = new List<RentalItem>();



            return rentalItems;
        }

    }
}
