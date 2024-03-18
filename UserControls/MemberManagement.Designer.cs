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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // searchMethodLabel
            // 
            searchMethodLabel.AutoSize = true;
            searchMethodLabel.Location = new Point(645, 0);
            searchMethodLabel.Name = "searchMethodLabel";
            searchMethodLabel.Size = new Size(86, 15);
            searchMethodLabel.TabIndex = 21;
            searchMethodLabel.Text = "search method";
            // 
            // searchMessageLabel
            // 
            searchMessageLabel.AutoSize = true;
            searchMessageLabel.Location = new Point(645, 88);
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
            searchMethodBox.Location = new Point(324, 2);
            searchMethodBox.Margin = new Padding(3, 2, 3, 2);
            searchMethodBox.Name = "searchMethodBox";
            searchMethodBox.Size = new Size(154, 23);
            searchMethodBox.TabIndex = 18;
            searchMethodBox.SelectedIndexChanged += searchMethodBox_SelectedIndexChanged;
            // 
            // membersListView
            // 
            membersListView.Location = new Point(3, 141);
            membersListView.Margin = new Padding(3, 2, 3, 2);
            membersListView.Name = "membersListView";
            membersListView.Size = new Size(964, 221);
            membersListView.TabIndex = 17;
            membersListView.UseCompatibleStateImageBehavior = false;
            membersListView.SelectedIndexChanged += MemberListView_Select;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 16;
            label2.Text = "General Search";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(324, 90);
            searchBox.Margin = new Padding(3, 2, 3, 2);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(298, 23);
            searchBox.TabIndex = 15;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 44);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 14;
            label1.Text = "Member Name";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(645, 46);
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
            customerListBox.Location = new Point(324, 46);
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
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(964, 133);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 374);
            editButton.Name = "editButton";
            editButton.Size = new Size(102, 23);
            editButton.TabIndex = 23;
            editButton.Text = "Edit Member";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(93, 23);
            addButton.TabIndex = 24;
            addButton.Text = "Add Member";
            addButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(485, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 25;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(membersListView, 0, 1);
            tableLayoutPanel2.Controls.Add(editButton, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(970, 465);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(addButton, 0, 0);
            tableLayoutPanel3.Controls.Add(clearButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 420);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(964, 42);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // MemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MemberManagement";
            Size = new Size(970, 465);
            Load += MemberManagement_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}
