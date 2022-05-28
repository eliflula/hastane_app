using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using MODEL;

namespace Hastane.App.Forms
{
    public partial class IlacDepo : Form
    {
        private AnaMenu menux;
        private IlacBL ibl= new IlacBL();
        private int deleteID = -1;
        public IlacDepo(AnaMenu menu)
        {

            InitializeComponent();
            menux = menu;
            prepareGridData();
        }

        private void IlacDepo_FormClosing(object sender, FormClosingEventArgs e)
        {
            menux.Show();
            this.Hide();
        }

        private void txtSeriNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {

            if (txtIlacAdi.Text != null && txtSeriNo.Text != null && nmbAdet.Value != null)
            {
                try
                {
                    Ilac ilac=new Ilac();
                    ilac.ADI = txtIlacAdi.Text;
                    ilac.SERINO = txtSeriNo.Text;
                    ilac.ADET = (int) nmbAdet.Value;
                    if (ibl.Add(ilac))
                    {
                        MessageBox.Show("Kayıt Başarılı");
                        prepareGridData();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Sırasında Hata Oluştu");
                    }

                    txtIlacAdi.Text = "";
                    txtSeriNo.Text = "";
                    nmbAdet.Value = 0;
                }
                catch (Exception exception)
                {
                
                }


            }



        }

        private void IlacDepo_Load(object sender, EventArgs e)
        {

        }

        private void prepareGridData()
        {


            DataTable dt;
            try
            {

                dt = ibl.getIlacs();
                dataIlac.DataSource = dt;

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }


        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            if (txtSorguAdi.Text!=null)
            {
               DataTable dt= ibl.getIlacByName(txtSorguAdi.Text);
               if (dt!=null)
               {
                   dataIlac.DataSource = dt;
               }

            }
        }

        private void btnGridRefresh_Click(object sender, EventArgs e)
        {
            prepareGridData();
        }

        private void dataIlac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.deleteID = (int) dataIlac.SelectedRows[0].Cells[0].Value;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "TEYİT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result==DialogResult.Yes && deleteID>-1)
            {
                try
                {
                    if (ibl.Delete(new Ilac() { ID = this.deleteID }))
                    {
                        MessageBox.Show("Kayıt Silindi");
                        prepareGridData();
                        this.deleteID = -1;
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi sırasında hata");
                    }

                }
                catch (Exception exception)
                {
                    

                }
            }

        }
    }
}
