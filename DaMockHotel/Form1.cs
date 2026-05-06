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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;

            if (username == "admin" && password == "1234")
            {
                Form2 login = new Form2(username);
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
            Form4 registerForm = new Form4();
            registerForm.ShowDialog();

        }

        private void lbl_forgotPassword_Click(object sender, EventArgs e)
        {
            Form3 forgotPassword = new Form3(txt_Username.Text);
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
    }
}
