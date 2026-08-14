using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using WMPLib;
using AxWMPLib;
using System.Windows.Shapes;
using System.Threading;
using System.Security.Cryptography;
using System.Windows.Controls.Primitives;
using System.Diagnostics;
using static Project_Z.login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Z
{
    public partial class View : Form
    {
        
        //private string currentUser = Environment.UserName;
        //private string userRootFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Environment.UserName);
        private string filePath = System.IO.Path.Combine("C:\\", "Users", Environment.UserName);
        private string cmdDir = System.IO.Path.Combine("C:\\", "Users", Environment.UserName);
        private bool isFile = false; //its false for navigation
        private string currentlySelectedItemName;
        public View()
        {
            InitializeComponent();
            //webBrowser1.Parent.BackColor = Color.DimGray;
            //listView1.Focus();
            this.Text = "File Explorer";
            this.Icon = new Icon("../../dpabs-icon.ico");
            userLoginLabel.Text = User.LoginName;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //enable keypress events to be raised:
            appNameLabel.Text = "DPABS EXPLORER";
            filePathTextBox.Text = filePath;
            //login login = new login();
            //string tempUsername = login.tempUserName;

            //userNameLabel.Text = tempUsername;
            loadFileAndDirectories();
        }

        public void fileShredder(string fileToShred)
        { 
            
        }
        public void loadFileDetails()
        {
            string tempFilePath = "";
            webBrowser1.Navigate("");
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "\\" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;

                    fileTypeLabel.Text = fileDetails.Extension;
                    long fileSizeInBytes = fileDetails.Length;
                    double fileSizeInKB = fileSizeInBytes / 1024.0;
                    double fileSizeInMB = fileSizeInKB / 1024.0;

                    if (fileSizeInMB >= 1)
                    {
                        fileSizeLabel.Text = fileSizeInMB.ToString("0.00") + " MB";
                    }
                    else if (fileSizeInKB >= 1)
                    {
                        fileSizeLabel.Text = fileSizeInKB.ToString("0.00") + " KB";
                    }
                    else
                    {
                        fileSizeLabel.Text = fileSizeInBytes.ToString() + " bytes";
                    }

                    fileAttr = File.GetAttributes(tempFilePath);
                    FileInfo file = new FileInfo(tempFilePath);
                    string fileExtension = file.Extension.ToLower();
                    switch (fileExtension)
                    {
                        case ".png":
                        case ".jpg":
                        case ".txt":
                            webBrowser1.Navigate(tempFilePath);
                            webBrowser1.DocumentCompleted += (sender, e) => {
                                webBrowser1.Document.Body.Style = "zoom: " + (webBrowser1.Width / (double)webBrowser1.Document.Body.ScrollRectangle.Width * 100) + "%";
                            };
                            break;
                        default:
                            webBrowser1.DocumentText = "<html><body><p>Unable to preview file: </p></body></html>";
                            break;
                    }
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);


                }
            }
            catch (Exception e)
            {

            }

        }
        public void loadFileAndDirectories() 
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "\\" + currentlySelectedItemName;

                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileAttr = File.GetAttributes(tempFilePath);
                    FileInfo file = new FileInfo(tempFilePath);
                    string fileExtension = file.Extension.ToLower();

                    string password = filePass.Text;
                    if (password == "")
                    {
                        MessageBox.Show("Password field cannot be empty", "Encryption Process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        filePass.Focus();
                        return;
                    }
                    else
                    {
                        filePass.Clear();

                        if (fileExtension == ".dpabs")
                        {
                            // Create a Stopwatch instance
                            Stopwatch stopwatch = new Stopwatch();

                            // Start the stopwatch
                            stopwatch.Start();

                            decryptFile(tempFilePath, password);

                            // Stop the stopwatch
                            stopwatch.Stop();

                            // Get the elapsed time in milliseconds
                            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

                            //MessageBox.Show(elapsedMilliseconds.ToString());
                            Console.WriteLine($"Decryption Processing time: {elapsedMilliseconds} ms.");
                        }
                        else
                        {
                            // Create a Stopwatch instance
                            Stopwatch stopwatch = new Stopwatch();

                            // Start the stopwatch
                            stopwatch.Start();


                            encryptFile(tempFilePath, password);

                            // Stop the stopwatch
                            stopwatch.Stop();

                            // Get the elapsed time in milliseconds
                            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

                            //MessageBox.Show(elapsedMilliseconds.ToString());
                            Console.WriteLine($"Encryption Processing time: {elapsedMilliseconds} ms.");

                        }

                    }
                    //switch (fileExtension)
                    //{
                    //    case ".mp4":
                    //    case ".avi":
                    //    case ".mkv":
                    //        //var fileViewerForm = new fileViewerForm(tempFilePath);
                    //        //AxWindowsMediaPlayer player = new AxWindowsMediaPlayer();
                    //        fileViewerForm.Show();
                    //        break;
                    //    case ".txt":
                    //    case ".jpg":
                    //    case ".png":
                    //        fileViewerForm.Show();
                    //        break;
                    //    default:
                    //        Process.Start(tempFilePath);
                    //        break;
                    //}
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                    

                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); //get all files
                    DirectoryInfo[] dirs = fileList.GetDirectories(); //get all directories
                    string fileExtension = "";
                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToLower();
                        switch (fileExtension)
                        {
                            case ".mp3":
                            case ".mp2":
                                listView1.Items.Add(files[i].Name, 2);
                                break;
                            case ".exe":
                            case ".com":
                                listView1.Items.Add(files[i].Name, 9);
                                break;
                            case ".mp4":
                            case ".avi":
                            case ".mkv":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".pdf":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".doc":
                            case ".docx":
                                listView1.Items.Add(files[i].Name, 0);
                                break;
                            case ".png":
                            case ".jpg":
                            case ".jpeg":
                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".txt":
                            case ".xml":
                            case ".ini":
                            case ".json":
                                listView1.Items.Add(files[i].Name, 10);
                                break;

                            default:
                                listView1.Items.Add(files[i].Name, 8);
                                break;
                        }

                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 1);

                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }
            }
            catch (Exception e)
            { 
            }
        }
        public void SecurelyDeleteFile(string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Write))
                {
                    // Overwrite file content with random data
                    byte[] randomData = new byte[fileStream.Length];
                    new Random().NextBytes(randomData);
                    fileStream.Write(randomData, 0, randomData.Length);
                }

                // Delete the file
                File.Delete(filePath);

                MessageBox.Show("Original file securely deleted.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while securely deleting file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        byte[] salt = Encoding.UTF8.GetBytes("dpabs2023");
        public void decryptFile(string fileToDecrypt, string password)
        {
            try
            {
                string decryptedFilePath = System.IO.Path.ChangeExtension(fileToDecrypt, null); // Remove the extension

                using (Aes aesAlg = Aes.Create())
                {
                    Rfc2898DeriveBytes keyDerivationFunction = new Rfc2898DeriveBytes(password, salt);
                    aesAlg.Key = keyDerivationFunction.GetBytes(aesAlg.KeySize / 8);
                    aesAlg.IV = keyDerivationFunction.GetBytes(aesAlg.BlockSize / 8);

                    using (FileStream encryptedFileStream = new FileStream(fileToDecrypt, FileMode.Open))
                    using (FileStream decryptedFileStream = new FileStream(decryptedFilePath, FileMode.Create))
                    using (CryptoStream cryptoStream = new CryptoStream(decryptedFileStream, aesAlg.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        encryptedFileStream.CopyTo(cryptoStream);
                    }
                }

                MessageBox.Show("File decrypted successfully.");
                SecurelyDeleteFile(fileToDecrypt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void encryptFile(string fileToEncrypt, string password)
        {
            try
            {
                // Read the original file content
                byte[] fileBytes = File.ReadAllBytes(fileToEncrypt);
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.KeySize = 256; // Set the key size to 256 bits

                    // Derive key and IV from password and salt
                    Rfc2898DeriveBytes keyDerivationFunction = new Rfc2898DeriveBytes(password, salt);
                    aesAlg.Key = keyDerivationFunction.GetBytes(aesAlg.KeySize / 8);
                    aesAlg.IV = keyDerivationFunction.GetBytes(aesAlg.BlockSize / 8);

                    // Create a new memory stream to write encrypted data
                    using (MemoryStream encryptedStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream(encryptedStream, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cryptoStream.Write(fileBytes, 0, fileBytes.Length);
                            cryptoStream.FlushFinalBlock();
                        }

                        // Write encrypted data to the file with the specified extension
                        string encryptedFilePath = System.IO.Path.ChangeExtension(fileToEncrypt, "dpabs");
                        File.WriteAllBytes(encryptedFilePath, encryptedStream.ToArray());

                        MessageBox.Show("File encrypted successfully.");
                    }
                    SecurelyDeleteFile(fileToEncrypt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void loadButonAction() 
        {
            removeBackSlash();
            filePath = filePathTextBox.Text;
            if (filePath.ToLower() == "cmd")
            {
                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.WorkingDirectory = cmdDir;
                process.Start();
            }

            // Create a Stopwatch instance
            Stopwatch stopwatch = new Stopwatch();

            // Start the stopwatch
            stopwatch.Start();


            loadFileAndDirectories();

            // Stop the stopwatch
            stopwatch.Stop();

            // Get the elapsed time in milliseconds
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            Console.WriteLine($"Load Files Processing Time: {elapsedMilliseconds} ms.");
            isFile = false;

        }
        //remove additional and inadvertently added backslash
        public void removeBackSlash()
        {
            string path = filePathTextBox.Text;
            if (path.LastIndexOf ("\\") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }
        public void goBack() 
        {
            try
            {
                removeBackSlash();
                string path = filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("\\"));
                this.isFile = false;
                filePathTextBox.Text = path;
                removeBackSlash();
            }
            catch (Exception e)
            { 
            
            }
        }
        private void goButton_Click(object sender, EventArgs e)
        {
            loadButonAction();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileAttr = File.GetAttributes(filePath + "\\" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTextBox.Text = filePath + "\\" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;

            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButonAction();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            goBack();
            loadButonAction();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            fileNameLabel.Text = "...";
            fileTypeLabel.Text = "...";

            fileSizeLabel.Text = "...";
            loadFileDetails();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void filePathTextBox_KeyDown(object sender, KeyEventArgs e) //handle enter key event
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadButonAction();
                // Set e.Handled to true to prevent the textbox from processing the Enter key as input
                e.Handled = true;
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            login login = new login();
            this.Hide();
            login.Show();
        }

        private void filePathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fileNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void encrypt_btn_Click(object sender, EventArgs e)
        {
            loadButonAction();
        }
        
        private void chat_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DPABS Secure Messaging App is currently under development.\nOur existing customers would be the first to know once we launch.\n\nThank you!","Coming soon");
        }

        private void shred_btn_Click(object sender, EventArgs e)
        {

        }

        private void fileTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void userLoginLabel_Click(object sender, EventArgs e)
        {
            faceIDReg Face = new faceIDReg();
            Face.Show();
        }
    }
}
