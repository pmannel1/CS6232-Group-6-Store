namespace CS6232_Group_6_Store
{
    partial class MainDashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainTabControl = new TabControl();
            customerTabPage = new TabPage();
            memberManagement1 = new UserControls.MemberManagement();
            greetingLabel = new Label();
            logoutLinkLabel = new LinkLabel();
            userNameLabel = new Label();
            employeeNameLebel = new Label();
            mainTabControl.SuspendLayout();
            customerTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(customerTabPage);
            mainTabControl.Dock = DockStyle.Bottom;
            mainTabControl.Location = new Point(0, 47);
            mainTabControl.Margin = new Padding(3, 4, 3, 4);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1206, 657);
            mainTabControl.TabIndex = 0;
            // 
            // customerTabPage
            // 
            customerTabPage.Controls.Add(memberManagement1);
            customerTabPage.Location = new Point(4, 29);
            customerTabPage.Margin = new Padding(3, 4, 3, 4);
            customerTabPage.Name = "customerTabPage";
            customerTabPage.Padding = new Padding(3, 4, 3, 4);
            customerTabPage.Size = new Size(1198, 624);
            customerTabPage.TabIndex = 0;
            customerTabPage.Text = "Customer";
            customerTabPage.UseVisualStyleBackColor = true;
            // 
            // memberManagement1
            // 
            memberManagement1.Location = new Point(8, 7);
            memberManagement1.Name = "memberManagement1";
            memberManagement1.Size = new Size(1386, 775);
            memberManagement1.TabIndex = 0;
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Dock = DockStyle.Left;
            greetingLabel.Location = new Point(0, 0);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(0, 20);
            greetingLabel.TabIndex = 1;
            // 
            // logoutLinkLabel
            // 
            logoutLinkLabel.AutoSize = true;
            logoutLinkLabel.Dock = DockStyle.Right;
            logoutLinkLabel.Location = new Point(1141, 0);
            logoutLinkLabel.Name = "logoutLinkLabel";
            logoutLinkLabel.Size = new Size(65, 20);
            logoutLinkLabel.TabIndex = 2;
            logoutLinkLabel.TabStop = true;
            logoutLinkLabel.Text = "LOGOUT";
            logoutLinkLabel.LinkClicked += logoutLinkLabel_LinkClicked;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(799, 9);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(78, 20);
            userNameLabel.TabIndex = 6;
            userNameLabel.Text = "UserName";
            // 
            // employeeNameLebel
            // 
            employeeNameLebel.AutoSize = true;
            employeeNameLebel.Location = new Point(532, 9);
            employeeNameLebel.Name = "employeeNameLebel";
            employeeNameLebel.Size = new Size(115, 20);
            employeeNameLebel.TabIndex = 5;
            employeeNameLebel.Text = "EmployeeName";
            // 
            // MainDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 704);
            Controls.Add(userNameLabel);
            Controls.Add(employeeNameLebel);
            Controls.Add(logoutLinkLabel);
            Controls.Add(greetingLabel);
            Controls.Add(mainTabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainDashBoard";
            Text = "Main Dashboard";
            mainTabControl.ResumeLayout(false);
            customerTabPage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage customerTabPage;
        private Label greetingLabel;
        private LinkLabel logoutLinkLabel;
        private UserControls.MemberManagement memberManagement1;
        private Label userNameLabel;
        private Label employeeNameLebel;
    }
}
