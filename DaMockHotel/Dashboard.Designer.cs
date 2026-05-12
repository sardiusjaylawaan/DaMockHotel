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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbBookingHistory = new System.Windows.Forms.GroupBox();
            this.gbReservationDetails = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbCustomerSupp = new System.Windows.Forms.GroupBox();
            this.dgvBookingHIstory = new System.Windows.Forms.DataGridView();
            this.clmCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_CheckIn = new System.Windows.Forms.TextBox();
            this.txt_CheckOut = new System.Windows.Forms.TextBox();
            this.txt_Room = new System.Windows.Forms.TextBox();
            this.txt_TotalCost = new System.Windows.Forms.TextBox();
            this.txt_Guests = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            this.gbBookingHistory.SuspendLayout();
            this.gbReservationDetails.SuspendLayout();
            this.gbCustomerSupp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHIstory)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(140, 805);
            this.panel1.TabIndex = 0;
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Silver;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.Location = new System.Drawing.Point(21, 301);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(93, 30);
            this.btn_settings.TabIndex = 17;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_reviews
            // 
            this.btn_reviews.BackColor = System.Drawing.Color.Silver;
            this.btn_reviews.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviews.Location = new System.Drawing.Point(21, 233);
            this.btn_reviews.Name = "btn_reviews";
            this.btn_reviews.Size = new System.Drawing.Size(93, 34);
            this.btn_reviews.TabIndex = 17;
            this.btn_reviews.Text = "Reviews";
            this.btn_reviews.UseVisualStyleBackColor = false;
            this.btn_reviews.Click += new System.EventHandler(this.btn_reviews_Click);
            // 
            // btn_bookings
            // 
            this.btn_bookings.BackColor = System.Drawing.Color.Silver;
            this.btn_bookings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookings.Location = new System.Drawing.Point(21, 170);
            this.btn_bookings.Name = "btn_bookings";
            this.btn_bookings.Size = new System.Drawing.Size(93, 30);
            this.btn_bookings.TabIndex = 2;
            this.btn_bookings.Text = "Bookings";
            this.btn_bookings.UseVisualStyleBackColor = false;
            this.btn_bookings.Click += new System.EventHandler(this.btn_bookings_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.White;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Location = new System.Drawing.Point(21, 99);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(93, 31);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "DaMock Hotel";
            // 
            // pnlProfile
            // 
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProfile.Controls.Add(this.textBox1);
            this.pnlProfile.Controls.Add(this.label1);
            this.pnlProfile.Controls.Add(this.btnLogout);
            this.pnlProfile.Controls.Add(this.btnProfile);
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfile.Location = new System.Drawing.Point(0, 0);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(1120, 55);
            this.pnlProfile.TabIndex = 2;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(865, 10);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(84, 25);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Navy;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(955, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(84, 25);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome, ";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(750, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // gbBookingHistory
            // 
            this.gbBookingHistory.Controls.Add(this.dgvBookingHIstory);
            this.gbBookingHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookingHistory.Location = new System.Drawing.Point(160, 100);
            this.gbBookingHistory.Name = "gbBookingHistory";
            this.gbBookingHistory.Size = new System.Drawing.Size(489, 168);
            this.gbBookingHistory.TabIndex = 3;
            this.gbBookingHistory.TabStop = false;
            this.gbBookingHistory.Text = "Booking History";
            // 
            // gbReservationDetails
            // 
            this.gbReservationDetails.Controls.Add(this.txt_Guests);
            this.gbReservationDetails.Controls.Add(this.txt_TotalCost);
            this.gbReservationDetails.Controls.Add(this.txt_Room);
            this.gbReservationDetails.Controls.Add(this.txt_CheckOut);
            this.gbReservationDetails.Controls.Add(this.txt_CheckIn);
            this.gbReservationDetails.Controls.Add(this.label9);
            this.gbReservationDetails.Controls.Add(this.label8);
            this.gbReservationDetails.Controls.Add(this.label7);
            this.gbReservationDetails.Controls.Add(this.label6);
            this.gbReservationDetails.Controls.Add(this.label5);
            this.gbReservationDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReservationDetails.Location = new System.Drawing.Point(655, 111);
            this.gbReservationDetails.Name = "gbReservationDetails";
            this.gbReservationDetails.Size = new System.Drawing.Size(442, 293);
            this.gbReservationDetails.TabIndex = 4;
            this.gbReservationDetails.TabStop = false;
            this.gbReservationDetails.Text = "Reservation Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(160, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 170);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // gbCustomerSupp
            // 
            this.gbCustomerSupp.BackColor = System.Drawing.Color.GhostWhite;
            this.gbCustomerSupp.Controls.Add(this.panel2);
            this.gbCustomerSupp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerSupp.Location = new System.Drawing.Point(655, 410);
            this.gbCustomerSupp.Name = "gbCustomerSupp";
            this.gbCustomerSupp.Size = new System.Drawing.Size(442, 134);
            this.gbCustomerSupp.TabIndex = 4;
            this.gbCustomerSupp.TabStop = false;
            this.gbCustomerSupp.Text = "Customer Support";
            // 
            // dgvBookingHIstory
            // 
            this.dgvBookingHIstory.AllowUserToAddRows = false;
            this.dgvBookingHIstory.AllowUserToDeleteRows = false;
            this.dgvBookingHIstory.AllowUserToOrderColumns = true;
            this.dgvBookingHIstory.AllowUserToResizeColumns = false;
            this.dgvBookingHIstory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingHIstory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBookingHIstory.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookingHIstory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBookingHIstory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCheckIn,
            this.clmCheckOut,
            this.clmRoomType,
            this.clmPaymentStatus});
            this.dgvBookingHIstory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookingHIstory.GridColor = System.Drawing.Color.White;
            this.dgvBookingHIstory.Location = new System.Drawing.Point(3, 21);
            this.dgvBookingHIstory.Name = "dgvBookingHIstory";
            this.dgvBookingHIstory.ReadOnly = true;
            this.dgvBookingHIstory.RowHeadersVisible = false;
            this.dgvBookingHIstory.Size = new System.Drawing.Size(483, 144);
            this.dgvBookingHIstory.TabIndex = 0;
            // 
            // clmCheckIn
            // 
            this.clmCheckIn.HeaderText = "Check-in";
            this.clmCheckIn.Name = "clmCheckIn";
            this.clmCheckIn.ReadOnly = true;
            // 
            // clmCheckOut
            // 
            this.clmCheckOut.HeaderText = "Check-out";
            this.clmCheckOut.Name = "clmCheckOut";
            this.clmCheckOut.ReadOnly = true;
            // 
            // clmRoomType
            // 
            this.clmRoomType.HeaderText = "Room Type";
            this.clmRoomType.Name = "clmRoomType";
            this.clmRoomType.ReadOnly = true;
            // 
            // clmPaymentStatus
            // 
            this.clmPaymentStatus.HeaderText = "Payment Status";
            this.clmPaymentStatus.Name = "clmPaymentStatus";
            this.clmPaymentStatus.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(97, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 94);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Call 📞: 0960 325 1076";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email ✉︎: DaMockhotel@gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Check-in:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Check-out:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Room:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Total Cost:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(225, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Guests:";
            // 
            // txt_CheckIn
            // 
            this.txt_CheckIn.Location = new System.Drawing.Point(102, 40);
            this.txt_CheckIn.Name = "txt_CheckIn";
            this.txt_CheckIn.Size = new System.Drawing.Size(100, 25);
            this.txt_CheckIn.TabIndex = 5;
            // 
            // txt_CheckOut
            // 
            this.txt_CheckOut.Location = new System.Drawing.Point(102, 104);
            this.txt_CheckOut.Name = "txt_CheckOut";
            this.txt_CheckOut.Size = new System.Drawing.Size(100, 25);
            this.txt_CheckOut.TabIndex = 6;
            // 
            // txt_Room
            // 
            this.txt_Room.Location = new System.Drawing.Point(102, 163);
            this.txt_Room.Name = "txt_Room";
            this.txt_Room.Size = new System.Drawing.Size(100, 25);
            this.txt_Room.TabIndex = 7;
            // 
            // txt_TotalCost
            // 
            this.txt_TotalCost.Location = new System.Drawing.Point(102, 219);
            this.txt_TotalCost.Name = "txt_TotalCost";
            this.txt_TotalCost.Size = new System.Drawing.Size(100, 25);
            this.txt_TotalCost.TabIndex = 8;
            // 
            // txt_Guests
            // 
            this.txt_Guests.Location = new System.Drawing.Point(286, 63);
            this.txt_Guests.Name = "txt_Guests";
            this.txt_Guests.Size = new System.Drawing.Size(100, 25);
            this.txt_Guests.TabIndex = 9;
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1120, 556);
            this.Controls.Add(this.gbReservationDetails);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbCustomerSupp);
            this.Controls.Add(this.gbBookingHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProfile);
            this.Name = "Frm_Dashboard";
            this.Text = "DaMock Hotel - Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.gbBookingHistory.ResumeLayout(false);
            this.gbReservationDetails.ResumeLayout(false);
            this.gbReservationDetails.PerformLayout();
            this.gbCustomerSupp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingHIstory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_reviews;
        private System.Windows.Forms.Button btn_bookings;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbBookingHistory;
        private System.Windows.Forms.GroupBox gbReservationDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbCustomerSupp;
        private System.Windows.Forms.DataGridView dgvBookingHIstory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPaymentStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Guests;
        private System.Windows.Forms.TextBox txt_TotalCost;
        private System.Windows.Forms.TextBox txt_Room;
        private System.Windows.Forms.TextBox txt_CheckOut;
        private System.Windows.Forms.TextBox txt_CheckIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}