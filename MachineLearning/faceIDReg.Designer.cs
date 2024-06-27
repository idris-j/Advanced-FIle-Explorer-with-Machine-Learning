namespace Project_Z
{
    partial class faceIDReg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userLoginLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.camera_btn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.faceIDCheckBox = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 59;
            this.label1.Text = "CAMERA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "CAPTURED";
            // 
            // userLoginLabel
            // 
            this.userLoginLabel.AutoSize = true;
            this.userLoginLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userLoginLabel.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.userLoginLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userLoginLabel.Location = new System.Drawing.Point(726, 429);
            this.userLoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLoginLabel.Name = "userLoginLabel";
            this.userLoginLabel.Size = new System.Drawing.Size(27, 12);
            this.userLoginLabel.TabIndex = 62;
            this.userLoginLabel.Text = "user";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.userNameLabel.Location = new System.Drawing.Point(649, 429);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(74, 12);
            this.userNameLabel.TabIndex = 61;
            this.userNameLabel.Text = "Signed in as: ";
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.save_btn.BackgroundImage = global::Dpabs_FE.Properties.Resources.white_disk;
            this.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.FlatAppearance.BorderSize = 0;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(253, 355);
            this.save_btn.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(37, 36);
            this.save_btn.TabIndex = 58;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // camera_btn
            // 
            this.camera_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.camera_btn.BackgroundImage = global::Dpabs_FE.Properties.Resources.white_camera;
            this.camera_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.camera_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.camera_btn.FlatAppearance.BorderSize = 0;
            this.camera_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.camera_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camera_btn.Location = new System.Drawing.Point(194, 355);
            this.camera_btn.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.camera_btn.Name = "camera_btn";
            this.camera_btn.Size = new System.Drawing.Size(37, 36);
            this.camera_btn.TabIndex = 57;
            this.camera_btn.UseVisualStyleBackColor = false;
            this.camera_btn.Click += new System.EventHandler(this.camera_btn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Location = new System.Drawing.Point(442, 190);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 144);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Location = new System.Drawing.Point(100, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 267);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // faceIDCheckBox
            // 
            this.faceIDCheckBox.AutoSize = true;
            this.faceIDCheckBox.Location = new System.Drawing.Point(442, 67);
            this.faceIDCheckBox.Name = "faceIDCheckBox";
            this.faceIDCheckBox.Size = new System.Drawing.Size(123, 20);
            this.faceIDCheckBox.TabIndex = 63;
            this.faceIDCheckBox.Text = "Enable/Disable";
            this.faceIDCheckBox.UseVisualStyleBackColor = true;
            this.faceIDCheckBox.CheckedChanged += new System.EventHandler(this.faceIDCheckBox_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Dpabs_FE.Properties.Resources.logout_1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(764, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 27);
            this.button3.TabIndex = 64;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // faceIDReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.faceIDCheckBox);
            this.Controls.Add(this.userLoginLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.camera_btn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "faceIDReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faceIDReg";
            this.Load += new System.EventHandler(this.faceIDReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button camera_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userLoginLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.CheckBox faceIDCheckBox;
        private System.Windows.Forms.Button button3;
    }
}