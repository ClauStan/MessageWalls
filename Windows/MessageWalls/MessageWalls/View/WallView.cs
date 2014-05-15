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
    public partial class WallView : UserControl, IWallView
    {
        public event EventHandler NewWallClicked;
        public event EventHandler NewMessageClicked;
        public event EventHandler NewWallSelected;
        public event EventHandler RefreshWallsClicked;
        public event EventHandler WallsAutoRefresh;

        private Timer backgroundTimer;
        private bool backgroundTimerWorking;
        private int backgroundTimerInterval;

        public WallView()
        {
            InitializeComponent();

            backgroundTimerWorking = false;
            backgroundTimerInterval = 2000;
            backgroundTimer = new Timer();
            backgroundTimer.Tick += backgroundTimer_Tick;
            backgroundTimer.Interval = backgroundTimerInterval;
        }

        public string NewMessageText
        {
            get { return textBoxMessage.Text; }
            set { textBoxMessage.Text = value; }
        }

        public string NewWallNameText
        {
            get { return textBoxAddWall.Text; }
            set { textBoxAddWall.Text = value; }
        }

        public string SelectedWall
        {
            get { return getSelectedWallName(); }
            set { setSelectedWallName(value); }
        }

        public string ErrorText
        {
            get { return labelError.Text; }
            set { labelError.Text = value; }
        }

        public bool RefreshEnabled
        {
            get { return buttonRefresh.Enabled; }
            set { buttonRefresh.Enabled = value; }
        }

        public bool AddNewWallEnabled
        {
            get { return buttonAddWall.Enabled; }
            set { buttonAddWall.Enabled = value; }
        }

        public bool AddNewMessageEnabled
        {
            get { return buttonPostMessage.Enabled; }
            set { buttonPostMessage.Enabled = value; }
        }

        public int AutoRefreshInterval 
        {
            get { return backgroundTimerInterval; }
            set { backgroundTimerInterval = value; backgroundTimer.Interval = value; }
        }

        public bool AutoRefreshWorking 
        {
            get { return backgroundTimerWorking; }
            set
            {
                bool oldValue = backgroundTimerWorking;
                backgroundTimerWorking = value;
                if (backgroundTimerWorking == true && oldValue == false)
                {
                    backgroundTimer.Start();
                }

                if (backgroundTimerWorking == false && oldValue == true)
                {
                    backgroundTimer.Stop();
                }
            }
        }

        private string getSelectedWallName()
        {
            if (comboBoxMessageWalls.SelectedIndex == -1)
            {
                return "";
            }

            return comboBoxMessageWalls.Items[comboBoxMessageWalls.SelectedIndex].ToString();
        }

        private void setSelectedWallName(string name)
        {
            int index = comboBoxMessageWalls.Items.IndexOf(name);
            if (index != -1)
            {
                comboBoxMessageWalls.SelectedIndex = index;
            }
        }

        public void AddNewWallName(string name)
        {
            comboBoxMessageWalls.Items.Add(name);
        }

        public void SelectWallByPos(int pos)
        {
            if (pos < 0 || pos > comboBoxMessageWalls.Items.Count - 1)
            {
                return;
            }

            comboBoxMessageWalls.SelectedIndex = pos;
        }

        public void AddMessageToSelectedWall(string content, string author, string date)
        {
            string text = content + Environment.NewLine;
            richTextBoxMessages.SelectionStart = richTextBoxMessages.TextLength;
            richTextBoxMessages.SelectionLength = 0;
            richTextBoxMessages.SelectionColor = Color.Blue;
            richTextBoxMessages.AppendText(text);

            text = "by " + author + " at " + date + Environment.NewLine + Environment.NewLine;
            richTextBoxMessages.SelectionStart = richTextBoxMessages.TextLength;
            richTextBoxMessages.SelectionLength = 0;
            richTextBoxMessages.SelectionColor = Color.Black;
            richTextBoxMessages.SelectionFont = new Font(richTextBoxMessages.Font, FontStyle.Bold);
            richTextBoxMessages.AppendText(text);

            richTextBoxMessages.ScrollToCaret();
        }

        public void ResetMessages()
        {
            richTextBoxMessages.ResetText();
        }

        public void SetNewMessageFocus()
        {
            textBoxMessage.Focus();
        }

        private void buttonAddWall_Click(object sender, EventArgs e)
        {
            if (NewWallClicked != null)
            {
                NewWallClicked(this, e);
            }
        }

        private void buttonPostMessage_Click(object sender, EventArgs e)
        {
            if (NewMessageClicked != null)
            {
                NewMessageClicked(this, e);
            }
        }

        private void comboBoxMessageWalls_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NewWallSelected != null)
            {
                NewWallSelected(this, e);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (RefreshWallsClicked != null)
            {
                RefreshWallsClicked(this, e);
            }
        }

        private void backgroundTimer_Tick(object sender, EventArgs e)
        {
            if (WallsAutoRefresh != null)
            {
                WallsAutoRefresh(this, e);
            }
        }

        private void textBoxMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //test if enter was pressed
            //if (e.KeyChar == (char)13)
            //{
            //    buttonPostMessage.PerformClick();
            //}
            //cannot send multiline messages this way
        }
    }
}
