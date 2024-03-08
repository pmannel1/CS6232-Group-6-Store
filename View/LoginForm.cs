using CS6232_Group_6_Store.Controller;

namespace CS6232_Group_6_Store.View
{
    /// <summary>
    /// Login form for program
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class LoginForm : Form
    {
        private EmployeeController _employeeController;
        private MainDashBoard _mainDashBoard;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        /// <param name="md">The md.</param>
        public LoginForm(MainDashBoard md)
        {
            InitializeComponent();
            this._mainDashBoard = md;
            this._employeeController = new EmployeeController();
        }

        /// <summary>
        /// Handles the Click event of the loginButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void loginButton_Click(object sender, EventArgs e)
        {
            string idStr = this.idTextBox.Text;
            string password = this.passwordTextBox.Text;
            int id = 0;

            if (!int.TryParse(idStr, out id) ||id < 1 || string.IsNullOrEmpty(password) 
                || !this._employeeController.ValidateEmployee(id, password))
            {
                this.errorLabel.Text = "Invalid username or password.";
                this.idTextBox.Text = "";
                this.passwordTextBox.Text = "";
            }
            else
            {
                this._mainDashBoard.SetGreetingLabel("Employee ID: " + idStr);
                this.Visible = false;
                this._mainDashBoard.Visible = true;
                this.errorLabel.Text = "";
                this.idTextBox.Text = "";
                this.passwordTextBox.Text = "";
            }
        }

        /// <summary>
        /// Handles the FormClosed event of the LoginForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LoginForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
