namespace CODES
{
    partial class Profile
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelAccountActions = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelStatCard3 = new System.Windows.Forms.Panel();
            this.lblLastOrderValue = new System.Windows.Forms.Label();
            this.lblLastOrderTitle = new System.Windows.Forms.Label();
            this.panelStatCard2 = new System.Windows.Forms.Panel();
            this.lblTotalSpentValue = new System.Windows.Forms.Label();
            this.lblTotalSpentTitle = new System.Windows.Forms.Label();
            this.panelStatCard1 = new System.Windows.Forms.Panel();
            this.lblTotalOrdersValue = new System.Windows.Forms.Label();
            this.lblTotalOrdersTitle = new System.Windows.Forms.Label();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.lblMemberSinceValue = new System.Windows.Forms.Label();
            this.lblMemberSinceLbl = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblStatusLbl = new System.Windows.Forms.Label();
            this.lblRoleValue = new System.Windows.Forms.Label();
            this.lblRoleLbl = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblEmailLbl = new System.Windows.Forms.Label();
            this.lblUsernameValue = new System.Windows.Forms.Label();
            this.lblUsernameLbl = new System.Windows.Forms.Label();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelAccountActions.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelStatCard3.SuspendLayout();
            this.panelStatCard2.SuspendLayout();
            this.panelStatCard1.SuspendLayout();
            this.panelUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.lblProfile);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(780, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblProfile.Location = new System.Drawing.Point(30, 18);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(140, 51);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "Profile";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(165, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 51);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Overview";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(30);
            this.panelMain.Size = new System.Drawing.Size(900, 570);
            this.panelMain.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelAccountActions);
            this.panelContent.Controls.Add(this.panelStats);
            this.panelContent.Controls.Add(this.panelUserInfo);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(30, 30);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(840, 510);
            this.panelContent.TabIndex = 0;
            // 
            // panelAccountActions
            // 
            this.panelAccountActions.BackColor = System.Drawing.Color.White;
            this.panelAccountActions.Controls.Add(this.btnLogout);
            this.panelAccountActions.Controls.Add(this.btnChangePassword);
            this.panelAccountActions.Location = new System.Drawing.Point(0, 430);
            this.panelAccountActions.Name = "panelAccountActions";
            this.panelAccountActions.Padding = new System.Windows.Forms.Padding(30);
            this.panelAccountActions.Size = new System.Drawing.Size(840, 80);
            this.panelAccountActions.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(500, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnChangePassword.Location = new System.Drawing.Point(140, 15);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(220, 50);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "🔒 Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.panelStatCard3);
            this.panelStats.Controls.Add(this.panelStatCard2);
            this.panelStats.Controls.Add(this.panelStatCard1);
            this.panelStats.Location = new System.Drawing.Point(0, 300);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(840, 110);
            this.panelStats.TabIndex = 1;
            // 
            // panelStatCard3
            // 
            this.panelStatCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.panelStatCard3.Controls.Add(this.lblLastOrderValue);
            this.panelStatCard3.Controls.Add(this.lblLastOrderTitle);
            this.panelStatCard3.Location = new System.Drawing.Point(570, 10);
            this.panelStatCard3.Name = "panelStatCard3";
            this.panelStatCard3.Padding = new System.Windows.Forms.Padding(20);
            this.panelStatCard3.Size = new System.Drawing.Size(250, 90);
            this.panelStatCard3.TabIndex = 2;
            // 
            // lblLastOrderValue
            // 
            this.lblLastOrderValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblLastOrderValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLastOrderValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblLastOrderValue.Location = new System.Drawing.Point(20, 45);
            this.lblLastOrderValue.Name = "lblLastOrderValue";
            this.lblLastOrderValue.Size = new System.Drawing.Size(210, 25);
            this.lblLastOrderValue.TabIndex = 1;
            this.lblLastOrderValue.Text = "No orders yet";
            this.lblLastOrderValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastOrderTitle
            // 
            this.lblLastOrderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLastOrderTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastOrderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblLastOrderTitle.Location = new System.Drawing.Point(20, 20);
            this.lblLastOrderTitle.Name = "lblLastOrderTitle";
            this.lblLastOrderTitle.Size = new System.Drawing.Size(210, 25);
            this.lblLastOrderTitle.TabIndex = 0;
            this.lblLastOrderTitle.Text = "🕒 Last Order";
            this.lblLastOrderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStatCard2
            // 
            this.panelStatCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panelStatCard2.Controls.Add(this.lblTotalSpentValue);
            this.panelStatCard2.Controls.Add(this.lblTotalSpentTitle);
            this.panelStatCard2.Location = new System.Drawing.Point(295, 10);
            this.panelStatCard2.Name = "panelStatCard2";
            this.panelStatCard2.Padding = new System.Windows.Forms.Padding(20);
            this.panelStatCard2.Size = new System.Drawing.Size(250, 90);
            this.panelStatCard2.TabIndex = 1;
            // 
            // lblTotalSpentValue
            // 
            this.lblTotalSpentValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalSpentValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblTotalSpentValue.Location = new System.Drawing.Point(20, 45);
            this.lblTotalSpentValue.Name = "lblTotalSpentValue";
            this.lblTotalSpentValue.Size = new System.Drawing.Size(210, 25);
            this.lblTotalSpentValue.TabIndex = 1;
            this.lblTotalSpentValue.Text = "₱0.00";
            this.lblTotalSpentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalSpentTitle
            // 
            this.lblTotalSpentTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalSpentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblTotalSpentTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTotalSpentTitle.Name = "lblTotalSpentTitle";
            this.lblTotalSpentTitle.Size = new System.Drawing.Size(210, 25);
            this.lblTotalSpentTitle.TabIndex = 0;
            this.lblTotalSpentTitle.Text = "💰 Total Spent";
            this.lblTotalSpentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelStatCard1
            // 
            this.panelStatCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panelStatCard1.Controls.Add(this.lblTotalOrdersValue);
            this.panelStatCard1.Controls.Add(this.lblTotalOrdersTitle);
            this.panelStatCard1.Location = new System.Drawing.Point(20, 10);
            this.panelStatCard1.Name = "panelStatCard1";
            this.panelStatCard1.Padding = new System.Windows.Forms.Padding(20);
            this.panelStatCard1.Size = new System.Drawing.Size(250, 90);
            this.panelStatCard1.TabIndex = 0;
            // 
            // lblTotalOrdersValue
            // 
            this.lblTotalOrdersValue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotalOrdersValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrdersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.lblTotalOrdersValue.Location = new System.Drawing.Point(20, 45);
            this.lblTotalOrdersValue.Name = "lblTotalOrdersValue";
            this.lblTotalOrdersValue.Size = new System.Drawing.Size(210, 25);
            this.lblTotalOrdersValue.TabIndex = 1;
            this.lblTotalOrdersValue.Text = "0";
            this.lblTotalOrdersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalOrdersTitle
            // 
            this.lblTotalOrdersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalOrdersTitle.ForeColor = System.Drawing.Color.White;
            this.lblTotalOrdersTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            this.lblTotalOrdersTitle.Size = new System.Drawing.Size(210, 25);
            this.lblTotalOrdersTitle.TabIndex = 0;
            this.lblTotalOrdersTitle.Text = "📦 Total Orders";
            this.lblTotalOrdersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.White;
            this.panelUserInfo.Controls.Add(this.lblMemberSinceValue);
            this.panelUserInfo.Controls.Add(this.lblMemberSinceLbl);
            this.panelUserInfo.Controls.Add(this.lblStatusValue);
            this.panelUserInfo.Controls.Add(this.lblStatusLbl);
            this.panelUserInfo.Controls.Add(this.lblRoleValue);
            this.panelUserInfo.Controls.Add(this.lblRoleLbl);
            this.panelUserInfo.Controls.Add(this.lblEmailValue);
            this.panelUserInfo.Controls.Add(this.lblEmailLbl);
            this.panelUserInfo.Controls.Add(this.lblUsernameValue);
            this.panelUserInfo.Controls.Add(this.lblUsernameLbl);
            this.panelUserInfo.Controls.Add(this.lblAccountInfo);
            this.panelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Padding = new System.Windows.Forms.Padding(30);
            this.panelUserInfo.Size = new System.Drawing.Size(840, 280);
            this.panelUserInfo.TabIndex = 0;
            // 
            // lblMemberSinceValue
            // 
            this.lblMemberSinceValue.AutoSize = true;
            this.lblMemberSinceValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMemberSinceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lblMemberSinceValue.Location = new System.Drawing.Point(590, 100);
            this.lblMemberSinceValue.Name = "lblMemberSinceValue";
            this.lblMemberSinceValue.Size = new System.Drawing.Size(75, 21);
            this.lblMemberSinceValue.TabIndex = 10;
            this.lblMemberSinceValue.Text = "Loading...";
            // 
            // lblMemberSinceLbl
            // 
            this.lblMemberSinceLbl.AutoSize = true;
            this.lblMemberSinceLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberSinceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblMemberSinceLbl.Location = new System.Drawing.Point(450, 100);
            this.lblMemberSinceLbl.Name = "lblMemberSinceLbl";
            this.lblMemberSinceLbl.Size = new System.Drawing.Size(123, 21);
            this.lblMemberSinceLbl.TabIndex = 9;
            this.lblMemberSinceLbl.Text = "Member Since:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblStatusValue.Location = new System.Drawing.Point(220, 205);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(84, 21);
            this.lblStatusValue.TabIndex = 8;
            this.lblStatusValue.Text = "Loading...";
            // 
            // lblStatusLbl
            // 
            this.lblStatusLbl.AutoSize = true;
            this.lblStatusLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatusLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblStatusLbl.Location = new System.Drawing.Point(50, 205);
            this.lblStatusLbl.Name = "lblStatusLbl";
            this.lblStatusLbl.Size = new System.Drawing.Size(61, 21);
            this.lblStatusLbl.TabIndex = 7;
            this.lblStatusLbl.Text = "Status:";
            // 
            // lblRoleValue
            // 
            this.lblRoleValue.AutoSize = true;
            this.lblRoleValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoleValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblRoleValue.Location = new System.Drawing.Point(220, 170);
            this.lblRoleValue.Name = "lblRoleValue";
            this.lblRoleValue.Size = new System.Drawing.Size(84, 21);
            this.lblRoleValue.TabIndex = 6;
            this.lblRoleValue.Text = "Loading...";
            // 
            // lblRoleLbl
            // 
            this.lblRoleLbl.AutoSize = true;
            this.lblRoleLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblRoleLbl.Location = new System.Drawing.Point(50, 170);
            this.lblRoleLbl.Name = "lblRoleLbl";
            this.lblRoleLbl.Size = new System.Drawing.Size(48, 21);
            this.lblRoleLbl.TabIndex = 5;
            this.lblRoleLbl.Text = "Role:";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lblEmailValue.Location = new System.Drawing.Point(220, 135);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(75, 21);
            this.lblEmailValue.TabIndex = 4;
            this.lblEmailValue.Text = "Loading...";
            // 
            // lblEmailLbl
            // 
            this.lblEmailLbl.AutoSize = true;
            this.lblEmailLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblEmailLbl.Location = new System.Drawing.Point(50, 135);
            this.lblEmailLbl.Name = "lblEmailLbl";
            this.lblEmailLbl.Size = new System.Drawing.Size(57, 21);
            this.lblEmailLbl.TabIndex = 3;
            this.lblEmailLbl.Text = "Email:";
            // 
            // lblUsernameValue
            // 
            this.lblUsernameValue.AutoSize = true;
            this.lblUsernameValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUsernameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lblUsernameValue.Location = new System.Drawing.Point(220, 100);
            this.lblUsernameValue.Name = "lblUsernameValue";
            this.lblUsernameValue.Size = new System.Drawing.Size(75, 21);
            this.lblUsernameValue.TabIndex = 2;
            this.lblUsernameValue.Text = "Loading...";
            // 
            // lblUsernameLbl
            // 
            this.lblUsernameLbl.AutoSize = true;
            this.lblUsernameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblUsernameLbl.Location = new System.Drawing.Point(50, 100);
            this.lblUsernameLbl.Name = "lblUsernameLbl";
            this.lblUsernameLbl.Size = new System.Drawing.Size(91, 21);
            this.lblUsernameLbl.TabIndex = 1;
            this.lblUsernameLbl.Text = "Username:";
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lblAccountInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAccountInfo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAccountInfo.ForeColor = System.Drawing.Color.White;
            this.lblAccountInfo.Location = new System.Drawing.Point(30, 30);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblAccountInfo.Size = new System.Drawing.Size(780, 45);
            this.lblAccountInfo.TabIndex = 0;
            this.lblAccountInfo.Text = "👤 Account Information";
            this.lblAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoDeS - My Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelAccountActions.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelStatCard3.ResumeLayout(false);
            this.panelStatCard2.ResumeLayout(false);
            this.panelStatCard1.ResumeLayout(false);
            this.panelUserInfo.ResumeLayout(false);
            this.panelUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelAccountActions;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Label lblUsernameLbl;
        private System.Windows.Forms.Label lblUsernameValue;
        private System.Windows.Forms.Label lblEmailLbl;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblRoleLbl;
        private System.Windows.Forms.Label lblRoleValue;
        private System.Windows.Forms.Label lblStatusLbl;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblMemberSinceLbl;
        private System.Windows.Forms.Label lblMemberSinceValue;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelStatCard1;
        private System.Windows.Forms.Label lblTotalOrdersValue;
        private System.Windows.Forms.Label lblTotalOrdersTitle;
        private System.Windows.Forms.Panel panelStatCard2;
        private System.Windows.Forms.Label lblTotalSpentValue;
        private System.Windows.Forms.Label lblTotalSpentTitle;
        private System.Windows.Forms.Panel panelStatCard3;
        private System.Windows.Forms.Label lblLastOrderValue;
        private System.Windows.Forms.Label lblLastOrderTitle;
    }
}