using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_App
{
    public partial class RegSus : Form
    {
       public string pass { get; set; }
        public string user { get; set; }

        public RegSus()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(455, 200);
        }

        private void panel_Settings_Paint(object sender, PaintEventArgs e)
        {
            label5.Text = user;
            label6.Text = pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Page panel = new Login_Page();
            panel.Show();
        }
    }
}
