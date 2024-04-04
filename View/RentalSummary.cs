using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;


namespace CS6232_Group_6_Store.View
{
    public partial class RentalSummary : Form
    {
        private List<RentalItem> _cart;
        private RentalTransaction _transaction;
        private readonly FurnitureController _furnitureController;

        public RentalSummary(List<RentalItem> cart, RentalTransaction transaction)
        {
            InitializeComponent();
            _cart = cart;
            _transaction = transaction;
           
            _furnitureController = new FurnitureController();

            PopulateTotalCostBox();
            refreshCartView();
        }

        private void refreshCartView()
        {
            try
            {
                this.rentalSummaryList.Clear();
                rentalSummaryList.View = System.Windows.Forms.View.Details;
                rentalSummaryList.GridLines = true;
                rentalSummaryList.Columns.Add("Transaction ID", 150);
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
                    cartList.SubItems.Add(dr.Quantity.ToString());
                    TimeSpan timespan = _transaction.DueDate.Subtract(_transaction.RentalDate);
                    int time = (int)timespan.TotalDays;
                    decimal quantityTime = dr.Quantity * time;
                    cartList.SubItems.Add("$" + (Decimal.Multiply(furniture.RentalRate, quantityTime).ToString()));
                    cartList.SubItems.Add(_transaction.RentalDate.ToShortDateString());
                    cartList.SubItems.Add(_transaction.DueDate.ToShortDateString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            

            this.DialogResult = DialogResult.OK;
        }

       
    }
}
