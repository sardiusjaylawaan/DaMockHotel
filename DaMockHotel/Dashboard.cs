using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DaMockHotel
{
    public partial class Dashboard : Form
    {
        public Dashboard(string username)
        {
            InitializeComponent();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_bookings_Click(object sender, EventArgs e)
        {
            Frm_Bookings bookings = new Frm_Bookings();
            bookings.Show();
            this.Close();
        }
    }
}
