
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
            string selectStatement =
                "select furniture.* " +
                " from furniture ";

            
            if(searchMethod == "Id")
            {

                selectStatement = selectStatement+ " where id = @searchId";
            }
            else if (searchMethod == "Category")
            {
                selectStatement = selectStatement + " where categoryName =@searchItem";
            }
            else if (searchMethod == "Style")
            {
                selectStatement = selectStatement + " where styleName =@searchItem";
            }

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                   

                    if (searchMethod == "Id")
                    {
                        selectCommand.Parameters.Add("@searchId", SqlDbType.Int);
                        selectCommand.Parameters["@searchId"].Value = int.Parse(searchItem);
                    }
                    else if (searchMethod == "Category" || searchMethod == "Style")
                    {
                        selectCommand.Parameters.Add("@searchItem", SqlDbType.VarChar);
                        selectCommand.Parameters["@searchItem"].Value = searchItem;
                    }
                    

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture();
                            var id = int.Parse(reader["id"].ToString());
                            var name = reader["name"].ToString();
                            var description = reader["description"].ToString();
                            var styles = reader["styleName"].ToString();
                            var categoryName = reader["categoryName"].ToString();
                            var rentalRate = Convert.IsDBNull(reader["rentalRate"]) ? 0 : Convert.ToDecimal(reader["rentalRate"].ToString());
                            var instockNumber = Convert.IsDBNull(reader["instockNumber"]) ? 0 : int.Parse(reader["instockNumber"].ToString());

                            furniture.Id = id;
                            furniture.Name = name;
                            furniture.Description = description;
                            furniture.Style = styles;
                            furniture.Category = categoryName;
                            furniture.RentalRate = rentalRate;
                            furniture.InStockNumber = instockNumber;
                            furnitureList.Add(furniture);

                        }
                    }
                }
            }

            return furnitureList;
        }
       
    }
}
