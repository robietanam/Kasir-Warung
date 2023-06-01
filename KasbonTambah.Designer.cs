namespace PBO_Kasir
{
    partial class KasbonTambah
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
            this.textBox_NamaBon = new System.Windows.Forms.TextBox();
            this.button_TambahBon = new System.Windows.Forms.Button();
            this.dateTimePicker_TanggalHutang = new System.Windows.Forms.DateTimePicker();
            this.textBox_AtasNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_TenggatHutang = new System.Windows.Forms.DateTimePicker();
            this.label_error = new System.Windows.Forms.Label();
            this.textBox_Jumlah = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Kode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Bon";
            // 
            // textBox_NamaBon
            // 
            this.textBox_NamaBon.Location = new System.Drawing.Point(97, 125);
            this.textBox_NamaBon.Name = "textBox_NamaBon";
            this.textBox_NamaBon.Size = new System.Drawing.Size(138, 20);
            this.textBox_NamaBon.TabIndex = 1;
            // 
            // button_TambahBon
            // 
            this.button_TambahBon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TambahBon.Location = new System.Drawing.Point(247, 266);
            this.button_TambahBon.Name = "button_TambahBon";
            this.button_TambahBon.Size = new System.Drawing.Size(75, 23);
            this.button_TambahBon.TabIndex = 2;
            this.button_TambahBon.Text = "Tambah";
            this.button_TambahBon.UseVisualStyleBackColor = true;
            this.button_TambahBon.Click += new System.EventHandler(this.button_TambahBon_Click);
            // 
            // dateTimePicker_TanggalHutang
            // 
            this.dateTimePicker_TanggalHutang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_TanggalHutang.Location = new System.Drawing.Point(323, 125);
            this.dateTimePicker_TanggalHutang.Name = "dateTimePicker_TanggalHutang";
            this.dateTimePicker_TanggalHutang.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker_TanggalHutang.TabIndex = 3;
            // 
            // textBox_AtasNama
            // 
            this.textBox_AtasNama.Location = new System.Drawing.Point(97, 174);
            this.textBox_AtasNama.Name = "textBox_AtasNama";
            this.textBox_AtasNama.Size = new System.Drawing.Size(138, 20);
            this.textBox_AtasNama.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Atas Nama";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tanggal Hutang";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tenggat Hutang";
            // 
            // dateTimePicker_TenggatHutang
            // 
            this.dateTimePicker_TenggatHutang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker_TenggatHutang.Location = new System.Drawing.Point(323, 197);
            this.dateTimePicker_TenggatHutang.Name = "dateTimePicker_TenggatHutang";
            this.dateTimePicker_TenggatHutang.Size = new System.Drawing.Size(156, 20);
            this.dateTimePicker_TenggatHutang.TabIndex = 7;
            this.dateTimePicker_TenggatHutang.ValueChanged += new System.EventHandler(this.dateTimePicker_TenggatHutang_ValueChanged);
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(94, 304);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(56, 13);
            this.label_error.TabIndex = 11;
            this.label_error.Text = "label_error";
            // 
            // textBox_Jumlah
            // 
            this.textBox_Jumlah.Location = new System.Drawing.Point(97, 218);
            this.textBox_Jumlah.Name = "textBox_Jumlah";
            this.textBox_Jumlah.Size = new System.Drawing.Size(138, 20);
            this.textBox_Jumlah.TabIndex = 13;
            this.textBox_Jumlah.TextChanged += new System.EventHandler(this.textBox_Jumlah_TextChanged);
            this.textBox_Jumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HargaBarang_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Jumlah";
            // 
            // textBox_Kode
            // 
            this.textBox_Kode.Location = new System.Drawing.Point(97, 86);
            this.textBox_Kode.Name = "textBox_Kode";
            this.textBox_Kode.Size = new System.Drawing.Size(138, 20);
            this.textBox_Kode.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kode Bon";
            // 
            // KasbonTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_Kode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Jumlah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker_TenggatHutang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_AtasNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_TanggalHutang);
            this.Controls.Add(this.button_TambahBon);
            this.Controls.Add(this.textBox_NamaBon);
            this.Controls.Add(this.label1);
            this.Name = "KasbonTambah";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NamaBon;
        private System.Windows.Forms.Button button_TambahBon;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TanggalHutang;
        private System.Windows.Forms.TextBox textBox_AtasNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TenggatHutang;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.TextBox textBox_Jumlah;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Kode;
        private System.Windows.Forms.Label label6;
    }
}
