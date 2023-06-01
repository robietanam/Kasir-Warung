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
    public partial class KategoriTambah : UserControl
    {
        barangModel objBarangModel = new barangModel();
        mainForm objParent;
        public KategoriTambah(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
            isiDataKategori();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void isiDataKategori()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = objBarangModel.getKategori(); ;
        }
        private void button_Tambah_Click(object sender, EventArgs e)
        {
            if (objBarangModel.checkValueAda("id_kategori", textBox_Kategori.Text, "kategori"))
            {
                label_error.Text = "Kategori sudah ada";
            }
            else if (String.IsNullOrWhiteSpace(textBox_Kategori.Text))
            {
                label_error.Text = "Kategori perlu diisi";
            }
            else
            {
                objBarangModel.tambahKategori(textBox_Kategori.Text);
            }
            isiDataKategori();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel_Kembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objParent.showMenuBarang();
        }
    }
}
