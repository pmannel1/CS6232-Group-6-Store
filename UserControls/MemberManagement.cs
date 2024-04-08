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
            memberSearchBox.TextChanged += MemberSearchBox_TextChanged;
            memberListView.SelectedIndexChanged += memberListView_SelectedIndexChanged; 
            memberListView.ItemChecked += memberListView_ItemChecked;
        }

        /// <summary>
        /// Displays the members.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <param name="searchParameter">The search parameter.</param>
        public void DisplayMembers(string searchItem)
        {
                if (!int.TryParse(searchItem, out int searchInt))
                {
                    memberErrorLabel.Text = "Invalid search item. Please enter a valid integer ID.";
                    memberErrorLabel.ForeColor = Color.Red;
                    memberErrorLabel.Visible = true;
                    return;
                }

                memberErrorLabel.Visible = false;

                memberListView.Clear();
                memberListView.View = System.Windows.Forms.View.Details;
                memberListView.GridLines = true;
                memberListView.Columns.Add("ID", 50);
                memberListView.Columns.Add("Last Name", 150);
                memberListView.Columns.Add("First Name", 150);
                memberListView.Columns.Add("Date Of Birth", 100);
                memberListView.Columns.Add("Address", 150);
                memberListView.Columns.Add("City", 100);
                memberListView.Columns.Add("State", 50);
                memberListView.Columns.Add("ZipCode", 100);
                memberListView.Columns.Add("Country", 150);
                memberListView.Columns.Add("Phone", 150);

                List<Member> searchResult = _memberController.ReturnMembersSearch(searchInt);

                if (searchResult.Count == 0)
                {
                    memberErrorLabel.Text = "No member found matching the search criteria.";
                    memberErrorLabel.ForeColor = Color.Red;
                    memberErrorLabel.Visible = true;
                    return;
                }

                foreach (var dr in searchResult)
                {
                    var membersList = memberListView.Items.Add(dr.Id.ToString());
                    membersList.SubItems.Add(dr.LastName ?? "");
                    membersList.SubItems.Add(dr.FirstName ?? "");
                    membersList.SubItems.Add(dr.DateOfBirth.ToString("MM/dd/yyyy") ?? "");
                    membersList.SubItems.Add(dr.StreetAddress ?? "");
                    membersList.SubItems.Add(dr.City ?? "");
                    membersList.SubItems.Add(dr.State ?? "");
                    membersList.SubItems.Add(dr.ZipCode.ToString() ?? "");
                    membersList.SubItems.Add(dr.Country ?? "");
                    membersList.SubItems.Add(dr.ContactPhone ?? "");
                }
            }



            /// <summary>
            /// Handles the SelectedIndexChanged event of the customerListBox control.
            /// </summary>
            /// <param name="sender">The source of the event.</param>
            /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
            private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            memberListView.Items.Clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            memberListView.Clear();
            if (string.IsNullOrEmpty(memberSearchBox.Text))
            {
                memberErrorLabel.Text = "Please enter a search term.";
                memberErrorLabel.ForeColor = Color.Red;
                memberErrorLabel.Visible = true;
                return;
            }

            if (searchMethodBox.SelectedItem == null)
            {
                memberErrorLabel.Text = "Please select a search method.";
                memberErrorLabel.ForeColor = Color.Red;
                memberErrorLabel.Visible = true;
                return;
            }

           
            DisplayMembers(memberSearchBox.Text);
                this.MemberSelection();
          

        }
       

        private void EditButton_Click(object sender, EventArgs e)
        {

            if (memberListView.CheckedItems.Count > 0)
            {
                this.selectedMember = int.Parse(memberListView.CheckedItems[0].SubItems[0].Text);
                EditMemberForm editForm = new EditMemberForm(this);
                DialogResult result = editForm.ShowDialog();
                this.Clear();
            }
            else
            { 
                memberErrorLabel.Text = "No Member Selected";
            memberErrorLabel.ForeColor = Color.Red;
            memberErrorLabel.Visible = true;
            }

        }

        private void memberListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                foreach (ListViewItem item in memberListView.Items)
                {
                    if (item != e.Item)
                    {
                        item.Checked = false;
                    }
                }
                this.editButton.Enabled = true;
            }
            else
            {
                this.editButton.Enabled = false;
            }

        }
        private void MemberListView_Select(object sender, EventArgs e)
        {
            this.MemberSelection();
        }

        private void MemberSelection()
        {
            if (memberListView.SelectedItems.Count > 0)
            {
                this.editButton.Enabled = true;

            }
            else
            {
                this.editButton.Enabled = true;

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
        private void memberListView_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  this.Clear();
        }

        private void Clear()
        {
            this.memberListView.Clear();
            this.searchMethodBox.SelectedIndex = -1;
            this.MemberSelection();
       
            this.searchButton.Enabled = false;

        }

        private void MemberManagement_VisibleChanged(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void MemberSearchBox_TextChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = !string.IsNullOrEmpty(memberSearchBox.Text);
        }

        private void MemberListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = memberListView.SelectedItems.Count > 0;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            AddMemberForm addForm = new AddMemberForm(this);
            DialogResult result = addForm.ShowDialog();
            this.Clear();
        }
    }
}