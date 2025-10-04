using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CODES
{
    public partial class FormProductDetails : Form
    {
        private string connString = "server=localhost;port=3307;database=codesfinal;uid=root;pwd=;";
        private int productId;
        private long currentUserId;
        private decimal price;
        private int availableStock;

        public FormProductDetails(int selectedProductId, long userId)
        {
            InitializeComponent();
            productId = selectedProductId;
            currentUserId = userId;
            this.Load += new System.EventHandler(this.FormProductDetails_Load);
            this.nudQuantity.ValueChanged += new System.EventHandler(this.nudQuantity_ValueChanged);
        }

        private void FormProductDetails_Load(object sender, EventArgs e)
        {
            
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            try
            {
                using (var conn = new MySqlConnection(connString))
                using (var cmd = new MySqlCommand("SELECT name, price, stock, image_url FROM products WHERE id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", productId);
                    conn.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblProductName.Text = reader["name"].ToString();
                            price = Convert.ToDecimal(reader["price"]);
                            availableStock = Convert.ToInt32(reader["stock"]);

                            lblPrice.Text = $"Price: ${price}";
                            lblStock.Text = $"Available: {availableStock}";

                            nudQuantity.Minimum = 1;
                            nudQuantity.Maximum = availableStock > 0 ? availableStock : 1;

                            CalculateTotal();

                            if (!reader.IsDBNull(reader.GetOrdinal("image_url")))
                            {
                                string imagePath = reader["image_url"].ToString();
                               
                                string fullPath = System.IO.Path.Combine(Application.StartupPath, imagePath);

                                if (System.IO.File.Exists(fullPath))
                                {
                                    pbProductImage.Image = Image.FromFile(fullPath);
                                    pbProductImage.SizeMode = PictureBoxSizeMode.StretchImage; 
                                }
                                else
                                {
                                    pbProductImage.Image = null;
                                    MessageBox.Show("Image not found at: " + fullPath);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product: " + ex.Message);
            }
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            int qty = (int)nudQuantity.Value;
            lblTotal.Text = $"Total: ${qty * price}";
        }

        private void btnConfirmPurchase_Click(object sender, EventArgs e)
        {      
        }

        private void btnConfirmPurchase_Click_1(object sender, EventArgs e)
        {
            int qty = (int)nudQuantity.Value;
            if (qty > availableStock)
            {
                MessageBox.Show("Not enough stock available.");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        var cmd = new MySqlCommand(@"
                    INSERT INTO transactions (user_id, total, status, created_at)
                    VALUES (@uid, @total, 'pending', NOW());
                    SELECT LAST_INSERT_ID();", conn, transaction);

                        decimal total = qty * price;
                        cmd.Parameters.AddWithValue("@uid", currentUserId);
                        cmd.Parameters.AddWithValue("@total", total);

                        long transactionId = Convert.ToInt64(cmd.ExecuteScalar());

                        var cmdItem = new MySqlCommand(@"
                    INSERT INTO transaction_items (transaction_id, product_id, qty, unit_price, total)
                    VALUES (@tid, @pid, @qty, @price, @total);", conn, transaction);

                        cmdItem.Parameters.AddWithValue("@tid", transactionId);
                        cmdItem.Parameters.AddWithValue("@pid", productId);
                        cmdItem.Parameters.AddWithValue("@qty", qty);
                        cmdItem.Parameters.AddWithValue("@price", price);
                        cmdItem.Parameters.AddWithValue("@total", total);
                        cmdItem.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    MessageBox.Show("📝 Order placed successfully!\n\nWaiting for admin confirmation.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing order: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PurchaseItemDashboard purchaseForm = new PurchaseItemDashboard(currentUserId);
            purchaseForm.StartPosition = FormStartPosition.CenterScreen;
            purchaseForm.Show();

            this.Close();
        }
    }
}
