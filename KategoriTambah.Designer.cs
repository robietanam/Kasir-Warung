namespace PBO_Kasir
{
    partial class KategoriTambah
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
            this.textBox_Kategori = new System.Windows.Forms.TextBox();
            this.button_Tambah = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_error = new System.Windows.Forms.Label();
            this.linkLabel_Kembali = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Kategori : ";
            // 
            // textBox_Kategori
            // 
            this.textBox_Kategori.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_Kategori.Location = new System.Drawing.Point(111, 38);
            this.textBox_Kategori.Name = "textBox_Kategori";
            this.textBox_Kategori.Size = new System.Drawing.Size(207, 20);
            this.textBox_Kategori.TabIndex = 1;
            this.textBox_Kategori.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Tambah
            // 
            this.button_Tambah.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Tambah.Location = new System.Drawing.Point(335, 38);
            this.button_Tambah.Name = "button_Tambah";
            this.button_Tambah.Size = new System.Drawing.Size(75, 23);
            this.button_Tambah.TabIndex = 2;
            this.button_Tambah.Text = "Tambah";
            this.button_Tambah.UseVisualStyleBackColor = true;
            this.button_Tambah.Click += new System.EventHandler(this.button_Tambah_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomor,
            this.Kategori});
            this.dataGridView1.Location = new System.Drawing.Point(22, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(554, 238);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nomor
            // 
            this.Nomor.FillWeight = 50.76142F;
            this.Nomor.HeaderText = "Nomor";
            this.Nomor.Name = "Nomor";
            this.Nomor.ReadOnly = true;
            this.Nomor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Kategori
            // 
            this.Kategori.DataPropertyName = "id_kategori";
            this.Kategori.FillWeight = 149.2386F;
            this.Kategori.HeaderText = "Nama Kategori";
            this.Kategori.Name = "Kategori";
            this.Kategori.ReadOnly = true;
            this.Kategori.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(108, 22);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 4;
            // 
            // linkLabel_Kembali
            // 
            this.linkLabel_Kembali.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel_Kembali.AutoSize = true;
            this.linkLabel_Kembali.Location = new System.Drawing.Point(416, 45);
            this.linkLabel_Kembali.Name = "linkLabel_Kembali";
            this.linkLabel_Kembali.Size = new System.Drawing.Size(44, 13);
            this.linkLabel_Kembali.TabIndex = 5;
            this.linkLabel_Kembali.TabStop = true;
            this.linkLabel_Kembali.Text = "Kembali";
            this.linkLabel_Kembali.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Kembali_LinkClicked);
            // 
            // KategoriTambah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel_Kembali);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Tambah);
            this.Controls.Add(this.textBox_Kategori);
            this.Controls.Add(this.label1);
            this.Name = "KategoriTambah";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Kategori;
        private System.Windows.Forms.Button button_Tambah;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategori;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.LinkLabel linkLabel_Kembali;
    }
}
