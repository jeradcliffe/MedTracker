namespace MedTracker.View
{
    partial class NewPatientForm
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
            this.createPatientButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.stateLabel = new System.Windows.Forms.Label();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.areaCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneFirstThreeDigitsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneLastFourDigitsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createPatientButton
            // 
            this.createPatientButton.Location = new System.Drawing.Point(102, 335);
            this.createPatientButton.Name = "createPatientButton";
            this.createPatientButton.Size = new System.Drawing.Size(82, 29);
            this.createPatientButton.TabIndex = 21;
            this.createPatientButton.Text = "Create";
            this.createPatientButton.UseVisualStyleBackColor = true;
            this.createPatientButton.Click += new System.EventHandler(this.createPatientButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(348, 335);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 29);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(104, 29);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(105, 58);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(95, 116);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(91, 17);
            this.dobLabel.TabIndex = 4;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(80, 144);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(106, 17);
            this.streetAddressLabel.TabIndex = 5;
            this.streetAddressLabel.Text = "Street Address:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(150, 172);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 17);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "City:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(152, 231);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(32, 17);
            this.zipLabel.TabIndex = 7;
            this.zipLabel.Text = "Zip:";
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(77, 259);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(107, 17);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(191, 26);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(241, 22);
            this.firstNameTextBox.TabIndex = 9;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(191, 53);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(241, 22);
            this.lastNameTextBox.TabIndex = 10;
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(191, 144);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(241, 22);
            this.streetAddressTextBox.TabIndex = 13;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(191, 171);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(241, 22);
            this.cityTextBox.TabIndex = 14;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(191, 228);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(241, 22);
            this.zipTextBox.TabIndex = 16;
            this.zipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipTextBox_KeyPress);
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Location = new System.Drawing.Point(191, 114);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.dobDateTimePicker.TabIndex = 12;
            this.dobDateTimePicker.ValueChanged += new System.EventHandler(this.dobDateTimePicker_ValueChanged);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(140, 202);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 17);
            this.stateLabel.TabIndex = 17;
            this.stateLabel.Text = "State:";
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(191, 286);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(241, 22);
            this.ssnTextBox.TabIndex = 20;
            this.ssnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ssnTextBox_KeyPress);
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(25, 289);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(159, 17);
            this.ssnLabel.TabIndex = 19;
            this.ssnLabel.Text = "Social Security Number:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(125, 86);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(60, 17);
            this.genderLabel.TabIndex = 21;
            this.genderLabel.Text = "Gender:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(191, 199);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(241, 24);
            this.stateComboBox.TabIndex = 15;
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(191, 83);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(241, 24);
            this.genderComboBox.TabIndex = 11;
            // 
            // areaCodeTextBox
            // 
            this.areaCodeTextBox.Location = new System.Drawing.Point(191, 256);
            this.areaCodeTextBox.Name = "areaCodeTextBox";
            this.areaCodeTextBox.Size = new System.Drawing.Size(48, 22);
            this.areaCodeTextBox.TabIndex = 17;
            this.areaCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.areaCodeTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "-";
            // 
            // phoneFirstThreeDigitsTextBox
            // 
            this.phoneFirstThreeDigitsTextBox.Location = new System.Drawing.Point(264, 256);
            this.phoneFirstThreeDigitsTextBox.Name = "phoneFirstThreeDigitsTextBox";
            this.phoneFirstThreeDigitsTextBox.Size = new System.Drawing.Size(48, 22);
            this.phoneFirstThreeDigitsTextBox.TabIndex = 18;
            this.phoneFirstThreeDigitsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneFirstThreeDigitsTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "-";
            // 
            // phoneLastFourDigitsTextBox
            // 
            this.phoneLastFourDigitsTextBox.Location = new System.Drawing.Point(337, 256);
            this.phoneLastFourDigitsTextBox.Name = "phoneLastFourDigitsTextBox";
            this.phoneLastFourDigitsTextBox.Size = new System.Drawing.Size(95, 22);
            this.phoneLastFourDigitsTextBox.TabIndex = 19;
            this.phoneLastFourDigitsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneLastFourDigitsTextBox_KeyPress);
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 389);
            this.Controls.Add(this.phoneLastFourDigitsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phoneFirstThreeDigitsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.areaCodeTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.streetAddressTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.streetAddressLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createPatientButton);
            this.Name = "NewPatientForm";
            this.Text = "New Patient";
            this.Load += new System.EventHandler(this.NewPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createPatientButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox streetAddressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox areaCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneFirstThreeDigitsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneLastFourDigitsTextBox;
    }
}