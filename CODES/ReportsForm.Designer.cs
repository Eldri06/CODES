namespace CODES
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSalesSummary = new System.Windows.Forms.TabPage();
            this.panelSalesSummary = new System.Windows.Forms.Panel();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblAvgOrderValueValue = new System.Windows.Forms.Label();
            this.lblAvgOrderValue = new System.Windows.Forms.Label();
            this.lblUniqueCustomersValue = new System.Windows.Forms.Label();
            this.lblUniqueCustomers = new System.Windows.Forms.Label();
            this.lblTotalTransactionsValue = new System.Windows.Forms.Label();
            this.lblTotalTransactions = new System.Windows.Forms.Label();
            this.tabProductPerformance = new System.Windows.Forms.TabPage();
            this.dgvProductPerformance = new System.Windows.Forms.DataGridView();
            this.tabTransactionTrends = new System.Windows.Forms.TabPage();
            this.dgvTransactionTrends = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSalesSummary.SuspendLayout();
            this.panelSalesSummary.SuspendLayout();
            this.tabProductPerformance.SuspendLayout();
            this.tabTransactionTrends.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductPerformance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionTrends)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reports";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSubtitle.Location = new System.Drawing.Point(20, 65);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(280, 21);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Business Analytics and Performance Metrics";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panelMain.Controls.Add(this.tabControl);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1200, 500);
            this.panelMain.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSalesSummary);
            this.tabControl.Controls.Add(this.tabProductPerformance);
            this.tabControl.Controls.Add(this.tabTransactionTrends);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(20, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1160, 460);
            this.tabControl.TabIndex = 0;
            // 
            // tabSalesSummary
            // 
            this.tabSalesSummary.BackColor = System.Drawing.Color.White;
            this.tabSalesSummary.Controls.Add(this.panelSalesSummary);
            this.tabSalesSummary.Location = new System.Drawing.Point(4, 26);
            this.tabSalesSummary.Name = "tabSalesSummary";
            this.tabSalesSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalesSummary.Size = new System.Drawing.Size(1152, 430);
            this.tabSalesSummary.TabIndex = 0;
            this.tabSalesSummary.Text = "Sales Summary";
            // 
            // panelSalesSummary
            // 
            this.panelSalesSummary.BackColor = System.Drawing.Color.White;
            this.panelSalesSummary.Controls.Add(this.lblTotalSalesValue);
            this.panelSalesSummary.Controls.Add(this.lblTotalSales);
            this.panelSalesSummary.Controls.Add(this.lblAvgOrderValueValue);
            this.panelSalesSummary.Controls.Add(this.lblAvgOrderValue);
            this.panelSalesSummary.Controls.Add(this.lblUniqueCustomersValue);
            this.panelSalesSummary.Controls.Add(this.lblUniqueCustomers);
            this.panelSalesSummary.Controls.Add(this.lblTotalTransactionsValue);
            this.panelSalesSummary.Controls.Add(this.lblTotalTransactions);
            this.panelSalesSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSalesSummary.Location = new System.Drawing.Point(3, 3);
            this.panelSalesSummary.Name = "panelSalesSummary";
            this.panelSalesSummary.Padding = new System.Windows.Forms.Padding(20);
            this.panelSalesSummary.Size = new System.Drawing.Size(1146, 424);
            this.panelSalesSummary.TabIndex = 0;
            // 
            // lblTotalSalesValue
            // 
            this.lblTotalSalesValue.AutoSize = true;
            this.lblTotalSalesValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalesValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblTotalSalesValue.Location = new System.Drawing.Point(200, 200);
            this.lblTotalSalesValue.Name = "lblTotalSalesValue";
            this.lblTotalSalesValue.Size = new System.Drawing.Size(120, 65);
            this.lblTotalSalesValue.TabIndex = 7;
            this.lblTotalSalesValue.Text = "₱0.00";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblTotalSales.Location = new System.Drawing.Point(200, 150);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(100, 25);
            this.lblTotalSales.TabIndex = 6;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // lblAvgOrderValueValue
            // 
            this.lblAvgOrderValueValue.AutoSize = true;
            this.lblAvgOrderValueValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgOrderValueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblAvgOrderValueValue.Location = new System.Drawing.Point(600, 200);
            this.lblAvgOrderValueValue.Name = "lblAvgOrderValueValue";
            this.lblAvgOrderValueValue.Size = new System.Drawing.Size(120, 65);
            this.lblAvgOrderValueValue.TabIndex = 5;
            this.lblAvgOrderValueValue.Text = "₱0.00";
            // 
            // lblAvgOrderValue
            // 
            this.lblAvgOrderValue.AutoSize = true;
            this.lblAvgOrderValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgOrderValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblAvgOrderValue.Location = new System.Drawing.Point(600, 150);
            this.lblAvgOrderValue.Name = "lblAvgOrderValue";
            this.lblAvgOrderValue.Size = new System.Drawing.Size(180, 25);
            this.lblAvgOrderValue.TabIndex = 4;
            this.lblAvgOrderValue.Text = "Average Order Value";
            // 
            // lblUniqueCustomersValue
            // 
            this.lblUniqueCustomersValue.AutoSize = true;
            this.lblUniqueCustomersValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniqueCustomersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.lblUniqueCustomersValue.Location = new System.Drawing.Point(600, 100);
            this.lblUniqueCustomersValue.Name = "lblUniqueCustomersValue";
            this.lblUniqueCustomersValue.Size = new System.Drawing.Size(52, 65);
            this.lblUniqueCustomersValue.TabIndex = 3;
            this.lblUniqueCustomersValue.Text = "0";
            // 
            // lblUniqueCustomers
            // 
            this.lblUniqueCustomers.AutoSize = true;
            this.lblUniqueCustomers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniqueCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblUniqueCustomers.Location = new System.Drawing.Point(600, 50);
            this.lblUniqueCustomers.Name = "lblUniqueCustomers";
            this.lblUniqueCustomers.Size = new System.Drawing.Size(160, 25);
            this.lblUniqueCustomers.TabIndex = 2;
            this.lblUniqueCustomers.Text = "Unique Customers";
            // 
            // lblTotalTransactionsValue
            // 
            this.lblTotalTransactionsValue.AutoSize = true;
            this.lblTotalTransactionsValue.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransactionsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(16)))), ((int)(((byte)(242)))));
            this.lblTotalTransactionsValue.Location = new System.Drawing.Point(200, 100);
            this.lblTotalTransactionsValue.Name = "lblTotalTransactionsValue";
            this.lblTotalTransactionsValue.Size = new System.Drawing.Size(52, 65);
            this.lblTotalTransactionsValue.TabIndex = 1;
            this.lblTotalTransactionsValue.Text = "0";
            // 
            // lblTotalTransactions
            // 
            this.lblTotalTransactions.AutoSize = true;
            this.lblTotalTransactions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblTotalTransactions.Location = new System.Drawing.Point(200, 50);
            this.lblTotalTransactions.Name = "lblTotalTransactions";
            this.lblTotalTransactions.Size = new System.Drawing.Size(170, 25);
            this.lblTotalTransactions.TabIndex = 0;
            this.lblTotalTransactions.Text = "Total Transactions";
            // 
            // tabProductPerformance
            // 
            this.tabProductPerformance.BackColor = System.Drawing.Color.White;
            this.tabProductPerformance.Controls.Add(this.dgvProductPerformance);
            this.tabProductPerformance.Location = new System.Drawing.Point(4, 26);
            this.tabProductPerformance.Name = "tabProductPerformance";
            this.tabProductPerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductPerformance.Size = new System.Drawing.Size(1152, 430);
            this.tabProductPerformance.TabIndex = 1;
            this.tabProductPerformance.Text = "Product Performance";
            // 
            // dgvProductPerformance
            // 
            this.dgvProductPerformance.AllowUserToAddRows = false;
            this.dgvProductPerformance.AllowUserToDeleteRows = false;
            this.dgvProductPerformance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductPerformance.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductPerformance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductPerformance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProductPerformance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductPerformance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductPerformance.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvProductPerformance.Location = new System.Drawing.Point(3, 3);
            this.dgvProductPerformance.MultiSelect = false;
            this.dgvProductPerformance.Name = "dgvProductPerformance";
            this.dgvProductPerformance.ReadOnly = true;
            this.dgvProductPerformance.RowHeadersVisible = false;
            this.dgvProductPerformance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductPerformance.Size = new System.Drawing.Size(1146, 424);
            this.dgvProductPerformance.TabIndex = 0;
            // 
            // tabTransactionTrends
            // 
            this.tabTransactionTrends.BackColor = System.Drawing.Color.White;
            this.tabTransactionTrends.Controls.Add(this.dgvTransactionTrends);
            this.tabTransactionTrends.Location = new System.Drawing.Point(4, 26);
            this.tabTransactionTrends.Name = "tabTransactionTrends";
            this.tabTransactionTrends.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransactionTrends.Size = new System.Drawing.Size(1152, 430);
            this.tabTransactionTrends.TabIndex = 2;
            this.tabTransactionTrends.Text = "Transaction Trends";
            // 
            // dgvTransactionTrends
            // 
            this.dgvTransactionTrends.AllowUserToAddRows = false;
            this.dgvTransactionTrends.AllowUserToDeleteRows = false;
            this.dgvTransactionTrends.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactionTrends.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactionTrends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactionTrends.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTransactionTrends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactionTrends.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvTransactionTrends.Location = new System.Drawing.Point(3, 3);
            this.dgvTransactionTrends.MultiSelect = false;
            this.dgvTransactionTrends.Name = "dgvTransactionTrends";
            this.dgvTransactionTrends.ReadOnly = true;
            this.dgvTransactionTrends.RowHeadersVisible = false;
            this.dgvTransactionTrends.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionTrends.Size = new System.Drawing.Size(1146, 424);
            this.dgvTransactionTrends.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.panelButtons.Controls.Add(this.btnClose);
            this.panelButtons.Controls.Add(this.btnExport);
            this.panelButtons.Controls.Add(this.btnRefresh);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 600);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(20);
            this.panelButtons.Size = new System.Drawing.Size(1200, 100);
            this.panelButtons.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(20, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(160, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 35);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export CSV";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(300, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 35);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports - CoDeS Merchandise System";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabSalesSummary.ResumeLayout(false);
            this.panelSalesSummary.ResumeLayout(false);
            this.panelSalesSummary.PerformLayout();
            this.tabProductPerformance.ResumeLayout(false);
            this.tabTransactionTrends.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductPerformance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionTrends)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSalesSummary;
        private System.Windows.Forms.Panel panelSalesSummary;
        private System.Windows.Forms.Label lblTotalTransactions;
        private System.Windows.Forms.Label lblTotalTransactionsValue;
        private System.Windows.Forms.Label lblUniqueCustomers;
        private System.Windows.Forms.Label lblUniqueCustomersValue;
        private System.Windows.Forms.Label lblAvgOrderValue;
        private System.Windows.Forms.Label lblAvgOrderValueValue;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalSalesValue;
        private System.Windows.Forms.TabPage tabProductPerformance;
        private System.Windows.Forms.DataGridView dgvProductPerformance;
        private System.Windows.Forms.TabPage tabTransactionTrends;
        private System.Windows.Forms.DataGridView dgvTransactionTrends;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
    }
}
