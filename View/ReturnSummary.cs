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
        private decimal fines;
        private decimal refunds;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnSummary"/> class.
        /// </summary>
        /// <param name="transactionSummary">The transaction summary.</param>
        public ReturnSummary(List<RentalReturnTransactionSummary> transactionSummary, decimal fines, decimal refunds)
        {
            InitializeComponent();
            _transactionSummary = transactionSummary;
            this.fines = fines;
            this.refunds = refunds;
            Populate();
        }

        /// <summary>
        /// populate transaction summary on the list view
        /// </summary>
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
                transactionSummarylistView.Columns.Add("Furniture ID", 50);
                transactionSummarylistView.Columns.Add("Furniture Name", 150);
                transactionSummarylistView.Columns.Add("Quantity", 150);
                transactionSummarylistView.Columns.Add("Members Name", 150);
                transactionSummarylistView.Columns.Add("Employee Name", 150);
                transactionSummarylistView.Columns.Add("Rental Date", 150);


                foreach (var dr in _transactionSummary)
                {

                    var returnList = transactionSummarylistView.Items.Add(dr.TransactionId.ToString());
                    returnList.SubItems.Add(dr.ReturnId.ToString());
                    returnList.SubItems.Add(dr.RentalItemId.ToString());
                    returnList.SubItems.Add(dr.FurnitureId.ToString());
                    returnList.SubItems.Add(dr.FurnitureName.ToString());
                    returnList.SubItems.Add(dr.Quantity.ToString());
                    returnList.SubItems.Add(dr.MemberName.ToString());
                    returnList.SubItems.Add(dr.EmployeeName.ToString());
                    returnList.SubItems.Add(dr.DueDate.ToShortDateString());
                }

                this.transactionSummarylistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.transactionSummarylistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                if (refunds > fines)
                {
                    this.fineCreditLabel.Text = "Credit: " + (refunds - fines).ToString();
                }
                else if (refunds < fines)
                {
                    this.fineCreditLabel.Text = "Fine: " + (fines - refunds).ToString();
                }
                else
                {
                    this.fineCreditLabel.Text = "";
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
