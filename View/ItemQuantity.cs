﻿

using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.Controller;

namespace CS6232_Group_6_Store.View
{
    public partial class ItemQuantity : Form
    {
        public int SelectedQuantity { get; private set; }
        public DateTime selectedDueDate { get; private set; }
        private Furniture _furniture;
        private RentalItem _rentalItem;
        private readonly FurnitureController furnitureController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemQuantity"/> class.
        /// </summary>
        /// <param name="furniture">The furniture.</param>
        public ItemQuantity(Furniture furniture)
        {
            InitializeComponent();
            _furniture = furniture;
            DisplayFurnitureDetails();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ItemQuantity"/> class.
        /// </summary>
        /// <param name="rental">The rental.</param>
        public ItemQuantity(RentalItem rental)
        {
            this.furnitureController = new FurnitureController();

            InitializeComponent();
            _rentalItem = rental;
            DisplayRentalDetails();

        }

        /// <summary>
        /// Displays the furniture details.
        /// </summary>
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

        /// <summary>
        /// Displays the rental details.
        /// </summary>
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

        /// <summary>
        /// Handles the Click event of the confirmButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (dateOfReturnPicker.Value <= DateTime.Now)

            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Due date should be greater than current date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else

            {
                SelectedQuantity = int.Parse(quantityComboBox.SelectedItem.ToString());
                selectedDueDate = dateOfReturnPicker.Value;
                this.DialogResult = DialogResult.OK;

            }
        }

        /// <summary>
        /// Handles the Click event of the cancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void dateOfReturnPicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
