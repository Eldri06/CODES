using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CODES
{
    public partial class Profile : Form
    {
        private string connectionString = "server=localhost;port=3307;database=codesfinal;uid=root;pwd=;";
        private int userId;
        private string username;

        public Profile(int userId, string username)
        {
            InitializeComponent();
            this.userId = userId;
            this.username = username;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
            LoadUserStatistics();
        }

        private void LoadUserProfile()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                        username, 
                                        email, 
                                        role, 
                                        status, 
                                        created_at 
                                    FROM users 
                                    WHERE id = @UserId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblUsernameValue.Text = reader["username"].ToString();
                        lblEmailValue.Text = reader["email"].ToString();

                        string role = reader["role"].ToString();
                        lblRoleValue.Text = role.ToUpper();
                        lblRoleValue.ForeColor = role == "admin"
                            ? System.Drawing.Color.FromArgb(220, 53, 69)
                            : System.Drawing.Color.FromArgb(40, 167, 69);

                        string status = reader["status"].ToString();
                        lblStatusValue.Text = status.ToUpper();
                        lblStatusValue.ForeColor = status == "active"
                            ? System.Drawing.Color.FromArgb(40, 167, 69)
                            : System.Drawing.Color.FromArgb(220, 53, 69);

                        DateTime createdAt = Convert.ToDateTime(reader["created_at"]);
                        lblMemberSinceValue.Text = createdAt.ToString("MMMM dd, yyyy");
                    }
                    else
                    {
                        MessageBox.Show("User profile not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserStatistics()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = @"SELECT 
                                        COUNT(DISTINCT t.id) as TotalOrders,
                                        COALESCE(SUM(t.total), 0) as TotalSpent,
                                        MAX(t.created_at) as LastOrderDate
                                    FROM transactions t
                                    WHERE t.user_id = @UserId 
                                    AND t.status = 'completed'";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int totalOrders = Convert.ToInt32(reader["TotalOrders"]);
                        decimal totalSpent = Convert.ToDecimal(reader["TotalSpent"]);

                        lblTotalOrdersValue.Text = totalOrders.ToString();
                        lblTotalSpentValue.Text = $"₱{totalSpent:N2}";

                        if (reader["LastOrderDate"] != DBNull.Value)
                        {
                            DateTime lastOrder = Convert.ToDateTime(reader["LastOrderDate"]);
                            lblLastOrderValue.Text = lastOrder.ToString("MMM dd, yyyy");
                        }
                        else
                        {
                            lblLastOrderValue.Text = "No orders yet";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordDialog changePasswordForm = new ChangePasswordDialog(userId);
            if (changePasswordForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Password changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();

                // Close UserDashboard only
                foreach (Form form in Application.OpenForms)
                {
                    if (form is UserDashboard)
                    {
                        form.Close();
                    }
                }

                LandingPage landingPage = new LandingPage();
                landingPage.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ChangePasswordDialog : Form
    {
        private string connectionString = "server=localhost;database=codesfinal;uid=root;pwd=;";
        private int userId;

        private Panel panelMain;
        private Label lblTitle;
        private Label lblCurrentPassword;
        private TextBox txtCurrentPassword;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnSave;
        private Button btnCancel;

        public ChangePasswordDialog(int userId)
        {
            this.userId = userId;
            InitializePasswordDialog();
        }

        private void InitializePasswordDialog()
        {
            this.Text = "Change Password";
            this.Size = new System.Drawing.Size(450, 400);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            panelMain = new Panel();
            panelMain.Dock = DockStyle.Fill;
            panelMain.BackColor = System.Drawing.Color.White;
            panelMain.Padding = new Padding(30);

            lblTitle = new Label();
            lblTitle.Text = "Change Your Password";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 51, 102);
            lblTitle.Location = new System.Drawing.Point(30, 30);
            lblTitle.Size = new System.Drawing.Size(370, 35);

            lblCurrentPassword = new Label();
            lblCurrentPassword.Text = "Current Password:";
            lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(0, 51, 102);
            lblCurrentPassword.Location = new System.Drawing.Point(30, 85);
            lblCurrentPassword.Size = new System.Drawing.Size(370, 20);

            txtCurrentPassword = new TextBox();
            txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtCurrentPassword.Location = new System.Drawing.Point(30, 110);
            txtCurrentPassword.Size = new System.Drawing.Size(370, 27);
            txtCurrentPassword.UseSystemPasswordChar = true;

            lblNewPassword = new Label();
            lblNewPassword.Text = "New Password:";
            lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblNewPassword.ForeColor = System.Drawing.Color.FromArgb(0, 51, 102);
            lblNewPassword.Location = new System.Drawing.Point(30, 155);
            lblNewPassword.Size = new System.Drawing.Size(370, 20);

            txtNewPassword = new TextBox();
            txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtNewPassword.Location = new System.Drawing.Point(30, 180);
            txtNewPassword.Size = new System.Drawing.Size(370, 27);
            txtNewPassword.UseSystemPasswordChar = true;

            lblConfirmPassword = new Label();
            lblConfirmPassword.Text = "Confirm New Password:";
            lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(0, 51, 102);
            lblConfirmPassword.Location = new System.Drawing.Point(30, 225);
            lblConfirmPassword.Size = new System.Drawing.Size(370, 20);

            txtConfirmPassword = new TextBox();
            txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 11F);
            txtConfirmPassword.Location = new System.Drawing.Point(30, 250);
            txtConfirmPassword.Size = new System.Drawing.Size(370, 27);
            txtConfirmPassword.UseSystemPasswordChar = true;

            btnSave = new Button();
            btnSave.Text = "Save Password";
            btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnSave.BackColor = System.Drawing.Color.FromArgb(0, 51, 102);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Location = new System.Drawing.Point(30, 300);
            btnSave.Size = new System.Drawing.Size(175, 40);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Click += BtnSave_Click;

            btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnCancel.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Location = new System.Drawing.Point(225, 300);
            btnCancel.Size = new System.Drawing.Size(175, 40);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            panelMain.Controls.Add(lblTitle);
            panelMain.Controls.Add(lblCurrentPassword);
            panelMain.Controls.Add(txtCurrentPassword);
            panelMain.Controls.Add(lblNewPassword);
            panelMain.Controls.Add(txtNewPassword);
            panelMain.Controls.Add(lblConfirmPassword);
            panelMain.Controls.Add(txtConfirmPassword);
            panelMain.Controls.Add(btnSave);
            panelMain.Controls.Add(btnCancel);

            this.Controls.Add(panelMain);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                MessageBox.Show("Please enter your current password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter a new password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters long!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("New passwords do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string verifyQuery = "SELECT password_h FROM users WHERE id = @UserId";
                    MySqlCommand verifyCmd = new MySqlCommand(verifyQuery, conn);
                    verifyCmd.Parameters.AddWithValue("@UserId", userId);

                    conn.Open();
                    string storedPassword = verifyCmd.ExecuteScalar()?.ToString();

                    if (storedPassword != txtCurrentPassword.Text)
                    {
                        MessageBox.Show("Current password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string updateQuery = "UPDATE users SET password_h = @NewPassword, updated_at = NOW() WHERE id = @UserId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@NewPassword", txtNewPassword.Text);
                    updateCmd.Parameters.AddWithValue("@UserId", userId);

                    updateCmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
