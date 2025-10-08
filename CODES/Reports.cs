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
using OfficeOpenXml;
using System.IO;

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
                MySqlCommand cmd = new MySqlCommand("sp_GetSalesReport", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StartDate", startDate);
                cmd.Parameters.AddWithValue("p_EndDate", endDate);

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
                MySqlCommand cmd = new MySqlCommand("sp_GetInventoryReport", conn);
                cmd.CommandType = CommandType.StoredProcedure;

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
                MySqlCommand cmd = new MySqlCommand("sp_GetTransactionReport", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StartDate", startDate);
                cmd.Parameters.AddWithValue("p_EndDate", endDate);

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
                MySqlCommand cmd = new MySqlCommand("sp_GetCustomerOrdersReport", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StartDate", startDate);
                cmd.Parameters.AddWithValue("p_EndDate", endDate);

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
                MySqlCommand cmd = new MySqlCommand("sp_GetLowStockReport", conn);
                cmd.CommandType = CommandType.StoredProcedure;

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
                MySqlCommand cmd = new MySqlCommand("sp_GetTopSellingProducts", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StartDate", startDate);
                cmd.Parameters.AddWithValue("p_EndDate", endDate);
                cmd.Parameters.AddWithValue("p_Limit", 20);

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
                MySqlCommand cmd = new MySqlCommand("sp_GetRevenueSummary", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("p_StartDate", startDate);
                cmd.Parameters.AddWithValue("p_EndDate", endDate);

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

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export! Please generate a report first.",
                    "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                
                string reportType = cmbReportType.SelectedItem.ToString();
                string fileName = GetFileNameForReport(reportType);

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel Files|*.xlsx";
                saveDialog.Title = "Save Excel Report";
                saveDialog.FileName = fileName;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(reportType);

                    
                        worksheet.Cells[1, 1, 1, dgvReport.Columns.Count].Merge = true;
                        worksheet.Cells[1, 1].Value = lblReportTitle.Text;
                        worksheet.Cells[1, 1].Style.Font.Size = 16;
                        worksheet.Cells[1, 1].Style.Font.Bold = true;
                        worksheet.Cells[1, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[1, 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[1, 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(0, 51, 102));
                        worksheet.Cells[1, 1].Style.Font.Color.SetColor(System.Drawing.Color.White);
                        worksheet.Row(1).Height = 30;

                     
                        worksheet.Cells[2, 1, 2, dgvReport.Columns.Count].Merge = true;
                        worksheet.Cells[2, 1].Value = $"Generated on: {DateTime.Now:MMMM dd, yyyy hh:mm tt}";
                        worksheet.Cells[2, 1].Style.Font.Size = 10;
                        worksheet.Cells[2, 1].Style.Font.Italic = true;
                        worksheet.Cells[2, 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        worksheet.Cells[2, 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[2, 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(240, 240, 240));
                        worksheet.Row(2).Height = 20;

                        for (int i = 0; i < dgvReport.Columns.Count; i++)
                        {
                            worksheet.Cells[4, i + 1].Value = dgvReport.Columns[i].HeaderText;
                            worksheet.Cells[4, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[4, i + 1].Style.Font.Size = 11;
                            worksheet.Cells[4, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            worksheet.Cells[4, i + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(68, 114, 196));
                            worksheet.Cells[4, i + 1].Style.Font.Color.SetColor(System.Drawing.Color.White);
                            worksheet.Cells[4, i + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                            worksheet.Cells[4, i + 1].Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;
                        }
                        worksheet.Row(4).Height = 25;

                        
                        for (int i = 0; i < dgvReport.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvReport.Columns.Count; j++)
                            {
                                var cellValue = dgvReport.Rows[i].Cells[j].Value;
                                worksheet.Cells[i + 5, j + 1].Value = cellValue?.ToString() ?? "";

                        
                                if (i % 2 == 0)
                                {
                                    worksheet.Cells[i + 5, j + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                                    worksheet.Cells[i + 5, j + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(242, 242, 242));
                                }

                               
                                if (dgvReport.Columns[j].HeaderText.Contains("Price") ||
                                    dgvReport.Columns[j].HeaderText.Contains("Revenue") ||
                                    dgvReport.Columns[j].HeaderText.Contains("Value") ||
                                    dgvReport.Columns[j].HeaderText.Contains("Total") ||
                                    dgvReport.Columns[j].HeaderText.Contains("Spent") ||
                                    dgvReport.Columns[j].HeaderText.Contains("Average"))
                                {
                                    if (decimal.TryParse(cellValue?.ToString(), out decimal numValue))
                                    {
                                        worksheet.Cells[i + 5, j + 1].Value = numValue;
                                        worksheet.Cells[i + 5, j + 1].Style.Numberformat.Format = "₱#,##0.00";
                                    }
                                }
                            }
                        }

                        
                        int summaryRow = dgvReport.Rows.Count + 6;
                        worksheet.Cells[summaryRow, 1, summaryRow, dgvReport.Columns.Count].Merge = true;
                        worksheet.Cells[summaryRow, 1].Value = "SUMMARY";
                        worksheet.Cells[summaryRow, 1].Style.Font.Bold = true;
                        worksheet.Cells[summaryRow, 1].Style.Font.Size = 12;
                        worksheet.Cells[summaryRow, 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        worksheet.Cells[summaryRow, 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(68, 114, 196));
                        worksheet.Cells[summaryRow, 1].Style.Font.Color.SetColor(System.Drawing.Color.White);

                   
                        summaryRow++;
                        worksheet.Cells[summaryRow, 1].Value = lblTotalRecords.Text;
                        worksheet.Cells[summaryRow, 1].Style.Font.Bold = true;
                        summaryRow++;
                        worksheet.Cells[summaryRow, 1].Value = lblTotalRevenue.Text;
                        worksheet.Cells[summaryRow, 1].Style.Font.Bold = true;
                        summaryRow++;
                        worksheet.Cells[summaryRow, 1].Value = lblAverageValue.Text;
                        worksheet.Cells[summaryRow, 1].Style.Font.Bold = true;

                      
                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        
                        for (int col = 1; col <= dgvReport.Columns.Count; col++)
                        {
                            if (worksheet.Column(col).Width < 15)
                                worksheet.Column(col).Width = 15;
                        }

                       
                        var dataRange = worksheet.Cells[4, 1, dgvReport.Rows.Count + 4, dgvReport.Columns.Count];
                        dataRange.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        dataRange.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        dataRange.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        dataRange.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                        FileInfo fileInfo = new FileInfo(saveDialog.FileName);
                        excelPackage.SaveAs(fileInfo);

                        MessageBox.Show($"Report exported successfully!\n\nSaved to:\n{saveDialog.FileName}",
                            "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        System.Diagnostics.Process.Start("explorer.exe", "/select, " + saveDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel:\n{ex.Message}",
                    "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetFileNameForReport(string reportType)
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            switch (reportType)
            {
                case "Sales Report":
                    return $"SalesReport_{timestamp}.xlsx";
                case "Product Inventory Report":
                    return $"InventoryReport_{timestamp}.xlsx";
                case "Transaction History":
                    return $"TransactionHistory_{timestamp}.xlsx";
                case "Customer Orders Report":
                    return $"CustomerOrdersReport_{timestamp}.xlsx";
                case "Low Stock Alert":
                    return $"LowStockAlert_{timestamp}.xlsx";
                case "Top Selling Products":
                    return $"TopSellingProducts_{timestamp}.xlsx";
                case "Revenue Summary":
                    return $"RevenueSummary_{timestamp}.xlsx";
                default:
                    return $"Report_{timestamp}.xlsx";
            }
        }
    }
}