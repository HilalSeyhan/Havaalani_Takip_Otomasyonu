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
    public partial class kullaniciBilgiDuzenle : Form
    {
        public kullaniciBilgiDuzenle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void kullaniciBilgiDuzenle_Load(object sender, EventArgs e)
        {
            /*cmbBoxGizliSorunuz.Items.Add("İlkokul Öğretmeninizin Adı");
            cmbBoxGizliSorunuz.Items.Add("En Sevdiğiniz Yemek");
            cmbBoxGizliSorunuz.Items.Add("İlk Evcil Hayvanınız");
            cmbBoxGizliSorunuz.Items.Add("En Sevdiğiniz Kitap");*/
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from gizliSorular", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                cmbBoxGizliSorunuz.Items.Add(read["gizliSoruIcerik"]);
            }
            cmbBoxGizliSorunuz.DropDownStyle = ComboBoxStyle.DropDownList;
            baglanti.Close();

            txtBoxTCno.MaxLength = 11;
            txtBoxTelefon.MaxLength = 11;

            txtBoxKullaniciAdi.Enabled = false;
            txtBoxMevcutParola.Enabled = false;

            txtBoxMevcutParola.PasswordChar = '*';

            ToolTip aciklama = new ToolTip();
            aciklama.SetToolTip(picBoxMenuDonus, "Menü Ekranına Dön");
            aciklama.IsBalloon = true;

            Form frm1 = new Form1();
            lblKullaniciFormBilgi.Text = Form1.kullaniciAdi;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from giris where kullaniciadi='" + Form1.kullaniciAdi + "' ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                txtBoxKullaniciAdi.Text = dr[0].ToString();
                txtBoxTCno.Text = dr[5].ToString();
                txtBoxAdSoyad.Text = dr[8].ToString();
                txtBoxEmail.Text = dr[7].ToString();
                txtBoxTelefon.Text = dr[4].ToString();
                txtBoxAdres.Text = dr[6].ToString();
                cmbBoxGizliSorunuz.Text = dr[2].ToString();
                txtBoxGizliCevabiniz.Text = dr[3].ToString();
                txtBoxMevcutParola.Text = dr[1].ToString();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMenuDonus_Click(object sender, EventArgs e)
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
            MessageBox.Show("Şu anda Kullanıcı Bilgileri Düzenleme Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string tcnoYeni = txtBoxTCno.Text;
            tcnoYeni.Trim();

            string telYeni = txtBoxTelefon.Text;
            telYeni.Trim();
            if (tcnoYeni.Length == 11)
            {
                if (telYeni.Length == 11)
                {
                    if (txtBoxTelefon.Text != "" && txtBoxTCno.Text != "" && txtBoxAdSoyad.Text != "" && txtBoxEmail.Text != "" && txtBoxAdres.Text != "" && cmbBoxGizliSorunuz.Text != "" && txtBoxGizliCevabiniz.Text != "")
                    {
                        baglanti.Open();

                        SqlCommand komut = new SqlCommand("update giris set telefon='" + txtBoxTelefon.Text + "' , tcno='" + txtBoxTCno.Text + "', adsoyad='" + txtBoxAdSoyad.Text + "', email='" + txtBoxEmail.Text + "',  adres='" + txtBoxAdres.Text + "', gizlisoru='" + cmbBoxGizliSorunuz.Text + "', gizlicevap='" + txtBoxGizliCevabiniz.Text + "'  where kullaniciadi='" + Form1.kullaniciAdi + "' ", baglanti);

                        SqlDataReader dr = komut.ExecuteReader();

                        MessageBox.Show("Güncelleme Başarılı..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtBoxMevcutParola.PasswordChar = '\0';
            }
            else
            {
                txtBoxMevcutParola.PasswordChar = '*';
            }
        }

        private void btnParolaDegistir_Click(object sender, EventArgs e)
        {
            if (txtBoxYeniParola.Text == txtBoxYeniParolaTekrar.Text)
            {
                if (txtBoxYeniParola.Text != "" && txtBoxYeniParolaTekrar.Text != "")
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand("update giris set sifre='" + txtBoxYeniParola.Text + "'where kullaniciadi='" + Form1.kullaniciAdi + "' ", baglanti);
                    SqlDataReader dr = komut.ExecuteReader();

                    baglanti.Close();

                    MessageBox.Show("Parola Değiştirildi..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form frmKullaniciBilgi = new kullaniciBilgiDuzenle();
                    frmKullaniciBilgi.Show();
                }
                else
                {
                    MessageBox.Show("Boş Giriş Yapmayınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Yeni Parola ile Parola Tekrarı Uyuşmamaktadır..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxTCno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txtBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
