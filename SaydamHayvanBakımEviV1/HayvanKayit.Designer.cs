
namespace SaydamHayvanBakımEviV1
{
    partial class HayvanKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HayvanKayit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtGelisNedeni = new System.Windows.Forms.TextBox();
            this.txtEkAciklama = new System.Windows.Forms.RichTextBox();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.cmbTuru = new System.Windows.Forms.ComboBox();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtKupeNo = new System.Windows.Forms.TextBox();
            this.lblGelisNedeni = new System.Windows.Forms.Label();
            this.lblTurId = new System.Windows.Forms.Label();
            this.lblRenkId = new System.Windows.Forms.Label();
            this.lblEkAciklama = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblHayvanKimlikNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlueViolet;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblCinsiyet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblFoto);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtGelisNedeni);
            this.groupBox1.Controls.Add(this.txtEkAciklama);
            this.groupBox1.Controls.Add(this.cmbRenk);
            this.groupBox1.Controls.Add(this.cmbTuru);
            this.groupBox1.Controls.Add(this.dtDogumTarihi);
            this.groupBox1.Controls.Add(this.txtKupeNo);
            this.groupBox1.Controls.Add(this.lblGelisNedeni);
            this.groupBox1.Controls.Add(this.lblTurId);
            this.groupBox1.Controls.Add(this.lblRenkId);
            this.groupBox1.Controls.Add(this.lblEkAciklama);
            this.groupBox1.Controls.Add(this.lblDogumTarihi);
            this.groupBox1.Controls.Add(this.lblHayvanKimlikNo);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // lblCinsiyet
            // 
            resources.ApplyResources(this.lblCinsiyet, "lblCinsiyet");
            this.lblCinsiyet.Name = "lblCinsiyet";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // lblFoto
            // 
            resources.ApplyResources(this.lblFoto, "lblFoto");
            this.lblFoto.Name = "lblFoto";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnTemizle, "btnTemizle");
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightSeaGreen;
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtGelisNedeni
            // 
            resources.ApplyResources(this.txtGelisNedeni, "txtGelisNedeni");
            this.txtGelisNedeni.Name = "txtGelisNedeni";
            // 
            // txtEkAciklama
            // 
            resources.ApplyResources(this.txtEkAciklama, "txtEkAciklama");
            this.txtEkAciklama.Name = "txtEkAciklama";
            // 
            // cmbRenk
            // 
            this.cmbRenk.FormattingEnabled = true;
            resources.ApplyResources(this.cmbRenk, "cmbRenk");
            this.cmbRenk.Name = "cmbRenk";
            // 
            // cmbTuru
            // 
            this.cmbTuru.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cmbTuru.FormattingEnabled = true;
            resources.ApplyResources(this.cmbTuru, "cmbTuru");
            this.cmbTuru.Name = "cmbTuru";
            // 
            // dtDogumTarihi
            // 
            resources.ApplyResources(this.dtDogumTarihi, "dtDogumTarihi");
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            // 
            // txtKupeNo
            // 
            resources.ApplyResources(this.txtKupeNo, "txtKupeNo");
            this.txtKupeNo.Name = "txtKupeNo";
            // 
            // lblGelisNedeni
            // 
            resources.ApplyResources(this.lblGelisNedeni, "lblGelisNedeni");
            this.lblGelisNedeni.Name = "lblGelisNedeni";
            // 
            // lblTurId
            // 
            resources.ApplyResources(this.lblTurId, "lblTurId");
            this.lblTurId.Name = "lblTurId";
            // 
            // lblRenkId
            // 
            resources.ApplyResources(this.lblRenkId, "lblRenkId");
            this.lblRenkId.Name = "lblRenkId";
            // 
            // lblEkAciklama
            // 
            resources.ApplyResources(this.lblEkAciklama, "lblEkAciklama");
            this.lblEkAciklama.Name = "lblEkAciklama";
            // 
            // lblDogumTarihi
            // 
            resources.ApplyResources(this.lblDogumTarihi, "lblDogumTarihi");
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            // 
            // lblHayvanKimlikNo
            // 
            resources.ApplyResources(this.lblHayvanKimlikNo, "lblHayvanKimlikNo");
            this.lblHayvanKimlikNo.Name = "lblHayvanKimlikNo";
            // 
            // HayvanKayit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HayvanKayit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HayvanKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRenkId;
        private System.Windows.Forms.Label lblEkAciklama;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblHayvanKimlikNo;
        private System.Windows.Forms.Label lblTurId;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtGelisNedeni;
        private System.Windows.Forms.RichTextBox txtEkAciklama;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.ComboBox cmbTuru;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.TextBox txtKupeNo;
        private System.Windows.Forms.Label lblGelisNedeni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCinsiyet;
    }
}