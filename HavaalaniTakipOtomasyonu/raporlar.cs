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
    public partial class raporlar : Form
    {
        public raporlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void raporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeHavaalaniDataSet2.seferler' table. You can move, or remove it, as needed.
            this.seferlerTableAdapter.Fill(this.projeHavaalaniDataSet2.seferler);
            // TODO: This line of code loads data into the 'projeHavaalaniDataSet1.biletler' table. You can move, or remove it, as needed.
            this.biletlerTableAdapter.Fill(this.projeHavaalaniDataSet1.biletler);
            // TODO: This line of code loads data into the 'projeHavaalaniDataSet.musteriler' table. You can move, or remove it, as needed.
            this.musterilerTableAdapter.Fill(this.projeHavaalaniDataSet.musteriler);

            Form frm1 = new Form1();
            lblKullaniciAdiRaporlama.Text = Form1.kullaniciAdi;

            ToolTip aciklama = new ToolTip();
            aciklama.SetToolTip(picBoxMenuDonRaporlama, "Menü Ekranına Dön");
            aciklama.IsBalloon = true;
            this.reportViewerMusteri.RefreshReport();
            this.reportViewerBilet.RefreshReport();
            this.reportViewer1.RefreshReport();

            Kadin();

            Erkek();
        }

        private void picBoxCikisRaporlama_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMenuDonRaporlama_Click(object sender, EventArgs e)
        {
            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void llbMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void llbRaporlama_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şu anda Raporlama Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Kadin()
        {
            string sorgu = "select * from [musteriler] where [cinsiyet] like 'Kadın'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            int sayac = 0;
            while (dr.Read())
            {
                sayac++;
            }
            baglanti.Close();
            lblKadinSayisi.Text = sayac.ToString();
        }

        public void Erkek()
        {
            string sorgu2 = "select * from [musteriler] where [cinsiyet] like 'Erkek'";
            SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
            baglanti.Open();
            SqlDataReader dr2 = komut2.ExecuteReader();
            int sayac2 = 0;
            while (dr2.Read())
            {
                sayac2++;
            }
            baglanti.Close();
            lblErkekSayisi.Text = sayac2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new raporMusteriDevamForm();
            frm.Show();
            this.Close();
        }
    }
}
