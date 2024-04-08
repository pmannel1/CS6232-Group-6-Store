namespace CS6232_Group_6_Store.UserControls
{
    partial class TransactionManagement
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            memberSelectionMethodLabel = new Label();
            memberSearchLabel = new Label();
            memberSearchListViewLabel = new Label();
            memberSearchMethodComboBox = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            memberSearchButton = new Button();
            memberSearchBox = new TextBox();
            memberListView = new ListView();
            tableLayoutPanel4 = new TableLayoutPanel();
            memberHistorySearchButton = new Button();
            clearMemberSearchButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            clearMemberHistorySearchButton = new Button();
            memberHistoryLabel = new Label();
            memberHistoryListView = new ListView();
            transactionErrorLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.5F));
            tableLayoutPanel1.Size = new Size(700, 400);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.8933716F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.10663F));
            tableLayoutPanel2.Controls.Add(memberSelectionMethodLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(memberSearchLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(memberSearchListViewLabel, 0, 2);
            tableLayoutPanel2.Controls.Add(memberSearchMethodComboBox, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Controls.Add(memberListView, 1, 2);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 3);
            tableLayoutPanel2.Controls.Add(transactionErrorLabel, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(694, 212);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // memberSelectionMethodLabel
            // 
            memberSelectionMethodLabel.AutoSize = true;
            memberSelectionMethodLabel.Location = new Point(3, 0);
            memberSelectionMethodLabel.Name = "memberSelectionMethodLabel";
            memberSelectionMethodLabel.Size = new Size(135, 15);
            memberSelectionMethodLabel.TabIndex = 0;
            memberSelectionMethodLabel.Text = "Member Search Method";
            // 
            // memberSearchLabel
            // 
            memberSearchLabel.AutoSize = true;
            memberSearchLabel.Location = new Point(3, 42);
            memberSearchLabel.Name = "memberSearchLabel";
            memberSearchLabel.Size = new Size(48, 15);
            memberSearchLabel.TabIndex = 1;
            memberSearchLabel.Text = "Search: ";
            // 
            // memberSearchListViewLabel
            // 
            memberSearchListViewLabel.AutoSize = true;
            memberSearchListViewLabel.Location = new Point(3, 84);
            memberSearchListViewLabel.Name = "memberSearchListViewLabel";
            memberSearchListViewLabel.Size = new Size(50, 15);
            memberSearchListViewLabel.TabIndex = 2;
            memberSearchListViewLabel.Text = "Results: ";
            // 
            // memberSearchMethodComboBox
            // 
            memberSearchMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            memberSearchMethodComboBox.FormattingEnabled = true;
            memberSearchMethodComboBox.Items.AddRange(new object[] { "ID", "Name" });
            memberSearchMethodComboBox.Location = new Point(148, 3);
            memberSearchMethodComboBox.Name = "memberSearchMethodComboBox";
            memberSearchMethodComboBox.Size = new Size(121, 23);
            memberSearchMethodComboBox.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 284F));
            tableLayoutPanel3.Controls.Add(memberSearchButton, 1, 0);
            tableLayoutPanel3.Controls.Add(memberSearchBox, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(148, 45);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(543, 36);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // memberSearchButton
            // 
            memberSearchButton.Location = new Point(132, 3);
            memberSearchButton.Name = "memberSearchButton";
            memberSearchButton.Size = new Size(118, 21);
            memberSearchButton.TabIndex = 0;
            memberSearchButton.Text = "Search";
            memberSearchButton.UseVisualStyleBackColor = true;
            memberSearchButton.Click += memberSearchButton_Click;
            // 
            // memberSearchBox
            // 
            memberSearchBox.Location = new Point(3, 3);
            memberSearchBox.Name = "memberSearchBox";
            memberSearchBox.Size = new Size(100, 23);
            memberSearchBox.TabIndex = 1;
           
            // 
            // memberListView
            // 
            memberListView.CheckBoxes = true;
            memberListView.Dock = DockStyle.Fill;
            memberListView.Location = new Point(148, 87);
            memberListView.Name = "memberListView";
            memberListView.Size = new Size(543, 78);
            memberListView.TabIndex = 5;
            memberListView.UseCompatibleStateImageBehavior = false;
            memberListView.ItemChecked += memberListView_ItemChecked;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(memberHistorySearchButton, 0, 0);
            tableLayoutPanel4.Controls.Add(clearMemberSearchButton, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(148, 171);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(543, 38);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // memberHistorySearchButton
            // 
            memberHistorySearchButton.Location = new Point(3, 3);
            memberHistorySearchButton.Name = "memberHistorySearchButton";
            memberHistorySearchButton.Size = new Size(118, 21);
            memberHistorySearchButton.TabIndex = 1;
            memberHistorySearchButton.Text = "Member History";
            memberHistorySearchButton.UseVisualStyleBackColor = true;
            memberHistorySearchButton.Click += memberHistorySearchButton_Click;
            // 
            // clearMemberSearchButton
            // 
            clearMemberSearchButton.Location = new Point(274, 3);
            clearMemberSearchButton.Name = "clearMemberSearchButton";
            clearMemberSearchButton.Size = new Size(118, 21);
            clearMemberSearchButton.TabIndex = 2;
            clearMemberSearchButton.Text = "Clear Search";
            clearMemberSearchButton.UseVisualStyleBackColor = true;
            clearMemberSearchButton.Click += clearMemberSearchButton_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel5.Controls.Add(memberHistoryLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(memberHistoryListView, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 221);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(694, 176);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(clearMemberHistorySearchButton, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 143);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(688, 30);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // clearMemberHistorySearchButton
            // 
            clearMemberHistorySearchButton.Location = new Point(347, 3);
            clearMemberHistorySearchButton.Name = "clearMemberHistorySearchButton";
            clearMemberHistorySearchButton.Size = new Size(118, 21);
            clearMemberHistorySearchButton.TabIndex = 0;
            clearMemberHistorySearchButton.Text = "Clear History";
            clearMemberHistorySearchButton.UseVisualStyleBackColor = true;
            clearMemberHistorySearchButton.Click += clearMemberHistorySearchButton_Click;
            // 
            // memberHistoryLabel
            // 
            memberHistoryLabel.AutoSize = true;
            memberHistoryLabel.Dock = DockStyle.Fill;
            memberHistoryLabel.Location = new Point(3, 0);
            memberHistoryLabel.Name = "memberHistoryLabel";
            memberHistoryLabel.Size = new Size(688, 35);
            memberHistoryLabel.TabIndex = 1;
            memberHistoryLabel.Text = "Rental History";
            memberHistoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // memberHistoryListView
            // 
            memberHistoryListView.Dock = DockStyle.Fill;
            memberHistoryListView.Location = new Point(3, 38);
            memberHistoryListView.Name = "memberHistoryListView";
            memberHistoryListView.Size = new Size(688, 99);
            memberHistoryListView.TabIndex = 2;
            memberHistoryListView.UseCompatibleStateImageBehavior = false;
            // 
            // transactionErrorLabel
            // 
            transactionErrorLabel.AutoSize = true;
            transactionErrorLabel.Location = new Point(3, 168);
            transactionErrorLabel.Name = "transactionErrorLabel";
            transactionErrorLabel.Size = new Size(0, 15);
            transactionErrorLabel.TabIndex = 7;
            // 
            // TransactionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionManagement";
            Size = new Size(700, 400);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label memberSelectionMethodLabel;
        private Label memberSearchLabel;
        private Label memberSearchListViewLabel;
        private ComboBox memberSearchMethodComboBox;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView memberListView;
        private TableLayoutPanel tableLayoutPanel4;
        private Button memberSearchButton;
        private TextBox memberSearchBox;
        private Button memberHistorySearchButton;
        private Button clearMemberSearchButton;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button clearMemberHistorySearchButton;
        private Label memberHistoryLabel;
        private ListView memberHistoryListView;
        private Label transactionErrorLabel;
    }
}
