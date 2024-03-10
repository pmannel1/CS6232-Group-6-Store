namespace CS6232_Group_6_Store.UserControls
{
    partial class MemberManagement
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
            searchMethodLabel = new Label();
            searchMessageLabel = new Label();
            label3 = new Label();
            searchMethodBox = new ComboBox();
            membersListView = new ListView();
            label2 = new Label();
            searchBox = new TextBox();
            label1 = new Label();
            searchButton = new Button();
            customerListBox = new ComboBox();
            ID = new ColumnHeader();
            LastName = new ColumnHeader();
            FirstName = new ColumnHeader();
            DateOfBirth = new ColumnHeader();
            StreetAddress = new ColumnHeader();
            SuspendLayout();
            // 
            // searchMethodLabel
            // 
            searchMethodLabel.AutoSize = true;
            searchMethodLabel.Location = new Point(378, 87);
            searchMethodLabel.Name = "searchMethodLabel";
            searchMethodLabel.Size = new Size(86, 15);
            searchMethodLabel.TabIndex = 21;
            searchMethodLabel.Text = "search method";
            // 
            // searchMessageLabel
            // 
            searchMessageLabel.AutoSize = true;
            searchMessageLabel.Location = new Point(195, 189);
            searchMessageLabel.Name = "searchMessageLabel";
            searchMessageLabel.Size = new Size(91, 15);
            searchMessageLabel.TabIndex = 20;
            searchMessageLabel.Text = "Search Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 87);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 19;
            label3.Text = "Select Search Method";
            // 
            // searchMethodBox
            // 
            searchMethodBox.FormattingEnabled = true;
            searchMethodBox.Items.AddRange(new object[] { "Name", "Id", "Phone" });
            searchMethodBox.Location = new Point(195, 85);
            searchMethodBox.Margin = new Padding(3, 2, 3, 2);
            searchMethodBox.Name = "searchMethodBox";
            searchMethodBox.Size = new Size(154, 23);
            searchMethodBox.TabIndex = 18;
            searchMethodBox.SelectedIndexChanged += searchMethodBox_SelectedIndexChanged;
            // 
            // membersListView
            // 
            membersListView.Location = new Point(10, 214);
            membersListView.Margin = new Padding(3, 2, 3, 2);
            membersListView.Name = "membersListView";
            membersListView.Size = new Size(950, 233);
            membersListView.TabIndex = 17;
            membersListView.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 161);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 16;
            label2.Text = "General Search";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(192, 155);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(298, 23);
            searchBox.TabIndex = 15;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 122);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 14;
            label1.Text = "Member Name";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(565, 120);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(110, 28);
            searchButton.TabIndex = 13;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // customerListBox
            // 
            customerListBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerListBox.FormattingEnabled = true;
            customerListBox.Location = new Point(192, 120);
            customerListBox.Margin = new Padding(3, 2, 3, 2);
            customerListBox.Name = "customerListBox";
            customerListBox.Size = new Size(298, 23);
            customerListBox.TabIndex = 12;
            customerListBox.SelectedIndexChanged += customerListBox_SelectedIndexChanged;
            // 
            // MemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchMethodLabel);
            Controls.Add(searchMessageLabel);
            Controls.Add(label3);
            Controls.Add(searchMethodBox);
            Controls.Add(membersListView);
            Controls.Add(label2);
            Controls.Add(searchBox);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(customerListBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MemberManagement";
            Size = new Size(970, 465);
            Load += MemberManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label searchMethodLabel;
        private Label searchMessageLabel;
        private Label label3;
        private ComboBox searchMethodBox;
        private ListView membersListView;
        private Label label2;
        private TextBox searchBox;
        private Label label1;
        private Button searchButton;
        private ComboBox customerListBox;
        private ColumnHeader ID;
        private ColumnHeader LastName;
        private ColumnHeader FirstName;
        private ColumnHeader DateOfBirth;
        private ColumnHeader StreetAddress;
    }
}
