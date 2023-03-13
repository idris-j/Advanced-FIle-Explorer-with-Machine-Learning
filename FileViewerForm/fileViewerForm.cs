using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using AxWMPLib;
using System.Diagnostics;

namespace Project_Z
{
    public partial class fileViewerForm : Form
    {
        List<string> movieExt = new List<string> {"mp4","mov","mkv","gif"};
        List<string> imageExt = new List<string> { "jpg", "jpeg", "png", "" };
        List<string> txtExt = new List<string> { "txt", "ini", "cs", "py" };

        MediaElement mediaElement = new MediaElement();
        private string filePath;
        public System.Drawing.Image cImage;
        private int _zoomLevel = 100;
        public fileViewerForm(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            LoadFile(filePath.ToLower());
        }
        private void LoadFile(string filePath)
        {
            try
            {
                if (filePath.EndsWith("mp4") || filePath.EndsWith("mkv") || filePath.EndsWith("mov") || filePath.EndsWith("gif"))
                {
                    string x = filePath;
                    // Create a panel control to enable full screen of player
                    System.Windows.Forms.Panel panel1 = new System.Windows.Forms.Panel();
                    panel1.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Dock = DockStyle.Fill;

                    axWindowsMediaPlayer1.Dock = DockStyle.Fill;
                    // Create a panel control to enable full screen of player

                    // Add the AxWindowsMediaPlayer control to the panel control
                    //panel1.Controls.Add(axWindowsMediaPlayer1) ;
                    webBrowser1.Hide();
                    axWindowsMediaPlayer1.URL = x;

                }
                else if (filePath.EndsWith("jpg") || filePath.EndsWith("jpeg") || filePath.EndsWith("png") || filePath.EndsWith("gif") || filePath.EndsWith("txt") || filePath.EndsWith("ini") || filePath.EndsWith("cs") || filePath.EndsWith("py"))
                {
                    //fileBrowser.Navigate(filePath);
                    //System.Drawing.Image currentImage = System.Drawing.Image.FromFile(filePath);
                    //pictureView.Image = currentImage;

                    // Create a panel control to enable full screen of player
                    System.Windows.Forms.Panel panel1 = new System.Windows.Forms.Panel();
                    panel1.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Dock = DockStyle.Fill;
                    webBrowser1.Dock = DockStyle.Fill; 
                    webBrowser1.Navigate(filePath);
                    webBrowser1.DocumentCompleted += (sender, e) => {
                        webBrowser1.Document.Body.Style = "zoom: " + (webBrowser1.Width / (double)webBrowser1.Document.Body.ScrollRectangle.Width * 100) + "%";
                    };
                    axWindowsMediaPlayer1.Visible = false;
                }
                else
                {
                    //MessageBox.Show("Unsupported File Type", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Process.Start(filePath);
                    var fileViewerForm = new fileViewerForm("");
                    fileViewerForm.Hide();
                    return;
                }
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine("Error message: " + ex.Message);
                Console.WriteLine("Stack trace: " + ex.StackTrace);
            }
        }

        private void pictureView_Click(object sender, EventArgs e)
        {

        }

        private void fileViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayerView_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
