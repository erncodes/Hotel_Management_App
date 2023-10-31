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
    public partial class Register : Form
    {
        string title;
        string gender;
        string userunique;
        public Register()
        {
            InitializeComponent();
            First.Focus();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Log_Reg_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Page().Show();
        }

        private void Register_button_Click(object sender, EventArgs e)
        {
            

            if (mr_radio.Checked == true)
            {
                title = mr_radio.Text;
            }
            if(mrs_radio.Checked == true)
            {
                title = mrs_radio.Text;
            }
            if (ms_radio.Checked == true)
            {
                title = ms_radio.Text;
            }
           if (other_radio.Checked == true)
            {
                title = other_radio.Text;
            }
            // for gender
            if (checkBox_male.Checked == true)
            {
                gender = checkBox_male.Text;
            }
            if (checkBox_female.Checked == true)
            {
                gender = checkBox_female.Text;
            }
            if (checkBox_other.Checked == true)
            {
                gender = checkBox_other.Text;
            }


            if (First.Text == "" || surname.Text == ""
                || contact.Text == ""|| Username.Text == "" || Password_T.Text == ""
                || Confirm_Pass.Text == "")
            {
                MessageBox.Show("Please Complete All Fields", "Registration Failed",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

            else if (mr_radio.Checked == false && mrs_radio.Checked == false &&
                ms_radio.Checked == false && other_radio.Checked == false)
            {
                MessageBox.Show("Please Select A Title", "Registration Failed",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (checkBox_male.Checked == false && checkBox_female.Checked == false &&
                 checkBox_other.Checked == false)
            {
                MessageBox.Show("Please Select A Gender", "Registration Failed",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (Password_T.Text != Confirm_Pass.Text)
            {
                MessageBox.Show("Your Password Does Not Match", "Registration Failed",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                string regista = "INSERT INTO User_Info VALUES('"+ First.Text + "','"+ surname.Text + "','" + title + "','" + gender +"','"+ contact.Text + "','"+ Username.Text + "','"+Password_T.Text+"')";
                command = new SqlCommand(regista, conn);
                command.ExecuteNonQuery();
                conn.Close();
                this.Hide();
                RegSus paneloo = new RegSus();
                paneloo.Show();
                paneloo.user = Username.Text;
                paneloo.pass = Password_T.Text;


                First.Text = "";
                surname.Text = "";
                contact.Text = "";
                Username.Text = "";
                Password_T.Text = "";
                Confirm_Pass.Text = "";
            }
        }

        private void Reg_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_pass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pass.Checked == true)
            {
                Password_T.PasswordChar = '\0';
            }
            else
            {
                Password_T.PasswordChar = '•';
            }
        }

        private void button_user_Click(object sender, EventArgs e)
        {

            string user = First.Text;
            string number = contact.Text;
            string userQ = user.Substring(0);
            string numberQ = number.Substring(7);

            userunique = userQ + numberQ;
            Username.Text = userunique;
        }

        private void button_user_MouseClick(object sender, MouseEventArgs e)
        {
            Random userno = new Random();
            int random = userno.Next(0,1000);
            string user = First.Text;
            string number = contact.Text;
            string userQ = user.Substring(0);

            userunique = userQ + random;
            Username.Text = userunique;
        }
    }
}
