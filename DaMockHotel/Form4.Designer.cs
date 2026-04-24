namespace DaMockHotel
{
    partial class Form4
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
            this.lbl_Createnew = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.cmb_Day = new System.Windows.Forms.ComboBox();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_Emailnum = new System.Windows.Forms.Label();
            this.txt_Emailnum = new System.Windows.Forms.TextBox();
            this.lbl_Newpass = new System.Windows.Forms.Label();
            this.txt_Newpass = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_HaveAcc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Createnew
            // 
            this.lbl_Createnew.AutoSize = true;
            this.lbl_Createnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Createnew.Location = new System.Drawing.Point(410, 47);
            this.lbl_Createnew.Name = "lbl_Createnew";
            this.lbl_Createnew.Size = new System.Drawing.Size(203, 25);
            this.lbl_Createnew.TabIndex = 0;
            this.lbl_Createnew.Text = "Create new account";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(352, 87);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 15);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.Location = new System.Drawing.Point(371, 120);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(118, 20);
            this.txt_Firstname.TabIndex = 2;
            this.txt_Firstname.Text = "First Name";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.Location = new System.Drawing.Point(495, 120);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(118, 20);
            this.txt_Lastname.TabIndex = 3;
            this.txt_Lastname.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birthday";
            // 
            // cmb_Month
            // 
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June ",
            "July ",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_Month.Location = new System.Drawing.Point(371, 190);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(80, 21);
            this.cmb_Month.TabIndex = 5;
            this.cmb_Month.Text = "Month";
            // 
            // cmb_Day
            // 
            this.cmb_Day.FormattingEnabled = true;
            this.cmb_Day.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmb_Day.Location = new System.Drawing.Point(457, 190);
            this.cmb_Day.Name = "cmb_Day";
            this.cmb_Day.Size = new System.Drawing.Size(80, 21);
            this.cmb_Day.TabIndex = 6;
            this.cmb_Day.Text = "Day";
            // 
            // cmb_Year
            // 
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010 ",
            "2011",
            "",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmb_Year.Location = new System.Drawing.Point(543, 190);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(70, 21);
            this.cmb_Year.TabIndex = 7;
            this.cmb_Year.Text = "Year";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(352, 223);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(54, 15);
            this.lbl_Gender.TabIndex = 8;
            this.lbl_Gender.Text = "Gender";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            ""});
            this.cmb_Gender.Location = new System.Drawing.Point(371, 250);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(242, 21);
            this.cmb_Gender.TabIndex = 9;
            this.cmb_Gender.Text = "Select Gender";
            // 
            // lbl_Emailnum
            // 
            this.lbl_Emailnum.AutoSize = true;
            this.lbl_Emailnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emailnum.Location = new System.Drawing.Point(357, 284);
            this.lbl_Emailnum.Name = "lbl_Emailnum";
            this.lbl_Emailnum.Size = new System.Drawing.Size(161, 15);
            this.lbl_Emailnum.TabIndex = 10;
            this.lbl_Emailnum.Text = "Mobile number or email";
            // 
            // txt_Emailnum
            // 
            this.txt_Emailnum.Location = new System.Drawing.Point(371, 313);
            this.txt_Emailnum.Name = "txt_Emailnum";
            this.txt_Emailnum.Size = new System.Drawing.Size(242, 20);
            this.txt_Emailnum.TabIndex = 11;
            this.txt_Emailnum.Text = "mobile number or email";
            // 
            // lbl_Newpass
            // 
            this.lbl_Newpass.AutoSize = true;
            this.lbl_Newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Newpass.Location = new System.Drawing.Point(357, 345);
            this.lbl_Newpass.Name = "lbl_Newpass";
            this.lbl_Newpass.Size = new System.Drawing.Size(69, 15);
            this.lbl_Newpass.TabIndex = 12;
            this.lbl_Newpass.Text = "Password";
            // 
            // txt_Newpass
            // 
            this.txt_Newpass.Location = new System.Drawing.Point(371, 372);
            this.txt_Newpass.Name = "txt_Newpass";
            this.txt_Newpass.Size = new System.Drawing.Size(242, 20);
            this.txt_Newpass.TabIndex = 13;
            this.txt_Newpass.Text = "Password";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Submit.Location = new System.Drawing.Point(399, 413);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(184, 23);
            this.btn_Submit.TabIndex = 14;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // btn_HaveAcc
            // 
            this.btn_HaveAcc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_HaveAcc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_HaveAcc.FlatAppearance.BorderSize = 0;
            this.btn_HaveAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_HaveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HaveAcc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_HaveAcc.Location = new System.Drawing.Point(399, 442);
            this.btn_HaveAcc.Name = "btn_HaveAcc";
            this.btn_HaveAcc.Size = new System.Drawing.Size(184, 23);
            this.btn_HaveAcc.TabIndex = 15;
            this.btn_HaveAcc.Text = "I already have an account";
            this.btn_HaveAcc.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 543);
            this.Controls.Add(this.btn_HaveAcc);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.txt_Newpass);
            this.Controls.Add(this.lbl_Newpass);
            this.Controls.Add(this.txt_Emailnum);
            this.Controls.Add(this.lbl_Emailnum);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Day);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Lastname);
            this.Controls.Add(this.txt_Firstname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_Createnew);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Createnew;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.ComboBox cmb_Day;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label lbl_Emailnum;
        private System.Windows.Forms.TextBox txt_Emailnum;
        private System.Windows.Forms.Label lbl_Newpass;
        private System.Windows.Forms.TextBox txt_Newpass;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_HaveAcc;
    }
}