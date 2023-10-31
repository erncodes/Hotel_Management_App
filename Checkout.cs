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

namespace Hotel_App
{
    public partial class Checkout : Form
    {
        public int roomN { get; set; }

        public DateTime end { get; set; }

        public int user { get; set; }
        public string customer { get; set; }
        public DateTime start { get; set; }
        public int guest { get; set; }
        public string addedserv { get; set; }
        public string roomT { get; set; }
        public double Totals { get; set; }
        public Checkout()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(355, 186);
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checkoutroom();
            CheckoutBook();

            MessageBox.Show("Booking Successfull", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void Checkoutroom()
        {
            conn.Open();
            string insert = "UPDATE Room_Status SET Status = 'Booked',Available = '" + end + "' WHERE Room_No = '" + roomN + "'";
            command = new SqlCommand(insert, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void CheckoutBook()
        {
            DateTime today = DateTime.Now;
            int value = Convert.ToInt32(Totals);
            conn.Open();
            string insert = "INSERT INTO Reservationss VALUES('" + user + "','" + customer + "','" + roomN + "','" + today + "','" + start + "','" + end + "','" + guest + "','" + addedserv + "','" + value + "')";
            command = new SqlCommand(insert, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
