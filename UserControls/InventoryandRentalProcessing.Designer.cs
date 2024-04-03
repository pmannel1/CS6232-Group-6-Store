namespace CS6232_Group_6_Store.UserControls
{
    partial class InventoryandRentalProcessing
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
            furnituresListView = new ListView();
            searchButton = new Button();
            searchMethodBox = new ComboBox();
            label3 = new Label();
            furnitureBox = new TextBox();
            SuspendLayout();
            // 
            // furnituresListView
            // 
            furnituresListView.Location = new Point(8, 187);
            furnituresListView.Name = "furnituresListView";
            furnituresListView.Size = new Size(1093, 416);
            furnituresListView.TabIndex = 30;
            furnituresListView.UseCompatibleStateImageBehavior = false;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(168, 116);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(172, 36);
            searchButton.TabIndex = 29;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchMethodBox
            // 
            searchMethodBox.DropDownStyle = ComboBoxStyle.DropDownList;
            searchMethodBox.FormattingEnabled = true;
            searchMethodBox.Items.AddRange(new object[] { "Id", "Category", "Style" });
            searchMethodBox.Location = new Point(168, 25);
            searchMethodBox.Name = "searchMethodBox";
            searchMethodBox.Size = new Size(151, 28);
            searchMethodBox.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 26);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 26;
            label3.Text = "Select Search Method";
            // 
            // furnitureBox
            // 
            furnitureBox.Location = new Point(168, 71);
            furnitureBox.Name = "furnitureBox";
            furnitureBox.Size = new Size(300, 27);
            furnitureBox.TabIndex = 31;
            // 
            // InventoryandRentalProcessing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(furnitureBox);
            Controls.Add(furnituresListView);
            Controls.Add(searchButton);
            Controls.Add(searchMethodBox);
            Controls.Add(label3);
            Name = "InventoryandRentalProcessing";
            Size = new Size(1108, 629);
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView furnituresListView;
        private Button searchButton;
        private ComboBox searchMethodBox;
        private Label label3;
        private TextBox furnitureBox;
    }
}
