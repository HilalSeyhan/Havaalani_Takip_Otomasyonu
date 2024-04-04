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
    public partial class kullaniciAdminArama : Form
    {
        public kullaniciAdminArama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BK845UE;Initial Catalog=projeHavaalani;Integrated Security=True;");

        private void kullaniciAdminArama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeHavaalaniDataSet3.giris' table. You can move, or remove it, as needed.
            this.girisTableAdapter.Fill(this.projeHavaalaniDataSet3.giris);
            // TODO: This line of code loads data into the 'projeHavaalaniDataSet3.giris' table. You can move, or remove it, as needed.
            this.girisTableAdapter.Fill(this.projeHavaalaniDataSet3.giris);


            Form frm1 = new Form1();
            lblKullaniciAdiAdmArama.Text = Form1.kullaniciAdiAdmin;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
            MessageBox.Show("Şu anda Kullanıcı Arama Ekranındasınız..", "✈ ~~ Otomasyon Mesajı ~~ ✈", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter aramayap1 = new SqlDataAdapter("select * from [giris] where [adsoyad] like '%" + textBox1.Text + "%'", baglanti);
            aramayap1.Fill(tbl);
            baglanti.Close();
            dataGridView1.DataSource = tbl;
        }
    }
}
