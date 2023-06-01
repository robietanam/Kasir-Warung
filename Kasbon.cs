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
    public partial class Kasbon : UserControl
    {
        mainForm objParent;
        kasbonModel objKasbonModel = new kasbonModel();
        transaksiModel objTransaksiModel = new transaksiModel();
        fitur objFitur = new fitur();
        List<string> indexBonS = new List<string>();
        string kodeBayar;
        string hargaBayar;
        string atasNama;
        public Kasbon(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
            
        }
        public void isiDataKasbon()
        {
            dataGridView_Bon.AutoGenerateColumns = false;
            dataGridView_Bon.DataSource = objKasbonModel.ambilKasbon();
        }
        public string[] informasiBerhasil()
        {
            string[] info = { atasNama, hargaBayar, Math.Round(float.Parse(textBox_Bayar.Text) - float.Parse(hargaBayar), 2).ToString() };
            return info;
        }
        private void dataGridView_Bon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow row = dataGridView_Bon.Rows[e.RowIndex];
                if (e.ColumnIndex == 7)  // bayar
                {
                    if (row.Cells[0].Value != null)
                    {
                        showKasbonBayarMenu();
                        label_Kode.Text = row.Cells[1].Value.ToString();
                        label_namaBon.Text = row.Cells[2].Value.ToString();
                        label_atasNama.Text = row.Cells[3].Value.ToString();
                        label_Jumlah.Text = row.Cells[4].Value.ToString();
                        kodeBayar = row.Cells[1].Value.ToString();
                        hargaBayar = row.Cells[4].Value.ToString();
                        atasNama = row.Cells[3].Value.ToString();
                    }
                }
                else if (e.ColumnIndex == 8)  // hapus
                {
                    if (row.Cells[0].Value != null)
                    {
                        indexBonS.Add(row.Cells[1].Value.ToString());
                        dataGridView_Bon.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }

        private void bayarKasbon()
        {
            foreach (DataGridViewRow row in dataGridView_Bon.Rows)
            {
                if (kodeBayar == row.Cells[1].Value.ToString())
                {
                    objTransaksiModel.simpanTransaksiKasbon(row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[1].Value.ToString());
                    objKasbonModel.hapusData(row.Cells[1].Value.ToString());
                }
            }
        }
        public void simpanDataBaru()
        {
            foreach (DataGridViewRow row in dataGridView_Bon.Rows)
            {
                //row.Cells[1].Value;
                Kasbonlabel.Text = row.Cells[5].Value.ToString().Replace(@"/", @"-").Split(' ')[0];
                objKasbonModel.updateKason(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString(), float.Parse(row.Cells[4].Value.ToString()), row.Cells[5].Value.ToString().Replace(@"/", @"-").Split(' ')[0], row.Cells[6].Value.ToString().Replace(@"/", @"-").Split(' ')[0]);
            
            }
            if (indexBonS.Count > 0)
            {
                foreach (string index in indexBonS)
                {
                    objKasbonModel.hapusData(index);
                }
            }
        }
        private void button_TambahBon_Click(object sender, EventArgs e)
        {
            objParent.showKasbonTambah();
            
        }

        private void button_Hapus_Click(object sender, EventArgs e)
        {
            HapusBon.Visible = true;
            button_Edit.Visible = false;
            button_Simpan.Visible = true;
            button_Cancel.Visible = true;
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            objFitur.countdownTimer(label_error);
            button_Hapus.Visible = false;
            button_Simpan.Visible = true;
            button_Cancel.Visible = true;
            dataGridView_Bon.ReadOnly = false;
        }
        private void resetBayar()
        {
            label_Kode.Text = "-";
            label_namaBon.Text = "-";
            label_atasNama.Text = "-";
            label_Jumlah.Text = "-";
            kodeBayar = "-";
            hargaBayar = "-";
            atasNama = "-";
            textBox_Bayar.Text = "0";
            HapusBon.Visible = false;
            button_Simpan.Visible = false;
            button_Cancel.Visible = false;
            button_Edit.Visible = true;
            button_Hapus.Visible = true;
            dataGridView_Bon.ReadOnly = true;

        }
        private void button_Simpan_Click(object sender, EventArgs e)
        {
            resetBayar();
            simpanDataBaru();
            indexBonS.Clear();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            resetBayar();
            isiDataKasbon();
            indexBonS.Clear();
        }

        private void Kasbonlabel_Click(object sender, EventArgs e)
        {

        }
        private void showKasbonBayarMenu()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label_namaBon.Visible = true;
            label_atasNama.Visible = true;
            label_Jumlah.Visible = true;
            label_Kode.Visible = true;
            button_Bayar.Visible = true;
            button_BayarCancel.Visible = true;
            textBox_Bayar.Visible = true;
        }
        private void hideBayarKasbonMenu()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label_namaBon.Visible = false;
            label_atasNama.Visible = false;
            label_Jumlah.Visible = false;
            label_Kode.Visible = false;
            button_Bayar.Visible = false;
            button_BayarCancel.Visible = false;
            textBox_Bayar.Visible = false;
        }
        private void button_BayarCancel_Click(object sender, EventArgs e)
        {
            resetBayar();
            hideBayarKasbonMenu();
            
        }

        private void button_Bayar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Math.Round(float.Parse(textBox_Bayar.Text.ToString()), 2) > Math.Round(float.Parse(hargaBayar), 2))
                {
                    bayarKasbon();
                    objParent.showKonfirmasiBerhasilKasbon();
                    resetBayar();
                }
                else
                {
                    label_error.Text = "Uang tidak Cukup";
                }
            }
            catch
            {
                label_error.Text = "Uang tidak Cukup";
            }
            
            
        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Bayar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
