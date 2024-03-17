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
            tableLayoutPanel1 = new TableLayoutPanel();
            editButton = new Button();
            addButton = new Button();
            clearButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchMethodLabel
            // 
            searchMethodLabel.AutoSize = true;
            searchMethodLabel.Location = new Point(649, 0);
            searchMethodLabel.Name = "searchMethodLabel";
            searchMethodLabel.Size = new Size(86, 15);
            searchMethodLabel.TabIndex = 21;
            searchMethodLabel.Text = "search method";
            // 
            // searchMessageLabel
            // 
            searchMessageLabel.AutoSize = true;
            searchMessageLabel.Location = new Point(649, 104);
            searchMessageLabel.Name = "searchMessageLabel";
            searchMessageLabel.Size = new Size(91, 15);
            searchMessageLabel.TabIndex = 20;
            searchMessageLabel.Text = "Search Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 19;
            label3.Text = "Select Search Method";
            // 
            // searchMethodBox
            // 
            searchMethodBox.FormattingEnabled = true;
            searchMethodBox.Items.AddRange(new object[] { "Name", "Id", "Phone" });
            searchMethodBox.Location = new Point(326, 2);
            searchMethodBox.Margin = new Padding(3, 2, 3, 2);
            searchMethodBox.Name = "searchMethodBox";
            searchMethodBox.Size = new Size(154, 23);
            searchMethodBox.TabIndex = 18;
            searchMethodBox.SelectedIndexChanged += searchMethodBox_SelectedIndexChanged;
            // 
            // membersListView
            // 
            membersListView.Location = new Point(-3, 161);
            membersListView.Margin = new Padding(3, 2, 3, 2);
            membersListView.Name = "membersListView";
            membersListView.Size = new Size(970, 221);
            membersListView.TabIndex = 17;
            membersListView.UseCompatibleStateImageBehavior = false;
            membersListView.SelectedIndexChanged += MemberListView_Select;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 104);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 16;
            label2.Text = "General Search";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(326, 106);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(298, 23);
            searchBox.TabIndex = 15;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 52);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 14;
            label1.Text = "Member Name";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(649, 54);
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
            customerListBox.Location = new Point(326, 54);
            customerListBox.Margin = new Padding(3, 2, 3, 2);
            customerListBox.Name = "customerListBox";
            customerListBox.Size = new Size(298, 23);
            customerListBox.TabIndex = 12;
            customerListBox.SelectedIndexChanged += customerListBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(searchMessageLabel, 2, 2);
            tableLayoutPanel1.Controls.Add(searchMethodLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(searchMethodBox, 1, 0);
            tableLayoutPanel1.Controls.Add(searchBox, 1, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(customerListBox, 1, 1);
            tableLayoutPanel1.Controls.Add(searchButton, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(970, 156);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // editButton
            // 
            editButton.Location = new Point(22, 397);
            editButton.Name = "editButton";
            editButton.Size = new Size(102, 23);
            editButton.TabIndex = 23;
            editButton.Text = "Edit Member";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(383, 397);
            addButton.Name = "addButton";
            addButton.Size = new Size(93, 23);
            addButton.TabIndex = 24;
            addButton.Text = "Add Member";
            addButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(676, 397);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 25;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // MemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(editButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(membersListView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MemberManagement";
            Size = new Size(970, 465);
            Load += MemberManagement_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private Button editButton;
        private Button addButton;
        private Button clearButton;
    }
}
