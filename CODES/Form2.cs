using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CODES
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            LandingPage LandingForm = new LandingPage();
            LandingForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                string connString = "server=localhost;port=3307;database=codesfinal;uid=root;pwd=;";
                using (MySqlConnection conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    string query = "SELECT id, username, password_hash, ROLE FROM users WHERE username = @username AND STATUS = 'active'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                long userId = reader.GetInt64("id");  
                                string storedHash = reader.GetString("password_hash");
                                string role = reader.GetString("ROLE");

                                if (VerifyPassword(password, storedHash))
                                {
                                    MessageBox.Show("Login successful!");

                                    if (role == "admin")
                                    {
                                        AdminDashboard adminForm = new AdminDashboard();
                                        adminForm.StartPosition = FormStartPosition.CenterScreen;
                                        adminForm.Show();
                                    }
                                    else
                                    {
                               
                                        UserDashboard userForm = new UserDashboard(username, userId);
                                        userForm.StartPosition = FormStartPosition.CenterScreen;
                                        userForm.Show();
                                    }

                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid password. Please try again.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username not found or account inactive.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private bool VerifyPassword(string password, string storedHash)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hashedInput = BitConverter.ToString(bytes).Replace("-", "").ToLower();
                return hashedInput == storedHash;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterPage RegisterForm = new RegisterPage();
            RegisterForm.Show();
            this.Hide();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            LandingPage LandingForm = new LandingPage();
            LandingForm.Show();
            this.Hide();
        }
    }
}