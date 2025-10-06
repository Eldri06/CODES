namespace CODES
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lblTagline = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLoginCard = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblDivider = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelLoginCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelLeft.Controls.Add(this.lblTagline);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(500, 650);
            this.panelLeft.TabIndex = 0;
            // 
            // lblTagline
            // 
            this.lblTagline.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTagline.ForeColor = System.Drawing.Color.White;
            this.lblTagline.Location = new System.Drawing.Point(50, 480);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(400, 60);
            this.lblTagline.TabIndex = 1;
            this.lblTagline.Text = "Your one-stop solution for premium\r\nmerchandise management";
            this.lblTagline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(125, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panelRight.Controls.Add(this.panelLoginCard);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(500, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(80, 100, 80, 100);
            this.panelRight.Size = new System.Drawing.Size(550, 650);
            this.panelRight.TabIndex = 1;
            // 
            // panelLoginCard
            // 
            this.panelLoginCard.BackColor = System.Drawing.Color.White;
            this.panelLoginCard.Controls.Add(this.btnSignUp);
            this.panelLoginCard.Controls.Add(this.lblDivider);
            this.panelLoginCard.Controls.Add(this.btnSignIn);
            this.panelLoginCard.Controls.Add(this.lblSubtitle);
            this.panelLoginCard.Controls.Add(this.label1);
            this.panelLoginCard.Controls.Add(this.lblSystemName);
            this.panelLoginCard.Controls.Add(this.lblWelcomeBack);
            this.panelLoginCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginCard.Location = new System.Drawing.Point(80, 100);
            this.panelLoginCard.Name = "panelLoginCard";
            this.panelLoginCard.Padding = new System.Windows.Forms.Padding(40);
            this.panelLoginCard.Size = new System.Drawing.Size(390, 450);
            this.panelLoginCard.TabIndex = 0;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.White;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignUp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSignUp.FlatAppearance.BorderSize = 2;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSignUp.Location = new System.Drawing.Point(40, 330);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(310, 50);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Create Account";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblDivider
            // 
            this.lblDivider.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDivider.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDivider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.lblDivider.Location = new System.Drawing.Point(40, 270);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.lblDivider.Size = new System.Drawing.Size(310, 60);
            this.lblDivider.TabIndex = 5;
            this.lblDivider.Text = "or";
            this.lblDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDivider.Click += new System.EventHandler(this.lblDivider_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(40, 220);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(310, 50);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Login";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.lblSubtitle.Location = new System.Drawing.Point(40, 155);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 25);
            this.lblSubtitle.Size = new System.Drawing.Size(310, 65);
            this.lblSubtitle.TabIndex = 3;
            this.lblSubtitle.Text = "Login to your account to continue";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(40, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Merchandise";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSystemName
            // 
            this.lblSystemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSystemName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblSystemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblSystemName.Location = new System.Drawing.Point(40, 65);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(310, 44);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "CoDeS";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSystemName.Click += new System.EventHandler(this.lblSystemName_Click);
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcomeBack.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblWelcomeBack.Location = new System.Drawing.Point(40, 40);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.Size = new System.Drawing.Size(310, 25);
            this.lblWelcomeBack.TabIndex = 0;
            this.lblWelcomeBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1066, 689);
            this.Name = "LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoDeS Merchandise - Welcome";
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelLoginCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLoginCard;
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Button btnSignUp;
    }
}
