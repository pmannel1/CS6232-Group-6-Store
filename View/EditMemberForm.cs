using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.UserControls;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.View
{
    /// <summary>
    /// edit member form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EditMemberForm : Form
    {
        private readonly MemberController _memberController;
        private readonly StateController _stateController;
        readonly MemberManagement dashboard;
        int selectedMember;
        Member updatedMember = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EditMemberForm"/> class.
        /// </summary>
        /// <param name="currentDashboard">The current dashboard.</param>
        public EditMemberForm(MemberManagement currentDashboard)
        {
            InitializeComponent();
            this._memberController = new MemberController();
            this._stateController = new StateController();
            this.dashboard = currentDashboard;
            this.selectedMember = dashboard.selectedMember;
        }

        /// <summary>
        /// Populates the fields.
        /// </summary>
        /// <exception cref="System.ArgumentException">Member could not be found</exception>
        private void PopulateFields()
        {
            
                Member member = this._memberController.RetrieveMember(this.selectedMember);
                if (member == null)
                {
                    throw new ArgumentException("Member could not be found");
                }

                this.FillComboBoxes();

                this.firstNameTextBox.Text = member.FirstName;
                this.lastNameTextBox.Text = member.LastName;
                this.dateOfBirthPicker.Value = member.DateOfBirth;
                this.streetAddressTextBox.Text = member.StreetAddress;
                this.cityTextBox.Text = member.City;
                this.zipCodeTextBox.Text = member.ZipCode.ToString();
                this.phoneNumberTextBox.Text = member.ContactPhone;
                this.passwordTextBox.Text = member.Password;


                stateTextBox.SelectedValue = member.State;
                sexComboBox.SelectedValue = member.Sex;

           

        }

        /// <summary>
        /// Fills the combo boxes.
        /// </summary>
        private void FillComboBoxes()
        {
            stateTextBox.DataSource = _stateController.GetStates();
            stateTextBox.DisplayMember = "Name";
            stateTextBox.ValueMember = "Name";

            stateTextBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var options = new Dictionary<string, string>
            {
                { "M", "Male" },
                { "F", "Female" },
                { "Other", "Other" }
            };

            sexComboBox.DataSource = new BindingSource(options, null);
            sexComboBox.DisplayMember = "Value";
            sexComboBox.ValueMember = "Key";

            sexComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Handles the Load event of the EditMemberForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            this.PopulateFields();
        }

        /// <summary>
        /// Updates the member.
        /// </summary>
        private void UpdateMember()
        {
            
                var id = this.selectedMember;
                var fName = this.firstNameTextBox.Text;
                var lName = this.lastNameTextBox.Text;
                var sex = this.sexComboBox.SelectedValue.ToString();
                var dob = this.dateOfBirthPicker.Value;
                var sAddress = this.streetAddressTextBox.Text;
                var city = this.cityTextBox.Text;
                var state = this.stateTextBox.Text;
                var zip = int.Parse(this.zipCodeTextBox.Text);
                var pNum = this.phoneNumberTextBox.Text;
                var pWord = this.passwordTextBox.Text;
                var country = "USA";

                updatedMember = new Member(id, lName, fName, dob, sAddress, city, state, zip, country, pNum, pWord, sex);
            
        }

        /// <summary>
        /// Validates the fields.
        /// </summary>
        /// <returns></returns>
        public bool ValidateFields()
        {
            this.ClearErrorLabels();
            bool isValid = true;

            if (string.IsNullOrEmpty(this.firstNameTextBox.Text))
            {
                firstNameErrorLabel.Text = "First Name Cannot Be Empty";
                firstNameErrorLabel.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.lastNameTextBox.Text))

            {
                lastNameErrorLabel.Text = "Last Name Cannot Be Empty";
                lastNameErrorLabel.ForeColor = Color.Red;
                isValid = false;
            }

            if (this.sexComboBox.SelectedItem == null)
            {
                sexErrorLabel.Text = "Please Select a Sex";
                sexErrorLabel.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.streetAddressTextBox.Text))
            {
                streetErrorLabel.Text = "Street Address Cannot Be Empty";
                streetErrorLabel.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.cityTextBox.Text))
            {
                cityErrorLabel.Text = "City Cannot Be Empty";
                cityErrorLabel.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.stateTextBox.Text))
            {
                stateErrorLabel.Text = "State Cannot Be Empty";
                stateErrorLabel.ForeColor = Color.Red;
                isValid = false;
            }

            int zipCode;
            if (!int.TryParse(this.zipCodeTextBox.Text, out zipCode))
            {
                zipCodeErrorLabel.Text = "Zip Code must be a number";
                zipCodeErrorLabel.ForeColor = Color.Red;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.phoneNumberTextBox.Text) || !System.Text.RegularExpressions.Regex.IsMatch(this.phoneNumberTextBox.Text, @"^\d+$"))
            {
                phoneErrorLabel.Text = "Phone Number must contain only numbers";
                phoneErrorLabel.ForeColor = Color.Red;
                isValid = false;
            }


            if (this.phoneNumberTextBox.Text.Length < 6 && this.phoneNumberTextBox.Text.Length > 11)
            {
                phoneErrorLabel.Text = "Phone Number must be 7 digits-11 digits";
                phoneErrorLabel.ForeColor = Color.Red;
                isValid = false;    
            }

                if (string.IsNullOrWhiteSpace(this.passwordTextBox.Text))
                {
                    passwordErrorLabel.Text = "Password Cannot Be Empty";
                    passwordErrorLabel.ForeColor = Color.Red;
                    isValid = false;
                }

            return isValid;
        }

        /// <summary>
        /// Clears the error labels.
        /// </summary>
        private void ClearErrorLabels()
        {
            this.firstNameErrorLabel.Text = string.Empty;
            this.lastNameErrorLabel.Text = string.Empty;
            this.sexErrorLabel.Text = string.Empty;
            this.streetErrorLabel.Text = string.Empty;
            this.cityErrorLabel.Text = string.Empty;
            this.stateErrorLabel.Text = string.Empty;
            this.phoneErrorLabel.Text = string.Empty;
            this.passwordErrorLabel.Text = string.Empty;
            this.zipCodeErrorLabel.Text = string.Empty;
        }

        /// <summary>
        /// Handles the Click event of the ConfirmButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {

            if (ValidateFields())
            {
                this.UpdateMember();
                _memberController.UpdateMember(updatedMember);
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.PopulateFields();
        }

        /// <summary>
        /// Handles the Click event of the CancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
