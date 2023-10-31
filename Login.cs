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
    public partial class Login_Page : Form
    {
        
        public Login_Page()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ernst-pc;Initial Catalog=Hotel_Management;Integrated Security=True");
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command = new SqlCommand();
        private void Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            string regist = "SELECT * FROM User_Info WHERE Username = '" + Username_T.Text + "' and Password = '" + Password_T.Text + "'";
            command = new SqlCommand(regist, conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read() == true)
            {
            
                if (Username_T.Text == "Admin13")
                {
                    Room_Management panelo = new Room_Management();
                    this.Hide();
                    panelo.Show();
                    Username_T.Text = "";
                    Password_T.Text = "";
                }

                else
                {
                    
                    this.Hide();
                    Dashboard panel = new Dashboard();
                    panel.userfirstname = Username_T.Text;
                    panel.Show();
                    Username_T.Text = "";
                    Password_T.Text = "";
                }
            }
            else if (Username_T.Text == "" || Password_T.Text == "")
            {
                MessageBox.Show("Please Enter A Username And Password", "Login Failed",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Username_T.Text = "";
                Password_T.Text = "";
                Username_T.Focus();
            }
            else
            {
                MessageBox.Show("Invalid Login Details", "Login Failed",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Username_T.Text = "";
                Password_T.Text = "";
                Username_T.Focus();
            }

            conn.Close();

        }

        private void Login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reg_Log_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void checkBox_login_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_login.Checked == true)
            {
                Password_T.PasswordChar = '\0';
            }
            else
            {
                Password_T.PasswordChar = '•';
            }
        }
    }
}
