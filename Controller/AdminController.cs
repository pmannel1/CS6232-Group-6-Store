using CS6232_Group_6_Store.DAL;
using System.Data;

namespace CS6232_Group_6_Store.Controller
{
    public class AdminController
    {
        private AdminDal _adminDal;

        public AdminController()
        {
            _adminDal = new AdminDal();
        }

        /// <summary>
        /// Executes the get most popular furniture during dates.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>The DataTable containing the results of the query.</returns>
        public DataTable ExecuteGetMostPopularFurnitureDuringDates(DateTime startDate, DateTime endDate)
        {
            return _adminDal.ExecuteGetMostPopularFurnitureDuringDates(startDate, endDate);
        }
    }
}
