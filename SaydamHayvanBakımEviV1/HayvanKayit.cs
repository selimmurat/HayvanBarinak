using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace SaydamHayvanBakımEviV1
{
    public partial class HayvanKayit : Form
    {
        public HayvanKayit()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void HayvanKayit_Load(object sender, EventArgs e)
        {
            #region Veritabanından Renkleri comboboxa yükleme yapılyor
            HayvanRenkManager hayvanRenkManager = new HayvanRenkManager(new EfHayvanRenkDAL());
            var renkResult = hayvanRenkManager.GetAll();



            cmbRenk.DataSource = renkResult;

            foreach (var renk in renkResult)
            {
                cmbRenk.DisplayMember = "renk";
                cmbRenk.ValueMember = "id";
            }
            #endregion

            #region Veritabanından hayvanın tür ve cinsi comboboxa yükleme işlemi yapılıyor.
            HayvanTuruCinsiManager hayvanTuruCinsiManager = new HayvanTuruCinsiManager(new EfHayvanTuruCinsiDAL());
            var turCinsResult = hayvanTuruCinsiManager.GetAll();
            cmbTuru.DataSource = turCinsResult;
            foreach (var turCins in turCinsResult)
            {
                cmbTuru.DisplayMember = "turu";
                cmbTuru.ValueMember = "id";
            }
            #endregion


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            HayvanKayitManager hayvanKayitManager = new HayvanKayitManager(new EfHayvanKayitDAL());
            hayvanKayitManager.Add(new Entities.Concrete.HayvanKayit
            {
                kayitTarihi = DateTime.Now,
                gelisNedeni = txtGelisNedeni.Text,
                kaydedenPersonelId = Dashboard.kullaniciIdDasboard
            });

            HayvanBilgileriManager hayvanBilgileriManager = new HayvanBilgileriManager(new EfHayvanBilgileriDAL());
            hayvanBilgileriManager.Add(new Entities.Concrete.HayvanBilgileri
            {
                hayvanKimlikNumarasi = Convert.ToInt32(txtKupeNo.Text),
                dogumTarihi = dtDogumTarihi.Value,
                ekBilgi = txtEkAciklama.Text,
                //foto = Convert.FromBase64String(pictureBox1.Image.ToString()),
                renkId = Convert.ToInt32(cmbRenk.SelectedValue),
                kayitId = hayvanKayitManager.GetLastAddId().id,
                turId = Convert.ToInt32(cmbTuru.SelectedValue),
                cinsiyet = comboBox1.Text
            });
            MessageBox.Show("Kaydedilmiştir");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        public void temizle()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    tb.Clear();
                }
                if (item is RichTextBox)
                {
                    RichTextBox rT = (RichTextBox)item;
                    rT.Clear();
                }
                if (item is DateTimePicker)
                {
                    DateTimePicker dt = (DateTimePicker)item;
                    dt.Value = DateTime.Now;
                }
            }
        }
    }
}
