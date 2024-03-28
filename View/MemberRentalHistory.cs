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
    public partial class MemberRentalHistory : Form
    {
        private RentalItemController _rentalItemController;

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberRentalHistory"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public MemberRentalHistory(int id)
        {
            InitializeComponent();
            this._rentalItemController = new RentalItemController();
            this.DisplayMemberRentalHistory(id);
        }

        /// <summary>
        /// Displays the member rental history.
        /// </summary>
        /// <param name="id">The identifier.</param>
        private void DisplayMemberRentalHistory(int id)
        {            
            this.memberRentalHistoryListView.Clear();
            this.memberRentalHistoryListView.View = System.Windows.Forms.View.Details;
            this.memberRentalHistoryListView.GridLines = true;
            this.memberRentalHistoryListView.Columns.Add("Employee ID", 50);
            this.memberRentalHistoryListView.Columns.Add("Rental Date", 150);
            this.memberRentalHistoryListView.Columns.Add("Due Date", 150);
            this.memberRentalHistoryListView.Columns.Add("Item Name", 100);
            this.memberRentalHistoryListView.Columns.Add("Quantity", 150);
            this.memberRentalHistoryListView.Columns.Add("Rental Rate", 100);
            this.memberRentalHistoryListView.Columns.Add("Quantity Returned", 50);
            List<RentalItem> searchResult = this._rentalItemController.GetMemberRentalItemHistory(id);

            foreach (var dr in searchResult)
            {
                var rentalItemList = this.memberRentalHistoryListView.Items.Add(dr.RentalTransaction.EmployeeId.ToString());
                rentalItemList.SubItems.Add(dr.RentalTransaction.RentalDate.ToString());
                rentalItemList.SubItems.Add(dr.RentalTransaction.DueDate.ToString());
                rentalItemList.SubItems.Add(dr.Furniture.Name);
                rentalItemList.SubItems.Add(dr.Quantity.ToString());
                rentalItemList.SubItems.Add(dr.Furniture.RentalRate.ToString());
                rentalItemList.SubItems.Add(dr.QuantityReturned.ToString());
            }

            for(int index = 0; index < this.memberRentalHistoryListView.Columns.Count; index++)
            {
                this.memberRentalHistoryListView.Columns[index].Width = -2;
            }

        }
    }
}
