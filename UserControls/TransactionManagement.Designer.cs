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
            tableLayoutPanel4 = new TableLayoutPanel();
            memberHistorySearchButton = new Button();
            transactionErrorLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            clearMemberHistorySearchButton = new Button();
            memberHistoryLabel = new Label();
            memberHistoryListView = new ListView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.75F));
            tableLayoutPanel1.Size = new Size(700, 400);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.89337F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.10663F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(transactionErrorLabel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(694, 87);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(memberHistorySearchButton, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(147, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(544, 81);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // memberHistorySearchButton
            // 
            memberHistorySearchButton.Location = new Point(3, 3);
            memberHistorySearchButton.Name = "memberHistorySearchButton";
            memberHistorySearchButton.Size = new Size(165, 60);
            memberHistorySearchButton.TabIndex = 1;
            memberHistorySearchButton.Text = "View Member History";
            memberHistorySearchButton.UseVisualStyleBackColor = true;
            memberHistorySearchButton.Click += memberHistorySearchButton_Click;
            // 
            // transactionErrorLabel
            // 
            transactionErrorLabel.AutoSize = true;
            transactionErrorLabel.Location = new Point(3, 0);
            transactionErrorLabel.Name = "transactionErrorLabel";
            transactionErrorLabel.Size = new Size(0, 15);
            transactionErrorLabel.TabIndex = 7;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel5.Controls.Add(memberHistoryLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(memberHistoryListView, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 96);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(694, 301);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(clearMemberHistorySearchButton, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 243);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(688, 55);
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
            memberHistoryLabel.Size = new Size(688, 60);
            memberHistoryLabel.TabIndex = 1;
            memberHistoryLabel.Text = "Rental History";
            memberHistoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // memberHistoryListView
            // 
            memberHistoryListView.Dock = DockStyle.Fill;
            memberHistoryListView.Location = new Point(3, 63);
            memberHistoryListView.Name = "memberHistoryListView";
            memberHistoryListView.Size = new Size(688, 174);
            memberHistoryListView.TabIndex = 2;
            memberHistoryListView.UseCompatibleStateImageBehavior = false;
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
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Button memberHistorySearchButton;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button clearMemberHistorySearchButton;
        private Label memberHistoryLabel;
        private ListView memberHistoryListView;
        private Label transactionErrorLabel;
    }
}
