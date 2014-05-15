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
    public partial class CreateUserView : UserControl, ICreateUserView
    {
        public event EventHandler CreateUserClicked;
        public event EventHandler GoToLoginUserClicked;

        public CreateUserView()
        {
            InitializeComponent();
        }

        public string Username
        {
            get { return textBoxCreateUsername.Text; }
            set { textBoxCreateUsername.Text = value; }
        }

        public string DisplayName
        {
            get { return textBoxCreateDisplayName.Text; }
            set { textBoxCreateDisplayName.Text = value; }
        }

        public string Password
        {
            get { return textBoxCreatePassword.Text; }
            set { textBoxCreatePassword.Text = value; }
        }

        public string RePassword
        {
            get { return textBoxCreateRetypePassword.Text; }
            set { textBoxCreateRetypePassword.Text = value; }
        }

        public bool CreateLoadingVisible
        {
            get { return progressBarCreate.Visible; }
            set { progressBarCreate.Visible = value; }
        }

        public string ErrorText
        {
            get { return labelError.Text; }
            set { labelError.Text = value; }
        }

        public void SetUsernameFocus()
        {
            textBoxCreateUsername.Focus();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (CreateUserClicked != null)
            {
                CreateUserClicked(this, e);
            }
        }

        private void linkLabelGoToCreateNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (GoToLoginUserClicked != null)
            {
                GoToLoginUserClicked(this, e);
            }
        }
    }
}
