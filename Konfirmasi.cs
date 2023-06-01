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
    public partial class Konfirmasi : UserControl
    {
        mainForm objParent;
        DataTable dtKonfirmasi = new DataTable();
        transaksiModel objTransaksiModel = new transaksiModel();
        fitur objFitur = new fitur();
        float HargaTotal;
        
        public Konfirmasi(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
            textBox_Bayar.Text = "0";
        }
        public void isiDatanya(DataTable dt)
        {
            dtKonfirmasi = dt;
            dataGridView1.DataSource = dtKonfirmasi;
        }
        private void button_Konfirmasi_Click(object sender, EventArgs e)
        {
            HargaTotal = 0;
            

            float Bayar = float.Parse(textBox_Bayar.Text.ToString());

            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                HargaTotal += float.Parse(row.Cells[2].Value.ToString());
            }

            if (HargaTotal > Bayar)
            {
                label_error.Text = "Bayar Tidak Cukup";
                objFitur.countdownTimer(label_error);
            }
            else
            {
                if (String.IsNullOrEmpty(textBox_Nama.Text.ToString()))
                {
                    textBox_Nama.Text = "Unknown";
                }
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    objTransaksiModel.simpanTransaksiBarang(textBox_Nama.Text.ToString(), row.Cells[2].Value.ToString(), row.Cells[0].Value.ToString());
                }
                dataGridView1.DataSource = null;
                objParent.ResetTransaksi();
                //objTransaksiModel.simpanTransaksi();
                objParent.showKonfirmasiBerhasilBarang();
                textBox_Nama.Text = "";
                textBox_Bayar.Text = "";
                
            }
            
        }
        public string[] informasiBerhasil()
        {
            string[] info = { textBox_Nama.Text.ToString(), textBox_Bayar.Text.ToString(), Math.Round((float.Parse(textBox_Bayar.Text) - HargaTotal),2).ToString() };
            return info;
        }
        private void linkLabel_Kembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objParent.showMenuTransaksi();
        }


        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox tb = e.Control as TextBox;
                tb.KeyPress -= new KeyPressEventHandler(tb_KeyPress);
                if (this.dataGridView1.CurrentCell.ColumnIndex == 4)
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.RowIndex != dtKonfirmasi.Rows.Count)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (e.ColumnIndex == 5)  // edit
                {

                    if (row.Cells[4].Value == null)
                    {
                        row.Cells[4].Value = "1";

                    }
                    else if (row.Cells[4].Value != null)
                    {
                        int num = int.Parse(row.Cells[4].Value.ToString());
                        num += 1;
                        row.Cells[4].Value = num.ToString();
                    }
                }

                else if (e.ColumnIndex == 6) // hapus
                {
                    if (row.Cells[4].Value != null && int.Parse(row.Cells[4].Value.ToString()) > 0)
                    {
                        int num = int.Parse(row.Cells[4].Value.ToString());
                        num -= 1;
                        row.Cells[4].Value = num.ToString();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            objParent.showMenuTransaksi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
