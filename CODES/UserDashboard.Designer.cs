namespace CODES
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panelHero = new System.Windows.Forms.Panel();
            this.btnViewItems = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFeatures = new System.Windows.Forms.Panel();
            this.panelCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Desc = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.panelCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Desc = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.panelCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Desc = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.lblFeaturesTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelHero.SuspendLayout();
            this.panelFeatures.SuspendLayout();
            this.panelCard3.SuspendLayout();
            this.panelCard2.SuspendLayout();
            this.panelCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 80);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.button4.Location = new System.Drawing.Point(1060, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(601, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Purchase";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(490, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(90, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 30);
            this.label13.TabIndex = 0;
            this.label13.Text = "CoDeS Merch";
            // 
            // panelHero
            // 
            this.panelHero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelHero.Controls.Add(this.btnViewItems);
            this.panelHero.Controls.Add(this.label5);
            this.panelHero.Controls.Add(this.label4);
            this.panelHero.Controls.Add(this.label3);
            this.panelHero.Controls.Add(this.label2);
            this.panelHero.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHero.Location = new System.Drawing.Point(0, 80);
            this.panelHero.Name = "panelHero";
            this.panelHero.Padding = new System.Windows.Forms.Padding(50, 80, 50, 60);
            this.panelHero.Size = new System.Drawing.Size(1200, 380);
            this.panelHero.TabIndex = 1;
            // 
            // btnViewItems
            // 
            this.btnViewItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnViewItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewItems.FlatAppearance.BorderSize = 0;
            this.btnViewItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewItems.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnViewItems.ForeColor = System.Drawing.Color.White;
            this.btnViewItems.Location = new System.Drawing.Point(470, 270);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(260, 60);
            this.btnViewItems.TabIndex = 4;
            this.btnViewItems.Text = "View Items";
            this.btnViewItems.UseVisualStyleBackColor = false;
            this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label5.Location = new System.Drawing.Point(320, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(560, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "for merchandise transactions.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(320, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "A basic and reliable system";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(250, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(700, 80);
            this.label3.TabIndex = 1;
            this.label3.Text = "Merchandise";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(250, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(700, 80);
            this.label2.TabIndex = 0;
            this.label2.Text = "CoDeS Official";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelFeatures
            // 
            this.panelFeatures.AutoScroll = true;
            this.panelFeatures.BackColor = System.Drawing.Color.White;
            this.panelFeatures.Controls.Add(this.panelCard3);
            this.panelFeatures.Controls.Add(this.panelCard2);
            this.panelFeatures.Controls.Add(this.panelCard1);
            this.panelFeatures.Controls.Add(this.lblFeaturesTitle);
            this.panelFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeatures.Location = new System.Drawing.Point(0, 460);
            this.panelFeatures.Name = "panelFeatures";
            this.panelFeatures.Padding = new System.Windows.Forms.Padding(80, 60, 80, 100);
            this.panelFeatures.Size = new System.Drawing.Size(1200, 289);
            this.panelFeatures.TabIndex = 2;
            this.panelFeatures.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFeatures_Paint);
            // 
            // panelCard3
            // 
            this.panelCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelCard3.Controls.Add(this.lblCard3Desc);
            this.panelCard3.Controls.Add(this.lblCard3Title);
            this.panelCard3.Location = new System.Drawing.Point(800, 105);
            this.panelCard3.Name = "panelCard3";
            this.panelCard3.Padding = new System.Windows.Forms.Padding(30);
            this.panelCard3.Size = new System.Drawing.Size(320, 150);
            this.panelCard3.TabIndex = 3;
            // 
            // lblCard3Desc
            // 
            this.lblCard3Desc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCard3Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblCard3Desc.Location = new System.Drawing.Point(30, 80);
            this.lblCard3Desc.Name = "lblCard3Desc";
            this.lblCard3Desc.Size = new System.Drawing.Size(260, 70);
            this.lblCard3Desc.TabIndex = 1;
            this.lblCard3Desc.Text = "Get the best deals and exclusive offers on our products.";
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblCard3Title.Location = new System.Drawing.Point(30, 30);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(260, 40);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "💰 Great Prices";
            // 
            // panelCard2
            // 
            this.panelCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panelCard2.Controls.Add(this.lblCard2Desc);
            this.panelCard2.Controls.Add(this.lblCard2Title);
            this.panelCard2.Location = new System.Drawing.Point(440, 104);
            this.panelCard2.Name = "panelCard2";
            this.panelCard2.Padding = new System.Windows.Forms.Padding(30);
            this.panelCard2.Size = new System.Drawing.Size(320, 150);
            this.panelCard2.TabIndex = 2;
            // 
            // lblCard2Desc
            // 
            this.lblCard2Desc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCard2Desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblCard2Desc.Location = new System.Drawing.Point(30, 80);
            this.lblCard2Desc.Name = "lblCard2Desc";
            this.lblCard2Desc.Size = new System.Drawing.Size(260, 70);
            this.lblCard2Desc.TabIndex = 1;
            this.lblCard2Desc.Text = "Quick and easy checkout process for a smooth shopping experience.";
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblCard2Title.Location = new System.Drawing.Point(30, 30);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(260, 40);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "⚡ Fast Checkout";
            // 
            // panelCard1
            // 
            this.panelCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelCard1.Controls.Add(this.lblCard1Desc);
            this.panelCard1.Controls.Add(this.lblCard1Title);
            this.panelCard1.Location = new System.Drawing.Point(80, 104);
            this.panelCard1.Name = "panelCard1";
            this.panelCard1.Padding = new System.Windows.Forms.Padding(30);
            this.panelCard1.Size = new System.Drawing.Size(320, 150);
            this.panelCard1.TabIndex = 1;
            // 
            // lblCard1Desc
            // 
            this.lblCard1Desc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCard1Desc.ForeColor = System.Drawing.Color.White;
            this.lblCard1Desc.Location = new System.Drawing.Point(30, 80);
            this.lblCard1Desc.Name = "lblCard1Desc";
            this.lblCard1Desc.Size = new System.Drawing.Size(260, 70);
            this.lblCard1Desc.TabIndex = 1;
            this.lblCard1Desc.Text = "Browse our wide selection of quality merchandise with ease.";
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblCard1Title.Location = new System.Drawing.Point(30, 30);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(260, 40);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "🛍️ Easy Shopping";
            // 
            // lblFeaturesTitle
            // 
            this.lblFeaturesTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblFeaturesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblFeaturesTitle.Location = new System.Drawing.Point(80, 21);
            this.lblFeaturesTitle.Name = "lblFeaturesTitle";
            this.lblFeaturesTitle.Size = new System.Drawing.Size(1040, 50);
            this.lblFeaturesTitle.TabIndex = 0;
            this.lblFeaturesTitle.Text = "Why Choose CoDeS?";
            this.lblFeaturesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            this.label1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 4;
            this.label6.Visible = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(714, 25);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(100, 35);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.button3_Click);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 749);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFeatures);
            this.Controls.Add(this.panelHero);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1216, 766);
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoDeS Merch - Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelHero.ResumeLayout(false);
            this.panelFeatures.ResumeLayout(false);
            this.panelCard3.ResumeLayout(false);
            this.panelCard2.ResumeLayout(false);
            this.panelCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelHero;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelFeatures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label lblFeaturesTitle;
        private System.Windows.Forms.Panel panelCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Desc;
        private System.Windows.Forms.Panel panelCard2;
        private System.Windows.Forms.Label lblCard2Desc;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Panel panelCard3;
        private System.Windows.Forms.Label lblCard3Desc;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Button btnProfile;
    }
}