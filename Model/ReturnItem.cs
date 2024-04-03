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

    }
}
