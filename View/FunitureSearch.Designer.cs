namespace CS6232_Group_6_Store.View
{
    partial class FunitureSearch
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
            selectionMethodComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            errorLabel = new Label();
            clearFurnitureButton = new Button();
            furnitureSearchButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            cancelButton = new Button();
            addButton = new Button();
            furnitureSearchComboBox = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            furnitureListView = new ListView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.23077F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.76923F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Controls.Add(selectionMethodComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(errorLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(clearFurnitureButton, 2, 2);
            tableLayoutPanel1.Controls.Add(furnitureSearchButton, 2, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 3);
            tableLayoutPanel1.Controls.Add(furnitureSearchComboBox, 1, 1);
            tableLayoutPanel1.Location = new Point(144, 22);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.04348F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.95652F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.Size = new Size(570, 153);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // selectionMethodComboBox
            // 
            selectionMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectionMethodComboBox.FormattingEnabled = true;
            selectionMethodComboBox.Items.AddRange(new object[] { "ID", "Category", "Style" });
            selectionMethodComboBox.Location = new Point(213, 3);
            selectionMethodComboBox.Name = "selectionMethodComboBox";
            selectionMethodComboBox.Size = new Size(176, 23);
            selectionMethodComboBox.TabIndex = 15;
            selectionMethodComboBox.SelectedIndexChanged += selectionMethodComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 25;
            label1.Text = "Select Search Method";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 26;
            label2.Text = "Insert searching value";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(3, 69);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 18;
            // 
            // clearFurnitureButton
            // 
            clearFurnitureButton.Location = new Point(429, 72);
            clearFurnitureButton.Name = "clearFurnitureButton";
            clearFurnitureButton.Size = new Size(100, 21);
            clearFurnitureButton.TabIndex = 21;
            clearFurnitureButton.Text = "Clear Search";
            clearFurnitureButton.UseVisualStyleBackColor = true;
            clearFurnitureButton.Click += clearFurnitureButton_Click;
            // 
            // furnitureSearchButton
            // 
            furnitureSearchButton.Location = new Point(429, 47);
            furnitureSearchButton.Name = "furnitureSearchButton";
            furnitureSearchButton.Size = new Size(101, 19);
            furnitureSearchButton.TabIndex = 20;
            furnitureSearchButton.Text = "Search";
            furnitureSearchButton.UseVisualStyleBackColor = true;
            furnitureSearchButton.Click += furnitureSearchButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel3.Controls.Add(addButton, 0, 0);
            tableLayoutPanel3.Location = new Point(213, 109);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(210, 41);
            tableLayoutPanel3.TabIndex = 27;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(108, 2);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(99, 22);
            cancelButton.TabIndex = 23;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 2);
            addButton.Margin = new Padding(3, 2, 3, 2);
            addButton.Name = "addButton";
            addButton.Size = new Size(82, 22);
            addButton.TabIndex = 22;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // furnitureSearchComboBox
            // 
            furnitureSearchComboBox.FormattingEnabled = true;
            furnitureSearchComboBox.Location = new Point(213, 46);
            furnitureSearchComboBox.Margin = new Padding(3, 2, 3, 2);
            furnitureSearchComboBox.Name = "furnitureSearchComboBox";
            furnitureSearchComboBox.Size = new Size(210, 23);
            furnitureSearchComboBox.TabIndex = 28;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(furnitureListView, 0, 0);
            tableLayoutPanel2.Location = new Point(28, 180);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(792, 125);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // furnitureListView
            // 
            furnitureListView.CheckBoxes = true;
            furnitureListView.Dock = DockStyle.Fill;
            furnitureListView.Location = new Point(3, 3);
            furnitureListView.Name = "furnitureListView";
            furnitureListView.Size = new Size(786, 119);
            furnitureListView.TabIndex = 6;
            furnitureListView.UseCompatibleStateImageBehavior = false;
            // 
            // FunitureSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 338);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FunitureSearch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FunitureSearch";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox selectionMethodComboBox;
        private Label errorLabel;
        private Button furnitureSearchButton;
        private Button clearFurnitureButton;
        private Button addButton;
        private Button cancelButton;
        private TableLayoutPanel tableLayoutPanel2;
        private ListView furnitureListView;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox furnitureSearchComboBox;
    }
}