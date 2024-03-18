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
            memberManagement2 = new UserControls.MemberManagement();
            addMemberTabPage = new TabPage();
            memberAdd1 = new UserControls.MemberAdd();
            greetingLabel = new Label();
            logoutLinkLabel = new LinkLabel();
            userNameLabel = new Label();
            employeeNameLebel = new Label();
            mainTabControl.SuspendLayout();
            customerTabPage.SuspendLayout();
            addMemberTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(customerTabPage);
            mainTabControl.Controls.Add(addMemberTabPage);
            mainTabControl.Dock = DockStyle.Bottom;
            mainTabControl.Location = new Point(0, 35);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1055, 493);
            mainTabControl.TabIndex = 0;
            // 
            // customerTabPage
            // 
            customerTabPage.Controls.Add(memberManagement2);
            customerTabPage.Location = new Point(4, 24);
            customerTabPage.Name = "customerTabPage";
            customerTabPage.Padding = new Padding(3);
            customerTabPage.Size = new Size(1047, 465);
            customerTabPage.TabIndex = 0;
            customerTabPage.Text = "Customer";
            customerTabPage.UseVisualStyleBackColor = true;
            // 
            // memberManagement2
            // 
            memberManagement2.Dock = DockStyle.Fill;
            memberManagement2.Location = new Point(3, 3);
            memberManagement2.Margin = new Padding(3, 2, 3, 2);
            memberManagement2.Name = "memberManagement2";
            memberManagement2.Size = new Size(1041, 459);
            memberManagement2.TabIndex = 0;
            // 
            // addMemberTabPage
            // 
            addMemberTabPage.Controls.Add(memberAdd1);
            addMemberTabPage.Location = new Point(4, 24);
            addMemberTabPage.Margin = new Padding(3, 2, 3, 2);
            addMemberTabPage.Name = "addMemberTabPage";
            addMemberTabPage.Padding = new Padding(3, 2, 3, 2);
            addMemberTabPage.Size = new Size(192, 72);
            addMemberTabPage.TabIndex = 1;
            addMemberTabPage.Text = "Add Member";
            addMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // memberAdd1
            // 
            memberAdd1.Dock = DockStyle.Fill;
            memberAdd1.Location = new Point(3, 2);
            memberAdd1.Margin = new Padding(3, 2, 3, 2);
            memberAdd1.Name = "memberAdd1";
            memberAdd1.Size = new Size(186, 68);
            memberAdd1.TabIndex = 0;
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Dock = DockStyle.Left;
            greetingLabel.Location = new Point(0, 0);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(0, 15);
            greetingLabel.TabIndex = 1;
            // 
            // logoutLinkLabel
            // 
            logoutLinkLabel.AutoSize = true;
            logoutLinkLabel.Dock = DockStyle.Right;
            logoutLinkLabel.Location = new Point(1002, 0);
            logoutLinkLabel.Name = "logoutLinkLabel";
            logoutLinkLabel.Size = new Size(53, 15);
            logoutLinkLabel.TabIndex = 2;
            logoutLinkLabel.TabStop = true;
            logoutLinkLabel.Text = "LOGOUT";
            logoutLinkLabel.LinkClicked += logoutLinkLabel_LinkClicked;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(699, 7);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(62, 15);
            userNameLabel.TabIndex = 6;
            userNameLabel.Text = "UserName";
            // 
            // employeeNameLebel
            // 
            employeeNameLebel.AutoSize = true;
            employeeNameLebel.Location = new Point(466, 7);
            employeeNameLebel.Name = "employeeNameLebel";
            employeeNameLebel.Size = new Size(91, 15);
            employeeNameLebel.TabIndex = 5;
            employeeNameLebel.Text = "EmployeeName";
            // 
            // MainDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 528);
            Controls.Add(userNameLabel);
            Controls.Add(employeeNameLebel);
            Controls.Add(logoutLinkLabel);
            Controls.Add(greetingLabel);
            Controls.Add(mainTabControl);
            Name = "MainDashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Dashboard";
            FormClosing += MainClosing;
            mainTabControl.ResumeLayout(false);
            customerTabPage.ResumeLayout(false);
            addMemberTabPage.ResumeLayout(false);
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
        private TabPage addMemberTabPage;
        private UserControls.MemberAdd memberEdit1;
        private UserControls.MemberManagement memberManagement2;
        private UserControls.MemberAdd memberAdd1;
    }
}
