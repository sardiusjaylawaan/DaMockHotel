namespace DaMockHotel
{
    partial class Frm_writeReviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_writeReviews));
            this.pnl_dashboard = new System.Windows.Forms.Panel();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_reviews = new System.Windows.Forms.Button();
            this.btn_bookings = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.lbl_hotel = new System.Windows.Forms.Label();
            this.pnl_review = new System.Windows.Forms.Panel();
            this.pnl_feedback = new System.Windows.Forms.Panel();
            this.lbl_feedback = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_review = new System.Windows.Forms.TextBox();
            this.lbl_stories = new System.Windows.Forms.Label();
            this.lbl_review = new System.Windows.Forms.Label();
            this.pnl_dashboard.SuspendLayout();
            this.pnl_review.SuspendLayout();
            this.pnl_feedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_dashboard
            // 
            this.pnl_dashboard.AutoSize = true;
            this.pnl_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.pnl_dashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_dashboard.Controls.Add(this.btn_settings);
            this.pnl_dashboard.Controls.Add(this.btn_reviews);
            this.pnl_dashboard.Controls.Add(this.btn_bookings);
            this.pnl_dashboard.Controls.Add(this.btn_dashboard);
            this.pnl_dashboard.Controls.Add(this.lbl_hotel);
            this.pnl_dashboard.Location = new System.Drawing.Point(0, 0);
            this.pnl_dashboard.Name = "pnl_dashboard";
            this.pnl_dashboard.Size = new System.Drawing.Size(170, 653);
            this.pnl_dashboard.TabIndex = 25;
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
            this.btn_reviews.BackColor = System.Drawing.Color.White;
            this.btn_reviews.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviews.Location = new System.Drawing.Point(21, 264);
            this.btn_reviews.Name = "btn_reviews";
            this.btn_reviews.Size = new System.Drawing.Size(113, 40);
            this.btn_reviews.TabIndex = 17;
            this.btn_reviews.Text = "Reviews";
            this.btn_reviews.UseVisualStyleBackColor = false;
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
            this.btn_dashboard.BackColor = System.Drawing.Color.Silver;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Location = new System.Drawing.Point(21, 99);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(113, 40);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // lbl_hotel
            // 
            this.lbl_hotel.AutoSize = true;
            this.lbl_hotel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hotel.ForeColor = System.Drawing.Color.White;
            this.lbl_hotel.Location = new System.Drawing.Point(26, 11);
            this.lbl_hotel.Name = "lbl_hotel";
            this.lbl_hotel.Size = new System.Drawing.Size(108, 20);
            this.lbl_hotel.TabIndex = 0;
            this.lbl_hotel.Text = "DaMock Hotel";
            // 
            // pnl_review
            // 
            this.pnl_review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_review.Controls.Add(this.pnl_feedback);
            this.pnl_review.Controls.Add(this.btn_submit);
            this.pnl_review.Controls.Add(this.txt_review);
            this.pnl_review.Controls.Add(this.lbl_stories);
            this.pnl_review.Controls.Add(this.lbl_review);
            this.pnl_review.Location = new System.Drawing.Point(239, 49);
            this.pnl_review.Name = "pnl_review";
            this.pnl_review.Size = new System.Drawing.Size(818, 538);
            this.pnl_review.TabIndex = 26;
            // 
            // pnl_feedback
            // 
            this.pnl_feedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.pnl_feedback.Controls.Add(this.lbl_feedback);
            this.pnl_feedback.ForeColor = System.Drawing.Color.White;
            this.pnl_feedback.Location = new System.Drawing.Point(73, 345);
            this.pnl_feedback.Name = "pnl_feedback";
            this.pnl_feedback.Size = new System.Drawing.Size(667, 117);
            this.pnl_feedback.TabIndex = 5;
            // 
            // lbl_feedback
            // 
            this.lbl_feedback.AutoSize = true;
            this.lbl_feedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_feedback.Location = new System.Drawing.Point(41, 27);
            this.lbl_feedback.Name = "lbl_feedback";
            this.lbl_feedback.Size = new System.Drawing.Size(580, 63);
            this.lbl_feedback.TabIndex = 4;
            this.lbl_feedback.Text = resources.GetString("lbl_feedback.Text");
            this.lbl_feedback.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(96)))), ((int)(((byte)(210)))));
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.Location = new System.Drawing.Point(509, 244);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(110, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_review
            // 
            this.txt_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_review.ForeColor = System.Drawing.Color.Gray;
            this.txt_review.Location = new System.Drawing.Point(160, 203);
            this.txt_review.Name = "txt_review";
            this.txt_review.Size = new System.Drawing.Size(459, 26);
            this.txt_review.TabIndex = 2;
            this.txt_review.Text = "What would you like to review?";
            // 
            // lbl_stories
            // 
            this.lbl_stories.AutoSize = true;
            this.lbl_stories.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stories.Location = new System.Drawing.Point(123, 98);
            this.lbl_stories.Name = "lbl_stories";
            this.lbl_stories.Size = new System.Drawing.Size(560, 60);
            this.lbl_stories.TabIndex = 1;
            this.lbl_stories.Text = "Stories like yours are what helps travelers have better trips. \r\nShare your exper" +
    "ience and help out a fellow traveler!";
            this.lbl_stories.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_review
            // 
            this.lbl_review.AutoSize = true;
            this.lbl_review.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_review.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(44)))), ((int)(((byte)(67)))));
            this.lbl_review.Location = new System.Drawing.Point(99, 51);
            this.lbl_review.Name = "lbl_review";
            this.lbl_review.Size = new System.Drawing.Size(617, 47);
            this.lbl_review.TabIndex = 0;
            this.lbl_review.Text = "Write a review, make someone\'s trip";
            // 
            // Frm_writeReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 652);
            this.Controls.Add(this.pnl_review);
            this.Controls.Add(this.pnl_dashboard);
            this.Name = "Frm_writeReviews";
            this.Text = "DaMock Hotel - Reviews";
            this.pnl_dashboard.ResumeLayout(false);
            this.pnl_dashboard.PerformLayout();
            this.pnl_review.ResumeLayout(false);
            this.pnl_review.PerformLayout();
            this.pnl_feedback.ResumeLayout(false);
            this.pnl_feedback.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_dashboard;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_reviews;
        private System.Windows.Forms.Button btn_bookings;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Label lbl_hotel;
        private System.Windows.Forms.Panel pnl_review;
        private System.Windows.Forms.Label lbl_review;
        private System.Windows.Forms.Label lbl_stories;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_review;
        private System.Windows.Forms.Panel pnl_feedback;
        private System.Windows.Forms.Label lbl_feedback;
    }
}