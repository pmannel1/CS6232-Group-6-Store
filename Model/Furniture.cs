namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model class for furniture table in DB
    /// </summary>
    public class Furniture
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the style.
        /// </summary>
        /// <value>
        /// The style.
        /// </value>
        public string Style { get; set; }

        /// <summary>
        /// Gets or sets the rental rate.
        /// </summary>
        /// <value>
        /// The rental rate.
        /// </value>
        public decimal RentalRate { get; set; }

        /// <summary>
        /// Gets or sets the in stock number.
        /// </summary>
        /// <value>
        /// The in stock number.
        /// </value>
        public int InStockNumber { get; set; }
       
        /// <summary>
        /// Gets or sets the in stock number.
        /// </summary>
        /// <value>
        /// The total stock number.
        /// </value>
       
        public int TotalStockNumber { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Furniture"/> class.
        /// </summary>
        public Furniture() 
        {
            Name = "";
            Description = "";
            Category = "";
            Style = "";
        }
    }
}
