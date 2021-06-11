using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using System;
using System.Windows.Forms;

namespace SaydamHayvanBakımEviV1
{
    public partial class Dashboard : Form
    {
        public static int kullaniciIdDasboard = 1;
        public string kullanici;
        public string yetki;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHayvanKayit_Click(object sender, EventArgs e)
        {
            lblpanel.Controls.Clear();
            HayvanKayit hayvanKayit = new HayvanKayit();
            hayvanKayit.TopLevel = false;
            lblpanel.Controls.Add(hayvanKayit);
            hayvanKayit.Show();
            hayvanKayit.Dock = DockStyle.Fill;
            hayvanKayit.BringToFront();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            #region Toplam hayvan sayımızı gösterdik
            HayvanBilgileriManager hayvanBilgileriManager = new HayvanBilgileriManager(new EfHayvanBilgileriDAL());
            int toplamHayvanSayisi = hayvanBilgileriManager.GetAll().Count;
            lblHayvanSayisi.Text = toplamHayvanSayisi.ToString();
            #endregion

            #region Son 1 haftada kaydedilen toplam hayvan sayısı
            HayvanKayitManager hayvanKayitManager = new HayvanKayitManager(new EfHayvanKayitDAL());
            int son1HaftaKayitSayisi = hayvanKayitManager.getLastWeekSave().Count;
            lblSon1Hafta.Text = son1HaftaKayitSayisi.ToString();
            #endregion

            #region toplam hayvan türlerine sayıları dashboarda yansıtma işlemi yapılıyor.
            HayvanBilgileriManager kopekSayisi = new HayvanBilgileriManager(new EfHayvanBilgileriDAL());
            var resultKopekSayisi = kopekSayisi.getHayvanTurCinsSayilarıAlma();
            int labelKopekSayisi = 0;
            int labelKediSayisi = 0;
            int labelKusSayisi = 0;

            foreach (var item in resultKopekSayisi)
            {
                switch (item.cinsi)
                {
                    case "KÖPEK":
                        labelKopekSayisi += 1;
                        break;
                    case "KEDİ":
                        labelKediSayisi += 1;
                        break;
                    case "KUŞ":
                        labelKusSayisi += 1;
                        break;
                    default:
                        break;
                }
            }
            lblKopekSayisi.Text = labelKopekSayisi.ToString();
            lblKediSayisi.Text = labelKediSayisi.ToString();
            lblKusSayisi.Text = labelKusSayisi.ToString();
            #endregion

            HayvanAsiBilgisiManager hayvanAsiBilgisiManager = new HayvanAsiBilgisiManager(new EfHayvanAsiBilgisiDAL());
            lblAsiSayisi.Text = hayvanAsiBilgisiManager.GetAll().Count.ToString();

            var result = hayvanBilgileriManager.getHayvanTurCinsSayilarıAlma();
            dataGridView1.DataSource = result;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].HeaderText = "HAYVAN KİMLİK NUMARASI";
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].HeaderText = "DOĞUM TARİHİ";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "EK BİLGİ";
            dataGridView1.Columns[3].Width = 550;
            dataGridView1.Columns[4].HeaderText = "RENK";
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].HeaderText = "CİNSİYET";
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[6].HeaderText = "CİNSİ";
            dataGridView1.Columns[6].Width = 110;
            dataGridView1.Columns[7].HeaderText = "TURU";
            dataGridView1.Columns[7].Width = 110;


            switch (yetki)
            {
                case "Admin":
                    btnPersonel.Visible = true;
                    break;
                default:
                    btnPersonel.Visible = false;
                    break;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblpanel.Controls.Clear();
            lblpanel.Controls.Add(panel5);
            lblpanel.Controls.Add(panel4);
            lblpanel.Controls.Add(dataGridView1);
            Dashboard_Load(sender, e);


        }

        private void btnHayvanBilgileri_Click(object sender, EventArgs e)
        {
            lblpanel.Controls.Clear();
            HayvanBilgileriEkranı hayvanBilgileriEkranı = new HayvanBilgileriEkranı();
            hayvanBilgileriEkranı.TopLevel = false;
            lblpanel.Controls.Add(hayvanBilgileriEkranı);
            hayvanBilgileriEkranı.Show();
            hayvanBilgileriEkranı.Dock = DockStyle.Fill;
            hayvanBilgileriEkranı.BringToFront();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            lblpanel.Controls.Clear();
            PersonelEkleDuzenle personelEkleDuzenle = new PersonelEkleDuzenle();
            personelEkleDuzenle.TopLevel = false;
            lblpanel.Controls.Add(personelEkleDuzenle);
            personelEkleDuzenle.Show();
            personelEkleDuzenle.Dock = DockStyle.Fill;
            personelEkleDuzenle.BringToFront();
        }

        private void btnAsiTakip_Click(object sender, EventArgs e)
        {
            lblpanel.Controls.Clear();
            AsiTakip asiTakip = new AsiTakip();
            asiTakip.TopLevel = false;
            lblpanel.Controls.Add(asiTakip);
            asiTakip.Show();
            asiTakip.Dock = DockStyle.Fill;
            asiTakip.BringToFront();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSahiplendirme_Click(object sender, EventArgs e)
        {
            lblpanel.Controls.Clear();
            HayvanSahiplendirme hayvanSahiplendirme = new HayvanSahiplendirme();
            hayvanSahiplendirme.TopLevel = false;
            lblpanel.Controls.Add(hayvanSahiplendirme);
            hayvanSahiplendirme.Show();
            hayvanSahiplendirme.Dock = DockStyle.Fill;
            hayvanSahiplendirme.BringToFront();
        }
    }
}
