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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label systolicLabel;
            System.Windows.Forms.Label diastolicLabel;
            System.Windows.Forms.Label temperatureLabel;
            System.Windows.Forms.Label pulseLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label nurseFullNameLabel;
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.appointmentDateTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.vitalsGroupBox = new System.Windows.Forms.GroupBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.systolicTextBox = new System.Windows.Forms.TextBox();
            this.diastolicTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.nursesComboBox = new System.Windows.Forms.ComboBox();
            this.addVitalsButton = new System.Windows.Forms.Button();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clearVitalsButton = new System.Windows.Forms.Button();
            systolicLabel = new System.Windows.Forms.Label();
            diastolicLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            nurseFullNameLabel = new System.Windows.Forms.Label();
            this.vitalsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
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
            // vitalsGroupBox
            // 
            this.vitalsGroupBox.Controls.Add(this.clearVitalsButton);
            this.vitalsGroupBox.Controls.Add(this.addVitalsButton);
            this.vitalsGroupBox.Controls.Add(nurseFullNameLabel);
            this.vitalsGroupBox.Controls.Add(this.nursesComboBox);
            this.vitalsGroupBox.Controls.Add(diagnosisLabel);
            this.vitalsGroupBox.Controls.Add(this.diagnosisTextBox);
            this.vitalsGroupBox.Controls.Add(symptomsLabel);
            this.vitalsGroupBox.Controls.Add(this.symptomsTextBox);
            this.vitalsGroupBox.Controls.Add(pulseLabel);
            this.vitalsGroupBox.Controls.Add(this.pulseTextBox);
            this.vitalsGroupBox.Controls.Add(temperatureLabel);
            this.vitalsGroupBox.Controls.Add(this.temperatureTextBox);
            this.vitalsGroupBox.Controls.Add(diastolicLabel);
            this.vitalsGroupBox.Controls.Add(this.diastolicTextBox);
            this.vitalsGroupBox.Controls.Add(systolicLabel);
            this.vitalsGroupBox.Controls.Add(this.systolicTextBox);
            this.vitalsGroupBox.Location = new System.Drawing.Point(12, 88);
            this.vitalsGroupBox.Name = "vitalsGroupBox";
            this.vitalsGroupBox.Size = new System.Drawing.Size(358, 206);
            this.vitalsGroupBox.TabIndex = 6;
            this.vitalsGroupBox.TabStop = false;
            this.vitalsGroupBox.Text = "Vitals";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 72);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 7;
            // 
            // systolicLabel
            // 
            systolicLabel.AutoSize = true;
            systolicLabel.Location = new System.Drawing.Point(6, 38);
            systolicLabel.Name = "systolicLabel";
            systolicLabel.Size = new System.Drawing.Size(46, 13);
            systolicLabel.TabIndex = 2;
            systolicLabel.Text = "Systolic:";
            // 
            // systolicTextBox
            // 
            this.systolicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "systolic", true));
            this.systolicTextBox.Location = new System.Drawing.Point(98, 35);
            this.systolicTextBox.Name = "systolicTextBox";
            this.systolicTextBox.Size = new System.Drawing.Size(237, 20);
            this.systolicTextBox.TabIndex = 3;
            // 
            // diastolicLabel
            // 
            diastolicLabel.AutoSize = true;
            diastolicLabel.Location = new System.Drawing.Point(6, 60);
            diastolicLabel.Name = "diastolicLabel";
            diastolicLabel.Size = new System.Drawing.Size(50, 13);
            diastolicLabel.TabIndex = 4;
            diastolicLabel.Text = "Diastolic:";
            // 
            // diastolicTextBox
            // 
            this.diastolicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "diastolic", true));
            this.diastolicTextBox.Location = new System.Drawing.Point(98, 57);
            this.diastolicTextBox.Name = "diastolicTextBox";
            this.diastolicTextBox.Size = new System.Drawing.Size(237, 20);
            this.diastolicTextBox.TabIndex = 5;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(6, 82);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(70, 13);
            temperatureLabel.TabIndex = 6;
            temperatureLabel.Text = "Temperature:";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "temperature", true));
            this.temperatureTextBox.Location = new System.Drawing.Point(98, 79);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(237, 20);
            this.temperatureTextBox.TabIndex = 7;
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new System.Drawing.Point(6, 104);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(36, 13);
            pulseLabel.TabIndex = 8;
            pulseLabel.Text = "Pulse:";
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "pulse", true));
            this.pulseTextBox.Location = new System.Drawing.Point(98, 101);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(237, 20);
            this.pulseTextBox.TabIndex = 9;
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(6, 126);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(58, 13);
            symptomsLabel.TabIndex = 10;
            symptomsLabel.Text = "Symptoms:";
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(98, 123);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(237, 20);
            this.symptomsTextBox.TabIndex = 11;
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(6, 148);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 12;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(98, 145);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(237, 20);
            this.diagnosisTextBox.TabIndex = 13;
            // 
            // nurseFullNameLabel
            // 
            nurseFullNameLabel.AutoSize = true;
            nurseFullNameLabel.Location = new System.Drawing.Point(6, 16);
            nurseFullNameLabel.Name = "nurseFullNameLabel";
            nurseFullNameLabel.Size = new System.Drawing.Size(86, 13);
            nurseFullNameLabel.TabIndex = 13;
            nurseFullNameLabel.Text = "Attending Nurse:";
            // 
            // nursesComboBox
            // 
            this.nursesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "nurseFullName", true));
            this.nursesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nursesComboBox.FormattingEnabled = true;
            this.nursesComboBox.Location = new System.Drawing.Point(98, 13);
            this.nursesComboBox.Name = "nursesComboBox";
            this.nursesComboBox.Size = new System.Drawing.Size(237, 21);
            this.nursesComboBox.TabIndex = 14;
            // 
            // addVitalsButton
            // 
            this.addVitalsButton.Location = new System.Drawing.Point(260, 171);
            this.addVitalsButton.Name = "addVitalsButton";
            this.addVitalsButton.Size = new System.Drawing.Size(75, 23);
            this.addVitalsButton.TabIndex = 15;
            this.addVitalsButton.Text = "Add Vitals";
            this.addVitalsButton.UseVisualStyleBackColor = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(MedTracker.Model.Appointment);
            // 
            // clearVitalsButton
            // 
            this.clearVitalsButton.Location = new System.Drawing.Point(179, 171);
            this.clearVitalsButton.Name = "clearVitalsButton";
            this.clearVitalsButton.Size = new System.Drawing.Size(75, 23);
            this.clearVitalsButton.TabIndex = 16;
            this.clearVitalsButton.Text = "Clear";
            this.clearVitalsButton.UseVisualStyleBackColor = true;
            this.clearVitalsButton.Click += new System.EventHandler(this.clearVitalsButton_Click);
            // 
            // CheckUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 633);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.vitalsGroupBox);
            this.Controls.Add(this.doctorNameTextBox);
            this.Controls.Add(this.patientNameTextBox);
            this.Controls.Add(this.appointmentDateTextBox);
            this.Controls.Add(this.appointmentDateLabel);
            this.Controls.Add(this.doctorNameLabel);
            this.Controls.Add(this.patientNameLabel);
            this.Name = "CheckUpForm";
            this.Text = "Check Up";
            this.Load += new System.EventHandler(this.CheckUpForm_Load);
            this.vitalsGroupBox.ResumeLayout(false);
            this.vitalsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox vitalsGroupBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ComboBox nursesComboBox;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox diastolicTextBox;
        private System.Windows.Forms.TextBox systolicTextBox;
        private System.Windows.Forms.Button addVitalsButton;
        private System.Windows.Forms.Button clearVitalsButton;
    }
}