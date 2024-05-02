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
            updateQuantity = new Button();
            selectionMethodComboBox = new ComboBox();
            furnitureSearchLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            furnitureSearchButton = new Button();
            furnitureListViewLabel = new Label();
            cartLabel = new Label();
            errorLabel = new Label();
            selectionMethodLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // furnitureListView
            // 
            furnitureListView.CheckBoxes = true;
            furnitureListView.Dock = DockStyle.Fill;
            furnitureListView.Location = new Point(147, 105);
            furnitureListView.Name = "furnitureListView";
            furnitureListView.Size = new Size(550, 90);
            furnitureListView.TabIndex = 4;
            furnitureListView.UseCompatibleStateImageBehavior = false;
            furnitureListView.ItemChecked += furnitureListView_ItemChecked;
            // 
            // addFurnitureButton
            // 
            addFurnitureButton.Location = new Point(3, 4);
            addFurnitureButton.Margin = new Padding(3, 4, 3, 4);
            addFurnitureButton.Name = "addFurnitureButton";
            addFurnitureButton.Size = new Size(114, 29);
            addFurnitureButton.TabIndex = 6;
            addFurnitureButton.Text = "Add to Cart";
            addFurnitureButton.UseVisualStyleBackColor = true;
            addFurnitureButton.Click += addFurnitureButton_Click;
            // 
            // clearFurnitureButton
            // 
            clearFurnitureButton.Location = new Point(318, 4);
            clearFurnitureButton.Margin = new Padding(3, 4, 3, 4);
            clearFurnitureButton.Name = "clearFurnitureButton";
            clearFurnitureButton.Size = new Size(114, 28);
            clearFurnitureButton.TabIndex = 7;
            clearFurnitureButton.Text = "Clear Search";
            clearFurnitureButton.UseVisualStyleBackColor = true;
            clearFurnitureButton.Click += clearFurnitureButton_Click;
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(3, 489);
            checkoutButton.Margin = new Padding(3, 4, 3, 4);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(114, 28);
            checkoutButton.TabIndex = 8;
            checkoutButton.Text = "Checkout";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(423, 4);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(114, 28);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear Cart";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // cartListView
            // 
            cartListView.CheckBoxes = true;
            cartListView.Dock = DockStyle.Fill;
            cartListView.Location = new Point(147, 252);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(550, 90);
            cartListView.TabIndex = 10;
            cartListView.UseCompatibleStateImageBehavior = false;
            cartListView.ItemChecked += cartListView_ItemChecked;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.57143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.42857F));
            tableLayoutPanel1.Controls.Add(checkoutButton, 0, 5);
            tableLayoutPanel1.Controls.Add(cartListView, 1, 4);
            tableLayoutPanel1.Controls.Add(selectionMethodLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(furnitureListView, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 5);
            tableLayoutPanel1.Controls.Add(selectionMethodComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(furnitureSearchLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 1);
            tableLayoutPanel1.Controls.Add(furnitureListViewLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(cartLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(errorLabel, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.951808F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.951808F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.096386F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.951808F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.096386F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.951808F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            tableLayoutPanel2.Location = new Point(147, 201);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(550, 45);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(clearButton, 2, 0);
            tableLayoutPanel3.Controls.Add(removeItemButton, 1, 0);
            tableLayoutPanel3.Controls.Add(updateQuantity, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(147, 348);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(550, 49);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(213, 4);
            removeItemButton.Margin = new Padding(3, 4, 3, 4);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(114, 28);
            removeItemButton.TabIndex = 10;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += removeItemButton_Click;
            // 
            // updateQuantity
            // 
            updateQuantity.Location = new Point(3, 4);
            updateQuantity.Margin = new Padding(3, 4, 3, 4);
            updateQuantity.Name = "updateQuantity";
            updateQuantity.Size = new Size(135, 28);
            updateQuantity.TabIndex = 11;
            updateQuantity.Text = "Update Quantity";
            updateQuantity.UseVisualStyleBackColor = true;
            updateQuantity.Click += updateQuantity_Click;
            // 
            // selectionMethodComboBox
            // 
            selectionMethodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            selectionMethodComboBox.FormattingEnabled = true;
            selectionMethodComboBox.Items.AddRange(new object[] { "ID", "Category", "Style" });
            selectionMethodComboBox.Location = new Point(147, 3);
            selectionMethodComboBox.Name = "selectionMethodComboBox";
            selectionMethodComboBox.Size = new Size(121, 23);
            selectionMethodComboBox.TabIndex = 13;
            // 
            // furnitureSearchLabel
            // 
            furnitureSearchLabel.AutoSize = true;
            furnitureSearchLabel.Location = new Point(3, 51);
            furnitureSearchLabel.Name = "furnitureSearchLabel";
            furnitureSearchLabel.Size = new Size(122, 20);
            furnitureSearchLabel.TabIndex = 15;
            furnitureSearchLabel.Text = "Furniture Search: ";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(furnitureSearchButton, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(147, 54);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(550, 45);
            tableLayoutPanel5.TabIndex = 17;
            // 
            // furnitureSearchButton
            // 
            furnitureSearchButton.Location = new Point(3, 4);
            furnitureSearchButton.Margin = new Padding(3, 4, 3, 4);
            furnitureSearchButton.Name = "furnitureSearchButton";
            furnitureSearchButton.Size = new Size(151, 29);
            furnitureSearchButton.TabIndex = 1;
            furnitureSearchButton.Text = "Search Furinture";
            furnitureSearchButton.UseVisualStyleBackColor = true;
            furnitureSearchButton.Click += furnitureSearchButton_Click;
            // 
            // furnitureListViewLabel
            // 
            furnitureListViewLabel.AutoSize = true;
            furnitureListViewLabel.Location = new Point(3, 102);
            furnitureListViewLabel.Name = "furnitureListViewLabel";
            furnitureListViewLabel.Size = new Size(133, 40);
            furnitureListViewLabel.TabIndex = 21;
            furnitureListViewLabel.Text = "Select Furniture to Rent";
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(3, 249);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(36, 20);
            cartLabel.TabIndex = 22;
            cartLabel.Text = "Cart";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Location = new Point(3, 198);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 20);
            errorLabel.TabIndex = 23;
            // 
            // selectionMethodLabel
            // 
            selectionMethodLabel.AutoSize = true;
            selectionMethodLabel.Location = new Point(3, 0);
            selectionMethodLabel.Name = "selectionMethodLabel";
            selectionMethodLabel.Size = new Size(138, 15);
            selectionMethodLabel.TabIndex = 2;
            selectionMethodLabel.Text = "Furniture Search Method";
            // 
            // InventoryRental
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventoryRental";
            Size = new Size(800, 533);
            VisibleChanged += InventoryRental_VisibleChanged;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
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
        private Label furnitureSearchLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox furnitureSearchBox;
        private Button furnitureSearchButton;
        private Label furnitureListViewLabel;
        private Label cartLabel;
        private Button removeItemButton;
        private Button updateQuantity;
        private Label errorLabel;
        private Label selectionMethodLabel;
    }
}
