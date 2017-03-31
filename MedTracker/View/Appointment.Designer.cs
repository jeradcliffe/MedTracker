namespace MedTracker.View
{
    partial class AppointmentForm
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(4, 11);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(4, 38);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(4, 90);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(79, 13);
            cityLabel.TabIndex = 5;
            cityLabel.Text = "City, State, Zip:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(4, 64);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 11;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "firstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(87, 8);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(282, 20);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(MedTracker.Model.Person);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "lastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(87, 35);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(282, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(87, 87);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(138, 20);
            this.cityTextBox.TabIndex = 6;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(231, 87);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(48, 20);
            this.stateTextBox.TabIndex = 8;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(285, 87);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.ReadOnly = true;
            this.zipTextBox.Size = new System.Drawing.Size(84, 20);
            this.zipTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(MedTracker.Model.Appointment);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(87, 61);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.ReadOnly = true;
            this.phoneNumberTextBox.Size = new System.Drawing.Size(282, 20);
            this.phoneNumberTextBox.TabIndex = 12;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 371);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "AppointmentForm";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
    }
}