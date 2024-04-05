

using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.Controller;

namespace CS6232_Group_6_Store.View
{
    public partial class ItemQuantity : Form
    {
        public int SelectedQuantity { get; private set; }
        private Furniture _furniture;
        private RentalItem _rentalItem;
        private readonly FurnitureController furnitureController;

        public ItemQuantity(Furniture furniture)
        {
            InitializeComponent();
            _furniture = furniture;
            DisplayFurnitureDetails();
        }

        public ItemQuantity(RentalItem rental)
        {
            this.furnitureController = new FurnitureController();

            InitializeComponent();
            _rentalItem = rental;
            DisplayRentalDetails();
            
        }

        private void DisplayFurnitureDetails()
        {
            nameBox.Text = _furniture.Name;
            descriptionBox.Text = _furniture.Description;

            int inStock = _furniture.InStockNumber;

            for (int i = 1; i <= inStock; i++)
            {
                quantityComboBox.Items.Add(i);
            }

            if (inStock > 0)
            {
                quantityComboBox.SelectedIndex = 0;
            }
            else
            {
                quantityComboBox.Enabled = false;
                confirmButton.Enabled = false;
                descriptionBox.Text += "\n OUT OF STOCK";
            }
        }

        private void DisplayRentalDetails()
        {
            Furniture furniture = this.furnitureController.GetFurniture(_rentalItem.FurnitureId);
            nameBox.Text = furniture.Name;
            descriptionBox.Text = furniture.Description;

            int inStock = furniture.InStockNumber;

            for (int i = 1; i <= inStock; i++)
            {
                quantityComboBox.Items.Add(i);
            }

            if (inStock > 0)
            {
                quantityComboBox.SelectedIndex = _rentalItem.Quantity - 1;
            }
            else
            {
                quantityComboBox.Enabled = false;
                confirmButton.Enabled = false;
                descriptionBox.Text += "\n OUT OF STOCK";
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SelectedQuantity = int.Parse(quantityComboBox.SelectedItem.ToString());
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
