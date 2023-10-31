using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_App
{
    public partial class User_Profile : Form
    {

        public User_Profile()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(332, 202);
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        private void label61_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string count = "SELECT * FROM Reservationss WHERE Room_No = '" + textBox1.Text + "'";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read() == true)
            {
                string customer = reader["Customer"].ToString();
                string usserx = reader["User_ID"].ToString();
                string Room = reader["Room_No"].ToString();
                string Extras = reader["Extras"].ToString();
                string In = reader["Start_Date"].ToString();
                string Out = reader["End_Date"].ToString();
                string Total = reader["Total"].ToString();


                label1.Text = customer;
                label13.Text = usserx;
                label8.Text = usserx;
                label14.Text = Room;
                label12.Text = Room;
                label15.Text = Extras;
                label20.Text = In.Substring(0, 10);
                label21.Text = Out.Substring(0, 10);
                label17.Text = "R " + Total;
            }
            else
            {
                MessageBox.Show("This Room Is Not Currently Booked", "Try Another One", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            string count = "SELECT * FROM Reservationss WHERE Room_No = '" + textBox1.Text + "'";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read() == true)
            {
            }
            else
            {
                MessageBox.Show("This Room Is Not Currently Booked", "Try Another One", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            conn.Close();
            updateeRuum();
            DeleteRuum();
            MessageBox.Show("Room Status Updated", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }
        private void DeleteRuum()
        {
            conn.Open();
            string insert = "DELETE FROM Reservationss WHERE Room_No = '" + updatetxt.Text + "'";
            command = new SqlCommand(insert, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        private void updateeRuum()
        {
            conn.Open();
            string insert = "UPDATE Room_Status SET Status = 'Free',Available = '' WHERE Room_No = '" + updatetxt.Text + "'";
            command = new SqlCommand(insert, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
