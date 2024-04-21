using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.Controller
{
    /// <summary>
    /// controller for rental transactions
    /// </summary>
    public class RentalTransactionController
    {
        private RentalTransactionDAL rentalTransactionDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalTransactionController"/> class.
        /// </summary>
        public RentalTransactionController()
        {
            this.rentalTransactionDal = new RentalTransactionDAL();
        }

        /// <summary>
        /// Starts the new transaction.
        /// </summary>
        /// <param name="transaction">The transaction.</param>
        /// <returns></returns>
        public string  StartNewTransaction(RentalTransaction transaction,  List<RentalItem> rental)
        {
            return this.rentalTransactionDal.CreateRentalTransaction(transaction, rental);
        }

        
    }
}
