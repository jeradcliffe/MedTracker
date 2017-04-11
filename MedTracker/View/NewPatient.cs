﻿using MedTracker.Controller;
using MedTracker.Model;
using System;
using System.Windows.Forms;

namespace MedTracker.View
{
    public partial class NewPatientForm : Form
    {
        private bool dateChosen;
        private PatientsController patientsController;

        public NewPatientForm()
        {
            InitializeComponent();
            this.patientsController = new PatientsController();
            this.dateChosen = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createPatientButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" ||
                lastNameTextBox.Text == "" ||
                genderTextBox.Text == "" ||
                !dateChosen ||
                streetAddressTextBox.Text == "" ||
                cityTextBox.Text == "" ||
                stateComboBox.Text == "" ||
                zipTextBox.Text == "" ||
                phoneNumberTextBox.Text == "" ||
                ssnTextBox.Text == "")
            {
                MessageBox.Show("ALL fields are required! Do not leave any blank.");
            }
            else if (ssnTextBox.Text.Length < 9 || ssnTextBox.Text.Length > 9)
            {
                MessageBox.Show("Social Security Number must be exactly 9 digits, using valid numbers only!", "Invalid SSN");
            }
            else
            {
                Person newPatient = new Person();

                newPatient.firstName     = firstNameTextBox.Text;
                newPatient.lastName      = lastNameTextBox.Text;
                newPatient.dateOfBirth   = dobDateTimePicker.Value.Date;
                newPatient.streetAddress = streetAddressTextBox.Text;
                newPatient.city          = cityTextBox.Text;
                newPatient.state         = stateComboBox.Text;
                newPatient.zip           = zipTextBox.Text;
                newPatient.phoneNumber   = phoneNumberTextBox.Text;
                newPatient.gender        = genderTextBox.Text;
                newPatient.ssn           = ssnTextBox.Text;

                int statusOfCreate = patientsController.CreatePatient(newPatient);

                //if create patient was successful
                if (statusOfCreate == 0)
                {
                    MessageBox.Show("Patient was successfully created!");
                    this.Close();
                }
            }
        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dobDateTimePicker.CustomFormat = "MMMM dd, yyyy";
            dateChosen = true;
        }

        private void ssnTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Used to validate for numbers only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NewPatientForm_Load(object sender, EventArgs e)
        {
            string[] states = new string[]
            {
                "AL", "AK", "AZ", "AR", "CA", 
                "CO", "CT", "DE", "FL", "GA", 
                "HI", "ID", "IL", "IN", "IA", 
                "KS", "KY", "LA", "ME", "MD", 
                "MA", "MI", "MN", "MS", "MO", 
                "MT", "NE", "NV", "NH", "NJ", 
                "NM", "NY", "NC", "ND", "OH", 
                "OK", "OR", "PA", "RI", "SC", 
                "SD", "TN", "TX", "UT", "VT", 
                "VA", "WA", "WV", "WI", "WY"
            };

            foreach (string state in states)
            {
                stateComboBox.Items.Add(state);
            }
        }
    }
}
