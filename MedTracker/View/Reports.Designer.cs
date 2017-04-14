namespace MedTracker.View
{
    partial class Reports
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
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.runReportButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(99, 90);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDateTimePicker.TabIndex = 0;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(347, 90);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endDateTimePicker.TabIndex = 1;
            // 
            // runReportButton
            // 
            this.runReportButton.Location = new System.Drawing.Point(591, 84);
            this.runReportButton.Name = "runReportButton";
            this.runReportButton.Size = new System.Drawing.Size(96, 28);
            this.runReportButton.TabIndex = 2;
            this.runReportButton.Text = "Run Report";
            this.runReportButton.UseVisualStyleBackColor = true;
            this.runReportButton.Click += new System.EventHandler(this.runReportButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(722, 84);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 28);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(163, 70);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 17);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(413, 70);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(67, 17);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date";
            // 
            // reportViewer
            // 
            this.reportViewer.Location = new System.Drawing.Point(13, 130);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(884, 536);
            this.reportViewer.TabIndex = 6;
            // 
            // reportTitleLabel
            // 
            this.reportTitleLabel.AutoSize = true;
            this.reportTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTitleLabel.Location = new System.Drawing.Point(239, 9);
            this.reportTitleLabel.Name = "reportTitleLabel";
            this.reportTitleLabel.Size = new System.Drawing.Size(429, 29);
            this.reportTitleLabel.TabIndex = 7;
            this.reportTitleLabel.Text = "Most Performed Tests During Dates";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 678);
            this.Controls.Add(this.reportTitleLabel);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.runReportButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Name = "Reports";
            this.Text = "Reports Form";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button runReportButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Label reportTitleLabel;
    }
}