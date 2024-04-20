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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CS6232_Group_6_Store.View
{
    public partial class ReturnSummary : Form
    {

        private readonly List<RentalReturnTransactionSummary> _transactionSummary;


        public ReturnSummary(List<RentalReturnTransactionSummary> transactionSummary)
        {
            InitializeComponent();
            _transactionSummary = transactionSummary;
            Populate();

        }

        public void Populate()
        {
            try
            {
                this.transactionSummarylistView.Clear();
                transactionSummarylistView.View = System.Windows.Forms.View.Details;
                transactionSummarylistView.GridLines = true;
                transactionSummarylistView.Columns.Add("Transaction ID", 150);
                transactionSummarylistView.Columns.Add("Return ID", 50);
                transactionSummarylistView.Columns.Add("Return Item ID", 50);
                transactionSummarylistView.Columns.Add("Furniture Name", 150);
                transactionSummarylistView.Columns.Add("Quantity", 150);
                transactionSummarylistView.Columns.Add("Members Name", 150);
                transactionSummarylistView.Columns.Add("Employee Name", 150);
                transactionSummarylistView.Columns.Add("Rental Date", 150);


                foreach (var dr in _transactionSummary)
                {

                    var returnList = transactionSummarylistView.Items.Add(dr.TransactionId.ToString());
                    returnList.SubItems.Add(dr.Id.ToString());
                    returnList.SubItems.Add(dr.RentalItemId.ToString());
                    returnList.SubItems.Add(dr.FurnitureName.ToString());
                    returnList.SubItems.Add(dr.Quantity.ToString());
                    returnList.SubItems.Add(dr.MemberName.ToString());
                    returnList.SubItems.Add(dr.EmployeeName.ToString());
                    returnList.SubItems.Add(dr.DueDate.ToShortDateString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
