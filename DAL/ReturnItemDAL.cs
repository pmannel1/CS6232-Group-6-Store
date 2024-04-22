

using CS6232_Group_6_Store.Model;
using System.Data.SqlClient;

namespace CS6232_Group_6_Store.DAL
{
    public class ReturnItemDAL
    {
        private FurnitureDAL _furnitureDAL;

        public ReturnItemDAL()
        {
            this._furnitureDAL = new FurnitureDAL();
        }
        
        public void ReturnItemByRentalReturnTransaction(List<ReturnItem> returnItems, SqlParameter[] parameters, string transactionId, SqlCommand command)
        {
            string insertReturnItemStatement = "INSERT INTO return_items (returnId, rentalItemId, quantity) "
                + "VALUES (@returnId, @rentalItemId, @quantity);";

            foreach (ReturnItem item in returnItems)
            {
                command.CommandText = insertReturnItemStatement;
                command.Parameters["@returnId"].Value = transactionId;
                command.Parameters["@rentalItemId"].Value = item.RentalItemId;
                command.Parameters["@quantity"].Value = item.Quantity;
                command.ExecuteNonQuery();

                this._furnitureDAL.UpdateFurnitureQuantityByRentalReturnTransaction(item, parameters, transactionId, command);

            }
        }
    }
}
