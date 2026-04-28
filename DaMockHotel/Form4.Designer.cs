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
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Createnew
            // 
            this.lbl_Createnew.AutoSize = true;
            this.lbl_Createnew.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Createnew.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Createnew.Location = new System.Drawing.Point(42, 15);
            this.lbl_Createnew.Name = "lbl_Createnew";
            this.lbl_Createnew.Size = new System.Drawing.Size(267, 37);
            this.lbl_Createnew.TabIndex = 0;
            this.lbl_Createnew.Text = "Create New Account";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_name.Location = new System.Drawing.Point(46, 77);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 17);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.ForeColor = System.Drawing.Color.Gray;
            this.txt_Firstname.Location = new System.Drawing.Point(49, 104);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(118, 20);
            this.txt_Firstname.TabIndex = 2;
            this.txt_Firstname.Text = "First Name";
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.ForeColor = System.Drawing.Color.Gray;
            this.txt_Lastname.Location = new System.Drawing.Point(173, 104);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(118, 20);
            this.txt_Lastname.TabIndex = 3;
            this.txt_Lastname.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(46, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birthday";
            // 
            // cmb_Month
            // 
            this.cmb_Month.ForeColor = System.Drawing.Color.Gray;
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
            this.cmb_Month.Location = new System.Drawing.Point(49, 245);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(80, 21);
            this.cmb_Month.TabIndex = 5;
            this.cmb_Month.Text = "Month";
            // 
            // cmb_Day
            // 
            this.cmb_Day.ForeColor = System.Drawing.Color.Gray;
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
            this.cmb_Day.Location = new System.Drawing.Point(135, 245);
            this.cmb_Day.Name = "cmb_Day";
            this.cmb_Day.Size = new System.Drawing.Size(80, 21);
            this.cmb_Day.TabIndex = 6;
            this.cmb_Day.Text = "Day";
            // 
            // cmb_Year
            // 
            this.cmb_Year.ForeColor = System.Drawing.Color.Gray;
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
            this.cmb_Year.Location = new System.Drawing.Point(221, 245);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(70, 21);
            this.cmb_Year.TabIndex = 7;
            this.cmb_Year.Text = "Year";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Gender.Location = new System.Drawing.Point(46, 279);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(52, 17);
            this.lbl_Gender.TabIndex = 8;
            this.lbl_Gender.Text = "Gender";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.ForeColor = System.Drawing.Color.Gray;
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            ""});
            this.cmb_Gender.Location = new System.Drawing.Point(49, 315);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(242, 21);
            this.cmb_Gender.TabIndex = 9;
            this.cmb_Gender.Text = "Select Gender";
            // 
            // lbl_Emailnum
            // 
            this.lbl_Emailnum.AutoSize = true;
            this.lbl_Emailnum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emailnum.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Emailnum.Location = new System.Drawing.Point(46, 353);
            this.lbl_Emailnum.Name = "lbl_Emailnum";
            this.lbl_Emailnum.Size = new System.Drawing.Size(158, 17);
            this.lbl_Emailnum.TabIndex = 10;
            this.lbl_Emailnum.Text = "Mobile number or email";
            // 
            // txt_Emailnum
            // 
            this.txt_Emailnum.Location = new System.Drawing.Point(49, 383);
            this.txt_Emailnum.Name = "txt_Emailnum";
            this.txt_Emailnum.Size = new System.Drawing.Size(242, 20);
            this.txt_Emailnum.TabIndex = 11;
            // 
            // lbl_Newpass
            // 
            this.lbl_Newpass.AutoSize = true;
            this.lbl_Newpass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Newpass.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Newpass.Location = new System.Drawing.Point(46, 427);
            this.lbl_Newpass.Name = "lbl_Newpass";
            this.lbl_Newpass.Size = new System.Drawing.Size(66, 17);
            this.lbl_Newpass.TabIndex = 12;
            this.lbl_Newpass.Text = "Password";
            // 
            // txt_Newpass
            // 
            this.txt_Newpass.Location = new System.Drawing.Point(49, 457);
            this.txt_Newpass.Name = "txt_Newpass";
            this.txt_Newpass.Size = new System.Drawing.Size(242, 20);
            this.txt_Newpass.TabIndex = 13;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Navy;
            this.btn_Submit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Submit.Location = new System.Drawing.Point(82, 504);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(184, 23);
            this.btn_Submit.TabIndex = 14;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btn_HaveAcc
            // 
            this.btn_HaveAcc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_HaveAcc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_HaveAcc.FlatAppearance.BorderSize = 0;
            this.btn_HaveAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_HaveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HaveAcc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HaveAcc.ForeColor = System.Drawing.Color.Gray;
            this.btn_HaveAcc.Location = new System.Drawing.Point(82, 533);
            this.btn_HaveAcc.Name = "btn_HaveAcc";
            this.btn_HaveAcc.Size = new System.Drawing.Size(184, 23);
            this.btn_HaveAcc.TabIndex = 15;
            this.btn_HaveAcc.Text = "I already have an account";
            this.btn_HaveAcc.UseVisualStyleBackColor = false;
            this.btn_HaveAcc.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(49, 174);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(242, 20);
            this.txt_Username.TabIndex = 16;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_Username.Location = new System.Drawing.Point(46, 143);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(69, 17);
            this.lbl_Username.TabIndex = 17;
            this.lbl_Username.Text = "Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_Createnew);
            this.panel1.Controls.Add(this.btn_HaveAcc);
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Controls.Add(this.btn_Submit);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.txt_Newpass);
            this.panel1.Controls.Add(this.txt_Username);
            this.panel1.Controls.Add(this.lbl_Newpass);
            this.panel1.Controls.Add(this.txt_Firstname);
            this.panel1.Controls.Add(this.txt_Emailnum);
            this.panel1.Controls.Add(this.txt_Lastname);
            this.panel1.Controls.Add(this.lbl_Emailnum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmb_Gender);
            this.panel1.Controls.Add(this.cmb_Month);
            this.panel1.Controls.Add(this.lbl_Gender);
            this.panel1.Controls.Add(this.cmb_Day);
            this.panel1.Controls.Add(this.cmb_Year);
            this.panel1.Location = new System.Drawing.Point(177, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 587);
            this.panel1.TabIndex = 18;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(775, 636);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Panel panel1;
    }
}