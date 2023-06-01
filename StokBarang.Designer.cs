namespace PBO_Kasir
{
    partial class StokBarang
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
            this.labe1 = new System.Windows.Forms.Label();
            this.textBox_NamaBarang = new System.Windows.Forms.TextBox();
            this.textBox_HargaDasar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_HargaBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Kode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Stok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Kategori = new System.Windows.Forms.ComboBox();
            this.button_tambahKategori = new System.Windows.Forms.Button();
            this.button_simpanBarang = new System.Windows.Forms.Button();
            this.label_kode = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labe1
            // 
            this.labe1.AutoSize = true;
            this.labe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labe1.Location = new System.Drawing.Point(91, 51);
            this.labe1.Name = "labe1";
            this.labe1.Size = new System.Drawing.Size(95, 17);
            this.labe1.TabIndex = 0;
            this.labe1.Text = "Nama Barang";
            // 
            // textBox_NamaBarang
            // 
            this.textBox_NamaBarang.Location = new System.Drawing.Point(94, 71);
            this.textBox_NamaBarang.Name = "textBox_NamaBarang";
            this.textBox_NamaBarang.Size = new System.Drawing.Size(121, 20);
            this.textBox_NamaBarang.TabIndex = 1;
            this.textBox_NamaBarang.TextChanged += new System.EventHandler(this.textBox_NamaBarang_TextChanged);
            // 
            // textBox_HargaDasar
            // 
            this.textBox_HargaDasar.Location = new System.Drawing.Point(94, 133);
            this.textBox_HargaDasar.Name = "textBox_HargaDasar";
            this.textBox_HargaDasar.Size = new System.Drawing.Size(121, 20);
            this.textBox_HargaDasar.TabIndex = 3;
            this.textBox_HargaDasar.TextChanged += new System.EventHandler(this.textBox_HargaDasar_TextChanged);
            this.textBox_HargaDasar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HargaDasar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(92, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Harga Dasar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(92, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori (Opsional)";
            // 
            // textBox_HargaBarang
            // 
            this.textBox_HargaBarang.Location = new System.Drawing.Point(94, 199);
            this.textBox_HargaBarang.Name = "textBox_HargaBarang";
            this.textBox_HargaBarang.Size = new System.Drawing.Size(121, 20);
            this.textBox_HargaBarang.TabIndex = 9;
            this.textBox_HargaBarang.TextChanged += new System.EventHandler(this.textBox_HargaBarang_TextChanged);
            this.textBox_HargaBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HargaBarang_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(92, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Harga Barang";
            // 
            // textBox_Kode
            // 
            this.textBox_Kode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Kode.Location = new System.Drawing.Point(314, 71);
            this.textBox_Kode.Name = "textBox_Kode";
            this.textBox_Kode.Size = new System.Drawing.Size(121, 20);
            this.textBox_Kode.TabIndex = 11;
            this.textBox_Kode.TextChanged += new System.EventHandler(this.textBox_Kode_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(312, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kode";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_Stok
            // 
            this.textBox_Stok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Stok.Location = new System.Drawing.Point(314, 133);
            this.textBox_Stok.Name = "textBox_Stok";
            this.textBox_Stok.Size = new System.Drawing.Size(121, 20);
            this.textBox_Stok.TabIndex = 13;
            this.textBox_Stok.TextChanged += new System.EventHandler(this.textBox_Stok_TextChanged);
            this.textBox_Stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Stok_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(312, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stok";
            // 
            // comboBox_Kategori
            // 
            this.comboBox_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Kategori.FormattingEnabled = true;
            this.comboBox_Kategori.Location = new System.Drawing.Point(94, 269);
            this.comboBox_Kategori.Name = "comboBox_Kategori";
            this.comboBox_Kategori.Size = new System.Drawing.Size(129, 21);
            this.comboBox_Kategori.TabIndex = 16;
            this.comboBox_Kategori.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kategori_SelectedIndexChanged);
            // 
            // button_tambahKategori
            // 
            this.button_tambahKategori.Location = new System.Drawing.Point(229, 266);
            this.button_tambahKategori.Name = "button_tambahKategori";
            this.button_tambahKategori.Size = new System.Drawing.Size(25, 23);
            this.button_tambahKategori.TabIndex = 17;
            this.button_tambahKategori.Text = "+";
            this.button_tambahKategori.UseVisualStyleBackColor = true;
            this.button_tambahKategori.Click += new System.EventHandler(this.button_tambahKategori_Click);
            // 
            // button_simpanBarang
            // 
            this.button_simpanBarang.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_simpanBarang.Location = new System.Drawing.Point(208, 352);
            this.button_simpanBarang.Name = "button_simpanBarang";
            this.button_simpanBarang.Size = new System.Drawing.Size(110, 38);
            this.button_simpanBarang.TabIndex = 18;
            this.button_simpanBarang.Text = "Simpan";
            this.button_simpanBarang.UseVisualStyleBackColor = true;
            this.button_simpanBarang.Click += new System.EventHandler(this.button_simpanBarang_Click);
            // 
            // label_kode
            // 
            this.label_kode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_kode.AutoSize = true;
            this.label_kode.Location = new System.Drawing.Point(359, 55);
            this.label_kode.Name = "label_kode";
            this.label_kode.Size = new System.Drawing.Size(101, 13);
            this.label_kode.TabIndex = 19;
            this.label_kode.Text = "Kode error message";
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_error.Location = new System.Drawing.Point(29, 407);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(93, 17);
            this.label_error.TabIndex = 20;
            this.label_error.Text = "error mesage";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(29, 377);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kembali";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // StokBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_kode);
            this.Controls.Add(this.button_simpanBarang);
            this.Controls.Add(this.button_tambahKategori);
            this.Controls.Add(this.comboBox_Kategori);
            this.Controls.Add(this.textBox_Stok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Kode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_HargaBarang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_HargaDasar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NamaBarang);
            this.Controls.Add(this.labe1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "StokBarang";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labe1;
        private System.Windows.Forms.TextBox textBox_NamaBarang;
        private System.Windows.Forms.TextBox textBox_HargaDasar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_HargaBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Kode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Kategori;
        private System.Windows.Forms.Button button_tambahKategori;
        private System.Windows.Forms.Button button_simpanBarang;
        private System.Windows.Forms.Label label_kode;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
