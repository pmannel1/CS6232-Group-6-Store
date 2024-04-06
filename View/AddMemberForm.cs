using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.UserControls;

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

      

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.AddMember();
                _memberController.AddMember(newMember);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
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
