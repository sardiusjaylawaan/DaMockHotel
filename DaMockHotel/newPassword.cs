using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DaMockHotel
{
    public partial class Frm_newPassword : Form
    {
        private string userEmail;

        public Frm_newPassword(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void btn_ConfirmNewPassword_Click(object sender, EventArgs e)
        {
            string newPassword = txt_NewPassword.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DaMockHotelDB;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            string query = "UPDATE Users SET Password=@pass WHERE Email=@email";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@pass", newPassword);
            cmd.Parameters.AddWithValue("@email", userEmail);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Password updated successfully!");

            Frm_Login login = new Frm_Login();
            login.Show();

            this.Close();
        }
    }
}