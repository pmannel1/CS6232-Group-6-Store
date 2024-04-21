using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model class for join table rental_transaction, return_items, rental_items, furniture, members
    /// and employeestable in DB
    /// </summary>
    public class RentalReturnTransactionSummary
    {
        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        /// <value>
        /// The transaction id.
        /// </value>
        public int TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the return identifier.
        /// </summary>
        /// <value>
        /// The return identifier.
        /// </value>
        public int ReturnId { get; set; }

        /// <summary>
        /// Gets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
        public int RentalItemId { get; set; }
        /// <summary>
        /// Gets or sets the rental item name.
        /// </summary>
        /// <value>
        /// The rental item name.
        /// </value>
        public string FurnitureName { get; set; }
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }
        /// <summary>
        /// Gets or sets the member name.
        /// </summary>
        /// <value>
        /// Member Name.
        /// </value>
        public string MemberName { get; set; }
        /// <summary>
        /// Gets or sets the employeet name.
        /// </summary>
        /// <value>
        /// Employee Name.
        /// </value>
        public string EmployeeName { get; set; }
        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        /// <value>
        /// The due date.
        /// </value>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalReturnTransactionSummary"/> class.
        /// </summary>
        /// <param name="transactionId">The transaction identifier.</param>
        /// <param name="returnId">The transaction identifier.</param>
        /// <param name="rentalItemId">The furniture id.</param>
        /// <param name="furnitureName">The funiture name</param>
        /// <param name="memberName">The member identifier.</param>
        /// <param name="employeeName">The employee name.</param>
        /// <param name="dueDate">The due date.</param>
        public RentalReturnTransactionSummary(int transactionId, int returnId, int rentalItemId, string furnitureName, int quantity,string  memberName, string  employeeName, DateTime dueDate)
        {
            TransactionId = transactionId;
            ReturnId = returnId;
            RentalItemId = rentalItemId;
            FurnitureName = furnitureName;
            Quantity = quantity;
            MemberName = memberName;
            EmployeeName = employeeName;
            DueDate = dueDate;
        }
    }
}
