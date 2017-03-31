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
    public partial class AppointmentForm : Form
    {
        public Person patient;

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = patient.firstName;
            lastNameTextBox.Text = patient.lastName;
            phoneNumberTextBox.Text = patient.phoneNumber;
            cityTextBox.Text = patient.city;
            stateTextBox.Text = patient.state;
            zipTextBox.Text = patient.zip;  
        }
    }
}
