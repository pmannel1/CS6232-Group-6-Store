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
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idLabel.AutoSize = true;
            idLabel.Location = new Point(65, 43);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(79, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Employee ID: ";
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(65, 72);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(63, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password: ";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(150, 40);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(147, 23);
            idTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(150, 69);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(147, 23);
            passwordTextBox.TabIndex = 3;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.Location = new Point(138, 115);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(105, 145);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 15);
            errorLabel.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 191);
            Controls.Add(errorLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(idTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(idLabel);
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
    }
}