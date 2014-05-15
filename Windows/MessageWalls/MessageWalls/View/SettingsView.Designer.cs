namespace MessageWalls.View
{
    partial class SettingsView
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSeconds = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.checkBoxShowNotifications = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Aqua;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(58, 234);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(97, 35);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxSeconds);
            this.panel1.Controls.Add(this.comboBoxMinutes);
            this.panel1.Controls.Add(this.checkBoxShowNotifications);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(58, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 115);
            this.panel1.TabIndex = 10;
            // 
            // comboBoxSeconds
            // 
            this.comboBoxSeconds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeconds.FormattingEnabled = true;
            this.comboBoxSeconds.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50"});
            this.comboBoxSeconds.Location = new System.Drawing.Point(307, 22);
            this.comboBoxSeconds.Name = "comboBoxSeconds";
            this.comboBoxSeconds.Size = new System.Drawing.Size(42, 21);
            this.comboBoxSeconds.TabIndex = 8;
            this.comboBoxSeconds.SelectedIndexChanged += new System.EventHandler(this.comboBoxSeconds_SelectedIndexChanged);
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "40",
            "50",
            "60",
            "120",
            "180"});
            this.comboBoxMinutes.Location = new System.Drawing.Point(191, 22);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(42, 21);
            this.comboBoxMinutes.TabIndex = 7;
            this.comboBoxMinutes.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinutes_SelectedIndexChanged);
            // 
            // checkBoxShowNotifications
            // 
            this.checkBoxShowNotifications.AutoSize = true;
            this.checkBoxShowNotifications.Checked = true;
            this.checkBoxShowNotifications.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowNotifications.Location = new System.Drawing.Point(21, 59);
            this.checkBoxShowNotifications.Name = "checkBoxShowNotifications";
            this.checkBoxShowNotifications.Size = new System.Drawing.Size(133, 20);
            this.checkBoxShowNotifications.TabIndex = 2;
            this.checkBoxShowNotifications.Text = "Show notifications";
            this.checkBoxShowNotifications.UseVisualStyleBackColor = true;
            this.checkBoxShowNotifications.CheckedChanged += new System.EventHandler(this.checkBoxShowNotifications_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Refresh rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Settings";
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(492, 343);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSeconds;
        private System.Windows.Forms.ComboBox comboBoxMinutes;
        private System.Windows.Forms.CheckBox checkBoxShowNotifications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}
