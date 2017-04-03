using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedTracker.Controller;
using MedTracker.View;
using MedTracker.Model;

namespace MedTracker.View
{
    public partial class MainDashboard : Form
    {
        private DoctorsController doctorController;
        private NursesController nurseController;
        private AdministratorsController adminController;
        private PersonController personController;
        private bool isNurse = false;
        private bool isAdmin = false;
        private bool isDoctor = false;
        private string role;
        private Person currentPerson;
        private Nurses tempNurse;
        private Administrators tempAdmin;
        private Doctors tempDoct;
        
        public MainDashboard()
        {
            InitializeComponent();
            doctorController = new DoctorsController();
            nurseController = new NursesController();
            adminController = new AdministratorsController();
            personController = new PersonController();
            currentPerson = new Person();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            assignPerson();
            lblUsername.Text = Login.currentUser;
            lblRole.Text = role;
            lblName.Text = currentPerson.lastName.ToString() + ", " + currentPerson.firstName.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
        private void assignPerson()
        {
           
            isNurse = nurseController.checkIfNurses(Login.currentUser);
            isAdmin = adminController.checkIfAdministrators(Login.currentUser);
            isDoctor = doctorController.checkIfDoctors(Login.currentUser);
            role = "";
            if (isNurse)
            {
                role = "Nurse";
                tempNurse = nurseController.getNurse(Login.currentUser);
                currentPerson = personController.GetPerson(tempNurse.peopleID);
            }
            else if(isDoctor)
            {
                role = "Doctor";
                tempDoct = doctorController.getDoctor(Login.currentUser);
                currentPerson = personController.GetPerson(tempDoct.peopleID);
            }
            else if(isAdmin)
            {
                role = "Administrator";
                tempAdmin = adminController.getAdministrator(Login.currentUser);
                currentPerson = personController.GetPerson(tempAdmin.peopleID);
            }
            else
            {
                role = "Role not assigned. Contact Administrator";
            }
        }
    }
}
