using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;


namespace CS6232_Group_6_Store.UserControls
{
    /// <summary>
    /// Class representing MemeberMangement : User Control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class MemberManagement : UserControl
    {
        private readonly MemberController _memberController;
        public MemberManagement()
        {
            InitializeComponent();
            this._memberController = new MemberController();
            this.searchMessageLabel.Hide();
            this.searchMethodLabel.Hide();
        }

        /// <summary>
        /// Clears the data.
        /// </summary>
        public void ClearData()
        {
            membersListView.Clear();
            searchBox.Text = "";
            searchMethodBox.Text = "";
            PopulateMembersNameCombobox();
            this.searchMessageLabel.Hide();
            this.searchMethodLabel.Hide();
        }

        /// <summary>
        /// Populates the members name combobox.
        /// </summary>
        public void PopulateMembersNameCombobox()
        {

            List<Member> memberList = this._memberController.ReturnMembersName();
            try
            {
                customerListBox.Items.Clear();
                Member member;
                for (int i = 0; i < memberList.Count; i++)
                {
                    member = memberList[i];
                    customerListBox.Items.Add(member.LastName.ToString() + " " + member.FirstName);
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
        public void DisplauMembes(string searchMethod, string searchParameter)
        {
            try
            {
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
                List<Member> searchResult = _memberController.RetrunMembers(searchMethod, searchParameter);
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
            searchBox.Text = "";
            PopulateMembersNameCombobox();
            this.searchMethodLabel.Hide();
            this.searchMessageLabel.Hide();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the customerListBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Text = customerListBox.Text;
            //DisplauMembes("Name", searchBox.Text);
        }

        /// <summary>
        /// Handles the TextChanged event of the searchBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.searchMessageLabel.Text = "";
            this.searchMessageLabel.Hide();
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
                if (searchMethodBox.Text == "")
                {
                    this.searchMethodLabel.Text = "Please select search method";
                    this.searchMethodLabel.ForeColor = Color.Red;
                    this.searchMethodLabel.Show();
                    return;
                }

                if (searchMethodBox.Text == "Id")
                {
                    if (!int.TryParse(searchBox.Text, out int id) || id <= 0)
                    {
                        this.searchMessageLabel.Text = "Invalid Customer ID, only positive integers.";
                        this.searchMessageLabel.ForeColor = Color.Red;
                        this.searchMessageLabel.Show();
                        return;
                    }
                }
                if (searchMethodBox.Text == "Name")
                {
                    if (customerListBox.Text == "" && searchBox.Text.Trim() == "")
                    {
                        this.searchMessageLabel.Text = "Please specift customer name";
                        this.searchMessageLabel.ForeColor = Color.Red;
                        this.searchMessageLabel.Show();
                        return;
                    }
                    // if customer is selected from dropdown and
                    // not typed in search box set searchbox with customer dropdown selection
                    if (customerListBox.Text != "" || searchBox.Text.Trim() == "")
                    {
                        searchBox.Text = customerListBox.Text.Trim();
                    }

                    if (searchBox.Text.IndexOf(" ") == searchBox.Text.Length || searchBox.Text.IndexOf(" ") == -1)
                    {
                        this.searchMessageLabel.Text = "Customer last name and first name is rquired. Last name " +
                            "and first name should be separated by blank space";
                        this.searchMessageLabel.ForeColor = Color.Red;
                        this.searchMessageLabel.Show();
                        return;
                    }

                }
                if (searchMethodBox.Text == "Phone")
                {
                    if (searchBox.Text == "")
                    {
                        this.searchMessageLabel.Text = "Invalid contact phone";
                        this.searchMessageLabel.ForeColor = Color.Red;
                        this.searchMessageLabel.Show();
                        return;
                    }
                }

                DisplauMembes(searchMethodBox.Text, searchBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Handles the Load event of the MemberManagement control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MemberManagement_Load(object sender, EventArgs e)
        {
            PopulateMembersNameCombobox();
        }
    }
}
