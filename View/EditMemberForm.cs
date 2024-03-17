using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.UserControls;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.View
{
    public partial class EditMemberForm : Form
    {
        private readonly MemberController _memberController;
        readonly MemberManagement dashboard;
        int selectedMember;

        public EditMemberForm(MemberManagement currentDashboard)
        {
            InitializeComponent();
            this._memberController = new MemberController();
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

                this.firstNameTextBox.Text = member.FirstName;
                this.lastNameTextBox.Text = member.LastName;
                this.dateOfBirthPicker.Value = member.DateOfBirth;
                this.streetAddressTextBox.Text = member.StreetAddress;
                this.cityTextBox.Text = member.City;
                this.zipCodeTextBox.Text = member.ZipCode.ToString();
                this.phoneNumberTextBox.Text = member.ContactPhone;
                this.passwordTextBox.Text = member.Password;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            this.PopulateFields();
        }
    }
}
