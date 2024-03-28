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
            label3 = new Label();
            searchMethodBox = new ComboBox();
            membersListView = new ListView();
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
            tableLayoutPanel4 = new TableLayoutPanel();
            editingInstructionLabel = new Label();
            viewRentalHistoryButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
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
            searchMethodBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchMethodBox.FormattingEnabled = true;
            searchMethodBox.Items.AddRange(new object[] { "Name", "Id", "Phone" });
            searchMethodBox.Location = new Point(141, 2);
            searchMethodBox.Margin = new Padding(3, 2, 3, 2);
            searchMethodBox.Name = "searchMethodBox";
            searchMethodBox.Size = new Size(154, 23);
            searchMethodBox.TabIndex = 0;
            searchMethodBox.SelectedIndexChanged += searchMethodBox_SelectedIndexChanged;
            // 
            // membersListView
            // 
            membersListView.Dock = DockStyle.Fill;
            membersListView.Location = new Point(3, 189);
            membersListView.Margin = new Padding(3, 2, 3, 2);
            membersListView.Name = "membersListView";
            membersListView.Size = new Size(694, 165);
            membersListView.TabIndex = 3;
            membersListView.UseCompatibleStateImageBehavior = false;
            membersListView.SelectedIndexChanged += MemberListView_Select;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(141, 76);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(110, 28);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // customerListBox
            // 
            customerListBox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerListBox.FormattingEnabled = true;
            customerListBox.Location = new Point(141, 39);
            customerListBox.Margin = new Padding(3, 2, 3, 2);
            customerListBox.Name = "customerListBox";
            customerListBox.Size = new Size(298, 23);
            customerListBox.TabIndex = 1;
            customerListBox.SelectedIndexChanged += customerListBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(searchMethodBox, 1, 0);
            tableLayoutPanel1.Controls.Add(customerListBox, 1, 1);
            tableLayoutPanel1.Controls.Add(searchButton, 1, 2);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(694, 114);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // editButton
            // 
            editButton.Location = new Point(350, 3);
            editButton.Name = "editButton";
            editButton.Size = new Size(93, 23);
            editButton.TabIndex = 4;
            editButton.Text = "Edit Member";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(93, 23);
            addButton.TabIndex = 5;
            addButton.Text = "Add Member";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(350, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(93, 23);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(membersListView, 0, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 31.41361F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7068081F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 42.4083824F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4712048F));
            tableLayoutPanel2.Size = new Size(700, 400);
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
            tableLayoutPanel3.Location = new Point(3, 359);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(694, 38);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(editingInstructionLabel, 0, 0);
            tableLayoutPanel4.Controls.Add(editButton, 1, 0);
            tableLayoutPanel4.Controls.Add(viewRentalHistoryButton, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 128);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel4.Size = new Size(694, 56);
            tableLayoutPanel4.TabIndex = 29;
            // 
            // editingInstructionLabel
            // 
            editingInstructionLabel.AutoSize = true;
            editingInstructionLabel.Dock = DockStyle.Fill;
            editingInstructionLabel.Location = new Point(3, 0);
            editingInstructionLabel.Name = "editingInstructionLabel";
            editingInstructionLabel.Size = new Size(341, 29);
            editingInstructionLabel.TabIndex = 29;
            editingInstructionLabel.Text = "Please Click the ID Value of the Member to Edit or View History";
            // 
            // viewRentalHistoryButton
            // 
            viewRentalHistoryButton.Location = new Point(3, 32);
            viewRentalHistoryButton.Name = "viewRentalHistoryButton";
            viewRentalHistoryButton.Size = new Size(93, 21);
            viewRentalHistoryButton.TabIndex = 30;
            viewRentalHistoryButton.Text = "Rental History";
            viewRentalHistoryButton.UseVisualStyleBackColor = true;
            viewRentalHistoryButton.Click += viewRentalHistoryButton_Click;
            // 
            // MemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MemberManagement";
            Size = new Size(700, 400);
            VisibleChanged += MemberManagement_VisibleChanged;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private ComboBox searchMethodBox;
        private ListView membersListView;
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
        private TableLayoutPanel tableLayoutPanel4;
        private Label editingInstructionLabel;
        private Button viewRentalHistoryButton;
    }
}
