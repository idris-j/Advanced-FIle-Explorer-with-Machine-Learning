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

namespace Project_Z
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
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
            if (textBoxUsername.Text == "" & textBoxPass.Text == "" & textBoxComPass.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (textBoxPass.Text == textBoxComPass.Text)
            {
                conn.Open(); // open connection
                string username = textBoxUsername.Text;
                string password = textBoxPass.Text;
                string register = "INSERT INTO user_tb (username, password) VALUES (@username, @password)";
                command = new OleDbCommand(register, conn);
                command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                command.Parameters.AddWithValue("@password", textBoxPass.Text);
                command.ExecuteNonQuery();
                conn.Close();
                textBoxPass.Text = "";
                textBoxComPass.Text = "";
                textBoxUsername.Text = "";

                MessageBox.Show("Success", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
