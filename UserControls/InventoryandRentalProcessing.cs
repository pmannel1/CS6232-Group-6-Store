using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6232_Group_6_Store.UserControls
{
    public partial class InventoryandRentalProcessing : UserControl
    {
        private readonly FurnitureController _furnitureController;
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryandRentalProcessing"/> class.
        /// </summary>
        public InventoryandRentalProcessing()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            //this.searchButton.Enabled = false;
        }

     
        /// <summary>
        /// Displaus the funiture.
        /// </summary>
        /// <param name="searchMethod">The search method.</param>
        /// <param name="searchParameter">The search parameter.</param>
        public void DisplayFurnitures(string searchItem)
        {
            try
            {
                string searchMethod = searchMethodBox.Text;
                furnituresListView.Clear();
                furnituresListView.View = System.Windows.Forms.View.Details;
                furnituresListView.GridLines = true;
                furnituresListView.Columns.Add("ID", 50);
                furnituresListView.Columns.Add("Name", 150);
                furnituresListView.Columns.Add("Description", 300);
                furnituresListView.Columns.Add("Style", 150);
                furnituresListView.Columns.Add("Category", 150);
                furnituresListView.Columns.Add("Rental rate", 150);
                furnituresListView.Columns.Add("Instock Number", 150);

                List<Furniture> searchResult = _furnitureController.SearchFurniture(searchMethod, searchItem);
                foreach (var dr in searchResult)
                {
                    var furnitureList = furnituresListView.Items.Add(dr.Id.ToString());
                    furnitureList.SubItems.Add(dr.Name.ToString());
                    furnitureList.SubItems.Add(dr.Description.ToString());
                    furnitureList.SubItems.Add(dr.Style.ToString());
                    furnitureList.SubItems.Add(dr.Category.ToString());
                    furnitureList.SubItems.Add(dr.RentalRate.ToString());
                    furnitureList.SubItems.Add(dr.InStockNumber.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            this.furnituresListView.Clear();
            this.searchMethodBox.SelectedIndex = -1;
            

        }
        /// <summary>
        /// Handles the Click event of the searchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (furnitureBox.Text.Trim() == "" || searchMethodBox.Text == "")
            {
                MessageBox.Show($"please select search method and/or specify search value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            furnituresListView.Clear();
            try
            {
                DisplayFurnitures(furnitureBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Handles the SelectedIndexChanged event of the furnitureListBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void furnitureListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            furnituresListView.Items.Clear();
        }

       
    }
}
