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
using System.Text.RegularExpressions;
using Npgsql;

namespace PBO_Kasir
{
    public partial class StokBarang : UserControl
    {
        mainForm objParent;
        SqlDBHelper objSqlDb = new SqlDBHelper();
        barangModel objBarangModel = new barangModel();
        KategoriTambah objKategoriTambah;


        public StokBarang(mainForm pantek_parent)
        {
            InitializeComponent();
            //label_error.Text = "";
            label_kode.Text = "";
            label_error.Text = "";
            objParent = pantek_parent;
            comboBox_Kategori.DisplayMember = "id_kategori";
            comboBox_Kategori.DataSource = objBarangModel.getKategori();

        }
        public bool checkFormatBarang(string kode, string nama, string hargaDasar, string hargaJual, string stok, string kategori)
        {
            bool check;
            if ((kode.Length < 100 && !String.IsNullOrWhiteSpace(kode))
                && (nama.Length < 255 && !String.IsNullOrWhiteSpace(nama)) && (hargaDasar.Length < 100 && !String.IsNullOrWhiteSpace(hargaDasar)) && (hargaJual.Length < 100 && !String.IsNullOrWhiteSpace(hargaJual))
                && (stok.Length < 100 && !String.IsNullOrWhiteSpace(stok)) && (kategori.Length < 255  && !String.IsNullOrWhiteSpace(kategori)))
            {
                check = true;
            }
            else check = false;
            return check;
        }

        private void textBox_Kode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox_Kode.Text.Length > 10)
            {
                e.Handled = true;
            }
        }

        private void textBox_HargaDasar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split(',');
                if (parts.Length > 1)
                {
                    if (parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
        private void textBox_HargaBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            {
                TextBox tb = sender as TextBox;
                int cursorPosLeft = tb.SelectionStart;
                int cursorPosRight = tb.SelectionStart + tb.SelectionLength;
                string result = tb.Text.Substring(0, cursorPosLeft) + e.KeyChar + tb.Text.Substring(cursorPosRight);
                string[] parts = result.Split(',');
                if (parts.Length > 1)
                {
                    if (parts[1].Length > 2 || parts.Length > 2)
                    {
                        e.Handled = true;
                    }
                }
            }
            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
        private void textBox_Stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }


        private void button_simpanBarang_Click(object sender, EventArgs e)
        {
            if (!checkFormatBarang(textBox_Kode.Text, textBox_NamaBarang.Text, textBox_HargaDasar.Text, textBox_HargaBarang.Text, textBox_Stok.Text, comboBox_Kategori.Text.ToString()))
            {
                label_error.Text = "Data tidak lengkap ";
                
            }
            else if (objBarangModel.checkValueAda("kode_barang",  textBox_Kode.Text, "barang"))
            {
                label_kode.Text = "Kode harus unik";
            }

            else
            {
                objBarangModel.tambahBarang(textBox_Kode.Text.ToString(), textBox_NamaBarang.Text.ToString(), textBox_HargaDasar.Text.ToString().Replace(@",", @"."), textBox_HargaBarang.Text.ToString().Replace(@",", @"."), textBox_Stok.Text.ToString(), comboBox_Kategori.Text.ToString());
                label_error.Text = textBox_HargaBarang.Text.ToString();
                textBox_Kode.Text = "";
                textBox_NamaBarang.Text = "";
                textBox_HargaDasar.Text = "";
                textBox_HargaBarang.Text = "";
                textBox_Stok.Text = "";
                comboBox_Kategori.Text = "";
            }

            
        }

        private void textBox_NamaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Kode_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_HargaDasar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_HargaBarang_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_tambahKategori_Click(object sender, EventArgs e)
        {
            objParent.showTambahKategori();
        }

        private void textBox_Stok_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objParent.showMenuBarang();
        }
    }
}
