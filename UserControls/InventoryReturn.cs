
using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.UserControls
{
    public partial class InventoryReturn : UserControl
    {
        private MemberController _memberController;

        public InventoryReturn()
        {
            InitializeComponent();
            this._memberController = new MemberController();
        }

        private void memberSearchButton_Click(object sender, EventArgs e)
        {
            this.errorMemberLabel.Visible = false;
            try
            {
                if (String.IsNullOrEmpty(this.memberSearchBox.Text))
                {
                    throw new Exception();
                }
                this.populateMemberListView();
            }
            catch (Exception ex)
            {
                this.errorMemberLabel.Visible = true;
                this.errorMemberLabel.ForeColor = Color.Red;
                this.errorMemberLabel.Text = "Search cannot be blank";
            }
        }

        private void populateMemberListView()
        {
            this.errorMemberLabel.Visible = false;
            string errorMessage = null;
            try
            {
                errorMessage = "invalid search";
                this.memberListView.Clear();
                memberListView.View = System.Windows.Forms.View.Details;
                memberListView.GridLines = true;
                memberListView.Columns.Add("ID", 50);
                memberListView.Columns.Add("Last Name", 150);
                memberListView.Columns.Add("First Name", 150);

                var method = memberSelectionComboBox.Text;
                var search = memberSearchBox.Text;
                List<Member> searchResult = _memberController.SearchMember(method, search);
                if (searchResult.Count == 0)
                {
                    errorMessage = "No results found";
                    throw new Exception();
                }
                else
                {
                    foreach (var dr in searchResult)
                    {
                        var membersList = memberListView.Items.Add(dr.Id.ToString());
                        membersList.SubItems.Add(dr.LastName.ToString());
                        membersList.SubItems.Add(dr.FirstName.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                this.errorMemberLabel.Visible = true;
                this.errorMemberLabel.ForeColor = Color.Red;
                this.errorMemberLabel.Text = errorMessage;
            }

        }
    }
}
