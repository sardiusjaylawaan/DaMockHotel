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
    public partial class Frm_writeReviews : Form
    {
        public Frm_writeReviews()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            Frm_Dashboard dashboard = new Frm_Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btn_bookings_Click(object sender, EventArgs e)
        {
            Frm_Bookings bookings = new Frm_Bookings();
            bookings.Show();
            this.Hide();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Frm_profileSettings settings = new Frm_profileSettings();
            settings.Show();
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {

        }
    }
}
