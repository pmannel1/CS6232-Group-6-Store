using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.View;

namespace CS6232_Group_6_Store
{
    /// <summary>
    /// Main Dashboard for program
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainDashBoard : Form
    {
        private LoginForm _loginForm;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashBoard"/> class.
        /// </summary>
        public MainDashBoard()
        {
            InitializeComponent();
            this._loginForm = new LoginForm(this);
            this._loginForm.ShowDialog();
            this.Visible = false;
            this.employeeNameLebel.Text = "Emplyee Name: " + this._loginForm.EmployeeName;
            this.userNameLabel.Text = "User Account: " + this._loginForm.UserName;
        }

        /// <summary>
        /// Sets the greeting label.
        /// </summary>
        /// <param name="greeting">The greeting.</param>
        public void SetGreetingLabel(string greeting)
        {
            this.greetingLabel.Text = greeting;
        }

        /// <summary>
        /// Handles the LinkClicked event of the logoutLinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.memberManagement1.ClearData();
            this.Visible = false;
            this._loginForm.Visible = true;
            this._loginForm.Logout();
        }

        private void memberManagement1_Load(object sender, EventArgs e)
        {

        }
    }
}
