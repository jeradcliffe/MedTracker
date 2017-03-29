﻿using MedTracker.Controller;
using MedTracker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedTracker.View
{
    public partial class PatientSearch : Form
    {
        public Patient patient;
        private List<Patient> patientList;
        private PatientsController patientsController;

        private Boolean dateChosen;

        public PatientSearch()
        {
            InitializeComponent();
            patientsController = new PatientsController();
            this.clearFields();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string dateOfBirth = this.formatDateOfBirth(dateOfBirthDateTimePicker);
            string firstName   = firstNameTextBox.Text;
            string lastName    = lastNameTextBox.Text;

            try
            {
                this.patientList = patientsController.GetSelectedPatients(dateOfBirth, firstName, lastName);
                patientDataGridView.DataSource = this.patientList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }





        /// <summary>
        /// Formats the DOB as a result of whether or not someone has chosen one 
        /// for their search feature. This has to be done because the date time picker
        /// auto-chooses the current date as a default. 
        /// </summary>
        /// <param name="datePicker"></param>
        /// <returns></returns>
        private string formatDateOfBirth(DateTimePicker datePicker)
        {
            if (dateChosen)
                return dateOfBirthDateTimePicker.Value.ToString("yyyy-MM-dd");
            else
                return ""; 
        }

        // Changes the date format
        private void dateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            dateOfBirthDateTimePicker.CustomFormat = "yyyy-MM-dd";
            dateChosen = true;
        }

        // Clears all the fields of their values.
        private void clearFields()
        {
            dateOfBirthDateTimePicker.CustomFormat = " ";
            dateOfBirthDateTimePicker.Format = DateTimePickerFormat.Custom;
            dateChosen = false;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            this.patientDataGridView.DataSource = null;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.clearFields();
        }
    }
}
