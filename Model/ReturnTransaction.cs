namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model for return_transactions table in DB
    /// </summary>
    internal class ReturnTransaction
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
        /// Gets or sets the return date.
        /// </summary>
        /// <value>
        /// The return date.
        /// </value>
        public DateTime ReturnDate { get; set; }
    }
}
