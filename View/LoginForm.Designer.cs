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
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(74, 57);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(101, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "Employee ID: ";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(74, 96);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(77, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password: ";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(171, 53);
            idTextBox.Margin = new Padding(3, 4, 3, 4);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(293, 27);
            idTextBox.TabIndex = 2;
            idTextBox.TextChanged += idTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(171, 92);
            passwordTextBox.Margin = new Padding(3, 4, 3, 4);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(293, 27);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.Location = new Point(112, 175);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(210, 31);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(175, 137);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 20);
            errorLabel.TabIndex = 5;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(340, 175);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(174, 31);
            clearButton.TabIndex = 7;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 255);
            Controls.Add(clearButton);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(idTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(idLabel);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
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
    }
}