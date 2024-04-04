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
    public partial class biletSatis : Form
    {
        public biletSatis()
        {
            InitializeComponent();
        }

        public static int seferID, MusteriID;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void biletSatis_Load(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            lblKullaniciAdiBiletSatis.Text = Form1.kullaniciAdi;
            dtpGidisTarihi.MinDate = DateTime.Now;

            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from havaalani", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                cmbBoxGidisHavaalani.Items.Add(read["havaalaniAdi"]);
                cmbBoxInisHavaalani.Items.Add(read["havaalaniAdi"]);
            }
            cmbBoxGidisHavaalani.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxInisHavaalani.DropDownStyle = ComboBoxStyle.DropDownList;
            baglanti.Close();

            cmbBoxCinsiyet.Items.Add("Kadın");
            cmbBoxCinsiyet.Items.Add("Erkek");
            cmbBoxCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBoxSaatveUcret.DropDownStyle = ComboBoxStyle.DropDownList;

            ToolTip aciklama = new ToolTip();
            aciklama.SetToolTip(picBoxMenuDonBiletSatis, "Menü Ekranına Dön");
            aciklama.IsBalloon = true;

            btnDevamEt.Enabled = false;
            grpBoxMusteriBilgi.Enabled = false;
        }

        private void picBoxCikisBiletSatis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llbMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şu anda Bilet Satış Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void picBoxMenuDonBiletSatis_Click(object sender, EventArgs e)
        {
            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void cmbBoxGidisHavaalani_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxSaatveUcret.Items.Clear();
            btnListele.Enabled = true;
            btnDevamEt.Enabled = false;
        }

        private void cmbBoxInisHavaalani_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBoxSaatveUcret.Items.Clear();
            btnListele.Enabled = true;
            btnDevamEt.Enabled = false;
        }

        private void dtpGidisTarihi_ValueChanged(object sender, EventArgs e)
        {
            cmbBoxSaatveUcret.Items.Clear();
            btnListele.Enabled = true;
            btnDevamEt.Enabled = false;
        }

        private void cmbBoxSaatveUcret_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxSaatveUcret.Text != "")
            {
                btnDevamEt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lütfen bir saat seçiniz..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            sorgu.Parameters.Add("@kalkis", cmbBoxGidisHavaalani.Text);
            sorgu.Parameters.Add("@inis", cmbBoxInisHavaalani.Text);
            sorgu.Parameters.Add("@zamann", ara1);
            SqlDataReader dr = sorgu.ExecuteReader();
            int sayac = 0;
            int koltuk;
            while (dr.Read())
            {
                // koltuk sayısı kontrolü
                sayac++;
                cmbBoxSaatveUcret.Items.Add(dr["gidissaat"] + " Saatli ve " + dr["ucret"].ToString() + " TL ücretli ");
                btnListele.Enabled = false;
                MessageBox.Show("Kriterlerinize Uygun Uçuşlar Listelendi.. Lütfen Saat ve Ücret Seçiminizi Yapınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (sayac == 0)
            {
                MessageBox.Show("Bu kriterlere uygun uçuş bulunmamaktadır..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string saat = cmbBoxSaatveUcret.Text.Substring(0, 8);
            SqlCommand sorgu = new SqlCommand("select seferID from seferler where kalkisyeri=@kalkiss and inisyeri=@iniss and gidistarihi=@tarihh and gidissaat=@saaat", baglanti);
            sorgu.Parameters.Add("@kalkiss", cmbBoxGidisHavaalani.Text);
            sorgu.Parameters.Add("@iniss", cmbBoxInisHavaalani.Text);
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
                txtBoxCepTelefonu.Enabled = false;
                txtBoxEvTelefonu.Enabled = false;
                cmbBoxCinsiyet.Enabled = false;
                txtBoxEmail.Enabled = false;
                txtBoxAdres.Enabled = false;
                btnOdemeYap.Enabled = false;
            }
            baglanti.Close();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            if (txtBoxMusteriNumarasi.Text != "")
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from musteriler where MID=" + txtBoxMusteriNumarasi.Text + " ", baglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    MusteriID = Convert.ToInt32(dr2[7]);
                    txtBoxTcNo.Text = dr2[0].ToString();
                    txtBoxAdSoyad.Text = dr2[1].ToString();
                    txtBoxCepTelefonu.Text = dr2[2].ToString();
                    txtBoxEvTelefonu.Text = dr2[3].ToString();
                    cmbBoxCinsiyet.Text = dr2[4].ToString();
                    txtBoxEmail.Text = dr2[5].ToString();
                    txtBoxAdres.Text = dr2[6].ToString();
                    btnOdemeYap.Enabled = true;
                }
                else
                {
                    txtBoxTcNo.Text = "";
                    txtBoxAdSoyad.Text = "";
                    txtBoxCepTelefonu.Text = "";
                    txtBoxEvTelefonu.Text = "";
                    cmbBoxCinsiyet.Text = "";
                    txtBoxEmail.Text = "";
                    txtBoxAdres.Text = "";
                    MessageBox.Show("Bu ID'ye ait müşteri bilgisi bulunamadı.!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnOdemeYap.Enabled = false;
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Müşteri Numarası Girişi Yapınız.!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxTcNo.Text = "";
                txtBoxAdSoyad.Text = "";
                txtBoxCepTelefonu.Text = "";
                txtBoxEvTelefonu.Text = "";
                cmbBoxCinsiyet.Text = "";
                txtBoxEmail.Text = "";
                txtBoxAdres.Text = "";
                btnOdemeYap.Enabled = false;
            }

        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            Form odemeForm = new odeme();
            odemeForm.Show();
            this.Close();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            grpBoxUcusBilgi.Enabled = true;
            btnDevamEt.Enabled = false;
            grpBoxMusteriBilgi.Enabled = false;
            cmbBoxSaatveUcret.Items.Clear();
        }

        private void txtBoxMusteriNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
