﻿namespace MedTracker.View
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
            System.Windows.Forms.Label testCodeLabel;
            System.Windows.Forms.Label testDateLabel;
            System.Windows.Forms.Label resultsLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.patientNameLabel = new System.Windows.Forms.Label();
            this.doctorNameLabel = new System.Windows.Forms.Label();
            this.appointmentDateLabel = new System.Windows.Forms.Label();
            this.appointmentDateTextBox = new System.Windows.Forms.TextBox();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.doctorNameTextBox = new System.Windows.Forms.TextBox();
            this.vitalsGroupBox = new System.Windows.Forms.GroupBox();
            this.clearVitalsButton = new System.Windows.Forms.Button();
            this.vitalsMessageLabel = new System.Windows.Forms.Label();
            this.addVitalsButton = new System.Windows.Forms.Button();
            this.nursesComboBox = new System.Windows.Forms.ComboBox();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.diastolicTextBox = new System.Windows.Forms.TextBox();
            this.systolicTextBox = new System.Windows.Forms.TextBox();
            this.testsGroupBox = new System.Windows.Forms.GroupBox();
            this.testsMessageLabel = new System.Windows.Forms.Label();
            this.clearTestsButton = new System.Windows.Forms.Button();
            this.orderTestButton = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.testDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.testComboBox = new System.Windows.Forms.ComboBox();
            this.testsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            systolicLabel = new System.Windows.Forms.Label();
            diastolicLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            nurseFullNameLabel = new System.Windows.Forms.Label();
            testCodeLabel = new System.Windows.Forms.Label();
            testDateLabel = new System.Windows.Forms.Label();
            resultsLabel = new System.Windows.Forms.Label();
            this.vitalsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.testsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // diastolicLabel
            // 
            diastolicLabel.AutoSize = true;
            diastolicLabel.Location = new System.Drawing.Point(6, 60);
            diastolicLabel.Name = "diastolicLabel";
            diastolicLabel.Size = new System.Drawing.Size(50, 13);
            diastolicLabel.TabIndex = 4;
            diastolicLabel.Text = "Diastolic:";
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
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new System.Drawing.Point(6, 104);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(36, 13);
            pulseLabel.TabIndex = 8;
            pulseLabel.Text = "Pulse:";
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
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(6, 148);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 12;
            diagnosisLabel.Text = "Diagnosis:";
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
            // testCodeLabel
            // 
            testCodeLabel.AutoSize = true;
            testCodeLabel.Location = new System.Drawing.Point(10, 22);
            testCodeLabel.Name = "testCodeLabel";
            testCodeLabel.Size = new System.Drawing.Size(36, 13);
            testCodeLabel.TabIndex = 1;
            testCodeLabel.Text = "Tests:";
            // 
            // testDateLabel
            // 
            testDateLabel.AutoSize = true;
            testDateLabel.Location = new System.Drawing.Point(10, 46);
            testDateLabel.Name = "testDateLabel";
            testDateLabel.Size = new System.Drawing.Size(57, 13);
            testDateLabel.TabIndex = 3;
            testDateLabel.Text = "Test Date:";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new System.Drawing.Point(10, 70);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new System.Drawing.Size(45, 13);
            resultsLabel.TabIndex = 5;
            resultsLabel.Text = "Results:";
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
            this.doctorNameLabel.Size = new System.Drawing.Size(90, 13);
            this.doctorNameLabel.TabIndex = 1;
            this.doctorNameLabel.Text = "Attending Doctor:";
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
            this.appointmentDateTextBox.Size = new System.Drawing.Size(290, 20);
            this.appointmentDateTextBox.TabIndex = 3;
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(113, 28);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.ReadOnly = true;
            this.patientNameTextBox.Size = new System.Drawing.Size(290, 20);
            this.patientNameTextBox.TabIndex = 4;
            // 
            // doctorNameTextBox
            // 
            this.doctorNameTextBox.Location = new System.Drawing.Point(113, 50);
            this.doctorNameTextBox.Name = "doctorNameTextBox";
            this.doctorNameTextBox.ReadOnly = true;
            this.doctorNameTextBox.Size = new System.Drawing.Size(290, 20);
            this.doctorNameTextBox.TabIndex = 5;
            // 
            // vitalsGroupBox
            // 
            this.vitalsGroupBox.Controls.Add(this.clearVitalsButton);
            this.vitalsGroupBox.Controls.Add(this.vitalsMessageLabel);
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
            this.vitalsGroupBox.Size = new System.Drawing.Size(404, 206);
            this.vitalsGroupBox.TabIndex = 6;
            this.vitalsGroupBox.TabStop = false;
            this.vitalsGroupBox.Text = "Vitals";
            // 
            // clearVitalsButton
            // 
            this.clearVitalsButton.Location = new System.Drawing.Point(316, 171);
            this.clearVitalsButton.Name = "clearVitalsButton";
            this.clearVitalsButton.Size = new System.Drawing.Size(75, 23);
            this.clearVitalsButton.TabIndex = 16;
            this.clearVitalsButton.Text = "Clear";
            this.clearVitalsButton.UseVisualStyleBackColor = true;
            this.clearVitalsButton.Click += new System.EventHandler(this.clearVitalsButton_Click);
            // 
            // vitalsMessageLabel
            // 
            this.vitalsMessageLabel.AutoSize = true;
            this.vitalsMessageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.vitalsMessageLabel.Location = new System.Drawing.Point(11, 176);
            this.vitalsMessageLabel.Name = "vitalsMessageLabel";
            this.vitalsMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.vitalsMessageLabel.TabIndex = 7;
            // 
            // addVitalsButton
            // 
            this.addVitalsButton.Location = new System.Drawing.Point(235, 171);
            this.addVitalsButton.Name = "addVitalsButton";
            this.addVitalsButton.Size = new System.Drawing.Size(75, 23);
            this.addVitalsButton.TabIndex = 15;
            this.addVitalsButton.Text = "Add Vitals";
            this.addVitalsButton.UseVisualStyleBackColor = true;
            this.addVitalsButton.Click += new System.EventHandler(this.addVitalsButton_Click);
            // 
            // nursesComboBox
            // 
            this.nursesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "nurseFullName", true));
            this.nursesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nursesComboBox.FormattingEnabled = true;
            this.nursesComboBox.Location = new System.Drawing.Point(98, 13);
            this.nursesComboBox.Name = "nursesComboBox";
            this.nursesComboBox.Size = new System.Drawing.Size(293, 21);
            this.nursesComboBox.TabIndex = 14;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(MedTracker.Model.Appointment);
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(98, 145);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(293, 20);
            this.diagnosisTextBox.TabIndex = 13;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(98, 123);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(293, 20);
            this.symptomsTextBox.TabIndex = 11;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "pulse", true));
            this.pulseTextBox.Location = new System.Drawing.Point(98, 101);
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(293, 20);
            this.pulseTextBox.TabIndex = 9;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "temperature", true));
            this.temperatureTextBox.Location = new System.Drawing.Point(98, 79);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(293, 20);
            this.temperatureTextBox.TabIndex = 7;
            // 
            // diastolicTextBox
            // 
            this.diastolicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "diastolic", true));
            this.diastolicTextBox.Location = new System.Drawing.Point(98, 57);
            this.diastolicTextBox.Name = "diastolicTextBox";
            this.diastolicTextBox.Size = new System.Drawing.Size(293, 20);
            this.diastolicTextBox.TabIndex = 5;
            // 
            // systolicTextBox
            // 
            this.systolicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "systolic", true));
            this.systolicTextBox.Location = new System.Drawing.Point(98, 35);
            this.systolicTextBox.Name = "systolicTextBox";
            this.systolicTextBox.Size = new System.Drawing.Size(293, 20);
            this.systolicTextBox.TabIndex = 3;
            // 
            // testsGroupBox
            // 
            this.testsGroupBox.Controls.Add(this.testsMessageLabel);
            this.testsGroupBox.Controls.Add(this.clearTestsButton);
            this.testsGroupBox.Controls.Add(this.orderTestButton);
            this.testsGroupBox.Controls.Add(resultsLabel);
            this.testsGroupBox.Controls.Add(this.resultsTextBox);
            this.testsGroupBox.Controls.Add(testDateLabel);
            this.testsGroupBox.Controls.Add(this.testDateDateTimePicker);
            this.testsGroupBox.Controls.Add(testCodeLabel);
            this.testsGroupBox.Controls.Add(this.testComboBox);
            this.testsGroupBox.Controls.Add(this.testsDataGridView);
            this.testsGroupBox.Location = new System.Drawing.Point(13, 301);
            this.testsGroupBox.Name = "testsGroupBox";
            this.testsGroupBox.Size = new System.Drawing.Size(410, 357);
            this.testsGroupBox.TabIndex = 8;
            this.testsGroupBox.TabStop = false;
            this.testsGroupBox.Text = "Tests";
            // 
            // testsMessageLabel
            // 
            this.testsMessageLabel.AutoSize = true;
            this.testsMessageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.testsMessageLabel.Location = new System.Drawing.Point(10, 96);
            this.testsMessageLabel.Name = "testsMessageLabel";
            this.testsMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.testsMessageLabel.TabIndex = 9;
            // 
            // clearTestsButton
            // 
            this.clearTestsButton.Location = new System.Drawing.Point(315, 90);
            this.clearTestsButton.Name = "clearTestsButton";
            this.clearTestsButton.Size = new System.Drawing.Size(75, 23);
            this.clearTestsButton.TabIndex = 8;
            this.clearTestsButton.Text = "Clear";
            this.clearTestsButton.UseVisualStyleBackColor = true;
            this.clearTestsButton.Click += new System.EventHandler(this.clearTestsButton_Click);
            // 
            // orderTestButton
            // 
            this.orderTestButton.Location = new System.Drawing.Point(234, 91);
            this.orderTestButton.Name = "orderTestButton";
            this.orderTestButton.Size = new System.Drawing.Size(75, 23);
            this.orderTestButton.TabIndex = 7;
            this.orderTestButton.Text = "Order Test";
            this.orderTestButton.UseVisualStyleBackColor = true;
            this.orderTestButton.Click += new System.EventHandler(this.orderTestButton_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "results", true));
            this.resultsTextBox.Location = new System.Drawing.Point(97, 64);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(293, 20);
            this.resultsTextBox.TabIndex = 6;
            // 
            // testDateDateTimePicker
            // 
            this.testDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.appointmentBindingSource, "testDate", true));
            this.testDateDateTimePicker.Location = new System.Drawing.Point(97, 42);
            this.testDateDateTimePicker.Name = "testDateDateTimePicker";
            this.testDateDateTimePicker.Size = new System.Drawing.Size(293, 20);
            this.testDateDateTimePicker.TabIndex = 4;
            // 
            // testComboBox
            // 
            this.testComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.appointmentBindingSource, "testCode", true));
            this.testComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.testComboBox.FormattingEnabled = true;
            this.testComboBox.Location = new System.Drawing.Point(97, 19);
            this.testComboBox.Name = "testComboBox";
            this.testComboBox.Size = new System.Drawing.Size(293, 21);
            this.testComboBox.TabIndex = 2;
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.AllowUserToAddRows = false;
            this.testsDataGridView.AllowUserToDeleteRows = false;
            this.testsDataGridView.AutoGenerateColumns = false;
            this.testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.testsDataGridView.DataSource = this.appointmentBindingSource;
            this.testsDataGridView.Location = new System.Drawing.Point(6, 120);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.ReadOnly = true;
            this.testsDataGridView.Size = new System.Drawing.Size(384, 231);
            this.testsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn1.HeaderText = "date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "doctorID";
            this.dataGridViewTextBoxColumn2.HeaderText = "doctorID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "patientID";
            this.dataGridViewTextBoxColumn3.HeaderText = "patientID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "reason";
            this.dataGridViewTextBoxColumn4.HeaderText = "reason";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "testCode";
            this.dataGridViewTextBoxColumn5.HeaderText = "Test Code";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "testDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "Test Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "results";
            this.dataGridViewTextBoxColumn7.HeaderText = "Results";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "nurseID";
            this.dataGridViewTextBoxColumn8.HeaderText = "nurseID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "systolic";
            this.dataGridViewTextBoxColumn9.HeaderText = "systolic";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "diastolic";
            this.dataGridViewTextBoxColumn10.HeaderText = "diastolic";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "temperature";
            this.dataGridViewTextBoxColumn11.HeaderText = "temperature";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "pulse";
            this.dataGridViewTextBoxColumn12.HeaderText = "pulse";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "symptoms";
            this.dataGridViewTextBoxColumn13.HeaderText = "symptoms";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "diagnosis";
            this.dataGridViewTextBoxColumn14.HeaderText = "diagnosis";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "doctorFullName";
            this.dataGridViewTextBoxColumn15.HeaderText = "doctorFullName";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "nurseFullName";
            this.dataGridViewTextBoxColumn16.HeaderText = "nurseFullName";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // CheckUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 658);
            this.Controls.Add(this.testsGroupBox);
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
            this.testsGroupBox.ResumeLayout(false);
            this.testsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
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
        private System.Windows.Forms.Label vitalsMessageLabel;
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
        private System.Windows.Forms.GroupBox testsGroupBox;
        private System.Windows.Forms.DataGridView testsDataGridView;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.DateTimePicker testDateDateTimePicker;
        private System.Windows.Forms.ComboBox testComboBox;
        private System.Windows.Forms.Button clearTestsButton;
        private System.Windows.Forms.Button orderTestButton;
        private System.Windows.Forms.Label testsMessageLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}