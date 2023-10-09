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
using System.Configuration;

namespace Class_Project
{
    public partial class RegistrationForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dataReader;
        public RegistrationForm()
        {
            InitializeComponent();
            string cs = ConfigurationManager.ConnectionStrings["DBCon"].ConnectionString;
            conn = new SqlConnection(cs);
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            //conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Iftekhar_Shakil\Desktop\1271633\Class_Project\MyProjectDatabase.mdf; Integrated Security = True");
            
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            if (FirstNametb.Text != String.Empty || LastNametb.Text != String.Empty || ConfirmPasswordtb.Text != String.Empty || Passwordtb.Text != String.Empty || UserNametb.Text != String.Empty)
            {
                conn.Open();
                if (Passwordtb.Text == ConfirmPasswordtb.Text)
                {
                    cmd = new SqlCommand("Select * from CoustomersReg where userName='" + UserNametb.Text+"'", conn);
                    dataReader = cmd.ExecuteReader();
                    if (dataReader.Read())
                    {
                        dataReader.Close();
                        MessageBox.Show("User Name Already exist please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        dataReader.Close();
                        cmd = new SqlCommand("insert into CoustomersReg Values(@userName,@password)", conn);
                        cmd.Parameters.AddWithValue("userName", UserNametb.Text);
                        cmd.Parameters.AddWithValue("password", Passwordtb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created. Please login now", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please Please enter both password same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Erron", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
