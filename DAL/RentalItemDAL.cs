﻿using CS6232_Group_6_Store.Model;
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
    }
}
