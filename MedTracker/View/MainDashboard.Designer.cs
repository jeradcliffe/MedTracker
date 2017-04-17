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
            this.searchLabel = new System.Windows.Forms.Label();
            this.reportLabel = new System.Windows.Forms.Label();
            this.reportPictureBox = new System.Windows.Forms.PictureBox();
            this.searchPictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(119, 44);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(129, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "UsernameWillAppearHere";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // lblInformationUsername
            // 
            this.lblInformationUsername.AutoSize = true;
            this.lblInformationUsername.Location = new System.Drawing.Point(11, 44);
            this.lblInformationUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformationUsername.Name = "lblInformationUsername";
            this.lblInformationUsername.Size = new System.Drawing.Size(107, 13);
            this.lblInformationUsername.TabIndex = 2;
            this.lblInformationUsername.Text = "You are logged in as:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(119, 62);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(105, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "NameOfPersonLogin";
            // 
            // lblRoleInformation
            // 
            this.lblRoleInformation.AutoSize = true;
            this.lblRoleInformation.Location = new System.Drawing.Point(11, 80);
            this.lblRoleInformation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoleInformation.Name = "lblRoleInformation";
            this.lblRoleInformation.Size = new System.Drawing.Size(32, 13);
            this.lblRoleInformation.TabIndex = 5;
            this.lblRoleInformation.Text = "Role:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(119, 80);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(138, 13);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "RoleOfTheUserAppearHere";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome to MedTracker!";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 236);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(121, 26);
            this.searchLabel.TabIndex = 11;
            this.searchLabel.Text = "Search Patient and \r\nAppointment Information";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchLabel.Visible = false;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Location = new System.Drawing.Point(35, 244);
            this.reportLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(62, 13);
            this.reportLabel.TabIndex = 13;
            this.reportLabel.Text = "Run Report";
            this.reportLabel.Visible = false;
            // 
            // reportPictureBox
            // 
            this.reportPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportPictureBox.Image = global::MedTracker.Properties.Resources.report;
            this.reportPictureBox.Location = new System.Drawing.Point(15, 113);
            this.reportPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.reportPictureBox.Name = "reportPictureBox";
            this.reportPictureBox.Size = new System.Drawing.Size(104, 121);
            this.reportPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportPictureBox.TabIndex = 12;
            this.reportPictureBox.TabStop = false;
            this.reportPictureBox.Visible = false;
            this.reportPictureBox.Click += new System.EventHandler(this.reportPictureBox_Click);
            // 
            // searchPictureBox
            // 
            this.searchPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPictureBox.Image = global::MedTracker.Properties.Resources.search1;
            this.searchPictureBox.Location = new System.Drawing.Point(12, 112);
            this.searchPictureBox.Name = "searchPictureBox";
            this.searchPictureBox.Size = new System.Drawing.Size(120, 121);
            this.searchPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchPictureBox.TabIndex = 10;
            this.searchPictureBox.TabStop = false;
            this.searchPictureBox.Visible = false;
            this.searchPictureBox.Click += new System.EventHandler(this.searchImage_click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::MedTracker.Properties.Resources.LOGO;
            this.logoPictureBox.Location = new System.Drawing.Point(318, 9);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(114, 94);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 9;
            this.logoPictureBox.TabStop = false;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 278);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.reportPictureBox);
            this.Controls.Add(this.searchLabel);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedTracker Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainDashboard_FormClosed);
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
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
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.PictureBox reportPictureBox;
        private System.Windows.Forms.Label reportLabel;
    }
}