
using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.UserControls
{
    public partial class InventoryReturn : UserControl
    {
        private MemberController _memberController;
        private RentalItemController _rentalItemController;
        private Member _currentMember;
        private List<RentalItem> _currentRentalItemList;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryReturn"/> class.
        /// </summary>
        public InventoryReturn()
        {
            InitializeComponent();
            this._memberController = new MemberController();
            this._currentRentalItemList = new List<RentalItem>();
            this._rentalItemController = new RentalItemController();

            this.memberSelectionComboBox.SelectedIndex = 0;
            this.memberListView.CheckBoxes = true;
            this.furnitureListView.CheckBoxes = true;
            this.addFurnitureButton.Enabled = false;
            this.clearButton.Enabled = false;
            this.returnListView.Enabled = false;
            this.checkoutButton.Enabled = false;
            this.clearFurnitureButton.Enabled = false;
            this.removeItemButton.Enabled = false;
            this.memberSelectButton.Enabled = false;
        }

        /// <summary>
        /// Handles the Click event of the memberSearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.Exception"></exception>
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
                this.memberSelectButton.Enabled = true;
            }
            catch (Exception ex)
            {
                this.errorMemberLabel.Visible = true;
                this.errorMemberLabel.ForeColor = Color.Red;
                this.errorMemberLabel.Text = "Search cannot be blank";
            }
        }

        /// <summary>
        /// Populates the member ListView.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
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

        private void memberSelectButton_Click(object sender, EventArgs e)
        {
            if (this.memberListView.CheckedItems.Count == 1)
            {
                ListViewItem checkedItem = memberListView.CheckedItems[0];
                int memberId = int.Parse(checkedItem.Text);
                _currentMember = _memberController.RetrieveMember(memberId);
                this.errorMemberLabel.Visible = true;
                this._currentRentalItemList = this._rentalItemController.GetOutstandingRentalItemsById(memberId);
                this.PopulateFurnitureListView();
                this.clearFurnitureButton.Enabled = true;
            }
            else if (this.memberListView.CheckedItems.Count > 1)
            {
                this.errorMemberLabel.Text = "Please selet only ONE member at a time.";
                this.errorMemberLabel.Visible = true;
            }
            else
            {
                this.errorMemberLabel.Text = "You must select a member.";
                this.errorMemberLabel.Visible = true;
            }
        }

        private void PopulateFurnitureListView()
        {
            this.errorMemberLabel.Text = "";
            this.errorMemberLabel.Visible = false;
            string errorMessage = null;
            try
            {
                errorMessage = "invalid search";
                this.furnitureListView.Clear();
                this.furnitureListView.View = System.Windows.Forms.View.Details;
                this.furnitureListView.GridLines = true;
                this.furnitureListView.Columns.Add("TransactionID", 50);
                this.furnitureListView.Columns.Add("LineItemID", 50);
                this.furnitureListView.Columns.Add("Furniture Name", 100);
                this.furnitureListView.Columns.Add("Rental Rate", 100);
                this.furnitureListView.Columns.Add("Outstanding", 50);
                this.furnitureListView.Columns.Add("Due Date", 100);

                if (this._currentRentalItemList.Count == 0)
                {
                    errorMessage = "No results found";
                    throw new Exception();
                }
                else
                {
                    foreach (RentalItem dr in this._currentRentalItemList)
                    {
                        var furnitureList = furnitureListView.Items.Add(dr.TransactionId.ToString());
                        furnitureList.SubItems.Add(dr.Id.ToString());
                        furnitureList.SubItems.Add(dr.FurnitureName);
                        furnitureList.SubItems.Add(dr.RentalRate.ToString());

                        int outstanding = dr.Quantity - dr.QuantityReturned;
                        furnitureList.SubItems.Add(outstanding.ToString());
                        furnitureList.SubItems.Add(dr.DueDate.ToString());
                    }
                    this.furnitureListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    this.furnitureListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                }
            }
            catch (Exception ex)
            {
                this.errorMemberLabel.Visible = true;
                this.errorMemberLabel.ForeColor = Color.Red;
                this.errorMemberLabel.Text = errorMessage;
            }

        }

        private void clearFurnitureButton_Click(object sender, EventArgs e)
        {
            this.furnitureListView.Clear();
            this.memberListView.Clear();
            this.memberSearchBox.Text = "";
            this.clearFurnitureButton.Enabled = false;
        }
    }
}
