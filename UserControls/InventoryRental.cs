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
        private readonly RentalItemController _rentalItemController;
        List<RentalItem> cart = new List<RentalItem>();
        RentalTransaction transaction;
        int employeeId;
        int memberId;
        int furnitureId;

        public InventoryRental()
        {
            InitializeComponent();

            this._transactionController = new RentalTransactionController();
            this._memberController = new MemberController();
            this._furnitureController = new FurnitureController();
            this._rentalItemController = new RentalItemController();

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
            this.errorLabel.Visible = false;
            try
            {
                if (String.IsNullOrEmpty(this.memberSearchBox.Text)){
                    throw new Exception();
                }
                this.populateMemberListView();
                this.clearButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                this.errorLabel.Visible = true;
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Text = "Search cannot be blank";
            }
            
        }

        private void populateMemberListView()
        {
            this.errorLabel.Visible = false;
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
                this.errorLabel.Visible = true;
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Text = errorMessage;
            }

        }

        private void furnitureSearchButton_Click(object sender, EventArgs e)
        {
            var method = selectionMethodComboBox.Text.Trim();
            var search = furnitureSearchBox.Text.Trim();
            string message = "invalid search";
            if (method == "")
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (furnitureSearchBox.Text == "")
            {
                if(selectionMethodComboBox.Text =="ID")
                {
                   message = "Please specify ID to search";
                }
                else if(selectionMethodComboBox.Text == "Category")
                {
                    message = "Please specify Category to search";
                }
                else if(selectionMethodComboBox.Text == "Style")
                {
                    message = "Please specify Style to search";
                }
                this.errorLabel.Visible = true;
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Text = message;
                return;
            }
            if (selectionMethodComboBox.Text == "ID")
            {
                if (int.TryParse(furnitureSearchBox.Text, out _) == false)
                {
                    this.errorLabel.Visible = true;
                    this.errorLabel.ForeColor = Color.Red;
                    this.errorLabel.Text = message;
                    return;
                }
            }
            this.populateFurnitureListView();
        }

        private void populateFurnitureListView()
        {
            this.errorLabel.Visible = false;
            string errorMessage = null;
            try
            {
                errorMessage = "invalid search";
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
                if (searchResult.Count == 0)
                {
                    errorMessage = "No results found";
                    throw new Exception();
                }
                else
                {
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

            }
            catch (Exception ex)
            {
                this.errorLabel.Visible = true;
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Text = errorMessage;
                this.clearFurnitureButton.Enabled = false;
            }

        }

        private void memberListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                memberId = int.Parse(e.Item.Text);
                foreach (ListViewItem item in memberListView.Items)
                {
                    // Uncheck all other items
                    if (item != e.Item)
                    {
                        item.Checked = false;
                    }
                }

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
            }
            else
            {
                this.addFurnitureButton.Enabled = false;
            }
        }

        private void furnitureListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                furnitureId = int.Parse(e.Item.Text);
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

        private void addFurnitureButton_Click(object sender, EventArgs e)
        {
            ListViewItem checkedItem = furnitureListView.CheckedItems[0];
            int furnitureId = int.Parse(checkedItem.Text);
            Furniture selectedFurniture = _furnitureController.GetFurniture(furnitureId);

            ItemQuantity detailsForm = new ItemQuantity(selectedFurniture);

            if (detailsForm.ShowDialog() == DialogResult.OK)
            {
                if (cartListView.Items.Count < 1)
                {
                    MainDashBoard parentForm = this.FindForm() as MainDashBoard;
                    if (parentForm != null)
                    {
                        employeeId = parentForm.EmployeeId;
                    }
                    var now = DateTime.Now;
                    var threeWeeksFromNow = DateTime.Now.AddDays(21);

                    transaction = null;
                    transaction = new RentalTransaction(employeeId, memberId, now, threeWeeksFromNow);
                }
                int selectedQuantity = detailsForm.SelectedQuantity;
                // Check if the item is already in the cart
                var existingCartItem = cart.FirstOrDefault(ci => ci.FurnitureId == furnitureId);
                if (existingCartItem != null)
                {
                    // If the item is already in the cart, just update the quantity
                    existingCartItem.Quantity += selectedQuantity;
                }
                else
                {
                    // If the item is not in the cart, add it as a new item
                    RentalItem cartItem = new RentalItem
                    {
                        TransactionId = transaction.Id,
                        FurnitureId = furnitureId,
                        Quantity = selectedQuantity,
                        QuantityReturned = 0
                    };

                    cart.Add(cartItem);
                }

                this.refreshCartView();
                this.cartListView.Enabled = true;
                this.checkoutButton.Enabled = true;

            }
        }

        private void refreshCartView()
        {
            try
            {
                this.cartListView.Clear();
                cartListView.View = System.Windows.Forms.View.Details;
                cartListView.GridLines = true;
                cartListView.Columns.Add("Furniture Name", 150);
                cartListView.Columns.Add("Quantity", 150);
                cartListView.Columns.Add("Price", 150);
                cartListView.Columns.Add("Rental Date", 150);
                cartListView.Columns.Add("Due Date", 150);

                foreach (var dr in cart)
                {
                    Furniture furniture = null;
                    furniture = this._furnitureController.GetFurniture(dr.FurnitureId);
                    var cartList = cartListView.Items.Add(furniture.Name);
                    cartList.SubItems.Add(dr.Quantity.ToString());
                    TimeSpan timespan = transaction.DueDate.Subtract(transaction.RentalDate);
                    int time = (int)timespan.TotalDays;
                    decimal quantityTime = dr.Quantity * time;
                    cartList.SubItems.Add("$" + (Decimal.Multiply(furniture.RentalRate, quantityTime).ToString()));
                    cartList.SubItems.Add(transaction.RentalDate.ToShortDateString());
                    cartList.SubItems.Add(transaction.DueDate.ToShortDateString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cartListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            this.errorLabel.Visible = false;
            if (e.Item.Checked)
            {
                foreach (ListViewItem item in cartListView.Items)
                {
                    // Uncheck all other items
                    if (item != e.Item)
                    {
                        item.Checked = false;
                    }
                }
                this.removeItemButton.Enabled = true;
                this.updateQuantity.Enabled = true;
            }
            else
            {
                this.removeItemButton.Enabled = false;
                this.updateQuantity.Enabled = false;
            }

        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var cartItem in cart)
                {
                    Furniture furniture = _furnitureController.GetFurniture(cartItem.FurnitureId);
                    if (cartItem.Quantity > furniture.InStockNumber)
                    {
                        // The order exceeds the inventory
                        MessageBox.Show($"The order exceeds the inventory for {furniture.Name}.", "Inventory Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Stop processing the checkout
                    }
                }

                transaction.Id = _transactionController.StartNewTransaction(transaction);

                foreach (var item in cart)
                {
                    item.TransactionId = transaction.Id;
                    _rentalItemController.AddRentalItem(item);
                }

                // Proceed to the summary form if validation passes
                RentalSummary summaryForm = new RentalSummary(cart, transaction);
                var dialogResult = summaryForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    this.clearButton_Click(sender, e);
                    this.clearFurnitureButton_Click(sender, e);
                    this.memberListView.Clear();
                    this.furnitureSearchBox.Clear();
                    this.memberSearchBox.Clear();
                    MessageBox.Show("Transaction completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateQuantity_Click(object sender, EventArgs e)
        {
            ListViewItem checkedItem = cartListView.CheckedItems[0];
            int index = checkedItem.Index;
            RentalItem selectedItem = cart[index];

            ItemQuantity quantityForm = new ItemQuantity(selectedItem);

            if (quantityForm.ShowDialog() == DialogResult.OK)
            {
                int newQuantity = quantityForm.SelectedQuantity;
                if (newQuantity > 0)
                {
                    selectedItem.Quantity = newQuantity;
                    refreshCartView();
                }
            }
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (cartListView.CheckedItems.Count == 1)
            {
                ListViewItem checkedItem = cartListView.CheckedItems[0];
                cart.RemoveAt(checkedItem.Index);
                refreshCartView();
                if(cart.Count == 0) 
                {
                    this.checkoutButton.Enabled = false;
                }
            }
            else
            {
                this.errorLabel.Visible = true;
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Text = "Please select an item to remove";
                this.clearFurnitureButton.Enabled = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.cartListView.Clear();
            this.updateQuantity.Enabled = false;
            this.removeItemButton.Enabled = false;
            this.checkoutButton.Enabled = false;
            this.cart.Clear();
            this.transaction = null;
        }

        private void clearFurnitureButton_Click(object sender, EventArgs e)
        {
            this.furnitureListView.Clear();
            this.addFurnitureButton.Enabled = false;

        }

        private void InventoryRental_VisibleChanged(object sender, EventArgs e)
        {
            this.clearButton_Click(sender, e);
            this.clearFurnitureButton_Click(sender, e);
            this.memberListView.Clear();
            this.furnitureSearchBox.Clear();
            this.memberSearchBox.Clear();
        }
    }
}
