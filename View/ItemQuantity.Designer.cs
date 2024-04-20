namespace CS6232_Group_6_Store.View
{
    partial class ItemQuantity
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
            nameLabel = new Label();
            descriptionLabel = new Label();
            quantityLabel = new Label();
            nameBox = new TextBox();
            descriptionBox = new TextBox();
            quantityComboBox = new ComboBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            confirmButton = new Button();
            cancelButton = new Button();
            dateOfReturnPicker = new DateTimePicker();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(descriptionLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(quantityLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(nameBox, 1, 0);
            tableLayoutPanel1.Controls.Add(descriptionBox, 1, 1);
            tableLayoutPanel1.Controls.Add(quantityComboBox, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 4);
            tableLayoutPanel1.Controls.Add(dateOfReturnPicker, 1, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.18328F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.65595F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.Size = new Size(505, 491);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(3, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(56, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name: ";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(3, 104);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(92, 20);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description: ";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(3, 208);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(72, 20);
            quantityLabel.TabIndex = 2;
            quantityLabel.Text = "Quantity: ";
            // 
            // nameBox
            // 
            nameBox.Dock = DockStyle.Fill;
            nameBox.Enabled = false;
            nameBox.Location = new Point(104, 4);
            nameBox.Margin = new Padding(3, 4, 3, 4);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(398, 27);
            nameBox.TabIndex = 4;
            // 
            // descriptionBox
            // 
            descriptionBox.Dock = DockStyle.Fill;
            descriptionBox.Enabled = false;
            descriptionBox.Location = new Point(104, 108);
            descriptionBox.Margin = new Padding(3, 4, 3, 4);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(398, 96);
            descriptionBox.TabIndex = 5;
            // 
            // quantityComboBox
            // 
            quantityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            quantityComboBox.FormattingEnabled = true;
            quantityComboBox.Location = new Point(104, 212);
            quantityComboBox.Margin = new Padding(3, 4, 3, 4);
            quantityComboBox.Name = "quantityComboBox";
            quantityComboBox.Size = new Size(138, 28);
            quantityComboBox.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(confirmButton, 0, 0);
            tableLayoutPanel3.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel3.Location = new Point(104, 418);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(229, 51);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(3, 4);
            confirmButton.Margin = new Padding(3, 4, 3, 4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(86, 31);
            confirmButton.TabIndex = 0;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(117, 4);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(86, 31);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // dateOfReturnPicker
            // 
            dateOfReturnPicker.Location = new Point(104, 266);
            dateOfReturnPicker.Margin = new Padding(3, 4, 3, 4);
            dateOfReturnPicker.Name = "dateOfReturnPicker";
            dateOfReturnPicker.Size = new Size(228, 27);
            dateOfReturnPicker.TabIndex = 8;
            dateOfReturnPicker.ValueChanged += dateOfReturnPicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 262);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 9;
            label1.Text = "Return Date:";
            label1.TextAlign = ContentAlignment.BottomCenter;
            label1.Click += label1_Click;
            // 
            // ItemQuantity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 491);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemQuantity";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label nameLabel;
        private Label descriptionLabel;
        private Label quantityLabel;
        private Button confirmButton;
        private Button cancelButton;
        private TextBox nameBox;
        private TextBox descriptionBox;
        private ComboBox quantityComboBox;
        private TableLayoutPanel tableLayoutPanel3;
        private DateTimePicker dateOfReturnPicker;
        private Label label1;
    }
}