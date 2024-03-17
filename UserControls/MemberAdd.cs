using CS6232_Group_6_Store.Controller;
using System.Text;
using System.Text.RegularExpressions;

namespace CS6232_Group_6_Store.UserControls
{
    public partial class MemberAdd : UserControl
    {
        public MemberAdd()
        {
            InitializeComponent();
      
            PopulateComboBoxes();

        }

        /// <summary>
        /// Populates the combo boxes.
        /// </summary>
        private void PopulateComboBoxes()
        {
            List<string> states =
            ["DC", "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia",
             "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland",
             "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
             "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania",
             "Rhode Island", "South Carolina", "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington",
              "West Virginia", "Wisconsin", "Wyoming"  ];

            stateComboBox.DataSource = states;

            List<string> sex = ["Male", "Female", "Other"];

            genderBox.DataSource = sex;
        }

        /// <summary>
        /// Validates the fields to ensure all fields are populated and use proper characters (strings/integers/combo).
        /// </summary>
        /// <returns></returns>
        public bool ValidateFields()
        {
            bool isValid = true;
            StringBuilder errorMessage = new StringBuilder();

            if (string.IsNullOrWhiteSpace(firstNameText.Text))
            {
                errorMessage.Append("First name is required. \n");
                isValid = false;
            }
            else if (!Regex.IsMatch(firstNameText.Text, "^[a-zA-Z]+$"))
            {
                errorMessage.Append("First name must contain only letters.\n");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                errorMessage.Append("Last name is required.\n");
                isValid = false;
            }

            else if (!Regex.IsMatch(lastNameText.Text, "^[a-zA-Z]+$"))
            {
                errorMessage.Append("Last name must contain only letters.\n");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                errorMessage.Append("Address is required.\n");
                isValid = false;
            }
            
            if (string.IsNullOrWhiteSpace(cityText.Text))
            {
                errorMessage.Append("City is required.\n");
                isValid = false;
            }
            else if (!Regex.IsMatch(cityText.Text, "^[a-zA-Z]+$"))
            {
                errorMessage.Append("City must contain only letters.\n");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                errorMessage.Append("Country is required.\n");
                isValid = false;
            }
            else if (!Regex.IsMatch(countryTextBox.Text, "^[a-zA-Z]+$"))
            {
                errorMessage.Append("Country must contain only letters.\n");
                isValid = false;
            }
            if (!int.TryParse(zipText.Text, out int zipCode) || zipCode <= 0)
            {
                errorMessage.Append("Zip code must be a positive integer.\n");
                isValid = false;
            }

            if (!int.TryParse(phoneText.Text, out int phoneNumber) || phoneNumber <= 0)
            {
                errorMessage.Append("Phone number must be a positive integer.\n");
                isValid = false;
            }

            if (isValid)
            {
                errorLabel.Text = "";
            }
            else
            {
                this.ShowError(errorMessage.ToString());
            }

            return isValid;
        }

        /// <summary>
        /// Shows the error.
        /// </summary>
        /// <param name="errorMessage">The error message.</param>
        /// <returns></returns>
        private void ShowError(string errorMessage)
        {
            errorLabel.Text = errorMessage;
            errorLabel.ForeColor = Color.Red;   
        }

        /// <summary>
        /// Handles the Click event of the AddButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                string? firstName = firstNameText.Text;
                string? lastName = lastNameText.Text;
                string? gender = genderBox.SelectedItem?.ToString();
                DateTime dob = dobPicker.Value;
                string? streetAddress = addressTextBox.Text;
                string? city = cityText.Text;
                string? state = stateComboBox.SelectedItem?.ToString();
                string? zipCode = zipText.Text;
                string? phone = phoneText.Text;
                string? country = countryTextBox.Text;
                MemberController memberController = new();

                try
                {
                    memberController.AddDBMember(firstName, lastName, gender, dob, streetAddress, city, state, zipCode, country, phone);
                    errorLabel.Text = "Member Successfully Added";
                    ClearFields();
                }
                catch (Exception ex)
                {
                    this.ShowError("Error: " + ex.Message); 
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <returns></returns>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            errorLabel.Text = "";
        }

        /// <summary>
        /// Clears the fields.
        /// </summary>
        /// <returns></returns>
        private void ClearFields()
        {
            // Clear text boxes
            firstNameText.Text = "";
            lastNameText.Text = "";
            addressTextBox.Text = "";
            cityText.Text = "";
            zipText.Text = "";
            phoneText.Text = "";
            countryTextBox.Text = "";

            // Clear combo boxes
            genderBox.SelectedIndex = -1;
            stateComboBox.SelectedIndex = -1;

            // Reset date picker
            dobPicker.Value = DateTime.Now;
        }

    }
}
