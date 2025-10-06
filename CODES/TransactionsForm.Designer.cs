namespace CODES
{
    partial class TransactionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteTransactions = new System.Windows.Forms.Button();
            this.btnCancelTransactions = new System.Windows.Forms.Button();
            this.btnConfrimTransactions = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelActions = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.ColumnHeadersHeight = 45;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgvTransactions.Location = new System.Drawing.Point(20, 60);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowTemplate.Height = 40;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(1100, 300);
            this.dgvTransactions.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1100, 40);
            this.label2.TabIndex = 45;
            this.label2.Text = "💳 Transactions Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblSystemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblSystemName.Location = new System.Drawing.Point(30, 15);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(276, 59);
            this.lblSystemName.TabIndex = 44;
            this.lblSystemName.Text = "Transactions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 59);
            this.label1.TabIndex = 43;
            this.label1.Text = "Management";
            // 
            // btnDeleteTransactions
            // 
            this.btnDeleteTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTransactions.FlatAppearance.BorderSize = 0;
            this.btnDeleteTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTransactions.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTransactions.Location = new System.Drawing.Point(680, 25);
            this.btnDeleteTransactions.Name = "btnDeleteTransactions";
            this.btnDeleteTransactions.Size = new System.Drawing.Size(180, 50);
            this.btnDeleteTransactions.TabIndex = 60;
            this.btnDeleteTransactions.Text = "Delete";
            this.btnDeleteTransactions.UseVisualStyleBackColor = false;
            this.btnDeleteTransactions.Click += new System.EventHandler(this.btnDeleteTransactions_Click);
            // 
            // btnCancelTransactions
            // 
            this.btnCancelTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnCancelTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelTransactions.FlatAppearance.BorderSize = 0;
            this.btnCancelTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelTransactions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnCancelTransactions.Location = new System.Drawing.Point(480, 25);
            this.btnCancelTransactions.Name = "btnCancelTransactions";
            this.btnCancelTransactions.Size = new System.Drawing.Size(180, 50);
            this.btnCancelTransactions.TabIndex = 59;
            this.btnCancelTransactions.Text = "Cancel";
            this.btnCancelTransactions.UseVisualStyleBackColor = false;
            this.btnCancelTransactions.Click += new System.EventHandler(this.btnCancelTransactions_Click);
            // 
            // btnConfrimTransactions
            // 
            this.btnConfrimTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfrimTransactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfrimTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfrimTransactions.FlatAppearance.BorderSize = 0;
            this.btnConfrimTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfrimTransactions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfrimTransactions.ForeColor = System.Drawing.Color.White;
            this.btnConfrimTransactions.Location = new System.Drawing.Point(280, 25);
            this.btnConfrimTransactions.Name = "btnConfrimTransactions";
            this.btnConfrimTransactions.Size = new System.Drawing.Size(180, 50);
            this.btnConfrimTransactions.TabIndex = 58;
            this.btnConfrimTransactions.Text = "Confirm";
            this.btnConfrimTransactions.UseVisualStyleBackColor = false;
            this.btnConfrimTransactions.Click += new System.EventHandler(this.btnConfrimTransactions_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelHeader.Controls.Add(this.lblSystemName);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.panelHeader.Size = new System.Drawing.Size(1200, 90);
            this.panelHeader.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelMain.Controls.Add(this.panelActions);
            this.panelMain.Controls.Add(this.panelDataGrid);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 90);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(30, 25, 30, 25);
            this.panelMain.Size = new System.Drawing.Size(1200, 560);
            this.panelMain.TabIndex = 1;
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.White;
            this.panelActions.Controls.Add(this.btnConfrimTransactions);
            this.panelActions.Controls.Add(this.btnCancelTransactions);
            this.panelActions.Controls.Add(this.btnDeleteTransactions);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelActions.Location = new System.Drawing.Point(30, 405);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(40, 25, 40, 25);
            this.panelActions.Size = new System.Drawing.Size(1140, 100);
            this.panelActions.TabIndex = 1;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BackColor = System.Drawing.Color.White;
            this.panelDataGrid.Controls.Add(this.dgvTransactions);
            this.panelDataGrid.Controls.Add(this.label2);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDataGrid.Location = new System.Drawing.Point(30, 25);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Padding = new System.Windows.Forms.Padding(20);
            this.panelDataGrid.Size = new System.Drawing.Size(1140, 380);
            this.panelDataGrid.TabIndex = 0;
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1216, 689);
            this.Name = "TransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoDeS Merch - Transactions Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelActions.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteTransactions;
        private System.Windows.Forms.Button btnCancelTransactions;
        private System.Windows.Forms.Button btnConfrimTransactions;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.Panel panelActions;
    }
}