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
    public partial class parola : Form
    {
        public parola()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void parola_Load(object sender, EventArgs e)
        {
            /*cmbBoxGizliSoru.Items.Add("İlkokul Öğretmeninizin Adı");
            cmbBoxGizliSoru.Items.Add("En Sevdiğiniz Yemek");
            cmbBoxGizliSoru.Items.Add("İlk Evcil Hayvanınız");
            cmbBoxGizliSoru.Items.Add("En Sevdiğiniz Kitap");*/
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from gizliSorular", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                cmbBoxGizliSoru.Items.Add(read["gizliSoruIcerik"]);
            }
            cmbBoxGizliSoru.DropDownStyle = ComboBoxStyle.DropDownList;
            baglanti.Close();

            ToolTip aciklama = new ToolTip();
            aciklama.SetToolTip(picBoxGirisDon, "Giriş Ekranına Dön");
            aciklama.IsBalloon = true;

            txtBoxGizliCevap.Enabled = false;
            btnParolaGoster.Enabled = false;
            txtBoxMevcutParola.Enabled = false;

            txtBoxKullaniciAdi.Text = "hilal-16";
            txtBoxEmail.Text = "hilal@gmail.com";
        }

        private void picBoxCikisParola_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxGirisDon_Click(object sender, EventArgs e)
        {
            Form frmGiriseDon = new Form1();
            frmGiriseDon.Show();
            this.Close();
        }

        private void btnTeyitEt_Click(object sender, EventArgs e)
        {
            txtBoxMevcutParola.Enabled = false;
            txtBoxMevcutParola.Text = "";
            txtBoxGizliCevap.Text = "";
            
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from giris where kullaniciadi='" + txtBoxKullaniciAdi.Text + "' and email='" + txtBoxEmail.Text + "'and gizlisoru='" + cmbBoxGizliSoru.Text + "'", baglanti);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                txtBoxGizliCevap.Enabled = true;
                btnParolaGoster.Enabled = true;

                txtBoxKullaniciAdi.Enabled = false;
                txtBoxEmail.Enabled = false;
                cmbBoxGizliSoru.Enabled = false;
                MessageBox.Show("Teyit İşlemi Başarılı.. Şimdi Gizli Soruyu Cevaplayınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtBoxGizliCevap.Enabled = false;
                txtBoxMevcutParola.Enabled = false;
                MessageBox.Show("Hatalı Giriş Yaptınız.", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            baglanti.Close();
        }

        private void btnParolaGoster_Click(object sender, EventArgs e)
        {
            if (txtBoxGizliCevap.Text != "")
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("select * from giris where kullaniciadi='" + txtBoxKullaniciAdi.Text + "' and email='" + txtBoxEmail.Text + "'and gizlisoru='" + cmbBoxGizliSoru.Text + "'and gizlicevap='" + txtBoxGizliCevap.Text + "' ", baglanti);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    txtBoxMevcutParola.Text = dr[1].ToString();
                    txtBoxGizliCevap.Enabled = true;
                    txtBoxEmail.Enabled = true;
                    txtBoxKullaniciAdi.Enabled = true;
                    cmbBoxGizliSoru.Enabled = true;
                    txtBoxMevcutParola.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Lütfen Gizli Cevabınızı Tekrar Kontrol Ediniz..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Gizli Cevap Alanını Boş Bırakmayınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
