using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HavaalaniTakipOtomasyonu
{
    public partial class raporMusteriDevamForm : Form
    {
        public raporMusteriDevamForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void raporMusteriDevamForm_Load(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            lblKullaniciAdiMusteriDetayRapor.Text = Form1.kullaniciAdi;

            Istanbul();
            Ankara();
            Izmir();
            Bursa();
            Antalya();
            Adana();
        }

        private void picBoxCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxgeriDon_Click(object sender, EventArgs e)
        {
            Form frm = new raporlar();
            frm.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm1 = new menu();
            frm1.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new raporlar();
            frm.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şu anda Müşteri Rapor İstatistikleri Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Istanbul()
        {
            string sorgu = "select * from [musteriler] where [adres] like '%İstanbul%'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = 0;
            while (dr.Read())
            {
                sayac++;
            }
            baglanti.Close();
            lblIstanbul.Text = sayac.ToString();
        }

        public void Ankara()
        {
            string sorgu2 = "select * from [musteriler] where [adres] like '%Ankara%'";
            SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
            baglanti.Open();
            SqlDataReader dr2 = komut2.ExecuteReader();
            int sayac2 = 0;
            while (dr2.Read())
            {
                sayac2++;
            }
            baglanti.Close();
            lblAnkara.Text = sayac2.ToString();
        }

        public void Izmir()
        {
            string sorgu3 = "select * from [musteriler] where [adres] like '%İzmir%'";
            SqlCommand komut3 = new SqlCommand(sorgu3, baglanti);
            baglanti.Open();
            SqlDataReader dr3 = komut3.ExecuteReader();
            int sayac3 = 0;
            while (dr3.Read())
            {
                sayac3++;
            }
            baglanti.Close();
            lblIzmir.Text = sayac3.ToString();
        }

        public void Bursa()
        {
            string sorgu4 = "select * from [musteriler] where [adres] like '%Bursa%'";
            SqlCommand komut4 = new SqlCommand(sorgu4, baglanti);
            baglanti.Open();
            SqlDataReader dr4 = komut4.ExecuteReader();
            int sayac4 = 0;
            while (dr4.Read())
            {
                sayac4++;
            }
            baglanti.Close();
            lblBursa.Text = sayac4.ToString();
        }

        public void Antalya()
        {
            string sorgu5 = "select * from [musteriler] where [adres] like '%Antalya%'";
            SqlCommand komut5 = new SqlCommand(sorgu5, baglanti);
            baglanti.Open();
            SqlDataReader dr5 = komut5.ExecuteReader();
            int sayac5 = 0;
            while (dr5.Read())
            {
                sayac5++;
            }
            baglanti.Close();
            lblAntalya.Text = sayac5.ToString();
        }

        public void Adana()
        {
            string sorgu6 = "select * from [musteriler] where [adres] like '%Adana%'";
            SqlCommand komut6 = new SqlCommand(sorgu6, baglanti);
            baglanti.Open();
            SqlDataReader dr6 = komut6.ExecuteReader();
            int sayac6 = 0;
            while (dr6.Read())
            {
                sayac6++;
            }
            baglanti.Close();
            lblAdana.Text = sayac6.ToString();
        }

    }
}
