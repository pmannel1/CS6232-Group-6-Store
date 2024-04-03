namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model class for rental_items table in DB
    /// </summary>
    public class RentalItem
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        /// <value>
        /// The transaction identifier.
        /// </value>
        public int TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
        public int FurnitureId { get; set; }
       
        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the quantity returned.
        /// </summary>
        /// <value>
        /// The quantity returned.
        /// </value>
        public int QuantityReturned { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalItem"/> class.
        /// </summary>
        /// <param name="itemId">The item identifier.</param>
        /// <param name="quantity">The quantity.</param>
        public RentalItem(int itemId, int quantity)
        {
            FurnitureId = itemId;
            Quantity = quantity;
        }

        
    }
}
