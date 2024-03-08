using CS6232_Group_6_Store.Controller;

namespace CS6232_Group_6_Store.View
{
    public partial class LoginForm : Form
    {
        private EmployeeController _employeeController;
        private MainDashBoard _mainDashBoard;

        public LoginForm(MainDashBoard md)
        {
            InitializeComponent();
            this._mainDashBoard = md;
            this._employeeController = new EmployeeController();
        }

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

        private void LoginForm_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
