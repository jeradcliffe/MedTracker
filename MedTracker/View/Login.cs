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
using MedTracker.Model;
using MedTracker.View;

namespace MedTracker
{
    public partial class Login : Form
    {
        private ClinicEmployeesController clinicEmployeesController;
        private string username = "";
        private string password = "";
        public static string currentUser;
         
        public Login()
        {
            InitializeComponent();
            clinicEmployeesController = new ClinicEmployeesController();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtBoxUserName.Text;
            password = txtBoxPassword.Text;
            currentUser = txtBoxUserName.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please be sure that both username and password are properly filled in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    bool loginSuccessful = clinicEmployeesController.checkLoginCredentials(username, password);
                    if (loginSuccessful)
                    {
                        // Clear pass and username fields so form is clear after logout happens
                        txtBoxUserName.Text = "";
                        txtBoxPassword.Text = "";

                        //Will be adding more features to make a nice main dashboard in Iteration 2
                        MainDashboard mainDashboard = new MainDashboard();
                        mainDashboard.loginForm = this;
                        mainDashboard.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login. Please try again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }
    }
}
