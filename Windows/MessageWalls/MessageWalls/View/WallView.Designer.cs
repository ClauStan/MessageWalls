namespace MessageWalls.View
{
    partial class WallView
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
            this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddWall = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonPostMessage = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddWall = new System.Windows.Forms.Button();
            this.comboBoxMessageWalls = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(22, 482);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 34;
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.Location = new System.Drawing.Point(25, 102);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.Size = new System.Drawing.Size(531, 361);
            this.richTextBoxMessages.TabIndex = 33;
            this.richTextBoxMessages.Text = "";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(464, 45);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(92, 27);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Add new wall";
            // 
            // textBoxAddWall
            // 
            this.textBoxAddWall.Location = new System.Drawing.Point(584, 121);
            this.textBoxAddWall.MaxLength = 25;
            this.textBoxAddWall.Name = "textBoxAddWall";
            this.textBoxAddWall.Size = new System.Drawing.Size(212, 20);
            this.textBoxAddWall.TabIndex = 30;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Aqua;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(366, 45);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(92, 27);
            this.buttonRefresh.TabIndex = 29;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonPostMessage
            // 
            this.buttonPostMessage.BackColor = System.Drawing.Color.Aqua;
            this.buttonPostMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostMessage.Location = new System.Drawing.Point(584, 432);
            this.buttonPostMessage.Name = "buttonPostMessage";
            this.buttonPostMessage.Size = new System.Drawing.Size(119, 32);
            this.buttonPostMessage.TabIndex = 28;
            this.buttonPostMessage.Text = "Post";
            this.buttonPostMessage.UseVisualStyleBackColor = false;
            this.buttonPostMessage.Click += new System.EventHandler(this.buttonPostMessage_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(584, 215);
            this.textBoxMessage.MaxLength = 300;
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(221, 199);
            this.textBoxMessage.TabIndex = 27;
            this.textBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMessage_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(581, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Post new message";
            // 
            // buttonAddWall
            // 
            this.buttonAddWall.BackColor = System.Drawing.Color.Aqua;
            this.buttonAddWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddWall.Location = new System.Drawing.Point(584, 148);
            this.buttonAddWall.Name = "buttonAddWall";
            this.buttonAddWall.Size = new System.Drawing.Size(92, 27);
            this.buttonAddWall.TabIndex = 25;
            this.buttonAddWall.Text = "Add";
            this.buttonAddWall.UseVisualStyleBackColor = false;
            this.buttonAddWall.Click += new System.EventHandler(this.buttonAddWall_Click);
            // 
            // comboBoxMessageWalls
            // 
            this.comboBoxMessageWalls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMessageWalls.FormattingEnabled = true;
            this.comboBoxMessageWalls.Location = new System.Drawing.Point(126, 50);
            this.comboBoxMessageWalls.Name = "comboBoxMessageWalls";
            this.comboBoxMessageWalls.Size = new System.Drawing.Size(212, 21);
            this.comboBoxMessageWalls.TabIndex = 24;
            this.comboBoxMessageWalls.SelectedIndexChanged += new System.EventHandler(this.comboBoxMessageWalls_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Message walls";
            // 
            // WallView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.richTextBoxMessages);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAddWall);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonPostMessage);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddWall);
            this.Controls.Add(this.comboBoxMessageWalls);
            this.Controls.Add(this.label1);
            this.Name = "WallView";
            this.Size = new System.Drawing.Size(826, 555);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.RichTextBox richTextBoxMessages;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddWall;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonPostMessage;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddWall;
        private System.Windows.Forms.ComboBox comboBoxMessageWalls;
        private System.Windows.Forms.Label label1;
    }
}
