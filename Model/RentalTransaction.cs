namespace CS6232_Group_6_Store.Model
{
    /// <summary>
    /// Model class for rental_transaction table in DB
    /// </summary>
    public class RentalTransaction
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>
        /// The member identifier.
        /// </value>
        public int MemberId { get; set; }

        /// <summary>
        /// Gets or sets the rental date.
        /// </summary>
        /// <value>
        /// The rental date.
        /// </value>
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        /// <value>
        /// The due date.
        /// </value>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalTransaction"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="employeeId">The employee identifier.</param>
        /// <param name="memberId">The member identifier.</param>
        /// <param name="rentalDate">The rental date.</param>
        /// <param name="dueDate">The due date.</param>
        public RentalTransaction(int id, int employeeId, int memberId, DateTime rentalDate, DateTime dueDate)
        {
            Id = id;
            EmployeeId = employeeId;
            MemberId = memberId;
            RentalDate = rentalDate;
            DueDate = dueDate;
        }

        public RentalTransaction( int employeeId, int memberId, DateTime rentalDate, DateTime dueDate)
        {
           
            EmployeeId = employeeId;
            MemberId = memberId;
            RentalDate = rentalDate;
            DueDate = dueDate;
        }
    }
}
