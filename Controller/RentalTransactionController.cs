﻿using CS6232_Group_6_Store.DAL;
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

        public void StartNewTransaction(int employeeId, int memberId, DateTime rentalDate, DateTime dueDate)
        {
            this.rentalTransactionDal.CreateRentalTransaction(employeeId, memberId, rentalDate, dueDate);
        }

        public bool AddItemToTransaction(int transactionId, int itemId, int quantity)
        {
            return rentalTransactionDal.AddRentalItem(transactionId, itemId, quantity);
        }

        public bool UpdateItemQuantity(int transactionId, int itemId, int newQuantity)
        {
            return rentalTransactionDal.UpdateRentalItemQuantity(transactionId, itemId, newQuantity);
        }

        public bool RemoveItemFromTransaction(int transactionId, int itemId)
        {
            return rentalTransactionDal.RemoveRentalItem(transactionId, itemId);
        }

        public RentalTransaction GetTransactionDetails(int transactionId)
        {
            return rentalTransactionDal.GetRentalTransactionById(transactionId);
        }

        public void FinalizeTransaction(int transactionId)
        {
            // Here you would add any business logic to finalize the transaction
            // For now, we just call a method that could complete the transaction and calculate the total cost
             this.rentalTransactionDal.CompleteRentalTransaction(transactionId);
        }
    }
}
