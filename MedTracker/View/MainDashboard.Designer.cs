namespace MedTracker.View
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInformationUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRoleInformation = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.reportPictureBox = new System.Windows.Forms.PictureBox();
            this.reportLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(159, 54);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(172, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "UsernameWillAppearHere";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // lblInformationUsername
            // 
            this.lblInformationUsername.AutoSize = true;
            this.lblInformationUsername.Location = new System.Drawing.Point(15, 54);
            this.lblInformationUsername.Name = "lblInformationUsername";
            this.lblInformationUsername.Size = new System.Drawing.Size(143, 17);
            this.lblInformationUsername.TabIndex = 2;
            this.lblInformationUsername.Text = "You are logged in as:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(159, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(140, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "NameOfPersonLogin";
            // 
            // lblRoleInformation
            // 
            this.lblRoleInformation.AutoSize = true;
            this.lblRoleInformation.Location = new System.Drawing.Point(15, 98);
            this.lblRoleInformation.Name = "lblRoleInformation";
            this.lblRoleInformation.Size = new System.Drawing.Size(41, 17);
            this.lblRoleInformation.TabIndex = 5;
            this.lblRoleInformation.Text = "Role:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(159, 98);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(184, 17);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "RoleOfTheUserAppearHere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to MedTracker!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search Patient and \r\nAppointment Information";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPictureBox.Image = global::MedTracker.Properties.Resources.search1;
            this.searchPictureBox.Location = new System.Drawing.Point(16, 138);
            this.searchPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(160, 149);
            this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchPictureBox.TabIndex = 10;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchImage_click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::MedTracker.Properties.Resources.LOGO;
            this.logoPictureBox.Location = new System.Drawing.Point(424, 11);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(152, 116);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 9;
            this.logoPictureBox.TabStop = false;
            // 
            // reportPictureBox
            // 
            this.reportPictureBox.Image = global::MedTracker.Properties.Resources.report;
            this.reportPictureBox.Location = new System.Drawing.Point(251, 138);
            this.reportPictureBox.Name = "reportPictureBox";
            this.reportPictureBox.Size = new System.Drawing.Size(139, 149);
            this.reportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportPictureBox.TabIndex = 12;
            this.reportPictureBox.TabStop = false;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Location = new System.Drawing.Point(278, 299);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(81, 17);
            this.reportLabel.TabIndex = 13;
            this.reportLabel.Text = "Run Report";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 342);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.reportPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchPictureBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblRoleInformation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInformationUsername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedTracker Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInformationUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRoleInformation;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.PictureBox searchPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox reportPictureBox;
        private System.Windows.Forms.Label reportLabel;
    }
}