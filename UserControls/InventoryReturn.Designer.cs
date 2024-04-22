namespace CS6232_Group_6_Store.UserControls
{
    partial class InventoryReturn
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
            tableLayoutPanel6 = new TableLayoutPanel();
            furnitureListViewLabel = new Label();
            returnItemNumberComboBox = new ComboBox();
            furnitureListViewQuantityLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            memberSelectLabel = new Label();
            memberSelectButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            clearReturnButton = new Button();
            removeItemButton = new Button();
            updateQuantityButton = new Button();
            checkoutButton = new Button();
            returnListView = new ListView();
            cartLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            addFurnitureButton = new Button();
            clearFurnitureButton = new Button();
            selectItemErrorLabel = new Label();
            furnitureListView = new ListView();
            memberSelectionComboBox = new ComboBox();
            memberListView = new ListView();
            tableLayoutPanel4 = new TableLayoutPanel();
            memberSearchBox = new TextBox();
            memberSearchButton = new Button();
            errorMemberLabel = new Label();
            memberSearchLabel = new Label();
            memberSearchMethod = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(furnitureListViewLabel, 0, 0);
            tableLayoutPanel6.Controls.Add(returnItemNumberComboBox, 0, 2);
            tableLayoutPanel6.Controls.Add(furnitureListViewQuantityLabel, 0, 1);
            tableLayoutPanel6.Location = new Point(3, 125);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel6.Size = new Size(138, 99);
            tableLayoutPanel6.TabIndex = 24;
            // 
            // furnitureListViewLabel
            // 
            furnitureListViewLabel.AutoSize = true;
            furnitureListViewLabel.Location = new Point(3, 0);
            furnitureListViewLabel.Name = "furnitureListViewLabel";
            furnitureListViewLabel.Size = new Size(73, 15);
            furnitureListViewLabel.TabIndex = 0;
            furnitureListViewLabel.Text = "Select Items:";
            // 
            // returnItemNumberComboBox
            // 
            returnItemNumberComboBox.FormattingEnabled = true;
            returnItemNumberComboBox.Location = new Point(3, 61);
            returnItemNumberComboBox.Name = "returnItemNumberComboBox";
            returnItemNumberComboBox.Size = new Size(121, 23);
            returnItemNumberComboBox.TabIndex = 1;
            // 
            // furnitureListViewQuantityLabel
            // 
            furnitureListViewQuantityLabel.AutoSize = true;
            furnitureListViewQuantityLabel.Location = new Point(3, 37);
            furnitureListViewQuantityLabel.Name = "furnitureListViewQuantityLabel";
            furnitureListViewQuantityLabel.Size = new Size(90, 15);
            furnitureListViewQuantityLabel.TabIndex = 2;
            furnitureListViewQuantityLabel.Text = "Select Quantity:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(memberSelectLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(memberSelectButton, 0, 1);
            tableLayoutPanel5.Location = new Point(3, 71);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.Size = new Size(138, 48);
            tableLayoutPanel5.TabIndex = 23;
            // 
            // memberSelectLabel
            // 
            memberSelectLabel.AutoSize = true;
            memberSelectLabel.Location = new Point(3, 0);
            memberSelectLabel.Name = "memberSelectLabel";
            memberSelectLabel.Size = new Size(89, 15);
            memberSelectLabel.TabIndex = 0;
            memberSelectLabel.Text = "Select Member:";
            // 
            // memberSelectButton
            // 
            memberSelectButton.Location = new Point(3, 22);
            memberSelectButton.Name = "memberSelectButton";
            memberSelectButton.Size = new Size(75, 23);
            memberSelectButton.TabIndex = 1;
            memberSelectButton.Text = "Select";
            memberSelectButton.UseVisualStyleBackColor = true;
            memberSelectButton.Click += memberSelectButton_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(clearReturnButton, 2, 0);
            tableLayoutPanel3.Controls.Add(removeItemButton, 1, 0);
            tableLayoutPanel3.Controls.Add(updateQuantityButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(147, 368);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(550, 29);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // clearReturnButton
            // 
            clearReturnButton.Location = new Point(369, 3);
            clearReturnButton.Name = "clearReturnButton";
            clearReturnButton.Size = new Size(100, 21);
            clearReturnButton.TabIndex = 9;
            clearReturnButton.Text = "Clear All Items";
            clearReturnButton.UseVisualStyleBackColor = true;
            clearReturnButton.Click += clearReturnButton_Click;
            // 
            // removeItemButton
            // 
            removeItemButton.Location = new Point(186, 3);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Size = new Size(100, 21);
            removeItemButton.TabIndex = 10;
            removeItemButton.Text = "Remove Item";
            removeItemButton.UseVisualStyleBackColor = true;
            removeItemButton.Click += removeItemButton_Click;
            // 
            // updateQuantityButton
            // 
            updateQuantityButton.Location = new Point(3, 3);
            updateQuantityButton.Name = "updateQuantityButton";
            updateQuantityButton.Size = new Size(118, 21);
            updateQuantityButton.TabIndex = 11;
            updateQuantityButton.Text = "Remove 1 Quantity";
            updateQuantityButton.UseVisualStyleBackColor = true;
            updateQuantityButton.Click += updateQuantityButton_Click;
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(3, 368);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(111, 21);
            checkoutButton.TabIndex = 8;
            checkoutButton.Text = "Complete Return";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // returnListView
            // 
            returnListView.CheckBoxes = true;
            returnListView.Dock = DockStyle.Fill;
            returnListView.Location = new Point(147, 262);
            returnListView.Name = "returnListView";
            returnListView.Size = new Size(550, 100);
            returnListView.TabIndex = 10;
            returnListView.UseCompatibleStateImageBehavior = false;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(3, 259);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(74, 15);
            cartLabel.TabIndex = 22;
            cartLabel.Text = "Return Items";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.53012F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.46988F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 219F));
            tableLayoutPanel2.Controls.Add(addFurnitureButton, 0, 0);
            tableLayoutPanel2.Controls.Add(clearFurnitureButton, 1, 0);
            tableLayoutPanel2.Controls.Add(selectItemErrorLabel, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(147, 230);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(550, 26);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // addFurnitureButton
            // 
            addFurnitureButton.Location = new Point(3, 3);
            addFurnitureButton.Name = "addFurnitureButton";
            addFurnitureButton.Size = new Size(100, 20);
            addFurnitureButton.TabIndex = 6;
            addFurnitureButton.Text = "Add to Return";
            addFurnitureButton.UseVisualStyleBackColor = true;
            addFurnitureButton.Click += addFurnitureButton_Click;
            // 
            // clearFurnitureButton
            // 
            clearFurnitureButton.Location = new Point(193, 3);
            clearFurnitureButton.Name = "clearFurnitureButton";
            clearFurnitureButton.Size = new Size(100, 20);
            clearFurnitureButton.TabIndex = 7;
            clearFurnitureButton.Text = "Clear Search";
            clearFurnitureButton.UseVisualStyleBackColor = true;
            clearFurnitureButton.Click += clearFurnitureButton_Click;
            // 
            // selectItemErrorLabel
            // 
            selectItemErrorLabel.AutoSize = true;
            selectItemErrorLabel.ForeColor = Color.Red;
            selectItemErrorLabel.Location = new Point(333, 0);
            selectItemErrorLabel.Name = "selectItemErrorLabel";
            selectItemErrorLabel.Size = new Size(0, 15);
            selectItemErrorLabel.TabIndex = 8;
            // 
            // furnitureListView
            // 
            furnitureListView.CheckBoxes = true;
            furnitureListView.Dock = DockStyle.Fill;
            furnitureListView.Location = new Point(147, 125);
            furnitureListView.Name = "furnitureListView";
            furnitureListView.Size = new Size(550, 99);
            furnitureListView.TabIndex = 4;
            furnitureListView.UseCompatibleStateImageBehavior = false;
            furnitureListView.ItemChecked += furnitureListView_ItemChecked;
            // 
            // memberSelectionComboBox
            // 
            memberSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            memberSelectionComboBox.FormattingEnabled = true;
            memberSelectionComboBox.Items.AddRange(new object[] { "Name", "ID", "Phone" });
            memberSelectionComboBox.Location = new Point(147, 3);
            memberSelectionComboBox.Name = "memberSelectionComboBox";
            memberSelectionComboBox.Size = new Size(121, 23);
            memberSelectionComboBox.TabIndex = 1;
            // 
            // memberListView
            // 
            memberListView.CheckBoxes = true;
            memberListView.Dock = DockStyle.Fill;
            memberListView.Location = new Point(147, 71);
            memberListView.Name = "memberListView";
            memberListView.Size = new Size(550, 48);
            memberListView.TabIndex = 20;
            memberListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.82927F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.17073F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 256F));
            tableLayoutPanel4.Controls.Add(memberSearchBox, 0, 0);
            tableLayoutPanel4.Controls.Add(memberSearchButton, 1, 0);
            tableLayoutPanel4.Controls.Add(errorMemberLabel, 2, 0);
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
            memberSearchBox.Size = new Size(146, 23);
            memberSearchBox.TabIndex = 0;
            // 
            // memberSearchButton
            // 
            memberSearchButton.Location = new Point(199, 3);
            memberSearchButton.Name = "memberSearchButton";
            memberSearchButton.Size = new Size(75, 22);
            memberSearchButton.TabIndex = 1;
            memberSearchButton.Text = "Search";
            memberSearchButton.UseVisualStyleBackColor = true;
            memberSearchButton.Click += memberSearchButton_Click;
            // 
            // errorMemberLabel
            // 
            errorMemberLabel.AutoSize = true;
            errorMemberLabel.ForeColor = Color.Red;
            errorMemberLabel.Location = new Point(296, 0);
            errorMemberLabel.Name = "errorMemberLabel";
            errorMemberLabel.Size = new Size(0, 15);
            errorMemberLabel.TabIndex = 2;
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
            // memberSearchMethod
            // 
            memberSearchMethod.AutoSize = true;
            memberSearchMethod.Location = new Point(3, 0);
            memberSearchMethod.Name = "memberSearchMethod";
            memberSearchMethod.Size = new Size(138, 15);
            memberSearchMethod.TabIndex = 0;
            memberSearchMethod.Text = "Member Search Method: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.57143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.42857F));
            tableLayoutPanel1.Controls.Add(memberSearchMethod, 0, 0);
            tableLayoutPanel1.Controls.Add(memberSearchLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(memberListView, 1, 2);
            tableLayoutPanel1.Controls.Add(memberSelectionComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(furnitureListView, 1, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutPanel1.Controls.Add(cartLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(returnListView, 1, 5);
            tableLayoutPanel1.Controls.Add(checkoutButton, 0, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(700, 400);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // InventoryReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "InventoryReturn";
            Size = new Size(700, 400);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button selectFurnitureItemButton;
        private TableLayoutPanel tableLayoutPanel6;
        private Label furnitureListViewLabel;
        private ComboBox returnItemNumberComboBox;
        private Label furnitureListViewQuantityLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label memberSelectLabel;
        private Button memberSelectButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button clearReturnButton;
        private Button removeItemButton;
        private Button updateQuantityButton;
        private Button checkoutButton;
        private ListView returnListView;
        private Label cartLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Button addFurnitureButton;
        private Button clearFurnitureButton;
        private Label selectItemErrorLabel;
        private ListView furnitureListView;
        private ComboBox memberSelectionComboBox;
        private ListView memberListView;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox memberSearchBox;
        private Button memberSearchButton;
        private Label errorMemberLabel;
        private Label memberSearchLabel;
        private Label memberSearchMethod;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
