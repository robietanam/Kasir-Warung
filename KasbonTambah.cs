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
    public partial class KasbonTambah : UserControl
    {
        mainForm objParent;
        kasbonModel objKasbonModel = new kasbonModel();

        public KasbonTambah(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
        }

        private void button_TambahBon_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_AtasNama.Text) || string.IsNullOrEmpty(textBox_NamaBon.Text) || string.IsNullOrEmpty(textBox_Jumlah.Text) || string.IsNullOrEmpty(textBox_Kode.Text))
            {
                label_error.Text = "Data belum lengkap";
            }
            else
            {
                objKasbonModel.tambahBon(textBox_Kode.Text,textBox_NamaBon.Text, textBox_AtasNama.Text,textBox_Jumlah.Text.ToString().Replace(@",", @"."), dateTimePicker_TanggalHutang.Value.ToString("yyyy-MM-dd"), dateTimePicker_TenggatHutang.Value.ToString("yyyy-MM-dd"));
                objParent.showMenuKasbon();
            }

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker_TanggalHutang.Value.ToString("yyyy-MM-dd");
        }


        private void dateTimePicker_TenggatHutang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Jumlah_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
