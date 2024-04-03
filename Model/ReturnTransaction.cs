namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model for return_transactions table in DB
    /// </summary>
    public class ReturnTransaction
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>
        /// The member identifier.
        /// </value>
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or sets the return date.
        /// </summary>
        /// <value>
        /// The return date.
        /// </value>
        public DateTime ReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the refund.
        /// </summary>
        /// <value>
        /// The refund.
        /// </value>
        public decimal Refund {  get; set; }

        /// <summary>
        /// Gets or sets the fine.
        /// </summary>
        /// <value>
        /// The fine.
        /// </value>
        public decimal Fine { get; set; }

    }
}
