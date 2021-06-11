
namespace SaydamHayvanBakımEviV1
{
    partial class PersonelEkleDuzenle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tabPersonelEkleDuzenle = new System.Windows.Forms.TabControl();
            this.tabPagePersonelGoruntuleme = new System.Windows.Forms.TabPage();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cmbUnvan = new System.Windows.Forms.ComboBox();
            this.dtKayitTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblKayitTarihi = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageYeniPersonelEkleme = new System.Windows.Forms.TabPage();
            this.cmbSaveUnvan = new System.Windows.Forms.ComboBox();
            this.btnSaveSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSaveSifre = new System.Windows.Forms.TextBox();
            this.txtSaveKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtSaveTCKimlikNo = new System.Windows.Forms.TextBox();
            this.txtSaveAdSoyadi = new System.Windows.Forms.TextBox();
            this.lblSaveUnvan = new System.Windows.Forms.Label();
            this.lblSaveSifre = new System.Windows.Forms.Label();
            this.lblSaveKullaniciAdi = new System.Windows.Forms.Label();
            this.lblSaveTCKimlikNo = new System.Windows.Forms.Label();
            this.lblSaveAdi = new System.Windows.Forms.Label();
            this.tabPersonelEkleDuzenle.SuspendLayout();
            this.tabPagePersonelGoruntuleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageYeniPersonelEkleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBaslik.Location = new System.Drawing.Point(450, 39);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(753, 37);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "PERSONEL GÖRÜNTÜLEME GÜNCELLEME VE EKLEME EKRANI";
            // 
            // tabPersonelEkleDuzenle
            // 
            this.tabPersonelEkleDuzenle.Controls.Add(this.tabPagePersonelGoruntuleme);
            this.tabPersonelEkleDuzenle.Controls.Add(this.tabPageYeniPersonelEkleme);
            this.tabPersonelEkleDuzenle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPersonelEkleDuzenle.Location = new System.Drawing.Point(244, 148);
            this.tabPersonelEkleDuzenle.Name = "tabPersonelEkleDuzenle";
            this.tabPersonelEkleDuzenle.SelectedIndex = 0;
            this.tabPersonelEkleDuzenle.Size = new System.Drawing.Size(1355, 764);
            this.tabPersonelEkleDuzenle.TabIndex = 1;
            // 
            // tabPagePersonelGoruntuleme
            // 
            this.tabPagePersonelGoruntuleme.BackColor = System.Drawing.Color.Thistle;
            this.tabPagePersonelGoruntuleme.Controls.Add(this.btnSil);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.btnGuncelle);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.cmbUnvan);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.dtKayitTarihi);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.txtSifre);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.txtKullaniciAdi);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.txtTCKimlikNo);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.txtAdiSoyadi);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.txtId);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.lblUnvan);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.lblSifre);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.lblKullaniciAdi);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.lblTCNo);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.lblKayitTarihi);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.lblAd);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.lblId);
            this.tabPagePersonelGoruntuleme.Controls.Add(this.dataGridView1);
            this.tabPagePersonelGoruntuleme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPagePersonelGoruntuleme.Location = new System.Drawing.Point(4, 30);
            this.tabPagePersonelGoruntuleme.Name = "tabPagePersonelGoruntuleme";
            this.tabPagePersonelGoruntuleme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonelGoruntuleme.Size = new System.Drawing.Size(1347, 730);
            this.tabPagePersonelGoruntuleme.TabIndex = 0;
            this.tabPagePersonelGoruntuleme.Text = "Görüntüleme/Düzeltme";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSil.Location = new System.Drawing.Point(1144, 142);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 48);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "Personeli Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuncelle.Location = new System.Drawing.Point(953, 141);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(163, 49);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Bilgileri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cmbUnvan
            // 
            this.cmbUnvan.FormattingEnabled = true;
            this.cmbUnvan.Location = new System.Drawing.Point(1030, 32);
            this.cmbUnvan.Name = "cmbUnvan";
            this.cmbUnvan.Size = new System.Drawing.Size(246, 29);
            this.cmbUnvan.TabIndex = 15;
            // 
            // dtKayitTarihi
            // 
            this.dtKayitTarihi.Location = new System.Drawing.Point(648, 32);
            this.dtKayitTarihi.Name = "dtKayitTarihi";
            this.dtKayitTarihi.Size = new System.Drawing.Size(245, 29);
            this.dtKayitTarihi.TabIndex = 14;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(161, 181);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(246, 29);
            this.txtSifre.TabIndex = 13;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(647, 176);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(246, 29);
            this.txtKullaniciAdi.TabIndex = 12;
            // 
            // txtTCKimlikNo
            // 
            this.txtTCKimlikNo.Location = new System.Drawing.Point(647, 100);
            this.txtTCKimlikNo.Name = "txtTCKimlikNo";
            this.txtTCKimlikNo.Size = new System.Drawing.Size(246, 29);
            this.txtTCKimlikNo.TabIndex = 11;
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(161, 103);
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(246, 29);
            this.txtAdiSoyadi.TabIndex = 10;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(161, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(246, 29);
            this.txtId.TabIndex = 9;
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(964, 35);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(55, 21);
            this.lblUnvan.TabIndex = 8;
            this.lblUnvan.Text = "YETKİ :";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(83, 184);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(60, 21);
            this.lblSifre.TabIndex = 7;
            this.lblSifre.Text = "ŞİFRE : ";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(518, 181);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(122, 21);
            this.lblKullaniciAdi.TabIndex = 6;
            this.lblKullaniciAdi.Text = "KULLANICI ADI :";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Location = new System.Drawing.Point(531, 103);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(110, 21);
            this.lblTCNo.TabIndex = 5;
            this.lblTCNo.Text = "TC KİMLİK NO:";
            // 
            // lblKayitTarihi
            // 
            this.lblKayitTarihi.AutoSize = true;
            this.lblKayitTarihi.Location = new System.Drawing.Point(535, 36);
            this.lblKayitTarihi.Name = "lblKayitTarihi";
            this.lblKayitTarihi.Size = new System.Drawing.Size(106, 21);
            this.lblKayitTarihi.TabIndex = 4;
            this.lblKayitTarihi.Text = "KAYIT TARİHİ :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(43, 111);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(100, 21);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "ADI SOYADI :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(111, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 21);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1341, 392);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabPageYeniPersonelEkleme
            // 
            this.tabPageYeniPersonelEkleme.BackColor = System.Drawing.Color.Thistle;
            this.tabPageYeniPersonelEkleme.Controls.Add(this.cmbSaveUnvan);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.btnSaveSil);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.btnKaydet);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.txtSaveSifre);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.txtSaveKullaniciAdi);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.txtSaveTCKimlikNo);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.txtSaveAdSoyadi);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.lblSaveUnvan);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.lblSaveSifre);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.lblSaveKullaniciAdi);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.lblSaveTCKimlikNo);
            this.tabPageYeniPersonelEkleme.Controls.Add(this.lblSaveAdi);
            this.tabPageYeniPersonelEkleme.Location = new System.Drawing.Point(4, 30);
            this.tabPageYeniPersonelEkleme.Name = "tabPageYeniPersonelEkleme";
            this.tabPageYeniPersonelEkleme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYeniPersonelEkleme.Size = new System.Drawing.Size(1347, 730);
            this.tabPageYeniPersonelEkleme.TabIndex = 1;
            this.tabPageYeniPersonelEkleme.Text = "Yeni Personel Ekle";
            // 
            // cmbSaveUnvan
            // 
            this.cmbSaveUnvan.FormattingEnabled = true;
            this.cmbSaveUnvan.Location = new System.Drawing.Point(582, 325);
            this.cmbSaveUnvan.Name = "cmbSaveUnvan";
            this.cmbSaveUnvan.Size = new System.Drawing.Size(273, 29);
            this.cmbSaveUnvan.TabIndex = 18;
            // 
            // btnSaveSil
            // 
            this.btnSaveSil.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSaveSil.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveSil.Location = new System.Drawing.Point(682, 491);
            this.btnSaveSil.Name = "btnSaveSil";
            this.btnSaveSil.Size = new System.Drawing.Size(173, 48);
            this.btnSaveSil.TabIndex = 17;
            this.btnSaveSil.Text = "EKRANI TEMİZLE";
            this.btnSaveSil.UseVisualStyleBackColor = false;
            this.btnSaveSil.Click += new System.EventHandler(this.btnSaveSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.SpringGreen;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKaydet.Location = new System.Drawing.Point(467, 491);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(175, 48);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "KAYDET ";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSaveSifre
            // 
            this.txtSaveSifre.Location = new System.Drawing.Point(582, 268);
            this.txtSaveSifre.Name = "txtSaveSifre";
            this.txtSaveSifre.Size = new System.Drawing.Size(273, 29);
            this.txtSaveSifre.TabIndex = 14;
            // 
            // txtSaveKullaniciAdi
            // 
            this.txtSaveKullaniciAdi.Location = new System.Drawing.Point(582, 210);
            this.txtSaveKullaniciAdi.Name = "txtSaveKullaniciAdi";
            this.txtSaveKullaniciAdi.Size = new System.Drawing.Size(273, 29);
            this.txtSaveKullaniciAdi.TabIndex = 13;
            // 
            // txtSaveTCKimlikNo
            // 
            this.txtSaveTCKimlikNo.Location = new System.Drawing.Point(582, 146);
            this.txtSaveTCKimlikNo.Name = "txtSaveTCKimlikNo";
            this.txtSaveTCKimlikNo.Size = new System.Drawing.Size(273, 29);
            this.txtSaveTCKimlikNo.TabIndex = 12;
            // 
            // txtSaveAdSoyadi
            // 
            this.txtSaveAdSoyadi.Location = new System.Drawing.Point(582, 86);
            this.txtSaveAdSoyadi.Name = "txtSaveAdSoyadi";
            this.txtSaveAdSoyadi.Size = new System.Drawing.Size(273, 29);
            this.txtSaveAdSoyadi.TabIndex = 10;
            // 
            // lblSaveUnvan
            // 
            this.lblSaveUnvan.AutoSize = true;
            this.lblSaveUnvan.Location = new System.Drawing.Point(467, 328);
            this.lblSaveUnvan.Name = "lblSaveUnvan";
            this.lblSaveUnvan.Size = new System.Drawing.Size(92, 21);
            this.lblSaveUnvan.TabIndex = 5;
            this.lblSaveUnvan.Text = "POZİSYON :";
            // 
            // lblSaveSifre
            // 
            this.lblSaveSifre.AutoSize = true;
            this.lblSaveSifre.Location = new System.Drawing.Point(503, 271);
            this.lblSaveSifre.Name = "lblSaveSifre";
            this.lblSaveSifre.Size = new System.Drawing.Size(56, 21);
            this.lblSaveSifre.TabIndex = 4;
            this.lblSaveSifre.Text = "ŞİFRE :";
            // 
            // lblSaveKullaniciAdi
            // 
            this.lblSaveKullaniciAdi.AutoSize = true;
            this.lblSaveKullaniciAdi.Location = new System.Drawing.Point(437, 213);
            this.lblSaveKullaniciAdi.Name = "lblSaveKullaniciAdi";
            this.lblSaveKullaniciAdi.Size = new System.Drawing.Size(122, 21);
            this.lblSaveKullaniciAdi.TabIndex = 3;
            this.lblSaveKullaniciAdi.Text = "KULLANICI ADI :";
            // 
            // lblSaveTCKimlikNo
            // 
            this.lblSaveTCKimlikNo.AutoSize = true;
            this.lblSaveTCKimlikNo.Location = new System.Drawing.Point(445, 154);
            this.lblSaveTCKimlikNo.Name = "lblSaveTCKimlikNo";
            this.lblSaveTCKimlikNo.Size = new System.Drawing.Size(114, 21);
            this.lblSaveTCKimlikNo.TabIndex = 2;
            this.lblSaveTCKimlikNo.Text = "TC KİMLİK NO :";
            // 
            // lblSaveAdi
            // 
            this.lblSaveAdi.AutoSize = true;
            this.lblSaveAdi.Location = new System.Drawing.Point(463, 89);
            this.lblSaveAdi.Name = "lblSaveAdi";
            this.lblSaveAdi.Size = new System.Drawing.Size(96, 21);
            this.lblSaveAdi.TabIndex = 0;
            this.lblSaveAdi.Text = "ADI SOYADI:";
            // 
            // PersonelEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1801, 1029);
            this.Controls.Add(this.tabPersonelEkleDuzenle);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonelEkleDuzenle";
            this.Text = "PersonelEkleDuzenle";
            this.Load += new System.EventHandler(this.PersonelEkleDuzenle_Load);
            this.tabPersonelEkleDuzenle.ResumeLayout(false);
            this.tabPagePersonelGoruntuleme.ResumeLayout(false);
            this.tabPagePersonelGoruntuleme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageYeniPersonelEkleme.ResumeLayout(false);
            this.tabPageYeniPersonelEkleme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TabControl tabPersonelEkleDuzenle;
        private System.Windows.Forms.TabPage tabPagePersonelGoruntuleme;
        private System.Windows.Forms.TabPage tabPageYeniPersonelEkleme;
        private System.Windows.Forms.ComboBox cmbUnvan;
        private System.Windows.Forms.DateTimePicker dtKayitTarihi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtTCKimlikNo;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblKayitTarihi;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtSaveSifre;
        private System.Windows.Forms.TextBox txtSaveKullaniciAdi;
        private System.Windows.Forms.TextBox txtSaveTCKimlikNo;
        private System.Windows.Forms.TextBox txtSaveAdSoyadi;
        private System.Windows.Forms.Label lblSaveUnvan;
        private System.Windows.Forms.Label lblSaveSifre;
        private System.Windows.Forms.Label lblSaveKullaniciAdi;
        private System.Windows.Forms.Label lblSaveTCKimlikNo;
        private System.Windows.Forms.Label lblSaveAdi;
        private System.Windows.Forms.Button btnSaveSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cmbSaveUnvan;
    }
}