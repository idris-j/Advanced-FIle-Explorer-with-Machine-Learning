using FaceRecognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Z
{
    public partial class faceIDAuth : Form
    {
        public faceIDAuth()
        {
            InitializeComponent();
            FaceRec faceRec = new FaceRec();
            faceRec.openCamera(pictureBox1, pictureBox1);
            faceRec.isTrained = false;
            checkUser(faceRec.isTrained);
        }

        public static void checkUser(bool var)
        {
            if (var == true)
            {
                MessageBox.Show("User known", "Success");
            }
            else if (var == true)
            {
                MessageBox.Show("User unknown", "Error");
            }
        }
    }
}
