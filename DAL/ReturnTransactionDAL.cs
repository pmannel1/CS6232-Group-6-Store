
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.DAL
{
    internal class ReturnTransactionDAL
    {
        /// <summary>
        /// Creates the return transaction scope.
        /// </summary>
        /// <param name="returnTransaction">The return transaction.</param>
        /// <param name="returnItems">The return items.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int CreateReturnTransactionScope(ReturnTransaction returnTransaction, List<ReturnItem> returnItems)
        {
            int transactionId = 0;
            
            string insertReturnTransactionStatement = "INSERT INTO return_transactions (employeeId, memberId, returnDate, refund, fine) "
                + "OUTPUT INSERTED.id "
                + "VALUES (@employeeId, @memberId, GETDATE(), @refund, @fine);";

            string insertReturnItemStatement = "INSERT INTO return_items (returnId, rentalItemId, quantity) " 
                + "VALUES (@returnId, @rentalItemId, @quantity);";

            string updateInstockNumberFurnitureStatement = "UPDATE furniture "
                + "SET instockNumber = instockNumber + @quantity " 
                + "WHERE id = @furnitureId;";

            string updateQuantityReturnedRentalItemStatement = "UPDATE rental_items "
                + "SET quantityReturned = quantityReturned + @quantity " 
                + "WHERE id = @rentalItemId;";

            return transactionId;

        }
    }
}
