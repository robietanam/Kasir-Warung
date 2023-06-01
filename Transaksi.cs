using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_Kasir.models;

namespace PBO_Kasir
{
    public partial class Transaksi : UserControl
    {
        barangModel objBarangModel = new barangModel();
        DataTable dtBarang = new DataTable();
        mainForm objParent;
        Dictionary<string,DataGridView> dgv = new Dictionary<string,DataGridView>();
        Dictionary<string, DataTable> dts = new Dictionary<string, DataTable>();
        string saveData;
       
        public Transaksi(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
            comboBox_Kategori.DisplayMember = "id_kategori";
            comboBox_Kategori.DataSource = objBarangModel.getKategori();
            /*objKonfirmasi = new Konfirmasi(this);
            objKonfirmasi.Location = new Point(200, 0);
            objKonfirmasi.Anchor = ((AnchorStyles.Left | AnchorStyles.Right) | (AnchorStyles.Bottom | AnchorStyles.Top));
            this.Controls.Add(objKonfirmasi);*/

            saveData = comboBox_Kategori.Text;
            for (int i = 0; i < comboBox_Kategori.Items.Count; i++)
            {
                string nama = comboBox_Kategori.GetItemText(comboBox_Kategori.Items[i]);
                //dts.Add(nama, objBarangModel.getDataBarang(nama));
                membuatGridView(nama);

            }
            dgv[comboBox_Kategori.Text].Visible = true;

        }
        public void membuatGridView(string kategori)
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

            genGridView.AllowUserToAddRows = false;
            genGridView.Name = "dataGridView_Barang";
            genGridView.RowHeadersVisible = false;
            genGridView.TabIndex = 4;
            genGridView.Location = new Point(30, 52);
            genGridView.MaximumSize = new Size(2000, 2000);
            genGridView.Size = new Size(558, 382);
            genGridView.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
           | AnchorStyles.Left)
           | AnchorStyles.Right)));
            genGridView.Visible = false;
            genGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            genGridView.DataSource = objBarangModel.getDataBarangTransaksi(ref kategori);
            dgv.Add(kategori,genGridView);
            genGridView.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView_Barang_CellContentClick);
            genGridView.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dataGridView_Barang_EditingControlShowing);
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
        public void tampilGridView(string kategori)
        {
            dataGridView_Barang.Visible = false;
            foreach (DataGridView dg in dgv.Values)
            {
                if (dg == dgv[kategori])
                {
                    dg.Visible = true;
                }
                else
                {
                    dg.Visible = false;
                }
            }
        }
        public void isiDataTransaksi()
        {
            /*dtBarang = objBarangModel.getDataBarangTransaksi(comboBox_Kategori.Text);*/
            dataGridView_Barang.AutoGenerateColumns = false;
            dataGridView_Barang.DataSource = dtBarang;
        }
        private void isiKonfirmasi()
        {
            /*            objKonfirmasi.isiDatanya(isiDataKonfirmasi());
                        this.Visible = false;
                        objKonfirmasi.Visible = true;*/
            //dataGridView1.DataSource = isiDataKonfirmasi();
            
        }
        /*        private void saveDataTransaksi(string name)
                {
                   dts.Add(name,isiDataKonfirmasi());
                }*/
        public void resetDataGrid()
        {
            foreach (DataGridView dg in dgv.Values)
            {
                foreach (DataGridViewRow row in dg.Rows)
                {
                    row.Cells[0].Value = "";
                }
            }
        }
        public DataTable isiDataKonfirmasi()
        {
            //Creating DataTable.
            DataTable dt = new DataTable();
            dt.Columns.Add("Kode Barang",typeof(string));
            dt.Columns.Add("Nama Barang", typeof(string));
            dt.Columns.Add("Harga", typeof(string));
            dt.Columns.Add("Stok", typeof(int));
            dt.Columns.Add("Jumlah", typeof(int));
            //Adding the Columns.
            foreach (DataGridView dg in dgv.Values)
            {

                /*foreach (DataGridViewColumn column in dg.Columns)
                {
                    if (column.Index == 0)
                    {
                        label1.Text = column.HeaderText.ToString();
                        column.ValueType = typeof(int);
                    }
                    else if (column.Index < 3)
                    {
                        continue;
                    }
                    try
                    {
                        dt.Columns.Add(column.HeaderText, column.ValueType);
                    }
                    catch (DuplicateNameException e)
                    {
                        break;
                    }
                }*/
                //string nama = comboBox_Kategori.GetItemText(comboBox_Kategori.Items[i]);
                //Adding the Rows.
                foreach (DataGridViewRow row in dg.Rows)
                {

                    /*if (dt.Rows.Contains(row.Cells[0]))
                    {
                        row.Cells[4].Value = row.Cells[4].Value.ToString();
                    }*/
                    try
                    {
                        if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) > 0)
                        {
                            label1.Text = row.Cells[0].Value.ToString();
                            dt.Rows.Add(row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[6].Value, row.Cells[0].Value);
                        }
                    }
                    catch
                    {
                        //
                    }

                }
            }
            return dt;
        }

        private void dataGridView_Barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn )
            {
                
                DataGridViewRow row = dgv[comboBox_Kategori.Text].Rows[e.RowIndex];
                if (e.ColumnIndex == 1)  // edit
                {
                    if (row.Cells[0].Value == null || row.Cells[0].Value == "")
                    {  
                        row.Cells[0].Value = "1";
                        int stok = int.Parse(row.Cells[6].Value.ToString());
                        stok -= 1;
                        row.Cells[6].Value = stok.ToString();

                    }
                    else if (row.Cells[0].Value != null)
                    {
                        int num = int.Parse(row.Cells[0].Value.ToString());
                        num += 1;
                        row.Cells[0].Value = num.ToString();
                        int stok = int.Parse(row.Cells[6].Value.ToString());
                        stok -= 1;
                        row.Cells[6].Value = stok.ToString();
                    }
                }

                else if (e.ColumnIndex == 2) // hapus
                {
                    if (row.Cells[0].Value != null && int.Parse(row.Cells[0].Value.ToString()) > 0)
                    {
                        int num = int.Parse(row.Cells[0].Value.ToString());
                        num -= 1;
                        row.Cells[0].Value = num.ToString();
                        int stok = int.Parse(row.Cells[6].Value.ToString());
                        stok += 1;
                        row.Cells[6].Value = stok.ToString();
                    }
                }
            }
        }
        private void dataGridView_Barang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox tb = e.Control as TextBox;
                tb.KeyPress -= new KeyPressEventHandler(tb_KeyPress);
                if (this.dgv[comboBox_Kategori.Text].CurrentCell.ColumnIndex == 4)
                {
                    tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
                }
            }
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != '\b') //allow the backspace key
                {
                    e.Handled = true;
                }
            }
        }
        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        // Load semua kategori terlebih dahulu, di dataTabel yang berbeda
       
        private void button_Selanjutnya_Click(object sender, EventArgs e)
        {
            objParent.showKonfirmasi();
            /*objKonfirmasi.Visible = true;
            saveDataTransaksi(comboBox_Kategori.Text);*/
            //objParent.showKonfirmasiBerhasil();

        }

        private void comboBox_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            tampilGridView(comboBox_Kategori.Text);
            label2.Text = comboBox_Kategori.Text;
            /*label2.Text = comboBox_Kategori.Text;
            saveData = comboBox_Kategori.Text;*/
            //saveDataTransaksi(comboBox_Kategori.Text);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = isiDataKonfirmasi();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            isiKonfirmasi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
