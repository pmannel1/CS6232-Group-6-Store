using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.Controller
{

    internal class ReturnTransactionController
    {
        private ReturnTransactionDAL _returnTransactionDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnTransactionController"/> class.
        /// </summary>
        public ReturnTransactionController()
        {
            _returnTransactionDAL = new ReturnTransactionDAL();
        }

        /// <summary>
        /// Creates the return transaction scope.
        /// </summary>
        /// <param name="returnTransaction">The return transaction.</param>
        /// <param name="returnItems">The return items.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int CreateReturnTransactionScope(ReturnTransaction returnTransaction, List<ReturnItem> returnItems)
        {
            return this._returnTransactionDAL.CreateReturnTransactionScope(returnTransaction, returnItems);
        }

        /// <summary>
        /// return  transaction summary.
        /// </summary>
        /// <param name="returnTransaction">The return transaction.</param>
        /// <param name="returnItems">The return items.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public List<RentalReturnTransactionSummary> GetReturnTransactionSummary(int transactionId)
        {
            return this._returnTransactionDAL.GetRentalReturnTransactionsummary(transactionId);
        }
    }
}
