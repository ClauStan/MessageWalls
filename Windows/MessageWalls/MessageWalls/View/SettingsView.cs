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
    public partial class SettingsView : UserControl, ISettingsView
    {
        public event EventHandler ShowNotificationChanged;
        public event EventHandler RefreshMinutesChanged;
        public event EventHandler RefreshSecondsChanged;
        public event EventHandler GoToPreviousView;

        public SettingsView()
        {
            InitializeComponent();
        }

        public int RefreshMinutes
        {
            get 
            {    
                try
                {
                    int minutes = Convert.ToInt32(comboBoxMinutes.SelectedItem.ToString());
                    return minutes;
                }
                catch
                {
                    //default value
                    return 0;
                }
            }
            set
            {
                comboBoxMinutes.SelectedItem = value.ToString();
            }
        }

        public int RefreshSeconds
        {
            get
            {
                try
                {
                    int seconds = Convert.ToInt32(comboBoxSeconds.SelectedItem.ToString());
                    return seconds;
                }
                catch
                {
                    //default value
                    return 2;
                }
            }
            set
            {
                comboBoxSeconds.SelectedItem = value.ToString();
            }
        }

        public bool ShowNotifications
        {
            get { return checkBoxShowNotifications.Checked; }
            set { checkBoxShowNotifications.Checked = value; }
        }

        private void checkBoxShowNotifications_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowNotificationChanged != null)
            {
                ShowNotificationChanged(this, e);
            }
        }

        private void comboBoxMinutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RefreshMinutesChanged != null)
            {
                RefreshMinutesChanged(this, e);
            }
        }

        private void comboBoxSeconds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RefreshSecondsChanged != null)
            {
                RefreshSecondsChanged(this, e);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (GoToPreviousView != null)
            {
                GoToPreviousView(this, e);
            }
        }
    }
}
