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
    public partial class adminIstatistik : Form
    {
        public adminIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void adminIstatistik_Load(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            lblKullaniciAdiAdmIstatistik.Text = Form1.kullaniciAdiAdmin;

            GizliSoruOgretmenOlan();

            GizliSoruHayvan();

            GizliSoruYemek();

            GizliSoruKitap();
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
            MessageBox.Show("Şu anda İstatistikler Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GizliSoruOgretmenOlan()
        {
            string sorgu = "select * from [giris] where [gizlisoru] like 'İlkokul Öğretmeninizin Adı'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = 0;
            while (dr.Read())
            {
                sayac++;
            }
            baglanti.Close();
            lblGizliSogretmen.Text = sayac.ToString();
        }

        public void GizliSoruHayvan()
        {
            string sorgu1 = "select * from [giris] where [gizlisoru] like 'İlk Evcil Hayvanınız'";
            SqlCommand komut1 = new SqlCommand(sorgu1, baglanti);
            baglanti.Open();
            SqlDataReader dr1 = komut1.ExecuteReader();
            int sayac1 = 0;
            while (dr1.Read())
            {
                sayac1++;
            }
            baglanti.Close();
            lblGizliSevcilhayvan.Text = sayac1.ToString();
        }

        public void GizliSoruYemek()
        {
            string sorgu2 = "select * from [giris] where [gizlisoru] like 'En Sevdiğiniz Yemek'";
            SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
            baglanti.Open();
            SqlDataReader dr2 = komut2.ExecuteReader();
            int sayac2 = 0;
            while (dr2.Read())
            {
                sayac2++;
            }
            baglanti.Close();
            lblGizliSyemek.Text = sayac2.ToString();
        }

        public void GizliSoruKitap()
        {
            string sorgu3 = "select * from [giris] where [gizlisoru] like 'En Sevdiğiniz Kitap'";
            SqlCommand komut3 = new SqlCommand(sorgu3, baglanti);
            baglanti.Open();
            SqlDataReader dr3 = komut3.ExecuteReader();
            int sayac3 = 0;
            while (dr3.Read())
            {
                sayac3++;
            }
            baglanti.Close();
            lblGizliSkitap.Text = sayac3.ToString();
        }
    }
}
