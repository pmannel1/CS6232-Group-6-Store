namespace CS6232_Group_6_Store.View
{
    partial class RentalSummary
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
            tableLayoutPanel2 = new TableLayoutPanel();
            totalCostLabel = new Label();
            totalCostBox = new TextBox();
            rentalSummaryList = new ListView();
            tableLayoutPanel3 = new TableLayoutPanel();
            confirmButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(rentalSummaryList, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(416, 221);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Controls.Add(totalCostLabel, 0, 0);
            tableLayoutPanel2.Controls.Add(totalCostBox, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 135);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(410, 38);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Dock = DockStyle.Fill;
            totalCostLabel.Location = new Point(3, 0);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(76, 38);
            totalCostLabel.TabIndex = 0;
            totalCostLabel.Text = "Total Cost: ";
            totalCostLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // totalCostBox
            // 
            totalCostBox.Dock = DockStyle.Fill;
            totalCostBox.Enabled = false;
            totalCostBox.Location = new Point(85, 3);
            totalCostBox.Name = "totalCostBox";
            totalCostBox.Size = new Size(322, 23);
            totalCostBox.TabIndex = 1;
            totalCostBox.TextAlign = HorizontalAlignment.Center;
            // 
            // rentalSummaryList
            // 
            rentalSummaryList.Dock = DockStyle.Fill;
            rentalSummaryList.Location = new Point(3, 3);
            rentalSummaryList.Name = "rentalSummaryList";
            rentalSummaryList.Size = new Size(410, 126);
            rentalSummaryList.TabIndex = 1;
            rentalSummaryList.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(confirmButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 179);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(410, 39);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(3, 3);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // RentalSummary
            // 
            AcceptButton = confirmButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 221);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RentalSummary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RentalSummary";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ListView rentalSummaryList;
        private Label totalCostLabel;
        private TextBox totalCostBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button confirmButton;
    }
}