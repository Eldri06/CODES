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
    public partial class ReportsForm : Form
    {
        private string connString = "server=localhost;port=3307;database=codesfinal;uid=root;pwd=;";

        public ReportsForm()
        {
            InitializeComponent();
            LoadReports();
        }

        private void LoadReports()
        {
            try
            {
                // Load sales summary
                LoadSalesSummary();
                
                // Load product performance
                LoadProductPerformance();
                
                // Load transaction trends
                LoadTransactionTrends();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reports: " + ex.Message);
            }
        }

        private void LoadSalesSummary()
        {
            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    var query = @"
                        SELECT 
                            COUNT(*) as TotalTransactions,
                            SUM(total_amount) as TotalSales,
                            AVG(total_amount) as AverageOrderValue,
                            COUNT(DISTINCT user_id) as UniqueCustomers
                        FROM transactions 
                        WHERE status = 'completed'";
                    
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTotalTransactions.Text = reader["TotalTransactions"].ToString();
                            lblTotalSales.Text = "₱" + Convert.ToDecimal(reader["TotalSales"]).ToString("N2");
                            lblAvgOrderValue.Text = "₱" + Convert.ToDecimal(reader["AverageOrderValue"]).ToString("N2");
                            lblUniqueCustomers.Text = reader["UniqueCustomers"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading sales summary: " + ex.Message);
            }
        }

        private void LoadProductPerformance()
        {
            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    var query = @"
                        SELECT 
                            p.name as ProductName,
                            SUM(ti.qty) as TotalSold,
                            SUM(ti.qty * p.price) as TotalRevenue,
                            p.stock as CurrentStock
                        FROM products p
                        LEFT JOIN transaction_items ti ON p.id = ti.product_id
                        LEFT JOIN transactions t ON ti.transaction_id = t.id AND t.status = 'completed'
                        GROUP BY p.id, p.name, p.stock
                        ORDER BY TotalSold DESC";
                    
                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvProductPerformance.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product performance: " + ex.Message);
            }
        }

        private void LoadTransactionTrends()
        {
            try
            {
                using (var conn = new MySqlConnection(connString))
                {
                    conn.Open();
                    var query = @"
                        SELECT 
                            DATE(created_at) as TransactionDate,
                            COUNT(*) as TransactionCount,
                            SUM(total_amount) as DailySales
                        FROM transactions 
                        WHERE status = 'completed'
                        GROUP BY DATE(created_at)
                        ORDER BY TransactionDate DESC
                        LIMIT 30";
                    
                    using (var da = new MySqlDataAdapter(query, conn))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        dgvTransactionTrends.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading transaction trends: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReports();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.Title = "Export Reports";
                sfd.FileName = "CoDeS_Reports_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToCSV(sfd.FileName);
                    MessageBox.Show("Reports exported successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting reports: " + ex.Message);
            }
        }

        private void ExportToCSV(string fileName)
        {
            using (var writer = new System.IO.StreamWriter(fileName))
            {
                // Write sales summary
                writer.WriteLine("SALES SUMMARY");
                writer.WriteLine("Total Transactions," + lblTotalTransactions.Text);
                writer.WriteLine("Total Sales," + lblTotalSales.Text);
                writer.WriteLine("Average Order Value," + lblAvgOrderValue.Text);
                writer.WriteLine("Unique Customers," + lblUniqueCustomers.Text);
                writer.WriteLine();

                // Write product performance
                writer.WriteLine("PRODUCT PERFORMANCE");
                var productData = (DataTable)dgvProductPerformance.DataSource;
                if (productData != null)
                {
                    foreach (DataRow row in productData.Rows)
                    {
                        writer.WriteLine(string.Join(",", row.ItemArray));
                    }
                }
                writer.WriteLine();

                // Write transaction trends
                writer.WriteLine("TRANSACTION TRENDS (Last 30 Days)");
                var trendData = (DataTable)dgvTransactionTrends.DataSource;
                if (trendData != null)
                {
                    foreach (DataRow row in trendData.Rows)
                    {
                        writer.WriteLine(string.Join(",", row.ItemArray));
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
