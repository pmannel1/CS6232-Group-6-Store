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
            mainTabControl.Location = new Point(0, 172);
            mainTabControl.Margin = new Padding(3, 4, 3, 4);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(1206, 657);
            mainTabControl.TabIndex = 0;
            // 
            // customerTabPage
            // 
            customerTabPage.Controls.Add(memberManagement2);
            customerTabPage.Location = new Point(4, 29);
            customerTabPage.Margin = new Padding(3, 4, 3, 4);
            customerTabPage.Name = "customerTabPage";
            customerTabPage.Padding = new Padding(3, 4, 3, 4);
            customerTabPage.Size = new Size(1198, 624);
            customerTabPage.TabIndex = 0;
            customerTabPage.Text = "Customer";
            customerTabPage.UseVisualStyleBackColor = true;
            // 
            // memberManagement2
            // 
            memberManagement2.Dock = DockStyle.Fill;
            memberManagement2.Location = new Point(3, 4);
            memberManagement2.Name = "memberManagement2";
            memberManagement2.Size = new Size(1192, 616);
            memberManagement2.TabIndex = 0;
            // 
            // inventoryAndRentTabPage
            // 
            inventoryAndRentTabPage.Controls.Add(inventoryRental1);
            inventoryAndRentTabPage.Location = new Point(4, 29);
            inventoryAndRentTabPage.Name = "inventoryAndRentTabPage";
            inventoryAndRentTabPage.Size = new Size(192, 67);
            inventoryAndRentTabPage.TabIndex = 1;
            inventoryAndRentTabPage.Text = "Inventory and Rental Processing ";
            inventoryAndRentTabPage.UseVisualStyleBackColor = true;
            // 
            // inventoryRental1
            // 
            inventoryRental1.Dock = DockStyle.Fill;
            inventoryRental1.Location = new Point(0, 0);
            inventoryRental1.Margin = new Padding(3, 5, 3, 5);
            inventoryRental1.Name = "inventoryRental1";
            inventoryRental1.Size = new Size(192, 67);
            inventoryRental1.TabIndex = 0;
            // 
            // returnTabPage
            // 
            returnTabPage.Controls.Add(inventoryReturn1);
            returnTabPage.Location = new Point(4, 29);
            returnTabPage.Margin = new Padding(3, 4, 3, 4);
            returnTabPage.Name = "returnTabPage";
            returnTabPage.Size = new Size(192, 67);
            returnTabPage.TabIndex = 3;
            returnTabPage.Text = "Return Processing";
            returnTabPage.UseVisualStyleBackColor = true;
            // 
            // inventoryReturn1
            // 
            inventoryReturn1.Dock = DockStyle.Fill;
            inventoryReturn1.Location = new Point(0, 0);
            inventoryReturn1.Margin = new Padding(3, 5, 3, 5);
            inventoryReturn1.Name = "inventoryReturn1";
            inventoryReturn1.Size = new Size(192, 67);
            inventoryReturn1.TabIndex = 0;
            // 
            // transactionManagementTab
            // 
            transactionManagementTab.Controls.Add(transactionManagement1);
            transactionManagementTab.Location = new Point(4, 29);
            transactionManagementTab.Margin = new Padding(3, 4, 3, 4);
            transactionManagementTab.Name = "transactionManagementTab";
            transactionManagementTab.Padding = new Padding(3, 4, 3, 4);
            transactionManagementTab.Size = new Size(192, 67);
            transactionManagementTab.TabIndex = 2;
            transactionManagementTab.Text = "Transaction Management";
            transactionManagementTab.UseVisualStyleBackColor = true;
            // 
            // transactionManagement1
            // 
            transactionManagement1.Dock = DockStyle.Fill;
            transactionManagement1.Location = new Point(3, 4);
            transactionManagement1.Margin = new Padding(3, 5, 3, 5);
            transactionManagement1.Name = "transactionManagement1";
            transactionManagement1.Size = new Size(186, 59);
            transactionManagement1.TabIndex = 0;
            // 
            // adminReportTab
            // 
            adminReportTab.Controls.Add(adminReport1);
            adminReportTab.Location = new Point(4, 29);
            adminReportTab.Name = "adminReportTab";
            adminReportTab.Size = new Size(192, 67);
            adminReportTab.TabIndex = 4;
            adminReportTab.Text = "Admin Report";
            adminReportTab.UseVisualStyleBackColor = true;
            // 
            // adminReport1
            // 
            adminReport1.Dock = DockStyle.Fill;
            adminReport1.Location = new Point(0, 0);
            adminReport1.Name = "adminReport1";
            adminReport1.Size = new Size(192, 67);
            adminReport1.TabIndex = 0;
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
            employeeNameLebel.Location = new Point(533, 9);
            employeeNameLebel.Name = "employeeNameLebel";
            employeeNameLebel.Size = new Size(115, 20);
            employeeNameLebel.TabIndex = 5;
            employeeNameLebel.Text = "EmployeeName";
            // 
            // MainDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 829);
            Controls.Add(userNameLabel);
            Controls.Add(employeeNameLebel);
            Controls.Add(logoutLinkLabel);
            Controls.Add(greetingLabel);
            Controls.Add(mainTabControl);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}
