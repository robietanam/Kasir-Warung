 namespace PBO_Kasir
{
    partial class playground
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
            this.KurangiBarang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TambahBarang = new System.Windows.Forms.DataGridViewButtonColumn();
            this.JumlahBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_Barang = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).BeginInit();
            this.SuspendLayout();
            // 
            // KurangiBarang
            // 
            this.KurangiBarang.FillWeight = 71.06599F;
            this.KurangiBarang.HeaderText = "Kurangi";
            this.KurangiBarang.Name = "KurangiBarang";
            this.KurangiBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KurangiBarang.Text = "-";
            // 
            // TambahBarang
            // 
            this.TambahBarang.FillWeight = 75.0966F;
            this.TambahBarang.HeaderText = "Tambah";
            this.TambahBarang.Name = "TambahBarang";
            this.TambahBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TambahBarang.Text = "+";
            // 
            // JumlahBarang
            // 
            this.JumlahBarang.FillWeight = 110.7675F;
            this.JumlahBarang.HeaderText = "Jumlah";
            this.JumlahBarang.Name = "JumlahBarang";
            this.JumlahBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Stok
            // 
            this.Stok.DataPropertyName = "stok";
            this.Stok.FillWeight = 110.7675F;
            this.Stok.HeaderText = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.ReadOnly = true;
            this.Stok.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // HargaBarang
            // 
            this.HargaBarang.DataPropertyName = "harga_jual";
            this.HargaBarang.FillWeight = 110.7675F;
            this.HargaBarang.HeaderText = "Harga";
            this.HargaBarang.Name = "HargaBarang";
            this.HargaBarang.ReadOnly = true;
            this.HargaBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NamaBarang
            // 
            this.NamaBarang.DataPropertyName = "nama_barang";
            this.NamaBarang.FillWeight = 110.7675F;
            this.NamaBarang.HeaderText = "Nama Barang";
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.ReadOnly = true;
            this.NamaBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // KodeBarang
            // 
            this.KodeBarang.DataPropertyName = "kode_barang";
            this.KodeBarang.FillWeight = 110.7675F;
            this.KodeBarang.HeaderText = "Kode Barang";
            this.KodeBarang.Name = "KodeBarang";
            this.KodeBarang.ReadOnly = true;
            this.KodeBarang.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridView_Barang
            // 
            this.dataGridView_Barang.AllowUserToAddRows = false;
            this.dataGridView_Barang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Barang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Barang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodeBarang,
            this.NamaBarang,
            this.HargaBarang,
            this.Stok,
            this.JumlahBarang,
            this.TambahBarang,
            this.KurangiBarang});
            this.dataGridView_Barang.Location = new System.Drawing.Point(25, 83);
            this.dataGridView_Barang.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.dataGridView_Barang.Name = "dataGridView_Barang";
            this.dataGridView_Barang.RowHeadersVisible = false;
            this.dataGridView_Barang.Size = new System.Drawing.Size(543, 242);
            this.dataGridView_Barang.TabIndex = 5;
            this.dataGridView_Barang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Barang_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // playground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_Barang);
            this.Name = "playground";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Barang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewButtonColumn KurangiBarang;
        private System.Windows.Forms.DataGridViewButtonColumn TambahBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodeBarang;
        private System.Windows.Forms.DataGridView dataGridView_Barang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}
