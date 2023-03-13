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

namespace Project_Z
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();


        }
        //OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLED")
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=users_db.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        private void button1_Click_1(object sender, EventArgs e)
        {

            conn.Open();//open connection
            string login = "SELECT * FROM user_tb WHERE username = " + textBoxUsername.Text + " and password = " + textBoxPass.Text + ")";
            command = new OleDbCommand(login, conn);
            command.ExecuteNonQuery();
            conn.Close();
            if (textBoxUsername.Text == "" & textBoxPass.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Ivalid usernme or password", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPass.Text = "";
                textBoxUsername.Text = "";
                textBoxPass.Focus();
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
            reg reg = new reg();
            reg.Show();
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
    }
}
