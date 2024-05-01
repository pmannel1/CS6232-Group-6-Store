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
            inventoryAndRentTabPage = new TabPage();
            inventoryRental1 = new UserControls.InventoryRental();
            returnTabPage = new TabPage();
            inventoryReturn1 = new UserControls.InventoryReturn();
            transactionManagementTab = new TabPage();
            transactionManagement1 = new UserControls.TransactionManagement();
            adminReportTab = new TabPage();
            adminReport1 = new UserControls.AdminReport();
            greetingLabel = new Label();
            logoutLinkLabel = new LinkLabel();
            userNameLabel = new Label();
            employeeNameLebel = new Label();
            selectedCustomerLabel = new Label();
            selectedCustomerDisplay = new Label();
            selectedCustomerNameLabel = new Label();
            selectedCustomerNameDisplay = new Label();
            mainTabControl.SuspendLayout();
            customerTabPage.SuspendLayout();
            inventoryAndRentTabPage.SuspendLayout();
            returnTabPage.SuspendLayout();
            transactionManagementTab.SuspendLayout();
            adminReportTab.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(customerTabPage);
            mainTabControl.Controls.Add(inventoryAndRentTabPage);
            mainTabControl.Controls.Add(returnTabPage);
            mainTabControl.Controls.Add(transactionManagementTab);
            mainTabControl.Controls.Add(adminReportTab);
            mainTabControl.Dock = DockStyle.Bottom;
            mainTabControl.Location = new Point(0, 129);
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
            customerTabPage.Text = "Member Management";
            customerTabPage.UseVisualStyleBackColor = true;
            // 
            // memberManagement2
            // 
            memberManagement2.Dock = DockStyle.Fill;
            memberManagement2.Location = new Point(3, 3);
            memberManagement2.MainDashBoard = null;
            memberManagement2.Margin = new Padding(3, 2, 3, 2);
            memberManagement2.Name = "memberManagement2";
            memberManagement2.Size = new Size(1041, 459);
            memberManagement2.TabIndex = 0;
            // 
            // inventoryAndRentTabPage
            // 
            inventoryAndRentTabPage.Controls.Add(inventoryRental1);
            inventoryAndRentTabPage.Location = new Point(4, 24);
            inventoryAndRentTabPage.Margin = new Padding(3, 2, 3, 2);
            inventoryAndRentTabPage.Name = "inventoryAndRentTabPage";
            inventoryAndRentTabPage.Size = new Size(192, 72);
            inventoryAndRentTabPage.TabIndex = 1;
            inventoryAndRentTabPage.Text = "Inventory and Rental Processing ";
            inventoryAndRentTabPage.UseVisualStyleBackColor = true;
            // 
            // inventoryRental1
            // 
            inventoryRental1.Dock = DockStyle.Fill;
            inventoryRental1.Location = new Point(0, 0);
            inventoryRental1.MainDashBoard = null;
            inventoryRental1.Margin = new Padding(3, 4, 3, 4);
            inventoryRental1.Name = "inventoryRental1";
            inventoryRental1.Size = new Size(192, 72);
            inventoryRental1.TabIndex = 0;
            // 
            // returnTabPage
            // 
            returnTabPage.Controls.Add(inventoryReturn1);
            returnTabPage.Location = new Point(4, 24);
            returnTabPage.Name = "returnTabPage";
            returnTabPage.Size = new Size(192, 72);
            returnTabPage.TabIndex = 3;
            returnTabPage.Text = "Return Processing";
            returnTabPage.UseVisualStyleBackColor = true;
            // 
            // inventoryReturn1
            // 
            inventoryReturn1.Dock = DockStyle.Fill;
            inventoryReturn1.Location = new Point(0, 0);
            inventoryReturn1.MainDashBoard = null;
            inventoryReturn1.Margin = new Padding(3, 4, 3, 4);
            inventoryReturn1.Name = "inventoryReturn1";
            inventoryReturn1.Size = new Size(192, 72);
            inventoryReturn1.TabIndex = 0;
            // 
            // transactionManagementTab
            // 
            transactionManagementTab.Controls.Add(transactionManagement1);
            transactionManagementTab.Location = new Point(4, 24);
            transactionManagementTab.Name = "transactionManagementTab";
            transactionManagementTab.Padding = new Padding(3);
            transactionManagementTab.Size = new Size(192, 72);
            transactionManagementTab.TabIndex = 2;
            transactionManagementTab.Text = "Transaction Management";
            transactionManagementTab.UseVisualStyleBackColor = true;
            // 
            // transactionManagement1
            // 
            transactionManagement1.Dock = DockStyle.Fill;
            transactionManagement1.Location = new Point(3, 3);
            transactionManagement1.Margin = new Padding(3, 4, 3, 4);
            transactionManagement1.Name = "transactionManagement1";
            transactionManagement1.Size = new Size(186, 66);
            transactionManagement1.TabIndex = 0;
            // 
            // adminReportTab
            // 
            adminReportTab.Controls.Add(adminReport1);
            adminReportTab.Location = new Point(4, 24);
            adminReportTab.Margin = new Padding(3, 2, 3, 2);
            adminReportTab.Name = "adminReportTab";
            adminReportTab.Size = new Size(192, 72);
            adminReportTab.TabIndex = 4;
            adminReportTab.Text = "Admin Report";
            adminReportTab.UseVisualStyleBackColor = true;
            // 
            // adminReport1
            // 
            adminReport1.Dock = DockStyle.Fill;
            adminReport1.Location = new Point(0, 0);
            adminReport1.Margin = new Padding(3, 2, 3, 2);
            adminReport1.Name = "adminReport1";
            adminReport1.Size = new Size(192, 72);
            adminReport1.TabIndex = 0;
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
            // selectedCustomerLabel
            // 
            selectedCustomerLabel.AutoSize = true;
            selectedCustomerLabel.Location = new Point(12, 9);
            selectedCustomerLabel.Name = "selectedCustomerLabel";
            selectedCustomerLabel.Size = new Size(106, 15);
            selectedCustomerLabel.TabIndex = 7;
            selectedCustomerLabel.Text = "Selected Customer";
            // 
            // selectedCustomerDisplay
            // 
            selectedCustomerDisplay.AutoSize = true;
            selectedCustomerDisplay.Location = new Point(129, 11);
            selectedCustomerDisplay.Name = "selectedCustomerDisplay";
            selectedCustomerDisplay.Size = new Size(0, 15);
            selectedCustomerDisplay.TabIndex = 8;
            // 
            // selectedCustomerNameLabel
            // 
            selectedCustomerNameLabel.AutoSize = true;
            selectedCustomerNameLabel.Location = new Point(12, 24);
            selectedCustomerNameLabel.Name = "selectedCustomerNameLabel";
            selectedCustomerNameLabel.Size = new Size(141, 15);
            selectedCustomerNameLabel.TabIndex = 9;
            selectedCustomerNameLabel.Text = "Selected Customer Name";
            // 
            // selectedCustomerNameDisplay
            // 
            selectedCustomerNameDisplay.AutoSize = true;
            selectedCustomerNameDisplay.Location = new Point(164, 29);
            selectedCustomerNameDisplay.Name = "selectedCustomerNameDisplay";
            selectedCustomerNameDisplay.Size = new Size(0, 15);
            selectedCustomerNameDisplay.TabIndex = 10;
            // 
            // MainDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 622);
            Controls.Add(selectedCustomerNameDisplay);
            Controls.Add(selectedCustomerNameLabel);
            Controls.Add(selectedCustomerDisplay);
            Controls.Add(selectedCustomerLabel);
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
            inventoryAndRentTabPage.ResumeLayout(false);
            returnTabPage.ResumeLayout(false);
            transactionManagementTab.ResumeLayout(false);
            adminReportTab.ResumeLayout(false);
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
        private UserControls.MemberManagement memberManagement2;
        private TabPage inventoryAndRentTabPage;
        private UserControls.InventoryRental inventoryRental1;
        private TabPage transactionManagementTab;
        private UserControls.TransactionManagement transactionManagement1;
        private TabPage returnTabPage;
        private UserControls.InventoryReturn inventoryReturn1;
        private TabPage adminReportTab;
        private UserControls.AdminReport adminReport1;
        private Label selectedCustomerLabel;
        private Label selectedCustomerDisplay;
        private Label selectedCustomerNameLabel;
        private Label selectedCustomerNameDisplay;
    }
}
