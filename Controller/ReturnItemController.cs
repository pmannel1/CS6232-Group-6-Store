using CS6232_Group_6_Store.DAL;

namespace CS6232_Group_6_Store.Controller
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