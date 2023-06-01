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
    public partial class UserProfile : UserControl
    {
        userModel objUserModel = new userModel();
        DataTable dt = new DataTable();
        public UserProfile()
        {
            InitializeComponent();
            tampilDataUser();
        }
        private void tampilDataUser()
        {
            dt = objUserModel.getLogin();
            textBox_nama.Text = dt.Rows[0][1].ToString();
            textBox_password.Text = dt.Rows[0][2].ToString();
        }
        private void updateDataUser()
        {
            objUserModel.updateLogin(textBox_nama.Text, textBox_password.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_nama.Text) || string.IsNullOrEmpty(textBox_password.Text))
            {
                label_status.Text = "Data Tidak Lengkap";
            }
            else
            {
                updateDataUser();
                tampilDataUser();
                label_status.Text = "Data Tersimpan";
            }
        }

        private void label_status_Click(object sender, EventArgs e)
        {

        }
    }
}
