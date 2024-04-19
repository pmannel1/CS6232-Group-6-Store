using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.DAL;
using System.Data;

namespace CS6232_Group_6_Store.UserControls
{
    public partial class AdminReport : UserControl
    {
        private readonly AdminController _adminController;

        public AdminReport()
        {
            InitializeComponent();
            _adminController = new AdminController();


        }

        private void adminReportButton_Click(object sender, EventArgs e)
        {

            adminReportListView.Items.Clear();

            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;
            if (startDate.Date >= endDate.Date) {
         
                adminErrorLabel.Text = "Start Date must be before End Date";
                adminErrorLabel.ForeColor = Color.Red;

            } 
            else
            {
                this.adminErrorLabel.Text = string.Empty;

                DataTable dataTable = _adminController.ExecuteGetMostPopularFurnitureDuringDates(startDate, endDate);
                this.adminReportListView.View = System.Windows.Forms.View.Details;
                this.adminReportListView.GridLines = true;
                this.adminReportListView.Columns.Clear();
                this.adminReportListView.Columns.Add("Furniture ID", 100);
                this.adminReportListView.Columns.Add("Furniture Category", 150);
                //        this.adminReportListView.Columns.Add("Furniture Name", 150);
                this.adminReportListView.Columns.Add("Total Rentals", 120);
                this.adminReportListView.Columns.Add("Total Furniture Rentals", 180);
                this.adminReportListView.Columns.Add("Percentage of Total Rentals", 200);
                this.adminReportListView.Columns.Add("Percentage of 18-29 Rentals", 220);
                this.adminReportListView.Columns.Add("Percentage of Rentals Outside 18-29 Range", 280);

                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["categoryName"].ToString());
                    //      item.SubItems.Add(row["name"].ToString());
                    item.SubItems.Add(row["totalRentalTransactions"].ToString());
                    item.SubItems.Add(row["totalAllRentalTransactions"].ToString());
                    item.SubItems.Add(((decimal)row["percentageOfTotal"]).ToString("0.00") + "%");
                    item.SubItems.Add(((decimal)row["percentage18To29"]).ToString("0.00") + "%");
                    item.SubItems.Add(((decimal)row["percentageOutside18To29"]).ToString("0.00") + "%");

                    adminReportListView.Items.Add(item);
                }

                foreach (ColumnHeader column in adminReportListView.Columns)
                {
                    column.Width = -2;
                }
            }
        }
    }
}
