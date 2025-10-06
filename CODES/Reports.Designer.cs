namespace CODES
{
    partial class Reports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelReportOptions = new System.Windows.Forms.Panel();
            this.lblReportType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.panelReportDisplay = new System.Windows.Forms.Panel();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblAverageValue = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelReportOptions.SuspendLayout();
            this.panelReportDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panelSummary.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelHeader.Controls.Add(this.lblReports);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1200, 80);
            this.panelHeader.TabIndex = 0;

            // lblReports
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblReports.Location = new System.Drawing.Point(30, 18);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(158, 51);
            this.lblReports.TabIndex = 0;
            this.lblReports.Text = "Reports";

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(185, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "& Analytics";

            // btnClose
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1080, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // panelMain
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelMain.Controls.Add(this.panelReportOptions);
            this.panelMain.Controls.Add(this.panelReportDisplay);
            this.panelMain.Controls.Add(this.panelSummary);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(30);
            this.panelMain.Size = new System.Drawing.Size(1200, 670);
            this.panelMain.TabIndex = 1;

            // panelReportOptions
            this.panelReportOptions.BackColor = System.Drawing.Color.White;
            this.panelReportOptions.Controls.Add(this.lblReportType);
            this.panelReportOptions.Controls.Add(this.cmbReportType);
            this.panelReportOptions.Controls.Add(this.lblDateRange);
            this.panelReportOptions.Controls.Add(this.dtpStartDate);
            this.panelReportOptions.Controls.Add(this.lblTo);
            this.panelReportOptions.Controls.Add(this.dtpEndDate);
            this.panelReportOptions.Controls.Add(this.btnGenerateReport);
            this.panelReportOptions.Location = new System.Drawing.Point(30, 30);
            this.panelReportOptions.Name = "panelReportOptions";
            this.panelReportOptions.Size = new System.Drawing.Size(1140, 120);
            this.panelReportOptions.TabIndex = 0;

            // lblReportType
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReportType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblReportType.Location = new System.Drawing.Point(30, 25);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(99, 20);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report Type:";

            // cmbReportType
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Sales Report",
            "Product Inventory Report",
            "Transaction History",
            "Customer Orders Report",
            "Low Stock Alert",
            "Top Selling Products",
            "Revenue Summary"});
            this.cmbReportType.Location = new System.Drawing.Point(30, 50);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(280, 28);
            this.cmbReportType.TabIndex = 1;

            // lblDateRange
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDateRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblDateRange.Location = new System.Drawing.Point(340, 25);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(95, 20);
            this.lblDateRange.TabIndex = 2;
            this.lblDateRange.Text = "Date Range:";

            // dtpStartDate
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(340, 51);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 25);
            this.dtpStartDate.TabIndex = 3;

            // lblTo
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblTo.Location = new System.Drawing.Point(500, 53);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(25, 20);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "to";

            // dtpEndDate
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(535, 51);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 25);
            this.dtpEndDate.TabIndex = 5;

            // btnGenerateReport
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(930, 35);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(180, 50);
            this.btnGenerateReport.TabIndex = 6;
            this.btnGenerateReport.Text = "📊 Generate";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);

            // panelReportDisplay
            this.panelReportDisplay.BackColor = System.Drawing.Color.White;
            this.panelReportDisplay.Controls.Add(this.lblReportTitle);
            this.panelReportDisplay.Controls.Add(this.dgvReport);
            this.panelReportDisplay.Location = new System.Drawing.Point(30, 170);
            this.panelReportDisplay.Name = "panelReportDisplay";
            this.panelReportDisplay.Size = new System.Drawing.Size(1140, 380);
            this.panelReportDisplay.TabIndex = 1;

            // lblReportTitle
            this.lblReportTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblReportTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReportTitle.ForeColor = System.Drawing.Color.White;
            this.lblReportTitle.Location = new System.Drawing.Point(0, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblReportTitle.Size = new System.Drawing.Size(1140, 50);
            this.lblReportTitle.TabIndex = 0;
            this.lblReportTitle.Text = "📈 Report Preview - Select report type and click Generate";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // dgvReport
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReport.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvReport.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dgvReport.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvReport.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dgvReport.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReport.ColumnHeadersHeight = 45;
            this.dgvReport.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvReport.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvReport.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.dgvReport.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvReport.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.dgvReport.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.dgvReport.EnableHeadersVisualStyles = false;
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvReport.Location = new System.Drawing.Point(0, 50);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersVisible = false;
            this.dgvReport.RowTemplate.Height = 40;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1140, 330);
            this.dgvReport.TabIndex = 1;

            // panelSummary
            this.panelSummary.BackColor = System.Drawing.Color.White;
            this.panelSummary.Controls.Add(this.lblTotalRecords);
            this.panelSummary.Controls.Add(this.lblTotalRevenue);
            this.panelSummary.Controls.Add(this.lblAverageValue);
            this.panelSummary.Location = new System.Drawing.Point(30, 570);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(1140, 70);
            this.panelSummary.TabIndex = 2;

            // lblTotalRecords
            this.lblTotalRecords.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblTotalRecords.Location = new System.Drawing.Point(30, 20);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(330, 30);
            this.lblTotalRecords.TabIndex = 0;
            this.lblTotalRecords.Text = "Total Records: 0";
            this.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblTotalRevenue
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(405, 20);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(330, 30);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "Total Revenue: ₱0.00";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblAverageValue
            this.lblAverageValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAverageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblAverageValue.Location = new System.Drawing.Point(780, 20);
            this.lblAverageValue.Name = "lblAverageValue";
            this.lblAverageValue.Size = new System.Drawing.Size(330, 30);
            this.lblAverageValue.TabIndex = 2;
            this.lblAverageValue.Text = "Average Order: ₱0.00";
            this.lblAverageValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // Reports
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoDeS - Reports & Analytics";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelReportOptions.ResumeLayout(false);
            this.panelReportOptions.PerformLayout();
            this.panelReportDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panelSummary.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelReportOptions;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Panel panelReportDisplay;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblAverageValue;
    }
}