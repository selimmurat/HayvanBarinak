using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace SaydamHayvanBakımEviV1
{
    public partial class HayvanSahiplendirme : Form
    {
        public HayvanSahiplendirme()
        {
            InitializeComponent();
        }
        HayvanBilgileriManager hayvanBilgileriManager;
        SahiplendirmeManager sahiplendirmeManager;
        HayvanRenkManager hayvanRenkManager;
        HayvanTuruCinsiManager hayvanTuruCinsiManager;
        HayvanCikisManager hayvanCikisManager;
        bool hayvanSahiplendirilmisMi = false;

        private void HayvanSahiplendirme_Load(object sender, EventArgs e)
        {
            #region form yüklenirken hayvanbilgilerini tabloya dolduruyoruz
            hayvanBilgileriManager = new HayvanBilgileriManager(new EfHayvanBilgileriDAL());
            dataGridView1.DataSource = hayvanBilgileriManager.getHayvanTurCinsSayilarıAlma();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "HAYVAN KİMLİK NUMARASI";
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].HeaderText = "DOĞUM TARİHİ";
            dataGridView1.Columns[2].Width = 122;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "EK BİLGİ";
            dataGridView1.Columns[3].Width = 110;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "RENK";
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "CİNSİYET";
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderText = "CİNSİ";
            dataGridView1.Columns[6].Width = 110;
            dataGridView1.Columns[7].HeaderText = "TÜRÜ";
            dataGridView1.Columns[7].Width = 140;
            dataGridView1.Columns[8].HeaderText = "FOTO";
            dataGridView1.Columns[8].Width = 130;
            dataGridView1.Columns[8].Visible = false;
            #endregion
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region seçilen hayvan id' sine göre sahiplendirme bilgileri çekiliyor
            sahiplendirmeManager = new SahiplendirmeManager(new EfSahiplendirmeDAL());
            var result = sahiplendirmeManager.hayvanSahipledirmeBilgileriDTOs(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            dataGridView2.DataSource = result;
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[0].Width = 60;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "HAYVAN KİMLİK NUMARASI";
            dataGridView2.Columns[1].Width = 120;
            dataGridView2.Columns[2].HeaderText = "DOĞUM TARİHİ";
            dataGridView2.Columns[2].Width = 122;
            dataGridView2.Columns[3].HeaderText = "EK BİLGİ";
            dataGridView2.Columns[3].Width = 130;
            dataGridView2.Columns[4].HeaderText = "CİNSİYET";
            dataGridView2.Columns[4].Width = 100;
            dataGridView2.Columns[5].HeaderText = "RENK";
            dataGridView2.Columns[5].Width = 100;
            dataGridView2.Columns[6].HeaderText = "TÜRÜ";
            dataGridView2.Columns[6].Width = 100;
            dataGridView2.Columns[7].HeaderText = "CİNSİ";
            dataGridView2.Columns[7].Width = 100;
            dataGridView2.Columns[8].HeaderText = "ÇIKIŞ ID";
            dataGridView2.Columns[8].Width = 50;
            dataGridView2.Columns[8].Visible = false;
            dataGridView2.Columns[9].HeaderText = "ÇIKIŞ TARİHİ";
            dataGridView2.Columns[9].Width = 50;
            dataGridView2.Columns[10].HeaderText = "ÇIKIŞ YAPAN PERSONEL ID";
            dataGridView2.Columns[10].Width = 10;
            dataGridView2.Columns[10].Visible = false;
            dataGridView2.Columns[11].HeaderText = "ÇIKIŞ NEDENİ";
            dataGridView2.Columns[11].Width = 150;
            dataGridView2.Columns[12].HeaderText = "SAHİPLENDİRME ID";
            dataGridView2.Columns[12].Width = 20;
            dataGridView2.Columns[12].Visible = false;
            dataGridView2.Columns[13].HeaderText = "SAHİP AD SOYAD";
            dataGridView2.Columns[13].Width = 130;
            dataGridView2.Columns[14].HeaderText = "SAHİP TEL";
            dataGridView2.Columns[14].Width = 150;
            dataGridView2.Columns[15].HeaderText = "ADRES";
            dataGridView2.Columns[15].Width = 150;
            dataGridView2.Columns[15].HeaderText = "AÇIKLAMA";
            dataGridView2.Columns[15].Width = 150;
            #endregion

            #region txtboxlara veri aktarımı sağlandı
            hayvanTuruCinsiManager = new HayvanTuruCinsiManager(new EfHayvanTuruCinsiDAL());
            hayvanRenkManager = new HayvanRenkManager(new EfHayvanRenkDAL());
            hayvanBilgileriManager = new HayvanBilgileriManager(new EfHayvanBilgileriDAL());
            var hayvanBilgileriResult = hayvanBilgileriManager.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));

            txtKupeNo.Text = hayvanBilgileriResult.hayvanKimlikNumarasi.ToString();
            var turCinsi = hayvanTuruCinsiManager.GetById(hayvanBilgileriResult.turId);
            txtCinsi.Text = turCinsi.cinsi;
            txtTuru.Text = turCinsi.turu;
            var renk = hayvanRenkManager.GetById(hayvanBilgileriResult.renkId);
            txtRenk.Text = renk.renk;
            #endregion


        }

        private void btnSahiplendir_Click(object sender, EventArgs e)
        {
            if (txtBoxAlanlariDoluMu())
            {
                hayvanBilgileriManager = new HayvanBilgileriManager(new EfHayvanBilgileriDAL());
                hayvanCikisManager = new HayvanCikisManager(new EfHayvanCikisDAL());
                sahiplendirmeManager = new SahiplendirmeManager(new EfSahiplendirmeDAL());


                if (hayvanBilgileriManager.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)).cikisId == 0)
                {

                    #region Hayvan Sahiplendirme işlemi için " Sahiplendirme " tablosuna yeni kayıt ekleme işlemi yapıyoruz.
                    sahiplendirmeManager.Add
                        (
                        new Sahiplendirme
                        {
                            adi = txtSahipAd.Text,
                            soyadi = txtSahipSoyad.Text,
                            tel = txtTelNo.Text,
                            aciklama = txtAciklama.Text,
                            adres = txtAdres.Text
                        }
                        );
                    #endregion

                    #region Hayvan Sahiplendirme sonrası hayvanCikis tablosuna verileri kaydediyoruz
                    hayvanCikisManager.Add
                        (
                        new HayvanCikis
                        {
                            cikisNedeni = txtCikisNedeni.Text,
                            cikisTarihi = dtCikisTarihi.Value,
                            cikisPersonelId = Dashboard.kullaniciIdDasboard,
                            sahiplendirmeId = sahiplendirmeManager.getLastAddId().id
                        }
                        );
                    #endregion

                    #region hayvan bilgileri tablosunda cikis ıd ile ilgili alanı güncelleyiyoruz  (Foreign Key alanı)
                    var guncellenecekHayvanCikisId = hayvanBilgileriManager.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    guncellenecekHayvanCikisId.cikisId = hayvanCikisManager.getLastAddId().id;
                    hayvanBilgileriManager.Update(guncellenecekHayvanCikisId);
                    #endregion

                    MessageBox.Show("Hayvan Sahiplendirme işlemi yapılmıştır.");

                    txtBoxAlanlariTemizle();
                }
                else
                {
                    DialogResult secenek = MessageBox.Show("Seçili hayvan zaten sahiplendirilmiş, bilgilerinizi kontrol ediniz. /n " +
                        "+ Bu hayvan başka birine sahiplendirilecekse bir önceki sahiplendirmeyi iptal ediniz.", "UYARI BİLGİLENDİRME", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secenek == DialogResult.Yes)
                    {
                        #region Seçilen hayvan başka birisine sahiplendirme işlemi yapılmasına rağmen üzerine veri yazdırma işlemi yapılıyor.
                        sahiplendirmeManager.Add
                            (
                            new Sahiplendirme
                            {
                                adi = txtSahipAd.Text,
                                soyadi = txtSahipSoyad.Text,
                                tel = txtTelNo.Text,
                                aciklama = txtAciklama.Text,
                                adres = txtAdres.Text
                            }
                            );
                        #endregion

                        txtBoxAlanlariTemizle();
                        MessageBox.Show("Eski sahiplendirme üzerine yeni sahip bilgileri yazılmıştır.");
                    }
                    else
                    {
                        txtBoxAlanlariTemizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanların doldurduğunuzdan emin olunuz!.");
            }

            
        }

        public void txtBoxAlanlariTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }
        public bool txtBoxAlanlariDoluMu()
        {
            bool control = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == null || item.Text == "")
                    {

                        control = false;
                        break;
                    }
                    else
                    {
                        control = true;
                    }
                }
            }
            return control;
        }
    }
}
