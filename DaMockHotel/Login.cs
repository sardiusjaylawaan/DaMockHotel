using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string username = txt_Username.Text;
            string password = txt_Password.Text;

            if (username == "admin" && password == "1234")
            {
                Dashboard login = new Dashboard(username);
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
            Frm_forgotPassword forgotPassword = new Frm_forgotPassword(txt_Username.Text);
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

            txt_Username.Font = new Font("Segoe UI", 11);
            txt_Username.BorderStyle = BorderStyle.FixedSingle;
            txt_Username.BackColor = Color.White;

            txt_Password.Font = new Font("Segoe UI", 11);
            txt_Password.BorderStyle = BorderStyle.FixedSingle;
            txt_Password.BackColor = Color.White;
            txt_Password.UseSystemPasswordChar = true;

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
            Frm_forgotPassword forgotPassword = new Frm_forgotPassword(txt_Username.Text);
            forgotPassword.Show();
            this.Hide();
        }

        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}