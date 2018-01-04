namespace CISDotnetGroupProject
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.RoleLabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.forgotButton = new System.Windows.Forms.Button();
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.singupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Location = new System.Drawing.Point(80, 46);
            this.RoleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(97, 20);
            this.RoleLabel.TabIndex = 0;
            this.RoleLabel.Text = "&Select Role*";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(80, 106);
            this.usernamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(89, 20);
            this.usernamelabel.TabIndex = 1;
            this.usernamelabel.Text = "&Username*";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Location = new System.Drawing.Point(80, 165);
            this.passwordlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(84, 20);
            this.passwordlabel.TabIndex = 2;
            this.passwordlabel.Text = "&Password*";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(238, 223);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(153, 35);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "&Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(435, 223);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 35);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // forgotButton
            // 
            this.forgotButton.Location = new System.Drawing.Point(238, 285);
            this.forgotButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forgotButton.Name = "forgotButton";
            this.forgotButton.Size = new System.Drawing.Size(153, 34);
            this.forgotButton.TabIndex = 5;
            this.forgotButton.Text = "&ForgotPassword ?";
            this.forgotButton.UseVisualStyleBackColor = true;
            this.forgotButton.Click += new System.EventHandler(this.forgotButton_Click);
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Items.AddRange(new object[] {
            "Faculty",
            "Student"});
            this.rolecomboBox.Location = new System.Drawing.Point(238, 42);
            this.rolecomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(307, 28);
            this.rolecomboBox.TabIndex = 6;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(238, 95);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(307, 26);
            this.usernameTextbox.TabIndex = 7;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(238, 154);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(307, 26);
            this.passwordTextbox.TabIndex = 8;
            this.passwordTextbox.UseWaitCursor = true;
            // 
            // singupButton
            // 
            this.singupButton.Location = new System.Drawing.Point(435, 283);
            this.singupButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.singupButton.Name = "singupButton";
            this.singupButton.Size = new System.Drawing.Size(112, 35);
            this.singupButton.TabIndex = 9;
            this.singupButton.Text = "S&ignup";
            this.singupButton.UseVisualStyleBackColor = true;
            this.singupButton.Click += new System.EventHandler(this.singupButton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(708, 358);
            this.Controls.Add(this.singupButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.rolecomboBox);
            this.Controls.Add(this.forgotButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.RoleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogIn";
            this.Text = "User LogIn ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button forgotButton;
        private System.Windows.Forms.ComboBox rolecomboBox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button singupButton;
    }
}

