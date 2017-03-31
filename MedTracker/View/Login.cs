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

namespace MedTracker
{
    public partial class Login : Form
    {
        private ClinicEmployeesController clinicEmployeeController;
        public static string username = "";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtBoxUserName.Text;
            String password = txtBoxPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please be sure that both username and password are properly filled in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                bool loginSuccessful = clinicEmployeeController.checkLoginCredentials(username, password);
                if (loginSuccessful)
                {
                    View.MainDashboard mainDashboard = new View.MainDashboard();
                    mainDashboard.Show();
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
