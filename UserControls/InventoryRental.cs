using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.View;

namespace CS6232_Group_6_Store.UserControls
{
    public partial class InventoryRental : UserControl
    {

        private readonly RentalTransactionController _transactionController;
        private readonly MemberController _memberController;
        private readonly FurnitureController _furnitureController;

        public InventoryRental()
        {
            InitializeComponent();

            this._transactionController = new RentalTransactionController();
            this._memberController = new MemberController();
            this._furnitureController = new FurnitureController();

            this.memberSelectionComboBox.SelectedIndex = 0;
            this.memberListView.CheckBoxes = true;
            this.furnitureListView.CheckBoxes = true;
            this.selectionMethodComboBox.SelectedIndex = 0;
            this.addFurnitureButton.Enabled = false;
            this.clearButton.Enabled = false;
            this.cartListView.Enabled = false;
            this.checkoutButton.Enabled = false;
            this.clearFurnitureButton.Enabled = false;
            this.removeItemButton.Enabled = false;
        }

        private void memberSearchButton_Click(object sender, EventArgs e)
        {
            this.populateMemberListView();
        }

        private void populateMemberListView()
        {
            try
            {
                this.memberListView.Clear();
                memberListView.View = System.Windows.Forms.View.Details;
                memberListView.GridLines = true;
                memberListView.Columns.Add("ID", 50);
                memberListView.Columns.Add("Last Name", 150);
                memberListView.Columns.Add("First Name", 150);

                var method = memberSelectionComboBox.Text;
                var search = memberSearchBox.Text;
                List<Member> searchResult = _memberController.SearchMember(method, search);
                foreach (var dr in searchResult)
                {
                    var membersList = memberListView.Items.Add(dr.Id.ToString());
                    membersList.SubItems.Add(dr.LastName.ToString());
                    membersList.SubItems.Add(dr.FirstName.ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void furnitureSearchButton_Click(object sender, EventArgs e)
        {
            this.populateFurnitureListView();
        }

        private void populateFurnitureListView()
        {
            try
            {
                this.furnitureListView.Clear();
                furnitureListView.View = System.Windows.Forms.View.Details;
                furnitureListView.GridLines = true;
                furnitureListView.Columns.Add("ID", 50);
                furnitureListView.Columns.Add("Name", 150);
                furnitureListView.Columns.Add("Description", 150);
                furnitureListView.Columns.Add("Style", 150);
                furnitureListView.Columns.Add("Category", 150);
                furnitureListView.Columns.Add("Daily Rental Rate", 150);

                var method = selectionMethodComboBox.Text;
                var search = furnitureSearchBox.Text;
                List<Furniture> searchResult = _furnitureController.SearchFurniture(method, search);
                foreach (var dr in searchResult)
                {
                    var furnitureList = furnitureListView.Items.Add(dr.Id.ToString());
                    furnitureList.SubItems.Add(dr.Name.ToString());
                    furnitureList.SubItems.Add(dr.Description.ToString());
                    furnitureList.SubItems.Add(dr.Style.ToString());
                    furnitureList.SubItems.Add(dr.Category.ToString());
                    furnitureList.SubItems.Add("$" + dr.RentalRate.ToString());
                }
                this.clearFurnitureButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.clearFurnitureButton.Enabled = false;
            }

        }

        private void memberListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                {
                    foreach (ListViewItem item in memberListView.Items)
                    {
                        // Uncheck all other items
                        if (item != e.Item)
                        {
                            item.Checked = false;
                        }
                    }
                this.checkoutButton.Enabled = true;
                this.clearButton.Enabled = true;
            }
            else
            {
                this.checkoutButton.Enabled = false;
                this.clearButton.Enabled = false;
            }
            if (furnitureListView.CheckedItems.Count > 0 && memberListView.CheckedItems.Count > 0)
                {
                    this.addFurnitureButton.Enabled = true;
                } else
                {
                    this.addFurnitureButton.Enabled= false;
                }
            }

        private void furnitureListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                foreach (ListViewItem item in furnitureListView.Items)
                {
                    // Uncheck all other items
                    if (item != e.Item)
                    {
                        item.Checked = false;
                    }
                }
                
            } 
            if (furnitureListView.CheckedItems.Count > 0 && memberListView.CheckedItems.Count > 0)
            {
                this.addFurnitureButton.Enabled = true;
            }
            else
            {
                this.addFurnitureButton.Enabled = false;
            }

        }


    }
}
