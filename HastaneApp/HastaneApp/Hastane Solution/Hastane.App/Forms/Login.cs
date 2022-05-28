using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Hastane.App.Forms;

namespace Hastane.App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            LoginData loginData=new LoginData();

            if (txtKullaniciAdi.Text==loginData.getKullaniciAdi() && txtSifre.Text==loginData.getSifre())
            {
                MessageBox.Show("Giriş Başarılı","Giriş Başarılı");
                AnaMenu menu = new AnaMenu();
                menu.Show();
                this.Hide();
                


            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
                txtKullaniciAdi.Focus();

            }





        }
    }
}
