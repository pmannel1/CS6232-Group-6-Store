using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;

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

        /// <summary>
        /// Handles the Click event of the memberSearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void memberSearchButton_Click(object sender, EventArgs e)
        {
            this.populateMemberListView();
        }

        /// <summary>
        /// Populates the member ListView.
        /// </summary>
        private void populateMemberListView()
        {
            transactionErrorLabel.Visible = false; // Hide error label initially

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
                    this.transactionErrorLabel.Text = "Input valid data for ID";
                    return;
                }
                this.transactionErrorLabel.Text = "";
                List<Member> searchResult = _memberController.SearchMember(method, search);

                if (searchResult.Count == 0)
                {
                    transactionErrorLabel.Text = "No matching records found.";
                    transactionErrorLabel.ForeColor = Color.Red;
                    transactionErrorLabel.Visible = true;
                    return;
                }

                if (memberSearchBox.Text.Length > 0) 
                {
                    transactionErrorLabel.Text = "Please input a number for ID/Name for Name";
                    transactionErrorLabel.ForeColor = Color.Red;
                    transactionErrorLabel.Visible = true;
                }

                foreach (var dr in searchResult)
                {
                    var membersList = memberListView.Items.Add(dr.Id.ToString());
                    membersList.SubItems.Add(dr.LastName.ToString());
                    membersList.SubItems.Add(dr.FirstName.ToString());
                }
            }
            catch (Exception ex)
            {
                transactionErrorLabel.Text = $"An error occurred: {ex.Message}";
                transactionErrorLabel.ForeColor = Color.Red;
                transactionErrorLabel.Visible = true;
            }
        }

        /// <summary>
        /// Handles the ItemChecked event of the memberListView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ItemCheckedEventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the memberHistorySearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the clearMemberSearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clearMemberSearchButton_Click(object sender, EventArgs e)
        {
            this.memberListView.Clear();
            this.memberSearchBox.Clear();
            this.memberHistorySearchButton.Enabled = false;
            this.memberHistoryListView.Clear();
        }

        /// <summary>
        /// Handles the Click event of the clearMemberHistorySearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clearMemberHistorySearchButton_Click(object sender, EventArgs e)
        {
            this.memberHistoryListView.Clear();
        }
    }
}
