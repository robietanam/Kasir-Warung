namespace PBO_Kasir
{
    partial class Kasbon
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
            this.Kasbonlabel = new System.Windows.Forms.Label();
            this.dataGridView_Bon = new System.Windows.Forms.DataGridView();
            this.Nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenggatBon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BayarBon = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HapusBon = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_TambahBon = new System.Windows.Forms.Button();
            this.button_Hapus = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Simpan = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Bayar = new System.Windows.Forms.TextBox();
            this.button_BayarCancel = new System.Windows.Forms.Button();
            this.button_Bayar = new System.Windows.Forms.Button();
            this.label_Kode = new System.Windows.Forms.Label();
            this.label_Jumlah = new System.Windows.Forms.Label();
            this.label_atasNama = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_namaBon = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bon)).BeginInit();
            this.SuspendLayout();
            // 
            // Kasbonlabel
            // 
            this.Kasbonlabel.AutoSize = true;
            this.Kasbonlabel.Location = new System.Drawing.Point(16, 42);
            this.Kasbonlabel.Name = "Kasbonlabel";
            this.Kasbonlabel.Size = new System.Drawing.Size(43, 13);
            this.Kasbonlabel.TabIndex = 0;
            this.Kasbonlabel.Text = "Kasbon";
            this.Kasbonlabel.Click += new System.EventHandler(this.Kasbonlabel_Click);
            // 
            // dataGridView_Bon
            // 
            this.dataGridView_Bon.AllowUserToAddRows = false;
            this.dataGridView_Bon.AllowUserToResizeColumns = false;
            this.dataGridView_Bon.AllowUserToResizeRows = false;
            this.dataGridView_Bon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Bon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Bon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Bon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomor,
            this.KodeBon,
            this.NamaBon,
            this.Nama,
            this.JumlahBon,
            this.TanggalBon,
            this.TenggatBon,
            this.BayarBon,
            this.HapusBon});
            this.dataGridView_Bon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridView_Bon.Location = new System.Drawing.Point(19, 61);
            this.dataGridView_Bon.Name = "dataGridView_Bon";
            this.dataGridView_Bon.ReadOnly = true;
            this.dataGridView_Bon.RowHeadersVisible = false;
            this.dataGridView_Bon.Size = new System.Drawing.Size(554, 337);
            this.dataGridView_Bon.TabIndex = 1;
            this.dataGridView_Bon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Bon_CellContentClick);
            // 
            // Nomor
            // 
            this.Nomor.DataPropertyName = "nomor";
            this.Nomor.FillWeight = 53.29949F;
            this.Nomor.HeaderText = "No";
            this.Nomor.Name = "Nomor";
            this.Nomor.ReadOnly = true;
            this.Nomor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KodeBon
            // 
            this.KodeBon.DataPropertyName = "kode_kasbon";
            this.KodeBon.HeaderText = "Kode";
            this.KodeBon.Name = "KodeBon";
            this.KodeBon.ReadOnly = true;
            // 
            // NamaBon
            // 
            this.NamaBon.DataPropertyName = "nama_bon";
            this.NamaBon.FillWeight = 107.7834F;
            this.NamaBon.HeaderText = "Bon";
            this.NamaBon.Name = "NamaBon";
            this.NamaBon.ReadOnly = true;
            this.NamaBon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nama
            // 
            this.Nama.DataPropertyName = "atas_nama";
            this.Nama.FillWeight = 107.7834F;
            this.Nama.HeaderText = "Nama";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            this.Nama.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // JumlahBon
            // 
            this.JumlahBon.DataPropertyName = "jumlah_bon";
            this.JumlahBon.FillWeight = 107.7834F;
            this.JumlahBon.HeaderText = "Jumlah";
            this.JumlahBon.Name = "JumlahBon";
            this.JumlahBon.ReadOnly = true;
            // 
            // TanggalBon
            // 
            this.TanggalBon.DataPropertyName = "tanggal_pinjam";
            this.TanggalBon.FillWeight = 107.7834F;
            this.TanggalBon.HeaderText = "Tanggal Bon";
            this.TanggalBon.Name = "TanggalBon";
            this.TanggalBon.ReadOnly = true;
            this.TanggalBon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TenggatBon
            // 
            this.TenggatBon.DataPropertyName = "tenggat_bayar";
            this.TenggatBon.FillWeight = 107.7834F;
            this.TenggatBon.HeaderText = "Tenggat Bon";
            this.TenggatBon.Name = "TenggatBon";
            this.TenggatBon.ReadOnly = true;
            this.TenggatBon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BayarBon
            // 
            this.BayarBon.FillWeight = 107.7834F;
            this.BayarBon.HeaderText = "Bayar";
            this.BayarBon.Name = "BayarBon";
            this.BayarBon.ReadOnly = true;
            this.BayarBon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HapusBon
            // 
            this.HapusBon.HeaderText = "Hapus";
            this.HapusBon.Name = "HapusBon";
            this.HapusBon.ReadOnly = true;
            this.HapusBon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HapusBon.Visible = false;
            // 
            // button_TambahBon
            // 
            this.button_TambahBon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TambahBon.Location = new System.Drawing.Point(475, 32);
            this.button_TambahBon.Name = "button_TambahBon";
            this.button_TambahBon.Size = new System.Drawing.Size(98, 23);
            this.button_TambahBon.TabIndex = 2;
            this.button_TambahBon.Text = "Tambah Bon";
            this.button_TambahBon.UseVisualStyleBackColor = true;
            this.button_TambahBon.Click += new System.EventHandler(this.button_TambahBon_Click);
            // 
            // button_Hapus
            // 
            this.button_Hapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Hapus.Location = new System.Drawing.Point(397, 3);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(70, 23);
            this.button_Hapus.TabIndex = 3;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Edit.Location = new System.Drawing.Point(397, 32);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(72, 23);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Simpan
            // 
            this.button_Simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Simpan.Location = new System.Drawing.Point(319, 32);
            this.button_Simpan.Name = "button_Simpan";
            this.button_Simpan.Size = new System.Drawing.Size(72, 23);
            this.button_Simpan.TabIndex = 5;
            this.button_Simpan.Text = "Simpan";
            this.button_Simpan.UseVisualStyleBackColor = true;
            this.button_Simpan.Visible = false;
            this.button_Simpan.Click += new System.EventHandler(this.button_Simpan_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(241, 32);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(72, 23);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Visible = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kode          : ";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Atas Nama :";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jumlah       :";
            this.label3.Visible = false;
            // 
            // textBox_Bayar
            // 
            this.textBox_Bayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Bayar.Location = new System.Drawing.Point(293, 423);
            this.textBox_Bayar.Name = "textBox_Bayar";
            this.textBox_Bayar.Size = new System.Drawing.Size(124, 20);
            this.textBox_Bayar.TabIndex = 10;
            this.textBox_Bayar.Visible = false;
            this.textBox_Bayar.TextChanged += new System.EventHandler(this.textBox_Bayar_TextChanged);
            // 
            // button_BayarCancel
            // 
            this.button_BayarCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BayarCancel.Location = new System.Drawing.Point(501, 420);
            this.button_BayarCancel.Name = "button_BayarCancel";
            this.button_BayarCancel.Size = new System.Drawing.Size(72, 23);
            this.button_BayarCancel.TabIndex = 11;
            this.button_BayarCancel.Text = "Batal";
            this.button_BayarCancel.UseVisualStyleBackColor = true;
            this.button_BayarCancel.Visible = false;
            this.button_BayarCancel.Click += new System.EventHandler(this.button_BayarCancel_Click);
            // 
            // button_Bayar
            // 
            this.button_Bayar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Bayar.Location = new System.Drawing.Point(423, 420);
            this.button_Bayar.Name = "button_Bayar";
            this.button_Bayar.Size = new System.Drawing.Size(72, 23);
            this.button_Bayar.TabIndex = 11;
            this.button_Bayar.Text = "Bayar";
            this.button_Bayar.UseVisualStyleBackColor = true;
            this.button_Bayar.Visible = false;
            this.button_Bayar.Click += new System.EventHandler(this.button_Bayar_Click);
            // 
            // label_Kode
            // 
            this.label_Kode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Kode.AutoSize = true;
            this.label_Kode.Location = new System.Drawing.Point(87, 404);
            this.label_Kode.Name = "label_Kode";
            this.label_Kode.Size = new System.Drawing.Size(13, 13);
            this.label_Kode.TabIndex = 12;
            this.label_Kode.Text = "- ";
            this.label_Kode.Visible = false;
            // 
            // label_Jumlah
            // 
            this.label_Jumlah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Jumlah.AutoSize = true;
            this.label_Jumlah.Location = new System.Drawing.Point(360, 404);
            this.label_Jumlah.Name = "label_Jumlah";
            this.label_Jumlah.Size = new System.Drawing.Size(13, 13);
            this.label_Jumlah.TabIndex = 13;
            this.label_Jumlah.Text = "- ";
            this.label_Jumlah.Visible = false;
            // 
            // label_atasNama
            // 
            this.label_atasNama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_atasNama.AutoSize = true;
            this.label_atasNama.Location = new System.Drawing.Point(87, 417);
            this.label_atasNama.Name = "label_atasNama";
            this.label_atasNama.Size = new System.Drawing.Size(13, 13);
            this.label_atasNama.TabIndex = 14;
            this.label_atasNama.Text = "- ";
            this.label_atasNama.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nama Bon  :";
            this.label4.Visible = false;
            // 
            // label_namaBon
            // 
            this.label_namaBon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_namaBon.AutoSize = true;
            this.label_namaBon.Location = new System.Drawing.Point(87, 430);
            this.label_namaBon.Name = "label_namaBon";
            this.label_namaBon.Size = new System.Drawing.Size(13, 13);
            this.label_namaBon.TabIndex = 16;
            this.label_namaBon.Text = "- ";
            this.label_namaBon.Visible = false;
            // 
            // label_error
            // 
            this.label_error.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(420, 404);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(10, 13);
            this.label_error.TabIndex = 17;
            this.label_error.Text = "-";
            this.label_error.Click += new System.EventHandler(this.label_error_Click);
            // 
            // Kasbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.label_namaBon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_atasNama);
            this.Controls.Add(this.label_Jumlah);
            this.Controls.Add(this.label_Kode);
            this.Controls.Add(this.button_Bayar);
            this.Controls.Add(this.button_BayarCancel);
            this.Controls.Add(this.textBox_Bayar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Simpan);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Hapus);
            this.Controls.Add(this.button_TambahBon);
            this.Controls.Add(this.dataGridView_Bon);
            this.Controls.Add(this.Kasbonlabel);
            this.Name = "Kasbon";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kasbonlabel;
        private System.Windows.Forms.DataGridView dataGridView_Bon;
        private System.Windows.Forms.Button button_TambahBon;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Simpan;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalBon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenggatBon;
        private System.Windows.Forms.DataGridViewButtonColumn BayarBon;
        private System.Windows.Forms.DataGridViewButtonColumn HapusBon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Bayar;
        private System.Windows.Forms.Button button_BayarCancel;
        private System.Windows.Forms.Button button_Bayar;
        private System.Windows.Forms.Label label_Kode;
        private System.Windows.Forms.Label label_Jumlah;
        private System.Windows.Forms.Label label_atasNama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_namaBon;
        private System.Windows.Forms.Label label_error;
    }
}
