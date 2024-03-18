namespace CS6232_Group_6_Store.View
{
    partial class EditMemberForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            streetLabel = new Label();
            dobLabel = new Label();
            sexLabel = new Label();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            cityLabel = new Label();
            stateLabel = new Label();
            zipCodeLabel = new Label();
            phoneNumberLabel = new Label();
            passwordLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            streetAddressTextBox = new TextBox();
            cityTextBox = new TextBox();
            zipCodeTextBox = new TextBox();
            sexComboBox = new ComboBox();
            dateOfBirthPicker = new DateTimePicker();
            stateTextBox = new ComboBox();
            phoneNumberTextBox = new TextBox();
            passwordTextBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            confirmButton = new Button();
            clearButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(streetLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(dobLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(sexLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(firstNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(lastNameLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(cityLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(stateLabel, 0, 6);
            tableLayoutPanel1.Controls.Add(zipCodeLabel, 0, 7);
            tableLayoutPanel1.Controls.Add(phoneNumberLabel, 0, 8);
            tableLayoutPanel1.Controls.Add(passwordLabel, 0, 9);
            tableLayoutPanel1.Controls.Add(firstNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(lastNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(streetAddressTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(cityTextBox, 1, 5);
            tableLayoutPanel1.Controls.Add(zipCodeTextBox, 1, 7);
            tableLayoutPanel1.Controls.Add(sexComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(dateOfBirthPicker, 1, 3);
            tableLayoutPanel1.Controls.Add(stateTextBox, 1, 6);
            tableLayoutPanel1.Controls.Add(phoneNumberTextBox, 1, 8);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 1, 9);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 10);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 11;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090908F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(3, 160);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(82, 15);
            streetLabel.TabIndex = 8;
            streetLabel.Text = "Street Address";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new Point(3, 120);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(73, 15);
            dobLabel.TabIndex = 6;
            dobLabel.Text = "Date of Birth";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new Point(3, 80);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(25, 15);
            sexLabel.TabIndex = 4;
            sexLabel.Text = "Sex";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(3, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(3, 40);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(3, 200);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(28, 15);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(3, 240);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(33, 15);
            stateLabel.TabIndex = 5;
            stateLabel.Text = "State";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new Point(3, 280);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new Size(50, 15);
            zipCodeLabel.TabIndex = 3;
            zipCodeLabel.Text = "Zipcode";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(3, 320);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(88, 15);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(3, 360);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(163, 3);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(100, 23);
            firstNameTextBox.TabIndex = 13;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(163, 43);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(100, 23);
            lastNameTextBox.TabIndex = 14;
            // 
            // streetAddressTextBox
            // 
            streetAddressTextBox.Location = new Point(163, 163);
            streetAddressTextBox.Name = "streetAddressTextBox";
            streetAddressTextBox.Size = new Size(100, 23);
            streetAddressTextBox.TabIndex = 15;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(163, 203);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(100, 23);
            cityTextBox.TabIndex = 16;
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Location = new Point(163, 283);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(100, 23);
            zipCodeTextBox.TabIndex = 17;
            // 
            // sexComboBox
            // 
            sexComboBox.FormattingEnabled = true;
            sexComboBox.Location = new Point(163, 83);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(121, 23);
            sexComboBox.TabIndex = 20;
            // 
            // dateOfBirthPicker
            // 
            dateOfBirthPicker.Location = new Point(163, 123);
            dateOfBirthPicker.Name = "dateOfBirthPicker";
            dateOfBirthPicker.Size = new Size(200, 23);
            dateOfBirthPicker.TabIndex = 21;
            // 
            // stateTextBox
            // 
            stateTextBox.FormattingEnabled = true;
            stateTextBox.Location = new Point(163, 243);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(121, 23);
            stateTextBox.TabIndex = 22;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(163, 323);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(100, 23);
            phoneNumberTextBox.TabIndex = 18;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(163, 363);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(confirmButton, 0, 0);
            tableLayoutPanel2.Controls.Add(clearButton, 2, 0);
            tableLayoutPanel2.Controls.Add(cancelButton, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(163, 403);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(474, 44);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(3, 3);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(73, 23);
            confirmButton.TabIndex = 11;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(161, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(73, 23);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(319, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(73, 23);
            cancelButton.TabIndex = 23;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // EditMemberForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EditMemberForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Member";
            Load += EditMemberForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label streetLabel;
        private Label dobLabel;
        private Label sexLabel;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label cityLabel;
        private Label stateLabel;
        private Label zipCodeLabel;
        private Label phoneNumberLabel;
        private Label passwordLabel;
        private Button confirmButton;
        private Button clearButton;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox streetAddressTextBox;
        private TextBox cityTextBox;
        private TextBox zipCodeTextBox;
        private TextBox phoneNumberTextBox;
        private TextBox passwordTextBox;
        private ComboBox sexComboBox;
        private DateTimePicker dateOfBirthPicker;
        private ComboBox stateTextBox;
        private Button cancelButton;
        private TableLayoutPanel tableLayoutPanel2;
    }
}