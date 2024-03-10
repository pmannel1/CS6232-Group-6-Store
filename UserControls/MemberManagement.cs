using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6232_Group_6_Store.UserControls
{
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

        private void searchMethodBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Text = "";
            PopulateMembersNameCombobox();
            this.searchMethodLabel.Hide();
            this.searchMessageLabel.Hide();
        }

        private void customerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBox.Text = customerListBox.Text;
            //DisplauMembes("Name", searchBox.Text);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            this.searchMessageLabel.Text = "";
            this.searchMessageLabel.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

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
                        searchBox.Text = customerListBox.Text;
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

        private void MemberManagement_Load(object sender, EventArgs e)
        {
            PopulateMembersNameCombobox();
        }
    }
}
