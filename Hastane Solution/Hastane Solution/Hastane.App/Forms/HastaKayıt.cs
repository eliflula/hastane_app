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
using Data;
using MODEL;

namespace Hastane.App.Forms
{
    public partial class HastaKayıt : Form
    {
        private List<Service> servisces;
        private List<PatientInfo> patientList = new List<PatientInfo>();
        private PatientInfo patient;
        ServiceBL sbl = new ServiceBL();
        DoctorBL dbl = new DoctorBL();
        PatientBL pbl = new PatientBL();
        private string delete_ID;
        private AnaMenu menux;

        public HastaKayıt( AnaMenu menu)
        {
            InitializeComponent();
            refreshGridData();
            menux = menu;
        }


        private void refreshGridData()
        {
            try
            {

                dataGridView1.DataSource = pbl.getAllPatient();
                dataGridView1.Columns[0].Visible = false;
                lblHastaSayi.Text = dataGridView1.Rows.Count.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }




        }


        #region Event methods

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtSurname.Text != "" && txtAge.Text != "" && cmbDoctor.SelectedItem.ToString() != "" && cmbService.SelectedItem.ToString() != "" && cmbDurum.SelectedItem.ToString()!="")
            {

                try
                {
                    patient = new PatientInfo();
                    patient.DoktorID = (int)cmbDoctor.SelectedValue;
                    patient.PolID = (int)cmbService.SelectedValue;
                    patient.Name = txtName.Text;
                    patient.LastName = txtSurname.Text;
                    patient.TC = txtID.Text;
                    patient.Age = txtAge.Text;
                    patient.KayitTarihi = DateTime.Now;
                    patient.Gender = cmbCinsiyet.SelectedItem.ToString();
                    patient.Durum = cmbDurum.SelectedItem.ToString();
                    if (pbl.Add(patient))
                    {
                        MessageBox.Show("Hasta Kayıdı Yapıldı.", "Bilgi Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshGridData();
                    }





                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }

            }

            else
            {
                MessageBox.Show("Lütfen Boşlukları Doldurunuz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtID.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtName.Text = String.Empty;
            txtSurname.Text = String.Empty;
            cmbService.SelectedIndex = -1;
            cmbDoctor.SelectedIndex = -1;
            cmbCinsiyet.SelectedIndex = -1;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }



        private void btnSil_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("SİLMEK İSTEDİĞİNİZE EMİN MİSİNİZ?", "TEYİT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                if (pbl.Delete(new PatientInfo(){TC = this.delete_ID.ToString()}))
                {
                    MessageBox.Show("Hasta Kaydı Silindi");
                    refreshGridData();
                }
                else MessageBox.Show("Hasta Kaydı Silinirken Hata.");

                
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi");
               
            }

        }

        private void btnKayitSorgu_Click_1(object sender, EventArgs e)
        {
            if (txtKayitAraTC.Text != null)
            {
                try
                {

                    dataGridView1.Columns[0].Visible = false;
                    if (pbl.getPatientInfo(txtKayitAraTC.Text) != null)
                    {

                        dataGridView1.DataSource = pbl.getPatientInfo(txtKayitAraTC.Text);
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz TC'ye bağlı hasta bulunamadı");
                    }


                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }



            }
        }

        private void txtKayitAraTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void txtAge_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void txtID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataTable dt;
            try
            {
                dt = sbl.List();

                cmbService.DisplayMember = "ADI";
                cmbService.ValueMember = "ID";
                cmbService.DataSource = dt;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbService.SelectedIndex >= 0)
            {
                int value = (int)cmbService.SelectedValue;
                cmbDoctor.DataSource = dbl.getList(value);
                cmbDoctor.ValueMember = "ID";
                cmbDoctor.DisplayMember = "ADI";

            }
        }

        #endregion

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            delete_ID = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void HastaIslem_FormClosing(object sender, FormClosingEventArgs e)
        {
           Hide();
            menux.Show();
        }

        private void btnGridRefresh_Click(object sender, EventArgs e)
        {
            refreshGridData();

        }
    }
}
