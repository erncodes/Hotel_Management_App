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
    public partial class Dashboard : Form
    {
        public string userfirstname { get; set; }
        Contact contact = new Contact();
        About About = new About();
        Booking panel = new Booking();
        public Dashboard()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        private void Book_button_Click(object sender, EventArgs e)
        {
           
            panel.userfirstname = userfirstname;
            panel.Show();
            About.Hide();

        }

        private void Contact_Button_Click(object sender, EventArgs e)
        {
            panel.Hide();
            About.Hide();
            contact.Show();
        }

        private void Settings_Button_Click(object sender, EventArgs e)
        {
            new RegSus().Show();
            panel.Hide();
            contact.Hide();
            About.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel.Hide();
            contact.Hide();
            About.Hide();
            new Login_Page().Show();
        }

        private void Review_Button_Click(object sender, EventArgs e)
        {
            panel.Hide();
            About.Show();
            contact.Hide();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            conn.Open();
            string regist = "SELECT First_Name,Surname FROM User_Info WHERE Username = @Username ";
            command = new SqlCommand(regist, conn);
            command.Parameters.AddWithValue("@Username", userfirstname);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                NameSpace.Text = reader["First_Name"].ToString() + " " +reader["Surname"].ToString();
            }
            conn.Close();


        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
