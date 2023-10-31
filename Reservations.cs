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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(332, 202);

            GetRuum1();
            GetRuum2();
            GetRuum3();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        private void label61_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        
        {
            textBox2.Text = "";
            conn.Open();
            string count = "SELECT Customer,Book_No,Room_No,Start_Date,End_Date,Total FROM Reservationss WHERE Customer LIKE '"+textBox1.Text +"' Order By Customer";
           
            adapter = new SqlDataAdapter(count, conn);

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            datatable1.DataSource = datatable;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            conn.Open();
            string count = "SELECT Customer,Book_No,Room_No,Start_Date,End_Date,Total FROM Reservationss WHERE Room_No = '" + textBox2.Text + "'";

            adapter = new SqlDataAdapter(count, conn);

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            datatable1.DataSource = datatable;
            conn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            conn.Open();
            string count = "SELECT Customer,Book_No,Room_No,Start_Date,End_Date,Total FROM Reservationss Order By Customer";

            adapter = new SqlDataAdapter(count, conn);

            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            datatable1.DataSource = datatable;
            conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void GetRuum1()
        {
            conn.Open();
            string regist = "WITH Reservations As (SELECT*,ROW_NUMBER()OVER(Order By End_Date ASC) as Room From Reservationss) SELECT * From Reservations Where Room = 1;";
            command = new SqlCommand(regist, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string room = reader["Room_No"].ToString() ;
                string Check = reader["End_Date"].ToString();
                string book  = reader["Book_No"].ToString();
                label2.Text = room;
                label14.Text = Check.Substring(0, 10);
                label21.Text = book;
            }
            conn.Close();
        }
        private void GetRuum2()
        {
            conn.Open();
            string regist = "WITH Reservations As (SELECT*,ROW_NUMBER()OVER(Order By End_Date ASC) as Room From Reservationss) SELECT * From Reservations Where Room = 2;";
            command = new SqlCommand(regist, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string room = reader["Room_No"].ToString();
                string Check = reader["End_Date"].ToString();
                string book = reader["Book_No"].ToString();
                label7.Text = room;
                label17.Text = Check.Substring(0, 10);
                label20.Text = book;
            }
            conn.Close();
        }
        private void GetRuum3()
        {
            conn.Open();
            string regist = "WITH Reservations As (SELECT*,ROW_NUMBER()OVER(Order By End_Date ASC) as Room From Reservationss) SELECT * From Reservations Where Room = 3;";
            command = new SqlCommand(regist, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string room = reader["Room_No"].ToString();
                string Check = reader["End_Date"].ToString();
                string book = reader["Book_No"].ToString();
                label8.Text = room;
                label18.Text = Check.Substring(0,10);
                label19.Text = book;
            }
            conn.Close();
        }
    }
}
