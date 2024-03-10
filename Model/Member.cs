namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model class for members table in DB
    /// </summary>
    internal class Member
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        //TODO Create field/property for enum sex attribute in DB, below is my attempt
        public enum Sex
        {
            M = 0,
            F = 1,
            Other = 2
        }

        /// <summary>
        /// Gets or sets the date of birth.
        /// </summary>
        /// <value>
        /// The date of birth.
        /// </value>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the street address.
        /// </summary>
        /// <value>
        /// The street address.
        /// </value>
        public String StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public String City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public String State { get; set; }

        /// <summary>
        /// Gets or sets the zip code.
        /// </summary>
        /// <value>
        /// The zip code.
        /// </value>
        public int ZipCode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public String Country { get; set; }

        /// <summary>
        /// Gets or sets the contact phone.
        /// </summary>
        /// <value>
        /// The contact phone.
        /// </value>
        public String ContactPhone { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        public Member()
        {
            LastName = "";
            FirstName = "";
            StreetAddress = "";
            City = "";
            State = "";
            Country = "";
            ContactPhone = "";
            Password = "";
        }
    }
}
