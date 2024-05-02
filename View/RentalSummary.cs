using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;


namespace CS6232_Group_6_Store.View
{
    /// <summary>
    /// Rental summary form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RentalSummary : Form
    {
        /// <summary>
        /// RentalItem list variable  declaration
        /// </summary>
        private List<RentalItem> _cart;
        /// <summary>
        /// RentalTransaction variable  declaration
        /// </summary>
        private RentalTransaction _transaction;
        /// <summary>
        /// Declare FurnitureController controller class.
        /// </summary>
        private readonly FurnitureController _furnitureController;
        /// <summary>
        /// Declare DialogResult variable.
        /// </summary>
        private DialogResult _dialogResult;

        /// <summary>
        /// Initializes a new instance of the <see cref="RentalSummary"/> class.
        /// </summary>
        /// <param name="cart">The cart.</param>
        /// <param name="transaction">The transaction.</param>
        public RentalSummary(List<RentalItem> cart, RentalTransaction transaction)
        {
            InitializeComponent();
            _cart = cart;
            _transaction = transaction;

            _furnitureController = new FurnitureController();

            PopulateTotalCostBox();
            refreshCartView();
        }

        /// <summary>
        /// Refreshes the cart view.
        /// </summary>
        private void refreshCartView()
        {
            try
            {
                this.rentalSummaryList.Clear();
                rentalSummaryList.View = System.Windows.Forms.View.Details;
                rentalSummaryList.GridLines = true;
                rentalSummaryList.Columns.Add("Transaction ID", 1);
                rentalSummaryList.Columns.Add("Furniture ID", 150);
                rentalSummaryList.Columns.Add("Furniture Name", 150);
                rentalSummaryList.Columns.Add("Quantity", 150);
                rentalSummaryList.Columns.Add("Price", 150);
                rentalSummaryList.Columns.Add("Rental Date", 150);
                rentalSummaryList.Columns.Add("Due Date", 150);

                foreach (var dr in _cart)
                {
                    Furniture furniture = null;
                    furniture = this._furnitureController.GetFurniture(dr.FurnitureId);
                    var cartList = rentalSummaryList.Items.Add(_transaction.Id.ToString());
                    cartList.SubItems.Add(furniture.Id.ToString());
                    cartList.SubItems.Add(furniture.Name.ToString());
                    cartList.SubItems.Add(dr.Quantity.ToString());
                    TimeSpan timespan = _transaction.DueDate.Subtract(_transaction.RentalDate);
                    int time = (int)timespan.TotalDays;
                    decimal quantityTime = dr.Quantity * time;
                    cartList.SubItems.Add("$" + (Decimal.Multiply(furniture.RentalRate, quantityTime).ToString()));
                    cartList.SubItems.Add(_transaction.RentalDate.ToShortDateString());
                    cartList.SubItems.Add(_transaction.DueDate.ToShortDateString());
                }
                this.rentalSummaryList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.rentalSummaryList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                this.rentalSummaryList.Columns[0].Width = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// calculate total cost and set the value in totalcostBox.
        /// </summary>
        private void PopulateTotalCostBox()
        {
            decimal totalCost = 0;
            TimeSpan rentalPeriod = _transaction.DueDate - _transaction.RentalDate;
            int rentalDays = rentalPeriod.Days;

            foreach (var item in _cart)
            {
                Furniture furniture = _furnitureController.GetFurniture(item.FurnitureId);
                totalCost += item.Quantity * furniture.RentalRate * rentalDays;
            }

            totalCostBox.Text = totalCost.ToString("C");
        }

        /// <summary>
        /// Handles the Click event of the confirmButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void confirmButton_Click(object sender, EventArgs e)
        {

            this._dialogResult = DialogResult.OK;
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._dialogResult = DialogResult.Cancel;
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Handles the FormClosed event of the RentalSummary form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        private void RentalSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = this._dialogResult;
        }
    }
}
