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

        /// <summary>
        /// Adds the rental item.
        /// </summary>
        /// <param name="rental">The rental.</param>
        public void AddRentalItem(RentalItem rental)
        {
            this._rentalItemDAL.AddRentalItem(rental);
        }

        /// <summary>
        /// Gets the outstanding rental items by identifier.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">memberId cannot be less than 1.</exception>
        public List<RentalItem> GetOutstandingRentalItemsById(int memberId)
        {
            if (memberId < 1)
            {
                throw new ArgumentException("memberId cannot be less than 1.");
            }

            List<RentalItem> rentalItems = new List<RentalItem>();

            rentalItems = this._rentalItemDAL.GetOutstandingRentalItemsById(memberId);

            return rentalItems;
        }
    }
}
