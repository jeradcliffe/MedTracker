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

                        View.MainDashboard mainDashboard = new View.MainDashboard();
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
