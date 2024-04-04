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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            lblKullanici.Text = Form1.kullaniciAdi;
        }

        private void llbKullaniciBilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmKullaniciBilgiDuzenle = new kullaniciBilgiDuzenle();
            frmKullaniciBilgiDuzenle.Show();
            this.Close();
        }

        private void picBoxCikisMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMusteriEkle_Click(object sender, EventArgs e)
        {
            Form frmMusteriEkle = new musteriEkle();
            frmMusteriEkle.Show();
            this.Close();
        }

        private void picBoxBiletSatis_Click(object sender, EventArgs e)
        {
            Form frmBiletSatis = new biletSatis();
            frmBiletSatis.Show();
            this.Close();
        }

        private void picBoxCheckIn_Click(object sender, EventArgs e)
        {
            Form frmCheckIn = new checkIn();
            frmCheckIn.Show();
            this.Close();
        }

        private void picBoxBiletIade_Click(object sender, EventArgs e)
        {
            Form frmBiletIade = new biletIade();
            frmBiletIade.Show();
            this.Close();
        }

        private void picBoxSeferEkle_Click(object sender, EventArgs e)
        {
            Form frmSeferEkle = new seferEkle();
            frmSeferEkle.Show();
            this.Close();
        }

        private void picBoxRezervasyon_Click(object sender, EventArgs e)
        {
            Form frmRezervasyon = new rezervasyon();
            frmRezervasyon.Show();
            this.Close();
        }

        private void picBoxRaporlar_Click(object sender, EventArgs e)
        {
            Form frmRaporlar = new raporlar();
            frmRaporlar.Show();
            this.Close();
        }

        private void picBoxGirisEkraninaDon_Click(object sender, EventArgs e)
        {
            Form frmGiriseDon = new Form1();
            frmGiriseDon.Show();
            this.Close();
        }
    }
}
