using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HavaalaniTakipOtomasyonu
{
    public partial class raporAdmin : Form
    {
        public raporAdmin()
        {
            InitializeComponent();
        }

        private void raporAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeHavaalaniDataSet3.giris' table. You can move, or remove it, as needed.
            this.girisTableAdapter.Fill(this.projeHavaalaniDataSet3.giris);
            Form frm1 = new Form1();
            lblKullaniciAdmRapor.Text = Form1.kullaniciAdiAdmin;

            this.reportViewer1.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form frm = new adminMenu();
            frm.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new adminMenu();
            frm.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şu anda Raporlama Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
