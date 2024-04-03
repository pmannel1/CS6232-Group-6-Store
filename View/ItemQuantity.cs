

using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.View
{
    public partial class ItemQuantity : Form
    {
        public int SelectedQuantity { get; private set; }
        private Furniture _furniture;

        public ItemQuantity(Furniture furniture)
        {
            InitializeComponent();
            _furniture = furniture;
            DisplayFurnitureDetails();
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
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            SelectedQuantity = int.Parse(quantityComboBox.SelectedItem.ToString());
            this.DialogResult = DialogResult.OK;
        }
    }
}
