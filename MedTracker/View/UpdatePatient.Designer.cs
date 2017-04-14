namespace MedTracker.View
{
    partial class UpdatePatientForm
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
            this.stateLabel = new System.Windows.Forms.Label();
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.zipLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetAddressLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updatePatientButton = new System.Windows.Forms.Button();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.phoneLastFourDigitsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneFirstThreeDigitsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.areaCodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(135, 201);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 17);
            this.stateLabel.TabIndex = 35;
            this.stateLabel.Text = "State:";
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.Location = new System.Drawing.Point(186, 118);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.dobDateTimePicker.TabIndex = 31;
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(186, 231);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(241, 22);
            this.zipTextBox.TabIndex = 35;
            this.zipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipTextBox_KeyPress);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(186, 174);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(241, 22);
            this.cityTextBox.TabIndex = 33;
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(186, 146);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(241, 22);
            this.streetAddressTextBox.TabIndex = 32;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(186, 62);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(241, 22);
            this.lastNameTextBox.TabIndex = 29;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(186, 33);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(241, 22);
            this.firstNameTextBox.TabIndex = 28;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Location = new System.Drawing.Point(75, 258);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(107, 17);
            this.phoneNumberLabel.TabIndex = 27;
            this.phoneNumberLabel.Text = "Phone Number:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(145, 231);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(32, 17);
            this.zipLabel.TabIndex = 26;
            this.zipLabel.Text = "Zip:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(145, 174);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 17);
            this.cityLabel.TabIndex = 25;
            this.cityLabel.Text = "City:";
            // 
            // streetAddressLabel
            // 
            this.streetAddressLabel.AutoSize = true;
            this.streetAddressLabel.Location = new System.Drawing.Point(75, 146);
            this.streetAddressLabel.Name = "streetAddressLabel";
            this.streetAddressLabel.Size = new System.Drawing.Size(106, 17);
            this.streetAddressLabel.TabIndex = 24;
            this.streetAddressLabel.Text = "Street Address:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(90, 118);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(91, 17);
            this.dobLabel.TabIndex = 23;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(100, 62);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 17);
            this.lastNameLabel.TabIndex = 22;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(99, 33);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(80, 17);
            this.firstNameLabel.TabIndex = 21;
            this.firstNameLabel.Text = "First Name:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(338, 331);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 29);
            this.cancelButton.TabIndex = 41;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updatePatientButton
            // 
            this.updatePatientButton.Location = new System.Drawing.Point(92, 331);
            this.updatePatientButton.Name = "updatePatientButton";
            this.updatePatientButton.Size = new System.Drawing.Size(82, 29);
            this.updatePatientButton.TabIndex = 40;
            this.updatePatientButton.Text = "Update";
            this.updatePatientButton.UseVisualStyleBackColor = true;
            this.updatePatientButton.Click += new System.EventHandler(this.updatePatientButton_Click);
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(186, 286);
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(241, 22);
            this.ssnTextBox.TabIndex = 39;
            this.ssnTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ssnTextBox_KeyPress);
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(23, 286);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(159, 17);
            this.ssnLabel.TabIndex = 38;
            this.ssnLabel.Text = "Social Security Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Gender:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(186, 201);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(241, 24);
            this.stateComboBox.TabIndex = 34;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(186, 90);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(241, 24);
            this.genderComboBox.TabIndex = 30;
            // 
            // phoneLastFourDigitsTextBox
            // 
            this.phoneLastFourDigitsTextBox.Location = new System.Drawing.Point(332, 259);
            this.phoneLastFourDigitsTextBox.Name = "phoneLastFourDigitsTextBox";
            this.phoneLastFourDigitsTextBox.Size = new System.Drawing.Size(95, 22);
            this.phoneLastFourDigitsTextBox.TabIndex = 38;
            this.phoneLastFourDigitsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneLastFourDigitsTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "-";
            // 
            // phoneFirstThreeDigitsTextBox
            // 
            this.phoneFirstThreeDigitsTextBox.Location = new System.Drawing.Point(259, 259);
            this.phoneFirstThreeDigitsTextBox.Name = "phoneFirstThreeDigitsTextBox";
            this.phoneFirstThreeDigitsTextBox.Size = new System.Drawing.Size(48, 22);
            this.phoneFirstThreeDigitsTextBox.TabIndex = 37;
            this.phoneFirstThreeDigitsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneFirstThreeDigitsTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "-";
            // 
            // areaCodeTextBox
            // 
            this.areaCodeTextBox.Location = new System.Drawing.Point(186, 259);
            this.areaCodeTextBox.Name = "areaCodeTextBox";
            this.areaCodeTextBox.Size = new System.Drawing.Size(48, 22);
            this.areaCodeTextBox.TabIndex = 36;
            this.areaCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.areaCodeTextBox_KeyPress);
            // 
            // UpdatePatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 389);
            this.Controls.Add(this.phoneLastFourDigitsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneFirstThreeDigitsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.areaCodeTextBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.label2);
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
            this.Controls.Add(this.updatePatientButton);
            this.Name = "UpdatePatientForm";
            this.Text = "Update Patient";
            this.Load += new System.EventHandler(this.UpdatePatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetAddressTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetAddressLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updatePatientButton;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.TextBox phoneLastFourDigitsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneFirstThreeDigitsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox areaCodeTextBox;
    }
}