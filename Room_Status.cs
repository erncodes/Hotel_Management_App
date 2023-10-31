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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_App
{
    public partial class Room_Status : Form
    {
        public string userfirstname { get; set; }

        public Room_Status()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(332, 202);

        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        int singles = 0;
        int bedz = 0;
        int famz = 0;
        int fre = 0;

        private void Room_Status_Load(object sender, EventArgs e)
        {
            rommchart.Titles.Add("Room Occupancy");
            rommchart.Series["rooms"].IsValueShownAsLabel = true;

            conn.Open();
            string count = "SELECT COUNT(CASE WHEN Room_Type = 'Single' AND Status = 'Booked' THEN Status END) As Single,COUNT(CASE WHEN Room_Type = 'Single' AND Status = 'Free' THEN Status END) As SingleFree,COUNT(CASE WHEN Room_Type = 'Two Bedroom' AND Status = 'Booked' THEN Status END)  As Two,COUNT(CASE WHEN Room_Type = 'Two Bedroom' AND Status = 'Free' THEN Status END) As TwoFree,COUNT(CASE WHEN Room_Type = 'Family' AND Status = 'Booked' THEN Status END)  As Family,COUNT(CASE WHEN Room_Type = 'Family' AND Status = 'Free' THEN Status END) As FamilyFree,COUNT(CASE WHEN  Status = 'Free' THEN Status END)  As Free From Room_Status";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                 string singlebooked = reader["Single"].ToString();
                 string Two = reader["Two"].ToString();
                 string Fam = reader["Family"].ToString();
                 string Free = reader["Free"].ToString();
                 string SFree = reader["SingleFree"].ToString();
                 string TFree = reader["TwoFree"].ToString();
                 string FFree = reader["FamilyFree"].ToString();


                 singles = Convert.ToInt32(singlebooked);
                 bedz = Convert.ToInt32(Two);
                 famz = Convert.ToInt32(Fam);
                 fre = Convert.ToInt32(Free);

                label17.Text = singlebooked;
                label14.Text = SFree;
                label15.Text = Two;
                label13.Text = TFree;
                label16.Text = Fam;
                label12.Text = FFree;

            }
            conn.Close();
 
            rommchart.Series["rooms"].Points.AddXY("Single", singles.ToString());
            rommchart.Series["rooms"].Points.AddXY("2Bedroom", bedz.ToString());
            rommchart.Series["rooms"].Points.AddXY("Family", famz.ToString());
            rommchart.Series["rooms"].Points.AddXY("Available", fre.ToString());
        }

        private void label61_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
