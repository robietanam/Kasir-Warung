namespace PBO_Kasir
{
    partial class Barang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaDasar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaJual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HapusBarang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_TambahBarang = new System.Windows.Forms.Button();
            this.comboBox_Kategori = new System.Windows.Forms.ComboBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Simpan = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Hapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.kode_barang,
            this.NamaBarang,
            this.HargaDasar,
            this.HargaJual,
            this.Stok,
            this.HapusBarang});
            this.dataGridView1.Location = new System.Drawing.Point(29, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(543, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // No
            // 
            this.No.DataPropertyName = "nomor";
            this.No.FillWeight = 38.07106F;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // kode_barang
            // 
            this.kode_barang.DataPropertyName = "kode_barang";
            this.kode_barang.FillWeight = 109.5275F;
            this.kode_barang.HeaderText = "Kode";
            this.kode_barang.Name = "kode_barang";
            this.kode_barang.ReadOnly = true;
            // 
            // NamaBarang
            // 
            this.NamaBarang.DataPropertyName = "nama_barang";
            this.NamaBarang.FillWeight = 164.2913F;
            this.NamaBarang.HeaderText = "Nama Barang";
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.ReadOnly = true;
            // 
            // HargaDasar
            // 
            this.HargaDasar.DataPropertyName = "harga_dasar";
            this.HargaDasar.FillWeight = 109.5275F;
            this.HargaDasar.HeaderText = "Harga Dasar";
            this.HargaDasar.Name = "HargaDasar";
            this.HargaDasar.ReadOnly = true;
            // 
            // HargaJual
            // 
            this.HargaJual.DataPropertyName = "harga_jual";
            this.HargaJual.FillWeight = 109.5275F;
            this.HargaJual.HeaderText = "Harga Jual";
            this.HargaJual.Name = "HargaJual";
            this.HargaJual.ReadOnly = true;
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "stok";
            this.Stok.FillWeight = 109.5275F;
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.ReadOnly = true;
            // 
            // HapusBarang
            // 
            this.HapusBarang.HeaderText = "Hapus";
            this.HapusBarang.Name = "HapusBarang";
            this.HapusBarang.ReadOnly = true;
            this.HapusBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.HapusBarang.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barang";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_TambahBarang
            // 
            this.button_TambahBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TambahBarang.Location = new System.Drawing.Point(477, 21);
            this.button_TambahBarang.Name = "button_TambahBarang";
            this.button_TambahBarang.Size = new System.Drawing.Size(95, 23);
            this.button_TambahBarang.TabIndex = 2;
            this.button_TambahBarang.Text = "Tambah Barang";
            this.button_TambahBarang.UseVisualStyleBackColor = true;
            this.button_TambahBarang.Click += new System.EventHandler(this.button_TambahBarang_Click);
            // 
            // comboBox_Kategori
            // 
            this.comboBox_Kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Kategori.Location = new System.Drawing.Point(73, 26);
            this.comboBox_Kategori.Name = "comboBox_Kategori";
            this.comboBox_Kategori.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Kategori.TabIndex = 3;
            this.comboBox_Kategori.SelectedIndexChanged += new System.EventHandler(this.comboBox_Kategori_SelectedIndexChanged);
            // 
            // button_Edit
            // 
            this.button_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Edit.Location = new System.Drawing.Point(398, 21);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(73, 23);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Simpan
            // 
            this.button_Simpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Simpan.Location = new System.Drawing.Point(319, 21);
            this.button_Simpan.Name = "button_Simpan";
            this.button_Simpan.Size = new System.Drawing.Size(73, 23);
            this.button_Simpan.TabIndex = 5;
            this.button_Simpan.Text = "Simpan";
            this.button_Simpan.UseVisualStyleBackColor = true;
            this.button_Simpan.Click += new System.EventHandler(this.button_Simpan_Click);
            // 
            // label_Status
            // 
            this.label_Status.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(26, 413);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(60, 13);
            this.label_Status.TabIndex = 6;
            this.label_Status.Text = "label status";
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(240, 21);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(73, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_Hapus
            // 
            this.button_Hapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Hapus.Location = new System.Drawing.Point(398, 0);
            this.button_Hapus.Name = "button_Hapus";
            this.button_Hapus.Size = new System.Drawing.Size(73, 23);
            this.button_Hapus.TabIndex = 9;
            this.button_Hapus.Text = "Hapus";
            this.button_Hapus.UseVisualStyleBackColor = true;
            this.button_Hapus.Click += new System.EventHandler(this.button_Hapus_Click);
            // 
            // Barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Hapus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_Simpan);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.comboBox_Kategori);
            this.Controls.Add(this.button_TambahBarang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Barang";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_TambahBarang;
        private System.Windows.Forms.ComboBox comboBox_Kategori;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Simpan;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Hapus;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaDasar;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridViewButtonColumn HapusBarang;
    }
}
