namespace PBO_Kasir
{
    partial class login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UsernameBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblInfo.Location = new System.Drawing.Point(19, 112);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(2, 15);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Log In";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsernameBox1
            // 
            this.UsernameBox1.BackColor = System.Drawing.Color.Transparent;
            this.UsernameBox1.Image = ((System.Drawing.Image)(resources.GetObject("UsernameBox1.Image")));
            this.UsernameBox1.Location = new System.Drawing.Point(297, 166);
            this.UsernameBox1.Name = "UsernameBox1";
            this.UsernameBox1.Size = new System.Drawing.Size(40, 40);
            this.UsernameBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UsernameBox1.TabIndex = 7;
            this.UsernameBox1.TabStop = false;
            this.UsernameBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.panel1.Location = new System.Drawing.Point(297, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 3);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.panel2.Location = new System.Drawing.Point(297, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 3);
            this.panel2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(385, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_User
            // 
            this.textBox_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_User.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.textBox_User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.textBox_User.Location = new System.Drawing.Point(347, 174);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(248, 24);
            this.textBox_User.TabIndex = 12;
            this.textBox_User.TextChanged += new System.EventHandler(this.textBox_User_TextChanged);
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(31)))), ((int)(((byte)(106)))));
            this.textBox_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Pass.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.textBox_Pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(113)))), ((int)(((byte)(254)))));
            this.textBox_Pass.Location = new System.Drawing.Point(343, 256);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(248, 24);
            this.textBox_Pass.TabIndex = 13;
            this.textBox_Pass.TextChanged += new System.EventHandler(this.textBox_Pass_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernameBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfo);
            this.Name = "login";
            this.Size = new System.Drawing.Size(816, 489);
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsernameBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox UsernameBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Pass;
    }
}
