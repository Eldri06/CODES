namespace CODES
{
    partial class TransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteTransactions = new System.Windows.Forms.Button();
            this.btnCancelTransactions = new System.Windows.Forms.Button();
            this.btnConfrimTransactions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Location = new System.Drawing.Point(141, 130);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(533, 216);
            this.dgvTransactions.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("League Spartan", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(253, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Transactions Managment Data";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemName.Font = new System.Drawing.Font("League Spartan", 26F, System.Drawing.FontStyle.Bold);
            this.lblSystemName.ForeColor = System.Drawing.Color.Gold;
            this.lblSystemName.Location = new System.Drawing.Point(233, 37);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(138, 44);
            this.lblSystemName.TabIndex = 44;
            this.lblSystemName.Text = "Admin";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("League Spartan", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(364, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 44);
            this.label1.TabIndex = 43;
            this.label1.Text = "Dashboard";
            // 
            // btnDeleteTransactions
            // 
            this.btnDeleteTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTransactions.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteTransactions.Location = new System.Drawing.Point(492, 361);
            this.btnDeleteTransactions.Name = "btnDeleteTransactions";
            this.btnDeleteTransactions.Size = new System.Drawing.Size(123, 32);
            this.btnDeleteTransactions.TabIndex = 60;
            this.btnDeleteTransactions.Text = "Delete ";
            this.btnDeleteTransactions.UseVisualStyleBackColor = false;
            this.btnDeleteTransactions.Click += new System.EventHandler(this.btnDeleteTransactions_Click);
            // 
            // btnCancelTransactions
            // 
            this.btnCancelTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelTransactions.BackColor = System.Drawing.Color.Gold;
            this.btnCancelTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnCancelTransactions.Location = new System.Drawing.Point(344, 362);
            this.btnCancelTransactions.Name = "btnCancelTransactions";
            this.btnCancelTransactions.Size = new System.Drawing.Size(123, 32);
            this.btnCancelTransactions.TabIndex = 59;
            this.btnCancelTransactions.Text = "Cancel";
            this.btnCancelTransactions.UseVisualStyleBackColor = false;
            this.btnCancelTransactions.Click += new System.EventHandler(this.btnCancelTransactions_Click);
            // 
            // btnConfrimTransactions
            // 
            this.btnConfrimTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfrimTransactions.BackColor = System.Drawing.Color.Lime;
            this.btnConfrimTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfrimTransactions.ForeColor = System.Drawing.Color.Black;
            this.btnConfrimTransactions.Location = new System.Drawing.Point(200, 362);
            this.btnConfrimTransactions.Name = "btnConfrimTransactions";
            this.btnConfrimTransactions.Size = new System.Drawing.Size(123, 32);
            this.btnConfrimTransactions.TabIndex = 58;
            this.btnConfrimTransactions.Text = "Confirm";
            this.btnConfrimTransactions.UseVisualStyleBackColor = false;
            this.btnConfrimTransactions.Click += new System.EventHandler(this.btnConfrimTransactions_Click);
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteTransactions);
            this.Controls.Add(this.btnCancelTransactions);
            this.Controls.Add(this.btnConfrimTransactions);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TransactionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteTransactions;
        private System.Windows.Forms.Button btnCancelTransactions;
        private System.Windows.Forms.Button btnConfrimTransactions;
    }
}