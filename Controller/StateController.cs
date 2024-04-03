using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.Controller
{
    /// <summary>
    /// controller for the state table
    /// </summary>
    public class StateController
    {
        private StateDAL stateDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="StateController"/> class.
        /// </summary>
        public StateController()
        {
            stateDAL = new StateDAL();
        }

        /// <summary>
        /// Gets the states.
        /// </summary>
        /// <returns></returns>
        public List<State> GetStates()
        {
            return stateDAL.GetStates();
        }
    }
}
