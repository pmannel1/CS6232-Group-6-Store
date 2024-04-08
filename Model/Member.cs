namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model class for members table in DB
    /// </summary>
    public class Member
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

        /// <summary>
        /// Gets or sets the sex.
        /// </summary>
        /// <value>
        /// The sex.
        /// </value>
        public string Sex{ get; set; }

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
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public String FullName { get; set; }

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
            FullName = FirstName + " " + LastName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="dateOfBirth">The date of birth.</param>
        /// <param name="streetAddress">The street address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="country">The country.</param>
        /// <param name="contactPhone">The contact phone.</param>
        /// <param name="password">The password.</param>
        /// <param name="sex">The sex.</param>
        /// <exception cref="System.ArgumentException">
        /// id cannot be less than or equal to zero
        /// or
        /// last name cannot be null or empty
        /// or
        /// first name cannot be null or empty
        /// or
        /// street address cannot be null or empty
        /// or
        /// city cannot be null or empty
        /// or
        /// state cannot be null or empty
        /// or
        /// country cannot be null or empty
        /// or
        /// phone number cannot be null or empty, must be seven digits and only numerical
        /// or
        /// password cannot be null or empty
        /// or
        /// Zipcode is out of range
        /// or
        /// Sex is invalid
        /// </exception>
        public Member(int id, string lastName, string firstName, DateTime dateOfBirth, string streetAddress, string city, string state, int zipCode, string country, string contactPhone, string password, string sex)
        {
            if(id <= 0) 
            {
                throw new ArgumentException("id cannot be less than or equal to zero");
            }
            if(string.IsNullOrEmpty(lastName)) 
            {
                throw new ArgumentException("last name cannot be null or empty");
            }
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("first name cannot be null or empty");
            }
            if (string.IsNullOrEmpty(streetAddress))
            {
                throw new ArgumentException("street address cannot be null or empty");
            }
            if (string.IsNullOrEmpty(city))
            {
                throw new ArgumentException("city cannot be null or empty");
            }
            if (string.IsNullOrEmpty(state))
            {
                throw new ArgumentException("state cannot be null or empty");
            }
            if (string.IsNullOrEmpty(country))
            {
                throw new ArgumentException("country cannot be null or empty");
            }
            if (string.IsNullOrEmpty(contactPhone) || contactPhone.Length != 10 || !contactPhone.All(char.IsDigit))
            {
                throw new ArgumentException("phone number cannot be null or empty, must be seven digits and only numerical");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("password cannot be null or empty");
            }
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("last name cannot be null or empty");
            }
            if (zipCode < 10000 || zipCode > 99999)
            {
                throw new ArgumentException("Zipcode is out of range");
            }
            if (!(sex == "M" || sex == "F" || sex == "Other"))
            {
                throw new ArgumentException("Sex is invalid");
            }
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
            ContactPhone = contactPhone;
            Password = password;
            Sex = sex;
            FullName = FirstName + " " + LastName;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Member"/> class.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="dateOfBirth">The date of birth.</param>
        /// <param name="streetAddress">The street address.</param>
        /// <param name="city">The city.</param>
        /// <param name="state">The state.</param>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="country">The country.</param>
        /// <param name="contactPhone">The contact phone.</param>
        /// <param name="password">The password.</param>
        /// <param name="sex">The sex.</param>
        /// <exception cref="System.ArgumentException">
        /// last name cannot be null or empty
        /// or
        /// first name cannot be null or empty
        /// or
        /// street address cannot be null or empty
        /// or
        /// city cannot be null or empty
        /// or
        /// state cannot be null or empty
        /// or
        /// country cannot be null or empty
        /// or
        /// phone number cannot be null or empty, must be seven digits and only numerical
        /// or
        /// password cannot be null or empty
        /// or
        /// Zipcode is out of range
        /// or
        /// Sex is invalid
        /// </exception>
        public Member(string lastName, string firstName, DateTime dateOfBirth, string streetAddress, string city, string state, int zipCode, string country, string contactPhone, string password, string sex)
        {

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("last name cannot be null or empty");
            }
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("first name cannot be null or empty");
            }
            if (string.IsNullOrEmpty(streetAddress))
            {
                throw new ArgumentException("street address cannot be null or empty");
            }
            if (string.IsNullOrEmpty(city))
            {
                throw new ArgumentException("city cannot be null or empty");
            }
            if (string.IsNullOrEmpty(state))
            {
                throw new ArgumentException("state cannot be null or empty");
            }
            if (string.IsNullOrEmpty(country))
            {
                throw new ArgumentException("country cannot be null or empty");
            }
            if (string.IsNullOrEmpty(contactPhone) || contactPhone.Length < 7 || contactPhone.Length > 10 || !contactPhone.All(char.IsDigit))
            {
                throw new ArgumentException("Phone number must be between 7 and 10 digits long and contain only numerical characters.");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("password cannot be null or empty");
            }
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("last name cannot be null or empty");
            }
            if (zipCode < 10000 || zipCode > 99999)
            {
                throw new ArgumentException("Zipcode is out of range");
            }
            if (!(sex == "M" || sex == "F" || sex == "Other"))
            {
                throw new ArgumentException("Sex is invalid");
            }

            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
            ContactPhone = contactPhone;
            Password = password;
            Sex = sex;
            FullName = FirstName + " " + LastName;
        }
    }
}
