using CS6232_Group_6_Store.DAL;

namespace CS6232_Group_6_Store.Controller
{
    /// <summary>
    /// Controller for Employee
    /// </summary>
    internal class EmployeeController    {
        private EmployeeDal _employeeDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        public EmployeeController()
        {
            _employeeDal = new EmployeeDal();
        }

        /// <summary>
        /// Validates the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public bool ValidateEmployee(int id, string password)
        {
            return this._employeeDal.ValidateEmployee(id, password);
        }
    }
}
