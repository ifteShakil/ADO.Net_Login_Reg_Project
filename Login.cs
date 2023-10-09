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

namespace Class_Project
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dataReader;
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(Passwordtb.Text != String.Empty || UserNametb.Text != String.Empty)
            {
                cmd = new SqlCommand("Select * from CoustomersReg where userName ='" + UserNametb.Text + "' and password = '" + Passwordtb.Text + "'", conn);
                dataReader = cmd.ExecuteReader();
                if(dataReader.Read())
                {
                    dataReader.Close();
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    dataReader.Close();
                    MessageBox.Show("Invalide User name or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegisterNowbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registration = new RegistrationForm();
            registration.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source = localhost; AttachDbFilename = C:\Users\Iftekhar_Shakil\Desktop\1271633\Class_Project\MyProjectDatabase.mdf; Integrated Security = True");
            conn.Open();
        }

        
    }
}
