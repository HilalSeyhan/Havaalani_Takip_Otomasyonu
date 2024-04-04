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
    public partial class biletIade : Form
    {
        public biletIade()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");
        int seferID, MusteriID, biletID;

        private void biletIade_Load(object sender, EventArgs e)
        {
            Form frm1 = new Form1();
            lblKullaniciAdi.Text = Form1.kullaniciAdi;

            grpBoxBiletBilgi.Enabled = false;

            ToolTip aciklama = new ToolTip();
            aciklama.SetToolTip(picBoxMenuDonBiletIade, "Menü Ekranına Dön");
            aciklama.IsBalloon = true;
        }

        private void pixBoxCikisBiletIade_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMenuDonBiletIade_Click(object sender, EventArgs e)
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

        private void llbBiletIade_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Şu anda Bilet İade Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int pnr = Convert.ToInt32(textBox1.Text);
                baglanti.Open();
                SqlCommand pnrbul = new SqlCommand("select * from biletler where biletID=@PNR", baglanti);
                pnrbul.Parameters.Add("@PNR", pnr);
                SqlDataReader oku = pnrbul.ExecuteReader();
                if (oku.Read())
                {
                    MusteriID = Convert.ToInt32(oku["musteriID"].ToString());
                    seferID = Convert.ToInt32(oku["seferID"].ToString());
                    biletID = Convert.ToInt32(textBox1.Text);
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand musteribul = new SqlCommand("select * from musteriler where MID=@MusteriID", baglanti);
                    musteribul.Parameters.Add("MusteriID", MusteriID);
                    SqlDataReader musteri = musteribul.ExecuteReader();
                    if (musteri.Read())
                    {
                        txtBoxAdSoyad.Text = musteri["adsoyad"].ToString();
                        txtBoxTCno.Text = musteri["tcno"].ToString();
                    }
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand seferBul = new SqlCommand("select * from seferler where seferID=@seferr", baglanti);
                    seferBul.Parameters.Add("@seferr", seferID);
                    SqlDataReader seferrr = seferBul.ExecuteReader();
                    if (seferrr.Read())
                    {
                        txtBoxInisHavaalani.Text = seferrr["inisyeri"].ToString();
                        txtBoxKalkisHavaalani.Text = seferrr["kalkisyeri"].ToString();
                        txtBoxTarihVeSaat.Text = seferrr["gidistarihi"].ToString().Substring(0, 11) + seferrr["gidissaat"].ToString();
                        txtBoxBiletTutari.Text = seferrr["ucret"].ToString();
                    }

                    grpBoxBiletBilgi.Enabled = true;
                    txtBoxTCno.Enabled = false;
                    txtBoxAdSoyad.Enabled = false;
                    txtBoxKalkisHavaalani.Enabled = false;
                    txtBoxInisHavaalani.Enabled = false;
                    txtBoxTarihVeSaat.Enabled = false;
                    txtBoxBiletTutari.Enabled = false;

                    grpBoxBiletIade.Enabled = false;
                }
                else { MessageBox.Show("Bu PNR numarasına ait bilet bulunamadı.!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen PNR numarası giriniz.", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            DateTime ucustarih;
            int checkin = 0;
            baglanti.Open();
            SqlCommand seferIDbul = new SqlCommand("select seferID,checkindurumu from biletler where biletID=@biletNO", baglanti);
            seferIDbul.Parameters.Add("biletNO", biletID);
            SqlDataReader dr = seferIDbul.ExecuteReader();
            if (dr.Read())
            {
                seferID = Convert.ToInt32(dr["seferID"].ToString());
                checkin = Convert.ToInt32(dr["checkindurumu"].ToString());
            }
            dr.Close();
            SqlCommand tarihal = new SqlCommand("select gidistarihi from seferler where seferID=@seferNO", baglanti);
            tarihal.Parameters.Add("seferNO", seferID);
            SqlDataReader dr1 = tarihal.ExecuteReader();
            if (dr1.Read())
            {

                ucustarih = Convert.ToDateTime(dr1["gidistarihi"].ToString());
                if (ucustarih < DateTime.Now)
                {
                    MessageBox.Show("Geçmiş Tarihe ait bilet iptal edilemez..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    dr1.Close();
                }
                else if (checkin != 0)
                {
                    MessageBox.Show("Checkin yapılan bilet iptal edilemez..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dr1.Close();
                    SqlCommand biletsil = new SqlCommand("delete from biletler where biletID=@BiletID", baglanti);
                    biletsil.Parameters.Add("BiletID", biletID);
                    biletsil.ExecuteNonQuery();
                    SqlCommand koltukarttir = new SqlCommand("update seferler set koltuksayisi=koltuksayisi+1 where seferID=@seferID", baglanti);
                    koltukarttir.Parameters.Add("@seferID", seferID);
                    koltukarttir.ExecuteNonQuery();
                    MessageBox.Show("Bilet Silindi..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form menuDon = new menu();
                    menuDon.Show();
                }
            }

            baglanti.Close();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            grpBoxBiletBilgi.Enabled = false;
            grpBoxBiletIade.Enabled = true;
            txtBoxTCno.Text = "";
            txtBoxAdSoyad.Text = "";
            txtBoxKalkisHavaalani.Text = "";
            txtBoxInisHavaalani.Text = "";
            txtBoxTarihVeSaat.Text = "";
            txtBoxBiletTutari   .Text = "";
        }



    }
}
