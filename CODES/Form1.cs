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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form2 signInForm = new Form2();
            signInForm.Show();  
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form3 signUpForm = new Form3();
            signUpForm.Show(); 
            this.Hide();
        }
    }
}
