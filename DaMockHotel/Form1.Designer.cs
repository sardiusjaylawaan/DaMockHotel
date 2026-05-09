namespace DaMockHotel
{
    partial class frmLogin
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
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_CreateAcc = new System.Windows.Forms.Button();
            this.lbl_NoAccount = new System.Windows.Forms.Label();
            this.pnl_Left = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lnk_Forgot = new System.Windows.Forms.LinkLabel();
            this.lbl_Tagline = new System.Windows.Forms.Label();
            this.lbl_Hotel = new System.Windows.Forms.Label();
            this.pnl_LoginCard = new System.Windows.Forms.Panel();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.lbl_WelcomeLeft = new System.Windows.Forms.Label();
            this.pnl_Left.SuspendLayout();
            this.pnl_LoginCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(45, 142);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(260, 27);
            this.txt_Username.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(45, 214);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(260, 27);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Welcome.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.lbl_Welcome.Location = new System.Drawing.Point(44, 27);
            this.lbl_Welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(260, 40);
            this.lbl_Welcome.TabIndex = 2;
            this.lbl_Welcome.Text = "Welcome Back";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(44, 267);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(260, 38);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(44, 117);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(120, 22);
            this.lbl_Username.TabIndex = 4;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(44, 189);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(120, 22);
            this.lbl_Password.TabIndex = 5;
            this.lbl_Password.Text = "Password ";
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // btn_CreateAcc
            // 
            this.btn_CreateAcc.BackColor = System.Drawing.Color.Gray;
            this.btn_CreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateAcc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_CreateAcc.FlatAppearance.BorderSize = 0;
            this.btn_CreateAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_CreateAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.btn_CreateAcc.Location = new System.Drawing.Point(207, 357);
            this.btn_CreateAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CreateAcc.Name = "btn_CreateAcc";
            this.btn_CreateAcc.Size = new System.Drawing.Size(115, 32);
            this.btn_CreateAcc.TabIndex = 7;
            this.btn_CreateAcc.Text = "Create Account";
            this.btn_CreateAcc.UseVisualStyleBackColor = false;
            this.btn_CreateAcc.Click += new System.EventHandler(this.btn_CreateAcc_Click);
            // 
            // lbl_NoAccount
            // 
            this.lbl_NoAccount.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_NoAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(100)))), ((int)(((byte)(115)))));
            this.lbl_NoAccount.Location = new System.Drawing.Point(49, 365);
            this.lbl_NoAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NoAccount.Name = "lbl_NoAccount";
            this.lbl_NoAccount.Size = new System.Drawing.Size(150, 18);
            this.lbl_NoAccount.TabIndex = 9;
            this.lbl_NoAccount.Text = "Don\'t have an account?";
            this.lbl_NoAccount.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Left
            // 
            this.pnl_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.pnl_Left.Controls.Add(this.lbl_WelcomeLeft);
            this.pnl_Left.Controls.Add(this.label1);
            this.pnl_Left.Location = new System.Drawing.Point(0, 0);
            this.pnl_Left.Name = "pnl_Left";
            this.pnl_Left.Size = new System.Drawing.Size(480, 600);
            this.pnl_Left.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(67, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Login to manage your bookings ";
            // 
            // lnk_Forgot
            // 
            this.lnk_Forgot.BackColor = System.Drawing.Color.LightGray;
            this.lnk_Forgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.lnk_Forgot.Location = new System.Drawing.Point(119, 317);
            this.lnk_Forgot.Name = "lnk_Forgot";
            this.lnk_Forgot.Size = new System.Drawing.Size(114, 20);
            this.lnk_Forgot.TabIndex = 11;
            this.lnk_Forgot.TabStop = true;
            this.lnk_Forgot.Text = "Forgot password?";
            // 
            // lbl_Tagline
            // 
            this.lbl_Tagline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.lbl_Tagline.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tagline.ForeColor = System.Drawing.Color.White;
            this.lbl_Tagline.Location = new System.Drawing.Point(64, 220);
            this.lbl_Tagline.Name = "lbl_Tagline";
            this.lbl_Tagline.Size = new System.Drawing.Size(350, 30);
            this.lbl_Tagline.TabIndex = 12;
            this.lbl_Tagline.Text = "Simple. Comfortable. Secure.";
            // 
            // lbl_Hotel
            // 
            this.lbl_Hotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.lbl_Hotel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hotel.ForeColor = System.Drawing.Color.White;
            this.lbl_Hotel.Location = new System.Drawing.Point(60, 160);
            this.lbl_Hotel.Name = "lbl_Hotel";
            this.lbl_Hotel.Size = new System.Drawing.Size(360, 50);
            this.lbl_Hotel.TabIndex = 13;
            this.lbl_Hotel.Text = "DaMock Hotel";
            // 
            // pnl_LoginCard
            // 
            this.pnl_LoginCard.BackColor = System.Drawing.Color.LightGray;
            this.pnl_LoginCard.Controls.Add(this.lbl_Subtitle);
            this.pnl_LoginCard.Controls.Add(this.lbl_NoAccount);
            this.pnl_LoginCard.Controls.Add(this.lbl_Welcome);
            this.pnl_LoginCard.Controls.Add(this.txt_Username);
            this.pnl_LoginCard.Controls.Add(this.lnk_Forgot);
            this.pnl_LoginCard.Controls.Add(this.txt_Password);
            this.pnl_LoginCard.Controls.Add(this.lbl_Username);
            this.pnl_LoginCard.Controls.Add(this.btn_Login);
            this.pnl_LoginCard.Controls.Add(this.lbl_Password);
            this.pnl_LoginCard.Controls.Add(this.btn_CreateAcc);
            this.pnl_LoginCard.Location = new System.Drawing.Point(605, 94);
            this.pnl_LoginCard.Name = "pnl_LoginCard";
            this.pnl_LoginCard.Size = new System.Drawing.Size(360, 410);
            this.pnl_LoginCard.TabIndex = 14;
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(125)))));
            this.lbl_Subtitle.Location = new System.Drawing.Point(46, 72);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(260, 24);
            this.lbl_Subtitle.TabIndex = 15;
            this.lbl_Subtitle.Text = "Please login to your account";
            // 
            // lbl_WelcomeLeft
            // 
            this.lbl_WelcomeLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.lbl_WelcomeLeft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WelcomeLeft.ForeColor = System.Drawing.Color.White;
            this.lbl_WelcomeLeft.Location = new System.Drawing.Point(64, 292);
            this.lbl_WelcomeLeft.Name = "lbl_WelcomeLeft";
            this.lbl_WelcomeLeft.Size = new System.Drawing.Size(300, 35);
            this.lbl_WelcomeLeft.TabIndex = 16;
            this.lbl_WelcomeLeft.Text = "Welcome back";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1070, 600);
            this.Controls.Add(this.lbl_Hotel);
            this.Controls.Add(this.lbl_Tagline);
            this.Controls.Add(this.pnl_Left);
            this.Controls.Add(this.pnl_LoginCard);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaMock Hotel - Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnl_Left.ResumeLayout(false);
            this.pnl_LoginCard.ResumeLayout(false);
            this.pnl_LoginCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_CreateAcc;
        private System.Windows.Forms.Label lbl_NoAccount;
        private System.Windows.Forms.Panel pnl_Left;
        private System.Windows.Forms.LinkLabel lnk_Forgot;
        private System.Windows.Forms.Label lbl_Tagline;
        private System.Windows.Forms.Label lbl_Hotel;
        private System.Windows.Forms.Panel pnl_LoginCard;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.Label lbl_WelcomeLeft;
        private System.Windows.Forms.Label label1;
    }
}

