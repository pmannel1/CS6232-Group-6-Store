namespace CS6232_Group_6_Store.UserControls
{
    partial class MemberAdd
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
            addButton = new Button();
            genderBox = new ComboBox();
            genderLabel = new Label();
            errorLabel = new Label();
            dobLabel = new Label();
            dobPicker = new DateTimePicker();
            countryTextBox = new TextBox();
            countryLabel = new Label();
            SuspendLayout();
            // 
            // memberFNameLabel
            // 
            memberFNameLabel.AutoSize = true;
            memberFNameLabel.Location = new Point(23, 26);
            memberFNameLabel.Name = "memberFNameLabel";
            memberFNameLabel.Size = new Size(64, 15);
            memberFNameLabel.TabIndex = 20;
            memberFNameLabel.Text = "First Name";
            // 
            // memberLastNameLabel
            // 
            memberLastNameLabel.AutoSize = true;
            memberLastNameLabel.Location = new Point(23, 61);
            memberLastNameLabel.Name = "memberLastNameLabel";
            memberLastNameLabel.Size = new Size(63, 15);
            memberLastNameLabel.TabIndex = 21;
            memberLastNameLabel.Text = "Last Name";
            // 
            // memberAddressStreetLabel
            // 
            memberAddressStreetLabel.AutoSize = true;
            memberAddressStreetLabel.Location = new Point(24, 114);
            memberAddressStreetLabel.Name = "memberAddressStreetLabel";
            memberAddressStreetLabel.Size = new Size(49, 15);
            memberAddressStreetLabel.TabIndex = 22;
            memberAddressStreetLabel.Text = "Address";
            // 
            // memberCityLabel
            // 
            memberCityLabel.AutoSize = true;
            memberCityLabel.Location = new Point(23, 146);
            memberCityLabel.Name = "memberCityLabel";
            memberCityLabel.Size = new Size(28, 15);
            memberCityLabel.TabIndex = 23;
            memberCityLabel.Text = "City";
            // 
            // memberStateLabel
            // 
            memberStateLabel.AutoSize = true;
            memberStateLabel.Location = new Point(24, 176);
            memberStateLabel.Name = "memberStateLabel";
            memberStateLabel.Size = new Size(33, 15);
            memberStateLabel.TabIndex = 24;
            memberStateLabel.Text = "State";
            // 
            // memebrZipCodeLabel
            // 
            memebrZipCodeLabel.AutoSize = true;
            memebrZipCodeLabel.Location = new Point(23, 206);
            memebrZipCodeLabel.Name = "memebrZipCodeLabel";
            memebrZipCodeLabel.Size = new Size(52, 15);
            memebrZipCodeLabel.TabIndex = 25;
            memebrZipCodeLabel.Text = "ZipCode";
            // 
            // memberPhoneNumberLabel
            // 
            memberPhoneNumberLabel.AutoSize = true;
            memberPhoneNumberLabel.Location = new Point(24, 234);
            memberPhoneNumberLabel.Name = "memberPhoneNumberLabel";
            memberPhoneNumberLabel.Size = new Size(41, 15);
            memberPhoneNumberLabel.TabIndex = 26;
            memberPhoneNumberLabel.Text = "Phone";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(150, 20);
            firstNameText.Margin = new Padding(3, 2, 3, 2);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(234, 23);
            firstNameText.TabIndex = 1;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(150, 56);
            lastNameText.Margin = new Padding(3, 2, 3, 2);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(234, 23);
            lastNameText.TabIndex = 2;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(150, 109);
            addressTextBox.Margin = new Padding(3, 2, 3, 2);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(234, 23);
            addressTextBox.TabIndex = 4;
            // 
            // cityText
            // 
            cityText.Location = new Point(150, 140);
            cityText.Margin = new Padding(3, 2, 3, 2);
            cityText.Name = "cityText";
            cityText.Size = new Size(234, 23);
            cityText.TabIndex = 5;
            // 
            // zipText
            // 
            zipText.Location = new Point(150, 201);
            zipText.Margin = new Padding(3, 2, 3, 2);
            zipText.Name = "zipText";
            zipText.Size = new Size(234, 23);
            zipText.TabIndex = 7;
            // 
            // phoneText
            // 
            phoneText.Location = new Point(150, 229);
            phoneText.Margin = new Padding(3, 2, 3, 2);
            phoneText.Name = "phoneText";
            phoneText.Size = new Size(234, 23);
            phoneText.TabIndex = 8;
            // 
            // stateComboBox
            // 
            stateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateComboBox.FormattingEnabled = true;
            stateComboBox.Location = new Point(150, 170);
            stateComboBox.Margin = new Padding(3, 2, 3, 2);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.Size = new Size(133, 23);
            stateComboBox.TabIndex = 6;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(150, 330);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(82, 22);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += ClearButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(302, 330);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(82, 22);
            addButton.TabIndex = 12;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // genderBox
            // 
            genderBox.DropDownStyle = ComboBoxStyle.DropDownList;
            genderBox.FormattingEnabled = true;
            genderBox.Location = new Point(150, 83);
            genderBox.Margin = new Padding(3, 2, 3, 2);
            genderBox.Name = "genderBox";
            genderBox.Size = new Size(133, 23);
            genderBox.TabIndex = 3;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(24, 89);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(45, 15);
            genderLabel.TabIndex = 36;
            genderLabel.Text = "Gender";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(458, 23);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 38;
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(24, 294);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(73, 15);
            dobLabel.TabIndex = 39;
            dobLabel.Text = "Date of Birth";
            // 
            // dobPicker
            // 
            dobPicker.Location = new Point(150, 288);
            dobPicker.Name = "dobPicker";
            dobPicker.Size = new Size(200, 23);
            dobPicker.TabIndex = 10;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(150, 260);
            countryTextBox.Margin = new Padding(3, 2, 3, 2);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(234, 23);
            countryTextBox.TabIndex = 9;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(24, 265);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(50, 15);
            countryLabel.TabIndex = 41;
            countryLabel.Text = "Country";
            // 
            // MemberAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(countryTextBox);
            Controls.Add(countryLabel);
            Controls.Add(dobPicker);
            Controls.Add(dobLabel);
            Controls.Add(errorLabel);
            Controls.Add(genderBox);
            Controls.Add(genderLabel);
            Controls.Add(addButton);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "MemberAdd";
            Size = new Size(615, 355);
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
        private Button addButton;
        private ComboBox genderBox;
        private Label genderLabel;
        private Label errorLabel;
        private Label dobLabel;
        private DateTimePicker dobPicker;
        private TextBox countryTextBox;
        private Label countryLabel;
    }
}
