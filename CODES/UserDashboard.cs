using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace CODES
{
    public partial class UserDashboard : Form
    {
        private string loggedInUser;
        private long loggedInUserId;
        public UserDashboard(string username, long userId)
        {
            InitializeComponent();
            loggedInUser = username;
            loggedInUserId = userId;
        }
        public UserDashboard()
        {
            InitializeComponent();
        }
        private void btnViewItems_Click(object sender, EventArgs e)
        {
            PurchaseItemDashboard purchaseForm = new PurchaseItemDashboard(loggedInUserId);
            purchaseForm.StartPosition = FormStartPosition.CenterScreen;
            purchaseForm.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            LandingPage landingForm = new LandingPage();
            landingForm.StartPosition = FormStartPosition.CenterScreen;
            landingForm.Show();
            this.Hide();
        }

        private void panelFeatures_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchaseItemDashboard purchaseForm = new PurchaseItemDashboard(loggedInUserId);
            purchaseForm.StartPosition = FormStartPosition.CenterScreen;
            purchaseForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Profile profileForm = new Profile((int)loggedInUserId, loggedInUser);
            profileForm.ShowDialog();
        }
    }
    }

