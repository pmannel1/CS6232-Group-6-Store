using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.View;


namespace CS6232_Group_6_Store.UserControls
{
    /// <summary>
    /// Class representing InventoryRental : User Control
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class InventoryRental : UserControl
    {
        public MainDashBoard MainDashBoard { get; set; }

        private readonly RentalTransactionController _transactionController;
        /// <summary>
        /// The MemberController controller class  declaration
        /// </summary>
        private readonly MemberController _memberController;
        /// <summary>
        /// The FurnitureController controller class  declaration
        /// </summary>
        private readonly FurnitureController _furnitureController;
        /// <summary>
        /// The RentalItemController controller class  declaration
        /// </summary>
        private readonly RentalItemController _rentalItemController;
        /// <summary>
        /// Initalizing cart or declaring cart list
        /// </summary>
        List<RentalItem> cart = new List<RentalItem>();
        /// <summary>
        /// The rental transaction variable  declaration
        /// </summary>
        RentalTransaction transaction;
        /// <summary>
        /// The Employee Id variable  declaration
        /// </summary>
        int employeeId;
        /// <summary>
        /// The members Id variable  declaration
        /// </summary>
        int memberId;
        /// <summary>
        /// The Funiture Id variable  declaration
        /// </summary>
        int furnitureId;
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryRental"/> class.
        /// </summary>
        public InventoryRental()
        {
            InitializeComponent();

            this._transactionController = new RentalTransactionController();
            this._memberController = new MemberController();
            this._furnitureController = new FurnitureController();
            this._rentalItemController = new RentalItemController();

            this.furnitureListView.CheckBoxes = true;

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
              
                this.clearButton_Click(sender, e);
            }
            catch (Exception ex)
            {
                this.errorLabel.Visible = true;
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Text = "Search cannot be blank";
            }

        }

        

        /// <summary>
        /// Handles the Click event of the furnitureSearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void furnitureSearchButton_Click(object sender, EventArgs e)
        {
            List<RentalItem> cartItems = cart;
            FunitureSearch detailsfunitureForm = new FunitureSearch();

            if (detailsfunitureForm.ShowDialog() == DialogResult.OK)
            {

                List<Furniture> furnitureList = detailsfunitureForm.searchResult;
                this.populateFurnitureListView(furnitureList);

            }

        }

        /// <summary>
        /// Populate  furniture to the list view.
        /// </summary>
        /// <param name="funituretList">The furnniture list.</param>
        private void populateFurnitureListView(List<Furniture> funituretList)
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


                List<Furniture> searchResult = funituretList;
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
                    this.furnitureListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    this.furnitureListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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


        
        private void furnitureListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int memberID = MainDashBoard.selectedMemberId;

            var method = selectionMethodComboBox.Text.Trim();
            var search = furnitureSearchBox.Text.Trim();
            string message = "invalid search";

            if (method == "")
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
            if (furnitureListView.CheckedItems.Count > 0 &&
             (MainDashBoard.selectedMemberId != 0))
            {
                this.addFurnitureButton.Enabled = true;
            }
            else
            {
                this.addFurnitureButton.Enabled = false;
            }

        }

        /// <summary>
        /// Handles the Click event of the addFurnitureButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addFurnitureButton_Click(object sender, EventArgs e)
        {
            int memberID = MainDashBoard.selectedMemberId;
            ListViewItem checkedItem = furnitureListView.CheckedItems[0];
            int furnitureId = int.Parse(checkedItem.Text);
            Furniture selectedFurniture = _furnitureController.GetFurniture(furnitureId);

            ItemQuantity detailsForm = new ItemQuantity(selectedFurniture);

            if (detailsForm.ShowDialog() == DialogResult.OK)
            {
                int selectedQuantity = detailsForm.SelectedQuantity;
                DateTime dueDate = detailsForm.selectedDueDate;
                if (cartListView.Items.Count < 1)

                {
                    MainDashBoard parentForm = this.FindForm() as MainDashBoard;
                    if (parentForm != null)

                    {
                        employeeId = parentForm.EmployeeId;
                    }
                    var now = DateTime.Now;
                    var dateofReturn = dueDate;
                    transaction = null;
                    transaction = new RentalTransaction(employeeId, MainDashBoard.selectedMemberId, now, dateofReturn);

                }
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
                        DueDate = dueDate,
                        QuantityReturned = 0
                    };

                    cart.Add(cartItem);
                }

                this.refreshCartView();
                this.cartListView.Enabled = true;
                this.checkoutButton.Enabled = true;

            }
        }

        /// <summary>
        /// Referesh or update cart list.
        /// </summary>
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
                cartListView.Columns.Add("Return Date", 150);

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
                this.cartListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.cartListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the ItemChecked event of the cartListView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ItemCheckedEventArgs"/> instance containing the event data.</param>

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

        /// <summary>
        /// Handles the Click event of the checkoutButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
                // Proceed to the summary form if validation passes
                RentalSummary summaryForm = new RentalSummary(cart, transaction);
                var dialogResult = summaryForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {

                    string message = _transactionController.StartNewTransaction(transaction, cart);


                    this.clearButton_Click(sender, e);
                    this.clearFurnitureButton_Click(sender, e);
                    this.furnitureSearchBox.Clear();
                    MessageBox.Show(message, "Transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Transaction canceled .", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during checkout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the updateQuantity control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the removeItemButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void removeItemButton_Click(object sender, EventArgs e)
        {
            if (cartListView.CheckedItems.Count == 1)
            {
                ListViewItem checkedItem = cartListView.CheckedItems[0];
                cart.RemoveAt(checkedItem.Index);
                refreshCartView();
                if (cart.Count == 0)
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

        /// <summary>
        /// Handles the Click event of the clearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.cartListView.Clear();
            this.updateQuantity.Enabled = false;
            this.removeItemButton.Enabled = false;
            this.checkoutButton.Enabled = false;
            this.cart.Clear();
            this.transaction = null;
        }

        /// <summary>
        /// Handles the Click event of the clearFurnitureButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clearFurnitureButton_Click(object sender, EventArgs e)
        {
            this.furnitureListView.Clear();
            this.addFurnitureButton.Enabled = false;

        }
        /// <summary>
        /// Handles the VisibleChanged event of the InventoryRental control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void InventoryRental_VisibleChanged(object sender, EventArgs e)
        {
            this.clearButton_Click(sender, e);
            this.clearFurnitureButton_Click(sender, e);
            this.furnitureSearchBox.Clear();
        }
    }
}
