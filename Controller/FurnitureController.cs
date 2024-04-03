using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;


namespace CS6232_Group_6_Store.Controller
{
    public class FurnitureController
    {
        private FurnitureDAL furnitureDAL;
        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>

        public FurnitureController()
        {
            this.furnitureDAL = new FurnitureDAL();
        }
       

        /// <summary>
        /// Retruns the Furniture.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <param name="searchField">The search field.</param>
        /// <returns></returns>
        public List<Furniture> SearchFurniture(string searchMethod, string searchItem)
        {
            return this.furnitureDAL.ReturnFurnituresSearch(searchMethod, searchItem);
        }
    }
}
