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

namespace MedTracker.View
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
            
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Login.currentUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
