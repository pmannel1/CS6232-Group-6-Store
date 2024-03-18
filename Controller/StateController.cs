using CS6232_Group_6_Store.DAL;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.Controller
{
    public class StateController
    {
        private StateDAL stateDAL;

        public StateController()
        {
            stateDAL = new StateDAL();
        }

        public List<State> GetStates()
        {
            return stateDAL.GetStates();
        }
    }
}
