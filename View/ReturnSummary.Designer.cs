﻿namespace CS6232_Group_6_Store.View
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
            tableLayoutPanel2 = new TableLayoutPanel();
            closeButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            fineCreditLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(transactionSummarylistView, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.21805F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.7819548F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.Size = new Size(926, 403);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // transactionSummarylistView
            // 
            transactionSummarylistView.Dock = DockStyle.Fill;
            transactionSummarylistView.Location = new Point(3, 3);
            transactionSummarylistView.Name = "transactionSummarylistView";
            transactionSummarylistView.Size = new Size(920, 304);
            transactionSummarylistView.TabIndex = 0;
            transactionSummarylistView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 526F));
            tableLayoutPanel2.Controls.Add(closeButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 359);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(920, 40);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(403, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(113, 32);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(fineCreditLabel, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 314);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(920, 37);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // fineCreditLabel
            // 
            fineCreditLabel.AutoSize = true;
            fineCreditLabel.Dock = DockStyle.Fill;
            fineCreditLabel.Location = new Point(3, 0);
            fineCreditLabel.Name = "fineCreditLabel";
            fineCreditLabel.Size = new Size(914, 37);
            fineCreditLabel.TabIndex = 0;
            fineCreditLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // ReturnSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 403);
            Controls.Add(tableLayoutPanel1);
            Name = "ReturnSummary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnSummary";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ListView transactionSummarylistView;
        private Button closeButton;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label fineCreditLabel;
    }
}