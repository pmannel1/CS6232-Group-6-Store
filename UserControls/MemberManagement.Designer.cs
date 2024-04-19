﻿namespace CS6232_Group_6_Store.UserControls
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
            ID = new ColumnHeader();
            LastName = new ColumnHeader();
            FirstName = new ColumnHeader();
            DateOfBirth = new ColumnHeader();
            StreetAddress = new ColumnHeader();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            editButton = new Button();
            addButton = new Button();
            clearButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            memberListView = new ListView();
            memberSearchListViewLabel = new Label();
            searchMethodBox = new ComboBox();
            memberSelectionMethodLabel = new Label();
            memberSearchLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            memberSearchBox = new TextBox();
            searchButton = new Button();
            memberErrorLabel = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(memberErrorLabel, 0, 1);
            tableLayoutPanel2.Location = new Point(0, 1);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75.93985F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 3.75939846F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.4712048F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel2.Size = new Size(800, 532);
            tableLayoutPanel2.TabIndex = 26;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tableLayoutPanel3.Controls.Add(editButton, 2, 0);
            tableLayoutPanel3.Controls.Add(addButton, 0, 0);
            tableLayoutPanel3.Controls.Add(clearButton, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 479);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(793, 49);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // editButton
            // 
            editButton.Location = new Point(555, 4);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(106, 31);
            editButton.TabIndex = 4;
            editButton.Text = "Edit Member";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 4);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(106, 31);
            addButton.TabIndex = 5;
            addButton.Text = "Add Member";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(279, 4);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(106, 31);
            clearButton.TabIndex = 6;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(memberListView, 1, 2);
            tableLayoutPanel1.Controls.Add(memberSearchListViewLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(searchMethodBox, 1, 0);
            tableLayoutPanel1.Controls.Add(memberSelectionMethodLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(memberSearchLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(793, 360);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // memberListView
            // 
            memberListView.CheckBoxes = true;
            memberListView.Dock = DockStyle.Fill;
            memberListView.Location = new Point(161, 112);
            memberListView.Margin = new Padding(3, 4, 3, 4);
            memberListView.Name = "memberListView";
            memberListView.Size = new Size(629, 244);
            memberListView.TabIndex = 8;
            memberListView.UseCompatibleStateImageBehavior = false;
            memberListView.SelectedIndexChanged += memberListView_SelectedIndexChanged;
            memberListView.Click += memberListView_SelectedIndexChanged;
            // 
            // memberSearchListViewLabel
            // 
            memberSearchListViewLabel.AutoSize = true;
            memberSearchListViewLabel.Location = new Point(3, 108);
            memberSearchListViewLabel.Name = "memberSearchListViewLabel";
            memberSearchListViewLabel.Size = new Size(62, 20);
            memberSearchListViewLabel.TabIndex = 7;
            memberSearchListViewLabel.Text = "Results: ";
            // 
            // searchMethodBox
            // 
            searchMethodBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchMethodBox.FormattingEnabled = true;
            searchMethodBox.Items.AddRange(new object[] { "Name", "ID", "Phone" });
            searchMethodBox.Location = new Point(161, 3);
            searchMethodBox.Name = "searchMethodBox";
            searchMethodBox.Size = new Size(175, 28);
            searchMethodBox.TabIndex = 0;
            // 
            // memberSelectionMethodLabel
            // 
            memberSelectionMethodLabel.AutoSize = true;
            memberSelectionMethodLabel.Location = new Point(3, 0);
            memberSelectionMethodLabel.Name = "memberSelectionMethodLabel";
            memberSelectionMethodLabel.Size = new Size(117, 40);
            memberSelectionMethodLabel.TabIndex = 3;
            memberSelectionMethodLabel.Text = "Member Search Method";
            // 
            // memberSearchLabel
            // 
            memberSearchLabel.AutoSize = true;
            memberSearchLabel.Location = new Point(3, 54);
            memberSearchLabel.Name = "memberSearchLabel";
            memberSearchLabel.Size = new Size(60, 20);
            memberSearchLabel.TabIndex = 4;
            memberSearchLabel.Text = "Search: ";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(memberSearchBox, 0, 0);
            tableLayoutPanel5.Controls.Add(searchButton, 1, 0);
            tableLayoutPanel5.Location = new Point(161, 58);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(629, 45);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // memberSearchBox
            // 
            memberSearchBox.Dock = DockStyle.Fill;
            memberSearchBox.Location = new Point(3, 4);
            memberSearchBox.Margin = new Padding(3, 4, 3, 4);
            memberSearchBox.Name = "memberSearchBox";
            memberSearchBox.Size = new Size(308, 27);
            memberSearchBox.TabIndex = 5;
            // 
            // searchButton
            // 
            searchButton.Dock = DockStyle.Fill;
            searchButton.Location = new Point(317, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(309, 39);
            searchButton.TabIndex = 2;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // memberErrorLabel
            // 
            memberErrorLabel.AutoSize = true;
            memberErrorLabel.Location = new Point(3, 405);
            memberErrorLabel.Name = "memberErrorLabel";
            memberErrorLabel.Size = new Size(0, 20);
            memberErrorLabel.TabIndex = 28;
            // 
            // MemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "MemberManagement";
            Size = new Size(800, 533);
            VisibleChanged += MemberManagement_VisibleChanged;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader ID;
        private ColumnHeader LastName;
        private ColumnHeader FirstName;
        private ColumnHeader DateOfBirth;
        private ColumnHeader StreetAddress;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox searchMethodBox;
        private Button searchButton;
        private Label memberSelectionMethodLabel;
        private Label memberSearchLabel;
        private TextBox memberSearchBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Label memberSearchListViewLabel;
        private ListView memberListView;
        private TableLayoutPanel tableLayoutPanel3;
        private Button editButton;
        private Button addButton;
        private Button clearButton;
        private Label memberErrorLabel;
    }
}
