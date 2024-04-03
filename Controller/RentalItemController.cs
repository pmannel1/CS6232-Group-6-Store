using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.Controller
{
    internal class RentalItemController
    {
        private RentalItemDAL _rentalItemDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalItemController"/> class.
        /// </summary>
        public RentalItemController()
        {
            _rentalItemDAL = new RentalItemDAL();
        }

        /// <summary>
        /// Gets the member rental item history.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException">id must be greater than 0</exception>
        public List<RentalItem> GetMemberRentalItemHistory(int id)
        {
            if (id < 1)
            {
                throw new ArgumentOutOfRangeException("id must be greater than 0");
            }

            return _rentalItemDAL.GetMemberRentalItemHistory(id);
        }
    }
}
