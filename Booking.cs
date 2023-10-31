using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hotel_App
{
    public partial class Booking : Form
    {
        public string userfirstname { get; set; }

        public Booking()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(355, 186);
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();

        double estimated = 0;
        double singlecost = 400;
        double twocost = 600;
        double famcost = 900;
        double vipcost = 4.5;
        double cheffcost = 1.3;
        double drivercost = 1.7;
        double spacost = 1.5;
        int guest = 0;
        double dayz = 0;

        // for Database Reservations
        string customaname;
        string addedserv;
        int userr;
        double valueR = 0;
        string roomtype;
        int final_room = 0;
        DateTime startdate ;
        DateTime enddate ;
        string value = "";
        string data = "";

        private void label62_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Booking_Load(object sender, EventArgs e)
        {
            if (Cheff_checkBox.Checked == false && Spar_checkBox.Checked == false && Chauffer_checkBox.Checked == false && Vip_CheckBox.Checked == false)
            {
                addedserv = "None";
            }

            conn.Open();
            string regist = "SELECT First_Name,Surname,User_ID FROM User_Info WHERE Username = @Username ";
            command = new SqlCommand(regist, conn);
            command.Parameters.AddWithValue("@Username", userfirstname);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                customaname = reader["First_Name"].ToString() + " " + reader["Surname"].ToString();
                string userrx = reader[("User_ID")].ToString();

                userr = int.Parse(userrx);
            }
            conn.Close();
        }

        private void Price_label_Click(object sender, EventArgs e)
        {
            new Pricing_Guide().Show();
        }


        public void Calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectdatestart = Calendar.SelectionStart;
            DateTime selectdatend = Calendar.SelectionEnd;
            calendor_textBox.Text = "Booking Info:" +Environment.NewLine+ "From " + selectdatestart + Environment.NewLine + " To " + selectdatend ;

            startdate = Calendar.SelectionRange.Start;
            enddate = Calendar.SelectionRange.End;
          
        }

        private void guest_numeric_ValueChanged(object sender, EventArgs e)
        {
            if (guest_numeric.Value >= 0 && guest_numeric.Value < 2)
            {
                Single_radio.Checked = true;
            }
            else if (guest_numeric.Value >= 2 && guest_numeric.Value < 3)
            {
                Two_radio.Checked = true;
            }
            else 
            {
                family_radio.Checked = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            guest = int.Parse(guest_numeric.Value.ToString());
            DateTime selectdatestart = Calendar.SelectionStart;
            DateTime selectdatend = Calendar.SelectionEnd;
            dayz = (selectdatend - selectdatestart).TotalDays;

            //Single Room Variations
            if (Single_radio.Checked)
            {
                estimated = singlecost * dayz ;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;

            }
            if (Vip_CheckBox.Checked && Single_radio.Checked)
            {
                Chauffer_checkBox.Checked = true;
                Cheff_checkBox.Checked = true;
                Spar_checkBox.Checked = true;
                estimated = vipcost * dayz * singlecost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Chauffer_checkBox.Checked && Single_radio.Checked)
            {
                estimated = drivercost * dayz * singlecost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
           
            if (Cheff_checkBox.Checked && Single_radio.Checked)
            {
                estimated = cheffcost * dayz * singlecost;
                value =  estimated.ToString("#.##");
                total_estimate.Text =  value;
            }
            if (Spar_checkBox.Checked && Single_radio.Checked)
            {
                estimated = spacost * dayz * singlecost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Chauffer_checkBox.Checked && Single_radio.Checked && Spar_checkBox.Checked)
            {
                estimated = drivercost * dayz * singlecost * spacost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Chauffer_checkBox.Checked && Single_radio.Checked && Cheff_checkBox.Checked)
            {
                estimated = drivercost * dayz * singlecost * cheffcost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Cheff_checkBox.Checked && Single_radio.Checked && Spar_checkBox.Checked)
            {
                estimated = cheffcost * dayz * singlecost * spacost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }





            //Two bedroom variations

            if (Two_radio.Checked)
            {
                  estimated = twocost * guest * dayz;
                  value =  estimated.ToString("#.##");
                  total_estimate.Text = value;

            }
            if (Vip_CheckBox.Checked && Two_radio.Checked)
            {
                Chauffer_checkBox.Checked = true;
                Cheff_checkBox.Checked = true;
                Spar_checkBox.Checked = true;
                estimated = vipcost * guest * dayz * twocost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Chauffer_checkBox.Checked && Two_radio.Checked)
            {
                estimated = drivercost * guest * dayz * twocost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;

            }
            if (Cheff_checkBox.Checked && Two_radio.Checked)
            {
                estimated = cheffcost * guest * dayz * twocost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Spar_checkBox.Checked && Two_radio.Checked)
            {
                estimated = spacost * guest * dayz * twocost;
                value =  estimated.ToString("#.##");
                
                total_estimate.Text = value;
            }
            if (Chauffer_checkBox.Checked && Two_radio.Checked && Spar_checkBox.Checked)
            {
                estimated = drivercost * dayz * twocost * spacost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Chauffer_checkBox.Checked && Two_radio.Checked && Cheff_checkBox.Checked)
            {
                estimated = drivercost * dayz * twocost * cheffcost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Cheff_checkBox.Checked && Two_radio.Checked && Spar_checkBox.Checked)
            {
                estimated = cheffcost * dayz * twocost * spacost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }




            //fAMILY VARIATIONS
            if (family_radio.Checked)
            {
                estimated = famcost * guest * dayz;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
          
            if (Vip_CheckBox.Checked && family_radio.Checked)
            {
                Chauffer_checkBox.Checked = true;
                Cheff_checkBox.Checked = true;
                Spar_checkBox.Checked = true;
                estimated = vipcost * guest * dayz * famcost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }

            if (Chauffer_checkBox.Checked && family_radio.Checked)
            {
                estimated = drivercost * guest * dayz * famcost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }

            if (Cheff_checkBox.Checked && family_radio.Checked)
            {
                estimated = cheffcost * guest * dayz * famcost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }

            if (Spar_checkBox.Checked && family_radio.Checked )
            {
                estimated = spacost * guest * dayz *famcost;
                value =   estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Spar_checkBox.Checked && family_radio.Checked && Cheff_checkBox.Checked)
            {
                estimated = spacost * guest * dayz * famcost * cheffcost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Cheff_checkBox.Checked && family_radio.Checked && Chauffer_checkBox.Checked)
            {
                estimated = cheffcost * guest * dayz * famcost * drivercost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }
            if (Cheff_checkBox.Checked && family_radio.Checked && Chauffer_checkBox.Checked)
            {
                estimated = cheffcost * guest * dayz * famcost * spacost;
                value =  estimated.ToString("#.##");
                total_estimate.Text = value;
            }


        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            total_estimate.Text = "0.00";
        }

        private void Book_Submit_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            guest = int.Parse(guest_numeric.Value.ToString());
            DateTime selectdatestart = Calendar.SelectionStart;
            DateTime selectdatend = Calendar.SelectionEnd;
            dayz = (selectdatend - selectdatestart).TotalDays;
            if (Single_radio.Checked == false && Two_radio.Checked == false && family_radio.Checked == false)
            {
                MessageBox.Show("Choose A Room Type Please", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); ;
            }
            else
            {
                if (Single_radio.Checked)
                {
                    estimated = singlecost * dayz;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    roomtype = Single_radio.Text;
                    data = "SELECT MIN(Room_No) FROM Room_Status WHERE Room_Type = 'Single' AND Status = 'Free'";
                }
                if (Vip_CheckBox.Checked && Single_radio.Checked)
                {
                    Chauffer_checkBox.Checked = true;
                    Cheff_checkBox.Checked = true;
                    Spar_checkBox.Checked = true;
                    estimated = vipcost * dayz * singlecost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "VIP";
                }
                if (Chauffer_checkBox.Checked && Single_radio.Checked)
                {
                    estimated = drivercost * dayz * singlecost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Chauffer";
                }

                if (Cheff_checkBox.Checked && Single_radio.Checked)
                {
                    estimated = cheffcost * dayz * singlecost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Cheff";
                }
                if (Spar_checkBox.Checked && Single_radio.Checked)
                {
                    estimated = spacost * dayz * singlecost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "SparDeluxe";
                }
                if (Chauffer_checkBox.Checked && Single_radio.Checked && Spar_checkBox.Checked)
                {
                    estimated = drivercost * dayz * singlecost * spacost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Spar+Chauffer";
                }
                if (Chauffer_checkBox.Checked && Single_radio.Checked && Cheff_checkBox.Checked)
                {
                    estimated = drivercost * dayz * singlecost * cheffcost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Chauffer+Cheff";
                }
                if (Cheff_checkBox.Checked && Single_radio.Checked && Spar_checkBox.Checked)
                {
                    estimated = cheffcost * dayz * singlecost * spacost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Cheff+Spar";
                }


                //Two bedroom variations

                if (Two_radio.Checked)
                {
                    data = "SELECT MIN(Room_No) FROM Room_Status WHERE Room_Type = 'Two Bedroom' AND Status = 'Free'";
                    estimated = twocost * guest * dayz;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    roomtype = Two_radio.Text;

                }
                if (Vip_CheckBox.Checked && Two_radio.Checked)
                {
                    Chauffer_checkBox.Checked = true;
                    Cheff_checkBox.Checked = true;
                    Spar_checkBox.Checked = true;
                    estimated = vipcost * guest * dayz * twocost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "VIP";
                }
                if (Chauffer_checkBox.Checked && Two_radio.Checked)
                {
                    estimated = drivercost * guest * dayz * twocost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Chauffer";

                }
                if (Cheff_checkBox.Checked && Two_radio.Checked)
                {
                    estimated = cheffcost * guest * dayz * twocost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Cheff";
                }
                if (Spar_checkBox.Checked && Two_radio.Checked)
                {
                    estimated = spacost * guest * dayz * twocost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "SparDeluxe";
                }
                if (Chauffer_checkBox.Checked && Two_radio.Checked && Spar_checkBox.Checked)
                {
                    estimated = drivercost * dayz * twocost * spacost;
                    value =  estimated.ToString("#.##");
                    total_estimate.Text = value;
                     valueR = double.Parse(value);
                    addedserv = "Spar+Chauffer";
                }
                if (Chauffer_checkBox.Checked && Two_radio.Checked && Cheff_checkBox.Checked)
                {
                    estimated = drivercost * dayz * twocost * cheffcost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Chauffer+Cheff";
                }
                if (Cheff_checkBox.Checked && Two_radio.Checked && Spar_checkBox.Checked)
                {
                    estimated = cheffcost * dayz * twocost * spacost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Cheff+Spar";
                }




                //fAMILY VARIATIONS
                if (family_radio.Checked)
                {
                    estimated = famcost * guest * dayz;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    roomtype = family_radio.Text;
                    data = "SELECT MIN(Room_No) FROM Room_Status WHERE Room_Type = 'Family' AND Status = 'Free'";

                }

                if (Vip_CheckBox.Checked && family_radio.Checked)
                {
                    Chauffer_checkBox.Checked = true;
                    Cheff_checkBox.Checked = true;
                    Spar_checkBox.Checked = true;
                    estimated = vipcost * guest * dayz * famcost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "VIP";
                }

                if (Chauffer_checkBox.Checked && family_radio.Checked)
                {
                    estimated = drivercost * guest * dayz * famcost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Chauffer";
                }

                if (Cheff_checkBox.Checked && family_radio.Checked)
                {
                    estimated = cheffcost * guest * dayz * famcost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Cheff";
                }

                if (Spar_checkBox.Checked && family_radio.Checked)
                {
                    estimated = spacost * guest * dayz * famcost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "SparDeluxe";
                }
                if (Spar_checkBox.Checked && family_radio.Checked && Cheff_checkBox.Checked)
                {
                    estimated = spacost * guest * dayz * famcost * cheffcost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Cheff+Spar";
                }
                if (Cheff_checkBox.Checked && family_radio.Checked && Chauffer_checkBox.Checked)
                {
                    estimated = cheffcost * guest * dayz * famcost * drivercost;
                    value =  estimated.ToString("#.##");
                     valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Chauffer+Cheff";
                }
                if (Cheff_checkBox.Checked && family_radio.Checked && Chauffer_checkBox.Checked)
                {
                    estimated = cheffcost * guest * dayz * famcost * spacost;
                    value =  estimated.ToString("#.##");
                    valueR = double.Parse(value);
                    total_estimate.Text = value;
                    addedserv = "Spar+Chauffer";
                }

                conn.Open();
                command = new SqlCommand(data, conn);
                SqlDataReader reader = command.ExecuteReader();
                
                if(reader.Read() == false)
                {
                    MessageBox.Show("Fully_Booked", "Please Choose Another", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else if (startdate.Date < today.Date)
                {
                    MessageBox.Show("Please Select A Valid Date", "Invalid Date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    string useRR = reader[("")].ToString();

                    final_room = int.Parse(useRR);

                    Confirmation panel = new Confirmation();
                    panel.customer = customaname;
                    panel.user = userr;
                    panel.guest = guest;
                    panel.roomN = final_room;
                    panel.start = startdate;
                    panel.end = enddate;
                    panel.roomT = roomtype;
                    panel.Totals = valueR;
                    panel.addedserv = addedserv;
                    panel.Show();

                    conn.Close();
                }
                this.Hide();
            }
        
        }
    }
}
