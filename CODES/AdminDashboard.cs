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
    public partial class AdminDashboard : Form
    {
        private string connString = "server=localhost;port=3307;database=codesfinal;uid=root;pwd=;";

        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
        }
        private void LoadProducts()
        {
            try
            {
                using (var conn = new MySqlConnection(connString))
                using (var da = new MySqlDataAdapter("SELECT id, name, description, price, stock, status, image_url FROM products", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    dgvProducts.DataSource = dt;

                    dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvProducts.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error loading products: " + ex.Message, "Database Error", CustomMessageBox.MessageBoxType.Error);
            }
        }
        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvProducts.Rows[e.RowIndex];
            txtName.Text = row.Cells["name"].Value.ToString();
            txtDescription.Text = row.Cells["description"].Value.ToString();
            txtPrice.Text = row.Cells["price"].Value.ToString();
            txtStock.Text = row.Cells["stock"].Value.ToString();
            txtImagePath.Text = row.Cells["image_url"].Value.ToString();
        }
        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            TransactionsForm tf = new TransactionsForm();
            tf.Show();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName;
                }
            }
        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                CustomMessageBox.Show("Please fill in all required fields.", "Validation Error", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                CustomMessageBox.Show("Please enter a valid price greater than 0.", "Invalid Price", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                CustomMessageBox.Show("Please enter a valid stock quantity (0 or greater).", "Invalid Stock", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(@"
                        INSERT INTO products (name, description, price, stock, image_url, status) 
                        VALUES (@name, @desc, @price, @stock, @image, 'available')", conn);

                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@image", txtImagePath.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                CustomMessageBox.Show("Product added successfully!", "Success", CustomMessageBox.MessageBoxType.Success);
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error adding product: " + ex.Message, "Database Error", CustomMessageBox.MessageBoxType.Error);
            }
        }

        private void btnUpdateProduct_Click_1(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select a product to update.", "No Selection", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                CustomMessageBox.Show("Please fill in all required fields.", "Validation Error", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                CustomMessageBox.Show("Please enter a valid price greater than 0.", "Invalid Price", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                CustomMessageBox.Show("Please enter a valid stock quantity (0 or greater).", "Invalid Stock", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["id"].Value);

            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand(@"
                        UPDATE products 
                        SET name=@name, description=@desc, price=@price, stock=@stock, image_url=@image 
                        WHERE id=@id", conn);

                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@stock", stock);
                    cmd.Parameters.AddWithValue("@image", txtImagePath.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                CustomMessageBox.Show("Product updated successfully!", "Success", CustomMessageBox.MessageBoxType.Success);
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error updating product: " + ex.Message, "Database Error", CustomMessageBox.MessageBoxType.Error);
            }
        }

        private void btnDeleteProduct_Click_1(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select a product to delete.", "No Selection", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["id"].Value);
            string productName = dgvProducts.SelectedRows[0].Cells["name"].Value.ToString();

            var confirm = MessageBox.Show($"Are you sure you want to delete '{productName}'?\n\nThis action cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    var cmd = new MySqlCommand("DELETE FROM products WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", productId);
                    cmd.ExecuteNonQuery();
                }

                CustomMessageBox.Show("Product deleted successfully!", "Success", CustomMessageBox.MessageBoxType.Success);
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error deleting product: " + ex.Message, "Database Error", CustomMessageBox.MessageBoxType.Error);
            }
        }

        private void btnViewProducts_Click_1(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnViewTransactions_Click_1(object sender, EventArgs e)
        {
            TransactionsForm tf = new TransactionsForm();
            tf.Show();
        }

        private void btnBrowseImage_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtImagePath.Text = ofd.FileName;
                }
            }
        }
        private void ClearInputs()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtImagePath.Clear();
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            reportsForm.ShowDialog();
        }
    }
}