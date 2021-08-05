namespace Retardhook
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.usernameText = new MetroFramework.Controls.MetroTextBox();
            this.passwordText = new MetroFramework.Controls.MetroTextBox();
            this.loginBtn = new MetroFramework.Controls.MetroButton();
            this.rememberCheck = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.BackColor = System.Drawing.SystemColors.Control;
            this.usernameText.Location = new System.Drawing.Point(12, 12);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(204, 23);
            this.usernameText.Style = MetroFramework.MetroColorStyle.Green;
            this.usernameText.TabIndex = 0;
            this.usernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(12, 41);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(204, 23);
            this.passwordText.Style = MetroFramework.MetroColorStyle.Green;
            this.passwordText.TabIndex = 1;
            this.passwordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordText.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(12, 91);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(204, 23);
            this.loginBtn.Style = MetroFramework.MetroColorStyle.Green;
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Log in";
            this.loginBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // rememberCheck
            // 
            this.rememberCheck.AutoSize = true;
            this.rememberCheck.Location = new System.Drawing.Point(12, 70);
            this.rememberCheck.Name = "rememberCheck";
            this.rememberCheck.Size = new System.Drawing.Size(141, 15);
            this.rememberCheck.Style = MetroFramework.MetroColorStyle.Green;
            this.rememberCheck.TabIndex = 3;
            this.rememberCheck.Text = "Remember credentials";
            this.rememberCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rememberCheck.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(228, 129);
            this.Controls.Add(this.rememberCheck);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(244, 168);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(244, 168);
            this.Name = "Auth";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox usernameText;
        private MetroFramework.Controls.MetroTextBox passwordText;
        private MetroFramework.Controls.MetroButton loginBtn;
        private MetroFramework.Controls.MetroCheckBox rememberCheck;
    }
}

