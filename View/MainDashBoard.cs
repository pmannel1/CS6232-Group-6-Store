using CS6232_Group_6_Store.Model;
using CS6232_Group_6_Store.View;

namespace CS6232_Group_6_Store
{
    public partial class MainDashBoard : Form
    {
        private LoginForm _loginForm;

        public MainDashBoard()
        {
            InitializeComponent();
            this._loginForm = new LoginForm(this);
            this._loginForm.ShowDialog();
            this.Visible = false;
        }

        public void SetGreetingLabel(string greeting)
        {
            this.greetingLabel.Text = greeting;
        }

        private void logoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            this._loginForm.Visible = true;
        }
    }
}
