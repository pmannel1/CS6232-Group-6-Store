using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.Controller
{
    internal class RentalItemController
    {
        private RentalItemDAL _rentalItemDAL;
        
        internal List<RentalItem> GetMemberRentalItemHistory(int id)
        {
            if (id < 1)
            {
                throw new ArgumentOutOfRangeException("id must be greater than 0");
            }

            return _rentalItemDAL.GetMemberRentalItemHistory(id);
        }
    }
}
