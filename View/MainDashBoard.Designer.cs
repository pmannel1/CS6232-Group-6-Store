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
            greetingLabel = new Label();
            logoutLinkLabel = new LinkLabel();
            mainTabControl.SuspendLayout();
            SuspendLayout();
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(customerTabPage);
            mainTabControl.Dock = DockStyle.Bottom;
            mainTabControl.Location = new Point(0, 35);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(800, 493);
            mainTabControl.TabIndex = 0;
            // 
            // customerTabPage
            // 
            customerTabPage.Location = new Point(4, 24);
            customerTabPage.Name = "customerTabPage";
            customerTabPage.Padding = new Padding(3);
            customerTabPage.Size = new Size(792, 465);
            customerTabPage.TabIndex = 0;
            customerTabPage.Text = "Customer";
            customerTabPage.UseVisualStyleBackColor = true;
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
            logoutLinkLabel.Location = new Point(747, 0);
            logoutLinkLabel.Name = "logoutLinkLabel";
            logoutLinkLabel.Size = new Size(53, 15);
            logoutLinkLabel.TabIndex = 2;
            logoutLinkLabel.TabStop = true;
            logoutLinkLabel.Text = "LOGOUT";
            logoutLinkLabel.LinkClicked += logoutLinkLabel_LinkClicked;
            // 
            // MainDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(logoutLinkLabel);
            Controls.Add(greetingLabel);
            Controls.Add(mainTabControl);
            Name = "MainDashBoard";
            Text = "Main Dashboard";
            mainTabControl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl mainTabControl;
        private TabPage customerTabPage;
        private Label greetingLabel;
        private LinkLabel logoutLinkLabel;
    }
}
