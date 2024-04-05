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

        /// <summary>
        /// Gets or sets the EmployeeName.
        /// </summary>
        /// <value>
        /// The EmployeeName.
        /// </value>
        public string EmployeeName { get; set; }
        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        /// <value>
        /// The UserName.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        /// <param name="md">The md.</param>
        public LoginForm()
        {
            InitializeComponent();
            this._employeeController = new EmployeeController();
        }

        /// <summary>
        /// Check login credintals by using logincontroller
        /// </summary>
        /// <returns>employee name if credintail is valid</returns>
        public string CheckCredentials()
        {
            Id = Convert.ToInt32(idTextBox.Text);
            var password = passwordTextBox.Text;
            return this._employeeController.ValidateEmployee(Id, password);

        }
        /// <summary>
        /// Logouts this instance.
        /// </summary>
        public void Logout()
        {
            idTextBox.Clear();
            passwordTextBox.Clear();
            this.Show();
        }

        /// <summary>
        /// Handles the Click event of the loginButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void loginButton_Click(object sender, EventArgs e)
        {

            if (idTextBox.Text.Trim() == "" || passwordTextBox.Text.Trim() == "")
            {
                this.errorLabel.Text = "UserName and/or password is required";
                this.errorLabel.Visible = true;
                this.errorLabel.ForeColor = Color.Red;
                return;
            }
            if (!int.TryParse(idTextBox.Text, out int id) || id <= 0)
            {
                this.errorLabel.Text = "Invalid user name, only positive integers.";
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Show();
                return;
            }

            EmployeeName = CheckCredentials();

            if (EmployeeName != null && EmployeeName.Length > 0)
            {
                UserName = idTextBox.Text;
                
                MainDashBoard mainDashBoard = new MainDashBoard(this);
                mainDashBoard.Show();
                this.Hide();

            }
            else
            {
                this.errorLabel.Text = "incorrect username/password";
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Show();
                return;
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

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            this.errorLabel.Hide();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.errorLabel.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
