using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace SaydamHayvanBakımEviV1
{
    public partial class PersonelEkleDuzenle : Form
    {
        public PersonelEkleDuzenle()
        {
            InitializeComponent();
        }

        private PersonelManager personelManager;
        private KullaniciManager kullaniciManager;
        private UnvanManager unvanManager;
        private int kullaniciId = 0;
        private int unvanId = 0;

        private void PersonelEkleDuzenle_Load(object sender, EventArgs e)
        {
            #region tablo veri ekleme 
            PersonelManager personelManager = new PersonelManager(new EfPersonelDAL());
            dataGridView1.DataSource = personelManager.personelEkleDuzenleGetir();
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].HeaderText = "ADI SOYADI";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].HeaderText = "KAYIT TARİHİ";
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].HeaderText = "TC KİMLİK NO";
            dataGridView1.Columns[3].Width = 120;
            dataGridView1.Columns[4].HeaderText = "KULLANICI İD";
            dataGridView1.Columns[4].Width = 110;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].HeaderText = "KULLANICI ADI";
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns[6].HeaderText = "SİFRE";
            dataGridView1.Columns[6].Width = 110;
            dataGridView1.Columns[7].HeaderText = "UNVAN ID";
            dataGridView1.Columns[7].Width = 110;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "UNVAN";
            dataGridView1.Columns[8].Width = 110;
            #endregion

            #region comboboxa ünvan isimleri ve arka planda idlerini tutma işlemi yaptık
            unvanManager = new UnvanManager(new EfUnvanDAL());
            var unvanResult = unvanManager.Getll();
            cmbUnvan.DataSource = unvanResult;
            foreach (var unvan in unvanResult)
            {
                cmbUnvan.DisplayMember = "unvanAdi";
                cmbUnvan.ValueMember = "id";
            }
            #endregion

            #region Yeni personel ekleme ekranındaki ünvan isimleri ve arka planda idlerini tutma işlemi yaptık
            unvanManager = new UnvanManager(new EfUnvanDAL());
            var unvanSaveResult = unvanManager.Getll();
            cmbSaveUnvan.DataSource = unvanResult;
            foreach (var unvan in unvanResult)
            {
                cmbSaveUnvan.DisplayMember = "unvanAdi";
                cmbSaveUnvan.ValueMember = "id";
            }
            #endregion



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAdiSoyadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtKayitTarihi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txtTCKimlikNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kullaniciId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            unvanId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            cmbUnvan.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            #region personel tablosunda güncelleme yapılıyor
            personelManager = new PersonelManager(new EfPersonelDAL());
            personelManager.Update
           (
           new Personel
           {
               id = Convert.ToInt32(txtId.Text),
               adiSoyadi = txtAdiSoyadi.Text,
               kayitTarihi = dtKayitTarihi.Value,
               kullaniciId = kullaniciId,
               tcKimlikNo = txtTCKimlikNo.Text,
               unvanId = Convert.ToInt32(cmbUnvan.SelectedValue.ToString())
           }
           );
            #endregion

            #region Kullanici tablosunda bilgileri güncelleme yapılıyor
            kullaniciManager = new KullaniciManager(new EfKullaniciDAL());
            kullaniciManager.Update
                (
                new Kullanici
                {
                    id = kullaniciId,
                    kullaniciAdi = txtKullaniciAdi.Text,
                    sifre = txtSifre.Text,
                    unvanId = Convert.ToInt32(cmbUnvan.SelectedValue.ToString())
                }
                );
            #endregion
            PersonelEkleDuzenle_Load(sender, e);
            MessageBox.Show("Personel bilgileri güncellenmiştir.");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBoxlarDoluMuValidator())
            {
                kullaniciManager = new KullaniciManager(new EfKullaniciDAL());
                kullaniciManager.Add
                    (
                    new Kullanici
                    {
                        kullaniciAdi = txtSaveKullaniciAdi.Text.ToLower(),
                        sifre = txtSaveSifre.Text,
                        unvanId = Convert.ToInt32(cmbSaveUnvan.SelectedValue)
                    }
                    );

                personelManager = new PersonelManager(new EfPersonelDAL());
                personelManager.Add
                    (
                    new Personel
                    {
                        adiSoyadi = txtSaveAdSoyadi.Text,
                        tcKimlikNo = txtSaveTCKimlikNo.Text,
                        kayitTarihi = DateTime.Now,
                        unvanId = Convert.ToInt32(cmbSaveUnvan.SelectedValue),
                        kullaniciId = kullaniciManager.GetLastAddId().id
                    }
                    );
                txtBoxAlanlariTemizle();
                MessageBox.Show(txtSaveAdSoyadi.Text + " " + "Personel oluşturulmuştur.");
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurduğunuzdan emin olunuz.");
            }


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                #region Kullanici tablosunda silme işlemi yapılıyor
                kullaniciManager = new KullaniciManager(new EfKullaniciDAL());
                kullaniciManager.Delete
                    (
                    new Kullanici
                    {
                        id = kullaniciId,
                        kullaniciAdi = txtKullaniciAdi.Text,
                        sifre = txtSifre.Text,
                        unvanId = Convert.ToInt32(cmbUnvan.SelectedValue.ToString())
                    }
                    );
                #endregion

                #region personel tablosunda silme işlemi yapılıyor
                personelManager = new PersonelManager(new EfPersonelDAL());
                personelManager.Delete
               (
               new Personel
               {
                   id = Convert.ToInt32(txtId.Text),
                   adiSoyadi = txtAdiSoyadi.Text,
                   kayitTarihi = dtKayitTarihi.Value,
                   kullaniciId = kullaniciId,
                   tcKimlikNo = txtTCKimlikNo.Text,
                   unvanId = Convert.ToInt32(cmbUnvan.SelectedValue.ToString())
               }
               );
                #endregion

                MessageBox.Show(txtAdiSoyadi.Text + " " + " Kişisi silinmiştir.");
            }
            else
            {
                MessageBox.Show("Silinecek personeli tablodan seçmeniz gerekmektedir.");
            }



        }

        private void btnSaveSil_Click(object sender, EventArgs e)
        {
            txtBoxAlanlariTemizle();

        }

        public void txtBoxAlanlariTemizle()
        {
            foreach (Control item in tabPageYeniPersonelEkleme.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }
            }
        }

        public bool txtBoxlarDoluMuValidator()
        {
            bool control = false;

            foreach (Control item in tabPageYeniPersonelEkleme.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text != null && item.Text != "")
                    {
                        control = true;
                    }
                    else
                    {
                        control = false;
                        return control;
                    }
                }
            }
            return control;
        }
    }
}

