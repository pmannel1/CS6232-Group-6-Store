namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model class for return_items table in DB
    /// </summary>
    public class ReturnItem
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the return identifier.
        /// </summary>
        /// <value>
        /// The return identifier.
        /// </value>
        public int ReturnId { get; set; }

        /// <summary>
        /// Gets or sets the rental item identifier.
        /// </summary>
        /// <value>
        /// The rental item identifier.
        /// </value>
        public int RentalItemId {  get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>
        /// The member identifier.
        /// </value>
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        /// <value>
        /// The due date.
        /// </value>
        public DateTime DueDate { get; set; }

    }
}
