namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model class for return_items table in DB
    /// </summary>
    internal class ReturnItem
    {
        /// <summary>
        /// Gets or sets the return identifier.
        /// </summary>
        /// <value>
        /// The return identifier.
        /// </value>
        public int ReturnId { get; set; }

        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
        public int FurnitureId { get; set; }

        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        /// <value>
        /// The transaction identifier.
        /// </value>
        public int TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }
    }
}
