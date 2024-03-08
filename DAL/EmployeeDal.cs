using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_Group_6_Store.DAL
{
    /// <summary>
    /// DAL for employee table in DB
    /// </summary>
    internal class EmployeeDal
    {
        /// <summary>
        /// Validates the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException">Employee ID cannot be less than 1.</exception>
        /// <exception cref="System.ArgumentNullException">Password cannot be empty or null.</exception>
        public bool ValidateEmployee(int id, string password)
        {
            if (id < 1)
            {
                throw new ArgumentOutOfRangeException("Employee ID cannot be less than 1.");
            }
            if (string.IsNullOrEmpty(password)) 
            {
                throw new ArgumentNullException("Password cannot be empty or null.");
            }

            //TODO Implement check to DB once DB is created
            if (id == 1 && "test1234".Equals(password))
            {
                return true;
            }

            return false;
        }
    }
}
