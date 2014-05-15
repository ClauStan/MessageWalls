using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageWalls.View
{
    public partial class LoginUserView : UserControl , ILoginUserView
    {
        public event EventHandler LoginUserClicked;
        public event EventHandler LoginUserOfflineClicked;
        public event EventHandler GoToCreateUserClicked;
        public event EventHandler LoginUsernameChanged;

        public LoginUserView()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return textBoxLoginUsername.Text; }
            set { textBoxLoginUsername.Text = value; }
        }

        public string Password
        {
            get { return textBoxLoginPassword.Text; }
            set { textBoxLoginPassword.Text = value; }
        }

        public bool RememberUser
        {
            get { return checkBoxLoginRememberMe.Checked; }
            set { checkBoxLoginRememberMe.Checked = value; }
        }

        public bool LoginOfflineVisible
        {
            get { return buttonOffline.Visible; }
            set { buttonOffline.Visible = value; }
        }

        public bool LoginLoadingVisible
        {
            get { return progressBarLogin.Visible; }
            set { progressBarLogin.Visible = value; }
        }

        public string ErrorText
        {
            get { return labelError.Text; }
            set { labelError.Text = value; }
        }

        public void SetUsernameFocus()
        {
            textBoxLoginUsername.Focus();
        }

        public void SetPasswordFocus()
        {
            textBoxLoginPassword.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (LoginUserClicked != null)
            {
                LoginUserClicked(this, e);
            }
        }

        private void buttonOffline_Click(object sender, EventArgs e)
        {
            if (LoginUserOfflineClicked != null)
            {
                LoginUserOfflineClicked(this, e);
            }
        }

        private void linkLabelGoToCreateNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GoToCreateUserClicked != null)
            {
                GoToCreateUserClicked(this, e);
            }
        }

        private void textBoxLoginUsername_TextChanged(object sender, EventArgs e)
        {
            if (LoginUsernameChanged != null)
            {
                LoginUsernameChanged(this, e);
            }
        }
    }
}
