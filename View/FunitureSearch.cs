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

namespace CS6232_Group_6_Store.View
{
    /// <summary>
    /// Funiture Search form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FunitureSearch : Form
    {
        /// <summary>
        /// Declare FurnitureController controller class.
        /// </summary>
        private readonly FurnitureController _furnitureController;

        /// <summary>
        /// Declare Furniture model class list.
        /// </summary>
        public List<Furniture> searchResult = new List<Furniture>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunitureSearch"/> class.
        /// </summary>
        public FunitureSearch()
        {
            InitializeComponent();
            this._furnitureController = new FurnitureController();
            this.selectionMethodComboBox.SelectedIndex = 0;
            this.addButton.Enabled = false;
        }


        /// <summary>
        /// Populate  furniture to the list view.
        /// </summary>
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
                furnitureListView.Columns.Add("Instock Quantity", 120);
                furnitureListView.Columns.Add("Total Quantity", 120);
                var method = selectionMethodComboBox.Text;
                var search = furnitureSearchComboBox.Text;
                List<Furniture> searchResult = _furnitureController.SearchFurniture(method, search);
                if (searchResult.Count == 0)
                {
                    errorMessage = "No results found";
                    this.addButton.Enabled = false;
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
                        furnitureList.SubItems.Add(dr.InStockNumber.ToString());
                        furnitureList.SubItems.Add(dr.TotalStockNumber.ToString());
                    }
                    this.furnitureListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    this.furnitureListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    this.clearFurnitureButton.Enabled = true;
                    this.addButton.Enabled = true;
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

        /// <summary>
        /// Populate  dropdown box by category or style list.
        /// </summary>
        private void populateFurnitureCategoryStyle()
        {
            this.errorLabel.Visible = false;

            try
            {

                this.furnitureSearchComboBox.Items.Clear();
                var method = selectionMethodComboBox.Text;
                List<string> dropdownList = _furnitureController.ReturnFurnituresCategoyOrStyle(method);
                for (int i = 0; i < dropdownList.Count; i++)
                {
                    this.furnitureSearchComboBox.Items.Add(dropdownList[i]);
                }
                this.furnitureSearchComboBox.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Handles the Click event of the furnitureSearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void furnitureSearchButton_Click(object sender, EventArgs e)
        {
            var method = selectionMethodComboBox.Text.Trim();
            var search = furnitureSearchComboBox.Text.Trim();
            string message = "invalid search";
            if (method == "")
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (furnitureSearchComboBox.Text == "")
            {
                if (selectionMethodComboBox.Text == "ID")
                {
                    message = "Please specify ID to search";
                }
                else if (selectionMethodComboBox.Text == "Category")
                {
                    message = "Please specify Category to search";
                }
                else if (selectionMethodComboBox.Text == "Style")
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
                if (int.TryParse(furnitureSearchComboBox.Text, out _) == false)
                {
                    this.errorLabel.Visible = true;
                    this.errorLabel.ForeColor = Color.Red;
                    this.errorLabel.Text = message;
                    return;
                }
            }
            this.populateFurnitureListView();

        }

        /// <summary>
        /// Handles the Click event of the addButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            var method = selectionMethodComboBox.Text;
            var search = furnitureSearchComboBox.Text;
            searchResult = this._furnitureController.SearchFurniture(method, search);

            this.DialogResult = DialogResult.OK;
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
        /// <summary>
        /// Handles the Click event of the clearFurnitureButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        private void clearFurnitureButton_Click(object sender, EventArgs e)
        {
            this.furnitureListView.Clear();
            this.addButton.Enabled = false;
        }


       

        /// <summary>
        /// Handles the select index changed event of the selectionMethodComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void selectionMethodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectionMethodComboBox.Text == "Category" || selectionMethodComboBox.Text == "Style")
            {

                populateFurnitureCategoryStyle();
            }
            else
            {
                furnitureSearchComboBox.Items.Clear();
                furnitureSearchComboBox.DataSource = null;
            }
        }
    }
}
