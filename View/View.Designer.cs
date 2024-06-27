namespace Project_Z
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.backButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.filePass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.shred_btn = new System.Windows.Forms.Button();
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chat_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(8, 0);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(47, 26);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "<-";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goButton.Location = new System.Drawing.Point(1049, 0);
            this.goButton.Margin = new System.Windows.Forms.Padding(4);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(51, 27);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "->";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(16, 55);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(981, 576);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "doc.png");
            this.iconList.Images.SetKeyName(1, "folder.png");
            this.iconList.Images.SetKeyName(2, "music.png");
            this.iconList.Images.SetKeyName(3, "pdf.png");
            this.iconList.Images.SetKeyName(4, "photo.png");
            this.iconList.Images.SetKeyName(5, "txt.png");
            this.iconList.Images.SetKeyName(6, "video.png");
            this.iconList.Images.SetKeyName(7, "zip.png");
            this.iconList.Images.SetKeyName(8, "unknown.png");
            this.iconList.Images.SetKeyName(9, "exe.png");
            this.iconList.Images.SetKeyName(10, "text.png");
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.AcceptsReturn = true;
            this.filePathTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.filePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePathTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathTextBox.Location = new System.Drawing.Point(109, 5);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(921, 20);
            this.filePathTextBox.TabIndex = 3;
            this.filePathTextBox.TextChanged += new System.EventHandler(this.filePathTextBox_TextChanged);
            this.filePathTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filePathTextBox_KeyDown);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(17, 646);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(15, 16);
            this.fileNameLabel.TabIndex = 5;
            this.fileNameLabel.Text = "--";
            this.fileNameLabel.Click += new System.EventHandler(this.fileNameLabel_Click);
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(467, 646);
            this.fileTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(15, 16);
            this.fileTypeLabel.TabIndex = 7;
            this.fileTypeLabel.Text = "--";
            this.fileTypeLabel.Click += new System.EventHandler(this.fileTypeLabel_Click);
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(945, 647);
            this.fileSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(15, 16);
            this.fileSizeLabel.TabIndex = 8;
            this.fileSizeLabel.Text = "--";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1036, 134);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(333, 291);
            this.webBrowser1.TabIndex = 9;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // filePass
            // 
            this.filePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.filePass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filePass.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePass.Location = new System.Drawing.Point(1039, 597);
            this.filePass.Margin = new System.Windows.Forms.Padding(4);
            this.filePass.Multiline = true;
            this.filePass.Name = "filePass";
            this.filePass.PasswordChar = '•';
            this.filePass.Size = new System.Drawing.Size(291, 34);
            this.filePass.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(1035, 571);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Password:";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(1088, 87);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(140, 27);
            this.appNameLabel.TabIndex = 51;
            this.appNameLabel.Text = "APP NAME";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.userNameLabel.Location = new System.Drawing.Point(1248, 646);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(74, 12);
            this.userNameLabel.TabIndex = 52;
            this.userNameLabel.Text = "Signed in as: ";
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userLoginLabel.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.userLoginLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userLoginLabel.Location = new System.Drawing.Point(1325, 646);
            this.userLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(27, 12);
            this.userLoginLabel.TabIndex = 54;
            this.userLoginLabel.Text = "user";
            this.userLoginLabel.Click += new System.EventHandler(this.userLoginLabel_Click);
            // 
            // shred_btn
            // 
            this.shred_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.shred_btn.BackgroundImage = global::Dpabs_FE.Properties.Resources.white_bin1;
            this.shred_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.shred_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shred_btn.FlatAppearance.BorderSize = 0;
            this.shred_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shred_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shred_btn.Location = new System.Drawing.Point(1220, 448);
            this.shred_btn.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.shred_btn.Name = "shred_btn";
            this.shred_btn.Size = new System.Drawing.Size(37, 36);
            this.shred_btn.TabIndex = 56;
            this.shred_btn.UseVisualStyleBackColor = false;
            this.shred_btn.Click += new System.EventHandler(this.shred_btn_Click);
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.encrypt_btn.BackgroundImage = global::Dpabs_FE.Properties.Resources.white_lock;
            this.encrypt_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.encrypt_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encrypt_btn.FlatAppearance.BorderSize = 0;
            this.encrypt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_btn.Location = new System.Drawing.Point(1339, 595);
            this.encrypt_btn.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(37, 36);
            this.encrypt_btn.TabIndex = 55;
            this.encrypt_btn.UseVisualStyleBackColor = false;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Dpabs_FE.Properties.Resources.logout_1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1371, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 27);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chat_btn
            // 
            this.chat_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.chat_btn.BackgroundImage = global::Dpabs_FE.Properties.Resources.white_chat;
            this.chat_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chat_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chat_btn.FlatAppearance.BorderSize = 0;
            this.chat_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chat_btn.Location = new System.Drawing.Point(1161, 448);
            this.chat_btn.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.chat_btn.Name = "chat_btn";
            this.chat_btn.Size = new System.Drawing.Size(37, 36);
            this.chat_btn.TabIndex = 53;
            this.chat_btn.UseVisualStyleBackColor = false;
            this.chat_btn.Click += new System.EventHandler(this.chat_btn_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1405, 671);
            this.Controls.Add(this.shred_btn);
            this.Controls.Add(this.encrypt_btn);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.chat_btn);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filePass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.Button shred_btn;
        private System.Windows.Forms.Button chat_btn;
    }
}

