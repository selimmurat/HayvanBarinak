using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccess.Concrete.EntitiyFramework;
using Business.Concrete;
using System.IO;
using Entities.Concrete;

namespace SaydamHayvanBakımEviV1
{
    public partial class HayvanBilgileriEkranı : Form
    {
        public HayvanBilgileriEkranı()
        {
            InitializeComponent();
        }

        private void HayvanBilgileriEkranı_Load(object sender, EventArgs e)
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
            foreach (var turTurCins in turCinsResult)
            {
                cmbTuru.DisplayMember = "turu";
                cmbTuru.ValueMember = "id";
            }
            #endregion


            HayvanBilgileriManager hayvanBilgileriManager = new HayvanBilgileriManager(new EfHayvanBilgileriDAL());
            dataGridView1.DataSource = hayvanBilgileriManager.getHayvanTurCinsSayilarıAlma();           
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].HeaderText = "HAYVAN KİMLİK NUMARASI";
            dataGridView1.Columns[1].Width = 80;
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
            dataGridView1.Columns[7].Width = 190;
            dataGridView1.Columns[8].HeaderText = "FOTOĞRAF";
            dataGridView1.Columns[8].Width = 140;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtKimlik.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateDogumTarihi.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            TxtEkBilgi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbRenk.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCinsiyet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbTuru.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            /*MemoryStream ms = new MemoryStream(Convert.FromBase64String(dataGridView1.CurrentRow.Cells[5].Value.ToString()));
            if (ms!= null)
            {
                Image returnImage = Image.FromStream(ms);
                pictureBox1.Image = returnImage;
            }
            else
            {
                MessageBox.Show("boş resim");
                //pictureBox1.Image = "../images/noImage.png";
            }*/


        }

        private void button3_Click(object sender, EventArgs e)
        {
            HayvanBilgileriManager hayvanBilgileriManager = new HayvanBilgileriManager(new EfHayvanBilgileriDAL());
            HayvanBilgileri hayvanBilgileri = new HayvanBilgileri
            {
                id = Convert.ToInt32(TxtId.Text),
                hayvanKimlikNumarasi = Convert.ToInt32(TxtKimlik.Text),
                turId = Convert.ToInt32(cmbTuru.SelectedValue),
                renkId = Convert.ToInt32(cmbRenk.SelectedValue),
                cinsiyet = txtCinsiyet.Text,
                ekBilgi = TxtEkBilgi.Text,
                dogumTarihi = dateDogumTarihi.Value,
                kayitId = Convert.ToInt32(TxtId.Text)                

            };
            hayvanBilgileriManager.Update(hayvanBilgileri);
            dataGridView1.DataSource = hayvanBilgileriManager.getHayvanTurCinsSayilarıAlma();
            MessageBox.Show("Bilgiler Güncellenmiştir.");
        }
    }
}
