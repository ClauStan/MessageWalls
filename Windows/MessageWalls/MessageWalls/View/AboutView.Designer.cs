namespace MessageWalls.View
{
    partial class AboutView
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabelCode = new System.Windows.Forms.LinkLabel();
            this.linkLabelAuthor = new System.Windows.Forms.LinkLabel();
            this.labelAppName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Aqua;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(73, 181);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(97, 35);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "About";
            // 
            // linkLabelCode
            // 
            this.linkLabelCode.AutoSize = true;
            this.linkLabelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCode.LinkArea = new System.Windows.Forms.LinkArea(44, 4);
            this.linkLabelCode.Location = new System.Drawing.Point(73, 131);
            this.linkLabelCode.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabelCode.Name = "linkLabelCode";
            this.linkLabelCode.Size = new System.Drawing.Size(283, 20);
            this.linkLabelCode.TabIndex = 17;
            this.linkLabelCode.TabStop = true;
            this.linkLabelCode.Text = "You can find the latest version of the code here";
            this.linkLabelCode.UseCompatibleTextRendering = true;
            this.linkLabelCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // linkLabelAuthor
            // 
            this.linkLabelAuthor.AutoSize = true;
            this.linkLabelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelAuthor.LinkArea = new System.Windows.Forms.LinkArea(11, 12);
            this.linkLabelAuthor.Location = new System.Drawing.Point(73, 105);
            this.linkLabelAuthor.Margin = new System.Windows.Forms.Padding(3);
            this.linkLabelAuthor.Name = "linkLabelAuthor";
            this.linkLabelAuthor.Size = new System.Drawing.Size(150, 20);
            this.linkLabelAuthor.TabIndex = 18;
            this.linkLabelAuthor.TabStop = true;
            this.linkLabelAuthor.Text = "Created by Claudiu Stan";
            this.linkLabelAuthor.UseCompatibleTextRendering = true;
            this.linkLabelAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAuthor_LinkClicked);
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppName.Location = new System.Drawing.Point(73, 83);
            this.labelAppName.Margin = new System.Windows.Forms.Padding(3);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(126, 16);
            this.labelAppName.TabIndex = 19;
            this.labelAppName.Text = "Message Wall 2014";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::MessageWalls.Properties.Resources.messagewall1;
            this.pictureBox1.Image = global::MessageWalls.Properties.Resources.messagewall1;
            this.pictureBox1.InitialImage = global::MessageWalls.Properties.Resources.messagewall1;
            this.pictureBox1.Location = new System.Drawing.Point(229, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.linkLabelAuthor);
            this.Controls.Add(this.linkLabelCode);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Name = "AboutView";
            this.Size = new System.Drawing.Size(510, 273);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelCode;
        private System.Windows.Forms.LinkLabel linkLabelAuthor;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
