using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.UserControls;
using System.Drawing.Imaging;
using System.Text;

namespace CS6232_Group_6_Store.View
{
    /// <summary>
    /// add members form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class AddMemberForm : Form
    {
        private readonly MemberController _memberController;
        private readonly StateController _stateController;
        readonly MemberManagement dashboard;
        Member newMember = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddMemberForm"/> class.
        /// </summary>
        /// <param name="currentDashboard">The current dashboard.</param>
        public AddMemberForm(MemberManagement currentDashboard)
        {
            InitializeComponent();
            this._memberController = new MemberController();
            this._stateController = new StateController();
            this.dashboard = currentDashboard;
        }

        private void AddMember()
        {
            
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

            newMember = new Member(lName, fName, dob, sAddress, city, state, zip, country, pNum, pWord, sex);
        }

        public bool ValidateFields()
        {
            this.ClearErrorLabels();
            bool isValid = true;

            if(string.IsNullOrEmpty(this.firstNameTextBox.Text))
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

        private void ConfirmButton_Click(object sender, EventArgs e)

        {
            if (ValidateFields())            {
                this.AddMember();
                _memberController.AddMember(newMember);
                DialogResult = DialogResult.OK;

            }

        }

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


        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearFields();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ClearFields()
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.phoneNumberTextBox.Clear();
            this.passwordTextBox.Clear();
            this.sexComboBox.SelectedIndex = -1;
            this.dateOfBirthPicker.Value = DateTime.Now;
            this.stateTextBox.SelectedIndex = -1;
            this.cityTextBox.Clear();
            this.zipCodeTextBox.Clear();
            this.streetAddressTextBox.Clear();
        }

        private void FillComboBoxes()
        {
            stateTextBox.DataSource = _stateController.GetStates();
            stateTextBox.DisplayMember = "Name";
            stateTextBox.ValueMember = "Name";

            stateTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateTextBox.SelectedIndex = -1;

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
            sexComboBox.SelectedIndex = -1;
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            this.FillComboBoxes();
        }
    }
}
