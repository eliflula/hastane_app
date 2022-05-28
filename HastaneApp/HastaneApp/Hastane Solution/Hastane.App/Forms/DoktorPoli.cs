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
    public partial class DoktorPoli : Form
    {
        private AnaMenu menux;
        ServiceBL sbl = new ServiceBL();
        DoctorBL dbl = new DoctorBL();
        public DoktorPoli(AnaMenu menu)
        {
            InitializeComponent();
            menux = menu;
            prepareData();
        }

        private void DoktorPoli_FormClosing(object sender, FormClosingEventArgs e)
        {
            menux.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtPolAdi.Text!=""&& txtPolAdres.Text!="")
            {

                try
                {

                    Service service = new Service();
                    service.ADI = txtPolAdi.Text;
                    service.ADRES = txtPolAdres.Text;
                    if (sbl.Add(service))
                    {
                        MessageBox.Show("Poliklinik başarıyla eklendi");
                        prepareData();
                    }

                }
                catch (Exception exception)
                {
                }
            }
        }

        private void prepareData()
        {


            try
            {
                cmbPol.DataSource = sbl.List();
                cmbPol.DisplayMember = "ADI";
                cmbPol.ValueMember = "ID";


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }





        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDocAdi.Text!="" && txtDocSoyad.Text!="" && cmbPol.SelectedItem.ToString()!="")
                {
                    Doctor doc = new Doctor();
                    doc.Name = txtDocAdi.Text;
                    doc.Surname = txtDocSoyad.Text;
                    doc.PolId = (int)cmbPol.SelectedValue;
                    if (dbl.Add(doc))
                    {
                        MessageBox.Show("Doktor Başarıyla eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Doktor ekleme sırasında hata.");
                    }
                }



            }
            catch (Exception exception)
            {
                

            }
        }
    }
}
