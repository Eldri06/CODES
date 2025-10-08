using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CODES
{
    public partial class PurchaseItemDashboard : Form
    {
        private string connString = "server=localhost;port=3307;database=codesfinal;uid=root;pwd=;";
        private long currentUserId;

        public PurchaseItemDashboard(long userId)
        {
            InitializeComponent();
            currentUserId = userId;
        }
        private void PurchaseItemDashboard_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            try
            {
                using (var conn = new MySqlConnection(connString))
                using (var da = new MySqlDataAdapter("SELECT id, name, price, stock, image_url FROM products WHERE status='available'", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);

                    dgvProducts.DataSource = dt;


                    if (dgvProducts.Columns["id"] != null)
                        dgvProducts.Columns["id"].Visible = false;

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
            int productId = Convert.ToInt32(row.Cells["id"].Value);

            using (var details = new FormProductDetails(productId, currentUserId))
            {
                details.StartPosition = FormStartPosition.CenterScreen;
                var result = details.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewProducts_Click_1(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
        }
        private void dgvProucts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchItem.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                CustomMessageBox.Show("Please enter a search term.", "Search Required", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    string query = @"SELECT id, name, price, stock, image_url 
                             FROM products 
                             WHERE status='available' 
                             AND name LIKE @search";

                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchValue + "%");
                        var dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            CustomMessageBox.Show($"No products found matching '{searchValue}'.", "No Results", CustomMessageBox.MessageBoxType.Info);
                        }

                        dgvProducts.DataSource = dt;

                        if (dgvProducts.Columns["id"] != null)
                            dgvProducts.Columns["id"].Visible = false;

                        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgvProducts.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error searching products: " + ex.Message, "Search Error", CustomMessageBox.MessageBoxType.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UserDashboard UserForm = new UserDashboard();
            UserForm.Show();
            this.Close();
        }
    }
}
