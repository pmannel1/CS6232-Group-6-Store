
using System.Data;
using System.Data.SqlClient;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.DAL
{
    public class FurnitureDAL
    {


        public List<Furniture> ReturnFurnituresSearch(string searchMethod, string searchItem)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            string selectStatement = "SELECT furniture.* FROM furniture";
            SqlCommand selectCommand;

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                if (searchMethod == "ID")
                {
                    selectStatement += " WHERE id = @SearchTerm";
                    selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.Add("@SearchTerm", SqlDbType.Int);
                    selectCommand.Parameters["@SearchTerm"].Value = int.Parse(searchItem);
                }
                else if (searchMethod == "Category")
                {
                    selectStatement += " WHERE categoryName = @SearchTerm";
                    selectCommand = new SqlCommand(selectStatement, connection);
                    selectCommand.Parameters.Add("@SearchTerm", SqlDbType.NVarChar);
                    selectCommand.Parameters["@SearchTerm"].Value = searchItem;
                }
                else if (searchMethod == "Style")
                {
                    selectStatement += " WHERE styleName = @SearchTerm";
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
                            InStockNumber = Convert.IsDBNull(reader["instockNumber"]) ? 0 : int.Parse(reader["instockNumber"].ToString())
                        };

                        furnitureList.Add(furniture);
                    }
                }
            }

            return furnitureList;
        }

    }
}
