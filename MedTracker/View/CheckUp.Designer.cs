namespace MedTracker.View
{
    partial class CheckUpForm
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
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.appointmentDateTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // patientNameLabel
            // 
            this.patientNameLabel.AutoSize = true;
            this.patientNameLabel.Location = new System.Drawing.Point(12, 31);
            this.patientNameLabel.Name = "patientNameLabel";
            this.patientNameLabel.Size = new System.Drawing.Size(43, 13);
            this.patientNameLabel.TabIndex = 0;
            this.patientNameLabel.Text = "Patient:";
            // 
            // doctorNameLabel
            // 
            this.doctorNameLabel.AutoSize = true;
            this.doctorNameLabel.Location = new System.Drawing.Point(12, 53);
            this.doctorNameLabel.Name = "doctorNameLabel";
            this.doctorNameLabel.Size = new System.Drawing.Size(42, 13);
            this.doctorNameLabel.TabIndex = 1;
            this.doctorNameLabel.Text = "Doctor:";
            // 
            // appointmentDateLabel
            // 
            this.appointmentDateLabel.AutoSize = true;
            this.appointmentDateLabel.Location = new System.Drawing.Point(12, 9);
            this.appointmentDateLabel.Name = "appointmentDateLabel";
            this.appointmentDateLabel.Size = new System.Drawing.Size(95, 13);
            this.appointmentDateLabel.TabIndex = 2;
            this.appointmentDateLabel.Text = "Appointment Date:";
            // 
            // appointmentDateTextBox
            // 
            this.appointmentDateTextBox.Location = new System.Drawing.Point(113, 6);
            this.appointmentDateTextBox.Name = "appointmentDateTextBox";
            this.appointmentDateTextBox.ReadOnly = true;
            this.appointmentDateTextBox.Size = new System.Drawing.Size(234, 20);
            this.appointmentDateTextBox.TabIndex = 3;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(113, 28);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.ReadOnly = true;
            this.patientNameTextBox.Size = new System.Drawing.Size(234, 20);
            this.patientNameTextBox.TabIndex = 4;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(113, 50);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.ReadOnly = true;
            this.doctorNameTextBox.Size = new System.Drawing.Size(234, 20);
            this.doctorNameTextBox.TabIndex = 5;
            // 
            // CheckUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 633);
            this.Controls.Add(this.doctorNameTextBox);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.appointmentDateTextBox);
            this.Controls.Add(this.appointmentDateLabel);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Name = "CheckUpForm";
            this.Text = "Check Up";
            this.Load += new System.EventHandler(this.CheckUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientNameLabel;
        private System.Windows.Forms.Label doctorNameLabel;
        private System.Windows.Forms.Label appointmentDateLabel;
        private System.Windows.Forms.TextBox appointmentDateTextBox;
        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.TextBox doctorNameTextBox;
    }
}