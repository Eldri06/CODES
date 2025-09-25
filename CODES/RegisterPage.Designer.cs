namespace CODES
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.lblSystemName = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblRegConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.BackColor = System.Drawing.Color.Transparent;
            this.lblSystemName.Font = new System.Drawing.Font("League Spartan", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemName.ForeColor = System.Drawing.Color.Gold;
            this.lblSystemName.Location = new System.Drawing.Point(222, 149);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(356, 60);
            this.lblSystemName.TabIndex = 22;
            this.lblSystemName.Text = "CoDeS Merch";
            this.lblSystemName.Click += new System.EventHandler(this.lblSystemName_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(338, 38);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(113, 97);
            this.pbLogo.TabIndex = 21;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblRegUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRegUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegUsername.Location = new System.Drawing.Point(251, 216);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(81, 18);
            this.lblRegUsername.TabIndex = 23;
            this.lblRegUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtUsername.Location = new System.Drawing.Point(338, 212);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(179, 27);
            this.txtUsername.TabIndex = 24;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRegPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRegPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegPassword.Location = new System.Drawing.Point(251, 286);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(79, 18);
            this.lblRegPassword.TabIndex = 25;
            this.lblRegPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtPassword.Location = new System.Drawing.Point(338, 283);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(179, 27);
            this.txtPassword.TabIndex = 26;
            // 
            // lblRegConfirmPassword
            // 
            this.lblRegConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegConfirmPassword.AutoSize = true;
            this.lblRegConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRegConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRegConfirmPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegConfirmPassword.Location = new System.Drawing.Point(194, 325);
            this.lblRegConfirmPassword.Name = "lblRegConfirmPassword";
            this.lblRegConfirmPassword.Size = new System.Drawing.Size(136, 18);
            this.lblRegConfirmPassword.TabIndex = 27;
            this.lblRegConfirmPassword.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(337, 319);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(179, 27);
            this.txtConfirmPassword.TabIndex = 28;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.Gold;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(250, 371);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(139, 39);
            this.btnRegister.TabIndex = 30;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Gold;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(428, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 39);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblRegEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblRegEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegEmail.Location = new System.Drawing.Point(281, 251);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(49, 18);
            this.lblRegEmail.TabIndex = 31;
            this.lblRegEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtEmail.Location = new System.Drawing.Point(338, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 27);
            this.txtEmail.TabIndex = 32;
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRegEmail);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblRegConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblRegPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblRegUsername);
            this.Controls.Add(this.lblSystemName);
            this.Controls.Add(this.pbLogo);
            this.Name = "RegisterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblRegUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRegConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}