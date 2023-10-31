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
    public partial class Money_Page : Form
    {
        public Money_Page()
        {
            InitializeComponent();
            Single();
            Thuz();
            Fam();
            Currentsing();
            Currentfam();
            CurrentTwo();
            Prevsing();
            Prevfam();
            PrevTwo();
            Nextsing();
            Nextfam();
            NextTwo();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(332, 202);
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        private void Single()
        {
            conn.Open();
            string count = "SELECT SUM(Total) From Reservationss WHERE Room_No <=129";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                singl.Text = "R "+ totals;
            }
            conn.Close();
        }
        private void Thuz()
        {
            conn.Open();
            string count = "SELECT SUM(Total) From Reservationss WHERE Room_No >129 AND Room_No <=159";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                twol.Text = "R "+totals;
            }
            conn.Close();
        }
        private void Fam()
        {
            conn.Open();
            string count = "SELECT SUM(Total) From Reservationss WHERE Room_No >159 ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                faml.Text ="R " + totals;
            }
            conn.Close();
        }
        private void Currentsing()
        {
            conn.Open();
            string count = "SELECT SUM(Total) FROM Reservationss WHERE DATEPART(m, End_Date) = DATEPART(m, DATEADD(m, 0, getdate())) AND DATEPART(yyyy, End_Date) = DATEPART(yyyy, DATEADD(m, 0, getdate())) AND Room_No < 129  ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                money.Series["Current Month"].Points.AddXY("Single", totals.ToString());
            }
            
            conn.Close();
        }
        private void Currentfam()
        {
            conn.Open();
            string count = "SELECT SUM(Total) FROM Reservationss WHERE DATEPART(m, End_Date) = DATEPART(m, DATEADD(m, 0, getdate())) AND DATEPART(yyyy, End_Date) = DATEPART(yyyy, DATEADD(m, 0, getdate())) AND Room_No > 159 ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                money.Series["Current Month"].Points.AddXY("Family", totals.ToString());
            }
            conn.Close();
        }
        private void CurrentTwo()
        {
            conn.Open();
            string count = "SELECT SUM(Total) FROM Reservationss WHERE DATEPART(m, End_Date) = DATEPART(m, DATEADD(m, 0, getdate())) AND DATEPART(yyyy, End_Date) = DATEPART(yyyy, DATEADD(m, 0, getdate())) AND Room_No <= 159 AND Room_No > 129 ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                money.Series["Current Month"].Points.AddXY("2Bedroom", totals.ToString());
            }
            conn.Close();
        }
        private void Prevsing()
        {
            conn.Open();
            string count = "SELECT SUM(Total) FROM Reservationss WHERE DATEPART(m, End_Date) = DATEPART(m, DATEADD(m, -1, getdate())) AND DATEPART(yyyy, End_Date) = DATEPART(yyyy, DATEADD(m, -1, getdate())) AND Room_No > 159  ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                money.Series["Last Month"].Points.AddXY("Single", totals.ToString());
            }
            conn.Close();
        }
        private void Prevfam()
        {
            conn.Open();
            string count = "SELECT SUM(Total) FROM Reservationss WHERE DATEPART(m, End_Date) = DATEPART(m, DATEADD(m, -1, getdate())) AND DATEPART(yyyy, End_Date) = DATEPART(yyyy, DATEADD(m, 1, getdate())) AND Room_No > 159 ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                money.Series["Last Month"].Points.AddXY("Family", totals.ToString());
            }
            conn.Close();
        }
        private void PrevTwo()
        {
            conn.Open();
            string count = "SELECT SUM(Total) FROM Reservationss WHERE DATEPART(m, End_Date) = DATEPART(m, DATEADD(m, -1, getdate())) AND DATEPART(yyyy, End_Date) = DATEPART(yyyy, DATEADD(m, -1, getdate())) AND Room_No <= 159 AND Room_No > 129 ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                money.Series["Last Month"].Points.AddXY("2Bedroom", totals.ToString());
            }
            conn.Close();
        }
        private void Nextsing()
        {
            conn.Open();
            string count = "SELECT SUM(Total) FROM Reservationss WHERE DATEPART(m, End_Date) = DATEPART(m, DATEADD(m, +1, getdate())) AND DATEPART(yyyy, End_Date) = DATEPART(yyyy, DATEADD(m, +1, getdate())) AND Room_No < 129  ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                money.Series["Next Month"].Points.AddXY("Single", totals.ToString());
            }
            conn.Close();
        }
        private void Nextfam()
        {
            conn.Open();
            string count = "SELECT SUM(Total) FROM Reservationss WHERE DATEPART(m, End_Date) = DATEPART(m, DATEADD(m, +1, getdate())) AND DATEPART(yyyy, End_Date) = DATEPART(yyyy, DATEADD(m, +1, getdate())) AND Room_No > 159 ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                money.Series["Next Month"].Points.AddXY("Family", totals.ToString());
            }
            conn.Close();
        }
        private void NextTwo()
        {
            conn.Open();
            string count = "SELECT SUM(Total) FROM Reservationss WHERE DATEPART(m, End_Date) = DATEPART(m, DATEADD(m, +1, getdate())) AND DATEPART(yyyy, End_Date) = DATEPART(yyyy, DATEADD(m, +1, getdate())) AND Room_No <= 159 AND Room_No > 129 ";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                money.Series["Next Month"].Points.AddXY("2Bedroom", totals.ToString());
            }
            conn.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            money.Series["Last Month"].IsValueShownAsLabel = true;

            conn.Open();

            string count = "SELECT SUM(Total) From Reservationss";
            command = new SqlCommand(count, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string totals = reader[""].ToString();
                totl.Text = "R " + totals;

            }
            conn.Close();

        }

        private void label61_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
