using CS6232_Group_6_Store.DAL;

namespace CS6232_Group_6_Store.Controller
{
    /// <summary>
    /// Controller for Employee
    /// </summary>
    internal class EmployeeController    {
        private EmployeeDal _employeeDal;

        public EmployeeController()
        {
            _employeeDal = new EmployeeDal();
        }
    }
}
