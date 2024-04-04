namespace HavaalaniTakipOtomasyonu
{
    partial class raporlar
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeHavaalaniDataSet = new HavaalaniTakipOtomasyonu.projeHavaalaniDataSet();
            this.biletlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeHavaalaniDataSet1 = new HavaalaniTakipOtomasyonu.projeHavaalaniDataSet1();
            this.seferlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projeHavaalaniDataSet2 = new HavaalaniTakipOtomasyonu.projeHavaalaniDataSet2();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.llbRaporlama = new System.Windows.Forms.LinkLabel();
            this.llbMenu = new System.Windows.Forms.LinkLabel();
            this.lblKullaniciAdiRaporlama = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musterilerTableAdapter = new HavaalaniTakipOtomasyonu.projeHavaalaniDataSetTableAdapters.musterilerTableAdapter();
            this.biletlerTableAdapter = new HavaalaniTakipOtomasyonu.projeHavaalaniDataSet1TableAdapters.biletlerTableAdapter();
            this.seferlerTableAdapter = new HavaalaniTakipOtomasyonu.projeHavaalaniDataSet2TableAdapters.seferlerTableAdapter();
            this.picBoxMenuDonRaporlama = new System.Windows.Forms.PictureBox();
            this.picBoxCikisRaporlama = new System.Windows.Forms.PictureBox();
            this.tabPageMusteri = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblErkekSayisi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKadinSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewerMusteri = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPageBilet = new System.Windows.Forms.TabPage();
            this.reportViewerBilet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPageSefer = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeHavaalaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeHavaalaniDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeHavaalaniDataSet2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenuDonRaporlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCikisRaporlama)).BeginInit();
            this.tabPageMusteri.SuspendLayout();
            this.tabPageBilet.SuspendLayout();
            this.tabPageSefer.SuspendLayout();
            this.SuspendLayout();
            // 
            // musterilerBindingSource
            // 
            this.musterilerBindingSource.DataMember = "musteriler";
            this.musterilerBindingSource.DataSource = this.projeHavaalaniDataSet;
            // 
            // projeHavaalaniDataSet
            // 
            this.projeHavaalaniDataSet.DataSetName = "projeHavaalaniDataSet";
            this.projeHavaalaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // biletlerBindingSource
            // 
            this.biletlerBindingSource.DataMember = "biletler";
            this.biletlerBindingSource.DataSource = this.projeHavaalaniDataSet1;
            // 
            // projeHavaalaniDataSet1
            // 
            this.projeHavaalaniDataSet1.DataSetName = "projeHavaalaniDataSet1";
            this.projeHavaalaniDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seferlerBindingSource
            // 
            this.seferlerBindingSource.DataMember = "seferler";
            this.seferlerBindingSource.DataSource = this.projeHavaalaniDataSet2;
            // 
            // projeHavaalaniDataSet2
            // 
            this.projeHavaalaniDataSet2.DataSetName = "projeHavaalaniDataSet2";
            this.projeHavaalaniDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMusteri);
            this.tabControl1.Controls.Add(this.tabPageBilet);
            this.tabControl1.Controls.Add(this.tabPageSefer);
            this.tabControl1.Location = new System.Drawing.Point(0, 95);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1520, 750);
            this.tabControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picBoxMenuDonRaporlama);
            this.panel1.Controls.Add(this.picBoxCikisRaporlama);
            this.panel1.Controls.Add(this.llbRaporlama);
            this.panel1.Controls.Add(this.llbMenu);
            this.panel1.Controls.Add(this.lblKullaniciAdiRaporlama);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1520, 90);
            this.panel1.TabIndex = 1;
            // 
            // llbRaporlama
            // 
            this.llbRaporlama.AutoSize = true;
            this.llbRaporlama.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llbRaporlama.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.llbRaporlama.Location = new System.Drawing.Point(522, 43);
            this.llbRaporlama.Name = "llbRaporlama";
            this.llbRaporlama.Size = new System.Drawing.Size(119, 28);
            this.llbRaporlama.TabIndex = 5;
            this.llbRaporlama.TabStop = true;
            this.llbRaporlama.Text = "Raporlama";
            this.llbRaporlama.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbRaporlama_LinkClicked);
            // 
            // llbMenu
            // 
            this.llbMenu.AutoSize = true;
            this.llbMenu.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llbMenu.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.llbMenu.Location = new System.Drawing.Point(387, 43);
            this.llbMenu.Name = "llbMenu";
            this.llbMenu.Size = new System.Drawing.Size(72, 28);
            this.llbMenu.TabIndex = 4;
            this.llbMenu.TabStop = true;
            this.llbMenu.Text = "Menü";
            this.llbMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMenu_LinkClicked);
            // 
            // lblKullaniciAdiRaporlama
            // 
            this.lblKullaniciAdiRaporlama.AutoSize = true;
            this.lblKullaniciAdiRaporlama.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdiRaporlama.ForeColor = System.Drawing.Color.RosyBrown;
            this.lblKullaniciAdiRaporlama.Location = new System.Drawing.Point(1285, 18);
            this.lblKullaniciAdiRaporlama.Name = "lblKullaniciAdiRaporlama";
            this.lblKullaniciAdiRaporlama.Size = new System.Drawing.Size(72, 28);
            this.lblKullaniciAdiRaporlama.TabIndex = 3;
            this.lblKullaniciAdiRaporlama.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.Location = new System.Drawing.Point(1136, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hoşgeldiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(465, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "→";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Uçak Bileti Otomasyonu";
            // 
            // musterilerTableAdapter
            // 
            this.musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // biletlerTableAdapter
            // 
            this.biletlerTableAdapter.ClearBeforeFill = true;
            // 
            // seferlerTableAdapter
            // 
            this.seferlerTableAdapter.ClearBeforeFill = true;
            // 
            // picBoxMenuDonRaporlama
            // 
            this.picBoxMenuDonRaporlama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picBoxMenuDonRaporlama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxMenuDonRaporlama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMenuDonRaporlama.Image = global::HavaalaniTakipOtomasyonu.Properties.Resources.sadeGeriDonMinik;
            this.picBoxMenuDonRaporlama.Location = new System.Drawing.Point(1416, 12);
            this.picBoxMenuDonRaporlama.Name = "picBoxMenuDonRaporlama";
            this.picBoxMenuDonRaporlama.Size = new System.Drawing.Size(40, 40);
            this.picBoxMenuDonRaporlama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMenuDonRaporlama.TabIndex = 7;
            this.picBoxMenuDonRaporlama.TabStop = false;
            this.picBoxMenuDonRaporlama.Click += new System.EventHandler(this.picBoxMenuDonRaporlama_Click);
            // 
            // picBoxCikisRaporlama
            // 
            this.picBoxCikisRaporlama.BackColor = System.Drawing.Color.Silver;
            this.picBoxCikisRaporlama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxCikisRaporlama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCikisRaporlama.Image = global::HavaalaniTakipOtomasyonu.Properties.Resources.kapama;
            this.picBoxCikisRaporlama.Location = new System.Drawing.Point(1468, 12);
            this.picBoxCikisRaporlama.Name = "picBoxCikisRaporlama";
            this.picBoxCikisRaporlama.Size = new System.Drawing.Size(40, 40);
            this.picBoxCikisRaporlama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCikisRaporlama.TabIndex = 6;
            this.picBoxCikisRaporlama.TabStop = false;
            this.picBoxCikisRaporlama.Click += new System.EventHandler(this.picBoxCikisRaporlama_Click);
            // 
            // tabPageMusteri
            // 
            this.tabPageMusteri.BackgroundImage = global::HavaalaniTakipOtomasyonu.Properties.Resources.musteriRaporArka;
            this.tabPageMusteri.Controls.Add(this.button1);
            this.tabPageMusteri.Controls.Add(this.lblErkekSayisi);
            this.tabPageMusteri.Controls.Add(this.label6);
            this.tabPageMusteri.Controls.Add(this.lblKadinSayisi);
            this.tabPageMusteri.Controls.Add(this.label4);
            this.tabPageMusteri.Controls.Add(this.reportViewerMusteri);
            this.tabPageMusteri.Location = new System.Drawing.Point(4, 35);
            this.tabPageMusteri.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMusteri.Name = "tabPageMusteri";
            this.tabPageMusteri.Size = new System.Drawing.Size(1512, 711);
            this.tabPageMusteri.TabIndex = 0;
            this.tabPageMusteri.Text = "Müşteri Raporları";
            this.tabPageMusteri.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(161)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1286, 647);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Diğer İstatistikler →";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblErkekSayisi
            // 
            this.lblErkekSayisi.AutoSize = true;
            this.lblErkekSayisi.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblErkekSayisi.ForeColor = System.Drawing.Color.White;
            this.lblErkekSayisi.Location = new System.Drawing.Point(1064, 650);
            this.lblErkekSayisi.Name = "lblErkekSayisi";
            this.lblErkekSayisi.Size = new System.Drawing.Size(79, 32);
            this.lblErkekSayisi.TabIndex = 4;
            this.lblErkekSayisi.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(161)))));
            this.label6.Location = new System.Drawing.Point(802, 650);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Erkek Müşteri Sayısı :";
            // 
            // lblKadinSayisi
            // 
            this.lblKadinSayisi.AutoSize = true;
            this.lblKadinSayisi.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKadinSayisi.ForeColor = System.Drawing.Color.White;
            this.lblKadinSayisi.Location = new System.Drawing.Point(488, 650);
            this.lblKadinSayisi.Name = "lblKadinSayisi";
            this.lblKadinSayisi.Size = new System.Drawing.Size(79, 32);
            this.lblKadinSayisi.TabIndex = 2;
            this.lblKadinSayisi.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(55)))));
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(199)))), ((int)(((byte)(161)))));
            this.label4.Location = new System.Drawing.Point(226, 650);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kadın Müşteri Sayısı :";
            // 
            // reportViewerMusteri
            // 
            reportDataSource4.Name = "DataSetMusteri";
            reportDataSource4.Value = this.musterilerBindingSource;
            this.reportViewerMusteri.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewerMusteri.LocalReport.ReportEmbeddedResource = "HavaalaniTakipOtomasyonu.musteriRapor.rdlc";
            this.reportViewerMusteri.Location = new System.Drawing.Point(106, 15);
            this.reportViewerMusteri.Name = "reportViewerMusteri";
            this.reportViewerMusteri.ServerReport.BearerToken = null;
            this.reportViewerMusteri.Size = new System.Drawing.Size(1300, 600);
            this.reportViewerMusteri.TabIndex = 0;
            this.reportViewerMusteri.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // tabPageBilet
            // 
            this.tabPageBilet.BackgroundImage = global::HavaalaniTakipOtomasyonu.Properties.Resources.biletRaporArka;
            this.tabPageBilet.Controls.Add(this.reportViewerBilet);
            this.tabPageBilet.Location = new System.Drawing.Point(4, 22);
            this.tabPageBilet.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageBilet.Name = "tabPageBilet";
            this.tabPageBilet.Size = new System.Drawing.Size(1512, 724);
            this.tabPageBilet.TabIndex = 1;
            this.tabPageBilet.Text = "Bilet Raporları";
            this.tabPageBilet.UseVisualStyleBackColor = true;
            // 
            // reportViewerBilet
            // 
            reportDataSource5.Name = "DataSetbilet";
            reportDataSource5.Value = this.biletlerBindingSource;
            this.reportViewerBilet.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerBilet.LocalReport.ReportEmbeddedResource = "HavaalaniTakipOtomasyonu.biletRapor.rdlc";
            this.reportViewerBilet.Location = new System.Drawing.Point(106, 15);
            this.reportViewerBilet.Name = "reportViewerBilet";
            this.reportViewerBilet.ServerReport.BearerToken = null;
            this.reportViewerBilet.Size = new System.Drawing.Size(1300, 600);
            this.reportViewerBilet.TabIndex = 0;
            this.reportViewerBilet.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // tabPageSefer
            // 
            this.tabPageSefer.BackgroundImage = global::HavaalaniTakipOtomasyonu.Properties.Resources.seferRaporArkafoto;
            this.tabPageSefer.Controls.Add(this.reportViewer1);
            this.tabPageSefer.Location = new System.Drawing.Point(4, 22);
            this.tabPageSefer.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageSefer.Name = "tabPageSefer";
            this.tabPageSefer.Size = new System.Drawing.Size(1512, 724);
            this.tabPageSefer.TabIndex = 2;
            this.tabPageSefer.Text = "Sefer Raporları";
            this.tabPageSefer.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.seferlerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HavaalaniTakipOtomasyonu.seferRapor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(106, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1300, 600);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // raporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1520, 845);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "raporlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "raporlar";
            this.Load += new System.EventHandler(this.raporlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeHavaalaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biletlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeHavaalaniDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seferlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projeHavaalaniDataSet2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMenuDonRaporlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCikisRaporlama)).EndInit();
            this.tabPageMusteri.ResumeLayout(false);
            this.tabPageMusteri.PerformLayout();
            this.tabPageBilet.ResumeLayout(false);
            this.tabPageSefer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMusteri;
        private System.Windows.Forms.TabPage tabPageBilet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageSefer;
        private System.Windows.Forms.PictureBox picBoxCikisRaporlama;
        private System.Windows.Forms.LinkLabel llbRaporlama;
        private System.Windows.Forms.LinkLabel llbMenu;
        private System.Windows.Forms.Label lblKullaniciAdiRaporlama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxMenuDonRaporlama;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMusteri;
        private System.Windows.Forms.BindingSource musterilerBindingSource;
        private projeHavaalaniDataSet projeHavaalaniDataSet;
        private projeHavaalaniDataSetTableAdapters.musterilerTableAdapter musterilerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBilet;
        private System.Windows.Forms.BindingSource biletlerBindingSource;
        private projeHavaalaniDataSet1 projeHavaalaniDataSet1;
        private projeHavaalaniDataSet1TableAdapters.biletlerTableAdapter biletlerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource seferlerBindingSource;
        private projeHavaalaniDataSet2 projeHavaalaniDataSet2;
        private projeHavaalaniDataSet2TableAdapters.seferlerTableAdapter seferlerTableAdapter;
        private System.Windows.Forms.Label lblErkekSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblKadinSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}