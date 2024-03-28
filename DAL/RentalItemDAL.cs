using CS6232_Group_6_Store.Model;
using System.Data;

namespace CS6232_Group_6_Store.DAL
{
    internal class RentalItemDAL
    {
        /// <summary>
        /// Gets the member rental item history.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id must be greater than 0</exception>
        internal List<RentalItem> GetMemberRentalItemHistory(int id)
        {
            if (id < 1)
            {
                throw new ArgumentOutOfRangeException("id must be greater than 0");
            }

            List<RentalItem> list = new List<RentalItem>();

            using (var connection = DBConnection.GetConnection())
            {
                
                connection.Open();

                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "  SELECT * FROM rental_transactions as rt" 
                        + " JOIN rental_items as ri ON rt.id = ri.transactionId" 
                        + " JOIN furniture as f ON ri.furnitureId = f.id" 
                        + " WHERE rt.memberId = @id;";

                    command.Connection = connection;

                    command.Parameters.Add("@id", SqlDbType.Int);
                    command.Parameters["@id"].Value = id;

                    using (var  reader = command.ExecuteReader())
                    {
                        int employeeIdOrdinal = reader.GetOrdinal("employeeId");
                        int rentalDateOrdinal = reader.GetOrdinal("rentalDate");
                        int dueDateOrdinal = reader.GetOrdinal("dueDate");
                        int nameOrdinal = reader.GetOrdinal("name");
                        int quantityOrdinal = reader.GetOrdinal("quantity");
                        int rentalRateOrdinal = reader.GetOrdinal("rentalRate");
                        int quantityReturnedOrdinal = reader.GetOrdinal("quantityReturned");
                        
                        while (reader.Read())
                        {
                            RentalItem item = new RentalItem();

                            item.RentalTransaction.EmployeeId = reader.GetInt32(employeeIdOrdinal);
                            item.RentalTransaction.RentalDate = reader.GetDateTime(rentalDateOrdinal);
                            item.RentalTransaction.DueDate = reader.GetDateTime(dueDateOrdinal);
                            item.Furniture.Name = reader.GetString(nameOrdinal);
                            item.Quantity = reader.GetInt32(quantityOrdinal);
                            item.Furniture.RentalRate = reader.GetDecimal(rentalRateOrdinal);
                            item.QuantityReturned = reader.GetInt32(quantityReturnedOrdinal);

                            list.Add(item);
                        }
                    }
                }
            }

            return list;
        }
    }
}
