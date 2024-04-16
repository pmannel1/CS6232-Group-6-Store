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


    }
}
