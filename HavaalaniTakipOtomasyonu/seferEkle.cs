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
    public partial class seferEkle : Form
    {
        public seferEkle()
        {
            InitializeComponent();
        }

        int seferID;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void seferEkle_Load(object sender, EventArgs e)
        {
            dtpSeferTarihi.MinDate = DateTime.Now.AddDays(1);
            dtpSeferTarihi.Value = DateTime.Now.AddDays(1);

            txtBoxKoltukSayisi.Text = "20";
            txtBoxKoltukSayisi.Enabled = false;

            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from havaalani", baglanti);
            SqlDataReader read = kmt.ExecuteReader();
            while (read.Read())
            {
                cmbBoxKalkisHavaalani.Items.Add(read["havaalaniAdi"]);
                cmbBoxInisHavaalani.Items.Add(read["havaalaniAdi"]);
            }
            cmbBoxKalkisHavaalani.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxInisHavaalani.DropDownStyle = ComboBoxStyle.DropDownList;
            baglanti.Close();

            cmbBoxSaat.Items.Add("00");
            cmbBoxSaat.Items.Add("01");
            cmbBoxSaat.Items.Add("02");
            cmbBoxSaat.Items.Add("03");
            cmbBoxSaat.Items.Add("04");
            cmbBoxSaat.Items.Add("05");
            cmbBoxSaat.Items.Add("06");
            cmbBoxSaat.Items.Add("07");
            cmbBoxSaat.Items.Add("08");
            cmbBoxSaat.Items.Add("09");
            cmbBoxSaat.Items.Add("10");
            cmbBoxSaat.Items.Add("11");
            cmbBoxSaat.Items.Add("12");
            cmbBoxSaat.Items.Add("13");
            cmbBoxSaat.Items.Add("14");
            cmbBoxSaat.Items.Add("15");
            cmbBoxSaat.Items.Add("16");
            cmbBoxSaat.Items.Add("17");
            cmbBoxSaat.Items.Add("18");
            cmbBoxSaat.Items.Add("19");
            cmbBoxSaat.Items.Add("20");
            cmbBoxSaat.Items.Add("21");
            cmbBoxSaat.Items.Add("22");
            cmbBoxSaat.Items.Add("23");
            cmbBoxSaat.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbBoxDakika.Items.Add("00");
            cmbBoxDakika.Items.Add("15");
            cmbBoxDakika.Items.Add("30");
            cmbBoxDakika.Items.Add("45");
            cmbBoxDakika.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void picBoxCikisSeferEkle_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxMenuDonSeferEkle_Click(object sender, EventArgs e)
        {
            Form menuDon = new menu();
            menuDon.Show();
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpSeferTarihi.Value;
            if (cmbBoxKalkisHavaalani.Text != "" && cmbBoxInisHavaalani.Text != "" && txtBoxKoltukSayisi.Text != "" && txtBoxUcret.Text != "" && cmbBoxSaat.Text != "" && cmbBoxDakika.Text != "")
            {
                if (cmbBoxKalkisHavaalani.Text != cmbBoxInisHavaalani.Text)
                {
                    string zaman = tarih.ToShortDateString();
                    tarih = Convert.ToDateTime(zaman);
                    string saat = cmbBoxSaat.Text + ":" + cmbBoxDakika.Text + ":00.0";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Insert Into seferler(kalkisyeri, inisyeri,gidistarihi,gidissaat,koltuksayisi,ucret) values (@kalkis,@inis,@tarih,@saat,@koltuk,@ucret)", baglanti);
                    komut.Parameters.AddWithValue("@inis", cmbBoxInisHavaalani.Text);
                    komut.Parameters.AddWithValue("@kalkis", cmbBoxKalkisHavaalani.Text);
                    komut.Parameters.AddWithValue("@tarih", tarih);
                    komut.Parameters.AddWithValue("@saat", saat);
                    komut.Parameters.AddWithValue("@koltuk", txtBoxKoltukSayisi.Text);
                    komut.Parameters.AddWithValue("@ucret", txtBoxUcret.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Sefer Eklendi..Menü Ekranına Yönlendirileceksiniz..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("select seferID from seferler where kalkisyeri=@kalkiss and inisyeri=@iniss and gidistarihi=@tarihh and gidissaat=@saatt ", baglanti);
                    komut2.Parameters.AddWithValue("@iniss", cmbBoxInisHavaalani.Text);
                    komut2.Parameters.AddWithValue("@kalkiss", cmbBoxKalkisHavaalani.Text);
                    komut2.Parameters.AddWithValue("@tarihh", tarih);
                    komut2.Parameters.AddWithValue("@saatt", saat);
                    komut2.ExecuteNonQuery();
                    SqlDataReader dr = komut2.ExecuteReader();
                    if (dr.Read())
                    {
                        seferID = Convert.ToInt32(dr["seferID"]);
                    }
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand koltukekle = new SqlCommand("Insert into koltuklar (seferID,koltuk1,koltuk2,koltuk3,koltuk4,koltuk5,koltuk6,koltuk7,koltuk8,koltuk9,koltuk10,koltuk11,koltuk12,koltuk13,koltuk14,koltuk15,koltuk16,koltuk17,koltuk18,koltuk19,koltuk20) values (@seferID,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0)", baglanti);
                    koltukekle.Parameters.Add("seferID", seferID);
                    koltukekle.ExecuteNonQuery();
                    baglanti.Close();

                    Form menuDon = new menu();
                    menuDon.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kalkış Yeri İle İniş Yeri  aynı olamaz..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxKoltukSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBoxUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
