using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.Controller
{
    public class RentalTransactionController
    {
        private RentalTransactionDAL rentalTransactionDal;

        public RentalTransactionController()
        {
            this.rentalTransactionDal = new RentalTransactionDAL();
        }

        public int StartNewTransaction(RentalTransaction transaction)
        {
            return this.rentalTransactionDal.CreateRentalTransaction(transaction);
        }

        public void AddItemToTransaction(int transactionId, int itemId, int quantity)
        {
             this.rentalTransactionDal.AddRentalItem(transactionId, itemId, quantity);
        }

        public void UpdateItemQuantity(int transactionId, int itemId, int newQuantity)
        {
             this.rentalTransactionDal.UpdateRentalItemQuantity(transactionId, itemId, newQuantity);
        }

        public void RemoveItemFromTransaction(int transactionId, int itemId)
        {
            this.rentalTransactionDal.RemoveRentalItem(transactionId, itemId);
        }
    }
}
