

namespace CS6232_Group_6_Store.Model
{
    public class State
    {
        public string Name {  get; set; }

        public State(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name is required");
            }
            Name = name;
        }
    }
}
