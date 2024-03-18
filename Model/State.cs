

namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// class for states
    /// </summary>
    public class State
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name {  get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="State"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <exception cref="System.ArgumentNullException">Name is required</exception>
        public State(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name is required");
            }
            Name = name;
        }
    }
}
