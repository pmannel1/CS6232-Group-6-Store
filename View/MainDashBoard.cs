
using CS6232_Group_6_Store.View;

namespace CS6232_Group_6_Store
{
    /// <summary>
    /// Main Dashboard for program
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashBoard : Form
    {
        bool logout;
        readonly LoginForm _loginForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashBoard"/> class.
        /// </summary>
        public MainDashBoard(LoginForm newLogin)
        {
            InitializeComponent();
            this._loginForm = newLogin;
            this.employeeNameLebel.Text = "Emplyee Name: " + this._loginForm.EmployeeName;
            this.userNameLabel.Text = "User Account: " + this._loginForm.UserName;
            this.logout = false;
        }

        /// <summary>
        /// Handles the LinkClicked event of the logoutLinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logout = true;
            _loginForm.Logout();
            this.Close();
        }

        private void MainClosing(object sender, FormClosingEventArgs e)
        {
            if (!logout)
            {
                Application.Exit();
            }
        }
    }
}
