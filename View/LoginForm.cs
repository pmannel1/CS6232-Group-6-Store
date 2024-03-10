﻿using CS6232_Group_6_Store.Controller;
using CS6232_Group_6_Store.Model;

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
        private readonly LoginController _loginController;
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
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        /// <param name="md">The md.</param>
        public LoginForm(MainDashBoard md)
        {
            InitializeComponent();
            this._mainDashBoard = md;
            this._employeeController = new EmployeeController();
            this._loginController = new LoginController();

        }

        /// <summary>
        /// Check login credintals by using logincontroller
        /// </summary>
        /// <returns>employee name if credintail is valid</returns>
        public string CheckCredentials()
        {
            Login login = new Login();
            login.UserName = Convert.ToInt32(idTextBox.Text);
            login.Password = passwordTextBox.Text;
            return this._loginController.CheckCredentials(login);

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
                this.Hide();
                this._mainDashBoard.Visible = true;
               
            }
            else
            {
                this.errorLabel.Text = "incorrect username/password";
                this.errorLabel.ForeColor = Color.Red;
                this.errorLabel.Show();
                return;
            }


            /*-----------old code
             string idStr = this.idTextBox.Text;
             string password = this.passwordTextBox.Text;
             int id = 0;

             if (!int.TryParse(idStr, out id) || id < 1 || string.IsNullOrEmpty(password)
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
            */
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
