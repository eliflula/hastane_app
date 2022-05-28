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

namespace Hastane.App.Forms
{
    public partial class HastaServisi : Form
    {
        PatientBL pbl = new PatientBL();
        IlacBL ibl = new IlacBL();
        private AnaMenu menux;

        private int hastaId = -1;
        private int ilacId = -1;


        public HastaServisi(AnaMenu menu)
        {
            InitializeComponent();
            menux = menu;
            prepareData();
        }

        private void HastaServisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            menux.Show();
            this.Hide();
        }

        private void prepareData()
        {
            try
            {
                dataHasta.DataSource = pbl.getAllPatient();
                dataHasta.Columns[0].Visible = false;


                dataIlac.DataSource = ibl.getIlacs();
                dataIlac.Columns[0].Visible = false;





            }
            catch
            {
            }
        }

        private void dataIlac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ilacId = (int)dataIlac.SelectedRows[0].Cells[0].Value;
            txtIlacAdi.Text = dataIlac.SelectedRows[0].Cells[1].Value.ToString();
            txtStok.Text = dataIlac.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void dataHasta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataHasta.SelectedRows[0].Cells[1].Value.ToString() + " " +
                         dataHasta.SelectedRows[0].Cells[2].Value.ToString();

            txtDoktor.Text = dataHasta.SelectedRows[0].Cells[6].Value.ToString();
            txtPoli.Text = dataHasta.SelectedRows[0].Cells[7].Value.ToString();
            txtDurum.Text = dataHasta.SelectedRows[0].Cells[8].Value.ToString();

            hastaId = (int)dataHasta.SelectedRows[0].Cells[0].Value;

            try
            {
                dataHastaIlac.DataSource = ibl.getIlacsByHasta((int)dataHasta.SelectedRows[0].Cells[0].Value);
                

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAd.Text != "" && txtIlacAdi.Text!=null)
                {
                    int stok = int.Parse(txtStok.Text);

                    if (stok >= 0 && (int)numericUpDown1.Value<stok)
                    {
                        if (pbl.HastaIlacEkle(hastaId, ilacId, (int)numericUpDown1.Value))
                        {
                            MessageBox.Show("Hastaya ilaç kaydı yapıldı.");
                            prepareData();
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("İLACIN STOĞU KALMADIĞI İÇİN VEYA STOK SINIRININ ÜSTÜNDE BİR DEĞER GİRDİĞİNİZ İÇİN İLAÇ KAYDI YAPILAMIYOR");
                    }

                }
                else
                {

                    MessageBox.Show("LÜTFEN TABLODAN HASTAYI VE İLACINI SEÇİNİZ.");
                }


            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
