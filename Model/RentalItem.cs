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
        /// Gets or sets the rental transaction.
        /// </summary>
        /// <value>
        /// The rental transaction.
        /// </value>
        public RentalTransaction RentalTransaction { get; set; }

        /// <summary>
        /// Gets or sets the furniture.
        /// </summary>
        /// <value>
        /// The furniture.
        /// </value>
        public Furniture Furniture { get; set; }

        public RentalItem ()
        {
            RentalTransaction = new RentalTransaction();
            Furniture = new Furniture ();
        }
    }
}
