
namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// class for categories of furniture
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        public Category()
        {
            Name = "";
        }
    }
}
