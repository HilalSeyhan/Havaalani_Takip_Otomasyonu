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
    public partial class musteriEkle : Form
    {
        public musteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void musteriEkle_Load(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            lblKullaniciAdiMusteriEkleForm.Text = Form1.kullaniciAdi;

            cmbBoxYeniCinsiyet.Items.Add("Kadın");
            cmbBoxYeniCinsiyet.Items.Add("Erkek");
            cmbBoxYeniCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBoxMevcutCinsiyet.Items.Add("Kadın");
            cmbBoxMevcutCinsiyet.Items.Add("Erkek");
            cmbBoxMevcutCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;

            grpBoxMevcutMusteri.Enabled = false;
            txtBoxYeniMusteriNo.Enabled = false;

            txtBoxYeniTCno.MaxLength = 11;
            txtBoxMevcutTCno.MaxLength = 11;

            txtBoxYeniCepTelNo.MaxLength = 11;
            txtBoxMevcutCepTelNo.MaxLength = 11;

            txtBoxYeniEvTelNo.MaxLength = 11;
            txtBoxMevcutEvTelNo.MaxLength = 11;

            ToolTip aciklama = new ToolTip();
            aciklama.SetToolTip(picBoxMenuDonMusteri, "Menü Ekranına Dön");
            aciklama.IsBalloon = true;
        }

        private void picBoxCikisMusteriEkle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMenuDonMusteri_Click(object sender, EventArgs e)
        {
            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şu anda Müşteri Ekleme Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
            string tcnoYeni = txtBoxYeniTCno.Text;
            tcnoYeni.Trim();

            string ceptelYeni = txtBoxYeniCepTelNo.Text;
            ceptelYeni.Trim();

            string evtelYeni = txtBoxYeniEvTelNo.Text;
            evtelYeni.Trim();

            if (tcnoYeni.Length == 11)
            {
                if (ceptelYeni.Length == 11 && evtelYeni.Length == 11)
                {
                    if (txtBoxYeniTCno.Text != "" && txtBoxYeniAdSoyad.Text != "" && txtBoxYeniCepTelNo.Text != "" && txtBoxYeniEvTelNo.Text != "" && cmbBoxYeniCinsiyet.Text != "" && txtBoxYeniEmail.Text != "" && txtBoxYeniAdres.Text != "")
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Insert into musteriler(tcno,adsoyad,ceptelno,evtelno,cinsiyet,email,adres) Values('" + txtBoxYeniTCno.Text + "','" + txtBoxYeniAdSoyad.Text + "','" + txtBoxYeniCepTelNo.Text + "','" + txtBoxYeniEvTelNo.Text + "','" + cmbBoxYeniCinsiyet.Text + "','" + txtBoxYeniEmail.Text + "','" + txtBoxYeniAdres.Text + "' ) ", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        MessageBox.Show("Kayıt Başarılı..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        baglanti.Close();
                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("select * from musteriler where tcno='" + txtBoxYeniTCno.Text + "' and adsoyad='" + txtBoxYeniAdSoyad.Text + "' and ceptelno='" + txtBoxYeniCepTelNo.Text + "' ", baglanti);
                        SqlDataReader dr2 = komut2.ExecuteReader();
                        if (dr2.Read())
                        {
                            txtBoxYeniMusteriNo.Text = dr2[7].ToString();
                        }
                        baglanti.Close();

                        MessageBox.Show("Müşteri Numarası : "+ txtBoxYeniMusteriNo.Text + "\nMenü Sayfasına Yönlendirileceksiniz..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtBoxYeniTCno.Text = "";
                        txtBoxYeniAdSoyad.Text = "";
                        txtBoxYeniCepTelNo.Text = "";
                        txtBoxYeniEvTelNo.Text = "";
                        cmbBoxYeniCinsiyet.Text = "";
                        txtBoxYeniEmail.Text = "";
                        txtBoxYeniAdres.Text = "";

                        Form menuDon = new menu();
                        menuDon.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Telefon Bilgilerinizi Kontrol Ediniz..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen TC Alanını Kontrol Ediniz..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnMevcutMusteriBul_Click(object sender, EventArgs e)
        {
            txtBoxYeniMusteriNo.Text = "";
            if (txtBoxMevcutMusteriNo.Text != "")
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from musteriler where MID=" + txtBoxMevcutMusteriNo.Text + " ", baglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    grpBoxMevcutMusteri.Enabled = true;
                    txtBoxMevcutTCno.Text = dr2[0].ToString();
                    txtBoxMevcutAdSoyad.Text = dr2[1].ToString();
                    txtBoxMevcutCepTelNo.Text = dr2[2].ToString();
                    txtBoxMevcutEvTelNo.Text = dr2[3].ToString();
                    cmbBoxMevcutCinsiyet.Text = dr2[4].ToString();
                    txtBoxMevcutEmail.Text = dr2[5].ToString();
                    txtBoxMevcutAdres.Text = dr2[6].ToString();

                }
                else
                {
                    MessageBox.Show("Bu ID'ye ait Müşteri bilgisi Bulunamadı.!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxMevcutTCno.Text = "";
                    txtBoxMevcutAdSoyad.Text = "";
                    txtBoxMevcutCepTelNo.Text = "";
                    txtBoxMevcutEvTelNo.Text = "";
                    cmbBoxMevcutCinsiyet.Text = "";
                    txtBoxMevcutEmail.Text = "";
                    txtBoxMevcutAdres.Text = "";
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Müşteri Numarasını Giriniz.!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnMevcutGuncelle_Click(object sender, EventArgs e)
        {
            string tcnoMevcut = txtBoxMevcutTCno.Text;
            tcnoMevcut.Trim();

            string ceptelMevcut = txtBoxMevcutCepTelNo.Text;
            ceptelMevcut.Trim();

            string evtelMevcut = txtBoxMevcutEvTelNo.Text;
            evtelMevcut.Trim();

            if (tcnoMevcut.Length == 11)
            {
                if (ceptelMevcut.Length == 11 && evtelMevcut.Length == 11)
                {
                    if (txtBoxMevcutTCno.Text != "" && txtBoxMevcutAdSoyad.Text != "" && txtBoxMevcutCepTelNo.Text != "" && txtBoxMevcutEvTelNo.Text != "" && cmbBoxMevcutCinsiyet.Text != "" && txtBoxMevcutEmail.Text != "" && txtBoxMevcutAdres.Text != "")
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("update musteriler set tcno='" + txtBoxMevcutTCno.Text + "' , adsoyad='" + txtBoxMevcutAdSoyad.Text + "', ceptelno='" + txtBoxMevcutCepTelNo.Text + "', evtelno='" + txtBoxMevcutEvTelNo.Text + "',  cinsiyet='" + cmbBoxMevcutCinsiyet.Text + "', email='" + txtBoxMevcutEmail.Text + "', adres='" + txtBoxMevcutAdres.Text + "' where MID=" + txtBoxMevcutMusteriNo.Text + " ", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        MessageBox.Show("Güncelleme Başarılı..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxMevcutMusteriNo.Enabled = true;
                        txtBoxMevcutMusteriNo.Text = "";
                        grpBoxMevcutMusteri.Enabled = false;

                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Boş Alan Bırakmayınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Telefon Bilgilerinizi Kontrol Ediniz..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen TC Alanını Kontrol Ediniz..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txtBoxYeniTCno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxYeniCepTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxYeniEvTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxMevcutMusteriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxMevcutCepTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxMevcutEvTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxYeniAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtBoxMevcutAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
