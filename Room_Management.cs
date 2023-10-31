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
    public partial class Room_Management : Form
    {
        public string userfirstname { get; set; }
        Money_Page money = new Money_Page();
        Room_Status roomzo = new Room_Status();
        Reservations panellz = new Reservations();
        Login_Page panell = new Login_Page();
        User_Profile profile = new User_Profile();

        int checkout =0;
        string roomN = "";
        public Room_Management()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            panell.Show();
            panellz.Hide();
            profile.Hide();
            money.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panellz.Show();
            roomzo.Hide();
            profile.Hide();
            money.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            roomzo.Show();
            panellz.Hide();
            profile.Hide();
            money.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            money.Show();
            panellz.Hide();
            roomzo.Hide();
            profile.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            profile.Show();
            panellz.Hide();
            roomzo.Hide();
            money.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void GetRuum1()
        {
                conn.Open();
                string insert = "UPDATE Room_Status SET Status = 'Free',Available = '' WHERE Available = CAST (GETDATE() AS date)";
                command = new SqlCommand(insert, conn);
                command.ExecuteNonQuery();
                conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetRuum1();
        }
    }
}
