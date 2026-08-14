using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; //for microsoft access db
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;

namespace Project_Z
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();

            this.Text = "Register";
            this.Icon = new Icon("../../dpabs-icon.ico");
        }

        //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLED")
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=users_db.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        private void label7_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void reg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPass.Text;
            string confirmPassword = textBoxComPass.Text;
            if (textBoxUsername.Text == "" & textBoxPass.Text == "" & textBoxComPass.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password == confirmPassword)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                    byte[] hashedBytes = sha256.ComputeHash(passwordBytes);
                    string hashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                    try
                    {
                        conn.Open(); // Open connection

                        string registerQuery = "INSERT INTO users_tbl ([username], [password]) VALUES (@username, @password)";
                        command = new OleDbCommand(registerQuery, conn);
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", hashedPassword);
                        command.ExecuteNonQuery();

                        conn.Close();

                        textBoxPass.Text = "";
                        textBoxComPass.Text = "";
                        textBoxUsername.Text = "";

                        MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        login login = new login();
                        login.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Password does not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPass.Text = "";
                textBoxComPass.Text = "";
                textBoxPass.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxPass.Text = "";
            textBoxComPass.Text = "";
            textBoxUsername.Text = "";
            textBoxUsername.Focus();
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                textBoxPass.PasswordChar = '\0';
                textBoxComPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPass.PasswordChar = '•';
                textBoxComPass.PasswordChar = '•';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
