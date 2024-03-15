namespace CS6232_Group_6_Store.UserControls
{
    partial class MemberEdit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            memberFNameLabel = new Label();
            memberLastNameLabel = new Label();
            memberAddressStreetLabel = new Label();
            memberCityLabel = new Label();
            memberStateLabel = new Label();
            memebrZipCodeLabel = new Label();
            memberPhoneNumberLabel = new Label();
            firstNameText = new TextBox();
            lastNameText = new TextBox();
            addressTextBox = new TextBox();
            cityText = new TextBox();
            zipText = new TextBox();
            phoneText = new TextBox();
            stateComboBox = new ComboBox();
            cancelButton = new Button();
            updateButton = new Button();
            customerIDLabel = new Label();
            memberIDText = new TextBox();
            memberSearchButton = new Button();
            SuspendLayout();
            // 
            // memberFNameLabel
            // 
            memberFNameLabel.AutoSize = true;
            memberFNameLabel.Location = new Point(23, 101);
            memberFNameLabel.Name = "memberFNameLabel";
            memberFNameLabel.Size = new Size(80, 20);
            memberFNameLabel.TabIndex = 20;
            memberFNameLabel.Text = "First Name";
            // 
            // memberLastNameLabel
            // 
            memberLastNameLabel.AutoSize = true;
            memberLastNameLabel.Location = new Point(23, 148);
            memberLastNameLabel.Name = "memberLastNameLabel";
            memberLastNameLabel.Size = new Size(79, 20);
            memberLastNameLabel.TabIndex = 21;
            memberLastNameLabel.Text = "Last Name";
            // 
            // memberAddressStreetLabel
            // 
            memberAddressStreetLabel.AutoSize = true;
            memberAddressStreetLabel.Location = new Point(24, 193);
            memberAddressStreetLabel.Name = "memberAddressStreetLabel";
            memberAddressStreetLabel.Size = new Size(62, 20);
            memberAddressStreetLabel.TabIndex = 22;
            memberAddressStreetLabel.Text = "Address";
            // 
            // memberCityLabel
            // 
            memberCityLabel.AutoSize = true;
            memberCityLabel.Location = new Point(23, 235);
            memberCityLabel.Name = "memberCityLabel";
            memberCityLabel.Size = new Size(34, 20);
            memberCityLabel.TabIndex = 23;
            memberCityLabel.Text = "City";
            // 
            // memberStateLabel
            // 
            memberStateLabel.AutoSize = true;
            memberStateLabel.Location = new Point(24, 276);
            memberStateLabel.Name = "memberStateLabel";
            memberStateLabel.Size = new Size(43, 20);
            memberStateLabel.TabIndex = 24;
            memberStateLabel.Text = "State";
            // 
            // memebrZipCodeLabel
            // 
            memebrZipCodeLabel.AutoSize = true;
            memebrZipCodeLabel.Location = new Point(23, 316);
            memebrZipCodeLabel.Name = "memebrZipCodeLabel";
            memebrZipCodeLabel.Size = new Size(66, 20);
            memebrZipCodeLabel.TabIndex = 25;
            memebrZipCodeLabel.Text = "ZipCode";
            // 
            // memberPhoneNumberLabel
            // 
            memberPhoneNumberLabel.AutoSize = true;
            memberPhoneNumberLabel.Location = new Point(24, 353);
            memberPhoneNumberLabel.Name = "memberPhoneNumberLabel";
            memberPhoneNumberLabel.Size = new Size(50, 20);
            memberPhoneNumberLabel.TabIndex = 26;
            memberPhoneNumberLabel.Text = "Phone";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(169, 94);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(267, 27);
            firstNameText.TabIndex = 27;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(169, 141);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(267, 27);
            lastNameText.TabIndex = 28;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(169, 186);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(267, 27);
            addressTextBox.TabIndex = 29;
            // 
            // cityText
            // 
            cityText.Location = new Point(169, 228);
            cityText.Name = "cityText";
            cityText.Size = new Size(267, 27);
            cityText.TabIndex = 30;
            // 
            // zipText
            // 
            zipText.Location = new Point(169, 309);
            zipText.Name = "zipText";
            zipText.Size = new Size(267, 27);
            zipText.TabIndex = 31;
            // 
            // phoneText
            // 
            phoneText.Location = new Point(169, 346);
            phoneText.Name = "phoneText";
            phoneText.Size = new Size(267, 27);
            phoneText.TabIndex = 32;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(169, 268);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(151, 28);
            stateComboBox.TabIndex = 33;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(169, 398);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 34;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(342, 398);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(94, 29);
            updateButton.TabIndex = 35;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new Point(24, 26);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new Size(80, 20);
            customerIDLabel.TabIndex = 36;
            customerIDLabel.Text = "MemberID";
            // 
            // memberIDText
            // 
            memberIDText.Location = new Point(169, 19);
            memberIDText.Name = "memberIDText";
            memberIDText.Size = new Size(267, 27);
            memberIDText.TabIndex = 37;
            // 
            // memberSearchButton
            // 
            memberSearchButton.Location = new Point(534, 17);
            memberSearchButton.Name = "memberSearchButton";
            memberSearchButton.Size = new Size(94, 29);
            memberSearchButton.TabIndex = 38;
            memberSearchButton.Text = "Search";
            memberSearchButton.UseVisualStyleBackColor = true;
            // 
            // MemberEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(memberSearchButton);
            Controls.Add(memberIDText);
            Controls.Add(customerIDLabel);
            Controls.Add(updateButton);
            Controls.Add(cancelButton);
            Controls.Add(stateComboBox);
            Controls.Add(phoneText);
            Controls.Add(zipText);
            Controls.Add(cityText);
            Controls.Add(addressTextBox);
            Controls.Add(lastNameText);
            Controls.Add(firstNameText);
            Controls.Add(memberPhoneNumberLabel);
            Controls.Add(memebrZipCodeLabel);
            Controls.Add(memberStateLabel);
            Controls.Add(memberCityLabel);
            Controls.Add(memberAddressStreetLabel);
            Controls.Add(memberLastNameLabel);
            Controls.Add(memberFNameLabel);
            Name = "MemberEdit";
            Size = new Size(703, 473);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label memberFNameLabel;
        private Label memberLastNameLabel;
        private Label memberAddressStreetLabel;
        private Label memberCityLabel;
        private Label memberStateLabel;
        private Label memebrZipCodeLabel;
        private Label memberPhoneNumberLabel;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private TextBox addressTextBox;
        private TextBox cityText;
        private TextBox zipText;
        private TextBox phoneText;
        private ComboBox stateComboBox;
        private Button cancelButton;
        private Button updateButton;
        private Label customerIDLabel;
        private TextBox memberIDText;
        private Button memberSearchButton;
    }
}
