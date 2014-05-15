using MessageWalls.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageWalls
{
    public partial class ParentView : Form, IParentView
    {
        public event EventHandler InvertVisibility;
        public event EventHandler ExitClicked;
        public event EventHandler SettingsClicked;
        public event EventHandler AboutClicked;

        IChildView currentChildView;

        public ParentView()
        {
            InitializeComponent();
            SetParentViewLocation();
        }

        public string Title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public IChildView CurrentChildView 
        {
            get { return currentChildView; }
            set
            {
                UserControl currentChild = (UserControl)currentChildView;

                if (currentChild != null)
                {
                    this.Controls.Remove(currentChild);
                }

                currentChildView = value;
                currentChild = (UserControl)currentChildView;

                this.Size = currentChild.Size;
                this.Controls.Add(currentChild);
            }
        }

        public bool IsVisible 
        {
            get { return this.Visible; }
            set
            {
                if (value)
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                }
                else
                {
                    this.Hide();
                    notifyIcon1.Visible = true;
                }
            }
        }

        public void ShowNotification(string text)
        {
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.ShowBalloonTip(1);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SettingsClicked != null)
            {
                SettingsClicked(this, e);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the app
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AboutClicked != null)
            {
                AboutClicked(this, e);
            }
        }

        private void ParentView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ExitClicked != null)
            {
                ExitClicked(this, e);
            }
        }

        private void SetParentViewLocation()
        {
            Screen myScreen = Screen.FromControl(this);
            Size size = myScreen.WorkingArea.Size;
            this.Location = new System.Drawing.Point(size.Width / 4, size.Height / 4);
        }

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InvertVisibility != null)
            {
                InvertVisibility(this, e);
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //close the app
            this.Close();
        }

        private void ParentView_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                if (InvertVisibility != null)
                {
                    InvertVisibility(this, e);
                }
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (InvertVisibility != null)
            {
                InvertVisibility(this, e);
            }
        }
    }
}
