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
    public partial class KonfirmasiBerhasil : UserControl
    {
        mainForm objParent;
        public KonfirmasiBerhasil(mainForm pantek_parent)
        {
            InitializeComponent();
            objParent = pantek_parent;
        }
        public void dataKonfirmasiBerhasil(string[] info)
        {
            label_nama.Text = info[0];
            label_Bayar.Text = info[1];
            label_Kembali.Text = info[2];
        }
        private void linkLabel_Kembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objParent.showMenuTransaksi();
        }

        private void label_Kembali_Click(object sender, EventArgs e)
        {

        }

        private void label_nama_Click(object sender, EventArgs e)
        {

        }
    }
}
