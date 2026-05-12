namespace DaMockHotel
{
    partial class Frm_Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_reviews = new System.Windows.Forms.Button();
            this.btn_bookings = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.MaskedTextBox();
            this.progBar_newBook = new System.Windows.Forms.ProgressBar();
            this.progBar_schedRoom = new System.Windows.Forms.ProgressBar();
            this.progBar_checkout = new System.Windows.Forms.ProgressBar();
            this.progBar_checkin = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progBar_latestReviews = new System.Windows.Forms.ProgressBar();
            this.calendar_month = new System.Windows.Forms.MonthCalendar();
            this.pnl_customerSatisfaction = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnl_reservStatistic = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_dontForget = new System.Windows.Forms.Label();
            this.btn_profile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_customerSatisfaction.SuspendLayout();
            this.pnl_reservStatistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_settings);
            this.panel1.Controls.Add(this.btn_reviews);
            this.panel1.Controls.Add(this.btn_bookings);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 653);
            this.panel1.TabIndex = 0;
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Silver;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Location = new System.Drawing.Point(21, 348);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(113, 40);
            this.btn_settings.TabIndex = 17;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_reviews
            // 
            this.btn_reviews.BackColor = System.Drawing.Color.Silver;
            this.btn_reviews.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviews.Location = new System.Drawing.Point(21, 264);
            this.btn_reviews.Name = "btn_reviews";
            this.btn_reviews.Size = new System.Drawing.Size(113, 40);
            this.btn_reviews.TabIndex = 17;
            this.btn_reviews.Text = "Reviews";
            this.btn_reviews.UseVisualStyleBackColor = false;
            this.btn_reviews.Click += new System.EventHandler(this.btn_reviews_Click);
            // 
            // btn_bookings
            // 
            this.btn_bookings.BackColor = System.Drawing.Color.Silver;
            this.btn_bookings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookings.Location = new System.Drawing.Point(21, 180);
            this.btn_bookings.Name = "btn_bookings";
            this.btn_bookings.Size = new System.Drawing.Size(113, 40);
            this.btn_bookings.TabIndex = 2;
            this.btn_bookings.Text = "Bookings";
            this.btn_bookings.UseVisualStyleBackColor = false;
            this.btn_bookings.Click += new System.EventHandler(this.btn_bookings_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.White;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Location = new System.Drawing.Point(21, 99);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(113, 40);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DaMock Hotel";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(732, 24);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(205, 24);
            this.txt_search.TabIndex = 2;
            this.txt_search.Text = "Search";
            // 
            // progBar_newBook
            // 
            this.progBar_newBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.progBar_newBook.ForeColor = System.Drawing.Color.White;
            this.progBar_newBook.Location = new System.Drawing.Point(205, 85);
            this.progBar_newBook.Name = "progBar_newBook";
            this.progBar_newBook.Size = new System.Drawing.Size(218, 68);
            this.progBar_newBook.TabIndex = 3;
            // 
            // progBar_schedRoom
            // 
            this.progBar_schedRoom.ForeColor = System.Drawing.Color.White;
            this.progBar_schedRoom.Location = new System.Drawing.Point(429, 85);
            this.progBar_schedRoom.Name = "progBar_schedRoom";
            this.progBar_schedRoom.Size = new System.Drawing.Size(206, 68);
            this.progBar_schedRoom.TabIndex = 4;
            // 
            // progBar_checkout
            // 
            this.progBar_checkout.Location = new System.Drawing.Point(860, 85);
            this.progBar_checkout.Name = "progBar_checkout";
            this.progBar_checkout.Size = new System.Drawing.Size(223, 68);
            this.progBar_checkout.TabIndex = 5;
            // 
            // progBar_checkin
            // 
            this.progBar_checkin.Location = new System.Drawing.Point(641, 85);
            this.progBar_checkin.Name = "progBar_checkin";
            this.progBar_checkin.Size = new System.Drawing.Size(207, 68);
            this.progBar_checkin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(270, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Booking";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(474, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scheduled Rooms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(695, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Check-in";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.label6.Location = new System.Drawing.Point(920, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Check-out";
            // 
            // progBar_latestReviews
            // 
            this.progBar_latestReviews.BackColor = System.Drawing.Color.White;
            this.progBar_latestReviews.Location = new System.Drawing.Point(205, 367);
            this.progBar_latestReviews.Name = "progBar_latestReviews";
            this.progBar_latestReviews.Size = new System.Drawing.Size(634, 195);
            this.progBar_latestReviews.TabIndex = 11;
            // 
            // calendar_month
            // 
            this.calendar_month.Location = new System.Drawing.Point(860, 172);
            this.calendar_month.Name = "calendar_month";
            this.calendar_month.TabIndex = 12;
            this.calendar_month.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pnl_customerSatisfaction
            // 
            this.pnl_customerSatisfaction.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_customerSatisfaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_customerSatisfaction.Controls.Add(this.label8);
            this.pnl_customerSatisfaction.Location = new System.Drawing.Point(860, 367);
            this.pnl_customerSatisfaction.Name = "pnl_customerSatisfaction";
            this.pnl_customerSatisfaction.Size = new System.Drawing.Size(227, 257);
            this.pnl_customerSatisfaction.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Satisfaction";
            // 
            // pnl_reservStatistic
            // 
            this.pnl_reservStatistic.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_reservStatistic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_reservStatistic.Controls.Add(this.label7);
            this.pnl_reservStatistic.Location = new System.Drawing.Point(205, 171);
            this.pnl_reservStatistic.Name = "pnl_reservStatistic";
            this.pnl_reservStatistic.Size = new System.Drawing.Size(643, 163);
            this.pnl_reservStatistic.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.label7.Location = new System.Drawing.Point(10, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reservation Statistic";
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(198, 5);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(318, 37);
            this.lbl_welcome.TabIndex = 15;
            this.lbl_welcome.Text = "Welcome to Dashboard";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(216, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Latest Reviews";
            // 
            // lbl_dontForget
            // 
            this.lbl_dontForget.AutoSize = true;
            this.lbl_dontForget.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbl_dontForget.Location = new System.Drawing.Point(202, 42);
            this.lbl_dontForget.Name = "lbl_dontForget";
            this.lbl_dontForget.Size = new System.Drawing.Size(261, 17);
            this.lbl_dontForget.TabIndex = 18;
            this.lbl_dontForget.Text = "Don\'t forget to control the activity that exist";
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(210)))));
            this.btn_profile.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Location = new System.Drawing.Point(952, 22);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(112, 31);
            this.btn_profile.TabIndex = 19;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1120, 652);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.lbl_dontForget);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.pnl_reservStatistic);
            this.Controls.Add(this.pnl_customerSatisfaction);
            this.Controls.Add(this.calendar_month);
            this.Controls.Add(this.progBar_latestReviews);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progBar_checkin);
            this.Controls.Add(this.progBar_checkout);
            this.Controls.Add(this.progBar_schedRoom);
            this.Controls.Add(this.progBar_newBook);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Dashboard";
            this.Text = "DaMock Hotel - Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_customerSatisfaction.ResumeLayout(false);
            this.pnl_customerSatisfaction.PerformLayout();
            this.pnl_reservStatistic.ResumeLayout(false);
            this.pnl_reservStatistic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progBar_newBook;
        private System.Windows.Forms.ProgressBar progBar_schedRoom;
        private System.Windows.Forms.ProgressBar progBar_checkout;
        private System.Windows.Forms.ProgressBar progBar_checkin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progBar_latestReviews;
        private System.Windows.Forms.MonthCalendar calendar_month;
        private System.Windows.Forms.Panel pnl_customerSatisfaction;
        private System.Windows.Forms.Panel pnl_reservStatistic;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_reviews;
        private System.Windows.Forms.Button btn_bookings;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_dontForget;
        private System.Windows.Forms.Button btn_profile;
    }
}