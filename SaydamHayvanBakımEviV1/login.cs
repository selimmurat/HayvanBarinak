using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Business.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccess.Concrete.EntitiyFramework;

namespace SaydamHayvanBakımEviV1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            KullaniciManager kullaniciManager = new KullaniciManager(new EfKullaniciDAL());
            var result = kullaniciManager.login(TxtEposta.Text.ToLower(), TxtPassword.Text.ToLower());
            if (result!=null)
            {                
                MessageBox.Show("Giriş Başarılı");
                Dashboard d = new Dashboard();
                d.lblKullanici.Text = result.adiSoyadi;
                d.yetki = result.unvan;

                this.Visible = false;
                d.Show();
            }
            else
            {
                MessageBox.Show("Giriş Yapılamadı. Lütfen Verilerinizi kontrol ediniz.");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void TxtEposta_Click(object sender, EventArgs e)
        {
            TxtEposta.Clear();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.AliceBlue;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.RosyBrown;
        }

        private void btnLogin_MouseDown(object sender, MouseEventArgs e)
        {
            btnLogin.BackColor = Color.Green;
        }
    }
}
