using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DaMockHotel
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DaMockHotelDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            string query = "SELECT COUNT(*) FROM Users WHERE Username=@user AND Password=@pass";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@user", txtUsername.Text);
            cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

            conn.Open();

            int count = (int)cmd.ExecuteScalar();

            conn.Close();

            if (count > 0)
            {
                Dashboard login = new Dashboard(txtUsername.Text);
                login.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            Frm_createAccount registerForm = new Frm_createAccount();
            this.Hide();
            registerForm.Show();
            
        }

        private void lbl_forgotPassword_Click(object sender, EventArgs e)
        {
            Frm_forgotPassword forgotPassword = new Frm_forgotPassword(txtUsername.Text);
            this.Hide();
            forgotPassword.Show();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Password_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(241, 245, 249);
            this.Size = new Size(1100, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            SetTransparentLabels(this);

            btn_Login.BackColor = Color.FromArgb(37, 99, 235);
            btn_Login.ForeColor = Color.White;
            btn_Login.FlatStyle = FlatStyle.Flat;
            btn_Login.FlatAppearance.BorderSize = 0;
            btn_Login.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn_Login.Cursor = Cursors.Hand;

            btn_CreateAcc.BackColor = Color.White;
            btn_CreateAcc.ForeColor = Color.FromArgb(37, 99, 235);
            btn_CreateAcc.FlatStyle = FlatStyle.Flat;
            btn_CreateAcc.FlatAppearance.BorderSize = 1;
            btn_CreateAcc.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);
            btn_CreateAcc.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btn_CreateAcc.Cursor = Cursors.Hand;

            txtUsername.Font = new Font("Segoe UI", 11);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.BackColor = Color.White;

            txtPassword.Font = new Font("Segoe UI", 11);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.BackColor = Color.White;
            txtPassword.UseSystemPasswordChar = true;

            lnk_Forgot.ForeColor = Color.FromArgb(37, 99, 235);
            lnk_Forgot.Font = new Font("Segoe UI", 9, FontStyle.Underline);
            lnk_Forgot.BackColor = Color.Transparent;
            lnk_Forgot.Cursor = Cursors.Hand;

            pnl_LoginCard.Paint += (s, pe) =>
            {
                pe.Graphics.DrawRectangle(
                    new Pen(Color.FromArgb(220, 220, 220)),
                    0, 0,
                    pnl_LoginCard.Width - 1,
                    pnl_LoginCard.Height - 1);
            };
        }

        private void SetTransparentLabels(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.BackColor = Color.Transparent;
                }

                if (ctrl.HasChildren)
                {
                    SetTransparentLabels(ctrl);
                }
            }
        }

        private void lnk_Forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_forgotPassword forgotPassword = new Frm_forgotPassword(txtUsername.Text);
            forgotPassword.Show();
            this.Hide();
        }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}