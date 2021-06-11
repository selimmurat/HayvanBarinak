
using System.Drawing;
using System.Windows.Forms;

namespace SaydamHayvanBakımEviV1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblpanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblKusSayisi = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblKediSayisi = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblKopekSayisi = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblAsiSayisi = new System.Windows.Forms.Label();
            this.labellToplamAsiSayisi = new System.Windows.Forms.Label();
            this.lblSon1Hafta = new System.Windows.Forms.Label();
            this.lblhafta = new System.Windows.Forms.Label();
            this.lblHayvanSayisi = new System.Windows.Forms.Label();
            this.lblHyvLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSahiplendirme = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAsiTakip = new System.Windows.Forms.Button();
            this.btnHayvanBilgileri = new System.Windows.Forms.Button();
            this.btnHayvanKayit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.lblpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblpanel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 1041);
            this.panel1.TabIndex = 0;
            // 
            // lblpanel
            // 
            this.lblpanel.BackColor = System.Drawing.Color.BlueViolet;
            this.lblpanel.Controls.Add(this.dataGridView1);
            this.lblpanel.Controls.Add(this.panel4);
            this.lblpanel.Controls.Add(this.panel5);
            this.lblpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblpanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblpanel.Location = new System.Drawing.Point(228, 0);
            this.lblpanel.Name = "lblpanel";
            this.lblpanel.Size = new System.Drawing.Size(1676, 1041);
            this.lblpanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.BlueViolet;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(46, 357);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 45;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1517, 577);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel4.Controls.Add(this.lblKusSayisi);
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.lblKediSayisi);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.lblKopekSayisi);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(1036, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 196);
            this.panel4.TabIndex = 1;
            // 
            // lblKusSayisi
            // 
            this.lblKusSayisi.AutoSize = true;
            this.lblKusSayisi.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblKusSayisi.Location = new System.Drawing.Point(347, 134);
            this.lblKusSayisi.Name = "lblKusSayisi";
            this.lblKusSayisi.Size = new System.Drawing.Size(51, 20);
            this.lblKusSayisi.TabIndex = 5;
            this.lblKusSayisi.Text = "label4";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(313, 16);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(91, 92);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // lblKediSayisi
            // 
            this.lblKediSayisi.AutoSize = true;
            this.lblKediSayisi.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblKediSayisi.Location = new System.Drawing.Point(201, 134);
            this.lblKediSayisi.Name = "lblKediSayisi";
            this.lblKediSayisi.Size = new System.Drawing.Size(51, 20);
            this.lblKediSayisi.TabIndex = 3;
            this.lblKediSayisi.Text = "label3";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(176, 16);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(91, 84);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // lblKopekSayisi
            // 
            this.lblKopekSayisi.AutoSize = true;
            this.lblKopekSayisi.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblKopekSayisi.Location = new System.Drawing.Point(54, 134);
            this.lblKopekSayisi.Name = "lblKopekSayisi";
            this.lblKopekSayisi.Size = new System.Drawing.Size(51, 20);
            this.lblKopekSayisi.TabIndex = 1;
            this.lblKopekSayisi.Text = "label2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lblSon1Hafta);
            this.panel5.Controls.Add(this.lblhafta);
            this.panel5.Controls.Add(this.lblHayvanSayisi);
            this.panel5.Controls.Add(this.lblHyvLabel);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(295, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(451, 196);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(269, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(176, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.BlueViolet;
            this.panel6.Controls.Add(this.lblAsiSayisi);
            this.panel6.Controls.Add(this.labellToplamAsiSayisi);
            this.panel6.Location = new System.Drawing.Point(8, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(255, 45);
            this.panel6.TabIndex = 1;
            // 
            // lblAsiSayisi
            // 
            this.lblAsiSayisi.AutoSize = true;
            this.lblAsiSayisi.BackColor = System.Drawing.Color.DarkViolet;
            this.lblAsiSayisi.Location = new System.Drawing.Point(218, 14);
            this.lblAsiSayisi.Name = "lblAsiSayisi";
            this.lblAsiSayisi.Size = new System.Drawing.Size(18, 20);
            this.lblAsiSayisi.TabIndex = 1;
            this.lblAsiSayisi.Text = "0";
            // 
            // labellToplamAsiSayisi
            // 
            this.labellToplamAsiSayisi.AutoSize = true;
            this.labellToplamAsiSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labellToplamAsiSayisi.Location = new System.Drawing.Point(12, 14);
            this.labellToplamAsiSayisi.Name = "labellToplamAsiSayisi";
            this.labellToplamAsiSayisi.Size = new System.Drawing.Size(200, 21);
            this.labellToplamAsiSayisi.TabIndex = 0;
            this.labellToplamAsiSayisi.Text = "Toplam Yapılan Aşı Sayımız:";
            // 
            // lblSon1Hafta
            // 
            this.lblSon1Hafta.AutoSize = true;
            this.lblSon1Hafta.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblSon1Hafta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSon1Hafta.Location = new System.Drawing.Point(16, 166);
            this.lblSon1Hafta.Name = "lblSon1Hafta";
            this.lblSon1Hafta.Size = new System.Drawing.Size(51, 20);
            this.lblSon1Hafta.TabIndex = 3;
            this.lblSon1Hafta.Text = "label2";
            // 
            // lblhafta
            // 
            this.lblhafta.AutoSize = true;
            this.lblhafta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblhafta.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblhafta.Location = new System.Drawing.Point(16, 148);
            this.lblhafta.Name = "lblhafta";
            this.lblhafta.Size = new System.Drawing.Size(144, 15);
            this.lblhafta.TabIndex = 2;
            this.lblhafta.Text = "Son 1 Haftada kaydedilen:";
            // 
            // lblHayvanSayisi
            // 
            this.lblHayvanSayisi.AutoSize = true;
            this.lblHayvanSayisi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHayvanSayisi.Location = new System.Drawing.Point(8, 52);
            this.lblHayvanSayisi.Name = "lblHayvanSayisi";
            this.lblHayvanSayisi.Size = new System.Drawing.Size(78, 32);
            this.lblHayvanSayisi.TabIndex = 1;
            this.lblHayvanSayisi.Text = "label2";
            // 
            // lblHyvLabel
            // 
            this.lblHyvLabel.AutoSize = true;
            this.lblHyvLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHyvLabel.ForeColor = System.Drawing.Color.FloralWhite;
            this.lblHyvLabel.Location = new System.Drawing.Point(0, 25);
            this.lblHyvLabel.Name = "lblHyvLabel";
            this.lblHyvLabel.Size = new System.Drawing.Size(160, 20);
            this.lblHyvLabel.TabIndex = 0;
            this.lblHyvLabel.Text = "Toplam Hayvan Sayısı :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnSahiplendirme);
            this.panel2.Controls.Add(this.btnPersonel);
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Controls.Add(this.btnAsiTakip);
            this.panel2.Controls.Add(this.btnHayvanBilgileri);
            this.panel2.Controls.Add(this.btnHayvanKayit);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnDashboard);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblKullanici);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 1041);
            this.panel2.TabIndex = 0;
            // 
            // btnSahiplendirme
            // 
            this.btnSahiplendirme.FlatAppearance.BorderSize = 0;
            this.btnSahiplendirme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSahiplendirme.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSahiplendirme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSahiplendirme.Image = ((System.Drawing.Image)(resources.GetObject("btnSahiplendirme.Image")));
            this.btnSahiplendirme.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSahiplendirme.Location = new System.Drawing.Point(0, 548);
            this.btnSahiplendirme.Name = "btnSahiplendirme";
            this.btnSahiplendirme.Size = new System.Drawing.Size(228, 57);
            this.btnSahiplendirme.TabIndex = 8;
            this.btnSahiplendirme.Text = "Hayvan Sahiplendir/Görüntüle";
            this.btnSahiplendirme.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSahiplendirme.UseVisualStyleBackColor = true;
            this.btnSahiplendirme.Click += new System.EventHandler(this.btnSahiplendirme_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPersonel.FlatAppearance.BorderSize = 0;
            this.btnPersonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPersonel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnPersonel.Image = ((System.Drawing.Image)(resources.GetObject("btnPersonel.Image")));
            this.btnPersonel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonel.Location = new System.Drawing.Point(0, 927);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(228, 57);
            this.btnPersonel.TabIndex = 7;
            this.btnPersonel.Text = "Personel Ekle/Düzenle";
            this.btnPersonel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCikis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.Location = new System.Drawing.Point(0, 984);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(228, 57);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAsiTakip
            // 
            this.btnAsiTakip.FlatAppearance.BorderSize = 0;
            this.btnAsiTakip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiTakip.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsiTakip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAsiTakip.Image = ((System.Drawing.Image)(resources.GetObject("btnAsiTakip.Image")));
            this.btnAsiTakip.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsiTakip.Location = new System.Drawing.Point(0, 468);
            this.btnAsiTakip.Name = "btnAsiTakip";
            this.btnAsiTakip.Size = new System.Drawing.Size(228, 57);
            this.btnAsiTakip.TabIndex = 5;
            this.btnAsiTakip.Text = "Aşı Takip";
            this.btnAsiTakip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsiTakip.UseVisualStyleBackColor = true;
            this.btnAsiTakip.Click += new System.EventHandler(this.btnAsiTakip_Click);
            // 
            // btnHayvanBilgileri
            // 
            this.btnHayvanBilgileri.FlatAppearance.BorderSize = 0;
            this.btnHayvanBilgileri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHayvanBilgileri.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHayvanBilgileri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHayvanBilgileri.Image = ((System.Drawing.Image)(resources.GetObject("btnHayvanBilgileri.Image")));
            this.btnHayvanBilgileri.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHayvanBilgileri.Location = new System.Drawing.Point(0, 396);
            this.btnHayvanBilgileri.Name = "btnHayvanBilgileri";
            this.btnHayvanBilgileri.Size = new System.Drawing.Size(228, 57);
            this.btnHayvanBilgileri.TabIndex = 4;
            this.btnHayvanBilgileri.Text = "Hayvan Bilgileri";
            this.btnHayvanBilgileri.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHayvanBilgileri.UseVisualStyleBackColor = true;
            this.btnHayvanBilgileri.Click += new System.EventHandler(this.btnHayvanBilgileri_Click);
            // 
            // btnHayvanKayit
            // 
            this.btnHayvanKayit.FlatAppearance.BorderSize = 0;
            this.btnHayvanKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHayvanKayit.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHayvanKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHayvanKayit.Image = ((System.Drawing.Image)(resources.GetObject("btnHayvanKayit.Image")));
            this.btnHayvanKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHayvanKayit.Location = new System.Drawing.Point(0, 316);
            this.btnHayvanKayit.Name = "btnHayvanKayit";
            this.btnHayvanKayit.Size = new System.Drawing.Size(228, 57);
            this.btnHayvanKayit.TabIndex = 2;
            this.btnHayvanKayit.Text = "Hayvan Kayıt";
            this.btnHayvanKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHayvanKayit.UseVisualStyleBackColor = true;
            this.btnHayvanKayit.Click += new System.EventHandler(this.btnHayvanKayit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 1);
            this.panel3.TabIndex = 3;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(0, 241);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(228, 57);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(39, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Merhaba! Hoş Geldiniz";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKullanici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblKullanici.Location = new System.Drawing.Point(60, 148);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(63, 25);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightYellow;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1904, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "HayvanBarinak v_1.0.0";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.lblpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHayvanKayit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAsiTakip;
        private System.Windows.Forms.Button btnHayvanBilgileri;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Panel lblpanel;
        protected System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblHayvanSayisi;
        private System.Windows.Forms.Label lblHyvLabel;
        private System.Windows.Forms.Label lblhafta;
        private System.Windows.Forms.Label lblSon1Hafta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAsiSayisi;
        private System.Windows.Forms.Label labellToplamAsiSayisi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblKusSayisi;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblKediSayisi;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblKopekSayisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button btnSahiplendirme;
    }
}