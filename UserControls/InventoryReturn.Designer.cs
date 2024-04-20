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
            furnitureListViewQuantityLabel = new Label();
            returnItemNumberComboBox = new ComboBox();
            furnitureListViewLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            memberSelectButton = new Button();
            memberSelectLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            updateQuantityButton = new Button();
            removeItemButton = new Button();
            clearReturnButton = new Button();
            checkoutButton = new Button();
            returnListView = new ListView();
            cartLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            selectItemErrorLabel = new Label();
            clearFurnitureButton = new Button();
            addFurnitureButton = new Button();
            furnitureListView = new ListView();
            memberSelectionComboBox = new ComboBox();
            memberListView = new ListView();
            tableLayoutPanel4 = new TableLayoutPanel();
            errorMemberLabel = new Label();
            memberSearchButton = new Button();
            memberSearchBox = new TextBox();
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
            tableLayoutPanel6.Location = new Point(3, 168);
            tableLayoutPanel6.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel6.Size = new Size(158, 132);
            tableLayoutPanel6.TabIndex = 24;
            // 
            // furnitureListViewQuantityLabel
            // 
            furnitureListViewQuantityLabel.AutoSize = true;
            furnitureListViewQuantityLabel.Location = new Point(3, 49);
            furnitureListViewQuantityLabel.Name = "furnitureListViewQuantityLabel";
            furnitureListViewQuantityLabel.Size = new Size(112, 20);
            furnitureListViewQuantityLabel.TabIndex = 2;
            furnitureListViewQuantityLabel.Text = "Select Quantity:";
            // 
            // returnItemNumberComboBox
            // 
            returnItemNumberComboBox.FormattingEnabled = true;
            returnItemNumberComboBox.Location = new Point(3, 81);
            returnItemNumberComboBox.Margin = new Padding(3, 4, 3, 4);
            returnItemNumberComboBox.Name = "returnItemNumberComboBox";
            returnItemNumberComboBox.Size = new Size(138, 28);
            returnItemNumberComboBox.TabIndex = 1;
            // 
            // furnitureListViewLabel
            // 
            furnitureListViewLabel.AutoSize = true;
            furnitureListViewLabel.Location = new Point(3, 0);
            furnitureListViewLabel.Name = "furnitureListViewLabel";
            furnitureListViewLabel.Size = new Size(92, 20);
            furnitureListViewLabel.TabIndex = 0;
            furnitureListViewLabel.Text = "Select Items:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(memberSelectLabel, 0, 0);
            tableLayoutPanel5.Controls.Add(memberSelectButton, 0, 1);
            tableLayoutPanel5.Location = new Point(3, 96);
            tableLayoutPanel5.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel5.Size = new Size(158, 64);
            tableLayoutPanel5.TabIndex = 23;
            // 
            // memberSelectButton
            // 
            memberSelectButton.Location = new Point(3, 29);
            memberSelectButton.Margin = new Padding(3, 4, 3, 4);
            memberSelectButton.Name = "memberSelectButton";
            memberSelectButton.Size = new Size(86, 31);
            memberSelectButton.TabIndex = 1;
            memberSelectButton.Text = "Select";
            memberSelectButton.UseVisualStyleBackColor = true;
            memberSelectButton.Click += memberSelectButton_Click;
            // 
            // memberSelectLabel
            // 
            memberSelectLabel.AutoSize = true;
            memberSelectLabel.Location = new Point(3, 0);
            memberSelectLabel.Name = "memberSelectLabel";
            memberSelectLabel.Size = new Size(112, 20);
            memberSelectLabel.TabIndex = 0;
            memberSelectLabel.Text = "Select Member:";
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
            tableLayoutPanel3.Location = new Point(167, 491);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(630, 38);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // updateQuantityButton
            // 
            updateQuantityButton.Location = new Point(3, 4);
            updateQuantityButton.Margin = new Padding(3, 4, 3, 4);
            updateQuantityButton.Name = "updateQuantityButton";
            updateQuantityButton.Size = new Size(135, 28);
            updateQuantityButton.TabIndex = 11;
            updateQuantityButton.Text = "Remove 1 Quantity";
            updateQuantityButton.UseVisualStyleBackColor = true;
            updateQuantityButton.Click += updateQuantityButton_Click;
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
            // clearReturnButton
            // 
            clearReturnButton.Location = new Point(423, 4);
            clearReturnButton.Margin = new Padding(3, 4, 3, 4);
            clearReturnButton.Name = "clearReturnButton";
            clearReturnButton.Size = new Size(114, 28);
            clearReturnButton.TabIndex = 9;
            clearReturnButton.Text = "Clear All Items";
            clearReturnButton.UseVisualStyleBackColor = true;
            clearReturnButton.Click += clearReturnButton_Click;
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(3, 491);
            checkoutButton.Margin = new Padding(3, 4, 3, 4);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(127, 28);
            checkoutButton.TabIndex = 8;
            checkoutButton.Text = "Complete Return";
            checkoutButton.UseVisualStyleBackColor = true;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // returnListView
            // 
            returnListView.CheckBoxes = true;
            returnListView.Dock = DockStyle.Fill;
            returnListView.Location = new Point(167, 350);
            returnListView.Margin = new Padding(3, 4, 3, 4);
            returnListView.Name = "returnListView";
            returnListView.Size = new Size(630, 133);
            returnListView.TabIndex = 10;
            returnListView.UseCompatibleStateImageBehavior = false;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(3, 346);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(92, 20);
            cartLabel.TabIndex = 22;
            cartLabel.Text = "Return Items";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.53012F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.46988F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 249F));
            tableLayoutPanel2.Controls.Add(addFurnitureButton, 0, 0);
            tableLayoutPanel2.Controls.Add(clearFurnitureButton, 1, 0);
            tableLayoutPanel2.Controls.Add(selectItemErrorLabel, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(167, 308);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(630, 34);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // selectItemErrorLabel
            // 
            selectItemErrorLabel.AutoSize = true;
            selectItemErrorLabel.ForeColor = Color.Red;
            selectItemErrorLabel.Location = new Point(383, 0);
            selectItemErrorLabel.Name = "selectItemErrorLabel";
            selectItemErrorLabel.Size = new Size(0, 20);
            selectItemErrorLabel.TabIndex = 8;
            // 
            // clearFurnitureButton
            // 
            clearFurnitureButton.Location = new Point(222, 4);
            clearFurnitureButton.Margin = new Padding(3, 4, 3, 4);
            clearFurnitureButton.Name = "clearFurnitureButton";
            clearFurnitureButton.Size = new Size(114, 26);
            clearFurnitureButton.TabIndex = 7;
            clearFurnitureButton.Text = "Clear Search";
            clearFurnitureButton.UseVisualStyleBackColor = true;
            clearFurnitureButton.Click += clearFurnitureButton_Click;
            // 
            // addFurnitureButton
            // 
            addFurnitureButton.Location = new Point(3, 4);
            addFurnitureButton.Margin = new Padding(3, 4, 3, 4);
            addFurnitureButton.Name = "addFurnitureButton";
            addFurnitureButton.Size = new Size(114, 26);
            addFurnitureButton.TabIndex = 6;
            addFurnitureButton.Text = "Add to Return";
            addFurnitureButton.UseVisualStyleBackColor = true;
            addFurnitureButton.Click += addFurnitureButton_Click;
            // 
            // furnitureListView
            // 
            furnitureListView.CheckBoxes = true;
            furnitureListView.Dock = DockStyle.Fill;
            furnitureListView.Location = new Point(167, 168);
            furnitureListView.Margin = new Padding(3, 4, 3, 4);
            furnitureListView.Name = "furnitureListView";
            furnitureListView.Size = new Size(630, 132);
            furnitureListView.TabIndex = 4;
            furnitureListView.UseCompatibleStateImageBehavior = false;
            furnitureListView.ItemChecked += furnitureListView_ItemChecked;
            // 
            // memberSelectionComboBox
            // 
            memberSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            memberSelectionComboBox.FormattingEnabled = true;
            memberSelectionComboBox.Items.AddRange(new object[] { "Name", "ID", "Phone" });
            memberSelectionComboBox.Location = new Point(167, 4);
            memberSelectionComboBox.Margin = new Padding(3, 4, 3, 4);
            memberSelectionComboBox.Name = "memberSelectionComboBox";
            memberSelectionComboBox.Size = new Size(138, 28);
            memberSelectionComboBox.TabIndex = 1;
            // 
            // memberListView
            // 
            memberListView.CheckBoxes = true;
            memberListView.Dock = DockStyle.Fill;
            memberListView.Location = new Point(167, 96);
            memberListView.Margin = new Padding(3, 4, 3, 4);
            memberListView.Name = "memberListView";
            memberListView.Size = new Size(630, 64);
            memberListView.TabIndex = 20;
            memberListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.82927F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.17073F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 291F));
            tableLayoutPanel4.Controls.Add(memberSearchBox, 0, 0);
            tableLayoutPanel4.Controls.Add(memberSearchButton, 1, 0);
            tableLayoutPanel4.Controls.Add(errorMemberLabel, 2, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(167, 50);
            tableLayoutPanel4.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(630, 38);
            tableLayoutPanel4.TabIndex = 16;
            // 
            // errorMemberLabel
            // 
            errorMemberLabel.AutoSize = true;
            errorMemberLabel.ForeColor = Color.Red;
            errorMemberLabel.Location = new Point(341, 0);
            errorMemberLabel.Name = "errorMemberLabel";
            errorMemberLabel.Size = new Size(0, 20);
            errorMemberLabel.TabIndex = 2;
            // 
            // memberSearchButton
            // 
            memberSearchButton.Location = new Point(229, 4);
            memberSearchButton.Margin = new Padding(3, 4, 3, 4);
            memberSearchButton.Name = "memberSearchButton";
            memberSearchButton.Size = new Size(86, 29);
            memberSearchButton.TabIndex = 1;
            memberSearchButton.Text = "Search";
            memberSearchButton.UseVisualStyleBackColor = true;
            memberSearchButton.Click += memberSearchButton_Click;
            // 
            // memberSearchBox
            // 
            memberSearchBox.Location = new Point(3, 4);
            memberSearchBox.Margin = new Padding(3, 4, 3, 4);
            memberSearchBox.Name = "memberSearchBox";
            memberSearchBox.Size = new Size(166, 27);
            memberSearchBox.TabIndex = 0;
            // 
            // memberSearchLabel
            // 
            memberSearchLabel.AutoSize = true;
            memberSearchLabel.Location = new Point(3, 46);
            memberSearchLabel.Name = "memberSearchLabel";
            memberSearchLabel.Size = new Size(120, 20);
            memberSearchLabel.TabIndex = 14;
            memberSearchLabel.Text = "Member Search: ";
            // 
            // memberSearchMethod
            // 
            memberSearchMethod.AutoSize = true;
            memberSearchMethod.Location = new Point(3, 0);
            memberSearchMethod.Name = "memberSearchMethod";
            memberSearchMethod.Size = new Size(117, 40);
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
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.Size = new Size(800, 533);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // InventoryReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InventoryReturn";
            Size = new Size(800, 533);
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
