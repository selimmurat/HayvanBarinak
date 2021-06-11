using Business.Concrete;
using DataAccess.Concrete.EntitiyFramework;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SaydamHayvanBakımEviV1
{
    public partial class AsiTakip : Form
    {
        public AsiTakip()
        {
            InitializeComponent();
        }
        HayvanAsiBilgisiManager hayvanAsiBilgisiManager;
        HayvanBilgileriManager hayvanBilgileriManager;
        PersonelManager personelManager;
        int secilenHayvanId = 0;
        int asiYapanPersonelId = 0;

        private void AsiTakip_Load(object sender, EventArgs e)
        {

            personelManager = new PersonelManager(new EfPersonelDAL());
            var asiYapanPersonelResult = personelManager.personelEkleDuzenleGetir();
            cmbAsiYapanPersonel.DataSource = asiYapanPersonelResult;
            foreach (var asiYapanPersonel in asiYapanPersonelResult)
            {
                cmbAsiYapanPersonel.DisplayMember = "adiSoyadi";
                cmbAsiYapanPersonel.ValueMember = "id";
            }

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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hayvanAsiBilgisiManager = new HayvanAsiBilgisiManager(new EfHayvanAsiBilgisiDAL());
            var result = hayvanAsiBilgisiManager.GetById(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            dataGridView2.DataSource = result;
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[0].Width = 110;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "KÜPE NUMARASI";
            dataGridView2.Columns[1].Width = 120;
            dataGridView2.Columns[2].HeaderText = "EK BİLGİ";
            dataGridView2.Columns[2].Width = 50;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].HeaderText = "CİNSİYET";
            dataGridView2.Columns[3].Width = 50;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].HeaderText = "RENK ";
            dataGridView2.Columns[4].Width = 50;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].HeaderText = "TURU ";
            dataGridView2.Columns[5].Width = 50;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].HeaderText = "CİNSİ ";
            dataGridView2.Columns[6].Width = 50;
            dataGridView2.Columns[6].Visible = false;
            dataGridView2.Columns[7].HeaderText = "YAPILAN AŞININ İSMİ ";
            dataGridView2.Columns[7].Width = 250;
            dataGridView2.Columns[8].HeaderText = "AŞI TARİHİ ";
            dataGridView2.Columns[8].Width = 150;
            dataGridView2.Columns[9].HeaderText = "AŞI YAPAN PERSONEL";
            dataGridView2.Columns[9].Width = 200;
            secilenHayvanId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (secilenHayvanId != 0 && txtAsiAdi.Text != null && txtAsiAdi.Text != "")
            {
                hayvanAsiBilgisiManager = new HayvanAsiBilgisiManager(new EfHayvanAsiBilgisiDAL());
                hayvanAsiBilgisiManager.Add
                    (
                    new HayvanAsiBilgisi
                    {
                        hayvanId = secilenHayvanId,
                        asiBilgisi = txtAsiAdi.Text,
                        asiTarihi = dtAsiTarihi.Value,
                        asiYapanPersonelId = Convert.ToInt32(cmbAsiYapanPersonel.SelectedValue)
                    }
                    );
                MessageBox.Show("Aşı bilgisi kaydedilmiştir.");

            }
            else
            {
                MessageBox.Show("Aşı bilgisi eklemek istediğiniz hayvanı seçmemiş yada yapılacak aşı bilgisini kontrol ediniz.");
            }
        }
    }
}
