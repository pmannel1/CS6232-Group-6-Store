using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.View;

namespace CS6232_Group_6_Store.UserControls
{
    public partial class TransactionManagement : UserControl
    {

        private readonly MemberController _memberController;
        private readonly RentalItemController _rentalItemController;

        public TransactionManagement()
        {
            InitializeComponent();
            this._memberController = new MemberController();
            this._rentalItemController = new RentalItemController();

            this.memberHistorySearchButton.Enabled = false;
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

                var method = memberSearchMethodComboBox.Text;
                var search = memberSearchBox.Text;
                var searchToInt = 0;

                if (memberSearchMethodComboBox.Text.Equals("ID") && !int.TryParse(search, out searchToInt))
                {
                    this.memberSearchButtonError.Text = "Input valid data for ID";
                    return;
                }
                this.memberSearchButtonError.Text = "";
                List<Member> searchResult = _memberController.SearchMember(method, search);
                foreach (var dr in searchResult)
                {
                    var membersList = memberListView.Items.Add(dr.Id.ToString());
                    membersList.SubItems.Add(dr.LastName.ToString());
                    membersList.SubItems.Add(dr.FirstName.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                this.memberHistorySearchButton.Enabled = true;
            }
            else
            {
                this.memberHistorySearchButton.Enabled = false;
            }
        }

        private void memberHistorySearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.memberHistoryListView.Clear();
                this.memberHistoryListView.View = System.Windows.Forms.View.Details;
                this.memberHistoryListView.GridLines = true;
                this.memberHistoryListView.Columns.Add("Transaction ID", 50);
                this.memberHistoryListView.Columns.Add("Rental Date", 150);
                this.memberHistoryListView.Columns.Add("Due Date", 150);
                this.memberHistoryListView.Columns.Add("Item Name", 100);
                this.memberHistoryListView.Columns.Add("Quantity", 150);
                this.memberHistoryListView.Columns.Add("Rental Rate", 100);
                this.memberHistoryListView.Columns.Add("Quantity Returned", 50);

                ListViewItem checkedItem = memberListView.CheckedItems[0];
                int id = int.Parse(checkedItem.Text);
                List<RentalItem> searchResult = this._rentalItemController.GetMemberRentalItemHistory(id);
                foreach (var dr in searchResult)
                {
                    var furnitureList = memberHistoryListView.Items.Add(dr.TransactionId.ToString());
                    furnitureList.SubItems.Add(dr.RentalDate.ToShortDateString());
                    furnitureList.SubItems.Add(dr.DueDate.ToShortDateString());
                    furnitureList.SubItems.Add(dr.FurnitureName.ToString());
                    furnitureList.SubItems.Add(dr.Quantity.ToString());
                    furnitureList.SubItems.Add("$" + dr.RentalRate.ToString());
                    furnitureList.SubItems.Add(dr.QuantityReturned.ToString());
                }
                this.memberHistoryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.memberHistoryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearMemberSearchButton_Click(object sender, EventArgs e)
        {
            this.memberListView.Clear();
            this.memberSearchBox.Clear();
            this.memberHistorySearchButton.Enabled = false;
            this.memberHistoryListView.Clear();
        }

        private void clearMemberHistorySearchButton_Click(object sender, EventArgs e)
        {
            this.memberHistoryListView.Clear();
        }
    }
}
