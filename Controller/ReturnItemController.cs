using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;

{
    internal class ReturnItemController
    {
    private ReturnItemDAL _returnItemDAL;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnItemController"/> class.
        /// </summary>
        public ReturnItemController() 
        { 
            this._returnItemDAL = new ReturnItemDAL();
        }

        /// <summary>
        /// Gets the outstanding return items by identifier.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">memberId cannot be less than 1.</exception>
        public List<ReturnItem> getOutstandingReturnItemsById(int memberId)
        {
            if (memberId < 1)
            {
                throw new ArgumentException("memberId cannot be less than 1.");
            }
            
            List<ReturnItem> returnItems = new List<ReturnItem>();

            returnItems = this._returnItemDAL.getOutstandingReturnItemsById(memberId);

            return returnItems;
        }
    }
}
