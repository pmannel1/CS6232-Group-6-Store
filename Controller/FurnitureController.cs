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

        /// <summary>
        ///Returns the furnitures category or style list.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <returns>category or style list</returns>
        public List<string> ReturnFurnituresCategoyOrStyle(string searchMethod)
        {
            return this.furnitureDAL.ReturnFurnituresCategoyOrStyle(searchMethod);
        }


        /// <summary>
        /// Gets the furniture.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public Furniture GetFurniture(int id)
        {
            return this.furnitureDAL.GetFurniture(id);
        }

        /// <summary>
        /// Updates the inventory.
        /// </summary>
        /// <param name="furnitureQuantities">The furniture quantities.</param>
        public void UpdateInventory(Dictionary<int, int> furnitureQuantities)
        {
            this.furnitureDAL.UpdateInventory(furnitureQuantities);
        }
    }
}
