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
    public partial class kullaniciAdminIslemleri : Form
    {
        public kullaniciAdminIslemleri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void kullaniciAdminIslemleri_Load(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            lblKullaniciAdiAdmKi.Text = Form1.kullaniciAdiAdmin;

            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from gizliSorular", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                cmbBoxGizliSoru.Items.Add(read["gizliSoruIcerik"]);
                cmbBoxMevcutGizliSoru.Items.Add(read["gizliSoruIcerik"]);
            }
            cmbBoxGizliSoru.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxMevcutGizliSoru.DropDownStyle = ComboBoxStyle.DropDownList;
            baglanti.Close();

            grpBoxMevcutKullanici.Enabled = false;
            txtBoxKullaniciNo.Enabled = false;

            txtBoxTcNo.MaxLength = 11;
            txtBoxMevcutTcNo.MaxLength = 11;

            txtBoxTelefon.MaxLength = 11;
            txtBoxMevcutTelefon.MaxLength = 11;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
            MessageBox.Show("Şu anda Kullanıcı İşlemleri Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYeniKaydet_Click(object sender, EventArgs e)
        {
            string tcnoYeni = txtBoxTcNo.Text;
            tcnoYeni.Trim();

            string telYeni = txtBoxTelefon.Text;
            telYeni.Trim();

            if (tcnoYeni.Length == 11)
            {
                if (telYeni.Length == 11)
                {
                    if (txtBoxTcNo.Text != "" && txtBoxAdSoyad.Text != "" && txtBoxTelefon.Text != "" && txtBoxEmail.Text != "" && txtBoxKullaniciAdi.Text != "" && txtBoxParola.Text != "" && cmbBoxGizliSoru.Text != "" && txtBoxGizliCevap.Text != "" && txtBoxAdres.Text != "")
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Insert into giris(kullaniciadi, sifre, gizlisoru, gizlicevap, telefon, tcno, adres, email, adsoyad) Values('" + txtBoxKullaniciAdi.Text + "','" + txtBoxParola.Text + "','" + cmbBoxGizliSoru.Text + "','" + txtBoxGizliCevap.Text + "','" + txtBoxTelefon.Text + "','" + txtBoxTcNo.Text + "','" + txtBoxAdres.Text + "' ,'" + txtBoxEmail.Text + "','" + txtBoxAdSoyad.Text + "') ", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        MessageBox.Show("Kayıt Başarılı..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        baglanti.Close();
                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("select * from giris where tcno='" + txtBoxTcNo.Text + "' and adsoyad='" + txtBoxAdSoyad.Text + "' and telefon='" + txtBoxTelefon.Text + "' ", baglanti);
                        SqlDataReader dr2 = komut2.ExecuteReader();
                        if (dr2.Read())
                        {
                            txtBoxKullaniciNo.Text = dr2[9].ToString();
                        }
                        baglanti.Close();

                        MessageBox.Show("Kullanıcı Numarası : " + txtBoxKullaniciNo.Text + "\nMenü Sayfasına Yönlendirileceksiniz..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtBoxTcNo.Text = "";
                        txtBoxAdSoyad.Text = "";
                        txtBoxTelefon.Text = "";
                        txtBoxEmail.Text = "";
                        txtBoxKullaniciAdi.Text = "";
                        txtBoxParola.Text = "";
                        cmbBoxGizliSoru.Text = "";
                        txtBoxGizliCevap.Text = "";
                        txtBoxAdres.Text = "";

                        Form menuDon = new adminMenu();
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

        private void btnKullaniciBul_Click(object sender, EventArgs e)
        {
            txtBoxKullaniciNo.Text = "";
            if (txtBoxKullaniciBulNo.Text != "")
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("select * from giris where kullaniciID=" + txtBoxKullaniciBulNo.Text + " ", baglanti);
                SqlDataReader dr2 = komut2.ExecuteReader();
                if (dr2.Read())
                {
                    grpBoxMevcutKullanici.Enabled = true;

                    txtBoxMevcutKullaniciAdi.Text = dr2[0].ToString();
                    txtBoxMevcutParola.Text = dr2[1].ToString();
                    cmbBoxMevcutGizliSoru.Text = dr2[2].ToString();
                    txtBoxMevcutGizliCevap.Text = dr2[3].ToString();
                    txtBoxMevcutTelefon.Text = dr2[4].ToString();
                    txtBoxMevcutTcNo.Text = dr2[5].ToString();
                    txtBoxMevcutAdres.Text = dr2[6].ToString();
                    txtBoxMevcutEmail.Text = dr2[7].ToString();
                    txtBoxMevcutAdSoyad.Text = dr2[8].ToString();

                }
                else
                {
                    MessageBox.Show("Bu ID'ye ait Kullanıcı bilgisi Bulunamadı.!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBoxMevcutTcNo.Text = "";
                    txtBoxMevcutAdSoyad.Text = "";
                    txtBoxMevcutTelefon.Text = "";
                    txtBoxMevcutEmail.Text = "";
                    txtBoxMevcutKullaniciAdi.Text = "";
                    txtBoxMevcutParola.Text = "";
                    cmbBoxMevcutGizliSoru.Text = "";
                    txtBoxMevcutGizliCevap.Text = "";
                    txtBoxMevcutAdres.Text = "";
                    grpBoxMevcutKullanici.Enabled = false;
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Kullanıcı Numarasını Giriniz.!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpBoxMevcutKullanici.Enabled = false;
            }
        }

        private void btnMevcutGuncelle_Click(object sender, EventArgs e)
        {
            string tcnoMevcut = txtBoxMevcutTcNo.Text;
            tcnoMevcut.Trim();

            string telMevcut = txtBoxMevcutTelefon.Text;
            telMevcut.Trim();

            if (tcnoMevcut.Length == 11)
            {
                if (telMevcut.Length == 11)
                {
                    if (txtBoxMevcutTcNo.Text != "" && txtBoxMevcutAdSoyad.Text != "" && txtBoxMevcutTelefon.Text != "" && txtBoxMevcutEmail.Text != "" && txtBoxMevcutKullaniciAdi.Text != "" && txtBoxMevcutParola.Text != "" && cmbBoxMevcutGizliSoru.Text != "" && txtBoxMevcutGizliCevap.Text != "" && txtBoxMevcutAdres.Text != "")
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("update giris set kullaniciadi='" + txtBoxMevcutKullaniciAdi.Text + "' , sifre='" + txtBoxMevcutParola.Text + "', gizlisoru='" + cmbBoxMevcutGizliSoru.Text + "', gizlicevap='" + txtBoxMevcutGizliCevap.Text + "',  telefon='" + txtBoxMevcutTelefon.Text + "', tcno='" + txtBoxMevcutTcNo.Text + "', adres='" + txtBoxMevcutAdres.Text + "', email='" + txtBoxMevcutEmail.Text + "', adsoyad='" + txtBoxMevcutAdSoyad.Text + "' where kullaniciID=" + txtBoxKullaniciBulNo.Text + " ", baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        MessageBox.Show("Güncelleme Başarılı..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBoxKullaniciBulNo.Enabled = true;
                        txtBoxKullaniciBulNo.Text = "";
                        grpBoxMevcutKullanici.Enabled = false;

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

        private void txtBoxTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxKullaniciBulNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxMevcutTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxMevcutTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtBoxMevcutAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
