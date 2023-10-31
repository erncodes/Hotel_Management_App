using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_App
{
    public partial class Confirmation : Form
    {
        public int user { get; set; }
        public string customer { get; set; }
        public int roomN { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public int guest { get; set; }
        public string addedserv { get; set; }
        public string roomT { get; set; }
        public double Totals { get; set; }
        public Confirmation()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(355, 186);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           

            this.Hide();
            Checkout panel = new Checkout();
            panel.Show();
            panel.roomN = roomN;
            panel.end = end;
            panel.customer = customer;
            panel.user = user;
            panel.guest = guest;
            panel.start = start;
            panel.end = end;
            panel.roomT = roomT;
            panel.Totals = Totals;
            panel.addedserv = addedserv;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Label_Cust.Text = customer;
            Label_End.Text = end.ToString();
            Label_Star.Text = start.ToString();
            Label_Gue.Text = guest.ToString();
            Label_Type.Text = roomT;
            Label_Tot.Text = Totals.ToString();
            Label_Xtra.Text = addedserv;

        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
