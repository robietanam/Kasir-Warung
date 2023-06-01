using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Kasir
{
    public partial class playground : UserControl
    {
        mainForm objParent;
        List<DataGridView> dgv = new List<DataGridView>();
        int i = 0;
        public playground(mainForm p_parent)
        {
            InitializeComponent();
            objParent = p_parent;
        }
        public void membuatGrid()
        {
            DataGridView dataGridView1;
            DataGridViewTextBoxColumn Kolom1;
            DataGridViewTextBoxColumn Kolom2;
            DataGridViewTextBoxColumn Kolom3;
            DataGridViewTextBoxColumn Kolom4;
            DataGridViewTextBoxColumn Kolom5;
            DataGridViewButtonColumn Kolom6;
            DataGridViewButtonColumn Kolom7;
            dataGridView1 = new DataGridView();
            Kolom1 = new DataGridViewTextBoxColumn();
            Kolom2 = new DataGridViewTextBoxColumn();
            Kolom3 = new DataGridViewTextBoxColumn();
            Kolom4 = new DataGridViewTextBoxColumn();
            Kolom5 = new DataGridViewTextBoxColumn();
            Kolom6 = new DataGridViewButtonColumn();
            Kolom7 = new DataGridViewButtonColumn();
            dataGridView1 = new DataGridView();
            // 
            // dataGridView1
            // 

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] {
            Kolom1,
            Kolom2,
            Kolom3,
            Kolom4,
            Kolom5,
            Kolom6,
            Kolom7
            });
            dataGridView1.Location = new System.Drawing.Point(29, 104);
            dataGridView1.MaximumSize = new System.Drawing.Size(2000, 2000);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new System.Drawing.Size(543, 242);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView_Barang_CellContentClick);
            // 
            // Kolom1
            // 
            Kolom1.DataPropertyName = "kode_barang";
            Kolom1.FillWeight = 110.7675F;
            Kolom1.HeaderText = "Kode Barang";
            Kolom1.Name = "Kolom1";
            Kolom1.ReadOnly = true;
            Kolom1.Resizable = DataGridViewTriState.False;
            // 
            // Kolom2
            // 
            Kolom2.DataPropertyName = "nama_barang";
            Kolom2.FillWeight = 110.7675F;
            Kolom2.HeaderText = "Nama Barang";
            Kolom2.Name = "Kolom2";
            Kolom2.ReadOnly = true;
            Kolom2.Resizable = DataGridViewTriState.False;
            // 
            // Kolom3
            // 
            Kolom3.DataPropertyName = "harga_jual";
            Kolom3.FillWeight = 110.7675F;
            Kolom3.HeaderText = "Harga";
            Kolom3.Name = "Kolom3";
            Kolom3.ReadOnly = true;
            Kolom3.Resizable = DataGridViewTriState.False;
            // 
            // Kolom4
            // 
            Kolom4.DataPropertyName = "stok";
            Kolom4.FillWeight = 110.7675F;
            Kolom4.HeaderText = "Kolom4";
            Kolom4.Name = "Kolom4";
            Kolom4.ReadOnly = true;
            Kolom4.Resizable = DataGridViewTriState.False;
            // 
            // Kolom5
            // 
            Kolom5.FillWeight = 110.7675F;
            Kolom5.HeaderText = "Jumlah";
            Kolom5.Name = "Kolom5";
            Kolom5.Resizable = DataGridViewTriState.False;
            // 
            // Kolom6
            // 
            Kolom6.FillWeight = 75.0966F;
            Kolom6.HeaderText = "Tambah";
            Kolom6.Name = "Kolom6";
            Kolom6.Resizable = DataGridViewTriState.False;
            Kolom6.Text = "+";
            // 
            // Kolom7
            // 
            Kolom7.FillWeight = 71.06599F;
            Kolom7.HeaderText = "Kurangi";
            Kolom7.Name = "Kolom7";
            Kolom7.Resizable = DataGridViewTriState.False;
            Kolom7.Text = "-";
        }

        public void membuatGridView()
        {
            var rand = new Random();
            DataGridView genGridView = new DataGridView();
            DataGridViewTextBoxColumn KodeBarang = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn NamaBarang = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn HargaBarang = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn Stok = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn JumlahBarang = new DataGridViewTextBoxColumn();
            DataGridViewButtonColumn TambahBarang = new DataGridViewButtonColumn();
            DataGridViewButtonColumn KurangiBarang = new DataGridViewButtonColumn();
            DataTable dt = new DataTable();
            KodeBarang.DataPropertyName = "kode_barang";
            KodeBarang.HeaderText = "Kode Barang";
            KodeBarang.Name = "KodeBarang";
            KodeBarang.ReadOnly = true;
            KodeBarang.Resizable = DataGridViewTriState.False;

            NamaBarang.DataPropertyName = "nama_barang";
            NamaBarang.HeaderText = "Nama Barang";
            NamaBarang.Name = "NamaBarang";
            NamaBarang.ReadOnly = true;
            NamaBarang.Resizable = DataGridViewTriState.False;
            // 
            // HargaBarang
            // 
            HargaBarang.DataPropertyName = "harga_jual";
            HargaBarang.HeaderText = "Harga";
            HargaBarang.Name = "HargaBarang";
            HargaBarang.ReadOnly = true;
            HargaBarang.Resizable = DataGridViewTriState.False;
            // 
            // Stok
            // 
            Stok.DataPropertyName = "stok";
            Stok.HeaderText = "Stok";
            Stok.Name = "Stok";
            Stok.ReadOnly = true;
            Stok.Resizable = DataGridViewTriState.False;
            // 
            // JumlahBarang
            // 
            JumlahBarang.HeaderText = "Jumlah";
            JumlahBarang.Name = "JumlahBarang";
            JumlahBarang.Resizable = DataGridViewTriState.False;
            // 
            // TambahBarang
            // 
            TambahBarang.HeaderText = "Tambah";
            TambahBarang.Name = "TambahBarang";
            TambahBarang.Resizable = DataGridViewTriState.False;
            TambahBarang.Text = "+";
            TambahBarang.UseColumnTextForButtonValue = true;
            // 
            // KurangiBarang
            // 
            KurangiBarang.HeaderText = "Kurangi";
            KurangiBarang.Name = "KurangiBarang";
            KurangiBarang.Resizable = DataGridViewTriState.False;
            KurangiBarang.Text = "-";
            KurangiBarang.UseColumnTextForButtonValue = true;

            genGridView.Name = "dataGridView_Barang";
            genGridView.RowHeadersVisible = false;
            genGridView.TabIndex = 4;
            genGridView.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView_Barang_CellContentClick);
            //genGridView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dataGridView_Barang_EditingControlShowing);
            genGridView.AllowUserToAddRows = false;
            genGridView.TabIndex = 4;
            genGridView.Location = new Point(30, 52);
            genGridView.MaximumSize = new Size(2000, 2000);
            genGridView.Size = new Size(543, 242);
            genGridView.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
           | AnchorStyles.Left)
           | AnchorStyles.Right)));
            genGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            genGridView.DataSource = dt;
            dgv.Add(genGridView);

            genGridView.Columns.Add(KodeBarang);
            genGridView.Columns.Add(NamaBarang);
            genGridView.Columns.Add(HargaBarang);
            genGridView.Columns.Add(Stok);
            genGridView.Columns.Add(JumlahBarang);
            genGridView.Columns.Add(TambahBarang);
            genGridView.Columns.Add(KurangiBarang);

            this.Controls.Add(genGridView);

            //label1.Text = "sukses";
        }
        public void tampilGridView()
        {
            dataGridView_Barang.Visible = false;
            foreach (DataGridView dg in dgv )
            {
                if (dg == dgv[i])
                {
                    label1.Text = dg.Width.ToString();
                    label2.Text = dgv[i].Width.ToString();
                    dg.Visible = true;
                }
                else
                {
                    dg.Visible = false;
                }
            }
            i += 1;

        }
        void dataGridView_Barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            membuatGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tampilGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
