using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.View;


namespace CS6232_Group_6_Store.UserControls
{
    /// <summary>
    /// Class representing MemeberMangement : User Control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class MemberManagement : UserControl
    {
        /// <summary>
        /// The selected member
        /// </summary>
        public int selectedMember;
        private readonly MemberController _memberController;
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberManagement"/> class.
        /// </summary>
        public MemberManagement()
        {
            InitializeComponent();
            this._memberController = new MemberController();
            this.editButton.Enabled = false;
            customerListBox.Enabled = false;
            searchButton.Enabled = false;
        }

        /// <summary>
        /// Populates the members name combobox.
        /// </summary>
        public void PopulateMembersNameCombobox()
        {
            try
            {
                this.searchButton.Enabled = true;
                this.customerListBox.DataSource = null;
                var field = this.searchMethodBox.Text;
                List<Member> memberList = this._memberController.ReturnMembers();
                this.customerListBox.DataSource = memberList;

                if (field == "Name")
                {
                    customerListBox.DisplayMember = "FullName";
                    customerListBox.ValueMember = "Id";
                    customerListBox.Enabled = true;
                }

                if (searchMethodBox.Text == "Id")
                {
                    customerListBox.DisplayMember = "Id";
                    customerListBox.ValueMember = "Id";
                    customerListBox.Enabled = true;
                }

                if (searchMethodBox.Text == "Phone")
                {
                    customerListBox.DisplayMember = "ContactPhone";
                    customerListBox.ValueMember = "Id";
                    customerListBox.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        /// <summary>
        /// Displaus the membes.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <param name="searchParameter">The search parameter.</param>
        public void DisplayMembers(string searchItem)
        {
            try
            {
                int searchInt = int.Parse(searchItem);
                membersListView.Clear();
                membersListView.View = System.Windows.Forms.View.Details;
                membersListView.GridLines = true;
                membersListView.Columns.Add("ID", 50);
                membersListView.Columns.Add("Last Name", 150);
                membersListView.Columns.Add("First Name", 150);
                membersListView.Columns.Add("Date Of Birth", 100);
                membersListView.Columns.Add("Adress", 150);
                membersListView.Columns.Add("City", 100);
                membersListView.Columns.Add("State", 50);
                membersListView.Columns.Add("ZipCode", 100);
                membersListView.Columns.Add("Country", 150);
                membersListView.Columns.Add("Phone", 150);
                List<Member> searchResult = _memberController.ReturnMembersSearch(searchInt);
                foreach (var dr in searchResult)
                {
                    var membersList = membersListView.Items.Add(dr.Id.ToString());
                    membersList.SubItems.Add(dr.LastName.ToString());
                    membersList.SubItems.Add(dr.FirstName.ToString());
                    if (!Convert.IsDBNull(dr.DateOfBirth))
                    {
                        membersList.SubItems.Add(Convert.ToDateTime(dr.DateOfBirth.ToString()).ToString("MM/dd/yyyy"));
                    }
                    else
                    {
                        membersList.SubItems.Add(dr.DateOfBirth.ToString());
                    }
                    membersList.SubItems.Add(dr.StreetAddress.ToString());
                    membersList.SubItems.Add(dr.City.ToString());
                    membersList.SubItems.Add(dr.State.ToString());
                    membersList.SubItems.Add(dr.ZipCode.ToString());
                    membersList.SubItems.Add(dr.Country.ToString());
                    membersList.SubItems.Add(dr.ContactPhone.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the searchMethodBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void searchMethodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateMembersNameCombobox();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the customerListBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            membersListView.Items.Clear();
        }

        /// <summary>
        /// Handles the Click event of the searchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            membersListView.Clear();
            try
            {
                DisplayMembers(customerListBox.SelectedValue.ToString());
                this.MemberSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.selectedMember = int.Parse(membersListView.SelectedItems[0].SubItems[0].Text);
            EditMemberForm editForm = new EditMemberForm(this);
            DialogResult result = editForm.ShowDialog();
            this.Clear();
        }

        private void MemberListView_Select(object sender, EventArgs e)
        {
            this.MemberSelection();
        }

        private void MemberSelection()
        {
            if (membersListView.SelectedItems.Count > 0)
            {
                this.editButton.Enabled = true;
               
            }
            else
            {
                this.editButton.Enabled = false;
             
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void Clear()
        {
            this.membersListView.Clear();
            this.customerListBox.SelectedIndex = -1;
            this.searchMethodBox.SelectedIndex = -1;
            this.MemberSelection();
            this.customerListBox.Enabled = false;
            this.customerListBox.DataSource = null;
            this.customerListBox.Items.Clear();
            this.searchButton.Enabled = false;

        }

        private void MemberManagement_VisibleChanged(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddMemberForm addForm = new AddMemberForm(this);
            DialogResult result = addForm.ShowDialog();
            this.Clear();
        }
    }
}
