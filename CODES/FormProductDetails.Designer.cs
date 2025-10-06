namespace CODES
{
    partial class FormProductDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.pbProductImage = new System.Windows.Forms.PictureBox();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmPurchase = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelImageSection = new System.Windows.Forms.Panel();
            this.panelDetailsSection = new System.Windows.Forms.Panel();
            this.panelInfoCard = new System.Windows.Forms.Panel();
            this.panelQuantityCard = new System.Windows.Forms.Panel();
            this.panelActions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelImageSection.SuspendLayout();
            this.panelDetailsSection.SuspendLayout();
            this.panelInfoCard.SuspendLayout();
            this.panelQuantityCard.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
           
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "Details";
             
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblSystemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblSystemName.Location = new System.Drawing.Point(30, 25);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(185, 59);
            this.lblSystemName.TabIndex = 25;
            this.lblSystemName.Text = "Product";
           
            this.pbProductImage.BackColor = System.Drawing.Color.White;
            this.pbProductImage.Location = new System.Drawing.Point(40, 40);
            this.pbProductImage.Name = "pbProductImage";
            this.pbProductImage.Size = new System.Drawing.Size(300, 300);
            this.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProductImage.TabIndex = 26;
            this.pbProductImage.TabStop = false;
           
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRegUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblRegUsername.Location = new System.Drawing.Point(30, 30);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(124, 21);
            this.lblRegUsername.TabIndex = 27;
            this.lblRegUsername.Text = "Product Name:";
           
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(30, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Price:";
            
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Available Stock:";
            
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(30, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quantity:";
          
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(30, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Total Price: ₱";
         
            this.btnConfirmPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnConfirmPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPurchase.FlatAppearance.BorderSize = 0;
            this.btnConfirmPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPurchase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPurchase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnConfirmPurchase.Location = new System.Drawing.Point(260, 20);
            this.btnConfirmPurchase.Name = "btnConfirmPurchase";
            this.btnConfirmPurchase.Size = new System.Drawing.Size(200, 50);
            this.btnConfirmPurchase.TabIndex = 32;
            this.btnConfirmPurchase.Text = "Confirm Purchase";
            this.btnConfirmPurchase.UseVisualStyleBackColor = false;
            this.btnConfirmPurchase.Click += new System.EventHandler(this.btnConfirmPurchase_Click_1);
           
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(30, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 50);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
           
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblProductName.Location = new System.Drawing.Point(30, 60);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(430, 30);
            this.lblProductName.TabIndex = 34;
            this.lblProductName.Text = "Product Name Here";
         
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(84, 106);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(62, 25);
            this.lblPrice.TabIndex = 35;
            this.lblPrice.Text = "₱0.00";
          
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblStock.Location = new System.Drawing.Point(169, 147);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(19, 21);
            this.lblStock.TabIndex = 36;
            this.lblStock.Text = "0";
           
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(152, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 32);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "0.00";
           
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.nudQuantity.Location = new System.Drawing.Point(120, 28);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 31);
            this.nudQuantity.TabIndex = 39;
            this.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelHeader.Controls.Add(this.lblSystemName);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 100);
            this.panelHeader.TabIndex = 0;
            
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelImageSection);
            this.panelMain.Controls.Add(this.panelDetailsSection);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(50, 40, 50, 40);
            this.panelMain.Size = new System.Drawing.Size(1000, 550);
            this.panelMain.TabIndex = 1;
            
            this.panelImageSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelImageSection.Controls.Add(this.pbProductImage);
            this.panelImageSection.Location = new System.Drawing.Point(50, 40);
            this.panelImageSection.Name = "panelImageSection";
            this.panelImageSection.Size = new System.Drawing.Size(380, 380);
            this.panelImageSection.TabIndex = 0;
           
            this.panelDetailsSection.BackColor = System.Drawing.Color.White;
            this.panelDetailsSection.Controls.Add(this.panelInfoCard);
            this.panelDetailsSection.Controls.Add(this.panelQuantityCard);
            this.panelDetailsSection.Controls.Add(this.panelActions);
            this.panelDetailsSection.Location = new System.Drawing.Point(460, 40);
            this.panelDetailsSection.Name = "panelDetailsSection";
            this.panelDetailsSection.Size = new System.Drawing.Size(490, 470);
            this.panelDetailsSection.TabIndex = 1;
          
            this.panelInfoCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelInfoCard.Controls.Add(this.lblRegUsername);
            this.panelInfoCard.Controls.Add(this.lblProductName);
            this.panelInfoCard.Controls.Add(this.label2);
            this.panelInfoCard.Controls.Add(this.lblPrice);
            this.panelInfoCard.Controls.Add(this.label3);
            this.panelInfoCard.Controls.Add(this.lblStock);
            this.panelInfoCard.Location = new System.Drawing.Point(0, 0);
            this.panelInfoCard.Name = "panelInfoCard";
            this.panelInfoCard.Padding = new System.Windows.Forms.Padding(30);
            this.panelInfoCard.Size = new System.Drawing.Size(490, 200);
            this.panelInfoCard.TabIndex = 0;
           
            this.panelQuantityCard.BackColor = System.Drawing.Color.White;
            this.panelQuantityCard.Controls.Add(this.label4);
            this.panelQuantityCard.Controls.Add(this.nudQuantity);
            this.panelQuantityCard.Controls.Add(this.label5);
            this.panelQuantityCard.Controls.Add(this.lblTotal);
            this.panelQuantityCard.Location = new System.Drawing.Point(0, 220);
            this.panelQuantityCard.Name = "panelQuantityCard";
            this.panelQuantityCard.Padding = new System.Windows.Forms.Padding(30);
            this.panelQuantityCard.Size = new System.Drawing.Size(490, 130);
            this.panelQuantityCard.TabIndex = 1;
         
            this.panelActions.BackColor = System.Drawing.Color.White;
            this.panelActions.Controls.Add(this.btnConfirmPurchase);
            this.panelActions.Controls.Add(this.btnClose);
            this.panelActions.Location = new System.Drawing.Point(0, 370);
            this.panelActions.Name = "panelActions";
            this.panelActions.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelActions.Size = new System.Drawing.Size(490, 100);
            this.panelActions.TabIndex = 2;
         
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoDeS Merch - Product Details";
            ((System.ComponentModel.ISupportInitialize)(this.pbProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelImageSection.ResumeLayout(false);
            this.panelDetailsSection.ResumeLayout(false);
            this.panelInfoCard.ResumeLayout(false);
            this.panelInfoCard.PerformLayout();
            this.panelQuantityCard.ResumeLayout(false);
            this.panelQuantityCard.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.PictureBox pbProductImage;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmPurchase;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelImageSection;
        private System.Windows.Forms.Panel panelDetailsSection;
        private System.Windows.Forms.Panel panelInfoCard;
        private System.Windows.Forms.Panel panelQuantityCard;
        private System.Windows.Forms.Panel panelActions;
    }
}