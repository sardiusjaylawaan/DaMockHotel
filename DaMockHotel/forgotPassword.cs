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
    public partial class Frm_forgotPassword : Form
    {
        public Frm_forgotPassword(string username)
        {
            InitializeComponent();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Find_Click(object sender, EventArgs e)
        {

        }

        private void btn_forgotsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txt_forgotEmail.Text;

                if (string.IsNullOrWhiteSpace(email))
                {
                    throw new Exception("Email cannot be empty.");
                }

                MessageBox.Show($"Password reset link has been sent to {email}");
                txt_forgotEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txt_forgotEmail.Focus();
                
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login();
            login.Show();
            this.Close();
        }

        private void Frm_forgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
