namespace HavaalaniTakipOtomasyonu
{
    partial class rezervasyon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxCikisRezervasyon = new System.Windows.Forms.PictureBox();
            this.llbRezervasyon = new System.Windows.Forms.LinkLabel();
            this.llbMenu = new System.Windows.Forms.LinkLabel();
            this.lblKullaniciAdiRezervasyon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxUcusBilgi = new System.Windows.Forms.GroupBox();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.dtpGidisTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxSaatVeTarih = new System.Windows.Forms.ComboBox();
            this.cmbBoxInısHavaalani = new System.Windows.Forms.ComboBox();
            this.cmbBoxKalkisHavaalani = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxMusteriBilgi = new System.Windows.Forms.GroupBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnRezerveYap = new System.Windows.Forms.Button();
            this.btnMusteriBul = new System.Windows.Forms.Button();
            this.cmbBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtBoxAdres = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxEvTelNo = new System.Windows.Forms.TextBox();
            this.txtBoxCepTelNo = new System.Windows.Forms.TextBox();
            this.txtBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.txtBoxTcNo = new System.Windows.Forms.TextBox();
            this.txtBoxMusteriNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picBoxMenuDonRezervasyon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCikisRezervasyon)).BeginInit();
            this.grpBoxUcusBilgi.SuspendLayout();
            this.grpBoxMusteriBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenuDonRezervasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picBoxCikisRezervasyon);
            this.panel1.Controls.Add(this.llbRezervasyon);
            this.panel1.Controls.Add(this.llbMenu);
            this.panel1.Controls.Add(this.lblKullaniciAdiRezervasyon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 90);
            this.panel1.TabIndex = 0;
            // 
            // picBoxCikisRezervasyon
            // 
            this.picBoxCikisRezervasyon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxCikisRezervasyon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCikisRezervasyon.Image = global::HavaalaniTakipOtomasyonu.Properties.Resources.kapama;
            this.picBoxCikisRezervasyon.Location = new System.Drawing.Point(1152, 8);
            this.picBoxCikisRezervasyon.Name = "picBoxCikisRezervasyon";
            this.picBoxCikisRezervasyon.Size = new System.Drawing.Size(40, 40);
            this.picBoxCikisRezervasyon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCikisRezervasyon.TabIndex = 6;
            this.picBoxCikisRezervasyon.TabStop = false;
            this.picBoxCikisRezervasyon.Click += new System.EventHandler(this.picBoxCikisRezervasyon_Click);
            // 
            // llbRezervasyon
            // 
            this.llbRezervasyon.AutoSize = true;
            this.llbRezervasyon.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llbRezervasyon.Location = new System.Drawing.Point(510, 42);
            this.llbRezervasyon.Name = "llbRezervasyon";
            this.llbRezervasyon.Size = new System.Drawing.Size(185, 26);
            this.llbRezervasyon.TabIndex = 5;
            this.llbRezervasyon.TabStop = true;
            this.llbRezervasyon.Text = "Rezervasyon Yaptır";
            this.llbRezervasyon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRezervasyon_LinkClicked);
            // 
            // llbMenu
            // 
            this.llbMenu.AutoSize = true;
            this.llbMenu.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llbMenu.Location = new System.Drawing.Point(385, 42);
            this.llbMenu.Name = "llbMenu";
            this.llbMenu.Size = new System.Drawing.Size(65, 26);
            this.llbMenu.TabIndex = 4;
            this.llbMenu.TabStop = true;
            this.llbMenu.Text = "Menü";
            this.llbMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMenu_LinkClicked);
            // 
            // lblKullaniciAdiRezervasyon
            // 
            this.lblKullaniciAdiRezervasyon.AutoSize = true;
            this.lblKullaniciAdiRezervasyon.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdiRezervasyon.ForeColor = System.Drawing.Color.Maroon;
            this.lblKullaniciAdiRezervasyon.Location = new System.Drawing.Point(1012, 20);
            this.lblKullaniciAdiRezervasyon.Name = "lblKullaniciAdiRezervasyon";
            this.lblKullaniciAdiRezervasyon.Size = new System.Drawing.Size(72, 28);
            this.lblKullaniciAdiRezervasyon.TabIndex = 3;
            this.lblKullaniciAdiRezervasyon.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(863, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hoşgeldiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(456, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "→";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uçak Bileti Otomasyonu";
            // 
            // grpBoxUcusBilgi
            // 
            this.grpBoxUcusBilgi.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxUcusBilgi.Controls.Add(this.btnDevamEt);
            this.grpBoxUcusBilgi.Controls.Add(this.btnListele);
            this.grpBoxUcusBilgi.Controls.Add(this.dtpGidisTarihi);
            this.grpBoxUcusBilgi.Controls.Add(this.cmbBoxSaatVeTarih);
            this.grpBoxUcusBilgi.Controls.Add(this.cmbBoxInısHavaalani);
            this.grpBoxUcusBilgi.Controls.Add(this.cmbBoxKalkisHavaalani);
            this.grpBoxUcusBilgi.Controls.Add(this.label7);
            this.grpBoxUcusBilgi.Controls.Add(this.label6);
            this.grpBoxUcusBilgi.Controls.Add(this.label5);
            this.grpBoxUcusBilgi.Controls.Add(this.label4);
            this.grpBoxUcusBilgi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxUcusBilgi.Location = new System.Drawing.Point(119, 130);
            this.grpBoxUcusBilgi.Name = "grpBoxUcusBilgi";
            this.grpBoxUcusBilgi.Size = new System.Drawing.Size(459, 411);
            this.grpBoxUcusBilgi.TabIndex = 0;
            this.grpBoxUcusBilgi.TabStop = false;
            this.grpBoxUcusBilgi.Text = "Uçuş Bilgileri";
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(254, 342);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(133, 30);
            this.btnDevamEt.TabIndex = 9;
            this.btnDevamEt.Text = "Devam Et";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(254, 220);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(133, 30);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // dtpGidisTarihi
            // 
            this.dtpGidisTarihi.Location = new System.Drawing.Point(187, 160);
            this.dtpGidisTarihi.Name = "dtpGidisTarihi";
            this.dtpGidisTarihi.Size = new System.Drawing.Size(266, 33);
            this.dtpGidisTarihi.TabIndex = 7;
            this.dtpGidisTarihi.ValueChanged += new System.EventHandler(this.dtpGidisTarihi_ValueChanged);
            // 
            // cmbBoxSaatVeTarih
            // 
            this.cmbBoxSaatVeTarih.FormattingEnabled = true;
            this.cmbBoxSaatVeTarih.Location = new System.Drawing.Point(187, 282);
            this.cmbBoxSaatVeTarih.Name = "cmbBoxSaatVeTarih";
            this.cmbBoxSaatVeTarih.Size = new System.Drawing.Size(266, 34);
            this.cmbBoxSaatVeTarih.TabIndex = 6;
            this.cmbBoxSaatVeTarih.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSaatVeTarih_SelectedIndexChanged);
            // 
            // cmbBoxInısHavaalani
            // 
            this.cmbBoxInısHavaalani.FormattingEnabled = true;
            this.cmbBoxInısHavaalani.Location = new System.Drawing.Point(187, 102);
            this.cmbBoxInısHavaalani.Name = "cmbBoxInısHavaalani";
            this.cmbBoxInısHavaalani.Size = new System.Drawing.Size(266, 34);
            this.cmbBoxInısHavaalani.TabIndex = 5;
            this.cmbBoxInısHavaalani.SelectedIndexChanged += new System.EventHandler(this.cmbBoxInısHavaalani_SelectedIndexChanged);
            // 
            // cmbBoxKalkisHavaalani
            // 
            this.cmbBoxKalkisHavaalani.FormattingEnabled = true;
            this.cmbBoxKalkisHavaalani.Location = new System.Drawing.Point(187, 42);
            this.cmbBoxKalkisHavaalani.Name = "cmbBoxKalkisHavaalani";
            this.cmbBoxKalkisHavaalani.Size = new System.Drawing.Size(266, 34);
            this.cmbBoxKalkisHavaalani.TabIndex = 4;
            this.cmbBoxKalkisHavaalani.SelectedIndexChanged += new System.EventHandler(this.cmbBoxKalkisHavaalani_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Saat ve Ücret :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 26);
            this.label6.TabIndex = 2;
            this.label6.Text = "Gidiş Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "İniş Havaalanı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kalkış Havaalanı :";
            // 
            // grpBoxMusteriBilgi
            // 
            this.grpBoxMusteriBilgi.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxMusteriBilgi.Controls.Add(this.btnGeriDon);
            this.grpBoxMusteriBilgi.Controls.Add(this.btnRezerveYap);
            this.grpBoxMusteriBilgi.Controls.Add(this.btnMusteriBul);
            this.grpBoxMusteriBilgi.Controls.Add(this.cmbBoxCinsiyet);
            this.grpBoxMusteriBilgi.Controls.Add(this.txtBoxAdres);
            this.grpBoxMusteriBilgi.Controls.Add(this.txtBoxEmail);
            this.grpBoxMusteriBilgi.Controls.Add(this.txtBoxEvTelNo);
            this.grpBoxMusteriBilgi.Controls.Add(this.txtBoxCepTelNo);
            this.grpBoxMusteriBilgi.Controls.Add(this.txtBoxAdSoyad);
            this.grpBoxMusteriBilgi.Controls.Add(this.txtBoxTcNo);
            this.grpBoxMusteriBilgi.Controls.Add(this.txtBoxMusteriNo);
            this.grpBoxMusteriBilgi.Controls.Add(this.label15);
            this.grpBoxMusteriBilgi.Controls.Add(this.label14);
            this.grpBoxMusteriBilgi.Controls.Add(this.label13);
            this.grpBoxMusteriBilgi.Controls.Add(this.label12);
            this.grpBoxMusteriBilgi.Controls.Add(this.label11);
            this.grpBoxMusteriBilgi.Controls.Add(this.label10);
            this.grpBoxMusteriBilgi.Controls.Add(this.label9);
            this.grpBoxMusteriBilgi.Controls.Add(this.label8);
            this.grpBoxMusteriBilgi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoxMusteriBilgi.Location = new System.Drawing.Point(596, 130);
            this.grpBoxMusteriBilgi.Name = "grpBoxMusteriBilgi";
            this.grpBoxMusteriBilgi.Size = new System.Drawing.Size(529, 481);
            this.grpBoxMusteriBilgi.TabIndex = 0;
            this.grpBoxMusteriBilgi.TabStop = false;
            this.grpBoxMusteriBilgi.Text = "Müşteri Bilgileri";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Location = new System.Drawing.Point(403, 418);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(120, 35);
            this.btnGeriDon.TabIndex = 18;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnRezerveYap
            // 
            this.btnRezerveYap.Location = new System.Drawing.Point(197, 418);
            this.btnRezerveYap.Name = "btnRezerveYap";
            this.btnRezerveYap.Size = new System.Drawing.Size(150, 35);
            this.btnRezerveYap.TabIndex = 17;
            this.btnRezerveYap.Text = "Rezerve Yap";
            this.btnRezerveYap.UseVisualStyleBackColor = true;
            this.btnRezerveYap.Click += new System.EventHandler(this.btnRezerveYap_Click);
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.Location = new System.Drawing.Point(448, 43);
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(75, 30);
            this.btnMusteriBul.TabIndex = 16;
            this.btnMusteriBul.Text = "Bul";
            this.btnMusteriBul.UseVisualStyleBackColor = true;
            this.btnMusteriBul.Click += new System.EventHandler(this.btnMusteriBul_Click);
            // 
            // cmbBoxCinsiyet
            // 
            this.cmbBoxCinsiyet.FormattingEnabled = true;
            this.cmbBoxCinsiyet.Location = new System.Drawing.Point(197, 242);
            this.cmbBoxCinsiyet.Name = "cmbBoxCinsiyet";
            this.cmbBoxCinsiyet.Size = new System.Drawing.Size(326, 34);
            this.cmbBoxCinsiyet.TabIndex = 15;
            // 
            // txtBoxAdres
            // 
            this.txtBoxAdres.Location = new System.Drawing.Point(197, 322);
            this.txtBoxAdres.Multiline = true;
            this.txtBoxAdres.Name = "txtBoxAdres";
            this.txtBoxAdres.Size = new System.Drawing.Size(326, 76);
            this.txtBoxAdres.TabIndex = 14;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(197, 282);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(326, 33);
            this.txtBoxEmail.TabIndex = 13;
            // 
            // txtBoxEvTelNo
            // 
            this.txtBoxEvTelNo.Location = new System.Drawing.Point(197, 202);
            this.txtBoxEvTelNo.Name = "txtBoxEvTelNo";
            this.txtBoxEvTelNo.Size = new System.Drawing.Size(326, 33);
            this.txtBoxEvTelNo.TabIndex = 12;
            // 
            // txtBoxCepTelNo
            // 
            this.txtBoxCepTelNo.Location = new System.Drawing.Point(197, 162);
            this.txtBoxCepTelNo.Name = "txtBoxCepTelNo";
            this.txtBoxCepTelNo.Size = new System.Drawing.Size(326, 33);
            this.txtBoxCepTelNo.TabIndex = 11;
            // 
            // txtBoxAdSoyad
            // 
            this.txtBoxAdSoyad.Location = new System.Drawing.Point(197, 122);
            this.txtBoxAdSoyad.Name = "txtBoxAdSoyad";
            this.txtBoxAdSoyad.Size = new System.Drawing.Size(326, 33);
            this.txtBoxAdSoyad.TabIndex = 10;
            // 
            // txtBoxTcNo
            // 
            this.txtBoxTcNo.Location = new System.Drawing.Point(197, 82);
            this.txtBoxTcNo.Name = "txtBoxTcNo";
            this.txtBoxTcNo.Size = new System.Drawing.Size(326, 33);
            this.txtBoxTcNo.TabIndex = 9;
            // 
            // txtBoxMusteriNo
            // 
            this.txtBoxMusteriNo.Location = new System.Drawing.Point(197, 42);
            this.txtBoxMusteriNo.Name = "txtBoxMusteriNo";
            this.txtBoxMusteriNo.Size = new System.Drawing.Size(244, 33);
            this.txtBoxMusteriNo.TabIndex = 8;
            this.txtBoxMusteriNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxMusteriNo_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(116, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 26);
            this.label15.TabIndex = 7;
            this.label15.Text = "Adres :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(111, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 26);
            this.label14.TabIndex = 6;
            this.label14.Text = "E-mail :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 26);
            this.label13.TabIndex = 5;
            this.label13.Text = "Cinsiyet :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 26);
            this.label12.TabIndex = 4;
            this.label12.Text = "Ev Telefonu :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(48, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cep Telefonu :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ad Soyad :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "TC Kimlik No :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Müşteri Numarası :";
            // 
            // picBoxMenuDonRezervasyon
            // 
            this.picBoxMenuDonRezervasyon.BackColor = System.Drawing.Color.Transparent;
            this.picBoxMenuDonRezervasyon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxMenuDonRezervasyon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMenuDonRezervasyon.Image = global::HavaalaniTakipOtomasyonu.Properties.Resources.sadedonus;
            this.picBoxMenuDonRezervasyon.Location = new System.Drawing.Point(1112, 612);
            this.picBoxMenuDonRezervasyon.Name = "picBoxMenuDonRezervasyon";
            this.picBoxMenuDonRezervasyon.Size = new System.Drawing.Size(80, 80);
            this.picBoxMenuDonRezervasyon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMenuDonRezervasyon.TabIndex = 1;
            this.picBoxMenuDonRezervasyon.TabStop = false;
            this.picBoxMenuDonRezervasyon.Click += new System.EventHandler(this.picBoxMenuDonRezervasyon_Click);
            // 
            // rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HavaalaniTakipOtomasyonu.Properties.Resources.rezervasyonArka;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.picBoxMenuDonRezervasyon);
            this.Controls.Add(this.grpBoxUcusBilgi);
            this.Controls.Add(this.grpBoxMusteriBilgi);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "rezervasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rezervasyon";
            this.Load += new System.EventHandler(this.rezervasyon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCikisRezervasyon)).EndInit();
            this.grpBoxUcusBilgi.ResumeLayout(false);
            this.grpBoxUcusBilgi.PerformLayout();
            this.grpBoxMusteriBilgi.ResumeLayout(false);
            this.grpBoxMusteriBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenuDonRezervasyon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpBoxUcusBilgi;
        private System.Windows.Forms.GroupBox grpBoxMusteriBilgi;
        private System.Windows.Forms.PictureBox picBoxCikisRezervasyon;
        private System.Windows.Forms.LinkLabel llbRezervasyon;
        private System.Windows.Forms.LinkLabel llbMenu;
        private System.Windows.Forms.Label lblKullaniciAdiRezervasyon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxMenuDonRezervasyon;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.DateTimePicker dtpGidisTarihi;
        private System.Windows.Forms.ComboBox cmbBoxSaatVeTarih;
        private System.Windows.Forms.ComboBox cmbBoxInısHavaalani;
        private System.Windows.Forms.ComboBox cmbBoxKalkisHavaalani;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnRezerveYap;
        private System.Windows.Forms.Button btnMusteriBul;
        private System.Windows.Forms.ComboBox cmbBoxCinsiyet;
        private System.Windows.Forms.TextBox txtBoxAdres;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxEvTelNo;
        private System.Windows.Forms.TextBox txtBoxCepTelNo;
        private System.Windows.Forms.TextBox txtBoxAdSoyad;
        private System.Windows.Forms.TextBox txtBoxTcNo;
        private System.Windows.Forms.TextBox txtBoxMusteriNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}