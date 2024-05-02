
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using CS6232_Group_6_Store.Model;


namespace CS6232_Group_6_Store.DAL
{
    /// <summary>
    /// furniture table data access layer
    /// </summary>
    public class FurnitureDAL
    {

        private RentalItemDAL _itemDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureDAL"/> class.
        /// </summary>
        public FurnitureDAL()
        {
            this._itemDAL = new RentalItemDAL();
        }

        /// <summary>
        /// Returns the furnitures search.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <param name="searchItem">The search item.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Invalid search method.</exception>
        public List<Furniture> ReturnFurnituresSearch(string searchMethod, string searchItem)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            string selectStatement =  "select F.id, F.name, F.description, F.styleName, F.categoryName,F.RentalRate, F.instockNumber,  F.instockNumber + G.OutStock[TotalStock]" +
                " from furniture F inner join  (select furnitureId, sum(quantity) - sum(quantityReturned)[OutStock] from rental_items group by furnitureId) G on F.id=G.furnitureId";

            SqlCommand selectCommand;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                if (searchMethod == "ID")
                {
                    selectStatement += " WHERE F.id = @SearchTerm";
                    selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.Add("@SearchTerm", SqlDbType.Int);
                    selectCommand.Parameters["@SearchTerm"].Value = int.Parse(searchItem);
                }
                else if (searchMethod == "Category")
                {
                    selectStatement += " WHERE F.categoryName = @SearchTerm";
                    selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.Add("@SearchTerm", SqlDbType.NVarChar);
                    selectCommand.Parameters["@SearchTerm"].Value = searchItem;
                }
                else if (searchMethod == "Style")
                {
                    selectStatement += " WHERE F.styleName = @SearchTerm";
                    selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.Add("@SearchTerm", SqlDbType.NVarChar);
                    selectCommand.Parameters["@SearchTerm"].Value = searchItem;
                }
                else
                {
                    // If no valid search method is provided, perhaps throw an error or return empty list
                    throw new ArgumentException("Invalid search method.");
                }

                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Furniture furniture = new Furniture
                        {
                            Id = int.Parse(reader["id"].ToString()),
                            Name = reader["name"].ToString(),
                            Description = reader["description"].ToString(),
                            Style = reader["styleName"].ToString(),
                            Category = reader["categoryName"].ToString(),
                            RentalRate = Convert.IsDBNull(reader["rentalRate"]) ? 0 : Convert.ToDecimal(reader["rentalRate"]),
                            InStockNumber = Convert.IsDBNull(reader["instockNumber"]) ? 0 : int.Parse(reader["instockNumber"].ToString()),
                            TotalStockNumber = Convert.IsDBNull(reader["TotalStock"]) ? 0 : int.Parse(reader["TotalStock"].ToString())

                        };

                        furnitureList.Add(furniture);
                    }
                }
            }

            return furnitureList;
        }


        /// <summary>
        /// Returns the furnitures category or style.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Invalid search method.</exception>
        public List<string> ReturnFurnituresCategoyOrStyle(string searchMethod)
        {
            List<string> dropdownList = new List<string>();
            string selectStatement = "SELECT name FROM categories";
            SqlCommand selectCommand;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                if (searchMethod == "Category")
                {
                    selectStatement = "SELECT name FROM categories";
                }
                else if (searchMethod == "Style")
                {
                    selectStatement = "SELECT name  FROM styles";
                }

                selectCommand = new SqlCommand(selectStatement, connection);
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dropdownList.Add(reader[0].ToString());
                    }
                }
            }

            return dropdownList;
        }



        /// <summary>
        /// Gets the furniture.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Furniture GetFurniture(int id)
        {
            Furniture furniture = null;
            string selectStatement =
               "SELECT furniture.* " +
               "FROM furniture " +
               "WHERE furniture.id = @id ";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.Add("@id", SqlDbType.Int);
                    selectCommand.Parameters["@id"].Value = id;

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            furniture = new Furniture
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Name = reader["name"].ToString(),
                                Description = reader["description"].ToString(),
                                Style = reader["styleName"].ToString(),
                                Category = reader["categoryName"].ToString(),
                                RentalRate = Convert.IsDBNull(reader["rentalRate"]) ? 0 : Convert.ToDecimal(reader["rentalRate"]),
                                InStockNumber = Convert.IsDBNull(reader["instockNumber"]) ? 0 : int.Parse(reader["instockNumber"].ToString())
                            };
                        
                        }
                    }
                }
            }
            return furniture;
        }


        /// <summary>
        /// Updates the inventory.
        /// </summary>
        /// <param name="furnitureQuantities">The furniture quantities.</param>
        public void UpdateInventory(Dictionary<int,int> furnitureQuantities)
        {
            string updateStatement = "UPDATE furniture SET instockNumber = instockNumber - @Quantity WHERE id = @FurnitureId";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                foreach (KeyValuePair<int, int> entry in furnitureQuantities)
                {
                    using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@Quantity", entry.Value);
                        updateCommand.Parameters.AddWithValue("@FurnitureId", entry.Key);
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        /// <summary>
        /// Updates the furniture quantity by rental return transaction.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="command">The command.</param>
        public void UpdateFurnitureQuantityByRentalReturnTransaction(ReturnItem item, SqlParameter[] parameters, string transactionId, SqlCommand command)
        {
            string updateInstockNumberFurnitureStatement = "UPDATE furniture "
                + "SET instockNumber = instockNumber + @quantity "
                + "WHERE id = @furnitureId;";

                command.CommandText = updateInstockNumberFurnitureStatement;

                command.Parameters["@furnitureId"].Value = item.FurnitureId;
                command.ExecuteNonQuery();

                this._itemDAL.UpdateRentalItemQuantityReturnedByRentalReturnTransaction(parameters, transactionId, command);
            
        }

    }
}
