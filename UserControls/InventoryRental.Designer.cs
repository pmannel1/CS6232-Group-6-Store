namespace CS6232_Group_6_Store.UserControls
{
    partial class InventoryRental
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
            memberSearchMethod = new Label();
            memberSelectionComboBox = new ComboBox();
            selectionMethodLabel = new Label();
            furnitureListView = new ListView();
            addFurnitureButton = new Button();
            clearFurnitureButton = new Button();
            checkoutButton = new Button();
            clearButton = new Button();
            cartListView = new ListView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            removeItemButton = new Button();
            selectionMethodComboBox = new ComboBox();
            memberSearchLabel = new Label();
            furnitureSearchLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            memberSearchBox = new TextBox();
            memberSearchButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            furnitureSearchBox = new TextBox();
            furnitureSearchButton = new Button();
            memberListViewLabel = new Label();
            memberListView = new ListView();
            furnitureListViewLabel = new Label();
            cartLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // memberSearchMethod
            // 
            memberSearchMethod.AutoSize = true;
            memberSearchMethod.Location = new Point(3, 0);
            memberSearchMethod.Name = "memberSearchMethod";
            memberSearchMethod.Size = new Size(138, 15);
            memberSearchMethod.TabIndex = 0;
            memberSearchMethod.Text = "Member Search Method: ";
            // 
            // memberSelectionComboBox
            // 
            memberSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            memberSelectionComboBox.FormattingEnabled = true;
            memberSelectionComboBox.Items.AddRange(new object[] { "Name", "ID" });
            memberSelectionComboBox.Location = new Point(147, 3);
            memberSelectionComboBox.Name = "memberSelectionComboBox";
            memberSelectionComboBox.Size = new Size(121, 23);
            memberSelectionComboBox.TabIndex = 1;
            // 
            // selectionMethodLabel
            // 
            selectionMethodLabel.AutoSize = true;
            selectionMethodLabel.Location = new Point(3, 132);
            selectionMethodLabel.Name = "selectionMethodLabel";
            selectionMethodLabel.Size = new Size(138, 15);
            selectionMethodLabel.TabIndex = 2;
            selectionMethodLabel.Text = "Furniture Search Method";
            // 
            // furnitureListView
            // 
            furnitureListView.CheckBoxes = true;
            furnitureListView.Dock = DockStyle.Fill;
            furnitureListView.Location = new Point(147, 203);
            furnitureListView.Name = "furnitureListView";
            furnitureListView.Size = new Size(550, 58);
            furnitureListView.TabIndex = 4;
            furnitureListView.UseCompatibleStateImageBehavior = false;
            furnitureListView.ItemChecked += furnitureListView_ItemChecked;
            // 
            // addFurnitureButton
            // 
            addFurnitureButton.Location = new Point(3, 3);
            addFurnitureButton.Name = "addFurnitureButton";
            addFurnitureButton.Size = new Size(100, 22);
            addFurnitureButton.TabIndex = 6;
            addFurnitureButton.Text = "Add to Cart";
            addFurnitureButton.UseVisualStyleBackColor = true;
            addFurnitureButton.Click += addFurnitureButton_Click;
            // 
            // clearFurnitureButton
            // 
            clearFurnitureButton.Location = new Point(278, 3);
            clearFurnitureButton.Name = "clearFurnitureButton";
            clearFurnitureButton.Size = new Size(100, 21);
            clearFurnitureButton.TabIndex = 7;
            clearFurnitureButton.Text = "Clear Search";
            clearFurnitureButton.UseVisualStyleBackColor = true;
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(3, 3);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(100, 21);
            checkoutButton.TabIndex = 8;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(369, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 21);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear Cart";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // cartListView
            // 
            cartListView.CheckBoxes = true;
            cartListView.Dock = DockStyle.Fill;
            cartListView.Location = new Point(147, 301);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(550, 58);
            cartListView.TabIndex = 10;
            cartListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.57143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.42857F));
            tableLayoutPanel1.Controls.Add(memberSearchMethod, 0, 0);
            tableLayoutPanel1.Controls.Add(cartListView, 1, 7);
            tableLayoutPanel1.Controls.Add(selectionMethodLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(memberSelectionComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(furnitureListView, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 8);
            tableLayoutPanel1.Controls.Add(selectionMethodComboBox, 1, 3);
            tableLayoutPanel1.Controls.Add(memberSearchLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(furnitureSearchLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 4);
            tableLayoutPanel1.Controls.Add(memberListViewLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(memberListView, 1, 2);
            tableLayoutPanel1.Controls.Add(furnitureListViewLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(cartLabel, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0642567F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0642567F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0642567F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.Size = new Size(700, 400);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(addFurnitureButton, 0, 0);
            tableLayoutPanel2.Controls.Add(clearFurnitureButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(147, 267);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(550, 28);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(checkoutButton, 0, 0);
            tableLayoutPanel3.Controls.Add(clearButton, 2, 0);
            tableLayoutPanel3.Controls.Add(removeItemButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(147, 365);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(550, 32);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(186, 3);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(100, 21);
            removeItemButton.TabIndex = 10;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            // 
            // selectionMethodComboBox
            // 
            selectionMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectionMethodComboBox.FormattingEnabled = true;
            selectionMethodComboBox.Items.AddRange(new object[] { "ID", "Category", "Style" });
            selectionMethodComboBox.Location = new Point(147, 135);
            selectionMethodComboBox.Name = "selectionMethodComboBox";
            selectionMethodComboBox.Size = new Size(121, 23);
            selectionMethodComboBox.TabIndex = 13;
            // 
            // memberSearchLabel
            // 
            memberSearchLabel.AutoSize = true;
            memberSearchLabel.Location = new Point(3, 34);
            memberSearchLabel.Name = "memberSearchLabel";
            memberSearchLabel.Size = new Size(96, 15);
            memberSearchLabel.TabIndex = 14;
            memberSearchLabel.Text = "Member Search: ";
            // 
            // furnitureSearchLabel
            // 
            furnitureSearchLabel.AutoSize = true;
            furnitureSearchLabel.Location = new Point(3, 166);
            furnitureSearchLabel.Name = "furnitureSearchLabel";
            furnitureSearchLabel.Size = new Size(99, 15);
            furnitureSearchLabel.TabIndex = 15;
            furnitureSearchLabel.Text = "Furniture Search: ";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(memberSearchBox, 0, 0);
            tableLayoutPanel4.Controls.Add(memberSearchButton, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(147, 37);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(550, 28);
            tableLayoutPanel4.TabIndex = 16;
            // 
            // memberSearchBox
            // 
            memberSearchBox.Location = new Point(3, 3);
            memberSearchBox.Name = "memberSearchBox";
            memberSearchBox.Size = new Size(100, 23);
            memberSearchBox.TabIndex = 0;
            // 
            // memberSearchButton
            // 
            memberSearchButton.Location = new Point(278, 3);
            memberSearchButton.Name = "memberSearchButton";
            memberSearchButton.Size = new Size(75, 22);
            memberSearchButton.TabIndex = 1;
            memberSearchButton.Text = "Search";
            memberSearchButton.UseVisualStyleBackColor = true;
            memberSearchButton.Click += memberSearchButton_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(furnitureSearchBox, 0, 0);
            tableLayoutPanel5.Controls.Add(furnitureSearchButton, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(147, 169);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(550, 28);
            tableLayoutPanel5.TabIndex = 17;
            // 
            // furnitureSearchBox
            // 
            furnitureSearchBox.Location = new Point(3, 3);
            furnitureSearchBox.Name = "furnitureSearchBox";
            furnitureSearchBox.Size = new Size(100, 23);
            furnitureSearchBox.TabIndex = 0;
            // 
            // furnitureSearchButton
            // 
            furnitureSearchButton.Location = new Point(278, 3);
            furnitureSearchButton.Name = "furnitureSearchButton";
            furnitureSearchButton.Size = new Size(75, 22);
            furnitureSearchButton.TabIndex = 1;
            furnitureSearchButton.Text = "Search";
            furnitureSearchButton.UseVisualStyleBackColor = true;
            furnitureSearchButton.Click += furnitureSearchButton_Click;
            // 
            // memberListViewLabel
            // 
            memberListViewLabel.AutoSize = true;
            memberListViewLabel.Location = new Point(3, 68);
            memberListViewLabel.Name = "memberListViewLabel";
            memberListViewLabel.Size = new Size(92, 15);
            memberListViewLabel.TabIndex = 19;
            memberListViewLabel.Text = "Select Member: ";
            // 
            // memberListView
            // 
            memberListView.Dock = DockStyle.Fill;
            memberListView.Location = new Point(147, 71);
            memberListView.Name = "memberListView";
            memberListView.Size = new Size(550, 58);
            memberListView.TabIndex = 20;
            memberListView.UseCompatibleStateImageBehavior = false;
            memberListView.ItemChecked += memberListView_ItemChecked;
            // 
            // furnitureListViewLabel
            // 
            furnitureListViewLabel.AutoSize = true;
            furnitureListViewLabel.Location = new Point(3, 200);
            furnitureListViewLabel.Name = "furnitureListViewLabel";
            furnitureListViewLabel.Size = new Size(130, 15);
            furnitureListViewLabel.TabIndex = 21;
            furnitureListViewLabel.Text = "Select Furniture to Rent";
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(3, 298);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(29, 15);
            cartLabel.TabIndex = 22;
            cartLabel.Text = "Cart";
            // 
            // InventoryRental
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "InventoryRental";
            Size = new Size(700, 400);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label memberSearchMethod;
        private ComboBox memberSelectionComboBox;
        private Label selectionMethodLabel;
        private ListView furnitureListView;
        private Button addFurnitureButton;
        private Button clearFurnitureButton;
        private Button checkoutButton;
        private Button clearButton;
        private ListView cartListView;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox selectionMethodComboBox;
        private Label memberSearchLabel;
        private Label furnitureSearchLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox memberSearchBox;
        private Button memberSearchButton;
        private TextBox furnitureSearchBox;
        private Button furnitureSearchButton;
        private Label memberListViewLabel;
        private ListView memberListView;
        private Label furnitureListViewLabel;
        private Label cartLabel;
        private Button removeItemButton;
    }
}
