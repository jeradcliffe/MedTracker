namespace MedTracker.View
{
    partial class PatientSearch
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
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newPatientButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentsButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.updatePatientColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(17, 18);
            dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(91, 17);
            dateOfBirthLabel.TabIndex = 1;
            dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(708, 18);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(80, 17);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(359, 18);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(80, 17);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1072, 12);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 28);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Enter += new System.EventHandler(this.searchButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.messageLabel.Location = new System.Drawing.Point(17, 55);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 17);
            this.messageLabel.TabIndex = 9;
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(117, 15);
            this.dateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(232, 22);
            this.dateOfBirthDateTimePicker.TabIndex = 2;
            this.dateOfBirthDateTimePicker.ValueChanged += new System.EventHandler(this.dateOfBirthDateTimePicker_ValueChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(792, 15);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(256, 22);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(443, 15);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(256, 22);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1180, 12);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AllowUserToAddRows = false;
            this.patientDataGridView.AllowUserToDeleteRows = false;
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.appointmentsButton,
            this.updatePatientColumn,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.patientDataGridView.DataSource = this.personBindingSource;
            this.patientDataGridView.Location = new System.Drawing.Point(16, 75);
            this.patientDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.ReadOnly = true;
            this.patientDataGridView.Size = new System.Drawing.Size(1391, 452);
            this.patientDataGridView.TabIndex = 10;
            this.patientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientDataGridView_CellContentClick);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(MedTracker.Model.Person);
            // 
            // newPatientButton
            // 
            this.newPatientButton.Location = new System.Drawing.Point(1288, 12);
            this.newPatientButton.Margin = new System.Windows.Forms.Padding(4);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(100, 28);
            this.newPatientButton.TabIndex = 11;
            this.newPatientButton.Text = "New Patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.newPatientButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "peopleID";
            this.dataGridViewTextBoxColumn1.HeaderText = "peopleID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "lastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dateOfBirth";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Of Birth";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "streetAddress";
            this.dataGridViewTextBoxColumn5.HeaderText = "Street Address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "state";
            this.dataGridViewTextBoxColumn7.HeaderText = "State";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "zip";
            this.dataGridViewTextBoxColumn8.HeaderText = "Zip";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "phoneNumber";
            this.dataGridViewTextBoxColumn9.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // appointmentsButton
            // 
            this.appointmentsButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.appointmentsButton.HeaderText = "Appointment";
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.ReadOnly = true;
            this.appointmentsButton.Text = "Create/View/Edit";
            this.appointmentsButton.UseColumnTextForButtonValue = true;
            this.appointmentsButton.Width = 93;
            // 
            // updatePatientColumn
            // 
            this.updatePatientColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.updatePatientColumn.HeaderText = "Patient Info";
            this.updatePatientColumn.Name = "updatePatientColumn";
            this.updatePatientColumn.ReadOnly = true;
            this.updatePatientColumn.Text = "Update";
            this.updatePatientColumn.UseColumnTextForButtonValue = true;
            this.updatePatientColumn.Width = 77;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "patientID";
            this.dataGridViewTextBoxColumn10.HeaderText = "patientID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "doctorID";
            this.dataGridViewTextBoxColumn11.HeaderText = "doctorID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "nurseID";
            this.dataGridViewTextBoxColumn12.HeaderText = "nurseID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "administratorID";
            this.dataGridViewTextBoxColumn13.HeaderText = "administratorID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // PatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 542);
            this.Controls.Add(this.newPatientButton);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(dateOfBirthLabel);
            this.Controls.Add(this.dateOfBirthDateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PatientSearch";
            this.Text = "Patient Search";
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewButtonColumn appointmentsButton;
        private System.Windows.Forms.DataGridViewButtonColumn updatePatientColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
    }
}