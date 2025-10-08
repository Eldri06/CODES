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
            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    var adapter = new MySqlDataAdapter("SELECT * FROM transactions ORDER BY created_at DESC", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvTransactions.DataSource = dt;

                    dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvTransactions.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error loading transactions: " + ex.Message, "Database Error", CustomMessageBox.MessageBoxType.Error);
            }
        }

        private void dgvTransactions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfrimTransactions_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select a transaction to confirm.", "No Selection", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            int transactionId = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["id"].Value);
            string currentStatus = dgvTransactions.SelectedRows[0].Cells["status"].Value.ToString();

            if (currentStatus.ToLower() == "completed")
            {
                CustomMessageBox.Show("This transaction is already completed.", "Already Completed", CustomMessageBox.MessageBoxType.Info);
                return;
            }

            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connString))
                {
                    conn.Open();

                    using (var tx = conn.BeginTransaction())
                    {
                        var items = new List<(int productId, int qty, string productName)>();
                        using (var cmdItems = new MySql.Data.MySqlClient.MySqlCommand(
                            @"SELECT ti.product_id, ti.qty, p.name 
                              FROM transaction_items ti 
                              JOIN products p ON ti.product_id = p.id 
                              WHERE ti.transaction_id=@tid", conn, tx))
                        {
                            cmdItems.Parameters.AddWithValue("@tid", transactionId);
                            using (var reader = cmdItems.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int pid = Convert.ToInt32(reader["product_id"]);
                                    int qty = Convert.ToInt32(reader["qty"]);
                                    string name = reader["name"].ToString();
                                    items.Add((pid, qty, name));
                                }
                            }
                        }

                        if (items.Count == 0)
                        {
                            CustomMessageBox.Show("This transaction has no items.", "No Items", CustomMessageBox.MessageBoxType.Warning);
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
                                    CustomMessageBox.Show($"Product '{item.productName}' (ID: {item.productId}) not found.", "Product Not Found", CustomMessageBox.MessageBoxType.Error);
                                    tx.Rollback();
                                    return;
                                }

                                int currentStock = Convert.ToInt32(res);
                                if (currentStock < item.qty)
                                {
                                    CustomMessageBox.Show($"Not enough stock for '{item.productName}'.\n\nRequired: {item.qty}\nAvailable: {currentStock}", "Insufficient Stock", CustomMessageBox.MessageBoxType.Warning);
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

                CustomMessageBox.Show("Transaction confirmed successfully!\n\nStock has been updated.", "Success", CustomMessageBox.MessageBoxType.Success);
                LoadTransactions();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error confirming transaction: " + ex.Message, "Transaction Error", CustomMessageBox.MessageBoxType.Error);
            }
        }

        private void btnCancelTransactions_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteTransactions_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Please select a transaction to delete.", "No Selection", CustomMessageBox.MessageBoxType.Warning);
                return;
            }

            int transactionId = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["id"].Value);
            string status = dgvTransactions.SelectedRows[0].Cells["status"].Value.ToString();

            var confirm = MessageBox.Show($"Are you sure you want to delete this transaction?\n\nTransaction ID: {transactionId}\nStatus: {status}\n\nThis action cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    conn.Open();

                    using (var transaction = conn.BeginTransaction())
                    {
                        var cmdItems = new MySqlCommand("DELETE FROM transaction_items WHERE transaction_id=@id", conn, transaction);
                        cmdItems.Parameters.AddWithValue("@id", transactionId);
                        cmdItems.ExecuteNonQuery();

                        var cmd = new MySqlCommand("DELETE FROM transactions WHERE id=@id", conn, transaction);
                        cmd.Parameters.AddWithValue("@id", transactionId);
                        cmd.ExecuteNonQuery();

                        transaction.Commit();
                    }
                }

                CustomMessageBox.Show("Transaction deleted successfully!", "Success", CustomMessageBox.MessageBoxType.Success);
                LoadTransactions();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show("Error deleting transaction: " + ex.Message, "Delete Error", CustomMessageBox.MessageBoxType.Error);
            }
        }
    }
}
