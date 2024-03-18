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
        }

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
            if (string.IsNullOrEmpty(contactPhone) && contactPhone.Length != 7 && !contactPhone.All(char.IsDigit))
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
            if (string.IsNullOrEmpty(contactPhone) && contactPhone.Length != 7 && !contactPhone.All(char.IsDigit))
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
        }
    }
}
