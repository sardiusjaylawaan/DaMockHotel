using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaMockHotel
{
    public partial class Frm_createAccount : Form
    {
        public Frm_createAccount()
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

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DaMockHotelDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            string query = "INSERT INTO Users (Username, Password, Role, Email) VALUES (@user, @pass, @role, @email)";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@pass", password);
            cmd.Parameters.AddWithValue("@role", "Staff");
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"Account created for {firstName} {lastName}!");

                Frm_Login loginForm = new Frm_Login();
                loginForm.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Frm_Login loginForm = new Frm_Login();
            loginForm.Show();
            this.Hide();
        }

        private void Frm_createAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}