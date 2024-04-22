

using CS6232_Group_6_Store.Model;
using System.Data.SqlClient;

namespace CS6232_Group_6_Store.DAL
{
    public class ReturnItemDAL
    {
        private FurnitureDAL _furnitureDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnItemDAL"/> class.
        /// </summary>
        public ReturnItemDAL()
        {
            this._furnitureDAL = new FurnitureDAL();
        }

        /// <summary>
        /// Returns the item by rental return transaction.
        /// </summary>
        /// <param name="returnItems">The return items.</param>
        /// <param name="parameters">The parameters.</param>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="command">The command.</param>
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
