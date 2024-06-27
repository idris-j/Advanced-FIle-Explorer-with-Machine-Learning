using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_Z.login;
using FaceRecognition;
using System.Windows.Controls.Primitives;
using Google.Protobuf.WellKnownTypes;
using System.Threading;

namespace Project_Z
{
    public partial class faceIDReg : Form
    {
        public faceIDReg()
        {
            InitializeComponent();


            userLoginLabel.Text = User.LoginName;
            // Loading settings
            bool faceIDEnabled = Dpabs_FE.Properties.Settings.Default.faceIDToggle;
            if (faceIDEnabled == true) 
            {
                faceIDCheckBox.Checked = true;
            }
            else
            {
                faceIDCheckBox.Checked = false;
            }
        }

        FaceRec faceRec = new FaceRec();

        private void faceIDReg_Load(object sender, EventArgs e)
        {

        }

        private void camera_btn_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBox1, pictureBox2);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(User.LoginName);
            //MessageBox.Show("Save success");
            faceRec.isTrained = true;
        }

        private void faceIDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (faceIDCheckBox.Checked)
            {
                Dpabs_FE.Properties.Settings.Default.faceIDToggle = true;
                Dpabs_FE.Properties.Settings.Default.Save();
            }
            else
            {
                Dpabs_FE.Properties.Settings.Default.faceIDToggle = false;
                Dpabs_FE.Properties.Settings.Default.Save();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }
    }
}