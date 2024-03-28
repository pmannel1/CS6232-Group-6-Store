namespace CS6232_Group_6_Store.View
{
    partial class MemberRentalHistory
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
            memberRentalHistoryListView = new ListView();
            SuspendLayout();
            // 
            // memberRentalHistoryListView
            // 
            memberRentalHistoryListView.Dock = DockStyle.Fill;
            memberRentalHistoryListView.Location = new Point(0, 0);
            memberRentalHistoryListView.Margin = new Padding(3, 2, 3, 2);
            memberRentalHistoryListView.Name = "memberRentalHistoryListView";
            memberRentalHistoryListView.Size = new Size(800, 450);
            memberRentalHistoryListView.TabIndex = 4;
            memberRentalHistoryListView.UseCompatibleStateImageBehavior = false;
            // 
            // MemberRentalHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(memberRentalHistoryListView);
            Name = "MemberRentalHistory";
            Text = "MemberRentalHistory";
            ResumeLayout(false);
        }

        #endregion

        private ListView memberRentalHistoryListView;
    }
}