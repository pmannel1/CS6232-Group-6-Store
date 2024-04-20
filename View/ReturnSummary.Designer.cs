namespace CS6232_Group_6_Store.View
{
    partial class ReturnSummary
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
            transactionSummarylistView = new ListView();
            closeButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(transactionSummarylistView, 0, 0);
            tableLayoutPanel1.Controls.Add(closeButton, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.62195F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.3780479F));
            tableLayoutPanel1.Size = new Size(880, 328);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // transactionSummarylistView
            // 
            transactionSummarylistView.Location = new Point(3, 3);
            transactionSummarylistView.Name = "transactionSummarylistView";
            transactionSummarylistView.Size = new Size(874, 263);
            transactionSummarylistView.TabIndex = 0;
            transactionSummarylistView.UseCompatibleStateImageBehavior = false;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(3, 274);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(113, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ReturnSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 352);
            Controls.Add(tableLayoutPanel1);
            Name = "ReturnSummary";
            Text = "ReturnSummary";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView transactionSummarylistView;
        private Button closeButton;
    }
}