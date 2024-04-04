namespace HavaalaniTakipOtomasyonu
{
    partial class Form1
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
            this.picBoxCikis = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtBoxParola = new System.Windows.Forms.TextBox();
            this.chkBoxParolaGoster = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.llbParolaUnuttum = new System.Windows.Forms.LinkLabel();
            this.radioBtnPersonel = new System.Windows.Forms.RadioButton();
            this.radioBtnAdmin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDenemeKalan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCikis
            // 
            this.picBoxCikis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCikis.Image = global::HavaalaniTakipOtomasyonu.Properties.Resources.kapama;
            this.picBoxCikis.Location = new System.Drawing.Point(536, 8);
            this.picBoxCikis.Name = "picBoxCikis";
            this.picBoxCikis.Size = new System.Drawing.Size(40, 40);
            this.picBoxCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCikis.TabIndex = 0;
            this.picBoxCikis.TabStop = false;
            this.picBoxCikis.Click += new System.EventHandler(this.picBoxCikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(125, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uçak Bileti Otomasyonu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::HavaalaniTakipOtomasyonu.Properties.Resources.giriskilit;
            this.pictureBox2.Location = new System.Drawing.Point(167, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(149, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola :";
            // 
            // txtBoxKullaniciAdi
            // 
            this.txtBoxKullaniciAdi.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxKullaniciAdi.Location = new System.Drawing.Point(238, 354);
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Size = new System.Drawing.Size(181, 33);
            this.txtBoxKullaniciAdi.TabIndex = 5;
            // 
            // txtBoxParola
            // 
            this.txtBoxParola.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBoxParola.Location = new System.Drawing.Point(238, 402);
            this.txtBoxParola.Name = "txtBoxParola";
            this.txtBoxParola.PasswordChar = '*';
            this.txtBoxParola.Size = new System.Drawing.Size(181, 33);
            this.txtBoxParola.TabIndex = 6;
            // 
            // chkBoxParolaGoster
            // 
            this.chkBoxParolaGoster.AutoSize = true;
            this.chkBoxParolaGoster.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxParolaGoster.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBoxParolaGoster.Location = new System.Drawing.Point(406, 441);
            this.chkBoxParolaGoster.Name = "chkBoxParolaGoster";
            this.chkBoxParolaGoster.Size = new System.Drawing.Size(176, 30);
            this.chkBoxParolaGoster.TabIndex = 7;
            this.chkBoxParolaGoster.Text = "Parolamı Göster";
            this.chkBoxParolaGoster.UseVisualStyleBackColor = false;
            this.chkBoxParolaGoster.CheckedChanged += new System.EventHandler(this.chkBoxParolaGoster_CheckedChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(406, 538);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(138, 40);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // llbParolaUnuttum
            // 
            this.llbParolaUnuttum.AutoSize = true;
            this.llbParolaUnuttum.BackColor = System.Drawing.Color.Transparent;
            this.llbParolaUnuttum.Cursor = System.Windows.Forms.Cursors.Help;
            this.llbParolaUnuttum.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llbParolaUnuttum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.llbParolaUnuttum.LinkColor = System.Drawing.Color.PowderBlue;
            this.llbParolaUnuttum.Location = new System.Drawing.Point(12, 553);
            this.llbParolaUnuttum.Name = "llbParolaUnuttum";
            this.llbParolaUnuttum.Size = new System.Drawing.Size(195, 28);
            this.llbParolaUnuttum.TabIndex = 9;
            this.llbParolaUnuttum.TabStop = true;
            this.llbParolaUnuttum.Text = "Parolamı Unuttum";
            this.llbParolaUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbParolaUnuttum_LinkClicked);
            // 
            // radioBtnPersonel
            // 
            this.radioBtnPersonel.AutoSize = true;
            this.radioBtnPersonel.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnPersonel.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnPersonel.Location = new System.Drawing.Point(127, 455);
            this.radioBtnPersonel.Name = "radioBtnPersonel";
            this.radioBtnPersonel.Size = new System.Drawing.Size(107, 31);
            this.radioBtnPersonel.TabIndex = 10;
            this.radioBtnPersonel.TabStop = true;
            this.radioBtnPersonel.Text = "Personel";
            this.radioBtnPersonel.UseVisualStyleBackColor = false;
            // 
            // radioBtnAdmin
            // 
            this.radioBtnAdmin.AutoSize = true;
            this.radioBtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radioBtnAdmin.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnAdmin.Location = new System.Drawing.Point(240, 455);
            this.radioBtnAdmin.Name = "radioBtnAdmin";
            this.radioBtnAdmin.Size = new System.Drawing.Size(94, 31);
            this.radioBtnAdmin.TabIndex = 11;
            this.radioBtnAdmin.TabStop = true;
            this.radioBtnAdmin.Text = "Admin";
            this.radioBtnAdmin.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kalan Deneme:";
            // 
            // lblDenemeKalan
            // 
            this.lblDenemeKalan.AutoSize = true;
            this.lblDenemeKalan.BackColor = System.Drawing.Color.Transparent;
            this.lblDenemeKalan.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDenemeKalan.ForeColor = System.Drawing.Color.Red;
            this.lblDenemeKalan.Location = new System.Drawing.Point(157, 499);
            this.lblDenemeKalan.Name = "lblDenemeKalan";
            this.lblDenemeKalan.Size = new System.Drawing.Size(77, 26);
            this.lblDenemeKalan.TabIndex = 13;
            this.lblDenemeKalan.Text = "lblkalan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HavaalaniTakipOtomasyonu.Properties.Resources.arkaplann;
            this.ClientSize = new System.Drawing.Size(585, 590);
            this.Controls.Add(this.lblDenemeKalan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioBtnAdmin);
            this.Controls.Add(this.radioBtnPersonel);
            this.Controls.Add(this.llbParolaUnuttum);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.chkBoxParolaGoster);
            this.Controls.Add(this.txtBoxParola);
            this.Controls.Add(this.txtBoxKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxCikis);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.TextBox txtBoxParola;
        private System.Windows.Forms.CheckBox chkBoxParolaGoster;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel llbParolaUnuttum;
        private System.Windows.Forms.RadioButton radioBtnPersonel;
        private System.Windows.Forms.RadioButton radioBtnAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDenemeKalan;
    }
}

