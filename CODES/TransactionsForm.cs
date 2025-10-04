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
using Org.BouncyCastle.Asn1.Cmp;

namespace CODES
{
    public partial class TransactionsForm : Form
    {
        private string connString = "server=localhost;port=3307;database=codesfinal;uid=root;pwd=;";
        public TransactionsForm()
        {
            InitializeComponent();
            LoadTransactions();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LoadTransactions()
        {
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                var adapter = new MySqlDataAdapter("SELECT * FROM transactions", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTransactions.DataSource = dt;
            }
        }

        private void dgvTransactions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnConfrimTransactions_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a transaction to confirm.");
                return;
            }

            int transactionId = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["id"].Value);

            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connString))
                {
                    conn.Open();

                    using (var tx = conn.BeginTransaction())
                    {
                  
                        var items = new List<(int productId, int qty)>();
                        using (var cmdItems = new MySql.Data.MySqlClient.MySqlCommand(
                            "SELECT product_id, qty FROM transaction_items WHERE transaction_id=@tid", conn, tx))
                        {
                            cmdItems.Parameters.AddWithValue("@tid", transactionId);
                            using (var reader = cmdItems.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int pid = Convert.ToInt32(reader["product_id"]);
                                    int qty = Convert.ToInt32(reader["qty"]);
                                    items.Add((pid, qty));
                                }
                            }
                        }

                        if (items.Count == 0)
                        {
                            MessageBox.Show("This transaction has no items.");
                            tx.Rollback();
                            return;
                        }
                      
                       foreach (var item in items)
                        {
                          
                            using (var cmdCheck = new MySql.Data.MySqlClient.MySqlCommand(
                                "SELECT stock FROM products WHERE id=@pid FOR UPDATE", conn, tx))
                            {
                                cmdCheck.Parameters.AddWithValue("@pid", item.productId);
                                object res = cmdCheck.ExecuteScalar();
                                if (res == null)
                                {
                                    MessageBox.Show($"Product id {item.productId} not found.");
                                    tx.Rollback();
                                    return;
                                }

                                int currentStock = Convert.ToInt32(res);
                                if (currentStock < item.qty)
                                {
                                    MessageBox.Show($"Not enough stock for product id {item.productId}. Current: {currentStock}, required: {item.qty}");
                                    tx.Rollback();
                                    return;
                                }
                            }

                      
                            using (var cmdUpdateStock = new MySql.Data.MySqlClient.MySqlCommand(
                                "UPDATE products SET stock = stock - @qty WHERE id=@pid", conn, tx))
                            {
                                cmdUpdateStock.Parameters.AddWithValue("@qty", item.qty);
                                cmdUpdateStock.Parameters.AddWithValue("@pid", item.productId);
                                cmdUpdateStock.ExecuteNonQuery();
                            }
                        }

                       
                        using (var cmdFinish = new MySql.Data.MySqlClient.MySqlCommand(
                            "UPDATE transactions SET status = 'completed' WHERE id=@tid", conn, tx))
                        {
                            cmdFinish.Parameters.AddWithValue("@tid", transactionId);
                            cmdFinish.ExecuteNonQuery();
                        }

                        tx.Commit();
                    } 
                } 

                MessageBox.Show("Transaction confirmed and stock updated!");
                LoadTransactions(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error confirming transaction: " + ex.Message);
            }
        }

        private void btnCancelTransactions_Click(object sender, EventArgs e)
        {
            this.Close();

            AdminDashboard adminForm = new AdminDashboard();
            adminForm.Show();

        }

        private void btnDeleteTransactions_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0) return;

            int transactionId = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["id"].Value);

            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
         
                var cmdItems = new MySqlCommand("DELETE FROM transaction_items WHERE transaction_id=@id", conn);
                cmdItems.Parameters.AddWithValue("@id", transactionId);
                cmdItems.ExecuteNonQuery();
             
                var cmd = new MySqlCommand("DELETE FROM transactions WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", transactionId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Transaction deleted!");
            LoadTransactions();
        }
    }
}
