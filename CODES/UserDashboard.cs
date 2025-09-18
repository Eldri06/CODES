using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODES
{
    public partial class UserDashboard : Form
    {
        private string loggedInUser; // store logged-in username

        public UserDashboard(string username)
        {
            InitializeComponent();
            loggedInUser = username; // save username for later
        }

       
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // ✅ Optional: Show welcome message (make sure you have a label named lblWelcome)
            if (!string.IsNullOrEmpty(loggedInUser))
            {
               
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewItems_Click(object sender, EventArgs e)
        {
            PurchaseItemDashboard PurchaseForm = new PurchaseItemDashboard();
            PurchaseForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LandingPage LandingForm = new LandingPage();
            LandingForm.Show();
            this.Hide();
        }
    }
}
