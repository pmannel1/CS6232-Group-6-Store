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

        private void PopulateFields()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

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

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            this.PopulateFields();
        }

        private void UpdateMember()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.UpdateMember();
                _memberController.UpdateMember(updatedMember);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.PopulateFields();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
