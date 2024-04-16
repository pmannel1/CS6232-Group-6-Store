

using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.DAL
{
    internal class ReturnItemDAL
    {
        internal List<ReturnItem> getOutstandingReturnItemsById(int memberId)
        {            
            if (memberId < 1)
            {
                throw new ArgumentException("memberId cannot be less than 1.");
            }

            List<ReturnItem> returnItems = new List<ReturnItem>();



            return returnItems;
        }
    }
}
