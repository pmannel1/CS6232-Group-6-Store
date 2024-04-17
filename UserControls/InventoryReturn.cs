﻿
using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.View;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Transactions;
using System.Data.Common;

namespace CS6232_Group_6_Store.UserControls
{
    public partial class InventoryReturn : UserControl
    {
        private MemberController _memberController;
        private RentalItemController _rentalItemController;
        private Member _currentMember;
        private List<RentalItem> _currentRentalItemList;
        private List<ReturnItem> _returnCartList;
        private int furnitureId;
        private int employeeId;
        private int memberId;

        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryReturn"/> class.
        /// </summary>
        public InventoryReturn()
        {
            InitializeComponent();
            this._memberController = new MemberController();
            this._currentRentalItemList = new List<RentalItem>();
            this._rentalItemController = new RentalItemController();
            this._returnCartList = new List<ReturnItem>();

            this.memberSelectionComboBox.SelectedIndex = 0;
            this.memberListView.CheckBoxes = true;
            this.furnitureListView.CheckBoxes = true;
            this.addFurnitureButton.Enabled = false;
            this.clearButton.Enabled = false;
            this.returnListView.Enabled = false;
            this.checkoutButton.Enabled = false;
            this.clearFurnitureButton.Enabled = false;
            this.removeItemButton.Enabled = false;
            this.memberSelectButton.Enabled = false;
            this.returnItemNumberComboBox.Enabled = false;

            MainDashBoard parentForm = this.FindForm() as MainDashBoard;
            if (parentForm != null)
            {
                this.employeeId = parentForm.EmployeeId;
            }
        }

        /// <summary>
        /// Handles the Click event of the memberSearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="System.Exception"></exception>
        private void memberSearchButton_Click(object sender, EventArgs e)
        {
            this.errorMemberLabel.Visible = false;
            try
            {
                if (String.IsNullOrEmpty(this.memberSearchBox.Text))
                {
                    throw new Exception();
                }
                this.populateMemberListView();
                this.memberSelectButton.Enabled = true;
            }
            catch (Exception ex)
            {
                this.errorMemberLabel.Visible = true;
                this.errorMemberLabel.ForeColor = Color.Red;
                this.errorMemberLabel.Text = "Search cannot be blank";
            }
        }

        /// <summary>
        /// Populates the member ListView.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        private void populateMemberListView()
        {
            this.errorMemberLabel.Visible = false;
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
                this.errorMemberLabel.Visible = true;
                this.errorMemberLabel.ForeColor = Color.Red;
                this.errorMemberLabel.Text = errorMessage;
            }

        }

        private void memberSelectButton_Click(object sender, EventArgs e)
        {
            if (this.memberListView.CheckedItems.Count == 1)
            {
                ListViewItem checkedItem = memberListView.CheckedItems[0];
                memberId = int.Parse(checkedItem.Text);
                _currentMember = _memberController.RetrieveMember(memberId);
                this.errorMemberLabel.Visible = true;
                this._currentRentalItemList = this._rentalItemController.GetOutstandingRentalItemsById(memberId);
                this.PopulateFurnitureListView();
                this.clearFurnitureButton.Enabled = true;
                this.returnItemNumberComboBox.Enabled = true;
            }
            else if (this.memberListView.CheckedItems.Count > 1)
            {
                this.errorMemberLabel.Text = "Please selet only ONE member at a time.";
                this.errorMemberLabel.Visible = true;
            }
            else
            {
                this.errorMemberLabel.Text = "You must select a member.";
                this.errorMemberLabel.Visible = true;
            }
        }

        private void PopulateFurnitureListView()
        {
            this.errorMemberLabel.Text = "";
            this.errorMemberLabel.Visible = false;
            string errorMessage = null;
            try
            {
                errorMessage = "invalid search";
                this.furnitureListView.Clear();
                this.furnitureListView.View = System.Windows.Forms.View.Details;
                this.furnitureListView.GridLines = true;
                this.furnitureListView.Columns.Add("TransactionID", 50);
                this.furnitureListView.Columns.Add("LineItemID", 50);
                this.furnitureListView.Columns.Add("FurnitureID", 100);
                this.furnitureListView.Columns.Add("Furniture Name", 100);
                this.furnitureListView.Columns.Add("Rental Rate", 100);
                this.furnitureListView.Columns.Add("Outstanding", 50);
                this.furnitureListView.Columns.Add("Due Date", 100);

                if (this._currentRentalItemList.Count == 0)
                {
                    errorMessage = "No results found";
                    throw new Exception();
                }
                else
                {
                    foreach (RentalItem dr in this._currentRentalItemList)
                    {
                        var furnitureList = furnitureListView.Items.Add(dr.TransactionId.ToString());
                        furnitureList.SubItems.Add(dr.Id.ToString());
                        furnitureList.SubItems.Add(dr.FurnitureId.ToString());
                        furnitureList.SubItems.Add(dr.FurnitureName);
                        furnitureList.SubItems.Add(dr.RentalRate.ToString());

                        int outstanding = dr.Quantity - dr.QuantityReturned;
                        furnitureList.SubItems.Add(outstanding.ToString());
                        furnitureList.SubItems.Add(dr.DueDate.ToString());
                    }
                    this.furnitureListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    this.furnitureListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                }
            }
            catch (Exception ex)
            {
                this.errorMemberLabel.Visible = true;
                this.errorMemberLabel.ForeColor = Color.Red;
                this.errorMemberLabel.Text = errorMessage;
            }

        }

        private void clearFurnitureButton_Click(object sender, EventArgs e)
        {
            this.furnitureListView.Clear();
            this.memberListView.Clear();
            this.memberSearchBox.Text = "";
            this.clearFurnitureButton.Enabled = false;
            this.returnItemNumberComboBox.Enabled = false;
            this.returnItemNumberComboBox.Items.Clear();
        }

        private void furnitureListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                furnitureId = int.Parse(e.Item.Text);
                foreach (ListViewItem item in furnitureListView.Items)
                {
                    if (item != e.Item)
                    {
                        item.Checked = false;
                    }
                }

            }
            if (furnitureListView.CheckedItems.Count > 0 && memberListView.CheckedItems.Count > 0)
            {
                this.returnItemNumberComboBox.Items.Clear();
                this.addFurnitureButton.Enabled = true;
                this.returnItemNumberComboBox.Enabled = true;
                for (int index = 1; index <= int.Parse(e.Item.SubItems[5].Text); index++)
                {
                    this.returnItemNumberComboBox.Items.Add(index.ToString());
                }
            }
            else
            {
                this.addFurnitureButton.Enabled = false;
                this.returnItemNumberComboBox.Enabled = false;
            }

        }

        private void addFurnitureButton_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(this.returnItemNumberComboBox.Text) || this.furnitureListView.CheckedItems.Count < 1)
            { 
                   
            }
            else
            {
                
                int returnComboBoxValue = int.Parse(this.returnItemNumberComboBox.Text);
                RentalItem currentRentalItem = new RentalItem();

                currentRentalItem.TransactionId = int.Parse(this.furnitureListView.CheckedItems[0].SubItems[0].Text);
                currentRentalItem.Id = int.Parse(this.furnitureListView.CheckedItems[0].SubItems[1].Text);
                currentRentalItem.FurnitureId = int.Parse(this.furnitureListView.CheckedItems[0].SubItems[2].Text);
                currentRentalItem.FurnitureName = this.furnitureListView.CheckedItems[0].SubItems[3].Text;
                currentRentalItem.RentalRate = decimal.Parse(this.furnitureListView.CheckedItems[0].SubItems[4].Text);

                currentRentalItem.DueDate = DateTime.Parse(this.furnitureListView.CheckedItems[0].SubItems[6].Text);
                currentRentalItem.QuantityReturned = returnComboBoxValue;

                ReturnItem returnItem = new ReturnItem();
                returnItem.EmployeeId = this.employeeId;
                returnItem.MemberId = this.memberId;
                returnItem.DueDate = currentRentalItem.DueDate;
                returnItem.RentalItemId = currentRentalItem.TransactionId;
                returnItem.Quantity = currentRentalItem.QuantityReturned;


                this.refreshReturnListView(returnItem);
            }       

        }

        private void refreshReturnListView(ReturnItem returnItem)
        {
            try
            {
                this._returnCartList.Add( returnItem );
                
                this.returnListView.Clear();
                this.returnListView.View = System.Windows.Forms.View.Details;
                this.returnListView.GridLines = true;
                this.returnListView.Columns.Add("EmpID", 50);
                this.returnListView.Columns.Add("MemID", 50);
                this.returnListView.Columns.Add("Due Date", 100);
                this.returnListView.Columns.Add("RentTransID", 50);
                this.returnListView.Columns.Add("Quantity", 50);

                foreach (ReturnItem dr in this._returnCartList)
                {
                    var cartList = returnListView.Items.Add(dr.EmployeeId.ToString());
                    cartList.SubItems.Add(dr.MemberId.ToString());
                    cartList.SubItems.Add(dr.DueDate.ToString());
                    cartList.SubItems.Add(dr.RentalItemId.ToString());
                    cartList.SubItems.Add(dr.Quantity.ToString());
                }

                this.returnListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.returnListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                this.returnListView.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
