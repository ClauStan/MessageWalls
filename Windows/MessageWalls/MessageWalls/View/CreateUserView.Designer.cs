namespace MessageWalls.View
{
    partial class CreateUserView
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
            this.labelError = new System.Windows.Forms.Label();
            this.progressBarCreate = new System.Windows.Forms.ProgressBar();
            this.textBoxCreateRetypePassword = new System.Windows.Forms.TextBox();
            this.labelCreateRetypePassword = new System.Windows.Forms.Label();
            this.textBoxCreatePassword = new System.Windows.Forms.TextBox();
            this.labelCreatePassword = new System.Windows.Forms.Label();
            this.textBoxCreateDisplayName = new System.Windows.Forms.TextBox();
            this.labelCreateDisplayName = new System.Windows.Forms.Label();
            this.textBoxCreateUsername = new System.Windows.Forms.TextBox();
            this.labelCreateUsername = new System.Windows.Forms.Label();
            this.labelCreateTitle = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelGoToCreateNewUser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(56, 262);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 33;
            // 
            // progressBarCreate
            // 
            this.progressBarCreate.Location = new System.Drawing.Point(59, 246);
            this.progressBarCreate.MarqueeAnimationSpeed = 30;
            this.progressBarCreate.Name = "progressBarCreate";
            this.progressBarCreate.Size = new System.Drawing.Size(139, 10);
            this.progressBarCreate.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarCreate.TabIndex = 32;
            this.progressBarCreate.Visible = false;
            // 
            // textBoxCreateRetypePassword
            // 
            this.textBoxCreateRetypePassword.Location = new System.Drawing.Point(176, 159);
            this.textBoxCreateRetypePassword.MaxLength = 15;
            this.textBoxCreateRetypePassword.Name = "textBoxCreateRetypePassword";
            this.textBoxCreateRetypePassword.PasswordChar = '*';
            this.textBoxCreateRetypePassword.Size = new System.Drawing.Size(134, 20);
            this.textBoxCreateRetypePassword.TabIndex = 31;
            // 
            // labelCreateRetypePassword
            // 
            this.labelCreateRetypePassword.AutoSize = true;
            this.labelCreateRetypePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateRetypePassword.Location = new System.Drawing.Point(56, 160);
            this.labelCreateRetypePassword.Name = "labelCreateRetypePassword";
            this.labelCreateRetypePassword.Size = new System.Drawing.Size(114, 16);
            this.labelCreateRetypePassword.TabIndex = 30;
            this.labelCreateRetypePassword.Text = "Retype password";
            // 
            // textBoxCreatePassword
            // 
            this.textBoxCreatePassword.Location = new System.Drawing.Point(176, 133);
            this.textBoxCreatePassword.MaxLength = 15;
            this.textBoxCreatePassword.Name = "textBoxCreatePassword";
            this.textBoxCreatePassword.PasswordChar = '*';
            this.textBoxCreatePassword.Size = new System.Drawing.Size(134, 20);
            this.textBoxCreatePassword.TabIndex = 29;
            // 
            // labelCreatePassword
            // 
            this.labelCreatePassword.AutoSize = true;
            this.labelCreatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreatePassword.Location = new System.Drawing.Point(56, 134);
            this.labelCreatePassword.Name = "labelCreatePassword";
            this.labelCreatePassword.Size = new System.Drawing.Size(68, 16);
            this.labelCreatePassword.TabIndex = 28;
            this.labelCreatePassword.Text = "Password";
            // 
            // textBoxCreateDisplayName
            // 
            this.textBoxCreateDisplayName.Location = new System.Drawing.Point(176, 106);
            this.textBoxCreateDisplayName.MaxLength = 15;
            this.textBoxCreateDisplayName.Name = "textBoxCreateDisplayName";
            this.textBoxCreateDisplayName.Size = new System.Drawing.Size(134, 20);
            this.textBoxCreateDisplayName.TabIndex = 27;
            // 
            // labelCreateDisplayName
            // 
            this.labelCreateDisplayName.AutoSize = true;
            this.labelCreateDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateDisplayName.Location = new System.Drawing.Point(56, 107);
            this.labelCreateDisplayName.Name = "labelCreateDisplayName";
            this.labelCreateDisplayName.Size = new System.Drawing.Size(94, 16);
            this.labelCreateDisplayName.TabIndex = 26;
            this.labelCreateDisplayName.Text = "Display Name";
            // 
            // textBoxCreateUsername
            // 
            this.textBoxCreateUsername.Location = new System.Drawing.Point(176, 80);
            this.textBoxCreateUsername.MaxLength = 15;
            this.textBoxCreateUsername.Name = "textBoxCreateUsername";
            this.textBoxCreateUsername.Size = new System.Drawing.Size(134, 20);
            this.textBoxCreateUsername.TabIndex = 25;
            // 
            // labelCreateUsername
            // 
            this.labelCreateUsername.AutoSize = true;
            this.labelCreateUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateUsername.Location = new System.Drawing.Point(56, 81);
            this.labelCreateUsername.Name = "labelCreateUsername";
            this.labelCreateUsername.Size = new System.Drawing.Size(71, 16);
            this.labelCreateUsername.TabIndex = 24;
            this.labelCreateUsername.Text = "Username";
            // 
            // labelCreateTitle
            // 
            this.labelCreateTitle.AutoSize = true;
            this.labelCreateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateTitle.Location = new System.Drawing.Point(55, 41);
            this.labelCreateTitle.Name = "labelCreateTitle";
            this.labelCreateTitle.Size = new System.Drawing.Size(125, 20);
            this.labelCreateTitle.TabIndex = 23;
            this.labelCreateTitle.Text = "Create new user";
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.Red;
            this.buttonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.Location = new System.Drawing.Point(59, 202);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(141, 38);
            this.buttonCreate.TabIndex = 22;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(56, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 35;
            // 
            // linkLabelGoToCreateNewUser
            // 
            this.linkLabelGoToCreateNewUser.AutoSize = true;
            this.linkLabelGoToCreateNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelGoToCreateNewUser.LinkArea = new System.Windows.Forms.LinkArea(9, 19);
            this.linkLabelGoToCreateNewUser.Location = new System.Drawing.Point(59, 313);
            this.linkLabelGoToCreateNewUser.Name = "linkLabelGoToCreateNewUser";
            this.linkLabelGoToCreateNewUser.Size = new System.Drawing.Size(212, 20);
            this.linkLabelGoToCreateNewUser.TabIndex = 34;
            this.linkLabelGoToCreateNewUser.TabStop = true;
            this.linkLabelGoToCreateNewUser.Text = "Or go to login existing user window";
            this.linkLabelGoToCreateNewUser.UseCompatibleTextRendering = true;
            this.linkLabelGoToCreateNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoToCreateNewUser_LinkClicked);
            // 
            // CreateUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelGoToCreateNewUser);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.progressBarCreate);
            this.Controls.Add(this.textBoxCreateRetypePassword);
            this.Controls.Add(this.labelCreateRetypePassword);
            this.Controls.Add(this.textBoxCreatePassword);
            this.Controls.Add(this.labelCreatePassword);
            this.Controls.Add(this.textBoxCreateDisplayName);
            this.Controls.Add(this.labelCreateDisplayName);
            this.Controls.Add(this.textBoxCreateUsername);
            this.Controls.Add(this.labelCreateUsername);
            this.Controls.Add(this.labelCreateTitle);
            this.Controls.Add(this.buttonCreate);
            this.Name = "CreateUserView";
            this.Size = new System.Drawing.Size(366, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.ProgressBar progressBarCreate;
        private System.Windows.Forms.TextBox textBoxCreateRetypePassword;
        private System.Windows.Forms.Label labelCreateRetypePassword;
        private System.Windows.Forms.TextBox textBoxCreatePassword;
        private System.Windows.Forms.Label labelCreatePassword;
        private System.Windows.Forms.TextBox textBoxCreateDisplayName;
        private System.Windows.Forms.Label labelCreateDisplayName;
        private System.Windows.Forms.TextBox textBoxCreateUsername;
        private System.Windows.Forms.Label labelCreateUsername;
        private System.Windows.Forms.Label labelCreateTitle;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelGoToCreateNewUser;
    }
}
