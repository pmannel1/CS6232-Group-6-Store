namespace CS6232_Group_6_Store.UserControls
{
    public partial class MemberAdd : UserControl
    {
        public MemberAdd()
        {
            InitializeComponent();
      
            PopulateComboBoxes();
            

        }

        private void PopulateComboBoxes()
        {
            List<string> states = new List<string> { "DC", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia",
"Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland",
"Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
"New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania",
"Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington",
"West Virginia", "Wisconsin", "Wyoming"  };

            stateComboBox.DataSource = states;

            List<string> sex = new List<string> { "Male", "Female", "Other" };

            genderBox.DataSource = sex;
        }
    }
}
