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
    public partial class odeme : Form
    {
        public odeme()
        {
            InitializeComponent();
        }

        int gelenseferID, gelenMusteriID, ucret;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void odeme_Load(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            Form frmBiletSatis = new biletSatis();

            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from kartSonKullanimYillar", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                cmbBoxSonKullanmaYil.Items.Add(read["kartSonKullanmaYili"]);
            }
            cmbBoxSonKullanmaYil.DropDownStyle = ComboBoxStyle.DropDownList;
            baglanti.Close();

            cmbBoxSonKullanmaAy.Items.Add("01");
            cmbBoxSonKullanmaAy.Items.Add("02");
            cmbBoxSonKullanmaAy.Items.Add("03");
            cmbBoxSonKullanmaAy.Items.Add("04");
            cmbBoxSonKullanmaAy.Items.Add("05");
            cmbBoxSonKullanmaAy.Items.Add("06");
            cmbBoxSonKullanmaAy.Items.Add("07");
            cmbBoxSonKullanmaAy.Items.Add("08");
            cmbBoxSonKullanmaAy.Items.Add("09");
            cmbBoxSonKullanmaAy.Items.Add("10");
            cmbBoxSonKullanmaAy.Items.Add("11");
            cmbBoxSonKullanmaAy.Items.Add("12");
            cmbBoxSonKullanmaAy.DropDownStyle = ComboBoxStyle.DropDownList;

            txtBoxKartNumarasi.MaxLength = 16;
            txtBoxGüvenlikKoduKrediKarti.MaxLength = 3;

            txtBoxBiletTutariOdeme.Enabled = false;
            txtBoxHizmetBedeliOdeme.Enabled = false;
            txtBoxVergiOdeme.Enabled = false;
            txtBoxToplamTutarOdeme.Enabled = false;

            txtBoxToplamTutarNakit.Enabled = false;
            txtBoxParaUstuNakit.Enabled = false;

            txtBoxToplamTutarKrediKarti.Enabled = false;

            lblKullaniciAdi.Text = Form1.kullaniciAdi;
            int kID = Form1.kullaniciID;
            gelenseferID = biletSatis.seferID;
            gelenMusteriID = biletSatis.MusteriID;
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select ucret from seferler where seferID=@seferno", baglanti);
            sorgu.Parameters.Add("@seferno", gelenseferID);
            SqlDataReader oku = sorgu.ExecuteReader();
            if (oku.Read())
            {
                ucret = Convert.ToInt32(oku["ucret"].ToString());
                txtBoxBiletTutariOdeme.Text = oku["ucret"].ToString();
            }
            baglanti.Close();
            double hizmet = (double)ucret * 0.01F;
            hizmet = Math.Round(hizmet, 2);
            txtBoxHizmetBedeliOdeme.Text = (hizmet).ToString();
            double vergi = (double)ucret * 0.18F;
            vergi = Math.Round(vergi, 2);
            txtBoxVergiOdeme.Text = vergi.ToString();
            double toplam = (float)ucret + (float)hizmet + (float)vergi;
            toplam = Math.Round(toplam, 2);
            txtBoxToplamTutarOdeme.Text = toplam.ToString();
        }

        private void picBoxCikisOdeme_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form biletSatisDon = new biletSatis();
            biletSatisDon.Show();
            this.Close();
        }

        private void llbMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form biletSatisDon = new biletSatis();
            biletSatisDon.Show();
            this.Close();
        }

        private void llbOdeme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şu anda Ödeme Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioBtnNakit_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxNakit.Enabled = true;
            grpBoxKrediKarti.Enabled = false;
            double sayi = (double)ucret * 1.19F;
            sayi = Math.Round(sayi, 2);
            txtBoxToplamTutarNakit.Text = sayi.ToString();
            txtBoxToplamTutarKrediKarti.Text = "";
        }

        private void radioBtnKrediKarti_CheckedChanged(object sender, EventArgs e)
        {
            grpBoxKrediKarti.Enabled = true;
            grpBoxNakit.Enabled = false;
            double sayi = (double)ucret * 1.19F;
            sayi = Math.Round(sayi, 2);
            txtBoxToplamTutarKrediKarti.Text = sayi.ToString();
            txtBoxToplamTutarNakit.Text = "";
        }

        private void btnOdemeyiTamamlaNakit_Click(object sender, EventArgs e)
        {
            Form fm1 = new Form1();
            int kID = Form1.kullaniciID;
            double toplamtutar = ucret * 1.19F;
            if (txtBoxOdemeTutariNakit.Text != "")
            {
                int nakitodeme = Convert.ToInt32(txtBoxOdemeTutariNakit.Text);
                if (toplamtutar <= nakitodeme)
                {
                    double hesapla = nakitodeme - toplamtutar;
                    hesapla = Math.Round(hesapla, 2);
                    txtBoxParaUstuNakit.Text = (hesapla).ToString();
                    baglanti.Open();
                    DateTime satis = DateTime.Now;
                    SqlCommand sorgu = new SqlCommand("insert into biletler (seferID,kullaniciID,musteriID,checkindurumu,rezervasyondurumu,satistarihi)values (@seferID,@kullaniciID,@musteriID,0,0,@satistarihi)", baglanti);
                    sorgu.Parameters.Add("@seferID", gelenseferID);
                    sorgu.Parameters.Add("@kullaniciID", kID);
                    sorgu.Parameters.Add("@musteriID", gelenMusteriID);
                    sorgu.Parameters.Add("@satistarihi", satis);
                    sorgu.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand IDogren = new SqlCommand("select biletID from biletler where seferID=@seferr and kullaniciID=@KID and musteriID=@MID and satistarihi=@tarihh ", baglanti);
                    IDogren.Parameters.Add("@seferr", gelenseferID);
                    IDogren.Parameters.Add("@KID", kID);
                    IDogren.Parameters.Add("@MID", gelenMusteriID);
                    IDogren.Parameters.Add("@tarihh", satis);
                    SqlDataReader oku = IDogren.ExecuteReader();
                    if (oku.Read())
                    {
                        int PNRno = Convert.ToInt32(oku["biletID"].ToString());
                        MessageBox.Show("PNR Numaranız: " + PNRno.ToString() + " \nNot alınız..\nMenü sayfasına yönlendirme..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    baglanti.Close();

                    baglanti.Open();
                    SqlCommand guncelleKoltuk = new SqlCommand("update seferler set koltuksayisi=koltuksayisi-1 where seferID=@seferrr", baglanti);
                    guncelleKoltuk.Parameters.Add("@seferrr", gelenseferID);
                    guncelleKoltuk.ExecuteNonQuery();
                    baglanti.Close();

                    Form menuDon = new menu();
                    menuDon.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Eksik tutar girdiniz..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Lütfen ödeme tutarı giriniz..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdemeyiTamamlaKrediKarti_Click(object sender, EventArgs e)
        {
            string kartNumarasi = txtBoxKartNumarasi.Text;
            kartNumarasi.Trim();

            string kartGuvenlikNo = txtBoxGüvenlikKoduKrediKarti.Text;
            kartGuvenlikNo.Trim();

            if (txtBoxKartNumarasi.Text != "" && txtBoxKartSahibiAdi.Text != "" && txtBoxGüvenlikKoduKrediKarti.Text != "" && cmbBoxSonKullanmaAy.Text != "" && cmbBoxSonKullanmaYil.Text != "")
            {
                if (kartNumarasi.Length == 16 && kartGuvenlikNo.Length == 3)
                {
                    Form fm1 = new Form1();
                    int kID = Form1.kullaniciID;
                    baglanti.Open();
                    DateTime satis = DateTime.Now;
                    SqlCommand sorgu = new SqlCommand("insert into biletler (seferID,kullaniciID,musteriID,checkindurumu,rezervasyondurumu,satistarihi)values (@seferID,@kullaniciID,@musteriID,0,0,@satistarihi)", baglanti);
                    sorgu.Parameters.Add("@seferID", gelenseferID);
                    sorgu.Parameters.Add("@kullaniciID", kID);
                    sorgu.Parameters.Add("@musteriID", gelenMusteriID);
                    sorgu.Parameters.Add("@satistarihi", satis);
                    sorgu.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand IDogren = new SqlCommand("select biletID from biletler where seferID=@seferr and kullaniciID=@KID and musteriID=@MID and satistarihi=@tarihh ", baglanti);
                    IDogren.Parameters.Add("@seferr", gelenseferID);
                    IDogren.Parameters.Add("@KID", kID);
                    IDogren.Parameters.Add("@MID", gelenMusteriID);
                    IDogren.Parameters.Add("@tarihh", satis);
                    SqlDataReader oku = IDogren.ExecuteReader();
                    if (oku.Read())
                    {
                        int PNRno = Convert.ToInt32(oku["biletID"].ToString());
                        MessageBox.Show("PNR Numaranız: " + PNRno.ToString() + " \nNot alınız.. \nMenü sayfasına yönlendirme..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand guncelleKoltuk = new SqlCommand("update seferler set koltuksayisi=koltuksayisi-1 where seferID=@seferrr", baglanti);
                    guncelleKoltuk.Parameters.Add("@seferrr", gelenseferID);
                    guncelleKoltuk.ExecuteNonQuery();
                    baglanti.Close();

                    Form menuDon = new menu();
                    menuDon.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen Kart Numaranızı / Güvenlik Kodunuzu Kontrol Ediniz..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bilgilerinizi Eksiksiz Doldurunuz..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtBoxOdemeTutariNakit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxKartNumarasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxKartSahibiAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtBoxGüvenlikKoduKrediKarti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
