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
    public partial class Frm_passwordSettings : Form
    {
        public Frm_passwordSettings()
        {
            InitializeComponent();
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Frm_profileSettings profileSettings = new Frm_profileSettings();
            profileSettings.Show();
            this.Hide();
        }
    }
}
