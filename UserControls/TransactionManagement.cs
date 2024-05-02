using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;

namespace CS6232_Group_6_Store.UserControls
{
    /// <summary>
    /// Transaction Management form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class TransactionManagement : UserControl
    {
        public MainDashBoard MainDashBoard { get; set; }

        /// <summary>
        /// Declare MemberController controller class.
        /// </summary>
        private readonly MemberController _memberController;
        /// <summary>
        /// Declare RentalItemController controller class.
        /// </summary>
        private readonly RentalItemController _rentalItemController;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionManagement"/> class.
        /// </summary>
        public TransactionManagement()
        {
            InitializeComponent();
            this._memberController = new MemberController();
            this._rentalItemController = new RentalItemController();

            this.memberHistorySearchButton.Enabled = true;
        }

        /// <summary>
        /// Handles the Click event of the memberSearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void memberSearchButton_Click(object sender, EventArgs e)
        {
           
            
                transactionErrorLabel.Text = "Please input a number for ID/Name for Name";
                transactionErrorLabel.ForeColor = Color.Red;
                transactionErrorLabel.Visible = true;
           

        }

        
        /// <summary>
        /// Handles the ItemChecked event of the memberListView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ItemCheckedEventArgs"/> instance containing the event data.</param>
        private void memberListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                
            }
            else
            {
                this.memberHistorySearchButton.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the memberHistorySearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void memberHistorySearchButton_Click(object sender, EventArgs e)
        {
            int memberID = MainDashBoard.selectedMemberId;

            if (MainDashBoard.selectedMemberId == 0)
            {
                transactionErrorLabel.Text = "Please Select A Member on the Member Management Page";
                transactionErrorLabel.ForeColor= Color.Red;
            }
            else
            {
                transactionErrorLabel.Text = "";
                this.memberHistoryListView.Clear();
                this.memberHistoryListView.View = System.Windows.Forms.View.Details;
                this.memberHistoryListView.GridLines = true;
                this.memberHistoryListView.Columns.Add("Transaction ID", 50);
                this.memberHistoryListView.Columns.Add("Rental Date", 150);
                this.memberHistoryListView.Columns.Add("Due Date", 150);
                this.memberHistoryListView.Columns.Add("Item Name", 100);
                this.memberHistoryListView.Columns.Add("Quantity", 150);
                this.memberHistoryListView.Columns.Add("Rental Rate", 100);
                this.memberHistoryListView.Columns.Add("Quantity Returned", 50);

                int id = memberID;
                List<RentalItem> searchResult = this._rentalItemController.GetMemberRentalItemHistory(id);
                foreach (var dr in searchResult)
                {
                    var furnitureList = memberHistoryListView.Items.Add(dr.TransactionId.ToString());
                    furnitureList.SubItems.Add(dr.RentalDate.ToShortDateString());
                    furnitureList.SubItems.Add(dr.DueDate.ToShortDateString());
                    furnitureList.SubItems.Add(dr.FurnitureName.ToString());
                    furnitureList.SubItems.Add(dr.Quantity.ToString());
                    furnitureList.SubItems.Add("$" + dr.RentalRate.ToString());
                    furnitureList.SubItems.Add(dr.QuantityReturned.ToString());
                }
                this.memberHistoryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                this.memberHistoryListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        /// <summary>
        /// Handles the Click event of the clearMemberSearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clearMemberSearchButton_Click(object sender, EventArgs e)
        {
            this.memberHistorySearchButton.Enabled = false;
            this.memberHistoryListView.Clear();
        }

        /// <summary>
        /// Handles the Click event of the clearMemberHistorySearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void clearMemberHistorySearchButton_Click(object sender, EventArgs e)
        {
            this.memberHistoryListView.Clear();
        }
    }
}
