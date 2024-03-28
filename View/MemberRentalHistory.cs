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

        public MemberRentalHistory(int id)
        {
            InitializeComponent();
            this._rentalItemController = new RentalItemController();
            this.DisplayMemberRentalHistory(id);
        }

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
            /*
            foreach (var dr in searchResult)
            {
                var membersList = this.memberRentalHistoryListView.Items.Add(dr.emp);
                membersList.SubItems.Add(dr.LastName.ToString());
                membersList.SubItems.Add(dr.FirstName.ToString());
                if (!Convert.IsDBNull(dr.DateOfBirth))
                {
                    membersList.SubItems.Add(Convert.ToDateTime(dr.DateOfBirth.ToString()).ToString("MM/dd/yyyy"));
                }
                else
                {
                    membersList.SubItems.Add(dr.DateOfBirth.ToString());
                }
                membersList.SubItems.Add(dr.StreetAddress.ToString());
                membersList.SubItems.Add(dr.City.ToString());
                membersList.SubItems.Add(dr.State.ToString());
                membersList.SubItems.Add(dr.ZipCode.ToString());
                membersList.SubItems.Add(dr.Country.ToString());
                membersList.SubItems.Add(dr.ContactPhone.ToString());

                var rentalItem
            }
            */
        }
    }
}
