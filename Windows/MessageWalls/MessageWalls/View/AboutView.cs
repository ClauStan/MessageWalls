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
    public partial class AboutView : UserControl , IAboutView
    {
        public event EventHandler AuthorWebLinkClicked;
        public event EventHandler CodeWebLinkClicked;
        public event EventHandler GoToPreviousView;

        public AboutView()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (GoToPreviousView != null)
            {
                GoToPreviousView(this, e);
            }
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CodeWebLinkClicked != null)
            {
                CodeWebLinkClicked(this, e);
            }
        }

        private void linkLabelAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (AuthorWebLinkClicked != null)
            {
                AuthorWebLinkClicked(this, e);
            }
        }
    }
}
