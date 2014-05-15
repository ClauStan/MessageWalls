namespace MessageWalls.View
{
    partial class LoginUserView
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
            this.buttonOffline = new System.Windows.Forms.Button();
            this.progressBarLogin = new System.Windows.Forms.ProgressBar();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxLoginRememberMe = new System.Windows.Forms.CheckBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.textBoxLoginUsername = new System.Windows.Forms.TextBox();
            this.labelLoginUsername = new System.Windows.Forms.Label();
            this.labelLoginTitle = new System.Windows.Forms.Label();
            this.linkLabelGoToCreateNewUser = new System.Windows.Forms.LinkLabel();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOffline
            // 
            this.buttonOffline.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonOffline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOffline.Location = new System.Drawing.Point(172, 192);
            this.buttonOffline.Name = "buttonOffline";
            this.buttonOffline.Size = new System.Drawing.Size(99, 26);
            this.buttonOffline.TabIndex = 31;
            this.buttonOffline.Text = "Offline Mode";
            this.buttonOffline.UseVisualStyleBackColor = false;
            this.buttonOffline.Visible = false;
            this.buttonOffline.Click += new System.EventHandler(this.buttonOffline_Click);
            // 
            // progressBarLogin
            // 
            this.progressBarLogin.Location = new System.Drawing.Point(49, 229);
            this.progressBarLogin.MarqueeAnimationSpeed = 30;
            this.progressBarLogin.Name = "progressBarLogin";
            this.progressBarLogin.Size = new System.Drawing.Size(117, 10);
            this.progressBarLogin.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarLogin.TabIndex = 30;
            this.progressBarLogin.Visible = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Aqua;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(49, 185);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(117, 38);
            this.buttonLogin.TabIndex = 29;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxLoginRememberMe
            // 
            this.checkBoxLoginRememberMe.AutoSize = true;
            this.checkBoxLoginRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLoginRememberMe.Location = new System.Drawing.Point(49, 144);
            this.checkBoxLoginRememberMe.Name = "checkBoxLoginRememberMe";
            this.checkBoxLoginRememberMe.Size = new System.Drawing.Size(117, 20);
            this.checkBoxLoginRememberMe.TabIndex = 28;
            this.checkBoxLoginRememberMe.Text = "Remember me";
            this.checkBoxLoginRememberMe.UseVisualStyleBackColor = true;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(123, 109);
            this.textBoxLoginPassword.MaxLength = 15;
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(134, 20);
            this.textBoxLoginPassword.TabIndex = 27;
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.Location = new System.Drawing.Point(46, 113);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(68, 16);
            this.labelLoginPassword.TabIndex = 26;
            this.labelLoginPassword.Text = "Password";
            // 
            // textBoxLoginUsername
            // 
            this.textBoxLoginUsername.Location = new System.Drawing.Point(123, 84);
            this.textBoxLoginUsername.MaxLength = 15;
            this.textBoxLoginUsername.Name = "textBoxLoginUsername";
            this.textBoxLoginUsername.Size = new System.Drawing.Size(134, 20);
            this.textBoxLoginUsername.TabIndex = 25;
            this.textBoxLoginUsername.TextChanged += new System.EventHandler(this.textBoxLoginUsername_TextChanged);
            // 
            // labelLoginUsername
            // 
            this.labelLoginUsername.AutoSize = true;
            this.labelLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUsername.Location = new System.Drawing.Point(46, 84);
            this.labelLoginUsername.Name = "labelLoginUsername";
            this.labelLoginUsername.Size = new System.Drawing.Size(71, 16);
            this.labelLoginUsername.TabIndex = 24;
            this.labelLoginUsername.Text = "Username";
            // 
            // labelLoginTitle
            // 
            this.labelLoginTitle.AutoSize = true;
            this.labelLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTitle.Location = new System.Drawing.Point(45, 44);
            this.labelLoginTitle.Name = "labelLoginTitle";
            this.labelLoginTitle.Size = new System.Drawing.Size(140, 20);
            this.labelLoginTitle.TabIndex = 23;
            this.labelLoginTitle.Text = "Login existing user";
            // 
            // linkLabelGoToCreateNewUser
            // 
            this.linkLabelGoToCreateNewUser.AutoSize = true;
            this.linkLabelGoToCreateNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGoToCreateNewUser.LinkArea = new System.Windows.Forms.LinkArea(9, 15);
            this.linkLabelGoToCreateNewUser.Location = new System.Drawing.Point(49, 300);
            this.linkLabelGoToCreateNewUser.Name = "linkLabelGoToCreateNewUser";
            this.linkLabelGoToCreateNewUser.Size = new System.Drawing.Size(200, 20);
            this.linkLabelGoToCreateNewUser.TabIndex = 32;
            this.linkLabelGoToCreateNewUser.TabStop = true;
            this.linkLabelGoToCreateNewUser.Text = "Or go to create new user window";
            this.linkLabelGoToCreateNewUser.UseCompatibleTextRendering = true;
            this.linkLabelGoToCreateNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoToCreateNewUser_LinkClicked);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(46, 249);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 33;
            // 
            // LoginUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.linkLabelGoToCreateNewUser);
            this.Controls.Add(this.buttonOffline);
            this.Controls.Add(this.progressBarLogin);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBoxLoginRememberMe);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.textBoxLoginUsername);
            this.Controls.Add(this.labelLoginUsername);
            this.Controls.Add(this.labelLoginTitle);
            this.Name = "LoginUserView";
            this.Size = new System.Drawing.Size(321, 374);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOffline;
        private System.Windows.Forms.ProgressBar progressBarLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxLoginRememberMe;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginUsername;
        private System.Windows.Forms.Label labelLoginUsername;
        private System.Windows.Forms.Label labelLoginTitle;
        private System.Windows.Forms.LinkLabel linkLabelGoToCreateNewUser;
        private System.Windows.Forms.Label labelError;
    }
}
