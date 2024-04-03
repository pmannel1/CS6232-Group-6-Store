namespace CS6232_Group_6_Store.View
{
    partial class LoginForm
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
            idLabel = new Label();
            passwordLabel = new Label();
            idTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            errorLabel = new Label();
            clearButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(80, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Employee ID: ";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(3, 64);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(80, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password: ";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(89, 3);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(342, 23);
            idTextBox.TabIndex = 0;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(89, 67);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(342, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Dock = DockStyle.Fill;
            loginButton.Location = new Point(3, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(165, 27);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(153, 103);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 5;
            // 
            // clearButton
            // 
            clearButton.Dock = DockStyle.Fill;
            clearButton.Location = new Point(174, 2);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(165, 29);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Controls.Add(idLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(passwordLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(idTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.64596F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.6024837F));
            tableLayoutPanel1.Size = new Size(434, 161);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(clearButton, 1, 0);
            tableLayoutPanel2.Controls.Add(loginButton, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(89, 125);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(342, 33);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = clearButton;
            ClientSize = new Size(434, 161);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(errorLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label passwordLabel;
        private TextBox idTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label errorLabel;
        private Button clearButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}