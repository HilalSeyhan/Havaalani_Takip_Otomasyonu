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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        public static string kullaniciAdi;
        public static int kullaniciID;

        public static string kullaniciAdiAdmin;
        public static int kullaniciIDAdmin;

        int hak = 3;
        bool durum = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDenemeKalan.Text = Convert.ToString(hak);
            txtBoxKullaniciAdi.Text = "hilal-16";
            txtBoxParola.Text = "1234";
        }

        private void picBoxCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if(hak != 0)
            {
                if (radioBtnPersonel.Checked)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from giris where kullaniciadi=@ad and sifre=@sifre", baglanti);
                    komut.Parameters.Add("@ad", txtBoxKullaniciAdi.Text);
                    komut.Parameters.Add("@sifre", txtBoxParola.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        kullaniciAdi = txtBoxKullaniciAdi.Text;
                        kullaniciID = Convert.ToInt32(dr["kullaniciID"].ToString());
                        Form frm = new menu();
                        frm.Show();
                        this.Hide();
                        durum = true;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı ya da Parola Girişi Yaptınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    baglanti.Close();
                }

                if (radioBtnAdmin.Checked)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from admin where kullaniciAdi=@adAdmin and sifre=@sifreAdmin", baglanti);
                    komut.Parameters.Add("@adAdmin", txtBoxKullaniciAdi.Text);
                    komut.Parameters.Add("@sifreAdmin", txtBoxParola.Text);
                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        kullaniciAdiAdmin = txtBoxKullaniciAdi.Text;
                        kullaniciIDAdmin = Convert.ToInt32(dr["adminId"].ToString());
                        Form frm = new adminMenu();
                        frm.Show();
                        this.Hide();
                        durum = true;
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı ya da Parola Girişi Yaptınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    baglanti.Close();
                }
                if ((!radioBtnPersonel.Checked) && (!radioBtnAdmin.Checked))
                {
                    MessageBox.Show("Lütfen Yetki Alanınızı Seçiniz..!", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (durum == false)
                {
                    hak--;
                }
            }
            lblDenemeKalan.Text = Convert.ToString(hak);
            if (hak == 0)
            {
                btnGiris.Enabled = false;
                MessageBox.Show("GİRİŞ HAKKINIZ KALMADI.!!\n'ÇIKIŞ' YAPINIZ VE PROGRAMI YENİDEN BAŞLATINIZ..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void llbParolaUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmParola = new parola();
            frmParola.Show();
            this.Hide();
        }

        private void chkBoxParolaGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxParolaGoster.Checked == true)
            {
                txtBoxParola.PasswordChar = '\0';
            }
            else
            {
                txtBoxParola.PasswordChar = '*';
            }
        }
    }
}
