namespace CapacityKeyV8
{
    partial class LogInPage
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
            this.userNameLogInLabel = new System.Windows.Forms.Label();
            this.passwordLogInLabel = new System.Windows.Forms.Label();
            this.userTypeLogInLabel = new System.Windows.Forms.Label();
            this.userNameLogInBox = new System.Windows.Forms.TextBox();
            this.passwordLogInBox = new System.Windows.Forms.TextBox();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.logInExitButton = new System.Windows.Forms.Button();
            this.logInTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameLogInLabel
            // 
            this.userNameLogInLabel.AutoSize = true;
            this.userNameLogInLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLogInLabel.Location = new System.Drawing.Point(148, 130);
            this.userNameLogInLabel.Name = "userNameLogInLabel";
            this.userNameLogInLabel.Size = new System.Drawing.Size(95, 23);
            this.userNameLogInLabel.TabIndex = 0;
            this.userNameLogInLabel.Text = "User Name:";
            // 
            // passwordLogInLabel
            // 
            this.passwordLogInLabel.AutoSize = true;
            this.passwordLogInLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLogInLabel.Location = new System.Drawing.Point(163, 189);
            this.passwordLogInLabel.Name = "passwordLogInLabel";
            this.passwordLogInLabel.Size = new System.Drawing.Size(81, 23);
            this.passwordLogInLabel.TabIndex = 1;
            this.passwordLogInLabel.Text = "Password:";
            // 
            // userTypeLogInLabel
            // 
            this.userTypeLogInLabel.AutoSize = true;
            this.userTypeLogInLabel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeLogInLabel.Location = new System.Drawing.Point(154, 254);
            this.userTypeLogInLabel.Name = "userTypeLogInLabel";
            this.userTypeLogInLabel.Size = new System.Drawing.Size(92, 23);
            this.userTypeLogInLabel.TabIndex = 2;
            this.userTypeLogInLabel.Text = "User Type:";
            // 
            // userNameLogInBox
            // 
            this.userNameLogInBox.Location = new System.Drawing.Point(249, 126);
            this.userNameLogInBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameLogInBox.Name = "userNameLogInBox";
            this.userNameLogInBox.Size = new System.Drawing.Size(136, 26);
            this.userNameLogInBox.TabIndex = 3;
            // 
            // passwordLogInBox
            // 
            this.passwordLogInBox.Location = new System.Drawing.Point(249, 186);
            this.passwordLogInBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordLogInBox.Name = "passwordLogInBox";
            this.passwordLogInBox.Size = new System.Drawing.Size(136, 26);
            this.passwordLogInBox.TabIndex = 4;
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.userTypeComboBox.Location = new System.Drawing.Point(249, 251);
            this.userTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(136, 28);
            this.userTypeComboBox.TabIndex = 5;
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(141, 354);
            this.logInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(84, 39);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Log In";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // logInExitButton
            // 
            this.logInExitButton.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInExitButton.Location = new System.Drawing.Point(284, 354);
            this.logInExitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logInExitButton.Name = "logInExitButton";
            this.logInExitButton.Size = new System.Drawing.Size(84, 39);
            this.logInExitButton.TabIndex = 7;
            this.logInExitButton.Text = "Exit";
            this.logInExitButton.UseVisualStyleBackColor = true;
            this.logInExitButton.Click += new System.EventHandler(this.logInExitButton_Click);
            // 
            // logInTitleLabel
            // 
            this.logInTitleLabel.AutoSize = true;
            this.logInTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInTitleLabel.Location = new System.Drawing.Point(201, 39);
            this.logInTitleLabel.Name = "logInTitleLabel";
            this.logInTitleLabel.Size = new System.Drawing.Size(139, 35);
            this.logInTitleLabel.TabIndex = 17;
            this.logInTitleLabel.Text = "User Login";
            this.logInTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 428);
            this.Controls.Add(this.logInTitleLabel);
            this.Controls.Add(this.logInExitButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.userTypeComboBox);
            this.Controls.Add(this.passwordLogInBox);
            this.Controls.Add(this.userNameLogInBox);
            this.Controls.Add(this.userTypeLogInLabel);
            this.Controls.Add(this.passwordLogInLabel);
            this.Controls.Add(this.userNameLogInLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogInPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacity Key for Software Teams";
            this.Load += new System.EventHandler(this.LogInPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLogInLabel;
        private System.Windows.Forms.Label passwordLogInLabel;
        private System.Windows.Forms.Label userTypeLogInLabel;
        private System.Windows.Forms.TextBox userNameLogInBox;
        private System.Windows.Forms.TextBox passwordLogInBox;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button logInExitButton;
        private System.Windows.Forms.Label logInTitleLabel;
    }
}

