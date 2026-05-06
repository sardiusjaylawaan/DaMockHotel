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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string firstName = txt_Firstname.Text;
            string lastName = txt_Lastname.Text;
            string email = txt_Emailnum.Text;
            string password = txt_Newpass.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please choose a username.");
                return;
                            }

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            
            MessageBox.Show($"Account created for {firstName} {lastName}!");
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide(); 
        }

       
    }
}
