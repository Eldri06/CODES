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
    public partial class Reports : Form
    {
        private string connectionString = "server=localhost;port=3307;database=codesfinal;uid=root;pwd=;";

        public Reports()
        {
            InitializeComponent();
            cmbReportType.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now.AddMonths(-1);
            dtpEndDate.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a report type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reportType = cmbReportType.SelectedItem.ToString();
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddSeconds(-1);

            try
            {
                switch (reportType)
                {
                    case "Sales Report":
                        GenerateSalesReport(startDate, endDate);
                        break;
                    case "Product Inventory Report":
                        GenerateInventoryReport();
                        break;
                    case "Transaction History":
                        GenerateTransactionReport(startDate, endDate);
                        break;
                    case "Customer Orders Report":
                        GenerateCustomerOrdersReport(startDate, endDate);
                        break;
                    case "Low Stock Alert":
                        GenerateLowStockReport();
                        break;
                    case "Top Selling Products":
                        GenerateTopSellingReport(startDate, endDate);
                        break;
                    case "Revenue Summary":
                        GenerateRevenueSummary(startDate, endDate);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateSalesReport(DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                    p.name AS ProductName,
                                    SUM(ti.qty) AS TotalSold,
                                    p.price AS UnitPrice,
                                    SUM(ti.total) AS TotalRevenue,
                                    COUNT(DISTINCT ti.transaction_id) AS Orders
                                FROM transaction_items ti
                                INNER JOIN products p ON ti.product_id = p.id
                                INNER JOIN transactions t ON ti.transaction_id = t.id
                                WHERE t.created_at BETWEEN @StartDate AND @EndDate
                                AND t.status = 'completed'
                                GROUP BY p.id, p.name, p.price
                                ORDER BY TotalRevenue DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReport.DataSource = dt;
                lblReportTitle.Text = $"📈 Sales Report ({startDate:MMM dd} - {endDate:MMM dd, yyyy})";

                CalculateSummary(dt, "TotalRevenue", "TotalSold");
            }
        }

        private void GenerateInventoryReport()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                    id AS ProductID,
                                    name AS ProductName,
                                    description AS Description,
                                    price AS Price,
                                    stock AS StockQuantity,
                                    (price * stock) AS TotalValue,
                                    CASE 
                                        WHEN stock = 0 THEN 'Out of Stock'
                                        WHEN stock <= 10 THEN 'Low Stock'
                                        WHEN stock <= 50 THEN 'Medium Stock'
                                        ELSE 'Well Stocked'
                                    END AS StockStatus,
                                    status AS Availability
                                FROM products
                                ORDER BY stock ASC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReport.DataSource = dt;
                lblReportTitle.Text = "📦 Product Inventory Report";

                if (dt.Rows.Count > 0)
                {
                    decimal totalValue = 0;
                    int totalProducts = dt.Rows.Count;
                    int totalStock = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        totalValue += Convert.ToDecimal(row["TotalValue"]);
                        totalStock += Convert.ToInt32(row["StockQuantity"]);
                    }

                    lblTotalRecords.Text = $"Total Products: {totalProducts}";
                    lblTotalRevenue.Text = $"Inventory Value: ₱{totalValue:N2}";
                    lblAverageValue.Text = $"Total Stock: {totalStock} units";
                }
            }
        }

        private void GenerateTransactionReport(DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                    t.id AS TransactionID,
                                    t.created_at AS TransactionDate,
                                    u.username AS Customer,
                                    u.email AS Email,
                                    p.name AS ProductName,
                                    ti.qty AS Quantity,
                                    ti.unit_price AS UnitPrice,
                                    ti.total AS TotalAmount,
                                    t.status AS Status
                                FROM transactions t
                                INNER JOIN users u ON t.user_id = u.id
                                INNER JOIN transaction_items ti ON t.id = ti.transaction_id
                                INNER JOIN products p ON ti.product_id = p.id
                                WHERE t.created_at BETWEEN @StartDate AND @EndDate
                                ORDER BY t.created_at DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReport.DataSource = dt;
                lblReportTitle.Text = $"🧾 Transaction History ({startDate:MMM dd} - {endDate:MMM dd, yyyy})";

                CalculateSummary(dt, "TotalAmount", "Quantity");
            }
        }

        private void GenerateCustomerOrdersReport(DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                    u.username AS Customer,
                                    u.email AS Email,
                                    u.role AS Role,
                                    COUNT(DISTINCT t.id) AS TotalOrders,
                                    SUM(ti.qty) AS TotalItems,
                                    SUM(t.total) AS TotalSpent,
                                    MAX(t.created_at) AS LastOrderDate,
                                    AVG(t.total) AS AverageOrderValue
                                FROM transactions t
                                INNER JOIN users u ON t.user_id = u.id
                                INNER JOIN transaction_items ti ON t.id = ti.transaction_id
                                WHERE t.created_at BETWEEN @StartDate AND @EndDate
                                AND t.status = 'completed'
                                GROUP BY u.id, u.username, u.email, u.role
                                ORDER BY TotalSpent DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReport.DataSource = dt;
                lblReportTitle.Text = $"👥 Customer Orders Report ({startDate:MMM dd} - {endDate:MMM dd, yyyy})";

                CalculateSummary(dt, "TotalSpent", "TotalOrders");
            }
        }

        private void GenerateLowStockReport()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                    id AS ProductID,
                                    name AS ProductName,
                                    description AS Description,
                                    price AS Price,
                                    stock AS StockQuantity,
                                    status AS Availability,
                                    CASE 
                                        WHEN stock = 0 THEN 'URGENT - Out of Stock'
                                        WHEN stock <= 5 THEN 'CRITICAL - Reorder Now'
                                        WHEN stock <= 10 THEN 'LOW - Monitor Closely'
                                        ELSE 'Warning Level'
                                    END AS AlertLevel
                                FROM products
                                WHERE stock <= 10
                                ORDER BY stock ASC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReport.DataSource = dt;
                lblReportTitle.Text = "⚠️ Low Stock Alert Report";

                if (dt.Rows.Count > 0)
                {
                    int outOfStock = 0;
                    int lowStock = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        int stock = Convert.ToInt32(row["StockQuantity"]);
                        if (stock == 0) outOfStock++;
                        else if (stock <= 10) lowStock++;
                    }

                    lblTotalRecords.Text = $"Products at Risk: {dt.Rows.Count}";
                    lblTotalRevenue.Text = $"Out of Stock: {outOfStock}";
                    lblAverageValue.Text = $"Low Stock: {lowStock}";
                }
                else
                {
                    lblTotalRecords.Text = "All products well stocked! ✓";
                    lblTotalRevenue.Text = "";
                    lblAverageValue.Text = "";
                }
            }
        }

        private void GenerateTopSellingReport(DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                    p.id AS ProductID,
                                    p.name AS ProductName,
                                    SUM(ti.qty) AS TotalQuantitySold,
                                    p.price AS CurrentPrice,
                                    SUM(ti.total) AS TotalRevenue,
                                    COUNT(DISTINCT ti.transaction_id) AS NumberOfOrders,
                                    p.stock AS CurrentStock
                                FROM transaction_items ti
                                INNER JOIN products p ON ti.product_id = p.id
                                INNER JOIN transactions t ON ti.transaction_id = t.id
                                WHERE t.created_at BETWEEN @StartDate AND @EndDate
                                AND t.status = 'completed'
                                GROUP BY p.id, p.name, p.price, p.stock
                                ORDER BY TotalQuantitySold DESC
                                LIMIT 20";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReport.DataSource = dt;
                lblReportTitle.Text = $"🏆 Top 20 Selling Products ({startDate:MMM dd} - {endDate:MMM dd, yyyy})";

                CalculateSummary(dt, "TotalRevenue", "TotalQuantitySold");
            }
        }

        private void GenerateRevenueSummary(DateTime startDate, DateTime endDate)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                    DATE(t.created_at) AS Date,
                                    COUNT(DISTINCT t.id) AS TotalOrders,
                                    SUM(ti.qty) AS TotalItemsSold,
                                    SUM(t.total) AS DailyRevenue,
                                    AVG(t.total) AS AverageOrderValue,
                                    COUNT(DISTINCT t.user_id) AS UniqueCustomers
                                FROM transactions t
                                INNER JOIN transaction_items ti ON t.id = ti.transaction_id
                                WHERE t.created_at BETWEEN @StartDate AND @EndDate
                                AND t.status = 'completed'
                                GROUP BY DATE(t.created_at)
                                ORDER BY Date DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReport.DataSource = dt;
                lblReportTitle.Text = $"💰 Daily Revenue Summary ({startDate:MMM dd} - {endDate:MMM dd, yyyy})";

                if (dt.Rows.Count > 0)
                {
                    decimal totalRevenue = 0;
                    int totalOrders = 0;

                    foreach (DataRow row in dt.Rows)
                    {
                        totalRevenue += Convert.ToDecimal(row["DailyRevenue"]);
                        totalOrders += Convert.ToInt32(row["TotalOrders"]);
                    }

                    decimal avgDaily = dt.Rows.Count > 0 ? totalRevenue / dt.Rows.Count : 0;

                    lblTotalRecords.Text = $"Total Days: {dt.Rows.Count}";
                    lblTotalRevenue.Text = $"Total Revenue: ₱{totalRevenue:N2}";
                    lblAverageValue.Text = $"Avg Daily: ₱{avgDaily:N2}";
                }
            }
        }

        private void CalculateSummary(DataTable dt, string revenueColumn, string quantityColumn)
        {
            if (dt.Rows.Count > 0)
            {
                decimal totalRevenue = 0;
                decimal totalQuantity = 0;

                foreach (DataRow row in dt.Rows)
                {
                    if (dt.Columns.Contains(revenueColumn) && row[revenueColumn] != DBNull.Value)
                        totalRevenue += Convert.ToDecimal(row[revenueColumn]);
                    if (dt.Columns.Contains(quantityColumn) && row[quantityColumn] != DBNull.Value)
                        totalQuantity += Convert.ToDecimal(row[quantityColumn]);
                }

                decimal average = dt.Rows.Count > 0 ? totalRevenue / dt.Rows.Count : 0;

                lblTotalRecords.Text = $"Total Records: {dt.Rows.Count}";
                lblTotalRevenue.Text = $"Total Revenue: ₱{totalRevenue:N2}";
                lblAverageValue.Text = $"Average: ₱{average:N2}";
            }
            else
            {
                lblTotalRecords.Text = "No data found for selected period";
                lblTotalRevenue.Text = "";
                lblAverageValue.Text = "";
            }
        }
    }
}
