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
                MessageBox.Show("Error loading products: " + ex.Message);
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
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                    cmd.Parameters.AddWithValue("@image", txtImagePath.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(" Product added successfully.");
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btnUpdateProduct_Click_1(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product to update.");
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
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                    cmd.Parameters.AddWithValue("@image", txtImagePath.Text.Trim());

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("✅ Product updated successfully.");
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void btnDeleteProduct_Click_1(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product to delete.");
                return;
            }

            int productId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["id"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this product?",
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

                MessageBox.Show("Product deleted successfully.");
                LoadProducts();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm();
            reportsForm.Show();
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
    }
}