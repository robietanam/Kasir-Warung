namespace PBO_Kasir
{
    partial class UserProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.button_simpan = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama : ";
            // 
            // textBox_nama
            // 
            this.textBox_nama.Location = new System.Drawing.Point(224, 103);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(152, 20);
            this.textBox_nama.TabIndex = 1;
            this.textBox_nama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_simpan
            // 
            this.button_simpan.Location = new System.Drawing.Point(235, 175);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(75, 23);
            this.button_simpan.TabIndex = 2;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(224, 129);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(152, 20);
            this.textBox_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password : ";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(104, 217);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(35, 13);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "status";
            this.label_status.Click += new System.EventHandler(this.label_status_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.textBox_nama);
            this.Controls.Add(this.label1);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(600, 450);
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
    }
}
