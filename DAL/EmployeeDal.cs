using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232_Group_6_Store.DAL
{
    internal class EmployeeDal
    {
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
