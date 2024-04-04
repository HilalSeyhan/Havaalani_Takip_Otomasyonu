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
    public partial class rezervasyon : Form
    {
        public rezervasyon()
        {
            InitializeComponent();
        }

        int seferID, MusteriID, kID;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void rezervasyon_Load(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            lblKullaniciAdiRezervasyon.Text = Form1.kullaniciAdi;
            kID = Form1.kullaniciID;
            dtpGidisTarihi.MinDate = DateTime.Now.AddDays(2);

            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from havaalani", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                cmbBoxKalkisHavaalani.Items.Add(read["havaalaniAdi"]);
                cmbBoxInısHavaalani.Items.Add(read["havaalaniAdi"]);
            }
            cmbBoxKalkisHavaalani.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxInısHavaalani.DropDownStyle = ComboBoxStyle.DropDownList;
            baglanti.Close();

            cmbBoxCinsiyet.Items.Add("Kadın");
            cmbBoxCinsiyet.Items.Add("Erkek");
            cmbBoxCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBoxSaatVeTarih.DropDownStyle = ComboBoxStyle.DropDownList;

            ToolTip aciklama = new ToolTip();
            aciklama.SetToolTip(picBoxMenuDonRezervasyon, "Menü Ekranına Dön");
            aciklama.IsBalloon = true;

            grpBoxMusteriBilgi.Enabled = false;
        }
        
        private void picBoxCikisRezervasyon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void llbMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void picBoxMenuDonRezervasyon_Click(object sender, EventArgs e)
        {
            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void llbRezervasyon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şu anda Rezervasyon Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dtpGidisTarihi_ValueChanged(object sender, EventArgs e)
        {
            cmbBoxSaatVeTarih.Items.Clear();
            btnListele.Enabled = true;
            btnDevamEt.Enabled = false;
        }

        private void cmbBoxKalkisHavaalani_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxSaatVeTarih.Items.Clear();
            btnListele.Enabled = true;
            btnDevamEt.Enabled = false;
        }

        private void cmbBoxInısHavaalani_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxSaatVeTarih.Items.Clear();
            btnListele.Enabled = true;
            btnDevamEt.Enabled = false;
        }

        private void cmbBoxSaatVeTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxSaatVeTarih.Text != "")
            {
                btnDevamEt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen bir saat seçiniz..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DateTime tarih = dtpGidisTarihi.Value;
            DateTime ara1;
            string zaman = tarih.ToShortDateString();
            string saat = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":00";
            ara1 = Convert.ToDateTime(zaman);
            SqlCommand sorgu = new SqlCommand("select * from seferler where kalkisyeri=@kalkis and inisyeri=@inis and gidistarihi=@zamann and koltuksayisi!=0", baglanti);
            sorgu.Parameters.Add("@kalkis", cmbBoxKalkisHavaalani.Text);
            sorgu.Parameters.Add("@inis", cmbBoxInısHavaalani.Text);
            sorgu.Parameters.Add("@zamann", ara1);
            SqlDataReader dr = sorgu.ExecuteReader();
            int sayac = 0;
            int koltuk;
            while (dr.Read())
            {
                // koltuk sayisi kontrolü
                sayac++;
                cmbBoxSaatVeTarih.Items.Add(dr["gidissaat"] + " Saatli ve " + dr["ucret"].ToString() + " TL ücretli ");
                btnListele.Enabled = false;
                MessageBox.Show("Kriterlerinize Uygun Uçuşlar Listelendi.. Lütfen Saat ve Ücret Seçiminizi Yapınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (sayac == 0)
            {
                MessageBox.Show("Bu kriterlere uygun uçuş bulunmamaktadır..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dr.Close();
            baglanti.Close();
        }

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DateTime tarih = dtpGidisTarihi.Value;
            string zaman = tarih.ToShortDateString();
            tarih = Convert.ToDateTime(zaman);
            string saat = cmbBoxSaatVeTarih.Text.Substring(0, 8);
            SqlCommand sorgu = new SqlCommand("select seferID from seferler where kalkisyeri=@kalkiss and inisyeri=@iniss and gidistarihi=@tarihh and gidissaat=@saaat", baglanti);
            sorgu.Parameters.Add("@kalkiss", cmbBoxKalkisHavaalani.Text);
            sorgu.Parameters.Add("@iniss", cmbBoxInısHavaalani.Text);
            sorgu.Parameters.Add("@tarihh", tarih);
            sorgu.Parameters.Add("@saaat", saat);
            SqlDataReader sorgula = sorgu.ExecuteReader();
            if (sorgula.Read())
            {
                seferID = Convert.ToInt32(sorgula["seferID"].ToString());
                grpBoxUcusBilgi.Enabled = false;
                grpBoxMusteriBilgi.Enabled = true;
                txtBoxTcNo.Enabled = false;
                txtBoxAdSoyad.Enabled = false;
                txtBoxCepTelNo.Enabled = false;
                txtBoxEvTelNo.Enabled = false;
                cmbBoxCinsiyet.Enabled = false;
                txtBoxEmail.Enabled = false;
                txtBoxAdres.Enabled = false;
                btnRezerveYap.Enabled = false;
            }
            baglanti.Close();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            if (txtBoxMusteriNo.Text != "")
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from musteriler where MID=" + txtBoxMusteriNo.Text + " ", baglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    MusteriID = Convert.ToInt32(dr2[7]);
                    txtBoxTcNo.Text = dr2[0].ToString();
                    txtBoxAdSoyad.Text = dr2[1].ToString();
                    txtBoxCepTelNo.Text = dr2[2].ToString();
                    txtBoxEvTelNo.Text = dr2[3].ToString();
                    cmbBoxCinsiyet.Text = dr2[4].ToString();
                    txtBoxEmail.Text = dr2[5].ToString();
                    txtBoxAdres.Text = dr2[6].ToString();
                    btnRezerveYap.Enabled = true;
                }
                else
                {
                    txtBoxTcNo.Text = "";
                    txtBoxAdSoyad.Text = "";
                    txtBoxCepTelNo.Text = "";
                    txtBoxEvTelNo.Text = "";
                    cmbBoxCinsiyet.Text = "";
                    txtBoxEmail.Text = "";
                    txtBoxAdres.Text = "";
                    MessageBox.Show("Bu ID'ye ait müşteri bilgisi bulunamadı.!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnRezerveYap.Enabled = false;
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Müşteri Numarası Girişi Yapınız.!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxTcNo.Text = "";
                txtBoxAdSoyad.Text = "";
                txtBoxCepTelNo.Text = "";
                txtBoxEvTelNo.Text = "";
                cmbBoxCinsiyet.Text = "";
                txtBoxEmail.Text = "";
                txtBoxAdres.Text = "";
                btnRezerveYap.Enabled = false;
            }
        }

        private void btnRezerveYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DateTime satis = DateTime.Now;
            SqlCommand sorgu = new SqlCommand("insert into biletler (seferID,kullaniciID,musteriID,checkindurumu,rezervasyondurumu,satistarihi)values (@seferID,@kullaniciID,@musteriID,0,1,@satistarihi)", baglanti);
            sorgu.Parameters.Add("@seferID", seferID);
            sorgu.Parameters.Add("@kullaniciID", kID);
            sorgu.Parameters.Add("@musteriID", MusteriID);
            sorgu.Parameters.Add("@satistarihi", satis);
            sorgu.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            SqlCommand IDogren = new SqlCommand("select biletID from biletler where seferID=@seferr and kullaniciID=@KID and musteriID=@MID and satistarihi=@tarihh ", baglanti);
            IDogren.Parameters.Add("@seferr", seferID);
            IDogren.Parameters.Add("@KID", kID);
            IDogren.Parameters.Add("@MID", MusteriID);
            IDogren.Parameters.Add("@tarihh", satis);
            SqlDataReader oku = IDogren.ExecuteReader();
            if (oku.Read())
            {
                int PNRno = Convert.ToInt32(oku["biletID"].ToString());
                MessageBox.Show("PNR Numaranız: " + PNRno.ToString() + "\nNot alınız..\nMenü sayfasına yönlendiriliyorsunuz..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand guncelleKoltuk = new SqlCommand("update seferler set koltuksayisi=koltuksayisi-1 where seferID=@seferrr", baglanti);
            guncelleKoltuk.Parameters.Add("@seferrr", seferID);
            guncelleKoltuk.ExecuteNonQuery();
            baglanti.Close();

            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            grpBoxUcusBilgi.Enabled = true;
            btnListele.Enabled = true;
            btnDevamEt.Enabled = false;
            grpBoxMusteriBilgi.Enabled = false;
            cmbBoxSaatVeTarih.Items.Clear();
        }

        private void txtBoxMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



    }
}
