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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uspmostPerformedTestsDuringDatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CS6232_g3DataSet = new MedTracker._CS6232_g3DataSet();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.runReportButton = new System.Windows.Forms.Button();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportTitleLabel = new System.Windows.Forms.Label();
            this.usp_mostPerformedTestsDuringDatesTableAdapter = new MedTracker._CS6232_g3DataSetTableAdapters.usp_mostPerformedTestsDuringDatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uspmostPerformedTestsDuringDatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uspmostPerformedTestsDuringDatesBindingSource
            // 
            this.uspmostPerformedTestsDuringDatesBindingSource.DataMember = "usp_mostPerformedTestsDuringDates";
            this.uspmostPerformedTestsDuringDatesBindingSource.DataSource = this._CS6232_g3DataSet;
            // 
            // _CS6232_g3DataSet
            // 
            this._CS6232_g3DataSet.DataSetName = "_CS6232_g3DataSet";
            this._CS6232_g3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(117, 63);
            this.startDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.startDateTimePicker.TabIndex = 0;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(303, 63);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.endDateTimePicker.TabIndex = 1;
            // 
            // runReportButton
            // 
            this.runReportButton.Location = new System.Drawing.Point(491, 64);
            this.runReportButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.runReportButton.Name = "runReportButton";
            this.runReportButton.Size = new System.Drawing.Size(72, 23);
            this.runReportButton.TabIndex = 2;
            this.runReportButton.Text = "Run Report";
            this.runReportButton.UseVisualStyleBackColor = true;
            this.runReportButton.Click += new System.EventHandler(this.runReportButton_Click);
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(114, 48);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 4;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(300, 48);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 5;
            this.endDateLabel.Text = "End Date";
            // 
            // reportViewer
            // 
            reportDataSource1.Name = "MostPerformedTestsDuringDatesDataSet";
            reportDataSource1.Value = this.uspmostPerformedTestsDuringDatesBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "MedTracker.MostPerformedTestsDuringDatesReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(10, 106);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(667, 436);
            this.reportViewer.TabIndex = 6;
            // 
            // reportTitleLabel
            // 
            this.reportTitleLabel.AutoSize = true;
            this.reportTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTitleLabel.Location = new System.Drawing.Point(179, 7);
            this.reportTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reportTitleLabel.Name = "reportTitleLabel";
            this.reportTitleLabel.Size = new System.Drawing.Size(339, 24);
            this.reportTitleLabel.TabIndex = 7;
            this.reportTitleLabel.Text = "Most Performed Tests During Dates";
            // 
            // usp_mostPerformedTestsDuringDatesTableAdapter
            // 
            this.usp_mostPerformedTestsDuringDatesTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 551);
            this.Controls.Add(this.reportTitleLabel);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.runReportButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Reports";
            this.Text = "Reports Form";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uspmostPerformedTestsDuringDatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button runReportButton;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Label reportTitleLabel;
        private System.Windows.Forms.BindingSource uspmostPerformedTestsDuringDatesBindingSource;
        private _CS6232_g3DataSet _CS6232_g3DataSet;
        private _CS6232_g3DataSetTableAdapters.usp_mostPerformedTestsDuringDatesTableAdapter usp_mostPerformedTestsDuringDatesTableAdapter;
    }
}