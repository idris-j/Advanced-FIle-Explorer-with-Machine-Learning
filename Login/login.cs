using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //for microsoft access db
using System.Security.Cryptography;
using Project_Z.Splash;

namespace Project_Z
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.Text = "Login";
            this.Icon = new Icon("../../dpabs-icon.ico");


        }

        public static class User
        {
            public static String LoginName { get; set; }
        }

        //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLED")
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=users_db.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        public void button1_Click_1(object sender, EventArgs e)
        {
            string tempUserName = textBoxUsername.Text;
            User.LoginName = tempUserName;
            if (tempUserName == "")
            {
                MessageBox.Show("String Empty\nUsername field cannot be empty", "Error");
            }
            else if (textBoxPass.Text == "")
            {
                MessageBox.Show("String Empty\nPassword field cannot be empty", "Error");
            }
            else
            {
                try
                {
                    conn.Open(); // Open connection

                    string loginQuery = "SELECT * FROM users_tbl WHERE username = @username";

                    command = new OleDbCommand(loginQuery, conn);
                    command.Parameters.AddWithValue("@username", textBoxUsername.Text);

                    OleDbDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        string storedHashedPassword = reader["password"].ToString();

                        using (SHA256 sha256 = SHA256.Create())
                        {
                            byte[] passwordBytes = Encoding.UTF8.GetBytes(textBoxPass.Text);
                            byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
                            string hashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                            if (storedHashedPassword == hashedPassword)
                            {
                                // User credentials are valid, perform actions here
                                View view = new View();
                                view.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                textBoxPass.Text = "";
                                textBoxUsername.Text = "";
                                textBoxUsername.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPass.Text = "";
                        textBoxUsername.Text = "";
                        textBoxUsername.Focus();
                    }

                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            textBoxPass.Text = "";
            textBoxUsername.Text = "";
            textBoxUsername.Focus();
        }
        private void label7_Click_1(object sender, EventArgs e)
        {
            splash splash = new splash();
            splash.Show();
            this.Hide();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxComPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPass.PasswordChar = '•';
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
