namespace CS6232_Group_6_Store.UserControls
{
    partial class AdminReport
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
            adminReportListView = new ListView();
            tableLayoutPanel2 = new TableLayoutPanel();
            startDateLabel = new Label();
            endDateLabel = new Label();
            adminReportButton = new Button();
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(adminReportListView, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(784, 420);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // adminReportListView
            // 
            adminReportListView.Dock = DockStyle.Fill;
            adminReportListView.Location = new Point(3, 213);
            adminReportListView.Name = "adminReportListView";
            adminReportListView.Size = new Size(778, 204);
            adminReportListView.TabIndex = 0;
            adminReportListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(startDateLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(endDateLabel, 0, 1);
            tableLayoutPanel2.Controls.Add(adminReportButton, 1, 2);
            tableLayoutPanel2.Controls.Add(startDatePicker, 1, 0);
            tableLayoutPanel2.Controls.Add(endDatePicker, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            tableLayoutPanel2.Size = new Size(778, 204);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Dock = DockStyle.Fill;
            startDateLabel.Location = new Point(3, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(383, 67);
            startDateLabel.TabIndex = 0;
            startDateLabel.Text = "Start Date";
            startDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Dock = DockStyle.Fill;
            endDateLabel.Location = new Point(3, 67);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(383, 67);
            endDateLabel.TabIndex = 1;
            endDateLabel.Text = "End Date";
            endDateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // adminReportButton
            // 
            adminReportButton.Dock = DockStyle.Fill;
            adminReportButton.Location = new Point(392, 137);
            adminReportButton.Name = "adminReportButton";
            adminReportButton.Size = new Size(383, 64);
            adminReportButton.TabIndex = 2;
            adminReportButton.Text = "Generate Report";
            adminReportButton.UseVisualStyleBackColor = true;
            // 
            // startDatePicker
            // 
            startDatePicker.Dock = DockStyle.Fill;
            startDatePicker.Location = new Point(392, 3);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(383, 27);
            startDatePicker.TabIndex = 3;
            // 
            // endDatePicker
            // 
            endDatePicker.Dock = DockStyle.Fill;
            endDatePicker.Location = new Point(392, 70);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(383, 27);
            endDatePicker.TabIndex = 4;
            // 
            // AdminReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AdminReport";
            Size = new Size(784, 420);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView adminReportListView;
        private TableLayoutPanel tableLayoutPanel2;
        private Label startDateLabel;
        private Label endDateLabel;
        private Button adminReportButton;
        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
    }
}
