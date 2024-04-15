﻿namespace CS6232_Group_6_Store.UserControls
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
            tableLayoutPanel1 = new TableLayoutPanel();
            checkoutButton = new Button();
            memberSearchMethod = new Label();
            cartListView = new ListView();
            furnitureListView = new ListView();
            tableLayoutPanel2 = new TableLayoutPanel();
            addFurnitureButton = new Button();
            clearFurnitureButton = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            clearButton = new Button();
            removeItemButton = new Button();
            updateQuantity = new Button();
            memberSearchLabel = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            memberSearchBox = new TextBox();
            memberSearchButton = new Button();
            memberListViewLabel = new Label();
            memberListView = new ListView();
            cartLabel = new Label();
            memberSelectionComboBox = new ComboBox();
            furnitureListViewLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.57143F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.42857F));
            tableLayoutPanel1.Controls.Add(memberSearchMethod, 0, 0);
            tableLayoutPanel1.Controls.Add(memberSearchLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Controls.Add(memberListViewLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(memberListView, 1, 2);
            tableLayoutPanel1.Controls.Add(memberSelectionComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(furnitureListView, 1, 3);
            tableLayoutPanel1.Controls.Add(furnitureListViewLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 4);
            tableLayoutPanel1.Controls.Add(cartLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(cartListView, 1, 5);
            tableLayoutPanel1.Controls.Add(checkoutButton, 0, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.634539F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 26.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(700, 400);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // checkoutButton
            // 
            checkoutButton.Location = new Point(3, 368);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(111, 21);
            checkoutButton.TabIndex = 8;
            checkoutButton.Text = "Complete Return";
            checkoutButton.UseVisualStyleBackColor = true;
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
            // cartListView
            // 
            cartListView.CheckBoxes = true;
            cartListView.Dock = DockStyle.Fill;
            cartListView.Location = new Point(147, 259);
            cartListView.Name = "cartListView";
            cartListView.Size = new Size(550, 103);
            cartListView.TabIndex = 10;
            cartListView.UseCompatibleStateImageBehavior = false;
            // 
            // furnitureListView
            // 
            furnitureListView.CheckBoxes = true;
            furnitureListView.Dock = DockStyle.Fill;
            furnitureListView.Location = new Point(147, 121);
            furnitureListView.Name = "furnitureListView";
            furnitureListView.Size = new Size(550, 100);
            furnitureListView.TabIndex = 4;
            furnitureListView.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(addFurnitureButton, 0, 0);
            tableLayoutPanel2.Controls.Add(clearFurnitureButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(147, 227);
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
            // 
            // clearFurnitureButton
            // 
            clearFurnitureButton.Location = new Point(278, 3);
            clearFurnitureButton.Name = "clearFurnitureButton";
            clearFurnitureButton.Size = new Size(100, 20);
            clearFurnitureButton.TabIndex = 7;
            clearFurnitureButton.Text = "Clear Search";
            clearFurnitureButton.UseVisualStyleBackColor = true;
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
            tableLayoutPanel3.Location = new Point(147, 368);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(550, 29);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(369, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(100, 21);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear All Items";
            clearButton.UseVisualStyleBackColor = true;
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
            // updateQuantity
            // 
            updateQuantity.Location = new Point(3, 3);
            updateQuantity.Name = "updateQuantity";
            updateQuantity.Size = new Size(118, 21);
            updateQuantity.TabIndex = 11;
            updateQuantity.Text = "Update Quantity";
            updateQuantity.UseVisualStyleBackColor = true;
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
            memberListView.Size = new Size(550, 44);
            memberListView.TabIndex = 20;
            memberListView.UseCompatibleStateImageBehavior = false;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(3, 256);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(74, 15);
            cartLabel.TabIndex = 22;
            cartLabel.Text = "Return Items";
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
            // furnitureListViewLabel
            // 
            furnitureListViewLabel.AutoSize = true;
            furnitureListViewLabel.Location = new Point(3, 118);
            furnitureListViewLabel.Name = "furnitureListViewLabel";
            furnitureListViewLabel.Size = new Size(111, 15);
            furnitureListViewLabel.TabIndex = 21;
            furnitureListViewLabel.Text = "Select Items to Rent";
            // 
            // InventoryReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "InventoryReturn";
            Size = new Size(700, 400);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button checkoutButton;
        private Label memberSearchMethod;
        private ListView cartListView;
        private ListView furnitureListView;
        private TableLayoutPanel tableLayoutPanel2;
        private Button addFurnitureButton;
        private Button clearFurnitureButton;
        private TableLayoutPanel tableLayoutPanel3;
        private Button clearButton;
        private Button removeItemButton;
        private Button updateQuantity;
        private Label memberSearchLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox memberSearchBox;
        private Button memberSearchButton;
        private Label memberListViewLabel;
        private ListView memberListView;
        private Label cartLabel;
        private ComboBox memberSelectionComboBox;
        private Label furnitureListViewLabel;
    }
}
