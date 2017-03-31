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
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(243, 32);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1055, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInformationUsername
            // 
            this.lblInformationUsername.AutoSize = true;
            this.lblInformationUsername.Location = new System.Drawing.Point(29, 32);
            this.lblInformationUsername.Name = "lblInformationUsername";
            this.lblInformationUsername.Size = new System.Drawing.Size(217, 25);
            this.lblInformationUsername.TabIndex = 2;
            this.lblInformationUsername.Text = "You are logged in as:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 807);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInformationUsername);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUsername);
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedTracker Dashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInformationUsername;
        private System.Windows.Forms.Label label2;
    }
}