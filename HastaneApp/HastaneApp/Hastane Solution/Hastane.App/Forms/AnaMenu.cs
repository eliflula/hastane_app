using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane.App.Forms
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaKayıt hasta= new HastaKayıt(this);
            hasta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IlacDepo poli = new IlacDepo(this);
            poli.Show();
            this.Hide();
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            HastaServisi servis = new HastaServisi(this);
            servis.Show();
            this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PROGRAMI ILK KEZ KULLANIYORSANIZ LUTFEN ÖNCE POLIKLINIK VE DOKTOR KAYITLARINI YAPIN. AKSİ HALDE HASTA GİRİŞİ YAPILAMAZ  ");
        }

        private void btnDoktorPoli_Click(object sender, EventArgs e)
        {
            DoktorPoli poli = new DoktorPoli(this);
            poli.Show();
            this.Hide();
        }
    }
}
